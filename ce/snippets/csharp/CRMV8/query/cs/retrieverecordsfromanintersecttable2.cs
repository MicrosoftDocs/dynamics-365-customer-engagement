// <snippetretrieverecordsfromanintersecttable2>


 #region Retrieve records from an intersect table via Fetch

 // Setup Fetch XML.
 StringBuilder linkFetch = new StringBuilder();
 linkFetch.Append("<fetch version=\"1.0\" output-format=\"xml-platform\" mapping=\"logical\" distinct=\"true\">");
 linkFetch.Append("<entity name=\"role\">");
 linkFetch.Append("<attribute name=\"name\"/>");
 linkFetch.Append("<link-entity name=\"systemuserroles\" from=\"roleid\" to=\"roleid\" visible=\"false\" intersect=\"true\">");
 linkFetch.Append("<filter type=\"and\">");
 linkFetch.Append("<condition attribute=\"systemuserid\" operator=\"eq\" value=\"" + _userId + "\"/>");
 linkFetch.Append("</filter>");
 linkFetch.Append("</link-entity>");
 linkFetch.Append("</entity>");
 linkFetch.Append("</fetch>");

 // Build fetch request and obtain results.
 RetrieveMultipleRequest efr = new RetrieveMultipleRequest()
 {
     Query = new FetchExpression(linkFetch.ToString())
 };
 EntityCollection entityResults = ((RetrieveMultipleResponse)_serviceProxy.Execute(efr)).EntityCollection;

 // Display results.
 foreach (var e in entityResults.Entities) 
 {
     Console.WriteLine("Fetch Retrieved: {0}", e.Attributes["name"]);
 }

 #endregion

// </snippetretrieverecordsfromanintersecttable2>