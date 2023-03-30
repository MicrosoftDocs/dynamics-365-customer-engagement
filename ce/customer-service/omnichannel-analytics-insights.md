---
title: Omnichannel for Customer Service dashboards | Microsoft Docs
description: Learn about the various dashboards and reports for historical operational metrics and KPIs in Omnichannel for Customer Service to manage contact centers.
ms.date: 03/30/2023
ms.topic: overview
author: neeranelli
ms.author: nenellim
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
 
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Omnichannel for Customer Service dashboards

The insights dashboards in Omnichannel for Customer Service contain various charts and metrics to help you understand the factors that can improve customer service for your organization. Key performance indicators and visual breakdowns of your organization's support cases are coupled with AI-generated insights on cases, agents, and topics that contribute to overall trends.

The Omnichannel for Customer Service dashboards provide a view into the support operation across the various channels.

## Configure dashboards

To enable the dashboards, see [Configure Omnichannel historical analytics](oc-historical-analytics-reports.md).

## Omnichannel historical analytics reports

The following dashboard reports are available for Omnichannel historical analytics.

### Summary

The Summary dashboard gives you an integrated view of the Power Virtual Agents bot and Omnichannel metrics.

> [!div class="mx-imgBorder"]
> ![Summary dashboard.](media/oc-summary-dashboard.png "Summary dashboard")

More information: [Conversation dashboard](omnichannel-summary-dashboard.md)

### Conversation

The Conversation dashboard gives you a broad overview of the assisted support customer service experience in your organization.

> [!div class="mx-imgBorder"]
> ![Conversation dashboard.](media/conversation-dashboard.png "Conversation dashboard")

More information: [Conversation dashboard](oc-conversation-dashboard.md)

### Queue

The Queue dashboard gives you a broad overview of the customer service experience in your organization by providing insights into how specific queues are operating.

> [!div class="mx-imgBorder"]
> ![Queue dashboard.](media/queue-report.png "Queue dashboard")

More information: [Queue dashboard](oc-queue-dashboard.md)

### Agent

The Agent dashboard shows charts and KPIs that you can use to guide agents and understand overall agent performance.

> [!div class="mx-imgBorder"]
> ![Agent dashboard.](media/agent-report-cs.png "Agent report").

More information: [Agent dashboard](agent-dashboard.md#agent-dashboard)

### Bot

The Bot dashboard shows charts and KPIs that you can use to understand how bots are playing a role in a support organization. 

> [!div class="mx-imgBorder"]
> ![Bot dashboard.](media/oc-bot-dashboard.png "Bot dashboard")

More information: [Bot dashboard](oc-bot-dashboard.md)

### Conversation Topics

The Topics dashboard shows a detailed breakdown of conversations and their assigned topics.

> [!div class="mx-imgBorder"]
> ![Conversation Topics.](media/conversation-topics-dashboard.png "Conversation Topics")

More information: [Topics dashboard](oc-conversation-topics-dashboard.md)

## Information that you need to know about analytics reports

### Refresh reports, retain data

The reports refresh shows the following information.

- **Data refresh:** Occurs every 24 hours. The reports are available during the refresh process. The **Last updated** timestamp in the report pages indicates when the latest data was included in the report, and the time reflects the time zone that's set in your user preferences. 
- **Custom refresh:** Isn't available.
- **Data refresh for inactive environments:** Data refresh is paused if the reports aren't used continuously for two weeks. When you access a report after a lengthy period of inactivity, the report will be refreshed in the next refresh cycle.
- **Data retention:** Data is stored for 24 months.

> [!NOTE]
> A report might be blank if you've customized any of the listed entities or are using out-of-the-box entities.

## Customize reports

### Save report views using bookmarks

You can also save personalized views of your reports as bookmarks and then use the **Bookmarks** option to select a saved view, update, or delete a bookmark, and set a default bookmark. More information: [Manage report bookmarks](manage-bookmarks.md)

## Troubleshoot issues

To troubleshoot issues when you try to access or view the reports, see [Troubleshoot issues when accessing reports](customer-service-analytics-insights-csh.md#troubleshoot-issues-when-accessing-reports).


### See also

[Introduction to Customer Service insights](introduction-customer-service-analytics.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
