' <snippetcreatealinqquery1>


 Dim accounts = From a In svcContext.AccountSet _
                               Select New Account With _
                                      { _
                                          .Name = a.Name, _
                                          .Address1_County = a.Address1_County _
                                      }
 Console.WriteLine("List all accounts in CRM")
 Console.WriteLine("========================")
 For Each a In accounts
  Console.WriteLine(a.Name &amp; " " &amp; a.Address1_County)
 Next a

' </snippetcreatealinqquery1>