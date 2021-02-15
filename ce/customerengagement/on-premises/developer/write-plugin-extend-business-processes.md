---
title: "Write plug-ins to extend business processes (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "A plug-in is custom business logic that you can integrate with Dynamics 365 Customer Engagement (on-premises) Customer Engagement to modify or augment the standard behavior of the platform. Plug-ins are event handlers since they are registered to execute in response to a particular event being fired by the platform."
ms.custom: on-premise
ms.date: 02/13/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
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

---
# Write plug-ins to extend business processes

Whenever possible, you should first consider applying one of the several declarative process options to define or apply business logic. More information: [Automate your business processes in Customer Engagement (on-premises)](automate-business-processes-customer-engagement.md).

When a declarative process doesn’t meet a requirement, as a developer you have several options. This topic will introduce common options to write code.

A plug-in is custom business logic that you can integrate with Customer Engagement (on-premises) to modify or augment the standard behavior of the platform. Plug-ins are event handlers since they are registered to execute in response to a particular event being fired by the platform.
  
 The following topics describe how to add custom business logic to Dynamics 365 Customer Engagement (on-premises) through the development and registration of plug-ins. For more information about the run-time execution of plug-ins and the plug-in development framework, see [Event Framework](/powerapps/developer/common-data-service/event-framework). 

> [!NOTE]
> The documentation that follows describes additional options only available in on-premises environments. For general information about writing plug-ins that work for both on-premises and online deployments, read the [Use plug-ins to extend business processes](/powerapps/developer/common-data-service/plug-ins) topic in the Dataverse documentation.

## In This Section  
[Plug-in Development](plugin-development.md)
  
## Related Sections  
 [Developer Guide for Dynamics 365 Customer Engagement (on-premises)](overview.md)<br />     
 [Write Workflows to Automate Business Processes in Dynamics 365 Customer Engagement (on-premises)](automate-business-processes-customer-engagement.md)<br />     
 [Package and Distribute Extensions with Dynamics 365 Customer Engagement (on-premises) Solutions](package-distribute-extensions-use-solutions.md)<br /> 
 [Use plug-ins to extend business processes in Dataverse](/powerapps/developer/common-data-service/plug-ins)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]