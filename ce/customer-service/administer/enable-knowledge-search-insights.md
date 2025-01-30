---
title: Manage knowledge analytics
description: Learn how to configure Knowledge analytics dashboards.
ms.date: 06/21/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Manage knowledge analytics

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


The Knowledge analytics dashboard is designed to provide your supervisors and knowledge workers with valuable insights into how your customer service representatives are searching and using knowledge articles.

By default, the Knowledge analytics dashboard is enabled for the System Administrator, Knowledge Manager, and CSR Manager roles. To configure user roles to access analytics and dashboards, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).


> [!NOTE]
> Knowledge analytics provides data that's based on internal knowledge search and doesn't provide information about customer search behavior.

## Manage Knowledge analytics dashboard

Use the Customer Service admin center app to enable or disable knowledge analytics reports.

1. In the site map of Customer Service admin center, select **Insights** in **Operations**. The **Insights** page appears.

1. In **Knowledge analytics**, select **Manage**. The **Knowledge analytics** page is displayed.
    
      :::image type="content" source="../media/knowledge-analytics_csac.png" alt-text="Screenshot of the Insights page in Custom service admin center":::

1. Set the **Enable Knowledge analytics** toggle to **On** to enable the reports or set the toggle to **Off** to disable the reports.

1. Select **Save** or **Save and Close**.

## Configure Search term insights dashboard

1. In the site map of Customer Service admin center, select **Insights** in **Operations**. The **Insights** page appears.

1. In the **Knowledge analytics** section, select **Manage**. The **Knowledge analytics** page is displayed.

1. In the **Additional features** section, select the **Add knowledge search analytics** checkbox.

1. Select **Save** or **Save and Close**.

## View Knowledge analytics dashboards

- To view the reports in Customer Service Hub, go to **Service** > **Insights** > **Knowledge analytics**.

- To view the reports in Customer Service workspace, select the hamburger menu, and then select **Knowledge analytics** in the site map. The **Article insights** dashboard is displayed. The **Search term insights** are displayed if you previously configured the steps in [Configure Search term insights dashboard](#configure-search-term-insights-dashboard).

If you customized the Customer Service workspace app, you must complete the following steps to be able to view the reports.

1. On the Customer Service workspace app tile, select the ellipsis for **More Options**, and then select **Open in App Designer**.
1. Select **New**.
1. On the **New page** dialog, select **Dataverse Table** for Knowledge analytics, and then select **Next**.
1. To add a Dataverse table, select the **Select existing table** option, and then select **Knowledge analytics**.
1. Select **Show in navigation**, and then select **Add**.
1. From **Navigation**, select **Knowledge analytics**, and then select **Settings**.
1. Enter the following information:
    - **Title**: Knowledge analytics
    - **Icon**: Select **Use web resource**.
    - **Select icon**: msdyn_/Analytics/imgs/KnowledgeSearchIcon.svg
    - **ID**: KSIReportsSubArea
1. Select **Advanced Settings**, and then select the following checkboxes:
      - **SKU**: **All**, **On premise**, **Live**, and **SPLA**.
      - **Client**: **Web**.
1. Select **Save**, and then select **Publish**.

### Related information

[Introduction to Customer Service analytics and insights](../implement/customer-service-analytics.md)  
[View and understand Customer Service analytics and insights in Customer Service Hub](../use/customer-service-analytics-insights-csh.md)  
[View and understand Customer Service analytics](../implement/customer-service-analytics.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
