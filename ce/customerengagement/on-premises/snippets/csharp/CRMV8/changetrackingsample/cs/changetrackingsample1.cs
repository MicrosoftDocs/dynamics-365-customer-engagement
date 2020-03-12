// <snippetchangetrackingsample1>


 string token;

 // Initialize page number.
 int pageNumber = 1;
 List<Entity> initialrecords = new List<Entity>();

 // Retrieve records by using Change Tracking feature.
 RetrieveEntityChangesRequest request = new RetrieveEntityChangesRequest();
 request.EntityName = _customBooksEntityName.ToLower();
 request.Columns = new ColumnSet("sample_bookcode", "sample_name", "sample_author");
 request.PageInfo = new PagingInfo() { Count = 5000, PageNumber = 1, ReturnTotalRecordCount = false };


 // Initial Synchronization. Retrieves all records as well as token value.
 Console.WriteLine("Initial synchronization....retrieving all records.");
 while (true)
 {
     RetrieveEntityChangesResponse response = (RetrieveEntityChangesResponse)_serviceProxy.Execute(request);

     initialrecords.AddRange(response.EntityChanges.Changes.Select(x => (x as NewOrUpdatedItem).NewOrUpdatedEntity).ToArray());
     initialrecords.ForEach(x => Console.WriteLine("initial record id:{0}", x.Id));
     if (!response.EntityChanges.MoreRecords)
     {
         // Store token for later query
         token = response.EntityChanges.DataToken;
         break;

     }
     // Increment the page number to retrieve the next page.
     request.PageInfo.PageNumber++;
     // Set the paging cookie to the paging cookie returned from current results.
     request.PageInfo.PagingCookie = response.EntityChanges.PagingCookie;
 }

// </snippetchangetrackingsample1>