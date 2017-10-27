---
title: "msdyn_characteristicreqforteammember Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_characteristicreqforteammember entity."
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
# msdyn_characteristicreqforteammember Entity Reference

Characteristic requirement for team member

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers(*msdyn_characteristicreqforteammemberid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers(*msdyn_characteristicreqforteammemberid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers(*msdyn_characteristicreqforteammemberid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers(*msdyn_characteristicreqforteammemberid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_characteristicreqforteammembers(*msdyn_characteristicreqforteammemberid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Competency Requirement (Deprecated)<br />
**DisplayCollectionName**: Competency Requirements<br />
**SchemaName**: msdyn_characteristicreqforteammember<br />
**CollectionSchemaName**: msdyn_characteristicreqforteammembers<br />
**LogicalName**: msdyn_characteristicreqforteammember<br />
**LogicalCollectionName**: msdyn_characteristicreqforteammembers<br />
**EntitySetName**: msdyn_characteristicreqforteammembers<br />
**PrimaryIdAttribute**: msdyn_characteristicreqforteammemberid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Characteristic](#BKMK_msdyn_Characteristic)
- [msdyn_characteristicreqforteammemberId](#BKMK_msdyn_characteristicreqforteammemberId)
- [msdyn_characteristictype](#BKMK_msdyn_characteristictype)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ratingvalue](#BKMK_msdyn_ratingvalue)
- [msdyn_resourcerequirementid](#BKMK_msdyn_resourcerequirementid)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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


### <a name="BKMK_msdyn_Characteristic"></a> msdyn_Characteristic

**Description**: Select the characteristic required.<br />
**DisplayName**: Characteristic<br />
**LogicalName**: msdyn_characteristic<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: characteristic


### <a name="BKMK_msdyn_characteristicreqforteammemberId"></a> msdyn_characteristicreqforteammemberId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Characteristic requirement for team member<br />
**LogicalName**: msdyn_characteristicreqforteammemberid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_characteristictype"></a> msdyn_characteristictype

**Description**: Shows the skill type of this team member.<br />
**DisplayName**: Bookable Characteristic Type<br />
**LogicalName**: msdyn_characteristictype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 1 **Label**: Skill
- **Value**: 2 **Label**: Certification



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


### <a name="BKMK_msdyn_ratingvalue"></a> msdyn_ratingvalue

**Description**: Shows the proficiency in this skill for this team member.<br />
**DisplayName**: Rating Value<br />
**LogicalName**: msdyn_ratingvalue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: ratingvalue


### <a name="BKMK_msdyn_resourcerequirementid"></a> msdyn_resourcerequirementid

**Description**: Unique identifier for Resource Requirement associated with Competency Requirement.<br />
**DisplayName**: Resource Requirement<br />
**LogicalName**: msdyn_resourcerequirementid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_resourcerequirement


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


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Characteristic requirement for team member<br />
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

**Description**: Reason for the status of the Characteristic requirement for team member<br />
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
- [msdyn_CharacteristicName](#BKMK_msdyn_CharacteristicName)
- [msdyn_ratingvalueName](#BKMK_msdyn_ratingvalueName)
- [msdyn_resourcerequirementidName](#BKMK_msdyn_resourcerequirementidName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
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


### <a name="BKMK_msdyn_CharacteristicName"></a> msdyn_CharacteristicName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_characteristicname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ratingvalueName"></a> msdyn_ratingvalueName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_ratingvaluename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_resourcerequirementidName"></a> msdyn_resourcerequirementidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcerequirementidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Yomi name of the owner<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


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

- [msdyn_characteristicreqforteammember_SyncErrors](#BKMK_msdyn_characteristicreqforteammember_SyncErrors)
- [msdyn_characteristicreqforteammember_DuplicateMatchingRecord](#BKMK_msdyn_characteristicreqforteammember_DuplicateMatchingRecord)
- [msdyn_characteristicreqforteammember_DuplicateBaseRecord](#BKMK_msdyn_characteristicreqforteammember_DuplicateBaseRecord)
- [msdyn_characteristicreqforteammember_AsyncOperations](#BKMK_msdyn_characteristicreqforteammember_AsyncOperations)
- [msdyn_characteristicreqforteammember_MailboxTrackingFolders](#BKMK_msdyn_characteristicreqforteammember_MailboxTrackingFolders)
- [msdyn_characteristicreqforteammember_UserEntityInstanceDatas](#BKMK_msdyn_characteristicreqforteammember_UserEntityInstanceDatas)
- [msdyn_characteristicreqforteammember_ProcessSession](#BKMK_msdyn_characteristicreqforteammember_ProcessSession)
- [msdyn_characteristicreqforteammember_BulkDeleteFailures](#BKMK_msdyn_characteristicreqforteammember_BulkDeleteFailures)
- [msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses](#BKMK_msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses)
- [msdyn_characteristicreqforteammember_Annotations](#BKMK_msdyn_characteristicreqforteammember_Annotations)


### <a name="BKMK_msdyn_characteristicreqforteammember_SyncErrors"></a> msdyn_characteristicreqforteammember_SyncErrors

Same as syncerror entity [msdyn_characteristicreqforteammember_SyncErrors](syncerror.md#BKMK_msdyn_characteristicreqforteammember_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_characteristicreqforteammember_SyncErrors<br />
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


### <a name="BKMK_msdyn_characteristicreqforteammember_DuplicateMatchingRecord"></a> msdyn_characteristicreqforteammember_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_characteristicreqforteammember_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_characteristicreqforteammember_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_characteristicreqforteammember_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_characteristicreqforteammember_DuplicateBaseRecord"></a> msdyn_characteristicreqforteammember_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_characteristicreqforteammember_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_characteristicreqforteammember_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_characteristicreqforteammember_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_characteristicreqforteammember_AsyncOperations"></a> msdyn_characteristicreqforteammember_AsyncOperations

Same as asyncoperation entity [msdyn_characteristicreqforteammember_AsyncOperations](asyncoperation.md#BKMK_msdyn_characteristicreqforteammember_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_characteristicreqforteammember_AsyncOperations<br />
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


### <a name="BKMK_msdyn_characteristicreqforteammember_MailboxTrackingFolders"></a> msdyn_characteristicreqforteammember_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_characteristicreqforteammember_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_characteristicreqforteammember_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_characteristicreqforteammember_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_characteristicreqforteammember_UserEntityInstanceDatas"></a> msdyn_characteristicreqforteammember_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_characteristicreqforteammember_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_characteristicreqforteammember_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_characteristicreqforteammember_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_characteristicreqforteammember_ProcessSession"></a> msdyn_characteristicreqforteammember_ProcessSession

Same as processsession entity [msdyn_characteristicreqforteammember_ProcessSession](processsession.md#BKMK_msdyn_characteristicreqforteammember_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_characteristicreqforteammember_ProcessSession<br />
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


### <a name="BKMK_msdyn_characteristicreqforteammember_BulkDeleteFailures"></a> msdyn_characteristicreqforteammember_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_characteristicreqforteammember_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_characteristicreqforteammember_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_characteristicreqforteammember_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses"></a> msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_characteristicreqforteammember_Annotations"></a> msdyn_characteristicreqforteammember_Annotations

Same as annotation entity [msdyn_characteristicreqforteammember_Annotations](annotation.md#BKMK_msdyn_characteristicreqforteammember_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_characteristicreqforteammember_Annotations<br />
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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_characteristicreqforteammember_createdby](#BKMK_lk_msdyn_characteristicreqforteammember_createdby)
- [lk_msdyn_characteristicreqforteammember_createdonbehalfby](#BKMK_lk_msdyn_characteristicreqforteammember_createdonbehalfby)
- [lk_msdyn_characteristicreqforteammember_modifiedby](#BKMK_lk_msdyn_characteristicreqforteammember_modifiedby)
- [lk_msdyn_characteristicreqforteammember_modifiedonbehalfby](#BKMK_lk_msdyn_characteristicreqforteammember_modifiedonbehalfby)
- [user_msdyn_characteristicreqforteammember](#BKMK_user_msdyn_characteristicreqforteammember)
- [team_msdyn_characteristicreqforteammember](#BKMK_team_msdyn_characteristicreqforteammember)
- [business_unit_msdyn_characteristicreqforteammember](#BKMK_business_unit_msdyn_characteristicreqforteammember)
- [msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic](#BKMK_msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic)
- [msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue](#BKMK_msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue)
- [msdyn_resourcerequirement_characteristicreq](#BKMK_msdyn_resourcerequirement_characteristicreq)


### <a name="BKMK_lk_msdyn_characteristicreqforteammember_createdby"></a> lk_msdyn_characteristicreqforteammember_createdby

See systemuser Entity [lk_msdyn_characteristicreqforteammember_createdby](systemuser.md#BKMK_lk_msdyn_characteristicreqforteammember_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_characteristicreqforteammember_createdonbehalfby"></a> lk_msdyn_characteristicreqforteammember_createdonbehalfby

See systemuser Entity [lk_msdyn_characteristicreqforteammember_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_characteristicreqforteammember_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_characteristicreqforteammember_modifiedby"></a> lk_msdyn_characteristicreqforteammember_modifiedby

See systemuser Entity [lk_msdyn_characteristicreqforteammember_modifiedby](systemuser.md#BKMK_lk_msdyn_characteristicreqforteammember_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_characteristicreqforteammember_modifiedonbehalfby"></a> lk_msdyn_characteristicreqforteammember_modifiedonbehalfby

See systemuser Entity [lk_msdyn_characteristicreqforteammember_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_characteristicreqforteammember_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_characteristicreqforteammember"></a> user_msdyn_characteristicreqforteammember

See systemuser Entity [user_msdyn_characteristicreqforteammember](systemuser.md#BKMK_user_msdyn_characteristicreqforteammember) One-To-Many relationship.

### <a name="BKMK_team_msdyn_characteristicreqforteammember"></a> team_msdyn_characteristicreqforteammember

See team Entity [team_msdyn_characteristicreqforteammember](team.md#BKMK_team_msdyn_characteristicreqforteammember) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_characteristicreqforteammember"></a> business_unit_msdyn_characteristicreqforteammember

See businessunit Entity [business_unit_msdyn_characteristicreqforteammember](businessunit.md#BKMK_business_unit_msdyn_characteristicreqforteammember) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic"></a> msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic

See characteristic Entity [msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic](characteristic.md#BKMK_msdyn_characteristic_msdyn_characteristicreqforteammember_characteristic) One-To-Many relationship.

### <a name="BKMK_msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue"></a> msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue

See ratingvalue Entity [msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue](ratingvalue.md#BKMK_msdyn_ratingvalue_msdyn_characteristicreqforteammember_ratingvalue) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_characteristicreq"></a> msdyn_resourcerequirement_characteristicreq

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_characteristicreq](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_characteristicreq) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_characteristicreqforteammember?text=msdyn_characteristicreqforteammember EntityType" />