---
title: "Sample: Serialize and deserialize an entity Instance (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to serialize early-bound and late-bound entity instances into an XML format, and how to de-serialize from an XML format to an early-bound entity instance"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: "pehecke"
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - samples for early-bound classes, serializing and deserializing entities sample
  - sample for serializing and deserializing entities
  - serializing and deserializing entities sample, early-bound class samples
  - early-bound class samples, serializing and deserializing entities sample
ms.assetid: 705f78dc-c392-4ca7-bc48-0ed3fc687a6f
caps.latest.revision: 20
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Serialize and deserialize an entity Instance

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)]. Download the complete sample here [Business management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to serialize early-bound and late-bound entity instances into an XML format, and how to de-serialize from an XML format to an early-bound entity instance.  
  
## Example  
 [!code-csharp[BusinessManagement#SerializeAndDeserialize](../../snippets/csharp/CRMV8/businessmanagement/cs/serializeanddeserialize.cs#serializeanddeserialize)]  
  
### See also  
 [Use the Early Bound Entity Classes in Code](use-early-bound-entity-classes-code.md)   
 [Sample: Initialize a Record From an Existing Record](sample-initialize-record-existing-record.md)   
 [Mix Early and Late Bound Entities](mix-early-late-bound-entities.md)   
 [DataContractSerializer Class](https://msdn.microsoft.com/library/system.runtime.serialization.datacontractserializer.aspx)
