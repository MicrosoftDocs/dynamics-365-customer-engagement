// <snippetsetstateforcontract>


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

// </snippetsetstateforcontract>