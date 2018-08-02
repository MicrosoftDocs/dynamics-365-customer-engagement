---
title: "Enable SharePoint document management for specific entities for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 07/23/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: ac5a3303-206b-43b0-b0a4-d7346a001ba5
caps.latest.revision: 51
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Enable SharePoint document management for specific entities

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Store the documents related to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] entity records in [!INCLUDE[pn_ms_SharePoint_long](../includes/pn-ms-sharepoint-long.md)] and quickly access, share, and manage these documents from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] by enabling document management on the specific entities.  
  
> [!TIP]
>  If you haven’t set up server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration, you may want to do that before enabling document management for specific entities. For more information, see [Set up SharePoint integration with Microsoft Dynamics 365](set-up-sharepoint-integration.md).  
  
1. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)] Or verify that you have Read and Write privileges on all record types that are customizable.  
  
    Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_doc_mgmt](../includes/proc-settings-doc-mgmt.md)]  
  
3. Click **Document Management Settings**.  
  
4. Select the entities that you want to use to manage [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] documents.  
  
    If a URL is not already specified, enter the URL of the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site where the document locations and folders for storing documents will be created, and then click **Next**.  
  
5. If you use server-based integration (recommended)  
  
   - Check **Based on entity** to have  document libraries and folders that are based on the Dynamics 365 Account entity automatically  created on the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site. Users will not be prompted to create them.  
  
      If you don't want folders automatically created, clear the **Based on entity** check box.  
  
      When you first visit the documents grid, if you want users to confirm folder creation corresponding to the entity record on [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)], clear the **Automatically create folder** check box.  
  
     > [!IMPORTANT]
     >  If you have [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] and [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)], make sure the site is under the same [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] tenant as your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instances.  
     > 
     >  The **Folders will be automatically created on the SharePoint site** option was first introduced in [!INCLUDE[pn_crm_8_1_0_online](../includes/pn-crm-8-1-0-online.md)] and [!INCLUDE[pn_crm_8_1_0_op](../includes/pn-crm-8-1-0-op.md)].  
     >
     > A hierarchical folder structure will not be automatically created in [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] for entities that have more than one many-to-one (N:1) relationship with the parent entity. 

  
   - Click **Finish**.  
  
      For more information on server-based integration, see [Set up SharePoint integration with Microsoft Dynamics 365](set-up-sharepoint-integration.md).  
  
   If you don't use server-based integration  
  
   - If you want the document libraries and folders to be created, specify a valid [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site URL, and make sure the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site  has the [!INCLUDE[pn_crm_list_component_sharepoint_server](../includes/pn-crm-list-component-sharepoint-server.md)] installed. Note, this will also work if you specify a [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)] site URL.  
  
     > [!NOTE]
     >  The list component has been deprecated as of [!INCLUDE[pn_crm_online_2015_update_1](../includes/pn-crm-online-2015-update-1.md)]. For information on converting from the List Component, see [Switching from the list component or changing the deployment](switching-list-component-changing-deployment.md).  
  
   - The remaining steps assume that the specified site is on [!INCLUDE[pn_sharepoint_server_2010](../includes/pn-sharepoint-server-2010.md)] or [!INCLUDE[pn_sharepoint_server_2013](../includes/pn-sharepoint-server-2013.md)] and the site collection for this site has the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] installed.  
  
     By default, a folder for each record is created under the corresponding document library for the entity. For example, for an opportunity record “100 Bikes”, a document library “opportunity” is created, and in it, a folder “100 Bikes\<entityGUID>” is created. The path is ../opportunity/100 Bikes\<entityGUID>.  
  
6. To have the folders created under the parent account or contact, select the **Based on entity** check box. In the list next to the check box, choose **Account** or **Contact**.  
  
    When you select this option, the folders are created under the related account or contact folder.  
  
    The structure is:.../account/Margie's Travel/opportunity/100 Bikes\<entityGUID> where “account” is the document library for the referenced entity that you selected from the list, and “Margie's Travel” is the folder for the referenced record of the selected entity, which in this case it the `Opportunity` entity.  
  
7. Click **Next**.  
  
   [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] creates document libraries for the selected entities on [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] also creates the corresponding document location records that contain the links to these document libraries. The **Document Management Settings** wizard shows the creation status of the document libraries.  
  
### See also  
 [Edit existing SharePoint site records](../admin/edit-existing-sharepoint-site-records.md)   
 [Set up SharePoint integration with Microsoft Dynamics 365](set-up-sharepoint-integration.md)
