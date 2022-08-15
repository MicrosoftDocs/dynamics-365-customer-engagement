// <snippetcreateaworkflow>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

// These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to use C# code to define a new workflow in Microsoft Dynamics CRM.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class CreateAWorkflow
    {
        #region Class Level Members

        private Guid _workflowId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        /// <summary>
        /// This method first creates XAML to define the custom workflow. Afterwards, 
        /// it creates the workflow record with this XAML and then activates it.
        /// </summary>
        /// <remarks>
        /// Visit https://msdn.microsoft.com/library/gg309458.aspx 
        /// for instructions on enabling XAML workflows on the Microsoft Dynamics CRM server.
        /// </remarks>
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
                
                    CreateRequiredRecords();

                    #region Create XAML

                    // Define the workflow XAML.
                    string xamlWF;

                    xamlWF = @"<?xml version=""1.0"" encoding=""utf-16""?>
                        <Activity x:Class=""SampleWF"" 
                                  xmlns=""https://schemas.microsoft.com/netfx/2009/xaml/activities"" 
                                  xmlns:mva=""clr-namespace:Microsoft.VisualBasic.Activities;assembly=System.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" 
                                  xmlns:mxs=""clr-namespace:Microsoft.Xrm.Sdk;assembly=Microsoft.Xrm.Sdk, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" 
                                  xmlns:mxswa=""clr-namespace:Microsoft.Xrm.Sdk.Workflow.Activities;assembly=Microsoft.Xrm.Sdk.Workflow, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"" 
                                  xmlns:s=""clr-namespace:System;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" 
                                  xmlns:scg=""clr-namespace:System.Collections.Generic;assembly=mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" 
                                  xmlns:srs=""clr-namespace:System.Runtime.Serialization;assembly=System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089""                                  
                                  xmlns:this=""clr-namespace:"" xmlns:x=""https://schemas.microsoft.com/winfx/2006/xaml"">
                            <x:Members>
                                <x:Property Name=""InputEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />
                                <x:Property Name=""CreatedEntities"" Type=""InArgument(scg:IDictionary(x:String, mxs:Entity))"" />
                            </x:Members>
                            <this:SampleWF.InputEntities>
                                <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />
                            </this:SampleWF.InputEntities>
                            <this:SampleWF.CreatedEntities>
                              <InArgument x:TypeArguments=""scg:IDictionary(x:String, mxs:Entity)"" />
                           </this:SampleWF.CreatedEntities>
                            <mva:VisualBasic.Settings>Assembly references and imported namespaces for internal implementation</mva:VisualBasic.Settings>
                            <mxswa:Workflow>
                                <Sequence>
                                    <Sequence.Variables>
                                        <Variable x:TypeArguments=""x:Int32"" Default=""[40]"" Name=""probability_value"" />
                                        <Variable x:TypeArguments=""mxs:Entity"" Default=""[CreatedEntities(&amp;quot;primaryEntity#Temp&amp;quot;)]"" Name=""CreatedEntity"" />
                                    </Sequence.Variables>
                                    <Assign x:TypeArguments=""mxs:Entity"" To=""[CreatedEntity]"" Value=""[New Entity(&amp;quot;opportunity&amp;quot;)]"" />
                                    <Assign x:TypeArguments=""s:Guid"" To=""[CreatedEntity.Id]"" Value=""[InputEntities(&amp;quot;primaryEntity&amp;quot;).Id]"" />
                                    <mxswa:SetEntityProperty Attribute=""closeprobability"" Entity=""[CreatedEntity]"" 
                                        EntityName=""opportunity"" TargetType=""[Type.GetType(&amp;quot;probability_value&amp;quot;)]"" 
                                                       Value=""[probability_value]"">
                                    </mxswa:SetEntityProperty>
                                    <mxswa:UpdateEntity Entity=""[CreatedEntity]"" EntityName=""opportunity"" />
                                    <Assign x:TypeArguments=""mxs:Entity"" To=""[InputEntities(&amp;quot;primaryEntity&amp;quot;)]"" Value=""[CreatedEntity]"" />
                                    <Persist />
                                </Sequence>
                            </mxswa:Workflow>
                        </Activity>";

                    #endregion Create XAML

                    #region Create Workflow

                    // Create an asynchronous workflow.
                    // The workflow should execute after a new opportunity is created.
                    Workflow workflow = new Workflow()
                    {
                        // These properties map to the New Process form settings in the web application.
                        Name = "Set closeprobability on opportunity create (async)",
                        Type = new OptionSetValue((int)WorkflowType.Definition),
                        Category = new OptionSetValue((int)WorkflowCategory.Workflow),
                        PrimaryEntity = Opportunity.EntityLogicalName,
                        Mode = new OptionSetValue((int)WorkflowMode.Background),

                        // Additional settings from the second New Process form.
                        Description = @"When an opportunity is created, this workflow" +
                            " sets the closeprobability field of the opportunity record to 40%.",
                        OnDemand = false,
                        Subprocess = false,
                        Scope = new OptionSetValue((int)WorkflowScope.User),
                        TriggerOnCreate = true,
                        AsyncAutoDelete = true,
                        Xaml = xamlWF,

                        // Other properties not in the web forms.
                        LanguageCode = 1033,  // U.S. English                        
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

        #region Class methods

        /// <summary>
        /// Creates any entity records that this sample requires.
        /// </summary>
        public void CreateRequiredRecords()
        {

        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool toBeDeleted = true;

            if (prompt)
            {
                // Ask the user if the created entities should be deleted.
                Console.Write("\nDo you want these entity records deleted? (y/n) [y]: ");
                String answer = Console.ReadLine();
                if (answer.StartsWith("y") ||
                    answer.StartsWith("Y") ||
                    answer == String.Empty)
                {
                    toBeDeleted = true;
                }
                else
                {
                    toBeDeleted = false;
                }
            }

            if (toBeDeleted)
            {

                // Deactivate and delete workflow
                SetStateRequest deactivateRequest = new SetStateRequest
                {
                    EntityMoniker = new EntityReference(Workflow.EntityLogicalName, _workflowId),
                    State = new OptionSetValue((int)WorkflowState.Draft),
                    Status = new OptionSetValue((int)workflow_statuscode.Draft)
                };
                _serviceProxy.Execute(deactivateRequest);
                _serviceProxy.Delete(Workflow.EntityLogicalName, _workflowId);
                Console.WriteLine("Workflow has been deactivated and deleted.");

            }
        }

        #endregion Class methods

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

                CreateAWorkflow app = new CreateAWorkflow();
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

// </snippetcreateaworkflow>