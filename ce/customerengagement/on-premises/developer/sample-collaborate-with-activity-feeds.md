---
title: "Sample: Collaborate with activity feeds| MicrosoftDocs"
description: The sample shows how to create posts with comments and mentions and how to follow Dynamics 365 Customer Engagement (on-premise) records. It also demonstrates how to retrieve information for the personal and record walls.
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - collaborating with activity feeds sample, requirements
  - personal wall sample, retrieving information from
  - records sample, following
  - posts with comments sample, creating
  - updating posts, sample
  - multiple pages of posts, retrieving information from
  - activity feeds sample, downloading MicrosoftCRMActivityFeeds.zip.cab
  - following records, sample
  - activity feeds sample, collaborating
  - MicrosoftCRMActivityFeeds.zip.cab, downloading
ms.assetid: d680463c-09d4-4cd8-bdbe-2ca4309c12a3
caps.latest.revision: 24
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Collaborate with activity feeds

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Activity Feeds](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/ActivityFeeds).  

[!include[cc-sample-note](includes/cc-sample-note.md)]
  
## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]

## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create posts with comments and mentions and how to follow [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] records. It also demonstrates how to retrieve information for the personal and record walls.  
  
## Example  
 [!code-csharp[ActivityFeeds#WorkingWithActivityFeeds](../snippets/csharp/CRMV8/activityfeeds/cs/workingwithactivityfeeds.cs#workingwithactivityfeeds)]  
  
### See also  
 [Activity Feeds Entities](activity-feeds-entities.md)   
 [Introduction to Activity Feeds](introduction-activity-feeds.md)   
 [Configure Activity Feeds](configure-activity-feeds.md)   
 <xref:Microsoft.Crm.Sdk.Messages.RetrievePersonalWallRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveRecordWallRequest>   
 [Post Entity](entities/post.md)   
 [PostComment Entity](entities/postcomment.md)   
 [PostFollow Entity](entities/postfollow.md)
