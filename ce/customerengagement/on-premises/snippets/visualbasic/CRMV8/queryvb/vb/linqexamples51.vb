' <snippetlinqexamples51>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_string = From c In svcContext.ContactSet _
                     Where c.ContactId.Value.Equals(_contactId2) _
                     Select New With
                            {Key .IndexOf = c.FirstName.IndexOf("contact"),
                             Key .Insert = c.FirstName.Insert(1, "Insert"),
                             Key .Remove = c.FirstName.Remove(1, 1),
                             Key .Substring = c.FirstName.Substring(1, 1),
                             Key .ToUpper = c.FirstName.ToUpper(),
                             Key .ToLower = c.FirstName.ToLower(),
                             Key .TrimStart = c.FirstName.TrimStart(),
                             Key .TrimEnd = c.FirstName.TrimEnd()}

  For Each c In query_string
   Console.WriteLine(c.IndexOf &amp; vbLf &amp; c.Insert &amp; vbLf _
                     &amp; c.Remove &amp; vbLf &amp; c.Substring &amp; vbLf _
                     &amp; c.ToUpper &amp; vbLf &amp; c.ToLower &amp; vbLf _
                     &amp; c.TrimStart &amp; " " &amp; c.TrimEnd)
  Next c
 End Using

' </snippetlinqexamples51>