' <snippetexecutemultiple2>


 Catch fault As FaultException(Of OrganizationServiceFault)

     ' Check if the maximum batch size has been exceeded. The maximum batch size is only included in the fault if it
     ' the input request collection count exceeds the maximum batch size.
     If fault.Detail.ErrorDetails.Contains("MaxBatchSize") Then

         Dim maxBatchSize As Integer = Convert.ToInt32(fault.Detail.ErrorDetails("MaxBatchSize"))
         If maxBatchSize < requestWithResults.Requests.Count Then
             ' Here you could reduce the size of your request collection and re-submit the ExecuteMultiple request.
             ' For this sample, that only issues a few requests per batch, we will just print out some info. However,
             ' this code will never be executed because the default max batch size is 1000.
             Console.WriteLine("The input request collection contains %0 requests, which exceeds the maximum allowed (%1)", requestWithResults.Requests.Count, maxBatchSize)
         End If
     End If
     ' Re-throw so Main() can process the fault.
     Throw
 End Try

' </snippetexecutemultiple2>