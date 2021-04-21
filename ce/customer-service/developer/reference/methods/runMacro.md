---
title: "runMacro (Omnichannel for Customer Service JavaScript API reference)| MicrosoftDocs"
description: 
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 10/17/2019
ms.topic: article
ms.service: dynamics-365-customerservice
---
# runMacro

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

Allows you to execute a macro that was created using Macro Designer.

## Syntax

`Microsoft.ProductivityMacros.runMacro(macroName);`

## Parameters

| Parameter | Type | Required | Description |
| ---- | ---- | ---- | ---- |
| macroName | String | Yes | Name of the macro that is to be executed.  |

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

## See also

[Overview of Productivity Tools](../../../productivity-tools.md)<br />
[Automate tasks with macros](../../../../app-profile-manager/macros.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]