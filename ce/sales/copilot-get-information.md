---
title: Get information from Copilot
description: Learn how to use Copilot in Dynamics 365 Sales to get information about your pipeline, summarize leads and opportunities, and get the latest news about your accounts.
ms.date: 10/07/2024
ms.topic: how-to
ms.service: dynamics-365-sales
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
---

# Get information from Copilot

Use Copilot to get information about your pipeline, summarize your opportunities and leads, and get the latest news about your accounts. You can either use predefined prompts or ask questions in natural language. This article describes some of the prompts you can use to get information from Copilot. [Learn more about chatting with Copilot in natural language](use-sales-copilot.md#chat-with-copilot-in-NL).

## Show my pipeline

Copilot can provide a list of open opportunities assigned to you, sorted by the estimated close date.

[Open Copilot](use-sales-copilot.md#open-copilot), select **View Prompts** above the Copilot chat box, select **Get info** > **Show my pipeline**, and select **Enter**.

## Summarize an account

> [!IMPORTANT]
> The Account summary feature is an early access feature. So, this feature is available only if your administrator has [opted in to early access updates](/power-platform/admin/opt-in-early-access-updates).

Open [Copilot in a side pane](use-sales-copilot.md#open-copilot-sidepane). Open an account and have Copilot automatically summarize it for you. Alternatively, you can type **Summarize account /** from anywhere in the app or from the [Copilot full-screen view](use-sales-copilot.md#open-copilot-immersive) to ask Copilot to summarize a specific account.
 
:::image type="content" source="media/copilot-account-summary.png" alt-text="Screenshot of a Copilot account summary.":::

The account summary includes the following information:

- **Basic information**: The basic information of the account includes annual revenue, number of employees, country/region, and parent account. If this information is available in the respective fields of the account record, it's displayed in the summary; otherwise, the field isn't displayed.
- **Key information**: The key information includes details on how long the account is associated with your organization, its domain, the total value of closed opportunities, the most recently closed opportunity, most recent activity, and other AI-generated information.  
- **Related leads, opportunities, and cases**: All the open leads, opportunities, and cases that are associated with the account are displayed. Listed records are the ones that you have read access to. A maximum of 10 records are displayed for each section. 
    Select the section to view the details of the associated records. To summarize a specific lead, opportunity, or case, hover over the record and select **Summarize**. For cases to display, your organization must have the Dynamics 365 Customer Service app enabled.

> [!NOTE]
> Administrators can configure the fields that generate summaries and related information for the account summary view. More information: [Configure fields for generating summaries and recent changes list](copilot-configure-summary-fields.md).

Further, you can drill down into the details associated with the account, select the suggested prompts displayed below the account summary. The **Find relevant Sales Navigator accounts** prompt appears if you have the LinkedIn Sales Navigator license. Select the prompt to open the relevant LinkedIn Sales Navigator accounts associated with the account.

## Summarize an opportunity

Open [Copilot in a side pane](use-sales-copilot.md#open-copilot-sidepane). Open an opportunity and have Copilot automatically summarize it for you. Alternatively, you can type **Summarize opportunity /** from anywhere in the app or from the [Copilot full-screen view](use-sales-copilot.md#open-copilot-immersive) to ask Copilot to summarize a specific opportunity.

The opportunity summary is displayed as shown in the following image:

:::image type="content" source="media/copilot-opportunity-summary.png" alt-text="Screenshot of a Copilot opportunity summary.":::

The opportunity summary includes the following information:

- **Basic information**: The basic information of the opportunity includes estimated revenue, estimated close date, key contact of the opportunity, and account name. If this information is available in the respective fields of the opportunity record, it's displayed in the summary; otherwise, the field isn't displayed.
- **Key information**: The key information includes details on how long the account is associated with your organization, the total value of closed opportunities, the most recently closed opportunity, progress of the most recent opportunity, contact name of the account with the most opportunities, and other AI-generated information.  
- **Product, quote, and competitor insights**:
  - The **Product insights** section All the products associated with the opportunity are displayed along with the budget and estimated revenue.  
  - The **Quote insights** section displays the number of quotes that are shared with the opportunity along with the date of the most recent quote.  
  - The **Competitor insights** section displays the competitors associated with the opportunity along with the strengths and weaknesses of the competitors.  

The information is displayed in these sections are based on the fields configured by the administrator for generating summaries. More information: [Configure fields for generating summaries and recent changes list](copilot-configure-summary-fields.md).

> [!NOTE]
> To understand the default attributes used to generate summaries in Copilot in Dynamics 365 Sales, see [opportunity summary default attributes](understand-copilot-summaries.md#opportunity-summary).

### View opportunity summary widget

By default, when you open an opportunity, the opportunity summary widget is displayed in the **Opportunity** form, above the **Up next** widget. The widget displays insights of the opportunity similar to [the opportunity summary](#summarize-an-opportunity) displayed in the Copilot side pane or page.  

:::image type="content" source="media/copilot-opportunity-summary-widget.png" alt-text="Screenshot of a Copilot opportunity summary widget.":::

If you don't see the opportunity summary widget in the **Opportunity** form, contact your administrator to [enable it](copilot-configure-summary-fields.md#admin-opportunity-summary-widget). 

## Summarize a lead

Open [Copilot in a side pane](use-sales-copilot.md#open-copilot-sidepane). Open a lead and have Copilot automatically summarize it for you. Alternatively, you can type **Summarize lead /** from anywhere in the app or from the [Copilot full-screen view](use-sales-copilot.md#open-copilot-immersive) to ask Copilot to summarize a specific lead.

The lead summary is also available as an embedded experience after you qualify a lead. [Learn more about the embedded lead summary](qualify-lead-convert-opportunity-sales.md#lead-summary).

## Would you like to view a summary of different fields?

Copilot generates the summary from a set of predefined fields. Other fields might be more important to you, however. For example, estimated revenue, close date, contact, pipeline stage, and proposed solution might be the first things you look for in an opportunity. Work with your Dynamics 365 Sales administrator to [add those fields to the configuration](copilot-configure-summary-fields.md).

Keep in mind that the summary fields are configured at the organization level. Make sure that your entire sales team agrees on the **top 15** fields that are most relevant for your business.

### Enrich leads with related information

Copilot can enrich your leads with information from Dynamics 365 Sales, LinkedIn, and Bing, such as:

- Possible contacts based on the lead's email address.

- The latest news about the account, curated by Bing.

- Suggested LinkedIn profiles for the contact, if you have the LinkedIn Sales Navigator license.

After you select a lead, Copilot suggests other records that might be associated with the lead and from which it can glean more information.

1. [Ask Copilot to summarize a lead](#summarize-a-lead).

    If Copilot finds possible matching contact records, it lists them after the summary. [How does Copilot match leads with contacts and can I customize the matching fields?](sales-copilot-faq.md#how-does-copilot-match-leads-with-contacts-and-can-i-customize-the-matching-fields)

1. Select **Connect** to connect the lead with a matching record.

    :::image type="content" source="media/copilot-lead-enrichment.png" alt-text="Screenshot of a lead card in the Copilot chat, with a matching account highlighted.":::

1. After Copilot connects the records, select **Get updated lead summary** to generate a new summary that includes information from the connected record.

    Copilot also lists the fields that can be updated with information from the connected record, such as the city, state, phone numbers, and postal code.

1. To update the lead record with the suggested values, select **Update all**.

<a name="copilot-doc-summarization"></a>
## Summarize proposals or sales documents

You might often have documents such as proposals and contracts associated with your records. Copilot can summarize the content of these documents and help you understand the key points. For example, you can ask Copilot to summarize a proposal document to understand the budget, authority (decision maker), need, and timeline (BANT) of the opportunity.

> [!NOTE]
>- Currently, Copilot can summarize only PDF and Word documents.
>- Your administrator can [configure the SharePoint location](copilot-sharepoint-config.md) where your sales documents stored. Otherwise, Copilot searches all the SharePoint folders that you have access to.

1. [Open Copilot](use-sales-copilot.md#open-copilot).  

1. (Optional) Open a record to summarize a document associated with it.
1. Select **View Prompts** above the Copilot chat box, select **Get info** > **Summarize file** and then type "/" to search for a document. You can also type **Summarize file /** or **Summarize document /**.
    If you opened a record, a list of documents attached to the **Files** tab of the record is displayed. Otherwise, Copilot lists the top 15 documents you recently opened in SharePoint.

1. Search for the document you want to summarize by typing the filename, extension, or keywords in the document. A minimum of three characters is required to start the search.

   The search operation starts with the documents in the list first and then searches for documents that meet the following criteria:
  
    - Documents in the SharePoint folders configured by your administrator.
    - Documents that you have access to.

    For example,
    - Enter **Summarize file /contract** to get a list of documents that has **contract** in the file name or content of the document.
    - Enter **Summarize file /pdf** to get a list of documents that has **pdf** in the file name, extension, or content of the document.

   Depending on the size of the document, it might take a few seconds to summarize the document.

> [!NOTE]
> Copilot in Dynamics 365 Sales can summarize only sales documents such as proposals, contracts, and other sales-related documents. If you select a non-sales document, Copilot returns a message stating the same. [How does Copilot determine if a document is a sales document?](sales-copilot-faq.md#how-does-copilot-determine-if-a-document-is-a-sales-document).


## Show the latest news about an account

Copilot can get the latest news that features or mentions your accounts, curated by Bing. These news articles can be great conversation starters and help you understand the dynamics in your customers' organizations.

As always when you're working with AI-sourced content, read articles thoroughly to confirm they're from authentic sources and are indeed about your customer.

1. [Open Copilot](use-sales-copilot.md#open-copilot).

1. Select **View Prompts** above the Copilot chat box, select **Get info** > **Get latest news for account**, and select Enter.

    - If you have a record open, Copilot lists the news articles related to that account.
    - If you're in the grid view, Copilot lists news articles for the top 10 accounts you work with, sorted by the revenue associated with them.

1. To get the news articles for a specific account, type **/** and then start typing the name of the account.

## Related information

- [Copilot overview](copilot-overview.md)
- [Copilot prompt guide reference](copilot-prompt-guide.md)
- [Enable and set up Copilot](enable-setup-copilot.md)
- [Chat with Copilot in natural language](use-sales-copilot.md#chat-with-copilot-in-NL)
- [Get content recommendations from SharePoint](copilot-get-doc-suggestions.md#copilot-content-recommendation)
