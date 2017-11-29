---
title: "msdyn_transactioncategory Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_transactioncategory entity."
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
# msdyn_transactioncategory Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Business transaction categories to classify costs and revenue.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_transactioncategories<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_transactioncategories(*msdyn_transactioncategoryid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_transactioncategories(*msdyn_transactioncategoryid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_transactioncategories<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_transactioncategories(*msdyn_transactioncategoryid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_transactioncategories(*msdyn_transactioncategoryid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Transaction Category<br />
**DisplayCollectionName**: Transaction Categories<br />
**SchemaName**: msdyn_transactioncategory<br />
**CollectionSchemaName**: msdyn_transactioncategories<br />
**LogicalName**: msdyn_transactioncategory<br />
**LogicalCollectionName**: msdyn_transactioncategories<br />
**EntitySetName**: msdyn_transactioncategories<br />
**PrimaryIdAttribute**: msdyn_transactioncategoryid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BillingType](#BKMK_msdyn_BillingType)
- [msdyn_DefaultUnit](#BKMK_msdyn_DefaultUnit)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_transactioncategoryId](#BKMK_msdyn_transactioncategoryId)
- [msdyn_UnitGroup](#BKMK_msdyn_UnitGroup)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


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


### <a name="BKMK_msdyn_BillingType"></a> msdyn_BillingType

**Description**: Select the default billing type of project transactions in this category. Valid values are Chargeable, Non chargeable or Complimentary. Only chargeable transactions will add to an invoice total<br />
**DisplayName**: Billing Type<br />
**LogicalName**: msdyn_billingtype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Non Chargeable
- **Value**: 192350001 **Label**: Chargeable
- **Value**: 192350002 **Label**: Complimentary
- **Value**: 192350003 **Label**: Not Available



### <a name="BKMK_msdyn_DefaultUnit"></a> msdyn_DefaultUnit

**Description**: <br />
**DisplayName**: Default Unit<br />
**LogicalName**: msdyn_defaultunit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uom


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Type the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_transactioncategoryId"></a> msdyn_transactioncategoryId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Transaction Category<br />
**LogicalName**: msdyn_transactioncategoryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_UnitGroup"></a> msdyn_UnitGroup

**Description**: Select the unit schedule that is associated with the transaction category.<br />
**DisplayName**: Unit Schedule<br />
**LogicalName**: msdyn_unitgroup<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: uomschedule


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


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Transaction Category<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Transaction Category<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



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

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_DefaultUnitName](#BKMK_msdyn_DefaultUnitName)
- [msdyn_UnitGroupName](#BKMK_msdyn_UnitGroupName)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the record was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Unique identifier of the delegate user who created the record.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the record was modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who modified the record.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_DefaultUnitName"></a> msdyn_DefaultUnitName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultunitname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_UnitGroupName"></a> msdyn_UnitGroupName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_unitgroupname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier for the organization<br />
**DisplayName**: Organization Id<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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

- [msdyn_transactioncategory_SyncErrors](#BKMK_msdyn_transactioncategory_SyncErrors)
- [msdyn_transactioncategory_DuplicateMatchingRecord](#BKMK_msdyn_transactioncategory_DuplicateMatchingRecord)
- [msdyn_transactioncategory_DuplicateBaseRecord](#BKMK_msdyn_transactioncategory_DuplicateBaseRecord)
- [msdyn_transactioncategory_AsyncOperations](#BKMK_msdyn_transactioncategory_AsyncOperations)
- [msdyn_transactioncategory_MailboxTrackingFolders](#BKMK_msdyn_transactioncategory_MailboxTrackingFolders)
- [msdyn_transactioncategory_UserEntityInstanceDatas](#BKMK_msdyn_transactioncategory_UserEntityInstanceDatas)
- [msdyn_transactioncategory_ProcessSession](#BKMK_msdyn_transactioncategory_ProcessSession)
- [msdyn_transactioncategory_BulkDeleteFailures](#BKMK_msdyn_transactioncategory_BulkDeleteFailures)
- [msdyn_transactioncategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactioncategory_PrincipalObjectAttributeAccesses)
- [msdyn_transactioncategory_Annotations](#BKMK_msdyn_transactioncategory_Annotations)
- [msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_expensecatego](#BKMK_msdyn_msdyn_transactioncategory_msdyn_expensecatego)
- [msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory)
- [msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory)
- [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory)
- [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory)
- [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory)
- [msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory)
- [msdyn_msdyn_transactioncategory_product_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory)


### <a name="BKMK_msdyn_transactioncategory_SyncErrors"></a> msdyn_transactioncategory_SyncErrors

Same as syncerror entity [msdyn_transactioncategory_SyncErrors](syncerror.md#BKMK_msdyn_transactioncategory_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactioncategory_SyncErrors<br />
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


### <a name="BKMK_msdyn_transactioncategory_DuplicateMatchingRecord"></a> msdyn_transactioncategory_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_transactioncategory_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_transactioncategory_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactioncategory_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_transactioncategory_DuplicateBaseRecord"></a> msdyn_transactioncategory_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_transactioncategory_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_transactioncategory_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactioncategory_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_transactioncategory_AsyncOperations"></a> msdyn_transactioncategory_AsyncOperations

Same as asyncoperation entity [msdyn_transactioncategory_AsyncOperations](asyncoperation.md#BKMK_msdyn_transactioncategory_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactioncategory_AsyncOperations<br />
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


### <a name="BKMK_msdyn_transactioncategory_MailboxTrackingFolders"></a> msdyn_transactioncategory_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_transactioncategory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_transactioncategory_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactioncategory_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_transactioncategory_UserEntityInstanceDatas"></a> msdyn_transactioncategory_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_transactioncategory_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_transactioncategory_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactioncategory_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_transactioncategory_ProcessSession"></a> msdyn_transactioncategory_ProcessSession

Same as processsession entity [msdyn_transactioncategory_ProcessSession](processsession.md#BKMK_msdyn_transactioncategory_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactioncategory_ProcessSession<br />
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


### <a name="BKMK_msdyn_transactioncategory_BulkDeleteFailures"></a> msdyn_transactioncategory_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_transactioncategory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_transactioncategory_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactioncategory_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_transactioncategory_PrincipalObjectAttributeAccesses"></a> msdyn_transactioncategory_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_transactioncategory_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_transactioncategory_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactioncategory_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_transactioncategory_Annotations"></a> msdyn_transactioncategory_Annotations

Same as annotation entity [msdyn_transactioncategory_Annotations](annotation.md#BKMK_msdyn_transactioncategory_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactioncategory_Annotations<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory

Same as bookableresourcecategory entity [msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory](bookableresourcecategory.md#BKMK_msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: bookableresourcecategory<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory

Same as msdyn_actual entity [msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory](msdyn_actual.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_actual<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory

Same as msdyn_estimateline entity [msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory](msdyn_estimateline.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_estimateline<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_expensecatego"></a> msdyn_msdyn_transactioncategory_msdyn_expensecatego

Same as msdyn_expensecategory entity [msdyn_msdyn_transactioncategory_msdyn_expensecatego](msdyn_expensecategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_expensecatego) Many-To-One relationship.

**ReferencingEntity**: msdyn_expensecategory<br />
**ReferencingAttribute**: msdyn_expensecategoryuid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_expensecatego<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory

Same as msdyn_fact entity [msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory](msdyn_fact.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_fact<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory

Same as msdyn_invoicelinetransaction entity [msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory](msdyn_invoicelinetransaction.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_invoicelinetransaction<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory

Same as msdyn_journalline entity [msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory](msdyn_journalline.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_journalline<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory

Same as msdyn_opportunitylinetransaction entity [msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory](msdyn_opportunitylinetransaction.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransaction<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory

Same as msdyn_opportunitylinetransactioncategory entity [msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_opportunitylinetransactioncategory<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory

Same as msdyn_orderlinetransaction entity [msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory](msdyn_orderlinetransaction.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransaction<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory

Same as msdyn_orderlinetransactioncategory entity [msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_orderlinetransactioncategory<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory

Same as msdyn_projectapproval entity [msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory](msdyn_projectapproval.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_projectapproval<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory"></a> msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory

Same as msdyn_projecttask entity [msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory](msdyn_projecttask.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttask<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory

Same as msdyn_projecttransactioncategory entity [msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory](msdyn_projecttransactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_projecttransactioncategory<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory

Same as msdyn_quotelineanalyticsbreakdown entity [msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelineanalyticsbreakdown<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory

Same as msdyn_quotelinetransaction entity [msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory](msdyn_quotelinetransaction.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransaction<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory

Same as msdyn_quotelinetransactioncategory entity [msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_quotelinetransactioncategory<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory"></a> msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory

Same as msdyn_transactioncategoryclassification entity [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory](msdyn_transactioncategoryclassification.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactioncategoryclassification<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory"></a> msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory

Same as msdyn_transactioncategoryhierarchyelement entity [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactioncategoryhierarchyelement<br />
**ReferencingAttribute**: msdyn_childcategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory"></a> msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory

Same as msdyn_transactioncategoryhierarchyelement entity [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactioncategoryhierarchyelement<br />
**ReferencingAttribute**: msdyn_parentcategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory

Same as msdyn_transactioncategorypricelevel entity [msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: msdyn_transactioncategorypricelevel<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory<br />
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


### <a name="BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory"></a> msdyn_msdyn_transactioncategory_product_TransactionCategory

Same as product entity [msdyn_msdyn_transactioncategory_product_TransactionCategory](product.md#BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory) Many-To-One relationship.

**ReferencingEntity**: product<br />
**ReferencingAttribute**: msdyn_transactioncategory<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_transactioncategory_product_TransactionCategory<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_transactioncategory_createdby](#BKMK_lk_msdyn_transactioncategory_createdby)
- [lk_msdyn_transactioncategory_createdonbehalfby](#BKMK_lk_msdyn_transactioncategory_createdonbehalfby)
- [lk_msdyn_transactioncategory_modifiedby](#BKMK_lk_msdyn_transactioncategory_modifiedby)
- [lk_msdyn_transactioncategory_modifiedonbehalfby](#BKMK_lk_msdyn_transactioncategory_modifiedonbehalfby)
- [organization_msdyn_transactioncategory](#BKMK_organization_msdyn_transactioncategory)
- [msdyn_uom_msdyn_transactioncategory_DefaultUnit](#BKMK_msdyn_uom_msdyn_transactioncategory_DefaultUnit)
- [msdyn_uomschedule_msdyn_transactioncategory_UnitGroup](#BKMK_msdyn_uomschedule_msdyn_transactioncategory_UnitGroup)


### <a name="BKMK_lk_msdyn_transactioncategory_createdby"></a> lk_msdyn_transactioncategory_createdby

See systemuser Entity [lk_msdyn_transactioncategory_createdby](systemuser.md#BKMK_lk_msdyn_transactioncategory_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactioncategory_createdonbehalfby"></a> lk_msdyn_transactioncategory_createdonbehalfby

See systemuser Entity [lk_msdyn_transactioncategory_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_transactioncategory_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactioncategory_modifiedby"></a> lk_msdyn_transactioncategory_modifiedby

See systemuser Entity [lk_msdyn_transactioncategory_modifiedby](systemuser.md#BKMK_lk_msdyn_transactioncategory_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactioncategory_modifiedonbehalfby"></a> lk_msdyn_transactioncategory_modifiedonbehalfby

See systemuser Entity [lk_msdyn_transactioncategory_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_transactioncategory_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_transactioncategory"></a> organization_msdyn_transactioncategory

See organization Entity [organization_msdyn_transactioncategory](organization.md#BKMK_organization_msdyn_transactioncategory) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_transactioncategory_DefaultUnit"></a> msdyn_uom_msdyn_transactioncategory_DefaultUnit

See uom Entity [msdyn_uom_msdyn_transactioncategory_DefaultUnit](uom.md#BKMK_msdyn_uom_msdyn_transactioncategory_DefaultUnit) One-To-Many relationship.

### <a name="BKMK_msdyn_uomschedule_msdyn_transactioncategory_UnitGroup"></a> msdyn_uomschedule_msdyn_transactioncategory_UnitGroup

See uomschedule Entity [msdyn_uomschedule_msdyn_transactioncategory_UnitGroup](uomschedule.md#BKMK_msdyn_uomschedule_msdyn_transactioncategory_UnitGroup) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_transactioncategory?text=msdyn_transactioncategory EntityType" />