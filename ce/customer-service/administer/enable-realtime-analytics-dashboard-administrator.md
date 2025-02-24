---
title: Manage real-time analytics reports in Omnichannel for Customer Service
description: Configure real-time analytics in Omnichannel for Customer Service to give supervisors access to metrics and KPIs.
ms.date: 02/03/2025
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:11/07/2023
---

# Manage real-time analytics reports in Omnichannel for Customer Service

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]


> [!IMPORTANT]
>
> This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with customer service representatives may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their customer service representatives that their communications with end users may be monitored, recorded, or stored.

> [!NOTE]
>  Any visual customizations that you might have made on the preview version will be overwritten when your organization gets upgraded to the latest generally available version. Future updates to the data model will be backward compatible and visual customizations will be retained. More information: [Future data model updates](../use/customize-reports.md#future-data-model-updates)

Real-time analytics reports give your supervisors access to real-time metrics and KPIs that reflect the situation in the contact center as they oversee customer service representatives (service representatives or representatives) who handle customer conversations that come through multiple channels.

The following real-time analytics reports are available:

- Summary
- Voice
- Agents
- Ongoing conversation

Omnichannel real-time analytics reports are on by default for the following roles: System Administrator, Omnichannel Administrator, Omnichannel Supervisor, Analytics Reports author, and CSR manager. To configure user roles to access analytics and dashboards, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

## Manage Omnichannel real-time analytics reports

Omnichannel real-time analytics reports are on by default. You can use the Customer Service admin center app to turn off the Omnichannel real-time analytics reports.

1. Sign in to Dynamics 365, and on the apps page, select Customer Service admin center.
    > [!Note]
    > The Customer Service admin center app is automatically installed in all the Customer Service organizations. More information: [Get started with Customer Service admin center](../implement/cs-admin-center.md#get-started-with-customer-service-admin-center)

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.

1. On the **Insights** page, **Report Settings** section, go to  **Real-time Analytics**, and select **Manage**.

1. On the **Real-time analytics** page, turn off the **Enable Omnichannel real-time analytics** toggle.

1. Optionally, when the **Enable Omnichannel real-time analytics** toggle is on, in the **Additional options** section, you can select the **Add real-time analytics for Omnichannel voice** option. This option is available only if your organization has the voice feature configured.

## View Omnichannel real-time analytics reports

To view the reports in Customer Service workspace or Contact Center workspace, see [Access reports](../use/intro-realtime-analytics-dashboard.md#access-reports).

If you customized the Customer Service workspace or Contact Center workspace app, you must complete the following steps to be able to view the reports.

1. On the Customer Service workspace or Contact Center workspace app tile, select the ellipsis for **More Options**, and then select **Open in App Designer**.
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
[View and understand the Summary report in Omnichannel real-time analytics](../use/realtime-summary-dashboard.md)  
[View and understand the Voice report in Omnichannel real-time analytics](../use/realtime-voice-dashboard.md)  
[View and understand the Agents report in Omnichannel real-time analytics](../use/realtime-agents-analytics.md)  
[View and understand the Ongoing Conversation report in Omnichannel real-time analytics](../use/realtime-ongoing.md)  
[Use report metrics](../use/oc-metrics-dimensions.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
