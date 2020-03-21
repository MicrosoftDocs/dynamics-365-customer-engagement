' <snippetretrieverecordwall>


 Private Sub DisplayRecordWall(ByVal lead As Lead)
     ' Display the first page of the record wall.
     Dim retrieveRecordWallReq = New RetrieveRecordWallRequest With
                                 {
                                     .Entity = lead.ToEntityReference(),
                                     .CommentsPerPost = 2,
                                     .PageSize = 10,
                                     .PageNumber = 1
                                 }

     Dim retrieveRecordWallRes = CType(_serviceProxy.Execute(retrieveRecordWallReq), 
         RetrieveRecordWallResponse)

     Console.WriteLine(vbCrLf &amp; "  Posts for lead {0}:", lead.FullName)
     For Each post As Post In retrieveRecordWallRes.EntityCollection.Entities
         DisplayPost(post)
     Next post
 End Sub

' </snippetretrieverecordwall>