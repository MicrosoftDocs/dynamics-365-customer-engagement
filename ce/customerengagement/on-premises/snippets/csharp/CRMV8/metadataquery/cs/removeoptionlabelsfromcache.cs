// <snippetremoveoptionlabelsfromcache>


 protected void removeOptionLabelsFromCache(DeletedMetadataCollection DeletedMetadata, Boolean showChanges)
 {
  List<OptionSetOption> optionSetOptionsToRemove = new List<OptionSetOption>();

  if (DeletedMetadata.Keys.Contains(DeletedMetadataFilters.OptionSet))
  {
   DataCollection<Guid> optionsetmetadataids = (DataCollection<Guid>)DeletedMetadata[DeletedMetadataFilters.OptionSet];
   foreach (Guid metadataid in optionsetmetadataids)
   {
    foreach (OptionSetOption oso in _optionLabelList)
    {
     if (metadataid == oso.optionsetId)
     {
      optionSetOptionsToRemove.Add(oso);
     }
    }
   }
  }
  foreach (OptionSetOption option in optionSetOptionsToRemove)
  {
   _optionLabelList.Remove(option);
  }
  if (showChanges)
  {
   if (optionSetOptionsToRemove.Count > 0)
   {
    Console.WriteLine("{0} Option Labels removed", optionSetOptionsToRemove.Count);
    Console.WriteLine("{0} Total Option Labels currently cached", _optionLabelList.Count);
    Console.WriteLine("");
   }
   else
   {
    Console.WriteLine("No Option Labels removed.");
    Console.WriteLine("");
   }

  }
 }

// </snippetremoveoptionlabelsfromcache>