' <snippetadvancedplugin>



' Microsoft Dynamics CRM namespace(s)
Imports Microsoft.Xrm.Sdk

Namespace Microsoft.Crm.Sdk.Samples
	Public Class AdvancedPlugin
		Implements IPlugin
		Private ReadOnly _unsecureString As String
		Private ReadOnly _secureString As String

		Public Sub New(ByVal unsecureString As String, ByVal secureString As String)
			If String.IsNullOrWhiteSpace(unsecureString) OrElse String.IsNullOrWhiteSpace(secureString) Then
				Throw New InvalidOperationException ("Unsecure and secure strings are required by the Advanced Plug-in, but not provided.")
			End If

			_unsecureString = unsecureString
			_secureString = secureString
		End Sub
		''' <summary>
		''' A plug-in that updates the description field with values 
		''' from the unsecure and secure constructor parameters.
		''' </summary>
		''' <remarks>Register this plug-in on the Update message, contact entity,
		''' pre-Operation and synchronous mode. See the Readme for more information.
		''' </remarks>
		Public Sub Execute(ByVal serviceProvider As IServiceProvider) Implements IPlugin.Execute

			'Extract the tracing service for use in debugging sandboxed plug-ins.
			Dim tracingService As ITracingService = CType(serviceProvider.GetService(GetType(ITracingService)), ITracingService)

			' Obtain the execution context from the service provider.
			Dim context As IPluginExecutionContext = CType(serviceProvider.GetService(GetType(IPluginExecutionContext)), IPluginExecutionContext)

			' For this sample, execute the plug-in code only while the client is online. 
			tracingService.Trace("AdvancedPlugin: Verifying the client is not offline.")
			If context.IsExecutingOffline OrElse context.IsOfflinePlayback Then
				Return
			End If

			' The InputParameters collection contains all the data passed 
			' in the message request.
			If context.InputParameters.Contains("Target") AndAlso TypeOf context.InputParameters("Target") Is Entity Then
				' Obtain the target entity from the Input Parameters.
				tracingService.Trace ("AdvancedPlugin: Getting the target entity from Input Parameters.")
				Dim entity As Entity = CType(context.InputParameters("Target"), Entity)

				' Obtain the image entity from the Pre Entity Images.
				tracingService.Trace ("AdvancedPlugin: Getting image entity from PreEntityImages.")
				Dim image As Entity = CType(context.PreEntityImages("Target"), Entity)

				' Verify that the target entity represents a contact.
				' If not, this plug-in was not registered correctly.
				tracingService.Trace ("AdvancedPlugin: Verifying that the target entity represents a contact.")
				If entity.LogicalName <> "contact" Then
					Return
				End If

				tracingService.Trace("AdvancedPlugin: Creating the description.")
				Dim descriptionMessage As String = "Old full name: " &amp; image("fullname") &amp; " -- Unsecured: " &amp; _unsecureString &amp; ", Secured: " &amp; _secureString

				tracingService.Trace ("AdvancedPlugin: Checking if the target entity doesn't have a description attribute.")
				If entity.Attributes.Contains("description") = False Then
					tracingService.Trace ("AdvancedPlugin: Adding a description attribute with the new value.")
					entity.Attributes.Add("description", descriptionMessage)
				End If
			End If
		End Sub
	End Class
End Namespace

' </snippetadvancedplugin>