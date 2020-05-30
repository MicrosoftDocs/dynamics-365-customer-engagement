' <snippetcreateprocessfromtemplate>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
	''' <summary>
	''' Create a Workflow Process from an existing Process Template.
	''' </summary>
	Public Class CreateProcessFromTemplate

		#Region "Class Level Members"

		Private _processTemplateId As Guid
		Private _processId As Guid
		Private _serviceProxy As OrganizationServiceProxy

		#End Region ' Class Level Members

		#Region "How-To Sample Code"
		''' <summary>
		''' Demonstrates how to programmatically create a Workflow from an existing
		''' Process Template.
		''' </summary>
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

                    Dim _orgContext As New OrganizationServiceContext(_serviceProxy)

                    CreateRequiredRecords()

                    Dim request As New CreateWorkflowFromTemplateRequest() With
                        {
                            .WorkflowName = "Workflow From Template",
                            .WorkflowTemplateId = _processTemplateId
                        }

                    ' Execute request.
                    Dim response As CreateWorkflowFromTemplateResponse =
                        CType(_serviceProxy.Execute(request), CreateWorkflowFromTemplateResponse)
                    _processId = response.Id

                    ' Verify success.
                    ' Retrieve the name of the workflow.
                    Dim cols As New ColumnSet("name")
                    Dim newWorkflow As Workflow =
                        CType(
                            _serviceProxy.Retrieve(
                                Workflow.EntityLogicalName,
                                response.Id,
                                cols), 
                            Workflow)
                    If newWorkflow.Name = "Workflow From Template" Then
                        Console.WriteLine("Created {0}.", request.WorkflowName)
                    End If

                    DeleteRequiredRecords(promptforDelete)
                End Using

                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

		''' <summary>
		''' Creates any entity records that this sample requires.
		''' </summary>
		Public Sub CreateRequiredRecords()

			' Define an anonymous type to define the possible values for
			' process type
            Dim ProcessType = New With {
                                            Key .Definition = 1,
                                            Key .Activation = 2,
                                            Key .Template = 3
                                       }

			' Define an anonymous type to define the possible values for
			' process category
			Dim ProcessCategory = New With {Key .Workflow = 0, Key .Dialog = 1}

			' Define an anonymous type to define the possible values for
			' process scope
            Dim ProcessScope = New With {
                                            Key .User = 1,
                                            Key .BusinessUnit = 2,
                                            Key .Deep = 3,
                                            Key .Global = 4
                                       }

			' Create the Workflow template that we will use to generate the Workflow.
            Dim processTemplate _
                As New Workflow() With
                {
                    .Name = "Sample Process Template",
                    .Type = New OptionSetValue(ProcessType.Template),
                    .Category = New OptionSetValue(ProcessCategory.Workflow),
                    .Scope = New OptionSetValue(ProcessScope.User),
                    .LanguageCode = 1033,
                    .TriggerOnCreate = True,
                    .OnDemand = False,
                    .PrimaryEntity = Account.EntityLogicalName,
                    .Xaml = "<?xml version=""1.0"" encoding=""utf-16""?>" _
 &amp; "<Activity x:Class=""SampleWorkflow"" xmlns=""https://schemas.microsoft.com/netfx/2009/xaml/activities"" xmlns:mva=""clr-namespace:Microsoft.VisualBasic.Activities;assembly=System.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:mxs=""clr-namespace:Microsoft.Xrm.Sdk;assembly=Microsoft.Xrm.Sdk, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:mxsq=""clr-namespace:Microsoft.Xrm.Sdk.Query;assembly=Microsoft.Xrm.Sdk, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:mxswa=""clr-namespace:Microsoft.Xrm.Sdk.Workflow.Activities;assembly=Microsoft.Xrm.Sdk.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:s=""clr-namespace:System;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:scg=""clr-namespace:System.Collections.Generic;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:sco=""clr-namespace:System.Collections.ObjectModel;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:srs=""clr-namespace:System.Runtime.Serialization;assembly=System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:this=""clr-namespace:"" xmlns:x=""https://schemas.microsoft.com/winfx/2006/xaml"">" _
 &amp; "  <x:Members>" _
 &amp; "    <x:Property Name=""InputEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />" _
 &amp; "    <x:Property Name=""CreatedEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />" _
 &amp; "  </x:Members>" _
 &amp; "  <this:SampleWorkflow.InputEntities>" _
 &amp; "    <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />" _
 &amp; "  </this:SampleWorkflow.InputEntities>" _
 &amp; "  <this:SampleWorkflow.CreatedEntities>" _
 &amp; "    <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />" _
 &amp; "  </this:SampleWorkflow.CreatedEntities>" _
 &amp; "  <mva:VisualBasic.Settings>Assembly references and imported namespaces for internal implementation</mva:VisualBasic.Settings>" _
 &amp; "  <mxswa:Workflow>" _
 &amp; "    <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.ConditionSequence, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""ConditionStep1: If Account Name is in the &amp;quot;Sample&amp;quot; family"">" _
 &amp; "      <mxswa:ActivityReference.Arguments>" _
 &amp; "        <InArgument x:TypeArguments=""x:Boolean"" x:Key=""Wait"">False</InArgument>" _
 &amp; "      </mxswa:ActivityReference.Arguments>" _
 &amp; "      <mxswa:ActivityReference.Properties>" _
 &amp; "        <sco:Collection x:TypeArguments=""Variable"" x:Key=""Variables"">" _
 &amp; "          <Variable x:TypeArguments=""x:Boolean"" Default=""False"" Name=""ConditionBranchStep2_condition"" />" _
 &amp; "          <Variable x:TypeArguments=""x:Object"" Name=""ConditionBranchStep2_1"" />" _
 &amp; "          <Variable x:TypeArguments=""x:Object"" Name=""ConditionBranchStep2_2"" />" _
 &amp; "        </sco:Collection>" _
 &amp; "        <sco:Collection x:TypeArguments=""Activity"" x:Key=""Activities"">" _
 &amp; "          <mxswa:GetEntityProperty Attribute=""name"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""account"" Value=""[ConditionBranchStep2_1]"">" _
 &amp; "            <mxswa:GetEntityProperty.TargetType>" _
 &amp; "              <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"">" _
 &amp; "                  <x:Null />" _
 &amp; "                </mxswa:ReferenceLiteral>" _
 &amp; "              </InArgument>" _
 &amp; "            </mxswa:GetEntityProperty.TargetType>" _
 &amp; "          </mxswa:GetEntityProperty>" _
 &amp; "          <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "            <mxswa:ActivityReference.Arguments>" _
 &amp; "              <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "              <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.String, ""Sample"", ""String"" }]</InArgument>" _
 &amp; "              <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />" _
 &amp; "              </InArgument>" _
 &amp; "              <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[ConditionBranchStep2_2]</OutArgument>" _
 &amp; "            </mxswa:ActivityReference.Arguments>" _
 &amp; "          </mxswa:ActivityReference>" _
 &amp; "          <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateCondition, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateCondition"">" _
 &amp; "            <mxswa:ActivityReference.Arguments>" _
 &amp; "              <InArgument x:TypeArguments=""mxsq:ConditionOperator"" x:Key=""ConditionOperator"">Contains</InArgument>" _
 &amp; "              <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { ConditionBranchStep2_2 }]</InArgument>" _
 &amp; "              <InArgument x:TypeArguments=""x:Object"" x:Key=""Operand"">[ConditionBranchStep2_1]</InArgument>" _
 &amp; "              <OutArgument x:TypeArguments=""x:Boolean"" x:Key=""Result"">[ConditionBranchStep2_condition]</OutArgument>" _
 &amp; "            </mxswa:ActivityReference.Arguments>" _
 &amp; "          </mxswa:ActivityReference>" _
 &amp; "          <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.ConditionBranch, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""ConditionBranchStep2"">" _
 &amp; "            <mxswa:ActivityReference.Arguments>" _
 &amp; "              <InArgument x:TypeArguments=""x:Boolean"" x:Key=""Condition"">[ConditionBranchStep2_condition]</InArgument>" _
 &amp; "            </mxswa:ActivityReference.Arguments>" _
 &amp; "            <mxswa:ActivityReference.Properties>" _
 &amp; "              <mxswa:ActivityReference x:Key=""Then"" AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.Composite, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""ConditionBranchStep2"">" _
 &amp; "                <mxswa:ActivityReference.Properties>" _
 &amp; "                  <sco:Collection x:TypeArguments=""Variable"" x:Key=""Variables"" />" _
 &amp; "                  <sco:Collection x:TypeArguments=""Activity"" x:Key=""Activities"">" _
 &amp; "                    <Sequence DisplayName=""CreateStep3: Add new contact for Nancy Anderson at new account."">" _
 &amp; "                      <Sequence.Variables>" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_1"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_2"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_3"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_4"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_5"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_6"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_7"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_8"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_9"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_10"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_11"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_12"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_13"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_14"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_15"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_16"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_17"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_18"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_19"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_20"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_21"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_22"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_23"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_24"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_25"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_26"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_27"" />" _
 &amp; "                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_28"" />" _
 &amp; "                      </Sequence.Variables>" _
 &amp; "                      <Assign x:TypeArguments=""mxs:Entity"" To=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" Value=""[New Entity(&amp;quot;contact&amp;quot;)]"" />" _
 &amp; "                      <mxswa:GetEntityProperty Attribute=""telephone1"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""account"" Value=""[CreateStep3_2]"">" _
 &amp; "                        <mxswa:GetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:GetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:GetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep3_2 }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_1]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""telephone1"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_1]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.String, ""Nancy"", ""String"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_3]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""firstname"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_3]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.String, ""Anderson"", ""String"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_4]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""lastname"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_4]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:GetEntityProperty Attribute=""accountid"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""account"" Value=""[CreateStep3_6]"">" _
 &amp; "                        <mxswa:GetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:GetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:GetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep3_6 }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_5]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""parentcustomerid"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_5]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:GetEntityProperty Attribute=""transactioncurrencyid"" Entity=""[InputEntities(&amp;quot;related_transactioncurrencyid#transactioncurrency&amp;quot;)]"" EntityName=""transactioncurrency"" Value=""[CreateStep3_8]"">" _
 &amp; "                        <mxswa:GetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:GetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:GetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep3_8 }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_7]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""transactioncurrencyid"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_7]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_9]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""creditonhold"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_9]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_10]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""preferredcontactmethodcode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_10]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_11]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""donotemail"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_11]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_12]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""donotbulkemail"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_12]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_13]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""donotphone"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_13]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_14]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""donotfax"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_14]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_15]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""donotpostalmail"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_15]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_16]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""donotsendmm"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_16]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_17]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""preferredappointmenttimecode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_17]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_18]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""address2_addresstypecode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_18]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_19]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""address2_freighttermscode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_19]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_20]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""address2_shippingmethodcode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_20]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_21]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""customersizecode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_21]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_22]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""customertypecode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_22]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_23]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""educationcode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_23]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_24]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""haschildrencode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_24]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_25]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""isbackofficecustomer"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_25]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_26]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""leadsourcecode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_26]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_27]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""shippingmethodcode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_27]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">" _
 &amp; "                        <mxswa:ActivityReference.Arguments>" _
 &amp; "                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_28]</OutArgument>" _
 &amp; "                        </mxswa:ActivityReference.Arguments>" _
 &amp; "                      </mxswa:ActivityReference>" _
 &amp; "                      <mxswa:SetEntityProperty Attribute=""territorycode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_28]"">" _
 &amp; "                        <mxswa:SetEntityProperty.TargetType>" _
 &amp; "                          <InArgument x:TypeArguments=""s:Type"">" _
 &amp; "                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />" _
 &amp; "                          </InArgument>" _
 &amp; "                        </mxswa:SetEntityProperty.TargetType>" _
 &amp; "                      </mxswa:SetEntityProperty>" _
 &amp; "                      <mxswa:CreateEntity EntityId=""{x:Null}"" DisplayName=""CreateStep3: Add new contact for Nancy Anderson at new account."" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" />" _
 &amp; "                      <Assign x:TypeArguments=""mxs:Entity"" To=""[CreatedEntities(&amp;quot;CreateStep3_localParameter&amp;quot;)]"" Value=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" />" _
 &amp; "                      <Persist />" _
 &amp; "                    </Sequence>" _
 &amp; "                  </sco:Collection>" _
 &amp; "                </mxswa:ActivityReference.Properties>" _
 &amp; "              </mxswa:ActivityReference>" _
 &amp; "              <x:Null x:Key=""Else"" />" _
 &amp; "            </mxswa:ActivityReference.Properties>" _
 &amp; "          </mxswa:ActivityReference>" _
 &amp; "        </sco:Collection>" _
 &amp; "      </mxswa:ActivityReference.Properties>" _
 &amp; "    </mxswa:ActivityReference>" _
 &amp; "  </mxswa:Workflow>" _
 &amp; "</Activity>"
            }
            'Language code for U.S. English
            _processTemplateId = _serviceProxy.Create(processTemplate)

            Console.Write("Created {0},", processTemplate.Name)

            ' Activate the process template
            Dim activateRequest As SetStateRequest =
                New SetStateRequest With
                {
                    .EntityMoniker =
                    New EntityReference(Workflow.EntityLogicalName, _processTemplateId),
                    .State =
                    New OptionSetValue(CInt(Fix(WorkflowState.Activated))),
                    .Status = New OptionSetValue(2)
                }
            _serviceProxy.Execute(activateRequest)
            Console.WriteLine(" and activated.")

        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") _
                                 OrElse answer.StartsWith("Y") _
                                 OrElse answer = String.Empty)
            End If

            If deleteRecords Then
                _serviceProxy.Delete(Workflow.EntityLogicalName, _processId)

                ' Deactivate the process template before you can delete it.
                Dim deactivateRequest As SetStateRequest =
                    New SetStateRequest With
                    {
                        .EntityMoniker = New EntityReference(Workflow.EntityLogicalName,
                                                             _processTemplateId),
                        .State = New OptionSetValue(CInt(Fix(WorkflowState.Draft))),
                        .Status = New OptionSetValue(1)
                    }
                _serviceProxy.Execute(deactivateRequest)
                _serviceProxy.Delete(Workflow.EntityLogicalName, _processTemplateId)
                Console.WriteLine("Entity records have been deleted.")
            End If
        End Sub

#End Region ' How-To Sample Code

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

				Dim app As New CreateProcessFromTemplate()
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
		#End Region ' Main method
	End Class
End Namespace

' </snippetcreateprocessfromtemplate>