---
title: "Tutorial: Create an entity in Solution Explorer | MicrosoftDocs"
description: "Learn how to create an entity in Solution Explorer"
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
ms.author: "matp"
manager: "kvivek"
---

# Tutorial: Create an entity in Solution Explorer

You can easily create an entity using the PowerApps portal for most common situations, but not all capabilities are implemented there. When you need to meet the requirements described in [Create an entity](create-entities.md), you can achieve them by creating entities using the Solution Explorer.

## Navigate to the solution

When creating an entity using the solution explorer you need to find the unmanaged solution that you want to add it to.

1. From the PowerApps portal in Model-driven design mode click **Advanced** to open the Common Data Services Default solution.
2. Edit the URL, removing everything after `dynamics.com` and refresh the page.
3. In the **Settings** area select **Customization** > **Solutions**.
4. In the  view selector, choose **Unmanaged Solutions**.
5. Open an existing unmanaged solution or create a new solution. More information: [Create a solution](create-solution.md).

## Create an Entity

To create an entity in the solution explorer:
1. In the **Components** node, select the **Entities** node.
2. Click **New** to open the new entity form.

    The new entity form has two tabs. The **General** tab is for entity options. The **Primary Field** tab is for options about the special single line of text field that each entity has that defines the text shown when there is a link to open the entity in a lookup field.

    For information about each section see the following:
    - [Edit the Primary field](#edit-the-primary-field)
    - [Edit entity options](#edit-entity-options)

    You can also make the entity a custom activity. This choice changes some of the default option values. More information: [Create a custom activity entity](#create-custom-activity-entity)

3. After you have set the options for the entity, click **Save** to create the custom entity.
4. After you save the entity, you can continue to to perform the following:
   - [Create and edit fields (attributes)](create-edit-fields.md)
   - [Create and edit relationships between entities](create-edit-entity-relationships.md)
   - [Create and design forms](../model-driven-apps/create-design-forms.md)
   - [Create a business process flow to standardize processes](../model-driven-apps/create-business-process-flow.md)

### Edit the Primary field

In the **Primary Field** tab you can usually accept the default values for the primary field, but you have the following options:

|Field   |Description  |
|---------|---------|
|**Display Name**|Enter the localizable label that will be displayed for this field in forms and lists. The default value is **Name**.|
|**Name**|Set the name used in the system for this field. The default value is `<customization prefix>_name`|
|**Maximum Length**|Enter the maximum length for the field values. The default is 100.|

> [!NOTE]
> These options do not apply if the entity is an activity entity. More information:  [Create a custom activity entity](#create-custom-activity-entity)

### Edit entity options

In the **General** tab, some of the options are required and some can only be set once. After you enable these *set once* options and save the entity, they cannot be disabled.

#### Required properties

|Field   |Description  |
|---------|---------|
|**Display Name**|This is the singular name for the entity that will be shown in the app.|
|**Plural Name**|This is the plural name for the entity that will be shown in the app.|
|**Name**|This field is pre-populated based on the display name you enter. It includes the solution publisher customization prefix.|
|**Ownership**|You can choose either user or team-owned or organization owned. More information: [Entity ownership](types-of-entities.md#entity-ownership)|

#### Set once options

The following options can be set once and cannot be changed after you set them. Take care to only set these options when you need them.

<!-- 
Same data is presented in edit-entities.md
Both should point to this include
 -->
[!INCLUDE [cc_entity-set-once-options-table](../../includes/cc_entity-set-once-options-table.md)]


#### Options that you can change

The following properties can be changed at any time.

<!-- 
Same data is presented in edit-entities.md
Both should point to this include
 -->
[!INCLUDE [cc_entity-changeable-options-table](../../includes/cc_entity-changeable-options-table.md)]

## Create custom activity entity

To create the entity as an activity entity, use the same steps described in this topic except select **Define as an activity entity**.

An activity entity is a special kind of entity that tracks actions for which an entry can be made on a calendar. More information: [Activity entities](types-of-entities.md#activity-entities).

When you set this option some entity properties are not compatible. An activity entity has to conform to standard behaviors that all activity entities use.

The primary field **Name** and **Display Name** will be set to **Subject** and you cannot change this.

The following options are set by default and cannot be changed:

 - **Feedback**
 - **Notes (includes attachments)**
 - **Connections**
 - **Queues**
 - **Offline capability for Dynamics 365 for Outlook**

The following options cannot be set:

- **Areas that display this entity**
- **Activities**
- **Sending email**
- **Mail Merge**
- **Single record auditing**
- **Multiple record auditing**

## Create a Virtual Entity

Some options are only used when creating a virtual entity.

|Option   |Description  |
|---------|---------|
|**Virtual Entity**|Whether the entity is a virtual entity.|
|**Data Source**|The data source for the entity.|

More information: [Create and edit virtual entities that contain data from an external data source](create-edit-virtual-entities.md)

### See also
[Create an entity](create-entities.md)<br />
[Edit an entity](edit-entities.md)<br />
[Tutorial: Create a custom entity that has components in PowerApps](/powerapps/maker/common-data-service/create-custom-entity)<br />
[Create a solution](create-solution.md)