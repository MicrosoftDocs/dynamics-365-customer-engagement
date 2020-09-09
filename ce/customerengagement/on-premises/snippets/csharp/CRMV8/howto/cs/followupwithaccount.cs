// <snippetfollowupwithaccount>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Crm.Sdk.Samples;
using System.ServiceModel;

namespace FollowupWithAccount
{
    public class FollowupWithAccount
    {
        #region Class Level Members

        private Guid _accountId;
        private Guid _workflowId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// creates a follow-up task activity when a new account is created.
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
                using (_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig))
                {
                    _serviceProxy.EnableProxyTypes();                    

                    #region Create XAML

                    // Define the workflow XAML.
                    string xamlWF = @"<?xml version=""1.0"" encoding=""utf-16""?>
                    <Activity x:Class=""FollowupWithAccount"" xmlns=""https://schemas.microsoft.com/netfx/2009/xaml/activities"" xmlns:mva=""clr-namespace:Microsoft.VisualBasic.Activities;assembly=System.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:mxs=""clr-namespace:Microsoft.Xrm.Sdk;assembly=Microsoft.Xrm.Sdk, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:mxsw=""clr-namespace:Microsoft.Xrm.Sdk.Workflow;assembly=Microsoft.Xrm.Sdk.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:mxswa=""clr-namespace:Microsoft.Xrm.Sdk.Workflow.Activities;assembly=Microsoft.Xrm.Sdk.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:s=""clr-namespace:System;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:scg=""clr-namespace:System.Collections.Generic;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:srs=""clr-namespace:System.Runtime.Serialization;assembly=System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:this=""clr-namespace:"" xmlns:x=""https://schemas.microsoft.com/winfx/2006/xaml"">
                        <x:Members>
                        <x:Property Name=""InputEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />
                        <x:Property Name=""CreatedEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />
                        </x:Members>
                        <this:FollowupWithAccount.InputEntities>
                        <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />
                        </this:FollowupWithAccount.InputEntities>
                        <this:FollowupWithAccount.CreatedEntities>
                        <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />
                        </this:FollowupWithAccount.CreatedEntities>
                        <mva:VisualBasic.Settings>Assembly references and imported namespaces for internal implementation</mva:VisualBasic.Settings>
                        <mxswa:Workflow>
                        <Sequence DisplayName=""CreateStep1"">
                            <Sequence.Variables>
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_1"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_2"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_3"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_4"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_5"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_6"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_7"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_8"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_9"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_10"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_11"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_12"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_13"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_14"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_15"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_16"" />
                            <Variable x:TypeArguments=""mxsw:XrmTimeSpan"" Name=""CreateStep1_17"">
                                <Variable.Default>
                                <Literal x:TypeArguments=""mxsw:XrmTimeSpan"">
                                    <mxsw:XrmTimeSpan Days=""30"" Hours=""0"" Minutes=""0"" Months=""0"" Years=""0"" />
                                </Literal>
                                </Variable.Default>
                            </Variable>
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_18"" />
                            <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_19"" />
                            </Sequence.Variables>
                            <Assign x:TypeArguments=""mxs:Entity"" To=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" Value=""[New Entity(&amp;quot;task&amp;quot;)]"" />
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.String, ""Send e-mail to the "", ""String"" }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_2]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:GetEntityProperty Attribute=""accountid"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""account"" Value=""[CreateStep1_4]"">
                            <mxswa:GetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                                </InArgument>
                            </mxswa:GetEntityProperty.TargetType>
                            </mxswa:GetEntityProperty>
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_4 }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_3]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.String, ""&amp;amp;#160;customer."", ""String"" }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_5]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">Add</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_2, CreateStep1_3, CreateStep1_5 }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_1]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:SetEntityProperty Attribute=""subject"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""task"" Value=""[CreateStep1_1]"">
                            <mxswa:SetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                                </InArgument>
                            </mxswa:SetEntityProperty.TargetType>
                            </mxswa:SetEntityProperty>
                            <mxswa:GetEntityProperty Attribute=""accountid"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""account"" Value=""[CreateStep1_7]"">
                            <mxswa:GetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                                </InArgument>
                            </mxswa:GetEntityProperty.TargetType>
                            </mxswa:GetEntityProperty>
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_7 }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_6]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:SetEntityProperty Attribute=""regardingobjectid"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""task"" Value=""[CreateStep1_6]"">
                            <mxswa:SetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                                </InArgument>
                            </mxswa:SetEntityProperty.TargetType>
                            </mxswa:SetEntityProperty>
                            <mxswa:GetEntityProperty Attribute=""accountid"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""account"" Value=""[CreateStep1_9]"">
                            <mxswa:GetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                                </InArgument>
                            </mxswa:GetEntityProperty.TargetType>
                            </mxswa:GetEntityProperty>
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_9 }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_8]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:SetEntityProperty Attribute=""category"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""task"" Value=""[CreateStep1_8]"">
                            <mxswa:SetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
                                </InArgument>
                            </mxswa:SetEntityProperty.TargetType>
                            </mxswa:SetEntityProperty>
                            <mxswa:GetEntityProperty Attribute=""createdby"" Entity=""[InputEntities(&amp;quot;related_createdby#systemuser&amp;quot;)]"" EntityName=""systemuser"" Value=""[CreateStep1_11]"">
                            <mxswa:GetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                                </InArgument>
                            </mxswa:GetEntityProperty.TargetType>
                            </mxswa:GetEntityProperty>
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_11 }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_10]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:SetEntityProperty Attribute=""ownerid"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""task"" Value=""[CreateStep1_10]"">
                            <mxswa:SetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
                                </InArgument>
                            </mxswa:SetEntityProperty.TargetType>
                            </mxswa:SetEntityProperty>
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.OptionSetValue, ""1"", ""Picklist"" }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_12]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:SetEntityProperty Attribute=""prioritycode"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""task"" Value=""[CreateStep1_12]"">
                            <mxswa:SetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
                                </InArgument>
                            </mxswa:SetEntityProperty.TargetType>
                            </mxswa:SetEntityProperty>
                            <mxswa:GetEntityProperty Attribute=""createdon"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""account"" Value=""[CreateStep1_16]"">
                            <mxswa:GetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""s:DateTime"" />
                                </InArgument>
                            </mxswa:GetEntityProperty.TargetType>
                            </mxswa:GetEntityProperty>
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_16 }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""s:DateTime"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_15]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">Add</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_15, CreateStep1_17 }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""s:DateTime"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_14]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_14 }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""s:DateTime"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_13]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:SetEntityProperty Attribute=""scheduledend"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""task"" Value=""[CreateStep1_13]"">
                            <mxswa:SetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""s:DateTime"" />
                                </InArgument>
                            </mxswa:SetEntityProperty.TargetType>
                            </mxswa:SetEntityProperty>
                            <mxswa:GetEntityProperty Attribute=""createdon"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""account"" Value=""[CreateStep1_19]"">
                            <mxswa:GetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""s:DateTime"" />
                                </InArgument>
                            </mxswa:GetEntityProperty.TargetType>
                            </mxswa:GetEntityProperty>
                            <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
                            <mxswa:ActivityReference.Arguments>
                                <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
                                <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_19 }]</InArgument>
                                <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""s:DateTime"" />
                                </InArgument>
                                <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_18]</OutArgument>
                            </mxswa:ActivityReference.Arguments>
                            </mxswa:ActivityReference>
                            <mxswa:SetEntityProperty Attribute=""scheduledstart"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""task"" Value=""[CreateStep1_18]"">
                            <mxswa:SetEntityProperty.TargetType>
                                <InArgument x:TypeArguments=""s:Type"">
                                <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""s:DateTime"" />
                                </InArgument>
                            </mxswa:SetEntityProperty.TargetType>
                            </mxswa:SetEntityProperty>
                            <mxswa:CreateEntity EntityId=""{x:Null}"" DisplayName=""CreateStep1"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""task"" />
                            <Assign x:TypeArguments=""mxs:Entity"" To=""[CreatedEntities(&amp;quot;CreateStep1_localParameter&amp;quot;)]"" Value=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" />
                            <Persist />
                        </Sequence>
                        </mxswa:Workflow>
                    </Activity>";

                    #endregion Create XAML

                    #region Create Workflow

                    // Create the workflow.
                    Workflow workflow = new Workflow()
                    {
                        Name = "SampleFollowupWithAccountWorkflow",
                        Type = new OptionSetValue((int)WorkflowType.Definition),       
                        Category = new OptionSetValue((int)WorkflowCategory.Workflow),
                        Scope = new OptionSetValue((int)WorkflowScope.User),     
                        LanguageCode = 1033,                // U.S. English
                        TriggerOnCreate = true,
                        OnDemand = true,
                        PrimaryEntity = Account.EntityLogicalName,
                        Description = @"Follow up with the customer. Check if there are any new issues that need resolution.",
                        Xaml = xamlWF
                    };
                    _workflowId = _serviceProxy.Create(workflow);

                    Console.WriteLine("Created Workflow: " + workflow.Name);

                    #endregion Create Workflow

                    #region Activate Workflow

                    // Activate the workflow.
                    var activateRequest = new SetStateRequest
                    {
                        EntityMoniker = new EntityReference
                            (Workflow.EntityLogicalName, _workflowId),
                        State = new OptionSetValue((int)WorkflowState.Activated),
                        Status = new OptionSetValue((int)workflow_statuscode.Activated)
                    };
                    _serviceProxy.Execute(activateRequest);
                    Console.WriteLine("Activated Workflow: " + workflow.Name);
                    
                    #endregion Activate Workflow

                    #region Create Account Record

                    CreateRequiredRecords();

                    #endregion Create Account Record

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
            // For this sample, all required entities are created in the Run() method.


            // Instantiate an account object. Note the use of the option set enumerations defined in OptionSets.cs.
            // See the Entity Metadata topic in the SDK documentation to determine 
            // which attributes must be set for each entity.
            Account account = new Account { Name = "Fourth Coffee" };
            account.AccountCategoryCode = new OptionSetValue((int)AccountAccountCategoryCode.PreferredCustomer);
            account.CustomerTypeCode = new OptionSetValue((int)AccountCustomerTypeCode.Investor);

            // Create an account record named Sample Fourth Coffee.
            _accountId = _serviceProxy.Create(account);

            Console.Write("{0} {1} is created, ", "Account :", account.Name);
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
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId);
                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion How To Sample Code

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

                FollowupWithAccount app = new FollowupWithAccount();
                app.Run(config, true);
            }

            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Trace: {0}", ex.Detail.TraceText);
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
                        Console.WriteLine("Trace: {0}", fe.Detail.TraceText);
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

// </snippetfollowupwithaccount>