' <snippetuselinqwithdotnetdataservicesde5>


 Dim complexQuery = From c In orgContext.CreateQuery("contact") _
                    Join a In orgContext.CreateQuery("account") _
                    On c("contactid") Equals a("primarycontactid") _
                    Join l In orgContext.CreateQuery("lead") _
                    On a("originatingleadid") Equals l("leadid") _
                    Select New With
                           {Key .Contact = New With
                                           {Key .FirstName = c("firstname"),
                                            Key .LastName = c("lastname")},
                            Key .Account = New With
                                           {Key .Address1_Telephone1 _
                                           = a("address1_telephone1")},
                            Key .Lead = New With
                                        {Key .LeadId = l("leadid")}}

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

' </snippetuselinqwithdotnetdataservicesde5>