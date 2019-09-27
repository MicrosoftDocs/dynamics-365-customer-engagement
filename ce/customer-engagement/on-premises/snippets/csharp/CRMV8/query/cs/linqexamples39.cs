// <snippetlinqexamples39>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_orderbypicklist = from c in svcContext.ContactSet
                              where c.LastName != "Parker" &&
                              c.AccountRoleCode != null
                              orderby c.AccountRoleCode, c.FirstName
                              select new
                              {
                               AccountRole = c.FormattedValues["accountrolecode"],
                               c.FirstName,
                               c.LastName
                              };
  foreach (var c in query_orderbypicklist)
  {
   System.Console.WriteLine(c.AccountRole + " " +
    c.FirstName + " " + c.LastName);
  }
 }

// </snippetlinqexamples39>