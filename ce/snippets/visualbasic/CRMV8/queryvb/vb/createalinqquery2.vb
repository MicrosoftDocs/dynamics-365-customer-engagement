' <snippetcreatealinqquery2>


 Dim queryAccounts = From a In svcContext.AccountSet _
                                    Join owner In svcContext.SystemUserSet _
                                    On a.OwnerId.Id Equals owner.SystemUserId _
                                    Where owner.LastName IsNot "Cannon" _
                                    Select New Account With _
                                           {
                                               .Name = a.Name, _
                                               .Address1_City = a.Address1_City _
                                           }
 Console.WriteLine("Accounts not owned by user w/ last name 'Cannon'")
 Console.WriteLine("================================================")
 For Each a In queryAccounts
  Console.WriteLine(a.Name &amp; " " &amp; a.Address1_County)
 Next a

' </snippetcreatealinqquery2>