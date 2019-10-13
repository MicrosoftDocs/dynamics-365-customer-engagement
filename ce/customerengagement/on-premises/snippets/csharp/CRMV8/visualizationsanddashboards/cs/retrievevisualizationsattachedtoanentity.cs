// <snippetretrievevisualizationsattachedtoanentity>


using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to retrieve organization-owned visualizations attached to
    /// an entity. This sample specifically retrieves organization-owned visualizations
    /// that are attached to the 'Account' entity.
    /// </summary>
    public class RetrieveVisualizationsAttachedToAnEntity
    {
        #region Class Level Members
        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;
        
        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Retrieve organization-owned visualizations.
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

                    // Create a query for retrieving all organization-owned visualizations 
                    // that are attached to the account entity.
                    QueryExpression mySavedQuery = new QueryExpression
                    {
                        EntityName = SavedQueryVisualization.EntityLogicalName,
                        ColumnSet = new ColumnSet("name"),
                        Criteria = new FilterExpression
                        {
                            Conditions = 
                         {
                            new ConditionExpression
                               {
                                  AttributeName = "primaryentitytypecode",
                                  Operator = ConditionOperator.Equal,
                                  Values =  {Account.EntityLogicalName}
                               }
                         }
                        }
                    };

                    // Retrieve a collection of organization-owned visualizations that are attached to the account entity.
                    DataCollection<Entity> results = _serviceProxy.RetrieveMultiple(mySavedQuery).Entities;

                    // Display the names of the retrieved organization-owned visualizations.
                    Console.WriteLine("Retrieved the following visualizations for the Account entity:");
                    foreach (Entity entity in results)
                    {
                        SavedQueryVisualization orgVisualization = (SavedQueryVisualization)entity;
                        Console.WriteLine("{0}", orgVisualization.Name);
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

        #endregion How To Sample Code

        #region Main
       /// <summary>
       /// Main. Runs the sample and provides error output.
       /// <param name="args">Array of arguments to Main method.</param>
       /// </summary>
       static public void Main(string[] args)
       {
           try
           {
               // Obtain the target organization's Web address and client logon 
               // credentials from the user.
               ServerConnection serverConnect = new ServerConnection();
               ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

               RetrieveVisualizationsAttachedToAnEntity app = new RetrieveVisualizationsAttachedToAnEntity();
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

// </snippetretrievevisualizationsattachedtoanentity>