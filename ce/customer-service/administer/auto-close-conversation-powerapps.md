---
title: Close conversations automatically
description: Use this article to understand how to configure the auto-close duration of conversations.
ms.date: 05/02/2024
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
ms.collection:
---
# Close conversations automatically

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

A default time is set for the conversations to close automatically in the contact center. That is, if a conversation in a certain stage remains in the stage for more than the default time, then the conversation is moved to the closed state. Conversations achieve closure, allowing agents to focus on other tasks, enhancing productivity.

The scheduler checks conversations every 5 minutes to identify conversations that don't transition for more than the default configured time. Such conversations become eligible for automatic closure, so the next time the scheduler runs, the conversations are moved from the existing state to the **Closed** state.

> [!IMPORTANT]
> - The scheduler checks the [modifiedon](../develop/reference/entities/msdyn_ocliveworkitem.md#BKMK_msdyn_modifiedon) field in msdyn_ocliveworkitem table to identity the conversations that are eligible for automatic closure.
> - To avoid inaccurate statuses, we recommend that you don't change the conversation state and status reason by manually updating the records in Microsoft Dataverse.
> - For any actions performed on the conversations such as monitor, consult, or transfer, the scheduler automatically recalculates the time to close the conversation.


### Default time for automatic closure of conversations

All channels have different default configured time after which conversations can be moved to the **Closed** state. However, the exact time at which the scheduler runs is dependent on the Omnichannel for Customer Service deployment time in your region. For more information, contact Microsoft Support.

The following table describes the channel, status reason, and default configured time.

 | Channel | Existing status reason | Default configured time | Description |
 |--------------------|-------|-------------|--------------------------------------|
 | Chat | Open |  20 min   | For a chat channel, a conversation in the **Open** state for more than 20 minutes is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from the **Open** state to the **Closed** state. |
 | Chat | Active | None | For a chat channel, a conversation in the Active state won’t be automatically closed. |
 | Chat | Wrap-up | 15 minutes | For a chat channel, a conversation that is in the **Wrap-up** stage for more than 15 minutes is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from **Wrap-up** to the **Closed** state. |
 |  |  |  |  |
 | Records (Case) | Open | None | For a records (case) channel, a conversation that's **Open** will be closed if the corresponding record is deleted. |
 | Records (Case) | Active | None | For a records (case) channel, a conversation that's  **Active** will be closed if the corresponding record is deleted. |
 |  |  |  |  |
| Voice | Open |  30 days   | The conversation is eligible for automatic closure after the default time, 30 days, elapses. The conversation is moved from the **Open** to **Closed** state when the scheduler runs after the elapsed time.|
 | Voice | Active | 2 hours | The conversation is eligible for automatic closure after the default time, 2 hours, elapses. The conversation is moved from the **Active** to **Wrap-up** state when the scheduler runs after the elapsed time. |
 | Voice | Wrap-up | 1 day | The conversation is eligible for automatic closure after the default time, 1 day, elapses. The conversation is moved from the **Wrap-up** to **Closed** state when the scheduler runs after the elapsed time. |
 |  |  |  |  |
 | SMS, Teams, persistent chat, and social | Open | 30 days | In an asynchronous channel&mdash;such as SMS, Teams, persistent chat, or a social channel&mdash;a conversation that has been in the **Open** state for more than 30 days is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from the **Open** state to the **Closed** state. |
 | SMS, Teams, and social | Active | 30 days | In an asynchronous channel&mdash;such as SMS, Teams, or a social channel&mdash;a conversation that has been in the **Active** state for more than 30 days is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from **Active** to the **Closed** state. |
 | SMS, Teams, persistent chat, and social | Wrap-up | One day | In an asynchronous channel&mdash;such as SMS, Teams, persistent chat, or a social channel&mdash;a conversation that has been in the **Wrap-up** state for more than one day is eligible for automatic closure. Next time, when the scheduler runs, the conversation will be moved from **Wrap-up** to the **Closed** state. |

### Conversation in waiting

A conversation in **Waiting** is moved to the **Closed** state when the conversation is inactive for a specified time. The inactive time can be set in the workstream for the **Auto-close after inactivity** option, based on which the conversation will be moved to the closed state after the criteria is met.

For example, when you set **Auto-close after inactivity** to 5 minutes, the conversation is moved to the **Closed** state if it has been in **Waiting** for more than 5 minutes.

> [!NOTE]
> The **Auto-close after inactivity**  option is available for persistent chat, SMS, social, and Microsoft Teams channels only.

Learn more at [Create a workstream](create-workstreams.md).

### Close conversations using Power Apps

You can configure the auto-close duration of a conversation in Power Apps by performing the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.

2. Select **Tables**, and then select **Channel State Configuration** table.

3. Select **Edit**, and in **Auto close conversation after** column, set the auto-close duration.

> [!NOTE]
> Make sure that you have write privileges to edit the table. Learn more at [security roles and privileges - Power Platform](security-roles.md).

### Close conversations using API

Programmatically, you can change the default time and set it as per your organization's requirements using the Web APIs. To learn more, see [Configure automatic closure of conversations using web API](../develop/auto-close-conversation.md).

### Related information
 
[Understand conversation states](../use/oc-conversation-state.md)



[!INCLUDE[footer-include](../../includes/footer-banner.md)]
