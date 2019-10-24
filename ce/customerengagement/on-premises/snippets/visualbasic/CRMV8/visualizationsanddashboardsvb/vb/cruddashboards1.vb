' <snippetcruddashboards1>



 'Grab the default public view for opportunities.
 Dim mySavedQuery As QueryExpression =
  New QueryExpression With {
   .ColumnSet = New ColumnSet("savedqueryid"),
   .EntityName = SavedQuery.EntityLogicalName
  }
 mySavedQuery.Criteria = New FilterExpression()
 mySavedQuery.Criteria.AddCondition("isdefault", ConditionOperator.Equal, {True})
 mySavedQuery.Criteria.AddCondition("querytype", ConditionOperator.Equal, {0})
 mySavedQuery.Criteria.AddCondition("returnedtypecode", ConditionOperator.Equal, {Opportunity.EntityTypeCode})

 'This query should return one and only one result.
 Dim defaultOpportunityQuery As SavedQuery = _serviceProxy.RetrieveMultiple(mySavedQuery).Entities.Select(Function(x) CType(x, SavedQuery)).FirstOrDefault()

 ' Retrieve visualizations out of the system. 
 ' This sample assumes that you have the "Top Opportunities"
 ' visualization that is installed with Microsoft Dynamics CRM.
 Dim visualizationQuery As QueryByAttribute =
  New QueryByAttribute With {
   .EntityName = SavedQueryVisualization.EntityLogicalName,
   .ColumnSet = New ColumnSet("savedqueryvisualizationid")
  }
 visualizationQuery.Attributes.Add("name")
 visualizationQuery.Values.Add("Top Opportunities")
 'If you do not have this visualization, you will need to change
 'this line.


 Dim visualization As SavedQueryVisualization =
  _serviceProxy.RetrieveMultiple(visualizationQuery).Entities.Select(Function(x) CType(x, SavedQueryVisualization)).FirstOrDefault()
 'This is the language code for U.S. English. If you are running this code
 'in a different locale, you will need to modify this value.
 Dim languageCode As Integer = 1033

 'We set up our dashboard and specify the FormXml. Refer to the
 'FormXml schema in the Microsoft Dynamics CRM SDK for more information.
 Dim dashboard As SystemForm =
  New SystemForm With {
   .Name = "Sample Dashboard",
   .Description = "Sample organization-owned dashboard.",
   .FormXml = String.Format("<form><tabs><tab name='Test Dashboard' verticallayout='true'>" &amp; _
                            "<labels><label description='Sample Dashboard' languagecode='{0}' />" &amp; _
                            "</labels><columns><column width='100%'><sections>" &amp; _
                            "<section name='Information Section' showlabel='false' showbar='false' columns='111'>" &amp; _
                            "<labels><label description='Information Section' languagecode='{0}' />" &amp; _
                            "</labels><rows><row><cell colspan='1' rowspan='10' showlabel='false'><labels>" &amp; _
                            "<label description='Top Opportunitiess - 1' languagecode='{0}' /></labels>" &amp; _
                            "<control id='TopOpportunities' classid='{{E7A81278-8635-4d9e-8D4D-59480B391C5B}}'>" &amp; _
                            "<parameters><ViewId>{1}</ViewId><IsUserView>false</IsUserView><RelationshipName />" &amp; _
                            "<TargetEntityType>opportunity</TargetEntityType><AutoExpand>Fixed</AutoExpand>" &amp; _
                            "<EnableQuickFind>false</EnableQuickFind><EnableViewPicker>false</EnableViewPicker>" &amp; _
                            "<EnableJumpBar>false</EnableJumpBar><ChartGridMode>Chart</ChartGridMode>" &amp; _
                            "<VisualizationId>{2}</VisualizationId><EnableChartPicker>false</EnableChartPicker>" &amp; _
                            "<RecordsPerPage>10</RecordsPerPage></parameters></control></cell>" &amp; _
                            "<cell colspan='1' rowspan='10' showlabel='false'><labels>" &amp; _
                            "<label description='Top Opportunities - 2' languagecode='{0}' /></labels>" &amp; _
                            "<control id='TopOpportunities2' classid='{{E7A81278-8635-4d9e-8D4D-59480B391C5B}}'>" &amp; _
                            "<parameters><ViewId>{1}</ViewId><IsUserView>false</IsUserView><RelationshipName />" &amp; _
                            "<TargetEntityType>opportunity</TargetEntityType><AutoExpand>Fixed</AutoExpand>" &amp; _
                            "<EnableQuickFind>false</EnableQuickFind><EnableViewPicker>false</EnableViewPicker>" &amp; _
                            "<EnableJumpBar>false</EnableJumpBar><ChartGridMode>Grid</ChartGridMode>" &amp; _
                            "<VisualizationId>{2}</VisualizationId><EnableChartPicker>false</EnableChartPicker>" &amp; _
                            "<RecordsPerPage>10</RecordsPerPage></parameters></control></cell></row><row /><row />" &amp; _
                            "<row /><row /><row /><row /><row /><row /><row /></rows></section></sections></column>" &amp; _
                            "</columns></tab></tabs></form>",
                            languageCode,
                            defaultOpportunityQuery.SavedQueryId.Value.ToString("B"),
                            visualization.SavedQueryVisualizationId.Value.ToString("B")),
   .IsDefault = False
  }
 _dashboardId = _serviceProxy.Create(dashboard)
 Console.WriteLine("Created {0}.", dashboard.Name)

 'Now we will retrieve the dashboard.
 Dim retrievedDashboard As SystemForm =
  CType(_serviceProxy.Retrieve(SystemForm.EntityLogicalName, _dashboardId, New ColumnSet(True)), SystemForm)
 Console.WriteLine("Retrieved the dashboard.")

 ' Update the retrieved dashboard. Enable the chart picker on the chart.                                       
 Dim xDocument As XDocument = xDocument.Parse(retrievedDashboard.FormXml)

 Dim chartPicker = ( _
     From control In xDocument.Descendants("control") _
     Where control.Attribute("id").Value = "TopOpportunities" _
     Select control.Descendants("EnableChartPicker").First()).First()
 chartPicker.Value = "true"

 'Now we place the updated Xml back into the dashboard, and update it.
 retrievedDashboard.FormXml = xDocument.ToString()
 _serviceProxy.Update(retrievedDashboard)

 ' Publish the dashboard changes to the solution. 
 ' This is only required for organization-owned dashboards.
 Dim updateRequest As PublishXmlRequest =
  New PublishXmlRequest With {
   .ParameterXml = "<dashboard>_dashboardId</dashboard>"
  }

 _serviceProxy.Execute(updateRequest)

 Console.WriteLine("Updated the dashboard.")

 DeleteRequiredRecords(promptForDelete)

' </snippetcruddashboards1>