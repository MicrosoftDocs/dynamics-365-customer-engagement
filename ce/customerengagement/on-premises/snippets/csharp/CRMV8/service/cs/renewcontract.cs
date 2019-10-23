// <snippetrenewcontract>


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

// </snippetrenewcontract>