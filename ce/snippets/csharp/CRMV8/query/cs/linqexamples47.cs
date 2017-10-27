// <snippetlinqexamples47>


 using (ServiceContext svcContext = new ServiceContext(_serviceProxy))
 {
  var query_getattrib = from c in svcContext.ContactSet
                        where c.GetAttributeValue<Guid>("contactid") != _contactId1
                        select new
                        {
                         ContactId = c.GetAttributeValue<Guid?>("contactid"),
                         NumberOfChildren = c.GetAttributeValue<int?>("numberofchildren"),
                         CreditOnHold = c.GetAttributeValue<bool?>("creditonhold"),
                         Anniversary = c.GetAttributeValue<DateTime?>("anniversary"),
                        };

  foreach (var c in query_getattrib)
  {
   System.Console.WriteLine(c.ContactId + " " + c.NumberOfChildren + 
    " " + c.CreditOnHold + " " + c.Anniversary);
  }
 }

// </snippetlinqexamples47>