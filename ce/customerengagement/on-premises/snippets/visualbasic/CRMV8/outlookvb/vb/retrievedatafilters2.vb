' <snippetretrievedatafilters2>



 ' Call InstantiateFiltersRequest
 Console.WriteLine("Retrieving user's ID and creating the template collection")
 Dim whoAmI As New WhoAmIRequest()
 Dim id As Guid = (CType(_serviceProxy.Execute(whoAmI), WhoAmIResponse)).UserId
 Dim templates As New EntityReferenceCollection()
 templates.Add(New EntityReference(SavedQuery.EntityLogicalName, _offlineTemplate))

 Console.WriteLine("Activating the selected offline templates for this user")
 Dim request As InstantiateFiltersRequest = New InstantiateFiltersRequest With {.UserId = id, .TemplateCollection = templates}
 Dim response As InstantiateFiltersResponse = CType(_serviceProxy.Execute(request), InstantiateFiltersResponse)
 Console.WriteLine()

' </snippetretrievedatafilters2>