// <snippetclonecontract>


 // Create the first clone of the contract.
 CloneContractRequest cloneRequest = new CloneContractRequest()
 {
     ContractId = _contractId,
     IncludeCanceledLines = false
 };
 CloneContractResponse cloneResponse =
     (CloneContractResponse)_serviceProxy.Execute(cloneRequest);
 _firstCloneId = ((Contract)cloneResponse.Entity).ContractId.Value;

// </snippetclonecontract>