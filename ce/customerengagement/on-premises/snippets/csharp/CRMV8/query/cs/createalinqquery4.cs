// <snippetcreatealinqquery4>


 int statesWithAccounts = (from a in svcContext.AccountSet
                           where (a.Address1_StateOrProvince != null)
                           select a.Address1_StateOrProvince)
                           .Distinct().ToArray().Count();
 System.Console.Write("Number of unique states that contain accounts: ");
 System.Console.WriteLine(statesWithAccounts);

// </snippetcreatealinqquery4>