// <snippetauditing8>


 Console.WriteLine("Retrieving audit details for an audit record.");

 // Retrieve the audit details and display them.
 var auditDetailsRequest = new RetrieveAuditDetailsRequest
 {
     AuditId = auditSampleId
 };

 var auditDetailsResponse =
     (RetrieveAuditDetailsResponse)_service.Execute(auditDetailsRequest);

// </snippetauditing8>