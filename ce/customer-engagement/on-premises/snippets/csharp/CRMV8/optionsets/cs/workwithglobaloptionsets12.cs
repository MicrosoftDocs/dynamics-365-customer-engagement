// <snippetworkwithglobaloptionsets12>


   // Create the request to see which components have a dependency on the
   // global option set.
   RetrieveDependentComponentsRequest dependencyRequest =
       new RetrieveDependentComponentsRequest
       {
           ObjectId = _optionSetId,
           ComponentType = (int)componenttype.OptionSet
       };

   RetrieveDependentComponentsResponse dependencyResponse =
       (RetrieveDependentComponentsResponse)_serviceProxy.Execute(
       dependencyRequest);

   // Here you would check the dependencyResponse.EntityCollection property
   // and act as appropriate. However, we know there is exactly one 
   // dependency so this example deals with it directly and deletes 
   // the previously created attribute.
   DeleteAttributeRequest deleteAttributeRequest =
       new DeleteAttributeRequest
   {
       EntityLogicalName = Contact.EntityLogicalName,
       LogicalName = "sample_examplepicklist"
   };

   _serviceProxy.Execute(deleteAttributeRequest);
 
   Console.WriteLine("Referring attribute deleted.");
     
   // Finally, delete the global option set. Attempting this before deleting
   // the picklist above will result in an exception being thrown.
   DeleteOptionSetRequest deleteRequest = new DeleteOptionSetRequest
   {
       Name = _globalOptionSetName
   };

   _serviceProxy.Execute(deleteRequest);

// </snippetworkwithglobaloptionsets12>