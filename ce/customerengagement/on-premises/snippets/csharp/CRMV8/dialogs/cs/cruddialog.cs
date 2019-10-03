// <snippetcruddialog>


using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in the Microsoft.Crm.Sdk.Proxy.dll assembly
// located in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to create, retrieve, update, and delete.
    /// a dialog process.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class CRUDDialog
    {
        #region Class Level Members

        private Guid _dialogId;        
        private OrganizationServiceProxy _serviceProxy;

        /// <summary>
        /// TODO: Change the location and file name of the sample XAML file
        /// containing the dialog definition.
        /// e.g. Use the sample xml file located in the SDK\SampleCode\CS\Dialogs folder.
        /// </summary>
        String pathToXAML = Path.Combine(Environment.CurrentDirectory, @"CallCategorization.xml");
        
        #endregion Class Level Members

        #region How-To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// create, retrieve, update, and delete operations are performed on a  
        /// dialog process.
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

                    CreateRequiredRecords();
                    
                    // Define an anonymous type to define the possible values for 
                    // workflow category
                    var WorkflowCategory = new
                    {
                        Workflow = 0,
                        Dialog = 1
                    };
                    
                    // Instantiate a Workflow object.
                    // See the Entity Metadata topic in the SDK documentation to determine 
                    // which attributes must be set for each entity.
                    Workflow sampleDialog = new Workflow
                    {
                        Category = new OptionSetValue((int)WorkflowCategory.Dialog),
                        Name = "Sample Dialog: Call Categorization",
                        PrimaryEntity = PhoneCall.EntityLogicalName,

                        //Language code for U.S. English
                        LanguageCode = 1033,
                        Xaml = File.ReadAllText(pathToXAML)
                    };

                    // Create a dialog record.
                    _dialogId = _serviceProxy.Create(sampleDialog);
                    Console.Write("{0} created,", sampleDialog.Name);

                    // Activate the dialog.
                    SetStateRequest activateRequest = new SetStateRequest
                    {
                        EntityMoniker = new EntityReference(Workflow.EntityLogicalName, _dialogId),
                        State = new OptionSetValue((int)WorkflowState.Activated),
                        Status = new OptionSetValue(2)
                    };
                    _serviceProxy.Execute(activateRequest);
                    Console.WriteLine(" and activated.");

                    // Retrieve the dialog containing several of its attributes.
                    ColumnSet cols = new ColumnSet("name", "statecode", "statuscode");

                    Workflow retrievedDialog = (Workflow)_serviceProxy.Retrieve(Workflow.EntityLogicalName, _dialogId, cols);
                    Console.Write("Retrieved,");

                    // Update the dialog.
                    // Deactivate the dialog before you can update it.
                    SetStateRequest deactivateRequest = new SetStateRequest
                    {
                        EntityMoniker = new EntityReference(Workflow.EntityLogicalName, _dialogId),
                        State = new OptionSetValue((int)WorkflowState.Draft),
                        Status = new OptionSetValue(1)

                    };
                    _serviceProxy.Execute(deactivateRequest);

                    // Retrieve the dialog record again to get the unpublished 
                    // instance in order to update.
                    Workflow retrievedDialogDeactivated = (Workflow)_serviceProxy.Retrieve(Workflow.EntityLogicalName, _dialogId, cols);

                    // Update the dialog.
                    retrievedDialogDeactivated.Name = "Updated Dialog: Call Categorization";
                    _serviceProxy.Update(retrievedDialogDeactivated);

                    Console.Write(" updated,");

                    // Activate the dialog.
                    SetStateRequest updateActivateRequest = new SetStateRequest
                    {
                        EntityMoniker = new EntityReference(Workflow.EntityLogicalName, _dialogId),
                        State = new OptionSetValue((int)WorkflowState.Activated),
                        Status = new OptionSetValue(2)
                    };
                    _serviceProxy.Execute(updateActivateRequest);
                    Console.WriteLine(" and activated again.");

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
                // Deactivate the dialog, and then delete it.
                SetStateRequest deactivateRequest = new SetStateRequest
                {
                    EntityMoniker = new EntityReference(Workflow.EntityLogicalName, _dialogId),
                    State = new OptionSetValue((int)WorkflowState.Draft),
                    Status = new OptionSetValue(1),
                };
                _serviceProxy.Execute(deactivateRequest);
                _serviceProxy.Delete(Workflow.EntityLogicalName, _dialogId);
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

                CRUDDialog app = new CRUDDialog();
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
            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
        }
        #endregion Main method
    }
}

// </snippetcruddialog>