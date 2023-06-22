---
title: "Manage historical analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to configure Customer Service historical analytics reports in Omnichannel for Customer Service."
ms.date: 06/23/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Manage historical analytics reports in Customer Service

You can configure Customer Service historical analytics to give your service managers a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support cases and group related support cases into topics.

By default, the Customer Service historical analytics reports are enabled for the System Administrator and CSR Manager roles. To configure other user roles to access analytics and dashboards, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

The historical reports include:

- [Summary report](summary-dashboard-cs.md)
- [Agent report](agent-dashboard-cs.md)
- [Topics report](case-topics-dashboard-cs.md) 
- [Unified routing](cs-historical-analytics-unified-routing.md)

After you enable the reports, you can access them in one of the following ways:

- In Customer Service workspace, select the hamburger menu, and then select **Customer Service historical analytics** in the site map.

- In Customer Service Hub, in **Service**, in the site map, select **Customer Service historical analytics**.

## Manage Customer Service historical analytics reports

Use the Customer Service admin center or Customer Service Hub app to enable or disable the reports.

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     
     1. For **Customer Service historical analytics**, select **Manage**.
     
     1. On the **Customer Service historical analytics** page, set the **Enable Customer Service historical analytics report** toggle to **On** to enable the reports or set the toggle to **Off** to disable the reports.

   ### [Customer Service Hub (deprecated) ](#tab/customerservicehub)
    
     1. In the site map, select **Service Management**.
     
     1. Select **Settings** in **Insights**. The **Insights** page appears.
     
     1. In the **Customer Service historical analytics** section, select **Manage**.
     
     1. On the **Customer Service historical analytics** page, set the **Status** toggle to **Enabled** to enable the reports or set the toggle to **Disabled** to disable the reports.

1. Select **Save** or **Save and Close**.

   This configuration will also enable AI-discovered topics from cases with default settings.

## Enable historical analytics for unified routing

Use the Customer Service admin center or Customer Service Hub app to enable or disable the reports. The metrics will be available in the report after 24 hours.

> [!IMPORTANT]
>
> Unified routing must be enabled to enable historical analytics for unified routing. More information: [Provision unified routing for Customer Service](provision-unified-routing.md)

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
     
     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     
     1. For **Customer Service historical analytics**, select **Manage**. The **Customer Service historical analytics** page is displayed. 

     1. Select the **Add historical analytics for unified routing** check box.  

   ### [Customer Service Hub (deprecated)](#tab/customerservicehub)
    
     1. In the site map, select **Service Management**.
     
     1. Select **Settings** in **Insights**. The **Insights** page appears.
     
     1. In the **Historical analytics for unified routing** section, select **Manage**. The **Historical analytics for unified routing** page is displayed.

     1. Set the **Status** toggle to enabled.

1. Select **Save and Close**.

## Enable historical analytics for Copilot (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

> [!IMPORTANT]
> [!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

Customer Service historical analytics must be enabled and you must opt in to Copilot help pane and Copilot summaries to turn on analytics for Copilot.

1. In the Customer Service admin center, go to Insights, and on the page that appears, select **Manage** for **Customer Service historical analytics**.

1. On the **Customer Service historical analytics** page, select the **Add historical analytics for Copilot (Preview)** checkbox, and then save the changes.

You'll see a message on the command bar that your reports are being provisioned and it might take up to 24 hours for the process to complete.

### See also

[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  
[Dashboard overview](customer-service-analytics-insights-csh.md)  
[Knowledge search analytics](knowledge-search-analytics-cs.md)  
[Historical analytics for unified routing in Customer Service](cs-historical-analytics-unified-routing.md)  
[View analytics for Copilot impact](copilot-analytics-report.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
