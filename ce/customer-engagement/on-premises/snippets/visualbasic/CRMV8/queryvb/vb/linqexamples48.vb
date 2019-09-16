' <snippetlinqexamples48>


 Using svcContext As New ServiceContext(_serviceProxy)
  Dim query_math = From c In svcContext.ContactSet _
                   Where Not c.ContactId.Value.Equals(_contactId2) _
                   AndAlso c.Address1_Latitude IsNot Nothing _
                   AndAlso c.Address1_Longitude IsNot Nothing _
                   Select New With
                          {Key .Round =
                              Math.Round(c.Address1_Latitude.Value),
                           Key .Floor =
                              Math.Floor(c.Address1_Latitude.Value),
                           Key .Ceiling =
                              Math.Ceiling(c.Address1_Latitude.Value),
                           Key .Abs =
                              Math.Abs(c.Address1_Latitude.Value)}
  For Each c In query_math
   Console.WriteLine(c.Round &amp; " " &amp; c.Floor &amp; " " _
                     &amp; c.Ceiling &amp; " " &amp; c.Abs)
  Next c
 End Using

' </snippetlinqexamples48>