// <snippetlinqexamples51>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_string = from c in svcContext.ContactSet
                     where c.ContactId == _contactId2
                     select new
                     {
                      IndexOf = c.FirstName.IndexOf("contact"),
                      Insert = c.FirstName.Insert(1, "Insert"),
                      Remove = c.FirstName.Remove(1, 1),
                      Substring = c.FirstName.Substring(1, 1),
                      ToUpper = c.FirstName.ToUpper(),
                      ToLower = c.FirstName.ToLower(),
                      TrimStart = c.FirstName.TrimStart(),
                      TrimEnd = c.FirstName.TrimEnd(),
                     };

  foreach (var c in query_string)
  {
   System.Console.WriteLine(c.IndexOf + "\n" + c.Insert + "\n" + 
    c.Remove + "\n" + c.Substring + "\n"
                            + c.ToUpper + "\n" + c.ToLower + 
                            "\n" + c.TrimStart + " " + c.TrimEnd);
  }
 }

// </snippetlinqexamples51>