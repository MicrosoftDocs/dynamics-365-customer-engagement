' <snippetscheduleresource>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This sample shows how to schedule a resource.
    ''' </summary>
    Public Class ScheduleResource
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Public _vanId As Guid
        Public _groupId As Guid
        Public _specId As Guid
        Public _plumberServiceId As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Initiate the method to create any data that this sample requires.
        ''' Schedule a resource.        
        ''' Optionally delete any entity records that were created for this sample.
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

                    ' Create the van required resource object.
                    Dim vanReq As RequiredResource = New RequiredResource With {.ResourceId = _vanId, .ResourceSpecId = _specId}

                    ' Create the appointment request.
                    Dim appointmentReq As AppointmentRequest = New AppointmentRequest With { _
                        .RequiredResources = New RequiredResource() {vanReq}, .Direction = SearchDirection.Backward, _
                        .Duration = 60, .NumberOfResults = 10, .ServiceId = _plumberServiceId, _
                        .SearchWindowStart = Date.Now.ToUniversalTime(), .SearchWindowEnd = Date.Now.AddDays(7).ToUniversalTime(), _
                        .UserTimeZoneCode = 1}
                        ' The search window describes the time when the resouce can be scheduled.
                        ' It must be set.

                    ' Verify that the resources have been scheduled                
                    Dim search As SearchRequest = New SearchRequest With {.AppointmentRequest = appointmentReq}
                    Dim searched As SearchResponse = CType(_serviceProxy.Execute(search), SearchResponse)

                    If searched.SearchResults.Proposals.Length > 0 Then
                        Console.WriteLine("Scheduled the resources sucessfully.")
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
        ''' This method creates any entity records that this sample requires.        
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Get the current user's information.
            Dim userRequest As New WhoAmIRequest()
            Dim userResponse As WhoAmIResponse = CType(_serviceProxy.Execute(userRequest), WhoAmIResponse)

            ' Create the van resource.
            Dim van As Equipment = New Equipment With {.Name = "Van 1", .TimeZoneCode = 1, _
                                .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName, userResponse.BusinessUnitId)}

            _vanId = _serviceProxy.Create(van)

            Console.WriteLine("Created a sample equipment: {0}.", van.Name)

            ' Create the contraints for creating the plumber resource group
            Dim builder As New System.Text.StringBuilder("<Constraints>")
            builder.Append("<Constraint>")
            builder.Append("<Expression>")
            builder.Append("<Body>resource[""Id""] == ")
            builder.Append(userResponse.UserId.ToString("B"))
            builder.Append(" || resource[""Id""] == ")
            builder.Append(_vanId.ToString("B"))
            builder.Append("</Body>")
            builder.Append("<Parameters>")
            builder.Append("<Parameter name=""resource"" />")
            builder.Append("</Parameters>")
            builder.Append("</Expression>")
            builder.Append("</Constraint>")
            builder.Append("</Constraints>")

            ' Define an anonymous type to define the possible constraint based group type code values.
            Dim ConstraintBasedGroupTypeCode = New With {Key .Static = 0, Key .Dynamic = 1, Key .Implicit = 2}
            ' Create the plumber resource group.
            Dim group As ConstraintBasedGroup = New ConstraintBasedGroup With { _
                .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName, userResponse.BusinessUnitId), _
                .Name = "Plumber with Van 1", .Constraints = builder.ToString(), _
                .GroupTypeCode = New OptionSetValue(ConstraintBasedGroupTypeCode.Static)}

            _groupId = _serviceProxy.Create(group)

            Console.WriteLine("Created a sample resource group: {0}.", group.Name)

            ' Create the resource specification.
            Dim spec As ResourceSpec = New ResourceSpec With { _
                .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName, userResponse.BusinessUnitId), _
                .ObjectiveExpression = " <Expression> <Body>udf ""Random""(factory,resource,appointment,request,leftoffset,rightoffset)</Body>" &amp; _
                "<Parameters> <Parameter name=""factory"" /> <Parameter name=""resource"" /> <Parameter name=""appointment"" />" &amp; _
                "<Parameter name=""request"" /> <Parameter name=""leftoffset"" /> <Parameter name=""rightoffset"" /> </Parameters>" &amp; _
                "<Properties EvaluationInterval=""P0D"" evaluationcost=""0"" /> </Expression>", _
                .RequiredCount = 1, .Name = "Test Spec", .GroupObjectId = _groupId}
            _specId = _serviceProxy.Create(spec)

            ' Create the plumber required resource object.
            Dim plumberReq As RequiredResource = New RequiredResource With {.ResourceId = userResponse.UserId, .ResourceSpecId = _specId}


            ' Create the service for the equipment.
            Dim plumberService As Service = New Service With { _
                .Name = "Plumber 1", .Duration = 60, .InitialStatusCode = New OptionSetValue(1), _
                .Granularity = "FREQ=MINUTELY;INTERVAL=15;", _
                .ResourceSpecId = New EntityReference(ResourceSpec.EntityLogicalName, _specId)}

            _plumberServiceId = _serviceProxy.Create(plumberService)

            Console.WriteLine("Created a sample service for the equipment: {0}.", plumberService.Name)
        End Sub


        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
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
                _serviceProxy.Delete(Service.EntityLogicalName, _plumberServiceId)
                _serviceProxy.Delete(Equipment.EntityLogicalName, _vanId)
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

                Dim app As New ScheduleResource()
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
        #End Region ' Main
    End Class
End Namespace

' </snippetscheduleresource>