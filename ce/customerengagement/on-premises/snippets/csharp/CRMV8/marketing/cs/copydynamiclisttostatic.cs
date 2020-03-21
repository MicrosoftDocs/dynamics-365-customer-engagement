// <snippetcopydynamiclisttostatic>



 // Copy the dynamic list to a static list.
 CopyDynamicListToStaticRequest copyRequest = 
     new CopyDynamicListToStaticRequest()
     {
         ListId = _dynamicListId
     };
 CopyDynamicListToStaticResponse copyResponse =
     (CopyDynamicListToStaticResponse)_serviceProxy.Execute(copyRequest);
 _staticListId = copyResponse.StaticListId;

 Console.WriteLine("Copied dynamic list to a static list.");

// </snippetcopydynamiclisttostatic>