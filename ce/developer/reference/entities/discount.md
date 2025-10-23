---
title: "Discount table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Discount table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Discount table/entity reference (Microsoft Dynamics 365)

Price reduction made from the list price of a product or service based on the quantity purchased.

## Messages

The following table lists the messages for the Discount table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /discounts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /discounts(*discountid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /discounts(*discountid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /discounts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /discounts(*discountid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /discounts(*discountid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|

## Properties

The following table lists selected properties for the Discount table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Discount** |
| **DisplayCollectionName** | **Discounts** |
| **SchemaName** | `Discount` |
| **CollectionSchemaName** | `Discounts` |
| **EntitySetName** | `discounts`|
| **LogicalName** | `discount` |
| **LogicalCollectionName** | `discounts` |
| **PrimaryIdAttribute** | `discountid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [Amount](#BKMK_Amount)
- [DiscountId](#BKMK_DiscountId)
- [DiscountTypeId](#BKMK_DiscountTypeId)
- [HighQuantity](#BKMK_HighQuantity)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [LowQuantity](#BKMK_LowQuantity)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [Percentage](#BKMK_Percentage)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_Amount"></a> Amount

|Property|Value|
|---|---|
|Description|**Amount of the discount, specified either as a percentage or as a monetary amount.**|
|DisplayName|**Amount**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`amount`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000000|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_DiscountId"></a> DiscountId

|Property|Value|
|---|---|
|Description|**Unique identifier of the discount.**|
|DisplayName|**Discount**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`discountid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_DiscountTypeId"></a> DiscountTypeId

|Property|Value|
|---|---|
|Description|**Unique identifier of the discount list associated with the discount.**|
|DisplayName|**Discount Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`discounttypeid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|discounttype|

### <a name="BKMK_HighQuantity"></a> HighQuantity

|Property|Value|
|---|---|
|Description|**Upper boundary for the quantity range to which a particular discount can be applied.**|
|DisplayName|**End Quantity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`highquantity`|
|RequiredLevel|SystemRequired|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-05|
|Precision|5|
|SourceTypeMask|0|

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

### <a name="BKMK_LowQuantity"></a> LowQuantity

|Property|Value|
|---|---|
|Description|**Lower boundary for the quantity range to which a particular discount is applied.**|
|DisplayName|**Begin Quantity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`lowquantity`|
|RequiredLevel|SystemRequired|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-05|
|Precision|5|
|SourceTypeMask|0|

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**name**|
|DisplayName|**name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|ApplicationRequired|
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

### <a name="BKMK_Percentage"></a> Percentage

|Property|Value|
|---|---|
|Description|**Percentage discount value.**|
|DisplayName|**Percentage**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`percentage`|
|RequiredLevel|ApplicationRequired|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|5|
|SourceTypeMask|0|

### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|---|---|
|Description|**Select the discount's status.**|
|DisplayName|**Status Reason**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue|-1|
|GlobalChoiceName|`discount_statuscode`|

#### StatusCode Choices/Options

|Value|Details|
|---|---|

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

- [Amount_Base](#BKMK_Amount_Base)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ExchangeRate](#BKMK_ExchangeRate)
- [IsAmountType](#BKMK_IsAmountType)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_Amount_Base"></a> Amount_Base

|Property|Value|
|---|---|
|Description|**Value of the Amount in base currency.**|
|DisplayName|**Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`amount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the discount.**|
|DisplayName|**Created By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the discount was created.**|
|DisplayName|**Created On**|
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who created the discount.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|False|
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

### <a name="BKMK_IsAmountType"></a> IsAmountType

|Property|Value|
|---|---|
|Description|**Specifies whether the discount is specified as a monetary amount or a percentage.**|
|DisplayName|**Amount Type**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isamounttype`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`discount_isamounttype`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who last modified the discount.**|
|DisplayName|**Modified By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the discount was last modified.**|
|DisplayName|**Modified On**|
|IsValidForForm|False|
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
|Description|**Unique identifier of the delegate user who last modified the discount.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier of the organization associated with the discount.**|
|DisplayName|**Organization**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Choose the local currency for the record to make sure budgets are reported in the correct currency.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

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

- [discount_type_discounts](#BKMK_discount_type_discounts)
- [lk_discount_createdonbehalfby](#BKMK_lk_discount_createdonbehalfby)
- [lk_discount_modifiedonbehalfby](#BKMK_lk_discount_modifiedonbehalfby)
- [lk_discountbase_createdby](#BKMK_lk_discountbase_createdby)
- [lk_discountbase_modifiedby](#BKMK_lk_discountbase_modifiedby)
- [transactioncurrency_discount](#BKMK_transactioncurrency_discount)

### <a name="BKMK_discount_type_discounts"></a> discount_type_discounts

One-To-Many Relationship: [discounttype discount_type_discounts](discounttype.md#BKMK_discount_type_discounts)

|Property|Value|
|---|---|
|ReferencedEntity|`discounttype`|
|ReferencedAttribute|`discounttypeid`|
|ReferencingAttribute|`discounttypeid`|
|ReferencingEntityNavigationPropertyName|`discounttypeid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_discount_createdonbehalfby"></a> lk_discount_createdonbehalfby

One-To-Many Relationship: [systemuser lk_discount_createdonbehalfby](systemuser.md#BKMK_lk_discount_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_discount_modifiedonbehalfby"></a> lk_discount_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_discount_modifiedonbehalfby](systemuser.md#BKMK_lk_discount_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_discountbase_createdby"></a> lk_discountbase_createdby

One-To-Many Relationship: [systemuser lk_discountbase_createdby](systemuser.md#BKMK_lk_discountbase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_discountbase_modifiedby"></a> lk_discountbase_modifiedby

One-To-Many Relationship: [systemuser lk_discountbase_modifiedby](systemuser.md#BKMK_lk_discountbase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_transactioncurrency_discount"></a> transactioncurrency_discount

One-To-Many Relationship: [transactioncurrency transactioncurrency_discount](transactioncurrency.md#BKMK_transactioncurrency_discount)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [Discount_AsyncOperations](#BKMK_Discount_AsyncOperations)
- [Discount_BulkDeleteFailures](#BKMK_Discount_BulkDeleteFailures)
- [discount_MailboxTrackingFolders](#BKMK_discount_MailboxTrackingFolders)
- [discount_PrincipalObjectAttributeAccesses](#BKMK_discount_PrincipalObjectAttributeAccesses)
- [Discount_ProcessSessions](#BKMK_Discount_ProcessSessions)
- [Discount_SyncErrors](#BKMK_Discount_SyncErrors)

### <a name="BKMK_Discount_AsyncOperations"></a> Discount_AsyncOperations

Many-To-One Relationship: [asyncoperation Discount_AsyncOperations](asyncoperation.md#BKMK_Discount_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Discount_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Discount_BulkDeleteFailures"></a> Discount_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure Discount_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Discount_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Discount_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_discount_MailboxTrackingFolders"></a> discount_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder discount_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_discount_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`discount_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_discount_PrincipalObjectAttributeAccesses"></a> discount_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess discount_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_discount_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`discount_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Discount_ProcessSessions"></a> Discount_ProcessSessions

Many-To-One Relationship: [processsession Discount_ProcessSessions](processsession.md#BKMK_Discount_ProcessSessions)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Discount_ProcessSessions`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 110<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_Discount_SyncErrors"></a> Discount_SyncErrors

Many-To-One Relationship: [syncerror Discount_SyncErrors](syncerror.md#BKMK_Discount_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`Discount_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

