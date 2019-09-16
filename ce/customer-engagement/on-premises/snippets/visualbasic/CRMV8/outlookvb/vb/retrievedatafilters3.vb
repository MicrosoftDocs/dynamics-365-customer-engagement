' <snippetretrievedatafilters3>



 ' Call ResetUserFiltersRequest
 Console.WriteLine("Resetting the user's offline templates to the defaults")
 Dim resetRequest As ResetUserFiltersRequest = New ResetUserFiltersRequest With {.QueryType = SavedQueryQueryType.OfflineFilters}
 Dim resetResponse As ResetUserFiltersResponse = CType(_serviceProxy.Execute(resetRequest), ResetUserFiltersResponse)
 Console.WriteLine()

' </snippetretrievedatafilters3>