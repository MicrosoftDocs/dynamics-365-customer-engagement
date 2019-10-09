' <snippetassign1>


 ' Create the Request Object and Set the Request Object's Properties
 Dim assign As AssignRequest = New AssignRequest With { _
     .Assignee = New EntityReference(SystemUser.EntityLogicalName, _otherUserId), _
     .Target = New EntityReference(Account.EntityLogicalName, _accountId)}


 ' Execute the Request
 _service.Execute(assign)

' </snippetassign1>