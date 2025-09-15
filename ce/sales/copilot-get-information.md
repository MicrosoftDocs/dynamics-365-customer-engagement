---
title: Get information from Copilot
description: Learn how to use Copilot in Dynamics 365 Sales to get information about your pipeline, summarize leads and opportunities, and get the latest news about your accounts.
ms.date: 09/12/2025
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/04/2023
  - bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
---

# Get information from Copilot

Use Copilot to get information about your pipeline, summarize your opportunities, leads, and accounts, and get the latest news about your accounts. You can either use predefined prompts or ask questions in natural language. This article describes some of the prompts that you can use to get information from Copilot. [Learn more about chatting with Copilot in natural language](use-sales-copilot.md#chat-with-copilot-in-NL).

<a name="copilot-show-pipeline"></a>
## Show my pipeline

Copilot can provide a list of open opportunities that are assigned to you, sorted by the estimated close date.

1. [Open Copilot](use-sales-copilot.md#open-copilot), and then select **View Prompts** above the Copilot chat box.

1. Select **Get info** > **Show my pipeline**, and then press Enter.

<a name="copilot-doc-summarization"></a>
## Summarize proposals or sales documents

Your records might have sales documents, such as proposals and contracts, associated with them. Copilot can summarize the content of these documents to help you understand their key points. For example, you can ask Copilot to summarize a proposal document to understand the budget, authority (decision maker), need, and timeline (BANT) of the opportunity.

Copilot can summarize only PDF and Word files that it determines are related to sales based on their content length, document type, and use of sales-specific keywords. Learn more in [How does Copilot determine if a document is a sales document?](sales-copilot-faq.md#how-does-copilot-determine-if-a-document-is-a-sales-document).

Copilot searches all the SharePoint folders that you have access to unless your administrator [configures Copilot to use specific SharePoint folders](copilot-sharepoint-config.md).

Watch this video to learn how to summarize a document with Copilot:

> [!VIDEO https://www.youtube.com/embed/x0gNwIvDOAA]

1. [Open Copilot](use-sales-copilot.md#open-copilot).

1. (Optional) Open a record to summarize a document that's associated with it.

1. Select **View Prompts** above the Copilot chat box, select **Get info** > **Summarize file**, and then type a slash (**/**) to search for a document.

    Alternatively, type **Summarize file /** or **Summarize document /** in the chat box.

    If you opened a record, a list of documents attached to the **Files** tab of the record is displayed. Otherwise, Copilot lists the 15 documents you most recently opened in SharePoint.

1. To search for the document that you want to summarize, type the file name, extension, or keywords found in the document. A minimum of three characters is required to start the search.

The search operation starts with the documents in the list, and then continues with documents that meet the following criteria:

- Documents that are in the SharePoint folders that your administrator tells Copilot to search.
- Documents that you have access to.

For example, to get a list of files that have "contract" in their name or content, enter **Summarize file /contract**. To get a list of files that have "pdf" in their name, extension, or content, enter **Summarize file /pdf**.

Depending on the size of the file, it might take Copilot a few seconds to summarize the content.

## Would you like to view a summary of different fields?

Copilot generates its summary from a set of predefined fields. Other fields might be more important to you, however. For example, estimated revenue, close date, contact, pipeline stage, and proposed solution might be the first things you look for in an opportunity. Work with your Dynamics 365 Sales administrator to [add those fields to the summary](copilot-configure-summary-fields.md).

Keep in mind that the summary fields are set at the organization level. Make sure that your entire sales team agrees on the *top 15* fields that are most relevant for your business.

<a name="copilot-get-news"></a>

## Show the latest news about an account

Copilot can get the latest news that features or mentions your accounts, curated by Bing. These news articles can be great conversation starters and help you understand the dynamics in your customers' organizations.

The latest news feature is available only if the following conditions are met:  

- Your admin has provided consent for Copilot to use Bing search. Learn more in [provide consent for Copilot to use Bing search](/power-platform/admin/geographical-availability-copilot#regions-involved-with-copilots-and-generative-ai-features).  
- You haven't turned off the Bing search. Learn more in [Turn off Bing search](use-sales-copilot.md#turn-off-bing-search)

As always when you're working with AI-sourced content, read articles thoroughly to confirm they're from authentic sources and are indeed about your customer.

1. [Open Copilot](use-sales-copilot.md#open-copilot).

1. Select **View Prompts** above the Copilot chat box, select **Get info** > **Get latest news for account**, and then press Enter.

    - If you have a record open, Copilot lists the news articles that are related to that account.
    - If you're in the grid view, Copilot lists news articles for the top 10 accounts you work with, ordered by their associated revenue.

1. To get the news articles for a specific account, type a slash (**/**) and then start typing the name of the account.

## Related information

- [Copilot overview](copilot-overview.md)
- [Copilot prompt guide reference](copilot-prompt-guide.md)
- [Enable and set up Copilot](enable-setup-copilot.md)
- [Chat with Copilot in natural language](use-sales-copilot.md#chat-with-copilot-in-NL)
- [Get content recommendations from SharePoint](copilot-get-doc-suggestions.md#copilot-content-recommendation)
