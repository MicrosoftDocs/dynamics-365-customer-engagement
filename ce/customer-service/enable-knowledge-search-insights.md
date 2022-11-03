---
title: "Configure Knowledge search insights for Dynamics 365 in Customer Service Hub and Customer Service workspace | MicrosoftDocs"
description: "Learn how to configure Knowledge search insights in Customer Service Hub and Customer Service workspace"
ms.date: 11/03/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure Knowledge search insights for Dynamics 365 Customer Service

The knowledge search analytics dashboard is designed to provide your organization's customer service supervisors and knowledge workers with valuable insights into how your support agents are finding and using knowledge articles.

The knowledge search analytics dashboard is enabled by default.

> [!NOTE]
> Knowledge search analytics will not provide information about customer search behavior. Data is only from internal knowledge searches.

## Configure the Knowledge search analytics dashboard

If the knowledge search analytics dashboard gets disabled, you can enable the dashboard in the Customer Service admin center or Customer Service Hub app.

**Enable the Knowledge search analytics dashboard**

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     1. In the **Knowledge search analytics** section, select **Manage**.

     The **Knowledge search analytics** page is displayed.

   ### [Customer Service Hub](#tab/customerservicehub)
    
     1. In the site map, select **Service Management**.
     2. Select **Settings** in **Insights**. The **Insights** page appears.
     3. In the **Knowledge search analytics** section, select **Manage**.

      The **Knowledge search analytics** page is displayed. 

    > [!div class=ms-imgBorder]
    > ![Enable knowledge search analytics.](media/cs-enable-analyticsinsights.png "Enable knowledge search analytics")

2. Set the **Enable knowledge analytics** toggle to **On**.

3. Select **Save** or **Save and Close**.

### View Customer Service knowledge search analytics reports

The service managers must have the System Administrator, Knowledge Manager, or CSR Manager role to view the reports.

You can see the reports by navigating to the **Service** > **Insights** > **Knowledge search analytics** page. Search term insights are displayed.

### Provide report access to additional security roles

If your organization needs to enable users with different privileges to access reports in addition to the default ones, see [Assign a security role to a user](/power-platform/admin/assign-security-roles).

> [!NOTE]
> The knowledge base analytics dashboard supports only English and is available only in organizations that have the base language set as English.

### See also

[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  
[View and understand Customer Service analytics and insights in Customer Service Hub](customer-service-analytics-insights-csh.md)  
[View and understand Customer Service analytics](customer-service-analytics.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
