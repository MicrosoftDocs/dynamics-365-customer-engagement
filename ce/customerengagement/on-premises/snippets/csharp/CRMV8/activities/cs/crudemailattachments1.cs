// <snippetcrudemailattachments1>



 // Create three e-mail attachments
 for (int i = 0; i < 3; i++)
 {
     ActivityMimeAttachment _sampleAttachment = new ActivityMimeAttachment
     {
         ObjectId = new EntityReference(Email.EntityLogicalName, _emailId),
         ObjectTypeCode = Email.EntityLogicalName,
         Subject = String.Format("Sample Attachment {0}", i),
         Body = System.Convert.ToBase64String(
                 new ASCIIEncoding().GetBytes("Example Attachment")),
         FileName = String.Format("ExampleAttachment{0}.txt", i)
     };

     _emailAttachmentId[i] = _serviceProxy.Create(_sampleAttachment);
 }

 Console.WriteLine("Created three e-mail attachments for the e-mail activity.");

 // Retrieve an attachment including its id, subject, filename and body.
 ActivityMimeAttachment _singleAttachment =
     (ActivityMimeAttachment)_serviceProxy.Retrieve(
                                 ActivityMimeAttachment.EntityLogicalName,
                                 _emailAttachmentId[0],
                                 new ColumnSet("activitymimeattachmentid",
                                     "subject",
                                     "filename",
                                     "body"));

 Console.WriteLine("Retrieved an email attachment, {0}.", _singleAttachment.FileName);

 // Update attachment
 _singleAttachment.FileName = "ExampleAttachmentUpdated.txt";
 _serviceProxy.Update(_singleAttachment);

 Console.WriteLine("Updated the retrieved e-mail attachment to {0}.", _singleAttachment.FileName);

 // Retrieve all attachments associated with the email activity.
 QueryExpression _attachmentQuery = new QueryExpression
 {
     EntityName = ActivityMimeAttachment.EntityLogicalName,
     ColumnSet = new ColumnSet("activitymimeattachmentid"),
     Criteria = new FilterExpression
     {
         Conditions =
     {
         new ConditionExpression
         {
             AttributeName = "objectid",
             Operator = ConditionOperator.Equal,
             Values = {_emailId}
         },
         new ConditionExpression
         {
             AttributeName = "objecttypecode",
             Operator = ConditionOperator.Equal,
             Values = {Email.EntityLogicalName}
         }
     }
     }
 };

 EntityCollection results = _serviceProxy.RetrieveMultiple(
     _attachmentQuery);

 Console.WriteLine("Retrieved all the e-mail attachments.");

// </snippetcrudemailattachments1>