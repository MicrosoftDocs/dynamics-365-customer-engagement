// <snippetentityimages5>


 QueryExpression qe = new QueryExpression("systemform");
 qe.Criteria.AddCondition("type", ConditionOperator.Equal, 2); //main form
 qe.Criteria.AddCondition("objecttypecode", ConditionOperator.Equal, _customEntityName.ToLower()); 
 qe.ColumnSet.AddColumn("formxml");

 SystemForm ImageAttributeDemoMainForm = (SystemForm)_serviceProxy.RetrieveMultiple(qe).Entities[0];

 XDocument ImageAttributeDemoMainFormXml = XDocument.Parse(ImageAttributeDemoMainForm.FormXml);
 //Set the showImage attribute so the entity image will be displayed
 ImageAttributeDemoMainFormXml.Root.SetAttributeValue("showImage", true);

 //Updating the entity form definition
 ImageAttributeDemoMainForm.FormXml = ImageAttributeDemoMainFormXml.ToString();

 _serviceProxy.Update(ImageAttributeDemoMainForm);

// </snippetentityimages5>