' <snippetgetemailtemplateattachments1>



 'Create a query to retrieve attachments.
 Dim query As QueryExpression = New QueryExpression With { _
     .EntityName = ActivityMimeAttachment.EntityLogicalName, .ColumnSet = New ColumnSet("filename")}
 query.Criteria = New FilterExpression()
 query.Criteria.AddCondition("objecttypecode", ConditionOperator.Equal, {Template.EntityTypeCode})
 query.Criteria.AddCondition("objectid", ConditionOperator.Equal, {_emailTemplateId})
 query.Criteria.FilterOperator = LogicalOperator.And
     'Define the conditions for each attachment.
         'The ObjectTypeCode must be specified, or else the query
         'defaults to "email" instead of "template".
         'Specify which template we need.

 'Write out the filename of each attachment retrieved.
 For Each attachment As ActivityMimeAttachment In _serviceProxy.RetrieveMultiple(query).Entities
     Console.WriteLine("Retrieved attachment {0}", attachment.FileName)
 Next attachment

' </snippetgetemailtemplateattachments1>