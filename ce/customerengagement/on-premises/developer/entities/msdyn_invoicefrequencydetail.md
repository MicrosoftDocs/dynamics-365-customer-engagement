---
title: "msdyn_invoicefrequencydetail Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_invoicefrequencydetail entity."
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
# msdyn_invoicefrequencydetail Entity Reference

List of days expressed as dates or day of week for a specific invoice schedule template.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails(*msdyn_invoicefrequencydetailid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails(*msdyn_invoicefrequencydetailid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails(*msdyn_invoicefrequencydetailid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_invoicefrequencydetails(*msdyn_invoicefrequencydetailid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_invoicefrequencydetails|
|DisplayCollectionName|Invoice Frequency Details|
|DisplayName|Invoice Frequency Detail|
|EntitySetName|msdyn_invoicefrequencydetails|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_invoicefrequencydetails|
|LogicalName|msdyn_invoicefrequencydetail|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_invoicefrequencydetailid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_invoicefrequencydetail|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_dayofmonth](#BKMK_msdyn_dayofmonth)
- [msdyn_invoicefrequency](#BKMK_msdyn_invoicefrequency)
- [msdyn_invoicefrequencydetailId](#BKMK_msdyn_invoicefrequencydetailId)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_occurrenceofweekday](#BKMK_msdyn_occurrenceofweekday)
- [msdyn_weekday](#BKMK_msdyn_weekday)
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


### <a name="BKMK_msdyn_dayofmonth"></a> msdyn_dayofmonth

|Property|Value|
|--------|-----|
|Description|Specify the day(s) of the month on which invoicing should run|
|DisplayName|Day of month|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_dayofmonth|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_dayofmonth Options

|Value|Label|
|-----|-----|
|192350001|1|
|192350002|2|
|192350003|3|
|192350004|4|
|192350005|5|
|192350006|6|
|192350007|7|
|192350008|8|
|192350009|9|
|192350010|10|
|192350011|11|
|192350012|12|
|192350013|13|
|192350014|14|
|192350015|15|
|192350016|16|
|192350017|17|
|192350018|18|
|192350019|19|
|192350020|20|
|192350021|21|
|192350022|22|
|192350023|23|
|192350024|24|
|192350025|25|
|192350026|26|
|192350027|27|
|192350028|28|
|192350029|29|
|192350030|30|
|192350031|31|



### <a name="BKMK_msdyn_invoicefrequency"></a> msdyn_invoicefrequency

|Property|Value|
|--------|-----|
|Description|Select the invoice frequency.|
|DisplayName|Invoice Frequency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_invoicefrequency|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_invoicefrequency|
|Type|Lookup|


### <a name="BKMK_msdyn_invoicefrequencydetailId"></a> msdyn_invoicefrequencydetailId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Invoice Frequency Detail|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_invoicefrequencydetailid|
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
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_occurrenceofweekday"></a> msdyn_occurrenceofweekday

|Property|Value|
|--------|-----|
|Description|Specifies which occurrence of a weekday the invoicing job should run if there are multiple occurrences of a weekday in the selected period|
|DisplayName|Occurrence of weekday|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_occurrenceofweekday|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_occurrenceofweekday Options

|Value|Label|
|-----|-----|
|192350000|First|
|192350001|Second|
|192350002|Third|
|192350003|Fourth|
|192350004|Last|



### <a name="BKMK_msdyn_weekday"></a> msdyn_weekday

|Property|Value|
|--------|-----|
|Description|Select the weekday of the invoicing job run.|
|DisplayName|Weekday|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_weekday|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_weekday Options

|Value|Label|
|-----|-----|
|192350000|Sunday|
|192350001|Monday|
|192350002|Tuesday|
|192350003|Wednesday|
|192350004|Thursday|
|192350005|Friday|
|192350006|Saturday|



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
|Description|Status of the Invoice Frequency Detail|
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
|Description|Reason for the status of the Invoice Frequency Detail|
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
- [msdyn_invoicefrequencyName](#BKMK_msdyn_invoicefrequencyName)
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


### <a name="BKMK_msdyn_invoicefrequencyName"></a> msdyn_invoicefrequencyName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_invoicefrequencyname|
|MaxLength|100|
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

- [msdyn_invoicefrequencydetail_SyncErrors](#BKMK_msdyn_invoicefrequencydetail_SyncErrors)
- [msdyn_invoicefrequencydetail_DuplicateMatchingRecord](#BKMK_msdyn_invoicefrequencydetail_DuplicateMatchingRecord)
- [msdyn_invoicefrequencydetail_DuplicateBaseRecord](#BKMK_msdyn_invoicefrequencydetail_DuplicateBaseRecord)
- [msdyn_invoicefrequencydetail_AsyncOperations](#BKMK_msdyn_invoicefrequencydetail_AsyncOperations)
- [msdyn_invoicefrequencydetail_MailboxTrackingFolders](#BKMK_msdyn_invoicefrequencydetail_MailboxTrackingFolders)
- [msdyn_invoicefrequencydetail_ProcessSession](#BKMK_msdyn_invoicefrequencydetail_ProcessSession)
- [msdyn_invoicefrequencydetail_BulkDeleteFailures](#BKMK_msdyn_invoicefrequencydetail_BulkDeleteFailures)
- [msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_invoicefrequencydetail_SyncErrors"></a> msdyn_invoicefrequencydetail_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_invoicefrequencydetail_SyncErrors](syncerror.md#BKMK_msdyn_invoicefrequencydetail_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequencydetail_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequencydetail_DuplicateMatchingRecord"></a> msdyn_invoicefrequencydetail_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_invoicefrequencydetail_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_invoicefrequencydetail_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequencydetail_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequencydetail_DuplicateBaseRecord"></a> msdyn_invoicefrequencydetail_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_invoicefrequencydetail_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_invoicefrequencydetail_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequencydetail_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequencydetail_AsyncOperations"></a> msdyn_invoicefrequencydetail_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_invoicefrequencydetail_AsyncOperations](asyncoperation.md#BKMK_msdyn_invoicefrequencydetail_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequencydetail_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequencydetail_MailboxTrackingFolders"></a> msdyn_invoicefrequencydetail_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_invoicefrequencydetail_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_invoicefrequencydetail_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequencydetail_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequencydetail_ProcessSession"></a> msdyn_invoicefrequencydetail_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_invoicefrequencydetail_ProcessSession](processsession.md#BKMK_msdyn_invoicefrequencydetail_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequencydetail_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequencydetail_BulkDeleteFailures"></a> msdyn_invoicefrequencydetail_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_invoicefrequencydetail_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_invoicefrequencydetail_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequencydetail_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses"></a> msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_invoicefrequencydetail_createdby](#BKMK_lk_msdyn_invoicefrequencydetail_createdby)
- [lk_msdyn_invoicefrequencydetail_createdonbehalfby](#BKMK_lk_msdyn_invoicefrequencydetail_createdonbehalfby)
- [lk_msdyn_invoicefrequencydetail_modifiedby](#BKMK_lk_msdyn_invoicefrequencydetail_modifiedby)
- [lk_msdyn_invoicefrequencydetail_modifiedonbehalfby](#BKMK_lk_msdyn_invoicefrequencydetail_modifiedonbehalfby)
- [organization_msdyn_invoicefrequencydetail](#BKMK_organization_msdyn_invoicefrequencydetail)
- [msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency](#BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency)


### <a name="BKMK_lk_msdyn_invoicefrequencydetail_createdby"></a> lk_msdyn_invoicefrequencydetail_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_invoicefrequencydetail_createdby](systemuser.md#BKMK_lk_msdyn_invoicefrequencydetail_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequencydetail_createdonbehalfby"></a> lk_msdyn_invoicefrequencydetail_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_invoicefrequencydetail_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_invoicefrequencydetail_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequencydetail_modifiedby"></a> lk_msdyn_invoicefrequencydetail_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_invoicefrequencydetail_modifiedby](systemuser.md#BKMK_lk_msdyn_invoicefrequencydetail_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_invoicefrequencydetail_modifiedonbehalfby"></a> lk_msdyn_invoicefrequencydetail_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_invoicefrequencydetail_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_invoicefrequencydetail_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_invoicefrequencydetail"></a> organization_msdyn_invoicefrequencydetail

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_invoicefrequencydetail](organization.md#BKMK_organization_msdyn_invoicefrequencydetail) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency"></a> msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency

See msdyn_invoicefrequency Entity [msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency](msdyn_invoicefrequency.md#BKMK_msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_invoicefrequencydetail?text=msdyn_invoicefrequencydetail EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]