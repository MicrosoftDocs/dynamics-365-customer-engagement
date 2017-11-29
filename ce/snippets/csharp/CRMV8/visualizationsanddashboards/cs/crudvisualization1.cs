// <snippetcrudvisualization1>


 // Create a visualization

 // Set The presentation XML string.
 string presentationXml = @"
 <Chart Palette='BrightPastel'>
     <Series>
         <Series _Template_='All' ShadowOffset='2' 
             BorderColor='64, 64, 64' BorderDashStyle='Solid'
             BorderWidth='1' IsValueShownAsLabel='true' 
             Font='Tahoma, 6.75pt, GdiCharSet=0' 
             LabelForeColor='100, 100, 100'
             CustomProperties='FunnelLabelStyle=Outside' 
             ChartType='Funnel'>
             <SmartLabelStyle Enabled='True' />
             <Points />
         </Series>
      </Series>
     <ChartAreas>
         <ChartArea _Template_='All' BackColor='Transparent'
             BorderColor='Transparent' 
             BorderDashStyle='Solid'>
             <Area3DStyle Enable3D='True' 
                 IsClustered='True'/>
         </ChartArea>
     </ChartAreas>
     <Legends>
         <Legend _Template_='All' Alignment='Center' 
             LegendStyle='Table' Docking='Bottom' 
             IsEquallySpacedItems='True' BackColor='White'
             BorderColor='228, 228, 228' BorderWidth='0' 
             Font='Tahoma, 8pt, GdiCharSet=0' 
             ShadowColor='0, 0, 0, 0' 
             ForeColor='100, 100, 100'>
         </Legend>
     </Legends>
     <Titles>
         <Title _Template_='All'
             Font='Tahoma, 9pt, style=Bold, GdiCharSet=0'
             ForeColor='102, 102, 102'>
         </Title>
     </Titles>
     <BorderSkin PageColor='Control'
         BackColor='CornflowerBlue'
         BackSecondaryColor='CornflowerBlue' />
 </Chart>
 ";

 // Set the data XML string.
 string dataXml = @"
 <datadefinition>
     <fetchcollection>
         <fetch mapping='logical' count='10' 
             aggregate='true'>
             <entity name='opportunity'>
                 <attribute name='actualvalue_base' 
                     aggregate='sum' 
                     alias='sum_actualvalue_base' />
                 <attribute name='stepname' groupby='true' 
                     alias='stepname' />
                 <order alias='stepname' descending='false'/>
             </entity>
         </fetch>
     </fetchcollection>
     <categorycollection>
         <category>
             <measurecollection>
                 <measure alias='sum_actualvalue_base'/>
             </measurecollection>
         </category>
     </categorycollection>
 </datadefinition>
 ";
 // Create the visualization entity instance.
 SavedQueryVisualization newOrgOwnedVisualization = new SavedQueryVisualization
 {
     Name = "Sample Visualization",
     Description = "Sample organization-owned visualization.",
     PresentationDescription = presentationXml,
     DataDescription = dataXml,
     PrimaryEntityTypeCode = Opportunity.EntityLogicalName,
     IsDefault = false
 };
 _orgOwnedVisualizationId = _serviceProxy.Create(newOrgOwnedVisualization);
 Console.WriteLine("Created {0}.", newOrgOwnedVisualization.Name);

// </snippetcrudvisualization1>