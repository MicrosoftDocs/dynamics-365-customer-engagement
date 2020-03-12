' <snippetretrieverecordsfromanintersecttable2>


 '					#Region "Retrieve records from an intersect table via Fetch"

 ' Setup Fetch XML.
 Dim linkFetch As New StringBuilder()
 linkFetch.Append("<fetch version=""1.0"" " _
                  &amp; "output-format=""xml-platform"" " _
                  &amp; "mapping=""logical"" distinct=""true"">")
 linkFetch.Append("<entity name=""role"">")
 linkFetch.Append("<attribute name=""name""/>")
 linkFetch.Append("<link-entity name=""systemuserroles"" " _
                  &amp; "from=""roleid"" to=""roleid"" " _
                  &amp; "visible=""false"" intersect=""true"">")
 linkFetch.Append("<filter type=""and"">")
 linkFetch.Append("<condition attribute=""systemuserid"" " _
                  &amp; "operator=""eq"" value=""" _
                  &amp; _userId.ToString() &amp; """/>")
 linkFetch.Append("</filter>")
 linkFetch.Append("</link-entity>")
 linkFetch.Append("</entity>")
 linkFetch.Append("</fetch>")

 ' Build fetch request and obtain results.
 Dim efr As New RetrieveMultipleRequest() With
     {
         .Query = New FetchExpression(linkFetch.ToString())
     }
 Dim entityResults As EntityCollection =
     (CType(_serviceProxy.Execute(efr), 
      RetrieveMultipleResponse)).EntityCollection

 ' Display results.
 For Each e In entityResults.Entities
     Console.WriteLine("Fetch Retrieved: {0}", e.Attributes("name"))
 Next e

 '					#End Region

' </snippetretrieverecordsfromanintersecttable2>