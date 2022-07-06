---
title: "Configure routing to preferred agents | MicrosoftDocs"
description: "Know how you can configure the settings to route work items to preferred agents in Customer Service."
ms.date: 07/05/2022
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

For a more personalized experience, Dynamics 365 Customer Service gives you the option to route work items from a specific contact to the customer's preferred agents or relationship managers.

Configure contacts and their preferred agents in the Customer Service admin center. If a contact isn't configured, you can't assign a preferred agent to the contact.

To find the preferred agent for an incoming work item, the contact should be identified. For more information, see the **Channel-specific support for identifying a contact record** section.

In the preview release, you can map agents to contacts only.

## Configure preferred agent for contacts

Make sure that the agent you intend to assign to a contact is a member of the queue to which a work item will be routed.

1. In the Customer Service admin center site map, select **Routing**.

1. On the page that appears, next to **Preferred agent routing (preview)**, select **Manage**.

1. Turn on **Enable preferred agent routing**.

1. Select who should get the work item if preferred agent is unavailable:

   - **Next best agent based on assignment logic**: The work item will be routed based on the assignment rules. We recommend that you use this option for live chat conversations and voice channel calls.

   - **No one. Let the work remain unassigned in the queue**: The work item will remain in the queue until an agent picks it up or it's manually assigned to another agent. We recommend that you use this option for asynchronous channel conversations.

1. Select contacts and their preferred agents in the **Preferred agents matrix** area by doing the following steps:

1. Select **Add a contact** to add a contact.

1. In **Contact full name**, enter a contact name, and select a value from the dropdown list.

1. Select **Add user** to map agents to the contact.

   Only agents who are configured as bookable resources and assigned the agent role persona are displayed in the list of users.

   You can map up to three preferred agents to a contact. The order in which you map the agents is the order in which they'll receive a work item if an agent earlier in the list isn't available.

1. Save and close.

  :::image type="content" source="media/preferred-agents-mapped-view.png" alt-text="Screenshot of the Preferred agent routing settings page, showing contacts and their preferred agents.":::

### Routing diagnostics and preferred agent settings

If you've turned on routing diagnostics, a work item's diagnostics page includes information about preferred agent routing under **Agent assignment trace**. The **Assignment criteria** section shows whether the setting is turned on. The **Assignment trace** section displays the reason information. More information: [Diagnostics for unified routing](unified-routing-diagnostics.md)

## Update contacts and preferred agents

In **Preferred agents matrix**, use the edit and remove options to modify contacts and their preferred agents.

For each contact, you can map up to three agents and remove any two. At least one agent remains mapped to a contact.

### Identify contacts in supported channels

For the supported channels, use the information mentioned in the following table to identify customers as contacts.

|Channel|Customer record|
|-------|---------------|
|Record |<ul><li>**Case**: Use the **Customer** field to store the contact ID.</li><li>**Email, phone, fax, letter, appointment**: Use the **Regarding** field to store the contact ID. </li></ul>|
|**Digital messaging**: Chat, voice, and other channels|<ul><li> **Chat**: [Authenticated users are automatically identified as contacts](record-identification-rule.md). For unauthenticated users, use the pre-conversation survey to set the survey question name as **Name**.</li><li>**Voice**: Authenticated with the phone number.</li><li>Other channels: [Social profile](card-support-in-channels.md#support-for-social-profiles). </li></ul> |

### Roles and permissions for preferred agent routing

You must have one of the following roles to configure preferred agent routing.

- **For Customer Service**: CSR Manager
- **For Omnichannel for Customer Service**: Omnichannel administrator

You must be able to access the Contact entity. More information: [Contact](/customerengagement/on-premises/developer/entities/contact?view=op-9-1)

If you have a custom role, you must also have access to the following entities:

- [msdyn_preferredagent](developer/reference/entities/msdyn_preferredagent.md)
- [msdyn_preferredagentcustomeridentity](developer/reference/entities/msdyn_preferredagentcustomeridentity.md)

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Configure queues](queues-omnichannel.md)  
