---
title: "Skill control for routed records| MicrosoftDocs"
description: "Learn how to add a skill control on forms to view skills of any routed record."
ms.date: 08/25/2021
ms.topic: article
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Add a skill control for routed records

Dynamics 365 provides an out-of-the box custom control that you can embed on any of your forms to view the skills of any routed record. To be able to add the skill control, you must have the System Administrator or System Customizer security role, or equivalent permissions. For more information about your security role, go to [View your user profile](../basics/view-your-user-profile.md).

> [!NOTE]
> To customize a form to add the skill control in Customer Service workspace or the Omnichannel admin center, you can add the control to the **Case for Multisession experience** form.

In the following example, to add a skill control named **Skills** to the case form:

1. In Dynamics 365, go to **Advanced Settings** and select the **Case for Interactive experience** form for the **Case** entity.
   The form designer opens.

2. Drag and drop a **One Column** section on to the form. Then, from the **Field Explorer** pane, drag and drop a field that supports a single line of text (such as **Case Title**).

3. Select the field you just added, and then select **Change Properties** on the **Home** tab.

   In the **Field Properties** dialog that appears, select the **Display** tab and enter a label name for the field, such as **Skills**.

4. On the **Controls** tab, select **Add Control**.
  
   In the **Add Control** dialog that appears, select the **CC_OCRoutedEtnRelatedRecordsControl** custom control from the dropdown list, and then select **OK**.

5. Save and publish the solution.

The skill control is added to the **Case Interactive experience** form. Your agents will now be able to view the newly added custom control on all routed case records in Customer Service Hub.

Though we don't recommend setting up any parameters for the skill control, in case you need to populate the logical collection name or the relationship name of the record, you can use the following OData queries.

- To get the logical collection name, run the following OData query and enter the same in the **Value** field of the **CC_OCRoutedEntityName_value** property.

```HTTP
GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName='{EntityLogicalName}')?$select=LogicalCollectionName,LogicalName
```

- To get the relationship name for one-to-many, many-to-one, or many-to-many relationships, run any of the following OData queries, and enter the same in the **Value** field of the **CC_OCRoutedEntityRelationshipName_value** property.
```HTTP
GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName='incident')/OneToManyRelationships
```
```HTTP
GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName='incident')/ManyToOneRelationships
```
```HTTP
GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName=%27incident%27)/ManyToManyRelationships
```

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Configure work classification rule](configure-work-classification.md)  
[Set up record routing](set-up-record-routing.md)  
[Set up unified routing](set-up-routing-process.md)  
[Query table definitions using the Web API](/powerapps/developer/data-platform/webapi/query-metadata-web-api)  
[Overview of the model-driven form designer](/powerapps/maker/model-driven-apps/form-designer-overview)  
[Add, configure, move, or delete components on a form](/powerapps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]