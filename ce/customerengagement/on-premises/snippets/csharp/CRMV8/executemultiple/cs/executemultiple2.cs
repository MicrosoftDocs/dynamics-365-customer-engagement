// <snippetexecutemultiple2>


 catch (FaultException<OrganizationServiceFault> fault)
 {
     // Check if the maximum batch size has been exceeded. The maximum batch size is only included in the fault if it
     // the input request collection count exceeds the maximum batch size.
     if (fault.Detail.ErrorDetails.Contains("MaxBatchSize"))
     {
         int maxBatchSize = Convert.ToInt32(fault.Detail.ErrorDetails["MaxBatchSize"]);
         if (maxBatchSize < requestWithResults.Requests.Count)
         {
             // Here you could reduce the size of your request collection and re-submit the ExecuteMultiple request.
             // For this sample, that only issues a few requests per batch, we will just print out some info. However,
             // this code will never be executed because the default max batch size is 1000.
             Console.WriteLine("The input request collection contains %0 requests, which exceeds the maximum allowed (%1)",
                 requestWithResults.Requests.Count, maxBatchSize);
         }
     }
     // Re-throw so Main() can process the fault.
     throw;
 }

// </snippetexecutemultiple2>