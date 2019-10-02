// <snippetworkingwithcontracts>


using System;
using System.ServiceModel;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to do manage contract records programmatically.</summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.</remarks>
    public class WorkingWithContracts
    {
        #region Class Level Members

        private Guid _accountId;
        private Guid _contractId;
        private Guid _contractTemplateId;
        private Guid _firstCloneId;
        private Guid _secondCloneId;
        private Guid _renewedId;
        private OrganizationServiceProxy _serviceProxy;

        #endregion Class Level Members

        #region How To Sample Code
        /// <summary>
        /// This method first connects to the Organization service. Afterwards,
        /// a Contract Template and several Contracts are created, demonstrating how to
        /// create and work with the Contract entity.
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

                    #region Create Contract Template

                    // First, attempt to retrieve the Contract Template. Otherwise, 
                    // create the template.
                    QueryExpression templateQuery = new QueryExpression()
                    {
                        EntityName = ContractTemplate.EntityLogicalName,
                        ColumnSet = new ColumnSet("contracttemplateid"),
                        Criteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression("abbreviation", ConditionOperator.Equal, "SCT")
                            }
                        }
                    };
                    EntityCollection ec = _serviceProxy.RetrieveMultiple(templateQuery);

                    if (ec.Entities.Count > 0)
                    {
                        _contractTemplateId = ec.Entities[0].Id;
                        Console.Write("Template retrieved, ");
                    }
                    else
                    {
                        ContractTemplate contractTemplate = new ContractTemplate()
                        {
                            Name = "Sample Contract Template",
                            BillingFrequencyCode = new OptionSetValue((int)ContractTemplateBillingFrequencyCode.Monthly),
                            Abbreviation = "SCT",
                            AllotmentTypeCode = new OptionSetValue((int)ContractTemplateAllotmentTypeCode.NumberofCases),
                            EffectivityCalendar =
                                "--------+++++++++---------------+++++++++---------------+++++++++---------------+++++++++---------------+++++++++-------------------------------------------------------"
                        };
                        _contractTemplateId = _serviceProxy.Create(contractTemplate);
                        Console.Write("Template created, ");
                    }

                    #endregion

                    #region Create Contract

                    // Create a Contract from the Contract Template.
                    Contract contract = new Contract()
                    {
                        Title = "Sample Contract",
                        ContractTemplateId = new EntityReference
                        {
                            Id = _contractTemplateId,
                            LogicalName = ContractTemplate.EntityLogicalName
                        },
                        CustomerId = new EntityReference
                        {
                            Id = _accountId,
                            LogicalName = Account.EntityLogicalName
                        },
                        BillingCustomerId = new EntityReference
                        {
                            Id = _accountId,
                            LogicalName = Account.EntityLogicalName
                        },
                        ActiveOn = new DateTime(2015, 1, 1),
                        ExpiresOn = new DateTime(2020, 1, 1),
                        BillingStartOn = new DateTime(2015, 1, 1),
                        BillingEndOn = new DateTime(2020, 1, 1)
                    };
                    _contractId = _serviceProxy.Create(contract);

                    Console.Write("parent contract created, ");

                    // Create a contract line item.
                    ContractDetail contractLineItem = new ContractDetail()
                    {
                        Title = "Sample Contract Line Item",
                        ContractId = new EntityReference
                        {
                            Id = _contractId,
                            LogicalName = Contract.EntityLogicalName
                        },
                        CustomerId = new EntityReference
                        {
                            Id = _accountId,
                            LogicalName = Account.EntityLogicalName
                        },
                        ActiveOn = new DateTime(2015, 1, 1),
                        ExpiresOn = new DateTime(2020, 1, 1),
                        Price = new Money(20.0M),
                        TotalAllotments = 20
                    };
                    _serviceProxy.Create(contractLineItem);

                    Console.Write("contract line attached, ");

                    #endregion

                    #region Clone contract twice

                    // Create the first clone of the contract.
                    CloneContractRequest cloneRequest = new CloneContractRequest()
                    {
                        ContractId = _contractId,
                        IncludeCanceledLines = false
                    };
                    CloneContractResponse cloneResponse =
                        (CloneContractResponse)_serviceProxy.Execute(cloneRequest);
                    _firstCloneId = ((Contract)cloneResponse.Entity).ContractId.Value;

                    Console.Write("first clone created, ");

                    // Create the second clone of the contract.
                    cloneRequest = new CloneContractRequest()
                    {
                        ContractId = _contractId,
                        IncludeCanceledLines = true
                    };
                    cloneResponse =
                        (CloneContractResponse)_serviceProxy.Execute(cloneRequest);
                    _secondCloneId = ((Contract)cloneResponse.Entity).ContractId.Value;

                    Console.Write("second clone created. \n");

                    // Retrieve all Contracts.
                    QueryExpression contractQuery = new QueryExpression()
                    {
                        EntityName = Contract.EntityLogicalName,
                        ColumnSet = new ColumnSet("contractid"),
                        Criteria =
                        {
                            Conditions = 
                            {
                                new ConditionExpression("customerid", ConditionOperator.Equal, _accountId)
                            }
                        }
                    };
                    EntityCollection contracts = _serviceProxy.RetrieveMultiple(contractQuery);

                    // Display the retrieved Contract Ids.
                    for (int i = 0; i < contracts.Entities.Count; i++)
                    {
                        Console.WriteLine("Retrieved contract with Id: {0}",
                            ((Contract)contracts.Entities[i]).ContractId);
                    }

                    #endregion

                    #region Deactivate a cloned contract

                    // In order to deactivate a contract (put it on hold), it is first
                    // necessary to invoice the contract.
                    SetStateRequest setStateRequest = new SetStateRequest()
                    {
                        EntityMoniker = new EntityReference
                        {
                            Id = _firstCloneId,
                            LogicalName = Contract.EntityLogicalName
                        },
                        State = new OptionSetValue((int)ContractState.Invoiced),
                        Status = new OptionSetValue(2)
                    };
                    _serviceProxy.Execute(setStateRequest);

                    Console.Write("Contract invoiced, ");

                    // Now that the contract has been invoiced, it is possible to put
                    // the contract on hold.
                    setStateRequest = new SetStateRequest()
                    {
                        EntityMoniker = new EntityReference
                        {
                            Id = _firstCloneId,
                            LogicalName = Contract.EntityLogicalName
                        },
                        State = new OptionSetValue((int)ContractState.OnHold),
                        Status = new OptionSetValue(4)
                    };
                    _serviceProxy.Execute(setStateRequest);

                    Console.Write("and put on hold.\n");

                    #endregion

                    #region Renew an invoiced contract

                    // In order to renew a contract, it must be invoiced first, and
                    // then canceled.

                    // Invoice the contract.
                    setStateRequest = new SetStateRequest()
                    {
                        EntityMoniker = new EntityReference
                        {
                            Id = _contractId,
                            LogicalName = Contract.EntityLogicalName
                        },
                        State = new OptionSetValue((int)ContractState.Invoiced),
                        Status = new OptionSetValue(3)
                    };
                    _serviceProxy.Execute(setStateRequest);

                    Console.Write("Contract invoiced, ");

                    // Cancel the contract.
                    setStateRequest = new SetStateRequest()
                    {
                        EntityMoniker = new EntityReference
                        {
                            Id = _contractId,
                            LogicalName = Contract.EntityLogicalName
                        },
                        State = new OptionSetValue((int)ContractState.Canceled),
                        Status = new OptionSetValue(5)
                    };
                    _serviceProxy.Execute(setStateRequest);

                    Console.Write("canceled, ");

                    // Renew the canceled contract.
                    RenewContractRequest renewRequest = new RenewContractRequest()
                    {
                        ContractId = _contractId,
                        IncludeCanceledLines = true,
                        Status = 1
                    };
                    RenewContractResponse renewResponse =
                        (RenewContractResponse)_serviceProxy.Execute(renewRequest);

                    // Retrieve Id of renewed contract.
                    _renewedId = ((Contract)renewResponse.Entity).ContractId.Value;

                    // Display the Id of the renewed contract.
                    Console.WriteLine("and renewed.");

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
            // Instantiate an Account object.
            // See the Entity Metadata topic in the SDK documentation to determine
            // which attributes must be set for each entity.
            Account setupAccount = new Account()
            {
                Name = "Litware, Inc."
            };
            _accountId = _serviceProxy.Create(setupAccount);
        }

        /// <summary>
        /// Deletes any entity records that were created for this sample.
        /// <param name="prompt">Indicates whether to prompt the user 
        /// to delete the records created in this sample.</param>
        /// </summary>
        public void DeleteRequiredRecords(bool prompt)
        {
            // Two of the contracts, their associated account and the contract template
            // records that were created and used in this sample will continue to exist 
            // on your system because contracts that have been invoiced cannot be deleted 
            // in Microsoft Dynamics CRM. They can only be put on hold or canceled.

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
                _serviceProxy.Delete(Contract.EntityLogicalName, _secondCloneId);
                _serviceProxy.Delete(Contract.EntityLogicalName, _renewedId);
                _serviceProxy.Delete(Contract.EntityLogicalName, _contractId);
                SetStateRequest setStateRequest = new SetStateRequest()
                {
                    EntityMoniker = new EntityReference
                    {
                        Id = _firstCloneId,
                        LogicalName = Contract.EntityLogicalName
                    },
                    State = new OptionSetValue((int)ContractState.Invoiced),
                    Status = new OptionSetValue(3)
                };
                _serviceProxy.Execute(setStateRequest);
                setStateRequest = new SetStateRequest()
                {
                    EntityMoniker = new EntityReference
                    {
                        Id = _firstCloneId,
                        LogicalName = Contract.EntityLogicalName
                    },
                    State = new OptionSetValue((int)ContractState.Canceled),
                    Status = new OptionSetValue(5)
                };
                _serviceProxy.Execute(setStateRequest);
                _serviceProxy.Delete(Contract.EntityLogicalName, _firstCloneId);
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId);
                Console.WriteLine("Entity record(s) have been deleted.");
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
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                WorkingWithContracts app = new WorkingWithContracts();
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

// </snippetworkingwithcontracts>