// <snippetlinqexamples38>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_orderbylookup = from a in svcContext.AccountSet
                            where a.Address1_Name == "Contoso Pharmaceuticals"
                            orderby a.PrimaryContactId
                            select new
                            {
                             a.Name,
                             a.Address1_City
                            };
  foreach (var a in query_orderbylookup)
  {
   System.Console.WriteLine(a.Name + " " + a.Address1_City);
  }
 }

// </snippetlinqexamples38>