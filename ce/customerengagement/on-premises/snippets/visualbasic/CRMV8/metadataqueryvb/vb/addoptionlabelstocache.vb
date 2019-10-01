' <snippetaddoptionlabelstocache>


  Protected Sub addOptionLabelsToCache(ByVal entityMetadataCollection_Renamed As EntityMetadataCollection, ByVal showChanges As Boolean)

   Dim changes As New List(Of OptionSetOption)()

   For Each em As EntityMetadata In entityMetadataCollection_Renamed
	For Each am As AttributeMetadata In em.Attributes
	 Select Case am.AttributeType
	  Case AttributeTypeCode.Boolean
	   Dim booleanAttribute As BooleanAttributeMetadata = CType(am, BooleanAttributeMetadata)
	   'Labels will not be included if they aren't new
	   If booleanAttribute.OptionSet.FalseOption.Label.UserLocalizedLabel IsNot Nothing Then
                                changes.Add(New OptionSetOption(CType(booleanAttribute.OptionSet.MetadataId, Guid), 0,
                                                                booleanAttribute.OptionSet.FalseOption.Label.UserLocalizedLabel.Label))
	   End If
	   'Labels will not be included if they aren't new
	   If booleanAttribute.OptionSet.TrueOption.Label.UserLocalizedLabel IsNot Nothing Then
                                changes.Add(New OptionSetOption(CType(booleanAttribute.OptionSet.MetadataId, Guid), 1,
                                                                booleanAttribute.OptionSet.TrueOption.Label.UserLocalizedLabel.Label))
	   End If
	  Case Else
	   Dim optionsetAttribute As EnumAttributeMetadata = CType(am, EnumAttributeMetadata)
	   For Each [option] As OptionMetadata In optionsetAttribute.OptionSet.Options
		'Labels will not be included if they aren't new
		If [option].Label.UserLocalizedLabel IsNot Nothing Then
                                    changes.Add(New OptionSetOption(CType(optionsetAttribute.OptionSet.MetadataId, Guid),
                                                                    CInt(Fix([option].Value)), [option].Label.UserLocalizedLabel.Label))
		End If
	   Next [option]
	 End Select
	Next am
   Next em

   _optionLabelList.AddRange(changes)

   If showChanges Then

	If changes.Count > 0 Then
                    Console.WriteLine("{0} option labels for {1} entities were added to the cache.",
                                      changes.Count, entityMetadataCollection_Renamed.Count)
	 Console.WriteLine("{0} Option Labels cached", _optionLabelList.Count)
	Else
		Console.WriteLine("No option labels were added to the cache.")
	End If

   End If
  End Sub

' </snippetaddoptionlabelstocache>