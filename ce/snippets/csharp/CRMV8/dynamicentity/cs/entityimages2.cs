// <snippetentityimages2>


 //Use a 144x144 pixel image
 Entity imageEntity1 = new Entity(_customEntityName.ToLower());
 imageEntity1["sample_name"] = "144x144.png";
 imageEntity1["entityimage"] = File.ReadAllBytes("Images\\144x144.png");
 Guid imageEntity1Id = _serviceProxy.Create(imageEntity1);
 ShowEntityFormInBrowser(promptforDelete, "144x144.png", imageEntity1Id);
 
 //Use a 144x400 pixel image
 Entity imageEntity2 = new Entity(_customEntityName.ToLower());
 imageEntity2["sample_name"] = "144x400.png";
 imageEntity2["entityimage"] = File.ReadAllBytes("Images\\144x400.png");
 Guid imageEntity2Id = _serviceProxy.Create(imageEntity2);     
 ShowEntityFormInBrowser(promptforDelete, "144x400.png", imageEntity2Id);
 
 //Use a 400x144 pixel image
 Entity imageEntity3 = new Entity(_customEntityName.ToLower());
 imageEntity3["sample_name"] = "400x144.png";
 imageEntity3["entityimage"] = File.ReadAllBytes("Images\\400x144.png");
 Guid imageEntity3Id = _serviceProxy.Create(imageEntity3);
 ShowEntityFormInBrowser(promptforDelete, "400x144.png", imageEntity3Id);

 //Use a 400x500 pixel image
 Entity imageEntity4 = new Entity(_customEntityName.ToLower());
 imageEntity4["sample_name"] = "400x500.png";
 imageEntity4["entityimage"] = File.ReadAllBytes("Images\\400x500.png");
 Guid imageEntity4Id = _serviceProxy.Create(imageEntity4);
 ShowEntityFormInBrowser(promptforDelete, "400x500.png", imageEntity4Id);

 //Use a 60x80 pixel image
 Entity imageEntity5 = new Entity(_customEntityName.ToLower());
 imageEntity5["sample_name"] = "60x80.png";
 imageEntity5["entityimage"] = File.ReadAllBytes("Images\\60x80.png");
 Guid imageEntity5Id = _serviceProxy.Create(imageEntity5);
 ShowEntityFormInBrowser(promptforDelete, "60x80.png", imageEntity5Id);

// </snippetentityimages2>