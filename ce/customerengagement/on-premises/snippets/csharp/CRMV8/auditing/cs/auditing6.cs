// <snippetauditing6>


 // Get the list of audit partitions.
 RetrieveAuditPartitionListResponse partitionRequest =
     (RetrieveAuditPartitionListResponse)_service.Execute(new RetrieveAuditPartitionListRequest());
 AuditPartitionDetailCollection partitions = partitionRequest.AuditPartitionDetailCollection;

// </snippetauditing6>