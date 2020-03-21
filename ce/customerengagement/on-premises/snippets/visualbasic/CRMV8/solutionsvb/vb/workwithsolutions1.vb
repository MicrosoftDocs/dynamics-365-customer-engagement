' <snippetworkwithsolutions1>




 'Define a new publisher
 Dim _crmSdkPublisher As Publisher =
  New Publisher With {
   .UniqueName = "sdksamples",
   .FriendlyName = "Microsoft CRM SDK Samples",
   .SupportingWebsiteUrl = "https://msdn.microsoft.com/dynamics/crm/default.aspx",
   .CustomizationPrefix = "sample",
   .EMailAddress = "someone@microsoft.com",
   .Description = "This publisher was created with samples from the Microsoft Dynamics CRM SDK"
  }

 'Does publisher already exist?
 Dim querySDKSamplePublisher As QueryExpression =
  New QueryExpression With {
   .EntityName = Publisher.EntityLogicalName,
   .ColumnSet = New ColumnSet("publisherid", "customizationprefix"),
   .Criteria = New FilterExpression()
  }

 querySDKSamplePublisher.Criteria.AddCondition("uniquename",
                                               ConditionOperator.Equal,
                                               _crmSdkPublisher.UniqueName)
 Dim querySDKSamplePublisherResults As EntityCollection =
  _serviceProxy.RetrieveMultiple(querySDKSamplePublisher)
 Dim SDKSamplePublisherResults As Publisher = Nothing

 'If it already exists, use it
 If querySDKSamplePublisherResults.Entities.Count > 0 Then
  SDKSamplePublisherResults = CType(querySDKSamplePublisherResults.Entities(0), Publisher)
  _crmSdkPublisherId = CType(SDKSamplePublisherResults.PublisherId, Guid)
  _customizationPrefix = SDKSamplePublisherResults.CustomizationPrefix
 End If
 'If it doesn't exist, create it
 If SDKSamplePublisherResults Is Nothing Then
  _crmSdkPublisherId = _serviceProxy.Create(_crmSdkPublisher)
  Console.WriteLine(String.Format("Created publisher: {0}.", _crmSdkPublisher.FriendlyName))
  _customizationPrefix = _crmSdkPublisher.CustomizationPrefix
 End If

' </snippetworkwithsolutions1>