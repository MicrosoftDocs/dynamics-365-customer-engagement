---
title: FAQ about chat with Sales data on Microsoft 365 Copilot (preview)
description: Discover how to use Microsoft 365 Copilot to chat with Sales data and ask questions in natural language.
ms.date: 11/29/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:11/13/2023
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot 
---

# FAQ about chat with Sales data on Microsoft 365 Copilot (preview)

> [!IMPORTANT]
> Some or all of the functionality noted in this article is available as part of a preview release. The content and the functionality are subject to change.

This article explains how to use Microsoft 365 Copilot to chat with Dynamics 365 Sales data.

A Microsoft 365 Copilot license enables authorized users to engage in a natural-language conversation with Dynamics 365 Sales data. For example, they can ask the following questions:

- Who is the primary contact for Adventure Works?

- What are the opportunities for account Adventure Works?

Microsoft 365 Copilot summarizes the information that is spread across emails, chats, and documents, and reconciles it with the relevant data that resides inside Dataverse. The reconciled summary is presented as the response to the user.

:::image type="content" source="media/m365-copilot.png" alt-text="Screenshot showing chat with Microsoft 365 Copilot.":::

## What types of data are supported?

Data that resides inside tables is referred to as *structured data*. Data that's present in static documents, such as Word files, PDF files, and publicly available content, is referred to as *unstructured data*. Microsoft 365 Copilot supports data inquiries against both structured and unstructured data. 

## What are the scenarios available out-of-the-box?

A user can inquire about Account, Contact, Lead, Opportunity, Quote, Order, and Case tables. 

Example questions: 

- List all accounts

- Who is the primary contact for Adventure Works? 
- what are the opportunities for account Adventure Works?
- What accounts are in address Redmond WA?
- How many opportunities were closed? 
- Give me all the details about Adventure Works account
- Show all opportunities with an estimated value of more than $20,000
- Show top 10 leads 
- Give me the status of Lidman Anna lead?
- When was the Lidman Anna lead created?
- Who is the record owner of Lidman Anna lead?
- What is the company name for contact Nancy Anderson?
- What is the email address of Contact Nancy Anderson?
- Show all leads owned by Amanda Donnelly
- Show all leads owned by Amanda Donnelly. Display as a table, including the record owner and the email address of the lead
- Find all Dynamics 365 Sales contacts named Nancy
- What is the business phone for Nancy Anderson?
- What is the status of contact Nancy Anderson?
- What is the email for account Adventure Works?
- What is the phone number for account Adventure Works?
- What is the address for account Adventure Works?
- What is the opportunity for Jim Glynn?
- Show me the opportunity for Coho Winery?
- Show me all opportunities owned by Amanda Donnelly

## What is happening behind the scenes?

The user's question is translated into a SQL query and run against the Dataverse tables. The results are summarized and presented as the response to the user. The following illustration shows the architecture that works behind the scenes:

:::image type="content" source="media/m365-copilot-architecture.png" alt-text="Architecture diagram depicting how the chat input flows from the user to the Copilot Orchestrator, the skill discovery service, and Dataverse to fetch and summarize the data.":::

## Are we limited to the supported customer scenarios?

No, you aren't limited to the supported customer scenarios. Think of the scenarios as patterns that Microsoft 365 Copilot can process. All Dynamics 365 Sales tables that follow these patterns can be enabled for Microsoft 365 Copilot. 

Microsoft 365 Copilot is available only for en-us language settings. 

## Best practices

When you use Microsoft 365 Copilot to chat with Dynamics 365 Sales data, follow these best practices. These best practices are revised continuously to improve the product experience. 

- Be specific with your question to copilot and avoid ambiguity. If your question is about an account, then use the keyword "account" in your question. For example, don't ask, "Who is the primary contact for Adventure Works?" Instead, ask, "Who is the primary contact for account Adventure Works?"

- Be specific about the expected outcomes. If you want results in table format, then use the key phrase "in table format". If you want a consolidated result or a summary, make sure you call it out explicitly. For example, you can ask, "List all accounts in table format."

- If you know the name or label that is associated with the required data in the Sales app, use that name when you search, to make the search easier. For example, you can ask, "Who is the primary contact for account Adventure Works?". 

- Use letter casing correctly:
    - Use lower case for field or attribute names, like 'primary contact', 'record owner'. Capital cased words are more likely to be treated as literals. 
    - If you're unsure about the spelling about a string literal, try using lower case letters so that spelling correction is more likely to kick in. Words with capital letters are more likely to be treated as special names and might not be spell checked. 
