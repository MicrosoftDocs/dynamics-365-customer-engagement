---
title: "How do I check my online service health for Dynamics 365 (online)? | MicrosoftDocs"
ms.custom: ""
ms.date: 06/13/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: c16f1162-f8f4-4ce2-9749-3d0293540d3f
caps.latest.revision: 4
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# How do I check my online service health?

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

You can quickly get a real-time status of your [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] and [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] services. The dashboard on the [!INCLUDE[pn_office_365_admin_center](../includes/pn-office-365-admin-center.md)] provides a comprehensive view of the service health of your online services. If users are having trouble signing in to [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)], check this page to see if there is a service outage.  
  
<a name="BKMK_Snapshot"></a>   

## View a snapshot of service health  
[!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)] You can see a quick snapshot of service health for some of your [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] services. Select **Service health** (from the menu: **Health** > **Service health**) to get more information on all your services.  
  
![Office 365 Admin Center service health dashboard](../admin/media/office-365-admin-center-service-health-dashboard.png "Office 365 Admin Center service health dashboard")  
  
<a name="BKMK_TenantHealth"></a>   

## View Dynamics 365 (online) service health  
Select an [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] service, such as [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)],  to get detailed information on its service health status.  
  
![Office 365 Admin Center service issue](../admin/media/office-365-admin-center-service-issue.png "Office 365 Admin Center service issue")  
  
## View service health history  
Select **View history** in the upper-right corner to view the past 7 or the past 30 days of service. 

![Service health view history](media/view-history.png)

Select an item to see service health status and details for that item. 
  
![Office 365 Admin Center service health history](../admin/media/office-365-admin-center-service-health-history.png "Office 365 Admin Center service health history")  
  
<a name="BKMK_PlannedMaintenance"></a>   

## View planned maintenance  

Select the **Message center** on your home dashboard (from the menu: **Health** > **Message center**) to see if there are any scheduled events for your online service and to view other informative messages.  
  
![Office 365 Admin Center Message Center](../admin/media/office-365-admin-center-message-center.png "Office 365 Admin Center Message Center")  
  
## View instance service health  

If your company has multiple instances of [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)], you can see the health status for individual [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] instances in the [!INCLUDE[pn_dyn_365_admin_center](../includes/pn-dyn-365-admin-center.md)].  
  
1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)]  
  
2. [!INCLUDE[proc_office365_choose_admin_crm](../includes/proc-office365-choose-admin-crm.md)]  
  
3. Select the **Service Health** tab.  
  
![View health of individual instances](../admin/media/o365-instance-health.png "View health of individual instances")  
  
### See also  
 [Use the Organization Insights solution to view metrics about your instance](use-organization-insights-solution-view-instance-metrics.md)<br />
 [Preview feature: Use the Organization Insights dashboard to view metrics about your instance](use-organization-insights-dashboard-view-instance-metrics.md)
