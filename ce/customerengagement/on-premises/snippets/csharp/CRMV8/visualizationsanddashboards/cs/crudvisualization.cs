// <snippetcrudvisualization>


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
    /// This sample shows how to create retrieve, update, and delete an 
    /// organization-owned visualization. The visualization will be attached
    /// to the 'Opportunity' entity. As part of updating the visualization,
    /// we will also set it to be the default visualization for the Opportunity
    /// entity.
    /// </summary>
    public class CRUDVisualization
    {
        #region Class Level Members
        

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        private OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        private Guid _orgOwnedVisualizationId;
        private Guid _accountId;
        private Guid[] _opportunitiyIds;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Initiate the method to create any data that this sample requires.
        /// Create an organization-owned visualization.
        /// Retrieve the visualization.
        /// Update the visualization; update the name and set it as the default
        /// visualization for the Opportunity entity.
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


                    // Call the method to create any data that this sample requires.
                    CreateRequiredRecords();

                    // Create a visualization

                    // Set The presentation XML string.
                    string presentationXml = @"
                    <Chart Palette='BrightPastel'>
                        <Series>
                            <Series _Template_='All' ShadowOffset='2' 
                                BorderColor='64, 64, 64' BorderDashStyle='Solid'
                                BorderWidth='1' IsValueShownAsLabel='true' 
                                Font='Tahoma, 6.75pt, GdiCharSet=0' 
                                LabelForeColor='100, 100, 100'
                                CustomProperties='FunnelLabelStyle=Outside' 
                                ChartType='Funnel'>
                                <SmartLabelStyle Enabled='True' />
                                <Points />
                            </Series>
                         </Series>
                        <ChartAreas>
                            <ChartArea _Template_='All' BackColor='Transparent'
                                BorderColor='Transparent' 
                                BorderDashStyle='Solid'>
                                <Area3DStyle Enable3D='True' 
                                    IsClustered='True'/>
                            </ChartArea>
                        </ChartAreas>
                        <Legends>
                            <Legend _Template_='All' Alignment='Center' 
                                LegendStyle='Table' Docking='Bottom' 
                                IsEquallySpacedItems='True' BackColor='White'
                                BorderColor='228, 228, 228' BorderWidth='0' 
                                Font='Tahoma, 8pt, GdiCharSet=0' 
                                ShadowColor='0, 0, 0, 0' 
                                ForeColor='100, 100, 100'>
                            </Legend>
                        </Legends>
                        <Titles>
                            <Title _Template_='All'
                                Font='Tahoma, 9pt, style=Bold, GdiCharSet=0'
                                ForeColor='102, 102, 102'>
                            </Title>
                        </Titles>
                        <BorderSkin PageColor='Control'
                            BackColor='CornflowerBlue'
                            BackSecondaryColor='CornflowerBlue' />
                    </Chart>
                    ";

                    // Set the data XML string.
                    string dataXml = @"
                    <datadefinition>
                        <fetchcollection>
                            <fetch mapping='logical' count='10' 
                                aggregate='true'>
                                <entity name='opportunity'>
                                    <attribute name='actualvalue_base' 
                                        aggregate='sum' 
                                        alias='sum_actualvalue_base' />
                                    <attribute name='stepname' groupby='true' 
                                        alias='stepname' />
                                    <order alias='stepname' descending='false'/>
                                </entity>
                            </fetch>
                        </fetchcollection>
                        <categorycollection>
                            <category>
                                <measurecollection>
                                    <measure alias='sum_actualvalue_base'/>
                                </measurecollection>
                            </category>
                        </categorycollection>
                    </datadefinition>
                    ";
                    // Create the visualization entity instance.
                    SavedQueryVisualization newOrgOwnedVisualization = new SavedQueryVisualization
                    {
                        Name = "Sample Visualization",
                        Description = "Sample organization-owned visualization.",
                        PresentationDescription = presentationXml,
                        DataDescription = dataXml,
                        PrimaryEntityTypeCode = Opportunity.EntityLogicalName,
                        IsDefault = false
                    };
                    _orgOwnedVisualizationId = _serviceProxy.Create(newOrgOwnedVisualization);
                    Console.WriteLine("Created {0}.", newOrgOwnedVisualization.Name);

                    // Retrieve the visualization
                    SavedQueryVisualization retrievedOrgOwnedVisualization = (SavedQueryVisualization)_serviceProxy.Retrieve(SavedQueryVisualization.EntityLogicalName, _orgOwnedVisualizationId, new ColumnSet(true));
                    Console.WriteLine("Retrieved the visualization.");

                    // Update the retrieved visualization
                    // 1.  Update the name.
                    // 2.  Update the data description string.                    

                    string newDataXml = @"<datadefinition>
                                        <fetchcollection>
                                            <fetch mapping='logical' count='10' 
                                                aggregate='true'>
                                                <entity name='opportunity'>
                                                    <attribute name='estimatedvalue_base' 
                                                        aggregate='sum' 
                                                        alias='sum_estimatedvalue_base' />
                                                    <attribute name='name' 
                                                        groupby='true' 
                                                        alias='name' />
                                                    <order alias='name' 
                                                        descending='false'/>
                                                </entity>
                                            </fetch>
                                        </fetchcollection>
                                        <categorycollection>
                                            <category>
                                                <measurecollection>
                                                    <measure alias='sum_estimatedvalue_base'/>
                                                </measurecollection>
                                            </category>
                                        </categorycollection>
                                    </datadefinition>";

                    retrievedOrgOwnedVisualization.Name = "Updated Sample Visualization";
                    retrievedOrgOwnedVisualization.DataDescription = newDataXml;

                    _serviceProxy.Update(retrievedOrgOwnedVisualization);

                    // Publish the changes to the solution. This step is only required
                    // for organization-owned visualizations.
                    PublishAllXmlRequest updateRequest = new PublishAllXmlRequest();
                    _serviceProxy.Execute(updateRequest);

                    Console.WriteLine("Updated the visualization.");

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
        /// This method creates any entity records that this sample requires.
        /// Create an account and few opportuntiy records for sample data 
        /// for the chart.
        /// </summary>
        public void CreateRequiredRecords()
        {
            // Create a sample account
            Account setupAccount = new Account { Name = "Sample Account" };
            _accountId = _serviceProxy.Create(setupAccount);
            Console.WriteLine("Created {0}.", setupAccount.Name);

            // Create some oppotunity records for the visualization
            Opportunity[] setupOpportunities = new Opportunity[]
                {
                    new Opportunity
                    {
                        Name = "Sample Opp 01",
                        EstimatedValue = new Money(120000.00m),
                        ActualValue = new Money(100000.00m),
                        CustomerId = new EntityReference(Account.EntityLogicalName, 
                            _accountId),
                        StepName = "Open"
                    },
                    new Opportunity
                    {
                        Name = "Sample Opp 02",
                        EstimatedValue = new Money(240000.00m),
                        ActualValue = new Money(200000.00m),
                        CustomerId = new EntityReference(Account.EntityLogicalName, 
                            _accountId),
                        StepName = "Open"
                    },
                    new Opportunity
                    {
                        Name = "Sample Opp 03",
                        EstimatedValue = new Money(360000.00m),
                        ActualValue = new Money(300000.00m),
                        CustomerId = new EntityReference(Account.EntityLogicalName, 
                            _accountId),
                        StepName = "Open"
                    },
                    new Opportunity
                    {
                        Name = "Sample Opp 04",
                        EstimatedValue = new Money(500000.00m),
                        ActualValue = new Money(500000.00m),
                        CustomerId = new EntityReference(Account.EntityLogicalName, 
                            _accountId),
                        StepName = "Open"
                    },
                    new Opportunity
                    {
                        Name = "Sample Opp 05",
                        EstimatedValue = new Money(110000.00m),
                        ActualValue = new Money(60000.00m),
                        CustomerId = new EntityReference(Account.EntityLogicalName, 
                            _accountId),
                        StepName = "Open"
                    },
                    new Opportunity
                    {
                        Name = "Sample Opp 06",
                        EstimatedValue = new Money(90000.00m),
                        ActualValue = new Money(70000.00m),
                        CustomerId = new EntityReference(Account.EntityLogicalName, 
                            _accountId),
                        StepName = "Open"
                    },
                    new Opportunity
                    {
                        Name = "Sample Opp 07",
                        EstimatedValue = new Money(620000.00m),
                        ActualValue = new Money(480000.00m),
                        CustomerId = new EntityReference(Account.EntityLogicalName, 
                            _accountId),
                        StepName = "Open"
                    },
                    new Opportunity
                    {
                        Name = "Sample Opp 08",
                        EstimatedValue = new Money(440000.00m),
                        ActualValue = new Money(400000.00m),
                        CustomerId = new EntityReference(Account.EntityLogicalName, 
                            _accountId),
                        StepName = "Open"
                    },
                    new Opportunity
                    {
                        Name = "Sample Opp 09",
                        EstimatedValue = new Money(410000.00m),
                        ActualValue = new Money(400000.00m),
                        CustomerId = new EntityReference(Account.EntityLogicalName, 
                            _accountId),
                        StepName = "Open"
                    },
                    new Opportunity
                    {
                        Name = "Sample Opp 10",
                        EstimatedValue = new Money(650000.00m),
                        ActualValue = new Money(650000.00m),
                        CustomerId = new EntityReference(Account.EntityLogicalName, 
                            _accountId),
                        StepName = "Open"
                    }                    
                };

            _opportunitiyIds = (from opp in setupOpportunities
                                select _serviceProxy.Create(opp)).ToArray();

            Console.WriteLine("Created few opportunity records for {0}.", setupAccount.Name);

            return;
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
                _serviceProxy.Delete(SavedQueryVisualization.EntityLogicalName,
                    _orgOwnedVisualizationId);
                _serviceProxy.Delete("account", _accountId);
                Console.WriteLine("Entity records have been deleted.");
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

                CRUDVisualization app = new CRUDVisualization();
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

// </snippetcrudvisualization>