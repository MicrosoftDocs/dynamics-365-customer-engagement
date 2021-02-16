---
title: "AsyncOperation (system job) entity (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Learn about the system job, also known as an asynchronous operation, is used to define and track the execution of an asynchronous operation, for example an asynchronous registered plug-in, workflow, or other background system operation."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 2745928e-1601-4bde-b777-cdf518a65b92
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# AsyncOperation (system job) entity

A *system job*, also known as an asynchronous operation, is used to define and track the execution of an asynchronous operation, for example an 
asynchronous registered plug-in, workflow, or other background system operation. When dealing with asynchronous plug-ins and workflows, you typically 
don’t create an `asyncoperation` entity record directly. Instead, an `asyncoperation` record is automatically created in the database whenever an 
asynchronous system operation, such as an asynchronous plug-in or a workflow, is going to run. However, you can use the `asyncoperation` entity when you 
develop custom tools to manage or report on asynchronous operations in Dynamics 365 Customer Engagement (on-premises).  
  
 Note that **System Job** is the display name of this entity when you view it in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. When you write code, you use the `asyncoperation` logical name.  
  
### See also  
 [Asynchronous Service in Dynamics 365 Customer Engagement (on-premises)](asynchronous-service.md)   
 [AsyncOperation Entity](entities/asyncoperation.md) 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]