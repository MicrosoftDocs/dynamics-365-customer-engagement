---
title: "msdyn_iotdevicecommand Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_iotdevicecommand entity."
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
# msdyn_iotdevicecommand Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Represents an outgoing message to a device connected to an IoT hub.

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: IoT Device Command<br />
**DisplayCollectionName**: IoT Device Commands<br />
**SchemaName**: msdyn_iotdevicecommand<br />
**CollectionSchemaName**: msdyn_iotdevicecommands<br />
**LogicalName**: msdyn_iotdevicecommand<br />
**LogicalCollectionName**: msdyn_iotdevicecommands<br />
**EntitySetName**: msdyn_iotdevicecommands<br />
**PrimaryIdAttribute**: msdyn_iotdevicecommandid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_CommandStatus](#BKMK_msdyn_CommandStatus)
- [msdyn_CommandStatusReason](#BKMK_msdyn_CommandStatusReason)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Device](#BKMK_msdyn_Device)
- [msdyn_DeviceID](#BKMK_msdyn_DeviceID)
- [msdyn_iotdevicecommandId](#BKMK_msdyn_iotdevicecommandId)
- [msdyn_Message](#BKMK_msdyn_Message)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ParentAlert](#BKMK_msdyn_ParentAlert)
- [msdyn_SendToAllConnectedDevices](#BKMK_msdyn_SendToAllConnectedDevices)
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


### <a name="BKMK_msdyn_CommandStatus"></a> msdyn_CommandStatus

**Description**: Describes the status of the command. If this stays at "In Progress" for a long time, verify the IoT endpoint configuration.<br />
**DisplayName**: Command Status<br />
**LogicalName**: msdyn_commandstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: In Progress
- **Value**: 192350001 **Label**: Sent
- **Value**: 192350002 **Label**: Error



### <a name="BKMK_msdyn_CommandStatusReason"></a> msdyn_CommandStatusReason

**Description**: A reason field that explains the command status.<br />
**DisplayName**: Command Status Reason<br />
**LogicalName**: msdyn_commandstatusreason<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution<br />
**Description**: The command will be sent to a device connected to this asset.<br />
**DisplayName**: Customer Asset<br />
**LogicalName**: msdyn_customerasset<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_customerasset


### <a name="BKMK_msdyn_Device"></a> msdyn_Device

**Description**: IoT device to send the message to.<br />
**DisplayName**: Device<br />
**LogicalName**: msdyn_device<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_iotdevice


### <a name="BKMK_msdyn_DeviceID"></a> msdyn_DeviceID

**Description**: The ID of the IoT device to send the message to.<br />
**DisplayName**: Device ID<br />
**LogicalName**: msdyn_deviceid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_iotdevicecommandId"></a> msdyn_iotdevicecommandId

**Description**: Unique identifier for entity instances<br />
**DisplayName**: IoT Device Command<br />
**LogicalName**: msdyn_iotdevicecommandid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_Message"></a> msdyn_Message

**Description**: Message to send to the IoT device. E.g.: A Json string.<br />
**DisplayName**: Message<br />
**LogicalName**: msdyn_message<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 8192


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


### <a name="BKMK_msdyn_ParentAlert"></a> msdyn_ParentAlert

**Description**: Reference to a parent alert in response to which the message is being sent.<br />
**DisplayName**: Parent Alert<br />
**LogicalName**: msdyn_parentalert<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_iotalert


### <a name="BKMK_msdyn_SendToAllConnectedDevices"></a> msdyn_SendToAllConnectedDevices

**Description**: Yes, if a copy of the command should be sent to all registered devices connected under the parent entity of the selected device. No, if this command needs to be sent only to the selected device.<br />
**DisplayName**: Send To All Connected Devices<br />
**LogicalName**: msdyn_sendtoallconnecteddevices<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


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

**Description**: Status of the IoT Device Command<br />
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

**Description**: Reason for the status of the IoT Device Command<br />
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
- [msdyn_CustomerAssetName](#BKMK_msdyn_CustomerAssetName)
- [msdyn_DeviceName](#BKMK_msdyn_DeviceName)
- [msdyn_ParentAlertName](#BKMK_msdyn_ParentAlertName)
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


### <a name="BKMK_msdyn_CustomerAssetName"></a> msdyn_CustomerAssetName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_customerassetname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
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


### <a name="BKMK_msdyn_ParentAlertName"></a> msdyn_ParentAlertName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_parentalertname<br />
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

- [msdyn_iotdevicecommand_SyncErrors](#BKMK_msdyn_iotdevicecommand_SyncErrors)
- [msdyn_iotdevicecommand_DuplicateMatchingRecord](#BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord)
- [msdyn_iotdevicecommand_DuplicateBaseRecord](#BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord)
- [msdyn_iotdevicecommand_AsyncOperations](#BKMK_msdyn_iotdevicecommand_AsyncOperations)
- [msdyn_iotdevicecommand_MailboxTrackingFolders](#BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders)
- [msdyn_iotdevicecommand_UserEntityInstanceDatas](#BKMK_msdyn_iotdevicecommand_UserEntityInstanceDatas)
- [msdyn_iotdevicecommand_ProcessSession](#BKMK_msdyn_iotdevicecommand_ProcessSession)
- [msdyn_iotdevicecommand_BulkDeleteFailures](#BKMK_msdyn_iotdevicecommand_BulkDeleteFailures)
- [msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses)
- [msdyn_iotdevicecommand_connections1](#BKMK_msdyn_iotdevicecommand_connections1)
- [msdyn_iotdevicecommand_connections2](#BKMK_msdyn_iotdevicecommand_connections2)
- [msdyn_iotdevicecommand_Annotations](#BKMK_msdyn_iotdevicecommand_Annotations)
- [msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent)
- [msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent)
- [msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent)


### <a name="BKMK_msdyn_iotdevicecommand_SyncErrors"></a> msdyn_iotdevicecommand_SyncErrors

Same as syncerror entity [msdyn_iotdevicecommand_SyncErrors](syncerror.md#BKMK_msdyn_iotdevicecommand_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_SyncErrors<br />
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


### <a name="BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord"></a> msdyn_iotdevicecommand_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_iotdevicecommand_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_DuplicateMatchingRecord<br />
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


### <a name="BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord"></a> msdyn_iotdevicecommand_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_iotdevicecommand_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_DuplicateBaseRecord<br />
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


### <a name="BKMK_msdyn_iotdevicecommand_AsyncOperations"></a> msdyn_iotdevicecommand_AsyncOperations

Same as asyncoperation entity [msdyn_iotdevicecommand_AsyncOperations](asyncoperation.md#BKMK_msdyn_iotdevicecommand_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_AsyncOperations<br />
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


### <a name="BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders"></a> msdyn_iotdevicecommand_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_iotdevicecommand_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_iotdevicecommand_UserEntityInstanceDatas"></a> msdyn_iotdevicecommand_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_iotdevicecommand_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_iotdevicecommand_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_iotdevicecommand_ProcessSession"></a> msdyn_iotdevicecommand_ProcessSession

Same as processsession entity [msdyn_iotdevicecommand_ProcessSession](processsession.md#BKMK_msdyn_iotdevicecommand_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_ProcessSession<br />
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


### <a name="BKMK_msdyn_iotdevicecommand_BulkDeleteFailures"></a> msdyn_iotdevicecommand_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_iotdevicecommand_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iotdevicecommand_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses"></a> msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_iotdevicecommand_connections1"></a> msdyn_iotdevicecommand_connections1

Same as connection entity [msdyn_iotdevicecommand_connections1](connection.md#BKMK_msdyn_iotdevicecommand_connections1) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record1id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_connections1<br />
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


### <a name="BKMK_msdyn_iotdevicecommand_connections2"></a> msdyn_iotdevicecommand_connections2

Same as connection entity [msdyn_iotdevicecommand_connections2](connection.md#BKMK_msdyn_iotdevicecommand_connections2) Many-To-One relationship.

**ReferencingEntity**: connection<br />
**ReferencingAttribute**: record2id<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_connections2<br />
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


### <a name="BKMK_msdyn_iotdevicecommand_Annotations"></a> msdyn_iotdevicecommand_Annotations

Same as annotation entity [msdyn_iotdevicecommand_Annotations](annotation.md#BKMK_msdyn_iotdevicecommand_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_iotdevicecommand_Annotations<br />
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


### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent

Same as msdyn_iotalert entity [msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotalert<br />
**ReferencingAttribute**: msdyn_lastcommandsent<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent<br />
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


### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent

Same as msdyn_iotdevice entity [msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent](msdyn_iotdevice.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent) Many-To-One relationship.

**ReferencingEntity**: msdyn_iotdevice<br />
**ReferencingAttribute**: msdyn_lastcommandsent<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent<br />
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


### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent

Same as msdyn_customerasset entity [msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent](msdyn_customerasset.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent) Many-To-One relationship.

**ReferencingEntity**: msdyn_customerasset<br />
**ReferencingAttribute**: msdyn_lastcommandsent<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent<br />
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

- [lk_msdyn_iotdevicecommand_createdby](#BKMK_lk_msdyn_iotdevicecommand_createdby)
- [lk_msdyn_iotdevicecommand_createdonbehalfby](#BKMK_lk_msdyn_iotdevicecommand_createdonbehalfby)
- [lk_msdyn_iotdevicecommand_modifiedby](#BKMK_lk_msdyn_iotdevicecommand_modifiedby)
- [lk_msdyn_iotdevicecommand_modifiedonbehalfby](#BKMK_lk_msdyn_iotdevicecommand_modifiedonbehalfby)
- [user_msdyn_iotdevicecommand](#BKMK_user_msdyn_iotdevicecommand)
- [team_msdyn_iotdevicecommand](#BKMK_team_msdyn_iotdevicecommand)
- [business_unit_msdyn_iotdevicecommand](#BKMK_business_unit_msdyn_iotdevicecommand)
- [msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device)
- [msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert](#BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert)
- [msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset)


### <a name="BKMK_lk_msdyn_iotdevicecommand_createdby"></a> lk_msdyn_iotdevicecommand_createdby

See systemuser Entity [lk_msdyn_iotdevicecommand_createdby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdevicecommand_createdonbehalfby"></a> lk_msdyn_iotdevicecommand_createdonbehalfby

See systemuser Entity [lk_msdyn_iotdevicecommand_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdevicecommand_modifiedby"></a> lk_msdyn_iotdevicecommand_modifiedby

See systemuser Entity [lk_msdyn_iotdevicecommand_modifiedby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdevicecommand_modifiedonbehalfby"></a> lk_msdyn_iotdevicecommand_modifiedonbehalfby

See systemuser Entity [lk_msdyn_iotdevicecommand_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_iotdevicecommand"></a> user_msdyn_iotdevicecommand

See systemuser Entity [user_msdyn_iotdevicecommand](systemuser.md#BKMK_user_msdyn_iotdevicecommand) One-To-Many relationship.

### <a name="BKMK_team_msdyn_iotdevicecommand"></a> team_msdyn_iotdevicecommand

See team Entity [team_msdyn_iotdevicecommand](team.md#BKMK_team_msdyn_iotdevicecommand) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_iotdevicecommand"></a> business_unit_msdyn_iotdevicecommand

See businessunit Entity [business_unit_msdyn_iotdevicecommand](businessunit.md#BKMK_business_unit_msdyn_iotdevicecommand) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device

See msdyn_iotdevice Entity [msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device](msdyn_iotdevice.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert"></a> msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert

See msdyn_iotalert Entity [msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_iotdevicecommand?text=msdyn_iotdevicecommand EntityType" />