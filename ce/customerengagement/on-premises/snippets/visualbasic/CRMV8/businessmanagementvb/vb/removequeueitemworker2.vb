' <snippetremovequeueitemworker2>


 ' Retrieve the user information.
 Dim whoAmIRequest As New WhoAmIRequest()
 Dim whoAmIResponse As WhoAmIResponse = CType(_serviceProxy.Execute(whoAmIRequest), WhoAmIResponse)

 Dim columnSet As New ColumnSet("fullname")
 Dim currentUser As SystemUser = CType(_serviceProxy.Retrieve(SystemUser.EntityLogicalName, _
                                                              whoAmIResponse.UserId, columnSet), SystemUser)
 Dim currentUserName As String = currentUser.FullName

' </snippetremovequeueitemworker2>