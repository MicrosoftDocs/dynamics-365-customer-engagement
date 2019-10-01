// <snippetcruddashboards2>


 //This is the language code for U.S. English. If you are running this code
 //in a different locale, you will need to modify this value.
 int languageCode = 1033;

 //We set up our dashboard and specify the FormXml. Refer to the
 //FormXml schema in the Microsoft Dynamics CRM SDK for more information.
 SystemForm dashboard = new SystemForm
 {
     Name = "Sample Dashboard",
     Description = "Sample organization-owned dashboard.",
     FormXml = String.Format(@"<form>
             <tabs>
                 <tab name='Test Dashboard' verticallayout='true'>
                     <labels>
                         <label description='Sample Dashboard' languagecode='{0}' />
                     </labels>
                     <columns>
                         <column width='100%'>
                             <sections>
                                 <section name='Information Section'
                                     showlabel='false' showbar='false'
                                     columns='111'>
                                     <labels>
                                         <label description='Information Section'
                                             languagecode='{0}' />
                                     </labels>
                                     <rows>
                                         <row>
                                             <cell colspan='1' rowspan='10' 
                                                 showlabel='false'>
                                                 <labels>
                                                     <label description='Top Opportunitiess - 1'
                                                     languagecode='{0}' />
                                                 </labels>
                                                 <control id='TopOpportunities'
                                                     classid='{{E7A81278-8635-4d9e-8D4D-59480B391C5B}}'>
                                                     <parameters>
                                                         <ViewId>{1}</ViewId>
                                                         <IsUserView>false</IsUserView>
                                                         <RelationshipName />
                                                         <TargetEntityType>opportunity</TargetEntityType>
                                                         <AutoExpand>Fixed</AutoExpand>
                                                         <EnableQuickFind>false</EnableQuickFind>
                                                         <EnableViewPicker>false</EnableViewPicker>
                                                         <EnableJumpBar>false</EnableJumpBar>
                                                         <ChartGridMode>Chart</ChartGridMode>
                                                         <VisualizationId>{2}</VisualizationId>
                                                         <EnableChartPicker>false</EnableChartPicker>
                                                         <RecordsPerPage>10</RecordsPerPage>
                                                     </parameters>
                                                 </control>
                                             </cell>
                                             <cell colspan='1' rowspan='10' 
                                                 showlabel='false'>
                                                 <labels>
                                                     <label description='Top Opportunities - 2'
                                                     languagecode='{0}' />
                                                 </labels>
                                                 <control id='TopOpportunities2'
                                                     classid='{{E7A81278-8635-4d9e-8D4D-59480B391C5B}}'>
                                                     <parameters>
                                                         <ViewId>{1}</ViewId>
                                                         <IsUserView>false</IsUserView>
                                                         <RelationshipName />
                                                         <TargetEntityType>opportunity</TargetEntityType>
                                                         <AutoExpand>Fixed</AutoExpand>
                                                         <EnableQuickFind>false</EnableQuickFind>
                                                         <EnableViewPicker>false</EnableViewPicker>
                                                         <EnableJumpBar>false</EnableJumpBar>
                                                         <ChartGridMode>Grid</ChartGridMode>
                                                         <VisualizationId>{2}</VisualizationId>
                                                         <EnableChartPicker>false</EnableChartPicker>
                                                         <RecordsPerPage>10</RecordsPerPage>
                                                     </parameters>
                                                 </control>
                                             </cell>
                                         </row>
                                         <row />
                                         <row />
                                         <row />
                                         <row />
                                         <row />
                                         <row />
                                         <row />
                                         <row />
                                         <row />
                                     </rows>
                                 </section>
                             </sections>
                         </column>
                     </columns>
                 </tab>
             </tabs>
         </form>",
     languageCode,
     defaultOpportunityQuery.SavedQueryId.Value.ToString("B"),
     visualization.SavedQueryVisualizationId.Value.ToString("B")),
     IsDefault = false
 };
 _dashboardId = _serviceProxy.Create(dashboard);

// </snippetcruddashboards2>