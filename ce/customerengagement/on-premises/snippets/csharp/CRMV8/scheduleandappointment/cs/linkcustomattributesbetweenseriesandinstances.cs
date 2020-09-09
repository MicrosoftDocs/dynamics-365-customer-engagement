// <snippetlinkcustomattributesbetweenseriesandinstances>


using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to custom attribute created for 
    /// recurring appointment series with a custom attribute 
    /// created for the appointment instances.
    /// </summary>
    public class LinkCustomAttributesBetweenSeriesandInstances
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs as well as strings needed for this sample.
        public Guid _instanceAttributeID;
        public Guid _seriesAttributeID;
        
        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate the method to create any data that this sample requires.
        /// Link the custom attributes.
        /// Optionally delete any entity records that were created for this sample.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
        {
            try
            {
                 
                // Connect to the Organization service. 
                // The using statement assures that the service proxy will be properly disposed.
                using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
                {
                    // This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes();



                    // Create a custom string attribute for the appointment instance
                    StringAttributeMetadata customAppointmentInstanceAttribute = new StringAttributeMetadata
                    {
                        LogicalName = "new_customAppInstanceAttribute",
                        DisplayName = new Label("CustomAppInstanceAttribute", 1033),
                        Description = new Label("Sample Custom Appointment Instance Attribute", 1033),
                        MaxLength = 500,
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        SchemaName = "new_customAppInstanceAttribute"
                    };

                    CreateAttributeRequest instanceAttributeRequest = new CreateAttributeRequest
                    {
                        Attribute = customAppointmentInstanceAttribute,
                        EntityName = "appointment"
                    };

                    CreateAttributeResponse instanceAttributeResponse = (CreateAttributeResponse)_serviceProxy.Execute(instanceAttributeRequest);
                    _instanceAttributeID = instanceAttributeResponse.AttributeId;

                    // Create a custom string attribute for the recurring appointment master (series)
                    StringAttributeMetadata customAppointmentSeriesAttribute = new StringAttributeMetadata
                    {
                        LogicalName = "new_customAppSeriesAttribute",
                        DisplayName = new Label("CustomAppSeriesAttribute", 1033),
                        Description = new Label("Sample Custom Appointment Series Attribute", 1033),
                        MaxLength = 500,
                        RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
                        SchemaName = "new_customAppSeriesAttribute",
                        LinkedAttributeId = _instanceAttributeID // Link the custom attribute to the appointment’s custom attribute.
                    };

                    CreateAttributeRequest seriesAttributeRequest = new CreateAttributeRequest
                    {
                        Attribute = customAppointmentSeriesAttribute,
                        EntityName = "recurringappointmentmaster"
                    };

                    CreateAttributeResponse seriesAttributeResponse = (CreateAttributeResponse)_serviceProxy.Execute(seriesAttributeRequest);
                    _seriesAttributeID = seriesAttributeResponse.AttributeId;

                    // Publish all the changes to the solution.
                    PublishAllXmlRequest createRequest = new PublishAllXmlRequest();
                    _serviceProxy.Execute(createRequest);

                    Console.WriteLine("Created a custom string attribute, {0}, for the appointment.", customAppointmentInstanceAttribute.LogicalName);
                    Console.WriteLine("Created a custom string attribute, {0}, for the recurring appointment, and linked it with {1}.", customAppointmentSeriesAttribute.LogicalName, customAppointmentInstanceAttribute.LogicalName);


                    DeleteRequiredRecords(promptForDelete);

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
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records to be deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {
                DeleteAttributeRequest delSeriesAttribute = new DeleteAttributeRequest
                {
                    LogicalName = "new_customappseriesattribute",
                    EntityLogicalName = RecurringAppointmentMaster.EntityLogicalName
                };
                _serviceProxy.Execute(delSeriesAttribute);

                DeleteAttributeRequest delInstanceAttribute = new DeleteAttributeRequest
                {
                    LogicalName = "new_customappinstanceattribute",
                    EntityLogicalName = Appointment.EntityLogicalName
                };
                _serviceProxy.Execute(delInstanceAttribute);

                // Publish all the changes to the solution.
                PublishAllXmlRequest delRequest = new PublishAllXmlRequest();
                _serviceProxy.Execute(delRequest);
                
                Console.WriteLine("Entity records have been deleted.");
            }
        }

        #endregion How To Sample Code

        #region Main
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

                LinkCustomAttributesBetweenSeriesandInstances app = new LinkCustomAttributesBetweenSeriesandInstances();
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

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe
                        = ex.InnerException
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
        #endregion Main
    }
}

// </snippetlinkcustomattributesbetweenseriesandinstances>