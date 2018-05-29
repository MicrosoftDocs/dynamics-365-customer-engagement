---
title: "Create an entity with PowerApps | MicrosoftDocs"
description: "Learn how to create an entity"
ms.custom: ""
ms.date: 05/11/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "Mattp123"
ms.assetid: fa04f99d-a5f9-48cb-8bfb-f0f50718ccee
caps.latest.revision: 41
ms.author: "matp"
manager: "kvivek"
---
# Create an entity

Before you create a custom entity, evaluate whether using an existing entity will meet your requirements. More information: [Create new metadata or use existing metadata?](create-edit-metadata.md#create-new-metadata-or-use-existing-metadata)

There are two designers you can use to create an entity:

|Designer| Description|
|--|--|
|[PowerApps portal](https://web.powerapps.com)|Provides an easy streamlined experience, but some special settings are not available.  More information: [Tutorial: Create a custom entity that has components in PowerApps](/powerapps/maker/common-data-service/create-custom-entity)|
|Solution explorer|Not as easy, but provides for more flexibility for less common requirements. More information [Create an entity in Solution Explorer](create-entity-solution-explorer.md)|

> [!NOTE]
> You can also create entities in your environment using the following:
> - Import a solution that contains the definition of the entity.
> - Use Power Query to create new entities and fill them with data. More information: [Quickstart: Add data to an entity in the Common Data Service by using Power Query](/powerapps/maker/common-data-service/data-platform-cds-newentity-pq).
> - A developer can use [Metadata services](/powerapps/developer/common-data-service/use-web-services#metadata-services) to write a program.


## Solution explorer capabilities not available in the PowerApp portal

Information in this topic will help you choose which designer you can use. You can use the PowerApps portal to create the entity unless you need to address any of the following requirements.

### Control the customization prefix

Part of the name of any custom entity you create is the customization prefix. This is set based on the solution publisher for the solution you’re working in. If you care about the customization prefix, make sure that you are working in an unmanaged solution where the customization prefix is the one you want for this entity. More information [Change the solution publisher prefix](change-solution-publisher-prefix.md).

### Control the name of the primary name field

By default, the **Primary Name** field created in PowerApps portal will be *`<customization prefix>`*+`_PrimaryName`. You can't change this after it is created,

### Create organization-owned entity

By default, the PowerApps portal will create **User or Team** owned entities. Use solution explorer to set ownership to **Organization**. More information: [Entity ownership](types-of-entities.md#entity-ownership)

### Create an activity entity

An activity entity is a special kind of entity that tracks actions for which an entry can be made on a calendar. More information: [Activity entities](types-of-entities.md#activity-entities).


### See also

[Tutorial: Create an entity in Solution Explorer](create-entity-solution-explorer.md)<br />
[Tutorial: Create a custom entity that has components in PowerApps](/powerapps/maker/common-data-service/create-custom-entity)<br />
[Edit an entity](edit-entities.md)<br />
[Developer Documentation: Create a custom entity](/dynamics365/customer-engagement/developer/org-service/create-custom-entity)
