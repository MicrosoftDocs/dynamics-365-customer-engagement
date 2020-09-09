' <snippetauditing5>



 ' Retrieve the audit history for the account and display it.
 Dim changeRequest As New RetrieveRecordChangeHistoryRequest()
 changeRequest.Target = New EntityReference(Account.EntityLogicalName, _newAccountId)

 Dim changeResponse As RetrieveRecordChangeHistoryResponse = CType(_service.Execute(changeRequest), RetrieveRecordChangeHistoryResponse)

 Dim details As AuditDetailCollection = changeResponse.AuditDetailCollection

' </snippetauditing5>