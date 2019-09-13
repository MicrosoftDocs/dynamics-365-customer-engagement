' <snippetworkingwithleads>


Imports System
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	Public Class WorkingWithLeads
		#Region "Class Level Members"
		Private _serviceProxy As OrganizationServiceProxy
		Private _lead1Id As Guid
		Private _lead2Id As Guid
		Private _accountId As Guid
		Private _leadAccountId As Guid
		Private _contactId As Guid
		Private _opportunityId As Guid
		#End Region

		#Region "How To Sample Code"

        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early bound type support.
                _serviceProxy.EnableProxyTypes()
                CreateRequiredRecords()

                Console.WriteLine("=== Creating and Qualifying Leads ===")

                ' Create two leads.
                Dim lead1 = New Lead With
                            {
                                .CompanyName = "A. Datum Corporation",
                                .FirstName = "Henriette",
                                .LastName = "Andersen",
                                .Subject = "Sample Lead 1"
                            }

                _lead1Id = _serviceProxy.Create(lead1)
                NotifyEntityCreated(Lead.EntityLogicalName, _lead1Id)

                Dim lead2 = New Lead With
                            {
                                .CompanyName = "Adventure Works",
                                .FirstName = "Michael",
                                .LastName = "Sullivan",
                                .Subject = "Sample Lead 2"
                            }

                _lead2Id = _serviceProxy.Create(lead2)
                NotifyEntityCreated(Lead.EntityLogicalName, _lead2Id)

                ' Qualify the first lead, creating an account and a contact from it, but
                ' not creating an opportunity.
                Dim qualifyIntoAccountContactReq =
                    New QualifyLeadRequest With
                    {
                        .CreateAccount = True,
                        .CreateContact = True,
                        .LeadId = New EntityReference(Lead.EntityLogicalName, _lead1Id),
                        .Status = New OptionSetValue(CInt(Fix(lead_statuscode.Qualified)))
                    }

                Dim qualifyIntoAccountContactRes =
                    CType(_serviceProxy.Execute(qualifyIntoAccountContactReq), 
                        QualifyLeadResponse)
                Console.WriteLine("  The first lead was qualified.")
                For Each entity In qualifyIntoAccountContactRes.CreatedEntities
                    NotifyEntityCreated(entity.LogicalName, entity.Id)
                    If entity.LogicalName = Account.EntityLogicalName Then
                        _leadAccountId = entity.Id
                    ElseIf entity.LogicalName = Contact.EntityLogicalName Then
                        _contactId = entity.Id
                    End If
                Next entity

                ' Retrieve the organization's base currency ID for setting the
                ' transaction currency of the opportunity.
                Dim query = New QueryExpression("organization")
                query.ColumnSet = New ColumnSet("basecurrencyid")
                Dim result = _serviceProxy.RetrieveMultiple(query)
                Dim currencyId = CType(result.Entities(0)("basecurrencyid"), 
                    EntityReference)

                ' Qualify the second lead, creating an opportunity from it, and not
                ' creating an account or a contact.  We use an existing account for the
                ' opportunity customer instead.
                Dim qualifyIntoOpportunityReq =
                    New QualifyLeadRequest With
                    {
                        .CreateOpportunity = True,
                        .OpportunityCurrencyId = currencyId,
                        .OpportunityCustomerId =
                        New EntityReference(Account.EntityLogicalName,
                                            _accountId),
                        .Status =
                        New OptionSetValue(CInt(Fix(lead_statuscode.Qualified))),
                        .LeadId = New EntityReference(Lead.EntityLogicalName, _lead2Id)
                    }

                Dim qualifyIntoOpportunityRes =
                    CType(_serviceProxy.Execute(qualifyIntoOpportunityReq), 
                        QualifyLeadResponse)
                Console.WriteLine("  The second lead was qualified.")

                For Each entity In qualifyIntoOpportunityRes.CreatedEntities
                    NotifyEntityCreated(entity.LogicalName, entity.Id)
                    If entity.LogicalName = Opportunity.EntityLogicalName Then
                        _opportunityId = entity.Id
                    End If
                Next entity

                DeleteRecords(promptforDelete)
            End Using
        End Sub

        Private Sub NotifyEntityCreated(ByVal entityName As String,
                                        ByVal entityId As Guid)
            Console.WriteLine("  {0} created with GUID {{{1}}}", entityName, entityId)
        End Sub

		Private Sub CreateRequiredRecords()
			' Create an account to relate the opportunity to.
            Dim account = New Account With
                          {
                              .Name = "Litware, Inc.",
                              .Address1_StateOrProvince = "Colorado"
                          }
			_accountId = (_serviceProxy.Create(account))
		End Sub

		Private Sub DeleteRecords(ByVal prompt As Boolean)
			Dim toBeDeleted As Boolean = True

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
                ' Deleting the accounts will delete all of their related records, and then
				' only the leads will be left.
				_serviceProxy.Delete(Account.EntityLogicalName, _accountId)
				_serviceProxy.Delete(Account.EntityLogicalName, _leadAccountId)

				_serviceProxy.Delete(Lead.EntityLogicalName, _lead1Id)
				_serviceProxy.Delete(Lead.EntityLogicalName, _lead2Id)
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

				Dim app = New WorkingWithLeads()
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

' </snippetworkingwithleads>