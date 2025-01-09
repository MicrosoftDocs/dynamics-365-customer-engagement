---
title: "runMacro (Omnichannel for Customer Service JavaScript API reference)| MicrosoftDocs"
description: "Includes  reference information such as syntax and parameters for the runMacro method in Omnichannel for Customer Service JavaScript API reference. Also included is a sample code for using the method."
ms.date: 04/04/2022
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
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

## Return value

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

### Related information

[Overview of Productivity Tools](../../../administer/productivity-tools.md)<br />
[Automate tasks with macros](../../../administer/macros.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
