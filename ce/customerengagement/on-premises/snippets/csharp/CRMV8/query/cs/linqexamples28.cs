// <snippetlinqexamples28>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_andor1 = from c in svcContext.ContactSet
                     where ((c.Address1_City == "Redmond" ||
                     c.Address1_City == "Bellevue") &&
                     (c.CreditLimit.Value != null &&
                     c.CreditLimit.Value >= 200))
                     select c;

  foreach (var c in query_andor1)
  {
   System.Console.WriteLine(c.LastName + ", " + c.FirstName + " " +
    c.Address1_City + " " + c.CreditLimit.Value);
  }
 }

// </snippetlinqexamples28>