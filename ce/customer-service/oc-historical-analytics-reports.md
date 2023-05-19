---
title: "Manage historical analytics reports in Omnichannel for Customer Service | MicrosoftDocs"
description: "Use this article to learn how to configure historical analytics reports for Omnichannel for Customer Service."
ms.date: 02/02/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Manage historical analytics reports in Omnichannel for Customer Service

You can configure Omnichannel historical analytics to give your service managers a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support conversations and to group related conversations into topics.

By default, the Omnichannel historical analytics reports are enabled for the System Administrator, Omnichannel Administrator, Omnichannel Supervisor, and CSR Manager roles. To configure other user roles to access analytics and dashboards, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

The historical analytics reports include:

- [Summary](omnichannel-summary-dashboard.md)
- [Conversation](oc-conversation-dashboard.md)
- [Queue](oc-queue-dashboard.md)
- [Voice](voice-channel-reports-analytics.md)
- [Voicemail](oc-voicemail-dashboard.md)
- [Agent](agent-dashboard.md)
- [Bot](oc-bot-dashboard.md)
- [Conversation Topics](oc-conversation-topics-dashboard.md)
- [Unified routing](oc-historical-analytics-unified-routing.md)

## Manage Omnichannel historical analytics reports

Use the Customer Service admin center or Customer Service Hub app to enable or disable the Omnichannel historical analytics reports.

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     1. In the **Omnichannel historical analytics** section, select **Manage**. The **Omnichannel historical analytics** page is displayed.
     1. Set the **Enable Omnichannel historical analytics report** toggle to **On** to enable the reports or set the toggle to **No** to disable the reports.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     1. In the site map, select **Settings** in **Insights**. The **Insights** page appears.
     1. In the **Omnichannel historical analytics** section, select **Manage**. The **Omnichannel historical analytics** page is displayed. 
     1. Set the **Status** toggle to **Enabled** to enable the reports or set the toggle to **Disabled** to disable the reports.

1. Select **Save** or **Save and Close**.

This configuration will also enable AI-discovered topics from conversations with default settings and historical analytics for unified routing.

## Enable historical analytics for unified routing in Omnichannel for Customer Service

You can enable historical analytics for unified routing in the Customer Service admin center or Omnichannel admin center app. The metrics are available in the report after 24 hours.

> [!IMPORTANT]
>
> Omnichannel historical analytics must be enabled before you can enable historical analytics for unified routing.

1. Go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     1. In the **Omnichannel historical analytics** section, select **Manage**.

     The **Omnichannel historical analytics** page is displayed. Select the **Add historical analytics for unified routing** checkbox.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     1. In the site map, select **Settings** in **Insights**. The **Insights** page appears.
     2. In the **Historical analytics for unified routing** section, select **Manage**.

      The **Historical analytics for unified routing** page appears. Toggle the **Status** to **Enabled**.    

1. Select **Save** or **Save and Close**.
    
The Unified routing historical analytics report will be available as a tab in the Omnichannel historical analytics report.

## Enable historical analytics for bots in Omnichannel for Customer Service

In Customer Service admin center, you can enable the historical analytics for bots to give your service managers integrated reports that combine Power Virtual Agents bots and Omnichannel conversation metrics.

> [!IMPORTANT]
>
> Omnichannel historical analytics must be enabled before you can enable historical analytics for bots. This feature is available only if Power Virtual Agents bots are integrated with Omnichannel for Customer Service.

- If you select this option, the Omnichannel Summary and Bot dashboards will be available as a tab in the Omnichannel historical analytics report. The Bot dashboard shows metrics specific to the Power Virtual Agents bot.

 :::image type="content" source="media/oc-bot-session-dashboard.png" alt-text="Power Virtual Agents bot dashboard.":::
  
- If no Power Virtual Agents bots are integrated with the application or you haven't selected this option, then the Bot dashboard displays the key performance indicators (KPIs) and charts for all bots.

 :::image type="content" source="media/bot-dashboard-oc.png" alt-text="Dashboard for all bots.":::

**Enable historical analytics for bots in Omnichannel for Customer Service**

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
1. In the **Omnichannel historical analytics** section, select **Manage**. The **Omnichannel historical analytics** page is displayed. 
1. Select the **Add historical analytics for bot** checkbox.
1. Select **Save** or **Save and Close**.

The unified routing historical analytics report will be available as a tab in the Omnichannel historical analytics report.

## Enable historical analytics for voice in Omnichannel for Customer Service

You can enable the historical analytics dashboard for voice in the Customer Service admin center or Omnichannel admin center app. The metrics will be available in the dashboard 24 hours after you've enabled historical analytics.

> [!IMPORTANT]
>
> Omnichannel historical analytics must be enabled before you can enable historical analytics for unified routing.

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     1. In the **Omnichannel historical analytics** section, select **Manage**.

     The **Omnichannel historical analytics** page appears. Select the **Add historical analytics for voice** checkbox.      

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     1. In the site map, select **Settings** in **Insights**. The **Insights** page appears.
     2. In the **Historical analytics for unified routing** section, select **Manage**.

      The **Historical analytics for voice** page appears. Toggle the **Status** to **Enabled**.    

1. Select **Save** or **Save and Close**.

The historical analytics for voice dashboard will be available as a tab in the Omnichannel historical analytics report.

## Enable historical analytics for voicemail in Omnichannel for Customer Service

You can enable the historical analytics dashboard for voicemail in the Customer Service admin center app. The metrics are available in the dashboard after 24 hours of enabling it.

1. In Customer Service admin center, select **Insights** in **Operations**.
1. For Omnichannel historical analytics, select **Manage**.
1. Select **Add historical analytics for voicemail**.

The historical analytics for voicemail dashboard will be available as a tab in the Omnichannel historical analytics report.

### See also

[Dashboard Overview](customer-service-analytics-insights-csh.md)  
[Historical analytics for unified routing in Omnichannel for Customer Service](oc-historical-analytics-unified-routing.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
