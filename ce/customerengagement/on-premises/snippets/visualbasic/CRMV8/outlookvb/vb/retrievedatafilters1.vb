' <snippetretrievedatafilters1>



 ' Create and Retrieve Offline Filter
 ' In your Outlook client, this will appear in the System Filters tab
 ' under File | CRM | Synchronize | Outlook Filters.
 Console.Write("Creating offline filter")
 Dim contactName As String = String.Format("offlineFilteredContact {0}", Date.Now.ToLongTimeString())
 Dim fetchXml As String = String.Format("<fetch version=""1.0"" output-format=""xml-platform"" mapping=""logical"">" &amp; _
     "<entity name=""contact""><attribute name=""contactid"" /><filter type=""and"">" &amp; _
     "<condition attribute=""ownerid"" operator=""eq-userid"" /><condition attribute=""description"" " &amp; _
     "operator=""eq"" value=""{0}"" />" &amp; "<condition attribute=""statecode"" operator=""eq"" value=""0"" />" &amp; _
     "</filter></entity></fetch>", contactName)
 Dim filter As New SavedQuery()
 filter.FetchXml = fetchXml
 filter.IsQuickFindQuery = False
 filter.QueryType = SavedQueryQueryType.OfflineFilters
 filter.ReturnedTypeCode = Contact.EntityLogicalName
 filter.Name = "ReadOnlyFilter_" &amp; contactName
 filter.Description = "Sample offline filter for Contact entity"
 _offlineFilter = _serviceProxy.Create(filter)

 Console.WriteLine(" and retrieving offline filter")
 Dim result As SavedQuery = CType(_serviceProxy.Retrieve(SavedQuery.EntityLogicalName, _offlineFilter, _
                                                         New ColumnSet("name", "description")), SavedQuery)
 Console.WriteLine("Name: {0}", result.Name)
 Console.WriteLine("Description: {0}", result.Description)
 Console.WriteLine()

 ' Create and Retrieve Offline Template
 ' In your Outlook client, this will appear in the User Filters tab
 ' under File | CRM | Synchronize | Outlook Filters.
 Console.Write("Creating offline template")
 Dim accountName As String = String.Format("offlineFilteredAccount {0}", Date.Now.ToLongTimeString())
 fetchXml = String.Format("<fetch version=""1.0"" output-format=""xml-platform"" mapping=""logical"">" &amp; _
                          "<entity name=""account""><attribute name=""accountid"" /><filter type=""and"">" &amp; _
                          "<condition attribute=""ownerid"" operator=""eq-userid"" /><condition attribute=""name"" " &amp; _
                          "operator=""eq"" value=""{0}"" />" &amp; _
                          "<condition attribute=""statecode"" operator=""eq"" value=""0"" /></filter></entity></fetch>", _
                          accountName)
 Dim template As New SavedQuery()
 template.FetchXml = fetchXml
 template.IsQuickFindQuery = False
 template.QueryType = SavedQueryQueryType.OfflineTemplate
 template.ReturnedTypeCode = Account.EntityLogicalName
 template.Name = "ReadOnlyFilter_" &amp; accountName
 template.Description = "Sample offline template for Account entity"
 _offlineTemplate = _serviceProxy.Create(template)

 Console.WriteLine(" and retrieving offline template")
 result = CType(_serviceProxy.Retrieve(SavedQuery.EntityLogicalName, _offlineTemplate, _
                                       New ColumnSet("name", "description")), SavedQuery)
 Console.WriteLine("Name: {0}", result.Name)
 Console.WriteLine("Description: {0}", result.Description)
 Console.WriteLine()

' </snippetretrievedatafilters1>