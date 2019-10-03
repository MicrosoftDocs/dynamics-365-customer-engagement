' <snippetcrudvisualization2>


 ' Create the visualization entity instance.
 Dim newOrgOwnedVisualization As SavedQueryVisualization =
  New SavedQueryVisualization With {
   .Name = "Sample Visualization",
   .Description = "Sample organization-owned visualization.",
   .PresentationDescription = presentationXml,
   .DataDescription = dataXml,
   .PrimaryEntityTypeCode = Opportunity.EntityLogicalName,
   .IsDefault = False
  }
 _orgOwnedVisualizationId = _serviceProxy.Create(newOrgOwnedVisualization)

' </snippetcrudvisualization2>