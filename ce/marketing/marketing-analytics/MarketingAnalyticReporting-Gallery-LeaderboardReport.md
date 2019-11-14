---
title: "Leaderboard report for customer journeys and email marketing for Dynamics 365 Marketing | Microsoft Docs"
description: "Use the leaderboard report for customer journey automation and email marketing to identify your most effective marketing activities."
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

# Leaderboard report for customer journeys and email marketing

> [!TIP]
> The leaderboard report for customer journeys and email marketing identifies your most effective journeys and messages.

Use the following links to download a template for running the report on your own organization and/or a sample report filled with sample data.

|Download report template  |Download sample report  |
|---------|---------|
[![Download template](media/IconDownloadTemplate30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/PowerBI-Templates/MarketingAnalyzers%20-%20Journey%26Email%20Leaderboard.pbit)|[![Download sample report](media/IconDownloadReport30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/pbx%20files/MarketingAnalyzers%20-%20Journey%26Email%20Leaderboard.pbix)|

You can find more downloads in the [marketing analytics reporting gallery](MarketingAnalyticReporting-Gallery.md).

This analytics report includes the following report pages:

- [The hidden common pages](#common-pages), which help you customize the report and build new marketing analytics
- A report homepage with an overview
- [A detailed leaderboard of email marketing activities](#email-leaderboard)
- [A detailed leaderboard of journeys](#journey-leaderboard)
- [A breakdown of leaderboard KPIs with a timeline](#leaderboard-kpis)

<a name="common-pages"></a>

## Common pages

> [!TIP]
> Each template and sample report contains a set of common pages that help you explain your report to your audience.

To learn more about the common pages, see [Common report pages](MarketingAnalyticReporting-Framework.md#common-report-pages).

<a name="email-leaderboard"></a>

## A leaderboard report for email marketing

The detailed email marketing leaderboard lets you compare and rank your marketing messages based on the KPIs:

- Total emails delivered
- Total emails opened, unique opens and open rate
- Total links clicks, unique clicks and click rate
- Total form submissions, unique submissions and submission rat
- Total subscriptions, unique subscriptions and submission rate

The marketing messages that shall be considered for this report can be filtered by data range, message status and journey status. And interactions can be filtered by a date recency filter as well.

The leaderboard chart control can be configured by the user who looks at the report, by rearranging columns and sorting by rank for select KPI.

![Email marketing leaderboard](media/Leaderboards/LeaderBoards-EmailLeaderBoardReport.png)

<a name="journey-leaderboard"></a>

## The leaderboard report for customer journeys

KPIs related to email marketing aggregate across all marketing messages that are part of a journey. The report compares and ranks your journeys based on the following KPIs:

- Number of contacts processed by the journey
- Total emails delivered
- Total email opens, unique opens, and open rate
- Total links clicks, unique clicks, and click rate
- Total form submissions, unique submissions, and submission rate
- Total subscriptions, unique subscriptions, and subscription rate

Use the data range and status slicers to filter the journeys. The interactions can also be filtered by age.

Users can configure the leaderboard chart control, rearrange columns, and sort the list by any selected KPI as needed.

![Customer journey automation leaderboard](media/Leaderboards/LeaderBoards-JourneyLeaderBoardReport.png)

<a name="leaderboard-kpis"></a>

## Leaderboard KPIs and timeline

This report lists all the KPIs, marketing messages, and journeys selected by the sliders. In addition, you can look at the individual interaction timelines that lie behind the KPIs. Try filtering the various journeys and messages, or slicing and dicing to compare your marketing activities by various criteria.

![KPI breakdown and timeline](media/Leaderboards/LeaderBoards-ActivityBreakdown.png)

***Happy analytic reporting with Dynamics 365 Marketing!***
