---
title: "Set up SharePoint integration with Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: b066f14a-e1a8-4a35-8f46-98ce79c38af3
caps.latest.revision: 40
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Set up SharePoint integration

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]
[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

With [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you can use the document management capabilities of [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)] from within [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. You can store and manage documents in the context of a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] record on a [!INCLUDE[pn_SharePoint_Server_short](../includes/pn-sharepoint-server-short.md)], and leverage the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] infrastructure to share, manage, and collaborate efficiently. Because the documents are stored on a [!INCLUDE[pn_SharePoint_Server_short](../includes/pn-sharepoint-server-short.md)], non-[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users can directly access the documents on the [!INCLUDE[pn_SharePoint_Server_short](../includes/pn-sharepoint-server-short.md)], provided they have the appropriate permissions.  
  
 For document management functionality, you either enable server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration (recommended) or install the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)], a [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] solution, on a site collection in [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. Server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration is recommended instead of the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] for the following reasons.  
  
-   Users sign-in once and do not have to sign-in to both [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. With the list component, users must sign in to both.  
  
-   The list component is a [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] sandboxed solution. Sandboxed solutions are being deprecated and will no longer be available for both [!INCLUDE[pn_microsoft_sharepoint_online](../includes/pn-microsoft-sharepoint-online.md)] and later versions of [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] on-premises. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Sandboxed solutions overview](https://technet.microsoft.com/library/ee721992%28v=office.14%29.aspx)  
  
-   No additional software is required to install on [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)].  
  
- [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] documents will display in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] lists.  
  
-   Users can perform [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] actions from the Dynamics 365 command bar.  
  
### See also 
 [Manage your documents](../admin/manage-documents-using-sharepoint.md)   
 [Permissions required for document management tasks](../admin/permissions-required-document-management-tasks.md)   
 [Validate and fix SharePoint site URLs](../admin/validate-fix-sharepoint-site-urls.md)   
 [Enable SharePoint document management for specific entities](enable-sharepoint-document-management-specific-entities.md)
