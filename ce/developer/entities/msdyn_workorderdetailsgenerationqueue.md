---
title: "msdyn_workorderdetailsgenerationqueue Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_workorderdetailsgenerationqueue entity."
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
# msdyn_workorderdetailsgenerationqueue Entity Reference

Pool for WO Generation

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues(*msdyn_workorderdetailsgenerationqueueid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues(*msdyn_workorderdetailsgenerationqueueid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues(*msdyn_workorderdetailsgenerationqueueid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderdetailsgenerationqueues(*msdyn_workorderdetailsgenerationqueueid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_workorderdetailsgenerationqueues|
|DisplayCollectionName|Work Order Details Generation Queue (Deprecated)|
|DisplayName|Work Order Details Generation Queue (Deprecated)|
|EntitySetName|msdyn_workorderdetailsgenerationqueues|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_workorderdetailsgenerationqueues|
|LogicalName|msdyn_workorderdetailsgenerationqueue|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_workorderdetailsgenerationqueueid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_workorderdetailsgenerationqueue|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AgreementBookingDate](#BKMK_msdyn_AgreementBookingDate)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_ExceptionMessage](#BKMK_msdyn_ExceptionMessage)
- [msdyn_ExceptionTrace](#BKMK_msdyn_ExceptionTrace)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Processed](#BKMK_msdyn_Processed)
- [msdyn_SchDateOwnerId](#BKMK_msdyn_SchDateOwnerId)
- [msdyn_WorkOrderDetails](#BKMK_msdyn_WorkOrderDetails)
- [msdyn_workorderdetailsgenerationqueueId](#BKMK_msdyn_workorderdetailsgenerationqueueId)
- [msdyn_WorkorderId](#BKMK_msdyn_WorkorderId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Shows the sequence number of the import that created this record.|
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


### <a name="BKMK_msdyn_AgreementBookingDate"></a> msdyn_AgreementBookingDate

|Property|Value|
|--------|-----|
|Description|Unique identifier for Agreement Booking Date associated with Work Order Details Generation Queue.|
|DisplayName|Agreement Booking Date|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingdate|
|RequiredLevel|None|
|Targets|msdyn_agreementbookingdate|
|Type|Lookup|


### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Booking|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_booking|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ExceptionMessage"></a> msdyn_ExceptionMessage

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Exception Message|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_exceptionmessage|
|MaxLength|4000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ExceptionTrace"></a> msdyn_ExceptionTrace

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Exception Trace|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_exceptiontrace|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Enter the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_Processed"></a> msdyn_Processed

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Processed|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_processed|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_Processed Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_SchDateOwnerId"></a> msdyn_SchDateOwnerId

|Property|Value|
|--------|-----|
|Description||
|DisplayName|SchDateOwnerId|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schdateownerid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderDetails"></a> msdyn_WorkOrderDetails

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Work Order Details|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderdetails|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_workorderdetailsgenerationqueueId"></a> msdyn_workorderdetailsgenerationqueueId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Work Order Details Generation Queue|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_workorderdetailsgenerationqueueid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_WorkorderId"></a> msdyn_WorkorderId

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Work Order ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time that the record was migrated.|
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
|Description|Status of the Work Order Details Generation Queue|
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
|Description|Reason for the status of the Work Order Details Generation Queue|
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
|Description|Shows the time zone code that was in use when the record was created.|
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
- [msdyn_AgreementBookingDateName](#BKMK_msdyn_AgreementBookingDateName)
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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows who created the record on behalf of another user.|
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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows who last updated the record on behalf of another user.|
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


### <a name="BKMK_msdyn_AgreementBookingDateName"></a> msdyn_AgreementBookingDateName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingdatename|
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

- [msdyn_workorderdetailsgenerationqueue_SyncErrors](#BKMK_msdyn_workorderdetailsgenerationqueue_SyncErrors)
- [msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord](#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord)
- [msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord](#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord)
- [msdyn_workorderdetailsgenerationqueue_AsyncOperations](#BKMK_msdyn_workorderdetailsgenerationqueue_AsyncOperations)
- [msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders](#BKMK_msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders)
- [msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas](#BKMK_msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas)
- [msdyn_workorderdetailsgenerationqueue_ProcessSession](#BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession)
- [msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures](#BKMK_msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures)
- [msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_SyncErrors"></a> msdyn_workorderdetailsgenerationqueue_SyncErrors

Same as syncerror entity [msdyn_workorderdetailsgenerationqueue_SyncErrors](syncerror.md#BKMK_msdyn_workorderdetailsgenerationqueue_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderdetailsgenerationqueue_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord"></a> msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord"></a> msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_AsyncOperations"></a> msdyn_workorderdetailsgenerationqueue_AsyncOperations

Same as asyncoperation entity [msdyn_workorderdetailsgenerationqueue_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderdetailsgenerationqueue_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderdetailsgenerationqueue_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders"></a> msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas"></a> msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession"></a> msdyn_workorderdetailsgenerationqueue_ProcessSession

Same as processsession entity [msdyn_workorderdetailsgenerationqueue_ProcessSession](processsession.md#BKMK_msdyn_workorderdetailsgenerationqueue_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderdetailsgenerationqueue_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures"></a> msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses"></a> msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_workorderdetailsgenerationqueue_createdby](#BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdby)
- [lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby](#BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby)
- [lk_msdyn_workorderdetailsgenerationqueue_modifiedby](#BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedby)
- [lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby](#BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby)
- [organization_msdyn_workorderdetailsgenerationqueue](#BKMK_organization_msdyn_workorderdetailsgenerationqueue)
- [msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate](#BKMK_msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate)


### <a name="BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdby"></a> lk_msdyn_workorderdetailsgenerationqueue_createdby

See systemuser Entity [lk_msdyn_workorderdetailsgenerationqueue_createdby](systemuser.md#BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby"></a> lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby

See systemuser Entity [lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedby"></a> lk_msdyn_workorderdetailsgenerationqueue_modifiedby

See systemuser Entity [lk_msdyn_workorderdetailsgenerationqueue_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby"></a> lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby

See systemuser Entity [lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_workorderdetailsgenerationqueue"></a> organization_msdyn_workorderdetailsgenerationqueue

See organization Entity [organization_msdyn_workorderdetailsgenerationqueue](organization.md#BKMK_organization_msdyn_workorderdetailsgenerationqueue) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate"></a> msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate

See msdyn_agreementbookingdate Entity [msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate](msdyn_agreementbookingdate.md#BKMK_msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_workorderdetailsgenerationqueue?text=msdyn_workorderdetailsgenerationqueue EntityType" />