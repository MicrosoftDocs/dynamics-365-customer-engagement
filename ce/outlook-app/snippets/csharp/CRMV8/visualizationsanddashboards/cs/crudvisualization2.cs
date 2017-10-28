// <snippetcrudvisualization2>


 // Create the visualization entity instance.
 SavedQueryVisualization newOrgOwnedVisualization = new SavedQueryVisualization
 {
     Name = "Sample Visualization",
     Description = "Sample organization-owned visualization.",
     PresentationDescription = presentationXml,
     DataDescription = dataXml,
     PrimaryEntityTypeCode = Opportunity.EntityLogicalName,
     IsDefault = false
 };
 _orgOwnedVisualizationId = _serviceProxy.Create(newOrgOwnedVisualization);

// </snippetcrudvisualization2>