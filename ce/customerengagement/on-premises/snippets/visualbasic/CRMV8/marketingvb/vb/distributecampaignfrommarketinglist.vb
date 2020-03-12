' <snippetdistributecampaignfrommarketinglist>


Imports System
Imports System.Collections.Generic
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	Public Class DistributeCampaignFromMarketingList
		#Region "Class Level Members"

		Private _accountId As Guid
		Private _serviceProxy As OrganizationServiceProxy
		Private ReadOnly _contactIdList As New List(Of Guid)()
		Private _marketingListId As Guid
		Private _copiedMarketingListId As Guid
		Private _campaignId As Guid
		Private _campaignActivityId As Guid
		Private _originalCampaignId As Guid

		#End Region ' Class Level Members

		#Region "Nested Classes"

		' This static class contains the possible values for marketing list types.
		Private NotInheritable Class MarketingListType
			Friend Shared [Static] As Boolean = False
			Friend Shared Dynamic As Boolean = True
		End Class

        ' This static class contains values for overriding or removing when making a qualify
		' member list request.  (Overriding means replacing all members of the list with
		' the specified members in the request.)
		Private NotInheritable Class OverrideOrRemove
			Friend Shared Override As Boolean = True
			Friend Shared Remove As Boolean = False
		End Class

		#End Region ' Nested Classes

		#Region "How To Sample Code"

        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early bound type support.
                _serviceProxy.EnableProxyTypes()
                CreateRequiredRecords()
                CreateMarketingList()
                DistributeCampaign()
                DeleteRecords(promptforDelete)
            End Using
        End Sub

		Private Sub DistributeCampaign()
			Console.WriteLine("=== Creating and Distributing the Campaign ===")
			' Create the campaign.
			Dim campaign = New Campaign With {.Name = "Sample Campaign"}

			_originalCampaignId = _serviceProxy.Create(campaign)

			NotifyEntityCreated(Campaign.EntityLogicalName, _originalCampaignId)

			' Copy the campaign.
            Dim campaignCopyRequest = New CopyCampaignRequest With
                                      {
                                          .BaseCampaign = _originalCampaignId
                                      }

            Dim copyCampaignResponse =
                CType(_serviceProxy.Execute(campaignCopyRequest), 
                    CopyCampaignResponse)
			_campaignId = copyCampaignResponse.CampaignCopyId

            Console.WriteLine("  Copied the campaign to new campaign with GUID " _
                              &amp; vbCrLf &amp; vbTab &amp; "{{{0}}}", _campaignId)

            Dim activity = New CampaignActivity With
                           {
                               .Subject = "Sample phone call",
                               .ChannelTypeCode =
                               New OptionSetValue(
                                   CInt(Fix(CampaignActivityChannelTypeCode.Phone))),
                               .RegardingObjectId =
                               New EntityReference(campaign.EntityLogicalName,
                                                   _campaignId)
                           }

			_campaignActivityId = _serviceProxy.Create(activity)

			NotifyEntityCreated(CampaignActivity.EntityLogicalName, _campaignActivityId)

			' Find the current user to determine who the owner of the activity should be.
			Dim whoAmI = New WhoAmIRequest()
			Dim currentUser = CType(_serviceProxy.Execute(whoAmI), WhoAmIResponse)

			' Add the marketing list created earlier to the campaign.
            Dim addListToCampaignRequest =
                New AddItemCampaignRequest With
                {
                    .CampaignId = _campaignId,
                    .EntityId = _copiedMarketingListId,
                    .EntityName = List.EntityLogicalName
                }

			_serviceProxy.Execute(addListToCampaignRequest)

			Console.WriteLine("  Added the marketing list to the campaign.")

			' Add the marketing list created earlier to the campaign activity.
            Dim addListToActivityRequest =
                New AddItemCampaignActivityRequest With
                {
                    .CampaignActivityId = _campaignActivityId,
                    .ItemId = _copiedMarketingListId,
                    .EntityName = List.EntityLogicalName
                }

			_serviceProxy.Execute(addListToActivityRequest)

			Console.WriteLine("  Added the marketing list to the campaign activity.")

			' Create the phone call to use for distribution.
			Dim phonecall = New PhoneCall With {.Subject = "Sample Phone Call"}

			' Distribute and execute the campaign activity.
            ' PostWorkflowEvent signals Microsoft Dynamics CRM to actually create the phone call activities.
            ' Propagate also signals to Microsoft Dynamics CRM to create the phone call activities.
			' OwnershipOptions indicates whom the created activities should be assigned
			' to.
            Dim distributeRequest =
                New DistributeCampaignActivityRequest With
                {
                    .Activity = phonecall,
                    .CampaignActivityId = _campaignActivityId,
                    .Owner = New EntityReference(SystemUser.EntityLogicalName,
                                                 currentUser.UserId),
                    .OwnershipOptions = PropagationOwnershipOptions.Caller,
                    .PostWorkflowEvent = True,
                    .Propagate = True,
                    .SendEmail = False
                }

            Dim distributeResponse =
                CType(_serviceProxy.Execute(distributeRequest), 
                    DistributeCampaignActivityResponse)

            Console.WriteLine(
                "  Distributed and executed the campaign activity to the marketing list.")

			' Retrieve the members that were distributed to.
            Dim retrieveMembersRequest =
                New RetrieveMembersBulkOperationRequest With
                {
                    .BulkOperationId = distributeResponse.BulkOperationId,
                    .BulkOperationSource = CInt(Fix(BulkOperationSource.CampaignActivity)),
                    .EntitySource = CInt(Fix(EntitySource.Contact)),
                    .Query = New QueryExpression(Contact.EntityLogicalName)
                }

            Dim retrieveMembersResponse =
                CType(_serviceProxy.Execute(retrieveMembersRequest), 
                    RetrieveMembersBulkOperationResponse)

			Console.WriteLine("  Contacts with the following GUIDs were distributed to:")
			For Each member In retrieveMembersResponse.EntityCollection.Entities
				Console.WriteLine(vbTab &amp; "{{{0}}}", member.Id)
			Next member
		End Sub

		Private Sub CreateMarketingList()
			Console.WriteLine("=== Creating the Marketing List ===")
            ' Create the marketing list.  Make it static because members are going to be
            ' added to the list.
            Dim list = New List With
                       {
                           .CreatedFromCode =
                           New OptionSetValue(CInt(Fix(ListCreatedFromCode.Contact))),
                           .ListName = "Sample Contact Marketing List",
                           .Type = MarketingListType.Static
                       }

			_marketingListId = _serviceProxy.Create(list)

			NotifyEntityCreated(List.EntityLogicalName, _marketingListId)

			' Add a list of contacts to the marketing list.
            Dim addMemberListReq =
                New AddListMembersListRequest With
                {
                    .MemberIds = {_contactIdList(0), _contactIdList(2)},
                    .ListId = _marketingListId
                }

			_serviceProxy.Execute(addMemberListReq)

            Console.WriteLine("  Contacts with GUIDs " _
                              &amp; vbCrLf &amp; vbTab &amp; "{{{0}}}" _
                              &amp; vbCrLf &amp; vbTab &amp; "and {{{1}}}" _
                              &amp; vbCrLf &amp; "  were added to the list.",
                              _contactIdList(0),
                              _contactIdList(1))

            ' Copy the marketing list.  First create a new one, and then copy over the
			' members.
			list.ListName = list.ListName &amp; " Copy"
			_copiedMarketingListId = _serviceProxy.Create(list)
            Dim copyRequest = New CopyMembersListRequest With
                              {
                                  .SourceListId = _marketingListId,
                                  .TargetListId = _copiedMarketingListId
                              }

			_serviceProxy.Execute(copyRequest)

			' Add a single contact to the copied marketing list.
            Dim addMemberReq = New AddMemberListRequest With
                               {
                                   .EntityId = _contactIdList(1),
                                   .ListId = _copiedMarketingListId
                               }

			_serviceProxy.Execute(addMemberReq)

            Console.WriteLine("  Contact with GUID" &amp; vbCrLf &amp; vbTab &amp; "{{{0}}}" _
                              &amp; vbCrLf &amp; "  was added to the list.", _contactIdList(1))

			' Qualify the marketing list.
            Dim qualifyRequest =
                New QualifyMemberListRequest With
                {
                    .OverrideorRemove = OverrideOrRemove.Override,
                    .MembersId = {_contactIdList(0), _contactIdList(1)},
                    .ListId = _copiedMarketingListId
                }

			_serviceProxy.Execute(qualifyRequest)

            Console.WriteLine("  Qualified the copied marketing list so that it only" _
                              &amp; vbCrLf &amp; "    includes the first two members.")
		End Sub

		Private Sub NotifyEntityCreated(ByVal entityName As String, ByVal entityId As Guid)
			Console.WriteLine("  {0} created with GUID {{{1}}}", entityName, entityId)
		End Sub

		Private Sub CreateRequiredRecords()
			' Create an account.
            Dim account = New Account With
                          {
                              .Name = "Litware, Inc.",
                              .Address1_StateOrProvince = "Colorado"
                          }
			_accountId = _serviceProxy.Create(account)

			' Create the contacts.
            Dim contact = New Contact With
                          {
                              .FirstName = "Ben",
                              .LastName = "Andrews",
                              .EMailAddress1 = "sample@example.com",
                              .Address1_City = "Redmond",
                              .Address1_StateOrProvince = "WA",
                              .Address1_Telephone1 = "(206)555-5555",
                              .ParentCustomerId = New EntityReference With
                                                  {
                                                      .Id = _accountId,
                                                      .LogicalName = account.LogicalName
                                                  }
                          }
			_contactIdList.Add(_serviceProxy.Create(contact))

            contact = New Contact With
                      {
                          .FirstName = "Colin",
                          .LastName = "Wilcox",
                          .EMailAddress1 = "sample@example.com",
                          .Address1_City = "Bellevue",
                          .Address1_StateOrProvince = "WA",
                          .Address1_Telephone1 = "(425)555-5555",
                          .ParentCustomerId = New EntityReference With
                                              {
                                                  .Id = _accountId,
                                                  .LogicalName = account.LogicalName
                                              }
                      }
			_contactIdList.Add(_serviceProxy.Create(contact))

            contact = New Contact With
                      {
                          .FirstName = "Lisa",
                          .LastName = "Andrews",
                          .EMailAddress1 = "sample@example.com",
                          .Address1_City = "Redmond",
                          .Address1_StateOrProvince = "WA",
                          .Address1_Telephone1 = "(206)555-5556",
                          .ParentCustomerId = New EntityReference With
                                              {
                                                  .Id = _accountId,
                                                  .LogicalName = account.LogicalName
                                              }
                      }
			_contactIdList.Add(_serviceProxy.Create(contact))

		End Sub

		Private Sub RemoveRelationships()
			' Remove the marketing list from the campaign activity.
            Dim removeFromCampaignActivity =
                New RemoveItemCampaignActivityRequest With
                {
                    .CampaignActivityId = _campaignActivityId,
                    .ItemId = _copiedMarketingListId
                }

			_serviceProxy.Execute(removeFromCampaignActivity)
			Console.WriteLine("  Removed the marketing list from the campaign activity.")

			' Remove the marketing list from the campaign.
            Dim removeFromCampaign =
                New RemoveItemCampaignRequest With
                {
                    .CampaignId = _campaignId,
                    .EntityId = _copiedMarketingListId
                }

			_serviceProxy.Execute(removeFromCampaign)
			Console.WriteLine("  Removed the marketing list from the campaign.")
		End Sub

		Private Sub DeleteRecords(ByVal prompt As Boolean)
			Dim toBeDeleted = True
			If prompt Then
				' Ask the user if the created entities should be deleted.
				Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer =
                    String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				RemoveRelationships()

				' Delete the marketing lists.
				_serviceProxy.Delete(List.EntityLogicalName, _marketingListId)
				_serviceProxy.Delete(List.EntityLogicalName, _copiedMarketingListId)

				' Delete the contacts.
				For Each contactId In _contactIdList
					_serviceProxy.Delete(Contact.EntityLogicalName, contactId)
				Next contactId

				' Delete the account.
				_serviceProxy.Delete(Account.EntityLogicalName, _accountId)

				' Just delete the campaign, no need to delete the campaign activity.
				_serviceProxy.Delete(Campaign.EntityLogicalName, _campaignId)
				_serviceProxy.Delete(Campaign.EntityLogicalName, _originalCampaignId)
			End If
		End Sub

		#End Region ' How To Sample Code

		#Region "Main method"

		''' <summary>
		''' Standard Main() method used by most SDK samples.
		''' </summary>
		''' <param name="args"></param>
		Public Shared Sub Main(ByVal args() As String)
			Try
                ' Obtain the target organization's web address and client logon 
				' credentials from the user.
				Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

				Dim app = New DistributeCampaignFromMarketingList()
				app.Run(config, True)
			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
			Catch ex As System.TimeoutException
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Message: {0}", ex.Message)
				Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
			Catch ex As System.Exception
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine(ex.Message)

				' Display the details of the inner exception.
				If ex.InnerException IsNot Nothing Then
					Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
                        TryCast(ex.InnerException, 
                            FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
					If fe IsNot Nothing Then
						Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
						Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
						Console.WriteLine("Message: {0}", fe.Detail.Message)
						Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
					End If
				End If
			' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
			' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

			Finally
				Console.WriteLine("Press <Enter> to exit.")
				Console.ReadLine()
			End Try
		End Sub
		#End Region ' Main method
	End Class
End Namespace

' </snippetdistributecampaignfrommarketinglist>