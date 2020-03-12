// <snippetdumpsdkmessagetofilede1>


 // Retrieve all SDK Message Records.
 QueryExpression sdkMessageQuery = new QueryExpression
 {
     EntityName = "sdkmessage",
     ColumnSet = new ColumnSet("categoryname",
         "name", "isprivate", "availability", "customizationlevel",
         "expand", "template", "sdkmessageid"),
     //Criteria = new FilterExpression(),
 };

 EntityCollection sdkMessages = _service.RetrieveMultiple(sdkMessageQuery);

// </snippetdumpsdkmessagetofilede1>