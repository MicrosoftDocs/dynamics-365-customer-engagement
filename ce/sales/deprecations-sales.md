---
title: Removed or deprecated features in Dynamics 365 Sales
description: Visit this page to see the deprecating features in Dynamics 365 Sales.
ms.date: 01/07/2026
ms.topic: concept-article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-sales
---
# Removed or deprecated features in Dynamics 365 Sales

The features that have been removed or deprecated in  Dynamics 365 Sales are listed in this article. For more information on other deprecations that impact all the Dynamics 365 customer engagement apps, see [Important changes (deprecations) coming in Power Apps, Power Automate, and customer engagement apps](/power-platform/important-changes-coming).

> [!IMPORTANT]
> "Deprecated" means we intend to remove the feature or capability in a major future release. The feature or capability continues to work and is fully supported until it's officially removed. This deprecation notification might span a few years. After removal, the feature or capability will no longer work. We're notifying you now so that you have sufficient time to plan and update your code before the feature or capability is removed.  

## Add chat message to Dynamics 365 record in Microsoft Teams

Effective January 2026, the ability to add chat messages from Microsoft Teams to Dynamics 365 records is deprecated. After the deprecation, you can no longer use the **Add to Dynamics 365** option in Microsoft Teams chat messages to save them to Dynamics 365 records.

<a name="sales-usage-reports"></a>
## Sales usage reports

Effective December 01, 2025, sales usage reports will be deprecated. This means that you can’t access the report to view historical operational metrics and key performance indicators (KPIs) of your contacts, accounts, leads, and opportunities. 

As an alternative, you can [download the sample Power BI report for sales usage reporting](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/sales/SalesUsageReporting/Sales%20Usage%20Reporting%20Sample.pbit) and use it to get insights into sales activities and performance metrics. The sample report is only provided to facilitate the transition. You can customize and maintain it to suit your needs. Microsoft doesn't provide support for the sample report.

## Document summary in Copilot  

Effective October 2025, the document summary feature in Copilot is deprecated. This means that you can no longer generate summaries of sales documents and proposals using Copilot. Prompt for document summarization will be removed and natural language prompts for document summarization will not work either. As an alternative, you can use the built-in summarization capabilities in Microsoft Word or other text editing tools.

## Emails that need follow-ups in Copilot in Dynamics 365 Sales

Effective September 2025, the **Show emails that need follow up** prompt in Copilot in Dynamics 365 Sales is deprecated region-wise. After the deprecation, you can no longer view the emails that need follow-ups in Copilot in Dynamics 365 using this prompt.  
However, you can use in-flow summarization and natural language processing capabilities to achieve similar outcomes.

## Copilot in Dynamics 365 Sales in full-screen view 

Effective September 2025, the full-screen view of Copilot in Dynamics 365 Sales is deprecated region-wise. After the deprecation, you can no longer select, view, or use Copilot option in app’s site map.  
Alternatively, you may utilize the Copilot side pane for supported functions, allowing banner summaries to appear within context rather than in an immersive canvas. This approach minimizes context switching and aligns with the strategy of engaging sellers directly within grids and forms.

<a name='exchange-integration-for-ra'></a>
## Exchange integration for relationship intelligence

Effective April 2025, the native Exchange integration for relationship intelligence is deprecated. If you want Dynamics 365 Sales to use emails and meetings from Exchange to generate insights, [enable server-side synchronization for Exchange](configure-email.md). Otherwise, insights are generated only using emails and data stored in Dynamics 365.

## Power BI template apps for Dynamics 365 Sales are deprecated

Effective May 2025, Sales Analytics for Dynamics 365 Sales and Process Analytics for Dynamics 365 Sales template apps are deprecated and will no longer be available for download.

## Copilot for email in side pane

Effective January 2025 (app/solution version 9.2.24124.0010), composing and sending email using Copilot side pane isn't supported and is being removed in a phased manner. This effects the users who have enabled the email copilot preview. However, you can use the [Copilot email assist](enable-copilot-email-assist.md) feature to compose and [send emails through the rich text editor](/power-apps/maker/model-driven-apps/use-copilot-email-assist).  

<a name='linkedin-lead-generation'></a>
## LinkedIn lead generation capabilities

Effective December 2024, LinkedIn lead generation capabilities are deprecated. You can however, develop your own custom integration. Learn more in the [LinkedIn Lead Sync Integration blog post](https://community.dynamics.com/blogs/post/?postid=fb6ed89f-67a1-ef11-8a69-7c1e520b1f9b).

## Assistant card templates

Effective August 1, 2024, templates to create new assistant cards won't be available. The existing cards that are created using the templates continue to work as-is. You can continue to use the Microsoft Power Automate flow to create your custom cards. [Learn more](create-insight-cards-flow.md).

<a name='snapshot-deprecation'></a>
## Snapshots in sales forecasting

Effective June 30, 2024, the snapshot capability in sales forecasting is deprecated. Snapshots and related charts such as deal flow, trend chart, and forecast grid history are no longer available. As an alternative, you can use the [Forecast API](developer/reference/custom-actions/msdyn_ForecastApi.md) to set up daily data sync to pull forecast data.

## Set seller availability using Outlook calendar

Effective April 1, 2024, the feature allowing configuration of seller availability through the Outlook calendar in work assignments is deprecated. This deprecation helps enhance the safety and security of your organization's data. Alternatively, you can use the Dynamics 365 CRM calendar to configure the seller availability. [Learn more](wa-manage-seller-availability.md)

## Exchange-based cards

Effective October 1, 2023, the following Exchange-based cards are deprecated and no longer available in Dynamics 365 Sales:
 
-	Send Content Request Card
-	Task Due Today Exchange Card
-	Upcoming Meeting Exchange Card 
-	Recent Meeting Exchange Card
-	Lead Detection Card
-	Meeting Today Exchange Card
-	Missed Email Card
-	Issue Detection Card
-	Meeting Request Card 
-	Yes or No Card

You can create your own cards using Power Automate. [Learn more](create-insight-cards-flow.md).

## Rank optimization of insight cards

Effective October 1, 2023, the rank optimization feature of insights cards is deprecated. Any ranking rules that you might have set up are no longer available and won't apply to insight cards. To optimize and prioritize the cards, turn off those cards that aren't in use.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
