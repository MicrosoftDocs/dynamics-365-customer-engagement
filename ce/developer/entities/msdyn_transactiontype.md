---
title: "msdyn_transactiontype Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_transactiontype entity."
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
# msdyn_transactiontype Entity Reference

Broad classification, such as time or expense, and the context such cost, unbilled revenue, or billed revenue of a project actual.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_transactiontypes<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_transactiontypes(*msdyn_transactiontypeid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_transactiontypes(*msdyn_transactiontypeid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_transactiontypes<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_transactiontypes(*msdyn_transactiontypeid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_transactiontypes(*msdyn_transactiontypeid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Transaction Type<br />
**DisplayCollectionName**: Transaction Types<br />
**SchemaName**: msdyn_transactiontype<br />
**CollectionSchemaName**: msdyn_transactiontypes<br />
**LogicalName**: msdyn_transactiontype<br />
**LogicalCollectionName**: msdyn_transactiontypes<br />
**EntitySetName**: msdyn_transactiontypes<br />
**PrimaryIdAttribute**: msdyn_transactiontypeid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_DefaultUnit](#BKMK_msdyn_DefaultUnit)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
- [msdyn_TransactionTypeCode](#BKMK_msdyn_TransactionTypeCode)
- [msdyn_transactiontypeId](#BKMK_msdyn_transactiontypeId)
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

**Description**: The name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

**Description**: <br />
**DisplayName**: Transaction Classification<br />
**LogicalName**: msdyn_transactionclassification<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Time
- **Value**: 192350001 **Label**: Expense
- **Value**: 192350002 **Label**: Material
- **Value**: 192350003 **Label**: Milestone
- **Value**: 192350004 **Label**: Fee
- **Value**: 690970000 **Label**: Commission
- **Value**: 690970001 **Label**: Additional
- **Value**: 690970002 **Label**: Tax



### <a name="BKMK_msdyn_TransactionTypeCode"></a> msdyn_TransactionTypeCode

**Description**: The code of the transaction type.<br />
**DisplayName**: Transaction Type Code<br />
**LogicalName**: msdyn_transactiontypecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Cost
- **Value**: 192350004 **Label**: Project Contract
- **Value**: 192350005 **Label**: Unbilled Sales
- **Value**: 192350006 **Label**: Billed Sales
- **Value**: 192350007 **Label**: Resourcing Unit Cost
- **Value**: 192350008 **Label**: Inter-Organizational Sales



### <a name="BKMK_msdyn_transactiontypeId"></a> msdyn_transactiontypeId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Transaction Type Id<br />
**LogicalName**: msdyn_transactiontypeid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_UnitGroup"></a> msdyn_UnitGroup

**Description**: <br />
**DisplayName**: Unit Group<br />
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

**Description**: Status of the Transaction Type<br />
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

**Description**: Reason for the status of the Transaction Type<br />
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

- [msdyn_transactiontype_SyncErrors](#BKMK_msdyn_transactiontype_SyncErrors)
- [msdyn_transactiontype_DuplicateMatchingRecord](#BKMK_msdyn_transactiontype_DuplicateMatchingRecord)
- [msdyn_transactiontype_DuplicateBaseRecord](#BKMK_msdyn_transactiontype_DuplicateBaseRecord)
- [msdyn_transactiontype_AsyncOperations](#BKMK_msdyn_transactiontype_AsyncOperations)
- [msdyn_transactiontype_MailboxTrackingFolders](#BKMK_msdyn_transactiontype_MailboxTrackingFolders)
- [msdyn_transactiontype_UserEntityInstanceDatas](#BKMK_msdyn_transactiontype_UserEntityInstanceDatas)
- [msdyn_transactiontype_ProcessSession](#BKMK_msdyn_transactiontype_ProcessSession)
- [msdyn_transactiontype_BulkDeleteFailures](#BKMK_msdyn_transactiontype_BulkDeleteFailures)
- [msdyn_transactiontype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactiontype_PrincipalObjectAttributeAccesses)
- [msdyn_transactiontype_Annotations](#BKMK_msdyn_transactiontype_Annotations)


### <a name="BKMK_msdyn_transactiontype_SyncErrors"></a> msdyn_transactiontype_SyncErrors

Same as syncerror entity [msdyn_transactiontype_SyncErrors](syncerror.md#BKMK_msdyn_transactiontype_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactiontype_SyncErrors<br />
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


### <a name="BKMK_msdyn_transactiontype_DuplicateMatchingRecord"></a> msdyn_transactiontype_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_transactiontype_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_transactiontype_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactiontype_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_transactiontype_DuplicateBaseRecord"></a> msdyn_transactiontype_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_transactiontype_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_transactiontype_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactiontype_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_transactiontype_AsyncOperations"></a> msdyn_transactiontype_AsyncOperations

Same as asyncoperation entity [msdyn_transactiontype_AsyncOperations](asyncoperation.md#BKMK_msdyn_transactiontype_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactiontype_AsyncOperations<br />
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


### <a name="BKMK_msdyn_transactiontype_MailboxTrackingFolders"></a> msdyn_transactiontype_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_transactiontype_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_transactiontype_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactiontype_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_transactiontype_UserEntityInstanceDatas"></a> msdyn_transactiontype_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_transactiontype_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_transactiontype_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactiontype_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_transactiontype_ProcessSession"></a> msdyn_transactiontype_ProcessSession

Same as processsession entity [msdyn_transactiontype_ProcessSession](processsession.md#BKMK_msdyn_transactiontype_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactiontype_ProcessSession<br />
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


### <a name="BKMK_msdyn_transactiontype_BulkDeleteFailures"></a> msdyn_transactiontype_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_transactiontype_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_transactiontype_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactiontype_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_transactiontype_PrincipalObjectAttributeAccesses"></a> msdyn_transactiontype_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_transactiontype_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_transactiontype_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactiontype_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_transactiontype_Annotations"></a> msdyn_transactiontype_Annotations

Same as annotation entity [msdyn_transactiontype_Annotations](annotation.md#BKMK_msdyn_transactiontype_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_transactiontype_Annotations<br />
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

- [lk_msdyn_transactiontype_createdby](#BKMK_lk_msdyn_transactiontype_createdby)
- [lk_msdyn_transactiontype_createdonbehalfby](#BKMK_lk_msdyn_transactiontype_createdonbehalfby)
- [lk_msdyn_transactiontype_modifiedby](#BKMK_lk_msdyn_transactiontype_modifiedby)
- [lk_msdyn_transactiontype_modifiedonbehalfby](#BKMK_lk_msdyn_transactiontype_modifiedonbehalfby)
- [organization_msdyn_transactiontype](#BKMK_organization_msdyn_transactiontype)
- [msdyn_uom_msdyn_transactiontype_DefaultUnit](#BKMK_msdyn_uom_msdyn_transactiontype_DefaultUnit)
- [msdyn_uomschedule_msdyn_transactiontype_UnitGroup](#BKMK_msdyn_uomschedule_msdyn_transactiontype_UnitGroup)


### <a name="BKMK_lk_msdyn_transactiontype_createdby"></a> lk_msdyn_transactiontype_createdby

See systemuser Entity [lk_msdyn_transactiontype_createdby](systemuser.md#BKMK_lk_msdyn_transactiontype_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactiontype_createdonbehalfby"></a> lk_msdyn_transactiontype_createdonbehalfby

See systemuser Entity [lk_msdyn_transactiontype_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_transactiontype_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactiontype_modifiedby"></a> lk_msdyn_transactiontype_modifiedby

See systemuser Entity [lk_msdyn_transactiontype_modifiedby](systemuser.md#BKMK_lk_msdyn_transactiontype_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_transactiontype_modifiedonbehalfby"></a> lk_msdyn_transactiontype_modifiedonbehalfby

See systemuser Entity [lk_msdyn_transactiontype_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_transactiontype_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_transactiontype"></a> organization_msdyn_transactiontype

See organization Entity [organization_msdyn_transactiontype](organization.md#BKMK_organization_msdyn_transactiontype) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_transactiontype_DefaultUnit"></a> msdyn_uom_msdyn_transactiontype_DefaultUnit

See uom Entity [msdyn_uom_msdyn_transactiontype_DefaultUnit](uom.md#BKMK_msdyn_uom_msdyn_transactiontype_DefaultUnit) One-To-Many relationship.

### <a name="BKMK_msdyn_uomschedule_msdyn_transactiontype_UnitGroup"></a> msdyn_uomschedule_msdyn_transactiontype_UnitGroup

See uomschedule Entity [msdyn_uomschedule_msdyn_transactiontype_UnitGroup](uomschedule.md#BKMK_msdyn_uomschedule_msdyn_transactiontype_UnitGroup) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_transactiontype?text=msdyn_transactiontype EntityType" />