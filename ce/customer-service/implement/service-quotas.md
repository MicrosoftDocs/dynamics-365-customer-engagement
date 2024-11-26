---
title: Service quotas
description: Get details about the service quotas for unified routing and omnichannel implementations.
author: gandhamm
ms.author: mgandham
ms.reviewer:
ms.topic: conceptual
ms.date: 11/12/2024
ms.custom: bap-template
---

# Service quotas

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Service quotas are the limits on resources, configurations, and items that are provided as part of Omnichannel for Customer Service. The tables that follow describe the service quotas and whether they can be adjusted for Dynamics 365 Customer Service Voice Channel Add-in and Dynamics 365 Customer Service Digital Messaging and Voice Add-in subscriptions.

> [!NOTE]
> - All limits are at an organization level unless otherwise specified.
> - If you need a higher limit on a measure that's indicated as adjustable, contact Microsoft Support to check whether the limit can be increased.

## Configuration limits

| Measure       | Description   |  Default limit per channel or submeasure |   Adjustable?  |
|------------ | -----------| --------------------| -----------|
| Intake rules  | Maximum number of intake rules | 100 for records | No |
| Route-to-queue rules | Maximum number of route-to-queue rulesets and rules per workstream   | 200 for rules |  No  |  
| Classification rules  |  Maximum number of classification rulesets and rules per workstream |  10 rulesets  <br><br> 100 rules per ruleset  |  No <br><br> No |

## Conversation limits

| Measure          | Description   | Default limit per channel or submeasure |   Adjustable?  |
|------------      | -----------   | ----------------   | -----------   |
| Message size     | Maximum size of a single message payload including metadata like timestamps, tags, and links   |    Approximately 28 KB for any messaging channel | No   |
| Incoming conversations or work items  |  Maximum rate of incoming conversations per minute, aggregated across channels <br><br><br>Maximum rate of incoming conversations per minute by channel <br><br> |  Total of 25 incoming conversations or work items per minute<sup>1</sup> for voice, live chat, digital messages, and record channels<sup>6</sup> <br><br> <li> Voice - 7 per minute<sup>2</sup> <li> Live chat - 20 per minute  <li> Record - 25 per minute<li> Social and Direct Line - 20 per minute<sup>2</sup>  | Yes <br><br><br><br> Yes <br>    |

> [!NOTE]
> For application limits for channels with third-party integrations like SMS integration through Twilio or TeleSign, see the third-party documentation.

## Miscellaneous limits

| Measure    | Description   | Default limit per channel or submeasure |   Adjustable? |
|------------   | -----------      |----------      | -----------       |
| Bulk user provisioning  | Number of users that can be added using role attachment in a single update |   500 per 15 minutes<sup>2</sup> <br> **Note**: You can add up to 500 users in a single update that takes 15 minutes for provisioning |  Yes   |
| Bulk user updates  |  Number of users with attributes like skills, capacity profiles, and queue membership that can be edited in a single bulk update   |    25 users per bulk update<sup>2</sup>  | Yes   |
| Bulk user calendar or schedule updates  | Number of users whose calendars can be updated in bulk  |  500 per 15 minutes<sup>2</sup>   | Yes   |
| Dataverse Storage Entitlement (aggregated at tenant level)  |  Microsoft Dataverse storage entitlement based on license; includes SQL/DB, file, and log storage in Dataverse <br><br>More information: [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544) |  32 GB of base storage per tenant<sup>3</sup><br><br>2.25 GB of extra storage per Customer Service license per user<sup>4</sup><br><br>35 GB of extra file storage for the Voice Channel Add-in per user<br>| Other Dataverse storage can be purchased     |
| Time for configuration updates to take effect, including channel and routing settings and updates to agent skills, capacity profile, and calendar  | Maximum time for configuration changes to reflect in the user experience |   15 minutes |    No.  |
| Block size per assignment cycle | Maximum number of unassigned conversations or work items picked per assignment cycle per queue | <ul><li> 100 digital messaging or voice conversations<sup>5</sup></li><li>10,000 records-related work items prioritized and assigned in a block size of 2,000. </li></ul>   |  Yes. |
| Updates to routed records | Number of actions per minute like resolve a case, queue transfer, agent transfer, queue item delete that can be done for routed records. | 25 updates per minute per organization. | Yes. |

<sup>1</sup> To get quality service in a channel, ensure that you don't exceed the defined limit for that channel. When multiple channels are in use, the total conversations per minute should remain under the overall limit of 25. For example, with 5 voice calls per minute, 15 live chat sessions per minute, and 10 digital messages, the total limit is considered to be 25. Any conversation coming in after the 25<sup>th</sup> item, irrespective of the channel, might reduce the service quality.

<sup>2</sup> These are recommended limits beyond which system reliability and performance might decrease.

<sup>3</sup> 10 GB of SQL/DB storage, 20 GB of file storage, and 2 GB of log storage  

<sup>4</sup> 250 MB of SQL/DB storage and 2 GB of file storage

<sup>5</sup> If eligible agents aren't available to serve the default block size of top priority conversations, then the auto assignment process can appear to be paused. In such cases, we recommend that you use features like overflow management to manage high load or review agent availability, scheduling, and skill configuration to expand the eligible agent pool. If these options aren't adequate, contact Microsoft Support with your business scenario to check whether the block size can be increased.

<sup>6</sup> If you use [overflow handling for work items in queue](../administer/manage-overflow.md#handle-overflow-when-a-work-item-is-queued) and more than 20 items overflow in a minute, the work items are addressed in batches. Those queues that have a lower wait time are addressed first. If all queues are configured with the same wait time, then overflow handling takes place in a round robin manner.

## Load test the services

Microsoft regularly conducts scale and stress tests on the services that run Omnichannel for Customer Service. These tests are performed at multiples of the peak volume observed in customer production traffic. While the services can sustain high loads, we understand that you might want to verify your own load profile against the services. Your load profile can include customizations, integrations, local networks, or other bespoke solutions that you integrate. Make sure that you perform load tests according to the [Microsoft Cloud Penetration Testing Rules of Engagement](https://www.microsoft.com/msrc/pentest-rules-of-engagement).

Load tests often generate synthetic traffic that targets specific endpoints or use cases and might approach or exceed quotas and limits for your environment. If you are concerned that your stress test might be flagged by the rules of engagement, we recommend that you work with Microsoft Support to have your tests reviewed before running them. For more information on Microsoft Cloud use rights, see [Licensing Use Rights](https://www.microsoft.com/licensing/docs/view/licensing-use-rights).

## Next steps

[System requirements for Omnichannel for Customer Service](system-requirements-omnichannel.md)  
[System requirements for Customer Service workspace](customer-service-workspace-system-requirements.md)  
[Provision channels](/dynamics365/contact-center/implement/provision-channels)  
[Provision unified routing for Customer Service](../administer/provision-unified-routing.md)
