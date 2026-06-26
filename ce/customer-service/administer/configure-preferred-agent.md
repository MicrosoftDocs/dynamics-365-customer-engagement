---
title: Configure routing to preferred or previously engaged representatives in Dynamics 365 Contact Center
description: Learn how to configure settings to route work items to preferred or previously engaged representatives in Dynamics 365 Contact Center and Customer Service.
ms.date: 06/25/2026
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.custom: bap-template
---

# Configure routing to preferred or previously engaged representatives

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

> [!NOTE]
> Case information applies to Customer Service only.

For a more personalized experience, route work items from a specific contact to the customer's preferred customer service representatives (service representatives or representatives) or relationship managers.

You can configure contacts and their preferred representatives in Copilot Service admin center. You can map representatives to contacts only. If you don't configure a contact, you can't assign a preferred representative to the contact.

## Prerequisites

- You must have one of the following roles to configure preferred representative routing:
  - **For Customer Service**: CSR Manager
  - **For Dynamics 365 Contact Center**: Omnichannel Administrator

- You must be able to access the [Contact table](../../developer/reference/entities/contact.md).
- If you have a custom role, you must also have access to the [msdyn_preferredagent](../../developer/reference/entities/msdyn_preferredagent.md) and [msdyn_preferredagentcustomeridentity](../../developer/reference/entities/msdyn_preferredagentcustomeridentity.md) tables.
- Ensure that the representatives you want to assign to a contact are members of the queue to which you route work items.

## Configure preferred representative for contacts

1. In the Copilot Service admin center site map, select **Routing**.

1. On the page that appears, select **Manage** next to **Preferred representative routing**.

1. Turn on **Enable preferred representative routing**.

1. Select who should get the work item if the preferred representative is unavailable:

   - **Next best representative based on assignment logic**: The work item is routed based on the assignment rules. Use this option for live chat conversations and voice channel calls.

   - **No one. Let the work remain unassigned in the queue**: The work item remains in the queue until a representative picks it up or you manually assign it to another representative. Use this option for asynchronous channel conversations.

1. Select contacts and their preferred representatives in the **Preferred representatives matrix** area by doing the following steps:

      1. Select **Add a contact** to add a contact.

      1. In **Select a contact**, enter a contact name, and select a value from the dropdown list.

      1. Select **Add user** to map representatives to the contact.

   You can map up to three preferred representatives to a contact. The representatives receive work items in the order in which they're listed if a representative who is listed higher in the order isn't available. You can sort their order by selecting a representative in the list and using the **Move up** or **Move down** option.

1. Save and close.

  :::image type="content" source="../media/preferred-agents-mapped-view.png" alt-text="Screenshot of the Preferred representative routing settings page, showing contacts and their preferred representatives.":::

### How routing to preferred representative works

If a preferred representative exists for a contact, the system tries to automatically assign the conversation to an available preferred representative whose presence matches one of the allowed presences configured in the workstream. The system skips the check for capacity, skills, and assignment rules. If no preferred representatives are available for a contact and **Next best representative based on assignment logic** is set as the fallback option, the system tries to find a matching representative according to the configured assignment strategy.

For contacts who don't have a preferred representative mapped, irrespective of the fallback option selected, the system always assigns them to the best eligible representative available in the queue based on the assignment method.

Routing to preferred representatives works with conversations that are routed through push-based workstreams only.

## Update contacts and preferred representatives

In the **Preferred representatives matrix** section, use the edit and remove options to modify contacts and their preferred representatives.

For each contact, you can map up to three representatives, but ensure that you map at least one to the contact.

### Identify contacts in supported channels

To find the preferred representative for an incoming work item, the contact should be identified. For supported channels, use the information mentioned in the following table to identify customers as contacts.

|Channel|Customer record|
|-------|---------------|
|Record |<ul><li>**Case**: Use the **Customer** field to store the contact ID.</li><li>**Email, phone, fax, letter, appointment**: Use the **Regarding** field to store the contact ID. </li></ul>|
|**Digital messaging**: Chat, voice, and other channels|<ul><li> **Chat**: [Authenticated users are automatically identified as contacts](record-identification-rule.md). For unauthenticated users, use the preconversation survey to set the survey question name as **Name**.</li><li>**Voice**: Authenticated with the phone number.</li><li>Other channels: [Social profiles](../use/supported-channels-social-profiles.md). </li></ul> |

## Assign to a previously engaged or preferred expert by using conversation orchestration playbooks (preview)

[!INCLUDE [preview-banner-section](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

By using historical interaction context, queue membership alignment, and expert availability, you can reconnect customers with experts who already understand their issue. When the previous or preferred expert isn't available, assignments automatically go to the next best qualified expert, so service levels and reliability stay consistent. This capability reduces repeat explanations, speeds up resolution times, and improves customer satisfaction. It helps businesses lower the cost to serve while delivering more consistent, personalized support experiences at scale.

Administrators define assignment logic by using natural language playbooks through conversation orchestration. You can configure the precedence order and the look back period with conditions based on context variables by using playbooks in conversation orchestration. Learn more in [Configure conversation orchestration using AI-powered playbooks (preview)](/dynamics365/contact-center/administer/configure-conversation-orchestration).

You must configure preferred representatives if you want to configure assignment to a preferred expert by using playbooks through conversation orchestration.

> [!IMPORTANT]
> This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature isn't intended for use in making—and shouldn't be used to make—decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This responsibility also includes adequately notifying end users that their communications with representatives might be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their representatives that their communications with end users might be monitored, recorded, or stored.

### How expert assignment works

A decision hierarchy determines expert assignment for returning customers. Admins can change the priority between preferred and previous experts to fit their business needs.

| Default Priority | Expert type       | Description                                        |
|---|---|---|
| 1 | Preferred Expert | Relationship manager or service representative mapped to the contact |
| 2 | Previous Expert  | Expert who handled prior interaction within recency window         |
| 3 | Fallback         | Next best available expert using queue's assignment method         |

**Assignment criteria**

Before assignment, the system validates the following criteria.

| Criteria | Description |
|---|---|
| Presence check | Expert must be in an allowed presence status |
| Queue membership | Expert must be a member of the relevant queue |
| Recency window | Previous interaction must be within configured time period such as 7, 10, or 30 days. The system supports up to 30 days cut off period for the recency window. |

### Assignment scenarios

**Scenario 1**: Preferred expert assignment

This scenario assigns conversations to a designated relationship manager mapped to the customer contact.

**Trigger event**: Conversation is routed to queue

**How expert assignment works**:

1. When a conversation enters the queue, the system checks for a preferred expert mapped to the contact.
1. The system verifies the preferred expert's presence, and queue membership.
1. If all criteria are met, the system assigns the conversation to the preferred expert.

Example configuration

| Customer segment | Assignment action |
|---|---|
| VIP 1 customers | Assign to preferred expert first |
| VIP 2 customers | Assign to preferred expert if previous expert unavailable |
| All other customers | Assign to preferred expert first |

**Scenario 2**: Previous expert assignment

This scenario assigns conversations to an expert who previously interacted with the customer within a configured time window.

**Trigger event**: Conversation is routed to queue

**How it works**

When a conversation enters the queue, the system does as follows:

1. Retrieves the previous experts from the customer's interaction history.
1. Filters by recency window, verifies presence, and queue membership.
1. Assigns the conversation to the previous expert if all criteria are met.

Example configuration

| Customer segment | Recency window |
|---|---|
| VIP 1 customers | 10 days |
| VIP 2 customers | 20 days |
| All other customers | 7 days |

**Scenario 3**: Fallback assignment

This scenario assigns conversations to the next best available expert when neither preferred nor previous experts are available.

**Trigger event**: Preferred and previous experts are unavailable

**How it works**

The system runs as follows:

1. Detects that no preferred or previous expert is available or eligible.

1. Invokes the queue's configured assignment method.
1. Assigns the conversation to the next best available expert.

**Example scenario**: Returning customer assignment

**Playbook**: "For all customers, first assign conversations to a preferred expert mapped to the contact. If a preferred expert isn't available, assign the conversation to a previous expert who interacted with the customer in the last 10 days. If neither a preferred expert nor a previous expert is available, assign the conversation to the next best available expert in the queue."

**Scenario timeline**:

| Time | Event | Assignment action | Notes |
|---|---|---|---|
| T=0 | Customer A contacts support | Check preferred expert | Customer A is VIP with mapped relationship manager |
| T=1 | Preferred expert found | Verify availability | Relationship manager (Expert X) is online |
| T=2 | Criteria check | Presence: Pass, Queue: Pass | All criteria met |
| T=3 | Assignment | Assign to Expert X | Customer connected to relationship manager |

**Scenario timeline (Fallback)**:

| Time | Event | Assignment action | Notes |
|---|---|---|---|
| T=0 | Customer B contacts support | Check preferred expert | No preferred expert mapped |
| T=1 | Check previous expert | Query interaction history | Customer B spoke to Expert Y 5 days ago |
| T=2 | Previous expert found | Verify availability | Expert Y is offline |
| T=3 | Fallback triggered | Apply queue assignment | Assign to next best available expert |
| T=4 | Assignment | Assign to Expert Z | Customer connected to available expert |

**Key outcomes**:

-	**Context continuity**: Customers reconnect with familiar experts without repeating their issues.
-	**VIP treatment**: High-value customers consistently reach their designated relationship managers.
-	**Operational efficiency**: Reduced handling time due to preserved context.
-	**Fair fallback**: When contextual experts are unavailable, standard routing ensures timely service.

### View diagnostics for preferred and previous expert assignment

You can view the diagnostics information by using a custom query. Learn more in [Sample queries and dashboards](/dynamics365/guidance/resources/conversation-diagnostics-sample-queries#conversation-orchestration).

### Related information

[Overview of unified routing](overview-unified-routing.md)  
[Configure queues](queues-omnichannel.md)  
[Add multiple preferred representative records](../develop/add-multiple-preferred-agent-records.md)  
[Blog: Use preferred representative routing to create lifelong customer relationships](https://cloudblogs.microsoft.com/dynamics365/it/2022/09/06/use-preferred-agent-routing-to-create-lifelong-customer-relationships/)
