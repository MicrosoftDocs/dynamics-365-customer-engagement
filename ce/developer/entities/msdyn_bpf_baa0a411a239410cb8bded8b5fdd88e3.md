---
title: "msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 entity."
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
# msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Base entity for process Agreement Business Process

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3s<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3s(*businessprocessflowinstanceid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3s(*businessprocessflowinstanceid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3s<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3s(*businessprocessflowinstanceid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3s(*businessprocessflowinstanceid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Agreement Business Process<br />
**DisplayCollectionName**: Agreement Business Process<br />
**SchemaName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3<br />
**CollectionSchemaName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3s<br />
**LogicalName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3<br />
**LogicalCollectionName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3s<br />
**EntitySetName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3s<br />
**PrimaryIdAttribute**: businessprocessflowinstanceid<br />
**PrimaryNameAttribute**: bpf_name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: True<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ActiveStageId](#BKMK_ActiveStageId)
- [ActiveStageStartedOn](#BKMK_ActiveStageStartedOn)
- [bpf_msdyn_agreementbookingsetupid](#BKMK_bpf_msdyn_agreementbookingsetupid)
- [bpf_msdyn_agreementid](#BKMK_bpf_msdyn_agreementid)
- [bpf_msdyn_agreementinvoicesetupid](#BKMK_bpf_msdyn_agreementinvoicesetupid)
- [bpf_name](#BKMK_bpf_name)
- [BusinessProcessFlowInstanceId](#BKMK_BusinessProcessFlowInstanceId)
- [CompletedOn](#BKMK_CompletedOn)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [ProcessId](#BKMK_ProcessId)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TraversedPath](#BKMK_TraversedPath)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_ActiveStageId"></a> ActiveStageId

**Description**: Unique identifier of the active stage for the Business Process Flow instance.<br />
**DisplayName**: Active Stage<br />
**LogicalName**: activestageid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: processstage


### <a name="BKMK_ActiveStageStartedOn"></a> ActiveStageStartedOn

**Description**: Date and time when current active stage is started<br />
**DisplayName**: Active Stage Started On<br />
**LogicalName**: activestagestartedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_bpf_msdyn_agreementbookingsetupid"></a> bpf_msdyn_agreementbookingsetupid

**Description**: <br />
**DisplayName**: Msdyn_Agreementbookingsetup<br />
**LogicalName**: bpf_msdyn_agreementbookingsetupid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementbookingsetup


### <a name="BKMK_bpf_msdyn_agreementid"></a> bpf_msdyn_agreementid

**Description**: <br />
**DisplayName**: Msdyn_Agreement<br />
**LogicalName**: bpf_msdyn_agreementid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreement


### <a name="BKMK_bpf_msdyn_agreementinvoicesetupid"></a> bpf_msdyn_agreementinvoicesetupid

**Description**: <br />
**DisplayName**: Msdyn_Agreementinvoicesetup<br />
**LogicalName**: bpf_msdyn_agreementinvoicesetupid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_agreementinvoicesetup


### <a name="BKMK_bpf_name"></a> bpf_name

**Description**: Description<br />
**DisplayName**: Name<br />
**LogicalName**: bpf_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_BusinessProcessFlowInstanceId"></a> BusinessProcessFlowInstanceId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Agreement Business Process<br />
**LogicalName**: businessprocessflowinstanceid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_CompletedOn"></a> CompletedOn

**Description**: Date and time when Business Process Flow instance is completed.<br />
**DisplayName**: Completed On<br />
**LogicalName**: completedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


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


### <a name="BKMK_ProcessId"></a> ProcessId

**Description**: Unique identifier of the workflow associated to the Business Process Flow instance.<br />
**DisplayName**: Process<br />
**LogicalName**: processid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: workflow


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Agreement Business Process<br />
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

**Description**: Reason for the status of the Agreement Business Process<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Finished **State**: 1
- **Value**: 3 **Label**: Aborted **State**: 1



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


### <a name="BKMK_TraversedPath"></a> TraversedPath

**Description**: Comma delimited string of process stage ids that represent visited stages of the Business Process Flow instance.<br />
**DisplayName**: Traversed Path<br />
**LogicalName**: traversedpath<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1250


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

- [ActiveStageIdName](#BKMK_ActiveStageIdName)
- [bpf_Duration](#BKMK_bpf_Duration)
- [bpf_msdyn_agreementbookingsetupidName](#BKMK_bpf_msdyn_agreementbookingsetupidName)
- [bpf_msdyn_agreementidName](#BKMK_bpf_msdyn_agreementidName)
- [bpf_msdyn_agreementinvoicesetupidName](#BKMK_bpf_msdyn_agreementinvoicesetupidName)
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
- [ProcessIdName](#BKMK_ProcessIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_ActiveStageIdName"></a> ActiveStageIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: activestageidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_bpf_Duration"></a> bpf_Duration

**Description**: Duration of Business Process Flow<br />
**DisplayName**: Duration<br />
**LogicalName**: bpf_duration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_bpf_msdyn_agreementbookingsetupidName"></a> bpf_msdyn_agreementbookingsetupidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: bpf_msdyn_agreementbookingsetupidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_bpf_msdyn_agreementidName"></a> bpf_msdyn_agreementidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: bpf_msdyn_agreementidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_bpf_msdyn_agreementinvoicesetupidName"></a> bpf_msdyn_agreementinvoicesetupidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: bpf_msdyn_agreementinvoicesetupidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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


### <a name="BKMK_ProcessIdName"></a> ProcessIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: processidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
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

- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_UserEntityInstanceDatas](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_UserEntityInstanceDatas)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses)


### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors

Same as syncerror entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors](syncerror.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_SyncErrors<br />
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


### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations

Same as asyncoperation entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations](asyncoperation.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_AsyncOperations<br />
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


### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs

Same as workflowlog entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs](workflowlog.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs) Many-To-One relationship.

**ReferencingEntity**: workflowlog<br />
**ReferencingAttribute**: asyncoperationid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_WorkflowLogs<br />
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


### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_UserEntityInstanceDatas"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession

Same as processsession entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession](processsession.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_ProcessSession<br />
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


### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses<br />
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

- [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdby](#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdby)
- [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdonbehalfby](#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdonbehalfby)
- [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedby](#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedby)
- [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedonbehalfby](#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedonbehalfby)
- [organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](#BKMK_organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)
- [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid](#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid)
- [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid](#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid)
- [bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](#BKMK_bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)
- [bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](#BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)
- [bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](#BKMK_bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)


### <a name="BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdby"></a> lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdby

See systemuser Entity [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdby](systemuser.md#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdonbehalfby"></a> lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdonbehalfby

See systemuser Entity [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedby"></a> lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedby

See systemuser Entity [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedby](systemuser.md#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedonbehalfby"></a> lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedonbehalfby

See systemuser Entity [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

See organization Entity [organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](organization.md#BKMK_organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid"></a> lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid

See processstage Entity [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid](processstage.md#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_activestageid) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid"></a> lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid

See workflow Entity [lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid](workflow.md#BKMK_lk_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_processid) One-To-Many relationship.

### <a name="BKMK_bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

See msdyn_agreement Entity [bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](msdyn_agreement.md#BKMK_bpf_msdyn_agreement_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3) One-To-Many relationship.

### <a name="BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

See msdyn_agreementbookingsetup Entity [bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](msdyn_agreementbookingsetup.md#BKMK_bpf_msdyn_agreementbookingsetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3) One-To-Many relationship.

### <a name="BKMK_bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

See msdyn_agreementinvoicesetup Entity [bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](msdyn_agreementinvoicesetup.md#BKMK_bpf_msdyn_agreementinvoicesetup_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3?text=msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 EntityType" />