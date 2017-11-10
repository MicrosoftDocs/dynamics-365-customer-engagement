// <snippetworkwithviews1>


                    System.String layoutXml =
@"<grid name='resultset' object='3' jump='name' select='1' 
    preview='1' icon='1'>
    <row name='result' id='opportunityid'>
    <cell name='name' width='150' /> 
    <cell name='customerid' width='150' /> 
    <cell name='estimatedclosedate' width='150' /> 
    <cell name='estimatedvalue' width='150' /> 
    <cell name='closeprobability' width='150' /> 
    <cell name='opportunityratingcode' width='150' /> 
    <cell name='opportunitycustomeridcontactcontactid.emailaddress1' 
        width='150' disableSorting='1' /> 
    </row>
</grid>";

                    System.String fetchXml =
                    @"<fetch version='1.0' output-format='xml-platform' 
    mapping='logical' distinct='false'>
    <entity name='opportunity'>
    <order attribute='estimatedvalue' descending='false' /> 
    <filter type='and'>
        <condition attribute='statecode' operator='eq' 
        value='0' /> 
    </filter>
    <attribute name='name' /> 
    <attribute name='estimatedvalue' /> 
    <attribute name='estimatedclosedate' /> 
    <attribute name='customerid' /> 
    <attribute name='opportunityratingcode' /> 
    <attribute name='closeprobability' /> 
    <link-entity alias='opportunitycustomeridcontactcontactid' 
        name='contact' from='contactid' to='customerid' 
        link-type='outer' visible='false'>
        <attribute name='emailaddress1' /> 
    </link-entity>
    <attribute name='opportunityid' /> 
    </entity>
</fetch>";

                    SavedQuery sq = new SavedQuery
                    {
                        Name = "A New Custom Public View",
                        Description = "A Saved Query created in code",
                        ReturnedTypeCode = "opportunity",
                        FetchXml = fetchXml,
                        LayoutXml = layoutXml,
                        QueryType = 0
                    };
                    
                    _customViewId = _serviceProxy.Create(sq);
                    Console.WriteLine("A new view with the name {0} was created.", sq.Name);

// </snippetworkwithviews1>