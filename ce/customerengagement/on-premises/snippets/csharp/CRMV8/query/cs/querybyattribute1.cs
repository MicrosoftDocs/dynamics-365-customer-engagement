// <snippetquerybyattribute1>


 //  Create query using QueryByAttribute.
 QueryByAttribute querybyattribute = new QueryByAttribute("account");
 querybyattribute.ColumnSet = new ColumnSet("name", "address1_city", "emailaddress1");

 //  Attribute to query.
 querybyattribute.Attributes.AddRange("address1_city");

 //  Value of queried attribute to return.
 querybyattribute.Values.AddRange("Redmond");

 //  Query passed to service proxy.
 EntityCollection retrieved = _service.RetrieveMultiple(querybyattribute);

 System.Console.WriteLine("Query Using QueryByAttribute");
 System.Console.WriteLine("===============================");

 //  Iterate through returned collection.
 foreach (var c in retrieved.Entities)
 {
     System.Console.WriteLine("Name: " + c.Attributes["name"]);
     
     if( c.Attributes.Contains("address1_city") )
         System.Console.WriteLine("Address: " + c.Attributes["address1_city"]);

     if( c.Attributes.Contains("emailaddress1") )
         System.Console.WriteLine("E-mail: " + c.Attributes["emailaddress1"]);
 }
 System.Console.WriteLine("===============================");

// </snippetquerybyattribute1>