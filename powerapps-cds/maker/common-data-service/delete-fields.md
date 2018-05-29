---
title: "Delete fields in Common Data Service for Apps | MicrosoftDocs"
description: "Learn how to delete fields"
ms.custom: ""
ms.date: 05/25/2018
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
ms.assetid: 578ac950-da16-4ec6-a0a4-25f3aaa3b96e
caps.latest.revision: 33
ms.author: "matp"
manager: "kvivek"
tags: 
---
# Delete fields

With the system administrator security role, you can delete any custom fields that aren’t part of a managed solution. When you delete a field, any data stored in the field is lost. The only way to recover data from a field that was deleted is to restore the database from a point before the field was deleted.

> [!NOTE]
> Before you can delete a custom field, you must remove any dependencies that may exist in other solution components. 

## Using PowerApps portal

See [Create and edit fields using PowerApps portal](create-edit-field-portal.md) for information about working with entity fields.

If you select a custom field that can be deleted in the list, the **Delete field** command appears and is enabled.

![Delete a field using the portal](media/delete-field-portal.png)

Use the **Delete field** command to delete the field. After deleting the field you must save the changes to the entity.

![Save entity after deleting field](media/delete-field-portal-save-entity.png)

> [!NOTE]
> If you get an error related to dependencies, you must use solution explorer to detect dependencies. More information: [Check field dependencies](#check-field-dependencies)

## Using PowerApps solution explorer

See [Create and edit fields using PowerApps solution explorer](create-edit-field-solution-explorer.md) for information about working with entity fields. 

1. Select a custom field that can be deleted in the list and click the ![Delete command](../model-driven-apps/media/delete.gif) button in the command bar.
2. In the **Confirm Deletion** dialog, select **Delete**.

> [!TIP]
> You can select multiple custom fields to be deleted in one operation.

### Check field dependencies 

Select the field in the list. In the **More Actions** menu, select **Show Dependencies**.

![Show dependencies for field](media/check-field-dependencies.png)

Dependencies are any related use of the field that would prevent it from being deleted. For example, if the field is used in a form or view, you must first remove references to the field in those solution components.  
  
If you delete a lookup field, the 1:N entity relationship for it will automatically be deleted.  

 ### See also

[Delete custom entities](delete-custom-entities.md)<br />
[Create and edit fields using PowerApps portal](create-edit-field-portal.md)<br />
[Create and edit fields using PowerApps solution explorer](create-edit-field-solution-explorer.md)<br />
[Developer Documentation: Work with attribute metadata > Delete an attribute](/dynamics365/customer-engagement/developer/org-service/work-attribute-metadata#delete-an-attribute)
