---
title: Manage Omnichannel historical analytics reports in Customer Service
description: Configure omnichannel historical analytics to analyze service performance, track KPIs, and gain AI insights into customer interactions in Dynamics 365 Customer Service and Contact Center.
ms.date: 01/23/2026
ms.topic: how-to
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Manage Omnichannel historical analytics reports in Customer Service

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

You can configure Omnichannel historical analytics to give your service managers a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support conversations and to group related conversations into topics.

The historical analytics reports include:

- [Summary](../use/omnichannel-summary-dashboard.md)
- [Conversation](../use/oc-conversation-dashboard.md)
- [Queue](../use/oc-queue-dashboard.md)
- [Voice](../use/voice-channel-reports-analytics.md)
- [Voicemail](../use/oc-voicemail-dashboard.md)
- [Agent](../use/agent-dashboard.md)
- [Bot](../use/oc-bot-dashboard.md)
- [Proactive Outbound](/dynamics365/contact-center/use/proactive-outbound-dashboard)
- [Bot-Intent](/dynamics365/contact-center/use/bot-intent-historical)

> [!NOTE]
> The reports retain their current state even when you switch session tabs. However, if you customized the Copilot Service workspace app, complete the steps provided [here](analytics_overview.md#keep-the-report-state-when-you-switch-session-tabs) to keep the report state.

The metrics on the dashboards are available 24 hours after you enable historical analytics. In Customer Service workspace, on the Omnichannel historical analytics dashboard, use the dashboard filter to go to the required dashboard.

## Prerequisites

- You must have one of the following roles: System Administrator, Omnichannel Administrator, Omnichannel Supervisor, or CSR Manager. 

To configure other user roles to access analytics and dashboards, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

## Manage Omnichannel historical analytics reports

You can manage the Omnichannel historical analytics reports in Copilot Service admin center. You must enable the Omnichannel historical analytics report to enable the other reports available on the page.

1. In the site map of Copilot Service admin center, select **Insights** in **Operations**. The **Insights** page appears.
1. In the **Omnichannel historical analytics** section, select **Manage**. The **Omnichannel historical analytics** page appears.
1. Select the **Enable Omnichannel historical analytics report** toggle to enable the related dashboards.
1. Select **Save** to apply changes.

This configuration enables AI-discovered topics from conversations with default settings.

### Enable historical analytics for Copilot agents

On the **Omnichannel historical analytics** page, select **Add historical analytics for bot**, and save the changes.

- If Copilot agents are configured with Dynamics 365 Contact Center and you select this option, the Summary and Bot dashboards appear as options in the dashboard filter for the Omnichannel historical analytics report. The Bot dashboard displays metrics specific to the Copilot agent.

 :::image type="content" source="../media/oc-bot-session-dashboard.png" alt-text="Screenshot of the Copilot Studio bot dashboard":::
  
- If no Copilot agents are integrated with the application or you didn't select this option, then the Bot dashboard displays the key performance indicators (KPIs) and charts for all agents.

 :::image type="content" source="../media/bot-dashboard-oc.png" alt-text="Dashboard showing KPIs and charts for all bots.":::


### Enable advanced historical analytics for voice and chat Copilot agents

On the **Omnichannel historical analytics** page, select **Add historical analytics for bot**, and save the changes.

To include additional custom variables for reporting in Microsoft Copilot Studio:

1. Select **Add advanced historical analytics for bot**.
1. In the **Custom Variables** section, add your reporting variables configured in Microsoft Copilot Studio to enable structured tracking and analysis for Line of Business, Division, Product Line, and other custom-defined attributes.
1. Save the changes.

You can add a maximum of 15 custom variables.

:::image type="content" source="../media/custom-variables-historical-bot.png" alt-text="Screenshot of custom variables used for advanced bot analytics." lightbox="../media/custom-variables-historical-bot.png":::

### Enable historical analytics for voice

On the **Omnichannel historical analytics** page, select **Add historical analytics for voice**, and save the changes.

### Enable historical analytics for voicemail

On the **Omnichannel historical analytics** page, select **Add historical analytics for voicemail**, and save the changes.

### Enable Omnichannel historical analytics for proactive outbound engagements

You can get insights about your contact center performance for proactive outbound engagements. The Proactive Outbound dashboard is available in Dynamics 365 Contact Center only.

On the **Omnichannel historical analytics** page, select **Add historical analytics for proactive outbound**, and save the changes.

### Enable historical analytics for intent

On the **Omnichannel historical analytics** page, select **Add historical analytics for intent**, and save the changes.

### Related information

[Dashboard Overview](../use/customer-service-analytics-insights-csh.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
