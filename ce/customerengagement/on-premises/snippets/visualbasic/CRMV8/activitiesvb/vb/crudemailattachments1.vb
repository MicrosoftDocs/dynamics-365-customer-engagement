' <snippetcrudemailattachments1>



 ' Create three e-mail attachments
 For i As Integer = 0 To 2
     Dim _sampleAttachment As ActivityMimeAttachment = New ActivityMimeAttachment With { _
         .ObjectId = New EntityReference(Email.EntityLogicalName, _emailId), .ObjectTypeCode = Email.EntityLogicalName, _
         .Subject = String.Format("Sample Attachment {0}", i), _
         .Body = Convert.ToBase64String(New ASCIIEncoding().GetBytes("Example Attachment")), _
         .FileName = String.Format("ExampleAttachment{0}.txt", i)}

     _emailAttachmentId(i) = _serviceProxy.Create(_sampleAttachment)
 Next i

 Console.WriteLine("Created three e-mail attachments for the e-mail activity.")

 ' Retrieve an attachment including its id, subject, filename and body.
 Dim _singleAttachment As ActivityMimeAttachment = CType(_serviceProxy.Retrieve(ActivityMimeAttachment.EntityLogicalName, _
         _emailAttachmentId(0), New ColumnSet("activitymimeattachmentid", "subject", "filename", "body")),  _
         ActivityMimeAttachment)

 Console.WriteLine("Retrieved an email attachment, {0}.", _singleAttachment.FileName)

 ' Update attachment
 _singleAttachment.FileName = "ExampleAttachmentUpdated.txt"
 _serviceProxy.Update(_singleAttachment)

 Console.WriteLine("Updated the retrieved e-mail attachment to {0}.", _singleAttachment.FileName)

 ' Retrieve all attachments associated with the email activity.
 Dim _attachmentQuery As QueryExpression = New QueryExpression With {.EntityName = ActivityMimeAttachment.EntityLogicalName, _
                                                                     .ColumnSet = New ColumnSet("activitymimeattachmentid")}

 _attachmentQuery.Criteria = New FilterExpression()
 _attachmentQuery.Criteria.AddCondition("objectid", ConditionOperator.Equal, {_emailId})
 _attachmentQuery.Criteria.AddCondition("objecttypecode", ConditionOperator.Equal, {Email.EntityLogicalName})
 _attachmentQuery.Criteria.FilterOperator = LogicalOperator.And
 Dim results As EntityCollection = _serviceProxy.RetrieveMultiple(_attachmentQuery)

 Console.WriteLine("Retrieved all the e-mail attachments.")

' </snippetcrudemailattachments1>