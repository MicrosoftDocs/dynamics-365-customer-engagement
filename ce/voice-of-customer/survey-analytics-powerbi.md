---
title: "Survey analytics using Power BI | MicrosoftDocs"
description: "Learn how to connect Voice of the Customer instance to Power BI and get insights about the surveys."
keywords: "voice of the customer analytics, voice of the customer analytics app for power BI"
ms.date: 04/03/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 033D39F5-5CB1-436F-966A-74ED90C7E73D
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Survey analytics using Power BI

The Voice of the Customer Analytics for Dynamics 365 content pack for Power BI allows you to connect to your Voice of the Customer for Dynamics 365 instance and get insights about the surveys and their responses. As a Survey Administrator or Survey Designer, you can track metrics, such as average NPS, average CSAT score, and response ratio and get visibility into the surveys. The dashboard and reports allow you to explore and analyze the survey data as you need.

## Install and configure content pack for Voice of the Customer

## Uninstall content pack for Voice of the Customer

## Dashboard

Dashboard is an intuitive user interface that graphically represents the survey insights. It consists of various tiles that provides an overview of the metrics, such as average NPS, average CSAT score, and response ratio and get visibility into the surveys. This allows you to explore and analyze the survey data as needed. When you click a tile on the dashboard, the corresponding report opens for further analysis.

More information: [Dashboards in Power BI service](https://docs.microsoft.com/en-us/power-bi/service-dashboards)

To open dashboard:
1. Sign in to [Power BI](https://powerbi.microsoft.com/).
2. Select **Apps** from the left navigation pane.
3. Select the app.

The dashboard contains the following tiles:

- **Total Surveys**: Displays the total number of surveys created.
- **Survey Invites Sent**: Displays the total number of survey invites sent.
- **Non-anonymous Responses**: Displays the number of non-anonymous survey responses received.
- **Anonymous Responses**: Displays the number of anonymous survey responses received.
- **Average CSAT**: Displays the average CSAT score.
- **Survey Score**: Displays the average survey score percentage.
- **Average NPS**: Displays the average NPS score.
- **NPS Type**: Displays the survey distribution of promotor, passive, and detractor NPS types. If you select a pie, data in other NPS tiles are refreshed accordingly.
- **CSAT Trend**: Displays the trend of average CSAT score over a period of time. The x-axis displays the time period and y-axis displays the average CSAT score.
- **NPS Trend**: Displays the trend of average Net Promoter Scores over a period of time. The x-axis displays the time period and y-axis displays the average NPS.
- **Survey Invite Trend**: Displays the number of survey invites sent over a period of time. The x-axis displays the time period and y-axis displays the count of survey invites sent. To view details, point to a data point on the line graph.
- **Response Time (from Invite Sent to Response Submitted)**: Displays the turnaround time for survey responses in 50th, 95th, and 99th percentile. The x-axis displays the survey name and y-axis displays the percentile. The unit is in seconds.

![Voice of the Customer Analytics for Dynamics 365 dashboard](media/voc-analytics-dashboard.png "Voice of the Customer Analytics for Dynamics 365 dashboard") 
