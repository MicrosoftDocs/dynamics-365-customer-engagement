' <snippetlinqexamples45>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_value = From c In svcContext.ContactSet _
                    Where Not c.ContactId.Value.Equals(_contactId2) _
                    Select New With
                           {Key .ContactId = If(
                                   c.ContactId IsNot Nothing,
                                   c.ContactId.Value,
                                   Guid.Empty),
                            Key .NumberOfChildren = If(
                                c.NumberOfChildren IsNot Nothing,
                                c.NumberOfChildren.Value, Nothing),
                            Key .CreditOnHold = If(
                                c.CreditOnHold IsNot Nothing,
                                c.CreditOnHold.Value,
                                Nothing),
                            Key .Anniversary = If(
                                c.Anniversary IsNot Nothing,
                                c.Anniversary.Value,
                                Nothing)}

  For Each c In query_value
   Console.WriteLine(c.ContactId.ToString() &amp; " " _
                     &amp; c.NumberOfChildren &amp; " " _
                     &amp; c.CreditOnHold &amp; " " &amp; c.Anniversary)
  Next c
 End Using

' </snippetlinqexamples45>