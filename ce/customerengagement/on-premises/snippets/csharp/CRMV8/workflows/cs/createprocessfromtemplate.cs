// <snippetcreateprocessfromtemplate>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Create a Workflow Process from an existing Process Template.
    /// </summary>
    public class CreateProcessFromTemplate
    {

        #region Class Level Members

        private Guid _processTemplateId;
        private Guid _processId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How-To Sample Code
        /// <summary>
        /// Demonstrates how to programmatically create a Workflow from an existing
        /// Process Template.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
        {
            try
            {
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                                     serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    OrganizationServiceContext _orgContext = new OrganizationServiceContext(_serviceProxy);

                    CreateRequiredRecords();

                    CreateWorkflowFromTemplateRequest request = new CreateWorkflowFromTemplateRequest()
                    {
                        WorkflowName = "Workflow From Template",
                        WorkflowTemplateId = _processTemplateId
                    };

                    // Execute request.
                    CreateWorkflowFromTemplateResponse response = (CreateWorkflowFromTemplateResponse)_serviceProxy.Execute(request);
                    _processId = response.Id;

                    // Verify success.
                    // Retrieve the name of the workflow.
                    ColumnSet cols = new ColumnSet("name");
                    Workflow newWorkflow = (Workflow)_serviceProxy.Retrieve(Workflow.EntityLogicalName, response.Id, cols);
                    if (newWorkflow.Name == "Workflow From Template")
                    {
                        Console.WriteLine("Created {0}.", request.WorkflowName);
                    }

                    DeleteRequiredRecords(promptforDelete);
                }
            }

            // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
            {
                // You can handle an exception here or pass it back to the calling method.
                throw;
            }
        }

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {

            // Define an anonymous type to define the possible values for
            // process type
            var ProcessType = new
            {
                Definition = 1,
                Activation = 2,
                Template = 3
            };

            // Define an anonymous type to define the possible values for
            // process category
            var ProcessCategory = new
            {
                Workflow = 0,
                Dialog = 1,
            };

            // Define an anonymous type to define the possible values for
            // process scope
            var ProcessScope = new
            {
                User = 1,
                BusinessUnit = 2,
                Deep = 3,
                Global = 4
            };

            // Create the Workflow template that we will use to generate the Workflow.
            Workflow processTemplate = new Workflow()
            {
                Name = "Sample Process Template",
                Type = new OptionSetValue(ProcessType.Template),
                Category = new OptionSetValue(ProcessCategory.Workflow),
                Scope = new OptionSetValue(ProcessScope.User),

                //Language code for U.S. English
                LanguageCode = 1033,
                TriggerOnCreate = true,
                OnDemand = false,
                PrimaryEntity = Account.EntityLogicalName,
                Xaml =
@"<?xml version=""1.0"" encoding=""utf-16""?>
<Activity x:Class=""SampleWorkflow"" xmlns=""https://schemas.microsoft.com/netfx/2009/xaml/activities"" xmlns:mva=""clr-namespace:Microsoft.VisualBasic.Activities;assembly=System.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:mxs=""clr-namespace:Microsoft.Xrm.Sdk;assembly=Microsoft.Xrm.Sdk, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:mxsq=""clr-namespace:Microsoft.Xrm.Sdk.Query;assembly=Microsoft.Xrm.Sdk, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:mxswa=""clr-namespace:Microsoft.Xrm.Sdk.Workflow.Activities;assembly=Microsoft.Xrm.Sdk.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:s=""clr-namespace:System;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:scg=""clr-namespace:System.Collections.Generic;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:sco=""clr-namespace:System.Collections.ObjectModel;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:srs=""clr-namespace:System.Runtime.Serialization;assembly=System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:this=""clr-namespace:"" xmlns:x=""https://schemas.microsoft.com/winfx/2006/xaml"">
  <x:Members>
    <x:Property Name=""InputEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />
    <x:Property Name=""CreatedEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />
  </x:Members>
  <this:SampleWorkflow.InputEntities>
    <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />
  </this:SampleWorkflow.InputEntities>
  <this:SampleWorkflow.CreatedEntities>
    <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />
  </this:SampleWorkflow.CreatedEntities>
  <mva:VisualBasic.Settings>Assembly references and imported namespaces for internal implementation</mva:VisualBasic.Settings>
  <mxswa:Workflow>
    <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.ConditionSequence, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""ConditionStep1: If Account Name is in the &amp;quot;Sample&amp;quot; family"">
      <mxswa:ActivityReference.Arguments>
        <InArgument x:TypeArguments=""x:Boolean"" x:Key=""Wait"">False</InArgument>
      </mxswa:ActivityReference.Arguments>
      <mxswa:ActivityReference.Properties>
        <sco:Collection x:TypeArguments=""Variable"" x:Key=""Variables"">
          <Variable x:TypeArguments=""x:Boolean"" Default=""False"" Name=""ConditionBranchStep2_condition"" />
          <Variable x:TypeArguments=""x:Object"" Name=""ConditionBranchStep2_1"" />
          <Variable x:TypeArguments=""x:Object"" Name=""ConditionBranchStep2_2"" />
        </sco:Collection>
        <sco:Collection x:TypeArguments=""Activity"" x:Key=""Activities"">
          <mxswa:GetEntityProperty Attribute=""name"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""account"" Value=""[ConditionBranchStep2_1]"">
            <mxswa:GetEntityProperty.TargetType>
              <InArgument x:TypeArguments=""s:Type"">
                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"">
                  <x:Null />
                </mxswa:ReferenceLiteral>
              </InArgument>
            </mxswa:GetEntityProperty.TargetType>
          </mxswa:GetEntityProperty>
          <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
            <mxswa:ActivityReference.Arguments>
              <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
              <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.String, ""Sample"", ""String"" }]</InArgument>
              <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
              </InArgument>
              <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[ConditionBranchStep2_2]</OutArgument>
            </mxswa:ActivityReference.Arguments>
          </mxswa:ActivityReference>
          <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateCondition, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateCondition"">
            <mxswa:ActivityReference.Arguments>
              <InArgument x:TypeArguments=""mxsq:ConditionOperator"" x:Key=""ConditionOperator"">Contains</InArgument>
              <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { ConditionBranchStep2_2 }]</InArgument>
              <InArgument x:TypeArguments=""x:Object"" x:Key=""Operand"">[ConditionBranchStep2_1]</InArgument>
              <OutArgument x:TypeArguments=""x:Boolean"" x:Key=""Result"">[ConditionBranchStep2_condition]</OutArgument>
            </mxswa:ActivityReference.Arguments>
          </mxswa:ActivityReference>
          <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.ConditionBranch, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""ConditionBranchStep2"">
            <mxswa:ActivityReference.Arguments>
              <InArgument x:TypeArguments=""x:Boolean"" x:Key=""Condition"">[ConditionBranchStep2_condition]</InArgument>
            </mxswa:ActivityReference.Arguments>
            <mxswa:ActivityReference.Properties>
              <mxswa:ActivityReference x:Key=""Then"" AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.Composite, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""ConditionBranchStep2"">
                <mxswa:ActivityReference.Properties>
                  <sco:Collection x:TypeArguments=""Variable"" x:Key=""Variables"" />
                  <sco:Collection x:TypeArguments=""Activity"" x:Key=""Activities"">
                    <Sequence DisplayName=""CreateStep3: Add new contact for Nancy Anderson at new account."">
                      <Sequence.Variables>
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_1"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_2"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_3"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_4"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_5"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_6"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_7"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_8"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_9"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_10"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_11"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_12"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_13"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_14"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_15"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_16"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_17"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_18"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_19"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_20"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_21"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_22"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_23"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_24"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_25"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_26"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_27"" />
                        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep3_28"" />
                      </Sequence.Variables>
                      <Assign x:TypeArguments=""mxs:Entity"" To=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" Value=""[New Entity(&amp;quot;contact&amp;quot;)]"" />
                      <mxswa:GetEntityProperty Attribute=""telephone1"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""account"" Value=""[CreateStep3_2]"">
                        <mxswa:GetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                          </InArgument>
                        </mxswa:GetEntityProperty.TargetType>
                      </mxswa:GetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep3_2 }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_1]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""telephone1"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_1]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.String, ""Nancy"", ""String"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_3]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""firstname"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_3]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.String, ""Anderson"", ""String"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_4]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""lastname"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_4]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:GetEntityProperty Attribute=""accountid"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""account"" Value=""[CreateStep3_6]"">
                        <mxswa:GetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                          </InArgument>
                        </mxswa:GetEntityProperty.TargetType>
                      </mxswa:GetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep3_6 }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_5]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""parentcustomerid"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_5]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:GetEntityProperty Attribute=""transactioncurrencyid"" Entity=""[InputEntities(&amp;quot;related_transactioncurrencyid#transactioncurrency&amp;quot;)]"" EntityName=""transactioncurrency"" Value=""[CreateStep3_8]"">
                        <mxswa:GetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                          </InArgument>
                        </mxswa:GetEntityProperty.TargetType>
                      </mxswa:GetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep3_8 }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_7]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""transactioncurrencyid"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_7]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_9]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""creditonhold"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_9]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_10]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""preferredcontactmethodcode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_10]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_11]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""donotemail"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_11]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_12]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""donotbulkemail"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_12]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_13]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""donotphone"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_13]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_14]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""donotfax"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_14]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_15]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""donotpostalmail"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_15]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_16]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""donotsendmm"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_16]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_17]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""preferredappointmenttimecode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_17]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_18]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""address2_addresstypecode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_18]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_19]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""address2_freighttermscode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_19]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_20]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""address2_shippingmethodcode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_20]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_21]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""customersizecode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_21]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_22]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""customertypecode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_22]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_23]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""educationcode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_23]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_24]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""haschildrencode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_24]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""False"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_25]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""isbackofficecustomer"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_25]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_26]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""leadsourcecode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_26]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_27]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""shippingmethodcode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_27]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                        <mxswa:ActivityReference.Arguments>
                          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep3_28]</OutArgument>
                        </mxswa:ActivityReference.Arguments>
                      </mxswa:ActivityReference>
                      <mxswa:SetEntityProperty Attribute=""territorycode"" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" Value=""[CreateStep3_28]"">
                        <mxswa:SetEntityProperty.TargetType>
                          <InArgument x:TypeArguments=""s:Type"">
                            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                          </InArgument>
                        </mxswa:SetEntityProperty.TargetType>
                      </mxswa:SetEntityProperty>
                      <mxswa:CreateEntity EntityId=""{x:Null}"" DisplayName=""CreateStep3: Add new contact for Nancy Anderson at new account."" Entity=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" EntityName=""contact"" />
                      <Assign x:TypeArguments=""mxs:Entity"" To=""[CreatedEntities(&amp;quot;CreateStep3_localParameter&amp;quot;)]"" Value=""[CreatedEntities(&amp;quot;CreateStep3_localParameter#Temp&amp;quot;)]"" />
                      <Persist />
                    </Sequence>
                  </sco:Collection>
                </mxswa:ActivityReference.Properties>
              </mxswa:ActivityReference>
              <x:Null x:Key=""Else"" />
            </mxswa:ActivityReference.Properties>
          </mxswa:ActivityReference>
        </sco:Collection>
      </mxswa:ActivityReference.Properties>
    </mxswa:ActivityReference>
  </mxswa:Workflow>
</Activity>"
             };
            _processTemplateId = _serviceProxy.Create(processTemplate);

            Console.Write("Created {0},", processTemplate.Name);

            // Activate the process template
            SetStateRequest activateRequest = new SetStateRequest
            {
                EntityMoniker = new EntityReference(Workflow.EntityLogicalName, _processTemplateId),
                State = new OptionSetValue((int)WorkflowState.Activated),
                Status = new OptionSetValue(2)
            };
            _serviceProxy.Execute(activateRequest);
            Console.WriteLine(" and activated.");

        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
            }

            if (deleteRecords)
            {
                _serviceProxy.Delete(Workflow.EntityLogicalName, _processId);

                // Deactivate the process template before you can delete it.
                SetStateRequest deactivateRequest = new SetStateRequest
                {
                    EntityMoniker = new EntityReference(Workflow.EntityLogicalName, _processTemplateId),
                    State = new OptionSetValue((int)WorkflowState.Draft),
                    Status = new OptionSetValue(1)
                };
                _serviceProxy.Execute(deactivateRequest);
                _serviceProxy.Delete(Workflow.EntityLogicalName, _processTemplateId);
                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion How-To Sample Code

        #region Main method

        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                CreateProcessFromTemplate app = new CreateProcessFromTemplate();
                app.Run(config, true);
            }
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
            }
            catch (System.TimeoutException ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.InnerException.Message ? "No Inner Fault" : ex.InnerException.Message);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine(ex.Message);

                // Display the details of the inner exception.
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = ex.InnerException
                        as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
                    if (fe != null)
                    {
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
                        Console.WriteLine("Message: {0}", fe.Detail.Message);
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText);
                        Console.WriteLine("Inner Fault: {0}",
                            null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
                    }
                }
            }
            // Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            // SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
        }
        #endregion Main method
    }
}

// </snippetcreateprocessfromtemplate>