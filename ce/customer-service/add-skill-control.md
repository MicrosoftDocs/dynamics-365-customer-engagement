---
title: "Skill control for routed records| MicrosoftDocs"
description: "Learn how to add a skill control on forms to view skills of any routed record in Customer Service Hub."
ms.date: 03/04/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
---

# Add a skill control for routed records

Dynamics 365 provides a custom control that you can embed in your forms to view the skills of any routed record. To display the skill control for the routed record in the Customer Service workspace or Omnichannel for Customer Service app, add the control to the multisession form.

## Prerequisites

- To add the skill control, you must have the System Administrator or System Customizer security role, or equivalent permissions. For more information about your security role, go to [View your user profile](../basics/view-your-user-profile.md).
- To ensure that the skill control is loaded and displayed for the routed records, you must [allow access to these websites](system-requirements-omnichannel.md#allow-access-to-websites).  

## Add skill control

In the following example, to add a skill control named **Skills** to the case form:

1. In Dynamics 365, go to **Advanced Settings** and select the **Case for Interactive experience** form for the **Case** entity.

2. Drag and drop a **One Column** section on to the form. Then, from the **Field Explorer** pane, drag and drop a field that supports a single line of text such as **Case Title**.

3. Select **Change Properties** on the **Home** tab, and in the **Field Properties** dialog that opens, do the following:
      - On the **Display** tab, enter a label name for the field, such as **Skills**.
      - On the **Controls** tab, select **Add Control**. The **Add Control** dialog opens.
      - Select the **CC_OCRoutedEtnRelatedRecordsControl** custom control from the dropdown list, and then select **OK**.

4. Save and publish the solution.

At runtime, your agents will be able to view the skill control on all routed case records in Customer Service Hub.

Though we don't recommend setting up parameters for the skill control, if you want to manually enter the logical collection name or the relationship name of the record, you can use the following OData queries to get the information.

- **Logical collection name**: Run the following OData query and enter the same in the **Value** field of the **CC_OCRoutedEntityName_value** property.

    `GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName='{EntityLogicalName}')?$select=LogicalCollectionName,LogicalName`

- **Relationship name**: Run any of the following OData queries for one-to-many, many-to-one, or many-to-many relationships, and enter the same in the **Value** field of the **CC_OCRoutedEntityRelationshipName_value** property.

    `GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName='incident')/OneToManyRelationships`

    `GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName='incident')/ManyToOneRelationships`

    `GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName=%27incident%27)/ManyToManyRelationships`

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Set up record routing](set-up-record-routing.md)  
[Set up unified routing](set-up-routing-process.md)  
[Query table definitions using the Web API](/powerapps/developer/data-platform/webapi/query-metadata-web-api)  
[Add, configure, move, or delete components on a form](/powerapps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
