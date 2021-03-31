---
title: "lcw error | MicrosoftDocs"
description: lcw error (Omnichannel for Customer Service JavaScript API reference)
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.topic: article
ms.service: dynamics-365-customerservice
---
# lcw:error (Omnichannel for Customer Service JavaScript API reference)

[!INCLUDE[cc-use-with-omnichannel](../../../../includes/cc-use-with-omnichannel.md)]

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


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]