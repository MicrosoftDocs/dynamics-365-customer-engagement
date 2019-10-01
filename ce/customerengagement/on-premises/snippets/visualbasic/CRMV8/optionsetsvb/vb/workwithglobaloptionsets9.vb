' <snippetworkwithglobaloptionsets9>


 ' Use RetrieveAllOptionSetsRequest to retrieve all global option sets.
 ' Create the request.
 Dim retrieveAllOptionSetsRequest As New RetrieveAllOptionSetsRequest()

 ' Execute the request
 Dim retrieveAllOptionSetsResponse As RetrieveAllOptionSetsResponse =
  CType(_serviceProxy.Execute(retrieveAllOptionSetsRequest), RetrieveAllOptionSetsResponse)

 ' Now you can use RetrieveAllOptionSetsResponse.OptionSetMetadata property to 
 ' work with all retrieved option sets.
 If retrieveAllOptionSetsResponse.OptionSetMetadata.Count() > 0 Then
  Console.WriteLine("All the global option sets retrieved as below:")
  Dim count As Integer = 1
  For Each optionSetMetadata As OptionSetMetadataBase In retrieveAllOptionSetsResponse.OptionSetMetadata
                        Console.WriteLine("{0} {1}",
                                          count,
                                          If(optionSetMetadata.DisplayName.LocalizedLabels.Count > 0,
                                             optionSetMetadata.DisplayName.LocalizedLabels(0).Label,
                                             String.Empty))
   count += 1
  Next optionSetMetadata
 End If

' </snippetworkwithglobaloptionsets9>