---
title: "addOnPostSearch (Client API reference) in Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.date: 10/04/2018
ms.service: crm-online
ms.topic: reference
applies_to: Dynamics 365 for Customer Engagement (online)
ms.assetid: 9d000628-5dbe-45bd-9c47-e19187ffdae7
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# addOnPostSearch (Client API reference)

[!INCLUDE[](../../../../includes/cc_applies_to_update_9_0_0.md)]

Adds an event handler to the [PostSearch](../events/postsearch.md) event. 

## Control types supported

knowledge base search control

## Syntax

```
var kbSearchControl = formContext.getControl("<name>");
kbSearchControl.addOnPostSearch(myFunction);
```

## Parameters

|Name | Type | Required | Description|
|--|--|--|--|
|myFunction |Function |Yes|The function to add to the **PostSearch** event. The [execution context](../../clientapi-execution-context.md) is automatically passed as the first parameter to this function.| 

### Related topics

[PostSearch event](../events/postsearch.md)

[removeOnPostSearch](removeOnPostSearch.md)
