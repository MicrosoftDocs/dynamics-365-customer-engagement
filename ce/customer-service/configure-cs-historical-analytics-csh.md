---
title: "Configure Customer Service historical analytics | MicrosoftDocs"
description: "Learn how to configure Customer Service analytic reports for Customer Service Hub and Customer Service workspace"
ms.date: 11/03/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure Customer Service historical analytics reports

You can configure historical analytics to give your service managers a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support cases and group related support cases into topics.

The Customer Service historical analytics reports are enabled by default.

The historical reports include:

- [Summary report](summary-dashboard-cs.md)
- [Agent report](agent-dashboard-cs.md)
- [Topics report](case-topics-dashboard-cs.md) 
- [Unified routing](cs-historical-analytics-unified-routing.md)

## Enable Customer Service historical analytics reports

Make sure that you have administrator permissions for Dynamics 365.

If the reports are disabled by you, you can again enable the reports in the Customer Service admin center or Customer Service Hub app.

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     
     1. For **Customer Service historical analytics**, select **Manage**.
     
     1. On the **Customer Service historical analytics** page, set the **Enable Customer Service historical analytics report** toggle to **On**.

   ### [Customer Service Hub](#tab/customerservicehub)
    
     1. In the site map, select **Service Management**.
     
     1. Select **Settings** in **Insights**. The **Insights** page appears.
     
     1. In the **Customer Service historical analytics** section, select **Manage**.
     
     1. On the **Customer Service historical analytics** page, set the **Status** toggle to enabled.

1. Select **Save** or **Save and Close**.

   This configuration will also enable AI-discovered topics from cases with default settings.

## Enable historical analytics for unified routing

You can enable historical analytics for unified routing in the Customer Service admin center or Customer Service Hub app. The metrics are available in the report after 24 hours.

> [!IMPORTANT]
>
> Unified routing must be enabled to enable historical analytics for unified routing. More information: [Provision unified routing for Customer Service](provision-unified-routing.md)

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
     
     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     
     1. For **Customer Service historical analytics**, select **Manage**. The **Customer Service historical analytics** page is displayed. 

     1. Select the **Add historical analytics for unified routing** check box.  

   ### [Customer Service Hub](#tab/customerservicehub)
    
     1. In the site map, select **Service Management**.
     
     1. Select **Settings** in **Insights**. The **Insights** page appears.
     
     1. In the **Historical analytics for unified routing** section, select **Manage**. The **Historical analytics for unified routing** page is displayed.

     1. Set the **Status** toggle to enabled.

1. Select **Save and Close**.

After you enable the setting, you can access the report in one of the following ways:

- In Customer Service workspace, select the plus (+) icon, and then select **Customer Service historical analytics**.

- In Customer Service Hub, in **Service**, in the site map, select **Customer Service historical analytics**.

### User roles to view analytics reports

The service managers must have the System Administrator or CSR Manager role to view the reports. 

### Provide report access to additional security roles

Perform the following steps to enable users with different privileges to access reports beyond the default ones.

1. In Dynamics 365, navigate to **Settings** and select **Advanced settings**.

1. Select **Security** and then **Security roles**.

1. Select the security role that you want to enable access for. For example, agent manager.

1. Select the **Custom Entities** tab.

1. Grant Read privileges to the following entities:
   - **Customer Service historical analytics**
   - **Insights**

1. Select **Save and close**. The agent manager can now see the Customer Service historical analytics report.

You can see the following reports by navigating to the **Service** > **Analytics and Insights** > **Customer Service historical analytics** page. By default, the **Summary** page is displayed.

### See also

[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  
[Dashboard overview](customer-service-analytics-insights-csh.md)  
[Knowledge search analytics](knowledge-search-analytics-cs.md)  
[Historical analytics for unified routing in Customer Service](cs-historical-analytics-unified-routing.md)  




[!INCLUDE[footer-include](../includes/footer-banner.md)]
