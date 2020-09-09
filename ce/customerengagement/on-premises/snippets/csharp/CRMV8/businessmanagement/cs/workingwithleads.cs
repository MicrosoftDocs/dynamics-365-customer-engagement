// <snippetworkingwithleads>


using System;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    public class WorkingWithLeads
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private Guid _lead1Id;
        private Guid _lead2Id;
        private Guid _accountId;
        private Guid _leadAccountId;
        private Guid _contactId;
        private Guid _opportunityId;
        #endregion

        #region How To Sample Code

        public void Run(ServerConnection.Configuration serverConfig,
            bool promptforDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early bound type support.
                _serviceProxy.EnableProxyTypes();
                CreateRequiredRecords();

                Console.WriteLine("=== Creating and Qualifying Leads ===");

                // Create two leads.
                var lead1 = new Lead
                {
                    CompanyName = "A. Datum Corporation",
                    FirstName = "Henriette",
                    LastName = "Andersen",
                    Subject = "Sample Lead 1"
                };

                _lead1Id = _serviceProxy.Create(lead1);
                NotifyEntityCreated(Lead.EntityLogicalName, _lead1Id);

                var lead2 = new Lead
                {
                    CompanyName = "Adventure Works",
                    FirstName = "Michael",
                    LastName = "Sullivan",
                    Subject = "Sample Lead 2"
                };

                _lead2Id = _serviceProxy.Create(lead2);
                NotifyEntityCreated(Lead.EntityLogicalName, _lead2Id);

                // Qualify the first lead, creating an account and a contact from it, but
                // not creating an opportunity.
                var qualifyIntoAccountContactReq = new QualifyLeadRequest
                {
                    CreateAccount = true,
                    CreateContact = true,
                    LeadId = new EntityReference(Lead.EntityLogicalName, _lead1Id),
                    Status = new OptionSetValue((int)lead_statuscode.Qualified)
                };

                var qualifyIntoAccountContactRes = 
                    (QualifyLeadResponse)_serviceProxy.Execute(qualifyIntoAccountContactReq);
                Console.WriteLine("  The first lead was qualified.");
                foreach (var entity in qualifyIntoAccountContactRes.CreatedEntities)
                {
                    NotifyEntityCreated(entity.LogicalName, entity.Id);
                    if (entity.LogicalName == Account.EntityLogicalName)
                    {
                        _leadAccountId = entity.Id;
                    }
                    else if (entity.LogicalName == Contact.EntityLogicalName)
                    {
                        _contactId = entity.Id;
                    }
                }

                // Retrieve the organization's base currency ID for setting the
                // transaction currency of the opportunity.
                var query = new QueryExpression("organization");
		        query.ColumnSet = new ColumnSet("basecurrencyid");
		        var result = _serviceProxy.RetrieveMultiple(query);
		        var currencyId = (EntityReference)result.Entities[0]["basecurrencyid"];

                // Qualify the second lead, creating an opportunity from it, and not
                // creating an account or a contact.  We use an existing account for the
                // opportunity customer instead.
                var qualifyIntoOpportunityReq = new QualifyLeadRequest
                {
                    CreateOpportunity = true,
                    OpportunityCurrencyId = currencyId,
                    OpportunityCustomerId = new EntityReference(
                        Account.EntityLogicalName,
                        _accountId),
                    Status = new OptionSetValue((int)lead_statuscode.Qualified),
                    LeadId = new EntityReference(Lead.EntityLogicalName, _lead2Id)
                };

                var qualifyIntoOpportunityRes =
                    (QualifyLeadResponse)_serviceProxy.Execute(qualifyIntoOpportunityReq);
                Console.WriteLine("  The second lead was qualified.");

                foreach (var entity in qualifyIntoOpportunityRes.CreatedEntities)
                {
                    NotifyEntityCreated(entity.LogicalName, entity.Id);
                    if (entity.LogicalName == Opportunity.EntityLogicalName)
                    {
                        _opportunityId = entity.Id;
                    }
                }

                DeleteRecords(promptforDelete);
            }
        }

        private void NotifyEntityCreated(String entityName, Guid entityId)
        {
            Console.WriteLine("  {0} created with GUID {{{1}}}",
                entityName, entityId);
        }

        private void CreateRequiredRecords()
        {
            // Create an account to relate the opportunity to.
            var account = new Account
            {
                Name = "Litware, Inc.",
                Address1_StateOrProvince = "Colorado"
            };
            _accountId = (_serviceProxy.Create(account));
        }

        private void DeleteRecords(bool prompt)
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
                // Deleting the accounts will delete all of their related records, and then
                // only the leads will be left.
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId);
                _serviceProxy.Delete(Account.EntityLogicalName, _leadAccountId);

                _serviceProxy.Delete(Lead.EntityLogicalName, _lead1Id);
                _serviceProxy.Delete(Lead.EntityLogicalName, _lead2Id);
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
                // Obtain the target organization's web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                var app = new WorkingWithLeads();
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

// </snippetworkingwithleads>