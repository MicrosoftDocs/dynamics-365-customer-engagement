' <snippetworkwithsolutions>


Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.IO

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Metadata
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages


Namespace Microsoft.Crm.Sdk.Samples

 ''' <summary>
 ''' Demonstrates common tasks performed using Microsoft Dynamics CRM Solutions
 ''' </summary>
 Public Class WorkWithSolutions
#Region "Class Level Members"

  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

  Private _crmSdkPublisherId As Guid
  Private _customizationPrefix As String
  Private _solutionsSampleSolutionId As Guid
  Private ManagedSolutionLocation As String = "C:\temp\ManagedSolutionForImportExample.zip"



  ' Specify which language code to use in the sample. If you are using a language
  ' other than US English, you will need to modify this value accordingly.
  ' See http://msdn.microsoft.com/library/0h88fahh.aspx
  Private Const _languageCode As Integer = 1033


#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' Shows how to perform the following tasks with solutions:
  ''' - Create a Publisher
  ''' - Retrieve the Default Publisher
  ''' - Create a Solution
  ''' - Retrieve a Solution
  ''' - Add an existing Solution Component
  ''' - Remove a Solution Component
  ''' - Export or Package a Solution
  ''' - Install or Upgrade a solution
  ''' - Delete a Solution
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

     ' Call the method to create any data that this sample requires.
     CreateRequiredRecords()


     'Define a new publisher
     Dim _crmSdkPublisher As Publisher =
      New Publisher With {
       .UniqueName = "sdksamples",
       .FriendlyName = "Microsoft CRM SDK Samples",
       .SupportingWebsiteUrl = "http://msdn.microsoft.com/dynamics/crm/default.aspx",
       .CustomizationPrefix = "sample",
       .EMailAddress = "someone@microsoft.com",
       .Description = "This publisher was created with samples from the Microsoft Dynamics CRM SDK"
      }

     'Does publisher already exist?
     Dim querySDKSamplePublisher As QueryExpression =
      New QueryExpression With {
       .EntityName = Publisher.EntityLogicalName,
       .ColumnSet = New ColumnSet("publisherid", "customizationprefix"),
       .Criteria = New FilterExpression()
      }

     querySDKSamplePublisher.Criteria.AddCondition("uniquename",
                                                   ConditionOperator.Equal,
                                                   _crmSdkPublisher.UniqueName)
     Dim querySDKSamplePublisherResults As EntityCollection =
      _serviceProxy.RetrieveMultiple(querySDKSamplePublisher)
     Dim SDKSamplePublisherResults As Publisher = Nothing

     'If it already exists, use it
     If querySDKSamplePublisherResults.Entities.Count > 0 Then
      SDKSamplePublisherResults = CType(querySDKSamplePublisherResults.Entities(0), Publisher)
      _crmSdkPublisherId = CType(SDKSamplePublisherResults.PublisherId, Guid)
      _customizationPrefix = SDKSamplePublisherResults.CustomizationPrefix
     End If
     'If it doesn't exist, create it
     If SDKSamplePublisherResults Is Nothing Then
      _crmSdkPublisherId = _serviceProxy.Create(_crmSdkPublisher)
      Console.WriteLine(String.Format("Created publisher: {0}.", _crmSdkPublisher.FriendlyName))
      _customizationPrefix = _crmSdkPublisher.CustomizationPrefix
     End If

     ' Retrieve the Default Publisher

     'The default publisher has a constant GUID value;
     Dim DefaultPublisherId As New Guid("{d21aab71-79e7-11dd-8874-00188b01e34f}")

     Dim DefaultPublisher As Publisher =
      CType(_serviceProxy.Retrieve(Publisher.EntityLogicalName,
                                   DefaultPublisherId,
                                   New ColumnSet(New String() {"friendlyname"})), 
                                  Publisher)

     Dim DefaultPublisherReference As EntityReference = New EntityReference With {
      .Id = DefaultPublisher.Id,
      .LogicalName = Publisher.EntityLogicalName,
      .Name = DefaultPublisher.FriendlyName
     }
     Console.WriteLine("Retrieved the {0}.", DefaultPublisherReference.Name)

     ' Create a Solution
     'Define a solution
     Dim solution As Solution =
      New Solution With {
       .UniqueName = "samplesolution",
       .FriendlyName = "Sample Solution",
       .PublisherId = New EntityReference(Publisher.EntityLogicalName, _crmSdkPublisherId),
       .Description = "This solution was created by the WorkWithSolutions sample code in the Microsoft Dynamics CRM SDK samples.",
       .Version = "1.0"
      }

     'Check whether it already exists
     Dim queryCheckForSampleSolution As QueryExpression =
      New QueryExpression With {
       .EntityName = solution.EntityLogicalName,
       .ColumnSet = New ColumnSet(),
       .Criteria = New FilterExpression()
      }
     queryCheckForSampleSolution.Criteria.AddCondition("uniquename",
                                                       ConditionOperator.Equal,
                                                       solution.UniqueName)

     'Create the solution if it does not already exist.
     Dim querySampleSolutionResults As EntityCollection =
      _serviceProxy.RetrieveMultiple(queryCheckForSampleSolution)
     Dim SampleSolutionResults As Solution = Nothing
     If querySampleSolutionResults.Entities.Count > 0 Then
      SampleSolutionResults = CType(querySampleSolutionResults.Entities(0), Solution)
      _solutionsSampleSolutionId = CType(SampleSolutionResults.SolutionId, Guid)
     End If
     If SampleSolutionResults Is Nothing Then
      _solutionsSampleSolutionId = _serviceProxy.Create(solution)
     End If

     ' Retrieve a solution
     Dim solutionUniqueName As String = "samplesolution"
     Dim querySampleSolution As QueryExpression =
      New QueryExpression With {
       .EntityName = solution.EntityLogicalName,
       .ColumnSet = New ColumnSet(New String() {"publisherid",
                                                "installedon",
                                                "version",
                                                "versionnumber",
                                                "friendlyname"}),
       .Criteria = New FilterExpression()
      }

     querySampleSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, solutionUniqueName)
     Dim SampleSolution As Solution =
      CType(_serviceProxy.RetrieveMultiple(querySampleSolution).Entities(0), Solution)

     ' Add an existing Solution Component
     'Add the Account entity to the solution
     Dim retrieveForAddAccountRequest As New RetrieveEntityRequest() With {
      .LogicalName = Account.EntityLogicalName
     }
     Dim retrieveForAddAccountResponse As RetrieveEntityResponse =
      CType(_serviceProxy.Execute(retrieveForAddAccountRequest), 
       RetrieveEntityResponse)
     Dim addReq As New AddSolutionComponentRequest() With {
      .ComponentType = componenttype.Entity,
      .ComponentId = CType(retrieveForAddAccountResponse.EntityMetadata.MetadataId, Guid),
      .SolutionUniqueName = solution.UniqueName
     }
     _serviceProxy.Execute(addReq)

     ' Remove a Solution Component
     'Remove the Account entity from the solution
     Dim retrieveForRemoveAccountRequest As New RetrieveEntityRequest() With {
      .LogicalName = Account.EntityLogicalName
     }
     Dim retrieveForRemoveAccountResponse As RetrieveEntityResponse =
      CType(_serviceProxy.Execute(retrieveForRemoveAccountRequest), RetrieveEntityResponse)

     Dim removeReq As New RemoveSolutionComponentRequest() With {
      .ComponentId = CType(retrieveForRemoveAccountResponse.EntityMetadata.MetadataId, Guid),
      .ComponentType = componenttype.Entity,
      .SolutionUniqueName = solution.UniqueName
     }
     _serviceProxy.Execute(removeReq)

     ' Export or package a solution
     'Export an a solution
     Dim outputDir As String = "C:\temp\"

     Dim exportSolutionRequest As New ExportSolutionRequest()
     exportSolutionRequest.Managed = False
     exportSolutionRequest.SolutionName = solution.UniqueName

     Dim exportSolutionResponse As ExportSolutionResponse =
      CType(_serviceProxy.Execute(exportSolutionRequest), ExportSolutionResponse)

     Dim exportXml() As Byte = exportSolutionResponse.ExportSolutionFile
     Dim filename As String = solution.UniqueName &amp; ".zip"
     File.WriteAllBytes(outputDir &amp; filename, exportXml)

     Console.WriteLine("Solution exported to {0}.", outputDir &amp; filename)

     ' Install or Upgrade a Solution                  

     Dim fileBytes() As Byte = File.ReadAllBytes(ManagedSolutionLocation)

     Dim impSolReq As New ImportSolutionRequest() With {
      .CustomizationFile = fileBytes
     }

     _serviceProxy.Execute(impSolReq)

     Console.WriteLine("Imported Solution from {0}", ManagedSolutionLocation)


     ' Monitor import success
     Dim fileBytesWithMonitoring() As Byte = File.ReadAllBytes(ManagedSolutionLocation)

     Dim impSolReqWithMonitoring As New ImportSolutionRequest() With {
      .CustomizationFile = fileBytes,
      .ImportJobId = Guid.NewGuid()
     }

     _serviceProxy.Execute(impSolReqWithMonitoring)
     Console.WriteLine("Imported Solution with Monitoring from {0}", ManagedSolutionLocation)

     Dim job As ImportJob =
      CType(_serviceProxy.Retrieve(ImportJob.EntityLogicalName,
                                   impSolReqWithMonitoring.ImportJobId,
                                   New ColumnSet(New String() {"data", "solutionname"})), 
                                  ImportJob)


     Dim doc As New System.Xml.XmlDocument()
     doc.LoadXml(job.Data)

     Dim ImportedSolutionName As String = doc.SelectSingleNode("//solutionManifest/UniqueName").InnerText
     Dim SolutionImportResult As String = doc.SelectSingleNode("//solutionManifest/result/@result").Value

     Console.WriteLine("Report from the ImportJob data")
     Console.WriteLine("Solution Unique name: {0}", ImportedSolutionName)
     Console.WriteLine("Solution Import Result: {0}", SolutionImportResult)
     Console.WriteLine("")

     'This code displays the results for Global Option sets installed as part of a solution.
     Dim optionSets As System.Xml.XmlNodeList = doc.SelectNodes("//optionSets/optionSet")
     For Each node As System.Xml.XmlNode In optionSets
      Dim OptionSetName As String = node.Attributes("LocalizedName").Value
      Dim result As String = node.FirstChild.Attributes("result").Value

      If result = "success" Then
       Console.WriteLine("{0} result: {1}", OptionSetName, result)
      Else
       Dim errorCode As String = node.FirstChild.Attributes("errorcode").Value
       Dim errorText As String = node.FirstChild.Attributes("errortext").Value

       Console.WriteLine("{0} result: {1} Code: {2} Description: {3}", OptionSetName, result, errorCode, errorText)
      End If
     Next node


     ' Delete a solution

     Dim queryImportedSolution As QueryExpression =
      New QueryExpression With {
       .EntityName = solution.EntityLogicalName,
       .ColumnSet = New ColumnSet(New String() {"solutionid", "friendlyname"}),
       .Criteria = New FilterExpression()
      }


     queryImportedSolution.Criteria.AddCondition("uniquename", ConditionOperator.Equal, ImportedSolutionName)

     Dim ImportedSolution As Solution =
      CType(_serviceProxy.RetrieveMultiple(queryImportedSolution).Entities(0), Solution)

     _serviceProxy.Delete(solution.EntityLogicalName, CType(ImportedSolution.SolutionId, Guid))

     Console.WriteLine("Deleted the {0} solution.", ImportedSolution.FriendlyName)




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
  ''' </summary>
  Public Sub CreateRequiredRecords()
   ' Create a managed solution for the Install or upgrade a solution sample

   Dim _tempPublisherId As New Guid()
   Dim _tempCustomizationPrefix As String = "new"
   Dim _tempSolutionsSampleSolutionId As New Guid()
   Dim _TempGlobalOptionSetName As String = "_TempSampleGlobalOptionSetName"
   Dim _publisherCreated As Boolean = False
   Dim _solutionCreated As Boolean = False


   'Define a new publisher
   Dim _crmSdkPublisher As Publisher =
    New Publisher With {
     .UniqueName = "sdksamples",
     .FriendlyName = "Microsoft CRM SDK Samples",
     .SupportingWebsiteUrl = "http://msdn.microsoft.com/dynamics/crm/default.aspx",
     .CustomizationPrefix = "sample",
     .EMailAddress = "someone@microsoft.com",
     .Description = "This publisher was created with samples from the Microsoft Dynamics CRM SDK"
    }

   'Does publisher already exist?
   Dim querySDKSamplePublisher As QueryExpression =
    New QueryExpression With {
     .EntityName = Publisher.EntityLogicalName,
     .ColumnSet = New ColumnSet("publisherid", "customizationprefix"),
     .Criteria = New FilterExpression()
    }

   querySDKSamplePublisher.Criteria.AddCondition("uniquename",
                                                 ConditionOperator.Equal,
                                                 _crmSdkPublisher.UniqueName)
   Dim querySDKSamplePublisherResults As EntityCollection =
    _serviceProxy.RetrieveMultiple(querySDKSamplePublisher)
   Dim SDKSamplePublisherResults As Publisher = Nothing

   'If it already exists, use it
   If querySDKSamplePublisherResults.Entities.Count > 0 Then
    SDKSamplePublisherResults = CType(querySDKSamplePublisherResults.Entities(0), Publisher)
    _tempPublisherId = CType(SDKSamplePublisherResults.PublisherId, Guid)
    _tempCustomizationPrefix = SDKSamplePublisherResults.CustomizationPrefix
   End If
   'If it doesn't exist, create it
   If SDKSamplePublisherResults Is Nothing Then
    _tempPublisherId = _serviceProxy.Create(_crmSdkPublisher)
    _tempCustomizationPrefix = _crmSdkPublisher.CustomizationPrefix
    _publisherCreated = True
   End If

   'Create a Solution
   'Define a solution
   Dim solution As Solution =
    New Solution With {
     .UniqueName = "samplesolutionforImport",
     .FriendlyName = "Sample Solution for Import",
     .PublisherId = New EntityReference(Publisher.EntityLogicalName, _tempPublisherId),
     .Description = "This solution was created by the WorkWithSolutions sample code in the Microsoft Dynamics CRM SDK samples.",
     .Version = "1.0"
    }

   'Check whether it already exists
   Dim querySampleSolution As QueryExpression =
    New QueryExpression With {
     .EntityName = solution.EntityLogicalName,
     .ColumnSet = New ColumnSet(),
     .Criteria = New FilterExpression()
    }
   querySampleSolution.Criteria.AddCondition("uniquename",
                                             ConditionOperator.Equal,
                                             solution.UniqueName)

   Dim querySampleSolutionResults As EntityCollection =
    _serviceProxy.RetrieveMultiple(querySampleSolution)
   Dim SampleSolutionResults As Solution = Nothing
   If querySampleSolutionResults.Entities.Count > 0 Then
    SampleSolutionResults = CType(querySampleSolutionResults.Entities(0), Solution)
    _tempSolutionsSampleSolutionId = CType(SampleSolutionResults.SolutionId, Guid)
   End If
   If SampleSolutionResults Is Nothing Then
    _tempSolutionsSampleSolutionId = _serviceProxy.Create(solution)
    _solutionCreated = True
   End If

   ' Add a solution Component
   Dim optionSetMetadata As New OptionSetMetadata() With {
    .Name = _tempCustomizationPrefix &amp; _TempGlobalOptionSetName,
    .DisplayName = New Label("Example Option Set", _languageCode),
    .IsGlobal = True, .OptionSetType = OptionSetType.Picklist}
   optionSetMetadata.Options.AddRange(
    {
     New OptionMetadata(New Label("Option A", _languageCode), Nothing),
     New OptionMetadata(New Label("Option B", _languageCode), Nothing)
    }
   )
   Dim createOptionSetRequest As CreateOptionSetRequest =
    New CreateOptionSetRequest With {
     .OptionSet = optionSetMetadata,
     .SolutionUniqueName = solution.UniqueName
    }


   _serviceProxy.Execute(createOptionSetRequest)

   'Export an a solution


   Dim exportSolutionRequest As New ExportSolutionRequest()
   exportSolutionRequest.Managed = True
   exportSolutionRequest.SolutionName = solution.UniqueName

   Dim exportSolutionResponse As ExportSolutionResponse =
    CType(_serviceProxy.Execute(exportSolutionRequest), ExportSolutionResponse)

   Dim exportXml() As Byte = exportSolutionResponse.ExportSolutionFile
   File.WriteAllBytes(ManagedSolutionLocation, exportXml)

   ' Delete the solution and the components so it can be installed.

   Dim delOptSetReq As DeleteOptionSetRequest =
    New DeleteOptionSetRequest With {
     .Name = (_tempCustomizationPrefix &amp; _TempGlobalOptionSetName).ToLower()
    }
   _serviceProxy.Execute(delOptSetReq)

   If _solutionCreated Then
    _serviceProxy.Delete(solution.EntityLogicalName, _tempSolutionsSampleSolutionId)
   End If

   If _publisherCreated Then
    _serviceProxy.Delete(Publisher.EntityLogicalName, _tempPublisherId)
   End If

   Console.WriteLine("Managed Solution created and copied to {0}", ManagedSolutionLocation)

  End Sub

  ''' <summary>
  ''' Deletes any entity records that were created for this sample.
  ''' <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
  ''' </summary>
  Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
   Dim deleteRecords As Boolean = True

   If prompt Then
    Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
    Dim answer As String = Console.ReadLine()

    deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
   End If

   If deleteRecords Then
    _serviceProxy.Delete(Solution.EntityLogicalName, _solutionsSampleSolutionId)
    _serviceProxy.Delete(Publisher.EntityLogicalName, _crmSdkPublisherId)
    ' Remove the managed solution created by the create required fields code.
    File.Delete(ManagedSolutionLocation)


    Console.WriteLine("Entity records have been deleted.")
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

    Dim app As New WorkWithSolutions()
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

' </snippetworkwithsolutions>