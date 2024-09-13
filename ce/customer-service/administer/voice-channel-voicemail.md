---
title: Configure voicemail to manage inbound calls
description: Configure voicemail to manage inbound calls, route voicemails to agents, and reduce on-hold wait times.
author: neeranelli
ms.author: nenellim
ms.date: 08/29/2024
ms.topic: how-to
ms.reviewer:
ms.collection:
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/26/2023
---

# Configure voicemail to manage inbound calls

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability.md)]

Voicemails help your customers record messages for agents when they come across long wait times or their direct calls to agents are unanswered. You can reduce on-hold calls when customers communicate their concerns promptly through voicemails and call back later for a status check.

The salient features of voicemail are as follows:

- Callers can record voicemails for up to five minutes only.
- If you don't want to use the out-of-the-box prompt for the voicemail, you can customize it in the [automated message](configure-automated-message.md#customize-automated-messages-at-the-channel-level) or [workstream settings](voice-channel-inbound-calling.md).
- Voicemails are always transcribed irrespective of whether you enable the voice call transcription.
- If the customer is unable to record the voicemail, an automated message plays for the customer that informs them that the system couldn't record their voicemail and they should call back again.
- The bot can't offer to take a voicemail. The call must be escalated to an agent. The system offers the voicemail option if the agent isn't available.

## Prerequisites for voicemail

The prerequisites are as follows:

- The [voice channel](voice-channel-install.md) is enabled.
- [Unified routing](provision-unified-routing.md) is enabled.
- [Agent presence](../use/oc-manage-presence-status.md) works correctly, which is required to open a voicemail.
- The operating hours message at the voice workstream level isn't set because it overrides the voice queue-level overflow setup that the system needs for the voicemail feature to work. If you set the operating hours message for the voice workstream, the system plays the message and disconnects the call.
- The [call recording and SMS services](voice-channel-configure-services.md) are enabled.

## Configure voicemail to manage overflow of voice calls

You can redirect the caller to record a voicemail for the agent when an incoming call reaches the voice queue and the queue is in one of the following conditions:

- Exceeds a defined number of calls that are waiting in the queue
- The call comes during the after hours of the call center operations
- Exceeds the estimated wait time

For information on how to configure the conditions and actions, go to [Manage overflow of work items in queues](manage-overflow.md).

You can also configure overflow override in the route-to-queue rule of a workstream.

Out of the box, **Default Group Voicemail Workstream** is available to route the group voicemails to the default group voicemail queue.

You can configure routing rules to route voicemail that your customer has recorded on your organization's phone number. In the rule condition, select **Organization phone number** in **Work classification** or **Create Intake rule** and add the required phone number to route the voicemail. When you define the intake or classification conditions, specify the following settings:

- The phone number with the country/region code, if you select the **Equals** operator.
- The phone number without the country/region code, if you select the **Contains** operator.

The following considerations apply:

* To route voicemails, avoid defining rules based on skills or sentiment category for the missed conversation attribute because the rules might not work as expected.
* You can't route voicemails to voice queues because the system categorizes them as records.


## Use voicemail to manage direct calls to agents

If an agent misses a direct call and voicemail is configured, the system presents an option to the customer to record a voicemail. The agent might not answer the call because of one of the following reasons:

- Agent rejects the call
- Call timed out
- Agent presence shows as "offline" or "do not disturb"

Out of the box, **Default Individual Voicemail Workstream** is available to route the individual voicemails to the default individual voicemail queue.

## Configure voicemail views in inbox for agents

1. In Customer Service admin center or Contact Center admin center, in the site map, select **Workspaces** under **Agent experience**.

1. Select **Manage** for **Agent experience profiles** and select the profile that you want to edit.

1. Edit the inbox and enable it.

1. Select **Add**.

1. On the **Add a new view** dialog, enter the following details:

     - **Name**: Name for the view.
     - **Agent visibility**: Select Show.
     - **Record type**: Select **Voicemail**.

1. In the **Settings** dropdown list, select one or all of the following options:
     - Assigned
     - Unassigned
     - Resolved

More information:

- [Configure the inbox](configure-inbox.md)
- [Create and use agent experience profiles](create-agent-experience-profile.md)

## How voicemail works

The voicemail record is set up for routing out of the box. Voicemails are categorized into individual and group voicemails.

### Individual voicemails

Individual voicemails are triggered through direct inward dialing and are routed to the default individual voicemail workstream.

> [!NOTE]
> Agents receive voicemails only if they are signed in to the app and presence loads at least once. If the agent is signed in and their presence is set to offline, they must decline the call to receive the voicemail.

- The workstream routes the voicemail to the individual voicemail queue.
- By default, the individual voicemail queue has no agents.
- The custom assignment rule assigns the voicemail to an agent based on their direct inward call number.
- The assignment method is round robin.
- You can add all your agents who are configured for direct inward dialing to the individual voicemail queue. The voicemails left for their numbers are automatically assigned to the agents.

### Group voicemails

If an overflow condition of a queue triggers the voicemail, it routes to the default group voicemail workstream, which is a pick workstream.

- The workstream routes the voicemail to the default group voicemail queue.
- By default, the queue has no agents. Add those agents to the queue who triage voicemails.
- The assignment method is highest capacity.
- Voicemails left for every voice queue are routed to the group voicemail queue.
- For a more elaborate routing set up for voicemails, configure the required voicemail queues and route-to-queues rules to route to these queues.


### Manage voicemail capacity

By default, the voicemail workstream capacity is set to zero.

However, if you let voicemails take up capacity, the capacity restriction applies for group voicemail workstreams of push type only and not the default pick workstreams. In all cases, if an agent is at nil capacity and picks a work item, the system still assigns the work item to them even if they don't have any capacity.

Because the individual voicemail workstream has a custom assignment rule, capacity isn't taken into account, and voicemails are always pushed to the agent corresponding to the direct inward dialing number.

Supervisors can view the voicemails on the **Omnichannel Ongoing Conversations Dashboard**.

### View the default settings

1. In Customer Service admin center or Contact Center admin center, select **Routing** in the site map, and then select **Manage** for **Setup record routing**. Voicemail is listed under **Record types** on the page that appears.

1. Select **Voicemail**. The **Voicemail routing hub** page displays the following default settings:

   - **Intake rules**: The rules check whether the voicemail is for individual or group and then routes the voicemail accordingly.
       - **Route to Individual Voicemail Workstream**: The rule routes the voicemail to **Default Individual Voicemail Workstream** if the voicemail type is individual.
       - **Route to Group Voicemail Workstream**: The rule routes the voicemail to **Default Group Voicemail Workstream** if the voicemail type is group.
   - **Workstreams**
       - **Default Individual Voicemail Workstream**: Contains the settings to handle individual voicemails.
       - **Default Group Voicemail Workstream**: Contains the settings to handle group voicemails.

### Related information

[Overview of voice channel](voice-channel.md)  
[Overview of unified routing](overview-unified-routing.md)  
[Configure routing for the voice channel](../voice-channel-route-queues.md)  
[Manage overflow of work items in queues](manage-overflow.md)  
[Manage voicemails](../use/manage-voicemails.md)  
[Configure direct callback](voice-channel-direct-callback.md)  
[Omnichannel Voicemail dashboard](../use/oc-voicemail-dashboard.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
