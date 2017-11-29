// <snippetlabelqueryexpression3>



 //A label query expression to limit the labels returned to only those for the user's preferred language
 LabelQueryExpression labelQuery = new LabelQueryExpression();
 labelQuery.FilterLanguages.Add(_languageCode);

// </snippetlabelqueryexpression3>