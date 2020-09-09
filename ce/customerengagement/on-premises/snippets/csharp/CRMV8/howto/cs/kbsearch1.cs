// <snippetkbsearch1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();
     
     // Create the query using FreeText operator
     QueryExpression userQuery = new QueryExpression
     {
         EntityName = KbArticle.EntityLogicalName,
         ColumnSet = new ColumnSet("title"),
         Criteria =
         {
             Conditions =
             {
                 new ConditionExpression
                     ("title", ConditionOperator.FreeText, "Rain or Thunder")
             }
         }                        
     };

     // Run the query as a query expression.
     EntityCollection entitiesFound =
         _serviceProxy.RetrieveMultiple(userQuery);

     // Show the results
     Console.WriteLine("Searching KB article with Title 'Rain' or 'Thunder'.");
     Console.WriteLine("-------------------------------------------------");
     if (entitiesFound.Entities.Count > 0)
     {
         foreach (Entity entityFound in entitiesFound.Entities)
         {
             Console.WriteLine("  Title: " + ((KbArticle)entityFound).Title +
                 ", Id: " + ((KbArticle)entityFound).Id.ToString());
         }
     }
     else
     {
         Console.WriteLine("There were no KB articles with that criteria.");
     }

     Console.WriteLine();

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetkbsearch1>