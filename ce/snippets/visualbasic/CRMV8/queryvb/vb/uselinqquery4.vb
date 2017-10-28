' <snippetuselinqquery4>


 ' Build a complex query with LINQ. 
 'This query includes multiple JOINs.
 'Note: Where statements are not working with the below multiple join query.
 '       Refer equivalent C# snippet for full complex query.
 'TODO: Fix issue to include where statements as shown in C# sample.
 Dim complexQuery = From c In svcContext.CreateQuery(Of Contact)() _
                    Join a In svcContext.CreateQuery(Of Account)() _
                         On c.ContactId Equals a.PrimaryContactId.Id _
                     Join l In svcContext.CreateQuery(Of Lead)() _
                         On a.OriginatingLeadId.Id Equals l.LeadId _
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
                               },
                               Key .Lead =
                               New Lead With
                               {
                                   .LeadId = l.LeadId
                               }
                           }
 Console.WriteLine("Join account, contact and lead")
 Console.WriteLine("List all records matching specified parameters")
 Console.WriteLine("==============================================")
 For Each record In complexQuery
     Console.WriteLine("Lead ID: {0}", record.Lead.LeadId)
     Console.WriteLine("Contact Name: {0} {1}",
                       record.Contact.FirstName,
                       record.Contact.LastName)
     Console.WriteLine("Account Phone: {0}",
                       record.Account.Address1_Telephone1)
 Next record
 Console.WriteLine("<End of Listing>")
 Console.WriteLine()

' </snippetuselinqquery4>