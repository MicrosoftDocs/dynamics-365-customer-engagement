---
title: "UoM Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the UoM entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# UoM Entity Reference

Unit of measure.

**Added by**: Product Management Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/uoms<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/uoms(*uomid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/uoms(*uomid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/uoms<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/uoms(*uomid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Unit<br />
**DisplayCollectionName**: Units<br />
**SchemaName**: UoM<br />
**CollectionSchemaName**: UoMs<br />
**LogicalName**: uom<br />
**LogicalCollectionName**: uoms<br />
**EntitySetName**: uoms<br />
**PrimaryIdAttribute**: uomid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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

**Description**: Choose the base or primary unit on which the unit is based.<br />
**DisplayName**: Base Unit<br />
**LogicalName**: baseuom<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

**Description**: Sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_Name"></a> Name

**Description**: Type a descriptive title or name for the unit of measure.<br />
**DisplayName**: Name<br />
**LogicalName**: name<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_Quantity"></a> Quantity

**Description**: Unit quantity for the product.<br />
**DisplayName**: Quantity<br />
**LogicalName**: quantity<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Decimal<br />
**MaxValue**: 10000000000<br />
**MinValue**: 0<br />
**Precision**: 5


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_UoMId"></a> UoMId

**Description**: Unique identifier of the unit.<br />
**DisplayName**: Unit<br />
**LogicalName**: uomid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_UoMScheduleId"></a> UoMScheduleId

**Description**: Choose the ID of the unit group that the unit is associated with.<br />
**DisplayName**: Unit Schedule<br />
**LogicalName**: uomscheduleid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: uomschedule


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [BaseUoMName](#BKMK_BaseUoMName)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByExternalParty](#BKMK_CreatedByExternalParty)
- [CreatedByExternalPartyName](#BKMK_CreatedByExternalPartyName)
- [CreatedByExternalPartyYomiName](#BKMK_CreatedByExternalPartyYomiName)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [IsScheduleBaseUoM](#BKMK_IsScheduleBaseUoM)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByExternalParty](#BKMK_ModifiedByExternalParty)
- [ModifiedByExternalPartyName](#BKMK_ModifiedByExternalPartyName)
- [ModifiedByExternalPartyYomiName](#BKMK_ModifiedByExternalPartyYomiName)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [UoMScheduleIdName](#BKMK_UoMScheduleIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_BaseUoMName"></a> BaseUoMName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: baseuomname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the unit.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

**Description**: Shows the external party who created the record.<br />
**DisplayName**: Created By (External Party)<br />
**LogicalName**: createdbyexternalparty<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: externalparty


### <a name="BKMK_CreatedByExternalPartyName"></a> CreatedByExternalPartyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyexternalpartyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByExternalPartyYomiName"></a> CreatedByExternalPartyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyexternalpartyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the unit was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the uom.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_IsScheduleBaseUoM"></a> IsScheduleBaseUoM

**Description**: Tells whether the unit is the base unit for the associated unit group.<br />
**DisplayName**: Is Schedule Base Unit<br />
**LogicalName**: isschedulebaseuom<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who last modified the unit.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

**Description**: Shows the external party who modified the record.<br />
**DisplayName**: Modified By (External Party)<br />
**LogicalName**: modifiedbyexternalparty<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: externalparty


### <a name="BKMK_ModifiedByExternalPartyName"></a> ModifiedByExternalPartyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyexternalpartyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByExternalPartyYomiName"></a> ModifiedByExternalPartyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyexternalpartyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the unit was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who last modified the uom.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier of the organization associated with the unit of measure.<br />
**DisplayName**: Organization <br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_UoMScheduleIdName"></a> UoMScheduleIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: uomscheduleidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [UoM_SyncErrors](#BKMK_UoM_SyncErrors)
- [UoM_AsyncOperations](#BKMK_UoM_AsyncOperations)
- [uom_MailboxTrackingFolders](#BKMK_uom_MailboxTrackingFolders)
- [userentityinstancedata_uom](#BKMK_userentityinstancedata_uom)
- [UoM_BulkDeleteFailures](#BKMK_UoM_BulkDeleteFailures)
- [uom_PrincipalObjectAttributeAccesses](#BKMK_uom_PrincipalObjectAttributeAccesses)
- [unit_of_measurement_base_unit](#BKMK_unit_of_measurement_base_unit)
- [unit_of_measurement_products](#BKMK_unit_of_measurement_products)
- [unit_of_measurement_productassociation](#BKMK_unit_of_measurement_productassociation)
- [unit_of_measurement_product_price_levels](#BKMK_unit_of_measurement_product_price_levels)
- [unit_of_measurement_contract_line_items](#BKMK_unit_of_measurement_contract_line_items)
- [unit_of_measurement_invoice_details](#BKMK_unit_of_measurement_invoice_details)
- [unit_of_measurement_opportunity_products](#BKMK_unit_of_measurement_opportunity_products)
- [unit_of_measurement_order_details](#BKMK_unit_of_measurement_order_details)
- [unit_of_measurement_quote_details](#BKMK_unit_of_measurement_quote_details)
- [msdyn_uom_msdyn_actual_Unit](#BKMK_msdyn_uom_msdyn_actual_Unit)
- [msdyn_uom_msdyn_estimateline_Unit](#BKMK_msdyn_uom_msdyn_estimateline_Unit)
- [msdyn_uom_msdyn_invoicelinetransaction_Unit](#BKMK_msdyn_uom_msdyn_invoicelinetransaction_Unit)
- [msdyn_uom_msdyn_journalline_Unit](#BKMK_msdyn_uom_msdyn_journalline_Unit)
- [msdyn_uom_msdyn_opportunitylinetransaction_Unit](#BKMK_msdyn_uom_msdyn_opportunitylinetransaction_Unit)
- [msdyn_uom_msdyn_orderlinetransaction_Unit](#BKMK_msdyn_uom_msdyn_orderlinetransaction_Unit)
- [msdyn_uom_msdyn_quotelinetransaction_Unit](#BKMK_msdyn_uom_msdyn_quotelinetransaction_Unit)
- [msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit](#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit)
- [msdyn_uom_msdyn_resourcecategorypricelevel_Unit](#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_Unit)
- [msdyn_uom_msdyn_transactioncategory_DefaultUnit](#BKMK_msdyn_uom_msdyn_transactioncategory_DefaultUnit)
- [msdyn_uom_msdyn_transactioncategorypricelevel_Unit](#BKMK_msdyn_uom_msdyn_transactioncategorypricelevel_Unit)
- [msdyn_uom_msdyn_transactiontype_DefaultUnit](#BKMK_msdyn_uom_msdyn_transactiontype_DefaultUnit)
- [msdyn_uom_pricelevel_TimeUnit](#BKMK_msdyn_uom_pricelevel_TimeUnit)
- [msdyn_uom_msdyn_agreementbookingproduct_Unit](#BKMK_msdyn_uom_msdyn_agreementbookingproduct_Unit)
- [msdyn_uom_msdyn_agreementbookingservice_Unit](#BKMK_msdyn_uom_msdyn_agreementbookingservice_Unit)
- [msdyn_uom_msdyn_agreementinvoiceproduct_Unit](#BKMK_msdyn_uom_msdyn_agreementinvoiceproduct_Unit)
- [msdyn_uom_msdyn_incidenttypeproduct_Unit](#BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit)
- [msdyn_uom_msdyn_incidenttypeservice_Unit](#BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit)
- [msdyn_uom_msdyn_inventoryadjustmentproduct_Unit](#BKMK_msdyn_uom_msdyn_inventoryadjustmentproduct_Unit)
- [msdyn_uom_msdyn_inventoryjournal_Unit](#BKMK_msdyn_uom_msdyn_inventoryjournal_Unit)
- [msdyn_uom_msdyn_orderinvoicingproduct_Unit](#BKMK_msdyn_uom_msdyn_orderinvoicingproduct_Unit)
- [msdyn_uom_msdyn_productinventory_Unit](#BKMK_msdyn_uom_msdyn_productinventory_Unit)
- [msdyn_uom_msdyn_purchaseorderproduct_Unit](#BKMK_msdyn_uom_msdyn_purchaseorderproduct_Unit)
- [msdyn_uom_msdyn_quotebookingproduct_Unit](#BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit)
- [msdyn_uom_msdyn_quotebookingservice_Unit](#BKMK_msdyn_uom_msdyn_quotebookingservice_Unit)
- [msdyn_uom_msdyn_quoteinvoicingproduct_Unit](#BKMK_msdyn_uom_msdyn_quoteinvoicingproduct_Unit)
- [msdyn_uom_msdyn_rmaproduct_Unit](#BKMK_msdyn_uom_msdyn_rmaproduct_Unit)
- [msdyn_uom_msdyn_rtvproduct_Unit](#BKMK_msdyn_uom_msdyn_rtvproduct_Unit)
- [msdyn_uom_msdyn_workorderproduct_Unit](#BKMK_msdyn_uom_msdyn_workorderproduct_Unit)
- [msdyn_uom_msdyn_workorderservice_Unit](#BKMK_msdyn_uom_msdyn_workorderservice_Unit)


### <a name="BKMK_UoM_SyncErrors"></a> UoM_SyncErrors

Same as syncerror entity [UoM_SyncErrors](syncerror.md#BKMK_UoM_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: UoM_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: Cascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_UoM_AsyncOperations"></a> UoM_AsyncOperations

Same as asyncoperation entity [UoM_AsyncOperations](asyncoperation.md#BKMK_UoM_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: UoM_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_uom_MailboxTrackingFolders"></a> uom_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [uom_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_uom_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: uom_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_userentityinstancedata_uom"></a> userentityinstancedata_uom

Same as userentityinstancedata entity [userentityinstancedata_uom](userentityinstancedata.md#BKMK_userentityinstancedata_uom) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_uom<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_UoM_BulkDeleteFailures"></a> UoM_BulkDeleteFailures

Same as bulkdeletefailure entity [UoM_BulkDeleteFailures](bulkdeletefailure.md#BKMK_UoM_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: UoM_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_uom_PrincipalObjectAttributeAccesses"></a> uom_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [uom_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_uom_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: uom_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_unit_of_measurement_base_unit"></a> unit_of_measurement_base_unit

Same as uom entity [unit_of_measurement_base_unit](uom.md#BKMK_unit_of_measurement_base_unit) Many-To-One relationship.

**ReferencingEntity**: uom<br />
**ReferencingAttribute**: baseuom<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measurement_base_unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_unit_of_measurement_products"></a> unit_of_measurement_products

Same as product entity [unit_of_measurement_products](product.md#BKMK_unit_of_measurement_products) Many-To-One relationship.

**ReferencingEntity**: product<br />
**ReferencingAttribute**: defaultuomid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measurement_products<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_unit_of_measurement_productassociation"></a> unit_of_measurement_productassociation

Same as productassociation entity [unit_of_measurement_productassociation](productassociation.md#BKMK_unit_of_measurement_productassociation) Many-To-One relationship.

**ReferencingEntity**: productassociation<br />
**ReferencingAttribute**: uomid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measurement_productassociation<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_unit_of_measurement_product_price_levels"></a> unit_of_measurement_product_price_levels

Same as productpricelevel entity [unit_of_measurement_product_price_levels](productpricelevel.md#BKMK_unit_of_measurement_product_price_levels) Many-To-One relationship.

**ReferencingEntity**: productpricelevel<br />
**ReferencingAttribute**: uomid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measurement_product_price_levels<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_unit_of_measurement_contract_line_items"></a> unit_of_measurement_contract_line_items

Same as contractdetail entity [unit_of_measurement_contract_line_items](contractdetail.md#BKMK_unit_of_measurement_contract_line_items) Many-To-One relationship.

**ReferencingEntity**: contractdetail<br />
**ReferencingAttribute**: uomid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measurement_contract_line_items<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_unit_of_measurement_invoice_details"></a> unit_of_measurement_invoice_details

Same as invoicedetail entity [unit_of_measurement_invoice_details](invoicedetail.md#BKMK_unit_of_measurement_invoice_details) Many-To-One relationship.

**ReferencingEntity**: invoicedetail<br />
**ReferencingAttribute**: uomid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measurement_invoice_details<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_unit_of_measurement_opportunity_products"></a> unit_of_measurement_opportunity_products

Same as opportunityproduct entity [unit_of_measurement_opportunity_products](opportunityproduct.md#BKMK_unit_of_measurement_opportunity_products) Many-To-One relationship.

**ReferencingEntity**: opportunityproduct<br />
**ReferencingAttribute**: uomid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measurement_opportunity_products<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_unit_of_measurement_order_details"></a> unit_of_measurement_order_details

Same as salesorderdetail entity [unit_of_measurement_order_details](salesorderdetail.md#BKMK_unit_of_measurement_order_details) Many-To-One relationship.

**ReferencingEntity**: salesorderdetail<br />
**ReferencingAttribute**: uomid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measurement_order_details<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_unit_of_measurement_quote_details"></a> unit_of_measurement_quote_details

Same as quotedetail entity [unit_of_measurement_quote_details](quotedetail.md#BKMK_unit_of_measurement_quote_details) Many-To-One relationship.

**ReferencingEntity**: quotedetail<br />
**ReferencingAttribute**: uomid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: unit_of_measurement_quote_details<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_actual_Unit"></a> msdyn_uom_msdyn_actual_Unit

Same as msdyn_actual entity [msdyn_uom_msdyn_actual_Unit](msdyn_actual.md#BKMK_msdyn_uom_msdyn_actual_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_actual_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_estimateline_Unit"></a> msdyn_uom_msdyn_estimateline_Unit

Same as msdyn_estimateline entity [msdyn_uom_msdyn_estimateline_Unit](msdyn_estimateline.md#BKMK_msdyn_uom_msdyn_estimateline_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_estimateline_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_invoicelinetransaction_Unit"></a> msdyn_uom_msdyn_invoicelinetransaction_Unit

Same as msdyn_invoicelinetransaction entity [msdyn_uom_msdyn_invoicelinetransaction_Unit](msdyn_invoicelinetransaction.md#BKMK_msdyn_uom_msdyn_invoicelinetransaction_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_invoicelinetransaction_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_journalline_Unit"></a> msdyn_uom_msdyn_journalline_Unit

Same as msdyn_journalline entity [msdyn_uom_msdyn_journalline_Unit](msdyn_journalline.md#BKMK_msdyn_uom_msdyn_journalline_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_journalline_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_opportunitylinetransaction_Unit"></a> msdyn_uom_msdyn_opportunitylinetransaction_Unit

Same as msdyn_opportunitylinetransaction entity [msdyn_uom_msdyn_opportunitylinetransaction_Unit](msdyn_opportunitylinetransaction.md#BKMK_msdyn_uom_msdyn_opportunitylinetransaction_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_opportunitylinetransaction_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_orderlinetransaction_Unit"></a> msdyn_uom_msdyn_orderlinetransaction_Unit

Same as msdyn_orderlinetransaction entity [msdyn_uom_msdyn_orderlinetransaction_Unit](msdyn_orderlinetransaction.md#BKMK_msdyn_uom_msdyn_orderlinetransaction_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_orderlinetransaction_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_quotelinetransaction_Unit"></a> msdyn_uom_msdyn_quotelinetransaction_Unit

Same as msdyn_quotelinetransaction entity [msdyn_uom_msdyn_quotelinetransaction_Unit](msdyn_quotelinetransaction.md#BKMK_msdyn_uom_msdyn_quotelinetransaction_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_quotelinetransaction_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit"></a> msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit

Same as msdyn_resourcecategorypricelevel entity [msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcecategorypricelevel<br />
**ReferencingAttribute**: msdyn_primaryunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_Unit"></a> msdyn_uom_msdyn_resourcecategorypricelevel_Unit

Same as msdyn_resourcecategorypricelevel entity [msdyn_uom_msdyn_resourcecategorypricelevel_Unit](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_resourcecategorypricelevel<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_resourcecategorypricelevel_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_transactioncategory_DefaultUnit"></a> msdyn_uom_msdyn_transactioncategory_DefaultUnit

Same as msdyn_transactioncategory entity [msdyn_uom_msdyn_transactioncategory_DefaultUnit](msdyn_transactioncategory.md#BKMK_msdyn_uom_msdyn_transactioncategory_DefaultUnit) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactioncategory<br />
**ReferencingAttribute**: msdyn_defaultunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_transactioncategory_DefaultUnit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_transactioncategorypricelevel_Unit"></a> msdyn_uom_msdyn_transactioncategorypricelevel_Unit

Same as msdyn_transactioncategorypricelevel entity [msdyn_uom_msdyn_transactioncategorypricelevel_Unit](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_uom_msdyn_transactioncategorypricelevel_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactioncategorypricelevel<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_transactioncategorypricelevel_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_transactiontype_DefaultUnit"></a> msdyn_uom_msdyn_transactiontype_DefaultUnit

Same as msdyn_transactiontype entity [msdyn_uom_msdyn_transactiontype_DefaultUnit](msdyn_transactiontype.md#BKMK_msdyn_uom_msdyn_transactiontype_DefaultUnit) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactiontype<br />
**ReferencingAttribute**: msdyn_defaultunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_transactiontype_DefaultUnit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_pricelevel_TimeUnit"></a> msdyn_uom_pricelevel_TimeUnit

Same as pricelevel entity [msdyn_uom_pricelevel_TimeUnit](pricelevel.md#BKMK_msdyn_uom_pricelevel_TimeUnit) Many-To-One relationship.

**ReferencingEntity**: pricelevel<br />
**ReferencingAttribute**: msdyn_timeunit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_pricelevel_TimeUnit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_agreementbookingproduct_Unit"></a> msdyn_uom_msdyn_agreementbookingproduct_Unit

Same as msdyn_agreementbookingproduct entity [msdyn_uom_msdyn_agreementbookingproduct_Unit](msdyn_agreementbookingproduct.md#BKMK_msdyn_uom_msdyn_agreementbookingproduct_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingproduct<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_agreementbookingproduct_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_agreementbookingservice_Unit"></a> msdyn_uom_msdyn_agreementbookingservice_Unit

Same as msdyn_agreementbookingservice entity [msdyn_uom_msdyn_agreementbookingservice_Unit](msdyn_agreementbookingservice.md#BKMK_msdyn_uom_msdyn_agreementbookingservice_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementbookingservice<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_agreementbookingservice_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_agreementinvoiceproduct_Unit"></a> msdyn_uom_msdyn_agreementinvoiceproduct_Unit

Same as msdyn_agreementinvoiceproduct entity [msdyn_uom_msdyn_agreementinvoiceproduct_Unit](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_uom_msdyn_agreementinvoiceproduct_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_agreementinvoiceproduct<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_agreementinvoiceproduct_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit"></a> msdyn_uom_msdyn_incidenttypeproduct_Unit

Same as msdyn_incidenttypeproduct entity [msdyn_uom_msdyn_incidenttypeproduct_Unit](msdyn_incidenttypeproduct.md#BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeproduct<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_incidenttypeproduct_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit"></a> msdyn_uom_msdyn_incidenttypeservice_Unit

Same as msdyn_incidenttypeservice entity [msdyn_uom_msdyn_incidenttypeservice_Unit](msdyn_incidenttypeservice.md#BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_incidenttypeservice<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_incidenttypeservice_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Restrict
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_inventoryadjustmentproduct_Unit"></a> msdyn_uom_msdyn_inventoryadjustmentproduct_Unit

Same as msdyn_inventoryadjustmentproduct entity [msdyn_uom_msdyn_inventoryadjustmentproduct_Unit](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_uom_msdyn_inventoryadjustmentproduct_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryadjustmentproduct<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_inventoryadjustmentproduct_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_inventoryjournal_Unit"></a> msdyn_uom_msdyn_inventoryjournal_Unit

Same as msdyn_inventoryjournal entity [msdyn_uom_msdyn_inventoryjournal_Unit](msdyn_inventoryjournal.md#BKMK_msdyn_uom_msdyn_inventoryjournal_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_inventoryjournal<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_inventoryjournal_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_orderinvoicingproduct_Unit"></a> msdyn_uom_msdyn_orderinvoicingproduct_Unit

Same as msdyn_orderinvoicingproduct entity [msdyn_uom_msdyn_orderinvoicingproduct_Unit](msdyn_orderinvoicingproduct.md#BKMK_msdyn_uom_msdyn_orderinvoicingproduct_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderinvoicingproduct<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_orderinvoicingproduct_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_productinventory_Unit"></a> msdyn_uom_msdyn_productinventory_Unit

Same as msdyn_productinventory entity [msdyn_uom_msdyn_productinventory_Unit](msdyn_productinventory.md#BKMK_msdyn_uom_msdyn_productinventory_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_productinventory<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_productinventory_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_purchaseorderproduct_Unit"></a> msdyn_uom_msdyn_purchaseorderproduct_Unit

Same as msdyn_purchaseorderproduct entity [msdyn_uom_msdyn_purchaseorderproduct_Unit](msdyn_purchaseorderproduct.md#BKMK_msdyn_uom_msdyn_purchaseorderproduct_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_purchaseorderproduct<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_purchaseorderproduct_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit"></a> msdyn_uom_msdyn_quotebookingproduct_Unit

Same as msdyn_quotebookingproduct entity [msdyn_uom_msdyn_quotebookingproduct_Unit](msdyn_quotebookingproduct.md#BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingproduct<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_quotebookingproduct_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_quotebookingservice_Unit"></a> msdyn_uom_msdyn_quotebookingservice_Unit

Same as msdyn_quotebookingservice entity [msdyn_uom_msdyn_quotebookingservice_Unit](msdyn_quotebookingservice.md#BKMK_msdyn_uom_msdyn_quotebookingservice_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotebookingservice<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_quotebookingservice_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_quoteinvoicingproduct_Unit"></a> msdyn_uom_msdyn_quoteinvoicingproduct_Unit

Same as msdyn_quoteinvoicingproduct entity [msdyn_uom_msdyn_quoteinvoicingproduct_Unit](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_uom_msdyn_quoteinvoicingproduct_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_quoteinvoicingproduct<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_quoteinvoicingproduct_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_rmaproduct_Unit"></a> msdyn_uom_msdyn_rmaproduct_Unit

Same as msdyn_rmaproduct entity [msdyn_uom_msdyn_rmaproduct_Unit](msdyn_rmaproduct.md#BKMK_msdyn_uom_msdyn_rmaproduct_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_rmaproduct<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_rmaproduct_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_rtvproduct_Unit"></a> msdyn_uom_msdyn_rtvproduct_Unit

Same as msdyn_rtvproduct entity [msdyn_uom_msdyn_rtvproduct_Unit](msdyn_rtvproduct.md#BKMK_msdyn_uom_msdyn_rtvproduct_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_rtvproduct<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_rtvproduct_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_workorderproduct_Unit"></a> msdyn_uom_msdyn_workorderproduct_Unit

Same as msdyn_workorderproduct entity [msdyn_uom_msdyn_workorderproduct_Unit](msdyn_workorderproduct.md#BKMK_msdyn_uom_msdyn_workorderproduct_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderproduct<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_workorderproduct_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_uom_msdyn_workorderservice_Unit"></a> msdyn_uom_msdyn_workorderservice_Unit

Same as msdyn_workorderservice entity [msdyn_uom_msdyn_workorderservice_Unit](msdyn_workorderservice.md#BKMK_msdyn_uom_msdyn_workorderservice_Unit) Many-To-One relationship.

**ReferencingEntity**: msdyn_workorderservice<br />
**ReferencingAttribute**: msdyn_unit<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_uom_msdyn_workorderservice_Unit<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_uombase_createdby](#BKMK_lk_uombase_createdby)
- [lk_uom_createdonbehalfby](#BKMK_lk_uom_createdonbehalfby)
- [lk_uombase_modifiedby](#BKMK_lk_uombase_modifiedby)
- [lk_uom_modifiedonbehalfby](#BKMK_lk_uom_modifiedonbehalfby)
- [lk_externalparty_uom_createdby](#BKMK_lk_externalparty_uom_createdby)
- [lk_externalparty_uom_modifiedby](#BKMK_lk_externalparty_uom_modifiedby)
- [unit_of_measurement_base_unit](#BKMK_unit_of_measurement_base_unit)
- [unit_of_measure_schedule_conversions](#BKMK_unit_of_measure_schedule_conversions)


### <a name="BKMK_lk_uombase_createdby"></a> lk_uombase_createdby

See systemuser Entity [lk_uombase_createdby](systemuser.md#BKMK_lk_uombase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_uom_createdonbehalfby"></a> lk_uom_createdonbehalfby

See systemuser Entity [lk_uom_createdonbehalfby](systemuser.md#BKMK_lk_uom_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_uombase_modifiedby"></a> lk_uombase_modifiedby

See systemuser Entity [lk_uombase_modifiedby](systemuser.md#BKMK_lk_uombase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_uom_modifiedonbehalfby"></a> lk_uom_modifiedonbehalfby

See systemuser Entity [lk_uom_modifiedonbehalfby](systemuser.md#BKMK_lk_uom_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_uom_createdby"></a> lk_externalparty_uom_createdby

See externalparty Entity [lk_externalparty_uom_createdby](externalparty.md#BKMK_lk_externalparty_uom_createdby) One-To-Many relationship.

### <a name="BKMK_lk_externalparty_uom_modifiedby"></a> lk_externalparty_uom_modifiedby

See externalparty Entity [lk_externalparty_uom_modifiedby](externalparty.md#BKMK_lk_externalparty_uom_modifiedby) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_base_unit"></a> unit_of_measurement_base_unit

See uom Entity [unit_of_measurement_base_unit](uom.md#BKMK_unit_of_measurement_base_unit) One-To-Many relationship.

### <a name="BKMK_unit_of_measure_schedule_conversions"></a> unit_of_measure_schedule_conversions

See uomschedule Entity [unit_of_measure_schedule_conversions](uomschedule.md#BKMK_unit_of_measure_schedule_conversions) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.uom?text=uom EntityType" />