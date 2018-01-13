---
title: "init | MicrosoftDocs"
ms.date: 01/12/2018
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 4485b7d4-c68f-4298-8676-1820eb33c1ad
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# init (Custom Control Framework API reference)

[!INCLUDE [cc_applies_to_update_9_0_0](../../../../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[./includes/destroy-description.md](./includes/destroy-description.md)]

Use this function for any initial setup necessary for your control.

## Syntax

`init(context,notifyOutputChanged,state,container)`

## Parameters

| Parameter Name|Type|Required|Description|
| ------------- |----|--------|-----------|
|context|IPropBag|yes|The *Input Properties* containing the parameters, control metadata and interface functions.|
|notifyOutputChanged|*function*|no|The method for this control to notify the framework that it has new outputs|
|state|dictionary|no|The control state for this control saved from setState in the last session|
|container|HTML DIV element|no|The div element to render|

## Remarks




### Related topics

[CustomControl (Custom Control Framework API reference)](../customcontrol.md)<br />
[Custom Control Framework API Reference for Customer Engagement](../index.md)<br />
[Custom Control Framework Overview](../../custom-control-framework-overview.md)<br />