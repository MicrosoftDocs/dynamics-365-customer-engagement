// <snippetexecuteworkflow>


using System;
using System.Linq;
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
    /// Execute a workflow programmatically.
    /// </summary>
    public class ExecuteWorkflow
    {

        #region Class Level Members

        private Guid _workflowId;
        private Guid _leadId;
        private Guid _asyncOperationId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How-To Sample Code
        /// <summary>
        /// Demonstrates how to programmatically execute a workflow.
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
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();

                    OrganizationServiceContext _orgContext = new OrganizationServiceContext(_serviceProxy);

                    CreateRequiredRecords();

                    // Create an ExecuteWorkflow request.
                    ExecuteWorkflowRequest request = new ExecuteWorkflowRequest()
                    {
                        WorkflowId = _workflowId,
                        EntityId = _leadId
                    };
                    Console.Write("Created ExecuteWorkflow request, ");

                    // Execute the workflow.
                    ExecuteWorkflowResponse response =
                        (ExecuteWorkflowResponse)_serviceProxy.Execute(request);
                    Console.WriteLine("and sent request to service.");


                    #region Check success

                    ColumnSet cols = new ColumnSet("statecode");
                    QueryByAttribute retrieveOpQuery = new QueryByAttribute();
                    retrieveOpQuery.EntityName = AsyncOperation.EntityLogicalName;
                    retrieveOpQuery.ColumnSet = cols;
                    retrieveOpQuery.AddAttributeValue("asyncoperationid", response.Id);

                    // Wait for the asyncoperation to complete.
                    // (wait no longer than 1 minute)
                    for (int i = 0; i < 60; i++)
                    {
                        System.Threading.Thread.Sleep(1000);

                        EntityCollection retrieveOpResults =
                            _serviceProxy.RetrieveMultiple(retrieveOpQuery);

                        if (retrieveOpResults.Entities.Count() > 0)
                        {
                            AsyncOperation op =
                                (AsyncOperation)retrieveOpResults.Entities[0];
                            if (op.StateCode == AsyncOperationState.Completed)
                            {
                                _asyncOperationId = op.AsyncOperationId.Value;
                                Console.WriteLine("AsyncOperation completed successfully.");
                                break;
                            }
                        }

                        if (i == 59)
                        {
                            throw new TimeoutException("AsyncOperation failed to complete in under one minute.");
                        }
                    }

                    // Retrieve the task that was created by the workflow.
                    cols = new ColumnSet("activityid");
                    QueryByAttribute retrieveActivityQuery = new QueryByAttribute();
                    retrieveActivityQuery.EntityName = PhoneCall.EntityLogicalName;
                    retrieveActivityQuery.ColumnSet = cols;
                    retrieveActivityQuery.AddAttributeValue("subject", "First call to Diogo Andrade");
                    
                    EntityCollection results = 
                        _serviceProxy.RetrieveMultiple(retrieveActivityQuery);

                    if (results.Entities.Count() == 0)
                    {
                        throw new InvalidOperationException("Phone call activity was not successfully created");
                    }
                    else
                    {
                        Console.WriteLine("Phone call activity successfully created from workflow.");
                    }

                    #endregion Check success

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
            // Create a Lead record on which we will execute the Workflow.
            Lead lead = new Lead()
            {
                FirstName = "Diogo",
                LastName = "Andrade"
            };
            _leadId = _serviceProxy.Create(lead);
            Console.WriteLine("Created Lead for workflow request.");

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

            // Create the Workflow that we will execute.
            Workflow workflow = new Workflow()
            {
                Name = "Sample Workflow", // friendly name of the record
                Type = new OptionSetValue(ProcessType.Definition),
                Category = new OptionSetValue(ProcessCategory.Workflow),
                Scope = new OptionSetValue(ProcessScope.User),
                OnDemand = true,
                PrimaryEntity = Lead.EntityLogicalName,
                Xaml =
@"<?xml version=""1.0"" encoding=""utf-16""?>
<Activity x:Class=""ExecuteWorkflowSample"" xmlns=""https://schemas.microsoft.com/netfx/2009/xaml/activities"" xmlns:mva=""clr-namespace:Microsoft.VisualBasic.Activities;assembly=System.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:mxs=""clr-namespace:Microsoft.Xrm.Sdk;assembly=Microsoft.Xrm.Sdk, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:mxswa=""clr-namespace:Microsoft.Xrm.Sdk.Workflow.Activities;assembly=Microsoft.Xrm.Sdk.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" xmlns:s=""clr-namespace:System;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:scg=""clr-namespace:System.Collections.Generic;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:srs=""clr-namespace:System.Runtime.Serialization;assembly=System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" xmlns:this=""clr-namespace:"" xmlns:x=""https://schemas.microsoft.com/winfx/2006/xaml"">
  <x:Members>
    <x:Property Name=""InputEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />
    <x:Property Name=""CreatedEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />
  </x:Members>
  <this:ExecuteWorkflowSample.InputEntities>
    <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />
  </this:ExecuteWorkflowSample.InputEntities>
  <this:ExecuteWorkflowSample.CreatedEntities>
    <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />
  </this:ExecuteWorkflowSample.CreatedEntities>
  <mva:VisualBasic.Settings>Assembly references and imported namespaces for internal implementation</mva:VisualBasic.Settings>
  <mxswa:Workflow>
    <Assign x:TypeArguments=""mxs:Entity"" To=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" Value=""[New Entity(&amp;quot;phonecall&amp;quot;)]"" />
    <Sequence DisplayName=""CreateStep1: Set first activity for lead."">
      <Sequence.Variables>
        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_1"" />
        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_2"" />
        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_3"" />
        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_4"" />
        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_5"" />
        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_6"" />
        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_7"" />
        <Variable x:TypeArguments=""x:Object"" Name=""CreateStep1_8"" />
      </Sequence.Variables>
      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
        <mxswa:ActivityReference.Arguments>
          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.Boolean, ""True"" }]</InArgument>
          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
          </InArgument>
          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_1]</OutArgument>
        </mxswa:ActivityReference.Arguments>
      </mxswa:ActivityReference>
      <mxswa:SetEntityProperty Attribute=""directioncode"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""phonecall"" Value=""[CreateStep1_1]"">
        <mxswa:SetEntityProperty.TargetType>
          <InArgument x:TypeArguments=""s:Type"">
            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:Boolean"" />
          </InArgument>
        </mxswa:SetEntityProperty.TargetType>
      </mxswa:SetEntityProperty>
      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
        <mxswa:ActivityReference.Arguments>
          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">CreateCrmType</InArgument>
          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { Microsoft.Xrm.Sdk.Workflow.WorkflowPropertyType.String, ""First call to "", ""String"" }]</InArgument>
          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
          </InArgument>
          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_3]</OutArgument>
        </mxswa:ActivityReference.Arguments>
      </mxswa:ActivityReference>
      <mxswa:GetEntityProperty Attribute=""fullname"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""lead"" Value=""[CreateStep1_5]"">
        <mxswa:GetEntityProperty.TargetType>
          <InArgument x:TypeArguments=""s:Type"">
            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
          </InArgument>
        </mxswa:GetEntityProperty.TargetType>
      </mxswa:GetEntityProperty>
      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
        <mxswa:ActivityReference.Arguments>
          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_5 }]</InArgument>
          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
          </InArgument>
          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_4]</OutArgument>
        </mxswa:ActivityReference.Arguments>
      </mxswa:ActivityReference>
      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
        <mxswa:ActivityReference.Arguments>
          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">Add</InArgument>
          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_3, CreateStep1_4 }]</InArgument>
          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
          </InArgument>
          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_2]</OutArgument>
        </mxswa:ActivityReference.Arguments>
      </mxswa:ActivityReference>
      <mxswa:SetEntityProperty Attribute=""subject"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""phonecall"" Value=""[CreateStep1_2]"">
        <mxswa:SetEntityProperty.TargetType>
          <InArgument x:TypeArguments=""s:Type"">
            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""x:String"" />
          </InArgument>
        </mxswa:SetEntityProperty.TargetType>
      </mxswa:SetEntityProperty>
      <mxswa:GetEntityProperty Attribute=""leadid"" Entity=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" EntityName=""lead"" Value=""[CreateStep1_7]"">
        <mxswa:GetEntityProperty.TargetType>
          <InArgument x:TypeArguments=""s:Type"">
            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
          </InArgument>
        </mxswa:GetEntityProperty.TargetType>
      </mxswa:GetEntityProperty>
      <mxswa:ActivityReference AssemblyQualifiedName=""Microsoft.Crm.Workflow.Activities.EvaluateExpression, Microsoft.Crm.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" DisplayName=""EvaluateExpression"">
        <mxswa:ActivityReference.Arguments>
          <InArgument x:TypeArguments=""x:String"" x:Key=""ExpressionOperator"">SelectFirstNonNull</InArgument>
          <InArgument x:TypeArguments=""s:Object[]"" x:Key=""Parameters"">[New Object() { CreateStep1_7 }]</InArgument>
          <InArgument x:TypeArguments=""s:Type"" x:Key=""TargetType"">
            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
          </InArgument>
          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_6]</OutArgument>
        </mxswa:ActivityReference.Arguments>
      </mxswa:ActivityReference>
      <mxswa:SetEntityProperty Attribute=""regardingobjectid"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""phonecall"" Value=""[CreateStep1_6]"">
        <mxswa:SetEntityProperty.TargetType>
          <InArgument x:TypeArguments=""s:Type"">
            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:EntityReference"" />
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
          <OutArgument x:TypeArguments=""x:Object"" x:Key=""Result"">[CreateStep1_8]</OutArgument>
        </mxswa:ActivityReference.Arguments>
      </mxswa:ActivityReference>
      <mxswa:SetEntityProperty Attribute=""prioritycode"" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""phonecall"" Value=""[CreateStep1_8]"">
        <mxswa:SetEntityProperty.TargetType>
          <InArgument x:TypeArguments=""s:Type"">
            <mxswa:ReferenceLiteral x:TypeArguments=""s:Type"" Value=""mxs:OptionSetValue"" />
          </InArgument>
        </mxswa:SetEntityProperty.TargetType>
      </mxswa:SetEntityProperty>
      <mxswa:CreateEntity EntityId=""{x:Null}"" DisplayName=""CreateStep1: Set first activity for lead."" Entity=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" EntityName=""phonecall"" />
      <Assign x:TypeArguments=""mxs:Entity"" To=""[CreatedEntities(&amp;quot;CreateStep1_localParameter&amp;quot;)]"" Value=""[CreatedEntities(&amp;quot;CreateStep1_localParameter#Temp&amp;quot;)]"" />
      <Persist />
    </Sequence>
  </mxswa:Workflow>
</Activity>"
            };
            _workflowId = _serviceProxy.Create(workflow);
            Console.Write("Created workflow to call in Execute Workflow request, ");

            SetStateRequest setStateRequest = new SetStateRequest()
            {
                EntityMoniker =
                    new EntityReference(Workflow.EntityLogicalName, _workflowId),
                State = new OptionSetValue((int)WorkflowState.Activated),
                Status = new OptionSetValue(2)
            };
            _serviceProxy.Execute(setStateRequest);
            Console.WriteLine("and activated.");
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
                SetStateRequest setStateRequest = new SetStateRequest()
                {
                    EntityMoniker =
                        new EntityReference(Workflow.EntityLogicalName, _workflowId),
                    State = new OptionSetValue((int)WorkflowState.Draft),
                    Status = new OptionSetValue(1)
                };
                _serviceProxy.Execute(setStateRequest);

                _serviceProxy.Delete(Workflow.EntityLogicalName, _workflowId);
                _serviceProxy.Delete(Lead.EntityLogicalName, _leadId);
                _serviceProxy.Delete(AsyncOperation.EntityLogicalName, _asyncOperationId);
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

                ExecuteWorkflow app = new ExecuteWorkflow();
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

// </snippetexecuteworkflow>