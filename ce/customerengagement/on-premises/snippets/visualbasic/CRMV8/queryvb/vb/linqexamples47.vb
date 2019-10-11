' <snippetlinqexamples47>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_getattrib = From c In svcContext.ContactSet _
                        Where Not c.GetAttributeValue(Of Guid)("contactid").Equals( _
                         _contactId1) _
                        Select New With
                               {Key .ContactId =
                                   c.GetAttributeValue(Of Guid?)("contactid"),
                                Key .NumberOfChildren =
                                c.GetAttributeValue(Of Integer?)("numberofchildren"),
                                Key .CreditOnHold =
                                c.GetAttributeValue(Of Boolean?)("creditonhold"),
                                Key .Anniversary =
                                c.GetAttributeValue(Of Date?)("anniversary")}

  For Each c In query_getattrib
   Console.WriteLine(c.ContactId.ToString() &amp; " " _
                     &amp; c.NumberOfChildren &amp; " " &amp; c.CreditOnHold _
                     &amp; " " &amp; c.Anniversary)
  Next c
 End Using

' </snippetlinqexamples47>