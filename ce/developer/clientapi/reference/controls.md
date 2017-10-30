---
title: "Controls in Customer Engagement for Dynamics 365| MicrosoftDocs"
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: "Dynamics 365 (online)"
ms.assetid: 4d025f92-db16-440c-9f82-e40d71e09862
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Controls (Client API reference)

> [!NOTE]
> ![This page is under construction. Check back soon!](../../../media/under_construction.png "Coming soon") [!INCLUDE[cc-under-construction](../../../includes/cc-under-construction.md)]

A control represents an HTML element present on the form. Some controls are bound to a specific attribute, whereas others may represent unbound controls such as an IFRAME, Web resource, or a sub grid that has been added to the form. 

The **control** object provides methods to change the presentation or behavior of a control and identify the corresponding attribute. You access controls using one of the following collections: 
- **formContext.ui.controls**
- **formContext.ui Section.controls**
- **formContext.data.entity** **Attribute.controls**

The **formContext**.[getControl](controls/getControl.md) method is a shortcut method to access **formContext.ui.controls.get**. 

Controls are categorized by type. You can determine the type of a control by using the [getControlType](controls/getControlType.md) method. Certain control methods are only available for specific types of controls.

