---
title: "updateContext (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Learn about updateContext (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 11/11/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---
# updateContext (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0


This method allows you to set the automation dictionary. It enables providers to add, modify, and remove values of slugs. The updated values are then available for future macro invocations.

## Syntax

`Microsoft.CIFramework.updateContext(input, sessionId, isDelete, correlationId);`

## Parameters

| Parameter | Type | Required| Description |
| ------- |-------|-------|-------|
|input| JSON Object | Yes | JSON string |
|sessionId| String| Yes | Unique identifier of the current session. |
|isDelete| Boolean | No | Set `isDelete` to `true` if the list of parameters in `input` JSON are to be deleted.<br />If `isDelete` is set to `true`, the slug values will be deleted and will no longer be available for subsequent macro invocations.|
|correlationId| GUID| No |Used to group all related API calls together for diagnostic telemetry|

## Return value

Returns a promise with string value.

## Example


```javascript
var sessionId = await Microsoft.CIFramework.getFocusedSession().then(successCallback, errorCallback);
var input = { "customerName" : "Contoso" };
Microsoft.CIFramework.updateContext(input, sessionId).then(
    function success(result) {
        console.log(result);
        // Perform operations upon record retrieval and opening
    },
    function (error) {
        console.log(error.message);
        // Handle error conditions
    }
);
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
