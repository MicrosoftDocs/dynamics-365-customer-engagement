---
title: "Configure routing to preferred agents | MicrosoftDocs"
description: "Know how you can configure the settings to route work items to preferred agents in Customer Service."
ms.date: 06/21/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Configure routing to preferred agents (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

To provide highly personalized services to your customers and enable highly context-aware conversations, you can configure the option to route work items from a specific contact to preferred agents or relationship managers.

You can configure preferred agents in Customer Service admin center only.

To find the preferred agent at runtime for an incoming work item, the contact should be identified. More information: [Identify customers automatically](record-identification-rule.md)

In the preview release, you can map agents to contacts only.

## Configure settings for routing to preferred agent

The agents that you'll map must be configured as bookable resources. For preferred agents to work optimally, you must ensure that the configured agent is also a part of the queues to which the work item will be routed. You can map up to three agents to one contact as preferred agents. The order of agents reflects the preference order in which the agents'll be assigned the work items if one or more agents aren't available.

1. In Customer Service admin center, select **Routing** in the site map, and then select **Manage** for **Preferred agent routing (preview)** on the page that appears.

1. Turn on the **Enable preferred agent routing** toggle.

1. Select one of the following additional settings to determine the action when preferred agent is unavailable:

   - **Next best agent based on assignment logic**: The work item will be routed based on the assignment rules. We recommend that you use this option for live chat conversations and voice channel calls.

   - **No one. Let the work remain unassigned in the queue**: The work item will remain in the queue till an agent picks it or it's manually assigned to another agent. We recommend that you use this option for asynchronous channel conversations.

1. To select the contact and agents, in the **Preferred agents matrix** area, select **Add a contact**. The **Add contact and preferred agent** flyout window appears.

1. In **Contact full name**, type the contact name, and select the required value from the dropdown list.

1. Select **Add user** to map agents to the contact.  The users with the agent persona only will be displayed in the list of users.

1. Save and close.

The routing diagnostics if enabled will display information on the preferred agent routing under **Agent assignment trace** of the diagnostics page of the work item. The **Assignment criteria** section displays information whether the setting is enabled. The **Assignment trace** section displays the reason information.

## Update contacts and preferred agents

For a contact, you can add or remove agents in the list but at least one agent will remain in the list at any point in time.

In **Preferred agents matrix**, use the edit and remove options to modify the contacts and the associated agents.

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Configure queues](queues-omnichannel.md)  
[Diagnostics for unified routing](unified-routing-diagnostics.md)  
