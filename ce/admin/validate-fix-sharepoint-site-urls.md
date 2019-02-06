---
title: "Validate and fix SharePoint site URLs for Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
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
ms.assetid: 65e2d673-43ee-4e0e-962c-6895cd1ddd6d
caps.latest.revision: 19
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Validate and fix SharePoint site URLs

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

In [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps, [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] site and document location records contain links to site collections, site, document libraries, and folders in [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. These site and document location records are associated with [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps records so that the documents for [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps records can be stored in [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)].  
  
 When the links between [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps and [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] break, you must validate and fix the links so that the [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps records continue to point to the correct document libraries and folders for managing the documents.  
  
1. [!INCLUDE[proc_permissions_system_admin](../includes/proc-permissions-system-admin.md)]  
  
    Check your security role  
  
   - [!INCLUDE[proc_check_your_security_role](../includes/proc-check-your-security-role.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. Find and fix the URLs. To do this, follow these steps.  
  
   1. [!INCLUDE[proc_settings_doc_mgmt](../includes/proc-settings-doc-mgmt.md)]  
  
   2. Click **[!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] Sites**.  
  
   3. Select the site URLs that you want to validate, and then click or tap **Validate**.  
  
3. [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps validates all the selected site URLs and their immediate subordinate site and document library URLs. It then displays the results in **Validating Sites**.  
  
4. To fix a URL, open the site record, and enter the correct URL. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create or edit site records](edit-existing-sharepoint-site-records.md).  
  
5. Click **Save & Close**.  
  
### See also  
 [Create or edit site records](edit-existing-sharepoint-site-records.md)   
