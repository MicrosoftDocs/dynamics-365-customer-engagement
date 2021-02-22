---
title: "Integrate Microsoft Dynamics 365 Customer Engagement with OneNote | MicrosoftDocs"
description: "Set up OneNote Integration in Dynamics 365 Customer Engagement (on-premises) Customer Engagement so that a dedicated OneNote notebook is automatically created for the selected entity records in Dynamics 365 Customer Engagement. This feature provides you the ability to easily take notes in the context of a Dynamics 365 Customer Engagement record in various formats such as pictures, drawings, formatted text (bullet points and tables), and voice recordings in a OneNote notebook. You can access the OneNote notebook directly on the activity wall in the Dynamics 365 Customer Engagement web client or from the record form in the Dynamics 365 Customer Engagement mobile apps."
ms.custom: 
ms.date: 02/07/2018
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: e666b9e9-65a6-4a89-918c-bbb3a6e84515
caps.latest.revision: 17
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Integrate Customer Engagement with OneNote

Set up [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] Integration in [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] so that a dedicated [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] notebook is automatically created for the selected entity records in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. This feature provides you the ability to easily take notes in the context of a Dynamics 365 Customer Engagement (on-premises) record in various formats such as pictures, drawings, formatted text (bullet points and tables), and voice recordings in a OneNote notebook. You can access the OneNote notebook directly on the activity wall in the Dynamics 365 Customer Engagement web client or from the record form in the Dynamics 365 Customer Engagement mobile apps.  
  
> [!NOTE]
>  This feature was introduced in [!INCLUDE[pn_crm_online_2015_update_1](../../includes/pn-crm-online-2015-update-1.md)], and is available only for [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)].  
  
 Developers can enable or detect [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] Integration for an entity in [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] using the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsOneNoteIntegrationEnabled> attribute. [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] integration can only be enabled for an entity when both the following are true:  
  
- Server-based SharePoint integration is enabled between your [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] and [!INCLUDE[pn_sharepoint_online](../../includes/pn-sharepoint-online.md)] instances. [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] Integration is supported only for [!INCLUDE[pn_sharepoint_online](../../includes/pn-sharepoint-online.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure server-based authentication with Dynamics CRM Online and SharePoint Online](https://technet.microsoft.com/library/dn894710.aspx)  
  
- Document management is enabled for the entity. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Enable Document Management for Entities](enable-document-management-entities.md)  
  
  By default, OneNote integration is enabled for the following entities: `Account`, `Lead`, `Opportunity`, and `Product`.  
  
  You must also ensure that the activity feed wall is enabled for an entity to be able to see and use the [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] file for the entity record. For more information about configuring activity feeds wall, see [Configure Activity Feeds](../configure-activity-feeds.md).  
  
  You can use the `SharePointDocumentLocation.LocationType` attribute to identify if the location for an entity record points to a SharePoint folder or to an [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] notebook. This attribute can have the following values:  
  
|                    Attribute                    |                              Value                               |                                                     Description                                                      |
|-------------------------------------------------|------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------|
| `SharePointDocumentLocation.LocationType` | -   `0`: General<br />-   `1`: Dedicated for OneNote Integration | -   Points to a SharePoint folder<br />-   Points to a [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] notebook |
  
 You cannot manually create an instance of `SharePointDocumentLocation` with the value of the `LocationType` attribute as 2. It is automatically created for an entity record when you enable [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] integration for it.  
  
 An entity record in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] can at most have one location record that points to [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] notebook. A [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] notebook is automatically created for a record the first time you select the **OneNote** tab in the activities area in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. The notebook is stored in the associated SharePoint document location record folder for the record. If there is more than one associated folders, the notebook is created in the first folder. Section groups are not supported in OneNote files in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. For more information about using the **OneNote** integration feature, see [Set up and use OneNote in CRM](https://go.microsoft.com/fwlink/p/?LinkId=533463).  
  
### See also  
 [Actions on SharePoint Location Records](actions-on-sharepoint-location-records.md)   
 [SharePointDocumentLocation Entity](../entities/sharepointdocumentlocation.md)   
 [Integrate Microsoft Dynamics 365 Customer Engagement (on-premises) with SharePoint](integrate-sharepoint.md) 
 


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]