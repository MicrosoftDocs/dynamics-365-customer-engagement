---
title: "onclicktoact event (JavaScript API Reference) for Channel Integration Framework (CIF) | Microsoft Docs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 12/10/2018
ms.topic: reference
ms.service: 
  - dynamics-365-cross-app
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# onclicktoact event (CIF JavaScript API reference)

The `onclicktoact` event invoked when user selects the outbound communication (ClickToAct) field in a form.

You can also write custom controls to raise the Channel Integration ClickToAct window event and pass any eventData as the business requirement.

## eventData

The `onclicktoact` event takes following eventData:

| eventData | Example |
|-----------|---------|
| ```{"value": <field_value>, "name": <field_name>, "format": <field_type>, "entityLogicalName": <entity_logical_name>}``` | ```{"value": "123456789", "name": "mobilephone", "format": "phone", "entityLogicalName": "contact"}``` |

## See also

- [setClickToAct](../microsoft-ciframework/setClickToAct.md)

- [addHandler](../microsoft-ciframework/addHandler.md)

- [removeHandler](../microsoft-ciframework/removeHandler.md)
