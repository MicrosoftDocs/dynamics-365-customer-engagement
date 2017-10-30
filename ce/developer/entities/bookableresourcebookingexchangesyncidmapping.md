---
title: "BookableResourceBookingExchangeSyncIdMapping Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BookableResourceBookingExchangeSyncIdMapping entity."
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
# BookableResourceBookingExchangeSyncIdMapping Entity Reference

The mapping used to keep track of the IDs for items synced between CRM BookableResourceBooking and Exchange.

**Added by**: Scheduling Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/bookableresourcebookingexchangesyncidmappings<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/bookableresourcebookingexchangesyncidmappings(*bookableresourcebookingexchangesyncidmappingid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/bookableresourcebookingexchangesyncidmappings(*bookableresourcebookingexchangesyncidmappingid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/bookableresourcebookingexchangesyncidmappings<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/bookableresourcebookingexchangesyncidmappings(*bookableresourcebookingexchangesyncidmappingid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: BookableResourceBooking to Exchange Id Mapping<br />
**DisplayCollectionName**: BookableResourceBooking to Exchange Id Mappings<br />
**SchemaName**: BookableResourceBookingExchangeSyncIdMapping<br />
**CollectionSchemaName**: BookableResourceBookingExchangeSyncIdMappings<br />
**LogicalName**: bookableresourcebookingexchangesyncidmapping<br />
**LogicalCollectionName**: bookableresourcebookingexchangesyncidmappings<br />
**EntitySetName**: bookableresourcebookingexchangesyncidmappings<br />
**PrimaryIdAttribute**: bookableresourcebookingexchangesyncidmappingid<br />
**PrimaryNameAttribute**: name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [BookableResourceBookingExchangeSyncIdMappingId](#BKMK_BookableResourceBookingExchangeSyncIdMappingId)
- [BookableResourceBookingId](#BKMK_BookableResourceBookingId)
- [ExchangeEntryId](#BKMK_ExchangeEntryId)
- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsDeletedInExchange](#BKMK_IsDeletedInExchange)
- [LastSyncError](#BKMK_LastSyncError)
- [LastSyncErrorCode](#BKMK_LastSyncErrorCode)
- [LastSyncErrorOccurredOn](#BKMK_LastSyncErrorOccurredOn)
- [Name](#BKMK_Name)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [Retries](#BKMK_Retries)
- [SyncStatus](#BKMK_SyncStatus)
- [SyncVersionNumber](#BKMK_SyncVersionNumber)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UserId](#BKMK_UserId)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)


### <a name="BKMK_BookableResourceBookingExchangeSyncIdMappingId"></a> BookableResourceBookingExchangeSyncIdMappingId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: bookableresourcebookingexchangesyncidmappingid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_BookableResourceBookingId"></a> BookableResourceBookingId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: bookableresourcebookingid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ExchangeEntryId"></a> ExchangeEntryId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: exchangeentryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1024


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


### <a name="BKMK_IsDeletedInExchange"></a> IsDeletedInExchange

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: isdeletedinexchange<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_LastSyncError"></a> LastSyncError

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: lastsyncerror<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2048


### <a name="BKMK_LastSyncErrorCode"></a> LastSyncErrorCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: lastsyncerrorcode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_LastSyncErrorOccurredOn"></a> LastSyncErrorOccurredOn

**Description**: Last Sync Error Time<br />
**DisplayName**: Last Sync Error Time<br />
**LogicalName**: lastsyncerroroccurredon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_Name"></a> Name

**Description**: name<br />
**DisplayName**: name<br />
**LogicalName**: name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


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
**IsValidForForm**: False<br />
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


### <a name="BKMK_Retries"></a> Retries

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: retries<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_SyncStatus"></a> SyncStatus

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: syncstatus<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 0 **Label**: Completed
- **Value**: 1 **Label**: Retry
- **Value**: 2 **Label**: Pending



### <a name="BKMK_SyncVersionNumber"></a> SyncVersionNumber

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: syncversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />


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


### <a name="BKMK_UserId"></a> UserId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: userid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: 


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

- [bookableresourcebookingexchangesyncidmapping_SyncErrors](#BKMK_bookableresourcebookingexchangesyncidmapping_SyncErrors)
- [bookableresourcebookingexchangesyncidmapping_AsyncOperations](#BKMK_bookableresourcebookingexchangesyncidmapping_AsyncOperations)
- [bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders](#BKMK_bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders)
- [bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas](#BKMK_bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas)
- [bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures](#BKMK_bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures)
- [bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses](#BKMK_bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses)


### <a name="BKMK_bookableresourcebookingexchangesyncidmapping_SyncErrors"></a> bookableresourcebookingexchangesyncidmapping_SyncErrors

Same as syncerror entity [bookableresourcebookingexchangesyncidmapping_SyncErrors](syncerror.md#BKMK_bookableresourcebookingexchangesyncidmapping_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingexchangesyncidmapping_SyncErrors<br />
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


### <a name="BKMK_bookableresourcebookingexchangesyncidmapping_AsyncOperations"></a> bookableresourcebookingexchangesyncidmapping_AsyncOperations

Same as asyncoperation entity [bookableresourcebookingexchangesyncidmapping_AsyncOperations](asyncoperation.md#BKMK_bookableresourcebookingexchangesyncidmapping_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingexchangesyncidmapping_AsyncOperations<br />
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


### <a name="BKMK_bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders"></a> bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders<br />
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


### <a name="BKMK_bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas"></a> bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas

Same as userentityinstancedata entity [bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingexchangesyncidmapping_UserEntityInstanceDatas<br />
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


### <a name="BKMK_bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures"></a> bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures

Same as bulkdeletefailure entity [bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures](bulkdeletefailure.md#BKMK_bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures<br />
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


### <a name="BKMK_bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses"></a> bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses<br />
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

- [lk_bookableresourcebookingexchangesyncidmapping_createdby](#BKMK_lk_bookableresourcebookingexchangesyncidmapping_createdby)
- [lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby](#BKMK_lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby)
- [lk_bookableresourcebookingexchangesyncidmapping_modifiedby](#BKMK_lk_bookableresourcebookingexchangesyncidmapping_modifiedby)
- [lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby](#BKMK_lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby)
- [user_bookableresourcebookingexchangesyncidmapping](#BKMK_user_bookableresourcebookingexchangesyncidmapping)
- [team_bookableresourcebookingexchangesyncidmapping](#BKMK_team_bookableresourcebookingexchangesyncidmapping)
- [business_unit_bookableresourcebookingexchangesyncidmapping](#BKMK_business_unit_bookableresourcebookingexchangesyncidmapping)


### <a name="BKMK_lk_bookableresourcebookingexchangesyncidmapping_createdby"></a> lk_bookableresourcebookingexchangesyncidmapping_createdby

See systemuser Entity [lk_bookableresourcebookingexchangesyncidmapping_createdby](systemuser.md#BKMK_lk_bookableresourcebookingexchangesyncidmapping_createdby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby"></a> lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby

See systemuser Entity [lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby](systemuser.md#BKMK_lk_bookableresourcebookingexchangesyncidmapping_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebookingexchangesyncidmapping_modifiedby"></a> lk_bookableresourcebookingexchangesyncidmapping_modifiedby

See systemuser Entity [lk_bookableresourcebookingexchangesyncidmapping_modifiedby](systemuser.md#BKMK_lk_bookableresourcebookingexchangesyncidmapping_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby"></a> lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby

See systemuser Entity [lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby](systemuser.md#BKMK_lk_bookableresourcebookingexchangesyncidmapping_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_bookableresourcebookingexchangesyncidmapping"></a> user_bookableresourcebookingexchangesyncidmapping

See systemuser Entity [user_bookableresourcebookingexchangesyncidmapping](systemuser.md#BKMK_user_bookableresourcebookingexchangesyncidmapping) One-To-Many relationship.

### <a name="BKMK_team_bookableresourcebookingexchangesyncidmapping"></a> team_bookableresourcebookingexchangesyncidmapping

See team Entity [team_bookableresourcebookingexchangesyncidmapping](team.md#BKMK_team_bookableresourcebookingexchangesyncidmapping) One-To-Many relationship.

### <a name="BKMK_business_unit_bookableresourcebookingexchangesyncidmapping"></a> business_unit_bookableresourcebookingexchangesyncidmapping

See businessunit Entity [business_unit_bookableresourcebookingexchangesyncidmapping](businessunit.md#BKMK_business_unit_bookableresourcebookingexchangesyncidmapping) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.bookableresourcebookingexchangesyncidmapping?text=bookableresourcebookingexchangesyncidmapping EntityType" />