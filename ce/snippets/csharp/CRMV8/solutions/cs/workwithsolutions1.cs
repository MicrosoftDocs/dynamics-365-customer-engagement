// <snippetworkwithsolutions1>




 //Define a new publisher
 Publisher _crmSdkPublisher = new Publisher
 {
     UniqueName = "sdksamples",
     FriendlyName = "Microsoft CRM SDK Samples",
     SupportingWebsiteUrl = "https://msdn.microsoft.com/dynamics/crm/default.aspx",
     CustomizationPrefix = "sample",
     EMailAddress = "someone@microsoft.com",
     Description = "This publisher was created with samples from the Microsoft Dynamics CRM SDK"
 };

 //Does publisher already exist?
 QueryExpression querySDKSamplePublisher = new QueryExpression
 {
     EntityName = Publisher.EntityLogicalName,
     ColumnSet = new ColumnSet("publisherid", "customizationprefix"),
     Criteria = new FilterExpression()
 };

 querySDKSamplePublisher.Criteria.AddCondition("uniquename", ConditionOperator.Equal, _crmSdkPublisher.UniqueName);
 EntityCollection querySDKSamplePublisherResults = _serviceProxy.RetrieveMultiple(querySDKSamplePublisher);
 Publisher SDKSamplePublisherResults = null;

 //If it already exists, use it
 if (querySDKSamplePublisherResults.Entities.Count > 0)
 {
     SDKSamplePublisherResults = (Publisher)querySDKSamplePublisherResults.Entities[0];
     _crmSdkPublisherId = (Guid)SDKSamplePublisherResults.PublisherId;
     _customizationPrefix = SDKSamplePublisherResults.CustomizationPrefix;
 }
 //If it doesn't exist, create it
 if (SDKSamplePublisherResults == null)
 {
     _crmSdkPublisherId = _serviceProxy.Create(_crmSdkPublisher);
     Console.WriteLine(String.Format("Created publisher: {0}.", _crmSdkPublisher.FriendlyName));
     _customizationPrefix = _crmSdkPublisher.CustomizationPrefix;
 }

// </snippetworkwithsolutions1>