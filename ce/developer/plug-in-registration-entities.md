---
title: "Plug-in registration entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about plug-in registration entities that define a Dynamics 365 Customer Engagement web services (SDK) message, the entities that support a particular message, and the entities used during plug-in registration. These entities do not apply to custom workflow activities. "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bd82dfec-a852-4bb1-8f46-7d574ac50782
caps.latest.revision: 19
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Plug-in registration entities
The plug-in registration entities define a [!INCLUDE[pn_sdk](../includes/pn-sdk.md)] message, the entities that support a particular SDK message, and the entities used during plug-in registration. These entities do not apply to custom workflow activities.  
  
 An *SDK Message* defines a message to the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement platform. The message represents the operation that the platform is to perform. You should not create or update a record of this entity.  
  
 An *SDK Message Filter* defines what entity type, for example, account or contact, supports a particular SDK message. It also identifies whether a custom plug-in can be registered for the message and executed when the message is processed by the event execution pipeline.  
  
 The SDK message processing entities are used when registering a plug-in in the event execution pipeline. An *SDK Message Processing Step* entity identifies the event in the pipeline for which a plug-in should be executed. An *SDK Message Processing Step Image* entity stores a snapshot of an entity, including its attributes, during an event that occurs before or after the core platform operation. An *SDK Message Processing Step Secure Configuration* entity stores secure custom information that is passed to a plug-in’s constructor at run-time.  
  
### See also  
 [Write Plug-Ins to Extend Business Processes](write-plugin-extend-business-processes.md)   
 [SdkMessage Entity](entities/sdkmessage.md)   
 [SdkMessageFilter Entity](entities/sdkmessagefilter.md)   
 [SdkMessageProcessingStep Entity](entities/sdkmessageprocessingstep.md)   
 [SdkMessageProcessingStepImage Entity](entities/sdkmessageprocessingstepimage.md)   
 [SdkMessageProcessingStepSecureConfig Entity](entities/sdkmessageprocessingstepsecureconfig.md)   
 [Plug-in Entities](plug-in-entities.md)
