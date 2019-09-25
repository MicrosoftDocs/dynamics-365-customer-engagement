' <snippetuselinqquery3>


 ' Filter multiple entities using LINQ.
 Dim query = From c In svcContext.CreateQuery(Of Contact)() _
             Join a In svcContext.CreateQuery(Of Account)() _
             On c.ContactId Equals a.PrimaryContactId.Id _
             Where c.LastName.Equals("Wilcox") _
                 OrElse c.LastName.Equals("Andrews") _
             Where a.Address1_Telephone1.Contains("(206)") _
                 OrElse a.Address1_Telephone1.Contains("(425)") _
             Select New With
                    {
                        Key .Contact =
                        New Contact With
                        {
                            .FirstName = c.FirstName,
                            .LastName = c.LastName
                        },
                        Key .Account =
                        New Account With
                        {
                            .Address1_Telephone1 =
                            a.Address1_Telephone1
                        }
                     }

 Console.WriteLine("Join account and contact")
 Console.WriteLine("List all records matching specified parameters")
 Console.WriteLine("Contact name: Wilcox or Andrews")
 Console.WriteLine("Account area code: 206 or 425")
 Console.WriteLine("==============================================")
 For Each record In query
     Console.WriteLine("Contact Name: {0} {1}",
                       record.Contact.FirstName,
                       record.Contact.LastName)
     Console.WriteLine("Account Phone: {0}",
                       record.Account.Address1_Telephone1)
 Next record
 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetuselinqquery3>