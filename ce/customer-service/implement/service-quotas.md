---
title: Service quotas
description: Get details about the service quotas for unified routing and omnichannel implementations in Dynamics 365 Contact Center.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.date: 11/16/2026
ms.custom: bap-template
---

# Service quotas

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Service quotas are the limits on resources, configurations, and items provided as part of Dynamics 365 Contact Center. The tables that follow describe the service quotas and whether they can be adjusted for Dynamics 365 Customer Service Voice Channel Add-in and Dynamics 365 Customer Service Digital Messaging and Voice Add-in subscriptions.

> [!NOTE]
> - All limits are at an organization level unless otherwise specified.
> - If you need a higher limit on an adjustable measure, contact Microsoft Support to check whether the limit can be increased. Higher limits generally require a higher Dataverse tier, subject to sufficient licenses.

## Configuration limits

| Measure       | Description   |  Default limit per channel or submeasure |   Adjustable?  |
|------------ | -----------| --------------------| -----------|
| Intake rules  | Maximum number of intake rules | 100 for records | No |
| Route-to-queue rules | Maximum number of route-to-queue rulesets and rules per workstream   | 200 for rules |  No  |
| Classification rules  |  Maximum number of classification rulesets and rules per workstream |  10 rulesets  <br><br> 100 rules per ruleset  |  No <br><br> No |
| Number of voice channels per workstream | Maximum number of channels or phone numbers per voice workstream| 2500 | Yes |

### Assignment scale limits

The following limits apply to out-of-box and custom assignment methods.

| Assignment method | Max conversations waiting for assignment across queues | Incoming conversation rate | Max number of queues | Max users per queue | Users across queues |
|-------------------|----------------------------------------------------------|----------------------------|----------------------|---------------------|---------------------|
| Out-of-box assignment method - Without cross-queue prioritization | Up to 50,000 work items across queues | Up to 5,000 conversations per minute | Not applicable | Up to 5,000 users | Up to 10,000 users |
| Out-of-box assignment method - With cross-queue prioritization | Up to 50,000 work items across queues | Up to 5,000 conversations per minute | Up to 100 queues | Up to 5,000 users | Up to 10,000 users |
| Custom assignment - Without cross-queue prioritization | Up to 10,000 work items across queues | Up to 500 conversations per minute | Not applicable | Up to 2,000 users | Up to 10,000 users |
| Custom assignment - With cross-queue prioritization | Up to 10,000 work items across queues | Up to 500 conversations per minute | Up to 20 queues | Up to 2,000 users | Up to 10,000 users |

## Conversation limits

| Measure          | Description   | Default limit per channel or submeasure |   Adjustable?  |
|------------      | -----------   | ----------------   | -----------   |
| Concurrent calls (voice) | Maximum number of ongoing (simultaneous) voice conversations per organization | 10,000 concurrent calls<sup>7</sup> | Yes |
| Message size     | Maximum size of a single message payload including metadata like timestamps, tags, and links   |    Approximately 28 KB for any messaging channel | No   |
| Incoming conversations or work items  |  Maximum rate of incoming conversations per minute, aggregated across channels <br><br><br>Maximum rate of incoming conversations per minute by channel <br><br> |  Mixed channels (Aggregated across all channels combined): 5,000 incoming conversations or work items per minute<sup>1, 7</sup> across mixed channels<sup>6</sup> <br><br> <li> Voice: 5,000 per minute<sup>7</sup> <li> Live chat: 2,500 per minute<sup>7</sup> <li> Record: 100 per minute <li> Custom channel: 300 per minute <li> Social: 2,000 per minute  | Yes <br><br><br><br> Yes <br>    |
| Send message | Rate of new messages accepted into each ongoing messaging channel conversation | 10 messages per 10 seconds <br><br> 30 messages per 60 seconds | No |

> [!NOTE]
> For application limits for channels with non-Microsoft integrations like SMS integration through Twilio or TeleSign, see the non-Microsoft product documentation.

## Miscellaneous limits

| Measure    | Description   | Default limit per channel or submeasure |   Adjustable? |
|------------   | -----------      |----------      | -----------       |
| Bulk user provisioning  | Number of users you can add by using role attachment in a single update |   500 per 15 minutes<sup>2</sup> <br> \*\*Note\*\*: You can add up to 500 users in a single update that takes 15 minutes for provisioning |  Yes   |
| Bulk user updates  |  Number of users with attributes like skills, capacity profiles, and queue membership that can be edited in a single bulk update   |    25 users per bulk update<sup>2</sup>  | Yes   |
| Bulk user calendar or schedule updates  | Number of users whose calendars can be updated in bulk  |  500 per 15 minutes<sup>2</sup>   | Yes   |
| Dataverse Storage Entitlement (aggregated at tenant level)  |  Microsoft Dataverse storage entitlement based on license; includes SQL/DB, file, and log storage in Dataverse <br><br>More information: [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?LinkId=866544) |  32 GB of base storage per tenant<sup>3</sup><br><br>2.25 GB of extra storage per Customer Service license per user<sup>4</sup><br><br>35 GB of extra file storage for the Voice Channel Add-in per user<br>| Other Dataverse storage can be purchased     |
| Time for configuration updates to take effect, including channel and routing settings and updates to skills, capacity profile, and calendar  | Maximum time for configuration changes to reflect in the user experience |   15 minutes |    No.  |
| Updates to routed records | Number of actions per minute like resolve a case, queue transfer, transfer to customer service representatives (service representatives or representatives), queue item delete that can be done for routed records. | Governed by the Dataverse limits applicable to the org. Learn more in [Microsoft Dataverse limits](/power-apps/maker/data-platform/api-limits-overview). | Yes. |

<sup>1</sup> To get quality service in a channel, ensure that you don't exceed the defined limit for that channel. When you use multiple channels, keep the total conversations per minute under the overall limit of 5,000. For example, with 2,000 voice calls per minute, 2,000 live chat sessions per minute, and 1,000 digital messages per minute, the total is 5,000. Any conversation coming in after the 5,000<sup>th</sup> item, irrespective of the channel, might reduce the service quality.

<sup>2</sup> These are recommended limits beyond which system reliability and performance might decrease.

<sup>3</sup> 10 GB of SQL/DB storage, 20 GB of file storage, and 2 GB of log storage

<sup>4</sup> 250 MB of SQL/DB storage and 2 GB of file storage

<sup>5</sup> If eligible service representatives aren't available to serve the top-priority conversations, then the auto assignment process can appear to be paused. In such cases, we recommend that you use features like overflow management to manage high load or review service representative availability, scheduling, and skill configuration to expand the eligible service representative pool.

<sup>6</sup> If you use [overflow handling for work items in queue](../administer/manage-overflow.md#in-queue-handle-overflow-when-a-work-item-is-queued) and more than 20 items overflow in a minute, the work items are addressed in batches. Those queues that have a lower wait time are addressed first. If all queues are configured with the same wait time, then overflow handling takes place in a round robin manner.

<sup>7</sup> These scale limits are derived from internal scale runs performed with minimal configurations on the Dataverse Hyperscale tier. Actual throughput depends on your configuration, customizations, and Dataverse tier.

## Load test the services

Microsoft regularly conducts scale and stress tests on the services that run the system. These tests run at multiples of the peak volume observed in customer production traffic and use synthetic traffic patterns that reflect production scenarios across supported contact center capabilities. While Microsoft validates the scale and resilience of the service, every customer environment is unique. You might want to run your own load tests to validate your specific configuration, customizations, integrations, local networks, routing patterns, usage scenarios, or other bespoke solutions that you connect to the service.

> [!IMPORTANT]
> If you plan to run a load or stress test, you must notify Microsoft at least two weeks before the planned test date by contacting Microsoft Support. This notice helps Microsoft review the planned test activity and reduces the risk of the test being flagged as unexpected or potentially abusive traffic.

Load tests often generate synthetic traffic that targets specific endpoints or use cases and might approach or exceed quotas and limits for your environment. If you're concerned that your stress test might be flagged by the rules of engagement, work with Microsoft Support to have your tests reviewed before running them. Ensure that you perform load tests according to the [Microsoft Cloud Penetration Testing Rules of Engagement](https://www.microsoft.com/msrc/pentest-rules-of-engagement). You can also coordinate higher-scale operation and load-test notifications through the Dynamics 365 Contact Center Scale Group at d365contactcenterscale@service.microsoft.com. Learn more about Microsoft Cloud use rights in [Licensing Use Rights](https://www.microsoft.com/licensing/docs/view/licensing-use-rights).

## Next steps

[System requirements](/dynamics365/contact-center/implement/system-requirements-contact-center)  
[System requirements for Copilot Service workspace](customer-service-workspace-system-requirements.md)  
[Provision channels](/dynamics365/contact-center/implement/provision-channels)  
[Provision unified routing for Customer Service](../administer/provision-unified-routing.md)
