' <snippetassigndashboardtouser1>


                Dim assignRequest As AssignRequest = New AssignRequest With
                                                     {
                                                         .Assignee = New EntityReference With
                                                                     {
                                                                         .LogicalName = SystemUser.EntityLogicalName,
                                                                         .Id = _otherUserId
                                                                     },
                                                         .Target = New EntityReference With
                                                                   {
                                                                       .LogicalName = UserForm.EntityLogicalName,
                                                                       .Id = _userDashboardId
                                                                   }
                                                     }
			' Here we could assign the visualization to the newly created user
	_serviceProxy.Execute(assignRequest)

	Console.WriteLine("The user dashboard has been assigned to Kevin Cook.")

' </snippetassigndashboardtouser1>