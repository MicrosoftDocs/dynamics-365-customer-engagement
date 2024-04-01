---
title: Dynamics 365 Field Service Plugin for Microsoft Copilot
description: Learn about the Dynamics 365 Field Service Plugin for Microsoft Copilot including the types of questions you can ask.
ms.date: 03/18/2024
ms.topic: overview
author: KishorIoT
ms.author: nandab
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
ms.collection: bap-ai-copilot 
---

# Dynamics 365 Field Service Plugin for Microsoft Copilot

With the Dynamics 365 Field Service Plugin for Microsoft Copilot, Dynamics 365 Field Service frontline managers and workers can access key work order information by asking Microsoft Copilot questions within Microsoft Teams. Users with a Microsoft 365 Copilot license can simply state in chat what they need using natural language to receive specific information related to their work orders in Field Service. This feature adheres to [responsible AI guidelines](faqs-m365-chat.md).

Copilot can also parse through a [work order's attachments](flw-teams-manager-setup.md#add-attachments-to-the-work-order) to provide answers to your questions. Frontline managers can upload information pertinent to the work order before a technician is scheduled to arrive. Frontline workers can upload history, common issues, and other information that would help technicians for future work orders.

To access this chat feature, an admin must [set up Microsoft Copilot for Field Service work orders](flw-copilot-setup.md).

## What do you want to know about work orders?

Ask any straight-forward question about Field Service work orders. Ambiguous questions such as "What are the most important work orders" might not return results as "most important" isn't a defined status. Instead, ask "What are the high priority work orders?"

Be specific about the expected outcomes. For example, if you want results in table format, then use the phrase "in table format." If you want a consolidated result or summary, be specific. For example, "What is the incident type and service account for work order 00041?"

## Frontline managers and dispatchers

### Get summarized information about key work orders that are important to you

   :::image type="content" source="media/fsp-m365-chat-flm1.png" alt-text="Microsoft Copilot chat showing work orders in progress in a table format":::

### Ask for detailed work order information

   :::image type="content" source="media/fsp-m365-chat-flm2.png" alt-text="Microsoft Copilot chat showing the status of a work order and details of another work order":::

### More sample questions

- Show me work orders created in October for customer {name}.
- Can you give me details on {several work order numbers} in a table format?
- What are the details for work order {work order number}? Can you summarize? Can you summarize in a paragraph?
- What is the incident type and service account of {several work order numbers} in table format?
- What is the progress of {work order number}?
- What type of work order is {work order number}, so I can assign the right technician?
- Who is the technician for {work order number}? or What is the {work order number} assigned to technician {email_address}?
- Show me bookings for next week in a table format.
- Show me high priority work orders created in November.
- How many work orders?
- How many of these work orders are unscheduled and high priority?
- How many work orders for customer {name} and what is the status?
- Can you find work orders from last week?

## Frontline workers

### Get specific information about a work order

   :::image type="content" source="media/fsp-m365-chat-flw.png" alt-text="Microsoft Copilot chat showing the address of a work order and the type of another work order":::

### Ask for detailed information from documents

   :::image type="content" source="media/fsp-m365-chat-flw.png" alt-text="Microsoft Copilot chat showing the address of a work order and the type of another work order":::

### More sample questions

- How do I handle the battery of the Surface Laptop 4 safely?
- What service tools are required to replace the non-skid foot pad on the Surface laptop?
- How do I remove the non-skid foot pad on the Surface laptop?
- What are the details for {work order number}? Can you summarize? Can you summarize in a paragraph?
- Give me the full details for my most recent work order.
- Are there any work orders with priority set to high?
- Tell me more about the primary incident type of {work order number}.
- Show my work orders that are scheduled for next week in a table format.
- What is the price list for {work order number}?
- How many work orders for customer {name} and what is the status?
- Can you find my work orders from last week?

## Next steps

- [FAQ about Dynamics 365 Field Service Plugin for Microsoft Copilot](faqs-m365-chat.md)
- [Set up Microsoft Copilot for Field Service work orders](flw-copilot-setup.md)