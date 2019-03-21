// <snippetstatemodeltransitions.getoptionsetlabel>


 /// <summary>
 /// Returns a string representing the label of an option in an optionset
 /// </summary>
 /// <param name="attribute">The metadata for an attribute with options</param>
 /// <param name="value">The value of the option</param>
 /// <returns>The label for the option</returns>
 public String GetOptionSetLabel(EnumAttributeMetadata attribute, int value)
  {
   String label = "";
   foreach (OptionMetadata option in attribute.OptionSet.Options)
   {
    if (option.Value.Value == value)
    {
     try
     {
      label = option.Label.UserLocalizedLabel.Label;
     }
     catch (Exception)
     {
      label = option.Label.LocalizedLabels[0].Label;
     };
    }
   }
   return label;
  }

// </snippetstatemodeltransitions.getoptionsetlabel>