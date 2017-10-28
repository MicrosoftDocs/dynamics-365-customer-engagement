// <snippetworkwithglobaloptionsets1>


 #region How to create global option set
 // Define the request object and pass to the service.
 CreateOptionSetRequest createOptionSetRequest = new CreateOptionSetRequest
 {
     // Create a global option set (OptionSetMetadata).
     OptionSet = new OptionSetMetadata
     {
         Name = _globalOptionSetName,
         DisplayName = new Label("Example Option Set", _languageCode),
         IsGlobal = true,
         OptionSetType = OptionSetType.Picklist,
         Options = 
     {
         new OptionMetadata(new Label("Open", _languageCode), null),
         new OptionMetadata(new Label("Suspended", _languageCode), null),
         new OptionMetadata(new Label("Cancelled", _languageCode), null),
         new OptionMetadata(new Label("Closed", _languageCode), null)
     }
     }
 };

 // Execute the request.
 CreateOptionSetResponse optionsResp =
     (CreateOptionSetResponse)_serviceProxy.Execute(createOptionSetRequest);

 #endregion How to create global option set

 // Store the option set's id as it will be needed to find all the
 // dependent components.
 _optionSetId = optionsResp.OptionSetId;
 Console.WriteLine("The global option set has been created.");

 #region How to create a picklist linked to the global option set
 // Create a Picklist linked to the option set.
 // Specify which entity will own the picklist, and create it.
 CreateAttributeRequest createRequest = new CreateAttributeRequest
 {
     EntityName = Contact.EntityLogicalName,
     Attribute = new PicklistAttributeMetadata
     {
         SchemaName = "sample_examplepicklist",
         LogicalName = "sample_examplepicklist",
         DisplayName = new Label("Example Picklist", _languageCode),
         RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),

         // In order to relate the picklist to the global option set, be sure
         // to specify the two attributes below appropriately.
         // Failing to do so will lead to errors.
         OptionSet = new OptionSetMetadata
         {
             IsGlobal = true,
             Name = _globalOptionSetName
         }
     }
 };

 _serviceProxy.Execute(createRequest);
 Console.WriteLine("Referring picklist attribute created.");
 #endregion How to create a picklist linked to the global option set

 #region How to update a global option set
 // Use UpdateOptionSetRequest to update the basic information of an option
 // set. Updating option set values requires different messages (see below).
 UpdateOptionSetRequest updateOptionSetRequest = new UpdateOptionSetRequest
 {
     OptionSet = new OptionSetMetadata
     {
         DisplayName = new Label("Updated Option Set", _languageCode),
         Name = _globalOptionSetName,
         IsGlobal = true
     }
 };

 _serviceProxy.Execute(updateOptionSetRequest);

 //Publish the OptionSet
 PublishXmlRequest pxReq1 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
 _serviceProxy.Execute(pxReq1);
 Console.WriteLine("Option Set display name changed.");
 #endregion How to update a global option set properties

 #region How to insert a new option item in a global option set
 // Use InsertOptionValueRequest to insert a new option into a 
 // global option set.
 InsertOptionValueRequest insertOptionValueRequest =
     new InsertOptionValueRequest
     {
         OptionSetName = _globalOptionSetName,
         Label = new Label("New Picklist Label", _languageCode)
     };

 // Execute the request and store the newly inserted option value 
 // for cleanup, used in the later part of this sample.
 _insertedOptionValue = ((InsertOptionValueResponse)_serviceProxy.Execute(
     insertOptionValueRequest)).NewOptionValue;

 //Publish the OptionSet
 PublishXmlRequest pxReq2 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
 _serviceProxy.Execute(pxReq2);
 Console.WriteLine("Created {0} with the value of {1}.",
     insertOptionValueRequest.Label.LocalizedLabels[0].Label,
     _insertedOptionValue);
 #endregion How to insert a new option item in a global option set

 #region How to retrieve a global option set by it's name
 // Use the RetrieveOptionSetRequest message to retrieve  
 // a global option set by it's name.
 RetrieveOptionSetRequest retrieveOptionSetRequest =
     new RetrieveOptionSetRequest
     {
         Name = _globalOptionSetName
     };

 // Execute the request.
 RetrieveOptionSetResponse retrieveOptionSetResponse =
     (RetrieveOptionSetResponse)_serviceProxy.Execute(
     retrieveOptionSetRequest);

 Console.WriteLine("Retrieved {0}.",
     retrieveOptionSetRequest.Name);

 // Access the retrieved OptionSetMetadata.
 OptionSetMetadata retrievedOptionSetMetadata =
     (OptionSetMetadata)retrieveOptionSetResponse.OptionSetMetadata;

 // Get the current options list for the retrieved attribute.
 OptionMetadata[] optionList =
     retrievedOptionSetMetadata.Options.ToArray();
 #endregion How to retrieve a global option set by it's name

 #region How to update an option item in a picklist
 // In order to change labels on option set values (or delete) option set
 // values, you must use UpdateOptionValueRequest 
 // (or DeleteOptionValueRequest).
 UpdateOptionValueRequest updateOptionValueRequest =
     new UpdateOptionValueRequest
     {
         OptionSetName = _globalOptionSetName,
         // Update the second option value.
         Value = optionList[1].Value.Value,
         Label = new Label("Updated Option 1", _languageCode)
     };

 _serviceProxy.Execute(updateOptionValueRequest);

 //Publish the OptionSet
 PublishXmlRequest pxReq3 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
 _serviceProxy.Execute(pxReq3);

 

 Console.WriteLine("Option Set option label changed.");
 #endregion How to update an option item in a picklist

 #region How to change the order of options of a global option set
 // Change the order of the original option's list.
 // Use the OrderBy (OrderByDescending) linq function to sort options in  
 // ascending (descending) order according to label text.
 // For ascending order use this:
 var updateOptionList =
     optionList.OrderBy(x => x.Label.LocalizedLabels[0].Label).ToList();

 // For descending order use this:
 // var updateOptionList =
 //      optionList.OrderByDescending(
 //      x => x.Label.LocalizedLabels[0].Label).ToList();

 // Create the request.
 OrderOptionRequest orderOptionRequest = new OrderOptionRequest
 {
     // Set the properties for the request.
     OptionSetName = _globalOptionSetName,
     // Set the changed order using Select linq function 
     // to get only values in an array from the changed option list.
     Values = updateOptionList.Select(x => x.Value.Value).ToArray()
 };

 // Execute the request
 _serviceProxy.Execute(orderOptionRequest);

 //Publish the OptionSet
 PublishXmlRequest pxReq4 = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><optionsets><optionset>{0}</optionset></optionsets></importexportxml>", _globalOptionSetName) };
 _serviceProxy.Execute(pxReq4);
 Console.WriteLine("Option Set option order changed");
 #endregion How to change the order of options of a global option set

 #region How to retrieve all global option sets
 // Use RetrieveAllOptionSetsRequest to retrieve all global option sets.
 // Create the request.
 RetrieveAllOptionSetsRequest retrieveAllOptionSetsRequest =
     new RetrieveAllOptionSetsRequest();

 // Execute the request
 RetrieveAllOptionSetsResponse retrieveAllOptionSetsResponse =
     (RetrieveAllOptionSetsResponse)_serviceProxy.Execute(
     retrieveAllOptionSetsRequest);

 // Now you can use RetrieveAllOptionSetsResponse.OptionSetMetadata property to 
 // work with all retrieved option sets.
 if (retrieveAllOptionSetsResponse.OptionSetMetadata.Count() > 0)
 {
     Console.WriteLine("All the global option sets retrieved as below:");
     int count = 1;
     foreach (OptionSetMetadataBase optionSetMetadata in
         retrieveAllOptionSetsResponse.OptionSetMetadata)
     {
         Console.WriteLine("{0} {1}", count++,
             (optionSetMetadata.DisplayName.LocalizedLabels.Count >0)? optionSetMetadata.DisplayName.LocalizedLabels[0].Label : String.Empty);
     }
 }
 #endregion How to retrieve all global option sets

// </snippetworkwithglobaloptionsets1>