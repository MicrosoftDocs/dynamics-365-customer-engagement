---
title: "removeOption (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 09fd288c-d687-4976-b708-29a466fc35b1
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# removeOption (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Removes an option from a control. 

## Control types supported

optionset, multiselectoptionset

## Syntax

`formContext.getControl(arg).removeOption(value);`

## Parameters

|Name | Type | Required | Description|
|--|--|--|--|
|value |Number |Yes|The value of the option you want to remove.|

### Related topics

[addOption](addOption.md)

[clearOptions](clearOptions.md)

 


