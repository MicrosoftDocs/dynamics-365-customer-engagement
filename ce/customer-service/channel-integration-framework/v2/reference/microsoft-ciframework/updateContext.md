---
title: "updateContext (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Learn about updateContext (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 11/20/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---
# updateContext (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0


This method allows you to set the automation dictionary. It enables providers to add, modify, and remove values of slugs. The updated values are then available for invoking macros in the future.

## Syntax

`Microsoft.Apm.getFocusedSession().updateContext(input);`

## Parameters

| Parameter | Type | Required| Description |
| ------- |-------|-------|-------|
|input| JSON | Yes | JSON input properties of the session context to be updated.|
|sessionId| String| Yes | Unique identifier of the current session. |
|isDelete| Boolean | No | Set `isDelete` to `true` if the list of parameters in `input` JSON are to be deleted.<br />If `isDelete` is set to `true`, the slug values will be deleted and will no longer be available for subsequent macro invocations.|
|correlationId| GUID| No |Used to group all related API calls together for diagnostic telemetry|

## Return value

Returns a promise with string value.

## Example


```javascript

Microsoft.Apm.getFocusedSession().updateContext({"customerName":"Contoso"});
Microsoft.Apm.getFocusedSession().getContext().then((context)=> context.get("customerName")).then(
    function success(result) {
        console.log(result);
        // should expected "Contoso"
        // Perform operations upon record retrieval and opening
    },
    function (error) {
        console.log(error.message);
        // Handle error conditions
    }
);
```


[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
