// <snippetlinqexamples45>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {

  var query_value = from c in svcContext.ContactSet
                    where c.ContactId != _contactId2
                    select new
                    {
                     ContactId = c.ContactId != null ?
                      c.ContactId.Value : Guid.Empty,
                     NumberOfChildren = c.NumberOfChildren != null ?
                      c.NumberOfChildren.Value : default(int),
                     CreditOnHold = c.CreditOnHold != null ?
                      c.CreditOnHold.Value : default(bool),
                     Anniversary = c.Anniversary != null ?
                      c.Anniversary.Value : default(DateTime)
                    };

  foreach (var c in query_value)
  {
   System.Console.WriteLine(c.ContactId + " " + c.NumberOfChildren + 
    " " + c.CreditOnHold + " " + c.Anniversary);
  }
 }

// </snippetlinqexamples45>