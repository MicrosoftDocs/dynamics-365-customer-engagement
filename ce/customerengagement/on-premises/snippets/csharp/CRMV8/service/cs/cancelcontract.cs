// <snippetcancelcontract>


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

// </snippetcancelcontract>