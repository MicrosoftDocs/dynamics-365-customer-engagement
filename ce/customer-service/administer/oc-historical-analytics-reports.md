---
title: Manage omnichannel historical analytics reports in Customer Service
description: Configure omnichannel historical analytics to analyze service performance, track KPIs, and gain AI insights into customer interactions in Dynamics 365 Customer Service and Contact Center.
ms.date: 09/03/2026
ms.topic: how-to
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Manage omnichannel historical analytics reports in Customer Service

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

You can configure omnichannel historical analytics to provide service managers with business intelligence and AI-generated insights into their organization’s service performance. The reports use natural language understanding to automatically detect the language used in your support conversations and to group related conversations into topics.

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
- [Quality Assurance Agent](/dynamics365/contact-center/use/quality-assurance-agent-dashboard)

> [!NOTE]
> The reports retain their current state even when you switch session tabs. However, if you customized the Copilot Service workspace app, [configure the app to retain the report state](analytics_overview.md#keep-the-report-state-when-you-switch-session-tabs).

Dashboard metrics become available 24 hours after you enable historical analytics. In Customer Service workspace, go to the Omnichannel historical analytics dashboard and use the dashboard filter to select the dashboard you want to view.

## Prerequisites

- You must have one of the following roles: System Administrator, Omnichannel Administrator, Omnichannel Supervisor, or CSR Manager. 

To configure other user roles to access analytics and dashboards, review [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

## Manage Omnichannel historical analytics reports

You can manage the Omnichannel historical analytics reports in Copilot Service admin center. Enable the main Omnichannel historical analytics report before you enable the other dashboards on this page.

1. In the site map of Copilot Service admin center, select **Insights** in **Operations**. The **Insights** page appears.
1. In the **Omnichannel historical analytics** section, select **Manage**. The **Omnichannel historical analytics** page appears.
1. Select the **Enable Omnichannel historical analytics report** toggle to enable the related dashboards.
1. Select **Save** to apply changes.

### Enable historical analytics for Copilot agents

On the **Omnichannel historical analytics** page, select **Add historical analytics for bot**, and save the changes.

- If Copilot agents are configured with Dynamics 365 Contact Center and you select this option, the Summary and Bot dashboards appear as options in the dashboard filter for the Omnichannel historical analytics report. The Bot dashboard displays metrics specific to the Copilot agent.

 :::image type="content" source="../media/oc-bot-session-dashboard.png" alt-text="Screenshot of the Copilot agent dashboard.":::

- If no Copilot agents are integrated with the application or you didn't select this option, then the Bot dashboard displays the key performance indicators (KPIs) and charts for all agents.

 :::image type="content" source="../media/bot-dashboard-oc.png" alt-text="Dashboard showing KPIs and charts for all bots.":::


### Enable advanced historical analytics for voice and chat Copilot agents

On the **Omnichannel historical analytics** page, select **Add historical analytics for bot**, and save the changes.

To include custom variables for reporting in Microsoft Copilot Studio:

1. In the **Custom Variables** section, add your reporting variables configured in Microsoft Copilot Studio to enable structured tracking and analysis for line of business, division, product line, and other custom-defined attributes.

1. Save the changes.

You can add a maximum of 15 custom variables.

:::image type="content" source="../media/custom-variables-historical-bot.png" alt-text="Screenshot of custom variables used for advanced bot analytics." lightbox="../media/custom-variables-historical-bot.png":::

### Enable historical analytics for voice

On the **Omnichannel historical analytics** page, select **Add historical analytics for voice**, and save the changes.

### Enable historical analytics for voicemail

On the **Omnichannel historical analytics** page, select **Add historical analytics for voicemail**, and save the changes.

### Enable historical analytics for proactive outbound engagements

You can get insights about your contact center performance for proactive outbound engagements. The Proactive Outbound dashboard is available in Dynamics 365 Contact Center only.

On the **Omnichannel historical analytics** page, select **Add historical analytics for proactive outbound**, and save the changes.

### Enable historical analytics for Quality Assurance Agent

The [Quality Assurance Agent dashboard](/dynamics365/contact-center/use/quality-assurance-agent-dashboard) is available in Dynamics 365 Contact Center only.

On the **Omnichannel historical analytics** page, select **Add historical analytics for quality assurance agent**, and save the changes.

### Enable historical analytics for intent

On the **Omnichannel historical analytics** page, select **Add historical analytics for intent**, and save the changes.

### Related information

[Customer Service dashboards](../use/customer-service-analytics-insights-csh.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
