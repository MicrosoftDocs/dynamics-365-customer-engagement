---
title: Use and customize analytics and insights
description: Learn how to activate and customize analytics and insights in Customer Service to boost contact center efficiency and improve customer satisfaction.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: concept-article
ms.collection: 
ms.date: 07/16/2025
ms.custom: bap-template
---

# Use and customize analytics and insights

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


As an administrator, you can [enable analytics and insights](configure-customer-service-analytics-insights-csh.md#configure-analytics-and-insights-dashboards) features within Customer Service. This data can then be shared with supervisors so they can review and analyze contact center activities. This valuable information can help identify and address issues, improve customer service representative (service representative or representative) efficiency, and ultimately enhance productivity and customer satisfaction.

You can configure these features and services in the Copilot Service admin center app. Once set up, supervisors can use the Copilot Service workspace app to access and view them.

## Use out-of-the-box features

Customer Service provides various default dashboards and reports. These dashboards display a range of charts, metrics, and key performance indicators that can offer valuable insights about your contact center operations. Here's an overview of what's readily available to you.

### Access dashboards

Supervisors can access and view these dashboards from the Copilot Service workspace app.

**Historical**

- [Customer Service historical analytics dashboards](../use/customer-service-analytics-insights-csh.md#customer-service-historical-analytics-reports): To help improve customer service, use the performance summary and detailed reports on cases, service representatives, and topics.

- [Omnichannel historical analytics dashboards](../use/omnichannel-analytics-insights.md): To get a view into the support operations across various channels, use key performance indicators coupled with AI-generated insights.

- [Knowledge analytics reports](../use/knowledge-search-analytics-cs.md): To understand how service representatives use knowledge articles to resolve customer issues, use article and search term insights.

**Real time**

- [Omnichannel real-time analytics dashboards](../use/intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboard): Monitor key operational metrics in real-time and make course corrections at the appropriate time to help keep service levels high.

- [Real-time analytics for record routing](../use/rr-overview.md#overview-of-real-time-analytics-for-record-routing): Monitor key operational metrics in real-time for record routing to enhance agent performance and customer support.

### Keep the report state when you switch session tabs

The reports retain their current state even when you switch session tabs. However, if you customized the Copilot Service workspace app, complete the following steps to retain the report state.

1. On the Copilot Service workspace app tile, select the ellipsis for **More Options**, and then select **Open in App Designer**. This navigation takes you to Power Apps.
1. In **Pages**, from **Navigation**, select the required report view. Here's an example. Select **Omnichannel real-time analytics view**.
1. From **Omnichannel real-time analytics**, go to **Settings** > **Display options**.
1. In **Display options**, from the **Content type** dropdown list, select **Table**.
1. From the **Table** dropdown list, select **Omnichannel Realtime analytics**.
1. Select **Save and Publish**.

After you finish these steps for a specific report, the state remains the same when you reopen the report.

## Customize features

Here are the customizations that you can utilize.

- [Customize Key Performance Indicators](../use/customize-reports.md#customize-visual-display): Use the embedded Power BI editor to modify the visual display of dashboards, tailoring the out-of-the-box reports to your organization's needs.
- Personalize analytics:
  - [Report Filters and Groups](../use/report-filters-groups.md#report-filters-and-groups): Save time by setting one or more filters to a report group, eliminating the need to set filters each time you access the reports.
  - [Manage Bookmarks for Reports](../use/manage-bookmarks.md#manage-bookmarks-for-reports): Utilize bookmarks to save the filters you set, allowing for easy viewing of specific data each time you open the report.
- [Use metrics](../use/oc-metrics-dimensions.md): Perform a quantitative assessment of the metrics displayed on the dashboards. Use these metrics to [customize the visual display](../use/customize-reports.md#customize-visual-display) of your reports.

## Related information

[Configure analytics and insights dashboards](configure-customer-service-analytics-insights-csh.md#configure-analytics-and-insights-dashboards)
