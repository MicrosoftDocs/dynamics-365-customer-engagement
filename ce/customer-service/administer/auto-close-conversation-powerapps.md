---
title: Close conversations automatically
description: Learn how to configure automatic conversation closure in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
ms.date: 11/26/2026
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
ms.collection:
ai-usage: ai-assisted
---
# Close conversations automatically

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Conversations can close automatically after they remain in a state longer than the configured duration. Automatic closure lets customer service representatives focus on other tasks.

The scheduler checks conversations every 5 minutes to identify those that remain in a state longer than the configured duration. These conversations become eligible for automatic closure and move to the **Closed** state the next time the scheduler runs.

> [!IMPORTANT]
> - The scheduler checks the [`modifiedon`](../../developer/reference/entities/msdyn_ocliveworkitem.md#BKMK_msdyn_modifiedon) field in the [Conversation (`msdyn_ocliveworkitem`) table](../../developer/reference/entities/msdyn_ocliveworkitem.md) to identify conversations that are eligible for automatic closure.
> - To avoid inaccurate statuses, don't manually update conversation state and status reason values in Microsoft Dataverse.
> - When you perform actions on a conversation, such as monitoring, consulting, or transferring, the scheduler recalculates the time to close it.

## Default time for automatic closure of conversations

The default duration before automatic closure varies by channel. The exact time the scheduler runs depends on the contact center deployment time in your region. For more information, contact Microsoft Support.

The following table lists the default duration and behavior for each channel and status reason.

 | Channel | Existing status reason | Default configured time | Description |
 |--------------------|-------|-------------|--------------------------------------|
 | Chat | Open | 20 minutes | A conversation in the **Open** state for more than 20 minutes is eligible for automatic closure. It moves to the **Closed** state the next time the scheduler runs. |
 | Chat | Active | None | A conversation in the **Active** state isn't automatically closed. |
 | Chat | Wrap-up | 15 minutes | A conversation in the **Wrap-up** state for more than 15 minutes is eligible for automatic closure. It moves to the **Closed** state the next time the scheduler runs. |
 | Records (Case) | Open | None | An **Open** conversation closes if the corresponding record is deleted. |
 | Records (Case) | Active | None | An **Active** conversation closes if the corresponding record is deleted. |
 | Voice | Open | 30 days | After 30 days, the conversation moves from **Open** to **Closed** when the scheduler runs. |
 | Voice | Active | Two hours | After two hours, the conversation moves from **Active** to **Wrap-up** when the scheduler runs. |
 | Voice | Wrap-up | One day | After one day, the conversation moves from **Wrap-up** to **Closed** when the scheduler runs. |
 | SMS, Teams, persistent chat, and social | Open | 30 days | A conversation in the **Open** state for more than 30 days is eligible for automatic closure. It moves to the **Closed** state the next time the scheduler runs. |
 | SMS, Teams, and social | Active | 30 days | A conversation in the **Active** state for more than 30 days is eligible for automatic closure. It moves to the **Closed** state the next time the scheduler runs. |
 | SMS, Teams, persistent chat, and social | Wrap-up | One day | A conversation in the **Wrap-up** state for more than one day is eligible for automatic closure. It moves to the **Closed** state the next time the scheduler runs. |

## Conversation in waiting

A conversation in **Waiting** moves to the **Closed** state after a specified period of inactivity. Set this duration in the workstream's **Auto-close after inactivity** option.

For example, when you set **Auto-close after inactivity** to 5 minutes, the conversation is moved to the **Closed** state if it's in **Waiting** for more than 5 minutes.

> [!NOTE]
> The **Auto-close after inactivity** option is available for persistent chat, SMS, social, and Microsoft Teams channels only.

Learn more in [Create a workstream](create-workstreams.md).

## Close conversations using Power Apps

To configure the automatic closure duration in Power Apps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.

1. Select **Tables**, and then select the **Channel State Configuration** table.

1. Select **Edit**, and set the duration in the **Auto close conversation after** column.

> [!NOTE]
> You need write privileges to edit the table. Learn more in [Security roles and privileges](security-roles.md).

## Close conversations using API

Use the Web API to change the default duration to meet your organization's requirements. Learn more in [Configure automatic closure of conversations using Web API](../develop/auto-close-conversation.md).

## Related information
 
[Understand conversation states](../use/oc-conversation-state.md)



[!INCLUDE[footer-include](../../includes/footer-banner.md)]
