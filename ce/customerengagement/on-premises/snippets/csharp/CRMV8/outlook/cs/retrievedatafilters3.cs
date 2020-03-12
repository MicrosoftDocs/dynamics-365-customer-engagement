// <snippetretrievedatafilters3>


 // Call ResetUserFiltersRequest
 Console.WriteLine("Resetting the user's offline templates to the defaults");
 ResetUserFiltersRequest resetRequest = new ResetUserFiltersRequest
 {
     QueryType = SavedQueryQueryType.OfflineFilters
 };
 ResetUserFiltersResponse resetResponse =
     (ResetUserFiltersResponse)_serviceProxy.Execute(resetRequest);
 Console.WriteLine();

// </snippetretrievedatafilters3>