---
title: Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)
description: Learn about the Dynamics 365 Field Service Plugin for Microsoft Copilot including the types of questions you can ask.
ms.date: 11/30/2023
ms.topic: overview
author: KishorIoT
ms.author: nandab
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

With the Dynamics 365 Field Service Plugin for Microsoft Copilot, Dynamics 365 Field Service frontline managers and workers can access key work order information by asking Microsoft Copilot questions within Microsoft Teams. Users with a Microsoft 365 Copilot license can simply state in chat what they need using natural language to receive specific information related to their work orders in Field Service.

This feature adheres to [responsible AI guidelines](faqs-m365-chat.md).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## What do you want to know about work orders?

Ask any straight-forward question about Field Service work orders. Ambiguous questions such as “What are the most important work orders” might not return results as "most important" is not a defined status. Instead, ask "What are the high priority work orders?"

Be specific about the expected outcomes. For example, if you want results in table format, then use the phrase "in table format." If you want a consolidated result or summary, be specific. For example, "What is the incident type and service account for work order 00041?"

## Frontline managers and dispatchers

### Get summarized information about key work orders that are important to you

   :::image type="content" source="media/fsp-m365-chat-flm1.png" alt-text="Microsoft Copilot chat showing work orders in progress in a table format":::

### Ask for detailed work order information

   :::image type="content" source="media/fsp-m365-chat-flm2.png" alt-text="Microsoft Copilot chat showing the status of a work order and details of another work order":::

### More sample questions

- Show me work orders created in October for customer {name}.
- Can you give me details on {several work order numbers} in a table format?
- What are the details for work order {work order number}? Can you summarize?
- What is the incident type and service account of {several work order numbers} in table format?
- What is the progress of {work order number}?
- What type of work order is {work order number}, so I can assign the right technician?
- Who is the technician for {work order number}? or What is the {work order number} assigned to technician {email_address}?
- Show me bookings for next week in a table format.
- Show me high priority work orders created in November.
- Does customer {name} have any emergency priority work orders?

## Frontline workers

### Get information about your work orders

   :::image type="content" source="media/fsp-m365-chat-flw.png" alt-text="Microsoft Copilot chat showing the address of a work order and the type of another work order":::

### More sample questions

- What are the details for {work order number}? Can you summarize?
- Give me the full details for my most recent work order.
- Are there any work orders with priority set to high?
- Tell me more about the primary incident type of {work order number}.
- Show my work orders that are scheduled for next week in a table format.
- What is the price list for {work order number}?

<!--- Additional questions 
- what are the 3 most recently created work orders
- give me the full details for the most recent work orders
- what are the most recently created work orders?
- Show me a table of the most recent high priority work orders
- Are there any work orders with priority set to high?
- What is the work order assigned to this account?
- Show me a table of work orders created in the last three days
--->

## Next steps

- [Set up Microsoft Copilot for Field Service work orders (admin)](flw-copilot-setup.md)
- [FAQ about Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)](faqs-m365-chat.md)