' <snippetcopydynamiclisttostatic>



 ' Copy the dynamic list to a static list.
 Dim copyRequest As New CopyDynamicListToStaticRequest() With
     {
         .ListId = _dynamicListId
     }
 Dim copyResponse As CopyDynamicListToStaticResponse =
     CType(_serviceProxy.Execute(copyRequest), 
         CopyDynamicListToStaticResponse)
 _staticListId = copyResponse.StaticListId

 Console.WriteLine("Copied dynamic list to a static list.")

' </snippetcopydynamiclisttostatic>