---
title: "Integrate Dynamics 365 Customer Engagement with SharePoint (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: fc7f8994-a531-48d1-8495-3f8663f6c3e3
caps.latest.revision: 52
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Integrate Dynamics 365 Customer Engagement with SharePoint

[!INCLUDE[pn_ms_sharepoint_server](../../includes/pn-ms-sharepoint-server.md)] is a collaboration and content management application that simplifies how people store, find, and share information. It helps people to collaborate effectively by having secure access to documents and information that they require to make business decisions.  
  
 The [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] integration feature enables you to store and manage documents on [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] in the context of a [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] record, and use the [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] document management abilities in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)], such as checking the document in and out, viewing version history, and changing document properties.  
  
 [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] supports two types of integration with [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]: client-to-server and server-to-server (server-based). [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Enable SharePoint integration](get-started-sharepoint-integration.md#SPIntegration)  
  
 Use the `SharePointSite` and `SharePointDocumentLocation` entities to store and manage the [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] location records in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], and the `UserMapping` entity to define custom claim mappings to use a value other than the default value used by [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] to authenticate and authorize [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] users in [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)].  
  
## In This Section  

[Understanding Microsoft Dynamics 365 Customer Engagement (on-premises) and SharePoint Integration](get-started-sharepoint-integration.md)  
[Enable SharePoint Integration](enable-document-management-entities.md)  
[Actions on SharePoint Location Records](actions-on-sharepoint-location-records.md)  
[Define custom claim mapping for SharePoint server-based integration](define-custom-claim-mapping-sharepoint-server-based-integration.md)  
[Sample: Enable Document Management for Entities](sample-enable-document-management-entities.md)  
[Sample: Create, Retrieve, Update, and Delete a SharePoint Location Record](sample-create-retrieve-update-delete-sharepoint-location-record.md)  
[Sample: Retrieve Absolute URL and Site Collection URL of a Location Record](sample-retrieve-absolute-url-and-site-collection-url-of-a-location-record.md)  
  
## Reference  

[Manage your documents using SharePoint](https://technet.microsoft.com/library/dn531062.aspx)  
[SharePoint general development](https://msdn.microsoft.com/sharepoint/default.aspx)  
[Overview of document management in SharePoint 2013](https://technet.microsoft.com/library/cc261933\(v=office.15\).aspx)  
  
## Related Sections  

[Extend Microsoft Dynamics 365 Customer Engagement (on-premises)](../extend-dynamics-365-server.md)   
[Integrate Microsoft Dynamics 365 Customer Engagement (on-premises) with OneNote](integrate-onenote.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]