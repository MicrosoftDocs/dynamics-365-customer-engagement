---
title: "Email marketing report for Dynamics 365 Marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "This email marketing analytics report provides you interaction and conversion leaderboards, automation status, block and failure analysis, and more."
ms.date: 11/22/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: cabeln
ms.author: cabeln
manager: shellyha
ms.reviewer: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Email marketing analytics report for Dynamics 365 Marketing

This marketing analytics report provides insights into your email marketing and related activities. Use the following links to download a template for running the report on your organization and an example report filled with sample data.

|Download report template  |Download sample report  |
|---------|---------|
[![Download template](media/IconDownloadTemplate30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/PowerBI-Templates/MarketingAnalyzers%20-%20Email%20Marketing.pbit)|[![Download sample report](media/IconDownloadReport30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/pbx%20files/MarketingAnalyzers%20-%20Email%20Marketing.pbix)|

> [!NOTE]
> You can find the full list of marketing analytics downloads in the [marketing analytics reporting gallery](analytics-gallery-start.md#gallery).

In addition to the [common report pages](analytics-gallery-framework.md#common-report-pages), this analytics report includes the following pages:

- [Home page](#report-home-page)
- [Email marketing plan overview](#marketing-plan)
- [Email marketing template usage report](#template-usage)
- [A leaderboard of your most effective email activities](#leaderboard)
- [Detailed email interaction timeline](#interaction-timeline)
- [Geo-mapping your interactions](#geo-mapping-interactions)
- [Detailed link-click analysis](#email-clicks)
- [Blocked email messages and other failures](#send-blocks-fails)

<a name="report-home-page"></a>

## Email marketing report home page

Each report includes a filter pane on the left that lets you quickly select the relevant marketing activities to focus on. You can also chose the relevant time frame for your exploration.

> [!TIP]
> Use the report home page to get a quick overview of your core marketing automation objects, customer journeys, and email marketing messages.

Here you can define report-wide data filtering, select the data range you'd like to include, and limit the view to include just the customer journeys and marketing messages you're interested in.An additional view shows the timeline of interactions arriving from your audience, which helps you set filters and define what to show.

![Email marketing report home page](media/EmailMarketing/EmailMarketing-(1)Home.png "Email marketing report home page")

<a name="marketing-plan"></a>

## Email marketing plan overview

The marketing plan presents a view of your marketing activities in the form of a Gantt chart. It shows how frequently individual marketing messages are used in your customer journey.

The view retains the slicer filter you selected previously and carries additional KPIs for the scope of data you're viewing.

![Email marketing schedule](media/EmailMarketing/EmailMarketing-(2)MarketingPlan.png "Email marketing schedule")

You can open each chart in full-screen view to better study its data.

![Schedule full screen](media/EmailMarketing/EmailMarketing-(2b)SchedulingDetail.png "Schedule full screen")

<a name="template-usage"></a>

## Email marketing template usage report

The template report shows which marketing message templates are being used in your marketing automation. It can be important to ensure that you're using the correct templates in certain journeys. Select which journeys you'd like to check, and then inspect the number of messages sent and which templates were used.

![Email template usage](media/EmailMarketing/EmailMarketing-(3)EmailMarketingDesign.png "Email template usage")

<a name="leaderboard"></a>

## Leaderboard&mdash;your most successful email marketing automation and messages

The leaderboard shows you which of your marketing automation and messages are performing best. Your best-performing customer journeys with their respective email marketing messages are ranked for various criteria, such as most unique opens, most clicks, or most conversions (leads captured). Select the criteria and then compare customer journeys or emails across selected or all customer journeys in which they appear.

![Email marketing leaderboard](media/EmailMarketing/EmailMarketing-(4)EmailMarketingLeaderBoard.png "Email marketing leaderboard")

> [!NOTE]
> A [more detailed leaderboard report](analytics-gallery-leaders.md) is also available. It supports a more fine-grained leader analysis based on more interactions for both your customer journeys and email marketing activities.

<a name="interaction-timeline"></a>

## Email marketing interaction timeline

The timeline view shows the trend of responses and other email-related interactions over time. Select the charts for the various interactions to focus on in the respective timeline. <!--self-->A few KPIs show the most opened/read messages, the messages with the most link clicks, and more.

![Email marketing interaction timeline](media/EmailMarketing/EmailMarketing-(5)InteractionTimeline.png "Email marketing interaction timeline")

<a name="geo-mapping-interactions"></a>

## Geo mapping&mdash;see where your audience is located

This report shows a map of roughly where recipients were when they opened or clicked a marketing email. It uses the IP addresses recorded for each interaction to approximate the location.

![Interaction geo mapping](media/EmailMarketing/EmailMarketing-(6)InteractionGeoMapping.png "Interaction geo mapping")

<a name="email-clicks"></a>

## Email links clicked

This detailed link-click report breaks down how many times each link was clicked and gives a ranking for your most opened links. A detailed click-stream timeline shows the history over time.

![Link click report](media/EmailMarketing/EmailMarketing-(7)LinkClickReport.png "Link click report")

<a name="send-blocks-fails"></a>

## Email sending failures and blocked sending

This important report shows all the sending failures and blocked emails that occurred over time, and lists the reasons for each of them. A per-message view identifies the most relevant messages and reports on failures so you can plan any required mitigations.

![Email marketing block and failure analysis](media/EmailMarketing/EmailMarketing-(8)EmailBlock-FailureAnalysis.png "Email marketing block and failure analysis")

***Happy analytics reporting with Dynamics 365 Marketing!***


[!INCLUDE[footer-include](../../includes/footer-banner.md)]