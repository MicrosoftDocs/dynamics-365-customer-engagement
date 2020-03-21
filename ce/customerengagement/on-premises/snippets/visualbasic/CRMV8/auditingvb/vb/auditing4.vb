' <snippetauditing4>


 ' Get the list of audit partitions.
 Dim partitionRequest As RetrieveAuditPartitionListResponse = CType(_service.Execute(New RetrieveAuditPartitionListRequest()), RetrieveAuditPartitionListResponse)
 Dim partitions As AuditPartitionDetailCollection = partitionRequest.AuditPartitionDetailCollection

 ' Create a delete request with an end date earlier than possible.
 Dim deleteRequest As New DeleteAuditDataRequest()
 deleteRequest.EndDate = New Date(2000, 1, 1)

 ' Check if partitions are not supported as is the case with SQL Server Standard edition.
 If partitions.IsLogicalCollection Then
     ' Delete all audit records created up until now.
     deleteRequest.EndDate = Date.Now

     ' Otherwise, delete all partitions that are older than the current partition.
     ' Hint: The partitions in the collection are returned in sorted order where the 
     ' partition with the oldest end date is at index 0.
 Else
     For n As Integer = partitions.Count - 1 To 0 Step -1
         If partitions(n).EndDate <= Date.Now AndAlso partitions(n).EndDate > deleteRequest.EndDate Then
             deleteRequest.EndDate = CDate(partitions(n).EndDate)
             Exit For
         End If
     Next n
 End If

 ' Delete the audit records.
 If deleteRequest.EndDate <> New Date(2000, 1, 1) Then
     _service.Execute(deleteRequest)
     Console.WriteLine("Audit records have been deleted.")
 Else
     Console.WriteLine("There were no audit records that could be deleted.")
 End If

' </snippetauditing4>