---
title: Omnichannel for Customer Service dashboards
description: Learn about dashboards that provide historical metrics and KPIs for managing contact center operations in Dynamics 365 Customer Service.
ms.date: 08/25/2026
ms.topic: overview
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
 
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Omnichannel for Customer Service dashboards

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


The insights dashboards in Omnichannel for Customer Service provide charts and metrics that help you analyze customer service performance. Key performance indicators and visual breakdowns of conversations, queues, and customer service representative activity help you identify trends and opportunities for improvement. The dashboards provide visibility into support operations across multiple engagement channels.

You can [customize the visual display](customize-reports.md#customize-visual-display) of the dashboards and save personalized views as [bookmarks](manage-bookmarks.md).

Learn more about [managing historical analytics reports in Omnichannel for Customer Service](../administer/oc-historical-analytics-reports.md).

## Omnichannel historical analytics reports

The following reports are available for Omnichannel historical analytics.

- [Summary dashboard](omnichannel-summary-dashboard.md): The Summary dashboard gives you an integrated view of Copilot agent and omnichannel metrics.

- [Conversation dashboard](oc-conversation-dashboard.md): The Conversation dashboard provides an overview of customer conversations handled by service representatives.

- [Queue dashboard](oc-queue-dashboard.md): The Queue dashboard gives you a broad overview of the customer service experience in your organization by providing insights into how specific queues are operating.

- [Voice dashboard](voice-channel-reports-analytics.md): The Voice dashboard provides comprehensive information on the overall performance of customer support across the voice channel.

- [Agent dashboard](agent-dashboard.md#agent-dashboard): The Agent dashboard contains service representative performance metrics that you can use to guide service representatives and understand overall representative performance.

- [Bot dashboard](oc-bot-dashboard.md): The Bot dashboard provides charts and KPIs for evaluating AI agent performance and its effect on customer conversations.

- [Voicemail dashboard](oc-voicemail-dashboard.md): The Voicemail dashboard shows voicemail status and voicemail volume by queue and representative.

- [Proactive Outbound dashboard](/dynamics365/contact-center/use/proactive-outbound-dashboard): The Proactive Outbound dashboard provides organizations with detailed insights into proactive outbound customer engagements initiated through proactive outreach. This dashboard is available in Dynamics 365 Contact Center only. Learn how to enable it in [historical analytics for proactive outbound engagements](../administer/oc-historical-analytics-reports.md#enable-historical-analytics-for-proactive-outbound-engagements).

- [Bot-Intent dashboard](/dynamics365/contact-center/use/bot-intent-historical): The Bot-Intent dashboard provides detailed insights about bot performance and customer engagement, supporting targeted analytics for continuous improvement. This dashboard is available in Dynamics 365 Contact Center only. Learn how to enable it in [historical analytics for intent](../administer/oc-historical-analytics-reports.md#enable-historical-analytics-for-intent).

- [Quality Assurance Agent dashboard](/dynamics365/contact-center/use/quality-assurance-agent-dashboard): The Quality Assurance Agent dashboard helps you get insights about the Quality Assurance Agent's quality and coaching skills. This dashboard is available in Dynamics 365 Contact Center only. Learn how to enable it in [historical analytics for Quality Assurance Agent](../administer/oc-historical-analytics-reports.md#enable-historical-analytics-for-quality-assurance-agent).

> [!NOTE]
> The reports don't include work items of the Entity Record channel.

## Data model

- Learn more about [Data models and report mappings for historical analytics reports in Customer Service](oob-data-models.md#data-models-and-report-mappings-for-historical-analytics-reports-in-customer-service).

- Learn more about [Dataverse tables used in historical and real-time analytics](dataverse-entities.md#dataverse-entities-used-in-historical-and-real-time-analytics).

## Metrics

[Calculate Conversation metrics](../develop/calculate-conversation-metrics.md#calculate-conversation-metrics)   
[Session metrics](session-metrics.md#session-metrics)  
[Service representative metrics](service-rep-metrics.md#service-representative-metrics)

## Access the dashboards

[!INCLUDE[cc-navigation](../../includes/cc-navigation.md)]

## Filter information displayed on dashboard

Use filters to refine the KPIs and charts displayed on the dashboard. Adjust the filters based on the insights that you're looking for. The available filters include **Duration**, **Channels**, **Queue**, **Agent**, **Conversation Status**, and **Time zone**. 

Optionally, you can also add the **Business Unit** filter that provides a consistent way to focus on a single business unit or compare multiple units. The filter can be configured through data model customization or by adjusting the visual under data measure for the dimension **DimBusinessUnit**. The **Business Unit** filter doesn't grant additional access; it simply restricts data visibility based on existing roles and business unit hierarchy. If a user doesn't have security permissions to view a business unit's data, selecting that business unit won't display any information.

## Reports refresh and data retention

For refresh schedules and retention periods, review [Reports refresh and data retention](customer-service-analytics-insights-csh.md#reports-refresh-and-data-retention).

## View historical analytics reports in a customized Copilot Service workspace app

If you customized the Copilot Service workspace app, you must complete the following steps to be able to view the reports.

1. On the Copilot Service workspace app tile, select the ellipsis (**More Options**), and then select **Open in App Designer**.
1. Select **New**.
1. On the **New page** dialog, select **Dataverse Table** for Omnichannel historical analytics, and then select **Next**.
1. To add a Dataverse table, select the **Select existing table** option, and then select **Omnichannel historical analytics**.
1. Select **Show in navigation**, and then select **Add**.
1. From **Navigation**, select **Omnichannel historical analytics**, and then select **Settings**.
1. Enter the following information:
    - **Title**: Omnichannel historical analytics
    - **Icon**: Select **Use web resource**.
    - **Select icon**: msdyn_/Analytics/imgs/OmnichannelReportIcon.svg
    - **ID**: OCReportsSubArea
1. Select **Advanced Settings**, and then select the following checkboxes:
    - **SKU**: **All**, **On premise**, **Live**, and **SPLA**.
    - **Client**: **Web**.
    - **Outlook shortcut**: **Offline availability**.
1. Select **Save**, and then select **Publish**.

## Related information

[Introduction to Customer Service insights](../implement/introduction-customer-service-analytics.md)  
[Manage bookmarks](manage-bookmarks.md)  
[Customize visual display](customize-reports.md#customize-visual-display)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
