---
title: "UoM Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the UoM entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# UoM Entity Reference

Unit of measure.

**Added by**: Product Management Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/uoms<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/uoms(*uomid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/uoms(*uomid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/uoms<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/uoms(*uomid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|UoMs|
|DisplayCollectionName|Units|
|DisplayName|Unit|
|EntitySetName|uoms|
|IsBPFEntity|False|
|LogicalCollectionName|uoms|
|LogicalName|uom|
|OwnershipType|None|
|PrimaryIdAttribute|uomid|
|PrimaryNameAttribute|name|
|SchemaName|UoM|

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

|Property|Value|
|--------|-----|
|Description|Choose the base or primary unit on which the unit is based.|
|DisplayName|Base Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|baseuom|
|RequiredLevel|ApplicationRequired|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Type a descriptive title or name for the unit of measure.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_Quantity"></a> Quantity

|Property|Value|
|--------|-----|
|Description|Unit quantity for the product.|
|DisplayName|Quantity|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|quantity|
|MaxValue|10000000000|
|MinValue|0|
|Precision|5|
|RequiredLevel|ApplicationRequired|
|Type|Decimal|


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UoMId"></a> UoMId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the unit.|
|DisplayName|Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|uomid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_UoMScheduleId"></a> UoMScheduleId

|Property|Value|
|--------|-----|
|Description|Choose the ID of the unit group that the unit is associated with.|
|DisplayName|Unit Schedule|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|uomscheduleid|
|RequiredLevel|SystemRequired|
|Targets|uomschedule|
|Type|Lookup|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

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

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|baseuomname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the unit.|
|DisplayName|Created By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByExternalParty"></a> CreatedByExternalParty

|Property|Value|
|--------|-----|
|Description|Shows the external party who created the record.|
|DisplayName|Created By (External Party)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdbyexternalparty|
|RequiredLevel|None|
|Targets|externalparty|
|Type|Lookup|


### <a name="BKMK_CreatedByExternalPartyName"></a> CreatedByExternalPartyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyexternalpartyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByExternalPartyYomiName"></a> CreatedByExternalPartyYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyexternalpartyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the unit was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the uom.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IsScheduleBaseUoM"></a> IsScheduleBaseUoM

|Property|Value|
|--------|-----|
|Description|Tells whether the unit is the base unit for the associated unit group.|
|DisplayName|Is Schedule Base Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isschedulebaseuom|
|RequiredLevel|None|
|Type|Boolean|

#### IsScheduleBaseUoM Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the unit.|
|DisplayName|Modified By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByExternalParty"></a> ModifiedByExternalParty

|Property|Value|
|--------|-----|
|Description|Shows the external party who modified the record.|
|DisplayName|Modified By (External Party)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalparty|
|RequiredLevel|None|
|Targets|externalparty|
|Type|Lookup|


### <a name="BKMK_ModifiedByExternalPartyName"></a> ModifiedByExternalPartyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalpartyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByExternalPartyYomiName"></a> ModifiedByExternalPartyYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyexternalpartyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the unit was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the uom.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the unit of measure.|
|DisplayName|Organization |
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_UoMScheduleIdName"></a> UoMScheduleIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|uomscheduleidname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [UoM_SyncErrors](#BKMK_UoM_SyncErrors)
- [UoM_AsyncOperations](#BKMK_UoM_AsyncOperations)
- [uom_MailboxTrackingFolders](#BKMK_uom_MailboxTrackingFolders)
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
- [msdyn_uom_msdyn_expense_Unit](#BKMK_msdyn_uom_msdyn_expense_Unit)
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
- [msdyn_uom_msdyn_geofencingsettings_DistanceUnit](#BKMK_msdyn_uom_msdyn_geofencingsettings_DistanceUnit)


### <a name="BKMK_UoM_SyncErrors"></a> UoM_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [UoM_SyncErrors](syncerror.md#BKMK_UoM_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|UoM_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_UoM_AsyncOperations"></a> UoM_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [UoM_AsyncOperations](asyncoperation.md#BKMK_UoM_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|UoM_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_uom_MailboxTrackingFolders"></a> uom_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [uom_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_uom_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|uom_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_UoM_BulkDeleteFailures"></a> UoM_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [UoM_BulkDeleteFailures](bulkdeletefailure.md#BKMK_UoM_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|UoM_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_uom_PrincipalObjectAttributeAccesses"></a> uom_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [uom_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_uom_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|uom_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measurement_base_unit"></a> unit_of_measurement_base_unit

Same as uom entity [unit_of_measurement_base_unit](uom.md#BKMK_unit_of_measurement_base_unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|uom|
|ReferencingAttribute|baseuom|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measurement_base_unit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measurement_products"></a> unit_of_measurement_products

Same as product entity [unit_of_measurement_products](product.md#BKMK_unit_of_measurement_products) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|defaultuomid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measurement_products|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measurement_productassociation"></a> unit_of_measurement_productassociation

Same as productassociation entity [unit_of_measurement_productassociation](productassociation.md#BKMK_unit_of_measurement_productassociation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productassociation|
|ReferencingAttribute|uomid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measurement_productassociation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measurement_product_price_levels"></a> unit_of_measurement_product_price_levels

Same as productpricelevel entity [unit_of_measurement_product_price_levels](productpricelevel.md#BKMK_unit_of_measurement_product_price_levels) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productpricelevel|
|ReferencingAttribute|uomid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measurement_product_price_levels|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measurement_contract_line_items"></a> unit_of_measurement_contract_line_items

**Added by**: Service Solution

Same as contractdetail entity [unit_of_measurement_contract_line_items](contractdetail.md#BKMK_unit_of_measurement_contract_line_items) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contractdetail|
|ReferencingAttribute|uomid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measurement_contract_line_items|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measurement_invoice_details"></a> unit_of_measurement_invoice_details

**Added by**: Sales Solution

Same as invoicedetail entity [unit_of_measurement_invoice_details](invoicedetail.md#BKMK_unit_of_measurement_invoice_details) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|uomid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measurement_invoice_details|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measurement_opportunity_products"></a> unit_of_measurement_opportunity_products

**Added by**: Sales Solution

Same as opportunityproduct entity [unit_of_measurement_opportunity_products](opportunityproduct.md#BKMK_unit_of_measurement_opportunity_products) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunityproduct|
|ReferencingAttribute|uomid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measurement_opportunity_products|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measurement_order_details"></a> unit_of_measurement_order_details

**Added by**: Sales Solution

Same as salesorderdetail entity [unit_of_measurement_order_details](salesorderdetail.md#BKMK_unit_of_measurement_order_details) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorderdetail|
|ReferencingAttribute|uomid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measurement_order_details|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measurement_quote_details"></a> unit_of_measurement_quote_details

**Added by**: Sales Solution

Same as quotedetail entity [unit_of_measurement_quote_details](quotedetail.md#BKMK_unit_of_measurement_quote_details) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quotedetail|
|ReferencingAttribute|uomid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measurement_quote_details|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_actual_Unit"></a> msdyn_uom_msdyn_actual_Unit

**Added by**: Universal Resource Scheduling Solution

Same as msdyn_actual entity [msdyn_uom_msdyn_actual_Unit](msdyn_actual.md#BKMK_msdyn_uom_msdyn_actual_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_actual_Unit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_estimateline_Unit"></a> msdyn_uom_msdyn_estimateline_Unit

**Added by**: Project Service Automation Solution

Same as msdyn_estimateline entity [msdyn_uom_msdyn_estimateline_Unit](msdyn_estimateline.md#BKMK_msdyn_uom_msdyn_estimateline_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimateline|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_estimateline_Unit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_expense_Unit"></a> msdyn_uom_msdyn_expense_Unit

**Added by**: Project Service Automation Solution

Same as msdyn_expense entity [msdyn_uom_msdyn_expense_Unit](msdyn_expense.md#BKMK_msdyn_uom_msdyn_expense_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_expense|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_expense_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_invoicelinetransaction_Unit"></a> msdyn_uom_msdyn_invoicelinetransaction_Unit

**Added by**: Project Service Automation Solution

Same as msdyn_invoicelinetransaction entity [msdyn_uom_msdyn_invoicelinetransaction_Unit](msdyn_invoicelinetransaction.md#BKMK_msdyn_uom_msdyn_invoicelinetransaction_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_invoicelinetransaction_Unit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_journalline_Unit"></a> msdyn_uom_msdyn_journalline_Unit

**Added by**: Project Service Automation Solution

Same as msdyn_journalline entity [msdyn_uom_msdyn_journalline_Unit](msdyn_journalline.md#BKMK_msdyn_uom_msdyn_journalline_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journalline|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_journalline_Unit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_opportunitylinetransaction_Unit"></a> msdyn_uom_msdyn_opportunitylinetransaction_Unit

**Added by**: Project Service Automation Solution

Same as msdyn_opportunitylinetransaction entity [msdyn_uom_msdyn_opportunitylinetransaction_Unit](msdyn_opportunitylinetransaction.md#BKMK_msdyn_uom_msdyn_opportunitylinetransaction_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransaction|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_opportunitylinetransaction_Unit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_orderlinetransaction_Unit"></a> msdyn_uom_msdyn_orderlinetransaction_Unit

**Added by**: Project Service Automation Solution

Same as msdyn_orderlinetransaction entity [msdyn_uom_msdyn_orderlinetransaction_Unit](msdyn_orderlinetransaction.md#BKMK_msdyn_uom_msdyn_orderlinetransaction_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransaction|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_orderlinetransaction_Unit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_quotelinetransaction_Unit"></a> msdyn_uom_msdyn_quotelinetransaction_Unit

**Added by**: Project Service Automation Solution

Same as msdyn_quotelinetransaction entity [msdyn_uom_msdyn_quotelinetransaction_Unit](msdyn_quotelinetransaction.md#BKMK_msdyn_uom_msdyn_quotelinetransaction_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransaction|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_quotelinetransaction_Unit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit"></a> msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit

**Added by**: Project Service Automation Solution

Same as msdyn_resourcecategorypricelevel entity [msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorypricelevel|
|ReferencingAttribute|msdyn_primaryunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_Unit"></a> msdyn_uom_msdyn_resourcecategorypricelevel_Unit

**Added by**: Project Service Automation Solution

Same as msdyn_resourcecategorypricelevel entity [msdyn_uom_msdyn_resourcecategorypricelevel_Unit](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_uom_msdyn_resourcecategorypricelevel_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorypricelevel|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_resourcecategorypricelevel_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_transactioncategory_DefaultUnit"></a> msdyn_uom_msdyn_transactioncategory_DefaultUnit

**Added by**: Project Service Automation Solution

Same as msdyn_transactioncategory entity [msdyn_uom_msdyn_transactioncategory_DefaultUnit](msdyn_transactioncategory.md#BKMK_msdyn_uom_msdyn_transactioncategory_DefaultUnit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategory|
|ReferencingAttribute|msdyn_defaultunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_transactioncategory_DefaultUnit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_transactioncategorypricelevel_Unit"></a> msdyn_uom_msdyn_transactioncategorypricelevel_Unit

**Added by**: Project Service Automation Solution

Same as msdyn_transactioncategorypricelevel entity [msdyn_uom_msdyn_transactioncategorypricelevel_Unit](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_uom_msdyn_transactioncategorypricelevel_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategorypricelevel|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_transactioncategorypricelevel_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_transactiontype_DefaultUnit"></a> msdyn_uom_msdyn_transactiontype_DefaultUnit

**Added by**: Project Service Automation Solution

Same as msdyn_transactiontype entity [msdyn_uom_msdyn_transactiontype_DefaultUnit](msdyn_transactiontype.md#BKMK_msdyn_uom_msdyn_transactiontype_DefaultUnit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactiontype|
|ReferencingAttribute|msdyn_defaultunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_transactiontype_DefaultUnit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_pricelevel_TimeUnit"></a> msdyn_uom_pricelevel_TimeUnit

**Added by**: Project Service Automation Solution

Same as pricelevel entity [msdyn_uom_pricelevel_TimeUnit](pricelevel.md#BKMK_msdyn_uom_pricelevel_TimeUnit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|pricelevel|
|ReferencingAttribute|msdyn_timeunit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_pricelevel_TimeUnit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_agreementbookingproduct_Unit"></a> msdyn_uom_msdyn_agreementbookingproduct_Unit

**Added by**: Field Service Solution

Same as msdyn_agreementbookingproduct entity [msdyn_uom_msdyn_agreementbookingproduct_Unit](msdyn_agreementbookingproduct.md#BKMK_msdyn_uom_msdyn_agreementbookingproduct_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingproduct|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_agreementbookingproduct_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_agreementbookingservice_Unit"></a> msdyn_uom_msdyn_agreementbookingservice_Unit

**Added by**: Field Service Solution

Same as msdyn_agreementbookingservice entity [msdyn_uom_msdyn_agreementbookingservice_Unit](msdyn_agreementbookingservice.md#BKMK_msdyn_uom_msdyn_agreementbookingservice_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservice|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_agreementbookingservice_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_agreementinvoiceproduct_Unit"></a> msdyn_uom_msdyn_agreementinvoiceproduct_Unit

**Added by**: Field Service Solution

Same as msdyn_agreementinvoiceproduct entity [msdyn_uom_msdyn_agreementinvoiceproduct_Unit](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_uom_msdyn_agreementinvoiceproduct_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementinvoiceproduct|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_agreementinvoiceproduct_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit"></a> msdyn_uom_msdyn_incidenttypeproduct_Unit

**Added by**: Field Service Solution

Same as msdyn_incidenttypeproduct entity [msdyn_uom_msdyn_incidenttypeproduct_Unit](msdyn_incidenttypeproduct.md#BKMK_msdyn_uom_msdyn_incidenttypeproduct_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypeproduct|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_incidenttypeproduct_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit"></a> msdyn_uom_msdyn_incidenttypeservice_Unit

**Added by**: Field Service Solution

Same as msdyn_incidenttypeservice entity [msdyn_uom_msdyn_incidenttypeservice_Unit](msdyn_incidenttypeservice.md#BKMK_msdyn_uom_msdyn_incidenttypeservice_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_incidenttypeservice|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_incidenttypeservice_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_inventoryadjustmentproduct_Unit"></a> msdyn_uom_msdyn_inventoryadjustmentproduct_Unit

**Added by**: Field Service Solution

Same as msdyn_inventoryadjustmentproduct entity [msdyn_uom_msdyn_inventoryadjustmentproduct_Unit](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_uom_msdyn_inventoryadjustmentproduct_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryadjustmentproduct|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_inventoryadjustmentproduct_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_inventoryjournal_Unit"></a> msdyn_uom_msdyn_inventoryjournal_Unit

**Added by**: Field Service Solution

Same as msdyn_inventoryjournal entity [msdyn_uom_msdyn_inventoryjournal_Unit](msdyn_inventoryjournal.md#BKMK_msdyn_uom_msdyn_inventoryjournal_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryjournal|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_inventoryjournal_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_orderinvoicingproduct_Unit"></a> msdyn_uom_msdyn_orderinvoicingproduct_Unit

**Added by**: Field Service Solution

Same as msdyn_orderinvoicingproduct entity [msdyn_uom_msdyn_orderinvoicingproduct_Unit](msdyn_orderinvoicingproduct.md#BKMK_msdyn_uom_msdyn_orderinvoicingproduct_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderinvoicingproduct|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_orderinvoicingproduct_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_productinventory_Unit"></a> msdyn_uom_msdyn_productinventory_Unit

**Added by**: Field Service Solution

Same as msdyn_productinventory entity [msdyn_uom_msdyn_productinventory_Unit](msdyn_productinventory.md#BKMK_msdyn_uom_msdyn_productinventory_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_productinventory|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_productinventory_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_purchaseorderproduct_Unit"></a> msdyn_uom_msdyn_purchaseorderproduct_Unit

**Added by**: Field Service Solution

Same as msdyn_purchaseorderproduct entity [msdyn_uom_msdyn_purchaseorderproduct_Unit](msdyn_purchaseorderproduct.md#BKMK_msdyn_uom_msdyn_purchaseorderproduct_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_purchaseorderproduct|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_purchaseorderproduct_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit"></a> msdyn_uom_msdyn_quotebookingproduct_Unit

**Added by**: Field Service Solution

Same as msdyn_quotebookingproduct entity [msdyn_uom_msdyn_quotebookingproduct_Unit](msdyn_quotebookingproduct.md#BKMK_msdyn_uom_msdyn_quotebookingproduct_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingproduct|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_quotebookingproduct_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_quotebookingservice_Unit"></a> msdyn_uom_msdyn_quotebookingservice_Unit

**Added by**: Field Service Solution

Same as msdyn_quotebookingservice entity [msdyn_uom_msdyn_quotebookingservice_Unit](msdyn_quotebookingservice.md#BKMK_msdyn_uom_msdyn_quotebookingservice_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservice|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_quotebookingservice_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_quoteinvoicingproduct_Unit"></a> msdyn_uom_msdyn_quoteinvoicingproduct_Unit

**Added by**: Field Service Solution

Same as msdyn_quoteinvoicingproduct entity [msdyn_uom_msdyn_quoteinvoicingproduct_Unit](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_uom_msdyn_quoteinvoicingproduct_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quoteinvoicingproduct|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_quoteinvoicingproduct_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_rmaproduct_Unit"></a> msdyn_uom_msdyn_rmaproduct_Unit

**Added by**: Field Service Solution

Same as msdyn_rmaproduct entity [msdyn_uom_msdyn_rmaproduct_Unit](msdyn_rmaproduct.md#BKMK_msdyn_uom_msdyn_rmaproduct_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmaproduct|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_rmaproduct_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_rtvproduct_Unit"></a> msdyn_uom_msdyn_rtvproduct_Unit

**Added by**: Field Service Solution

Same as msdyn_rtvproduct entity [msdyn_uom_msdyn_rtvproduct_Unit](msdyn_rtvproduct.md#BKMK_msdyn_uom_msdyn_rtvproduct_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtvproduct|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_rtvproduct_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_workorderproduct_Unit"></a> msdyn_uom_msdyn_workorderproduct_Unit

**Added by**: Field Service Solution

Same as msdyn_workorderproduct entity [msdyn_uom_msdyn_workorderproduct_Unit](msdyn_workorderproduct.md#BKMK_msdyn_uom_msdyn_workorderproduct_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderproduct|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_workorderproduct_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_workorderservice_Unit"></a> msdyn_uom_msdyn_workorderservice_Unit

**Added by**: Field Service Solution

Same as msdyn_workorderservice entity [msdyn_uom_msdyn_workorderservice_Unit](msdyn_workorderservice.md#BKMK_msdyn_uom_msdyn_workorderservice_Unit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservice|
|ReferencingAttribute|msdyn_unit|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_workorderservice_Unit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uom_msdyn_geofencingsettings_DistanceUnit"></a> msdyn_uom_msdyn_geofencingsettings_DistanceUnit

**Added by**: Geofence Management Solution

Same as msdyn_geofencingsettings entity [msdyn_uom_msdyn_geofencingsettings_DistanceUnit](msdyn_geofencingsettings.md#BKMK_msdyn_uom_msdyn_geofencingsettings_DistanceUnit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_geofencingsettings|
|ReferencingAttribute|msdyn_unitofmeasure|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uom_msdyn_geofencingsettings_DistanceUnit|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_uombase_createdby](#BKMK_lk_uombase_createdby)
- [lk_uom_createdonbehalfby](#BKMK_lk_uom_createdonbehalfby)
- [lk_uombase_modifiedby](#BKMK_lk_uombase_modifiedby)
- [lk_uom_modifiedonbehalfby](#BKMK_lk_uom_modifiedonbehalfby)
- [unit_of_measurement_base_unit](#BKMK_unit_of_measurement_base_unit)
- [unit_of_measure_schedule_conversions](#BKMK_unit_of_measure_schedule_conversions)


### <a name="BKMK_lk_uombase_createdby"></a> lk_uombase_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_uombase_createdby](systemuser.md#BKMK_lk_uombase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_uom_createdonbehalfby"></a> lk_uom_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_uom_createdonbehalfby](systemuser.md#BKMK_lk_uom_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_uombase_modifiedby"></a> lk_uombase_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_uombase_modifiedby](systemuser.md#BKMK_lk_uombase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_uom_modifiedonbehalfby"></a> lk_uom_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_uom_modifiedonbehalfby](systemuser.md#BKMK_lk_uom_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_unit_of_measurement_base_unit"></a> unit_of_measurement_base_unit

See uom Entity [unit_of_measurement_base_unit](uom.md#BKMK_unit_of_measurement_base_unit) One-To-Many relationship.

### <a name="BKMK_unit_of_measure_schedule_conversions"></a> unit_of_measure_schedule_conversions

See uomschedule Entity [unit_of_measure_schedule_conversions](uomschedule.md#BKMK_unit_of_measure_schedule_conversions) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.uom?text=uom EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]