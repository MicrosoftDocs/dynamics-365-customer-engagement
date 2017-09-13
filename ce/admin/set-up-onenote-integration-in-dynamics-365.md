---
title: "Set up OneNote integration in Dynamics 365 (online) | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: bb4f1489-238e-4b72-b5a3-cb1f36d2a274
caps.latest.revision: 27
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Set up OneNote integration
Gather your thoughts, ideas, plans and research in one single place with [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
 When you turn on [!INCLUDE[pn_microsoft_onenote](../includes/pn-microsoft-onenote.md)] integration in [!INCLUDE[pn_CRM_online](../includes/pn-crm-online.md)], you have the benefits of using [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] to take or review customer notes from within your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] records.  
  
 You can configure [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] when you’re also using [!INCLUDE[pn_sharepoint_online](../includes/pn-sharepoint-online.md)]. You must have a subscription to [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] to use [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)].  
  
<a name="BKMK_EnableSharePointInt"></a>   
## Step 1: Turn on server-based SharePoint integration  
 Before you can enable [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] integration, you need to [turn on server-based SharePoint integration](https://technet.microsoft.com/library/dn531154.aspx).  
  
 [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)] Or, make sure that you have Read and Write privileges on all record types that are customizable.  
  
#### Check your security role  
  
- [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
- [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
 ![Enable SharePoint Integration](../admin/media/enable-sharepoint-integration.png "Enable SharePoint Integration")  
  
<a name="BKMK_EnableOneNote"></a>   
## Step 2: Turn on [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] integration  
 When server-based [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] integration is turned on, [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] integration is listed in **Document Management**.  
  
1. [!INCLUDE[proc_settings_doc_mgmt](../includes/proc-settings-doc-mgmt.md)]  
  
2.  Choose **OneNote Integration**.  
  
 ![Choose OneNote Integration](../admin/media/onenote-integration.png "Choose OneNote Integration")  
  
3.  Follow the instructions in the wizard to turn on [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] integration for selected entities. Choose entities that need a full notebook per record. Only entities that are already enabled for document management are listed. Choose **Finish**.  
  
 ![Follow instructions in wizard](../admin/media/onenote-integration-wizard.png "Follow instructions in wizard")  
  
4.  You can also enable [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] integration for an entity from the customization form, as long as document management has been enabled for that entity.  
  
 ![Select OneNote integration for an entity](../admin/media/onenote-select-entity.png "Select OneNote integration for an entity")  
  
5.  A [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] notebook is automatically created for a record the first time you select the **OneNote** tab in the activities area in [!INCLUDE[pn_CRM_online](../includes/pn-crm-online.md)]. Once the dedicated [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] notebook is created for that [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] record, you can view and navigate to that notebook from any [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] client.  
  
 ![Select OneNote](../admin/media/select-onenote.png "Select OneNote")  
  
## To turn off [!INCLUDE[pn_onenote](../includes/pn-onenote.md)] integration  
  
1. [!INCLUDE[proc_settings_doc_mgmt](../includes/proc-settings-doc-mgmt.md)]  
  
2.  Choose **OneNote Integration**.  
  
 ![Choose OneNote Integration](../admin/media/onenote-integration.png "Choose OneNote Integration")  
  
3.  In the **OneNote Integration Setting** dialog box, uncheck all the entities and then choose **Finish**.  
  
## See Also  
 [Use OneNote in Dynamics 365 (online)](Use%20OneNote%20in%20Dynamics%20365%20\(online\).md)   
 [OneNote in Dynamics 365 FAQs](../basics/onenote-dynamics-365-faqs.md)   
 [Turn on server-based SharePoint integration](https://technet.microsoft.com/library/dn531154.aspx)   
 [Blog: OneNote in CRM](http://blogs.technet.com/b/lystavlen/archive/2015/03/31/make-a-note-of-this.aspx)