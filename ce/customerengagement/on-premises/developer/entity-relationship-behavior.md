---
title: "Entity relationship behavior (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
descriptions: Cascading of behaviors may arise in case of one-to-many entity relationships and they can be configured to preserve data integrity and automate business processes
ms.custom: 
ms.date: 11/03/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - entity relationship behaviors, automating business processes
  - entity relationship behaviors, preserving data integrity
  - reparent actions
  - automating business processes
  - entity relationship behaviors, overview
  - parental relationships between entities
  - entity relationship behaviors, parental relationships between entities
  - cascading behaviors from one-to-many entity relationships
  - entity relationship behaviors, reparent actions
  - configuring entity relationship behaviors, associated classes and properties to use
  - entity relationship behaviors, configuring entity relationship behaviors
  - entity relationship behaviors, cascading behaviors from one-to-many entity relationships
  - preserving data integrity
  - entity relationship behaviors, cascading behaviors of related entities in the entity hierarchy
ms.assetid: 841dbfc8-05e1-4992-83ac-b9d47eab1e7b
caps.latest.revision: 27
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Entity relationship behavior

When a one-to-many entity relationship exists there are cascading behaviors that can be configured to preserve data integrity and automate business processes. This topic will explain some key concepts and describe how you can configure these cascading behaviors.  
  
 Before describing how to configure entity relationship behaviors it is useful to consider how it applies to your business. Three key concepts are:  
  
-   [Preserve data integrity](entity-relationship-behavior.md#BKMK_DataIntegrity)  
  
-   [Automate business processes](entity-relationship-behavior.md#BKMK_BusinessProcesses)  
  
-   [Cascading behavior](entity-relationship-behavior.md#BKMK_CascadingBehavior)  
  
<a name="BKMK_DataIntegrity"></a>   
## Preserve data integrity  
 Each entity can have rules that define a valid record. For example, a Dynamics 365 Customer Engagement (on-premises) opportunity record must include a reference to a potential customer. Users can’t create a new opportunity record without either adding an existing customer or creating a new customer record.  
  
 But what if the account or contact that represents the customer is deleted? In a case like this, possible alternatives are to either:  
  
- Restrict any attempt to delete a customer record with an associated opportunity.  
  
- Cascade the delete action when a corresponding customer record is deleted so that any related opportunity records are automatically deleted.  
  
  In Dynamics 365 Customer Engagement (on-premises) for the one-to-many relationships that relate opportunities with customers, such as `Opportunity.opportunity_customer_accounts` and `Contact.opportunity_customer_contacts`, the behavior is to cascade the delete action.  
  
  When you model your data to use in Dynamics 365 Customer Engagement (on-premises) you will have similar decisions for how you want to preserve data integrity.  
  
<a name="BKMK_BusinessProcesses"></a>   
## Automate business processes  
 Your business processes may require you to perform actions on records that have related records. For example, you may need to assign an account to a new salesperson. If that account record has any opportunity records, some options include:  
  
- **Do nothing.** The opportunities should continue to be owned by the individuals who work on them.  
  
- **Assign all the opportunities to the new salesperson.** As the new owner of this account record, the salesperson is now responsible for all opportunities related to that account.  
  
- **Only assign the active opportunities to the new salesperson.** Preserve the owner for any inactive opportunity records for reporting purposes.  
  
- **Only assign the opportunities owned by the previous account owner to the new salesperson**. This allows the new salesperson to replace the previous owner.  
  
  These options are common ones you can configure using entity relationship behavior in Dynamics 365 Customer Engagement (on-premises). If you require different behaviors consider purchasing a solution containing the behavior you need or developing a plugin to provide additional options.  
  
<a name="BKMK_CascadingBehavior"></a>   
## Cascading behavior  
 These configuration options are called cascading behaviors because they cascade down the hierarchy of related entities. For example, if deleting an account causes related opportunities to be deleted, what about the activities associated with the opportunities? In Dynamics 365 Customer Engagement (on-premises) the behavior defined in each of the entity relationships for activity type entities is that they are deleted as well.  
  
 However, not all entities are treated this way. For example, orders and invoices contain important business data that shouldn’t be inadvertently deleted. They have entity relationship behavior configured to restrict deleting customer or opportunity records that they are associated with. Before you can delete the customer or opportunity that has a related order or invoice record, you must delete the order or invoice first.  
  
 As you model your business data by creating custom entities or when using existing Dynamics 365 Customer Engagement (on-premises) system entities, consider the behavior you require and the implications for the entire hierarchy of related entities.  
  
<a name="BKMK_ParentalEntityRelationships"></a>   
## Parental entity relationships  
 Each pair of entities that are eligible to have a 1:N relationship can have multiple 1:N relationships between them. Yet only one of those relationships can be considered a *parental* entity relationship. See [Customizable parental entity relationships](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn531061(v=crm.8)) for a list of all the customizable parental entity relationships.  
  
 A parental entity relationship is any 1:N entity relationship where one of the cascading options (defined in <xref:Microsoft.Xrm.Sdk.Metadata.CascadeType>) in the **Parental** column of the following table is true.  
  
|Action|Parental|Not Parental|  
|------------|--------------|------------------|  
|**Delete**|Cascade|RemoveLink<br />Restrict|  
|**Share**|Cascade<br />UserOwned<br />Active|NoCascade|  
|**Unshare**|Cascade<br />UserOwned<br />Active|NoCascade|  
|**Assign**|Cascade<br />UserOwned<br />Active|NoCascade|  
|**Reparent**|Cascade<br />UserOwned<br />Active|NoCascade|  
  
 Each referencing entity in a 1:N entity relationship has one referencing  attribute where the relationship can be considered parental.  
  
 For example, if you create a new custom entity and add a 1:N entity relationship with the account entity where your custom entity is the referencing entity, you can configure the actions for that entity relationship to use the options in the **Parental** column. If you later add another 1:N entity relationship with your custom entity as the referencing entity you can only configure the actions to use the options in the **Not Parental** column.  
  
 Usually this means that for each entity pair there is only one parental relationship. There are some cases where the referencing attribute on the referencing may include a reference to more than one type of entity.  
  
 For example, the `Opportunity` entity has a referencing attribute called `customerid` where a reference to either a contact or account record may be stored. There are two separate parental 1:N entity relationships in this case.  
  
 Any activity entity, for example, a task, fax, phone call, and so on, has a similar set of parental entity relationships for entities that can be associated using the `regardingobjectid` referencing attribute.  
  
<a name="BKMK_ConfigureEntityRelationshipBehavior"></a>   
## Configure entity relationship behavior  

### Using Web API

When working with Web API, you can define a One-to-Many relationship using <xref href="Microsoft.Dynamics.CRM.OneToManyRelationshipMetadata?text=OneToManyRelationshipMetadata EntityType" />. This definition includes the name of the intersect entity to be created as well as how the relationship should be displayed in the application by using <xref href="Microsoft.Dynamics.CRM.AssociatedMenuConfiguration?text=AssociatedMenuConfiguration ComplexType" />, <xref href="Microsoft.Dynamics.CRM.Label?text=Label ComplexType" /> and <xref href="Microsoft.Dynamics.CRM.LocalizedLabel?text=LocalizedLabel ComplexType" />. More information: [Create a One-to-Many relationship](/powerapps/developer/common-data-service/webapi/create-update-entity-relationships-using-web-api#create-a-one-to-many-relationship).

### Using Organization Service

When you use <xref:Microsoft.Xrm.Sdk.Messages.CreateOneToManyRequest> or <xref:Microsoft.Xrm.Sdk.Messages.UpdateRelationshipRequest> you include an instance of a <xref:Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata> class in the body of the request. In the <xref:Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata.CascadeConfiguration> property of that class you use the <xref:Microsoft.Xrm.Sdk.Metadata.CascadeConfiguration> class.  


The `CascadeConfiguration` (<xref:Microsoft.Xrm.Sdk.Metadata.CascadeConfiguration> class or <xref href="Microsoft.Dynamics.CRM.CascadeConfiguration?text=CascadeConfiguration ComplexType" />) contains the properties representing actions that may be performed on the referenced entity in the one-to-many entity relationship. Each property can be assigned one of the values of the <xref href="Microsoft.Dynamics.CRM.CascadeType?text=CascadeType EnumType" />.  

|Value|Application label|Description|  
|-----------|-----------------------|-----------------|  
|Active|Cascade Active|Perform the action on all active referencing entity records associated with the referenced entity record.|  
|Cascade|Cascade All|Perform the action on all referencing entity records associated with the referenced entity record.|  
|NoCascade|Cascade None|Do nothing.|  
|RemoveLink|Remove Link|Remove the value of the referencing attribute for all referencing entity records associated with the referenced entity record.|  
|Restrict|Restrict|Prevent the Referenced entity record from being deleted when referencing entities exist.|  
|UserOwned|Cascade User Owned|Perform the action on all referencing entity records owned by the same user as the referenced entity record.|  
  
 The `CascadeConfiguration` (<xref:Microsoft.Xrm.Sdk.Metadata.CascadeConfiguration> class or <xref href="Microsoft.Dynamics.CRM.CascadeConfiguration?text=CascadeConfiguration ComplexType" />) contains the following properties representing actions that may be performed on the referenced entity in the one-to-many entity relationship.  
  
|Action|Description|Valid options|  
|------------|-----------------|-------------------|  
|Assign|The referenced entity record owner is changed.|Active<br />Cascade<br />NoCascade<br />UserOwned|  
|Delete|The referenced entity record is deleted. **Note:**  The options for this action are limited.|Cascade<br />RemoveLink<br />Restrict|  
|Merge|The record is merged with another record. **Note:**  For referenced entities that can be merged, Cascade is the only valid option. In other cases use NoCascade.|Cascade<br />NoCascade|  
|Reparent|See [About the Reparent action](entity-relationship-behavior.md#BKMK_ReparentAction) below.|Active<br />Cascade<br />NoCascade<br />UserOwned|  
|Share|When the referenced entity record is shared with another user.|Active<br />Cascade<br />NoCascade<br />UserOwned|  
|Unshare|When sharing is removed for the referenced entity record.|Active<br />Cascade<br />NoCascade<br />UserOwned|  
  
<a name="BKMK_ReparentAction"></a>   
### About the reparent action  
 The reparent action is very similar to the share action except that it deals with the inherited read access rights instead of explicit read access rights.  
  
> [!NOTE]
>  For more information about inherited access rights, see [Use record-based security to control access to records](security-dev/use-record-based-security-control-access-records.md), especially the [Sharing and Inheritance](security-dev/use-record-based-security-control-access-records.md#BKMK_SharingAndInheritance) section.  
  
 The reparent action is when you change the value of the referencing attribute in a parental relationship. When a reparent action occurs, the desired scope of the inherited read access rights for related entities might change. The cascade actions related to the reparent action refer to changes to read access rights for the entity record and any entity records related to it. For more information about how an entity relationship is configured to be parental, see [Parental Entity Relationships](entity-relationship-behavior.md#BKMK_ParentalEntityRelationships).  
  
 For example, there is a parental relationship between Opportunity and Account based on the `CustomerId` referencing attribute. If you are the owner of an account and there is an opportunity associated with that account, you inherit read access rights to that opportunity and any records associated with it. If the `CustomerId` referencing attribute value for the opportunity is changed to refer to a different account, the owner of that account inherits read access rights to the opportunity if the Reparent action is Cascade. You can disable this automatic inheritance of read access rights if you set the reparent action to NoCascade. You can use the Active or UserOwned options to specify filters on which records are affected by the change in access rights. For any records related to the opportunity using a parental relationship, the reparent action cascades down those entity relationships and read access rights are inherited based on the filters set for the Reparent action.  
  
### See also  
 [One-To-Many Relationships](customize-entity-relationship-metadata.md#BKMK_OneToManyRelationships)  
 [Create and update entity relationships using Web API](/powerapps/developer/data-platform/webapi/create-update-entity-relationships-using-web-api)  
 [Extend the Metadata Model for Dynamics 365 Customer Engagement (on-premises)](org-service/use-organization-service-metadata.md)   
 [Customize Entity Metadata](customize-entity-metadata.md)   
 [Customize Entity Attribute Metadata](customize-entity-attribute-metadata.md)   
 [Entity Relationship Metadata](customize-entity-relationship-metadata.md)   
 [Entity and Attribute Mappings](customize-entity-attribute-mappings.md)   
 [Support Multiple Languages with Labels](customize-labels-support-multiple-languages.md)   
 [Use record-based security to control access to records](security-dev/use-record-based-security-control-access-records.md)   
 [Sample: Create and retrieve entity relationships](/powerapps/developer/data-platform/org-service/metadata-relationshipmetadata)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]