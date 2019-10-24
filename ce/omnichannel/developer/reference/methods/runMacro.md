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
# Preview: runMacro

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../../../../legal/dynamics-insider-agreement.md).

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

[Overview of Productivity Tools](../../../administrator/productivity-tools.md)<br />
[Automate tasks with macros](../../../administrator/macros.md)