' <snippetworkwithglobaloptionsets6>


 ' Use the RetrieveOptionSetRequest message to retrieve  
 ' a global option set by it's name.
 Dim retrieveOptionSetRequest As RetrieveOptionSetRequest = New RetrieveOptionSetRequest With {
  .Name = _globalOptionSetName
 }

 ' Execute the request.
 Dim retrieveOptionSetResponse As RetrieveOptionSetResponse =
  CType(_serviceProxy.Execute(retrieveOptionSetRequest), RetrieveOptionSetResponse)

 Console.WriteLine("Retrieved {0}.", retrieveOptionSetRequest.Name)

 ' Access the retrieved OptionSetMetadata.
 Dim retrievedOptionSetMetadata As OptionSetMetadata =
  CType(retrieveOptionSetResponse.OptionSetMetadata, OptionSetMetadata)

 ' Get the current options list for the retrieved attribute.
 Dim optionList() As OptionMetadata = retrievedOptionSetMetadata.Options.ToArray()

' </snippetworkwithglobaloptionsets6>