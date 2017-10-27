// <snippetcreateemailusingtemplate1>



 // Use the InstantiateTemplate message to create an e-mail message using a template.
 InstantiateTemplateRequest instTemplateReq = new InstantiateTemplateRequest
 {
     TemplateId = _templateId,
     ObjectId = _accountId,
     ObjectType = Account.EntityLogicalName
 };
 InstantiateTemplateResponse instTemplateResp = (InstantiateTemplateResponse)_serviceProxy.Execute(instTemplateReq);

 // Serialize the email message to XML, and save to a file.
 XmlSerializer serializer = new XmlSerializer(typeof(InstantiateTemplateResponse));
 string filename = "email-message.xml";
 using (StreamWriter writer = new StreamWriter(filename))
 {
     serializer.Serialize(writer, instTemplateResp);
 }
 Console.WriteLine("Created e-mail using the template.");

// </snippetcreateemailusingtemplate1>