' <snippetexecutemultiple>


Imports System.ServiceModel
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
    Public Class ExecuteMultiple
#Region "Class Level Members"

        Private _serviceProxy As OrganizationServiceProxy
        Private ReadOnly _newAccountIds As New List(Of Guid)()

        Private requestWithResults As ExecuteMultipleRequest
#End Region

#Region "How To Sample Code"

        ''' <summary>
        ''' This sample demonstrates how to execute a collection of message requests using a single web service
        ''' call and optionally return the results.
        ''' </summary>
        ''' <seealso cref="http://msdn.microsoft.com/library/gg328075.aspx"/>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptforDelete As Boolean)
            Try
                ' Get a reference to the organization service.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)

                Using _serviceProxy
                    ' Enable early-bound type support to add/update entity records required for this sample.
                    _serviceProxy.EnableProxyTypes()

                    '#Region "Execute Multiple with Results"
                    ' Create an ExecuteMultipleRequest object.
                    ' Assign settings that define execution behavior: continue on error, return responses.
                    ' Create an empty organization request collection.
                    requestWithResults = New ExecuteMultipleRequest() With
                        {
                            .Settings = New ExecuteMultipleSettings() With
                                        {
                                            .ContinueOnError = False,
                                            .ReturnResponses = True
                                        },
                            .Requests = New OrganizationRequestCollection()
                        }

                    ' Create several (local, in memory) entities in a collection. 
                    Dim input As EntityCollection = GetCollectionOfEntitiesToCreate()

                    ' Add a CreateRequest for each entity to the request collection.
                    For Each entity In input.Entities
                        Dim createRequest_Renamed As CreateRequest = New CreateRequest With {.Target = entity}
                        requestWithResults.Requests.Add(createRequest_Renamed)
                    Next entity

                    ' Execute all the requests in the request collection using a single web method call.
                    Dim responseWithResults As ExecuteMultipleResponse =
                        CType(_serviceProxy.Execute(requestWithResults), ExecuteMultipleResponse)

                    ' Display the results returned in the responses.
                    For Each responseItem In responseWithResults.Responses

                        If responseItem.Response IsNot Nothing Then
                            ' A valid response.
                            DisplayResponse(requestWithResults.Requests(responseItem.RequestIndex),
                                            responseItem.Response)

                        ElseIf responseItem.Fault IsNot Nothing Then
                            ' An error has occurred.
                            DisplayFault(requestWithResults.Requests(responseItem.RequestIndex),
                                         responseItem.RequestIndex, responseItem.Fault)
                        End If
                    Next responseItem
                    '#End Region ' Execute Multiple with Results


                    '#Region "Execute Multiple with No Results"

                    ' Set the execution behavior to not continue after the first error is received
                    ' and to not return responses.
                    Dim requestWithNoResults As New ExecuteMultipleRequest() With
                        {
                            .Settings = New ExecuteMultipleSettings() With
                                        {
                                            .ContinueOnError = False,
                                            .ReturnResponses = False
                                        },
                            .Requests = New OrganizationRequestCollection()
                        }

                    ' Update the entities that were previously created.
                    Dim update As EntityCollection = GetCollectionOfEntitiesToUpdate()

                    For Each entity In update.Entities
                        Dim updateRequest_Renamed As UpdateRequest = New UpdateRequest With {.Target = entity}
                        requestWithNoResults.Requests.Add(updateRequest_Renamed)
                    Next entity

                    Dim responseWithNoResults As ExecuteMultipleResponse =
                        CType(_serviceProxy.Execute(requestWithNoResults), ExecuteMultipleResponse)

                    ' There should be no responses unless there was an error. Only the first error 
                    ' should be returned. That is the behavior defined in the settings.
                    If responseWithNoResults.Responses.Count > 0 Then
                        For Each responseItem In responseWithNoResults.Responses

                            If responseItem.Fault IsNot Nothing Then
                                DisplayFault(requestWithNoResults.Requests(responseItem.RequestIndex),
                                             responseItem.RequestIndex, responseItem.Fault)
                            End If
                        Next responseItem
                    Else
                        Console.WriteLine("All account records have been updated successfully.")
                    End If

                    '#End Region ' Execute Multiple with No Results


                    '#Region "Execute Multiple with Continue On Error"

                    ' Set the execution behavior to continue on an error and not return responses.
                    Dim requestWithContinueOnError As New ExecuteMultipleRequest() With
                        {
                            .Settings = New ExecuteMultipleSettings() With
                                        {
                                            .ContinueOnError = True,
                                            .ReturnResponses = False
                                        },
                            .Requests = New OrganizationRequestCollection()
                        }

                    ' Update the entities but introduce some bad attribute values so we get errors.
                    Dim updateWithErrors As EntityCollection = GetCollectionOfEntitiesToUpdateWithErrors()

                    For Each entity In updateWithErrors.Entities
                        Dim updateRequest_Renamed As UpdateRequest = New UpdateRequest With {.Target = entity}
                        requestWithContinueOnError.Requests.Add(updateRequest_Renamed)
                    Next entity

                    Dim responseWithContinueOnError As ExecuteMultipleResponse =
                        CType(_serviceProxy.Execute(requestWithContinueOnError), ExecuteMultipleResponse)

                    ' There should be no responses except for those that contain an error. 
                    If responseWithContinueOnError.Responses.Count > 0 Then

                        If responseWithContinueOnError.Responses.Count < requestWithContinueOnError.Requests.Count Then
                            Console.WriteLine("Response collection contain a mix of successful response objects and errors.")
                        End If

                        For Each responseItem In responseWithContinueOnError.Responses
                            If responseItem.Fault IsNot Nothing Then
                                DisplayFault(requestWithContinueOnError.Requests(responseItem.RequestIndex),
                                             responseItem.RequestIndex, responseItem.Fault)
                            End If
                        Next responseItem
                    Else
                        ' No errors means all transactions are successful.
                        Console.WriteLine("All account records have been updated successfully.")
                    End If

                    '#End Region ' Execute Multiple with Continue On Error

                    DeleteRequiredRecords(promptforDelete)
                End Using

            Catch fault As FaultException(Of OrganizationServiceFault)

                ' Check if the maximum batch size has been exceeded. The maximum batch size is only included in the fault if it
                ' the input request collection count exceeds the maximum batch size.
                If fault.Detail.ErrorDetails.Contains("MaxBatchSize") Then

                    Dim maxBatchSize As Integer = Convert.ToInt32(fault.Detail.ErrorDetails("MaxBatchSize"))
                    If maxBatchSize < requestWithResults.Requests.Count Then
                        ' Here you could reduce the size of your request collection and re-submit the ExecuteMultiple request.
                        ' For this sample, that only issues a few requests per batch, we will just print out some info. However,
                        ' this code will never be executed because the default max batch size is 1000.
                        Console.WriteLine("The input request collection contains %0 requests, which exceeds the maximum allowed (%1)", requestWithResults.Requests.Count, maxBatchSize)
                    End If
                End If
                ' Re-throw so Main() can process the fault.
                Throw
            End Try
        End Sub


#Region "Public Methods"

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want to delete the account record? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse
                                 answer.StartsWith("Y") OrElse
                                 answer = String.Empty)
            End If

            If Not deleteRecords Then
                Return
            End If

            Dim requestWithNoResults As New ExecuteMultipleRequest() With {.Settings = New ExecuteMultipleSettings() With {.ContinueOnError = False, .ReturnResponses = False}, .Requests = New OrganizationRequestCollection()}
            ' Set the execution behavior to not continue after the first error is received
            ' and to not return responses.

            ' Update the entities that were previously created.
            Dim delete As EntityCollection = GetCollectionOfEntitiesToDelete()

            For Each entity In delete.Entities
                Dim deleteRequest_Renamed As DeleteRequest = New DeleteRequest With {.Target = entity.ToEntityReference()}
                requestWithNoResults.Requests.Add(deleteRequest_Renamed)
            Next entity

            Dim responseWithNoResults As ExecuteMultipleResponse = CType(_serviceProxy.Execute(requestWithNoResults), ExecuteMultipleResponse)

            ' There should be no responses unless there was an error. Only the first error 
            ' should be returned. That is the behavior defined in the settings.
            If responseWithNoResults.Responses.Count > 0 Then
                For Each responseItem In responseWithNoResults.Responses
                    If responseItem.Fault IsNot Nothing Then
                        DisplayFault(requestWithNoResults.Requests(responseItem.RequestIndex), responseItem.RequestIndex, responseItem.Fault)
                    End If
                Next responseItem
            Else
                Console.WriteLine("All account records have been deleted successfully.")
            End If
        End Sub

#End Region

#Region "Private Methods"

        ''' <summary>
        ''' Create a collection of entity objects for updating. Give these entities a new
        ''' name for the update. However, use a bad (empty) GUID in some entities to demonstrate
        ''' returning errors in ExecuteMultipleResponse.
        ''' </summary>
        ''' <returns>An entity collection.</returns>
        Private Function GetCollectionOfEntitiesToUpdateWithErrors() As EntityCollection
            Dim collection As New EntityCollection() With {.EntityName = Account.EntityLogicalName}

            For i As Integer = 1 To _newAccountIds.Count
                ' Introducing errors for sample demonstration.
                If i Mod 2 > 0 Then
                    collection.Entities.Add(
                        New Account With
                        {
                            .Name = "Again Updated Example Account " &amp; i.ToString(),
                            .Id = New Guid()
                        })
                Else

                    collection.Entities.Add(
                        New Account With
                        {
                            .Name = "Again Updated Example Account " &amp; i.ToString(),
                            .Id = _newAccountIds(i - 1)
                        })
                End If
            Next i

            Return collection
        End Function

        ''' <summary>
        ''' Create a collection of entity objects for updating. Give these entities a new
        ''' name for the update.
        ''' </summary>
        ''' <returns>An entity collection.</returns>
        Private Function GetCollectionOfEntitiesToUpdate() As EntityCollection
            Dim collection As New EntityCollection() With {.EntityName = Account.EntityLogicalName}

            For i As Integer = 1 To _newAccountIds.Count
                collection.Entities.Add(
                    New Account With
                    {
                        .Name = "Updated Example Account " &amp; i.ToString(),
                        .Id = _newAccountIds(i - 1)
                    })
            Next i

            Return collection
        End Function

        ''' <summary>
        ''' Create a collection of new entity objects.
        ''' </summary>
        ''' <returns>A collection of entity objects.</returns>
        Private Function GetCollectionOfEntitiesToCreate() As EntityCollection
            Dim collection As New EntityCollection() With {.EntityName = Account.EntityLogicalName}

            For i As Integer = 1 To 5
                collection.Entities.Add(New Account With {.Name = "Example Account " &amp; i.ToString()})
            Next i

            Return collection
        End Function

        ''' <summary>
        ''' Delete a collection of entity objects.
        ''' </summary>
        ''' <returns>A collection of entity objects</returns>
        Private Function GetCollectionOfEntitiesToDelete() As EntityCollection
            Dim collection As New EntityCollection() With {.EntityName = Account.EntityLogicalName}

            For i As Integer = 1 To _newAccountIds.Count
                collection.Entities.Add(New Account With {.Id = _newAccountIds(i - 1)})
            Next i

            Return collection
        End Function

        ''' <summary>
        ''' Display the response of an organization message request.
        ''' </summary>
        ''' <param name="organizationRequest">The organization message request.</param>
        ''' <param name="organizationResponse">The organization message response.</param>
        Private Sub DisplayResponse(ByVal organizationRequest_Renamed As OrganizationRequest,
                             ByVal organizationResponse_Renamed As OrganizationResponse)
            Console.WriteLine("Created " _
                              &amp; (CType(organizationRequest_Renamed.Parameters("Target"), Account)).Name _
                              &amp; " with account id as " _
                              &amp; organizationResponse_Renamed.Results("id").ToString())
            _newAccountIds.Add(New Guid(organizationResponse_Renamed.Results("id").ToString()))
        End Sub

        ''' <summary>
        ''' Display the fault that resulted from processing an organization message request.
        ''' </summary>
        ''' <param name="organizationRequest_Renamed">The organization message request.</param>
        ''' <param name="count">nth request number from ExecuteMultiple request</param>
        ''' <param name="organizationServiceFault_Renamed">A WCF fault.</param>
        Private Sub DisplayFault(ByVal organizationRequest_Renamed As OrganizationRequest,
                                 ByVal count As Integer,
                                 ByVal organizationServiceFault_Renamed As OrganizationServiceFault)
            Console.WriteLine("A fault occurred when processing {1} request, at index {0} in the request collection with a fault message: {2}",
                              count + 1, organizationRequest_Renamed.RequestName, organizationServiceFault_Renamed.Message)
        End Sub

#End Region

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

                Dim app = New ExecuteMultiple()
                app.Run(config, True)

            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault,
                                     "No Inner Fault", "Has Inner Fault"))
            Catch ex As TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message,
                                     "No Inner Fault", ex.InnerException.Message))
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
                        Console.WriteLine("Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault,
                                             "No Inner Fault", "Has Inner Fault"))
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

' </snippetexecutemultiple>