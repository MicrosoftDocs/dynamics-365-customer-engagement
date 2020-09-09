' <snippetuselinqwithdotnetdataservicesde4>


 Dim query = From c In orgContext.CreateQuery("contact") _
             Join a In orgContext.CreateQuery("account") _
             On c("contactid") Equals a("primarycontactid") _
             Where CType(c("lastname"), String).Equals("Wilcox") _
             OrElse CType(c("lastname"), String).Equals("Andrews") _
             Where (CType(a("address1_telephone1"), String)) _
             .Contains("(206)") OrElse _
             (CType(a("address1_telephone1"),
              String)).Contains("(425)") _
             Select New With
                    {
                        Key .Contact = New With
                                       {Key .FirstName = c("firstname"),
                                        Key .LastName = c("lastname")},
                         Key .Account = New With
                                        {Key .Address1_Telephone1 _
                                        = a("address1_telephone1")}}

 Console.WriteLine("Join account and contact")
 Console.WriteLine("List all records matching specified parameters")
 Console.WriteLine("Contact name: Wilcox or Andrews")
 Console.WriteLine("Account area code: 206 or 425")
 Console.WriteLine("==============================================")
 For Each record In query
  Console.WriteLine("Contact Name: {0} {1}", record.Contact.FirstName, record.Contact.LastName)
  Console.WriteLine("Account Phone: {0}", record.Account.Address1_Telephone1)
 Next record

' </snippetuselinqwithdotnetdataservicesde4>