' <snippetdumpentityinfo>


Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.Xml.Serialization
Imports System.Xml
Imports System.IO

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Metadata
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
 ''' <summary>
 ''' This sample shows how to retrieve and write out entity metadata.
 ''' </summary>
 Public Class DumpEntityInfo
#Region "Class Level Members"

  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

  ' Create storage for new attributes being created
  Public addedAttributes As List(Of AttributeMetadata)

  ' Specify which language code to use in the sample. If you are using a language
  ' other than US English, you will need to modify this value accordingly.
  ' See http://msdn.microsoft.com/library/0h88fahh.aspx
  Public Const _languageCode As Integer = 1033

  ' Define the IDs/variables needed for this sample.
  Public _insertedStatusValue As Integer

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' </summary>
  ''' <param name="serverConfig">Contains server connection information.</param>
  ''' <param name="promptForDelete">When True, the user will be prompted to delete all
  ''' created entities.</param>
  Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
   Try

    ' Connect to the Organization service. 
    ' The using statement assures that the service proxy will be properly disposed.
    _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
    Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     Dim request As New RetrieveAllEntitiesRequest() With {
      .EntityFilters = EntityFilters.Entity,
      .RetrieveAsIfPublished = True
     }

     ' Retrieve the MetaData.
     Dim response As RetrieveAllEntitiesResponse = CType(_serviceProxy.Execute(request), RetrieveAllEntitiesResponse)


     ' Create an instance of StreamWriter to write text to a file.
     ' The using statement also closes the StreamWriter.
     ' To view this file, right click the file and choose open with Excel. 
     ' Excel will figure out the schema and display the information in columns.

     Dim filename As String = String.Concat("EntityInfo.xml")
     Using sw As New StreamWriter(filename)
      ' Create Xml Writer.
      Dim metadataWriter As New XmlTextWriter(sw)

      ' Start Xml File.
      metadataWriter.WriteStartDocument()

      ' Metadata Xml Node.
      metadataWriter.WriteStartElement("Metadata")

      For Each currentEntity As EntityMetadata In response.EntityMetadata
       'if (currentEntity.IsIntersect.Value == false)
       If True Then
        ' Start Entity Node
        metadataWriter.WriteStartElement("Entity")

        ' Write the Entity's Information.
        metadataWriter.WriteElementString("EntityLogicalName", currentEntity.LogicalName)
        metadataWriter.WriteElementString("OTC", currentEntity.ObjectTypeCode.ToString())
        metadataWriter.WriteElementString("OwnershipType", currentEntity.OwnershipType.Value.ToString())
        If currentEntity.DisplayName.UserLocalizedLabel IsNot Nothing Then
         metadataWriter.WriteElementString("DisplayName", currentEntity.DisplayName.UserLocalizedLabel.Label)
        End If
        If currentEntity.DisplayCollectionName.UserLocalizedLabel IsNot Nothing Then
         metadataWriter.WriteElementString("DisplayCollectionName", currentEntity.DisplayCollectionName.UserLocalizedLabel.Label)
        End If

        metadataWriter.WriteElementString("AutoRouteToOwnerQueue", currentEntity.AutoRouteToOwnerQueue.ToString())
        metadataWriter.WriteElementString("CanBeInManyToMany", currentEntity.CanBeInManyToMany.Value.ToString())
        metadataWriter.WriteElementString("CanBePrimaryEntityInRelationship", currentEntity.CanBePrimaryEntityInRelationship.Value.ToString())
        metadataWriter.WriteElementString("CanBeRelatedEntityInRelationship", currentEntity.CanBeRelatedEntityInRelationship.Value.ToString())
        metadataWriter.WriteElementString("CanCreateAttributes", currentEntity.CanCreateAttributes.Value.ToString())
        metadataWriter.WriteElementString("CanCreateCharts", currentEntity.CanCreateCharts.Value.ToString())
        metadataWriter.WriteElementString("CanCreateForms", currentEntity.CanCreateForms.Value.ToString())
        metadataWriter.WriteElementString("CanCreateViews", currentEntity.CanCreateViews.Value.ToString())
        metadataWriter.WriteElementString("CanModifyAdditionalSettings", currentEntity.CanModifyAdditionalSettings.Value.ToString())
        metadataWriter.WriteElementString("CanTriggerWorkflow", currentEntity.CanTriggerWorkflow.Value.ToString())

        metadataWriter.WriteElementString("IsActivity", currentEntity.IsActivity.Value.ToString())
        'metadataWriter.WriteElementString("ActivityTypeMask", currentEntity.ActivityTypeMask.ToString());

        metadataWriter.WriteElementString("IsActivityParty", currentEntity.IsActivityParty.Value.ToString())

        metadataWriter.WriteElementString("IsAuditEnabled", currentEntity.IsAuditEnabled.Value.ToString())
        metadataWriter.WriteElementString("IsAvailableOffline", currentEntity.IsAvailableOffline.ToString())
        metadataWriter.WriteElementString("IsChildEntity", currentEntity.IsChildEntity.ToString())
        metadataWriter.WriteElementString("IsConnectionsEnabled", currentEntity.IsConnectionsEnabled.ManagedPropertyLogicalName.ToString())
        metadataWriter.WriteElementString("IsCustomEntity", currentEntity.IsCustomEntity.Value.ToString())
        metadataWriter.WriteElementString("IsCustomizable", currentEntity.IsCustomizable.Value.ToString())

        metadataWriter.WriteElementString("IsDocumentManagementEnabled", currentEntity.IsDocumentManagementEnabled.Value.ToString())
        metadataWriter.WriteElementString("IsDuplicateDetectionEnabled", currentEntity.IsDuplicateDetectionEnabled.Value.ToString())
        If currentEntity.IsEnabledForCharts IsNot Nothing Then
         metadataWriter.WriteElementString("IsEnabledForCharts", currentEntity.IsEnabledForCharts.Value.ToString())
        End If
        metadataWriter.WriteElementString("IsImportable", currentEntity.IsImportable.Value.ToString())
        metadataWriter.WriteElementString("IsIntersect", currentEntity.IsIntersect.Value.ToString())

        metadataWriter.WriteElementString("IsMailMergeEnabled", currentEntity.IsMailMergeEnabled.Value.ToString())
        metadataWriter.WriteElementString("IsManaged", currentEntity.IsManaged.Value.ToString())
        metadataWriter.WriteElementString("IsMappable", currentEntity.IsMappable.Value.ToString())

        metadataWriter.WriteElementString("IsReadingPaneEnabled", currentEntity.IsReadingPaneEnabled.Value.ToString())
        metadataWriter.WriteElementString("IsRenameable", currentEntity.IsRenameable.Value.ToString())
        metadataWriter.WriteElementString("IsValidForAdvancedFind", currentEntity.IsValidForAdvancedFind.Value.ToString())
        metadataWriter.WriteElementString("IsValidForQueue", currentEntity.IsValidForQueue.Value.ToString())
        metadataWriter.WriteElementString("IsVisibleInMobile", currentEntity.IsVisibleInMobile.Value.ToString())

        metadataWriter.WriteElementString("PrimaryIdAttribute", currentEntity.PrimaryIdAttribute)
        metadataWriter.WriteElementString("PrimaryNameAttribute", currentEntity.PrimaryNameAttribute)
        metadataWriter.WriteElementString("ReportViewName", currentEntity.ReportViewName)
        metadataWriter.WriteElementString("RecurrenceBaseEntityLogicalName", currentEntity.RecurrenceBaseEntityLogicalName)
        If currentEntity.Description.UserLocalizedLabel IsNot Nothing Then
         metadataWriter.WriteElementString("Description", currentEntity.Description.UserLocalizedLabel.Label)
        End If



        ' End Entity Node
        metadataWriter.WriteEndElement()
       End If
      Next currentEntity

      ' End Metadata Xml Node
      metadataWriter.WriteEndElement()
      metadataWriter.WriteEndDocument()

      ' Close xml writer.
      metadataWriter.Close()
     End Using




     Console.WriteLine("Done.")

     'DeleteRequiredRecords(promptForDelete);
    End Using

    ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
   Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
    ' You can handle an exception here or pass it back to the calling method.
    Throw
   End Try
  End Sub

  ''' <summary>
  ''' Deletes/Reverts the record that was created/changed for this sample.
  ''' <param name="prompt">Indicates whether to prompt the user to delete 
  ''' the records created in this sample.</param>
  ''' </summary>
  Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
   Dim deleteRecords As Boolean = True

   If prompt Then
    Console.WriteLine(vbLf &amp; "Do you want these entity records to be deleted? (y/n)")
    Dim answer As String = Console.ReadLine()

    deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
   End If

   If deleteRecords Then

   End If
  End Sub
#End Region ' How To Sample Code

#Region "Main"
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

    Dim app As New DumpEntityInfo()
    app.Run(config, False)
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

     Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
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

' </snippetdumpentityinfo>