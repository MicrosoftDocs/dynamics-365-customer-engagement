' <snippetexportribbonxml>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata



Imports Microsoft.Crm.Sdk.Messages

'These references are required for this sample
Imports System.IO
Imports System.IO.Packaging

Namespace Microsoft.Crm.Sdk.Samples
 ''' <summary>
 ''' Demonstrates how to export the RibbonXml definitions.</summary>
 ''' <remarks>
 ''' The generated XML files will be created in the ExportedRibbonXml folder of this project.</remarks>
 Public Class ExportRibbonXml
  #Region "Class Level Members"


  Private _serviceProxy As OrganizationServiceProxy
  'This array contains all of the system entities that use the ribbon.
        Public entitiesWithRibbons() As String = {"account", "activitymimeattachment", "activitypointer", "appointment", "bulkoperation", _
                                                  "campaign", "campaignactivity", "campaignresponse", "competitor", "connection", "contact", _
                                                  "contract", "contractdetail", "customeraddress", "discount", "discounttype", "email", "fax", "goal", _
                                                  "importfile", "incident", "invoice", "invoicedetail", "kbarticle", "kbarticlecomment", "lead", _
                                                  "letter", "list", "listmember", "metric", "opportunity", "opportunityproduct", "phonecall", _
                                                  "pricelevel", "product", "productpricelevel", "queueitem", "quote", "quotedetail", _
                                                  "recurringappointmentmaster", "report", "salesliterature", "salesorder", "salesorderdetail", _
                                                  "service", "serviceappointment", "sharepointdocumentlocation", "sharepointsite", "systemuser", _
                                                  "task", "team", "territory", "uom", "uomschedule", "userquery"}
  'Folder name for exported ribbon xml files.
  Public exportFolder As String = "ExportedRibbonXml"

  #End Region ' Class Level Members

  #Region "How To Sample Code"
  ''' <summary>
  ''' This method first connects to the Organization service. Afterwards,
  ''' basic create, retrieve, update, and delete entity operations are performed.
  ''' </summary>
  ''' <param name="serverConfig">Contains server connection information.</param>
  ''' <param name="promptforDelete">When True, the user will be prompted to delete all
  ''' created entities.</param>
  Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptforDelete As Boolean)
   Try
    ' Connect to the Organization service. 
    ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
    Using _serviceProxy
     ' This statement is required to enable early-bound type support.                  
     _serviceProxy.EnableProxyTypes()

     'Create export folder for ribbon xml files if not already exist.
     If Not Directory.Exists(exportFolder) Then
         Directory.CreateDirectory(exportFolder)
     End If

     'Retrieve the Application Ribbon
     Dim appribReq As New RetrieveApplicationRibbonRequest()
     Dim appribResp As RetrieveApplicationRibbonResponse = CType(_serviceProxy.Execute(appribReq), RetrieveApplicationRibbonResponse)

     Dim applicationRibbonPath As String = Path.GetFullPath(exportFolder &amp; "\applicationRibbon.xml")
     File.WriteAllBytes(applicationRibbonPath, unzipRibbon(appribResp.CompressedApplicationRibbonXml))
     'Write the path where the file has been saved.
     Console.WriteLine(applicationRibbonPath)
     'Retrieve system Entity Ribbons
     Dim entRibReq As New RetrieveEntityRibbonRequest() With {.RibbonLocationFilter = RibbonLocationFilters.All}

     For Each entityName As String In entitiesWithRibbons
      entRibReq.EntityName = entityName
      Dim entRibResp As RetrieveEntityRibbonResponse = CType(_serviceProxy.Execute(entRibReq), RetrieveEntityRibbonResponse)

      Dim entityRibbonPath As String = Path.GetFullPath(exportFolder &amp; "\" &amp; entityName &amp; "Ribbon.xml")
      File.WriteAllBytes(entityRibbonPath, unzipRibbon(entRibResp.CompressedEntityXml))
      'Write the path where the file has been saved.
      Console.WriteLine(entityRibbonPath)
     Next entityName

     'Check for custom entities
     Dim raer As New RetrieveAllEntitiesRequest() With {.EntityFilters = EntityFilters.Entity}

     Dim resp As RetrieveAllEntitiesResponse = CType(_serviceProxy.Execute(raer), RetrieveAllEntitiesResponse)

     For Each em As EntityMetadata In resp.EntityMetadata
      If em.IsCustomEntity = True AndAlso em.IsIntersect = False Then
       entRibReq.EntityName = em.LogicalName
       Dim entRibResp As RetrieveEntityRibbonResponse = CType(_serviceProxy.Execute(entRibReq), RetrieveEntityRibbonResponse)

       Dim entityRibbonPath As String = Path.GetFullPath(exportFolder &amp; "\" &amp; em.LogicalName &amp; "Ribbon.xml")
       File.WriteAllBytes(entityRibbonPath, unzipRibbon(entRibResp.CompressedEntityXml))
       'Write the path where the file has been saved.
       Console.WriteLine(entityRibbonPath)
      End If
     Next em
    End Using

   ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
   Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
    ' You can handle an exception here or pass it back to the calling method.
    Throw
   End Try
  End Sub

  ''' <summary>
  ''' A helper method that decompresses the Ribbon data returned
  ''' </summary>
  ''' <param name="data">The compressed ribbon data</param>
  ''' <returns></returns>
  Public Function unzipRibbon(ByVal data() As Byte) As Byte()
   Dim package As System.IO.Packaging.ZipPackage = Nothing
   Dim memStream As MemoryStream = Nothing

   memStream = New MemoryStream()
   memStream.Write(data, 0, data.Length)
   package = CType(ZipPackage.Open(memStream, FileMode.Open), ZipPackage)

   Dim part As ZipPackagePart = CType(package.GetPart(New Uri("/RibbonXml.xml", UriKind.Relative)), ZipPackagePart)
   Using strm As Stream = part.GetStream()
    Dim len As Long = strm.Length
                Dim buff(CInt(len - 1)) As Byte
    strm.Read(buff, 0, CInt(len))
    Return buff
   End Using
  End Function

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
    Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

    Dim app As New ExportRibbonXml()
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

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = _
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
  #End Region ' Main method
 End Class
End Namespace

' </snippetexportribbonxml>