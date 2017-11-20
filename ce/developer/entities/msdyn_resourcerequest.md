---
title: "msdyn_resourcerequest Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_resourcerequest entity."
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
# msdyn_resourcerequest Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Entity that wraps the resource requirement to capture the type of resources, skills, and location required.

**Added by**: Project Service Automation Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_resourcerequests(*msdyn_resourcerequestid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_resourcerequests<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_resourcerequests(*msdyn_resourcerequestid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_resourcerequests(*msdyn_resourcerequestid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_resourcerequests<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_resourcerequests(*msdyn_resourcerequestid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_resourcerequests(*msdyn_resourcerequestid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Resource Request<br />
**DisplayCollectionName**: Resource Requests<br />
**SchemaName**: msdyn_resourcerequest<br />
**CollectionSchemaName**: msdyn_resourcerequests<br />
**LogicalName**: msdyn_resourcerequest<br />
**LogicalCollectionName**: msdyn_resourcerequests<br />
**EntitySetName**: msdyn_resourcerequests<br />
**PrimaryIdAttribute**: msdyn_resourcerequestid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_claimedby](#BKMK_msdyn_claimedby)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_positiondescription](#BKMK_msdyn_positiondescription)
- [msdyn_requestedby](#BKMK_msdyn_requestedby)
- [msdyn_resourcerequestId](#BKMK_msdyn_resourcerequestId)
- [msdyn_resourcerequirementid](#BKMK_msdyn_resourcerequirementid)
- [msdyn_roleid](#BKMK_msdyn_roleid)
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


### <a name="BKMK_msdyn_claimedby"></a> msdyn_claimedby

**Description**: Select the user who claimed the request.<br />
**DisplayName**: Claimed By<br />
**LogicalName**: msdyn_claimedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Type the name of the custom entity.<br />
**DisplayName**: Entity Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_positiondescription"></a> msdyn_positiondescription

**Description**: Shows the position description of the related project team member position.<br />
**DisplayName**: Position Description<br />
**LogicalName**: msdyn_positiondescription<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_requestedby"></a> msdyn_requestedby

**Description**: Select the user submitting the request.<br />
**DisplayName**: Requested By<br />
**LogicalName**: msdyn_requestedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_msdyn_resourcerequestId"></a> msdyn_resourcerequestId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Resource Request<br />
**LogicalName**: msdyn_resourcerequestid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_resourcerequirementid"></a> msdyn_resourcerequirementid

**Description**: Unique identifier of the resource requirement for the resource request.<br />
**DisplayName**: Resource Requirement<br />
**LogicalName**: msdyn_resourcerequirementid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_resourcerequirement


### <a name="BKMK_msdyn_roleid"></a> msdyn_roleid

**Description**: Primary role id in resource requirement<br />
**DisplayName**: Role<br />
**LogicalName**: msdyn_roleid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookableresourcecategory


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

**Description**: Status of the Resource Request<br />
**DisplayName**: State<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 192350000 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 192350007 **InvariantName**: Inactive



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Resource Request<br />
**DisplayName**: Status<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 192350000 **Label**: Submitted **State**: 0
- **Value**: 192350003 **Label**: Proposed **State**: 0
- **Value**: 192350008 **Label**: Fulfilled **State**: 1
- **Value**: 192350009 **Label**: In Progress **State**: 0



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
- [msdyn_claimedbyName](#BKMK_msdyn_claimedbyName)
- [msdyn_claimedbyYomiName](#BKMK_msdyn_claimedbyYomiName)
- [msdyn_requestedbyName](#BKMK_msdyn_requestedbyName)
- [msdyn_requestedbyYomiName](#BKMK_msdyn_requestedbyYomiName)
- [msdyn_resourcerequirementidName](#BKMK_msdyn_resourcerequirementidName)
- [msdyn_roleidName](#BKMK_msdyn_roleidName)
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


### <a name="BKMK_msdyn_claimedbyName"></a> msdyn_claimedbyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_claimedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_claimedbyYomiName"></a> msdyn_claimedbyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_claimedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_requestedbyName"></a> msdyn_requestedbyName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_requestedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_requestedbyYomiName"></a> msdyn_requestedbyYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_requestedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


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


### <a name="BKMK_msdyn_roleidName"></a> msdyn_roleidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_roleidname<br />
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

- [msdyn_resourcerequest_SyncErrors](#BKMK_msdyn_resourcerequest_SyncErrors)
- [msdyn_resourcerequest_DuplicateMatchingRecord](#BKMK_msdyn_resourcerequest_DuplicateMatchingRecord)
- [msdyn_resourcerequest_DuplicateBaseRecord](#BKMK_msdyn_resourcerequest_DuplicateBaseRecord)
- [msdyn_resourcerequest_AsyncOperations](#BKMK_msdyn_resourcerequest_AsyncOperations)
- [msdyn_resourcerequest_MailboxTrackingFolders](#BKMK_msdyn_resourcerequest_MailboxTrackingFolders)
- [msdyn_resourcerequest_UserEntityInstanceDatas](#BKMK_msdyn_resourcerequest_UserEntityInstanceDatas)
- [msdyn_resourcerequest_ProcessSession](#BKMK_msdyn_resourcerequest_ProcessSession)
- [msdyn_resourcerequest_BulkDeleteFailures](#BKMK_msdyn_resourcerequest_BulkDeleteFailures)
- [msdyn_resourcerequest_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcerequest_PrincipalObjectAttributeAccesses)
- [msdyn_resourcerequest_QueueItems](#BKMK_msdyn_resourcerequest_QueueItems)
- [msdyn_resourcerequest_Annotations](#BKMK_msdyn_resourcerequest_Annotations)


### <a name="BKMK_msdyn_resourcerequest_SyncErrors"></a> msdyn_resourcerequest_SyncErrors

Same as syncerror entity [msdyn_resourcerequest_SyncErrors](syncerror.md#BKMK_msdyn_resourcerequest_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcerequest_SyncErrors<br />
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


### <a name="BKMK_msdyn_resourcerequest_DuplicateMatchingRecord"></a> msdyn_resourcerequest_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_resourcerequest_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_resourcerequest_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcerequest_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_resourcerequest_DuplicateBaseRecord"></a> msdyn_resourcerequest_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_resourcerequest_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_resourcerequest_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcerequest_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_resourcerequest_AsyncOperations"></a> msdyn_resourcerequest_AsyncOperations

Same as asyncoperation entity [msdyn_resourcerequest_AsyncOperations](asyncoperation.md#BKMK_msdyn_resourcerequest_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcerequest_AsyncOperations<br />
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


### <a name="BKMK_msdyn_resourcerequest_MailboxTrackingFolders"></a> msdyn_resourcerequest_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_resourcerequest_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_resourcerequest_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcerequest_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_resourcerequest_UserEntityInstanceDatas"></a> msdyn_resourcerequest_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_resourcerequest_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_resourcerequest_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcerequest_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_resourcerequest_ProcessSession"></a> msdyn_resourcerequest_ProcessSession

Same as processsession entity [msdyn_resourcerequest_ProcessSession](processsession.md#BKMK_msdyn_resourcerequest_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcerequest_ProcessSession<br />
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


### <a name="BKMK_msdyn_resourcerequest_BulkDeleteFailures"></a> msdyn_resourcerequest_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_resourcerequest_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_resourcerequest_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcerequest_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_resourcerequest_PrincipalObjectAttributeAccesses"></a> msdyn_resourcerequest_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_resourcerequest_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_resourcerequest_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcerequest_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_resourcerequest_QueueItems"></a> msdyn_resourcerequest_QueueItems

Same as queueitem entity [msdyn_resourcerequest_QueueItems](queueitem.md#BKMK_msdyn_resourcerequest_QueueItems) Many-To-One relationship.

**ReferencingEntity**: queueitem<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcerequest_QueueItems<br />
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


### <a name="BKMK_msdyn_resourcerequest_Annotations"></a> msdyn_resourcerequest_Annotations

Same as annotation entity [msdyn_resourcerequest_Annotations](annotation.md#BKMK_msdyn_resourcerequest_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_resourcerequest_Annotations<br />
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

- [lk_msdyn_resourcerequest_createdby](#BKMK_lk_msdyn_resourcerequest_createdby)
- [lk_msdyn_resourcerequest_createdonbehalfby](#BKMK_lk_msdyn_resourcerequest_createdonbehalfby)
- [lk_msdyn_resourcerequest_modifiedby](#BKMK_lk_msdyn_resourcerequest_modifiedby)
- [lk_msdyn_resourcerequest_modifiedonbehalfby](#BKMK_lk_msdyn_resourcerequest_modifiedonbehalfby)
- [user_msdyn_resourcerequest](#BKMK_user_msdyn_resourcerequest)
- [team_msdyn_resourcerequest](#BKMK_team_msdyn_resourcerequest)
- [business_unit_msdyn_resourcerequest](#BKMK_business_unit_msdyn_resourcerequest)
- [msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid](#BKMK_msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid)
- [msdyn_resourcerequirement_request](#BKMK_msdyn_resourcerequirement_request)
- [msdyn_systemuser_msdyn_resourcerequest_claimedby](#BKMK_msdyn_systemuser_msdyn_resourcerequest_claimedby)
- [msdyn_systemuser_msdyn_resourcerequest_requestedby](#BKMK_msdyn_systemuser_msdyn_resourcerequest_requestedby)


### <a name="BKMK_lk_msdyn_resourcerequest_createdby"></a> lk_msdyn_resourcerequest_createdby

See systemuser Entity [lk_msdyn_resourcerequest_createdby](systemuser.md#BKMK_lk_msdyn_resourcerequest_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcerequest_createdonbehalfby"></a> lk_msdyn_resourcerequest_createdonbehalfby

See systemuser Entity [lk_msdyn_resourcerequest_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_resourcerequest_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcerequest_modifiedby"></a> lk_msdyn_resourcerequest_modifiedby

See systemuser Entity [lk_msdyn_resourcerequest_modifiedby](systemuser.md#BKMK_lk_msdyn_resourcerequest_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_resourcerequest_modifiedonbehalfby"></a> lk_msdyn_resourcerequest_modifiedonbehalfby

See systemuser Entity [lk_msdyn_resourcerequest_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_resourcerequest_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_resourcerequest"></a> user_msdyn_resourcerequest

See systemuser Entity [user_msdyn_resourcerequest](systemuser.md#BKMK_user_msdyn_resourcerequest) One-To-Many relationship.

### <a name="BKMK_team_msdyn_resourcerequest"></a> team_msdyn_resourcerequest

See team Entity [team_msdyn_resourcerequest](team.md#BKMK_team_msdyn_resourcerequest) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_resourcerequest"></a> business_unit_msdyn_resourcerequest

See businessunit Entity [business_unit_msdyn_resourcerequest](businessunit.md#BKMK_business_unit_msdyn_resourcerequest) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid"></a> msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_request"></a> msdyn_resourcerequirement_request

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_request](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_request) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_resourcerequest_claimedby"></a> msdyn_systemuser_msdyn_resourcerequest_claimedby

See systemuser Entity [msdyn_systemuser_msdyn_resourcerequest_claimedby](systemuser.md#BKMK_msdyn_systemuser_msdyn_resourcerequest_claimedby) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_resourcerequest_requestedby"></a> msdyn_systemuser_msdyn_resourcerequest_requestedby

See systemuser Entity [msdyn_systemuser_msdyn_resourcerequest_requestedby](systemuser.md#BKMK_msdyn_systemuser_msdyn_resourcerequest_requestedby) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_resourcerequest?text=msdyn_resourcerequest EntityType" />