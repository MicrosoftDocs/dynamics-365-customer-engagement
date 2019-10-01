' <snippetmarketingautomation>


Imports Microsoft.VisualBasic
Imports System
Imports System.ServiceModel
Imports System.Linq
' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages
' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples

    ''' <summary>
    ''' Demonstrate how to create a dynamic list and distribute campaign activities to 
    ''' the members on the list.
    ''' </summary>
    ''' <remarks>
    ''' At run-time, you will be given the option to delete all the
    ''' database records created by this program.</remarks>
    Public Class MarketingAutomation

#Region "Class Level Members"

        Private _salesManagerId As Guid
        Private _accountId As Guid
        Private _campaignId As Guid
        Private _campaignActivityId As Guid
        Private _dynamicListId As Guid
        Private _staticListId As Guid
        Private _serviceProxy As OrganizationServiceProxy

#End Region ' Class Level Members

#Region "How To Sample Code"
        ''' <summary>
        ''' This method first connects to the Organization service. Afterwards a dynamic
        ''' list is created and associated to the campaign and the campaign's activity.
        ''' Then the dynamic list is copied to a static list and associated with the same
        ''' campaign and campaign activity. Finally the sample distributes the campaign
        ''' to both the dynamic and static lists.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)

            Try

                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy

                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()

                    '                    #Region "Create Dynamic List"

                    ' Create FetchXml for marketing list's query which locates accounts
                    ' in Seattle.
                    Dim fetchXml As String = _
                        "<fetch version='1.0' output-format='xml-platform' " _
                        &amp; "     mapping='logical' distinct='false'>" _
                        &amp; " <entity name='account'>" _
                        &amp; "     <attribute name='name' />" _
                        &amp; "     <attribute name='address1_city' />" _
                        &amp; "     <attribute name='primarycontactid' />" _
                        &amp; "     <attribute name='telephone1' />" _
                        &amp; "     <attribute name='accountid' />" _
                        &amp; "     <order attribute='name' descending='false' />" _
                        &amp; "     <filter type='and'>" _
                        &amp; "         <condition attribute='address1_city' " _
                        &amp; "                     operator='eq' value='seattle' />" _
                        &amp; "     </filter>" _
                        &amp; " </entity>" _
                        &amp; "</fetch>"

                    ' Create dynamic list. Set the type to true to declare a dynamic
                    ' list. Set CreatedFromCode to 1 for account member type.
                    Dim dynamicList As New List() With
                        {
                            .Type = True,
                            .ListName = "Dynamic List",
                            .CreatedFromCode = New OptionSetValue(CInt(ListCreatedFromCode.Account)),
                            .Query = fetchXml
                        }
                    _dynamicListId = _serviceProxy.Create(dynamicList)
                    dynamicList.Id = _dynamicListId

                    Console.WriteLine("Created dynamic list.")

                    '                    #End Region

                    '                    #Region "Associate dynamic list to campaign"
                    ' Create a campaign.
                    Dim campaign As New Campaign() With {.Name = "Sample Campaign"}
                    _campaignId = _serviceProxy.Create(campaign)
                    campaign.Id = _campaignId

                    ' Add the dynamic list to the campaign.
                    Dim addListToCampaignRequest As New AddItemCampaignRequest() With
                        {
                            .CampaignId = _campaignId,
                            .EntityId = _dynamicListId,
                            .EntityName = List.EntityLogicalName
                        }
                    _serviceProxy.Execute(addListToCampaignRequest)

                    Console.WriteLine("Added dynamic list to the campaign.")

                    ' Create a campaign activity to distribute fax to the list members.
                    Dim campaignActivity As New CampaignActivity() With
                        {.Subject = "Sample Campaign Activity",
                         .ChannelTypeCode = New OptionSetValue(CInt(CampaignActivityChannelTypeCode.Fax)),
                         .RegardingObjectId = campaign.ToEntityReference()}
                    _campaignActivityId = _serviceProxy.Create(campaignActivity)

                    ' Add dynamic list to campaign activity.
                    Dim addListToCampaignActivityRequest As _
                        New AddItemCampaignActivityRequest() With
                        {
                            .CampaignActivityId = _campaignActivityId,
                            .ItemId = _dynamicListId,
                            .EntityName = List.EntityLogicalName
                        }
                    _serviceProxy.Execute(addListToCampaignActivityRequest)

                    Console.WriteLine("Added dynamic list to the campaign activity.")

                    '                    #End Region

                    '                    #Region "Associate static list to campaign"

                    ' Copy the dynamic list to a static list.
                    Dim copyRequest As New CopyDynamicListToStaticRequest() With
                        {
                            .ListId = _dynamicListId
                        }
                    Dim copyResponse As CopyDynamicListToStaticResponse =
                        CType(_serviceProxy.Execute(copyRequest), 
                            CopyDynamicListToStaticResponse)
                    _staticListId = copyResponse.StaticListId

                    Console.WriteLine("Copied dynamic list to a static list.")

                    ' Add the static list to the campaign.
                    Dim addStaticListToCampaignRequest As _
                        New AddItemCampaignRequest() With
                        {
                            .CampaignId = _campaignId,
                            .EntityId = _staticListId,
                            .EntityName = List.EntityLogicalName
                        }
                    _serviceProxy.Execute(addStaticListToCampaignRequest)

                    Console.WriteLine("Added static list to the campaign.")

                    ' Add the static list to the campaign activity.
                    Dim addStaticListToCampaignActivityRequest As _
                        New AddItemCampaignActivityRequest() With
                        {
                            .CampaignActivityId = _campaignActivityId,
                            .ItemId = _staticListId,
                            .EntityName = List.EntityLogicalName
                        }
                    _serviceProxy.Execute(addStaticListToCampaignActivityRequest)

                    Console.WriteLine("Added static list to the campaign's activity.")

                    '                    #End Region

'		#Region "Create fax for campaign's activity"
                    ' Create a fax.
                    Dim fax As New Fax() With {.Subject = "Example Fax"}

                    Console.WriteLine("Created fax for campaign's activity.")
'		#End Region ' Create fax for campaign's activity

'					#Region "Distribute fax to the marketing list"
                    ' Distribute the campaign activity to the marketing lists.
                    Dim distributeRequest As New DistributeCampaignActivityRequest() With
                        {
                            .CampaignActivityId = _campaignActivityId,
                            .Activity = fax,
                            .Owner = New EntityReference("systemuser", _salesManagerId),
                            .Propagate = True,
                            .SendEmail = False,
                            .PostWorkflowEvent = True
                        }
                    _serviceProxy.Execute(distributeRequest)

                    Console.WriteLine("Distributed fax to the marketing lists.")
                    '					#End Region ' Distribute fax to the marketing list

'					#Region "Retrieve collection of entities from marketing list"
					' Retrieve a collection of entities that correspond 
					' to all of the members in a marketing list
					' This approach of retrieving list members allows you to dynamically
					' retrieve the members of a list programmatically without requiring 
					' knowledge of the member entity type.
					Dim orgContext As New OrganizationServiceContext(_serviceProxy)

					Dim member = ( _
					    From mb In orgContext.CreateQuery(Of List)() _
					    Where mb.Id = _dynamicListId _
					    Select mb).FirstOrDefault()

					Dim fetchQuery As String = member.Query

					Dim memberRequest As New RetrieveMultipleRequest()
					Dim fetch As New FetchExpression(fetchQuery)
					memberRequest.Query = fetch
					Dim memberResponse As RetrieveMultipleResponse = CType(_serviceProxy.Execute(memberRequest), RetrieveMultipleResponse)

					Console.WriteLine("Retrieved collection of entities from a marketing list.")
'					#End Region ' Retrieve collection of entities from marketing list
                    DeleteRequiredRecords(promptforDelete)

                End Using


                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)

                ' You can handle an exception here or pass it back to the calling method.
                Throw

            End Try

        End Sub

        ''' <summary>
        ''' Creates any entity records that this sample requires.
        ''' </summary>
        Public Sub CreateRequiredRecords()

            ' Retrieve a sales manager.
            _salesManagerId = SystemUserProvider.RetrieveMarketingManager(_serviceProxy)

            ' Create an account.
            Dim account As New Account() With
                {
                    .Name = "Fourth Coffee",
                    .Address1_City = "Seattle"
                }
            _accountId = _serviceProxy.Create(account)

        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)

            Dim toBeDeleted As Boolean = True

            If prompt Then

                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") _
                    OrElse answer = String.Empty Then

                    toBeDeleted = True

                Else

                    toBeDeleted = False

                End If

            End If

            If toBeDeleted Then

                ' Delete all records created in this sample.
                _serviceProxy.Delete(List.EntityLogicalName, _staticListId)
                _serviceProxy.Delete(List.EntityLogicalName, _dynamicListId)
                _serviceProxy.Delete("campaignactivity", _campaignActivityId)
                _serviceProxy.Delete("campaign", _campaignId)
                _serviceProxy.Delete("account", _accountId)

                Console.WriteLine("Entity record(s) have been deleted.")

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

                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

                Dim app As New MarketingAutomation()
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
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))

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
                        Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))

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

' </snippetmarketingautomation>