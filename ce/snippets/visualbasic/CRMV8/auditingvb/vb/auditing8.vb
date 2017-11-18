' <snippetauditing8>


 Console.WriteLine("Retrieving audit details for an audit record.")

 ' Retrieve the audit details and display them.
 Dim auditDetailsRequest = New RetrieveAuditDetailsRequest With {.AuditId = auditSampleId}

 Dim auditDetailsResponse = CType(_service.Execute(auditDetailsRequest), RetrieveAuditDetailsResponse)

' </snippetauditing8>