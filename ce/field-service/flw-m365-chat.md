---
title: Dynamics 365 Field Service Plugin for Microsoft Copilot
description: Learn about the Dynamics 365 Field Service Plugin for Microsoft Copilot including the types of questions you can ask.
ms.date: 11/12/2024
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

Copilot can also search through a work order's attachments to provide answers to questions. Attachments can be knowledge articles, manuals, or any documentation that can assist the technician in completing the work order. Frontline managers must first upload the information relevant to the work order so that Copilot can access the information. Go to [Add attachments to a work order](flw-teams-manager.md#add-attachments-to-a-work-order).

After a frontline manager uploads any relevant information to the work order, frontline workers can quickly get answers such as required tools or step-by-step instructions from Copilot.

To access this chat feature, an admin must [set up Microsoft Copilot for Field Service work orders](flw-copilot-setup.md).

## Best practices

- Ask any straightforward question about Field Service work orders. Ambiguous questions such as "What are the most important work orders" might not return results because "most important" isn't a defined status. Instead, ask "What are the high-priority work orders?"

- Be specific about the expected outcomes. For example, if you want results in table format, then use the phrase "in table format." If you want a consolidated result or summary, be specific. For example, "What is the incident type and service account for work order 00041?"

## Frontline managers and dispatchers

### Get summarized information about key work orders that are important to you

:::image type="content" source="media/fsp-m365-chat-flm1.png" alt-text="Microsoft Copilot chat showing work orders in progress in a table format":::

### Ask for detailed work order information

:::image type="content" source="media/fsp-m365-chat-flm2.png" alt-text="Microsoft Copilot chat showing the status of a work order and details of another work order":::

### More sample questions

- Show me work orders created in October for {customer name}.
- Can you give me details on work orders {several work order numbers} in a table?
- What are the details for work order {work order number}? Can you summarize in a paragraph?
- Can you give me the incident type and service account of work orders {several work order numbers} in table format?
- What is the progress of work order {work order number}?
- What type of work order is {work order number}, so I can assign the right technician?
- Who is the technician for work order {work order number}?
- What is the work order number assigned to {email_address}?
- Show me bookings for next week in a table.
- Show me high priority work orders created in November.
- How many work orders are in progress?
- How many work orders are unscheduled and high priority?
- How many work orders are there for {customer name} and what are their statuses?
- Can you find work orders from last week?

## Frontline workers

### Get specific information about a work order

:::image type="content" source="media/fsp-m365-chat-flw.png" alt-text="Microsoft Copilot chat showing the address of a work order and the type of another work order":::

### Ask for instructions for a work order (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

To ask for information from uploaded attachments such as installation manuals, maintenance documents, or troubleshooting notes, tell Copilot to search through documents.

> [!NOTE]
> Frontline managers must [add documents to the work order timeline or add knowledge articles](flw-teams-manager.md#add-attachments-to-a-work-order) so Copilot can search through them and provide answers.

:::image type="content" source="media/fsp-m365-chat-flw2.png" alt-text="Microsoft Copilot chat showing the list of tools needed for the work order":::

:::image type="content" source="media/fsp-m365-chat-flw3.png" alt-text="Microsoft Copilot chat showing step-by-step instructions for the work order":::

Answers that came from an attachment are listed under **reference** at the bottom of the answer.

### More sample questions

- How do I handle the battery of the Surface laptop safely? Provide a list of recommendations.
- What temperatures are in the Surface laptop battery's operating range?
- How do I separate the C-cover from the Surface laptop?
- What service tools are required to replace the non-skid foot pad on the Surface laptop?
- What are the details for work order {work order number}? Can you summarize?
- Give me the full details for my most recent work order.
- Are there any work orders with priority set to high?
- Tell me more about the primary incident type of work order {work order number}.
- Show my work orders that are scheduled for next week in a table.
- What is the price list for work order {work order number}?
- How many work orders are there for {customer name} and what are their statuses?
- Can you find my work orders from last week?

## Next steps

- [FAQ about Dynamics 365 Field Service Plugin for Microsoft Copilot](faqs-m365-chat.md)
- [Set up Microsoft Copilot for Field Service work orders](flw-copilot-setup.md)
