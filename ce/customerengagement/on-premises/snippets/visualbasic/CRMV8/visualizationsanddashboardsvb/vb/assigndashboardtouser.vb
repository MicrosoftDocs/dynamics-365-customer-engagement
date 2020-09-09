' <snippetassigndashboardtouser>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Client
' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Imports System.DirectoryServices
Imports System.Threading

Namespace Microsoft.Crm.Sdk.Samples
	Public Class AssignDashboardToUser
		#Region "Class Level Members  "

		''' <summary>
		''' Stores the organization service proxy.
		''' </summary>
		Private _serviceProxy As OrganizationServiceProxy

		' Define the IDs needed for this sample.
		Private _userDashboardId As Guid
		Private _otherUserId As Guid

		#End Region ' Class Level Members

		#Region "How To Sample Code"
		''' <summary>
		''' This method first connects to the Organization service. Afterwards,
		''' a user dashbaord is assigned to another user.
		''' </summary>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>
		Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
			Try

				' Connect to the Organization service. 
				' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
				Using _serviceProxy
					' This statement is required to enable early-bound type support.
					_serviceProxy.EnableProxyTypes()

					' Call the method to create any data that this sample requires.
					CreateRequiredRecords()

                    Dim assignRequest As AssignRequest = New AssignRequest With
                                                         {
                                                             .Assignee = New EntityReference With
                                                                         {
                                                                             .LogicalName = SystemUser.EntityLogicalName,
                                                                             .Id = _otherUserId
                                                                         },
                                                             .Target = New EntityReference With
                                                                       {
                                                                           .LogicalName = UserForm.EntityLogicalName,
                                                                           .Id = _userDashboardId
                                                                       }
                                                         }
							' Here we could assign the visualization to the newly created user
					_serviceProxy.Execute(assignRequest)

					Console.WriteLine("The user dashboard has been assigned to Kevin Cook.")


					DeleteRequiredRecords(promptForDelete)
				End Using

			' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
			Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				' You can handle an exception here or pass it back to the calling method.
				Throw
			End Try
		End Sub

		''' <summary>
		''' This method creates any entity records that this sample requires.
		''' Creates the dashboard.
		''' </summary>
		Public Sub CreateRequiredRecords()
			'Grab the default public view for opportunities.
            Dim mySavedQuery As QueryExpression = New QueryExpression With
                                                  {
                                                      .ColumnSet = New ColumnSet("savedqueryid"),
                                                      .EntityName = SavedQuery.EntityLogicalName
                                                  }
            mySavedQuery.Criteria = New FilterExpression()
            mySavedQuery.Criteria.AddCondition("isdefault", ConditionOperator.Equal, {True})
            mySavedQuery.Criteria.AddCondition("querytype", ConditionOperator.Equal, {0})
            mySavedQuery.Criteria.AddCondition("returnedtypecode", ConditionOperator.Equal, {Opportunity.EntityTypeCode})

			'This query should return one and only one result.
            Dim defaultOpportunityQuery As SavedQuery = _serviceProxy.RetrieveMultiple(mySavedQuery).
                Entities.Select(Function(x) CType(x, SavedQuery)).FirstOrDefault()

			' Retrieve visualizations out of the system. 
			' This sample assumes that you have the "Top Opportunities"
			' visualization that is installed with Microsoft Dynamics CRM.
            Dim visualizationQuery As QueryByAttribute = New QueryByAttribute With
                                                         {
                                                             .EntityName = SavedQueryVisualization.EntityLogicalName,
                                                             .ColumnSet = New ColumnSet("savedqueryvisualizationid")
                                                         }
            visualizationQuery.Attributes.Add("name")
            visualizationQuery.Values.Add("Top Opportunities")
            'If you do not have this visualization, you will need to change
				'this line.


            Dim visualization As SavedQueryVisualization = _serviceProxy.RetrieveMultiple(visualizationQuery).
                Entities.Select(Function(x) CType(x, SavedQueryVisualization)).FirstOrDefault()

			'This is the language code for U.S. English. If you are running this code
			'in a different locale, you will need to modify this value.
			Dim languageCode As Integer = 1033

			'We set up our dashboard and specify the FormXml. Refer to the
			'FormXml schema in the Microsoft Dynamics CRM SDK for more information.
            Dim dashboard As UserForm =
                New UserForm With
                {
                    .Name = "Sample User Dashboard",
                    .Description = "Sample user-owned dashboard.",
                    .FormXml = String.Format(
                        "<form> " _
                        + "<tabs> " _
                            + "<tab name='Test Dashboard' verticallayout='true'> " _
                                + "<labels> " _
                                    + "<label " _
                                        + "description='Sample User Dashboard' " _
                                        + "languagecode='{0}' /> " _
                                + "</labels> " _
                                + "<columns> " _
                                    + "<column width='100%'> " _
                                        + "<sections> " _
                                            + "<section name='Information Section' " _
                                                    + "showlabel='false' " _
                                                    + "showbar='false' columns='111'> " _
                                                + "<labels> " _
                                                    + "<label " _
                                                        + "description='Information Section' " _
                                                        + "languagecode='{0}' /> " _
                                                + "</labels> " _
                                                + "<rows> " _
                                                    + "<row> " _
                                                        + "<cell colspan='1' " _
                                                            + "rowspan='10' " _
                                                            + "showlabel='false'> " _
                                                            + "<labels> " _
                                                                + "<label " _
                                                                    + "description='Top Opportunities - 1' " _
                                                                    + "languagecode='{0}' /> " _
                                                            + "</labels> " _
                                                            + "<control " _
                                                                + "id='Top10Opportunities' " _
                                                                + "classid='{{E7A81278-8635-4d9e-8D4D-59480B391C5B}}'> " _
                                                                + "<parameters> " _
                                                                    + "<ViewId>{1}</ViewId> " _
                                                                    + "<IsUserView>false</IsUserView> " _
                                                                    + "<RelationshipName /> " _
                                                                    + "<TargetEntityType>opportunity</TargetEntityType> " _
                                                                    + "<AutoExpand>Fixed</AutoExpand> " _
                                                                    + "<EnableQuickFind>false</EnableQuickFind> " _
                                                                    + "<EnableViewPicker>false</EnableViewPicker> " _
                                                                    + "<EnableJumpBar>false</EnableJumpBar> " _
                                                                    + "<ChartGridMode>Chart</ChartGridMode> " _
                                                                    + "<VisualizationId>{2}</VisualizationId> " _
                                                                    + "<EnableChartPicker>false</EnableChartPicker> " _
                                                                    + "<RecordsPerPage>10</RecordsPerPage> " _
                                                                + "</parameters> " _
                                                            + "</control> " _
                                                        + "</cell> " _
                                                        + "<cell colspan='1' " _
                                                            + "rowspan='10' " _
                                                            + "showlabel='false'> " _
                                                            + "<labels> " _
                                                                + "<label " _
                                                                    + "description='Top Opportunities - 2' " _
                                                                    + "languagecode='{0}' /> " _
                                                            + "</labels> " _
                                                            + "<control " _
                                                                + "id='Top10Opportunities2' " _
                                                                + "classid='{{E7A81278-8635-4d9e-8D4D-59480B391C5B}}'> " _
                                                                + "<parameters> " _
                                                                    + "<ViewId>{1}</ViewId> " _
                                                                    + "<IsUserView>false</IsUserView> " _
                                                                    + "<RelationshipName /> " _
                                                                    + "<TargetEntityType>opportunity</TargetEntityType> " _
                                                                    + "<AutoExpand>Fixed</AutoExpand> " _
                                                                    + "<EnableQuickFind>false</EnableQuickFind> " _
                                                                    + "<EnableViewPicker>false</EnableViewPicker> " _
                                                                    + "<EnableJumpBar>false</EnableJumpBar> " _
                                                                    + "<ChartGridMode>Grid</ChartGridMode> " _
                                                                    + "<VisualizationId>{2}</VisualizationId> " _
                                                                    + "<EnableChartPicker>false</EnableChartPicker> " _
                                                                    + "<RecordsPerPage>10</RecordsPerPage> " _
                                                                + "</parameters> " _
                                                            + "</control> " _
                                                        + "</cell> " _
                                                    + "</row> " _
                                                    + "<row /> " _
                                                    + "<row /> " _
                                                    + "<row /> " _
                                                    + "<row /> " _
                                                    + "<row /> " _
                                                    + "<row /> " _
                                                    + "<row /> " _
                                                    + "<row /> " _
                                                    + "<row /> " _
                                                + "</rows> " _
                                            + "</section> " _
                                        + "</sections> " _
                                    + "</column> " _
                                + "</columns> " _
                            + "</tab> " _
                        + "</tabs> " _
                    + "</form>",
                    languageCode,
                    defaultOpportunityQuery.SavedQueryId.Value.ToString("B"),
                    visualization.SavedQueryVisualizationId.Value.ToString("B"))
                }
			_userDashboardId = _serviceProxy.Create(dashboard)

			Console.WriteLine("Created {0}.", dashboard.Name)

			' Create another user to whom the dashboard will be assigned.
			_otherUserId = SystemUserProvider.RetrieveSalesManager(_serviceProxy)
		End Sub


		''' <summary>
		''' Deletes the entity record that was created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the entity created in this sample.</param>
		''' The system user named "Kevin Cook" that was created by this sample will
		''' continue to exist on your system because system users cannot be deleted
		''' in Microsoft Dynamics CRM. They can only be enabled or disabled.

		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			If Not prompt Then
				Return
			End If

			' Ask the user if the created entities should be deleted.
			Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
			Dim answer As String = Console.ReadLine()

			If answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty Then
				' Delete action doesn't work on the UserForm instance if it is assigned
				' to a user other than current user.
				' So as a workaround, we are impersonating the actual owner of 
				' the UserForm instance to complete the delete action.
				' To impersonate another user, set the OrganizationServiceProxy.CallerId
				' property to the ID of the other user.
				_serviceProxy.CallerId = _otherUserId

				_serviceProxy.Delete(UserForm.EntityLogicalName, _userDashboardId)
				Console.WriteLine("Entity records have been deleted.")
			End If
		End Sub

		#End Region ' How To Sample Code

		#Region "Main"
		''' <summary>
		''' Main. Runs the sample and provides error output.
		''' <param name="args">Array of arguments to Main method.</param>
		''' </summary>
		Public Shared Sub Main(ByVal args() As String)

			Try
				' Obtain the target organization's Web address and client logon 
				' credentials from the user.
				Dim serverConnect As New ServerConnection()
				Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

				Dim app As New AssignDashboardToUser()
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
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
			Catch ex As Exception
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine(ex.Message)

				' Display the details of the inner exception.
				If ex.InnerException IsNot Nothing Then
					Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
                        TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
					If fe IsNot Nothing Then
						Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
						Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
						Console.WriteLine("Message: {0}", fe.Detail.Message)
						Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
					End If
				End If
			Finally
				Console.WriteLine("Press <Enter> to exit.")
				Console.ReadLine()
			End Try

		End Sub
		#End Region ' Main

	End Class
End Namespace

' </snippetassigndashboardtouser>