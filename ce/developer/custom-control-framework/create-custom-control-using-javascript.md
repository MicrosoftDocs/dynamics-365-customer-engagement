---
title: Create Custom Controls Using JavaScript | Microsoft Docs
description: create controls using javascript
keywords:
ms.author: nabuthuk
manager: jdaly
ms.date: 06/4/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: bc9ea42f-ee18-4f7f-9039-0c53325ab60f
---
# Create Custom Control Using JavaScript

[!INCLUDE [cc_applies_to_update_9_0_0](../../includes/cc_applies_to_update_9_0_0.md)]

This sample shows how to write a custom control using PowerApps Control Framework.

This custom control replaces a single line of text field to "Hellow World (JS)".

## Example
```JavaScript
"use strict";

var MyNameSpace = MyNameSpace || {};
MyNameSpace.JSHelloWorldControl = function(){
}

MyNameSpace.JSHelloWorldControl.prototype.init = function (context, notifyOutputChanged, state, container) {
    this._labelElement = document.createElement("label");
    this._labelElement.setAttribute("class", "JS_HelloWorldColor");
    container.appendChild(this._labelElement);
};

MyNameSpace.JSHelloWorldControl.prototype.updateView = function (context) {
    this._labelElement.innerText = "Hello World! (JS)";
};

MyNameSpace.JSHelloWorldControl.prototype.getOutputs = function () {
    return {};
};

MyNameSpace.JSHelloWorldControl.prototype.destroy = function () {
};
```

### Related topics

[PowerApps Control Framework API Reference](reference/index.md)<br />
[PowerApps Control Framework Manifest Schema Reference](manifest-schema-reference/index.md)
