---
title: "Enable Office Delve with Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 4c8755d3-dd1e-480e-b077-88b45c787b92
caps.latest.revision: 4
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# About Office Delve/Graph

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]
[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Office Graph integration for Dynamics 365 Customer Engagement will be removed on August 31, 2017, at the same time that [Office ends GQL query support](https://msdn.microsoft.com/office/office365/howto/query-office-graph-using-gql-with-search-rest-api). Customers can continue to use Office Graph integration through August 31, 2017. After August 31 that date, the Office Graph trending documents component will cease to function and you’ll see the following error message:

**We can't get to the trending documents. Try again later.**

To disable Office Graph:

1. Go to **Settings** > **Document Management** > **Office Graph Integration**.
2. Remove the Trending Documents dashboard component from existing dashboards.

For more information, see the blog: [Office Graph integration removal](https://blogs.msdn.microsoft.com/crm/2017/07/31/office-graph-integration-removal/).

<!--
This feature was introduced in [!INCLUDE[pn_crm_online_2016_update_shortest](../includes/pn-crm-online-2016-update-shortest.md)].  

 [!INCLUDE[pn_office_delve](../includes/pn-office-delve.md)] is powered by the [!INCLUDE[pn_office_graph](../includes/pn-office-graph.md)] and shows users the most relevant content based on who they work with and what they’re working on. The information in [!INCLUDE[pn_delve](../includes/pn-delve.md)] is tailored to each user. [!INCLUDE[pn_delve](../includes/pn-delve.md)] doesn't change permissions and users will only see what they already have access to. As an admin, you can make sure that you allow your organization to access the [!INCLUDE[pn_office_graph](../includes/pn-office-graph.md)], and that you have set up other [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] services that [!INCLUDE[pn_delve](../includes/pn-delve.md)] uses, for instance [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)] and [!INCLUDE[pn_onedrive_for_business](../includes/pn-onedrive-for-business.md)].  

  
## Requirements  
 The following are required to use [!INCLUDE[pn_delve](../includes/pn-delve.md)] with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]:  
  
- [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)]  
  
- [!INCLUDE[cc_feature_requires_office_365](../includes/cc-feature-requires-office-365.md)]  
  
- [!INCLUDE[cc_Office365PlanRequirement](../includes/cc-office365planrequirement.md)]  
  
- [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)]  
  
-   To use email attachments, you will need [!INCLUDE[pn_Exchange_Online](../includes/pn-exchange-online.md)].  
  
-   [Enable Server-Based SharePoint Integration](set-up-sharepoint-integration.md) and have at least one active [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site.  
  
## Enable Delve  
 System administrators can enable [!INCLUDE[pn_delve](../includes/pn-delve.md)] as follows.  
  
1.  Click **Settings** > **Document Management** > **Manage Office Graph Integration**  
  
2.  Click **Enable Office Graph integration** to enable it, and then click **Next**.  
  
3.  Click **Finish**.  
  
-->

### See also  
 [View relevant and trending information on a dashboard with Office Delve](../basics/view-relevant-trending-information-office-delve.md)