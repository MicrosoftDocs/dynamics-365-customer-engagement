' <snippetfetchxmlandqueryexpressionqueryconversion>


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
	Public Class FetchXmlAndQueryExpressionQueryConversion

		#Region "Class Level Members"
		Private _serviceProxy As OrganizationServiceProxy
		Private _accountId As Guid
		Private ReadOnly _contactIdList As New List(Of Guid)()
		Private ReadOnly _opportunityIdList As New List(Of Guid)()
		#End Region

		#Region "How To Sample Code"
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes()
                CreateRequiredRecords()
                DoQueryExpressionToFetchXmlConversion()
                DoFetchXmlToQueryExpressionConversion()
                DeleteRequiredRecords(promptforDelete)
            End Using
        End Sub

		Private Sub DoQueryExpressionToFetchXmlConversion()
            ' Build a query expression that we will turn into FetchXML.
            Dim queryExpressionObj As QueryExpression =
                New QueryExpression() With
                {
                    .Distinct = False,
                    .EntityName = Contact.EntityLogicalName,
                    .ColumnSet = New ColumnSet("fullname", "address1_telephone1")
                }
            Dim queryLink As New LinkEntity() With
                {
                    .JoinOperator = JoinOperator.LeftOuter,
                    .LinkFromAttributeName = "parentcustomerid",
                    .LinkFromEntityName = Contact.EntityLogicalName,
                    .LinkToAttributeName = "accountid",
                    .LinkToEntityName = Account.EntityLogicalName
                }
            queryLink.LinkCriteria().AddCondition("name",
                                                  ConditionOperator.Equal,
                                                  "Litware, Inc.")
            queryExpressionObj.LinkEntities().Add(queryLink)

            Dim queryCriteriaFilter1 As New FilterExpression() With
                {
                    .FilterOperator = LogicalOperator.And
                }
            queryCriteriaFilter1.AddCondition(
                New ConditionExpression("address1_stateorprovince",
                                        ConditionOperator.Equal,
                                        "WA"))
            queryCriteriaFilter1.AddCondition(
                New ConditionExpression("address1_city",
                                        ConditionOperator.In,
                                        New String() {"Redmond",
                                                      "Bellevue",
                                                      "Kirkland",
                                                      "Seattle"}))
            queryCriteriaFilter1.AddCondition(
                New ConditionExpression("createdon",
                                        ConditionOperator.LastXDays,
                                        30))
            queryCriteriaFilter1.AddCondition(
                New ConditionExpression("emailaddress1",
                                        ConditionOperator.NotNull))
            Dim queryCriteriaFilter2 As New FilterExpression() With
                {
                    .FilterOperator = LogicalOperator.Or
                }
            queryCriteriaFilter2.AddCondition(
                New ConditionExpression("address1_telephone1",
                                        ConditionOperator.Like,
                                        "(206)%"))
            queryCriteriaFilter2.AddCondition(
                New ConditionExpression("address1_telephone1",
                                        ConditionOperator.Like,
                                        "(425)%"))
            queryExpressionObj.Criteria.Filters.AddRange(queryCriteriaFilter1,
                                                      queryCriteriaFilter2)

            ' Run the query as a query expression.
            Dim queryExpressionResult As EntityCollection =
                _serviceProxy.RetrieveMultiple(queryExpressionObj)
            Console.WriteLine("Output for query as QueryExpression:")
            DisplayContactQueryResults(queryExpressionResult)

            ' Convert the query expression to FetchXML.
            Dim conversionRequest As QueryExpressionToFetchXmlRequest =
                New QueryExpressionToFetchXmlRequest With {.Query = queryExpressionObj}
            Dim conversionResponse = CType(_serviceProxy.Execute(conversionRequest), 
                QueryExpressionToFetchXmlResponse)

            ' Use the converted query to make a retrieve multiple request to Microsoft Dynamics CRM.
			Dim fetchXml As String = conversionResponse.FetchXml
			Dim fetchQuery = New FetchExpression(fetchXml)
			Dim result As EntityCollection = _serviceProxy.RetrieveMultiple(fetchQuery)

			' Display the results.
			Console.WriteLine(vbLf &amp; "Output for query after conversion to FetchXML:")
			DisplayContactQueryResults(result)
		End Sub

		Private Shared Sub DisplayContactQueryResults(ByVal result As EntityCollection)
			Console.WriteLine("List all contacts matching specified parameters")
			Console.WriteLine("===============================================")
			For Each entity As Entity In result.Entities
				Dim contact = entity.ToEntity(Of Contact)()
				Console.WriteLine("Contact ID: {0}", contact.Id)
				Console.WriteLine("Contact Name: {0}", contact.FullName)
				Console.WriteLine("Contact Phone: {0}", contact.Address1_Telephone1)
			Next entity
			Console.WriteLine("<End of Listing>")
			Console.WriteLine()
		End Sub

		Private Sub DoFetchXmlToQueryExpressionConversion()
            ' Create a Fetch query that we will convert into a query expression.
            Dim fetchXml = "<fetch mapping='logical' version='1.0'>" _
                           &amp; "  <entity name='opportunity'>" _
                           &amp; "      <attribute name='name' />" _
                           &amp; "      <filter>" _
                           &amp; "          <condition attribute='estimatedclosedate' operator='next-x-fiscal-years' value='3' />" _
                           &amp; "      </filter>" _
                           &amp; "      <link-entity name='account' from='accountid' to='customerid'>" _
                           &amp; "          <link-entity name='contact' from='parentcustomerid' to='accountid'>" _
                           &amp; "              <attribute name='fullname' />" _
                           &amp; "              <filter>" _
                           &amp; "                <condition attribute='address1_city' operator='eq' value='Bellevue' />" _
                           &amp; "                <condition attribute='address1_stateorprovince' operator='eq' value='WA' />" _
                           &amp; "              </filter>" _
                           &amp; "          </link-entity>" _
                           &amp; "      </link-entity>" _
                           &amp; "  </entity>" _
                           &amp; "</fetch>"

            ' Run the query with the FetchXML.
			Dim fetchExpression = New FetchExpression(fetchXml)
			Dim fetchResult As EntityCollection = _serviceProxy.RetrieveMultiple(fetchExpression)
			Console.WriteLine(vbLf &amp; "Output for query as FetchXML:")
			DisplayOpportunityQueryResults(fetchResult)

            ' Convert the FetchXML into a query expression.
            Dim conversionRequest = New FetchXmlToQueryExpressionRequest With
                                    {
                                        .FetchXml = fetchXml
                                    }

            Dim conversionResponse = CType(_serviceProxy.Execute(conversionRequest), 
                FetchXmlToQueryExpressionResponse)

			' Use the newly converted query expression to make a retrieve multiple
            ' request to Microsoft Dynamics CRM.
			Dim queryExpression As QueryExpression = conversionResponse.Query

			Dim result As EntityCollection = _serviceProxy.RetrieveMultiple(queryExpression)

			' Display the results.
			Console.WriteLine(vbLf &amp; "Output for query after conversion to QueryExpression:")
			DisplayOpportunityQueryResults(result)
		End Sub

		Private Shared Sub DisplayOpportunityQueryResults(ByVal result As EntityCollection)
			Console.WriteLine("List all opportunities matching specified parameters.")
			Console.WriteLine("===========================================================================")
			For Each entity As Entity In result.Entities
				Dim opportunity = entity.ToEntity(Of Opportunity)()
				Console.WriteLine("Opportunity ID: {0}", opportunity.Id)
				Console.WriteLine("Opportunity: {0}", opportunity.Name)
				Dim aliased = CType(opportunity("contact2.fullname"), AliasedValue)
				Dim contactName = CType(aliased.Value, String)
				Console.WriteLine("Associated contact: {0}", contactName)
			Next entity
			Console.WriteLine("<End of Listing>")
			Console.WriteLine()
		End Sub

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()

			' Create an account.
            Dim account = New Account With
                          {
                              .Name = "Litware, Inc.",
                              .Address1_StateOrProvince = "Colorado"
                          }
			_accountId = (_serviceProxy.Create(account))

            ' Create the two contacts.
            Dim contact = New Contact() With
                          {
                              .FirstName = "Ben",
                              .LastName = "Andrews",
                              .EMailAddress1 = "sample@example.com",
                              .Address1_City = "Redmond",
                              .Address1_StateOrProvince = "WA",
                              .Address1_Telephone1 = "(206)555-5555",
                              .ParentCustomerId =
                              New EntityReference With
                              {
                                  .Id = _accountId,
                                  .LogicalName = account.LogicalName
                              }
                          }
			_contactIdList.Add(_serviceProxy.Create(contact))

            contact = New Contact() With
                      {
                          .FirstName = "Colin",
                          .LastName = "Wilcox",
                          .EMailAddress1 = "sample@example.com",
                          .Address1_City = "Bellevue",
                          .Address1_StateOrProvince = "WA",
                          .Address1_Telephone1 = "(425)555-5555",
                          .ParentCustomerId =
                          New EntityReference With
                          {
                              .Id = _accountId,
                              .LogicalName = account.LogicalName
                          }
                      }
			_contactIdList.Add(_serviceProxy.Create(contact))

            ' Create two opportunities.
            Dim opportunity As New Opportunity() With
                {
                    .Name = "Litware, Inc. Opportunity 1",
                    .EstimatedCloseDate = Date.Now.AddMonths(6),
                    .CustomerId =
                    New EntityReference With
                    {
                        .Id = _accountId,
                        .LogicalName = account.LogicalName
                    }
                }
			_opportunityIdList.Add(_serviceProxy.Create(opportunity))

            opportunity = New Opportunity() With
                          {
                              .Name = "Litware, Inc. Opportunity 2",
                              .EstimatedCloseDate = Date.Now.AddYears(4),
                              .CustomerId =
                              New EntityReference With
                              {
                                  .Id = _accountId,
                                  .LogicalName = account.LogicalName
                              }
                          }
			_opportunityIdList.Add(_serviceProxy.Create(opportunity))
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
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer =
                    String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then
				' Delete all records created in this sample.
				For Each contactId As Guid In _contactIdList
					_serviceProxy.Delete(Contact.EntityLogicalName, contactId)
				Next contactId

				For Each opportunityId As Guid In _opportunityIdList
					_serviceProxy.Delete(Opportunity.EntityLogicalName, opportunityId)
				Next opportunityId

				_serviceProxy.Delete(Account.EntityLogicalName, _accountId)

				Console.WriteLine("Entity record(s) have been deleted.")
			End If
		End Sub

		#End Region

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

				Dim app = New FetchXmlAndQueryExpressionQueryConversion()
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

' </snippetfetchxmlandqueryexpressionqueryconversion>