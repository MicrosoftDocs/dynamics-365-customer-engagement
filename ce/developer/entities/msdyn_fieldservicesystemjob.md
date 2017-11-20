---
title: "msdyn_fieldservicesystemjob Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_fieldservicesystemjob entity."
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
# msdyn_fieldservicesystemjob Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

An internal entity used to track field service system jobs.

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicesystemjobs(*msdyn_fieldservicesystemjobid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Field Service System Job<br />
**DisplayCollectionName**: Field Service System Jobs<br />
**SchemaName**: msdyn_fieldservicesystemjob<br />
**CollectionSchemaName**: msdyn_fieldservicesystemjobs<br />
**LogicalName**: msdyn_fieldservicesystemjob<br />
**LogicalCollectionName**: msdyn_fieldservicesystemjobs<br />
**EntitySetName**: msdyn_fieldservicesystemjobs<br />
**PrimaryIdAttribute**: msdyn_fieldservicesystemjobid<br />
**PrimaryNameAttribute**: msdyn_jobname<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
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

**Description**: Shows the sequence number of the import that created this record.<br />
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


### <a name="BKMK_msdyn_ConditionCode"></a> msdyn_ConditionCode

**Description**: <br />
**DisplayName**: Condition Code<br />
**LogicalName**: msdyn_conditioncode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_ExceptionMessage"></a> msdyn_ExceptionMessage

**Description**: <br />
**DisplayName**: Exception Message<br />
**LogicalName**: msdyn_exceptionmessage<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1024


### <a name="BKMK_msdyn_ExceptionTrace"></a> msdyn_ExceptionTrace

**Description**: <br />
**DisplayName**: Exception Trace<br />
**LogicalName**: msdyn_exceptiontrace<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_fieldservicesystemjobId"></a> msdyn_fieldservicesystemjobId

**Description**: Shows the entity instances.<br />
**DisplayName**: Field Service System Job<br />
**LogicalName**: msdyn_fieldservicesystemjobid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_InputParameter"></a> msdyn_InputParameter

**Description**: <br />
**DisplayName**: Input Parameter<br />
**LogicalName**: msdyn_inputparameter<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_InputParameterType"></a> msdyn_InputParameterType

**Description**: <br />
**DisplayName**: Input Parameter Type<br />
**LogicalName**: msdyn_inputparametertype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: String List
- **Value**: 690970001 **Label**: Json
- **Value**: 690970002 **Label**: Xml



### <a name="BKMK_msdyn_jobname"></a> msdyn_jobname

**Description**: Type a name for the job.<br />
**DisplayName**: Type a name for the job.<br />
**LogicalName**: msdyn_jobname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1024


### <a name="BKMK_msdyn_JobStatus"></a> msdyn_JobStatus

**Description**: Enter the status of the job.<br />
**DisplayName**: Job Status<br />
**LogicalName**: msdyn_jobstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Pending
- **Value**: 690970001 **Label**: In Progress
- **Value**: 690970002 **Label**: Completed
- **Value**: 690970003 **Label**: Failed



### <a name="BKMK_msdyn_JobType"></a> msdyn_JobType

**Description**: <br />
**DisplayName**: Job Type<br />
**LogicalName**: msdyn_jobtype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_OutputParameter"></a> msdyn_OutputParameter

**Description**: <br />
**DisplayName**: Output Parameter<br />
**LogicalName**: msdyn_outputparameter<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_OutputParameterType"></a> msdyn_OutputParameterType

**Description**: <br />
**DisplayName**: Output Parameter Type<br />
**LogicalName**: msdyn_outputparametertype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: String List
- **Value**: 690970001 **Label**: Json
- **Value**: 690970002 **Label**: Xml



### <a name="BKMK_msdyn_OwnerId"></a> msdyn_OwnerId

**Description**: Shows the user associated with the field service system job.<br />
**DisplayName**: Owner<br />
**LogicalName**: msdyn_ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Shows the date and time that the record was migrated.<br />
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

**Description**: Status of the Field Service System Job<br />
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

**Description**: Shows the reason for the status of the field service system job.<br />
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

**Description**: Shows the time zone code that was in use when the record was created.<br />
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
- [msdyn_OwnerIdName](#BKMK_msdyn_OwnerIdName)
- [msdyn_OwnerIdYomiName](#BKMK_msdyn_OwnerIdYomiName)
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

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
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

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
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


### <a name="BKMK_msdyn_OwnerIdName"></a> msdyn_OwnerIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_OwnerIdYomiName"></a> msdyn_OwnerIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_owneridyominame<br />
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

- [msdyn_fieldservicesystemjob_SyncErrors](#BKMK_msdyn_fieldservicesystemjob_SyncErrors)
- [msdyn_fieldservicesystemjob_AsyncOperations](#BKMK_msdyn_fieldservicesystemjob_AsyncOperations)
- [msdyn_fieldservicesystemjob_MailboxTrackingFolders](#BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders)
- [msdyn_fieldservicesystemjob_UserEntityInstanceDatas](#BKMK_msdyn_fieldservicesystemjob_UserEntityInstanceDatas)
- [msdyn_fieldservicesystemjob_ProcessSession](#BKMK_msdyn_fieldservicesystemjob_ProcessSession)
- [msdyn_fieldservicesystemjob_BulkDeleteFailures](#BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures)
- [msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_fieldservicesystemjob_SyncErrors"></a> msdyn_fieldservicesystemjob_SyncErrors

Same as syncerror entity [msdyn_fieldservicesystemjob_SyncErrors](syncerror.md#BKMK_msdyn_fieldservicesystemjob_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesystemjob_SyncErrors<br />
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


### <a name="BKMK_msdyn_fieldservicesystemjob_AsyncOperations"></a> msdyn_fieldservicesystemjob_AsyncOperations

Same as asyncoperation entity [msdyn_fieldservicesystemjob_AsyncOperations](asyncoperation.md#BKMK_msdyn_fieldservicesystemjob_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesystemjob_AsyncOperations<br />
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


### <a name="BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders"></a> msdyn_fieldservicesystemjob_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_fieldservicesystemjob_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesystemjob_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_fieldservicesystemjob_UserEntityInstanceDatas"></a> msdyn_fieldservicesystemjob_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_fieldservicesystemjob_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_fieldservicesystemjob_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesystemjob_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_fieldservicesystemjob_ProcessSession"></a> msdyn_fieldservicesystemjob_ProcessSession

Same as processsession entity [msdyn_fieldservicesystemjob_ProcessSession](processsession.md#BKMK_msdyn_fieldservicesystemjob_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesystemjob_ProcessSession<br />
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


### <a name="BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures"></a> msdyn_fieldservicesystemjob_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_fieldservicesystemjob_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesystemjob_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses<br />
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

See systemuser Entity [lk_msdyn_fieldservicesystemjob_createdby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesystemjob_createdonbehalfby"></a> lk_msdyn_fieldservicesystemjob_createdonbehalfby

See systemuser Entity [lk_msdyn_fieldservicesystemjob_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesystemjob_modifiedby"></a> lk_msdyn_fieldservicesystemjob_modifiedby

See systemuser Entity [lk_msdyn_fieldservicesystemjob_modifiedby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesystemjob_modifiedonbehalfby"></a> lk_msdyn_fieldservicesystemjob_modifiedonbehalfby

See systemuser Entity [lk_msdyn_fieldservicesystemjob_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicesystemjob_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_fieldservicesystemjob"></a> organization_msdyn_fieldservicesystemjob

See organization Entity [organization_msdyn_fieldservicesystemjob](organization.md#BKMK_organization_msdyn_fieldservicesystemjob) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId"></a> msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId

See systemuser Entity [msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId](systemuser.md#BKMK_msdyn_systemuser_msdyn_fieldservicesystemjob_OwnerId) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_fieldservicesystemjob?text=msdyn_fieldservicesystemjob EntityType" />