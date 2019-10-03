// <snippetretrieverecordsfromanintersecttable>


using System;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to retrieve records from an intersect table.
    /// </summary>
    public class RetrieveRecordsFromAnIntersectTable
    {

        #region Class Level Members

        private Guid _userId;
        private Guid _roleId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How-To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// records are retrieved from the systemuserroles intersect table via three
        /// methods: Query Expression, Fetch, and LINQ.
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
                    #region Retrieve records from an intersect table via QueryExpression

                    //Create Query Expression.
                    QueryExpression query = new QueryExpression()
                    {
                        EntityName = "role",
                        ColumnSet = new ColumnSet("name"),
                        LinkEntities = 
                        {
                            new LinkEntity
                            {
                                LinkFromEntityName = Role.EntityLogicalName,
                                LinkFromAttributeName = "roleid",
                                LinkToEntityName = SystemUserRoles.EntityLogicalName,
                                LinkToAttributeName = "roleid",
                                LinkCriteria = new FilterExpression
                                {
                                    FilterOperator = LogicalOperator.And,
                                    Conditions = 
                                    {
                                        new ConditionExpression
                                        {
                                            AttributeName = "systemuserid",
                                            Operator = ConditionOperator.Equal,
                                            Values = { _userId }
                                        }
                                    }
                                }
                            }
                        }
                    };

                    // Obtain results from the query expression.
                    EntityCollection ec = _serviceProxy.RetrieveMultiple(query);

                    // Display results.
                    for (int i = 0; i < ec.Entities.Count; i++)
                    {
                        Console.WriteLine("Query Expression Retrieved: {0}", ((Role)ec.Entities[i]).Name);
                    }

                    #endregion
                    #region Retrieve records from an intersect table via Fetch

                    // Setup Fetch XML.
                    StringBuilder linkFetch = new StringBuilder();
                    linkFetch.Append("<fetch version=\"1.0\" output-format=\"xml-platform\" mapping=\"logical\" distinct=\"true\">");
                    linkFetch.Append("<entity name=\"role\">");
                    linkFetch.Append("<attribute name=\"name\"/>");
                    linkFetch.Append("<link-entity name=\"systemuserroles\" from=\"roleid\" to=\"roleid\" visible=\"false\" intersect=\"true\">");
                    linkFetch.Append("<filter type=\"and\">");
                    linkFetch.Append("<condition attribute=\"systemuserid\" operator=\"eq\" value=\"" + _userId + "\"/>");
                    linkFetch.Append("</filter>");
                    linkFetch.Append("</link-entity>");
                    linkFetch.Append("</entity>");
                    linkFetch.Append("</fetch>");

                    // Build fetch request and obtain results.
                    RetrieveMultipleRequest efr = new RetrieveMultipleRequest()
                    {
                        Query = new FetchExpression(linkFetch.ToString())
                    };
                    EntityCollection entityResults = ((RetrieveMultipleResponse)_serviceProxy.Execute(efr)).EntityCollection;

                    // Display results.
                    foreach (var e in entityResults.Entities) 
                    {
                        Console.WriteLine("Fetch Retrieved: {0}", e.Attributes["name"]);
                    }

                    #endregion
                    #region Retrieve records from an intersect table via LINQ

                    // Obtain the Organization Context.
                    OrganizationServiceContext context = new OrganizationServiceContext(_serviceProxy);

                    // Create Linq Query.
                    var roles = (from r in context.CreateQuery<Role>()
                                 join s in context.CreateQuery<SystemUserRoles>() on r.RoleId equals s.RoleId
                                 where s.SystemUserId == _userId
                                 orderby r.RoleId
                                 select r.Name);

                    // Display results.
                    foreach (var role in roles)
                    {
                        Console.WriteLine("Linq Retrieved: {0}", role);
                    }

                    #endregion
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
            // Retrieve the default business unit needed to create the team.
            QueryExpression queryDefaultBusinessUnit = new QueryExpression
            {
                EntityName = BusinessUnit.EntityLogicalName,
                ColumnSet = new ColumnSet("businessunitid"),
                Criteria = new FilterExpression()
            };

            // Execute the request.
            queryDefaultBusinessUnit.Criteria.AddCondition("parentbusinessunitid",
                ConditionOperator.Null);

            BusinessUnit defaultBusinessUnit = (BusinessUnit)_serviceProxy.RetrieveMultiple(
                queryDefaultBusinessUnit).Entities[0];

            // Get the GUID of the current user.
            WhoAmIRequest who = new WhoAmIRequest();
            WhoAmIResponse whoResp = (WhoAmIResponse)_serviceProxy.Execute(who);
            _userId = whoResp.UserId;

            // Instantiate a role entity record and set its property values.
            // See the Entity Metadata topic in the SDK documentation to determine
            // which attributes must be set for each entity.
            Role setupRole = new Role
            {
                Name = "ABC Management Role",
                BusinessUnitId = new EntityReference(BusinessUnit.EntityLogicalName,
                    defaultBusinessUnit.Id)
            };

            //Create a role record.
            _roleId = _serviceProxy.Create(setupRole);
            Console.WriteLine("Created Role.");

            // Assign User to Managers role.
            AssociateRequest associate = new AssociateRequest()
            {
                Target = new EntityReference(SystemUser.EntityLogicalName, _userId),
                RelatedEntities = new EntityReferenceCollection()
                {
                    new EntityReference(Role.EntityLogicalName, _roleId),
                },
                Relationship = new Relationship("systemuserroles_association")
            };

            // Execute the request.
            _serviceProxy.Execute(associate);
        }

        /// <summary>
        /// Deletes any entity records and files that were created for this sample.
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
                _serviceProxy.Delete(Role.EntityLogicalName, _roleId);
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

                RetrieveRecordsFromAnIntersectTable app = new RetrieveRecordsFromAnIntersectTable();
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

// </snippetretrieverecordsfromanintersecttable>