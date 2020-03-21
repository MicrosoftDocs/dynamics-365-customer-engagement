// <snippetlabelqueryexpression1>


 _userId = ((WhoAmIResponse)_service.Execute(new WhoAmIRequest())).UserId;
 _languageCode = RetrieveUserUILanguageCode(_userId);

// </snippetlabelqueryexpression1>