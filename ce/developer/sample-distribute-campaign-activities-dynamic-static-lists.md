---
title: "Sample: Distribute campaign activities to dynamic and static lists (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "The sample code demonstrates how to create a dynamic marketing list, copy it to the static marketing list, and distribute campaign activities to the members of the marketing lists."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
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
search.app: 
  - D365CE
---
# Sample: Distribute campaign activities to dynamic and static lists

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Marketing entities](https://code.msdn.microsoft.com/Marketing-Samples-c5429380). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create a dynamic marketing list, copy it to the static marketing list, and distribute campaign activities to the members of the marketing lists.  
  
## Example  
 [!code-csharp[Marketing#MarketingAutomation](../snippets/csharp/CRMV8/marketing/cs/marketingautomation.cs#marketingautomation)]  
  
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
