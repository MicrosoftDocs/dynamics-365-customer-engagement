---
title: Configure analytics and insights dashboards
description: Learn how to configure analytics and insights dashboards in Copilot Service admin center and Copilot Service workspace.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to
ms.date: 09/02/2025
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure analytics and insights dashboards

[!INCLUDE[cc-feature-availability-embedded](../../includes/cc-feature-availability.md)]


You can enable and configure the Customer Service Insights features and services and share them with service managers, who can then view and analyze different activities. You can configure the features and services in Copilot Service admin center app, and they can be viewed on both the Customer Service Hub and Copilot Service workspace apps.

> [!NOTE]
> Settings for the Power BI template applications are separate from these services.

## Configuration details

See the following articles for configuring analytics and insights:

- [Configure Customer Service historical analytics](configure-cs-historical-analytics-csh.md)  
- [Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)  
- [Configure AI topic clustering for cases](configure-topics-clustering-cases-cs.md)  
- [Configure Omnichannel real-time analytics](enable-realtime-analytics-dashboard-administrator.md)
- [Configure real-time analytics for record routing](enable-record-routing.md#manage-real-time-analytics-for-record-routing)
- [Configure Knowledge search insights](enable-knowledge-search-insights.md)  
- [Configure intraday insights](../implement/configure-intraday-dashboard-supervisor.md)

## Configure user access to analytics and dashboards

Users with the system administrator or supervisor role can access the analytics and dashboards. To grant other users access to analytics and dashboards, go the Power Platform admin center and [assign a security role](/power-platform/admin/assign-security-roles?tabs=new#tabpanel_1_new).

If you'd like to create a new role for analytics users, then perform the following steps:

1. In your Power Platform admin center environment, select **Settings** in the command bar. The **Settings** page for the environment appears.
1. Select **Users + permissions** > **Security roles**.
1. Select **New role** on the navigation bar. The **Create new role** dialog opens.
1. Enter your role name and business unit.
1. Enter your **Member's privilege inheritance**, as applicable. Learn more in [Define the privileges and properties of a security role](/power-platform/admin/security-roles-privileges?tabs=new#define-the-privileges-and-properties-of-a-security-role).
1. Select **Save**.
1. Select the role that you just created and from the **Custom Tables** dropdown, move through the list of analytics reports, and then grant **Read** privileges for the following entities:

    |Dashboard  |Report entity  |
    |---------|---------|
    |[Omnichannel historical analytics dashboards](../use/omnichannel-analytics-insights.md)    |   msdyn_dataanalyticsreport_oc      |
    |[Omnichannel real-time analytics dashboards](../use/intro-realtime-analytics-dashboard.md)   |   msdyn_dataanalyticsreport_oc_rt      |
    |[Real-time analytics for record routing](../use/rr-overview.md#overview-of-real-time-analytics-for-record-routing)    |   msdyn_dataanalyticsreport_ur_recordrouting_rt      |
    |[Customer Service historical analytics dashboards](../use/customer-service-analytics-insights-csh.md)     |    msdyn_dataanalyticsreport_csrmanager     |
    |[Copilot Analytics ](../use/copilot-analytics-report.md#use-copilot-analytics-report)  |    msdyn_dataanalyticsreport_copilot     |
    |[Knowledge analytics dashboards](../use/knowledge-search-analytics-cs.md#introduction-to-knowledge-analytics)| msdyn_dataanalyticsreport_ksinsights |
1. To grant Read privileges, select **Permission Settings** for a table.
1. On the **Permission Settings** dialog, provide **Read** access.
> [!NOTE]
> For custom roles, select **Read** privileges for [the entities used by historical and real-time analytics](../use/dataverse-entities.md), as applicable.

1. Select **Save**.

> [!NOTE]
> - To bookmark a report, grant **Create**, **Read**, **Write**, and **Delete** privileges to the security roles as applicable, for the **Report Bookmark** custom entity.
> - To edit analytics reports, grant the **Analytics Report Author** role. For information about assigning user roles, go to [Assign roles to users](../implement/add-users-assign-roles.md#assign-roles-to-users).

### Related information

[Create or edit a security role to manage user access](/power-platform/admin/create-edit-security-role#create-a-security-role.md)  
[Introduction to Customer Service analytics and insights](../implement/customer-service-analytics.md)  
[View and understand Customer Service analytics and insights in Customer Service Hub](../use/customer-service-analytics-insights-csh.md)  
[View and understand Customer Service analytics](../implement/customer-service-analytics.md)  
[Manage report bookmarks](../use/manage-bookmarks.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
