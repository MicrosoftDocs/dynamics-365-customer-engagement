---
title: "Asynchronous service architecture (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "The system architecture can be divided into three major components: the core system, which features the event execution pipeline, the database component, which hosts the asynchronous queue, and the asynchronous service. One benefit of the scalable architecture of Dynamics 365 Customer Engagement (on-premises) is that the asynchronous service can be hosted on servers other than the Dynamics 365 Server, resulting in improved performance."
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
  - asynchronous operations, asynchronous operations, architecture
ms.assetid: e4117ff8-8a4d-4919-af78-0b8b7d15433a
caps.latest.revision: 13
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Asynchronous service architecture

The Dynamics 365 Customer Engagement (on-premises) system architecture can be divided into three major components: the core system, which features the event execution pipeline, the database component, which hosts the asynchronous queue, and the asynchronous service. One benefit of the scalable architecture of Dynamics 365 Customer Engagement (on-premises) is that the asynchronous service can be hosted on servers other than the Dynamics 365 Server, resulting in improved performance. 
  
 Register plug-ins for asynchronous events when they have to perform lots of processing or for functions that are not time critical. Registering a plug-in that performs lots of processing for a synchronous event can adversely affect the performance of Dynamics 365 Customer Engagement (on-premises).  
  
 You should stop the asynchronous service before you unregister a plug-in that was registered to execute asynchronously. Stopping the service prevents a situation where an asynchronous registered plug-in has been queued for execution but for which there is no plug-in assembly currently registered. For example, consider the situation in which a plug-in has been registered to execute asynchronously and the related event has fired. After the asynchronous operation has been queued by the queue manager, you then unregister (delete) the plug-in assembly from the Dynamics 365 Customer Engagement (on-premises) database. In this case, an error occurs when the asynchronous service tries to execute the queued asynchronous operation but the plug-in assembly no longer exists.  
  
## Queue manager  
 The queue manager  creates and manages asynchronous operations that are sent to the asynchronous service either from the event execution pipeline or directly by a Web service call. When an event is raised in the event execution pipeline, and if one or more plug-ins are registered for that event, the queue manager creates a new asynchronous operation in the queue. Throughout the lifetime of the asynchronous operation, its status may change multiple times from creation until it is completed. The queue manager runs as part of the asynchronous service and manages the state changes of the asynchronous operations. A part of the queue manager, known as the asynchronous queue agent, is located on the Dynamics 365 Server.  
  
### See also  
 [Register and Deploy Plug-ins](register-deploy-plugins.md)   
 [Walkthrough: Stop and Start the Asynchronous Service](stop-start-asynchronous-service.md)   
 [Asynchronous Service in Dynamics 365 Customer Engagement (on-premises)](asynchronous-service.md)   
 [AsyncOperation (system job) entity](asyncoperation-system-job-entity.md)  
 [Event execution pipeline](/powerapps/developer/common-data-service/event-framework#event-execution-pipeline)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]