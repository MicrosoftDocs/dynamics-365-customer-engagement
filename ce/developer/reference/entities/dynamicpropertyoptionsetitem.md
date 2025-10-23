---
title: "Property Option Set Item (DynamicPropertyOptionSetItem) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Property Option Set Item (DynamicPropertyOptionSetItem) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Property Option Set Item (DynamicPropertyOptionSetItem) table/entity reference (Microsoft Dynamics 365)

Item with a name and value in a property option set type.

## Messages

The following table lists the messages for the Property Option Set Item (DynamicPropertyOptionSetItem) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: False |`POST` /dynamicpropertyoptionsetitems<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: False |`DELETE` /dynamicpropertyoptionsetitems(*dynamicpropertyoptionsetvalueid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: False |`GET` /dynamicpropertyoptionsetitems(*dynamicpropertyoptionsetvalueid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /dynamicpropertyoptionsetitems<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: False |`PATCH` /dynamicpropertyoptionsetitems(*dynamicpropertyoptionsetvalueid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /dynamicpropertyoptionsetitems(*dynamicpropertyoptionsetvalueid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|

## Properties

The following table lists selected properties for the Property Option Set Item (DynamicPropertyOptionSetItem) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Property Option Set Item** |
| **DisplayCollectionName** | **Property Option Set Items** |
| **SchemaName** | `DynamicPropertyOptionSetItem` |
| **CollectionSchemaName** | `DynamicPropertyOptionSetItems` |
| **EntitySetName** | `dynamicpropertyoptionsetitems`|
| **LogicalName** | `dynamicpropertyoptionsetitem` |
| **LogicalCollectionName** | `dynamicpropertyoptionsetitems` |
| **PrimaryIdAttribute** | `dynamicpropertyoptionsetvalueid` |
| **PrimaryNameAttribute** |`dynamicpropertyoptionname` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [DMTImportState](#BKMK_DMTImportState)
- [DynamicPropertyId](#BKMK_DynamicPropertyId)
- [DynamicPropertyOptionDescription](#BKMK_DynamicPropertyOptionDescription)
- [DynamicPropertyOptionName](#BKMK_DynamicPropertyOptionName)
- [DynamicPropertyOptionSetValueId](#BKMK_DynamicPropertyOptionSetValueId)
- [DynamicPropertyOptionSetValueSequenceNumber](#BKMK_DynamicPropertyOptionSetValueSequenceNumber)
- [DynamicPropertyOptionValue](#BKMK_DynamicPropertyOptionValue)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

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

### <a name="BKMK_DynamicPropertyId"></a> DynamicPropertyId

|Property|Value|
|---|---|
|Description|**Shows the property that uses this option set item.**|
|DisplayName|**Property ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`dynamicpropertyid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|dynamicproperty|

### <a name="BKMK_DynamicPropertyOptionDescription"></a> DynamicPropertyOptionDescription

|Property|Value|
|---|---|
|Description|**Type additional information about the property option set item.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`dynamicpropertyoptiondescription`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|100|

### <a name="BKMK_DynamicPropertyOptionName"></a> DynamicPropertyOptionName

|Property|Value|
|---|---|
|Description|**Type the name of the property option set item.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`dynamicpropertyoptionname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|True|
|MaxLength|100|

### <a name="BKMK_DynamicPropertyOptionSetValueId"></a> DynamicPropertyOptionSetValueId

|Property|Value|
|---|---|
|Description|**Shows the unique identifier of the property option set item.**|
|DisplayName|**Property Option Set ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`dynamicpropertyoptionsetvalueid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_DynamicPropertyOptionSetValueSequenceNumber"></a> DynamicPropertyOptionSetValueSequenceNumber

|Property|Value|
|---|---|
|Description|**Internal Use Only**|
|DisplayName|**Internal Use Only**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`dynamicpropertyoptionsetvaluesequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_DynamicPropertyOptionValue"></a> DynamicPropertyOptionValue

|Property|Value|
|---|---|
|Description|**Shows the value of the property option set item.**|
|DisplayName|**Value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`dynamicpropertyoptionvalue`|
|RequiredLevel|SystemRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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

- [DynamicProperty_DynamicPropertyOptionSetItem](#BKMK_DynamicProperty_DynamicPropertyOptionSetItem)
- [DynamicPropertyOptionSetItem_organization](#BKMK_DynamicPropertyOptionSetItem_organization)
- [DynamicPropertyOptionSetItem_TransactionCurrency](#BKMK_DynamicPropertyOptionSetItem_TransactionCurrency)
- [lk_DynamicPropertyOptionSetItem_createdby](#BKMK_lk_DynamicPropertyOptionSetItem_createdby)
- [lk_DynamicPropertyOptionSetItem_createdonbehalfby](#BKMK_lk_DynamicPropertyOptionSetItem_createdonbehalfby)
- [lk_DynamicPropertyOptionSetItem_modifiedby](#BKMK_lk_DynamicPropertyOptionSetItem_modifiedby)
- [lk_DynamicPropertyOptionSetItem_modifiedonbehalfby](#BKMK_lk_DynamicPropertyOptionSetItem_modifiedonbehalfby)

### <a name="BKMK_DynamicProperty_DynamicPropertyOptionSetItem"></a> DynamicProperty_DynamicPropertyOptionSetItem

One-To-Many Relationship: [dynamicproperty DynamicProperty_DynamicPropertyOptionSetItem](dynamicproperty.md#BKMK_DynamicProperty_DynamicPropertyOptionSetItem)

|Property|Value|
|---|---|
|ReferencedEntity|`dynamicproperty`|
|ReferencedAttribute|`dynamicpropertyid`|
|ReferencingAttribute|`dynamicpropertyid`|
|ReferencingEntityNavigationPropertyName|`dynamicpropertyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_DynamicPropertyOptionSetItem_organization"></a> DynamicPropertyOptionSetItem_organization

One-To-Many Relationship: [organization DynamicPropertyOptionSetItem_organization](organization.md#BKMK_DynamicPropertyOptionSetItem_organization)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_DynamicPropertyOptionSetItem_TransactionCurrency"></a> DynamicPropertyOptionSetItem_TransactionCurrency

One-To-Many Relationship: [transactioncurrency DynamicPropertyOptionSetItem_TransactionCurrency](transactioncurrency.md#BKMK_DynamicPropertyOptionSetItem_TransactionCurrency)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicPropertyOptionSetItem_createdby"></a> lk_DynamicPropertyOptionSetItem_createdby

One-To-Many Relationship: [systemuser lk_DynamicPropertyOptionSetItem_createdby](systemuser.md#BKMK_lk_DynamicPropertyOptionSetItem_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicPropertyOptionSetItem_createdonbehalfby"></a> lk_DynamicPropertyOptionSetItem_createdonbehalfby

One-To-Many Relationship: [systemuser lk_DynamicPropertyOptionSetItem_createdonbehalfby](systemuser.md#BKMK_lk_DynamicPropertyOptionSetItem_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicPropertyOptionSetItem_modifiedby"></a> lk_DynamicPropertyOptionSetItem_modifiedby

One-To-Many Relationship: [systemuser lk_DynamicPropertyOptionSetItem_modifiedby](systemuser.md#BKMK_lk_DynamicPropertyOptionSetItem_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_DynamicPropertyOptionSetItem_modifiedonbehalfby"></a> lk_DynamicPropertyOptionSetItem_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_DynamicPropertyOptionSetItem_modifiedonbehalfby](systemuser.md#BKMK_lk_DynamicPropertyOptionSetItem_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [DefaultValueOptionSet_DynamicProperty](#BKMK_DefaultValueOptionSet_DynamicProperty)
- [dynamicpropertyoptionsetitem_AsyncOperations](#BKMK_dynamicpropertyoptionsetitem_AsyncOperations)
- [dynamicpropertyoptionsetitem_BulkDeleteFailures](#BKMK_dynamicpropertyoptionsetitem_BulkDeleteFailures)
- [dynamicpropertyoptionsetitem_MailboxTrackingFolders](#BKMK_dynamicpropertyoptionsetitem_MailboxTrackingFolders)
- [dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses](#BKMK_dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses)
- [dynamicpropertyoptionsetitem_SyncErrors](#BKMK_dynamicpropertyoptionsetitem_SyncErrors)

### <a name="BKMK_DefaultValueOptionSet_DynamicProperty"></a> DefaultValueOptionSet_DynamicProperty

Many-To-One Relationship: [dynamicproperty DefaultValueOptionSet_DynamicProperty](dynamicproperty.md#BKMK_DefaultValueOptionSet_DynamicProperty)

|Property|Value|
|---|---|
|ReferencingEntity|`dynamicproperty`|
|ReferencingAttribute|`defaultvalueoptionset`|
|ReferencedEntityNavigationPropertyName|`DefaultValueOptionSet_DynamicProperty`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyoptionsetitem_AsyncOperations"></a> dynamicpropertyoptionsetitem_AsyncOperations

Many-To-One Relationship: [asyncoperation dynamicpropertyoptionsetitem_AsyncOperations](asyncoperation.md#BKMK_dynamicpropertyoptionsetitem_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyoptionsetitem_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyoptionsetitem_BulkDeleteFailures"></a> dynamicpropertyoptionsetitem_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure dynamicpropertyoptionsetitem_BulkDeleteFailures](bulkdeletefailure.md#BKMK_dynamicpropertyoptionsetitem_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyoptionsetitem_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyoptionsetitem_MailboxTrackingFolders"></a> dynamicpropertyoptionsetitem_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder dynamicpropertyoptionsetitem_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_dynamicpropertyoptionsetitem_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyoptionsetitem_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses"></a> dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_dynamicpropertyoptionsetitem_SyncErrors"></a> dynamicpropertyoptionsetitem_SyncErrors

Many-To-One Relationship: [syncerror dynamicpropertyoptionsetitem_SyncErrors](syncerror.md#BKMK_dynamicpropertyoptionsetitem_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`dynamicpropertyoptionsetitem_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

