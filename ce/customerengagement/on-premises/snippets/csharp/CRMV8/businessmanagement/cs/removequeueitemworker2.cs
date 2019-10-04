// <snippetremovequeueitemworker2>


 // Retrieve the user information.
 WhoAmIRequest whoAmIRequest = new WhoAmIRequest();
 WhoAmIResponse whoAmIResponse = (WhoAmIResponse)_serviceProxy.Execute(
     whoAmIRequest);

 ColumnSet columnSet = new ColumnSet("fullname");
 SystemUser currentUser = (SystemUser)_serviceProxy.Retrieve(
     SystemUser.EntityLogicalName,
     whoAmIResponse.UserId, columnSet);
 String currentUserName = currentUser.FullName;

// </snippetremovequeueitemworker2>