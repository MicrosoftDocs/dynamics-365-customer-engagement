' <snippetlabelqueryexpression2>


  Protected Function RetrieveUserUILanguageCode(ByVal userId As Guid) As Integer
   Dim userSettingsQuery As New QueryExpression("usersettings")
   userSettingsQuery.ColumnSet.AddColumns("uilanguageid", "systemuserid")
   userSettingsQuery.Criteria.AddCondition("systemuserid", ConditionOperator.Equal, userId)
   Dim userSettings As EntityCollection = _service.RetrieveMultiple(userSettingsQuery)
   If userSettings.Entities.Count > 0 Then
	Return CInt(Fix(userSettings.Entities(0)("uilanguageid")))
   End If
   Return 0
  End Function

' </snippetlabelqueryexpression2>