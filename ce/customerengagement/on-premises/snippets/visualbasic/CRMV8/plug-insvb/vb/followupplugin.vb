' <snippetfollowupplugin>


Imports System.ServiceModel

' Microsoft Dynamics CRM namespace(s)
Imports Microsoft.Xrm.Sdk

Namespace Microsoft.Crm.Sdk.Samples

    Public Class FollowupPlugin
        Implements IPlugin

        ''' <summary>
        ''' A plug-in that creates a follow-up task activity when a new account is created.
        ''' </summary>
        ''' <remarks>Register this plug-in on the Create message, account entity,
        ''' and asynchronous mode.
        ''' </remarks>
        Public Sub Execute(ByVal serviceProvider As IServiceProvider) _
            Implements IPlugin.Execute

            'Extract the tracing service for use in debugging sandboxed plug-ins.
            Dim tracingService As ITracingService =
                CType(serviceProvider.GetService(GetType(ITracingService)), 
                    ITracingService)

            ' Obtain the execution context from the service provider.
            Dim context As IPluginExecutionContext =
                CType(serviceProvider.GetService(GetType(IPluginExecutionContext)), 
                    IPluginExecutionContext)

            ' The InputParameters collection contains all the data passed in the message request.
            If context.InputParameters.Contains("Target") AndAlso
                TypeOf context.InputParameters("Target") Is Entity Then

                ' Obtain the target entity from the input parameters.
                Dim entity As Entity = CType(context.InputParameters("Target"), Entity)

                ' Verify that the target entity represents an account.
                ' If not, this plug-in was not registered correctly.
                If entity.LogicalName.Equals("account") Then

                    Try

                        ' Create a task activity to follow up with the account customer in 7 days. 
                        Dim followup As New Entity("task")

                        followup("subject") = "Send e-mail to the new customer."
                        followup("description") = "Follow up with the customer. " _
                            &amp; "Check if there are any new issues that need resolution."
                        followup("scheduledstart") = Date.Now.AddDays(7)
                        followup("scheduledend") = Date.Now.AddDays(7)
                        followup("category") = context.PrimaryEntityName

                        ' Refer to the account in the task activity.
                        If context.OutputParameters.Contains("id") Then

                            Dim regardingobjectid As _
                                New Guid(context.OutputParameters("id").ToString())
                            Dim regardingobjectidType As String = "account"

                            followup("regardingobjectid") =
                                New EntityReference(regardingobjectidType,
                                                    regardingobjectid)

                        End If

                        ' Obtain the organization service reference.
                        Dim serviceFactory As IOrganizationServiceFactory =
                            CType(serviceProvider.GetService(GetType(IOrganizationServiceFactory)), 
                                IOrganizationServiceFactory)
                        Dim service As IOrganizationService =
                            serviceFactory.CreateOrganizationService(context.UserId)

                        ' Create the task in Microsoft Dynamics CRM.
                        tracingService.Trace("FollowupPlugin: Creating the task activity.")
                        service.Create(followup)

                    Catch ex As FaultException(Of OrganizationServiceFault)

                        Throw New InvalidPluginExecutionException(
                            "An error occurred in the FollupupPlugin plug-in.", ex)


                    Catch ex As Exception

                        tracingService.Trace("FollowupPlugin: {0}", ex.ToString())
                        Throw

                    End Try

                End If
            End If

        End Sub
    End Class

End Namespace

' </snippetfollowupplugin>