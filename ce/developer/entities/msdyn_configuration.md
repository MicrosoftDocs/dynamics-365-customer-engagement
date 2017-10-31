---
title: "msdyn_Configuration Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_Configuration entity."
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
# msdyn_Configuration Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This entity is used to store queries and templates.

**Added by**: Unified Resource Scheduling Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_configurations(*msdyn_configurationid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_configurations<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_configurations(*msdyn_configurationid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_configurations(*msdyn_configurationid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_configurations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_configurations(*msdyn_configurationid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_configurations(*msdyn_configurationid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Configuration<br />
**DisplayCollectionName**: Configurations<br />
**SchemaName**: msdyn_Configuration<br />
**CollectionSchemaName**: msdyn_Configurations<br />
**LogicalName**: msdyn_configuration<br />
**LogicalCollectionName**: msdyn_configurations<br />
**EntitySetName**: msdyn_configurations<br />
**PrimaryIdAttribute**: msdyn_configurationid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_ConfigurationId](#BKMK_msdyn_ConfigurationId)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_Type](#BKMK_msdyn_Type)
- [msdyn_Value](#BKMK_msdyn_Value)
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


### <a name="BKMK_msdyn_ConfigurationId"></a> msdyn_ConfigurationId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Configuration<br />
**LogicalName**: msdyn_configurationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_Name"></a> msdyn_Name

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


### <a name="BKMK_msdyn_Type"></a> msdyn_Type

**Description**: <br />
**DisplayName**: Type<br />
**LogicalName**: msdyn_type<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Filter Layout
- **Value**: 192350001 **Label**: Resource Cell Template
- **Value**: 192350002 **Label**: Retrieve Resources Query
- **Value**: 192350003 **Label**: Schedule Assistant Filter Layout
- **Value**: 192350004 **Label**: Schedule Assistant Retrieve Constraints Query
- **Value**: 192350005 **Label**: Clone Entity Query



### <a name="BKMK_msdyn_Value"></a> msdyn_Value

**Description**: To store queries and templates.<br />
**DisplayName**: Value<br />
**LogicalName**: msdyn_value<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


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

**Description**: Status of the Configuration<br />
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

**Description**: Reason for the status of the Configuration<br />
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

- [msdyn_configuration_SyncErrors](#BKMK_msdyn_configuration_SyncErrors)
- [msdyn_configuration_AsyncOperations](#BKMK_msdyn_configuration_AsyncOperations)
- [msdyn_configuration_MailboxTrackingFolders](#BKMK_msdyn_configuration_MailboxTrackingFolders)
- [msdyn_configuration_UserEntityInstanceDatas](#BKMK_msdyn_configuration_UserEntityInstanceDatas)
- [msdyn_configuration_ProcessSession](#BKMK_msdyn_configuration_ProcessSession)
- [msdyn_configuration_BulkDeleteFailures](#BKMK_msdyn_configuration_BulkDeleteFailures)
- [msdyn_configuration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery)
- [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery](#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery)
- [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout](#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout)
- [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate](#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate)
- [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery](#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery)


### <a name="BKMK_msdyn_configuration_SyncErrors"></a> msdyn_configuration_SyncErrors

Same as syncerror entity [msdyn_configuration_SyncErrors](syncerror.md#BKMK_msdyn_configuration_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_configuration_SyncErrors<br />
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


### <a name="BKMK_msdyn_configuration_AsyncOperations"></a> msdyn_configuration_AsyncOperations

Same as asyncoperation entity [msdyn_configuration_AsyncOperations](asyncoperation.md#BKMK_msdyn_configuration_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_configuration_AsyncOperations<br />
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


### <a name="BKMK_msdyn_configuration_MailboxTrackingFolders"></a> msdyn_configuration_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_configuration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_configuration_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_configuration_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_configuration_UserEntityInstanceDatas"></a> msdyn_configuration_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_configuration_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_configuration_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_configuration_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_configuration_ProcessSession"></a> msdyn_configuration_ProcessSession

Same as processsession entity [msdyn_configuration_ProcessSession](processsession.md#BKMK_msdyn_configuration_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_configuration_ProcessSession<br />
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


### <a name="BKMK_msdyn_configuration_BulkDeleteFailures"></a> msdyn_configuration_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_configuration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_configuration_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_configuration_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses"></a> msdyn_configuration_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_configuration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_configuration_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery

Same as msdyn_bookingsetupmetadata entity [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery](msdyn_bookingsetupmetadata.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingsetupmetadata<br />
**ReferencingAttribute**: msdyn_cloneentityquery<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_CloneEntityQuery<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery

Same as msdyn_bookingsetupmetadata entity [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery](msdyn_bookingsetupmetadata.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingsetupmetadata<br />
**ReferencingAttribute**: msdyn_retrieveconstraintsquery<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveConstraintsQuery<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery"></a> msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery

Same as msdyn_bookingsetupmetadata entity [msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery](msdyn_bookingsetupmetadata.md#BKMK_msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingsetupmetadata<br />
**ReferencingAttribute**: msdyn_retrieveresourcesquery<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_configuration_msdyn_bookingsetupmetadata_RetrieveResourcesQuery<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout"></a> msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout

Same as msdyn_scheduleboardsetting entity [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout](msdyn_scheduleboardsetting.md#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout) Many-To-One relationship.

**ReferencingEntity**: msdyn_scheduleboardsetting<br />
**ReferencingAttribute**: msdyn_filterlayout<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate"></a> msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate

Same as msdyn_scheduleboardsetting entity [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate](msdyn_scheduleboardsetting.md#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate) Many-To-One relationship.

**ReferencingEntity**: msdyn_scheduleboardsetting<br />
**ReferencingAttribute**: msdyn_resourcecelltemplate<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery"></a> msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery

Same as msdyn_scheduleboardsetting entity [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery](msdyn_scheduleboardsetting.md#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery) Many-To-One relationship.

**ReferencingEntity**: msdyn_scheduleboardsetting<br />
**ReferencingAttribute**: msdyn_retrieveresourcesquery<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_configuration_createdby](#BKMK_lk_msdyn_configuration_createdby)
- [lk_msdyn_configuration_createdonbehalfby](#BKMK_lk_msdyn_configuration_createdonbehalfby)
- [lk_msdyn_configuration_modifiedby](#BKMK_lk_msdyn_configuration_modifiedby)
- [lk_msdyn_configuration_modifiedonbehalfby](#BKMK_lk_msdyn_configuration_modifiedonbehalfby)
- [user_msdyn_configuration](#BKMK_user_msdyn_configuration)
- [team_msdyn_configuration](#BKMK_team_msdyn_configuration)
- [business_unit_msdyn_configuration](#BKMK_business_unit_msdyn_configuration)


### <a name="BKMK_lk_msdyn_configuration_createdby"></a> lk_msdyn_configuration_createdby

See systemuser Entity [lk_msdyn_configuration_createdby](systemuser.md#BKMK_lk_msdyn_configuration_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_configuration_createdonbehalfby"></a> lk_msdyn_configuration_createdonbehalfby

See systemuser Entity [lk_msdyn_configuration_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_configuration_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_configuration_modifiedby"></a> lk_msdyn_configuration_modifiedby

See systemuser Entity [lk_msdyn_configuration_modifiedby](systemuser.md#BKMK_lk_msdyn_configuration_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_configuration_modifiedonbehalfby"></a> lk_msdyn_configuration_modifiedonbehalfby

See systemuser Entity [lk_msdyn_configuration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_configuration_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_configuration"></a> user_msdyn_configuration

See systemuser Entity [user_msdyn_configuration](systemuser.md#BKMK_user_msdyn_configuration) One-To-Many relationship.

### <a name="BKMK_team_msdyn_configuration"></a> team_msdyn_configuration

See team Entity [team_msdyn_configuration](team.md#BKMK_team_msdyn_configuration) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_configuration"></a> business_unit_msdyn_configuration

See businessunit Entity [business_unit_msdyn_configuration](businessunit.md#BKMK_business_unit_msdyn_configuration) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_configuration?text=msdyn_configuration EntityType" />