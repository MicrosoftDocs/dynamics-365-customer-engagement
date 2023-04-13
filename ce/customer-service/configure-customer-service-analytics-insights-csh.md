---
title: "Configure analytics and insights dashboards | MicrosoftDocs"
description: "Learn how to configure analytics and insights dashboards in Customer Service admin center and Customer Service workspace."
ms.date: 04/13/2023
ms.topic: article
author: lalexms
ms.author: laalexan
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
---

# Configure analytics and insights dashboards

You can enable and configure the Customer Service Insights features and services and share them with service managers, who can then view and analyze different activities. You can configure the features and services in Customer Service admin center app, and they can be viewed on both the Customer Service Hub and Customer Service workspace apps.

> [!NOTE]
> Settings for the Power BI template applications are separate from these services.

## Configuration details

See the following articles for configuring analytics and insights:

- [Configure Customer Service historical analytics](configure-cs-historical-analytics-csh.md)  
- [Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)  
- [Configure AI topic clustering for cases](configure-topics-clustering-cases-cs.md)  
- [Configure Omnichannel real-time analytics](enable-realtime-analytics-dashboard-administrator.md)  
- [Configure Knowledge search insights](enable-knowledge-search-insights.md)  
- [Configure intraday insights](configure-intraday-dashboard-supervisor.md)  

## Configure user access to analytics and dashboards

Users with the system administrator or supervisor role can access the analytics and dashboards. To grant other users access to analytics and dashboards, go the Power Platform admin center and perform the following steps:

1. Open the [Power Platform admin center](https://admin.powerplatform.microsoft.com/) and select your environment. 

2. In the **Access** section, under **Security roles**, select **See all**. A list of security roles available in the environment is displayed.

3. To add privileges to an existing role, select a role from the list of security roles, and then select **Edit** on the navigation bar. 
   
    If you'd like to create a new role for analytics users, then perform the following steps:
    a. Select **New role** on the navigation bar. The **New Security role** dialog opens. <br>
    b. On the **Details** tab, enter a name in the **Role Name** field.

4. Select the **Custom Entities** tab, move through the list of analytics reports, and then grant **Read** privileges for the following reports and :
    -  [Omnichannel historical analytics dashboards](omnichannel-analytics-insights.md)
    - [Omnichannel real-time analytics dashboards](intro-realtime-analytics-dashboard.md)    
    - [Customer Service historical analytics dashboards](customer-service-analytics-insights-csh.md)
    - [Knowledge analytics dashboards](knowledge-search-analytics-cs.md)
    - [Report Bookmarks](manage-bookmarks.md)

5. Select **Save and close**.

6. On the **Security roles** page, select the role that you just created or updated, and then select **Add people** to add users to the role.

To bookmark a report, grant **Create**, **Read**, **Write**, and **Delete** privileges to the security roles as applicable, for the **Report Bookmark** custom entity. 

To be able to edit analytics reports, grant the **Analytics Report Author** role. For information about assigning user roles, go to [Assign roles to users](add-users-assign-roles.md#assign-roles-to-users).

### See also

[Create or edit a security role to manage user access](/power-platform/admin/create-edit-security-role#create-a-security-role.md)  
[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  
[View and understand Customer Service analytics and insights in Customer Service Hub](customer-service-analytics-insights-csh.md)  
[View and understand Customer Service analytics](customer-service-analytics.md)  
[Manage report bookmarks](manage-bookmarks.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
