---
title: "getOutputs | MicrosoftDocs"
ms.date: 01/12/2018
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: c83c3a09-f04e-4dc6-8ddf-ccd0b4cc080e
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# getOutputs (Custom Control Framework API reference)

[!INCLUDE [cc_applies_to_update_9_0_0](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getoutputs-description.md](./includes/getoutputs-description.md)]

Return an *Output Bag* to the control Infrastructure.

## Syntax

`getOutputs()`

## Remarks

The outputs will contain a value for each property marked as `input-output` or `bound` in your manifest.
For example, if your manifest has a property `value` that is an `input-output`, and you want to set that to the local variable `myvalue` you should return:
```javascript
{
    value: myvalue
};
```

## Example

```javascript
SimpleIncrementStandardControl.prototype.getOutputs = function () {
    var result = {
        value: this._value
    };
    return result;
};
```

### Related topics

[CustomControl (Custom Control Framework API reference)](../customcontrol.md)<br />
[Custom Control Framework API Reference for Customer Engagement](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />