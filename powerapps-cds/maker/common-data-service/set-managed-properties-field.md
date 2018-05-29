---
title: "Set managed properties for fields in Common Data Service for Apps | MicrosoftDocs"
description: "Learn how to set managed properties for a field."
ms.custom: ""
ms.date: 04/17/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
  - "powerapps"
author: "Mattp123"
ms.assetid: 4ddcfcf3-5604-4b93-a5ee-589d4fb97fa4
caps.latest.revision: 33
ms.author: "matp"
manager: "kvivek"
tags: 
---
# Set managed properties for fields

 Managed properties only apply when you include fields in a managed solution and import the solution into another environment. These settings allow a solution maker to have some control over the level of customization that people who install their managed solution can have when they customize this field. 

To set managed properties for a field, you must use solution explorer. See [Create and edit fields using PowerApps solution explorer](create-edit-field-solution-explorer.md) for information about how to edit fields using solution explorer.

While viewing a list of fields, select a custom field from an unmanaged solution and then choose **More Actions** >  **Managed Properties** on the menu bar.

![View field managed properties](media/view-field-managed-properties-solution-explorer.png)  
  
This will open the **Set Managed Properties** dialog box.

![Set Field Managed Properties](media/set-field-managed-property.png)

The **Can be customized** option controls all the other options. If this option is **False**, none of the other settings apply. When it is **True**, you can specify the other customization options.  
  
If the field is customizable, you set the following options to **True** or **False**.  
  
- **Display name can be modified**
- **Can change requirement level** 
- **Can change Additional Properties** : This property controls any other customizations that do not have a specific managed property.

Setting all the individual options to **False**, is equivilent to setting **Can be customized** to **False**.  

Apply your choices and click **Set** to close the dialog box.


> [!NOTE]
> If this field is a **Date and Time** field, an addional **Can change date and time behavior** property is available. More information: [Behavior and format of the Date and Time field](behavior-format-date-time-field.md)
  

 ### See also

[Managed properties](solutions-overview.md#managed-properties)<br />[Create and edit fields using PowerApps solution explorer](create-edit-field-solution-explorer.md)<br />
[Behavior and format of the Date and Time field](behavior-format-date-time-field.md)<br />
[Set managed properties for an entity](set-entity-managed-properties.md)<br />

