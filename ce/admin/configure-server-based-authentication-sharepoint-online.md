---
title: "Configure server-based authentication with Dynamics 365 for Customer Engagement apps (online) and SharePoint Online | MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: e3a88e78-2267-4f08-a0b3-7843787fada6
caps.latest.revision: 18
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Configure server-based authentication with Dynamics 365 for Customer Engagement apps (online) and SharePoint Online

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)] Global administrators can enable document management functionality by using server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration. Server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration allows [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps and [!INCLUDE[pn_microsoft_sharepoint_online](../includes/pn-microsoft-sharepoint-online.md)] to perform a server-to-server connection. Server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration requires no additional software.  
  
> [!IMPORTANT]
>  Once you enable server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration, you won't be able to revert to the previous client-based authentication method. Therefore, you can’t use the [!INCLUDE[pn_list_component_short](../includes/pn-list-component-short.md)] after you have configured your [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps organization for server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration.  
> 
>  Before you implement server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration, see [Important considerations for server-based SharePoint integration](../admin/important-considerations-server-based-sharepoint-integration.md).  
  
 To enable server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration with [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps and [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)], follow these steps.  
  
1. [!INCLUDE[proc_settings_doc_management](../includes/proc-settings-doc-management.md)]  
  
2. Click **Enable server-based SharePoint integration**.  
  
3. The Enable server-based SharePoint integration page appears. Click **Next**.  
  
4. Under **Select where your SharePoint sites are located** make sure **Online** is selected, and then click **Next**.  
  
5. Enter the URL for the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site. The URL should appear similar to https://contoso.sharepoint.com. Click **Next**.  
  
   > [!TIP]
   >  To see your [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site collections, in the [!INCLUDE[pn_office_365_admin_center](../includes/pn-office-365-admin-center.md)], choose **Admin centers** > **[!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]**, and then choose site collections.  
  
6. The site is validated. Click **Enable** > **Finish**.  
  
    If the site cannot be validated, see [Troubleshooting server-based authentication](../admin/troubleshooting-server-based-authentication.md).  
  
   After you complete the **Enable server-based SharePoint integration** wizard, add or remove the entities that will be used for document management with [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)].  
  
7. [!INCLUDE[proc_settings_doc_management](../includes/proc-settings-doc-management.md)]  
  
8. Then go to **Document Management Settings**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable document management on entities](enable-sharepoint-document-management-specific-entities.md)  
  
> [!TIP]
> - ![Video symbol](../admin/media/video-thumbnail-4.png "Video symbol") For an overview and step-by-step configuration details, check out this video [YouTube: Connect CRM Online to SharePoint Online](https://youtu.be/k4MwmqMvM3s).  
> - Once you enable server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration with [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps and [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)], you can then enable [!INCLUDE[pn_microsoft_onenote](../includes/pn-microsoft-onenote.md)] integration. More information: [Set up OneNote integration](set-up-onenote-integration-in-dynamics-365.md)  
  
<a name="BKMK_info_trans_CRMtoSP"></a>   
## Information transmitted between Dynamics 365 for Customer Engagement apps (online) and SharePoint when you use server-based SharePoint integration  
 When you use the document management feature in [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps by using server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration, the following information is transmitted between [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps and [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]:  
  
- Entity name for the entity that is used to create folders in [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)], such as Account, Article, or Lead. To configure the entities that are integrated, go to **Settings** > **Document Management** > **Document Management Settings**.
