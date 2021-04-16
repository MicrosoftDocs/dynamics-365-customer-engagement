---
title: "Sample: Distribute campaign activities to dynamic and static lists (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample code demonstrates how to create a dynamic marketing list, copy it to the static marketing list, and distribute campaign activities to the members of the marketing lists."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - sample for distributing campaigns to dynamic and static marketing lists
  - distributing campaigns to dynamic and static marketing lists, marketing entities sample
ms.assetid: 646ad2a7-935b-4770-a7d5-bdccd18cc072
caps.latest.revision: 13
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Distribute campaign activities to dynamic and static lists

This sample shows how to create a dynamic marketing list, copy it to the static marketing list, and distribute campaign activities to the members of the marketing lists. You can download the sample from [here](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/marketing/DistributeCampaignActivitiesToLists).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-samples.md)]

## How this sample works

In order to simulate the scenario described above, the sample will do the following:

### Setup

1. Checks for the current version of the org. 
2. The `CreateRequiredRecords` method creates any entity records that this sample requires.

### Demonstrate

1. The `List` method creates a dynamic list. The list is considered to be a dynamic list only when the `Type` parameter is set to true. 
2. The `Campaign` method creates a campaign. 
3. The `AddItemCampaignRequest` method adds the dynamic list to the campaign.
4. The `CampaignActivity` method creates a campaign activity to distribute fax to the list members.
5. The `AddItemCampaignActivityRequest` method adds the dynamic list to the campaign activity.
6. The `CopyDynamicListToStaticRequest` method copies the dynamic list to a static list.
7. The `DistributeCampaignActivityRequest` method distributes the campaign activity to the marketing lists.

### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.
  
### See also  
 [Campaign Entities](campaign-entities.md)   
 [Sample: Distribute a Quick Campaign](sample-distribute-a-quick-campaign.md)   
 [List (Marketing List) Entity](list-marketing-list-entity.md)   
 [Marketing Entities (Campaign, List)](marketing-entities-campaign-list.md)   
 [Sample: Distribute Campaign Activities to Qualified Marketing List](sample-distribute-campaign-activities-qualified-marketing-list.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AddMemberListRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignActivityRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.CopyDynamicListToStaticRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.DistributeCampaignActivityRequest>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]