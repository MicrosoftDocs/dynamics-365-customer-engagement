---
title: "Create 1:N (one-to-many) or N:1 (many-to-one) relationships in Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn how to create one-to-many or many-to-one relationships"
ms.custom: 
ms.date: 11/09/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: 52c00707-b2bc-4950-abec-89baefd94f6e
caps.latest.revision: 33
ms.author: matp
manager: kvivek
tags: 
search.audienceType: 
  - customizer

---
# Create 1:N (one-to-many) or N:1 (many-to-one) relationships

<a name="BKMK_CreateEditN1Relationships"></a>   

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create and edit One-to-many or Many-to-one entity relationships using Power Apps portal](/powerapps/maker/common-data-service/create-edit-1n-relationships-portal)

 The easiest way to create a 1:N relationship is to create a new lookup field for an entity. This allows you to set the common field values for the lookup field as well as two additional options when you set the **Type** to **Lookup**. Those additional fields are **Target Record Type** and **Relationship Name**.  
  
 **Target Record Type** selects the **Primary Entity** in the 1:N relationship. **Relationship Name** is auto-generated for you based on the two entities that participate in the relationship. You typically don’t need to edit this, but you can if you want. The name of the entity relationship contains the customization prefix of the solution publisher for the solution you are currently working in.  
  
> [!NOTE]
>  If you care about the customization prefix, be sure you are working within the context of a solution that is linked to the solution publisher with the prefix you want.  
  
 However, when you create a 1:N relationship by creating a lookup field, certain default values are set for you. If you want to edit some of the options available in the relationship, you must locate the relationship and edit it.  
  
 Custom 1:N relationships can’t be created for all entities. When this is true there is no option to create a new custom entity relationship using the solution explorer. If you use the metadata browser, you can filter the list of entities according to the `CanBePrimaryEntityInRelationship` and `CanBeRelatedEntityInRelationship` properties.  
  
 The definition for the 1:N relationship has four parts: **Relationship Definition**, **Lookup Field**, **Navigation Pane Item for Primary Entity**, and **Relationship Behavior**.  
  
 ![1:N Entity Relationship](../customize/media/cust-1n-relationship-properties.png "1:N Entity Relationship")  
  
## Create or edit 1:N relationships between entities  
  
1. Open solution explorer.
  
2.  Under **Components**, expand **Entities**, and then expand the entity you want to work with.  
  
3.  Select **1:N Relationships**.  
  
4.  To edit a relationship or view the details for a relationship, select the relationship, and on the Actions toolbar, select **More Actions**, and then select **Edit**.  
  
     \-  OR -  
  
     To add a new relationship, select **New 1-to-Many Relationship**.  
  
    > [!IMPORTANT]
    >  If **New 1-to-Many Relationship** does not appear on the Actions toolbar, you cannot create a 1:N relationship for that entity.  
  
5.  For a new relationship, in the **Relationship Definition** section, in the **Related Entity** list, select the entity to be related.  
  
    > [!NOTE]
    >  Specifying the related entity sets a default value for the **Name** field. If you change the related entity before you save, the value of the **Name** changes accordingly.  
  
6.  Select whether this will be searchable to not.  
  
7.  In the **Lookup Field** section, specify a value for the **Display Name** field.  
  
    > [!IMPORTANT]
    >  Specifying the **Display Name** sets a default value for the **Name** field. If you change the **Display Name** of the lookup field before you save, the value in the **Name** field will not change. As a result, be sure the **Name** is meaningful before saving.  
  
8. In the **Field Requirement** list, choose an option to specify data requirements for the field prior to saving a record.  
  
9. In the **Navigation Pane Item for Primary Entity** section, in the **Display Option** list, choose an option for displaying associated views or a custom label.  
  
10. In the **Relationship Behavior** section, in the **Type of Behavior** list, choose one of the following options:  
  
    - **Parental**. In a parental relationship between two entities, any action taken on a record of the parent entity is also taken on any child entity records that are related to the primary (or parent) entity record.  
  
    - **Referential**. In a referential relationship between two entities, you can navigate to any related records, but actions taken on one will not affect the other.  
  
    - **Referential, Restrict Delete**. In a referential, restrict delete relationship between two entities, you can navigate to any related records. Actions taken on the parent record will not be applied to the child record, but the parent record cannot be deleted while the child record exists. Note that you cannot delete a record when related records exist.  
  
    - **Configurable Cascading**. In a configurable cascading relationship between two entities, you select the behavior associated with each of a set of possible actions.  
  
        > [!IMPORTANT]
        >  If you set the behaviors for the actions so that they match the behaviors for the actions associated with another **Type of Behavior**, when you save the relationship, the **Type of Behavior** is automatically set to the matching type.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure entity relationship behavior](../developer/entity-relationship-behavior.md#configure-entity-relationship-behavior)
  
11. Select **Save and Close** to close the **Relationship** form.  
  
12. When your customizations are complete, publish them:  
  
    -   To publish customizations for only the component that you are currently editing, on the Actions toolbar, select **Publish**.  
  
    -   To publish customizations for all unpublished components at one time, on the nav bar or in the Navigation Pane, select **Entities**, and then on the Actions toolbar, select **Publish All Customizations**.  
  
> [!NOTE]
> - A custom entity cannot be the primary entity in a relationship with a related system entity that cascades. This means you cannot have a relationship with any action set to Cascade All, Cascade Active, or Cascade User-Owned between a primary custom entity and a related system entity.  
> - No new relationship can have any action set to **Cascade All**, **Cascade Active**, or **Cascade User-Owned** if the related entity in that relationship already exists as a related entity in another relationship that has any action set to **Cascade All**, **Cascade Active**, or **Cascade User-Owned**. This prevents relationships that create a multi-parent relationship.  
> - Any time you change user-interface elements or implement form scripts for an entity, you need to publish changes to apply them. Any customizations that change the data schema of an app, such as custom entities, relationships, or fields are applied immediately.  
> - If a relationship is part of a managed solution, the developer of the managed solution can restrict you from customizing the relationship.  
> - [!INCLUDE[cc_solution_recommendation](../includes/cc-solution-recommendation.md)]  
  
## Relationship definition  
 Depending on whether you chose to create a **New 1-to-Many Relationship** or a **New Many-to-1 Relationship** from the solution explorer, either the **Primary Entity** or **Related Entity** fields will be pre-populated. You only need to choose the other one. A default value for the **Name** field is pre-populated based on the solution publisher’s customization prefix and the names of the entities you choose to participate in the relationship. You can edit this if you want. If you create more than one custom relationship between two entities and use the same customization prefix for both, the auto-generated name value will not be unique and you will not be able to save the new relationship. You must edit the name to differentiate it from any existing name before you can save it. Once saved, you cannot change it.  
  
 If you don’t want to have this entity relationship visible in **Advanced Find**, set the **Searchable** value to **No**.  
  
## Lookup fields  
 These fields are the common properties all fields have except **Searchable**, **Field Security**, and **Auditing**. To edit these values for the lookup field that is created with the entity relationship, you must locate and edit the lookup field separately after you create the entity relationship. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit fields](../customize/create-edit-fields.md#BKMK_CreatingAndEditngFields).  
  
 As a general rule, the **Display Name** should correspond to the primary entity display name.  
  
<a name="BKMK_NavigationPaneOptions"></a>   

## Navigation pane item for primary entity  
 The primary entity can reveal lists of related entities if you expand the navigation pane. The options in this group control how or whether to display this list. These navigation items can also be edited using the form editor and, by using [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)], a developer can apply changes to these items when the form is displayed.  
  
|Field|Description|  
|-----------|-----------------|  
|**Display Option**|- **Do Not Display**: Choose this if you do not want to allow people to be able to navigate to a list of related entity records.<br />- **Use Custom Label**: Choose this if you want to specify a custom label to use.<br />- **Use Plural Name**: Choose this if you want to use the plural name of the related entity as the label.|  
|**Custom Label**|When you select **Use Custom Label** as the display option, enter the custom label you want to use instead of the related entity plural name.|  
|**Display Area**|- **Details**: Choose this to include the navigation item in the **Common** group.<br />- **Marketing**: Choose this to include the navigation item in the **Marketing** group.<br />- **Sales**: Choose this to include the navigation item in the **Sales** group.<br />- **Service**: Choose this to include the navigation item in the **Service** group.|  
|**Display Order**|This number controls where the navigation item will be included within the selected display area. The range of allowed numbers begins with 10,000. Navigation pane items with a lower value appear above other relationships with a higher value.|  
  
## Relationship behavior  
 In a 1:N relationship, you can control how the relationship behaves to support business rules for your organization. Why would you want to do this? Let’s look at an example.  
  
 Let’s say that you have a new salesperson and you want to assign them a number of existing opportunities currently assigned to another salesperson. Each opportunity record may have a number of task activities associated with it. You can easily locate the active opportunities you want to reassign and assign them to the new salesperson. But what should happen for any of the task activities that are associated with the opportunities? Do you want to open each task and decide whether they should also be assigned to the new salesperson? Probably not. Instead, you can let the relationship apply some standard rules for you automatically. These rules only apply to task records associated to the opportunities you are reassigning. The entity relationship is named **Opportunity_Tasks**. Your options are:  
  
- Reassign all active tasks.  
  
- Reassign all tasks. This is the default behavior.  
  
- Reassign none of the tasks.  
  
- Reassign all tasks currently assigned to the former owner of the opportunity.  
  
  The relationship can control how actions performed on a record for the primary entity record cascade down to any related entity records. The actions and possible behaviors are shown in the following table.  
  
|Action|Description|Possible behaviors|  
|------------|-----------------|------------------------|  
|**Assign**|What should happen when the primary entity record changes ownership?|-   Cascade Active<br />-   Cascade All<br />-   Cascade None<br />-   Cascade User Owned|  
|**Share**|What should happen when the primary entity record is shared?|-   Cascade Active<br />-   Cascade All<br />-   Cascade None<br />-   Cascade User Owned|  
|**Unshare**|What should happen when sharing of the primary entity record stops?|-   Cascade Active<br />-   Cascade All<br />-   Cascade None<br />-   Cascade User Owned|  
|**Reparent**|What should happen when a lookup field value for a parental type relationship in the primary entity record is changed?<br /><br /> A parental type relationship is one that uses **Cascade All** for all actions. -   Cascade Active<br />-   Cascade All<br />-   Cascade None<br />-   Cascade User Owned|  
|**Delete**|What should happen when the primary entity record is deleted?|-   Cascade All<br />-   Remove Link<br />-   Restrict Delete|  
|**Merge**|What should happen when the primary entity record is merged with another record?|-   Cascade All<br />-   Cascade None|  
  
 Each of these actions can be configured to control how actions cascade down to records related to the primary entity record through the 1:N entity relationship. The behavior options are in the following table.  
  
|Behavior|Description|  
|--------------|-----------------|  
|**Cascade Active**|Perform the action on all active related entity records.|  
|**Cascade All**|Perform the action on all related entity records.|  
|**Cascade None**|Do nothing.|  
|**Remove Link**|Remove the value of the lookup field for all related entity records.|  
|**Restrict Delete**|Prevent the primary entity record from being deleted when related records exist.|  
|**Cascade User Owned**|Perform the action on all related entity records owned by the same user as the primary entity record.|  
  
 How these actions are applied within a relationship can be categorized or applied using the **Type of Behavior** field values described in the following table.  
  
|Field value|Description|  
|-----------------|-----------------|  
|**Parental**|All actions use the **Cascade All** behavior.<br /><br /> |  
|**Referential**|**Assign**, **Share**, **Unshare**, and **Reparent** use the **Cascade None** behavior.<br /><br /> **Delete** uses the **Remove Link** behavior.<br /><br /> **Merge** uses the **Cascade All** behavior.|  
|**Referential, Restrict Delete**|The same as **Referential**, except that **Delete** uses the **Restrict Delete** behavior.|  
|**Configurable Cascading**|Individual behaviors can be assigned for each action. If the choices match any of the other **Type of Behavior** categories, the value will change to that **Type of Behavior** value.|  
  
<a name="BKMK_RelationshipBehaviorLimitations"></a>   

## Limitations on behaviors you can set  
 There are some limitations you should keep in mind when you define entity relationships.  
  
-   A custom entity can’t be the primary entity in a relationship with a related system entity that cascades. This means you can’t have a relationship with any action set to **Cascade All**, **Cascade Active**, or **Cascade User-Owned** between a primary custom entity and a related system entity.  
  
-   No new relationship can have any action set to **Cascade All**, **Cascade Active**, or **Cascade User-Owned** if the related entity in that relationship already exists as a related entity in another relationship that has any action set to **Cascade All**, **Cascade Active**, or **Cascade User-Owned**. This prevents relationships that create a multi-parent relationship.  

-   Cascading on merge can't be set or changed, and is dependent on the referenced entity. If the referenced entity is an account, contact, or lead, the action cascades. Otherwise, it does not.

### See also

[Create N:N (many-to-many) relationships](../customize/create-and-edit-nn-many-to-many-relationships.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]