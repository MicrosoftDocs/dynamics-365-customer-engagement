// <snippetdistributecampaignfrommarketinglist1>


 // Copy the campaign.
 var campaignCopyRequest = new CopyCampaignRequest
 {
     BaseCampaign = _originalCampaignId
 };

 var copyCampaignResponse =
     (CopyCampaignResponse)_serviceProxy.Execute(campaignCopyRequest);
 _campaignId = copyCampaignResponse.CampaignCopyId;

 Console.WriteLine("  Copied the campaign to new campaign with GUID \r\n\t{{{0}}}",
     _campaignId);

// </snippetdistributecampaignfrommarketinglist1>