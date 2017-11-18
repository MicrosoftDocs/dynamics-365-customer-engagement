// <snippetretrievepersonalwall>


 private void DisplayPersonalWallPage(int pageNumber)
 {
     // Retrieve the page of posts.  We'll only retrieve 5 at a time so that
     // we will have more than one page.
     var pageSize = 5;

     var personalWallPageReq = new RetrievePersonalWallRequest
     {
         CommentsPerPost = 2,
         PageNumber = pageNumber,
         PageSize = pageSize
     };
     var personalWallPageRes =
         (RetrievePersonalWallResponse)_serviceProxy.Execute(personalWallPageReq);

     Console.WriteLine("\r\n  Personal Wall Page {0} Posts:", pageNumber);
     foreach (Post post in personalWallPageRes.EntityCollection.Entities)
     {
         DisplayPost(post);
     }
 }

// </snippetretrievepersonalwall>