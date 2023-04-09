---
title: "Manage real-time analytics for supervisors | MicrosoftDocs"
description: "Learn how to configure real-time analytics for Omnichannel for Customer Service."
ms.date: 04/06/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Manage real-time analytics reports in Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
>
> This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

You can configure real-time analytics in Omnichannel for Customer Service and give your supervisors access to real-time metrics and KPIs that reflect the situation in the contact center as they oversee agents handling customer conversations coming through multiple channels.

The following real-time analytics reports are available:

- Summary
- Voice
- Agents
- Ongoing conversation

Omnichannel real-time analytics reports aren't enabled by default. Once you enable these reports, the reports get enabled for the System Administrator, Omnichannel Administrator, Analytics Reports author, and CSR manager roles, by default. To configure user roles to access analytics and dashboards, see [Configure user access to analytics and dashboards](configure-customer-service-analytics-insights-csh.md#configure-user-access-to-analytics-and-dashboards).

## Manage Omnichannel real-time analytics reports
Use the Customer Service admin center app to enable or disable Omnichannel real-time analytics reports.

1. Sign in to Dynamics 365, and on the apps page, select Customer Service admin center.
    > [!Note]
    > The Customer Service admin center app is automatically installed in all the Customer Service organizations. More information: [Get started with Customer Service admin center](cs-admin-center.md)

1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.

1. On the **Insights** page, **Report Settings** section, go to  **Real-time Analytics** and select **Manage**.

1. On the **Real-time analytics** page, turn on the **Enable Omnichannel real-time analytics** toggle.

1. In the **Additional options** section, select the **Add real-time analytics for Omnichannel voice** option.
    This option will be available only if your organization has the voice feature configured.

## View Omnichannel real-time analytics reports

To view the reports in Customer Service workspace or Omnichannel for Customer Service, see [View reports](intro-realtime-analytics-dashboard.md#view-reports).

### See also

[Overview of Omnichannel real-time analytics reports](intro-realtime-analytics-dashboard.md)  
[View and understand the Summary report in Omnichannel real-time analytics](realtime-summary-dashboard.md)  
[View and understand the Voice report in Omnichannel real-time analytics](realtime-voice-dashboard.md)  
[View and understand the Agents report in Omnichannel real-time analytics](realtime-agents-analytics.md)  
[View and understand the Ongoing Conversation report in Omnichannel real-time analytics](realtime-ongoing.md)  
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
