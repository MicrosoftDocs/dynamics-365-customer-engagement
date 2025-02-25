---
title: "Unit (UoM) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Unit (UoM) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Unit (UoM) table/entity reference (Microsoft Dynamics 365)

Unit of measure.

## Messages

The following table lists the messages for the Unit (UoM) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `Create`<br />Event: True |`POST` /uoms<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `Delete`<br />Event: True |`DELETE` /uoms(*uomid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `Retrieve`<br />Event: True |`GET` /uoms(*uomid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /uoms<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `Update`<br />Event: True |`PATCH` /uoms(*uomid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `Upsert`<br />Event: False |`PATCH` /uoms(*uomid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|

## Properties

The following table lists selected properties for the Unit (UoM) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Unit** |
| **DisplayCollectionName** | **Units** |
| **SchemaName** | `UoM` |
| **CollectionSchemaName** | `UoMs` |
| **EntitySetName** | `uoms`|
| **LogicalName** | `uom` |
| **LogicalCollectionName** | `uoms` |
| **PrimaryIdAttribute** | `uomid` |
| **PrimaryNameAttribute** |`name` |
| **TableType** | `Standard` |
| **OwnershipType** | `None` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BaseUoM](#BKMK_BaseUoM)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [Quantity](#BKMK_Quantity)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UoMId](#BKMK_UoMId)
- [UoMScheduleId](#BKMK_UoMScheduleId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_BaseUoM"></a> BaseUoM

|Property|Value|
|---|---|
|Description|**Choose the base or primary unit on which the unit is based.**|
|DisplayName|**Base Unit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`baseuom`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|uom|

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

### <a name="BKMK_Name"></a> Name

|Property|Value|
|---|---|
|Description|**Type a descriptive title or name for the unit of measure.**|
|DisplayName|**Name**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`name`|
|RequiredLevel|SystemRequired|
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

### <a name="BKMK_Quantity"></a> Quantity

|Property|Value|
|---|---|
|Description|**Unit quantity for the product.**|
|DisplayName|**Quantity**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`quantity`|
|RequiredLevel|ApplicationRequired|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|10000000000|
|MinValue|0|
|Precision|5|
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

### <a name="BKMK_UoMId"></a> UoMId

|Property|Value|
|---|---|
|Description|**Unique identifier of the unit.**|
|DisplayName|**Unit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`uomid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_UoMScheduleId"></a> UoMScheduleId

|Property|Value|
|---|---|
|Description|**Choose the ID of the unit group that the unit is associated with.**|
|DisplayName|**Unit Schedule**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`uomscheduleid`|
|RequiredLevel|SystemRequired|
|Type|Lookup|
|Targets|uomschedule|

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
- [CreatedByExternalParty](#BKMK_CreatedByExternalParty)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsScheduleBaseUoM](#BKMK_IsScheduleBaseUoM)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByExternalParty](#BKMK_ModifiedByExternalParty)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the unit.**|
|DisplayName|**Created By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

|Property|Value|
|---|---|
|Description|**Shows the external party who created the record.**|
|DisplayName|**Created By (External Party)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdbyexternalparty`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|externalparty|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Date and time when the unit was created.**|
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
|Description|**Unique identifier of the delegate user who created the uom.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_IsScheduleBaseUoM"></a> IsScheduleBaseUoM

|Property|Value|
|---|---|
|Description|**Tells whether the unit is the base unit for the associated unit group.**|
|DisplayName|**Is Schedule Base Unit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`isschedulebaseuom`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`uom_isschedulebaseuom`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who last modified the unit.**|
|DisplayName|**Modified By**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

|Property|Value|
|---|---|
|Description|**Shows the external party who modified the record.**|
|DisplayName|**Modified By (External Party)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedbyexternalparty`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|externalparty|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Date and time when the unit was last modified.**|
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
|Description|**Unique identifier of the delegate user who last modified the uom.**|
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
|Description|**Unique identifier of the organization associated with the unit of measure.**|
|DisplayName|**Organization**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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

- [lk_uom_createdonbehalfby](#BKMK_lk_uom_createdonbehalfby)
- [lk_uom_modifiedonbehalfby](#BKMK_lk_uom_modifiedonbehalfby)
- [lk_uombase_createdby](#BKMK_lk_uombase_createdby)
- [lk_uombase_modifiedby](#BKMK_lk_uombase_modifiedby)
- [unit_of_measure_schedule_conversions](#BKMK_unit_of_measure_schedule_conversions)
- [unit_of_measurement_base_unit](#BKMK_unit_of_measurement_base_unit-many-to-one)

### <a name="BKMK_lk_uom_createdonbehalfby"></a> lk_uom_createdonbehalfby

One-To-Many Relationship: [systemuser lk_uom_createdonbehalfby](systemuser.md#BKMK_lk_uom_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_uom_modifiedonbehalfby"></a> lk_uom_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_uom_modifiedonbehalfby](systemuser.md#BKMK_lk_uom_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_uombase_createdby"></a> lk_uombase_createdby

One-To-Many Relationship: [systemuser lk_uombase_createdby](systemuser.md#BKMK_lk_uombase_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_uombase_modifiedby"></a> lk_uombase_modifiedby

One-To-Many Relationship: [systemuser lk_uombase_modifiedby](systemuser.md#BKMK_lk_uombase_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_unit_of_measure_schedule_conversions"></a> unit_of_measure_schedule_conversions

One-To-Many Relationship: [uomschedule unit_of_measure_schedule_conversions](uomschedule.md#BKMK_unit_of_measure_schedule_conversions)

|Property|Value|
|---|---|
|ReferencedEntity|`uomschedule`|
|ReferencedAttribute|`uomscheduleid`|
|ReferencingAttribute|`uomscheduleid`|
|ReferencingEntityNavigationPropertyName|`uomscheduleid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_unit_of_measurement_base_unit-many-to-one"></a> unit_of_measurement_base_unit

One-To-Many Relationship: [uom unit_of_measurement_base_unit](#BKMK_unit_of_measurement_base_unit-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`baseuom`|
|ReferencingEntityNavigationPropertyName|`baseuom`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [unit_of_measurement_base_unit](#BKMK_unit_of_measurement_base_unit-one-to-many)
- [unit_of_measurement_contract_line_items](#BKMK_unit_of_measurement_contract_line_items)
- [unit_of_measurement_invoice_details](#BKMK_unit_of_measurement_invoice_details)
- [unit_of_measurement_opportunity_products](#BKMK_unit_of_measurement_opportunity_products)
- [unit_of_measurement_order_details](#BKMK_unit_of_measurement_order_details)
- [unit_of_measurement_product_price_levels](#BKMK_unit_of_measurement_product_price_levels)
- [unit_of_measurement_productassociation](#BKMK_unit_of_measurement_productassociation)
- [unit_of_measurement_products](#BKMK_unit_of_measurement_products)
- [unit_of_measurement_quote_details](#BKMK_unit_of_measurement_quote_details)
- [UoM_AsyncOperations](#BKMK_UoM_AsyncOperations)
- [UoM_BulkDeleteFailures](#BKMK_UoM_BulkDeleteFailures)
- [uom_MailboxTrackingFolders](#BKMK_uom_MailboxTrackingFolders)
- [uom_PrincipalObjectAttributeAccesses](#BKMK_uom_PrincipalObjectAttributeAccesses)
- [UoM_SyncErrors](#BKMK_UoM_SyncErrors)

### <a name="BKMK_unit_of_measurement_base_unit-one-to-many"></a> unit_of_measurement_base_unit

Many-To-One Relationship: [uom unit_of_measurement_base_unit](#BKMK_unit_of_measurement_base_unit-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`uom`|
|ReferencingAttribute|`baseuom`|
|ReferencedEntityNavigationPropertyName|`unit_of_measurement_base_unit`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_unit_of_measurement_contract_line_items"></a> unit_of_measurement_contract_line_items

Many-To-One Relationship: [contractdetail unit_of_measurement_contract_line_items](contractdetail.md#BKMK_unit_of_measurement_contract_line_items)

|Property|Value|
|---|---|
|ReferencingEntity|`contractdetail`|
|ReferencingAttribute|`uomid`|
|ReferencedEntityNavigationPropertyName|`unit_of_measurement_contract_line_items`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_unit_of_measurement_invoice_details"></a> unit_of_measurement_invoice_details

Many-To-One Relationship: [invoicedetail unit_of_measurement_invoice_details](invoicedetail.md#BKMK_unit_of_measurement_invoice_details)

|Property|Value|
|---|---|
|ReferencingEntity|`invoicedetail`|
|ReferencingAttribute|`uomid`|
|ReferencedEntityNavigationPropertyName|`unit_of_measurement_invoice_details`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_unit_of_measurement_opportunity_products"></a> unit_of_measurement_opportunity_products

Many-To-One Relationship: [opportunityproduct unit_of_measurement_opportunity_products](opportunityproduct.md#BKMK_unit_of_measurement_opportunity_products)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityproduct`|
|ReferencingAttribute|`uomid`|
|ReferencedEntityNavigationPropertyName|`unit_of_measurement_opportunity_products`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_unit_of_measurement_order_details"></a> unit_of_measurement_order_details

Many-To-One Relationship: [salesorderdetail unit_of_measurement_order_details](salesorderdetail.md#BKMK_unit_of_measurement_order_details)

|Property|Value|
|---|---|
|ReferencingEntity|`salesorderdetail`|
|ReferencingAttribute|`uomid`|
|ReferencedEntityNavigationPropertyName|`unit_of_measurement_order_details`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_unit_of_measurement_product_price_levels"></a> unit_of_measurement_product_price_levels

Many-To-One Relationship: [productpricelevel unit_of_measurement_product_price_levels](productpricelevel.md#BKMK_unit_of_measurement_product_price_levels)

|Property|Value|
|---|---|
|ReferencingEntity|`productpricelevel`|
|ReferencingAttribute|`uomid`|
|ReferencedEntityNavigationPropertyName|`unit_of_measurement_product_price_levels`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_unit_of_measurement_productassociation"></a> unit_of_measurement_productassociation

Many-To-One Relationship: [productassociation unit_of_measurement_productassociation](productassociation.md#BKMK_unit_of_measurement_productassociation)

|Property|Value|
|---|---|
|ReferencingEntity|`productassociation`|
|ReferencingAttribute|`uomid`|
|ReferencedEntityNavigationPropertyName|`unit_of_measurement_productassociation`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_unit_of_measurement_products"></a> unit_of_measurement_products

Many-To-One Relationship: [product unit_of_measurement_products](product.md#BKMK_unit_of_measurement_products)

|Property|Value|
|---|---|
|ReferencingEntity|`product`|
|ReferencingAttribute|`defaultuomid`|
|ReferencedEntityNavigationPropertyName|`unit_of_measurement_products`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_unit_of_measurement_quote_details"></a> unit_of_measurement_quote_details

Many-To-One Relationship: [quotedetail unit_of_measurement_quote_details](quotedetail.md#BKMK_unit_of_measurement_quote_details)

|Property|Value|
|---|---|
|ReferencingEntity|`quotedetail`|
|ReferencingAttribute|`uomid`|
|ReferencedEntityNavigationPropertyName|`unit_of_measurement_quote_details`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_UoM_AsyncOperations"></a> UoM_AsyncOperations

Many-To-One Relationship: [asyncoperation UoM_AsyncOperations](asyncoperation.md#BKMK_UoM_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`UoM_AsyncOperations`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_UoM_BulkDeleteFailures"></a> UoM_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure UoM_BulkDeleteFailures](bulkdeletefailure.md#BKMK_UoM_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`UoM_BulkDeleteFailures`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_uom_MailboxTrackingFolders"></a> uom_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder uom_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_uom_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`uom_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_uom_PrincipalObjectAttributeAccesses"></a> uom_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess uom_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_uom_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`uom_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_UoM_SyncErrors"></a> UoM_SyncErrors

Many-To-One Relationship: [syncerror UoM_SyncErrors](syncerror.md#BKMK_UoM_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`UoM_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

