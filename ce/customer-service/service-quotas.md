---
title: Service quotas 
description: Get details about the service quotas for unified routing and omnichannel implementations in Omnichannel for Customer Service.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: nenellim 
ms.topic: conceptual 
ms.date: 01/13/2023
ms.custom: bap-template 
---

# Service quotas

Service quotas are the limits on resources, configurations, and items that are provided as part of Omnichannel for Customer Service. The tables that follow describe the service quotas and whether they can be adjusted for Dynamics 365 Customer Service Voice Channel Add-in and Dynamics 365 Customer Service Digital Messaging and Voice Add-in subscriptions.

> [!NOTE]
> - All limits are at an organizational level for licensed organizations. The limits don't apply to trial or other non-licensed organizations.
> - If you need a higher limit on a measure that's indicated as adjustable, contact Microsoft Support to check whether the limit can be increased.

## Configuration limits

| Measure       | Description   |  Default limit per channel or submeasure |   Adjustable?  |
|------------ | -----------| --------------------| -----------|
| Intake rules  | Maximum number of intake rules | 100 for records | No |
| Route-to-queue rules | Maximum number of route-to-queue rulesets and rules per workstream   | 100 for rules |  No  |  
| Classification rules  |  Maximum number of classification rulesets and rules per workstream |  10 rulesets  <br><br> 100 rules per ruleset  |  No <br><br> No |

## Conversation limits

| Measure          | Description   | Default limit per channel or submeasure |   Adjustable?  |
|------------      | -----------   | ----------------   | -----------   |
| Message size     | Maximum size of a single message payload including metadata like timestamps, tags, and links   |    Approximately 28 KB for any messaging channel | No   |
| Incoming conversations or work items  |  Maximum rate of incoming conversations per minute, aggregated across channels <br><br><br>Maximum rate of incoming conversations per minute by channel <br><br> |  Total of 25 incoming conversations or work items per minute<sup>1</sup> for voice, live chat, digital messages, and record channels <br><br> <li> Voice - 7 per minute<sup>2</sup> <li> Live chat - 20 per minute  <li> Record - 25 per minute<li> Social and Direct Line - 20 per minute<sup>2</sup>  | Yes <br><br><br><br> Yes <br>    |

> [!NOTE]
> For application limits for channels with third-party integrations like SMS integration through Twilio or TeleSign, see the third-party documentation.

## Miscellaneous limits

| Measure    | Description   | Default limit per channel or submeasure |   Adjustable? |
|------------   | -----------      |----------      | -----------       |
| Bulk user provisioning  | Number of users that can be added using role attachment in a single update |   500 per 15 minutes<sup>2</sup> <br> **Note**: You can add up to 500 users in a single update that takes 15 minutes for provisioning |  Yes   |
| Bulk user updates  |  Number of users with attributes like skills, capacity profiles, and queue membership that can be edited in a single bulk update   |    25 users per bulk update<sup>2</sup>  | Yes   |
| Bulk user calendar or schedule updates  | Number of users whose calendars can be updated in bulk  |  500 per 15 minutes<sup>2</sup>   | Yes   |
| Dataverse Storage Entitlement (aggregated at tenant level)  |  Microsoft Dataverse storage entitlement based on license; includes SQL/DB, file, and log storage in Dataverse <br><br>More information: [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544) |  32 GB of base storage per tenant<sup>3</sup><br><br>2.25 GB of extra storage per Customer Service license per user<sup>4</sup><br><br>35 GB of extra file storage for the Voice Channel Add-in per user<br>| Other Dataverse storage can be purchased     |
| Time for configuration updates to take effect, including channel and routing settings and updates to agent skills, capacity profile, and calendar  | Maximum time for configuration changes to reflect in the user experience |   15 minutes |    No  |
| Block size per assignment cycle | Maximum number of unassigned conversations or work items picked per assignment cycle per queue | 100 conversations or work items<sup>5</sup>   |  Yes  |

<sup>1</sup> To get quality service in a channel, ensure that you don't exceed the defined limit for that channel. But when multiple channels are in use, the total conversations per minute should remain under the overall limit of 25. For example, with 5 voice calls per minute, 15 live chat sessions per minute, and 10 digital messages, the total limit is considered to be 25. Any conversation coming in after the 25<sup>th</sup> item, irrespective of the channel, might reduce the service quality.

<sup>2</sup> These are recommended limits beyond which system reliability and performance might decrease. 

<sup>3</sup> 10 GB of SQL/DB storage, 20 GB of file storage, and 2 GB of log storage  

<sup>4</sup> 250 MB of SQL/DB storage and 2 GB of file storage 

<sup>5</sup> If there's a shortage of eligible agents to serve the 100 (the default block size) top priority conversations, then the autoassignment can appear to be paused. In such cases, we recommend that you use features like overflow management to manage high load or review agent availability, scheduling, and skill configuration to expand the eligible agent pool. If these options aren't adequate, contact Microsoft Support with your business scenario to check whether the block size can be increased. 


## Next steps

[System requirements for Omnichannel for Customer Service](system-requirements-omnichannel.md)  
[System requirements for Customer Service workspace](customer-service-workspace-system-requirements.md)  
[Provision Omnichannel for Customer Service](omnichannel-provision-license.md)  
[Provision unified routing for Customer Service](provision-unified-routing.md)
