---
title: "Configure knowledge analytics dashboards | MicrosoftDocs"
description: "Learn how to configure knowledge analytics dashboards."
ms.date: 11/03/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure knowledge analytics

The Knowledge analytics dashboard is designed to provide your customer service supervisors and knowledge workers with valuable insights into how your support agents are searching and using knowledge articles.

By default, the Knowledge analytics dashboard is enabled.

> [!NOTE]
> Knowledge analytics will not provide information about customer search behavior. Data is only from internal knowledge searches.

## Manage Knowledge analytics dashboard

Use the information in the following section to enable or disable the reports in the Customer Service admin center or Customer Service hub app.

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     1. In the **Knowledge analytics** section, select **Manage**. The **Knowledge analytics** page is displayed.
    
      :::image type="content" source="media/knowledge-analytics_csac.png" alt-text="Screenshot of the Insights page in Custom service admin center":::

   ### [Customer Service Hub](#tab/customerservicehub)
    
     1. In the site map, select **Service Management**.
     2. Select **Settings** in **Insights**. The **Insights** page appears.
     3. In the **Knowledge analytics** section, select **Manage**. The **Knowledge analytics** page is displayed.

    :::image type="content" source="media/cs-enable-analyticsinsights.png" alt-text="Screenshot of Knowledge analytics in Customer Service Hub":::

2. Set the **Enable Knowledge analytics** toggle to **On** to enable the reports or set the toggle to **Off** to disable the reports.

3. Select **Save** or **Save and Close**.

## Configure Search term insights dashboard

1. Go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     1. In the **Knowledge analytics** section, select **Manage**. The **Knowledge analytics** page is displayed.

      ### [Customer Service Hub](#tab/customerservicehub)
    
     1. In the site map, select **Service Management**.
     2. Select **Settings** in **Insights**. The **Insights** page appears.
     3. In the **Knowledge analytics** section, select **Manage**.
      The **Knowledge analytics** page is displayed.

  2. In the **Additional features** section, select the **Add knowledge search analytics** checkbox.

3. Select **Save** or **Save and Close**.

### View Knowledge analytics dashboards

The service managers must have the System Administrator, Knowledge Manager, or CSR Manager role to view the reports.

To view the reports in Customer Service Hub, go to **Service** > **Insights** > **Knowledge analytics**. To view the reports in Customer Service workspace, select the **plus (+)** icon, and then select **Knowledge analytics** from the dropdown list.

The **Article insights** dashboard is displayed. The **Search term insights dashboard** will be displayed if you have previously configured the steps in [Configure Search term insights dashboard](#configure-search-term-insights-dashboard).

### Provide report access to additional security roles

If your organization needs to enable users with different privileges to access reports in addition to the default ones, see [Assign a security role to a user](/power-platform/admin/assign-security-roles).

> [!NOTE]
> The Knowledge analytics dashboard supports content in the English language only and is available in organizations that have the base language set as English.

### See also

[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  
[View and understand Customer Service analytics and insights in Customer Service Hub](customer-service-analytics-insights-csh.md)  
[View and understand Customer Service analytics](customer-service-analytics.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
