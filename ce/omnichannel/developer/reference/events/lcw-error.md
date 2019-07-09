---
title: "lcw:error | MicrosoftDocs"
description: 
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 07/01/2019
ms.service: 
ms.topic: article
ms.assetid: 1C8C2D34-541C-468E-A73C-AB5EE40706C4
ms.custom: 
---
# lcw:error (Omnichannel for Customer Service JavaScript API reference)

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0.

[!INCLUDE[lcw-error-description](../includes/lcw-error-description.md)]

## Example

The sample code given below shows how the errorEvent is caught and how the error details are obtained.

```JavaScript
window.addEventListener("lcw:error", function (errorEvent) {
    let errorDetail = errorEvent.detail; // Object containing details about the error event
    let errorCode = errorEvent.detail.errorCode; // Error code corresponding to the error event
    let errorDescription = errorEvent.detail.errorDescription; // Description of the error
});
```
### See also

[lcw:ready](lcw-ready.md)<br />
[JavaScript API reference for Live chat SDK](../../omnichannel-reference.md)