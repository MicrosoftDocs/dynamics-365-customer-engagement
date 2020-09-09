// <snippetassignqueueitemworker1>


 // Retrieve the current user information.
 WhoAmIRequest whoAmIRequest = new WhoAmIRequest();
 WhoAmIResponse whoAmIResponse = (WhoAmIResponse)_serviceProxy.Execute(
     whoAmIRequest);

 ColumnSet columnSet = new ColumnSet("fullname");
 SystemUser currentUser = (SystemUser)_serviceProxy.Retrieve(
     SystemUser.EntityLogicalName,
     whoAmIResponse.UserId, columnSet);
 String currentUserName = currentUser.FullName;
 _userId = currentUser.Id;

 // Create an instance of an existing queueitem in order to specify 
 // the user that will be working on it using PickFromQueueRequest.

 PickFromQueueRequest pickFromQueueRequest = new PickFromQueueRequest
 {
     QueueItemId = _queueItemId,
     WorkerId = _userId
 };

 _serviceProxy.Execute(pickFromQueueRequest);

// </snippetassignqueueitemworker1>