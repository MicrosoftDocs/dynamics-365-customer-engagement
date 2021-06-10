---
title: "UoMSchedule Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the UoMSchedule entity."
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
# UoMSchedule Entity Reference

Grouping of units.

**Added by**: Product Management Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/uomschedules<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/uomschedules(*uomscheduleid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/uomschedules(*uomscheduleid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/uomschedules<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/uomschedules(*uomscheduleid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/uomschedules(*uomscheduleid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|UoMSchedules|
|DisplayCollectionName|Unit Groups|
|DisplayName|Unit Group|
|EntitySetName|uomschedules|
|IsBPFEntity|False|
|LogicalCollectionName|uomschedules|
|LogicalName|uomschedule|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|uomscheduleid|
|PrimaryNameAttribute|name|
|SchemaName|UoMSchedule|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BaseUoMName](#BKMK_BaseUoMName)
- [Description](#BKMK_Description)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [StateCode](#BKMK_StateCode)
- [StatusCode](#BKMK_StatusCode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UoMScheduleId](#BKMK_UoMScheduleId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BaseUoMName"></a> BaseUoMName

|Property|Value|
|--------|-----|
|Description|Name of the base unit.|
|DisplayName|Base Unit name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|baseuomname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_Description"></a> Description

|Property|Value|
|--------|-----|
|Description|Description of the unit group.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


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
|Description|Name of the unit group.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|name|
|MaxLength|200|
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


### <a name="BKMK_StateCode"></a> StateCode

|Property|Value|
|--------|-----|
|Description|Status of the Unit Group.|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### StateCode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_StatusCode"></a> StatusCode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Unit Group.|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### StatusCode Options

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


### <a name="BKMK_UoMScheduleId"></a> UoMScheduleId

|Property|Value|
|--------|-----|
|Description|Unique identifier for the unit group.|
|DisplayName|Unit Group|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|uomscheduleid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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
- [CreatedByExternalParty](#BKMK_CreatedByExternalParty)
- [CreatedByExternalPartyName](#BKMK_CreatedByExternalPartyName)
- [CreatedByExternalPartyYomiName](#BKMK_CreatedByExternalPartyYomiName)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
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
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the unit group.|
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
|Description|Date and time when the unit group was created.|
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
|Description|Unique identifier of the delegate user who created the uomschedule.|
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


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the unit group.|
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
|Description|Date and time when the unit group was last modified.|
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
|Description|Unique identifier of the delegate user who last modified the uomschedule.|
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
|Description|Unique identifier for the organization|
|DisplayName|Organization Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

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

- [UoMSchedule_SyncErrors](#BKMK_UoMSchedule_SyncErrors)
- [UoMSchedule_AsyncOperations](#BKMK_UoMSchedule_AsyncOperations)
- [uomschedule_MailboxTrackingFolders](#BKMK_uomschedule_MailboxTrackingFolders)
- [UoMSchedule_BulkDeleteFailures](#BKMK_UoMSchedule_BulkDeleteFailures)
- [uomschedule_PrincipalObjectAttributeAccesses](#BKMK_uomschedule_PrincipalObjectAttributeAccesses)
- [unit_of_measurement_schedule_products](#BKMK_unit_of_measurement_schedule_products)
- [unit_of_measure_schedule_conversions](#BKMK_unit_of_measure_schedule_conversions)
- [unit_of_measure_schedule_product_price_level](#BKMK_unit_of_measure_schedule_product_price_level)
- [contract_detail_unit_of_measure_schedule](#BKMK_contract_detail_unit_of_measure_schedule)
- [msdyn_uomschedule_msdyn_actual_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_actual_UnitSchedule)
- [msdyn_uomschedule_msdyn_estimateline_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_estimateline_UnitSchedule)
- [msdyn_uomschedule_msdyn_expense_UnitGroup](#BKMK_msdyn_uomschedule_msdyn_expense_UnitGroup)
- [msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule)
- [msdyn_uomschedule_msdyn_journalline_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_journalline_UnitSchedule)
- [msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule)
- [msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule)
- [msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule)
- [msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule)
- [msdyn_uomschedule_msdyn_transactioncategory_UnitGroup](#BKMK_msdyn_uomschedule_msdyn_transactioncategory_UnitGroup)
- [msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule)
- [msdyn_uomschedule_msdyn_transactiontype_UnitGroup](#BKMK_msdyn_uomschedule_msdyn_transactiontype_UnitGroup)


### <a name="BKMK_UoMSchedule_SyncErrors"></a> UoMSchedule_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [UoMSchedule_SyncErrors](syncerror.md#BKMK_UoMSchedule_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|UoMSchedule_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_UoMSchedule_AsyncOperations"></a> UoMSchedule_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [UoMSchedule_AsyncOperations](asyncoperation.md#BKMK_UoMSchedule_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|UoMSchedule_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_uomschedule_MailboxTrackingFolders"></a> uomschedule_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [uomschedule_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_uomschedule_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|uomschedule_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_UoMSchedule_BulkDeleteFailures"></a> UoMSchedule_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [UoMSchedule_BulkDeleteFailures](bulkdeletefailure.md#BKMK_UoMSchedule_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|UoMSchedule_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_uomschedule_PrincipalObjectAttributeAccesses"></a> uomschedule_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [uomschedule_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_uomschedule_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|uomschedule_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measurement_schedule_products"></a> unit_of_measurement_schedule_products

Same as product entity [unit_of_measurement_schedule_products](product.md#BKMK_unit_of_measurement_schedule_products) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|defaultuomscheduleid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measurement_schedule_products|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measure_schedule_conversions"></a> unit_of_measure_schedule_conversions

Same as uom entity [unit_of_measure_schedule_conversions](uom.md#BKMK_unit_of_measure_schedule_conversions) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|uom|
|ReferencingAttribute|uomscheduleid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measure_schedule_conversions|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_unit_of_measure_schedule_product_price_level"></a> unit_of_measure_schedule_product_price_level

Same as productpricelevel entity [unit_of_measure_schedule_product_price_level](productpricelevel.md#BKMK_unit_of_measure_schedule_product_price_level) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productpricelevel|
|ReferencingAttribute|uomscheduleid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|unit_of_measure_schedule_product_price_level|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_contract_detail_unit_of_measure_schedule"></a> contract_detail_unit_of_measure_schedule

**Added by**: Service Solution

Same as contractdetail entity [contract_detail_unit_of_measure_schedule](contractdetail.md#BKMK_contract_detail_unit_of_measure_schedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contractdetail|
|ReferencingAttribute|uomscheduleid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|contract_detail_unit_of_measure_schedule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_actual_UnitSchedule"></a> msdyn_uomschedule_msdyn_actual_UnitSchedule

**Added by**: Universal Resource Scheduling Solution

Same as msdyn_actual entity [msdyn_uomschedule_msdyn_actual_UnitSchedule](msdyn_actual.md#BKMK_msdyn_uomschedule_msdyn_actual_UnitSchedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_actual|
|ReferencingAttribute|msdyn_unitschedule|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_actual_UnitSchedule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_estimateline_UnitSchedule"></a> msdyn_uomschedule_msdyn_estimateline_UnitSchedule

**Added by**: Project Service Automation Solution

Same as msdyn_estimateline entity [msdyn_uomschedule_msdyn_estimateline_UnitSchedule](msdyn_estimateline.md#BKMK_msdyn_uomschedule_msdyn_estimateline_UnitSchedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_estimateline|
|ReferencingAttribute|msdyn_unitschedule|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_estimateline_UnitSchedule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_expense_UnitGroup"></a> msdyn_uomschedule_msdyn_expense_UnitGroup

**Added by**: Project Service Automation Solution

Same as msdyn_expense entity [msdyn_uomschedule_msdyn_expense_UnitGroup](msdyn_expense.md#BKMK_msdyn_uomschedule_msdyn_expense_UnitGroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_expense|
|ReferencingAttribute|msdyn_unitgroup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_expense_UnitGroup|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule"></a> msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule

**Added by**: Project Service Automation Solution

Same as msdyn_invoicelinetransaction entity [msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule](msdyn_invoicelinetransaction.md#BKMK_msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicelinetransaction|
|ReferencingAttribute|msdyn_unitschedule|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_invoicelinetransaction_UnitSchedule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_journalline_UnitSchedule"></a> msdyn_uomschedule_msdyn_journalline_UnitSchedule

**Added by**: Project Service Automation Solution

Same as msdyn_journalline entity [msdyn_uomschedule_msdyn_journalline_UnitSchedule](msdyn_journalline.md#BKMK_msdyn_uomschedule_msdyn_journalline_UnitSchedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_journalline|
|ReferencingAttribute|msdyn_unitschedule|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_journalline_UnitSchedule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule"></a> msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule

**Added by**: Project Service Automation Solution

Same as msdyn_opportunitylinetransaction entity [msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule](msdyn_opportunitylinetransaction.md#BKMK_msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_opportunitylinetransaction|
|ReferencingAttribute|msdyn_unitschedule|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_opportunitylinetransaction_UnitSchedule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule"></a> msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule

**Added by**: Project Service Automation Solution

Same as msdyn_orderlinetransaction entity [msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule](msdyn_orderlinetransaction.md#BKMK_msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_orderlinetransaction|
|ReferencingAttribute|msdyn_unitschedule|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_orderlinetransaction_UnitSchedule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule"></a> msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule

**Added by**: Project Service Automation Solution

Same as msdyn_quotelinetransaction entity [msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule](msdyn_quotelinetransaction.md#BKMK_msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelinetransaction|
|ReferencingAttribute|msdyn_unitschedule|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule"></a> msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule

**Added by**: Project Service Automation Solution

Same as msdyn_resourcecategorypricelevel entity [msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorypricelevel|
|ReferencingAttribute|msdyn_unitschedule|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_resourcecategorypricelevel_UnitSchedule|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_transactioncategory_UnitGroup"></a> msdyn_uomschedule_msdyn_transactioncategory_UnitGroup

**Added by**: Project Service Automation Solution

Same as msdyn_transactioncategory entity [msdyn_uomschedule_msdyn_transactioncategory_UnitGroup](msdyn_transactioncategory.md#BKMK_msdyn_uomschedule_msdyn_transactioncategory_UnitGroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategory|
|ReferencingAttribute|msdyn_unitgroup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_transactioncategory_UnitGroup|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule"></a> msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule

**Added by**: Project Service Automation Solution

Same as msdyn_transactioncategorypricelevel entity [msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategorypricelevel|
|ReferencingAttribute|msdyn_unitschedule|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_transactioncategorypricelevel_UnitSchedule|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_uomschedule_msdyn_transactiontype_UnitGroup"></a> msdyn_uomschedule_msdyn_transactiontype_UnitGroup

**Added by**: Project Service Automation Solution

Same as msdyn_transactiontype entity [msdyn_uomschedule_msdyn_transactiontype_UnitGroup](msdyn_transactiontype.md#BKMK_msdyn_uomschedule_msdyn_transactiontype_UnitGroup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactiontype|
|ReferencingAttribute|msdyn_unitgroup|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_uomschedule_msdyn_transactiontype_UnitGroup|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_uomschedulebase_createdby](#BKMK_lk_uomschedulebase_createdby)
- [lk_uomschedule_createdonbehalfby](#BKMK_lk_uomschedule_createdonbehalfby)
- [lk_uomschedulebase_modifiedby](#BKMK_lk_uomschedulebase_modifiedby)
- [lk_uomschedule_modifiedonbehalfby](#BKMK_lk_uomschedule_modifiedonbehalfby)
- [organization_uof_schedules](#BKMK_organization_uof_schedules)


### <a name="BKMK_lk_uomschedulebase_createdby"></a> lk_uomschedulebase_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_uomschedulebase_createdby](systemuser.md#BKMK_lk_uomschedulebase_createdby) One-To-Many relationship.

### <a name="BKMK_lk_uomschedule_createdonbehalfby"></a> lk_uomschedule_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_uomschedule_createdonbehalfby](systemuser.md#BKMK_lk_uomschedule_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_uomschedulebase_modifiedby"></a> lk_uomschedulebase_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_uomschedulebase_modifiedby](systemuser.md#BKMK_lk_uomschedulebase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_uomschedule_modifiedonbehalfby"></a> lk_uomschedule_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_uomschedule_modifiedonbehalfby](systemuser.md#BKMK_lk_uomschedule_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_uof_schedules"></a> organization_uof_schedules

**Added by**: System Solution Solution

See organization Entity [organization_uof_schedules](organization.md#BKMK_organization_uof_schedules) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.uomschedule?text=uomschedule EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]