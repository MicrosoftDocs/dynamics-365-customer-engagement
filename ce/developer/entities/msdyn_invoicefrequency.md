---
title: "msdyn_invoicefrequency Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_invoicefrequency entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_invoicefrequency Entity Reference

Setup entity for invoice schedules.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies(*msdyn_invoicefrequencyid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies(*msdyn_invoicefrequencyid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies(*msdyn_invoicefrequencyid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_invoicefrequencies(*msdyn_invoicefrequencyid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_invoicefrequencies|
|DisplayCollectionName|Invoice Frequencies|
|DisplayName|Invoice Frequency|
|EntitySetName|msdyn_invoicefrequencies|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_invoicefrequencies|
|LogicalName|msdyn_invoicefrequency|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_invoicefrequencyid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_invoicefrequency|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_daysofrun](#BKMK_msdyn_daysofrun)
- [msdyn_invoicefrequencyId](#BKMK_msdyn_invoicefrequencyId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_period](#BKMK_msdyn_period)
- [msdyn_runspermonth](#BKMK_msdyn_runspermonth)
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


### <a name="BKMK_msdyn_daysofrun"></a> msdyn_daysofrun

|Property|Value|
|--------|-----|
|Description|Describes how the run days per period interval are setup. As weekdays (Monday, Tuesday...) or day of period (1st, 2nd…) |
|DisplayName|Setup of runs|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_daysofrun|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_daysofrun Options

|Value|Label|
|-----|-----|
|192350000|Day of period|
|192350001|Weekday of period|



### <a name="BKMK_msdyn_invoicefrequencyId"></a> msdyn_invoicefrequencyId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Invoice Frequency|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_invoicefrequencyid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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


### <a name="BKMK_msdyn_period"></a> msdyn_period

|Property|Value|
|--------|-----|
|Description|Select the period used for the setup of invoice frequency: supported values are Monthly, Weekly or Bi Weekly.|
|DisplayName|Period|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_period|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_period Options

|Value|Label|
|-----|-----|
|192350000|Weekly|
|192350001|Monthly|
|192350002|Biweekly|



### <a name="BKMK_msdyn_runspermonth"></a> msdyn_runspermonth

|Property|Value|
|--------|-----|
|Description|Select the number of times invoicing should run in a period.|
|DisplayName|Runs per period|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_runspermonth|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_runspermonth Options

|Value|Label|
|-----|-----|
|1|1|
|2|2|
|3|3|
|4|4|



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
|Description|Status of the Invoice Frequency|
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
|Description|Reason for the status of the Invoice Frequency|
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
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

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

- [msdyn_invoicefrequency_SyncErrors](#BKMK_msdyn_invoicefrequency_SyncErrors)
- [msdyn_invoicefrequency_DuplicateMatchingRecord](#BKMK_msdyn_invoicefrequency_DuplicateMatchingRecord)
- [msdyn_invoicefrequency_DuplicateBaseRecord](#BKMK_msdyn_invoicefrequency_DuplicateBaseRecord)
- [msdyn_invoicefrequency_AsyncOperations](#BKMK_msdyn_invoicefrequency_AsyncOperations)
- [msdyn_invoicefrequency_MailboxTrackingFolders](#BKMK_msdyn_invoicefrequency_MailboxTrackingFolders)
- [msdyn_invoicefrequency_UserEntityInstanceDatas](#BKMK_msdyn_invoicefrequency_UserEntityInstanceDatas)
- [msdyn_invoicefrequency_ProcessSession](#BKMK_msdyn_invoicefrequency_ProcessSession)
- [msdyn_invoicefrequency_BulkDeleteFailures](#BKMK_msdyn_invoicefrequency_BulkDeleteFailures)
- [msdyn_invoicefrequency_PrincipalObjectAttributeAccesses](#BKMK_msdyn_invoicefrequency_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency](#BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency)
- [msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency](#BKMK_msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency)
- [msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency](#BKMK_msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency)
- [msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency](#BKMK_msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency)


### <a name="BKMK_msdyn_invoicefrequency_SyncErrors"></a> msdyn_invoicefrequency_SyncErrors

Same as syncerror entity [msdyn_invoicefrequency_SyncErrors](syncerror.md#BKMK_msdyn_invoicefrequency_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequency_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequency_DuplicateMatchingRecord"></a> msdyn_invoicefrequency_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_invoicefrequency_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_invoicefrequency_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequency_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequency_DuplicateBaseRecord"></a> msdyn_invoicefrequency_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_invoicefrequency_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_invoicefrequency_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequency_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequency_AsyncOperations"></a> msdyn_invoicefrequency_AsyncOperations

Same as asyncoperation entity [msdyn_invoicefrequency_AsyncOperations](asyncoperation.md#BKMK_msdyn_invoicefrequency_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequency_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequency_MailboxTrackingFolders"></a> msdyn_invoicefrequency_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_invoicefrequency_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_invoicefrequency_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequency_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequency_UserEntityInstanceDatas"></a> msdyn_invoicefrequency_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_invoicefrequency_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_invoicefrequency_UserEntityInstanceDatas) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequency_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequency_ProcessSession"></a> msdyn_invoicefrequency_ProcessSession

Same as processsession entity [msdyn_invoicefrequency_ProcessSession](processsession.md#BKMK_msdyn_invoicefrequency_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequency_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequency_BulkDeleteFailures"></a> msdyn_invoicefrequency_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_invoicefrequency_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_invoicefrequency_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequency_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequency_PrincipalObjectAttributeAccesses"></a> msdyn_invoicefrequency_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_invoicefrequency_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_invoicefrequency_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequency_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency"></a> msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency

Same as msdyn_invoicefrequencydetail entity [msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency](msdyn_invoicefrequencydetail.md#BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicefrequencydetail|
|ReferencingAttribute|msdyn_invoicefrequency|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency"></a> msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency

Same as msdyn_projectparameter entity [msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency](msdyn_projectparameter.md#BKMK_msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectparameter|
|ReferencingAttribute|msdyn_invoicefrequency|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency"></a> msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency

Same as quotedetail entity [msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency](quotedetail.md#BKMK_msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|quotedetail|
|ReferencingAttribute|msdyn_invoicefrequency|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency"></a> msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency

Same as salesorderdetail entity [msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency](salesorderdetail.md#BKMK_msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesorderdetail|
|ReferencingAttribute|msdyn_invoicefrequency|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Restrict<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_invoicefrequency_createdby](#BKMK_lk_msdyn_invoicefrequency_createdby)
- [lk_msdyn_invoicefrequency_createdonbehalfby](#BKMK_lk_msdyn_invoicefrequency_createdonbehalfby)
- [lk_msdyn_invoicefrequency_modifiedby](#BKMK_lk_msdyn_invoicefrequency_modifiedby)
- [lk_msdyn_invoicefrequency_modifiedonbehalfby](#BKMK_lk_msdyn_invoicefrequency_modifiedonbehalfby)
- [organization_msdyn_invoicefrequency](#BKMK_organization_msdyn_invoicefrequency)


### <a name="BKMK_lk_msdyn_invoicefrequency_createdby"></a> lk_msdyn_invoicefrequency_createdby

See systemuser Entity [lk_msdyn_invoicefrequency_createdby](systemuser.md#BKMK_lk_msdyn_invoicefrequency_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequency_createdonbehalfby"></a> lk_msdyn_invoicefrequency_createdonbehalfby

See systemuser Entity [lk_msdyn_invoicefrequency_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_invoicefrequency_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequency_modifiedby"></a> lk_msdyn_invoicefrequency_modifiedby

See systemuser Entity [lk_msdyn_invoicefrequency_modifiedby](systemuser.md#BKMK_lk_msdyn_invoicefrequency_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequency_modifiedonbehalfby"></a> lk_msdyn_invoicefrequency_modifiedonbehalfby

See systemuser Entity [lk_msdyn_invoicefrequency_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_invoicefrequency_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_invoicefrequency"></a> organization_msdyn_invoicefrequency

See organization Entity [organization_msdyn_invoicefrequency](organization.md#BKMK_organization_msdyn_invoicefrequency) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_invoicefrequency?text=msdyn_invoicefrequency EntityType" />