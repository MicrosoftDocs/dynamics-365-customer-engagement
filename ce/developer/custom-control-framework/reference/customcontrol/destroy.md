---
title: "destroy | MicrosoftDocs"
ms.date: 10/12/2018
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: ba66b513-2a7b-4ba6-b2d5-446ea2b42fdb
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# destroy (Custom Control Framework API reference)

[!INCLUDE [cc_applies_to_update_9_0_0](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/destroy-description.md](./includes/destroy-description.md)]

This function will be called when the control is destroyed. Use it for cleanup and to release any memory that the control is using

## Syntax

`destroy()`

## Example
```javascript
SimpleIncrementStandardControl.prototype.destroy = function () {
 this.button.removeEventListener("click", this.onButtonClick);
};
```

### Related topics

[CustomControl (Custom Control Framework API reference)](../customcontrol.md)<br />
[Custom Control Framework API Reference for Customer Engagement](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />
