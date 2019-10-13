// <snippetworkingwithcontracts1>


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

// </snippetworkingwithcontracts1>