---
title: "Plug-in development (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "Learn more about how to develop plug-ins that can integrate with Dynamics 365 for Customer Engagement apps to modify or augment the standard behavior of the platform. "
ms.custom: 
ms.date: 1/18/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: aa037f4a-b5ae-485c-aac9-8a138a57c576
caps.latest.revision: 30
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Plug-in development

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

A plug-in is custom business logic (code) that you can integrate with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] apps to modify or augment the standard behavior of the platform. Another way to think about plug-ins is that they are handlers for events fired by [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps. You can subscribe, or register, a plug-in to a known set of events to have your code run when the event occurs.

> [!NOTE]
> In this documentation release, the plug-in documentation that is common to all [!INCLUDE[pn_dynamics_365](../includes/pn-dynamics-365.md)] deployment types has been moved to the [Common Data Service for Apps](/powerapps/developer/common-data-service/overview) documentation set. The sub-sections that follow contain only the information specifically related to developing plug-ins for an on-premises or IFD deployment. To learn about plug-in development, start by reading the plug-in [documentation](/powerapps/developer/common-data-service/apply-business-logic-with-code) under Common Data Service (CDS) for Apps, and then if you are targeting an on-premises/IFD deployment, read the sub-topics that follow this topic.
  
 For more information about plug-in run-time execution, see [Event Framework](/powerapps/developer/common-data-service/event-framework).  
  
## In This Section

 [Impersonation in Plug-ins](impersonation-plugins.md)  

 [Register and Deploy Plug-ins](register-deploy-plugins.md)  
  
 [Debug a Plug-in](debug-plugin.md) 

 [Support offline execution](support-offline-execution.md)  
  
## Related Sections  
 [Write Plug-Ins to Extend Business Processes](write-plugin-extend-business-processes.md)  
 [Web Service Authentication and Impersonation](authenticate-users.md)