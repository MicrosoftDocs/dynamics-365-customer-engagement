' <snippetretrievemultipleconditionoperatorslinq1>


 Dim contacts = ( _
     From c In orgContext.CreateQuery(Of Contact)() _
     Join a In orgContext.CreateQuery(Of Account)() _
     On c.ParentCustomerId.Id Equals a.AccountId _
     Where (a.Name.Equals("Litware, Inc.")) _
     Where (c.Address1_StateOrProvince.Equals("WA") _
            AndAlso (c.Address1_Telephone1.StartsWith("(206)") _
             OrElse c.Address1_Telephone1.StartsWith("(425)")) _
         AndAlso (c.Address1_City.Equals("Redmond") _
                  OrElse c.Address1_City.Equals("Bellevue") _
                  OrElse c.Address1_City.Equals("Kirkland") _
                  OrElse c.Address1_City.Equals("Seattle")) _
              AndAlso (c.EMailAddress1 IsNot Nothing _
                       AndAlso c.EMailAddress1 IsNot "")) _
     Select New Contact With
            {
                .ContactId = c.ContactId,
                .FirstName = c.FirstName,
                .LastName = c.LastName,
                .Address1_Telephone1 = c.Address1_Telephone1
            })

 ' Display the results.
 Console.WriteLine("List all contacts matching specified parameters")
 Console.WriteLine("===============================================")
 For Each contact As Contact In contacts
     Console.WriteLine("Contact ID: {0}", contact.Id)
     Console.WriteLine("Contact Name: {0}", contact.FullName)
     Console.WriteLine("Contact Phone: {0}",
                       contact.Address1_Telephone1)
 Next contact
 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetretrievemultipleconditionoperatorslinq1>