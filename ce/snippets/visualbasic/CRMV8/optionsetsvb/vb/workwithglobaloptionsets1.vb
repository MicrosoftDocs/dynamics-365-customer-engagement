' <snippetworkwithglobaloptionsets1>


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

 '                    #End Region ' How to create global option set

 ' Store the option set's id as it will be needed to find all the
 ' dependent components.
 _optionSetId = optionsResp.OptionSetId
 Console.WriteLine("The global option set has been created.")

 '                    #Region "How to create a picklist linked to the global option set"
 ' Create a Picklist linked to the option set.
 ' Specify which entity will own the picklist, and create it.
 Dim createRequest As CreateAttributeRequest = New CreateAttributeRequest With {
  .EntityName = Contact.EntityLogicalName,
  .Attribute = New PicklistAttributeMetadata With {
   .SchemaName = "sample_examplepicklist", .LogicalName = "sample_examplepicklist",
   .DisplayName = New Label("Example Picklist", _languageCode),
   .RequiredLevel = New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
   .OptionSet = New OptionSetMetadata With {
    .IsGlobal = True,
    .Name = _globalOptionSetName
   }
  }
 }
 ' In order to relate the picklist to the global option set, be sure
 ' to specify the two attributes below appropriately.
 ' Failing to do so will lead to errors.

 _serviceProxy.Execute(createRequest)
 Console.WriteLine("Referring picklist attribute created.")
 '                    #End Region ' How to create a picklist linked to the global option set

 '                    #Region "How to update a global option set"
 ' Use UpdateOptionSetRequest to update the basic information of an option
 ' set. Updating option set values requires different messages (see below).
 Dim updateOptionSetRequest As UpdateOptionSetRequest = New UpdateOptionSetRequest With {
  .OptionSet = New OptionSetMetadata With {
   .DisplayName = New Label("Updated Option Set", _languageCode),
   .Name = _globalOptionSetName,
   .IsGlobal = True
  }
 }

 _serviceProxy.Execute(updateOptionSetRequest)

 'Publish the OptionSet
 Dim pxReq1 As PublishXmlRequest = New PublishXmlRequest With {
  .ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName)
 }
 _serviceProxy.Execute(pxReq1)
 Console.WriteLine("Option Set display name changed.")
 '                    #End Region ' How to update a global option set properties

 '                    #Region "How to insert a new option item in a global option set"
 ' Use InsertOptionValueRequest to insert a new option into a 
 ' global option set.
 Dim insertOptionValueRequest As InsertOptionValueRequest = New InsertOptionValueRequest With {
  .OptionSetName = _globalOptionSetName,
  .Label = New Label("New Picklist Label", _languageCode)
 }

 ' Execute the request and store the newly inserted option value 
 ' for cleanup, used in the later part of this sample.
 _insertedOptionValue =
  (CType(_serviceProxy.Execute(insertOptionValueRequest), InsertOptionValueResponse)).NewOptionValue

 'Publish the OptionSet
 Dim pxReq2 As PublishXmlRequest = New PublishXmlRequest With {
  .ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName)
 }
 _serviceProxy.Execute(pxReq2)
 Console.WriteLine("Created {0} with the value of {1}.",
                   insertOptionValueRequest.Label.LocalizedLabels(0).Label,
                   _insertedOptionValue)
 '#End Region ' How to insert a new option item in a global option set

 '#Region "How to retrieve a global option set by it's name"
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
 '                    #End Region ' How to retrieve a global option set by it's name

 '                    #Region "How to update an option item in a picklist"
 ' In order to change labels on option set values (or delete) option set
 ' values, you must use UpdateOptionValueRequest 
 ' (or DeleteOptionValueRequest).
 Dim updateOptionValueRequest As UpdateOptionValueRequest =
  New UpdateOptionValueRequest With {
   .OptionSetName = _globalOptionSetName,
   .Value = optionList(1).Value.Value,
   .Label = New Label("Updated Option 1", _languageCode)
  }
 ' Update the second option value.

 _serviceProxy.Execute(updateOptionValueRequest)

 'Publish the OptionSet
 Dim pxReq3 As PublishXmlRequest =
  New PublishXmlRequest With {
   .ParameterXml =
   String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>",
                 _globalOptionSetName)
  }
 _serviceProxy.Execute(pxReq3)



 Console.WriteLine("Option Set option label changed.")
 '#End Region ' How to update an option item in a picklist

 '#Region "How to change the order of options of a global option set"
 ' Change the order of the original option's list.
 ' Use the OrderBy (OrderByDescending) linq function to sort options in  
 ' ascending (descending) order according to label text.
 ' For ascending order use this:
 Dim updateOptionList = optionList.OrderBy(Function(x) x.Label.LocalizedLabels(0).Label).ToList()

 ' For descending order use this:
 ' var updateOptionList =
 '      optionList.OrderByDescending(
 '      x => x.Label.LocalizedLabels[0].Label).ToList();

 ' Create the request.
 Dim orderOptionRequest As OrderOptionRequest =
  New OrderOptionRequest With {
   .OptionSetName = _globalOptionSetName,
   .Values = updateOptionList.Select(Function(x) x.Value.Value).ToArray()
  }
 ' Set the properties for the request.
 ' Set the changed order using Select linq function 
 ' to get only values in an array from the changed option list.

 ' Execute the request
 _serviceProxy.Execute(orderOptionRequest)

 'Publish the OptionSet
 Dim pxReq4 As PublishXmlRequest =
  New PublishXmlRequest With {
   .ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>",
                                 _globalOptionSetName)
  }
 _serviceProxy.Execute(pxReq4)
 Console.WriteLine("Option Set option order changed")
 '                    #End Region ' How to change the order of options of a global option set

 '                    #Region "How to retrieve all global option sets"
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
 '                    #End Region ' How to retrieve all global option sets

' </snippetworkwithglobaloptionsets1>