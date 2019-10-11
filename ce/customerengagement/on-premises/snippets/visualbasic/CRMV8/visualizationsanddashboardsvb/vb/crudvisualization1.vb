' <snippetcrudvisualization1>


 ' Create a visualization

 ' Set The presentation XML string.
 Dim presentationXml As String = "" &amp; ControlChars.CrLf &amp; _
     "<Chart Palette='BrightPastel'>" &amp; ControlChars.CrLf &amp; _
     "    <Series>" &amp; ControlChars.CrLf &amp; _
     "        <Series _Template_='All' ShadowOffset='2' " &amp; ControlChars.CrLf &amp; _
     "            BorderColor='64, 64, 64' BorderDashStyle='Solid'" &amp; ControlChars.CrLf &amp; _
     "            BorderWidth='1' IsValueShownAsLabel='true' " &amp; ControlChars.CrLf &amp; _
     "            Font='Tahoma, 6.75pt, GdiCharSet=0' " &amp; ControlChars.CrLf &amp; _
     "            LabelForeColor='100, 100, 100'" &amp; ControlChars.CrLf &amp; _
     "            CustomProperties='FunnelLabelStyle=Outside' " &amp; ControlChars.CrLf &amp; _
     "            ChartType='Funnel'>" &amp; ControlChars.CrLf &amp; _
     "            <SmartLabelStyle Enabled='True' />" &amp; ControlChars.CrLf &amp; _
     "            <Points />" &amp; ControlChars.CrLf &amp; _
     "        </Series>" &amp; ControlChars.CrLf &amp; _
     "     </Series>" &amp; ControlChars.CrLf &amp; _
     "    <ChartAreas>" &amp; ControlChars.CrLf &amp; _
     "        <ChartArea _Template_='All' BackColor='Transparent'" &amp; ControlChars.CrLf &amp; _
     "            BorderColor='Transparent' " &amp; ControlChars.CrLf &amp; _
     "            BorderDashStyle='Solid'>" &amp; ControlChars.CrLf &amp; _
     "            <Area3DStyle Enable3D='True' " &amp; ControlChars.CrLf &amp; _
     "                IsClustered='True'/>" &amp; ControlChars.CrLf &amp; _
     "        </ChartArea>" &amp; ControlChars.CrLf &amp; _
     "    </ChartAreas>" &amp; ControlChars.CrLf &amp; _
     "    <Legends>" &amp; ControlChars.CrLf &amp; _
     "        <Legend _Template_='All' Alignment='Center' " &amp; ControlChars.CrLf &amp; _
     "            LegendStyle='Table' Docking='Bottom' " &amp; ControlChars.CrLf &amp; _
     "            IsEquallySpacedItems='True' BackColor='White'" &amp; ControlChars.CrLf &amp; _
     "            BorderColor='228, 228, 228' BorderWidth='0' " &amp; ControlChars.CrLf &amp; _
     "            Font='Tahoma, 8pt, GdiCharSet=0' " &amp; ControlChars.CrLf &amp; _
     "            ShadowColor='0, 0, 0, 0' " &amp; ControlChars.CrLf &amp; _
     "            ForeColor='100, 100, 100'>" &amp; ControlChars.CrLf &amp; _
     "        </Legend>" &amp; ControlChars.CrLf &amp; _
     "    </Legends>" &amp; ControlChars.CrLf &amp; _
     "    <Titles>" &amp; ControlChars.CrLf &amp; _
     "        <Title _Template_='All'" &amp; ControlChars.CrLf &amp; _
     "            Font='Tahoma, 9pt, style=Bold, GdiCharSet=0'" &amp; ControlChars.CrLf &amp; _
     "            ForeColor='102, 102, 102'>" &amp; ControlChars.CrLf &amp; _
     "        </Title>" &amp; ControlChars.CrLf &amp; _
     "    </Titles>" &amp; ControlChars.CrLf &amp; _
     "    <BorderSkin PageColor='Control'" &amp; ControlChars.CrLf &amp; _
     "        BackColor='CornflowerBlue'" &amp; ControlChars.CrLf &amp; _
     "        BackSecondaryColor='CornflowerBlue' />" &amp; ControlChars.CrLf &amp; _
     "</Chart>"

 ' Set the data XML string.
 Dim dataXml As String = "" &amp; ControlChars.CrLf &amp; _
     "<datadefinition>" &amp; ControlChars.CrLf &amp; _
     "    <fetchcollection>" &amp; ControlChars.CrLf &amp; _
     "        <fetch mapping='logical' count='10' " &amp; ControlChars.CrLf &amp; _
     "            aggregate='true'>" &amp; ControlChars.CrLf &amp; _
     "            <entity name='opportunity'>" &amp; ControlChars.CrLf &amp; _
     "                <attribute name='actualvalue_base' " &amp; ControlChars.CrLf &amp; _
     "                    aggregate='sum' " &amp; ControlChars.CrLf &amp; _
     "                    alias='sum_actualvalue_base' />" &amp; ControlChars.CrLf &amp; _
     "                <attribute name='stepname' groupby='true' " &amp; ControlChars.CrLf &amp; _
     "                    alias='stepname' />" &amp; ControlChars.CrLf &amp; _
     "                <order alias='stepname' descending='false'/>" &amp; ControlChars.CrLf &amp; _
     "            </entity>" &amp; ControlChars.CrLf &amp; _
     "        </fetch>" &amp; ControlChars.CrLf &amp; _
     "    </fetchcollection>" &amp; ControlChars.CrLf &amp; _
     "    <categorycollection>" &amp; ControlChars.CrLf &amp; _
     "        <category>" &amp; ControlChars.CrLf &amp; _
     "            <measurecollection>" &amp; ControlChars.CrLf &amp; _
     "                <measure alias='sum_actualvalue_base'/>" &amp; ControlChars.CrLf &amp; _
     "            </measurecollection>" &amp; ControlChars.CrLf &amp; _
     "        </category>" &amp; ControlChars.CrLf &amp; _
     "    </categorycollection>" &amp; ControlChars.CrLf &amp; _
     "</datadefinition>"
 ' Create the visualization entity instance.
 Dim newOrgOwnedVisualization As SavedQueryVisualization =
  New SavedQueryVisualization With {
   .Name = "Sample Visualization",
   .Description = "Sample organization-owned visualization.",
   .PresentationDescription = presentationXml,
   .DataDescription = dataXml,
   .PrimaryEntityTypeCode = Opportunity.EntityLogicalName,
   .IsDefault = False
  }
 _orgOwnedVisualizationId = _serviceProxy.Create(newOrgOwnedVisualization)
 Console.WriteLine("Created {0}.", newOrgOwnedVisualization.Name)

' </snippetcrudvisualization1>