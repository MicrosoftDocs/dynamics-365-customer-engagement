---
title: "Sample: Distribute campaign activities to qualified marketing list (Developer Guide for Dynamics 365 for Customer Engagement) | MicrosoftDocs"
description: "The sample code demonstrates how to distribute campaign activities to the qualified members of a marketing list."
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
  - distributing campaign activities to marketing list members, marketing entities sample
  - sample for distributing campaign activities to marketing list members
ms.assetid: 204308af-df43-41d2-9382-50a01aff8f3c
caps.latest.revision: 14
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Distribute campaign activities to qualified marketing list

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Marketing entities](https://code.msdn.microsoft.com/Marketing-Samples-c5429380).   

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to distribute campaign activities to the qualified members of a marketing list.  
  
## Example  
 [!code-csharp[Marketing#DistributeCampaignFromMarketingList](../snippets/csharp/CRMV8/marketing/cs/distributecampaignfrommarketinglist.cs#distributecampaignfrommarketinglist)]  
  
### See also  
 [Campaign Entities](campaign-entities.md)   
 [Sample: Distribute a Quick Campaign](sample-distribute-a-quick-campaign.md)   
 [Sample: Distribute Campaign Activities to Dynamic and Static Lists](sample-distribute-campaign-activities-dynamic-static-lists.md)   
 [List (Marketing List) Entity](list-marketing-list-entity.md)   
 [Marketing Entities (Campaign, List)](marketing-entities-campaign-list.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AddMemberListRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.AddItemCampaignActivityRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.QualifyMemberListRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.DistributeCampaignActivityRequest>
