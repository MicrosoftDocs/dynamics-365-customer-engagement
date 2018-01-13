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
# destroy

[!INCLUDE [cc_applies_to_update_9_0_0](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/destroy-description.md](./includes/destroy-description.md)]

## Syntax

`destroy()`

## Example
```javascript
SimpleIncrementStandardControl.prototype.destroy = function () {
 this.button.removeEventListener("click", this.onButtonClick);
};
```

### Related topics

[CustomControl](../customcontrol.md)<br />
[Custom Control Framework API Reference](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />
