---
title: "View relevant and trending information on a dashboard with Office Delve (Dynamics 365 for Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 09/15/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: e2d95967-f70b-4a68-97d9-a9c889d8fa4f
caps.latest.revision: 13
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - enduser
search.app: 
  - D365CE
---
# View relevant and trending information on a dashboard with Office Delve

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Office Graph integration for Dynamics 365 for Customer Engagement apps will be removed on August 31, 2017, at the same time that [Office ends GQL query support](https://msdn.microsoft.com/office/office365/howto/query-office-graph-using-gql-with-search-rest-api). Customers can continue to use Office Graph integration through August 31, 2017. After August 31 that date, the Office Graph trending documents component will cease to function and you’ll see the following error message:

**We can't get to the trending documents. Try again later.**

To disable Office Graph:

1. Go to **Settings** > **Document Management** > **Office Graph Integration**.
2. Remove the Trending Documents dashboard component from existing dashboards.

For more information, see the blog: [Office Graph integration removal](https://blogs.msdn.microsoft.com/crm/2017/07/31/office-graph-integration-removal/).

<!--
[!INCLUDE[pn_office_delve](../includes/pn-office-delve.md)] in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] is a new way to find and discover relevant and trending documents across your organization. [!INCLUDE[pn_delve](../includes/pn-delve.md)] searches across your company and uses Azure Machine Learning to provide a view of the documents you are most interested in based on who created, viewed, edited, or shared the documents. [!INCLUDE[pn_delve](../includes/pn-delve.md)] is a new dashboard component that can be added to any user or system dashboard so you can view trending information from within [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
 ![Office Delve dashboard in Dynamics 365 for Customer Engagement apps](../basics/media/crm-ua-delve-dashboard.png "Office Delve dashboard in Dynamics 365 for Customer Engagement apps")  
  
 View trending information important to you.  
  
> [!TIP]
> [![Video symbol](../basics/media/video-button.png "Video symbol")](http://go.microsoft.com/fwlink/p/?LinkId=404225) Check out the following video: [Find information fast with Dynamics 365 for Customer Engagement apps(2:39)](https://go.microsoft.com/fwlink/p/?linkid=837816).  
  
 To use [!INCLUDE[pn_delve](../includes/pn-delve.md)], the system administrator must first enable it. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable Office Delve](../admin/enable-office-delve.md).  
  
> [!IMPORTANT]
> [!INCLUDE[cc_feature_requires_office_365](../includes/cc-feature-requires-office-365.md)]  
  
## Add Delve to a dashboard  
 You can add [!INCLUDE[pn_delve](../includes/pn-delve.md)] to an existing dashboard or create a new dashboard and add it.  
  
### Add to a new dashboard  
 To add [!INCLUDE[pn_delve](../includes/pn-delve.md)] to a new dashboard, follow these steps.  
  
1.  On any dashboard page, click **New**.  
  
2.  Choose a layout, and then click **Create**.  
  
3.  Click **DELVE**, and then drag the **DELVE** component onto the dashboard and double-click it to set the properties.  
  
4.  Add other web components as desired.  
  
5.  Save the dashboard.  
  
### Add to an existing user dashboard  
 To add [!INCLUDE[pn_delve](../includes/pn-delve.md)] to an existing user-created dashboard, follow these steps.  
  
1.  Open the user dashboard.  
  
2.  Click **Edit**.  
  
3.  Click **DELVE**, and then drag the **DELVE** component onto the dashboard and double-click it to set the properties.  
  
4.  Save the dashboard.  
  
### Add to an existing system dashboard  
 To add [!INCLUDE[pn_delve](../includes/pn-delve.md)] to an existing system dashboard, follow these steps.  
  
> [!NOTE]
> [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
  
1.  Click **Settings** > **Customizations** > **Customize the System**  
  
2.  Under **Components**, click **Dashboards**. Select a dashboard and then double-click it to view the dashboard components.  
  
3.  Click **DELVE**, and then drag the **DELVE** component onto the dashboard and double-click it to set the properties.  
  
4.  Save the dashboard.  
  
## Open Office Delve  
 From any dashboard with the [!INCLUDE[pn_delve](../includes/pn-delve.md)] web component installed, you can open [!INCLUDE[pn_office_delve](../includes/pn-office-delve.md)] in a separate browser page.  
  
1.  Open a dashboard with the [!INCLUDE[pn_delve](../includes/pn-delve.md)] component installed.  
  
2.  Double-click the **Open Office Delve**![Office Delve](../basics/media/crm-ua-delve-icon.png "Office Delve") icon.  
  
### See also  
 [Enable Office Delve](../admin/enable-office-delve.md)   
 [What is Office Delve?](https://support.office.com/en-us/article/What-is-Office-Delve-1315665a-c6af-4409-a28d-49f8916878ca?ui=en-US&rs=en-US&ad=US)   
 [How does Office Delve know what's relevant to me?](https://support.office.com/en-us/article/How-does-Office-Delve-know-what-s-relevant-to-me-048d502e-80a7-4f77-ac5c-f9d81733c385?ui=en-US&rs=en-US&ad=US)   
 [Office Delve for Office 365 admins](https://support.office.com/en-us/article/Office-Delve-for-Office-365-admins-54f87a42-15a4-44b4-9df0-d36287d9531b?ui=en-US&rs=en-US&ad=US)

-->
