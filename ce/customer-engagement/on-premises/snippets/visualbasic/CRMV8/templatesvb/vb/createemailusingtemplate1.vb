' <snippetcreateemailusingtemplate1>


 ' Use the InstantiateTemplate message to create an e-mail message using a template.
 Dim instTemplateReq As InstantiateTemplateRequest = New InstantiateTemplateRequest With { _
     .TemplateId = _templateId, .ObjectId = _accountId, .ObjectType = Account.EntityLogicalName}
 Dim instTemplateResp As InstantiateTemplateResponse = _
     CType(_serviceProxy.Execute(instTemplateReq), InstantiateTemplateResponse)

 ' Serialize the email message to XML, and save to a file.
 Dim serializer As New XmlSerializer(GetType(InstantiateTemplateResponse))
 Dim filename As String = "email-message.xml"
 Using writer As New StreamWriter(filename)
     serializer.Serialize(writer, instTemplateResp)
 End Using
 Console.WriteLine("Created e-mail using the template.")

' </snippetcreateemailusingtemplate1>