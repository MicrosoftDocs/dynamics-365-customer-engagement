// <snippetretrievedatafilters1>



 // Create and Retrieve Offline Filter
 // In your Outlook client, this will appear in the System Filters tab
 // under File | CRM | Synchronize | Outlook Filters.
 Console.Write("Creating offline filter");
 String contactName = String.Format("offlineFilteredContact {0}",
     DateTime.Now.ToLongTimeString());
 String fetchXml = String.Format("<fetch version=\"1.0\" output-format=\"xml-platform\" mapping=\"logical\"><entity name=\"contact\"><attribute name=\"contactid\" /><filter type=\"and\">" +
     "<condition attribute=\"ownerid\" operator=\"eq-userid\" /><condition attribute=\"description\" operator=\"eq\" value=\"{0}\" />" +
     "<condition attribute=\"statecode\" operator=\"eq\" value=\"0\" /></filter></entity></fetch>", contactName);
 SavedQuery filter = new SavedQuery();
 filter.FetchXml = fetchXml;
 filter.IsQuickFindQuery = false;
 filter.QueryType = SavedQueryQueryType.OfflineFilters;
 filter.ReturnedTypeCode = Contact.EntityLogicalName;
 filter.Name = "ReadOnlyFilter_" + contactName;
 filter.Description = "Sample offline filter for Contact entity";
 _offlineFilter = _serviceProxy.Create(filter);

 Console.WriteLine(" and retrieving offline filter");
 SavedQuery result = (SavedQuery)_serviceProxy.Retrieve(
     SavedQuery.EntityLogicalName,
     _offlineFilter,
     new ColumnSet("name", "description"));
 Console.WriteLine("Name: {0}", result.Name);
 Console.WriteLine("Description: {0}", result.Description);
 Console.WriteLine();

 // Create and Retrieve Offline Template
 // In your Outlook client, this will appear in the User Filters tab
 // under File | CRM | Synchronize | Outlook Filters.
 Console.Write("Creating offline template");
 String accountName = String.Format("offlineFilteredAccount {0}",
     DateTime.Now.ToLongTimeString());
 fetchXml = String.Format("<fetch version=\"1.0\" output-format=\"xml-platform\" mapping=\"logical\"><entity name=\"account\"><attribute name=\"accountid\" /><filter type=\"and\">" +
     "<condition attribute=\"ownerid\" operator=\"eq-userid\" /><condition attribute=\"name\" operator=\"eq\" value=\"{0}\" />" +
     "<condition attribute=\"statecode\" operator=\"eq\" value=\"0\" /></filter></entity></fetch>", accountName);
 SavedQuery template = new SavedQuery();
 template.FetchXml = fetchXml;
 template.IsQuickFindQuery = false;
 template.QueryType = SavedQueryQueryType.OfflineTemplate;
 template.ReturnedTypeCode = Account.EntityLogicalName;
 template.Name = "ReadOnlyFilter_" + accountName;
 template.Description = "Sample offline template for Account entity";
 _offlineTemplate = _serviceProxy.Create(template);

 Console.WriteLine(" and retrieving offline template");
 result = (SavedQuery)_serviceProxy.Retrieve(
     SavedQuery.EntityLogicalName,
     _offlineTemplate,
     new ColumnSet("name", "description"));
 Console.WriteLine("Name: {0}", result.Name);
 Console.WriteLine("Description: {0}", result.Description);
 Console.WriteLine();

// </snippetretrievedatafilters1>