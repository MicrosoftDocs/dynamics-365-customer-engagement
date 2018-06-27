// <snippetlinqexamples48>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_math = from c in svcContext.ContactSet
                   where c.ContactId != _contactId2
                   && c.Address1_Latitude != null && 
                   c.Address1_Longitude != null
                   select new
                   {
                    Round = Math.Round(c.Address1_Latitude.Value),
                    Floor = Math.Floor(c.Address1_Latitude.Value),
                    Ceiling = Math.Ceiling(c.Address1_Latitude.Value),
                    Abs = Math.Abs(c.Address1_Latitude.Value),
                   };
  foreach (var c in query_math)
  {
   System.Console.WriteLine(c.Round + " " + c.Floor + 
    " " + c.Ceiling + " " + c.Abs);
  }
 }

// </snippetlinqexamples48>