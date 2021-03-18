---
title: "Use the Organization Service to read and write data or metadata (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "IOrganizationService is the primary web service that accesses data and metadata for your organization. This web service contains the methods that you use to write code that uses all the data and metadata in Dynamics 365 Customer Engagement"
ms.custom: on-premise
ms.date: 04/01/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 8c212d9c-cfd6-4dcb-9d11-04b7cb472dbc
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---

# Use the Organization Service to read and write data or metadata

In [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)], the primary web service that accesses data and metadata for your organization is <xref:Microsoft.Xrm.Sdk.IOrganizationService>. This web service contains the methods that you use to write code that uses all the data and metadata in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].  
  
 To use the `IOrganizationService` web service, add a reference to the Microsoft.Xrm.Sdk.dll assembly to your [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] project. To access the non-core xRM messages, add a reference to the Microsoft.Crm.Sdk.Proxy.dll assembly to your project also. Alternatively, add the service reference to your project. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Developer resources page](../developer-resources-page.md)
  
## In This Section  
 [Use Execute Multiple to Improve Performance](use-executemultiple-improve-performance-bulk-data-load.md)  
 
## Related Sections  

 [Use the Dataverse Organization Service](/powerapps/developer/common-data-service/org-service/overview)  
 [Use connection strings in XRM tooling to connect to Dynamics 365 Customer Engagement (on-premises)](../xrm-tooling/use-connection-strings-xrm-tooling-connect.md)  
 [Quick Start: Organization service sample (C#)](/powerapps/developer/common-data-service/org-service/quick-start-org-service-console-app)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]