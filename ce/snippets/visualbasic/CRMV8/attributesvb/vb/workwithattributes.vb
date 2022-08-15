' <snippetworkwithattributes>


Imports System.ServiceModel
Imports System.ServiceModel.Description

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
 ''' This sample shows how to create, retrieve, update and delete attribute.
 ''' </summary>
 Public Class WorkWithAttributes
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
  ''' Create and configure the organization service proxy.
  ''' Create few types of attributes.
  ''' Insert status in the existing status list.
  ''' Retrieve attribute.
  ''' Update attribute.
  ''' Update existing state value.
  ''' Optionally delete/revert any attributes 
  ''' that were created/changed for this sample.
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

     '                    #Region "How to create attributes"
     ' Create storage for new attributes being created
     addedAttributes = New List(Of AttributeMetadata)()

     ' Create a boolean attribute
     Dim boolAttribute As BooleanAttributeMetadata = New BooleanAttributeMetadata With {
      .SchemaName = "new_boolean",
      .DisplayName = New Label("Sample Boolean", _languageCode),
      .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
      .Description = New Label("Boolean Attribute", _languageCode),
      .OptionSet = New BooleanOptionSetMetadata(
       New OptionMetadata(
        New Label("True", _languageCode), 1),
        New OptionMetadata(
        New Label("False", _languageCode), 0)
       )
     }
     ' Set base properties
     ' Set extended properties

     ' Add to list
     addedAttributes.Add(boolAttribute)

     ' Create a date time attribute
     Dim dtAttribute As DateTimeAttributeMetadata = New DateTimeAttributeMetadata With {
      .SchemaName = "new_datetime",
      .DisplayName = New Label("Sample DateTime", _languageCode),
      .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
      .Description = New Label("DateTime Attribute", _languageCode),
      .Format = DateTimeFormat.DateOnly,
      .ImeMode = ImeMode.Disabled}
     ' Set base properties
     ' Set extended properties

     ' Add to list
     addedAttributes.Add(dtAttribute)

     ' Create a decimal attribute    
     Dim decimalAttribute As DecimalAttributeMetadata = New DecimalAttributeMetadata With {
      .SchemaName = "new_decimal",
      .DisplayName = New Label("Sample Decimal", _languageCode),
      .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
      .Description = New Label("Decimal Attribute", _languageCode),
      .MaxValue = 100,
      .MinValue = 0,
      .Precision = 1}
     ' Set base properties
     ' Set extended properties

     ' Add to list
     addedAttributes.Add(decimalAttribute)

     ' Create a integer attribute    
     Dim integerAttribute As IntegerAttributeMetadata = New IntegerAttributeMetadata With {
      .SchemaName = "new_integer",
      .DisplayName = New Label("Sample Integer", _languageCode),
      .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
      .Description = New Label("Integer Attribute", _languageCode),
      .Format = IntegerFormat.None,
      .MaxValue = 100,
      .MinValue = 0}
     ' Set base properties
     ' Set extended properties

     ' Add to list
     addedAttributes.Add(integerAttribute)

     ' Create a memo attribute 
     Dim memoAttribute As MemoAttributeMetadata = New MemoAttributeMetadata With {
      .SchemaName = "new_memo",
      .DisplayName = New Label("Sample Memo", _languageCode),
      .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
      .Description = New Label("Memo Attribute", _languageCode),
      .Format = StringFormat.TextArea,
      .ImeMode = ImeMode.Disabled,
      .MaxLength = 500}
     ' Set base properties
     ' Set extended properties

     ' Add to list
     addedAttributes.Add(memoAttribute)

     ' Create a money attribute    
     Dim moneyAttribute As MoneyAttributeMetadata = New MoneyAttributeMetadata With {
      .SchemaName = "new_money",
      .DisplayName = New Label("Money Picklist", _languageCode),
      .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
      .Description = New Label("Money Attribue", _languageCode),
      .MaxValue = 1000.0,
      .MinValue = 0.0,
      .Precision = 1,
      .PrecisionSource = 1,
      .ImeMode = ImeMode.Disabled}
     ' Set base properties
     ' Set extended properties

     ' Add to list
     addedAttributes.Add(moneyAttribute)

     ' Create a picklist attribute    
     Dim pickListAttribute As PicklistAttributeMetadata = New PicklistAttributeMetadata With {
      .SchemaName = "new_picklist",
      .DisplayName = New Label("Sample Picklist", _languageCode),
      .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
      .Description = New Label("Picklist Attribute", _languageCode)}
     Dim pickListOptionSetMetadata As OptionSetMetadata = New OptionSetMetadata() With {
      .IsGlobal = False,
      .OptionSetType = OptionSetType.Picklist}
     pickListOptionSetMetadata.Options.Add(New OptionMetadata(New Label("Created", _languageCode), Nothing))
     pickListOptionSetMetadata.Options.Add(New OptionMetadata(New Label("Updated", _languageCode), Nothing))
     pickListOptionSetMetadata.Options.Add(New OptionMetadata(New Label("Deleted", _languageCode), Nothing))
     pickListAttribute.OptionSet = pickListOptionSetMetadata
     ' Set base properties
     ' Set extended properties
     ' Build local picklist options

     ' Add to list
     addedAttributes.Add(pickListAttribute)

     ' Create a string attribute
     Dim stringAttribute As StringAttributeMetadata = New StringAttributeMetadata With {
      .SchemaName = "new_string",
      .DisplayName = New Label("Sample String", _languageCode),
      .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
      .Description = New Label("String Attribute", _languageCode),
      .MaxLength = 100}
     ' Set base properties
     ' Set extended properties

     ' Add to list
     addedAttributes.Add(stringAttribute)

     ' NOTE: LookupAttributeMetadata cannot be created outside the context of a relationship.
     ' Refer to the WorkWithRelationships.cs reference SDK sample for an example of this attribute type.

     ' NOTE: StateAttributeMetadata and StatusAttributeMetadata cannot be created via the SDK.

     For Each anAttribute As AttributeMetadata In addedAttributes
      ' Create the request.
      Dim createAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With {
       .EntityName = Contact.EntityLogicalName,
       .Attribute = anAttribute}

      ' Execute the request.
      _serviceProxy.Execute(createAttributeRequest)

      Console.WriteLine("Created the attribute {0}.", anAttribute.SchemaName)
     Next anAttribute
     '                    #End Region ' How to create attributes

     '                    #Region "How to insert status"
     ' Use InsertStatusValueRequest message to insert a new status 
     ' in an existing status attribute. 
     ' Create the request.
     Dim insertStatusValueRequest As InsertStatusValueRequest = New InsertStatusValueRequest With {
      .AttributeLogicalName = "statuscode",
      .EntityLogicalName = Contact.EntityLogicalName,
      .Label = New Label("Dormant", _languageCode),
      .StateCode = 0}

     ' Execute the request and store newly inserted value 
     ' for cleanup, used later part of this sample. 
     _insertedStatusValue = (CType(_serviceProxy.Execute(insertStatusValueRequest), InsertStatusValueResponse)).NewOptionValue

     Console.WriteLine("Created {0} with the value of {1}.", insertStatusValueRequest.Label.LocalizedLabels(0).Label, _insertedStatusValue)
     '                    #End Region ' How to insert status

     '                    #Region "How to retrieve attribute"
     ' Create the request
     Dim attributeRequest As RetrieveAttributeRequest = New RetrieveAttributeRequest With {
      .EntityLogicalName = Contact.EntityLogicalName,
      .LogicalName = "new_string",
      .RetrieveAsIfPublished = True}

     ' Execute the request
     Dim attributeResponse As RetrieveAttributeResponse = CType(_serviceProxy.Execute(attributeRequest), RetrieveAttributeResponse)

     Console.WriteLine("Retrieved the attribute {0}.", attributeResponse.AttributeMetadata.SchemaName)
     '#End Region ' How to retrieve attribute

     '#Region "How to update attribute"
     ' Modify the retrieved attribute
     Dim retrievedAttributeMetadata As AttributeMetadata = attributeResponse.AttributeMetadata
     retrievedAttributeMetadata.DisplayName = New Label("Update String Attribute", _languageCode)

     ' Update an attribute retrieved via RetrieveAttributeRequest
     Dim updateRequest As UpdateAttributeRequest = New UpdateAttributeRequest With {
      .Attribute = retrievedAttributeMetadata,
      .EntityName = Contact.EntityLogicalName,
      .MergeLabels = False}

     ' Execute the request
     _serviceProxy.Execute(updateRequest)

     Console.WriteLine("Updated the attribute {0}.", retrievedAttributeMetadata.SchemaName)
     '                    #End Region ' How to update attribute

     '                    #Region "How to update state value"
     ' Modify the state value label from Active to Open.
     ' Create the request.
     Dim updateStateValue As UpdateStateValueRequest = New UpdateStateValueRequest With {
      .AttributeLogicalName = "statecode",
      .EntityLogicalName = Contact.EntityLogicalName,
      .Value = 1,
      .Label = New Label("Open", _languageCode)}

     ' Execute the request.
     _serviceProxy.Execute(updateStateValue)

     Console.WriteLine("Updated {0} state attribute of {1} entity from 'Active' to '{2}'.",
                       updateStateValue.AttributeLogicalName,
                       updateStateValue.EntityLogicalName,
                       updateStateValue.Label.LocalizedLabels(0).Label)
     '                    #End Region ' How to update state value

     '                    #Region "How to insert a new option item in a local option set"
     ' Create a request.
     Dim insertOptionValueRequest As InsertOptionValueRequest = New InsertOptionValueRequest With {
      .AttributeLogicalName = "new_picklist",
      .EntityLogicalName = Contact.EntityLogicalName,
      .Label = New Label("New Picklist Label", _languageCode)}

     ' Execute the request.
     Dim insertOptionValue As Integer = (CType(_serviceProxy.Execute(insertOptionValueRequest), InsertOptionValueResponse)).NewOptionValue

     Console.WriteLine("Created {0} with the value of {1}.", insertOptionValueRequest.Label.LocalizedLabels(0).Label, insertOptionValue)
     '#End Region ' How to insert a new option item in a local option set

     '#Region "How to change the order of options of a local option set"
     ' Use the RetrieveAttributeRequest message to retrieve  
     ' a attribute by it's logical name.
     Dim retrieveAttributeRequest As RetrieveAttributeRequest = New RetrieveAttributeRequest With {
      .EntityLogicalName = Contact.EntityLogicalName,
      .LogicalName = "new_picklist",
      .RetrieveAsIfPublished = True}

     ' Execute the request.
     Dim retrieveAttributeResponse As RetrieveAttributeResponse = CType(_serviceProxy.Execute(retrieveAttributeRequest), RetrieveAttributeResponse)

     ' Access the retrieved attribute.
     Dim retrievedPicklistAttributeMetadata As PicklistAttributeMetadata = CType(retrieveAttributeResponse.AttributeMetadata, PicklistAttributeMetadata)

     ' Get the current options list for the retrieved attribute.
     Dim optionList() As OptionMetadata = retrievedPicklistAttributeMetadata.OptionSet.Options.ToArray()

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
     Dim orderOptionRequest As OrderOptionRequest = New OrderOptionRequest With {
      .AttributeLogicalName = "new_picklist",
      .EntityLogicalName = Contact.EntityLogicalName,
      .Values = updateOptionList.Select(Function(x) x.Value.Value).ToArray()}
     ' Set the properties for the request.
     ' Set the changed order using Select linq function 
     ' to get only values in an array from the changed option list.

     ' Execute the request
     _serviceProxy.Execute(orderOptionRequest)

     Console.WriteLine("Option Set option order changed")
     '#End Region ' How to change the order of options of a global option set

     ' NOTE: All customizations must be published before they can be used.
     _serviceProxy.Execute(New PublishAllXmlRequest())
     Console.WriteLine("Published all customizations.")

     DeleteRequiredRecords(promptForDelete)
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
    '                #Region "How to delete attribute"
    ' Delete all attributes created for this sample.
    For Each anAttribute As AttributeMetadata In addedAttributes
     ' Create the request object
     Dim deleteAttribute As DeleteAttributeRequest = New DeleteAttributeRequest With {
      .EntityLogicalName = Contact.EntityLogicalName,
      .LogicalName = anAttribute.SchemaName}
     ' Set the request properties 
     ' Execute the request
     _serviceProxy.Execute(deleteAttribute)
    Next anAttribute
    '#End Region ' How to delete attribute

    '#Region "How to remove inserted status value"
    ' Delete the newly inserted status value.
    ' Create the request object
    Dim deleteRequest As DeleteOptionValueRequest = New DeleteOptionValueRequest With {
     .AttributeLogicalName = "statuscode",
     .EntityLogicalName = Contact.EntityLogicalName,
     .Value = _insertedStatusValue}

    ' Execute the request
    _serviceProxy.Execute(deleteRequest)

    Console.WriteLine("Deleted all attributes created for this sample.")
    '#End Region ' How to remove inserted status value

    '#Region "Revert the changed state value"
    ' Revert the state value label from Open to Active.
    ' Create the request.
    Dim revertStateValue As UpdateStateValueRequest = New UpdateStateValueRequest With {
     .AttributeLogicalName = "statecode",
     .EntityLogicalName = Contact.EntityLogicalName,
     .Value = 1, .Label = New Label("Active", _languageCode)}

    ' Execute the request.
    _serviceProxy.Execute(revertStateValue)

    ' NOTE: All customizations must be published before they can be used.
    _serviceProxy.Execute(New PublishAllXmlRequest())

    Console.WriteLine("Reverted {0} state attribute of {1} entity from 'Open' to '{2}'.",
                      revertStateValue.AttributeLogicalName,
                      revertStateValue.EntityLogicalName,
                      revertStateValue.Label.LocalizedLabels(0).Label)
    '#End Region ' Revert the changed state value
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

    Dim app As New WorkWithAttributes()
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

' </snippetworkwithattributes>