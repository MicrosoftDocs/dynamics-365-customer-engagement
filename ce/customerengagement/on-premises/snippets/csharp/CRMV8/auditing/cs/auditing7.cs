// <snippetauditing7>


 // Update the Telephone1 attribute in the Account entity record.
 Account accountToUpdate = new Account();
 accountToUpdate.AccountId = _newAccountId;
 accountToUpdate.Telephone1 = "123-555-5555";
 _serviceProxy.Update(accountToUpdate);
 Console.WriteLine("Updated the Telephone1 field in the Account entity.");

 // Retrieve the attribute change history.
 Console.WriteLine("Retrieving the attribute change history for Telephone1.");

 var attributeChangeHistoryRequest = new RetrieveAttributeChangeHistoryRequest
 {
     Target = new EntityReference(
         Account.EntityLogicalName, _newAccountId),
     AttributeLogicalName = "telephone1"
 };

 var attributeChangeHistoryResponse =
     (RetrieveAttributeChangeHistoryResponse)_service.Execute(attributeChangeHistoryRequest);

 // Display the attribute change history.
 details = attributeChangeHistoryResponse.AuditDetailCollection;

// </snippetauditing7>