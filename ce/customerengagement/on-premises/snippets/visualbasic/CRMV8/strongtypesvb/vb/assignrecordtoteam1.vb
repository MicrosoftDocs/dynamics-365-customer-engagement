' <snippetassignrecordtoteam1>


 ' Assign the account to a team.                
 Dim assignRequest As New AssignRequest() With {.Assignee = New EntityReference With { _
         .LogicalName = Team.EntityLogicalName, .Id = _teamId}, _
         .Target = New EntityReference(Account.EntityLogicalName, _accountId)}

 _service.Execute(assignRequest)

' </snippetassignrecordtoteam1>