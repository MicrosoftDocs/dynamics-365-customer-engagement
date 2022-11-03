---
title: "Configure Omnichannel historical analytics reports | MicrosoftDocs"
description: "Configure historical analytics reports for Omnichannel"
ms.date: 11/03/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure Omnichannel historical analytics reports

You can configure historical analytics to give your service managers a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support conversations and group related support conversations into topics.

The Omnichannel historical analytics reports are turned **On** by default.

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

## Prerequisites

Make sure that you have the required administrator permissions for Dynamics 365.

## Enable Omnichannel historical analytics reports in Omnichannel for Customer Service

If the reports were disabled by you, you can again enable the reports in the Customer Service admin center or Omnichannel admin center app.

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     1. In the **Omnichannel historical analytics** section, select **Manage**.

     The **Omnichannel historical analytics** page is displayed. Toggle the **Enable Omnichannel historical analytics report** to **On**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     1. In the site map, select **Settings** in **Insights**. The **Insights** page appears.
     2. In the **Omnichannel historical analytics** section, select **Manage**.

      The **Omnichannel historical analytics** page is displayed. Toggle the **Status** to **Enabled**.    

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

     The **Omnichannel historical analytics** page is displayed. Select the **Add historical analytics for unified routing** check box.      

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     1. In the site map, select **Settings** in **Insights**. The **Insights** page appears.
     2. In the **Historical analytics for unified routing** section, select **Manage**.

      The **Historical analytics for unified routing** page is displayed. Toggle the **Status** to **Enabled**.    

1. Select **Save** or **Save and Close**.

The Unified routing historical analytics report will be available as a tab in the Omnichannel historical analytics report.

## Enable historical analytics for bots in Omnichannel for Customer Service

You can enable the historical analytics for bots in the Customer Service admin center, to give your service managers integrated reports that combine Power Virtual Agents bots and Omnichannel conversation metrics.

> [!IMPORTANT]
>
> Omnichannel historical analytics must be enabled before you can enable historical analytics for bots. This feature is available only if Power Virtual Agents bots are integrated with Omnichannel for Customer Service.

- If you select this option, the Omnichannel Summary and Bot dashboards, will be available as a tab in the Omnichannel historical analytics report. The Bot dashboard shows metrics specific to the Power Virtual Agents bot.

 :::image type="content" source="media/oc-bot-session-dashboard.png" alt-text="PVA bot dashboard.":::
  
- If no Power Virtual Agents bots are integrated withe application or you don't select this option, the Bot dashboard displays the key performance indicators (KPIs) and charts for all bots.

 :::image type="content" source="media/bot-dashboard-oc.png" alt-text="Dashboard for all bots.":::

**Enable historical analytics for bots in Omnichannel for Customer Service**

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
1. In the **Omnichannel historical analytics** section, select **Manage**. The **Omnichannel historical analytics** page is displayed. Select the **Add historical analytics for bot** checkbox.
1. Select **Save** or **Save and Close**.

The Unified routing historical analytics report will be available as a tab in the Omnichannel historical analytics report.

## Enable historical analytics for voice in Omnichannel for Customer Service

You can enable the historical analytics dashboard for voice in the Customer Service admin center or Omnichannel admin center app. The metrics are available in the dashboard after 24 hours of enabling it.

> [!IMPORTANT]
>
> Omnichannel historical analytics must be enabled before you can enable historical analytics for unified routing.

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     1. In the **Omnichannel historical analytics** section, select **Manage**.

     The **Omnichannel historical analytics** page is displayed. Select the **Add historical analytics for voice** checkbox.      

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     1. In the site map, select **Settings** in **Insights**. The **Insights** page appears.
     2. In the **Historical analytics for unified routing** section, select **Manage**.

      The **Historical analytics for voice** page is displayed. Toggle the **Status** to **Enabled**.    

1. Select **Save** or **Save and Close**.

The historical analytics for voice dashboard will be available as a tab in the Omnichannel historical analytics report.

## Enable historical analytics for voicemail (preview) in Omnichannel for Customer Service

You can enable the historical analytics dashboard for voicemail (preview) in the Customer Service admin center app. The metrics are available in the dashboard after 24 hours of enabling it.

1. In Customer Service admin center, select **Insights** in **Operations**.
1. For Omnichannel historical analytics, select **Manage**.
1. Select **Add historical analytics for voicemail (preview)**. 

The historical analytics for voicemail (preview) dashboard will be available as a tab in the Omnichannel historical analytics report.

### View Omnichannel historical analytics reports

The service managers must have either the Omnichannel Administrator, Omnichannel Supervisor, or CSR Manager role to view the reports.

### Provide report access to additional security roles

Perform the following steps to enable users with different privileges to access reports beyond the default ones.

1. In Dynamics 365, go to **Settings** and select **Advanced settings**.

1. Select **Security** and then **Security roles**.

1. Select the security role that you want to enable access for. For example, agent manager.

1. Select the **Custom Entities** tab.

1. Grant Read privileges to the following entities:
   - **Omnichannel historical analytics**
   - **Insights**

1. Select **Save and close**. The agent manager can now see the Omnichannel historical analytics report.

### See also

[Dashboard Overview](customer-service-analytics-insights-csh.md)  
[Historical analytics for unified routing in Omnichannel for Customer Service](oc-historical-analytics-unified-routing.md)  
