' <snippetcreateaworkflow>


Imports Microsoft.VisualBasic
Imports System
Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client

' These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
    ''' This sample shows how to use VB.NET code to define a new workflow in Microsoft Dynamics CRM.
	''' </summary>
	''' <remarks>
	''' At run-time, you will be given the option to delete all the
	''' database records created by this program.</remarks>
	Public Class CreateAWorkflow
		#Region "Class Level Members"

		Private _workflowId As Guid
		Private _serviceProxy As OrganizationServiceProxy

		#End Region ' Class Level Members

		''' <summary>
		''' This method first creates XAML to define the custom workflow. Afterwards, 
		''' it creates the workflow record with this XAML and then activates it.
		''' </summary>
		''' <remarks>
		''' Visit http://msdn.microsoft.com/library/gg309458.aspx 
		''' for instructions on enabling XAML workflows on the Microsoft Dynamics CRM server.
		''' </remarks>
		''' <param name="serverConfig">Contains server connection information.</param>
		''' <param name="promptforDelete">When True, the user will be prompted to delete all
		''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()

                    '					#Region "Create XAML"

                    ' Define the workflow XAML.
                    Dim xamlWF As String

                    xamlWF = "<?xml version=""1.0"" encoding=""utf-16""?>" &amp;
                        "<Activity x:Class=""SampleWF"" " &amp;
                        "          xmlns=""http://schemas.microsoft.com/netfx/2009/xaml/activities"" " &amp;
                        "          xmlns:mva=""clr-namespace:Microsoft.VisualBasic.Activities;assembly=System.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" " &amp;
                        "          xmlns:mxs=""clr-namespace:Microsoft.Xrm.Sdk;assembly=Microsoft.Xrm.Sdk, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" " &amp;
                        "          xmlns:mxswa=""clr-namespace:Microsoft.Xrm.Sdk.Workflow.Activities;assembly=Microsoft.Xrm.Sdk.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" " &amp;
                        "          xmlns:s=""clr-namespace:System;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" " &amp;
                        "          xmlns:scg=""clr-namespace:System.Collections.Generic;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" " &amp;
                        "          xmlns:srs=""clr-namespace:System.Runtime.Serialization;assembly=System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" " &amp;
                        "          xmlns:this=""clr-namespace:"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">" &amp;
                        "    <x:Members>" &amp;
                        "        <x:Property Name=""InputEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />" &amp;
                        "        <x:Property Name=""CreatedEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />" &amp;
                        "    </x:Members>" &amp;
                        "    <this:SampleWF.InputEntities>" &amp;
                        "        <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />" &amp;
                        "    </this:SampleWF.InputEntities>" &amp;
                        "    <this:SampleWF.CreatedEntities>" &amp;
                        "      <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />" &amp;
                        "   </this:SampleWF.CreatedEntities>" &amp;
                        "    <mva:VisualBasic.Settings>Assembly references and imported namespaces for internal implementation</mva:VisualBasic.Settings>" &amp;
                        "    <mxswa:Workflow>" &amp;
                        "        <Sequence>" &amp;
                        "            <Sequence.Variables>" &amp;
                        "                <Variable x:TypeArguments=""x:Int32"" Default=""[40]"" Name=""probability_value"" />" &amp;
                        "                <Variable x:TypeArguments=""mxs:Entity"" Default=""[CreatedEntities(&amp;quot;primaryEntity#Temp&amp;quot;)]"" Name=""CreatedEntity"" />" &amp;
                        "            </Sequence.Variables>" &amp;
                        "            <Assign x:TypeArguments=""mxs:Entity"" To=""[CreatedEntity]"" Value=""[New Entity(&amp;quot;opportunity&amp;quot;)]"" />" &amp;
                        "            <Assign x:TypeArguments=""s:Guid"" To=""[CreatedEntity.Id]"" Value=""[InputEntities(&amp;quot;primaryEntity&amp;quot;).Id]"" />" &amp;
                        "            <mxswa:SetEntityProperty Attribute=""closeprobability"" Entity=""[CreatedEntity]"" " &amp;
                        "                EntityName=""opportunity"" TargetType=""[Type.GetType(&amp;quot;probability_value&amp;quot;)]"" " &amp;
                        "                               Value=""[probability_value]"">" &amp;
                        "            </mxswa:SetEntityProperty>" &amp;
                        "            <mxswa:UpdateEntity Entity=""[CreatedEntity]"" EntityName=""opportunity"" />" &amp;
                        "            <Assign x:TypeArguments=""mxs:Entity"" To=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" Value=""[CreatedEntity]"" />" &amp;
                        "            <Persist />" &amp;
                        "        </Sequence>" &amp;
                        "    </mxswa:Workflow>" &amp;
                        "</Activity>"

                    '					#End Region ' Create XAML

                    '					#Region "Create Workflow"

                    ' Create the workflow.
                    Dim workflow As New Workflow() With
                        {
                            .Name = "SampleCustomWorkflow",
                            .Type = New OptionSetValue(CInt(Fix(WorkflowType.Definition))),
                            .Category = New OptionSetValue(CInt(Fix(WorkflowCategory.Workflow))),
                            .Scope = New OptionSetValue(CInt(Fix(WorkflowScope.User))),
                            .LanguageCode = 1033,
                            .TriggerOnCreate = True,
                            .OnDemand = False,
                            .PrimaryEntity = Opportunity.EntityLogicalName,
                            .Description = "When an opportunity is created, this workflow" &amp;
                            " sets the closeprobability field of the opportunity record to 40%.",
                            .Xaml = xamlWF
                        }
                    _workflowId = _serviceProxy.Create(workflow)

                    Console.WriteLine("Created Workflow: " &amp; workflow.Name)

                    '					#End Region ' Create Workflow

                    '					#Region "Activate Workflow"

                    ' Activate the workflow.
                    Dim activateRequest = New SetStateRequest With
                                          {
                                              .EntityMoniker = New EntityReference(workflow.EntityLogicalName,
                                                                                   _workflowId),
                                              .State = New OptionSetValue(CInt(Fix(WorkflowState.Activated))),
                                              .Status = New OptionSetValue(CInt(Fix(workflow_statuscode.Activated)))
                                          }
                    _serviceProxy.Execute(activateRequest)
                    Console.WriteLine("Activated Workflow: " &amp; workflow.Name)

                    '					#End Region ' Activate Workflow

                    DeleteRequiredRecords(promptforDelete)
                End Using

                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

		#Region "Class methods"

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()

		End Sub

		''' <summary>
		''' Deletes any entity records that were created for this sample.
		''' <param name="prompt">Indicates whether to prompt the user 
		''' to delete the records created in this sample.</param>
		''' </summary>
		Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
			' Two of the contracts, their associated account and the contract template
			' records that were created and used in this sample will continue to exist 
			' on your system because contracts that have been invoiced cannot be deleted 
			' in Microsoft Dynamics CRM. They can only be put on hold or canceled.

			Dim toBeDeleted As Boolean = True

			If prompt Then
				' Ask the user if the created entities should be deleted.
				Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
				Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse
                    answer.StartsWith("Y") OrElse
                    answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
			End If

			If toBeDeleted Then

				' Deactivate and delete workflow
                Dim deactivateRequest As SetStateRequest =
                    New SetStateRequest With
                    {
                        .EntityMoniker = New EntityReference(Workflow.EntityLogicalName,
                                                             _workflowId),
                        .State = New OptionSetValue(CInt(Fix(WorkflowState.Draft))),
                        .Status = New OptionSetValue(CInt(Fix(workflow_statuscode.Draft)))
                    }
				_serviceProxy.Execute(deactivateRequest)
				_serviceProxy.Delete(Workflow.EntityLogicalName, _workflowId)
				Console.WriteLine("Workflow has been deactivated and deleted.")

			End If
		End Sub

		#End Region ' Class methods

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
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

				Dim app As New CreateAWorkflow()
				app.Run(config, True)
			Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
				Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
				Console.WriteLine("Message: {0}", ex.Detail.Message)
				Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
			Catch ex As System.TimeoutException
				Console.WriteLine("The application terminated with an error.")
				Console.WriteLine("Message: {0}", ex.Message)
				Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
			Catch ex As System.Exception
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
		#End Region ' Main method
	End Class
End Namespace

' </snippetcreateaworkflow>