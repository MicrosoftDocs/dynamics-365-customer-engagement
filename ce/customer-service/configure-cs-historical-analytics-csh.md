---
title: "Manage historical analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to configure Customer Service historical analytics reports in Omnichannel for Customer Service."
ms.date: 10/31/2023
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

## Enable historical analytics for Copilot

Customer Service historical analytics must be enabled and you must opt in to the Copilot help pane and Copilot summaries to turn on analytics for Copilot.

1. In the Customer Service admin center, go to Insights, and on the page that appears, select **Manage** for **Customer Service historical analytics**.

1. On the **Customer Service historical analytics** page, select the **Add historical analytics for Copilot** checkbox, and then save the changes.

You'll see a message on the command bar that your reports are being provisioned and it might take up to 24 hours for the process to complete.

## View Customer Service historical analytics reports

If you've customized the Customer Service workspace, you need to perform the following steps to be able to view the reports.

1. Go to the Customer Service workspace app, and then select the ellipsis to launch App Designer.
1. Select **New**.
1. On the **New page** dialog:

     1. Select **Dataverse Table** for Customer Service historical, Omnichannel historical analytics, and Knowledge analytics.
     1. Select **URL** for Omnichannel real-time analytics and Customized reports.

1. To add Dataverse table:

      1. Select the **Select existing table** option, followed by the required table, and then select **Show in navigation**.
      - For **Customer service historical**, select **Customer Service historical analytics**.
      - For **Omnichannel historical analytics**, select **Omnichannel historical analytics**.
      - For **Knowledge analytics**, select **Knowledge analytics**. 
      2. Select **Add**.
      
1. To add URL:
      1. Add the **URL** and **Title** as provided below, and then select **Add**.

      |Feature Name |URL  |Title |
      |---------|---------|---------|
      |Omnichannel real-time analytics   |  [Organization Url]/main.aspx?pagetype=control&controlName=MscrmControls.Analytics.ReportingControl&data={"featureIds":"e67a1ada-6c62-4b45-b758-0b246f32c1a5"}       |     Omnichannel real-time analytics    |
      |Customized Reports     |  [Organization Url]/main.aspx?pagetype=control&controlName=MscrmControls.Analytics.ModernReportingControl&data={"featureIds":"f2266eb4-226f-4cf1-b422-89c5f48b40cb,09c168be-efe2-4f08-a986-3aab7095c863"}       |  Customized Reports       |

1. Select the area you added from **Navigation**, and then select **Settings**.
1. Rename the **Title**, **Select Icon**, **Update ID**, and set **Table Privileges**.
The following table represents the default settings for historical reports:  

    **Customer Service historical**
    
    |Id  |Icon  |Title |Privilege entity | Privilege |
    |-------|------|------|------|----------|
    |CSHistoricalAnalyticsSubArea|/WebResources/msdyn_/Analytics/imgs/CustomerServiceInsights.svg| Customer Service historical analytics| msdyn_dataanalyticsreport_csrmanager| Read |
    
    **Omnichannel historical analytics**
    
    |Id  |Icon  |Title |Privilege entity | Privilege |
    |---------|---------|---------|---------|-------------|
    |OCReportsSubArea|/WebResources/msdyn_/Analytics/imgs/OmnichannelReportIcon.svg| Omnichannel historical analytics| msdyn_dataanalyticsreport_oc| Read |
    
    **Knowledge analytics**
    
    |Id  |Icon  |Title |Privilege entity | Privilege |
    |---------|---------|---------|---------|-------------|
    |KSIReportsSubArea|/WebResources/msdyn_/Analytics/imgs/KnowledgeSearchIcon.svg | Knowledge analytics| msdyn_dataanalyticsreport_ksinsights| Read |
    
    **Customized reports**
    
    |Id  |Icon  |Title |Privilege entity | Privilege |
    |---------|---------|---------|---------|-------------|
    |CustomizedReportsSubArea|/WebResources/msdyn_/Analytics/imgs/CustomizedReportsIcon.svg | Customized Reports| msdyn_dataanalyticsreport_ksinsights| Read |
    
    **Omnichannel real-time analytics**
    
    |Id  |Icon  |Title |Privilege entity | Privilege |
    |---------|---------|---------|---------|-------------|
    |OCRealtimeReportsSubArea|/WebResources/msdyn_/Analytics/imgs/RealtimeReportIcon.svg | Omnichannel real-time analytics| msdyn_dataanalyticsreport_oc_rt| Read |

1. For **Settings**, fill in the following  details:
    - **SKU**: All, OnPremise, Live, SPLA
    - **Client**: Web
    - **PassParams**: Checked (for OC Real-time / Customized Reports)
    - **Offline availability**: Selected (for OC Real-time / Customized Reports / OC historical)
1. Select **Save**, and then select **Publish**.

### See also

[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  
[Dashboard overview](customer-service-analytics-insights-csh.md)  
[Knowledge search analytics](knowledge-search-analytics-cs.md)  
[Historical analytics for unified routing in Customer Service](cs-historical-analytics-unified-routing.md)  
[View copilot analytics report](copilot-analytics-report.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
