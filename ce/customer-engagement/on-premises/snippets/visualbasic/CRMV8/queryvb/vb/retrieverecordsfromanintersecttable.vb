' <snippetretrieverecordsfromanintersecttable>


Imports System.Text
Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Demonstrates how to retrieve records from an intersect table.
	''' </summary>
	Public Class RetrieveRecordsFromAnIntersectTable

		#Region "Class Level Members"

		Private _userId As Guid
		Private _roleId As Guid
		Private _serviceProxy As OrganizationServiceProxy

		#End Region ' Class Level Members

		#Region "How-To Sample Code"
		''' <summary>
		''' This method first connects to the Organization service. Afterwards,
		''' records are retrieved from the systemuserroles intersect table via three
		''' methods: Query Expression, Fetch, and LINQ.
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
                    '					#Region "Retrieve records from an intersect table via QueryExpression"

                    'Create Query Expression.
                    Dim query As New QueryExpression() With
                        {
                            .EntityName = "role",
                            .ColumnSet = New ColumnSet("name")
                        }

                    Dim queryLinkEntity As New LinkEntity With
                        {
                            .LinkToEntityName = SystemUserRoles.EntityLogicalName,
                            .LinkFromAttributeName = "roleid",
                            .LinkToAttributeName = "roleid"
                        }
                    queryLinkEntity.LinkCriteria().AddCondition(
                        "systemuserid",
                        ConditionOperator.Equal,
                        _userId)
                    queryLinkEntity.LinkCriteria().FilterOperator = LogicalOperator.And
                    query.LinkEntities().Add(queryLinkEntity)

                    ' Obtain results from the query expression.
                    Dim ec As EntityCollection = _serviceProxy.RetrieveMultiple(query)

                    ' Display results.
                    For i As Integer = 0 To ec.Entities.Count - 1
                        Console.WriteLine("Query Expression Retrieved: {0}",
                                          (CType(ec.Entities(i), Role)).Name)
                    Next i

                    '					#End Region
                    '					#Region "Retrieve records from an intersect table via Fetch"

                    ' Setup Fetch XML.
                    Dim linkFetch As New StringBuilder()
                    linkFetch.Append("<fetch version=""1.0"" " _
                                     &amp; "output-format=""xml-platform"" " _
                                     &amp; "mapping=""logical"" distinct=""true"">")
                    linkFetch.Append("<entity name=""role"">")
                    linkFetch.Append("<attribute name=""name""/>")
                    linkFetch.Append("<link-entity name=""systemuserroles"" " _
                                     &amp; "from=""roleid"" to=""roleid"" " _
                                     &amp; "visible=""false"" intersect=""true"">")
                    linkFetch.Append("<filter type=""and"">")
                    linkFetch.Append("<condition attribute=""systemuserid"" " _
                                     &amp; "operator=""eq"" value=""" _
                                     &amp; _userId.ToString() &amp; """/>")
                    linkFetch.Append("</filter>")
                    linkFetch.Append("</link-entity>")
                    linkFetch.Append("</entity>")
                    linkFetch.Append("</fetch>")

                    ' Build fetch request and obtain results.
                    Dim efr As New RetrieveMultipleRequest() With
                        {
                            .Query = New FetchExpression(linkFetch.ToString())
                        }
                    Dim entityResults As EntityCollection =
                        (CType(_serviceProxy.Execute(efr), 
                         RetrieveMultipleResponse)).EntityCollection

                    ' Display results.
                    For Each e In entityResults.Entities
                        Console.WriteLine("Fetch Retrieved: {0}", e.Attributes("name"))
                    Next e

                    '					#End Region
                    '					#Region "Retrieve records from an intersect table via LINQ"

                    ' Obtain the Organization Context.
                    Dim context As New OrganizationServiceContext(_serviceProxy)

                    ' Create Linq Query.
                    Dim roles = ( _
                        From r In context.CreateQuery(Of Role)() _
                        Join s In context.CreateQuery(Of SystemUserRoles)() _
                        On r.RoleId Equals s.RoleId _
                        Where s.SystemUserId.Equals(_userId) _
                        Order By r.RoleId _
                        Select r.Name)

                    ' Display results.
                    For Each role In roles
                        Console.WriteLine("Linq Retrieved: {0}", role)
                    Next role

                    '					#End Region
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
			' Retrieve the default business unit needed to create the team.
            Dim queryDefaultBusinessUnit As QueryExpression =
                New QueryExpression With
                {
                    .EntityName = BusinessUnit.EntityLogicalName,
                    .ColumnSet = New ColumnSet("businessunitid"),
                    .Criteria = New FilterExpression()
                }

			' Execute the request.
            queryDefaultBusinessUnit.Criteria.AddCondition("parentbusinessunitid",
                                                           ConditionOperator.Null)

            Dim defaultBusinessUnit As BusinessUnit =
                CType(_serviceProxy.RetrieveMultiple(queryDefaultBusinessUnit).Entities(0), 
                    BusinessUnit)

			' Get the GUID of the current user.
			Dim who As New WhoAmIRequest()
            Dim whoResp As WhoAmIResponse = CType(_serviceProxy.Execute(who), 
                WhoAmIResponse)
			_userId = whoResp.UserId

			' Instantiate a role entity record and set its property values.
			' See the Entity Metadata topic in the SDK documentation to determine
			' which attributes must be set for each entity.
            Dim setupRole As Role = New Role With
                                    {
                                        .Name = "ABC Management Role",
                                        .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName,
                                                                              defaultBusinessUnit.Id)
                                    }

			'Create a role record.
			_roleId = _serviceProxy.Create(setupRole)
			Console.WriteLine("Created Role.")

			' Assign User to Managers role.
            Dim associate As New AssociateRequest() With
                {
                    .Target = New EntityReference(SystemUser.EntityLogicalName, _userId),
                    .RelatedEntities = New EntityReferenceCollection() From
                    {
                        New EntityReference(Role.EntityLogicalName, _roleId)
                    },
                    .Relationship = New Relationship("systemuserroles_association")
                }

			' Execute the request.
			_serviceProxy.Execute(associate)
		End Sub

		''' <summary>
		''' Deletes any entity records and files that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			Dim deleteRecords As Boolean = True

			If prompt Then
				Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") _
                                 OrElse answer = String.Empty)
			End If

			If deleteRecords Then
				_serviceProxy.Delete(Role.EntityLogicalName, _roleId)
				Console.WriteLine("Entity records have been deleted.")
			End If
		End Sub

		#End Region ' How-To Sample Code

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
				Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

				Dim app As New RetrieveRecordsFromAnIntersectTable()
				app.Run(config, True)
			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
			Catch ex As TimeoutException
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Message: {0}", ex.Message)
				Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
			Catch ex As Exception
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

' </snippetretrieverecordsfromanintersecttable>