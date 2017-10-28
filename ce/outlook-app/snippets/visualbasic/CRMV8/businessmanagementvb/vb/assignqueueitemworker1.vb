' <snippetassignqueueitemworker1>


 ' Retrieve the user information.
 Dim whoAmIRequest As New WhoAmIRequest()
 Dim whoAmIResponse As WhoAmIResponse = CType(_serviceProxy.Execute(whoAmIRequest), WhoAmIResponse)

 Dim columnSet As New ColumnSet("fullname")
 Dim currentUser As SystemUser = CType(_serviceProxy.Retrieve(SystemUser.EntityLogicalName, _
                                                              whoAmIResponse.UserId, columnSet), SystemUser)
 Dim currentUserName As String = currentUser.FullName

 ' Create an instance of an existing queueitem in order to specify 
 ' the user that will be working on it.
 Dim queueItem As QueueItem = New QueueItem With {.QueueItemId = _queueItemId, .WorkerId = _
     New EntityReference(SystemUser.EntityLogicalName, whoAmIResponse.UserId)}

 _serviceProxy.Update(queueItem)

' </snippetassignqueueitemworker1>