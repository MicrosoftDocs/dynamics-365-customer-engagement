' <snippetworkwithglobaloptionsets2>


 '                    #Region "How to create global option set"
 ' Define the request object and pass to the service.
 Dim createOptionSetRequest As CreateOptionSetRequest = New CreateOptionSetRequest()
 Dim createOptionSetOptionSet As OptionSetMetadata = New OptionSetMetadata() With {
  .Name = _globalOptionSetName,
  .DisplayName = New Label("Example Option Set", _languageCode),
  .IsGlobal = True,
  .OptionSetType = OptionSetType.Picklist
 }
 createOptionSetOptionSet.Options.AddRange(
  {
   New OptionMetadata(New Label("Open", _languageCode), Nothing),
   New OptionMetadata(New Label("Suspended", _languageCode), Nothing),
   New OptionMetadata(New Label("Cancelled", _languageCode), Nothing),
   New OptionMetadata(New Label("Closed", _languageCode), Nothing)
  }
 )

 createOptionSetRequest.OptionSet = createOptionSetOptionSet
 ' Create a global option set (OptionSetMetadata).

 ' Execute the request.
 Dim optionsResp As CreateOptionSetResponse =
  CType(_serviceProxy.Execute(createOptionSetRequest), CreateOptionSetResponse)

' </snippetworkwithglobaloptionsets2>