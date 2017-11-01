// <snippetretrieverecordwall>


 private void DisplayRecordWall(Lead lead)
 {
     // Display the first page of the record wall.
     var retrieveRecordWallReq = new RetrieveRecordWallRequest
     {
         Entity = lead.ToEntityReference(),
         CommentsPerPost = 2,
         PageSize = 10,
         PageNumber = 1
     };

     var retrieveRecordWallRes =
         (RetrieveRecordWallResponse)_serviceProxy.Execute(retrieveRecordWallReq);

     Console.WriteLine("\r\n  Posts for lead {0}:", lead.FullName);
     foreach (Post post in retrieveRecordWallRes.EntityCollection.Entities)
     {
         DisplayPost(post);
     }
 }

// </snippetretrieverecordwall>