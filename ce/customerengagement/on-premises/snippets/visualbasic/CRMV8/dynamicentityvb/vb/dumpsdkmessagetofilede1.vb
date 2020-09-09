' <snippetdumpsdkmessagetofilede1>


 ' Retrieve all SDK Message Records.
 Dim sdkMessageQuery As QueryExpression = New QueryExpression With { _
     .EntityName = "sdkmessage", .ColumnSet = New ColumnSet("categoryname", "name", "isprivate", "availability", _
                                                            "customizationlevel", "expand", "template", "sdkmessageid")}
     'Criteria = new FilterExpression(),

 Dim sdkMessages As EntityCollection = _service.RetrieveMultiple(sdkMessageQuery)

' </snippetdumpsdkmessagetofilede1>