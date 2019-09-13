// <snippetuselinqwithdotnetdataservicesde5>


 var complexQuery = from c in orgContext.CreateQuery("contact")
                    join a in orgContext.CreateQuery("account")
                         on c["contactid"] equals a["primarycontactid"]
                    join l in orgContext.CreateQuery("lead")
                         on a["originatingleadid"] equals l["leadid"]
                    where (String)c["lastname"] == "Wilcox" ||
                         (String)c["lastname"] == "Andrews"
                    where ((String)a["address1_telephone1"]).Contains("(206)")
                        || ((String)a["address1_telephone1"]).Contains("(425)")
                    select new
                    {
                     Contact = new
                     {
                      FirstName = c["firstname"],
                      LastName = c["lastname"]
                     },
                     Account = new
                     {
                      Address1_Telephone1 = a["address1_telephone1"]
                     },
                     Lead = new
                     {
                      LeadId = l["leadid"]
                     }
                    };

 Console.WriteLine("Join account, contact and lead");
 Console.WriteLine("List all records matching specified parameters");
 Console.WriteLine("Contact name: Wilcox or Andrews");
 Console.WriteLine("Account area code: 206 or 425");
 Console.WriteLine("==============================================");
 foreach (var record in complexQuery)
 {
  Console.WriteLine("Lead ID: {0}",
      record.Lead.LeadId);
  Console.WriteLine("Contact Name: {0} {1}",
      record.Contact.FirstName, record.Contact.LastName);
  Console.WriteLine("Account Phone: {0}",
      record.Account.Address1_Telephone1);
 }

// </snippetuselinqwithdotnetdataservicesde5>