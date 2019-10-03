' <snippetauditing6>


 ' Get the list of audit partitions.
 Dim partitionRequest As RetrieveAuditPartitionListResponse = CType(_service.Execute(New RetrieveAuditPartitionListRequest()), RetrieveAuditPartitionListResponse)
 Dim partitions As AuditPartitionDetailCollection = partitionRequest.AuditPartitionDetailCollection

' </snippetauditing6>