' <snippetlinqexamples39>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_orderbypicklist = From c In svcContext.ContactSet _
                              Where c.LastName IsNot "Parker" _
                              AndAlso c.AccountRoleCode IsNot Nothing _
                              Order By c.AccountRoleCode, c.FirstName _
                              Select New With
                                     {Key .AccountRole =
                                         c.FormattedValues("accountrolecode"),
                                      Key c.FirstName, Key c.LastName}
  For Each c In query_orderbypicklist
   Console.WriteLine(c.AccountRole &amp; " " &amp; c.FirstName _
                     &amp; " " &amp; c.LastName)
  Next c
 End Using

' </snippetlinqexamples39>