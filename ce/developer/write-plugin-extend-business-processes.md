---
title: "Write plug-ins to extend business processes (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "A plug-in is custom business logic that you can integrate with Dynamics 365 for Customer Engagement (online) Customer Engagement to modify or augment the standard behavior of the platform. Plug-ins are event handlers since they are registered to execute in response to a particular event being fired by the platform."
ms.custom: 
ms.date: 03/27/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
f1_keywords: 
  - plugins
  - plugin
helpviewer_keywords: 
  - plug-in
ms.assetid: f5a0690c-1783-4b36-96cd-cd34ae41eb41
caps.latest.revision: 34
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Write plug-ins to extend business processes

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Whenever possible, you should first consider applying one of the several declarative process options to define or apply business logic. More information: [Automate your business processes in Customer Engagement apps](automate-business-processes-customer-engagement.md).

When a declarative process doesn’t meet a requirement, as a developer you have several options. This topic will introduce common options to write code.

A plug-in is custom business logic that you can integrate with [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] to modify or augment the standard behavior of the platform. Plug-ins are event handlers since they are registered to execute in response to a particular event being fired by the platform.
  
 The following topics describe how to add custom business logic to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] through the development and registration of plug-ins. For more information about the run-time execution of plug-ins and the plug-in development framework, see [Event Framework](/powerapps/developer/common-data-service/event-framework).  

> [!NOTE]
> [!INCLUDE[cc-cdsnote-1](./includes/cc-cdsnote-1.md)]
>
> The plug-in documentation that is applicable to Dynamics 365 for Customer Engagement apps (online) users is now available in the PowerApps documentation at: [Use plug-ins to extend business processes](/powerapps/developer/common-data-service/plug-ins)
>
> [!INCLUDE[cc-cdsnote-2-section](./includes/cc-cdsnote-2-section.md)]
  
## In This Section  
[Plug-in Development](plugin-development.md)
  
## Related Sections  
 [Developer Guide for Dynamics 365 for Customer Engagement apps](developer-guide.md)<br />     
 [Write Workflows to Automate Business Processes in Dynamics 365 for Customer Engagement apps](automate-business-processes-customer-engagement.md)<br />     
 [Package and Distribute Extensions with Dynamics 365 for Customer Engagement apps Solutions](package-distribute-extensions-use-solutions.md)<br /> 
