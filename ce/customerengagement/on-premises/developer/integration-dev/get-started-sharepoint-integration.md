---
title: "Get started with SharePoint integration (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "By using SharePoint Server document management capabilities, you can control how documents are created, reviewed, published and disposed or archived"
ms.custom: 
ms.date: 01/20/2021
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 00e5e847-d64c-46c8-92a2-19bcf17b9a76
caps.latest.revision: 57
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Get started with SharePoint integration

[!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] integration enables document management capabilities in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. There are two aspects to [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] integration:  
  
- **Setting up SharePoint integration**. A system administrator sets up a [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] environment. The [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] administrator (a user who has the SharePoint Site Collection Administrator role) selects the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] entities for which to enable the document management feature, and specifies the target [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)]. As part of specifying the target server, the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] administrator specifies the [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] site collection or the [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] site URL by using the                      `SharePointSite` entity.  
  
- **Creating and managing SharePoint document location records**. [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] users can create and manage [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] document location records after [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] integration is enabled. You can create and manage [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] document location records by using the                      `SharePointDocumentLocation` entity. [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] also allows for the automatic creation of folders on the server that is running [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] for entity records under certain conditions. However, automatic creation of folders cannot be done through the [!INCLUDE[cc-dyn365-ce-web-services](../../includes/cc-dyn365-ce-web-services.md)].  
  
<a name="StorageConcepts"></a>   
## SharePoint storage concepts  
 By using [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] document management capabilities, you can control the life cycle of documents in your organization: how they are created, reviewed, published, and disposed or archived. [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] uses a hierarchical storage model to store and manage documents. Some of the [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] storage concepts that you should know are as follows:                  *Site Collection*,                  *Site*,                  *Document Library*, and                  *Document Folder*. These storage objects provide the framework for the content management infrastructure that [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] provides. For more information about these storage concepts, see [Storage levels: content storage benefits and considerations](https://go.microsoft.com/fwlink/p/?LinkId=196843).  
  
<a name="SupportedSPVersions"></a>   
## Software requirements for SharePoint Integration  
 For supported versions of [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] and [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] for [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] integration, see [SharePoint Document Management software requirements for Microsoft Dynamics 365 Customer Engagement (on-premises)](/dynamics365/customerengagement/on-premises/admin/sharepoint-document-management-software-requirements).  
  
<a name="SPIntegration"></a>   
## Enable SharePoint integration  
 [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] integration for [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] can only be enabled using the web or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)]. This isn’t supported through SDK. For more information, see [Set up SharePoint integration](/dynamics365/customerengagement/on-premises/admin/manage-documents-using-sharepoint).  
  
 [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] supports two types of integration with [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]: client-to-server and server-to-server (server-based).  
  
- **Client-to-server integration with SharePoint**: The client-to-server integration is enabled by default. However, for a richer user experience, install the [!INCLUDE[pn_list_component](../../includes/pn-list-component.md)] or [!INCLUDE[pn_microsoft_sharepoint_server_2013](../../includes/pn-microsoft-sharepoint-server-2013.md)].                  For more information about the component, see **Microsoft Dynamics CRM list component for Microsoft SharePoint Server** section later in this topic.  
  
- **Server-to-server integration with SharePoint**: This does not require you to install the [!INCLUDE[pn_list_component_short](../../includes/pn-list-component-short.md)] in [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] or any other additional software to have the [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] document management functionality within [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. After you enable server-based [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] integration for your organization, you can’t revert to the client-based authentication method.  
  
  After enabling [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] integration:  
  
- **Enable document management for entities**: Select the entities in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] for which you want to create and manage documents on [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Enable SharePoint Integration for Entities](enable-document-management-entities.md).  
  
     When you enable document management for an entity in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)], a **Documents** link under the **Common** group in the left pane is added for the all entity records in the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] web application. You can use the **Documents** link to create or manage [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] location records for the entity record.  
  
- **Specify the target SharePoint server**: Specify the URL of a site or site collection on the [!INCLUDE[pn_sharepoint_online](../../includes/pn-sharepoint-online.md)], [!INCLUDE[pn_sharepoint_server_2010](../../includes/pn-sharepoint-server-2010.md)], or [!INCLUDE[pn_sharepoint_server_2013](../../includes/pn-sharepoint-server-2013.md)]. This URL is used to automatically create folders and document libraries on [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)].  
  
<a name="CRMListComponent"></a>   
## Microsoft Dynamics CRM list component for Microsoft SharePoint Server  
 [!INCLUDE[pn_list_component](../../includes/pn-list-component.md)] and [!INCLUDE[pn_microsoft_sharepoint_2013](../../includes/pn-microsoft-sharepoint-2013.md)] is a [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] solution package file (.wsp) that must be installed (uploaded and activated) on the site collection on the target [!INCLUDE[pn_ms_SharePoint_long](../../includes/pn-ms-sharepoint-long.md)] 2010 or 2013 server to enable the following:  
  
- View documents that are stored on the [!INCLUDE[pn_sharepoint_server_2010](../../includes/pn-sharepoint-server-2010.md)] server in a [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] List view (look and feel of Dynamics 365 Customer Engagement (on-premises)).  
  
- Automatic creation of the document locations on the [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] server.  
  
  You can [download and install the Microsoft Dynamics CRM 2013 List Component](https://go.microsoft.com/fwlink/p/?LinkId=516963) for [!INCLUDE[pn_sharepoint_server_2010](../../includes/pn-sharepoint-server-2010.md)] and [!INCLUDE[pn_sharepoint_server_2013](../../includes/pn-sharepoint-server-2013.md)]. To install this component, you must have [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] site collection administrator privileges on the target [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] server.  
  
  There are two versions of the [!INCLUDE[pn_list_component_short](../../includes/pn-list-component-short.md)]:  
  
- **[!INCLUDE[pn_list_component](../../includes/pn-list-component.md)]** : This version only works with [!INCLUDE[pn_ms_SharePoint_2010_short](../../includes/pn-ms-sharepoint-2010-short.md)].  
  
- **[!INCLUDE[pn_crm_list_component_sharepoint_server_2013](../../includes/pn-crm-list-component-sharepoint-server-2013.md)]** : This version only works with [!INCLUDE[pn_sharepoint_2013](../../includes/pn-sharepoint-2013.md)] and [!INCLUDE[pn_sharepoint_online](../../includes/pn-sharepoint-online.md)].  
  
  For more information about installing the component, see [Configure SharePoint integration using the list component](https://technet.microsoft.com/library/dn894708.aspx)  
  
### See also  
 [Integrate SharePoint with Microsoft Dynamics 365 Customer Engagement (on-premises)](integrate-sharepoint.md)   
 [Enable SharePoint Integration for Entities](enable-document-management-entities.md)   
 [Actions on SharePoint Location Records](actions-on-sharepoint-location-records.md)   
 [Define custom claim mapping for SharePoint server-based integration](define-custom-claim-mapping-sharepoint-server-based-integration.md)  
