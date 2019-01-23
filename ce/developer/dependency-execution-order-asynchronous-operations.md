---
title: "Dependency and execution order in asynchronous operations (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "An asynchronous operation can be made dependent with another asynchronous operation. A dependent asynchronous operation does not execute until the operation that it is dependent with has finished executing."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 180b0ac3-b869-4bdf-92a7-c4b0226d9a48
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Dependency and execution order in asynchronous operations

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

An asynchronous operation can be made dependent with another asynchronous operation. A dependent asynchronous operation does not execute until the operation that it is dependent with has finished executing. For example, if asynchronous operation B is dependent with asynchronous operation A, operation B does not execute until after operation A executes and is completed. This dependency between asynchronous operations is established by setting the `AsyncOperation.DependencyToken` attribute, which can contain any string value. Any dependent asynchronous operations must have the same `AsyncOperation.DependencyToken` value.  
  
 The [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps platform establishes which asynchronous operation is dependent when the operations are created in the asynchronous queue. For example, consider three asynchronous operations named A, B, and C, where B and C should only execute after A is completed. To establish the correct dependencies, A must be created in the queue first, followed by B and then C. This is because the order in which the operations are created establishes the sequence of their execution. In this example, all three asynchronous operations have the same `AsyncOperation.DependencyToken`. At run time, A executes first. After A has completed, B executes to completion, and then C executes until completion.  
  
 In the previous example, if operation B is postponed, operation A executes until it is completed and operation C is blocked until operation B is no longer postponed and executes until completed. You can postpone execution of an asynchronous operation by using the `AsyncOperation.PostponeUntil` attribute.  
  
 Any asynchronous operation that has a `AsyncOperation.DependencyToken` value of **null** executes independent of all other asynchronous operations in the queue. The order of execution with regard to other independent operations is not guaranteed. However, asynchronous operations created earlier have a better chance of executing before operations created later.  This assumes that the operations are not postponed and are not set to a state of Completed.  
  
 The dependency token must be set when the asynchronous operation is created. Because [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] apps create asynchronous operations for bulk operations such as bulk email, bulk delete, and import, you cannot make use of the dependency token for these operations. In addition, the dependency token cannot be used to order execution of asynchronous registered plug-ins because the asynchronous operation that executes plug-ins is created by the Queue Manager. For more information, refer to [Asynchronous Service Architecture](asynchronous-service-architecture.md).  
  
### See also  
 [Asynchronous Service in Dynamics 365 for Customer Engagement apps](asynchronous-service.md)   
 [Asynchronous Service in Dynamics 365 for Customer Engagement apps](recurrence-pattern-asynchronous-job-execution.md)
