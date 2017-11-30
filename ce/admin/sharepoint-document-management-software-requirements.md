---
title: "SharePoint Document Management software requirements for Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: 736cf9ab-6a7f-4dc8-940a-d7302e09e858
caps.latest.revision: 55
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# SharePoint Document Management software requirements

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

If you want to use [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)] document management functionality with [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] , you must meet the requirements listed in this topic.  
  
<a name="docman_online"></a>   
## Use document management in Dynamics 365 (online)  
 If you are using server-based integration with [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)], you can use [!INCLUDE[pn_microsoft_sharepoint_online](../includes/pn-microsoft-sharepoint-online.md)] or [!INCLUDE[pn_microsoft_sharepoint_2013](../includes/pn-microsoft-sharepoint-2013.md)] SP1 on-premises (or a later version).  
  
 If you are using the [!INCLUDE[pn_crm_2016_list_component_sharepoint](../includes/pn-crm-2016-list-component-sharepoint.md)], one of the following versions of [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)] must be available:  
  
- [!INCLUDE[pn_microsoft_sharepoint_2013](../includes/pn-microsoft-sharepoint-2013.md)] or [!INCLUDE[pn_microsoft_sharepoint_2013](../includes/pn-microsoft-sharepoint-2013.md)] SP1  
  
- [!INCLUDE[pn_Microsoft_SharePoint_2010](../includes/pn-microsoft-sharepoint-2010.md)] SP1 or SP2  
  
- [!INCLUDE[pn_microsoft_sharepoint_online](../includes/pn-microsoft-sharepoint-online.md)]  
  
**A SharePoint site collection**. You also need to have at least one site collection configured and available for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
Either **Server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration** (recommended) or **[!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)]** must be enabled.  
  
The list component, which is a [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] solution, is not required if you use server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration. Although the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] is the default document management configuration option, we recommend you enable server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Server-based SharePoint integration](../admin/sharepoint-document-management-software-requirements.md#BKMK_enable_servertoserver)  
  
> [!IMPORTANT]
>  The document management feature requires that [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] and [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)] subscriptions be under the same tenant.  
>   
> [!INCLUDE[pn_sharepoint_foundation](../includes/pn-sharepoint-foundation.md)] versions aren’t compatible with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] document management.  
  
 Users who access [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] must have appropriate permissions on the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site collection where the document management components are installed. For more information about how to grant membership on a site collection, see the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] Help.  
  
<a name="BKMK_enable_servertoserver"></a>   

## Server-based SharePoint integration  
 Earlier versions of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] document management use a client-to-server strategy to authenticate and transmit data from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] to [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. Server-based (using server-to-server authentication) [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration provides the following benefits:  
  
-   User interface that is consistent with the newly-updated [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] user interface.  
  
-   To configure and use document management, you do not need to be signed in to both [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)].  
  
-   You no longer need to install or continue to use the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] solution. Note that client-to-server authentication strategies that require [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)] server sandboxing may be deprecated soon. This functionality is required by the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)].  
  
**[!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] authentication method support**  
  
|[!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] version|List component support|Server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration support|  
|---------------------------------------------------------------------------------|----------------------------|-----------------------------------------------------------------------------------------------------------|  
|[!INCLUDE[pn_microsoft_sharepoint_2013](../includes/pn-microsoft-sharepoint-2013.md)] or [!INCLUDE[pn_microsoft_sharepoint_2013](../includes/pn-microsoft-sharepoint-2013.md)] SP1|Yes|Yes with [!INCLUDE[pn_microsoft_sharepoint_2013](../includes/pn-microsoft-sharepoint-2013.md)] SP1 when used with [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]|  
|[!INCLUDE[pn_Microsoft_SharePoint_2010](../includes/pn-microsoft-sharepoint-2010.md)] SP1 or SP2|Yes|No|  
|[!INCLUDE[pn_microsoft_sharepoint_online](../includes/pn-microsoft-sharepoint-online.md)]|Yes|Yes|  
  
> [!NOTE]
>  You can create and view folders when using the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)]. This is not available in server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration.  
  
 For information about how to enable server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration, see [Set up SharePoint integration with Dynamics 365](../admin/set-up-sharepoint-integration.md).  
  
 For more information about the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)], see [Dynamics CRM List Component for SharePoint](../admin/sharepoint-document-management-software-requirements.md#BKMK_listComp).  
  
<a name="BKMK_listComp"></a>   
## Dynamics CRM List Component for SharePoint  
 The [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] makes [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] documents that are stored on [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] available to you in a format that has the look and feel of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. This feature also lets [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] automatically create folders that will be used to store documents related to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records on [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)].  
  
 The [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] has the following benefits:  
  
-   Users can create and view folders when using document management within [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
-   Users can create [custom content types](http://go.microsoft.com/fwlink/p/?LinkID=396378) such as a Sales Contract content type.  
  
> [!IMPORTANT]
> -   Notice that the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] isn’t required when you use server-based integration with [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Server-based SharePoint integration](../admin/sharepoint-document-management-software-requirements.md#BKMK_enable_servertoserver)  
> -   Cient-to-server authentication strategies that require [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] server sandboxing, like those used with the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)],  may be deprecated soon.  
> -   There are two versions of the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)]:  
>   
>     - **[!INCLUDE[pn_crm_2016_list_component_sharepoint_server_2010](../includes/pn-crm-2016-list-component-sharepoint-server-2010.md)]** . This version doesn’t work with [!INCLUDE[pn_sharepoint_2013](../includes/pn-sharepoint-2013.md)].  
>     - **[!INCLUDE[pn_crm_2016_list_component_sharepoint_server_2013](../includes/pn-crm-2016-list-component-sharepoint-server-2013.md)]** . This version doesn’t work with [!INCLUDE[pn_ms_SharePoint_2010_short](../includes/pn-ms-sharepoint-2010-short.md)].  
  
### See also  
 [Download: Microsoft Dynamics CRM 2016 List Component for Microsoft SharePoint Server 2013 or Microsoft SharePoint Server 2010](http://go.microsoft.com/fwlink/p/?LinkID=627384)   
 [Set up and manage tablets and phones](../mobile-app/set-up-dynamics-365-for-phones-and-dynamics-365-for-tablets.md)
