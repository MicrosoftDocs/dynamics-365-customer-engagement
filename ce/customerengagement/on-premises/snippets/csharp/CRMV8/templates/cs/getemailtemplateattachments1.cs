// <snippetgetemailtemplateattachments1>



 //Create a query to retrieve attachments.
 QueryExpression query = new QueryExpression
 {
     EntityName = ActivityMimeAttachment.EntityLogicalName,
     ColumnSet = new ColumnSet("filename"),

     //Define the conditions for each attachment.
     Criteria =
     {
         FilterOperator = LogicalOperator.And,
         Conditions =
     {
         //The ObjectTypeCode must be specified, or else the query
         //defaults to "email" instead of "template".
         new ConditionExpression
         {
             AttributeName = "objecttypecode",
             Operator = ConditionOperator.Equal,
             Values = {Template.EntityTypeCode}
         },
         //Specify which template we need.
         new ConditionExpression
         {
             AttributeName = "objectid",
             Operator = ConditionOperator.Equal,
             Values = {_emailTemplateId}
         }
     }
     }
 };

 //Write out the filename of each attachment retrieved.
 foreach (ActivityMimeAttachment attachment in _serviceProxy.RetrieveMultiple(query).Entities)
 {
     Console.WriteLine("Retrieved attachment {0}", attachment.FileName);
 }

// </snippetgetemailtemplateattachments1>