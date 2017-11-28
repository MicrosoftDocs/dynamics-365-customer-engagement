---
title: "msdyn_systemuserschedulersetting Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_systemuserschedulersetting entity."
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
# msdyn_systemuserschedulersetting Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Stores user-specific settings for the schedule board.

**Added by**: Unified Resource Scheduling Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_systemuserschedulersettinges(*msdyn_systemuserschedulersettingid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_systemuserschedulersettinges<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_systemuserschedulersettinges(*msdyn_systemuserschedulersettingid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_systemuserschedulersettinges(*msdyn_systemuserschedulersettingid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_systemuserschedulersettinges<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_systemuserschedulersettinges(*msdyn_systemuserschedulersettingid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_systemuserschedulersettinges(*msdyn_systemuserschedulersettingid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: System User Scheduler Setting<br />
**DisplayCollectionName**: System User Scheduler Setting<br />
**SchemaName**: msdyn_systemuserschedulersetting<br />
**CollectionSchemaName**: msdyn_systemuserschedulersettings<br />
**LogicalName**: msdyn_systemuserschedulersetting<br />
**LogicalCollectionName**: msdyn_systemuserschedulersettings<br />
**EntitySetName**: msdyn_systemuserschedulersettinges<br />
**PrimaryIdAttribute**: msdyn_systemuserschedulersettingid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ScheduleSettings](#BKMK_msdyn_ScheduleSettings)
- [msdyn_systemuserschedulersettingId](#BKMK_msdyn_systemuserschedulersettingId)
- [msdyn_User](#BKMK_msdyn_User)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
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


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ScheduleSettings"></a> msdyn_ScheduleSettings

**Description**: <br />
**DisplayName**: Scheduler Settings<br />
**LogicalName**: msdyn_schedulesettings<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_systemuserschedulersettingId"></a> msdyn_systemuserschedulersettingId

**Description**: Shows the entity instances.<br />
**DisplayName**: System User Scheduler Setting<br />
**LogicalName**: msdyn_systemuserschedulersettingid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_User"></a> msdyn_User

**Description**: Unique identifier for User associated with System User Scheduler Setting.<br />
**DisplayName**: User<br />
**LogicalName**: msdyn_user<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
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

**Description**: Shows the owner ID type.<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the System User Scheduler Setting<br />
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

**Description**: Reason for the status of the System User Scheduler Setting<br />
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
- [msdyn_UserName](#BKMK_msdyn_UserName)
- [msdyn_UserYomiName](#BKMK_msdyn_UserYomiName)
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


### <a name="BKMK_msdyn_UserName"></a> msdyn_UserName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_username<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_UserYomiName"></a> msdyn_UserYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_useryominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Type the name of the owner.<br />
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

**Description**: Shows the Yomi name of the owner.<br />
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

- [msdyn_systemuserschedulersetting_ActivityPointers](#BKMK_msdyn_systemuserschedulersetting_ActivityPointers)
- [msdyn_systemuserschedulersetting_msdyn_bookingalerts](#BKMK_msdyn_systemuserschedulersetting_msdyn_bookingalerts)
- [msdyn_systemuserschedulersetting_SyncErrors](#BKMK_msdyn_systemuserschedulersetting_SyncErrors)
- [msdyn_systemuserschedulersetting_DuplicateMatchingRecord](#BKMK_msdyn_systemuserschedulersetting_DuplicateMatchingRecord)
- [msdyn_systemuserschedulersetting_DuplicateBaseRecord](#BKMK_msdyn_systemuserschedulersetting_DuplicateBaseRecord)
- [msdyn_systemuserschedulersetting_AsyncOperations](#BKMK_msdyn_systemuserschedulersetting_AsyncOperations)
- [msdyn_systemuserschedulersetting_MailboxTrackingFolders](#BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders)
- [msdyn_systemuserschedulersetting_UserEntityInstanceDatas](#BKMK_msdyn_systemuserschedulersetting_UserEntityInstanceDatas)
- [msdyn_systemuserschedulersetting_ProcessSession](#BKMK_msdyn_systemuserschedulersetting_ProcessSession)
- [msdyn_systemuserschedulersetting_BulkDeleteFailures](#BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures)
- [msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses)
- [msdyn_systemuserschedulersetting_Appointments](#BKMK_msdyn_systemuserschedulersetting_Appointments)
- [msdyn_systemuserschedulersetting_Emails](#BKMK_msdyn_systemuserschedulersetting_Emails)
- [msdyn_systemuserschedulersetting_Faxes](#BKMK_msdyn_systemuserschedulersetting_Faxes)
- [msdyn_systemuserschedulersetting_Letters](#BKMK_msdyn_systemuserschedulersetting_Letters)
- [msdyn_systemuserschedulersetting_PhoneCalls](#BKMK_msdyn_systemuserschedulersetting_PhoneCalls)
- [msdyn_systemuserschedulersetting_Tasks](#BKMK_msdyn_systemuserschedulersetting_Tasks)
- [msdyn_systemuserschedulersetting_RecurringAppointmentMasters](#BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters)
- [msdyn_systemuserschedulersetting_SocialActivities](#BKMK_msdyn_systemuserschedulersetting_SocialActivities)
- [msdyn_systemuserschedulersetting_connections1](#BKMK_msdyn_systemuserschedulersetting_connections1)
- [msdyn_systemuserschedulersetting_connections2](#BKMK_msdyn_systemuserschedulersetting_connections2)
- [msdyn_systemuserschedulersetting_Annotations](#BKMK_msdyn_systemuserschedulersetting_Annotations)
- [msdyn_systemuserschedulersetting_ServiceAppointments](#BKMK_msdyn_systemuserschedulersetting_ServiceAppointments)
- [msdyn_systemuserschedulersetting_msdyn_approvals](#BKMK_msdyn_systemuserschedulersetting_msdyn_approvals)


### <a name="BKMK_msdyn_systemuserschedulersetting_ActivityPointers"></a> msdyn_systemuserschedulersetting_ActivityPointers

Same as activitypointer entity [msdyn_systemuserschedulersetting_ActivityPointers](activitypointer.md#BKMK_msdyn_systemuserschedulersetting_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_bookingalerts"></a> msdyn_systemuserschedulersetting_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_systemuserschedulersetting_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_systemuserschedulersetting_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_SyncErrors"></a> msdyn_systemuserschedulersetting_SyncErrors

Same as syncerror entity [msdyn_systemuserschedulersetting_SyncErrors](syncerror.md#BKMK_msdyn_systemuserschedulersetting_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_SyncErrors<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_DuplicateMatchingRecord"></a> msdyn_systemuserschedulersetting_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_systemuserschedulersetting_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_systemuserschedulersetting_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_DuplicateBaseRecord"></a> msdyn_systemuserschedulersetting_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_systemuserschedulersetting_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_systemuserschedulersetting_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_AsyncOperations"></a> msdyn_systemuserschedulersetting_AsyncOperations

Same as asyncoperation entity [msdyn_systemuserschedulersetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_systemuserschedulersetting_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_AsyncOperations<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders"></a> msdyn_systemuserschedulersetting_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_systemuserschedulersetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_UserEntityInstanceDatas"></a> msdyn_systemuserschedulersetting_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_systemuserschedulersetting_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_systemuserschedulersetting_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_ProcessSession"></a> msdyn_systemuserschedulersetting_ProcessSession

Same as processsession entity [msdyn_systemuserschedulersetting_ProcessSession](processsession.md#BKMK_msdyn_systemuserschedulersetting_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_ProcessSession<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures"></a> msdyn_systemuserschedulersetting_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_systemuserschedulersetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses"></a> msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_Appointments"></a> msdyn_systemuserschedulersetting_Appointments

Same as appointment entity [msdyn_systemuserschedulersetting_Appointments](appointment.md#BKMK_msdyn_systemuserschedulersetting_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_Appointments<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_Emails"></a> msdyn_systemuserschedulersetting_Emails

Same as email entity [msdyn_systemuserschedulersetting_Emails](email.md#BKMK_msdyn_systemuserschedulersetting_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_Emails<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_Faxes"></a> msdyn_systemuserschedulersetting_Faxes

Same as fax entity [msdyn_systemuserschedulersetting_Faxes](fax.md#BKMK_msdyn_systemuserschedulersetting_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_Faxes<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_Letters"></a> msdyn_systemuserschedulersetting_Letters

Same as letter entity [msdyn_systemuserschedulersetting_Letters](letter.md#BKMK_msdyn_systemuserschedulersetting_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_Letters<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_PhoneCalls"></a> msdyn_systemuserschedulersetting_PhoneCalls

Same as phonecall entity [msdyn_systemuserschedulersetting_PhoneCalls](phonecall.md#BKMK_msdyn_systemuserschedulersetting_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_PhoneCalls<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_Tasks"></a> msdyn_systemuserschedulersetting_Tasks

Same as task entity [msdyn_systemuserschedulersetting_Tasks](task.md#BKMK_msdyn_systemuserschedulersetting_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_Tasks<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters"></a> msdyn_systemuserschedulersetting_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_systemuserschedulersetting_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_systemuserschedulersetting_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_SocialActivities"></a> msdyn_systemuserschedulersetting_SocialActivities

Same as socialactivity entity [msdyn_systemuserschedulersetting_SocialActivities](socialactivity.md#BKMK_msdyn_systemuserschedulersetting_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_SocialActivities<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_connections1"></a> msdyn_systemuserschedulersetting_connections1

Same as connection entity [msdyn_systemuserschedulersetting_connections1](connection.md#BKMK_msdyn_systemuserschedulersetting_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_connections1<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 100

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_systemuserschedulersetting_connections2"></a> msdyn_systemuserschedulersetting_connections2

Same as connection entity [msdyn_systemuserschedulersetting_connections2](connection.md#BKMK_msdyn_systemuserschedulersetting_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_connections2<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_Annotations"></a> msdyn_systemuserschedulersetting_Annotations

Same as annotation entity [msdyn_systemuserschedulersetting_Annotations](annotation.md#BKMK_msdyn_systemuserschedulersetting_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_Annotations<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_ServiceAppointments"></a> msdyn_systemuserschedulersetting_ServiceAppointments

Same as serviceappointment entity [msdyn_systemuserschedulersetting_ServiceAppointments](serviceappointment.md#BKMK_msdyn_systemuserschedulersetting_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_ServiceAppointments<br />
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


### <a name="BKMK_msdyn_systemuserschedulersetting_msdyn_approvals"></a> msdyn_systemuserschedulersetting_msdyn_approvals

Same as msdyn_approval entity [msdyn_systemuserschedulersetting_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_systemuserschedulersetting_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_systemuserschedulersetting_msdyn_approvals<br />
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

- [lk_msdyn_systemuserschedulersetting_createdby](#BKMK_lk_msdyn_systemuserschedulersetting_createdby)
- [lk_msdyn_systemuserschedulersetting_createdonbehalfby](#BKMK_lk_msdyn_systemuserschedulersetting_createdonbehalfby)
- [lk_msdyn_systemuserschedulersetting_modifiedby](#BKMK_lk_msdyn_systemuserschedulersetting_modifiedby)
- [lk_msdyn_systemuserschedulersetting_modifiedonbehalfby](#BKMK_lk_msdyn_systemuserschedulersetting_modifiedonbehalfby)
- [user_msdyn_systemuserschedulersetting](#BKMK_user_msdyn_systemuserschedulersetting)
- [team_msdyn_systemuserschedulersetting](#BKMK_team_msdyn_systemuserschedulersetting)
- [business_unit_msdyn_systemuserschedulersetting](#BKMK_business_unit_msdyn_systemuserschedulersetting)
- [msdyn_systemuser_msdyn_systemuserschedulersetting_User](#BKMK_msdyn_systemuser_msdyn_systemuserschedulersetting_User)


### <a name="BKMK_lk_msdyn_systemuserschedulersetting_createdby"></a> lk_msdyn_systemuserschedulersetting_createdby

See systemuser Entity [lk_msdyn_systemuserschedulersetting_createdby](systemuser.md#BKMK_lk_msdyn_systemuserschedulersetting_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_systemuserschedulersetting_createdonbehalfby"></a> lk_msdyn_systemuserschedulersetting_createdonbehalfby

See systemuser Entity [lk_msdyn_systemuserschedulersetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_systemuserschedulersetting_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_systemuserschedulersetting_modifiedby"></a> lk_msdyn_systemuserschedulersetting_modifiedby

See systemuser Entity [lk_msdyn_systemuserschedulersetting_modifiedby](systemuser.md#BKMK_lk_msdyn_systemuserschedulersetting_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_systemuserschedulersetting_modifiedonbehalfby"></a> lk_msdyn_systemuserschedulersetting_modifiedonbehalfby

See systemuser Entity [lk_msdyn_systemuserschedulersetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_systemuserschedulersetting_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_systemuserschedulersetting"></a> user_msdyn_systemuserschedulersetting

See systemuser Entity [user_msdyn_systemuserschedulersetting](systemuser.md#BKMK_user_msdyn_systemuserschedulersetting) One-To-Many relationship.

### <a name="BKMK_team_msdyn_systemuserschedulersetting"></a> team_msdyn_systemuserschedulersetting

See team Entity [team_msdyn_systemuserschedulersetting](team.md#BKMK_team_msdyn_systemuserschedulersetting) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_systemuserschedulersetting"></a> business_unit_msdyn_systemuserschedulersetting

See businessunit Entity [business_unit_msdyn_systemuserschedulersetting](businessunit.md#BKMK_business_unit_msdyn_systemuserschedulersetting) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuser_msdyn_systemuserschedulersetting_User"></a> msdyn_systemuser_msdyn_systemuserschedulersetting_User

See systemuser Entity [msdyn_systemuser_msdyn_systemuserschedulersetting_User](systemuser.md#BKMK_msdyn_systemuser_msdyn_systemuserschedulersetting_User) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_systemuserschedulersetting?text=msdyn_systemuserschedulersetting EntityType" />