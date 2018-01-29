---
title: "Extend Dynamics 365 Customer Engagement for Outlook (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Dynamics 365 for Outlook lets users interact with data while they’re offline and not connected to a server. Dynamics 365 Customer Engagement includes features that let you extend your solutions to offline scenarios by calling the web services offline from your custom code. In addition, the Sdk assembly provides programmatic support for basic Outlook actions such as synchronization, going offline or online, and Dynamics 365 for Outlook state verification. Offline programming uses the ASP.NET Development Server."
ms.custom: ""
ms.date: 01/29/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "Outlook"
ms.assetid: a5f6fe12-cb80-4ea7-a986-eb9543636bd8
caps.latest.revision: 28
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Extend Dynamics 365 Customer Engagement for Outlook

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

> [!IMPORTANT]
> As of 1/29/2018, based on overwhelming customer feedback and our desire to continue supporting our customers, we have **decided not to deprecate [!INCLUDE[pn-crm-2016-outlook-shortest](../includes/pn-crm-2016-outlook-shortest.md)]** ([!INCLUDE[pn-outlook](../includes/pn-outlook.md)] add-in). Please read [this blog post](https://blogs.msdn.microsoft.com/crm/2018/01/29/continued-support-for-outlook-add-in-dynamics-365-for-outlook/) for more details.

[!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] lets users interact with data while they’re offline and not connected to a server. [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement includes features that let you extend your solutions to offline scenarios by calling the web services offline from your custom code. In addition, the <xref:Microsoft.Crm.Outlook.Sdk> assembly provides programmatic support for basic [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)] actions such as synchronization, going offline or online, and [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] state verification. Offline programming uses the [!INCLUDE[pn_ms_asp_net_development_server](../includes/pn-ms-asp-net-development-server.md)].  
  
 [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] includes features that allow administrators to customize and manage filters for their users. Filter templates provide the starting point for entity synchronization on [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]. Filters determine which entity collections are synchronized to [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] and to [!INCLUDE[pn_MS_SQL_Express](../includes/pn-ms-sql-express.md)] for offline-enabled [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] solutions.  
  
## In This Section   
 [Offline and Outlook Filters and Templates](outlook-client/offline-outlook-filters-templates.md)<br />  
 [Sample: Retrieve Outlook Filters](outlook-client/sample-create-retrieve-outlook-filters.md)<br />  
 [Sample: Use Outlook Methods](outlook-client/sample-outlook-methods.md)<br />
  
## Related Sections  
 [Extend Dynamics 365](extend-dynamics-365-server.md)<br />
 [Supported Extensions for Dynamics 365](supported-extensions.md)<br />
 [The Metadata and Data Models in Dynamics 365](metadata-data-models.md)<br />
 [Extend Dynamics 365 on the server](extend-dynamics-365-server.md)<br />
 [Extend Dynamics 365 on the client](extend-client.md)<br />
 [Customize Dynamics 365 applications](customize-dev/customize-applications.md)<br />
 [Package and distribute extensions using solutions](package-distribute-extensions-use-solutions.md)<br />
 [Integrate Dynamics 365 with SharePoint](integration-dev/integrate-sharepoint.md)<br />
 [Integrate Dynamics 365 with OneNote](integration-dev/integrate-onenote.md)<br />
 <xref href="Microsoft.Dynamics.CRM.savedquery?text=savedquery EntityType" /><br />
 [SavedQuery Entity](entities/savedquery.md)<br />
  

