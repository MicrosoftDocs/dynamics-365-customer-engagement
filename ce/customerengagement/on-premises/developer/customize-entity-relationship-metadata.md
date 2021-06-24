---
title: "Customize entity relationship metadata (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The topic explains about working with entity relationships programmatically. Also, types of entity relationships and configuring associated menus."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 44ab54f6-f55a-4cf8-98f4-cbd4358286c7
caps.latest.revision: 36
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Customize entity relationship metadata

Entity relationships define the ways that entity records can be associated with records of other entities or the same entity. Creating new entity relationships creates new table relationships in the database. Use entity relationships to define specific associations that are frequently used to associate records for reports or in the user interface. Once a relationship exists, you can associate and disassociate records based on the relationship using the `Associate` and `Disassociate` methods. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Actions on Entity Records](introduction-entities.md#ActionsOnEntityRecords)  
  
 For relationships between individual records that are less formal and more flexible, see [Connection Entities](connection-entities.md).  
  
 This topic is about working with entity relationships programmatically. For information about working with entity relationship in the application, see [Create and edit entity relationships](../customize/create-edit-entity-relationships.md).  
  
<a name="BKMK_TypesOfEntityRelationships"></a>   
## Types of entity relationships  
 Dynamics 365 Customer Engagement (on-premises) provides two types of entity relationships. Both of these inherit from the <xref:Microsoft.Xrm.Sdk.Metadata.RelationshipMetadataBase> class:  
  
- **[One-to-many relationships](customize-entity-relationship-metadata.md#BKMK_OneToManyRelationships)**  
  
- **[Many-to-many relationships](customize-entity-relationship-metadata.md#BKMK_ManyToManyRelationships)**  
  
  Before you create a new entity relationship programmatically, check to see whether the entities are eligible to participate in the relationship. There are constraints applied to entity relationships that use the following `EntityMetadata` properties: `CanBeInManyToMany`, `CanBePrimaryEntityInRelationship`, and `CanBeRelatedEntityInRelationship`. These restrictions are taken into account when you manually create entity relationships in the customization tools. There are messages that you can use to determine which relationships an entity can use and what other entities are valid for that type of relationship. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Entity Relationship Eligibility](entity-relationship-eligibility.md)  
  
  Both types of entity relationships allow for options to display navigation links between related records. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configuring Associated Menus](customize-entity-relationship-metadata.md#BKMK_ConfiguringAssociatedMenus)  
  
<a name="BKMK_OneToManyRelationships"></a>   
## One-to-many relationships  
 In a one-to-many entity relationship, many referencing (related) entity records can be associated with a single referenced (primary) entity record. The referenced entity record is sometimes referred to as the ”parent” and records of the referencing entity are referred to as ”children.”  
  
 In an entity node on a solution page, this kind of entity relationship is displayed as either a **1-to-Many (1:N) Relationship** or a **Many-to-1 (N:1) Relationship**. These terms are used because you navigate to entity relationships through one of the entities. The label reflects which role the current entity has in the relationship.  

 > [!NOTE]
 > See [Web API: Create a one-to-many relationship](/powerapps/developer/common-data-service/webapi/create-update-entity-relationships-using-web-api#create-a-one-to-many-relationship) for information on how to use the Web API for creating a 1:N relationship.
 
 For Organization Service, you use an instance of the <xref:Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata> class when you work with this kind of entity relationship. Each entity relationship has a unique schema name that you use to retrieve it. For more information, see <xref:Microsoft.Xrm.Sdk.Metadata.RelationshipMetadataBase.SchemaName>. Each entity relationship of this kind also has a referenced entity (**Primary Entity**) with a referenced attribute, and a referencing entity (**Related Entity**) with a referencing attribute. The referencing attribute can be displayed as a lookup field in an entity form. For more information, see 
 
 |Web API|SDK Assembly|
 |---------------|---------------|
 |<xref href="Microsoft.Dynamics.CRM.OneToManyRelationshipMetadata?text=OneToManyRelationshipMetadata EntityType" />.ReferencedEntity|<xref:Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata.ReferencedEntity>| 
 |<xref href="Microsoft.Dynamics.CRM.OneToManyRelationshipMetadata?text=OneToManyRelationshipMetadata EntityType" />.ReferencedAttribute|<xref:Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata.ReferencedAttribute>|
|<xref href="Microsoft.Dynamics.CRM.OneToManyRelationshipMetadata?text=OneToManyRelationshipMetadata EntityType" />.ReferencingEntity|<xref:Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata.ReferencingEntity>|
|<xref href="Microsoft.Dynamics.CRM.OneToManyRelationshipMetadata?text=OneToManyRelationshipMetadata EntityType" />.ReferencingAttribute| <xref:Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata.ReferencingAttribute>|  
  
 You may require that a referencing entity have a reference by setting the `AttributeRequiredLevel` enumeration (<xref href="Microsoft.Dynamics.CRM.AttributeRequiredLevel?text=AttributeRequiredLevel EnumType" /> or <xref:Microsoft.Xrm.Sdk.Metadata.AttributeRequiredLevel> enumeration) to `ApplicationRequired` on the referencing attribute. To maintain data integrity, when you do this you should also specify what you want to occur if the primary record is deleted. Use the `OneToManyRelationshipMetadata.CascadeConfiguration` property to either prevent deleting the primary record or automatically delete the related record as well to prevent an orphaned record.  
  
 You can also use cascading configuration to automate behavior when specific actions are taken on related records in the organization. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Entity Relationship Behavior](entity-relationship-behavior.md)  
  
### Map data to new records  
 When there is a one-to-many entity relationship, you can specify that data from certain fields in the referenced entity can be transferred to any new related records created in the context of the relationship. This can streamline data entry when you are creating new related records. For more information, see  [Entity and Attribute Mappings](customize-entity-attribute-mappings.md).  
  
### Self-referencing one-to-many entity relationships  
 A self-referencing relationship is where the referencing and referenced entity is the same. For example, the account entity has a self-referencing one-to-many relationship that allows for a lookup labeled **Parent Account**. If the entity relationship behavior is defined as **Parental** it is not possible for a record to reference itself because this would create a circular reference when cascading behaviors are applied. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Entity Relationship Behavior](entity-relationship-behavior.md)  
  
<a name="BKMK_HierarchicalRelationships"></a>   
### Hierarchical one-to-many entity relationships  

 With Dynamics 365 Customer Engagement (on-premises), you can specify one self-referencing one-to-many entity relationship as the designated hierarchical relationship for an entity. The `OneToManyRelationship.IsHierarchical` property (OneToManyRelationship.IsHierarchical or <xref:Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata.IsHierarchical>) flags this relationship as the one-to-many relationship to use for the entity.  
  
 All one-to-many entity relationships represent a type of hierarchy, but relationships explicitly flagged using the `IsHierarchical` property are the only entity relationships that support the hierarchy visualizations in the application as well as new query operators to retrieve hierarchically related records. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Query hierarchical data](/powerapps/developer/data-platform/query-hierarchical-data)  
  
### Change the name of Web API navigation properties  
 If you want to apply a custom Web API navigation property name for a one-to-many relationship you can set values for the `OneToManyRelationshipMetadata.ReferencingEntityNavigationPropertyName` and `OneToManyRelationshipMetadata.ReferencedEntityNavigationPropertyName` properties.  
  
<a name="BKMK_ManyToManyRelationships"></a>   
## Many-to-many relationships  
 In a many-to-many entity relationship many entity records can be associated with many other entity records. Unlike one-to-many relationships, there is no lookup field on either entity and therefore no intended hierarchy. Records related using a many-to-many relationship can be considered peers and the relationship is reciprocal. A many-to-many relationship may also be self-referential. Because there is no cascading behavior involved in many-to-many relationships, you can allow an individual record to have a reference to itself.  

 > [!NOTE]
 > See [Create a Many-to-Many relationship using the Web API](/powerapps/developer/common-data-service/webapi/create-update-entity-relationships-using-web-api#create-a-many-to-many-relationship) for information on how to use the Web API for creating a N:N relationship.
 
 You use an instance of the `ManyToManyRelationshipMetadata` (<xref href="Microsoft.Dynamics.CRM.ManyToManyRelationshipMetadata?text=ManyToManyRelationshipMetadata EntityType" /> or <xref:Microsoft.Xrm.Sdk.Metadata.ManyToManyRelationshipMetadata> class) when you work with this kind of entity relationship. Each entity relationship has a unique `RelationshipMetadataBase.SchemaName` that you use to retrieve it.  

  
 Creating a many-to-many entity relationship creates a new intersect entity where the `EntityMetadata.IsIntersect` property is true. Records for this entity track each individual many-to-many relationship. You cannot add custom attributes to intersect entities.  
  
### Change the name of Web API navigation properties  
 If you want to apply a custom Web API navigation property name for a many-to-many relationship you can set values for the <xref href="Microsoft.Dynamics.CRM.ManyToManyRelationshipMetadata?text=ManyToManyRelationshipMetadata EntityType" />.Entity1NavigationPropertyName and <xref href="Microsoft.Dynamics.CRM.ManyToManyRelationshipMetadata?text=ManyToManyRelationshipMetadata EntityType" />.Entity2NavigationPropertyName properties.  
  
<a name="BKMK_ConfiguringAssociatedMenus"></a>   
## Configure associated menus  

 Both types of entity relationships allow for configuration of navigation links between related records. Use the `Metadata.AssociatedMenuConfiguration` properties in each type of entity relationship definition to specify how you want the navigation links in an entity form to be displayed.  
  
 These values provide the default configuration for the relationship. You can use the form editor to override these options for each form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Change navigation within a form](../customize/use-the-form-editor-legacy.md)
  
 **<xref:Microsoft.Xrm.Sdk.Metadata.AssociatedMenuConfiguration.Behavior>**  
 Provides the following options:  
  
- DoNotDisplay  
  
- UseCollectionName  
  
- UseLabel  
  
  **<xref:Microsoft.Xrm.Sdk.Metadata.AssociatedMenuConfiguration.Group>**  
  Provides the following options:  
  
- Details  
  
- Marketing  
  
- Sales  
  
- Service  
  
  You cannot add new groups, but you can change the text displayed for them using the form editor.  
  
  **Label**  
  If you select `AssociatedMenuBehavior.UseLabel`, you must provide a custom label.  
  
  **Order**  
  The integer provided for the order will control the relative position of navigation items in the group. The lower the value, the higher the item appears relative to the values of other items in the group.  
  
### See also  
 [Create and update entity relationships using Web API](/powerapps/developer/data-platform/webapi/create-update-entity-relationships-using-web-api)  
 [Extend the Metadata Model for Dynamics 365 Customer Engagement (on-premises)](org-service/use-organization-service-metadata.md)   
 [Entity Relationship Messages](entity-relationship-metadata-messages.md)   
 [Entity Relationship Eligibility](entity-relationship-eligibility.md)   
 [Entity Relationship Behavior](entity-relationship-behavior.md)   
 [Create Entity Relationships](/powerapps/developer/data-platform/org-service/metadata-relationshipmetadata)   
 [Sample: Create Entity Relationships](/powerapps/developer/data-platform/org-service/metadata-relationshipmetadata)   
 [Sample: Dump Entity Relationship Information to a File](/powerapps/developer/data-platform/org-service/metadata-relationshipmetadata)   
 [Entity and Attribute Mappings](customize-entity-attribute-mappings.md)   
 [Retrieve Records for Many-To-Many Relationships using Intersect Entities](/powerapps/developer/data-platform/org-service/samples/retrieve-records-intersect-table)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]