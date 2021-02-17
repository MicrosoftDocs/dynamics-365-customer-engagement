---
title: "msdyn_fieldservicesystemjob Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_fieldservicesystemjob entity."
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
# msdyn_fieldservicesystemjob Entity Reference

An internal entity used to track field service system jobs.

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_fieldservicesystemjobs|
|DisplayCollectionName|Field Service System Jobs|
|DisplayName|Field Service System Job|
|EntitySetName|msdyn_fieldservicesystemjobs|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_fieldservicesystemjobs|
|LogicalName|msdyn_fieldservicesystemjob|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|msdyn_fieldservicesystemjobid|
|PrimaryNameAttribute|msdyn_jobname|
|SchemaName|msdyn_fieldservicesystemjob|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ConditionCode](#BKMK_msdyn_ConditionCode)
- [msdyn_ExceptionMessage](#BKMK_msdyn_ExceptionMessage)
- [msdyn_ExceptionTrace](#BKMK_msdyn_ExceptionTrace)
- [msdyn_fieldservicesystemjobId](#BKMK_msdyn_fieldservicesystemjobId)
- [msdyn_InputParameter](#BKMK_msdyn_InputParameter)
- [msdyn_InputParameterType](#BKMK_msdyn_InputParameterType)
- [msdyn_jobname](#BKMK_msdyn_jobname)
- [msdyn_JobStatus](#BKMK_msdyn_JobStatus)
- [msdyn_JobType](#BKMK_msdyn_JobType)
- [msdyn_OutputParameter](#BKMK_msdyn_OutputParameter)
- [msdyn_OutputParameterType](#BKMK_msdyn_OutputParameterType)
- [msdyn_OwnerId](#BKMK_msdyn_OwnerId)
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


### <a name="BKMK_msdyn_ConditionCode"></a> msdyn_ConditionCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Condition Code|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_conditioncode|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


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
|MaxLength|1024|
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


### <a name="BKMK_msdyn_fieldservicesystemjobId"></a> msdyn_fieldservicesystemjobId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Field Service System Job|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_fieldservicesystemjobid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_InputParameter"></a> msdyn_InputParameter

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Input Parameter|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_inputparameter|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_InputParameterType"></a> msdyn_InputParameterType

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Input Parameter Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_inputparametertype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_InputParameterType Options

|Value|Label|
|-----|-----|
|690970000|String List|
|690970001|Json|
|690970002|Xml|



### <a name="BKMK_msdyn_jobname"></a> msdyn_jobname

|Property|Value|
|--------|-----|
|Description|Type a name for the job.|
|DisplayName|Type a name for the job.|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_jobname|
|MaxLength|1024|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_JobStatus"></a> msdyn_JobStatus

|Property|Value|
|--------|-----|
|Description|Enter the status of the job.|
|DisplayName|Job Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_jobstatus|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_JobStatus Options

|Value|Label|
|-----|-----|
|690970000|Pending|
|690970001|In Progress|
|690970002|Completed|
|690970003|Failed|



### <a name="BKMK_msdyn_JobType"></a> msdyn_JobType

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Job Type|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_jobtype|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_OutputParameter"></a> msdyn_OutputParameter

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Output Parameter|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_outputparameter|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_OutputParameterType"></a> msdyn_OutputParameterType

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Output Parameter Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_outputparametertype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_OutputParameterType Options

|Value|Label|
|-----|-----|
|690970000|String List|
|690970001|Json|
|690970002|Xml|



### <a name="BKMK_msdyn_OwnerId"></a> msdyn_OwnerId

|Property|Value|
|--------|-----|
|Description|Shows the user associated with the field service system job.|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ownerid|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


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
|Description|Status of the Field Service System Job|
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
|Description|Shows the reason for the status of the field service system job.|
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
- [msdyn_OwnerIdName](#BKMK_msdyn_OwnerIdName)
- [msdyn_OwnerIdYomiName](#BKMK_msdyn_OwnerIdYomiName)
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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows who created the record on behalf of another user.|
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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows who last updated the record on behalf of another user.|
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


### <a name="BKMK_msdyn_OwnerIdName"></a> msdyn_OwnerIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_owneridname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_OwnerIdYomiName"></a> msdyn_OwnerIdYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_owneridyominame|
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

- [msdyn_fieldservicesystemjob_SyncErrors](#BKMK_msdyn_fieldservicesystemjob_SyncErrors)
- [msdyn_fieldservicesystemjob_AsyncOperations](#BKMK_msdyn_fieldservicesystemjob_AsyncOperations)
- [msdyn_fieldservicesystemjob_MailboxTrackingFolders](#BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders)
- [msdyn_fieldservicesystemjob_ProcessSession](#BKMK_msdyn_fieldservicesystemjob_ProcessSession)
- [msdyn_fieldservicesystemjob_BulkDeleteFailures](#BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures)
- [msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_fieldservicesystemjob_SyncErrors"></a> msdyn_fieldservicesystemjob_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_fieldservicesystemjob_SyncErrors](syncerror.md#BKMK_msdyn_fieldservicesystemjob_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesystemjob_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesystemjob_AsyncOperations"></a> msdyn_fieldservicesystemjob_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_fieldservicesystemjob_AsyncOperations](asyncoperation.md#BKMK_msdyn_fieldservicesystemjob_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesystemjob_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders"></a> msdyn_fieldservicesystemjob_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_fieldservicesystemjob_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesystemjob_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesystemjob_ProcessSession"></a> msdyn_fieldservicesystemjob_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_fieldservicesystemjob_ProcessSession](processsession.md#BKMK_msdyn_fieldservicesystemjob_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesystemjob_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures"></a> msdyn_fieldservicesystemjob_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_fieldservicesystemjob_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesystemjob_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_fieldservicesystemjob_createdby](#BKMK_lk_msdyn_fieldservicesystemjob_createdby)
- [lk_msdyn_fieldservicesystemjob_createdonbehalfby](#BKMK_lk_msdyn_fieldservicesystemjob_createdonbehalfby)
- [lk_msdyn_fieldservicesystemjob_modifiedby](#BKMK_lk_msdyn_fieldservicesystemjob_modifiedby)
- [lk_msdyn_fieldservicesystemjob_modifiedonbehalfby](#BKMK_lk_msdyn_fieldservicesystemjob_modifiedonbehalfby)
- [organization_msdyn_fieldservicesystemjob](#BKMK_organization_msdyn_fieldservicesystemjob)
- [msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId](#BKMK_msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId)


### <a name="BKMK_lk_msdyn_fieldservicesystemjob_createdby"></a> lk_msdyn_fieldservicesystemjob_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldservicesystemjob_createdby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesystemjob_createdonbehalfby"></a> lk_msdyn_fieldservicesystemjob_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldservicesystemjob_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesystemjob_modifiedby"></a> lk_msdyn_fieldservicesystemjob_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldservicesystemjob_modifiedby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesystemjob_modifiedonbehalfby"></a> lk_msdyn_fieldservicesystemjob_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldservicesystemjob_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_fieldservicesystemjob"></a> organization_msdyn_fieldservicesystemjob

**Added by**: System Solution Solution

See organization Entity [organization_msdyn_fieldservicesystemjob](organization.md#BKMK_organization_msdyn_fieldservicesystemjob) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId"></a> msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId

**Added by**: System Solution Solution

See systemuser Entity [msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId](systemuser.md#BKMK_msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_fieldservicesystemjob?text=msdyn_fieldservicesystemjob EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]