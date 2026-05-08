---
title: Distribute campaign activities to qualified marketing list (Sample)
description: "The sample code demonstrates how to distribute campaign activities to the qualified members of a marketing list."
ms.date: 04/30/2026
ms.topic: sample
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.audienceType: 
  - developer
---
# Sample: Distribute campaign activities to qualified marketing list

This sample shows how to distribute campaign activities to the qualified members of a marketing list. You can download the sample from [here](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/marketing/DistributeCampaignActivitiesToMarketList).

## How to run this sample

[!include[cc-how-to-run-samples](../../includes/cc-how-to-run-samples.md)]

## How this sample works

To simulate the scenario described earlier, the sample performs the following steps:

### Setup

1. Checks for the current version of the org. 
1. The `CreateRequiredRecords` method creates any table rows that this sample requires.

### Demonstrate

1. The `DistributeCampaign` method creates and distributes the campaign. 
1. The `CreateMarketingList` method creates static marketing lists. 
1. The `RemoveRelationships` method removes the marketing list from the campaign activity.

### Clean up

The sample displays an option to delete the rows created in the [Setup](#setup). The deletion is optional in case you want to examine the table and data created by the sample. You can manually delete the rows to achieve the same result.
  
## Related information  
 [Campaign Tables](campaign-entities.md)   
 [Sample: Distribute a Quick Campaign](sample-distribute-a-quick-campaign.md)   
 [Sample: Distribute Campaign Activities to Dynamic and Static Lists](sample-distribute-campaign-activities-dynamic-static-lists.md)   
 [List (Marketing List) Table](list-marketing-list-entity.md)   
 [Marketing Tables (Campaign, List)](marketing-entities-campaign-list.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AddMemberListRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignActivityRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.QualifyMemberListRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.DistributeCampaignActivityRequest>


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
