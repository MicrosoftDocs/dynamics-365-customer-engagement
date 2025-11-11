---
title: Manage historical analytics reports in Omnichannel for Customer Service
description: Learn how to enable and customize Omnichannel historical analytics reports for BI and AI-driven insights in customer service operations.
ms.date: 11/11/2025
ms.topic: how-to
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Manage historical analytics reports in Omnichannel for Customer Service

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

You can configure Omnichannel historical analytics to give your service managers a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support conversations and to group related conversations into topics.

By default, the Omnichannel historical analytics reports are enabled for the System Administrator, Omnichannel Administrator, Omnichannel Supervisor, and CSR Manager roles. To configure other user roles to access analytics and dashboards, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).
The historical analytics reports include:

- [Summary](../use/omnichannel-summary-dashboard.md)
- [Conversation](../use/oc-conversation-dashboard.md)
- [Queue](../use/oc-queue-dashboard.md)
- [Voice](../use/voice-channel-reports-analytics.md)
- [Voicemail](../use/oc-voicemail-dashboard.md)
- [Agent](../use/agent-dashboard.md)
- [Bot](../use/oc-bot-dashboard.md)
- [Proactive outbound](/dynamics365/contact-center/use/proactive-outbound-dashboard.md)

> [!NOTE]
> The reports retain their current state even when you switch session tabs. However, if you customized the Copilot Service workspace app, complete the steps provided [here](analytics_overview.md#keep-the-report-state-when-you-switch-session-tabs) to keep the report state.


## Manage Omnichannel historical analytics reports

Use the Copilot Service admin center or Customer Service Hub app to enable or disable the Omnichannel historical analytics reports.

1. In the site map of Copilot Service admin center, select **Insights** in **Operations**. The **Insights** page appears.
1. In the **Omnichannel historical analytics** section, select **Manage**. The **Omnichannel historical analytics** page is displayed.
1. Set the **Enable Omnichannel historical analytics report** toggle to **On** to enable the reports or set the toggle to **No** to disable the reports.
1. Select **Save** or **Save and Close**.

This configuration enables AI-discovered topics from conversations with default settings.

## Enable historical analytics for Copilot agents in Omnichannel for Customer Service

In Copilot Service admin center, you can enable the historical analytics for AI agents (agents) to give your service managers integrated reports that combine Copilot agents and Omnichannel conversation metrics.

> [!IMPORTANT]
>
> Omnichannel historical analytics must be enabled before you can enable historical analytics for agents. This feature is available only if Copilot agents are integrated with Omnichannel for Customer Service.

- If you select this option, the Omnichannel Summary and Bot dashboards appear as options in the dashboard filter for the Omnichannel historical analytics report. The Bot dashboard shows metrics specific to the Copilot agent.

 :::image type="content" source="../media/oc-bot-session-dashboard.png" alt-text="Copilot Studio bot dashboard.":::
  
- If no Copilot agents are integrated with the application or you didn't select this option, then the Bot dashboard displays the key performance indicators (KPIs) and charts for all agents.

 :::image type="content" source="../media/bot-dashboard-oc.png" alt-text="Dashboard for all bots.":::

**Enable historical analytics for agents in Omnichannel for Customer Service**

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
1. In the **Omnichannel historical analytics** section, select **Manage**. The **Omnichannel historical analytics** page appears. 
1. Select the **Add historical analytics for bot** checkbox.
1. Select **Save** or **Save and Close**.


## Enable historical analytics for voice in Omnichannel for Customer Service

You can enable the historical analytics dashboard for voice in the Copilot Service admin center app. The metrics are available in the dashboard 24 hours after you enable historical analytics.

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
1. In the **Omnichannel historical analytics** section, select **Manage**.
1. The **Omnichannel historical analytics** page appears. Select the **Add historical analytics for voice** checkbox.
1. Select **Save** or **Save and Close**.

In the Omnichannel historical analytics report, use the dashboard filter to go to the **Voice** dashboard.

## Enable historical analytics for voicemail in Omnichannel for Customer Service

You can enable the historical analytics dashboard for voicemail in the Copilot Service admin center app. The metrics are available in the dashboard after 24 hours of enabling it.

1. In Copilot Service admin center, select **Insights** in **Operations**.
1. For Omnichannel historical analytics, select **Manage**.
1. Select **Add historical analytics for voicemail**.

## Enable omnichannel historical analytics for proactive outbound engagements

You can get insights about your contact center performance for proactive outbound engagements. The Proactive Outbound dashboard is available in Dynamics 365 Contact Center only.

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
1. In the **Omnichannel historical analytics** section, select **Manage**.
1. The **Omnichannel historical analytics** page appears. Select the **Add historical analytics for proactive outbound** checkbox.
1. Select **Save** or **Save and Close**.

## View Omnichannel historical analytics reports

If you customized the Copilot Service workspace app, you must complete the following steps to be able to view the reports.

1. On the Copilot Service workspace app tile, select the ellipsis for **More Options**, and then select **Open in App Designer**.
1. Select **New**.
1. On the **New page** dialog, select **Dataverse Table** for Omnichannel historical analytics, and then select **Next**.
1. To add a Dataverse table, select the **Select existing table** option, and then select **Omnichannel historical analytics**.
1. Select **Show in navigation**, and then select **Add**.
1. From **Navigation**, select **Omnichannel historical analytics**, and then select **Settings**.
1. Enter the following information:
    - **Title**: Omnichannel historical analytics
    - **Icon**: Select **Use web resource**.
    - **Select icon**: msdyn_/Analytics/imgs/OmnichannelReportIcon.svg
    - **ID**: OCReportsSubArea
1. Select **Advanced Settings**, and then select the following checkboxes:
    - **SKU**: **All**, **On premise**, **Live**, and **SPLA**.
    - **Client**: **Web**.
    - **Outlook shortcut**: **Offline availability**.
1. Select **Save**, and then select **Publish**.

### Related information

[Dashboard Overview](../use/customer-service-analytics-insights-csh.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
