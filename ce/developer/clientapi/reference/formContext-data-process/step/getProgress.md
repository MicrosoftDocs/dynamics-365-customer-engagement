---
title: "getProgress (Client API reference) in Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 56502c8b-af23-40d1-ad97-e780bb757d6d
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# getProgress (Client API reference)

[!INCLUDE[](../../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getProgress-description.md](./includes/getProgress-description.md)]

## Syntax

`var stepProgress = stepObj.getProgress();`

## Return Value

**Type**: Number. 

**Description**: Returns one of the following values:

|Value |Description|
|--|--|
|0|None|
|1|Processing|
|2|Completed|
|3|Failure|
|4|Invalid|

## Remarks

This method is only supported for the action steps.

### Related topics

[formContext.data.process](../../formContext-data-process.md)
 


