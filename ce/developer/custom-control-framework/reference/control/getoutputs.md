---
title: "getOutputs | MicrosoftDocs"
ms.date: 01/12/2018
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: c83c3a09-f04e-4dc6-8ddf-ccd0b4cc080e
author: "Nava kiran"
ms.author: "nabuthuk"
manager: "jdaly"
---
# getOutputs

[!INCLUDE [cc_applies_to_update_9_0_0](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/getoutputs-description.md](./includes/getoutputs-description.md)]



## Syntax

`getOutputs()`

## Remarks

The outputs will contain a value for each property marked as `input-output` or `bound` in your manifest.
For example, if your manifest has a property `value` that is an `input-output`, and you want to set that to the local variable `myvalue` you should return:
```javascript
{
    value: myvalue
}
```

## Example

```javascript
MyControl.prototype.getOutputs = function () {
    var result = {
        value: this._value
    };
    return result;
};
```

### Related topics

[Control](../control.md)<br />
[PowerApps Control Framework API Reference](../index.md)<br />
[PowerApps Control Framework Overview](../../powerapps-control-framework-overview.md)<br />
