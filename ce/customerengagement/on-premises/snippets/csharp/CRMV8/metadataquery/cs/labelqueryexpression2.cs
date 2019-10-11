// <snippetlabelqueryexpression2>


 protected int RetrieveUserUILanguageCode(Guid userId)
 {
  QueryExpression userSettingsQuery = new QueryExpression("usersettings");
  userSettingsQuery.ColumnSet.AddColumns("uilanguageid", "systemuserid");
  userSettingsQuery.Criteria.AddCondition("systemuserid", ConditionOperator.Equal, userId);
  EntityCollection userSettings = _service.RetrieveMultiple(userSettingsQuery);
  if (userSettings.Entities.Count > 0)
  {
   return (int)userSettings.Entities[0]["uilanguageid"];
  }
  return 0;
 }

// </snippetlabelqueryexpression2>