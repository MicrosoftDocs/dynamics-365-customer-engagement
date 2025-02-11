---
title: "Property Association (DynamicPropertyAssociation) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Property Association (DynamicPropertyAssociation) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Property Association (DynamicPropertyAssociation) table/entity reference (Microsoft Dynamics 365)

Association of a property definition with another entity in the system.

## Messages

The following table lists the messages for the Property Association (DynamicPropertyAssociation) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: False |`POST` /dynamicpropertyassociations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: False |`DELETE` /dynamicpropertyassociations(*dynamicpropertyassociationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: False |`GET` /dynamicpropertyassociations(*dynamicpropertyassociationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /dynamicpropertyassociations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: False |`PATCH` /dynamicpropertyassociations(*dynamicpropertyassociationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /dynamicpropertyassociations(*dynamicpropertyassociationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Property Association (DynamicPropertyAssociation) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Property Association** |
| **DisplayCollectionName** | **Property Associations** |
| **SchemaName** | `DynamicPropertyAssociation` |
| **CollectionSchemaName** | `DynamicPropertyAssociations` |
| **EntitySetName** | `dynamicpropertyassociations`|
| **LogicalName** | `dynamicpropertyassociation` |
| **LogicalCollectionName** | `dynamicpropertyassociations` |
| **PrimaryIdAttribute** | `dynamicpropertyassociationid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AssociationStatus](#BKMK_AssociationStatus)
- [DMTImportState](#BKMK_DMTImportState)
- [DynamicPropertyAssociationId](#BKMK_DynamicPropertyAssociationId)
- [DynamicPropertyId](#BKMK_DynamicPropertyId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [InheritanceState](#BKMK_InheritanceState)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [RegardingObjectid](#BKMK_RegardingObjectid)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_AssociationStatus"></a> AssociationStatus

|Property|Value|
|---|---|
|Description|**Shows the status of the property association.**|
|DisplayName|**Association Status.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`associationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`dynamicpropertyassociation_associationstatus`|

#### AssociationStatus Choices/Options

|Value|Label|
|---|---|
|0|**Active**|
|1|**Deleted**|
|2|**Draft**|
|3|**Draft Added**|
|4|**Draft Deleted**|

### <a name="BKMK_DMTImportState"></a> DMTImportState

|Property|Value|
|---|---|
|Description|**Internal Use Only**|
|DisplayName|**Internal Use Only**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`dmtimportstate`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_DynamicPropertyAssociationId"></a> DynamicPropertyAssociationId

|Property|Value|
|---|---|
|Description|**Shows the unique identifier of the property association.**|
|DisplayName|**Property Association ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`dynamicpropertyassociationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_DynamicPropertyId"></a> DynamicPropertyId

|Property|Value|
|---|---|
|Description|**Shows the property that uses this option set item.**|
|DisplayName|**Property ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`dynamicpropertyid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|dynamicproperty|

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_InheritanceState"></a> InheritanceState

|Property|Value|
|---|---|
|Description|**Shows the inheritance state in relationship to the parent property.**|
|DisplayName|**Inheritance State.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`inheritancestate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`dynamicpropertyassociation_inheritancestate`|

#### InheritanceState Choices/Options

|Value|Label|
|---|---|
|0|**Inherited**|
|1|**Overridden**|
|2|**Owned**|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**name**|
|DisplayName|**name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_RegardingObjectid"></a> RegardingObjectid

|Property|Value|
|---|---|
|Description|**Shows the object that the property is associated with.**|
|DisplayName|**Regarding**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjectid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|product, productassociation|

### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|---|---|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`regardingobjecttypecode`|
|RequiredLevel|None|
|Type|EntityName|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Shows the currency associated with the record.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was created.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who created the record.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-12|
|Precision|12|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the record was modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|organization|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [Dynamicproperty_DynamicPropertyAssociation](#BKMK_Dynamicproperty_DynamicPropertyAssociation)
- [DynamicPropertyAssociation_organization](#BKMK_DynamicPropertyAssociation_organization)
- [DynamicPropertyAssociation_TransactionCurrency](#BKMK_DynamicPropertyAssociation_TransactionCurrency)
- [lk_DynamicPropertyAssociationattribute_createdby](#BKMK_lk_DynamicPropertyAssociationattribute_createdby)
- [lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy](#BKMK_lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy)
- [lk_DynamicPropertyAssociationattribute_ModifiedBy](#BKMK_lk_DynamicPropertyAssociationattribute_ModifiedBy)
- [lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy](#BKMK_lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy)
- [Product_DynamicPropertyAssociation](#BKMK_Product_DynamicPropertyAssociation)
- [ProductAssociation_DynamicPropertyAssociation](#BKMK_ProductAssociation_DynamicPropertyAssociation)

### <a name="BKMK_Dynamicproperty_DynamicPropertyAssociation"></a> Dynamicproperty_DynamicPropertyAssociation

One-To-Many Relationship: [dynamicproperty Dynamicproperty_DynamicPropertyAssociation](dynamicproperty.md#BKMK_Dynamicproperty_DynamicPropertyAssociation)

|Property|Value|
|---|---|
|ReferencedEntity|`dynamicproperty`|
|ReferencedAttribute|`dynamicpropertyid`|
|ReferencingAttribute|`dynamicpropertyid`|
|ReferencingEntityNavigationPropertyName|`dynamicpropertyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_DynamicPropertyAssociation_organization"></a> DynamicPropertyAssociation_organization

One-To-Many Relationship: [organization DynamicPropertyAssociation_organization](organization.md#BKMK_DynamicPropertyAssociation_organization)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_DynamicPropertyAssociation_TransactionCurrency"></a> DynamicPropertyAssociation_TransactionCurrency

One-To-Many Relationship: [transactioncurrency DynamicPropertyAssociation_TransactionCurrency](transactioncurrency.md#BKMK_DynamicPropertyAssociation_TransactionCurrency)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicPropertyAssociationattribute_createdby"></a> lk_DynamicPropertyAssociationattribute_createdby

One-To-Many Relationship: [systemuser lk_DynamicPropertyAssociationattribute_createdby](systemuser.md#BKMK_lk_DynamicPropertyAssociationattribute_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy"></a> lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy

One-To-Many Relationship: [systemuser lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy](systemuser.md#BKMK_lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicPropertyAssociationattribute_ModifiedBy"></a> lk_DynamicPropertyAssociationattribute_ModifiedBy

One-To-Many Relationship: [systemuser lk_DynamicPropertyAssociationattribute_ModifiedBy](systemuser.md#BKMK_lk_DynamicPropertyAssociationattribute_ModifiedBy)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy"></a> lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy

One-To-Many Relationship: [systemuser lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy](systemuser.md#BKMK_lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_Product_DynamicPropertyAssociation"></a> Product_DynamicPropertyAssociation

One-To-Many Relationship: [product Product_DynamicPropertyAssociation](product.md#BKMK_Product_DynamicPropertyAssociation)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_ProductAssociation_DynamicPropertyAssociation"></a> ProductAssociation_DynamicPropertyAssociation

One-To-Many Relationship: [productassociation ProductAssociation_DynamicPropertyAssociation](productassociation.md#BKMK_ProductAssociation_DynamicPropertyAssociation)

|Property|Value|
|---|---|
|ReferencedEntity|`productassociation`|
|ReferencedAttribute|`productassociationid`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencingEntityNavigationPropertyName|`regardingobjectid_productassociation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [dynamicpropertyassociation_AsyncOperations](#BKMK_dynamicpropertyassociation_AsyncOperations)
- [dynamicpropertyassociation_BulkDeleteFailures](#BKMK_dynamicpropertyassociation_BulkDeleteFailures)
- [dynamicpropertyassociation_MailboxTrackingFolders](#BKMK_dynamicpropertyassociation_MailboxTrackingFolders)
- [dynamicpropertyassociation_PrincipalObjectAttributeAccesses](#BKMK_dynamicpropertyassociation_PrincipalObjectAttributeAccesses)
- [dynamicpropertyassociation_SyncErrors](#BKMK_dynamicpropertyassociation_SyncErrors)

### <a name="BKMK_dynamicpropertyassociation_AsyncOperations"></a> dynamicpropertyassociation_AsyncOperations

Many-To-One Relationship: [asyncoperation dynamicpropertyassociation_AsyncOperations](asyncoperation.md#BKMK_dynamicpropertyassociation_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyassociation_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyassociation_BulkDeleteFailures"></a> dynamicpropertyassociation_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure dynamicpropertyassociation_BulkDeleteFailures](bulkdeletefailure.md#BKMK_dynamicpropertyassociation_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyassociation_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyassociation_MailboxTrackingFolders"></a> dynamicpropertyassociation_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder dynamicpropertyassociation_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_dynamicpropertyassociation_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyassociation_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyassociation_PrincipalObjectAttributeAccesses"></a> dynamicpropertyassociation_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess dynamicpropertyassociation_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_dynamicpropertyassociation_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyassociation_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyassociation_SyncErrors"></a> dynamicpropertyassociation_SyncErrors

Many-To-One Relationship: [syncerror dynamicpropertyassociation_SyncErrors](syncerror.md#BKMK_dynamicpropertyassociation_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyassociation_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

