---
title: Copilot in Dynamics 365 Sales overview
description: Learn how to use Copilot in Dynamics 365 Sales to get quick summaries of opportunities and leads, prepare for meetings, compose emails, and stay up-to-date with news.
ms.date: 12/18/2024
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/02/2023
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Copilot in Dynamics 365 Sales overview

Copilot is an AI assistant in Dynamics 365 Sales that helps sales teams be more productive and efficient in their daily work. It has a chat interface that sellers can use to get a quick summary of their opportunity and lead records, catch up on recent changes to their records, prepare for meetings, and read the latest news about their accounts. Sellers can chat with Copilot in natural language or use predefined prompts to get the information they need. [Learn more about how to use Copilot in Dynamics 365 Sales](use-sales-copilot.md)

Copilot is also available as an add-in in Outlook and an integrated app in Teams. With it, sellers can capture, view, and update their customer account data in the apps they use every day. The add-in and Teams app have generative AI capabilities such as record summarization and email content generation. Learn more about [Microsoft 365 Copilot for Sales](/microsoft-sales-copilot/introduction) and its [generative AI capabilities](/microsoft-sales-copilot/ai-sales-copilot).

Learn more about the licensing requirements for Copilot in Dynamics 365 Sales in the [licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409) and [view the comparison table](https://www.microsoft.com/dynamics-365/products/sales/pricing?market=af#comparison-table) to compare plans.

## Chat in natural language or use predefined prompts

Copilot in Dynamics 365 Sales supports natural language chat. You can ask Copilot questions related to your sales records or sales-specific terms. You can also use predefined prompts to get the information you need. Copilot provides suggestions for prompts based on the context of the record you're viewing. The Prompt guide lists all the predefined prompts that Copilot supports.
  
Learn more: [Ask questions of Copilot in Dynamics 365 Sales](use-sales-copilot.md)  

## Copilot in Dynamics 365 Sales capabilities

Copilot offers the following capabilities:

- [Record summarization](#record-summarization)
- [Recent changes](#recent-changes)
- [Information assistance](#information-assistance)
- [Meeting preparation](#meeting-preparation)
- [Email assistance](#email-assistance)
- [News updates](#news-updates)

### Record summarization

Record summarization gives you a quick summary of your opportunity, lead, and account records. Copilot generates the summary from predefined fields. Your administrator can change the fields that Copilot uses to generate the summary. Ensure that your entire sales team agrees on the top 10 fields that are most relevant for your business.

Learn more:

- [Summarize an account](copilot-get-information.md#summarize-an-account)
- [Summarize an opportunity](copilot-get-information.md#summarize-an-opportunity)
- [Summarize a lead](copilot-get-information.md#summarize-a-lead)
- [Change the fields in the record summary](copilot-configure-summary-fields.md)

## Embedded experiences

Use Copilot's embedded experience in Dynamics 365 Sales to quickly gain insights into your records, including:

- [Embedded opportunity summary in the opportunity form](copilot-get-information.md#view-the-opportunity-summary-widget).
- [Embedded lead summary after lead qualification](qualify-lead-convert-opportunity-sales.md#lead-summary).

### Recent changes

To help you stay on top of your sales records, Copilot summarizes any changes that were made to your lead, opportunity, and account records. Copilot generates the list of recent changes from the records' audit history. Your administrator can change the fields that are included in the recent changes list. Ensure that your entire sales team agrees on the top 15 fields that are most relevant for your business.

Learn more:

- [View recent changes of your records](copilot-ask-questions.md#get-recent-changes)
- [Get a list of recently updated sales records](copilot-ask-questions.md#whats-new-with-my-sales-records)
- [View the leads and opportunities assigned to you recently](copilot-ask-questions.md#whats-newly-assigned-to-me)
- [Change the fields you want to view in the recent changes list](copilot-configure-summary-fields.md)

### Information assistance

With Copilot, you can get information at your fingertips. You don't have to switch between apps to find the information you need. Copilot can get product-related documents and fetch answers to sales-related questions from documents stored in SharePoint.

Learn more:

- [Get content recommendations from SharePoint](copilot-get-doc-suggestions.md#copilot-content-recommendation)
- [Get answers from SharePoint documents](copilot-get-doc-suggestions.md#get-answers-from-sharepoint-documents)

### Meeting preparation

Copilot helps you prepare for your upcoming meetings effortlessly, summarizing relevant information from the opportunity or lead records that are associated with the meeting.

[Learn more about preparing for upcoming sales appointments](copilot-stay-ahead.md#prepare-for-upcoming-sales-appointments).

### Email assistance

Copilot can help you compose professional-looking emails, summarize email conversations to add to your customer notes, and give you reminders to follow up on emails you haven't replied to.

Learn more:

- [Compose and send email messages using Copilot (preview)](compose-send-email-copilot.md)  
- [View and copy an email summary](view-copy-email-summary.md)  
- [Display unanswered emails](copilot-stay-ahead.md#display-unanswered-emails)

### News updates

Copilot can help you stay current with the latest news about your accounts. News updates can be great conversation starters and help you understand the dynamics of your customers' organizations. Ask Copilot to get you the latest news related to an account and it returns a list of articles that feature or mention the account, curated by Bing. As with any content that's provided by AI, make sure you read the news articles thoroughly and confirm that they're from an authentic source and are indeed about the customer.

[Learn how to get the latest news about an account](copilot-get-information.md#show-the-latest-news-about-an-account).

## Region availability and languages supported

Copilot in Dynamics 365 Sales is available in regions and languages listed in the [Copilot international availability report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport). [Learn how to use the report](#how-to-use-the-copilot-international-availability-report).

Copilot takes into account the [user's preferred UI language](/dynamics365/project-operations/environment/language-localization) and localizes responses based on that. Depending on the user's preferred UI language, org language, and languages supported for a specific Copilot feature, the responses are localized accordingly. The following table summarizes the expected behavior in different scenarios:

| Base language of the org | Preferred UI language of the user | Expected behavior                                                                 |
|--------------------------|-----------------------------------|-----------------------------------------------------------------------------------|
| English                  | English                           | Output in English                                                                 |
| English or non-English   | One of the supported non-English languages | Output in the preferred UI language of the user.                                                |
| English or non-English   | An unsupported language     | Output is unpredictable as the language is unsupported. The responses are mixed with English and the user language. We recommend using one of the supported Copilot languages in such cases. |

We're continuously working to expand the availability of Copilot features in more regions and languages. If you don't see your region or language listed in the report, check back later for updates.

### How to use the Copilot international availability report

The [Copilot international availability report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport) includes information about the availability of Copilot in Dynamics 365 Sales features in different regions and languages.

You can filter the [Copilot international availability report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport) by product name, region, and language to know whether a Copilot feature is available in your specific region and language. Alternatively, you can use the report to get a list of Copilot features available in your region and preferred language. The following screenshot illustrates Copilot in Dynamics 365 Sales features available in Europe and are supported in German:

:::image type="content" source="media/international-availability-report.png" alt-text="Screenshot of the international availability report with filters applied." lightbox="media/international-availability-report.png":::

The **Release Wave** column indicates the release wave in which the support is available.
