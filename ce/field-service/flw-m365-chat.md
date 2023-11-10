---
title: Microsoft 365 Chat for Field Service (Preview)
description: Learn about Microsoft 365 Chat in Dynamics 365 Field Service (Preview).
ms.date: 11/10/2023
ms.topic: overview
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Microsoft 365 Chat for Field Service (Preview)

With Microsoft 365 Chat, Dynamics 365 Field Service workers can access key work order information by asking Copilot questions within Microsoft Teams. Users with a Microsoft 365 license can simply state in chat what they need using natural language to receive specific information related to their work orders in Field Service. Microsoft 365 Chat for work orders in Field Service is available for public preview in December, 2023.

## Types of data that are supported

Microsoft 365 Chat for work orders in Field Service (Preview) supports structured data from the Field Service work order tables in Dataverse. Structured data in the context of Microsoft Dynamics and the Dataverse system refers to data that is organized into a defined format or schema, allowing for easy storage, access, and management within the database system. Structured data is typically managed in tables and columns.

Unstructured data, which includes free-form text, images, documents, PDFs and other types of content is currently not supported.

## Scenarios that are available out-of-the-box

To engage the Microsoft 365 Chat for work orders in Field Service (Preview), the first question must include “from fieldServicesCopilot”.

For example, what is the incident type and service account of work orders 00041, 00042, 00043, 00044, 00045, 00046, 00047 from fieldServicesCopilot in table format?

:::image type="content" source="media/fsp-m365-chat1.png" alt-text="Screenshot of M365 Chat asking for incident type and service account for several work orders.":::

What is work order 00025? Or who is the technician for work order 00028?

:::image type="content" source="media/fsp-m365-chat2.png" alt-text="Screenshot of M365 Chat asking about a work order and who a technician is for another work order.":::

More example questions: 

- When is work order 00046 scheduled to be completed? 
- What are the details for work order 00018? 
- Can you summarize this for me? 
- Can you give me details on work orders 00010, 00011, 00012, 00015, and 00022 in table format? 
- What is the status of work order 00016? 
- What other work orders has Joseph Price worked on? 
- What is the work order assigned to Caleb? 
- What is the progress of work order 00036? 

Ask any straight-forward question about Field Service work orders. Ambiguous questions such as “What are the most important work orders” might not return results.

# Set up Microsoft 365 Copilot for Field Service work orders


[!INCLUDE[footer-include](../includes/footer-banner.md)]
