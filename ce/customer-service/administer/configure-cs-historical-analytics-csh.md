---
title: "Manage historical analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to configure Customer Service historical analytics reports in Omnichannel for Customer Service."
ms.date: 06/14/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:10/19/2023
  - ai-gen-desc
---

# Manage historical analytics reports in Customer Service

You can configure Customer Service historical analytics to give your service managers a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support cases and group related support cases into topics.

By default, the Customer Service historical analytics reports are enabled for the System Administrator and CSR Manager roles. To configure other user roles to access analytics and dashboards, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

The historical reports include:

- [Summary report](../use/summary-dashboard-cs.md)
- [Agent report](../use/agent-dashboard-cs.md)
- [Topics report](../use/case-topics-dashboard-cs.md)
- [Unified routing](../use/cs-historical-analytics-unified-routing.md)

After you enable the reports, you can access them in one of the following ways:

- In Customer Service workspace, select the hamburger menu, and then select **Customer Service historical analytics** in the site map.

- In Customer Service Hub, in **Service**, in the site map, select **Customer Service historical analytics**.

## Manage Customer Service historical analytics reports

Use the Customer Service admin center app to enable or disable the reports.

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     
1. For **Customer Service historical analytics**, select **Manage**.
     
1. On the **Customer Service historical analytics** page, set the **Enable Customer Service historical analytics report** toggle to **On** to enable the reports or set the toggle to **Off** to disable the reports.

1. Select **Save** or **Save and Close**.

   This configuration also enables AI-discovered topics from cases with default settings.

## Enable historical analytics for unified routing

Use the Customer Service admin center app to enable or disable the reports. The metrics are available in the report after 24 hours.

> [!IMPORTANT]
>
> Unified routing must be enabled to enable historical analytics for unified routing. More information: [Provision unified routing for Customer Service](provision-unified-routing.md)

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     
1. For **Customer Service historical analytics**, select **Manage**. The **Customer Service historical analytics** page is displayed. 

1. Select the **Add historical analytics for unified routing** check box.  

1. Select **Save and Close**.

## Enable historical analytics for Copilot

Customer Service historical analytics must be enabled and you must opt in to the Copilot help pane and Copilot summaries to turn on analytics for Copilot.

1. In the Customer Service admin center, go to Insights, and on the page that appears, select **Manage** for **Customer Service historical analytics**.

1. On the **Customer Service historical analytics** page, select the **Add historical analytics for Copilot** checkbox, and then save the changes.

The command bar displays a message that your reports are being provisioned and it might take up to 24 hours for the process to complete.

## View Customer Service historical analytics reports

If you customized the Customer Service workspace app, you must complete the following steps to be able to view the reports.

1. On the Customer Service workspace app tile, select the ellipsis for **More Options**, and then select **Open in App Designer**.
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
[Historical analytics for unified routing in Customer Service](../use/cs-historical-analytics-unified-routing.md)  
[View copilot analytics report](../use/copilot-analytics-report.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
