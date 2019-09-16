' <snippetremoveoptionlabelsfromcache>


 Protected Sub removeOptionLabelsFromCache(ByVal DeletedMetadata As DeletedMetadataCollection,
                                           ByVal showChanges As Boolean)
     Dim optionSetOptionsToRemove As New List(Of OptionSetOption)()

     If DeletedMetadata.Keys.Contains(DeletedMetadataFilters.OptionSet) Then
         Dim optionsetmetadataids As DataCollection(Of Guid) =
             CType(DeletedMetadata(DeletedMetadataFilters.OptionSet), 
                 DataCollection(Of Guid))
         For Each metadataid As Guid In optionsetmetadataids
             For Each oso As OptionSetOption In _optionLabelList
                 If metadataid = oso.optionsetId Then
                     optionSetOptionsToRemove.Add(oso)
                 End If
             Next oso
         Next metadataid
     End If
     For Each [option] As OptionSetOption In optionSetOptionsToRemove
         _optionLabelList.Remove([option])
     Next [option]
     If showChanges Then
         If optionSetOptionsToRemove.Count > 0 Then
             Console.WriteLine("{0} Option Labels removed", optionSetOptionsToRemove.Count)
             Console.WriteLine("{0} Total Option Labels currently cached", _optionLabelList.Count)
             Console.WriteLine("")
         Else
             Console.WriteLine("No Option Labels removed.")
             Console.WriteLine("")
         End If

     End If
 End Sub

' </snippetremoveoptionlabelsfromcache>