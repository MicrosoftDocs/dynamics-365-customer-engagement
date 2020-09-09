' <snippetaccountnumberplugin>



' Microsoft Dynamics CRM namespace(s)
Imports Microsoft.Xrm.Sdk

Namespace Microsoft.Crm.Sdk.Samples

    Public Class AccountNumberPlugin
        Implements IPlugin

        ''' <summary>
        ''' A plug-in that auto generates an account number when an
        ''' account is created.
        ''' </summary>
        ''' <remarks>Register this plug-in on the Create message, account entity,
        ''' and pre-operation stage.
        ''' </remarks>
        Public Sub Execute(ByVal serviceProvider As IServiceProvider) _
            Implements IPlugin.Execute

            ' Obtain the execution context from the service provider.
            Dim context As Microsoft.Xrm.Sdk.IPluginExecutionContext =
                CType(serviceProvider.GetService(
                        GetType(Microsoft.Xrm.Sdk.IPluginExecutionContext)), 
                    Microsoft.Xrm.Sdk.IPluginExecutionContext)

            ' The InputParameters collection contains all the data passed in the message request.
            If context.InputParameters.Contains("Target") AndAlso
                TypeOf context.InputParameters("Target") Is Entity Then

                ' Obtain the target entity from the input parameters.
                Dim entity As Entity = CType(context.InputParameters("Target"), Entity)

                ' Verify that the target entity represents an account.
                ' If not, this plug-in was not registered correctly.
                If entity.LogicalName.Equals("account") Then

                    ' An accountnumber attribute should not already exist because
                    ' it is system generated.
                    If entity.Attributes.Contains("accountnumber").Equals(False) Then

                        ' Create a new accountnumber attribute, set its value, and add
                        ' the attribute to the entity's attribute collection.
                        Dim rndgen As New Random()
                        entity.Attributes.Add("accountnumber", rndgen.Next().ToString())

                    Else

                        ' Throw an error, because account numbers must be system generated.
                        ' Throwing an InvalidPluginExecutionException will cause the error message
                        ' to be displayed in a dialog of the Web application.
                        Throw New InvalidPluginExecutionException(
                            "The account number can only be set by the system.")

                    End If

                End If

            End If

        End Sub
    End Class

End Namespace

' </snippetaccountnumberplugin>