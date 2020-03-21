// <snippetcreatealinqquery3>


 int accountsWithCounty = (from a in svcContext.AccountSet
                           where (a.Address1_County != null)
                           select new Account
                           {
                            Name = a.Name,
                            Address1_City = a.Address1_City
                           }).ToArray().Count();
 System.Console.Write("Number of accounts with a county specified: ");
 System.Console.WriteLine(accountsWithCounty);

// </snippetcreatealinqquery3>