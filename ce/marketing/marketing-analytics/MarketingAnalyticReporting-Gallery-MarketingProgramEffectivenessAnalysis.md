---
title: "Marketing program effectiveness analysis for Dynamics 365 Marketing | Microsoft Docs"
description: "Get the end to end marketing program effectiveness analysis, including automation, journeys, channels, lead generation, conversion and revenue generation."
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

# Marketing program effectiveness analysis for Dynamics 365 Marketing

> [!TIP]
> Analyze the end-to-end effectiveness of your marketing programs, including automation, journeys, channels, lead generation, conversion, and revenue generation.

Use the following links to download a template for running the report on your own organization and/or a sample report filled with sample data.

|Download report template  |Download sample report  |
|---------|---------|
[![Download template](media/IconDownloadTemplate30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/PowerBI-Templates/MarketingAnalyzers%20-%20Marketing%20Automation.pbit)|[![Download template](media/IconDownloadReport30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/pbx%20files/MarketingAnalyzers%20-%20Marketing%20Automation.pbix)|

You can find more downloads in the [marketing analytics reporting gallery](MarketingAnalyticReporting-Gallery.md).


This report walks you through and end-to-end analytical exploration that starts from your marketing plan and continues all the way to return on investment and attribution to sales vs. marketing. Start your exploration on the [home page](#home-page), which provides a high-level overview of your marketing activities. Then go to the [marketing plan](#plan-overview) to see a Gantt chart that shows when your customer journeys are running and which messaging is being used. At the next station you can find out [who exactly is included in your audience](#journey-reach), and what feedback and interactions have been detected. Go to the [leader board](#leaderboard) to compare which of your automated marketing activities performs best. 
Next stop is [lead generation](#lead-generation), where you can find out which leads were created by inbound vs. outbound marketing activities, see their stage, and view related customer interactions. Explore the [full lead pipeline](#lead-pipeline) to find all leads, whether they are inbound/outbound or sales-generated; these leads are grouped by their current stage, as they leave marketing, go through teleprospecting, and finally become sales-accepted. At the end of the exploration, the [return on investment report](#roi) helps you see where the opportunities with highest budget, highest estimated revenue, and actual total amount have been generated&mdash;inbound marketing, outbound marketing, or by direct sales activities.

This analytics report includes the following report pages:

- [The report homepage](#home-page) with an overview
- [Your marketing automation plan](#plan-overview) in a Gantt chart
- [Journey reach](#journey-reach), which finds audience members included in your marketing automation and their related activities
- [A leader board](#leaderboard) for your marketing automation and various activities of your audience
- [Lead-generation performance analytics](#lead-generation) for your customer journey automation
- [A lead pipeline report](#lead-pipeline) for inbound and outbound lead generation, sales lead generation, and marketing lead generation
- [A ROI report](#roi), which shows you aggregated budget vs. total amount and revenue split by opportunities generated from inbound and outbound marketing and from sales activities.

<!--Common pages-->
## Common Pages

> [!TIP]
> Each template and sample report contains a set of common pages that help you explain your report to your audience.

To learn more about the common pages, see [Common report pages](MarketingAnalyticReporting-Framework.md#common-report-pages).

<a name="home-page"></a>

## The marketing automation report home page

Each report includes a filter pane on the left that lets you select the relevant marketing activities to focus on. You can also chose the relevant time frame for your exploration.

> [!TIP]
> The report home page gives you a quick overview of your core marketing automation objects, customer journeys, and email marketing messages.

You can define report-wide data filtering here, select the data range you'd like to report on, and limit the view to selected customer journeys.

![Automation report hope page](media/Automation/Automation-HomePage.png)

<a name="plan-overview"></a>

## The marketing automation plan overview

> [!TIP]
> The marketing plan presents a Gantt chart of your marketing automation activities

The marketing plan report shows all your customer journeys in a Gantt chart together with related marketing messages. You can use the sliders to apply filters that sync across other reports. This helps you to set the scope for your explorations.

![Marketing Automation Plan](media/Automation/Automation-MarketingPlan.png)

<a name="journey-reach"></a>

## Journey reach report

> [!TIP]
> The journey reach report dives into who was addressed by, and who responded to, your marketing activities.

In this report you will see all the audience members that have been included in and processed by your customer journeys. A *dispatchment* indicates that a contact has been pushed&mdash;typically from a segment&mdash;into the customer journey.

You can search dispatched contacts by name or email address. Then dive into details either per contact or aggregated at the customer journey level.

![Audience included in Marketing automation](media/Automation/Automation-AudienceIncluded.png)

<a name="leaderboard"></a>

## Leaderboard&mdash;your most successful email marketing automation activities

> [!TIP]
> The leaderboard shows which of your marketing automation plans perform best!

Find your best performing customer journeys with the respective audience interactions ranked by various criteria, including: unique opens, clicks, conversions (leads captured), subscriptions, and more. Select the criteria and then compare customer journeys or emails across selected or all customer journeys in which they appear.

![Automation leaderboard](media/Automation/Automation-Leaderboard.png)

<a name="lead-generation"></a>

## Your lead generation flow originating from inbound/outbound marketing

The lead generation report helps you to find out which leads were created from inbound vs. outbound marketing activities. Outbound leads will have the originating customer journey field set, and will also have stages assigned and related customer interactions attached to the respective contact.

![Lead generation](media/Automation/Automation-LeadGeneration.png)

<a name="lead-pipeline"></a>

## Your lead pipeline&mdash;see leads originating from inbound/outbound marketing and from sales

In the lead pipeline report, all leads originating from Dynamics 365 Marketing are grouped by their sales stage. The leads are split according to whether they came from inbound or outbound marketing activities. The leads originating from marketing move through the teleprospecting-ready and teleprospecting-accepted stages and then on to the sales-accepted and sales-ready stages. Sales-ready leads are typically the most promising and will probably be picked up by salespeople for extra attention.

![Lead pipeline](media/Automation/Automation-LeadPipeline.png)

<a name="roi"></a>

## ROI report&mdash;judge effectiveness according to your return on marketing investments

> [!TIP]
> Compare revenue generation originating from from inbound/outbound marketing and sales

The return on investment (ROI) report splits your opportunities into three groups to help you attribute revenue to your marketing activities or direct sales. Each group shows the number of opportunities, the total budget for the opportunities in this group, the estimated revenue, and the actual total amount.

The group association is done through the originating leads based on whether those originated from customer journeys, marketing pages, or sales campaigns.
The first block contains the opportunities that originated from sales campaigns. The second block aggregates all opportunities that originated from inbound marketing&mdash;these have been created based on an inbound visit to a marketing page that can't be attributed to an outbound customer journey. The third are all the opportunities that have been attributed to a customer journey.

This reports assumes all customer journeys to be outbound. But you can extend your journey model to include an inbound vs. outbound classification, and associate respective opportunities accordingly, if this is relevant for your marketing automation configuration.

![Marketing to Opportunity ROI report](media/Automation/Automation-OpportunityROIreport.png)

***Happy analytic reporting with Dynamics 365 Marketing!***
