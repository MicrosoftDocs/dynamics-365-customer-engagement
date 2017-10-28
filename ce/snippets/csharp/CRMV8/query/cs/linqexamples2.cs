// <snippetlinqexamples2>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_where2 = from a in svcContext.AccountSet
                     where a.Name.Contains("Contoso")
                     where a.Address1_City == "Redmond"
                     select a;

  foreach (var a in query_where2)
  {
   System.Console.WriteLine(a.Name + " " + a.Address1_City);
  }
 }

// </snippetlinqexamples2>