' <snippetdistributecampaignfrommarketinglist1>


	' Copy the campaign.
          Dim campaignCopyRequest = New CopyCampaignRequest With
                                    {
                                        .BaseCampaign = _originalCampaignId
                                    }

          Dim copyCampaignResponse =
              CType(_serviceProxy.Execute(campaignCopyRequest), 
                  CopyCampaignResponse)
	_campaignId = copyCampaignResponse.CampaignCopyId

          Console.WriteLine("  Copied the campaign to new campaign with GUID " _
                            &amp; vbCrLf &amp; vbTab &amp; "{{{0}}}", _campaignId)

' </snippetdistributecampaignfrommarketinglist1>