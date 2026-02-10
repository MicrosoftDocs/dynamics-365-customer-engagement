---
title: Manage real-time analytics reports in Dynamics 365 Contact Center
description: Configure real-time analytics in Dynamics 365 Contact Center to give supervisors access to metrics and KPIs.
ms.date: 02/10/2026
ms.topic: how-to
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:11/07/2023
---

# Manage real-time analytics reports

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


> [!IMPORTANT]
>
> This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature isn't intended for use in making, and shouldn't be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with customer service representatives may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their customer service representatives that their communications with end users may be monitored, recorded, or stored.

> [!NOTE]
>  Any visual customizations that you might have made on the preview version will be overwritten when your organization gets upgraded to the latest generally available version. Future updates to the data model will be backward compatible and visual customizations will be retained. Learn more in [Future data model updates](../use/customize-reports.md#future-data-model-updates).

Real-time analytics reports give your supervisors access to real-time metrics and KPIs that reflect the situation in the contact center as they oversee customer service representatives (service representatives or representatives) who handle customer conversations that come through multiple channels.

The following real-time analytics reports are available:

- Summary
- Voice
- Bot
- Agent
- Ongoing conversation
- Backlog conversation
- Intent group
- User group 

The Intent group and User group reports are available in Dynamics 365 Contact Center only.

Omnichannel real-time analytics reports are on by default for the following roles: System Administrator, Omnichannel Administrator, Omnichannel Supervisor, Analytics Reports author, and CSR manager. To configure user roles to access analytics and dashboards, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

> [!NOTE]
> The reports retain their current state even when you switch session tabs. However, if you customized the Copilot Service workspace app, complete the steps provided [here](analytics_overview.md#keep-the-report-state-when-you-switch-session-tabs) to keep the report state.

## Manage Omnichannel real-time analytics reports

Omnichannel real-time analytics reports are on by default. You can use the Copilot Service admin center app to turn off the Omnichannel real-time analytics reports.

1. Sign in to Dynamics 365, and on the apps page, select Copilot Service admin center.
    > [!Note]
    > The Copilot Service admin center app is automatically installed in all the Customer Service organizations. More information: [Get started with Copilot Service admin center](../implement/cs-admin-center.md#get-started-with-copilot-service-admin-center)

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.

1. On the **Insights** page, **Report Settings** section, go to  **Real-time Analytics**, and select **Manage**.

1. On the **Real-time analytics** page, turn off the **Enable Omnichannel real-time analytics** toggle.

1. Optionally, when the **Enable Omnichannel real-time analytics** toggle is on, in the **Additional options** section,

- Select the **Add real-time analytics for Omnichannel voice** option to view analytics related to voice calls. This option is available only if your organization has the voice feature configured.
- Select **Add real-time analytics for intent** to view intent insights.
- Select **Add real-time analytics for bot** to view insights related to bot.

## View Omnichannel real-time analytics reports

To view the reports in Copilot Service workspace, see [Access reports](../use/intro-realtime-analytics-dashboard.md#access-reports).

If you customized the Copilot Service workspace app, you must complete the following steps to be able to view the reports.

1. On the Copilot Service workspace app tile, select the ellipsis for **More Options**, and then select **Open in App Designer**.
1. Select **New**.
1. On the **New page** dialog, select **URL**, and then select **Next**.
1. Enter the following information, and then select **Add**
      - **URL**: [Organization Url]/main.aspx?pagetype=control&controlName=MscrmControls.Analytics.ReportingControl&data={"featureIds":"e67a1ada-6c62-4b45-b758-0b246f32c1a5"}
      - **Title** Omnichannel real-time analytics
1. From **Navigation**, select **Omnichannel real-time analytics**.
1. Enter the following information for **Display options**.
    - **Title**: Omnichannel real-time analytics
    - **Icon**: Select **Use web resource**.
    - **Select icon**: msdyn_/Analytics/imgs/RealtimeReportIcon.svg
    - **ID**: OCRealtimeReportsSubArea
1. Select **Advanced Settings**, and then select the following checkboxes:
    - **SKU**: **All**, **On premise**, **Live**, and **SPLA**.
    - **Client**: **Web**.
    - **Outlook shortcut**: **Pass parameters** and **Offline availability**
1. Select **Save**, and then select **Publish**.

### Related information

[Overview of Omnichannel real-time analytics reports](../use/intro-realtime-analytics-dashboard.md)  
[Summary report](../use/realtime-summary-dashboard.md)  
[Voice report](../use/realtime-voice-dashboard.md)  
[Agent report](../use/realtime-agents-analytics.md)  
[Bot report](/dynamics365/contact-center/use/agent-realtime-dashboard?toc=/dynamics365/customer-service/use/toc.json&bc=../../breadcrumb/toc.yml)
[Ongoing Conversation report](../use/realtime-ongoing.md)  
[Backlog conversation report](../use/realtime-backlog-conv.md)
[Use report metrics](../use/oc-metrics-dimensions.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
