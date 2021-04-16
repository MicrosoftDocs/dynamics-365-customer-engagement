---
title: "msdyn_transactioncategory Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_transactioncategory entity."
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
# msdyn_transactioncategory Entity Reference

Business transaction categories to classify costs and revenue.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_transactioncategories<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_transactioncategories(*msdyn_transactioncategoryid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_transactioncategories(*msdyn_transactioncategoryid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_transactioncategories<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_transactioncategories(*msdyn_transactioncategoryid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_transactioncategories(*msdyn_transactioncategoryid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_transactioncategories|
|DisplayCollectionName|Transaction Categories|
|DisplayName|Transaction Category|
|EntitySetName|msdyn_transactioncategories|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_transactioncategories|
|LogicalName|msdyn_transactioncategory|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_transactioncategoryid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_transactioncategory|

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


### <a name="BKMK_msdyn_BillingType"></a> msdyn_BillingType

|Property|Value|
|--------|-----|
|Description|Select the default billing type of project transactions in this category. Valid values are Chargeable, Non chargeable or Complimentary. Only chargeable transactions will add to an invoice total|
|DisplayName|Billing Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_billingtype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_BillingType Options

|Value|Label|
|-----|-----|
|192350000|Non Chargeable|
|192350001|Chargeable|
|192350002|Complimentary|
|192350003|Not Available|



### <a name="BKMK_msdyn_DefaultUnit"></a> msdyn_DefaultUnit

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Default Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultunit|
|RequiredLevel|None|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Type the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_transactioncategoryId"></a> msdyn_transactioncategoryId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Transaction Category|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_transactioncategoryid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_UnitGroup"></a> msdyn_UnitGroup

|Property|Value|
|--------|-----|
|Description|Select the unit schedule that is associated with the transaction category.|
|DisplayName|Unit Schedule|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitgroup|
|RequiredLevel|None|
|Targets|uomschedule|
|Type|Lookup|


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


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Transaction Category|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Transaction Category|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

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

**Added by**: Active Solution Solution

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_DefaultUnitName"></a> msdyn_DefaultUnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultunitname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_UnitGroupName"></a> msdyn_UnitGroupName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_unitgroupname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|None|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

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

- [msdyn_transactioncategory_SyncErrors](#BKMK_msdyn_transactioncategory_SyncErrors)
- [msdyn_transactioncategory_DuplicateMatchingRecord](#BKMK_msdyn_transactioncategory_DuplicateMatchingRecord)
- [msdyn_transactioncategory_DuplicateBaseRecord](#BKMK_msdyn_transactioncategory_DuplicateBaseRecord)
- [msdyn_transactioncategory_AsyncOperations](#BKMK_msdyn_transactioncategory_AsyncOperations)
- [msdyn_transactioncategory_MailboxTrackingFolders](#BKMK_msdyn_transactioncategory_MailboxTrackingFolders)
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
- [msdyn_msdyn_transactioncategory_msdyn_resourcecategorymarkuppricelevel_transactioncategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_resourcecategorymarkuppricelevel_transactioncategory)
- [msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory)
- [msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory)
- [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory)
- [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory)
- [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory)
- [msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory)
- [msdyn_msdyn_transactioncategory_product_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory)


### <a name="BKMK_msdyn_transactioncategory_SyncErrors"></a> msdyn_transactioncategory_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_transactioncategory_SyncErrors](syncerror.md#BKMK_msdyn_transactioncategory_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategory_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategory_DuplicateMatchingRecord"></a> msdyn_transactioncategory_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_transactioncategory_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_transactioncategory_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategory_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategory_DuplicateBaseRecord"></a> msdyn_transactioncategory_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_transactioncategory_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_transactioncategory_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategory_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategory_AsyncOperations"></a> msdyn_transactioncategory_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_transactioncategory_AsyncOperations](asyncoperation.md#BKMK_msdyn_transactioncategory_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategory_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategory_MailboxTrackingFolders"></a> msdyn_transactioncategory_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_transactioncategory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_transactioncategory_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategory_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategory_ProcessSession"></a> msdyn_transactioncategory_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_transactioncategory_ProcessSession](processsession.md#BKMK_msdyn_transactioncategory_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategory_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategory_BulkDeleteFailures"></a> msdyn_transactioncategory_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_transactioncategory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_transactioncategory_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategory_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategory_PrincipalObjectAttributeAccesses"></a> msdyn_transactioncategory_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_transactioncategory_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_transactioncategory_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategory_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_transactioncategory_Annotations"></a> msdyn_transactioncategory_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_transactioncategory_Annotations](annotation.md#BKMK_msdyn_transactioncategory_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_transactioncategory_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory

Same as bookableresourcecategory entity [msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory](bookableresourcecategory.md#BKMK_msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bookableresourcecategory|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory

Same as msdyn_actual entity [msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory](msdyn_actual.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory

Same as msdyn_estimateline entity [msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory](msdyn_estimateline.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimateline|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_expensecatego"></a> msdyn_msdyn_transactioncategory_msdyn_expensecatego

Same as msdyn_expensecategory entity [msdyn_msdyn_transactioncategory_msdyn_expensecatego](msdyn_expensecategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_expensecatego) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_expensecategory|
|ReferencingAttribute|msdyn_expensecategoryuid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_expensecatego|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory

Same as msdyn_fact entity [msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory](msdyn_fact.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fact|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory

Same as msdyn_invoicelinetransaction entity [msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory](msdyn_invoicelinetransaction.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory

Same as msdyn_journalline entity [msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory](msdyn_journalline.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journalline|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory

Same as msdyn_opportunitylinetransaction entity [msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory](msdyn_opportunitylinetransaction.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransaction|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory

Same as msdyn_opportunitylinetransactioncategory entity [msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransactioncategory|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory

Same as msdyn_orderlinetransaction entity [msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory](msdyn_orderlinetransaction.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransaction|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory

Same as msdyn_orderlinetransactioncategory entity [msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransactioncategory|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory

Same as msdyn_projectapproval entity [msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory](msdyn_projectapproval.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectapproval|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory"></a> msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory

Same as msdyn_projecttask entity [msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory](msdyn_projecttask.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttask|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory

Same as msdyn_projecttransactioncategory entity [msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory](msdyn_projecttransactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projecttransactioncategory|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory

Same as msdyn_quotelineanalyticsbreakdown entity [msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineanalyticsbreakdown|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory

Same as msdyn_quotelinetransaction entity [msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory](msdyn_quotelinetransaction.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransaction|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory

Same as msdyn_quotelinetransactioncategory entity [msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransactioncategory|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_resourcecategorymarkuppricelevel_transactioncategory"></a> msdyn_msdyn_transactioncategory_msdyn_resourcecategorymarkuppricelevel_transactioncategory

Same as msdyn_resourcecategorymarkuppricelevel entity [msdyn_msdyn_transactioncategory_msdyn_resourcecategorymarkuppricelevel_transactioncategory](msdyn_resourcecategorymarkuppricelevel.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_resourcecategorymarkuppricelevel_transactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorymarkuppricelevel|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_resourcecategorymarkuppricelevel_transactioncategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory"></a> msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory

Same as msdyn_resourcecategorypricelevel entity [msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorypricelevel|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_resourcecategorypricelevel_transactioncategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory"></a> msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory

Same as msdyn_timeentry entity [msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory](msdyn_timeentry.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_timeentry|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_timeentry_transactioncategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory"></a> msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory

Same as msdyn_transactioncategoryclassification entity [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory](msdyn_transactioncategoryclassification.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategoryclassification|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory"></a> msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory

Same as msdyn_transactioncategoryhierarchyelement entity [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategoryhierarchyelement|
|ReferencingAttribute|msdyn_childcategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory"></a> msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory

Same as msdyn_transactioncategoryhierarchyelement entity [msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategoryhierarchyelement|
|ReferencingAttribute|msdyn_parentcategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory

Same as msdyn_transactioncategorypricelevel entity [msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategorypricelevel|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory"></a> msdyn_msdyn_transactioncategory_product_TransactionCategory

Same as product entity [msdyn_msdyn_transactioncategory_product_TransactionCategory](product.md#BKMK_msdyn_msdyn_transactioncategory_product_TransactionCategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|msdyn_transactioncategory|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_transactioncategory_product_TransactionCategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_transactioncategory_createdby](systemuser.md#BKMK_lk_msdyn_transactioncategory_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactioncategory_createdonbehalfby"></a> lk_msdyn_transactioncategory_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_transactioncategory_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_transactioncategory_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactioncategory_modifiedby"></a> lk_msdyn_transactioncategory_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_transactioncategory_modifiedby](systemuser.md#BKMK_lk_msdyn_transactioncategory_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactioncategory_modifiedonbehalfby"></a> lk_msdyn_transactioncategory_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_transactioncategory_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_transactioncategory_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_transactioncategory"></a> organization_msdyn_transactioncategory

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_transactioncategory](organization.md#BKMK_organization_msdyn_transactioncategory) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_transactioncategory_DefaultUnit"></a> msdyn_uom_msdyn_transactioncategory_DefaultUnit

**Added by**: Product Management Solution

See uom Entity [msdyn_uom_msdyn_transactioncategory_DefaultUnit](uom.md#BKMK_msdyn_uom_msdyn_transactioncategory_DefaultUnit) One-To-Many relationship.

### <a name="BKMK_msdyn_uomschedule_msdyn_transactioncategory_UnitGroup"></a> msdyn_uomschedule_msdyn_transactioncategory_UnitGroup

**Added by**: Product Management Solution

See uomschedule Entity [msdyn_uomschedule_msdyn_transactioncategory_UnitGroup](uomschedule.md#BKMK_msdyn_uomschedule_msdyn_transactioncategory_UnitGroup) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_transactioncategory?text=msdyn_transactioncategory EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]