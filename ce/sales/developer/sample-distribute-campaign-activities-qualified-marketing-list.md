---
title: "Sample: Distribute campaign activities to qualified marketing list (Dynamics 365 Sales)"
description: "The sample code demonstrates how to distribute campaign activities to the qualified members of a marketing list."
ms.date: 03/01/2023
ms.reviewer: lavanyakr
ms.topic: sample
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
search.audienceType: 
  - developer
---
# Sample: Distribute campaign activities to qualified marketing list

This sample shows how to distribute campaign activities to the qualified members of a marketing list. You can download the sample from [here](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/marketing/DistributeCampaignActivitiesToMarketList).

## How to run this sample

[!include[cc-how-to-run-samples](../../includes/cc-how-to-run-samples.md)]

## How this sample works

In order to simulate the scenario described above, the sample will do the following:

### Setup

1. Checks for the current version of the org. 
2. The `CreateRequiredRecords` method creates any table rows that this sample requires.

### Demonstrate

1. The `DistributeCampaign` method creates and distributes campaign. 
2. The `CreateMarketingList` method creates static marketing lists. 
3. The `RemoveRelationships` method removes the marketing list from the campaign activity.

### Clean up

Display an option to delete the rows created in the [Setup](#setup). The deletion is optional in case you want to examine the table and data created by the sample. You can manually delete the rows to achieve the same result.
  
### See also  
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
