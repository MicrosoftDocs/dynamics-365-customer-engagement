---
title: Dynamics 365 Field Service Plugin for Microsoft Copilot
description: Learn about the Dynamics 365 Field Service Plugin for Microsoft Copilot including the types of questions you can ask.
ms.date: 11/22/2023
ms.topic: overview
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Dynamics 365 Field Service Plugin for Microsoft Copilot

With the Dynamics 365 Field Service Plugin for Microsoft Copilot, Dynamics 365 Field Service frontline managers and workers can access key work order information by asking Microsoft Copilot questions within Microsoft Teams. Users with a Microsoft 365 Copilot license can simply state in chat what they need using natural language to receive specific information related to their work orders in Field Service.

This feature adheres to [responsible AI guidelines](faqs-m365-chat.md).

## Scenarios that are available out-of-the-box

Ask any straight-forward question about Field Service work orders. Ambiguous questions such as “What are the most important work orders” might not return results.

Be specific about the expected outcomes. For example, if you want results in table format, then use the phrase "in table format." If you want a consolidated result or summary, be specific. For example, "What is the incident type and service account for work order 00041?"

### Scenario 1: Can you give me details on several work orders in a table format?

:::image type="content" source="media/fsp-m365-chat-work-orders-table.png" alt-text="Screenshot of Microsoft 365 Chat asking for details on several work orders in table format.":::

### Scenario 2: What are the details for a particular work order?

:::image type="content" source="media/fsp-m365-chat-work-order-20.png" alt-text="Screenshot of Microsoft 365 Chat asking for details on work order 00020.":::

### Scenario 3: Can you summarize?

:::image type="content" source="media/fsp-m365-chat-summarize.png" alt-text="Screenshot of Microsoft 365 Chat asking for a summary of work order 00020.":::

### Scenario 4: What is the incident type and service account of several work orders in table format?

:::image type="content" source="media/fsp-m365-chat-incident-type.png" alt-text="Screenshot of Microsoft 365 Chat asking for incident type and service account for several work orders.":::

### Scenario 5: What is the status of a particular work order?

:::image type="content" source="media/fsp-m365-chat-status-work-order-30.png" alt-text="Screenshot of Microsoft 365 Chat asking for the status of work order 00030.":::

### Scenario 6: Who is the technician for a work order?

:::image type="content" source="media/fsp-m365-chat-wo-and-technician.png" alt-text="Screenshot of Microsoft 365 Chat asking about work order 00025 and who is the technician for work order 00028.":::

### Scenario 7: What is the work order assigned to this account?

:::image type="content" source="media/fsp-m365-chat-wo-assigned-margie.png" alt-text="Screenshot of Microsoft 365 Chat asking what work order assigned to Margie.":::

### Scenario 8: What is the progress of a work order?

:::image type="content" source="media/fsp-m365-chat-progress-wo-36.png" alt-text="Screenshot of Microsoft 365 Chat asking about the progress of work order 00036.":::

### More sample questions

<!--- Categorize by persona, scenarios or use cases --->
- What is the work order assigned to technician \<email address\>?
- What type of work order is work order \<work order number\>, so I can assign the right technician?
- Show me bookings for next week in a table format
- Show work orders that are scheduled for next week in a table format
- Show me a table of work orders created in the last three days
- Show me work orders created in October for customer \<name\>
- Show me high priority work orders created in October
- Does customer \<name\> have any emergency priority work orders?
- what are the 3 most recently created work orders
- give me the full details for the most recent work orders
- what are the most recently created work orders?
 
show me a table of the most recent high priority work orders
are there any work orders with priority set to high?
 
Tell me more about the primary incident type of work order 00003.

## Set up Microsoft Copilot for Field Service work orders (admin)

As an admin, set up Microsoft Copilot for Field Service work orders for your users.

1. Log into the [Microsoft 365 admin center](https://admin.microsoft.com/).

1. Obtain the appropriate number of [Microsoft 365 Copilot licenses.](/microsoft-365-copilot/microsoft-365-copilot-setup#manage-licenses-for-copilot)

1. [Set up the plug-in](/power-virtual-agents/copilot-plugins-overview).

## Enable the Microsoft Copilot for Field Service work orders

Once an admin sets up the Microsoft Copilot for Field Service work orders, you can quickly enable the plug-in in Teams.

1. At the bottom of your Teams window, select the **Plug-in** :::image type="icon" source="media/fsp-plugin-icon.png"::: icon.

1. Enable the Field Service Plugin for Microsoft Copilot.

The Microsoft Copilot for Field Service work orders is available.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
