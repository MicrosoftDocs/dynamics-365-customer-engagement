---
title: Configure routing to preferred agents
description: Learn how to configure settings to route work items to preferred agents in Customer Service.
ms.date: 03/13/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
---

# Configure routing to preferred agents

For a more personalized experience, Dynamics 365 Customer Service gives you the option to route work items from a specific contact to the customer's preferred agents or relationship managers.

You can configure contacts and their preferred agents in the Customer Service admin center. If a contact isn't configured, then you can't assign a preferred agent to the contact. You can map agents to contacts only.

## Prerequisites

- You must have one of the following roles to configure preferred agent routing:
  - **For Customer Service**: CSR Manager
  - **For Omnichannel for Customer Service**: Omnichannel Administrator

- You must be able to access the Contact entity. More information: [Contact](/dynamics365/customerengagement/on-premises/developer/entities/contact?view=op-9-1&preserve-view=true)
- If you have a custom role, you must also have access to the msdyn_preferredagent and msdyn_preferredagentcustomeridentity entities.
- Ensure that the agent you want to assign to a contact is a member of the queue to which work items will be routed.

## Configure preferred agent for contacts

1. In the Customer Service admin center site map, select **Routing**.

1. On the page that appears, select **Manage** next to **Preferred agent routing**.

1. Turn on **Enable preferred agent routing**.

1. Select who should get the work item if preferred agent is unavailable:

   - **Next best agent based on assignment logic**: The work item will be routed based on the assignment rules. We recommend that you use this option for live chat conversations and voice channel calls.

   - **No one. Let the work remain unassigned in the queue**: The work item will remain in the queue until an agent picks it up or it's manually assigned to another agent. We recommend that you use this option for asynchronous channel conversations.

1. Select contacts and their preferred agents in the **Preferred agents matrix** area by doing the following steps:

      1. Select **Add a contact** to add a contact.

      1. In **Contact full name**, enter a contact name, and select a value from the dropdown list.

      1. Select **Add user** to map agents to the contact.

   You can map up to three preferred agents to a contact. The order in which the agents are listed is the order in which they'll receive a work item if an agent earlier in the list isn't available. You can sort the agent order by selecting an agent in the list and using the **Move up** or **Move down** option.

1. Save and close.

  :::image type="content" source="media/preferred-agents-mapped-view.png" alt-text="Screenshot of the Preferred agent routing settings page, showing contacts and their preferred agents.":::

## How routing to preferred agent works

If a preferred agent exists for a contact, the system will try to directly assign the conversation to an available preferred agent whose presence matches with one of the allowed presence configured in the workstream. The check for capacity, skills, and assignment rules will be skipped. If no preferred agents are available for a contact and **Next best agent based on assignment logic** is selected as the fallback option, then the system will try to find a matching agent according to the configured assignment strategy.

### Check diagnostics for routing to preferred agents

If you've turned on routing diagnostics, the work item's diagnostics page will include information about preferred agent routing under **Agent assignment trace**. The **Assignment criteria** section shows whether the setting is turned on. The **Assignment trace** section displays the reason information. More information: [Diagnostics for unified routing](unified-routing-diagnostics.md)

## Update contacts and preferred agents

In the **Preferred agents matrix** section, use the edit and remove options to modify contacts and their preferred agents.

For each contact, you can map a maximum of three agents, but ensure that at least one agent is mapped to the contact.

### Identify contacts in supported channels

To find the preferred agent for an incoming work item, the contact should be identified. For supported channels, use the information mentioned in the following table to identify customers as contacts.

|Channel|Customer record|
|-------|---------------|
|Record |<ul><li>**Case**: Use the **Customer** field to store the contact ID.</li><li>**Email, phone, fax, letter, appointment**: Use the **Regarding** field to store the contact ID. </li></ul>|
|**Digital messaging**: Chat, voice, and other channels|<ul><li> **Chat**: [Authenticated users are automatically identified as contacts](record-identification-rule.md). For unauthenticated users, use the pre-conversation survey to set the survey question name as **Name**.</li><li>**Voice**: Authenticated with the phone number.</li><li>Other channels: [Social profiles](supported-channels-social-profiles.md). </li></ul> |

### Add multiple preferred agent records

You can add multiple preferred agents to contact records at a time using the [createRecord](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-webapi/createrecord) call to update the preferred agent entities,  [msdyn_preferredagent](developer/reference/entities/msdyn_preferredagent.md) and [msdyn_preferredagentcustomeridentity](developer/reference/entities/msdyn_preferredagentcustomeridentity.md).

If you want to add multiple preferred agent routing records through the script, ensure that you map only three unique agents to a contact. If you add more than three agents, though the application displays all the mapped agents, work items are routed only to the top three agents. Agents are ordered based on the preference rating. If agents have the same preference rating, the application orders the agents based on the record creation timestamp.

You can also update or delete records using the [updateRecord](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-webapi/updaterecord) or [deleteRecord](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-webapi/deleterecord) calls.

> [!IMPORTANT]
> We recommend that you add the contact and preferred agent routing through the Preferred agent routing page.

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Configure queues](queues-omnichannel.md)  
[Blog: Use preferred agent routing to create lifelong customer relationships](https://cloudblogs.microsoft.com/dynamics365/it/2022/09/06/use-preferred-agent-routing-to-create-lifelong-customer-relationships/)
