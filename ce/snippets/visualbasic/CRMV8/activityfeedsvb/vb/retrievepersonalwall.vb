' <snippetretrievepersonalwall>



 Private Sub DisplayPersonalWallPage(ByVal pageNumber As Integer)
     ' Retrieve the page of posts.  We'll only retrieve 5 at a time so that
     ' we will have more than one page.
     Dim pageSize = 5

     Dim personalWallPageReq = New RetrievePersonalWallRequest With
                               {
                                   .CommentsPerPost = 2,
                                   .PageNumber = pageNumber,
                                   .PageSize = pageSize
                               }
     Dim personalWallPageRes = CType(_serviceProxy.Execute(personalWallPageReq), 
         RetrievePersonalWallResponse)

     Console.WriteLine(vbCrLf &amp; "  Personal Wall Page {0} Posts:", pageNumber)
     For Each post As Post In personalWallPageRes.EntityCollection.Entities
         DisplayPost(post)
     Next post
 End Sub

' </snippetretrievepersonalwall>