---
title: "getProcessInstances (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 11/20/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 4ed6c991-59c9-4a69-90d4-635f3f1d397b
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# getProcessInstances (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getProcessInstances-description.md](./includes/getProcessInstances-description.md)]

## Syntax

`formContext.data.process.getProcessInstances(callbackFunction(object));`

## Parameter

|Name|Type|Required|Description|
|--|--|--|--|
|callbackFunction|Function|Yes|The callback function is passed an object with the following attributes and their corresponding values as the key: value pair.<br/>- CreatedOn<br/>- ProcessDefinitionID<br/>- ProcessDefinitionName<br/>- ProcessInstanceID<br/>- ProcessInstanceName<br/>- StatusCodeName<br/><br/>The process instances are filtered according to the user’s privileges.|

### Related topics

[setActiveProcessInstance](setActiveProcessInstance.md)

[formContext.data.process](../formContext-data-process.md)
 


