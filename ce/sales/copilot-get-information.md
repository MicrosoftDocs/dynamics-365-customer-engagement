---
title: Get information from Copilot
description: Learn how to use Copilot in Dynamics 365 Sales to get information about your pipeline, summarize leads and opportunities, and get the latest news about your accounts.
ms.date: 02/14/2025
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

<a name="copilot-summarize-opportunity"></a>

## Summarize an opportunity

Open [Copilot in a side pane](use-sales-copilot.md#chat-with-copilot-in-a-side-pane), and then open an opportunity to have Copilot automatically summarize it for you.

Alternatively, type **Summarize opportunity /** from anywhere in the app or from the [Copilot full-screen view](use-sales-copilot.md#open-copilot-immersive) to ask Copilot to summarize a specific opportunity.

:::image type="content" source="media/copilot-opportunity-summary.png" alt-text="Screenshot of a Copilot opportunity summary in Dynamics 365 Sales.":::

The opportunity summary includes the following information, if the information is available in the opportunity record:

- **Basic information**: Estimated revenue, estimated close date, key contact, and account name.
- **Key information**: How long the account has been associated with your organization, the total value of closed opportunities, the most recently closed opportunity, progress on the most recent opportunity, the contact at the account with the most opportunities, and other AI-generated information.
- **Product insights**: All products that are associated with the opportunity, along with the budget and estimated revenue.
- **Quote insights**: The number of quotes that are shared with the opportunity, along with the date of the most recent quote.
- **Competitor insights**: The competitors that are associated with the opportunity, along with their strengths and weaknesses.

Learn more about the default attributes that Copilot uses to generate summaries in Dynamics 365 Sales in [Default attributes used in Copilot summaries](understand-copilot-summaries.md#opportunity-summary). [Would you like to view a summary of different fields?](copilot-get-information.md#would-you-like-to-view-a-summary-of-different-fields)

### View the opportunity summary widget

By default, when you open an opportunity, the opportunity summary widget is displayed above the **Up next** widget in the **Opportunity** form. It displays insights about the opportunity, similar to [the opportunity summary](#summarize-an-opportunity) that's displayed in the Copilot side pane or page.

:::image type="content" source="media/copilot-opportunity-summary-widget.png" alt-text="Screenshot of the Copilot opportunity summary widget in the Opportunity form.":::

If the opportunity summary widget isn't displayed in the **Opportunity** form, contact your administrator, and ask them to [turn it on](copilot-configure-summary-fields.md#admin-opportunity-summary-widget).

## Summarize a lead <a name="copilot-summarize-lead"></a>

Open [Copilot in a side pane](use-sales-copilot.md#chat-with-copilot-in-a-side-pane), and then open a lead to have Copilot automatically summarize it for you.

Alternatively, type **Summarize lead /** from anywhere in the app or from the [Copilot full-screen view](use-sales-copilot.md#open-copilot-immersive) to ask Copilot to summarize a specific lead.  

:::image type="content" source="media/copilot-lead-summary.png" alt-text="Screenshot of a Copilot lead summary in Dynamics 365 Sales.":::

The lead summary includes the following information, if the information is available in the lead record:

- **Basic information**: Rating, lead source, status reason, and parent account for lead.  
- **Key information**: Follow-up on the latest activity, preferred method of contact, lead creation date, annual revenue, closed opportunities associated with the lead, parent account, primary contact of the parent account associated with the lead, and other AI-generated information.  
- **Competitor insights**: The competitors that are associated with the lead, along with their strengths and weaknesses.  

The lead summary is also available as an embedded experience after you qualify a lead. Learn more in [Qualify and convert a lead to opportunity](qualify-lead-convert-opportunity-sales.md#lead-summary).

### Enrich leads with related information

Copilot can enrich your leads with information from Dynamics 365 Sales, LinkedIn, and Bing, such as:

- Possible contacts based on the lead's email address.
- The latest news about the account, curated by Bing.
- Suggested LinkedIn profiles for the contact, if you have a LinkedIn Sales Navigator license.

After you select a lead, Copilot suggests other records that might be associated with the lead and from which it can glean more information.

1. [Ask Copilot to summarize a lead](#summarize-a-lead-).

    If Copilot finds possible matching contact records based on the lead's email address, it lists them after the summary. Learn more in [How does Copilot match leads with contacts and can I customize the matching fields?](sales-copilot-faq.md#how-does-copilot-match-leads-with-contacts-and-can-i-customize-the-matching-fields).

1. To choose the correct match, select **Connect**.

    :::image type="content" source="media/copilot-lead-enrichment.png" alt-text="Screenshot of a lead card in the Copilot chat, with a matching account highlighted.":::

1. To generate a new summary that includes information from the connected record, select **Get updated lead summary**.

    Copilot also lists the fields that can be updated with information from the connected record, such as the city, state, phone numbers, and postal code.

1. To update the lead record with the suggested values, select **Update all**.

## Summarize an account <a name="copilot-summarize-accounts"></a>

Open [Copilot in a side pane](use-sales-copilot.md#open-copilot-sidepane), and then open an account to have Copilot automatically summarize it for you.

Alternatively, type **Summarize account /** from anywhere in the app or from the [Copilot full-screen view](use-sales-copilot.md#open-copilot-immersive) to ask Copilot to summarize a specific account.

:::image type="content" source="media/copilot-account-summary.png" alt-text="Screenshot of a Copilot account summary in Dynamics 365 Sales.":::

The account summary includes the following information, if the information is available in the account record:

- **Basic information**: Annual revenue, number of employees, country/region, and parent account.
- **Key information**: How long the account has been associated with your organization, its domain, the total value of closed opportunities, the most recently closed opportunity, the most recent activity, and other AI-generated information.  
- **Leads, opportunities, and cases**: Open leads, opportunities, and cases that are associated with the account and that you have read access to. Up to 10 records are displayed in each section. Your organization must have the Dynamics 365 Customer Service app for cases to be displayed.
    Select the section to view the details of the associated records. To summarize a specific lead, opportunity, or case, hover over the record and select **Summarize**.

To drill down into the details of the account, select the suggested prompts that are displayed below the summary. If you have a LinkedIn Sales Navigator license, the **Find relevant Sales Navigator accounts** prompt is also suggested. [Would you like to view a summary of different fields?](copilot-get-information.md#would-you-like-to-view-a-summary-of-different-fields)

## Summarize proposals or sales documents <a name="copilot-doc-summarization"></a>

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

> [!NOTE]
> The latest news feature is available only if your administrator has [provided consent for Copilot to use Bing search](/power-platform/admin/geographical-availability-copilot#regions-involved-with-copilots-and-generative-ai-features).

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
