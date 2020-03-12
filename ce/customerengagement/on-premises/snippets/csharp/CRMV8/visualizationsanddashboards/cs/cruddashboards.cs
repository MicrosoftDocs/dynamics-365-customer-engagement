// <snippetcruddashboards>


using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Xml.Linq;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Discovery;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{

    /// <summary>
    /// This sample shows how to perform Create, Retrieve, 
    /// Update, and Delete operations on a dashboard.
    /// </summary>
    
    public class CRUDDashboards
    {
        #region Class Level Members

        /// <summary>
        /// Stores the organization service proxy.
        /// </summary>
        OrganizationServiceProxy _serviceProxy;

        // Define the IDs needed for this sample.
        public Guid _dashboardId;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// Create and configure the organization service proxy.
        /// Create a dashboard.
        /// Retrieve the dashboard.
        /// Update the dashboard.
        /// Delete the dashboard.
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


                    //Grab the default public view for opportunities.
                    QueryExpression mySavedQuery = new QueryExpression
                    {
                        ColumnSet = new ColumnSet("savedqueryid"),
                        EntityName = SavedQuery.EntityLogicalName,
                        Criteria = new FilterExpression
                        {
                            Conditions =
                        {
                            new ConditionExpression
                            {
                                AttributeName = "isdefault",
                                Operator = ConditionOperator.Equal,
                                Values = {true}
                            },
                            new ConditionExpression
                            {
                                AttributeName = "querytype",
                                Operator = ConditionOperator.Equal,
                                Values = {0}
                            },
                            new ConditionExpression
                            {
                                AttributeName = "returnedtypecode",
                                Operator = ConditionOperator.Equal,
                                Values = {Opportunity.EntityTypeCode}
                            }
                        }
                        }
                    };

                    //This query should return one and only one result.
                    SavedQuery defaultOpportunityQuery = _serviceProxy.RetrieveMultiple(mySavedQuery)
                        .Entities.Select(x => (SavedQuery)x).FirstOrDefault();

                    // Retrieve visualizations out of the system. 
                    // This sample assumes that you have the "Top Opportunities"
                    // visualization that is installed with Microsoft Dynamics CRM.
                    QueryByAttribute visualizationQuery = new QueryByAttribute
                    {
                        EntityName = SavedQueryVisualization.EntityLogicalName,
                        ColumnSet = new ColumnSet("savedqueryvisualizationid"),
                        Attributes = { "name" },
                        //If you do not have this visualization, you will need to change
                        //this line.
                        Values = { "Top Opportunities" }
                    };


                    SavedQueryVisualization visualization = _serviceProxy.RetrieveMultiple(visualizationQuery).
                        Entities.Select(x => (SavedQueryVisualization)x).FirstOrDefault();
                    //This is the language code for U.S. English. If you are running this code
                    //in a different locale, you will need to modify this value.
                    int languageCode = 1033;

                    //We set up our dashboard and specify the FormXml. Refer to the
                    //FormXml schema in the Microsoft Dynamics CRM SDK for more information.
                    SystemForm dashboard = new SystemForm
                    {
                        Name = "Sample Dashboard",
                        Description = "Sample organization-owned dashboard.",
                        FormXml = String.Format(@"<form>
                                <tabs>
                                    <tab name='Test Dashboard' verticallayout='true'>
                                        <labels>
                                            <label description='Sample Dashboard' languagecode='{0}' />
                                        </labels>
                                        <columns>
                                            <column width='100%'>
                                                <sections>
                                                    <section name='Information Section'
                                                        showlabel='false' showbar='false'
                                                        columns='111'>
                                                        <labels>
                                                            <label description='Information Section'
                                                                languagecode='{0}' />
                                                        </labels>
                                                        <rows>
                                                            <row>
                                                                <cell colspan='1' rowspan='10' 
                                                                    showlabel='false'>
                                                                    <labels>
                                                                        <label description='Top Opportunitiess - 1'
                                                                        languagecode='{0}' />
                                                                    </labels>
                                                                    <control id='TopOpportunities'
                                                                        classid='{{E7A81278-8635-4d9e-8D4D-59480B391C5B}}'>
                                                                        <parameters>
                                                                            <ViewId>{1}</ViewId>
                                                                            <IsUserView>false</IsUserView>
                                                                            <RelationshipName />
                                                                            <TargetEntityType>opportunity</TargetEntityType>
                                                                            <AutoExpand>Fixed</AutoExpand>
                                                                            <EnableQuickFind>false</EnableQuickFind>
                                                                            <EnableViewPicker>false</EnableViewPicker>
                                                                            <EnableJumpBar>false</EnableJumpBar>
                                                                            <ChartGridMode>Chart</ChartGridMode>
                                                                            <VisualizationId>{2}</VisualizationId>
                                                                            <EnableChartPicker>false</EnableChartPicker>
                                                                            <RecordsPerPage>10</RecordsPerPage>
                                                                        </parameters>
                                                                    </control>
                                                                </cell>
                                                                <cell colspan='1' rowspan='10' 
                                                                    showlabel='false'>
                                                                    <labels>
                                                                        <label description='Top Opportunities - 2'
                                                                        languagecode='{0}' />
                                                                    </labels>
                                                                    <control id='TopOpportunities2'
                                                                        classid='{{E7A81278-8635-4d9e-8D4D-59480B391C5B}}'>
                                                                        <parameters>
                                                                            <ViewId>{1}</ViewId>
                                                                            <IsUserView>false</IsUserView>
                                                                            <RelationshipName />
                                                                            <TargetEntityType>opportunity</TargetEntityType>
                                                                            <AutoExpand>Fixed</AutoExpand>
                                                                            <EnableQuickFind>false</EnableQuickFind>
                                                                            <EnableViewPicker>false</EnableViewPicker>
                                                                            <EnableJumpBar>false</EnableJumpBar>
                                                                            <ChartGridMode>Grid</ChartGridMode>
                                                                            <VisualizationId>{2}</VisualizationId>
                                                                            <EnableChartPicker>false</EnableChartPicker>
                                                                            <RecordsPerPage>10</RecordsPerPage>
                                                                        </parameters>
                                                                    </control>
                                                                </cell>
                                                            </row>
                                                            <row />
                                                            <row />
                                                            <row />
                                                            <row />
                                                            <row />
                                                            <row />
                                                            <row />
                                                            <row />
                                                            <row />
                                                        </rows>
                                                    </section>
                                                </sections>
                                            </column>
                                        </columns>
                                    </tab>
                                </tabs>
                            </form>",
                        languageCode,
                        defaultOpportunityQuery.SavedQueryId.Value.ToString("B"),
                        visualization.SavedQueryVisualizationId.Value.ToString("B")),
                        IsDefault = false
                    };
                    _dashboardId = _serviceProxy.Create(dashboard);
                    Console.WriteLine("Created {0}.", dashboard.Name);

                    //Now we will retrieve the dashboard.
                    SystemForm retrievedDashboard = (SystemForm)_serviceProxy.Retrieve(SystemForm.EntityLogicalName, _dashboardId, new ColumnSet(true));
                    Console.WriteLine("Retrieved the dashboard.");

                    // Update the retrieved dashboard. Enable the chart picker on the chart.                                       
                    XDocument xDocument = XDocument.Parse(retrievedDashboard.FormXml);

                    var chartPicker = (from control in xDocument.Descendants("control")
                                       where control.Attribute("id").Value == "TopOpportunities"
                                       select control.Descendants("EnableChartPicker").First()
                                     ).First();
                    chartPicker.Value = "true";

                    //Now we place the updated Xml back into the dashboard, and update it.
                    retrievedDashboard.FormXml = xDocument.ToString();                    
                    _serviceProxy.Update(retrievedDashboard);

                    // Publish the dashboard changes to the solution. 
                    // This is only required for organization-owned dashboards.
                    PublishXmlRequest updateRequest = new PublishXmlRequest
                    {
                        ParameterXml = @"<dashboard>_dashboardId</dashboard>"
                    };

                    _serviceProxy.Execute(updateRequest);

                    Console.WriteLine("Updated the dashboard.");

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
        /// <param name='prompt'>Indicates whether to prompt the user 
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
                _serviceProxy.Delete(SystemForm.EntityLogicalName, _dashboardId);
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

                CRUDDashboards app = new CRUDDashboards();
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
        #endregion Main

    }
}

// </snippetcruddashboards>