---
title: "msdyn_wallsavedquery Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_wallsavedquery entity."
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
# msdyn_wallsavedquery Entity Reference

Contains information regarding which views are available for users to display on their personal walls. Only an administrator can specify the views that users can choose from to display on their personal walls.

**Added by**: Activity Feeds Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_wallsavedqueries(*msdyn_wallsavedqueryid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Wall View<br />
**DisplayCollectionName**: Wall Views<br />
**SchemaName**: msdyn_wallsavedquery<br />
**CollectionSchemaName**: msdyn_wallsavedqueries<br />
**LogicalName**: msdyn_wallsavedquery<br />
**LogicalCollectionName**: msdyn_wallsavedqueries<br />
**EntitySetName**: msdyn_wallsavedqueries<br />
**PrimaryIdAttribute**: msdyn_wallsavedqueryid<br />
**PrimaryNameAttribute**: msdyn_entityname<br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_entitydisplayname](#BKMK_msdyn_entitydisplayname)
- [msdyn_entityname](#BKMK_msdyn_entityname)
- [msdyn_IsVirtual](#BKMK_msdyn_IsVirtual)
- [msdyn_IsVisible](#BKMK_msdyn_IsVisible)
- [msdyn_isvisiblebit](#BKMK_msdyn_isvisiblebit)
- [msdyn_otc](#BKMK_msdyn_otc)
- [msdyn_postconfigurationid](#BKMK_msdyn_postconfigurationid)
- [msdyn_SavedQueryId](#BKMK_msdyn_SavedQueryId)
- [msdyn_savedqueryname](#BKMK_msdyn_savedqueryname)
- [msdyn_wallsavedqueryId](#BKMK_msdyn_wallsavedqueryId)
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


### <a name="BKMK_msdyn_entitydisplayname"></a> msdyn_entitydisplayname

**Description**: Type of entity to which the corresponding views belong<br />
**DisplayName**: Entity Display Name<br />
**LogicalName**: msdyn_entitydisplayname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_entityname"></a> msdyn_entityname

**Description**: Name of the entity to which the corresponding views belong.<br />
**DisplayName**: Entity Name<br />
**LogicalName**: msdyn_entityname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_IsVirtual"></a> msdyn_IsVirtual

**Description**: Information that indicates whether the entity is virtual, that is whether, it is generated by a plug-in, and no corresponding entity instance exists.<br />
**DisplayName**: Is Virtual<br />
**LogicalName**: msdyn_isvirtual<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_IsVisible"></a> msdyn_IsVisible

**Description**: Indicates that corresponding system view should be displayed on personal wall<br />
**DisplayName**: Status<br />
**LogicalName**: msdyn_isvisible<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Shown
- **FalseOption Value**: 0 **Label**: Hidden

**DefaultValue**: False


### <a name="BKMK_msdyn_isvisiblebit"></a> msdyn_isvisiblebit

**Description**: For internal use only.<br />
**DisplayName**: Is Visible bit<br />
**LogicalName**: msdyn_isvisiblebit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_otc"></a> msdyn_otc

**Description**: Type of entity to which the corresponding views belong.<br />
**DisplayName**: Entity Type<br />
**LogicalName**: msdyn_otc<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_postconfigurationid"></a> msdyn_postconfigurationid

**Description**: Unique identifier for Post Configuration associated with Wall View.<br />
**DisplayName**: Post Entity Id<br />
**LogicalName**: msdyn_postconfigurationid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_postconfig


### <a name="BKMK_msdyn_SavedQueryId"></a> msdyn_SavedQueryId

**Description**: Unique identifier of the view that should be displayed on the personal wall for all users.<br />
**DisplayName**: View Id<br />
**LogicalName**: msdyn_savedqueryid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_savedqueryname"></a> msdyn_savedqueryname

**Description**: Name of the corresponding view.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_savedqueryname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_wallsavedqueryId"></a> msdyn_wallsavedqueryId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: Wall View<br />
**LogicalName**: msdyn_wallsavedqueryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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

**Description**: Status of the Wall View<br />
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

**Description**: Reason for the status of the Wall View<br />
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
- [msdyn_postconfigurationidName](#BKMK_msdyn_postconfigurationidName)
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


### <a name="BKMK_msdyn_postconfigurationidName"></a> msdyn_postconfigurationidName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_postconfigurationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
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

- [msdyn_wallsavedquery_SyncErrors](#BKMK_msdyn_wallsavedquery_SyncErrors)
- [msdyn_wallsavedquery_AsyncOperations](#BKMK_msdyn_wallsavedquery_AsyncOperations)
- [msdyn_wallsavedquery_MailboxTrackingFolders](#BKMK_msdyn_wallsavedquery_MailboxTrackingFolders)
- [msdyn_wallsavedquery_UserEntityInstanceDatas](#BKMK_msdyn_wallsavedquery_UserEntityInstanceDatas)
- [msdyn_wallsavedquery_ProcessSession](#BKMK_msdyn_wallsavedquery_ProcessSession)
- [msdyn_wallsavedquery_BulkDeleteFailures](#BKMK_msdyn_wallsavedquery_BulkDeleteFailures)
- [msdyn_wallsavedquery_PrincipalObjectAttributeAccesses](#BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses)
- [msdyn_wallsavedquery_wallsavedqueryusersettings](#BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings)


### <a name="BKMK_msdyn_wallsavedquery_SyncErrors"></a> msdyn_wallsavedquery_SyncErrors

Same as syncerror entity [msdyn_wallsavedquery_SyncErrors](syncerror.md#BKMK_msdyn_wallsavedquery_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedquery_SyncErrors<br />
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


### <a name="BKMK_msdyn_wallsavedquery_AsyncOperations"></a> msdyn_wallsavedquery_AsyncOperations

Same as asyncoperation entity [msdyn_wallsavedquery_AsyncOperations](asyncoperation.md#BKMK_msdyn_wallsavedquery_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedquery_AsyncOperations<br />
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


### <a name="BKMK_msdyn_wallsavedquery_MailboxTrackingFolders"></a> msdyn_wallsavedquery_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_wallsavedquery_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_wallsavedquery_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedquery_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_wallsavedquery_UserEntityInstanceDatas"></a> msdyn_wallsavedquery_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_wallsavedquery_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_wallsavedquery_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedquery_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_wallsavedquery_ProcessSession"></a> msdyn_wallsavedquery_ProcessSession

Same as processsession entity [msdyn_wallsavedquery_ProcessSession](processsession.md#BKMK_msdyn_wallsavedquery_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedquery_ProcessSession<br />
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


### <a name="BKMK_msdyn_wallsavedquery_BulkDeleteFailures"></a> msdyn_wallsavedquery_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_wallsavedquery_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_wallsavedquery_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedquery_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses"></a> msdyn_wallsavedquery_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_wallsavedquery_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedquery_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings"></a> msdyn_wallsavedquery_wallsavedqueryusersettings

Same as msdyn_wallsavedqueryusersettings entity [msdyn_wallsavedquery_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedquery_wallsavedqueryusersettings) Many-To-One relationship.

**ReferencingEntity**: msdyn_wallsavedqueryusersettings<br />
**ReferencingAttribute**: msdyn_wallsavedqueryid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_wallsavedquery_wallsavedqueryusersettings<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

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

- [lk_msdyn_wallsavedquery_createdby](#BKMK_lk_msdyn_wallsavedquery_createdby)
- [lk_msdyn_wallsavedquery_createdonbehalfby](#BKMK_lk_msdyn_wallsavedquery_createdonbehalfby)
- [lk_msdyn_wallsavedquery_modifiedby](#BKMK_lk_msdyn_wallsavedquery_modifiedby)
- [lk_msdyn_wallsavedquery_modifiedonbehalfby](#BKMK_lk_msdyn_wallsavedquery_modifiedonbehalfby)
- [organization_msdyn_wallsavedquery](#BKMK_organization_msdyn_wallsavedquery)
- [msdyn_postconfig_wallsavedquery](#BKMK_msdyn_postconfig_wallsavedquery)


### <a name="BKMK_lk_msdyn_wallsavedquery_createdby"></a> lk_msdyn_wallsavedquery_createdby

See systemuser Entity [lk_msdyn_wallsavedquery_createdby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_wallsavedquery_createdonbehalfby"></a> lk_msdyn_wallsavedquery_createdonbehalfby

See systemuser Entity [lk_msdyn_wallsavedquery_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_wallsavedquery_modifiedby"></a> lk_msdyn_wallsavedquery_modifiedby

See systemuser Entity [lk_msdyn_wallsavedquery_modifiedby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_wallsavedquery_modifiedonbehalfby"></a> lk_msdyn_wallsavedquery_modifiedonbehalfby

See systemuser Entity [lk_msdyn_wallsavedquery_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_wallsavedquery_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_organization_msdyn_wallsavedquery"></a> organization_msdyn_wallsavedquery

See organization Entity [organization_msdyn_wallsavedquery](organization.md#BKMK_organization_msdyn_wallsavedquery) One-To-Many relationship.

### <a name="BKMK_msdyn_postconfig_wallsavedquery"></a> msdyn_postconfig_wallsavedquery

See msdyn_postconfig Entity [msdyn_postconfig_wallsavedquery](msdyn_postconfig.md#BKMK_msdyn_postconfig_wallsavedquery) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_wallsavedquery?text=msdyn_wallsavedquery EntityType" />