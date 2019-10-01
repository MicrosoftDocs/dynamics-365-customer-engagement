// <snippetlinqexamples1>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_where1 = from a in svcContext.AccountSet
                     where a.Name.Contains("Contoso")
                     select a;
  foreach (var a in query_where1)
  {
   System.Console.WriteLine(a.Name + " " + a.Address1_City);
  }
 }

// </snippetlinqexamples1>