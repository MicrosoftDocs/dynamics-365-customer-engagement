' <snippetworkwithglobaloptionsets12>


 ' Create the request to see which components have a dependency on the
 ' global option set.
 Dim dependencyRequest As RetrieveDependentComponentsRequest =
  New RetrieveDependentComponentsRequest With {
   .ObjectId = _optionSetId,
   .ComponentType = componenttype.OptionSet
  }

 Dim dependencyResponse As RetrieveDependentComponentsResponse =
  CType(_serviceProxy.Execute(dependencyRequest), RetrieveDependentComponentsResponse)

 ' Here you would check the dependencyResponse.EntityCollection property
 ' and act as appropriate. However, we know there is exactly one 
 ' dependency so this example deals with it directly and deletes 
 ' the previously created attribute.
 Dim deleteAttributeRequest As DeleteAttributeRequest =
  New DeleteAttributeRequest With {
   .EntityLogicalName = Contact.EntityLogicalName,
   .LogicalName = "sample_examplepicklist"
  }

 _serviceProxy.Execute(deleteAttributeRequest)

 Console.WriteLine("Referring attribute deleted.")
 '#End Region ' How to delete attribute

 '#Region "How to delete global option set"

 ' Finally, delete the global option set. Attempting this before deleting
 ' the picklist above will result in an exception being thrown.
 Dim deleteRequest As DeleteOptionSetRequest =
  New DeleteOptionSetRequest With {
   .Name = _globalOptionSetName
  }

 _serviceProxy.Execute(deleteRequest)

' </snippetworkwithglobaloptionsets12>