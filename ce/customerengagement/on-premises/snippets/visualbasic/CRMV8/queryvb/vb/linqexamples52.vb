' <snippetlinqexamples52>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_twowhere = From a In svcContext.AccountSet _
                       Join c In svcContext.ContactSet _
                       On a.PrimaryContactId.Id Equals c.ContactId _
                       Where c.LastName.Equals("Smith") _
                       AndAlso c.CreditOnHold IsNot Nothing _
                       Where a.Name.Equals("Contoso Ltd") _
                       Order By a.Name _
                       Select a
  For Each c In query_twowhere
   Console.WriteLine(c.AccountId.ToString() &amp; " " &amp; c.Name)
  Next c
 End Using

' </snippetlinqexamples52>