---
title: "Email marketing report for Dynamics 365 Marketing | Microsoft Docs"
description: "This email marketing analytical report provides you interaction and conversion leaderboards, automation status, block & failure analysis and more."
keywords: Email marketing report
ms.date: 11/11/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: cabeln
ms.author: cabeln
manager: 
ms.reviewer: kamaybac
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Email marketing analytical report for Dynamics 365 Marketing

> [!TIP]
> This marketing analytical report provides insights into your email marketing and related activities. You can download both a template for running the report on your organization and an example report filled with sample data.

<!-- kfm: consider removing this image. It's repeated later on the page and crowds the table of download links that comes right after. Maybe do this for all the similar topics that are using this format.  -->

![Email Interaction Timeline](media/EmailMarketing/EmailMarketing-(5)InteractionTimeline.png)

Use the following links to download a template for running the report on your own organization and/or a sample report filled with sample data.

|Download report template  |Download sample report  |
|---------|---------|
[![Download template](media/IconDownloadTemplate30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/PowerBI-Templates/MarketingAnalyzers%20-%20Email%20Marketing.pbit)|[![Download sample report](media/IconDownloadReport30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/pbx%20files/MarketingAnalyzers%20-%20Email%20Marketing.pbix)|

You can find more downloads in the [marketing analytics reporting gallery](MarketingAnalyticReporting-Gallery.md).

This analytics report includes the following report pages:

- [The hidden common pages](#common-pages), which help you to customize the report and build new marketing analytics
- [The report homepage](#report-home-page) with an overview
- [Your marketing plan](#marketing-plan) as a Gantt chart
- [A leader board](#leaderboard) for your marketing automation activities with email marketing
- [The timeline of interactions](#interaction-timeline) of your audience that result from your email marketing activities
- [A detailed link-click analysis](#email-clicks)
- [An analysis of blocked email message and other failures](#send-blocks-fails)
- We plan to add more capabilities, including: key influence analytics, forward to a friend, and more. <!-- kfm: this point was a bit garbled. I removed "and special topic lie " I actually recommend removing this point (better not to speculate in documentation about unreleased features). -->

<a name="common-pages"></a>

## Common Pages

> [!TIP]
> Each template and sample report contains a set of common pages that help you explain your report to your audience.

To learn more about the common pages, see [Common report pages](MarketingAnalyticReporting-Framework.md#common-report-pages).

<a name="report-home-page"></a>

## The email marketing report home page

Each report includes a filter pane on the left that lets you quickly select the relevant marketing activities to focus on. You can also chose the relevant time frame for your exploration.

> [!TIP]
> The report home page gives a quick overview of your core marketing automation objects, customer journeys, and email marketing messages.

Here you can define report-wide data filtering, select the data range you'd like to include, and limit the view to include selected customer journeys and marketing messages only.

An additional view shows the timeline of interactions arriving from your audience, which helps you to set filters and define what to show.

![Email marketing report home page](media/EmailMarketing/EmailMarketing-(1)Home.png)

<a name="marketing-plan"></a>

## The email marketing plan overview

> [!TIP]
> The marketing plan presents a Gantt view of your marketing activities

The plan also shows how frequently individual marketing messages are utilized in your customer journey.

The view retains the slicer filter you selected previously and carries additional KPIs for the scope of data you are viewing.

![Email marketing schedule](media/EmailMarketing/EmailMarketing-(2)MarketingPlan.png)

You can open each chart in full-screen view to better study its data.

![Schedule full screen](media/EmailMarketing/EmailMarketing-(2b)SchedulingDetail.png)

<!--Template usage-->
## Email marketing template usage report

> [!TIP]
> The template report shows which marketing message templates are being used in your marketing automation.

It can sometimes be important to ensure that the correct templates are being used by marketers in certain journeys. Select which journeys you'd like to check, and then inspect the number of messages sent and which templates were used.

![Email template usage](media/EmailMarketing/EmailMarketing-(3)EmailMarketingDesign.png)

<a name="leaderboard"></a>

## Leaderboard&mdash;your most successful email marketing automation and messages

> [!TIP]
> The leaderboard shows you which of marketing automation and message perform best!

Find your best performing customer journeys with their respective email marketing messages ranked for various criteria, such as: most unique opens, most clicks, or most conversions (leads captured). Select the criteria and then compare customer journeys or emails across selected or all customer journeys in which the appear.

![Email marketing leaderboard](media/EmailMarketing/EmailMarketing-(4)EmailMarketingLeaderBoard.png)

Please note that a [more detailed leaderboard report](MarketingAnalyticReporting-Gallery-LeaderboardReport.md) is also available. It supports a more fine-grained leader analysis based on more interactions for both your customer journeys and email marketing activities.

<a name="interaction-timeline"></a>

## Detailed email marketing interaction timeline

The timeline view shows the trend of responses and other email-related interactions over time. Select the charts for the various interactions to focus on in the respective timeline. A few KPIs show the most opened/read messages, the messages with the most link clicks, and more.

![Email marketing interaction timeline](media/EmailMarketing/EmailMarketing-(5)InteractionTimeline.png)

<!--Interaction geo mapping from your email marketing activities-->
## Geo mapping&mdash;see where your audience is located

This reports shows a map of roughly where recipients were when they opened or clicked a marketing email. It uses the IP addresses recorded for each interaction to approximate the location.

![Interaction geo mapping](media/EmailMarketing/EmailMarketing-(6)InteractionGeoMapping.png)

<a name="email-clicks"></a>

## Detailed breakdown of email links clicked

This detailed link-click report breaks down how many times each link was clicked and gives a ranking for your most opened links. A detailed click-stream timeline shows the history over time.

![Link click report](media/EmailMarketing/EmailMarketing-(7)LinkClickReport.png)

<a name="send-blocks-fails"></a>

## Email sending failures and blocked sending

This important report shows all the sending failures and blocked emails that occurred over time, and lists the reasons for each of them. A per-message view identifies the most relevant messages and reports on failures so you can plan any required mitigations.

![Email marketing block & failure analysis](media/EmailMarketing/EmailMarketing-(8)EmailBlock&FailureAnalysis.png)

***Happy analytic reporting with Dynamics 365 Marketing!***
