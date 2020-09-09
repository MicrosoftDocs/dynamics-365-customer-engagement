// <snippetfetchpagingwithcookie1>


 // Define the fetch attributes.
 // Set the number of records per page to retrieve.
 int fetchCount = 3;
 // Initialize the page number.
 int pageNumber = 1;
 // Initialize the number of records.
 int recordCount = 0;
 // Specify the current paging cookie. For retrieving the first page, 
 // pagingCookie should be null.
 string pagingCookie = null;

 // Create the FetchXml string for retrieving all child accounts to a parent account.
 // This fetch query is using 1 placeholder to specify the parent account id 
 // for filtering out required accounts. Filter query is optional.
 // Fetch query also includes optional order criteria that, in this case, is used 
 // to order the results in ascending order on the name data column.
 string fetchXml = string.Format(@"<fetch version='1.0' 
                                 mapping='logical' 
                                 output-format='xml-platform'>
                                 <entity name='account'>
                                     <attribute name='name' />
                                     <attribute name='emailaddress1' />
                                     <order attribute='name' descending='false'/>
                                     <filter type='and'>
                             <condition attribute='parentaccountid' 
                                             operator='eq' value='{0}' uiname='' uitype='' />
                                     </filter>
                                 </entity>
                             </fetch>",
                                 _parentAccountId);

 Console.WriteLine("Retrieving data in pages\n"); 
 Console.WriteLine("#\tAccount Name\t\t\tEmail Address");

 while (true)
 {
     // Build fetchXml string with the placeholders.
     string xml = CreateXml(fetchXml, pagingCookie, pageNumber, fetchCount);

     // Excute the fetch query and get the xml result.
     RetrieveMultipleRequest fetchRequest1 = new RetrieveMultipleRequest
     {
         Query = new FetchExpression(xml)
     };

     EntityCollection returnCollection = ((RetrieveMultipleResponse)_service.Execute(fetchRequest1)).EntityCollection;
     
     foreach (var c in returnCollection.Entities)
     {
         System.Console.WriteLine("{0}.\t{1}\t\t{2}", ++recordCount, c.Attributes["name"], c.Attributes["emailaddress1"] );
     }                        
     
     // Check for morerecords, if it returns 1.
     if (returnCollection.MoreRecords)
     {
         Console.WriteLine("\n****************\nPage number {0}\n****************", pageNumber);
         Console.WriteLine("#\tAccount Name\t\t\tEmail Address");
         
         // Increment the page number to retrieve the next page.
         pageNumber++;

         // Set the paging cookie to the paging cookie returned from current results.                            
         pagingCookie = returnCollection.PagingCookie;
     }
     else
     {
         // If no more records in the result nodes, exit the loop.
         break;
     }
 }

// </snippetfetchpagingwithcookie1>