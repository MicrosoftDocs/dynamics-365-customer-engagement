---
title: Manage historical analytics reports in Customer Service
description: Learn how to configure Customer Service historical analytics reports.
ms.date: 10/30/2026
ms.topic: how-to
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ai-usage: ai-assisted
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:10/19/2023
  - ai-gen-desc
---

# Manage historical analytics reports in Customer Service

You can configure Customer Service historical analytics to give your service managers a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support cases and group related support cases into topics.

By default, the Customer Service historical analytics reports are enabled for the System Administrator and CSR Manager roles. To give other user roles access to analytics and dashboards, complete the steps in [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

> [!NOTE]
> The reports retain their current state even when you switch session tabs. However, if you customized the Copilot Service workspace app, complete the steps in [Keep the report state when you switch session tabs](analytics_overview.md#keep-the-report-state-when-you-switch-session-tabs).

## Manage Customer Service historical analytics with enriched data

Use Customer Service historical analytics reports with enriched data to understand support demand, evaluate service outcomes, and identify backlogs that need attention. Consistent metrics across report pages help you make informed decisions to improve service operations. These reports are separate from the existing Customer Service historical analytics reports.


1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
1. For **Customer Service historical analytics with enriched data**, select **Manage**.
1. On the **Customer Service historical analytics with enriched data** page, set the toggle to **On** to turn on the reports or **Off** to turn them off.
1. Select **Save** or **Save and Close**.

Learn more about the reports in [Case analytics overview](../use/case-analytics-overview.md).

## Manage Customer Service historical analytics reports


1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.  
1. For **Customer Service historical analytics**, select **Manage**.    
1. On the **Customer Service historical analytics** page, set the **Enable Customer Service historical analytics report** toggle to **On** to turn on the reports or set the toggle to **Off** to turn off the reports.
1. Select **Save** or **Save and Close**.

When you turn on this configuration, it also enables AI-discovered topics from cases with default settings.

The historical reports include:

- [Summary report](../use/summary-dashboard-cs.md)
- [Agent report](../use/agent-dashboard-cs.md)
- [Topics report](../use/case-topics-dashboard-cs.md)

After you turn on the reports, you can access them in one of the following ways:

- In Copilot Service workspace, select the hamburger menu, and then select **Customer Service historical analytics** in the site map.

- In Customer Service Hub, in **Service**, in the site map, select **Customer Service historical analytics**.

## View Customer Service historical analytics reports

If you customized the Copilot Service workspace app, complete the following steps to view the reports.

1. On the Copilot Service workspace app tile, select the ellipsis for **More Options**, and then select **Open in App Designer**.
1. Select **New**.
1. On the **New page** dialog, select **Dataverse Table** for Customer Service historical analytics, and then select **Next**.
1. To add a Dataverse table, select the **Select existing table** option, and then select **Customer Service historical analytics**.
1. Select **Show in navigation**, and then select **Add**.
1. From **Navigation**, select **Customer Service historical analytics**, and then select **Settings**.
1. Enter the following information:
    - **Title**: Customer Service historical analytics
    - **Icon**: Select **Use web resource**.
    - **Select icon**: msdyn_/Analytics/imgs/CustomerServiceInsights.svg
    - **ID**: CSHistoricalAnalyticsSubArea
1. Select **Advanced Settings**, and then select the following checkboxes:
    - **SKU**: **All**, **On premise**, **Live**, and **SPLA**.
    - **Client**: **Web**.
1. Select **Save**, and then select **Publish**.


### Related information

[Introduction to Customer Service analytics and insights](../implement/introduction-customer-service-analytics.md)  
[Dashboard overview](../use/customer-service-analytics-insights-csh.md)  
[Knowledge search analytics](../use/knowledge-search-analytics-cs.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
