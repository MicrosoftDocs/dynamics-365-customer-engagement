' <snippetcruddashboards2>


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

' </snippetcruddashboards2>