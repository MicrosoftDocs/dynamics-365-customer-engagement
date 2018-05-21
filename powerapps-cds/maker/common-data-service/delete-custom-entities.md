---
title: "Delete custom entities in PowerApps | MicrosoftDocs"
description: "Learn how to delete a custom entity"
ms.custom: ""
ms.date: 05/17/2018
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
ms.assetid: e6ed6324-16ae-4c2b-b9a0-2422f54ccafb
caps.latest.revision: 41
ms.author: "matp"
manager: "kvivek"
---
# Delete custom entities
  
As someone with the system administrator security role, you can delete custom entities that aren’t part of a managed solution.  
  
> [!IMPORTANT]
>  When you delete a custom entity, the database tables that store data for that entity are deleted and all data they contain is lost. Any associated records that have a parental relationship to the custom entity are also deleted. For more information about parental relationships, see [Create and edit relationships between entities](create-edit-entity-relationships.md).  
  
> [!NOTE]
> The only way to recover data from an entity that was deleted is to restore the database from a point before the entity was deleted. More information: [Backup and restore instances](/dynamics365/customer-engagement/admin/backup-restore-instances)

## Delete a custom entity using PowerApps portal

Select the entity and select **Delete entity** from the context menu.

![Delete an entity using the PowerApps portal](media/delete-entity-powerapps-portal.png)

If the entity has dependencies that prevent it from being deleted you will see an error message. To identify and remove any dependencies, you will need to use the solution explorer. More information [Identify entity dependencies](#identify-entity-dependencies)

## Delete a custom entity using Solution Explorer

When deleting an entity using the solution explorer you need to find the unmanaged solution that contains it.

[!INCLUDE [cc_navigate-solution-from-powerapps-portal](../../includes/cc_navigate-solution-from-powerapps-portal.md)]

Locate the entity you want to delete in the **Entities** list, select it and click **Delete** in the command bar.
 
 ![Delete custom entity in solution explorer](media/delete-custom-entity-solution-explorer.png)

7. Confirm you want to delete the entity. 

    > [!NOTE]
    > If there are any entity dependencies you will get a **Cannot Delete Component** error with a **Details** link you can use to discover information about why the entity cannot be deleted. In most cases, this will be because of a dependency that has to be removed. 
    >
    > There may be more than one dependency blocking the deletion of an entity. This error message may only show the first one. For an alternate way to discover dependencies, see [Identify entity dependencies](#identify-entity-dependencies)

## Identify entity dependencies

You can identify dependencies that will prevent an entity from being deleted before you try to delete it. 

1. In the solution explorer with the entity selected, click **Show Dependencies** in the command bar.

![Show Dependencies command](media/entity-show-dependencies.png)

2. In the dialog window that opens, scroll the list to the right to view the **Dependency Type** column.

![Published Dependency Type](media/published-entity-dependency.png)

**Published** dependencies will block deleting an entity. **Internal** dependencies should be resolved by the system.  

3. Remove these published dependencies and you should be able to delete the entity.

 > [!NOTE]
 > A very common dependency is that another entity form has a lookup field for the entity you are deleting. Removing the lookup field from the form will resolve the dependency.
 
### See also
[Create an entity](create-entities.md)<br />
[Edit an entity](edit-entities.md)
