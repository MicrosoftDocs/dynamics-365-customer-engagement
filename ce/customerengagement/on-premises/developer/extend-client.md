---
title: "Extend Dynamics 365 Customer Engagement (on-premises) on the client (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn how developers can extend and customize Dynamics 365 Customer Engagement (on-premises) in clients such as web applications, Dynamics 365 for phones, and Dynamics 365 for tablets by using JavaScript and web resources"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - extending Microsoft Dynamics CRM and Dynamics CRM Online, building solutions and modeling your business data
  - building solutions by extending Microsoft Dynamics CRM and Dynamics CRM Online
  - modeling your business data by extending Microsoft Dynamics CRM and Dynamics CRM Online
  - extending Microsoft Dynamics CRM and Dynamics CRM Online, introduction
  - extending Microsoft Dynamics CRM and Dynamics CRM Online, with solutions; customizations; reports; plug-ins; processes; workflows; dashboards; SharePoint; and Outlook
ms.assetid: c6562c62-34fa-40c8-9f48-fae3e7d8b551
caps.latest.revision: 46
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Extend Dynamics 365 Customer Engagement on the client

This section contains information about changes developers and customizers can make to extend [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] in the clients provided for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] -- the web application, [!INCLUDE[pn_Microsoft_Dynamics_CRM_Mobile](../includes/pn-dyn-365-phones.md)], and [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] -- by using [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] and web resources. These clients are designed to allow you to add extensions that can be applied for all clients rather than each one separately.  
  
 Client extensions can provide a very rich and responsive experience for users because the code runs on their device. However, critical business logic should not be applied only by client-side scripts. Unlike extensions that are applied on the server, client extensions can’t apply business logic for data entering the system by other means, such as integrations with other systems, custom clients, or data import.  
  
## In This Section  
 [Use JavaScript with Customer Engagement](use-javascript.md)  
  
 [Work with data using web resources](work-data-using-web-resources.md) 
 
 [Open Forms, Views, and Dialogs with a URL](open-forms-views-dialogs-reports-url.md)  
  
 [Open forms, views, and dashboards in Dynamics 365 Customer Engagement mobile client with a URL](open-forms-views-dashboards-mobile-client-url.md)  
  
 [Web Resources for Customer Engagement (on-premises)](web-resources.md)  
  
## Related Sections  

[Client scripting in Customer Engagement (on-premises) using JavaScript](clientapi/client-scripting.md)

[Customize commands and the ribbon](customize-dev/customize-commands-ribbon.md)
  
  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]