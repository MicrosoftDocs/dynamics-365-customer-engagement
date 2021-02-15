---
title: "Sample: Collaborate with activity feeds| MicrosoftDocs"
description: The sample shows how to create posts with comments and mentions and how to follow Dynamics 365 Customer Engagement (on-premise) records. It also demonstrates how to retrieve information for the personal and record walls.
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

---
# Sample: Collaborate with activity feeds

This sample shows how to create posts with comments and mentions and how to follow records. It also demonstrates how to retrieve information for the personal and record walls. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/CollaborateWithActivityFeeds).  

[!include[cc-sample-note](includes/cc-sample-note.md)]
  
## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## How this sample works

In order to simulate the scenario described in above, the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. Creates leads for relating activity feed records. Since there is an active post rule configuration of a new lead, creating the leads should add an auto post to the record wall for each of the leads.

### Demonstrate

1. The `ConfigureActivityFeeds` method gets the original system user configuration in order to keep a copy for reverting after the sample has completed. This method also creates or retrieves an instance of `msdyn_PostConfig` to enable activity feeds for leads. If a new `msdyn_PostConfig` record gets created, activity feeds for system users will be enabled automatically.
2. The `PostToRecordWalls` method posts records to the wall.
3. The `PostToPersonalWalls` method posts lead records on personal walls.
4. The `ShowRecordWalls` methods shows leads records on the wall.

### Clean up

Display an option to delete the sample data created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the sample data to achieve the same result.

  
### See also  
 [Activity Feeds Entities](activity-feeds-entities.md)   
 [Introduction to Activity Feeds](introduction-activity-feeds.md)   
 [Configure Activity Feeds](configure-activity-feeds.md)   
 <xref:Microsoft.Crm.Sdk.Messages.RetrievePersonalWallRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveRecordWallRequest>   
 [Post Entity](entities/post.md)   
 [PostComment Entity](entities/postcomment.md)   
 [PostFollow Entity](entities/postfollow.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]