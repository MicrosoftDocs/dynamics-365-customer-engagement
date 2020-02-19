' <snippetgetsolutiondependencies>


Imports System.ServiceModel
Imports System.ServiceModel.Description

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
    ''' Demonstrates how to detect any dependencies prior to deleting a 
    ''' solution component.
    ''' </summary>
    Public Class GetSolutionDependencies
#Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        Private _publisherId As Guid
        Private Const _primarySolutionName As String = "PrimarySolution"
        Private _primarySolutionId As Guid
        Private _secondarySolutionId As Guid
        Private Const _prefix As String = "sample"
        Private Const _globalOptionSetName As String = _prefix &amp; "_exampleoptionset"
        Private _globalOptionSetId? As Guid
        Private Const _picklistName As String = _prefix &amp; "_examplepicklist"


        ' Specify which language code to use in the sample. If you are using a language
        ' other than US English, you will need to modify this value accordingly.
        ' See https://msdn.microsoft.com/library/0h88fahh.aspx
        Private Const _languageCode As Integer = 1033


#End Region ' Class Level Members

#Region "How To Sample Code"
        ''' <summary>
        ''' Shows how to detect dependencies that may cause a managed solution to become
        ''' un-deletable.
        ''' 
        ''' Get all solution components of a solution
        ''' For each solution component, list the dependencies upon that component.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptForDelete">When True, the user will be prompted to delete all
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

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()

                    ' Grab all Solution Components for a solution.
                    Dim componentQuery As QueryByAttribute =
                     New QueryByAttribute With {
                      .EntityName = SolutionComponent.EntityLogicalName,
                      .ColumnSet = New ColumnSet("componenttype", "objectid",
                                                 "solutioncomponentid", "solutionid")
                     }
                    componentQuery.Attributes.Add("solutionid")
                    componentQuery.Values.Add(_primarySolutionId)
                    ' In your code, this value would probably come from another query.

                    Dim allComponents As IEnumerable(Of SolutionComponent) =
                     _serviceProxy.RetrieveMultiple(componentQuery).Entities.Cast(Of SolutionComponent)()

                    For Each component As SolutionComponent In allComponents
                        ' For each solution component, retrieve all dependencies for the component.
                        Dim dependentComponentsRequest As RetrieveDependentComponentsRequest =
                         New RetrieveDependentComponentsRequest With {
                          .ComponentType = component.ComponentType.Value,
                          .ObjectId = component.ObjectId.Value
                         }
                        Dim dependentComponentsResponse As RetrieveDependentComponentsResponse =
                         CType(_serviceProxy.Execute(dependentComponentsRequest), 
                             RetrieveDependentComponentsResponse)

                        ' If there are no dependent components, we can ignore this component.
                        If dependentComponentsResponse.EntityCollection.Entities.Any() = False Then
                            Continue For
                        End If

                        ' If there are dependencies upon this solution component, and the solution
                        ' itself is managed, then you will be unable to delete the solution.
                        Console.WriteLine("Found {0} dependencies for Component {1} of type {2}",
                                          dependentComponentsResponse.EntityCollection.Entities.Count,
                                          component.ObjectId.Value,
                                          component.ComponentType.Value)
                        'A more complete report requires more code
                        For Each d As Dependency In dependentComponentsResponse.EntityCollection.Entities
                            DependencyReport(d)
                        Next d
                    Next component

                    'Find out if any dependencies on a  specific global option set would prevent it from being deleted
                    ' Use the RetrieveOptionSetRequest message to retrieve  
                    ' a global option set by it's name.
                    Dim retrieveOptionSetRequest_Renamed As RetrieveOptionSetRequest =
                        New RetrieveOptionSetRequest With {.Name = _globalOptionSetName}

                    ' Execute the request.
                    Dim retrieveOptionSetResponse_Renamed As RetrieveOptionSetResponse =
                        CType(_serviceProxy.Execute(retrieveOptionSetRequest_Renamed), RetrieveOptionSetResponse)
                    _globalOptionSetId = retrieveOptionSetResponse_Renamed.OptionSetMetadata.MetadataId
                    If _globalOptionSetId IsNot Nothing Then
                        'Use the global OptionSet MetadataId with the appropriate componenttype
                        ' to call RetrieveDependenciesForDeleteRequest
                        Dim retrieveDependenciesForDeleteRequest_Renamed As RetrieveDependenciesForDeleteRequest =
                            New RetrieveDependenciesForDeleteRequest With
                            {
                                .ComponentType = CInt(Fix(componenttype.OptionSet)),
                                .ObjectId = CType(_globalOptionSetId, Guid)
                            }

                        Dim retrieveDependenciesForDeleteResponse_Renamed As RetrieveDependenciesForDeleteResponse =
                            CType(_serviceProxy.Execute(retrieveDependenciesForDeleteRequest_Renamed), 
                                RetrieveDependenciesForDeleteResponse)
                        Console.WriteLine("")
                        For Each d As Dependency In retrieveDependenciesForDeleteResponse_Renamed _
                            .EntityCollection.Entities

                            If d.DependentComponentType.Value = 2 Then 'Just testing for Attributes
                                Dim attributeLabel As String = ""
                                Dim retrieveAttributeRequest_Renamed As RetrieveAttributeRequest =
                                    New RetrieveAttributeRequest With
                                    {
                                        .MetadataId = CType(d.DependentComponentObjectId, Guid)
                                    }
                                Dim retrieveAttributeResponse_Renamed As RetrieveAttributeResponse =
                                    CType(_serviceProxy.Execute(retrieveAttributeRequest_Renamed), 
                                        RetrieveAttributeResponse)

                                Dim attmet As AttributeMetadata = retrieveAttributeResponse_Renamed.AttributeMetadata

                                attributeLabel = attmet.DisplayName.UserLocalizedLabel.Label

                                Console.WriteLine("An {0} named {1} will prevent deleting the {2} global option set.",
                                                  CType(d.DependentComponentType.Value, componenttype),
                                                  attributeLabel, _globalOptionSetName)
                            End If
                        Next d
                    End If


                    DeleteRequiredRecords(promptForDelete)
                End Using

                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' Shows how to get a more friendly message based on information within the dependency
        ''' <param name="dependency">A Dependency returned from the RetrieveDependentComponents message</param>
        ''' </summary> 
        Public Sub DependencyReport(ByVal dependency As Dependency)
            'These strings represent parameters for the message.
            Dim dependentComponentName As String = ""
            Dim dependentComponentTypeName As String = ""
            Dim dependentComponentSolutionName As String = ""
            Dim requiredComponentName As String = ""
            Dim requiredComponentTypeName As String = ""
            Dim requiredComponentSolutionName As String = ""

            'The ComponentType global Option Set contains options for each possible component.
            Dim componentTypeRequest As RetrieveOptionSetRequest =
             New RetrieveOptionSetRequest With {
              .Name = "componenttype"
             }

            Dim componentTypeResponse As RetrieveOptionSetResponse =
             CType(_serviceProxy.Execute(componentTypeRequest), RetrieveOptionSetResponse)
            Dim componentTypeOptionSet As OptionSetMetadata =
             CType(componentTypeResponse.OptionSetMetadata, OptionSetMetadata)
            ' Match the Component type with the option value and get the label value of the option.
            For Each opt As OptionMetadata In componentTypeOptionSet.Options
                If dependency.DependentComponentType.Value = opt.Value Then
                    dependentComponentTypeName = opt.Label.UserLocalizedLabel.Label
                End If
                If dependency.RequiredComponentType.Value = opt.Value Then
                    requiredComponentTypeName = opt.Label.UserLocalizedLabel.Label
                End If
            Next opt
            'The name or display name of the compoent is retrieved in different ways depending on the component type
            dependentComponentName = getComponentName(dependency.DependentComponentType.Value,
                                                      CType(dependency.DependentComponentObjectId, 
                                                       Guid))
            requiredComponentName = getComponentName(dependency.RequiredComponentType.Value,
                                                     CType(dependency.RequiredComponentObjectId, 
                                                      Guid))

            ' Retrieve the friendly name for the dependent solution.
            Dim dependentSolution As Solution =
             CType(_serviceProxy.Retrieve(Solution.EntityLogicalName,
                                          CType(dependency.DependentComponentBaseSolutionId, Guid),
                                          New ColumnSet("friendlyname")), 
                                         Solution)
            dependentComponentSolutionName = dependentSolution.FriendlyName

            ' Retrieve the friendly name for the required solution.
            Dim requiredSolution As Solution =
             CType(_serviceProxy.Retrieve(Solution.EntityLogicalName,
                                          CType(dependency.RequiredComponentBaseSolutionId, 
                                           Guid),
                                          New ColumnSet("friendlyname")), 
                                         Solution)
            requiredComponentSolutionName = requiredSolution.FriendlyName

            'Display the message
            Console.WriteLine("The {0} {1} in the {2} depends on the {3} {4} in the {5} solution.",
                              dependentComponentName,
                              dependentComponentTypeName,
                              dependentComponentSolutionName,
                              requiredComponentName,
                              requiredComponentTypeName,
                              requiredComponentSolutionName)
        End Sub

        ' The name or display name of the component depends on the type of component.
        Public Function getComponentName(ByVal Type As Integer, ByVal ComponentId As Guid) As String
            Dim name As String = ""

            Select Case Type
                ' A separate method is required for each type of component
                Case componenttype.Attribute
                    name = getAttributeInformation(ComponentId)
                Case componenttype.OptionSet
                    name = getGlobalOptionSetName(ComponentId)
                Case Else
                    name = "not implemented"
            End Select

            Return name

        End Function

        ' Retrieve the display name and parent entity information about an attribute solution component.
        Public Function getAttributeInformation(ByVal id As Guid) As String
            Dim attributeInformation As String = ""
            Dim req As RetrieveAttributeRequest = New RetrieveAttributeRequest With {.MetadataId = id}
            Dim resp As RetrieveAttributeResponse = CType(_serviceProxy.Execute(req), RetrieveAttributeResponse)

            Dim attmet As AttributeMetadata = resp.AttributeMetadata

            attributeInformation = attmet.EntityLogicalName &amp; " : " &amp; attmet.DisplayName.UserLocalizedLabel.Label


            Return attributeInformation
        End Function
        'Retrieve the name of a global Option set
        Public Function getGlobalOptionSetName(ByVal id As Guid) As String
            Dim name As String = ""
            Dim req As RetrieveOptionSetRequest = New RetrieveOptionSetRequest With {.MetadataId = id}
            Dim resp As RetrieveOptionSetResponse = CType(_serviceProxy.Execute(req), RetrieveOptionSetResponse)
            Dim os As OptionSetMetadataBase = CType(resp.OptionSetMetadata, OptionSetMetadataBase)
            name = os.DisplayName.UserLocalizedLabel.Label
            Return name
        End Function

        ''' <summary>
        ''' This method creates any entity records that this sample requires.
        ''' Create a publisher
        ''' Create a new solution, "Primary"
        ''' Create a Global Option Set in solution "Primary"
        ''' Export the "Primary" solution, setting it to Protected
        ''' Delete the option set and solution
        ''' Import the "Primary" solution, creating a managed solution in CRM.
        ''' Create a new solution, "Secondary"
        ''' Create an attribute in "Secondary" that references the Global Option Set
        ''' </summary>
        Public Sub CreateRequiredRecords()
            'Create the publisher that will "own" the two solutions
            Dim publisher As Publisher =
             New Publisher With {
              .UniqueName = "examplepublisher",
              .FriendlyName = "An Example Publisher",
              .Description = "This is an example publisher",
              .CustomizationPrefix = _prefix
             }
            _publisherId = _serviceProxy.Create(publisher)
            'Create the primary solution - note that we are not creating it 
            'as a managed solution as that can only be done when exporting the solution.
            Dim primarySolution As Solution =
             New Solution With {
              .Version = "1.0",
              .FriendlyName = "Primary Solution",
              .PublisherId =
              New EntityReference(publisher.EntityLogicalName, _publisherId),
              .UniqueName = _primarySolutionName
             }
            _primarySolutionId = _serviceProxy.Create(primarySolution)
            'Now, create the Global Option Set and associate it to the solution.
            Dim optionSetMetadata As New OptionSetMetadata() With {
             .Name = _globalOptionSetName,
             .DisplayName = New Label("Example Option Set", _languageCode),
             .IsGlobal = True,
             .OptionSetType = OptionSetType.Picklist
            }
            optionSetMetadata.Options.AddRange(
             {
              New OptionMetadata(New Label("Option 1", _languageCode), 1),
              New OptionMetadata(New Label("Option 2", _languageCode), 2)
             }
            )
            Dim createOptionSetRequest As CreateOptionSetRequest =
             New CreateOptionSetRequest With {
              .OptionSet = optionSetMetadata
             }

            createOptionSetRequest.SolutionUniqueName = _primarySolutionName
            _serviceProxy.Execute(createOptionSetRequest)
            'Export the solution as managed so that we can later import it.
            Dim exportRequest As ExportSolutionRequest =
             New ExportSolutionRequest With {
              .Managed = True,
              .SolutionName = _primarySolutionName
             }
            Dim exportResponse As ExportSolutionResponse =
             CType(_serviceProxy.Execute(exportRequest), ExportSolutionResponse)
            ' Delete the option set previous created, so it can be imported under the
            ' managed solution.
            Dim deleteOptionSetRequest As DeleteOptionSetRequest =
             New DeleteOptionSetRequest With {
              .Name = _globalOptionSetName
             }
            _serviceProxy.Execute(deleteOptionSetRequest)
            ' Delete the previous primary solution, so it can be imported as managed.
            _serviceProxy.Delete(Solution.EntityLogicalName, _primarySolutionId)
            _primarySolutionId = Guid.Empty

            ' Re-import the solution as managed.
            Dim importRequest As ImportSolutionRequest =
             New ImportSolutionRequest With {
              .CustomizationFile = exportResponse.ExportSolutionFile
             }
            _serviceProxy.Execute(importRequest)

            ' Retrieve the solution from CRM in order to get the new id.
            Dim primarySolutionQuery As QueryByAttribute =
             New QueryByAttribute With {
              .EntityName = Solution.EntityLogicalName,
              .ColumnSet = New ColumnSet("solutionid")
             }
            primarySolutionQuery.Attributes.Add("uniquename")
            primarySolutionQuery.Values.Add(_primarySolutionName)
            _primarySolutionId =
             _serviceProxy.RetrieveMultiple(primarySolutionQuery) _
             .Entities.Cast(Of Solution)().FirstOrDefault().SolutionId.GetValueOrDefault()


            ' Create a secondary solution.
            Dim secondarySolution As Solution =
             New Solution With {
              .Version = "1.0",
              .FriendlyName = "Secondary Solution",
              .PublisherId = New EntityReference(publisher.EntityLogicalName, _publisherId),
              .UniqueName = "SecondarySolution"
             }
            _secondarySolutionId = _serviceProxy.Create(secondarySolution)

            ' Create a Picklist attribute in the secondary solution linked to the option set in the
            ' primary - see WorkWithOptionSets.cs for more on option sets.
            Dim picklistMetadata As PicklistAttributeMetadata =
             New PicklistAttributeMetadata With {
              .SchemaName = _picklistName,
              .LogicalName = _picklistName,
              .DisplayName = New Label("Example Picklist", _languageCode),
              .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
              .OptionSet = New OptionSetMetadata With {
               .IsGlobal = True,
               .Name = _globalOptionSetName
              }
             }

            Dim createAttributeRequest As CreateAttributeRequest =
             New CreateAttributeRequest With {
              .EntityName = Contact.EntityLogicalName,
              .Attribute = picklistMetadata
             }
            createAttributeRequest("SolutionUniqueName") = secondarySolution.UniqueName
            _serviceProxy.Execute(createAttributeRequest)
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

                Dim deleteAttributeRequest As DeleteAttributeRequest =
                 New DeleteAttributeRequest With {
                  .EntityLogicalName = Contact.EntityLogicalName,
                  .LogicalName = _picklistName
                 }
                _serviceProxy.Execute(deleteAttributeRequest)
                _serviceProxy.Delete(Solution.EntityLogicalName, _primarySolutionId)
                _serviceProxy.Delete(Solution.EntityLogicalName, _secondarySolutionId)
                _serviceProxy.Delete(Publisher.EntityLogicalName, _publisherId)


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
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

                Dim app As New GetSolutionDependencies()
                app.Run(config, True)
            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
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
#End Region ' Main

    End Class
End Namespace

' </snippetgetsolutiondependencies>