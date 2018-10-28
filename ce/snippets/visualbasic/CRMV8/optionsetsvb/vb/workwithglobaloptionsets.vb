' <snippetworkwithglobaloptionsets>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Metadata
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages


Namespace Microsoft.Crm.Sdk.Samples

 ''' <summary>
 ''' Create a global option set.
 ''' Set the options for that option set.
 ''' Create a new reference to that option set on an entity.
 ''' Update the option set's properties.
 ''' Check the global option set for dependencies.
 ''' Delete the option set.
 ''' </summary>
 Public Class WorkwithGlobalOptionSets
#Region "Class Level Members"

  ''' <summary>
  ''' Stores the organization service proxy.
  ''' </summary>
  Private _serviceProxy As OrganizationServiceProxy

  ' Specify which language code to use in the sample. If you are using a language
  ' other than US English, you will need to modify this value accordingly.
  ' See http://msdn.microsoft.com/library/0h88fahh.aspx
  Private Const _languageCode As Integer = 1033

  ' Specify the option set's schema name is used in many operations related to
  ' global option sets.
  Private Const _globalOptionSetName As String = "sample_exampleoptionset"

  ' Define the IDs needed for this sample.
  Private _optionSetId As Guid
  Private _insertedOptionValue As Integer

#End Region ' Class Level Members

#Region "How To Sample Code"
  ''' <summary>
  ''' Create a global option set.
  ''' Set the options for that option set.
  ''' Create a new reference to that option set on an entity.
  ''' Update the option set's properties.
  ''' Check the global option set for dependencies.
  ''' Delete the option set.
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

     '                    #Region "How to create global option set"
     ' Define the request object and pass to the service.
     Dim createOptionSetRequest As CreateOptionSetRequest = New CreateOptionSetRequest()
     Dim createOptionSetOptionSet As OptionSetMetadata = New OptionSetMetadata() With {
      .Name = _globalOptionSetName,
      .DisplayName = New Label("Example Option Set", _languageCode),
      .IsGlobal = True,
      .OptionSetType = OptionSetType.Picklist
     }
     createOptionSetOptionSet.Options.AddRange(
      {
       New OptionMetadata(New Label("Open", _languageCode), Nothing),
       New OptionMetadata(New Label("Suspended", _languageCode), Nothing),
       New OptionMetadata(New Label("Cancelled", _languageCode), Nothing),
       New OptionMetadata(New Label("Closed", _languageCode), Nothing)
      }
     )

     createOptionSetRequest.OptionSet = createOptionSetOptionSet
     ' Create a global option set (OptionSetMetadata).

     ' Execute the request.
     Dim optionsResp As CreateOptionSetResponse =
      CType(_serviceProxy.Execute(createOptionSetRequest), CreateOptionSetResponse)

     '                    #End Region ' How to create global option set

     ' Store the option set's id as it will be needed to find all the
     ' dependent components.
     _optionSetId = optionsResp.OptionSetId
     Console.WriteLine("The global option set has been created.")

     '                    #Region "How to create a picklist linked to the global option set"
     ' Create a Picklist linked to the option set.
     ' Specify which entity will own the picklist, and create it.
     Dim createRequest As CreateAttributeRequest = New CreateAttributeRequest With {
      .EntityName = Contact.EntityLogicalName,
      .Attribute = New PicklistAttributeMetadata With {
       .SchemaName = "sample_examplepicklist", .LogicalName = "sample_examplepicklist",
       .DisplayName = New Label("Example Picklist", _languageCode),
       .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
       .OptionSet = New OptionSetMetadata With {
        .IsGlobal = True,
        .Name = _globalOptionSetName
       }
      }
     }
     ' In order to relate the picklist to the global option set, be sure
     ' to specify the two attributes below appropriately.
     ' Failing to do so will lead to errors.

     _serviceProxy.Execute(createRequest)
     Console.WriteLine("Referring picklist attribute created.")
     '                    #End Region ' How to create a picklist linked to the global option set

     '                    #Region "How to update a global option set"
     ' Use UpdateOptionSetRequest to update the basic information of an option
     ' set. Updating option set values requires different messages (see below).
     Dim updateOptionSetRequest As UpdateOptionSetRequest = New UpdateOptionSetRequest With {
      .OptionSet = New OptionSetMetadata With {
       .DisplayName = New Label("Updated Option Set", _languageCode),
       .Name = _globalOptionSetName,
       .IsGlobal = True
      }
     }

     _serviceProxy.Execute(updateOptionSetRequest)

     'Publish the OptionSet
     Dim pxReq1 As PublishXmlRequest = New PublishXmlRequest With {
      .ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName)
     }
     _serviceProxy.Execute(pxReq1)
     Console.WriteLine("Option Set display name changed.")
     '                    #End Region ' How to update a global option set properties

     '                    #Region "How to insert a new option item in a global option set"
     ' Use InsertOptionValueRequest to insert a new option into a 
     ' global option set.
     Dim insertOptionValueRequest As InsertOptionValueRequest = New InsertOptionValueRequest With {
      .OptionSetName = _globalOptionSetName,
      .Label = New Label("New Picklist Label", _languageCode)
     }

     ' Execute the request and store the newly inserted option value 
     ' for cleanup, used in the later part of this sample.
     _insertedOptionValue =
      (CType(_serviceProxy.Execute(insertOptionValueRequest), InsertOptionValueResponse)).NewOptionValue

     'Publish the OptionSet
     Dim pxReq2 As PublishXmlRequest = New PublishXmlRequest With {
      .ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName)
     }
     _serviceProxy.Execute(pxReq2)
     Console.WriteLine("Created {0} with the value of {1}.",
                       insertOptionValueRequest.Label.LocalizedLabels(0).Label,
                       _insertedOptionValue)
     '#End Region ' How to insert a new option item in a global option set

     '#Region "How to retrieve a global option set by it's name"
     ' Use the RetrieveOptionSetRequest message to retrieve  
     ' a global option set by it's name.
     Dim retrieveOptionSetRequest As RetrieveOptionSetRequest = New RetrieveOptionSetRequest With {
      .Name = _globalOptionSetName
     }

     ' Execute the request.
     Dim retrieveOptionSetResponse As RetrieveOptionSetResponse =
      CType(_serviceProxy.Execute(retrieveOptionSetRequest), RetrieveOptionSetResponse)

     Console.WriteLine("Retrieved {0}.", retrieveOptionSetRequest.Name)

     ' Access the retrieved OptionSetMetadata.
     Dim retrievedOptionSetMetadata As OptionSetMetadata =
      CType(retrieveOptionSetResponse.OptionSetMetadata, OptionSetMetadata)

     ' Get the current options list for the retrieved attribute.
     Dim optionList() As OptionMetadata = retrievedOptionSetMetadata.Options.ToArray()
     '                    #End Region ' How to retrieve a global option set by it's name

     '                    #Region "How to update an option item in a picklist"
     ' In order to change labels on option set values (or delete) option set
     ' values, you must use UpdateOptionValueRequest 
     ' (or DeleteOptionValueRequest).
     Dim updateOptionValueRequest As UpdateOptionValueRequest =
      New UpdateOptionValueRequest With {
       .OptionSetName = _globalOptionSetName,
       .Value = optionList(1).Value.Value,
       .Label = New Label("Updated Option 1", _languageCode)
      }
     ' Update the second option value.

     _serviceProxy.Execute(updateOptionValueRequest)

     'Publish the OptionSet
     Dim pxReq3 As PublishXmlRequest =
      New PublishXmlRequest With {
       .ParameterXml =
       String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>",
                     _globalOptionSetName)
      }
     _serviceProxy.Execute(pxReq3)



     Console.WriteLine("Option Set option label changed.")
     '#End Region ' How to update an option item in a picklist

     '#Region "How to change the order of options of a global option set"
     ' Change the order of the original option's list.
     ' Use the OrderBy (OrderByDescending) linq function to sort options in  
     ' ascending (descending) order according to label text.
     ' For ascending order use this:
     Dim updateOptionList = optionList.OrderBy(Function(x) x.Label.LocalizedLabels(0).Label).ToList()

     ' For descending order use this:
     ' var updateOptionList =
     '      optionList.OrderByDescending(
     '      x => x.Label.LocalizedLabels[0].Label).ToList();

     ' Create the request.
     Dim orderOptionRequest As OrderOptionRequest =
      New OrderOptionRequest With {
       .OptionSetName = _globalOptionSetName,
       .Values = updateOptionList.Select(Function(x) x.Value.Value).ToArray()
      }
     ' Set the properties for the request.
     ' Set the changed order using Select linq function 
     ' to get only values in an array from the changed option list.

     ' Execute the request
     _serviceProxy.Execute(orderOptionRequest)

     'Publish the OptionSet
     Dim pxReq4 As PublishXmlRequest =
      New PublishXmlRequest With {
       .ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>",
                                     _globalOptionSetName)
      }
     _serviceProxy.Execute(pxReq4)
     Console.WriteLine("Option Set option order changed")
     '                    #End Region ' How to change the order of options of a global option set

     '                    #Region "How to retrieve all global option sets"
     ' Use RetrieveAllOptionSetsRequest to retrieve all global option sets.
     ' Create the request.
     Dim retrieveAllOptionSetsRequest As New RetrieveAllOptionSetsRequest()

     ' Execute the request
     Dim retrieveAllOptionSetsResponse As RetrieveAllOptionSetsResponse =
      CType(_serviceProxy.Execute(retrieveAllOptionSetsRequest), RetrieveAllOptionSetsResponse)

     ' Now you can use RetrieveAllOptionSetsResponse.OptionSetMetadata property to 
     ' work with all retrieved option sets.
     If retrieveAllOptionSetsResponse.OptionSetMetadata.Count() > 0 Then
      Console.WriteLine("All the global option sets retrieved as below:")
      Dim count As Integer = 1
      For Each optionSetMetadata As OptionSetMetadataBase In retrieveAllOptionSetsResponse.OptionSetMetadata
                            Console.WriteLine("{0} {1}",
                                              count,
                                              If(optionSetMetadata.DisplayName.LocalizedLabels.Count > 0,
                                                 optionSetMetadata.DisplayName.LocalizedLabels(0).Label,
                                                 String.Empty))
       count += 1
      Next optionSetMetadata
     End If
     '                    #End Region ' How to retrieve all global option sets



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
  ''' <param name="prompt">Indicates whether to prompt the user to 
  ''' delete the records created in this sample.</param>
  ''' </summary>
  Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
   Dim deleteRecords As Boolean = True

   If prompt Then
    Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
    Dim answer As String = Console.ReadLine()

    deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
   End If

   If deleteRecords Then
    '                #Region "How to delete a option from a option set"
    ' Use the DeleteOptionValueRequest message 
    ' to remove the newly inserted label.
    Dim deleteOptionValueRequest As DeleteOptionValueRequest =
     New DeleteOptionValueRequest With {
      .OptionSetName = _globalOptionSetName,
      .Value = _insertedOptionValue
     }

    ' Execute the request.
    _serviceProxy.Execute(deleteOptionValueRequest)

    Console.WriteLine("Option Set option removed.")
    '                #End Region ' How to delete a option from a option set

    '                #Region "How to delete attribute"
    ' Create the request to see which components have a dependency on the
    ' global option set.
    Dim dependencyRequest As RetrieveDependentComponentsRequest =
     New RetrieveDependentComponentsRequest With {
      .ObjectId = _optionSetId,
      .ComponentType = componenttype.OptionSet
     }

    Dim dependencyResponse As RetrieveDependentComponentsResponse =
     CType(_serviceProxy.Execute(dependencyRequest), RetrieveDependentComponentsResponse)

    ' Here you would check the dependencyResponse.EntityCollection property
    ' and act as appropriate. However, we know there is exactly one 
    ' dependency so this example deals with it directly and deletes 
    ' the previously created attribute.
    Dim deleteAttributeRequest As DeleteAttributeRequest =
     New DeleteAttributeRequest With {
      .EntityLogicalName = Contact.EntityLogicalName,
      .LogicalName = "sample_examplepicklist"
     }

    _serviceProxy.Execute(deleteAttributeRequest)

    Console.WriteLine("Referring attribute deleted.")
    '#End Region ' How to delete attribute

    '#Region "How to delete global option set"

    ' Finally, delete the global option set. Attempting this before deleting
    ' the picklist above will result in an exception being thrown.
    Dim deleteRequest As DeleteOptionSetRequest =
     New DeleteOptionSetRequest With {
      .Name = _globalOptionSetName
     }

    _serviceProxy.Execute(deleteRequest)
    Console.WriteLine("Global Option Set deleted")
    '#End Region ' How to delete global option set
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

    Dim app As New WorkwithGlobalOptionSets()
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

' </snippetworkwithglobaloptionsets>