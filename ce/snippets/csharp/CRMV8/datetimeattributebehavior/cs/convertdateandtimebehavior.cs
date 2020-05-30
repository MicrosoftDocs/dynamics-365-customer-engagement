// <snippetconvertdateandtimebehavior>


using System;
using System.Linq;
using System.Xml.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Collections.Specialized;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to use the ConvertDateandTimeBehaviorRequest message
    /// to change the behavior of existing date and time attribute values whose
    /// attribute behavior was changed using UI or SDK.
    /// For more information, see 
    /// https://msdn.microsoft.com/library/17014973-417b-4f53-8991-88ccc0096cfc.aspx.
    /// **********************************************************
    /// IMPORTANT: Your user account must have the System Adminsitrator role in
    /// the CRM instance to run this sample.
    /// **********************************************************
    /// </summary>
    public class ConvertDateandTimeBehavior
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;

        // Specify which language code to use in the sample. If you are using a language
        // other than US English, you will need to modify this value accordingly.
        // See https://msdn.microsoft.com/library/ms912047.aspx        
        public const int _languageCode = 1033;

        // Define the IDs/variables needed for this sample.        
        public Guid _account1ID;
        public Guid _account2ID;

        // Specifies the number of seconds the sample will
        // wait for the behavior conversion async job to
        // complete. Change this value accordingly if you want 
        // to wait for shorter or longer duration.
        public int waitCount = 50; 
        
        public DateTimeAttributeMetadata dtAttribute = new DateTimeAttributeMetadata();

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Create a date/time attribute for account entity with UserLocal behavior.
        /// Create an account record.
        /// Retrieve the value in the new date/time attribute.
        /// Update attribute to set the behavior to DateOnly.
        /// Create another account record.
        /// Retrieve both the account records to compare the date value retrieved.
        /// Use the "ConvertDateandTimeRequest" message to change the behavior for the
        /// existing records.
        /// Optionally delete/revert any attributes 
        /// that were created/changed for this sample.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptForDelete">When True, the user will be prompted to delete all
        /// created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
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

                    // Check if you are running the correct version of CRM.
                    // This sample requires that the CRM version be 7.1.0.xxxx or later.
                    RetrieveVersionRequest crmVersionReq = new RetrieveVersionRequest();
                    RetrieveVersionResponse crmVersionResp = (RetrieveVersionResponse)_serviceProxy.Execute(crmVersionReq);

                    if (String.CompareOrdinal("7.1.0.0", crmVersionResp.Version) < 0)
                    {
                        // Create required records for the sample.
                        CreateRequiredRecords();

                        // Use the ConvertDateandTimeBehaviorRequest SDK message to change
                        // the behavior of the date and time values in the custom attribute
                        // (new_SampleDateTimeAttribute) for the account entity.
                        ConvertDateAndTimeBehaviorRequest request = new ConvertDateAndTimeBehaviorRequest()
                        {
                            Attributes = new EntityAttributeCollection() 
                                    { 
                                        new KeyValuePair<string, StringCollection>("account", new StringCollection() 
                                        { "new_sampledatetimeattribute" }) 
                                    },
                            ConversionRule = DateTimeBehaviorConversionRule.SpecificTimeZone.Value,
                            TimeZoneCode = 190, // Time zone code for India Standard Time (IST) in CRM
                            AutoConvert = false // Conversion must be done using ConversionRule
                        };

                        // Execute the request
                        ConvertDateAndTimeBehaviorResponse response = (ConvertDateAndTimeBehaviorResponse)_serviceProxy.Execute(request);
                        
                        Console.WriteLine("***************************************");
                        Console.WriteLine("Executed the ConvertDateAndTimeBehaviorRequest SDK message.\n");

                        // Wait for two seconds to let the async job be created
                        System.Threading.Thread.Sleep(2000);

                        if (response.JobId != null)
                        {
                            Console.WriteLine("An async job created with ID: {0}", response.JobId.ToString());
                        }

                        // Retrieve the job completion details based on the Job ID                    
                        ColumnSet cs = new ColumnSet("statecode", "statuscode", "friendlymessage", "message");
                        Console.WriteLine("Waiting for the async job to complete...\n");
                        
                        AsyncOperation crmAsyncJob = new AsyncOperation();
                        while (response.JobId != null && waitCount > 0)
                        {
                            // Check to see if the async operation is complete
                            crmAsyncJob =
                              (AsyncOperation)_serviceProxy.Retrieve(AsyncOperation.EntityLogicalName,
                                           response.JobId, cs);
                            if (crmAsyncJob.StateCode.HasValue &&
                                    crmAsyncJob.StateCode.Value == AsyncOperationState.Completed && 
                                    crmAsyncJob.StatusCode.Value == (int)asyncoperation_statuscode.Succeeded)
                            {
                                waitCount = 0;                                
                                
                                Console.WriteLine("The async job is complete.\n");
                                Console.WriteLine("****************************");
                                Console.WriteLine(crmAsyncJob.FriendlyMessage);
                                Console.WriteLine("****************************");
                                Console.WriteLine(crmAsyncJob.Message);
                                Console.WriteLine("****************************\n");

                                // Retrieve both the account records created earlier to check the date value
                                Console.WriteLine("Retrieving the date and time values after the conversion...\n");
                                // Create a column set to define which attributes should be retrieved.
                                ColumnSet attributes = new ColumnSet(new string[] { "name", "new_sampledatetimeattribute" });

                                Account retrievedAccount1 = (Account)_serviceProxy.Retrieve(Account.EntityLogicalName, _account1ID, attributes);
                                Account retrievedAccount2 = (Account)_serviceProxy.Retrieve(Account.EntityLogicalName, _account2ID, attributes);

                                Console.WriteLine("'{0}' is: {1}", retrievedAccount1.GetAttributeValue<String>("name"), retrievedAccount1.GetAttributeValue<DateTime>("new_sampledatetimeattribute"));
                                Console.WriteLine("'{0}' is: {1}\n", retrievedAccount2.GetAttributeValue<String>("name"), retrievedAccount2.GetAttributeValue<DateTime>("new_sampledatetimeattribute"));
                                Console.WriteLine("The behavior converted to DateOnly for account record ('Sample Account 1')\nbased on the specified conversion rule.\n");
                                Console.WriteLine("No changes to 'Sample Account 2' because it was already DateOnly.\n");
                                Console.WriteLine("***************************************\n");
                            }
                            else
                            {
                                waitCount--;
                                System.Threading.Thread.Sleep(1000);
                            }
                        }

                        // If the async job is taking tool long to process,
                        // inform the user about the same.
                        if (waitCount == 0 && crmAsyncJob.StateCode.Value != (AsyncOperationState.Completed))
                        {
                            Console.WriteLine("The async job is taking too long to complete. Aborting the sample.");
                        }

                        // Prompt the user to delete the records and attribute created by the sample.
                        DeleteRequiredRecords(promptForDelete);
                    }
                    else
                    {
                        Console.WriteLine("This sample cannot be run against the current version of CRM.");
                        Console.WriteLine("Upgrade your CRM instance to the latest version to run this sample.");
                    }
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
        /// Creates required records for this sample. 
        /// </summary>
        private void CreateRequiredRecords()
        {
            // Create a date time attribute for the Account entity
            // with the UserLocal behavior
            dtAttribute = new DateTimeAttributeMetadata
            {                             
                SchemaName = "new_SampleDateTimeAttribute",
                DisplayName = new Label("Sample Date Time Attribute", _languageCode),
                RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),                
                Description = new Label("Created by SDK Sample", _languageCode),                
                DateTimeBehavior = DateTimeBehavior.UserLocal,
                Format = DateTimeFormat.DateAndTime,
                ImeMode = ImeMode.Disabled
            };

            CreateAttributeRequest createAttributeRequest = new CreateAttributeRequest
            {
                EntityName = Account.EntityLogicalName,
                Attribute = dtAttribute
            };
            _serviceProxy.Execute(createAttributeRequest);
            Console.WriteLine("Created attribute '{0}' with UserLocal behavior\nfor the Account entity.\n", 
                                        dtAttribute.SchemaName);

            // Create a sample account record with March 31, 2015 11:00 PM UTC
            // value in the new attribute.
            Entity newAccount1 = new Entity("account");
            newAccount1["name"] = "Sample Account 1";
            newAccount1["new_sampledatetimeattribute"] = new DateTime(2015,3,31,23,0,0,DateTimeKind.Utc);             
            _account1ID = _serviceProxy.Create(newAccount1);
            Console.WriteLine("Created account: '{0}'.", newAccount1.Attributes["name"]);

            // Create a column set to define which attributes should be retrieved.
            ColumnSet attributes1 = new ColumnSet(new string[] { "name", "new_sampledatetimeattribute" });

            // Retrieve the date and time value of the new attribute in the new account record.
            newAccount1 = _serviceProxy.Retrieve(newAccount1.LogicalName, _account1ID, attributes1);
            Console.WriteLine("Retrieved date and time value for '{0}': {1}\n", newAccount1.GetAttributeValue<String>("name"),
                           newAccount1.GetAttributeValue<DateTime>("new_sampledatetimeattribute"));

            // Retrieve the attribute to update its behavior and format
            RetrieveAttributeRequest attributeRequest = new RetrieveAttributeRequest
            {
                EntityLogicalName = Account.EntityLogicalName,
                LogicalName = "new_sampledatetimeattribute",
                RetrieveAsIfPublished = false
            };
            // Execute the request
            RetrieveAttributeResponse attributeResponse =
                            (RetrieveAttributeResponse)_serviceProxy.Execute(attributeRequest);

            Console.WriteLine("Retrieved the attribute '{0}'.",
                            attributeResponse.AttributeMetadata.SchemaName);

            // Modify the values of the retrieved attribute
            DateTimeAttributeMetadata retrievedAttributeMetadata =
                            (DateTimeAttributeMetadata)attributeResponse.AttributeMetadata;
            retrievedAttributeMetadata.DateTimeBehavior = DateTimeBehavior.DateOnly;
            retrievedAttributeMetadata.Format = DateTimeFormat.DateOnly;

            // Update the attribute with the modified value
            UpdateAttributeRequest updateRequest = new UpdateAttributeRequest
            {
                Attribute = retrievedAttributeMetadata,
                EntityName = Account.EntityLogicalName,
                MergeLabels = false
            };
            _serviceProxy.Execute(updateRequest);
            Console.WriteLine("Updated the behavior and format of '{0}' to DateOnly.",
                retrievedAttributeMetadata.SchemaName);

            // Publish customizations to the account entity
            PublishXmlRequest pxReq = new PublishXmlRequest
            {
                ParameterXml = String.Format("<importexportxml><entities><entity>account</entity></entities></importexportxml>")
            };
            _serviceProxy.Execute(pxReq);
            Console.WriteLine("Published customizations to the Account entity.\n");

            // Create another sample account record with a 
            // DateTime value in the new attribute.
            Entity newAccount2 = new Entity("account");
            newAccount2["name"] = "Sample Account 2";
            
            // Purposely pass the time value to check if it matters.
            // For DateOnly behavior, only the Date part is considered.
            // Time is always 12 AM (00:00:00)
            newAccount2["new_sampledatetimeattribute"] = new DateTime(2015, 3, 31, 23, 0, 0, DateTimeKind.Utc);
            
            _account2ID = _serviceProxy.Create(newAccount2);
            Console.WriteLine("Created account '{0}' after the behavior change.\n", newAccount2.Attributes["name"]);

            // Create a column set to define which attributes should be retrieved.
            ColumnSet attributes2 = new ColumnSet(new string[] { "name", "new_sampledatetimeattribute" });

            // Retrieve the date and time values existing and new account records.
            // Though both the values will display value in DateOnly behavior (Time is 12 AM (00:00:00)),
            // the actual value for the date and time value for "Sample Account 1" is still stored
            // in UTC.
            // We will use the UTC value for "Sample Account 1", and apply the conversion rule to
            // display a different date than what CRM converts and displays by default.

            newAccount1 = _serviceProxy.Retrieve(newAccount1.LogicalName, _account1ID, attributes1);            
            newAccount2 = _serviceProxy.Retrieve(newAccount2.LogicalName, _account2ID, attributes2);            

            Console.WriteLine("Retrieving date and time value for both the account records...");
            Console.WriteLine("'{0}': {1}", 
                newAccount1.GetAttributeValue<String>("name"), newAccount1.GetAttributeValue<DateTime>("new_sampledatetimeattribute"));
            Console.WriteLine("'{0}': {1}\n", 
                newAccount2.GetAttributeValue<String>("name"), newAccount2.GetAttributeValue<DateTime>("new_sampledatetimeattribute"));

            Console.WriteLine("The behavior is displayed as DateOnly when retrieved\nfor existing record ({0}) as well.", 
                                  newAccount1.Attributes["name"]);
            Console.WriteLine("We will now convert the UTC value in the DB for '{0}'.\n", newAccount1.Attributes["name"]);
        }

        /// <summary>
        /// Deletes/Reverts the record that was created/changed for this sample.
        /// <param name="prompt">Indicates whether to prompt the user to delete 
        /// the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            bool deleteRecords = true;

            if (prompt)
            {
                Console.WriteLine("\nDo you want these entity records and attribute to be deleted? (y/n)");
                String answer = Console.ReadLine();

                deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y"));
            }

            if (deleteRecords)
            {

                //Delete all records and attributes created for this sample.

                _serviceProxy.Delete(Account.EntityLogicalName, _account1ID);
                _serviceProxy.Delete(Account.EntityLogicalName, _account2ID);

                DeleteAttributeRequest deleteAttribute = new DeleteAttributeRequest
                {
                    EntityLogicalName = Account.EntityLogicalName,
                    LogicalName = dtAttribute.SchemaName.ToLower()
                };
                _serviceProxy.Execute(deleteAttribute);

                Console.WriteLine("Deleted all records and attribute created for this sample.");
            }
        }
        #endregion

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

                ConvertDateandTimeBehavior app = new ConvertDateandTimeBehavior();
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

// </snippetconvertdateandtimebehavior>