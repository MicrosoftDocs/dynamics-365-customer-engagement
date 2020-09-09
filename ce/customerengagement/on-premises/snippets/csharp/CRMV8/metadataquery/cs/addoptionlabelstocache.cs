// <snippetaddoptionlabelstocache>


 protected void addOptionLabelsToCache(EntityMetadataCollection entityMetadataCollection, Boolean showChanges)
 {

  List<OptionSetOption> changes = new List<OptionSetOption>();

  foreach (EntityMetadata em in entityMetadataCollection)
  {
   foreach (AttributeMetadata am in em.Attributes)
   {
    switch (am.AttributeType)
    {
     case AttributeTypeCode.Boolean:
      BooleanAttributeMetadata booleanAttribute = (BooleanAttributeMetadata)am;
      //Labels will not be included if they aren't new
      if (booleanAttribute.OptionSet.FalseOption.Label.UserLocalizedLabel != null)
      {
       changes.Add(new OptionSetOption(
       (Guid)booleanAttribute.OptionSet.MetadataId,
       0, 
       booleanAttribute.OptionSet.FalseOption.Label.UserLocalizedLabel.Label)
       );
      }
      //Labels will not be included if they aren't new
      if (booleanAttribute.OptionSet.TrueOption.Label.UserLocalizedLabel != null)
      {
       changes.Add(new OptionSetOption(
       (Guid)booleanAttribute.OptionSet.MetadataId,
       1, 
       booleanAttribute.OptionSet.TrueOption.Label.UserLocalizedLabel.Label));
      }
      break;
     default:
      EnumAttributeMetadata optionsetAttribute = (EnumAttributeMetadata)am;
      foreach (OptionMetadata option in optionsetAttribute.OptionSet.Options)
      {
       //Labels will not be included if they aren't new
       if (option.Label.UserLocalizedLabel != null)
       {
        changes.Add(new OptionSetOption(
         (Guid)optionsetAttribute.OptionSet.MetadataId,
        (int)option.Value, 
        option.Label.UserLocalizedLabel.Label));
       }        
      }
      break;
    }
   }
  }

  _optionLabelList.AddRange(changes);

  if (showChanges)
  {

   if (changes.Count > 0)
   {
    Console.WriteLine("{0} option labels for {1} entities were added to the cache.", changes.Count, entityMetadataCollection.Count);
    Console.WriteLine("{0} Option Labels cached", _optionLabelList.Count);
   }
   else
   { Console.WriteLine("No option labels were added to the cache."); }

  }
 }

// </snippetaddoptionlabelstocache>