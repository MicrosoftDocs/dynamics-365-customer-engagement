---
title: "init | MicrosoftDocs"
ms.date: 01/12/2018
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 4485b7d4-c68f-4298-8676-1820eb33c1ad
author: "Nava kiran"
ms.author: "nabuthuk"
manager: "jdaly"
---
# init

[!INCLUDE [cc_applies_to_update_9_0_0](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/destroy-description.md](./includes/destroy-description.md)]



## Syntax

`init(context,notifyOutputChanged,state,container)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|context|[Context](../context.md)|yes|The *Input Properties* containing the parameters, control metadata and interface functions.|
|notifyOutputChanged|`function`|no|The method for this control to notify the framework that it has new outputs|
|state|[KeyValuePair](../keyvaluepair.md)|no|The control state for this control saved from *setControlState* in the last session|
|container|[HTMLDivElement](https://developer.mozilla.org/docs/Web/API/HTMLDivElement)|no|The div element to render|




### Related topics

[Control](../control.md)<br />
[PowerApps Control Framework API Reference](../index.md)<br />
[PowerApps Control Framework Overview](../../custom-control-framework-overview.md)<br />
