---
title: "Create N:N (many-to-many) relationships in Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn how to create many-to-may relationships"
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
ms.assetid: 248cecfd-c9e8-430b-b4b0-860669866084
caps.latest.revision: 33
ms.author: matp
manager: kvivek
tags: 
search.audienceType: 
  - customizer

---
# Create N:N (many-to-many) relationships

<a name="BKMK_CreateEditNNRelationships"></a>   

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create Many-to-many entity relationships in Dataverse using Power Apps portal](/powerapps/maker/common-data-service/create-edit-nn-relationships-portal)

 1:N entity relationships establish a hierarchy between records. With N:N (many-to-many) relationships there is no explicit hierarchy. There are no lookup fields or behaviors to configure. Records created using N:N relationships can be considered peers and the relationship is reciprocal.  
  
 With N:N relationships a special entity is created called a Relationship (or Intersect) entity. This entity has a relationship with each of the related entities and only stores the necessary values to define the relationship. You can’t add custom fields to a relationship entity.  
  
 The procedure to create a N:N relationship is essentially choosing the two entities that you want to participate in the relationship, and then for each entity defining how you want the respective lists to be available within the navigation pane of the form for each entity. These are the same options used for the primary entity in 1:N entity relationships. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Navigation Pane Item for Primary Entity](../customize/create-and-edit-1n-relationships.md#BKMK_NavigationPaneOptions)  
  
 Not all entities can be used with N:N relationships. If the **New Many-to-Many Relationship** button isn’t present, you can’t create a new N:N relationship with this entity. If you use the metadata browser, you can filter on entities that have the `CanBeInManyToMany` value set to `true`. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the metadata browser](../customize/create-edit-metadata.md#BKMK_MetadataBrowser)  
  
## Create or edit N-N relationships between entities  
  
1. Open solution explorer.
  
2. Under **Components**, expand **Entities**, and then expand the entity you want to work with.  
  
3. Select **N:N Relationships**.  
  
4. To edit or view the details for an existing relationship, select the relationship, on the Actions toolbar, click **Actions**, and then click **Edit**.  
  
    \- OR -  
  
    To add a new relationship, click **New Many-to-Many Relationship**.  
  
   > [!IMPORTANT]
   >  If **New Many-to-Many Relationship** does not appear on the Actions toolbar, you cannot create a N:N relationship for that entity.  
  
5. For a new relationship, in the **Current Entity** section, in the **Display Option** list, choose one of the following options:  
  
   - **Do Not Display**: The other entity will not display an associated view for the current entity.  
  
   - **Use Custom Label**: This label will be used for the associated view created for the other entity. Be sure to enter a corresponding value in the **Custom Label** field.  
  
   - **Use Plural Name**: This will use the plural name of the current entity for the associated view.  
  
   > [!NOTE]
   >  When the **Use Plural Name** or **Use Custom Label** options are selected, you can choose from the **Display Area** option list to specify the display area (for example Marketing or Sales) on the form where the relationship label will be displayed. You can also specify the **Display Order** to control where the label will be included within the selected display area.  
  
   > [!IMPORTANT]
   >  The navigation paradigm for the forms associated with updated entities is significantly different than that for entities that have not been updated. While the mechanics for defining the Display Area and Display Order are common, be sure you understand the various navigation paradigms as you establish entity relationships.  
  
6. In the **Other Entity** section, select the other entity from the **Entity Name** list.  
  
   > [!NOTE]
   >  When you specify the entity name, default values are set for the **Name** and **Relationship Entity Name** fields in the **Relationship Definition** section. If you change the **Entity Name** value before you save, these names will not change, so be sure these names are meaningful before saving.  
  
7. In the **Relationship Definition** section, confirm the **Name** and the **Relationship Entity Name**.  
  
    These values must be unique among N:N relationships.  
  
8. Click **Save and Close** to close the N:N Relationship form.  
  
9. When your customizations are complete, publish them:  
  
   - To publish customizations for only the component that you’re currently editing, on the **Home** tab, in the **Save** group, click **Publish**.  
  
   - To publish customizations for all unpublished components at one time, click **Publish All Customizations**.  
  
     > [!NOTE]
     >  Any time you change user-interface elements or implement form scripts for an entity, you must publish changes to apply them. Any customizations that change the data schema of Dynamics 365 Customer Engagement (on-premises) such as custom entities, relationships, or fields, are applied immediately.  
     > 
     > [!INCLUDE[cc_solution_recommendation](../includes/cc-solution-recommendation.md)]  

### See also

[Create 1:N (one-to-many) relationships](../customize/create-and-edit-1n-relationships.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]