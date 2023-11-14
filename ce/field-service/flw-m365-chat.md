---
title: Microsoft 365 Chat for Field Service (preview)
description: Learn about Microsoft 365 Chat in Dynamics 365 Field Service (Preview).
ms.date: 11/13/2023
ms.topic: overview
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Microsoft 365 Chat for Dynamics 365 Field Service (preview)

With Microsoft 365 Chat, Dynamics 365 Field Service frontline managers and workers can access key work order information by asking Copilot questions within Microsoft Teams. Users with a Microsoft 365 Copilot license can simply state in chat what they need using natural language to receive specific information related to their work orders in Field Service. Microsoft 365 Chat for work orders in Field Service is available for public preview in December 2023.

This feature adheres to [responsible AI guidelines](faqs-m365-chat.md).

## Scenarios that are available out-of-the-box

Ask any straight-forward question about Field Service work orders. Ambiguous questions such as “What are the most important work orders” might not return results.

Be specific about the expected outcomes. For example, if you want results in table format, then use the phrase "in table format." If you want a consolidated result or summary, be specific. For example, "What is the incident type and service account for work order 00041?"

### Scenario 1: Can you give me details of work order 00002, 00003, 00004, 00005, 00006, 00007 00008 in table format?

:::image type="content" source="media/fsp-m365-chat-work-orders-table.png" alt-text="Screenshot of Microsoft 365 Chat asking for details on several work orders in table format.":::

### Scenario 2: What are the details for work order 00020?

:::image type="content" source="media/fsp-m365-chat-work-order-20.png" alt-text="Screenshot of Microsoft 365 Chat asking for details on work order 00020.":::

### Scenario 3: Can you summarize?

:::image type="content" source="media/fsp-m365-chat-summarize.png" alt-text="Screenshot of Microsoft 365 Chat asking for a summary of work order 00020.":::

### Scenario 4: What is the incident type and service account of work orders 00041, 00042, 00043, 00044, 00045, 00046, 00047 in table format?

:::image type="content" source="media/fsp-m365-chat-incident-type.png" alt-text="Screenshot of Microsoft 365 Chat asking for incident type and service account for several work orders.":::

### Scenario 5: What is the status of work order 00030?

:::image type="content" source="media/fsp-m365-chat-status-work-order-30.png" alt-text="Screenshot of Microsoft 365 Chat asking for the status of work order 00030.":::

### Scenario 6: What is work order 00025? Who is the technician for work order 00028?

:::image type="content" source="media/fsp-m365-chat-wo-and-technician.png" alt-text="Screenshot of Microsoft 365 Chat asking about work order 00025 and who is the technician for work order 00028.":::

### Scenario 7: What is the work order assigned to Margie's Travels?

:::image type="content" source="media/fsp-m365-chat-wo-assigned-margie.png" alt-text="Screenshot of Microsoft 365 Chat asking what work order assigned to Margie.":::

### Scenario 8: What is the progress of work order 00036?

:::image type="content" source="media/fsp-m365-chat-progress-wo-36.png" alt-text="Screenshot of Microsoft 365 Chat asking about the progress of work order 00036.":::

### More sample questions

- What is the work order assigned to technician \<email address\>?
- What type of work order is work order \<work order number\>, so I can assign the right technician?
- Show me bookings for next week in a table format
- Show work orders that are scheduled for next week in a table format
- Show me a table of work orders created in the last three days
- Show me work orders created in October for customer \<name\>
- Show me high priority work orders created in October
- Does customer \<name\> have any emergency priority work orders?

## Set up Microsoft 365 Chat for Field Service work orders (admin)

As an admin, set up Microsoft 365 Chat for Field Service work orders for your users.

1. Log into the [Microsoft 365 admin center](https://admin.microsoft.com/).

1. Obtain the appropriate number of [Microsoft 365 Copilot licenses.](/microsoft-365-copilot/microsoft-365-copilot-setup#manage-licenses-for-copilot)

1. [Set up the plug-in](/power-virtual-agents/copilot-plugins-overview).

## Enable the Microsoft 365 Chat for Field Service work orders

Once an admin sets up the Microsoft 365 Chat for Field Service work orders, you can quickly enable the Chat in Teams.

1. At the bottom of your Teams window, select the **Plug-in** :::image type="icon" source="media/fsp-plugin-icon.png"::: icon.

1. Enable the Field Service Copilot plug-in.

The Microsoft 365 Chat for Field Service work orders is available.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
