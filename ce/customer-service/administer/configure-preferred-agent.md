---
title: Configure routing to preferred representatives
description: Learn how to configure settings to route work items to preferred representatives in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
ms.date: 02/19/2026
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---

# Configure routing to preferred representatives

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

> [!NOTE]
> Case information is applicable to Customer Service only.

For a more personalized experience, Dynamics 365 Customer Service gives you the option to route work items from a specific contact to the customer's preferred customer service representatives (service representatives or representatives) or relationship managers.

You can configure contacts and their preferred representatives in the Copilot Service admin center. If a contact isn't configured, then you can't assign a preferred representative to the contact. You can map representatives to contacts only.

## Prerequisites

- You must have one of the following roles to configure preferred representative routing:
  - **For Customer Service**: CSR Manager
  - **For Dynamics 365 Contact Center**: Omnichannel Administrator

- You must be able to access the [Contact table](../../developer/reference/entities/contact.md).
- If you have a custom role, you must also have access to the [msdyn_preferredagent](../../developer/reference/entities/msdyn_preferredagent.md) and [msdyn_preferredagentcustomeridentity](../../developer/reference/entities/msdyn_preferredagentcustomeridentity.md) tables.
- Ensure that the representatives you want to assign to a contact is a member of the queue to which work items are routed.

## Configure preferred representative for contacts

1. In the Copilot Service admin center site map, select **Routing**.

1. On the page that appears, select **Manage** next to **Preferred representative routing**.

1. Turn on **Enable preferred representative routing**.

1. Select who should get the work item if preferred representative is unavailable:

   - **Next best representative based on assignment logic**: The work item is routed based on the assignment rules. We recommend that you use this option for live chat conversations and voice channel calls.

   - **No one. Let the work remain unassigned in the queue**: The work item remains in the queue until a representative picks it up or you manually assign it to another representative. We recommend that you use this option for asynchronous channel conversations.

1. Select contacts and their preferred representatives in the **Preferred representatives matrix** area by doing the following steps:

      1. Select **Add a contact** to add a contact.

      1. In **Select a contact**, enter a contact name, and select a value from the dropdown list.

      1. Select **Add user** to map representatives to the contact.

   You can map up to three preferred representatives to a contact. The representatives receive work items in the order in which they're listed if a representative who is listed higher in the order isn't available. You can sort their order by selecting a representative in the list and using the **Move up** or **Move down** option.

1. Save and close.

  :::image type="content" source="../media/preferred-agents-mapped-view.png" alt-text="Screenshot of the Preferred representative routing settings page, showing contacts and their preferred representatives.":::

## How routing to preferred representative works

If a preferred representative exists for a contact, the system tries to automatically assign the conversation to an available preferred representative whose presence matches with one of the allowed presences configured in the workstream. The system skips the check for capacity, skills, and assignment rules. If no preferred representatives are available for a contact and **Next best representative based on assignment logic** is set as the fallback option, then the system tries to find a matching representative according to the configured assignment strategy.

For contacts who don't have a preferred representative mapped, irrespective of the fallback option selected, the system always assigns them to the best eligible representative available in the queue based on the assignment method.

Routing to preferred representatives works with conversations that are routed through push-based workstreams only.

### Check diagnostics for routing to preferred representatives

If you turned on routing diagnostics, the work item diagnostics page includes information about preferred representative routing under **Agent assignment trace**. The **Assignment criteria** section shows whether the setting is enabled. The **Assignment trace** section displays the reason information. More information: [Diagnostics for unified routing](unified-routing-diagnostics.md)

## Update contacts and preferred representatives

In the **Preferred representatives matrix** section, use the edit and remove options to modify contacts and their preferred representatives.

For each contact, you can map a maximum of three representatives, but ensure that you map at least one to the contact.

### Identify contacts in supported channels

To find the preferred representative for an incoming work item, the contact should be identified. For supported channels, use the information mentioned in the following table to identify customers as contacts.

|Channel|Customer record|
|-------|---------------|
|Record |<ul><li>**Case**: Use the **Customer** field to store the contact ID.</li><li>**Email, phone, fax, letter, appointment**: Use the **Regarding** field to store the contact ID. </li></ul>|
|**Digital messaging**: Chat, voice, and other channels|<ul><li> **Chat**: [Authenticated users are automatically identified as contacts](record-identification-rule.md). For unauthenticated users, use the preconversation survey to set the survey question name as **Name**.</li><li>**Voice**: Authenticated with the phone number.</li><li>Other channels: [Social profiles](../use/supported-channels-social-profiles.md). </li></ul> |

### Related information

[Overview of unified routing](overview-unified-routing.md)  
[Configure queues](queues-omnichannel.md)  
[Add multiple preferred representative records](../develop/add-multiple-preferred-agent-records.md)  
[Blog: Use preferred representative routing to create lifelong customer relationships](https://cloudblogs.microsoft.com/dynamics365/it/2022/09/06/use-preferred-agent-routing-to-create-lifelong-customer-relationships/)
