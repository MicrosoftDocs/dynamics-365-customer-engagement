---
title: "onclicktoact event (JavaScript API Reference) for Channel Integration Framework (CIF) in Dynamics 365 | Microsoft Docs"
description: ""
keywords: ""
ms.date: 10/01/2018
ms.service:
  - "dynamics-365-cross-app"
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: reference
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 6C942CA2-D776-4596-B9C5-D9007DF1AEE9
author: kabala123
ms.author: kabala
manager: shujoshi
---

# onclicktoact event 

The `onclicktoact` event occurs when user selects the outbound communication (ClickToAct) field in a form.

You can also write custom controls to raise the Channel Integration ClickToAct window event and pass any eventData as the business requirement.

## eventData

The `onclicktoact` event takes following eventData:

| eventData | Example |
|-----------|---------|
| ```{“value”: <field_value>, “name”: <field_name>, “format”: <field_type>, “entityLogicalName”: <entity_logical_name>}``` | ```{“value”: “123456789”, “name”: “mobilephone”, “format”: “phone”, “entityLogicalName”: “contact”}``` |

## Methods supported for this event

There are two methods you can use to work with the onclicktoact event:

- [addHandler](../microsoft-ciframework/addHandler.md)

- [removeHandler](../microsoft-ciframework/removeHandler.md)
