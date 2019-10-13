' <snippetassignvisualizationtouser1>



                Dim assignRequest As AssignRequest =
                    New AssignRequest With
                    {
                        .Assignee = New EntityReference With
                                    {
                                        .LogicalName = SystemUser.EntityLogicalName,
                                        .Id = _otherUserId
                                    },
                        .Target = New EntityReference With
                                  {
                                      .LogicalName = UserQueryVisualization.EntityLogicalName,
                                      .Id = _userOwnedVisualizationId
                                  }
                    }
                ' Here we could assign the visualization to the newly created user
	_serviceProxy.Execute(assignRequest)

	Console.WriteLine("The user visualization has been assigned to Kevin Cook.")

' </snippetassignvisualizationtouser1>