---
title: Ask questions of Copilot in Dynamics 365 Sales
description: Learn how to use Copilot to summarize sales records, catch up on recent changes, prepare for meetings, answer questions, and so on. 
ms.date: 10/03/2024
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
 - AI-contribution
ms.custom:
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:10/04/2023
 - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Ask questions of Copilot in Dynamics 365 Sales

Copilot is an AI assistant that helps you be more productive and efficient in your daily work in Dynamics 365 Sales apps. Copilot can summarize information about your leads and opportunities, help you catch up on recent changes to your records, prepare for meetings, and enrich your leads with information from other sources.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [Any primary sales role, such as Salesperson or Sales Manager](security-roles-for-sales.md#primary-sales-roles) |

## Prerequisites

Your admin [turns on and sets up Copilot](enable-setup-copilot.md).

## Open Copilot

You can open Copilot in a [side pane](#open-copilot-sidepane)&mdash;side-by-side with a record such as an opportunity or a lead&mdash;or in a [full-screen view](#open-copilot-immersive).

<a name=open-copilot-sidepane></a>

### Chat with Copilot in a side pane

Open the Copilot side pane when you want to get quick insights about a record or ask Copilot to summarize other records, display recent changes, and prepare for meetings without leaving the current page.

1. Select the **Copilot** icon (:::image type="icon" source="media/copilot-icon.svg" border="false":::) on the right side of your app. You can open the **Copilot** side pane from any page in your app except for the **Copilot** page.

1. Do one of the following:
    - Enter your questions in [natural language](#chat-with-copilot-in-NL).
    - Select a prompt from the suggestion list or select **View Prompts** above the Copilot chat box,  to get a list of suggested requests, or *prompts*, that Copilot can help you with. [Learn more about predefined prompts](copilot-prompt-guide.md).
    :::image type="content" source="media/view-prompts.png" alt-text="Screenshot for the Prompt guide from the side pane.":::

<a name=open-copilot-immersive></a>

### Chat with Copilot in full-screen view (preview)

[!INCLUDE [preview-banner-section](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Open the Copilot page in a full-screen view when you want more space and focus to chat with Copilot and ask questions. 

1. Select **Copilot** in your site map.

   If it isn't there, ask your admin to [turn on Copilot preview features](copilot-preview-features.md#turn-on-all-copilot-preview-features). If you're using a custom app, ask your admin to [add the Copilot page to your app's site map](enable-setup-copilot.md#add-the-copilot-page-site-map-entry-to-custom-sales-app).

2. Do one of the following:
    - Enter your questions in [natural language](#chat-with-copilot-in-NL).
    - Select a prompt from the suggestion list or Select **View Prompts** above the Copilot chat box to get a list of suggested requests, or *prompts*, that Copilot can help you with. [Learn more about predefined prompts](copilot-prompt-guide.md).

    :::image type="content" source="media/copilot-immersive.png" alt-text="Screenshot of the Copilot page showing suggested requests, with the Copilot icons in the left and right side panes highlighted.":::

<a name=chat-with-copilot-in-NL></a>

## Natural language chat

When you chat with Copilot in natural language, Copilot looks for answers in the data stored in Dataverse (the underlying data platform) first. If the answer isn't available in Dataverse, Copilot displays a follow-up prompt to search for the answer in SharePoint.

You can use the following types of questions:

- **Data-based questions:** Straightforward data requests such as:

  - What's Contoso's annual revenue?

  - Who is the owner of Alpine Ski House?
  - Show me all my opportunities that are closing this month.

For more such questions, see [Questions about sales data](faqs-sales-copilot-natural-language.md#questions-about-sales-data).

- **Questions with sales-specific terminology:** Questions that are based on terms specific to Sales organizations. By default, questions around the following topics are supported:

  - **Conversion rates**. For example, what is my lead conversion rate for the last quarter?

  - **Deal cycle**. For example, what is the average deal cycle for my opportunities?
  - **Pipeline with filters**. For example, show my pipeline with deals closing in next 30 days.
  - **Deal sizes and values**. For example, display open deals with deal size greater than 10000.
  
For a list of sample questions, see [Questions with sales-specific terminology](faqs-sales-copilot-natural-language.md#questions-with-sales-specific-terminology). If your organization uses a different sales terminology, reach out to your Dynamics 365 admin to add those terms to the glossary. The glossary helps Copilot understand the context of your questions better. Learn more in [placeholder].

These questions are first answered using the data stored in Dataverse, which is the underlying data platform for Dynamics 365 Sales. If the answer isn't available in Dataverse, Copilot displays a follow-up prompt to search for the answer in SharePoint.  

You can also access some of these question from the Prompt guide that appears when you select **View Prompts** above the chat box in the Copilot side pane or Copilot page.

## Enhance Natural language chat (Public Preview) 
You can enhance your Copilot chat by adding a glossary to make it more personalized and useful. Define your own acronyms, guide Copilot to use custom fields, clarify ownership, and more! 
### Add Glossary for Copilot in side pane 
By providing extra information for the AI to understand and interpret the information in the tables, you increase the likelihood of the AI to recognize your customized requests, and return responses based on the information provided to the AI: 
1. Navigate to copilotstudio.microsoft.com (Note: Please make sure you are selecting the right environment) 
1. Open **Sales Copilot Power Virtual Agents Bot** under agent section 
1. Select **SalesSpecificQnA** under knowledge section 
1. Select **Glossary** section 
1. Enter the term and description and click **Next** 
1. Click **Save**

[Add glossary](media/Natural_chat_Glossary.png "Add glossary")

### Sample term and description
| Scenarios  | Term  | Description |
|-----------------------|---------|-----------------------|
| **Acronym** | VP | ‘VP’ refers to ‘Vice President’ value in ‘JobTitle’ column in ‘Contact’ table |
| **Custom ownership** (Specify your ownership instead of using the record owner id) | activity owner  | activity owner is identified by 'PartyId' column in 'ActivityParty' table.  |
| **Custom field** (Use a custom field instead of the OOB system columns or table) | opportunity revenue  | opportunity revenue refers to ‘custom revenue’ column in ‘opportunity' table  |
| **Complex rules/filter** (Define your tailored rules and guidelines) | overdue task  | ‘overdue task’ refers to ‘state code’ column with value ‘open’ in ‘task’ table and ‘scheduled end date’ column in ‘task’ table with value less than today.  |


## Related information

- [Get information from Copilot](copilot-get-information.md)
- [Ask Copilot about recent changes to your sales records](copilot-ask-questions.md)
- [Stay ahead with Copilot](copilot-stay-ahead.md)
