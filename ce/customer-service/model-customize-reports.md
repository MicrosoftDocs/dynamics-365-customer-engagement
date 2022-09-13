---
title: "Model customization of historical analytics reports in Customer Service | MicrosoftDocs"
description: "Learn how to customize historical analytics reports in Dynamics 365 Customer Service using the Power BI embedded editing experience."
ms.date: 09/13/2022
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
---

# Model customization of historical analytics reports in Customer Service

Model customization enables you to customize the out-of-the-box standard reports and add your own KPIs and metrics to make decisions. You can also integrate any external dataset into the OOB Power BI report. This will enable supervisors to view the key metrics that are important to you.
The model customization capability will be available for Knowledge Management, Omnichannel, and Unified Routing analytical reports.


For more information on visual customization, see [Visual customization of historical analytics reports in Customer Service](customize-reports.md#visual-customization-of-historical-analytics-reports-in-customer-service)


## Prerequisites

- To be able to edit analytics reports, users must have the **Analytics Report Author** role. For information about assigning user roles, go to [Assign roles to users](add-users-assign-roles.md#assign-roles-to-users).
- Have at least one of the historical reports enabled for Customer service manager, Omnichannel 
- Provide access to Power BI for Microsoft service account.
- You have administrative privileges for Dynamics 365 Customer Service and Power BI.
- Make sure that you have administrator permissions (Needs PBI license) for Dynamics 365.
- You have a Power BI Pro or Power BI Premium license for all supervisors and administrators. 
- As a system administrator, you must create and add a security group for Power BI service. Follow these steps to create and add a security group: 
  1. Create a security group in Azure Active Directory (Azure AD), and add Dynamics CCA Data Analytics as a member to that security group.  
More information: Create a basic group and add members using Azure Active Directory. 
  2. As a Power BI admin, enable the service principal in the Developer settings in the Power BI admin portal and the security group that you created in Azure AD. 

     1. Sign in to Power BI service and go to Settings > Admin portal. 
     2. In the admin portal, go to Tenant settings > Developer settings > Allow service principals to use Power BI APIs.
     1. Enable Allow service principals to use Power BI APIs and specify the security group to which you want to give access.
     1. Select **Apply**. 

## Enable model customization of your analytics reports

This section describes how to enable data model customization feature and set up the workspace for Microsoft to provision out of box data model in a “Read-only” workspace and a workspace where the customized report can be published to render it in the customer service workspace.

You can enable the customer service historical analytics reports in the Customer Service admin center or Customer Service Hub app.
1.	In the site map, select Insights in Operations. The Insights page appears.
2.	In the Report settings > Model customization section, select Manage. The Model customization page is displayed. 
3.	Set the Start model customization toggle to On.
Note: The toggle can be set to On, only when the PBI prerequisites are completed and at least one of the BI features is enabled.
4.	Select **Save** or **Save and Close**.

### See also

[Visual customization of historical analytics reports in Customer Service](customize-reports.md#visual-customization-of-historical-analytics-reports-in-customer-service)
[Introduction to Customer Service Insights](introduction-customer-service-analytics.md) <br>
[Configure Customer Service analytics and insights](configure-customer-service-analytics-insights-csh.md) <br>
[Configure Customer Service Analytics dashboards in Power BI](configure-customer-service-analytics-dashboard.md) <br>
[Configure Omnichannel historical analytics](oc-historical-analytics-reports.md)
