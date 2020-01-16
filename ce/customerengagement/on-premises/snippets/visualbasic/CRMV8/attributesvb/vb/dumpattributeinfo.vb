' <snippetdumpattributeinfo>


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
 ''' This sample shows how retreive all the attribute info and dump it to an Excel file.
 ''' </summary>
 Public Class DumpAttributeInfo
#Region "Class Level Members"

  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

  ' Create storage for new attributes being created
  Public addedAttributes As List(Of AttributeMetadata)

  ' Specify which language code to use in the sample. If you are using a language
  ' other than US English, you will need to modify this value accordingly.
  ' See https://msdn.microsoft.com/library/0h88fahh.aspx
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

     '                    #Region "How to dump attribute info"
     Dim request As New RetrieveAllEntitiesRequest() With {
         .EntityFilters = EntityFilters.Attributes,
         .RetrieveAsIfPublished = True}

     ' Retrieve the MetaData.
     Dim response As RetrieveAllEntitiesResponse = CType(_serviceProxy.Execute(request), RetrieveAllEntitiesResponse)

     ' Create an instance of StreamWriter to write text to a file.
     ' The using statement also closes the StreamWriter.
     ' To view this file, right click the file and choose open with Excel. 
     ' Excel will figure out the schema and display the information in columns.
     Dim filename As String = String.Concat("AllAttributeDesc.xml")
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
        If currentEntity.IsCustomizable.Value = True Then
         metadataWriter.WriteElementString("IsCustomizable", "yes")
        Else
         metadataWriter.WriteElementString("IsCustomizable", "no")
        End If
        If currentEntity.IsIntersect.Value = True Then
         metadataWriter.WriteElementString("IsIntersect", "yes")
        Else
         metadataWriter.WriteElementString("IsIntersect", "no")
        End If



        '#Region "Attributes"


        ' Write Entity's Attributes.
        metadataWriter.WriteStartElement("Attributes")

        For Each currentAttribute As AttributeMetadata In currentEntity.Attributes
         ' Only write out main attributes.
         If currentAttribute.AttributeOf Is Nothing Then

          ' Start Attribute Node
          metadataWriter.WriteStartElement("Attribute")

          ' Write Attribute's information.
          metadataWriter.WriteElementString("LogicalName", currentAttribute.LogicalName)
          ' Write the Description if it is set.
          If currentAttribute.Description.UserLocalizedLabel IsNot Nothing Then
           metadataWriter.WriteElementString("Description", currentAttribute.Description.UserLocalizedLabel.Label.ToString())
          End If

          metadataWriter.WriteElementString("Type", currentAttribute.AttributeType.Value.ToString())
          If currentAttribute.DisplayName.UserLocalizedLabel IsNot Nothing Then
           metadataWriter.WriteElementString("DisplayName", currentAttribute.DisplayName.UserLocalizedLabel.Label.ToString())
          End If
          If currentAttribute.SchemaName IsNot Nothing Then
           metadataWriter.WriteElementString("SchemaName", currentAttribute.SchemaName.ToString())
          End If
          If currentAttribute.DeprecatedVersion IsNot Nothing Then
           metadataWriter.WriteElementString("DeprecatedVersion", currentAttribute.DeprecatedVersion.ToString())
          End If
          metadataWriter.WriteElementString("IsCustomAttribute", currentAttribute.IsCustomAttribute.Value.ToString())
          metadataWriter.WriteElementString("IsCustomizable", currentAttribute.IsCustomizable.Value.ToString())
          metadataWriter.WriteElementString("RequiredLevel", currentAttribute.RequiredLevel.Value.ToString())
          metadataWriter.WriteElementString("IsValidForCreate", currentAttribute.IsValidForCreate.Value.ToString())
          metadataWriter.WriteElementString("IsValidForRead", currentAttribute.IsValidForRead.Value.ToString())
          metadataWriter.WriteElementString("IsValidForUpdate", currentAttribute.IsValidForUpdate.Value.ToString())
          metadataWriter.WriteElementString("CanBeSecuredForCreate", currentAttribute.CanBeSecuredForCreate.Value.ToString())
          metadataWriter.WriteElementString("CanBeSecuredForRead", currentAttribute.CanBeSecuredForRead.Value.ToString())
          metadataWriter.WriteElementString("CanBeSecuredForUpdate", currentAttribute.CanBeSecuredForUpdate.Value.ToString())
          metadataWriter.WriteElementString("IsAuditEnabled", currentAttribute.IsAuditEnabled.Value.ToString())
          metadataWriter.WriteElementString("IsManaged", currentAttribute.IsManaged.Value.ToString())
          metadataWriter.WriteElementString("IsPrimaryId", currentAttribute.IsPrimaryId.Value.ToString())
          metadataWriter.WriteElementString("IsPrimaryName", currentAttribute.IsPrimaryName.Value.ToString())
          metadataWriter.WriteElementString("IsRenameable", currentAttribute.IsRenameable.Value.ToString())
          metadataWriter.WriteElementString("IsSecured", currentAttribute.IsSecured.Value.ToString())
          metadataWriter.WriteElementString("IsValidForAdvancedFind", currentAttribute.IsValidForAdvancedFind.Value.ToString())

          ' End Attribute Node
          metadataWriter.WriteEndElement()
         End If
        Next currentAttribute
        ' End Attributes Node
        metadataWriter.WriteEndElement()

        '#End Region

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

     '#End Region ' How to dump attribute info



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

    Dim app As New DumpAttributeInfo()
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

' </snippetdumpattributeinfo>