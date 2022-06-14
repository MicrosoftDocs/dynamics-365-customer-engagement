---
title: "Configure routing to preferred agents | MicrosoftDocs"
description: "Know how you can configure the settings to route work items to preferred agents in Customer Service."
ms.date: 06/14/2022
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

To provide highly personalized services to your customers and address their pain points efficiently, you can configure the option to route work items to specific agents of your choice. You can configure the preferred agent settings for a contact or for an account depending on your business needs.

> [!NOTE]
> 
> - The settings to configure preferred agents are available only in Customer Service admin center.
> - In the preview release, you can configure contacts only.

For preferred agents to work optimally, you must ensure that the configured agent is also a part of the queues to which the work item will be routed.

The routing diagnostics if enabled will display information on the preferred agent routing under **Agent assignment trace** of the diagnostics page of the work item. The **Assignment criteria** section displays information whether the setting is enabled. The  **Assignment trace** section displays the reason information.

## Enable settings for routing to preferred agent

1. In Customer Service admin center, select **Routing** in the site map, and then select **Manage** for **Preferred agent routing (preview)** on the page that appears.

1. Turn on the **Enable preferred agent routing** toggle.

1. Select one of the following additional settings to determine the action when preferred agent is unavailable:

   - **Next best agent based on assignment logic**: The work item will be routed based on the assignment rules. We recommend that you use this option for live chat conversations and voice channel calls.

   - **No one. Let the work remain unassigned in the queue**: The work item will remain in the queue till the preferred agent picks it or it's manually routed to another agent. We recommend that you use this option for asynchronous channel conversations.

1. To select the contact and agents, in the **Preferred agents matrix** area, select **Add a contact**. The **Add contact and preferred agent** flyout window appears.

1. In **Contact full name**, type the contact name, and select the required value from the dropdown list.

1. Select **Add user** to map agents to the contact. You can add up to three agents to one contact as the preferred agents. The users with the agent persona only will be displayed in the list of users.

1. Save and close.

1. You can set the preference order by selecting the agents in the order in which you want the work item to be routed.

1. You can add or remove agents in the list but at least one agent will remain in the list at any point in time.

1. In **Preferred agents matrix**, you can use the edit and remove options to modify the contacts.

## See also

[Overview of unified routing](overview-unified-routing.md)  
[Configure queues](queues-omnichannel.md)  
[Diagnostics for unified routing](unified-routing-diagnostics.md)  

