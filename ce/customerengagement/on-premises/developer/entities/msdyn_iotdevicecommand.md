---
title: "msdyn_iotdevicecommand Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_iotdevicecommand entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# msdyn_iotdevicecommand Entity Reference

Represents an outgoing message to a device connected to an IoT hub.

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdevicecommands(*msdyn_iotdevicecommandid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_iotdevicecommands|
|DisplayCollectionName|IoT Device Commands|
|DisplayName|IoT Device Command|
|EntitySetName|msdyn_iotdevicecommands|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_iotdevicecommands|
|LogicalName|msdyn_iotdevicecommand|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_iotdevicecommandid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_iotdevicecommand|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Command](#BKMK_msdyn_Command)
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

|Property|Value|
|--------|-----|
|Description|Sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_Command"></a> msdyn_Command

|Property|Value|
|--------|-----|
|Description|This optional field denotes the command definition that is used to construct the command string.|
|DisplayName|Command|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_command|
|RequiredLevel|None|
|Targets|msdyn_iotdevicecommanddefinition|
|Type|Lookup|


### <a name="BKMK_msdyn_CommandStatus"></a> msdyn_CommandStatus

|Property|Value|
|--------|-----|
|Description|Describes the status of the command. If this stays at "In Progress" for a long time, verify the IoT endpoint configuration.|
|DisplayName|Command Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_commandstatus|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_CommandStatus Options

|Value|Label|
|-----|-----|
|192350000|In Progress|
|192350001|Sent|
|192350002|Error|



### <a name="BKMK_msdyn_CommandStatusReason"></a> msdyn_CommandStatusReason

|Property|Value|
|--------|-----|
|Description|A reason field that explains the command status.|
|DisplayName|Command Status Reason|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_commandstatusreason|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution

|Property|Value|
|--------|-----|
|Description|The command will be sent to a device connected to this asset.|
|DisplayName|Customer Asset|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customerasset|
|RequiredLevel|None|
|Targets|msdyn_customerasset|
|Type|Lookup|


### <a name="BKMK_msdyn_Device"></a> msdyn_Device

|Property|Value|
|--------|-----|
|Description|IoT device to send the message to.|
|DisplayName|Device|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_device|
|RequiredLevel|None|
|Targets|msdyn_iotdevice|
|Type|Lookup|


### <a name="BKMK_msdyn_DeviceID"></a> msdyn_DeviceID

|Property|Value|
|--------|-----|
|Description|The ID of the IoT device to send the message to.|
|DisplayName|Device ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deviceid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_iotdevicecommandId"></a> msdyn_iotdevicecommandId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|IoT Device Command|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_iotdevicecommandid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_Message"></a> msdyn_Message

|Property|Value|
|--------|-----|
|Description|Message to send to the IoT device. E.g.: A Json string.|
|DisplayName|Message|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_message|
|MaxLength|8192|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_ParentAlert"></a> msdyn_ParentAlert

|Property|Value|
|--------|-----|
|Description|Reference to a parent alert in response to which the message is being sent.|
|DisplayName|Parent Alert|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_parentalert|
|RequiredLevel|None|
|Targets|msdyn_iotalert|
|Type|Lookup|


### <a name="BKMK_msdyn_SendToAllConnectedDevices"></a> msdyn_SendToAllConnectedDevices

|Property|Value|
|--------|-----|
|Description|Yes, if a copy of the command should be sent to all registered devices connected under the parent entity of the selected device. No, if this command needs to be sent only to the selected device.|
|DisplayName|Send To All Connected Devices|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_sendtoallconnecteddevices|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_SendToAllConnectedDevices Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the IoT Device Command|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the IoT Device Command|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

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
- [msdyn_CommandName](#BKMK_msdyn_CommandName)
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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the record.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the record was modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_CommandName"></a> msdyn_CommandName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_commandname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CustomerAssetName"></a> msdyn_CustomerAssetName

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_customerassetname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DeviceName"></a> msdyn_DeviceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_devicename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ParentAlertName"></a> msdyn_ParentAlertName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_parentalertname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_iotdevicecommand_SyncErrors](#BKMK_msdyn_iotdevicecommand_SyncErrors)
- [msdyn_iotdevicecommand_DuplicateMatchingRecord](#BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord)
- [msdyn_iotdevicecommand_DuplicateBaseRecord](#BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord)
- [msdyn_iotdevicecommand_AsyncOperations](#BKMK_msdyn_iotdevicecommand_AsyncOperations)
- [msdyn_iotdevicecommand_MailboxTrackingFolders](#BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders)
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

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_iotdevicecommand_SyncErrors](syncerror.md#BKMK_msdyn_iotdevicecommand_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevicecommand_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord"></a> msdyn_iotdevicecommand_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_iotdevicecommand_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevicecommand_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord"></a> msdyn_iotdevicecommand_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_iotdevicecommand_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevicecommand_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevicecommand_AsyncOperations"></a> msdyn_iotdevicecommand_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_iotdevicecommand_AsyncOperations](asyncoperation.md#BKMK_msdyn_iotdevicecommand_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevicecommand_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders"></a> msdyn_iotdevicecommand_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_iotdevicecommand_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevicecommand_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevicecommand_ProcessSession"></a> msdyn_iotdevicecommand_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_iotdevicecommand_ProcessSession](processsession.md#BKMK_msdyn_iotdevicecommand_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevicecommand_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevicecommand_BulkDeleteFailures"></a> msdyn_iotdevicecommand_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_iotdevicecommand_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iotdevicecommand_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevicecommand_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses"></a> msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevicecommand_connections1"></a> msdyn_iotdevicecommand_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_iotdevicecommand_connections1](connection.md#BKMK_msdyn_iotdevicecommand_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevicecommand_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevicecommand_connections2"></a> msdyn_iotdevicecommand_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_iotdevicecommand_connections2](connection.md#BKMK_msdyn_iotdevicecommand_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevicecommand_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevicecommand_Annotations"></a> msdyn_iotdevicecommand_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_iotdevicecommand_Annotations](annotation.md#BKMK_msdyn_iotdevicecommand_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevicecommand_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent

Same as msdyn_iotalert entity [msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotalert|
|ReferencingAttribute|msdyn_lastcommandsent|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_iotdevicecommand_msdyn_iotalert_LastCommandSent|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent

Same as msdyn_iotdevice entity [msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent](msdyn_iotdevice.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevice|
|ReferencingAttribute|msdyn_lastcommandsent|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution

Same as msdyn_customerasset entity [msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent](msdyn_customerasset.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_customerasset|
|ReferencingAttribute|msdyn_lastcommandsent|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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
- [msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert](#BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert)
- [msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device)
- [msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command](#BKMK_msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command)
- [msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset)


### <a name="BKMK_lk_msdyn_iotdevicecommand_createdby"></a> lk_msdyn_iotdevicecommand_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotdevicecommand_createdby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdevicecommand_createdonbehalfby"></a> lk_msdyn_iotdevicecommand_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotdevicecommand_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdevicecommand_modifiedby"></a> lk_msdyn_iotdevicecommand_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotdevicecommand_modifiedby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdevicecommand_modifiedonbehalfby"></a> lk_msdyn_iotdevicecommand_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotdevicecommand_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevicecommand_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_iotdevicecommand"></a> user_msdyn_iotdevicecommand

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_iotdevicecommand](systemuser.md#BKMK_user_msdyn_iotdevicecommand) One-To-Many relationship.

### <a name="BKMK_team_msdyn_iotdevicecommand"></a> team_msdyn_iotdevicecommand

**Added by**: System Solution Solution

See team Entity [team_msdyn_iotdevicecommand](team.md#BKMK_team_msdyn_iotdevicecommand) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_iotdevicecommand"></a> business_unit_msdyn_iotdevicecommand

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_iotdevicecommand](businessunit.md#BKMK_business_unit_msdyn_iotdevicecommand) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert"></a> msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert

See msdyn_iotalert Entity [msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotalert_msdyn_iotdevicecommand_ParentAlert) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device

See msdyn_iotdevice Entity [msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device](msdyn_iotdevice.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command"></a> msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command

See msdyn_iotdevicecommanddefinition Entity [msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command](msdyn_iotdevicecommanddefinition.md#BKMK_msdyn_msdyn_iotdevicecommanddefinition_msdyn_iotdevicecommand_Command) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset

**Added by**: Field Service Solution

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_iotdevicecommand?text=msdyn_iotdevicecommand EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]