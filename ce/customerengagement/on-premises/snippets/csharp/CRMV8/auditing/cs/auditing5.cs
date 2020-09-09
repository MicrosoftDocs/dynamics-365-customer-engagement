// <snippetauditing5>


 // Retrieve the audit history for the account and display it.
 RetrieveRecordChangeHistoryRequest changeRequest = new RetrieveRecordChangeHistoryRequest();
 changeRequest.Target = new EntityReference(Account.EntityLogicalName, _newAccountId);

 RetrieveRecordChangeHistoryResponse changeResponse =
     (RetrieveRecordChangeHistoryResponse)_service.Execute(changeRequest);

 AuditDetailCollection details = changeResponse.AuditDetailCollection;

// </snippetauditing5>