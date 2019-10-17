---
title: "runMacro (Omnichannel for Customer Service JavaScript API reference)| MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 10/17/2019
ms.service: 
ms.topic: article
ms.assetid: FF1AC4AF-9754-4D8D-B1FC-9847B751EA7F
ms.custom: 
---
# runMacro

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Allows you to execute a macro that was created using Macro Designer.

## Syntax

`Microsoft.ProductivityMacros.runMacro(macroName);`

## Parameters

| Parameter | Type | Description |
| ---- | ---- | ---- |
| macroName | String | Name of the macro that is to be executed.  |

## Returns

Returns a promise string which is either resolved with a success message or rejected with an error message, based on execution result.

## Example

```javascript
Microsoft.ProductivityMacros.runMacro(macroName).then(function(success){
                console.log(success)
                },
                function(error){
                console.log(error)
});
```

### See also

[Overview of Productivity Tools](../../../administrator/productivity-tools.md)<br />
[Automate tasks with macros](../../../administrator/macros.md)