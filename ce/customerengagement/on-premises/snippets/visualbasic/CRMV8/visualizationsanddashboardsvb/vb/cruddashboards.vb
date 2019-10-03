' <snippetcruddashboards>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples

 ''' <summary>
 ''' This sample shows how to perform Create, Retrieve, 
 ''' Update, and Delete operations on a dashboard.
 ''' </summary>

 Public Class CRUDDashboards
#Region "Class Level Members"

  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

  ' Define the IDs needed for this sample.
  Public _dashboardId As Guid

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' Create and configure the organization service proxy.
  ''' Create a dashboard.
  ''' Retrieve the dashboard.
  ''' Update the dashboard.
  ''' Delete the dashboard.
  ''' </summary>
  ''' <param name="serverConfig">Contains server connection information.</param>
  ''' <param name="promptforDelete">When True, the user will be prompted to delete all
  ''' created entities.</param>

  Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                 ByVal promptForDelete As Boolean)
   Try
    ' Connect to the Organization service. 
    ' The using statement assures that the service proxy will be properly disposed.
    _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
    Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()


     'Grab the default public view for opportunities.
     Dim mySavedQuery As QueryExpression =
      New QueryExpression With {
       .ColumnSet = New ColumnSet("savedqueryid"),
       .EntityName = SavedQuery.EntityLogicalName
      }
     mySavedQuery.Criteria = New FilterExpression()
     mySavedQuery.Criteria.AddCondition("isdefault", ConditionOperator.Equal, {True})
     mySavedQuery.Criteria.AddCondition("querytype", ConditionOperator.Equal, {0})
     mySavedQuery.Criteria.AddCondition("returnedtypecode", ConditionOperator.Equal, {Opportunity.EntityTypeCode})

     'This query should return one and only one result.
     Dim defaultOpportunityQuery As SavedQuery = _serviceProxy.RetrieveMultiple(mySavedQuery).Entities.Select(Function(x) CType(x, SavedQuery)).FirstOrDefault()

     ' Retrieve visualizations out of the system. 
     ' This sample assumes that you have the "Top Opportunities"
     ' visualization that is installed with Microsoft Dynamics CRM.
     Dim visualizationQuery As QueryByAttribute =
      New QueryByAttribute With {
       .EntityName = SavedQueryVisualization.EntityLogicalName,
       .ColumnSet = New ColumnSet("savedqueryvisualizationid")
      }
     visualizationQuery.Attributes.Add("name")
     visualizationQuery.Values.Add("Top Opportunities")
     'If you do not have this visualization, you will need to change
     'this line.


     Dim visualization As SavedQueryVisualization =
      _serviceProxy.RetrieveMultiple(visualizationQuery).Entities.Select(Function(x) CType(x, SavedQueryVisualization)).FirstOrDefault()
     'This is the language code for U.S. English. If you are running this code
     'in a different locale, you will need to modify this value.
     Dim languageCode As Integer = 1033

     'We set up our dashboard and specify the FormXml. Refer to the
     'FormXml schema in the Microsoft Dynamics CRM SDK for more information.
     Dim dashboard As SystemForm =
      New SystemForm With {
       .Name = "Sample Dashboard",
       .Description = "Sample organization-owned dashboard.",
       .FormXml = String.Format("<form><tabs><tab name='Test Dashboard' verticallayout='true'>" &amp; _
                                "<labels><label description='Sample Dashboard' languagecode='{0}' />" &amp; _
                                "</labels><columns><column width='100%'><sections>" &amp; _
                                "<section name='Information Section' showlabel='false' showbar='false' columns='111'>" &amp; _
                                "<labels><label description='Information Section' languagecode='{0}' />" &amp; _
                                "</labels><rows><row><cell colspan='1' rowspan='10' showlabel='false'><labels>" &amp; _
                                "<label description='Top Opportunitiess - 1' languagecode='{0}' /></labels>" &amp; _
                                "<control id='TopOpportunities' classid='{{E7A81278-8635-4d9e-8D4D-59480B391C5B}}'>" &amp; _
                                "<parameters><ViewId>{1}</ViewId><IsUserView>false</IsUserView><RelationshipName />" &amp; _
                                "<TargetEntityType>opportunity</TargetEntityType><AutoExpand>Fixed</AutoExpand>" &amp; _
                                "<EnableQuickFind>false</EnableQuickFind><EnableViewPicker>false</EnableViewPicker>" &amp; _
                                "<EnableJumpBar>false</EnableJumpBar><ChartGridMode>Chart</ChartGridMode>" &amp; _
                                "<VisualizationId>{2}</VisualizationId><EnableChartPicker>false</EnableChartPicker>" &amp; _
                                "<RecordsPerPage>10</RecordsPerPage></parameters></control></cell>" &amp; _
                                "<cell colspan='1' rowspan='10' showlabel='false'><labels>" &amp; _
                                "<label description='Top Opportunities - 2' languagecode='{0}' /></labels>" &amp; _
                                "<control id='TopOpportunities2' classid='{{E7A81278-8635-4d9e-8D4D-59480B391C5B}}'>" &amp; _
                                "<parameters><ViewId>{1}</ViewId><IsUserView>false</IsUserView><RelationshipName />" &amp; _
                                "<TargetEntityType>opportunity</TargetEntityType><AutoExpand>Fixed</AutoExpand>" &amp; _
                                "<EnableQuickFind>false</EnableQuickFind><EnableViewPicker>false</EnableViewPicker>" &amp; _
                                "<EnableJumpBar>false</EnableJumpBar><ChartGridMode>Grid</ChartGridMode>" &amp; _
                                "<VisualizationId>{2}</VisualizationId><EnableChartPicker>false</EnableChartPicker>" &amp; _
                                "<RecordsPerPage>10</RecordsPerPage></parameters></control></cell></row><row /><row />" &amp; _
                                "<row /><row /><row /><row /><row /><row /><row /></rows></section></sections></column>" &amp; _
                                "</columns></tab></tabs></form>",
                                languageCode,
                                defaultOpportunityQuery.SavedQueryId.Value.ToString("B"),
                                visualization.SavedQueryVisualizationId.Value.ToString("B")),
       .IsDefault = False
      }
     _dashboardId = _serviceProxy.Create(dashboard)
     Console.WriteLine("Created {0}.", dashboard.Name)

     'Now we will retrieve the dashboard.
     Dim retrievedDashboard As SystemForm =
      CType(_serviceProxy.Retrieve(SystemForm.EntityLogicalName, _dashboardId, New ColumnSet(True)), SystemForm)
     Console.WriteLine("Retrieved the dashboard.")

     ' Update the retrieved dashboard. Enable the chart picker on the chart.                                       
     Dim xDocument As XDocument = xDocument.Parse(retrievedDashboard.FormXml)

     Dim chartPicker = ( _
         From control In xDocument.Descendants("control") _
         Where control.Attribute("id").Value = "TopOpportunities" _
         Select control.Descendants("EnableChartPicker").First()).First()
     chartPicker.Value = "true"

     'Now we place the updated Xml back into the dashboard, and update it.
     retrievedDashboard.FormXml = xDocument.ToString()
     _serviceProxy.Update(retrievedDashboard)

     ' Publish the dashboard changes to the solution. 
     ' This is only required for organization-owned dashboards.
     Dim updateRequest As PublishXmlRequest =
      New PublishXmlRequest With {
       .ParameterXml = "<dashboard>_dashboardId</dashboard>"
      }

     _serviceProxy.Execute(updateRequest)

     Console.WriteLine("Updated the dashboard.")

     DeleteRequiredRecords(promptForDelete)

    End Using

    ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
   Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
    ' You can handle an exception here or pass it back to the calling method.
    Throw
   End Try
  End Sub
  ''' <summary>
  ''' Deletes any entity records that were created for this sample.
  ''' <param name='prompt'>Indicates whether to prompt the user 
  ''' to delete the records created in this sample.</param>
  ''' </summary>
  Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
   Dim deleteRecords As Boolean = True

   If prompt Then
    Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
    Dim answer As String = Console.ReadLine()

    deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty)
   End If

   If deleteRecords Then
    _serviceProxy.Delete(SystemForm.EntityLogicalName, _dashboardId)
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

    Dim app As New CRUDDashboards()
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
    ' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
    ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

   Finally
    Console.WriteLine("Press <Enter> to exit.")
    Console.ReadLine()
   End Try

  End Sub
#End Region ' Main

 End Class
End Namespace

' </snippetcruddashboards>