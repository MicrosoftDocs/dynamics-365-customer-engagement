' <snippetlabelqueryexpression1>


 _userId = (CType(_service.Execute(New WhoAmIRequest()), WhoAmIResponse)).UserId
 _languageCode = RetrieveUserUILanguageCode(_userId)

' </snippetlabelqueryexpression1>