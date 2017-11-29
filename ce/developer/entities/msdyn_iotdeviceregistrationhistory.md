---
title: "msdyn_iotdeviceregistrationhistory Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_iotdeviceregistrationhistory entity."
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
# msdyn_iotdeviceregistrationhistory Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Tracks registration activities on an IoT device.

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdeviceregistrationhistories(*msdyn_iotdeviceregistrationhistoryid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_iotdeviceregistrationhistories<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_iotdeviceregistrationhistories(*msdyn_iotdeviceregistrationhistoryid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_iotdeviceregistrationhistories(*msdyn_iotdeviceregistrationhistoryid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_iotdeviceregistrationhistories<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdeviceregistrationhistories(*msdyn_iotdeviceregistrationhistoryid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdeviceregistrationhistories(*msdyn_iotdeviceregistrationhistoryid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: IoT Device Registration History<br />
**DisplayCollectionName**: IoT Device Registration History<br />
**SchemaName**: msdyn_iotdeviceregistrationhistory<br />
**CollectionSchemaName**: msdyn_iotdeviceregistrationhistories<br />
**LogicalName**: msdyn_iotdeviceregistrationhistory<br />
**LogicalCollectionName**: msdyn_iotdeviceregistrationhistories<br />
**EntitySetName**: msdyn_iotdeviceregistrationhistories<br />
**PrimaryIdAttribute**: msdyn_iotdeviceregistrationhistoryid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Action](#BKMK_msdyn_Action)
- [msdyn_Device](#BKMK_msdyn_Device)
- [msdyn_iotdeviceregistrationhistoryId](#BKMK_msdyn_iotdeviceregistrationhistoryId)
- [msdyn_name](#BKMK_msdyn_name)
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


### <a name="BKMK_msdyn_Action"></a> msdyn_Action

**Description**: <br />
**DisplayName**: Action<br />
**LogicalName**: msdyn_action<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Register
- **Value**: 192350001 **Label**: Unregister
- **Value**: 192350002 **Label**: Activate
- **Value**: 192350003 **Label**: Deactivate



### <a name="BKMK_msdyn_Device"></a> msdyn_Device

**Description**: IoT device<br />
**DisplayName**: Device<br />
**LogicalName**: msdyn_device<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_iotdevice


### <a name="BKMK_msdyn_iotdeviceregistrationhistoryId"></a> msdyn_iotdeviceregistrationhistoryId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: IoT Device Registration History<br />
**LogicalName**: msdyn_iotdeviceregistrationhistoryid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


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

**Description**: Status of the IoT Device Registration History<br />
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

**Description**: Reason for the status of the IoT Device Registration History<br />
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
- [msdyn_DeviceName](#BKMK_msdyn_DeviceName)
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


### <a name="BKMK_msdyn_DeviceName"></a> msdyn_DeviceName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_devicename<br />
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

- [msdyn_iotdeviceregistrationhistory_SyncErrors](#BKMK_msdyn_iotdeviceregistrationhistory_SyncErrors)
- [msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord](#BKMK_msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord)
- [msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord](#BKMK_msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord)
- [msdyn_iotdeviceregistrationhistory_AsyncOperations](#BKMK_msdyn_iotdeviceregistrationhistory_AsyncOperations)
- [msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders](#BKMK_msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders)
- [msdyn_iotdeviceregistrationhistory_UserEntityInstanceDatas](#BKMK_msdyn_iotdeviceregistrationhistory_UserEntityInstanceDatas)
- [msdyn_iotdeviceregistrationhistory_ProcessSession](#BKMK_msdyn_iotdeviceregistrationhistory_ProcessSession)
- [msdyn_iotdeviceregistrationhistory_BulkDeleteFailures](#BKMK_msdyn_iotdeviceregistrationhistory_BulkDeleteFailures)
- [msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses)
- [msdyn_iotdeviceregistrationhistory_connections1](#BKMK_msdyn_iotdeviceregistrationhistory_connections1)
- [msdyn_iotdeviceregistrationhistory_connections2](#BKMK_msdyn_iotdeviceregistrationhistory_connections2)
- [msdyn_iotdeviceregistrationhistory_Annotations](#BKMK_msdyn_iotdeviceregistrationhistory_Annotations)


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_SyncErrors"></a> msdyn_iotdeviceregistrationhistory_SyncErrors

Same as syncerror entity [msdyn_iotdeviceregistrationhistory_SyncErrors](syncerror.md#BKMK_msdyn_iotdeviceregistrationhistory_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_SyncErrors<br />
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


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord"></a> msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord"></a> msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_AsyncOperations"></a> msdyn_iotdeviceregistrationhistory_AsyncOperations

Same as asyncoperation entity [msdyn_iotdeviceregistrationhistory_AsyncOperations](asyncoperation.md#BKMK_msdyn_iotdeviceregistrationhistory_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_AsyncOperations<br />
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


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders"></a> msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_UserEntityInstanceDatas"></a> msdyn_iotdeviceregistrationhistory_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_iotdeviceregistrationhistory_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_iotdeviceregistrationhistory_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_ProcessSession"></a> msdyn_iotdeviceregistrationhistory_ProcessSession

Same as processsession entity [msdyn_iotdeviceregistrationhistory_ProcessSession](processsession.md#BKMK_msdyn_iotdeviceregistrationhistory_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_ProcessSession<br />
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


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_BulkDeleteFailures"></a> msdyn_iotdeviceregistrationhistory_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_iotdeviceregistrationhistory_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iotdeviceregistrationhistory_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses"></a> msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_connections1"></a> msdyn_iotdeviceregistrationhistory_connections1

Same as connection entity [msdyn_iotdeviceregistrationhistory_connections1](connection.md#BKMK_msdyn_iotdeviceregistrationhistory_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_connections1<br />
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


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_connections2"></a> msdyn_iotdeviceregistrationhistory_connections2

Same as connection entity [msdyn_iotdeviceregistrationhistory_connections2](connection.md#BKMK_msdyn_iotdeviceregistrationhistory_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_connections2<br />
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


### <a name="BKMK_msdyn_iotdeviceregistrationhistory_Annotations"></a> msdyn_iotdeviceregistrationhistory_Annotations

Same as annotation entity [msdyn_iotdeviceregistrationhistory_Annotations](annotation.md#BKMK_msdyn_iotdeviceregistrationhistory_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdeviceregistrationhistory_Annotations<br />
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

- [lk_msdyn_iotdeviceregistrationhistory_createdby](#BKMK_lk_msdyn_iotdeviceregistrationhistory_createdby)
- [lk_msdyn_iotdeviceregistrationhistory_createdonbehalfby](#BKMK_lk_msdyn_iotdeviceregistrationhistory_createdonbehalfby)
- [lk_msdyn_iotdeviceregistrationhistory_modifiedby](#BKMK_lk_msdyn_iotdeviceregistrationhistory_modifiedby)
- [lk_msdyn_iotdeviceregistrationhistory_modifiedonbehalfby](#BKMK_lk_msdyn_iotdeviceregistrationhistory_modifiedonbehalfby)
- [user_msdyn_iotdeviceregistrationhistory](#BKMK_user_msdyn_iotdeviceregistrationhistory)
- [team_msdyn_iotdeviceregistrationhistory](#BKMK_team_msdyn_iotdeviceregistrationhistory)
- [business_unit_msdyn_iotdeviceregistrationhistory](#BKMK_business_unit_msdyn_iotdeviceregistrationhistory)
- [msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device)


### <a name="BKMK_lk_msdyn_iotdeviceregistrationhistory_createdby"></a> lk_msdyn_iotdeviceregistrationhistory_createdby

See systemuser Entity [lk_msdyn_iotdeviceregistrationhistory_createdby](systemuser.md#BKMK_lk_msdyn_iotdeviceregistrationhistory_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdeviceregistrationhistory_createdonbehalfby"></a> lk_msdyn_iotdeviceregistrationhistory_createdonbehalfby

See systemuser Entity [lk_msdyn_iotdeviceregistrationhistory_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdeviceregistrationhistory_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdeviceregistrationhistory_modifiedby"></a> lk_msdyn_iotdeviceregistrationhistory_modifiedby

See systemuser Entity [lk_msdyn_iotdeviceregistrationhistory_modifiedby](systemuser.md#BKMK_lk_msdyn_iotdeviceregistrationhistory_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdeviceregistrationhistory_modifiedonbehalfby"></a> lk_msdyn_iotdeviceregistrationhistory_modifiedonbehalfby

See systemuser Entity [lk_msdyn_iotdeviceregistrationhistory_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdeviceregistrationhistory_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_iotdeviceregistrationhistory"></a> user_msdyn_iotdeviceregistrationhistory

See systemuser Entity [user_msdyn_iotdeviceregistrationhistory](systemuser.md#BKMK_user_msdyn_iotdeviceregistrationhistory) One-To-Many relationship.

### <a name="BKMK_team_msdyn_iotdeviceregistrationhistory"></a> team_msdyn_iotdeviceregistrationhistory

See team Entity [team_msdyn_iotdeviceregistrationhistory](team.md#BKMK_team_msdyn_iotdeviceregistrationhistory) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_iotdeviceregistrationhistory"></a> business_unit_msdyn_iotdeviceregistrationhistory

See businessunit Entity [business_unit_msdyn_iotdeviceregistrationhistory](businessunit.md#BKMK_business_unit_msdyn_iotdeviceregistrationhistory) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device

See msdyn_iotdevice Entity [msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device](msdyn_iotdevice.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_iotdeviceregistrationhistory?text=msdyn_iotdeviceregistrationhistory EntityType" />