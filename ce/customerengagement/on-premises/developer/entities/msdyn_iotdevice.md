---
title: "msdyn_iotdevice Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_iotdevice entity."
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
# msdyn_iotdevice Entity Reference

Represents a connected device that can registered with an IoT hub.

**Added by**: IoT Connector for Microsoft Dynamics 365 Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdevices(*msdyn_iotdeviceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_iotdevices<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_iotdevices(*msdyn_iotdeviceid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_iotdevices(*msdyn_iotdeviceid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_iotdevices<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdevices(*msdyn_iotdeviceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_iotdevices(*msdyn_iotdeviceid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_iotdevices|
|DisplayCollectionName|IoT Devices|
|DisplayName|IoT Device|
|EntitySetName|msdyn_iotdevices|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_iotdevices|
|LogicalName|msdyn_iotdevice|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_iotdeviceid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_iotdevice|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Account](#BKMK_msdyn_Account)
- [msdyn_Category](#BKMK_msdyn_Category)
- [msdyn_ConnectionState](#BKMK_msdyn_ConnectionState)
- [msdyn_DeviceId](#BKMK_msdyn_DeviceId)
- [msdyn_DeviceReportedProperties](#BKMK_msdyn_DeviceReportedProperties)
- [msdyn_DeviceSettings](#BKMK_msdyn_DeviceSettings)
- [msdyn_iotdeviceId](#BKMK_msdyn_iotdeviceId)
- [msdyn_IsSimulated](#BKMK_msdyn_IsSimulated)
- [msdyn_LastActivityTime](#BKMK_msdyn_LastActivityTime)
- [msdyn_LastCommandSent](#BKMK_msdyn_LastCommandSent)
- [msdyn_LastCommandSentTime](#BKMK_msdyn_LastCommandSentTime)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_RegistrationMessage](#BKMK_msdyn_RegistrationMessage)
- [msdyn_RegistrationStatus](#BKMK_msdyn_RegistrationStatus)
- [msdyn_Tags](#BKMK_msdyn_Tags)
- [msdyn_Timezone](#BKMK_msdyn_Timezone)
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


### <a name="BKMK_msdyn_Account"></a> msdyn_Account

|Property|Value|
|--------|-----|
|Description|Parent customer of this device|
|DisplayName|Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_account|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_Category"></a> msdyn_Category

|Property|Value|
|--------|-----|
|Description|The device category that this IoT device belongs to.|
|DisplayName|Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_category|
|RequiredLevel|None|
|Targets|msdyn_iotdevicecategory|
|Type|Lookup|


### <a name="BKMK_msdyn_ConnectionState"></a> msdyn_ConnectionState

|Property|Value|
|--------|-----|
|Description|The connection status of the device (Disconnected or Connected)|
|DisplayName|Connection State|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_connectionstate|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_ConnectionState Options

|Value|Label|
|-----|-----|
|1|Connected|
|0|Disconnected|

**DefaultValue**: False



### <a name="BKMK_msdyn_DeviceId"></a> msdyn_DeviceId

|Property|Value|
|--------|-----|
|Description|Device ID used to register with IoT hub.|
|DisplayName|Device ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deviceid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DeviceReportedProperties"></a> msdyn_DeviceReportedProperties

|Property|Value|
|--------|-----|
|Description|Reported Properties data for Device|
|DisplayName|Device Reported Properties|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_devicereportedproperties|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_DeviceSettings"></a> msdyn_DeviceSettings

|Property|Value|
|--------|-----|
|Description|The editable properties for a device.|
|DisplayName|Device Settings|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_devicesettings|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_iotdeviceId"></a> msdyn_iotdeviceId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|IoT Device|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_iotdeviceid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_IsSimulated"></a> msdyn_IsSimulated

|Property|Value|
|--------|-----|
|Description|Select “Yes” if this device is simulated for testing and development purposes. Select “No” if this is a real device.​|
|DisplayName|Simulated|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_issimulated|
|RequiredLevel|Recommended|
|Type|Picklist|

#### msdyn_IsSimulated Options

|Value|Label|
|-----|-----|
|192350000|Yes|
|192350001|No|



### <a name="BKMK_msdyn_LastActivityTime"></a> msdyn_LastActivityTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|The last activity time of the device|
|DisplayName|Last Activity Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lastactivitytime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_LastCommandSent"></a> msdyn_LastCommandSent

|Property|Value|
|--------|-----|
|Description||
|DisplayName|[Deprecated] Last Command Sent|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lastcommandsent|
|RequiredLevel|None|
|Targets|msdyn_iotdevicecommand|
|Type|Lookup|


### <a name="BKMK_msdyn_LastCommandSentTime"></a> msdyn_LastCommandSentTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName|[Deprecated] Last Command Sent Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lastcommandsenttime|
|RequiredLevel|None|
|Type|DateTime|


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


### <a name="BKMK_msdyn_RegistrationMessage"></a> msdyn_RegistrationMessage

|Property|Value|
|--------|-----|
|Description|A message field that explains the IoT Registration Status.|
|DisplayName|Registration Message|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_registrationmessage|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_RegistrationStatus"></a> msdyn_RegistrationStatus

|Property|Value|
|--------|-----|
|Description|A status field that denotes whether the device is registered with the IoT hub.|
|DisplayName|Registration Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_registrationstatus|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_RegistrationStatus Options

|Value|Label|
|-----|-----|
|192350000|Unknown|
|192350001|Unregistered|
|192350002|In Progress|
|192350003|Registered|
|192350004|Error|



### <a name="BKMK_msdyn_Tags"></a> msdyn_Tags

|Property|Value|
|--------|-----|
|Description|Identifying Tags for the Device|
|DisplayName|Device Tags|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_tags|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_Timezone"></a> msdyn_Timezone

|Property|Value|
|--------|-----|
|Description|The device's time zone.|
|DisplayName|Time Zone|
|Format|TimeZone|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_timezone|
|MaxValue|1500|
|MinValue|-1500|
|RequiredLevel|None|
|Type|Integer|


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
|Description|Status of the IoT Device|
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
|Description|Reason for the status of the IoT Device|
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
- [msdyn_AccountName](#BKMK_msdyn_AccountName)
- [msdyn_AccountYomiName](#BKMK_msdyn_AccountYomiName)
- [msdyn_CategoryName](#BKMK_msdyn_CategoryName)
- [msdyn_LastCommandSentName](#BKMK_msdyn_LastCommandSentName)
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


### <a name="BKMK_msdyn_AccountName"></a> msdyn_AccountName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_accountname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AccountYomiName"></a> msdyn_AccountYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_accountyominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CategoryName"></a> msdyn_CategoryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_categoryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_LastCommandSentName"></a> msdyn_LastCommandSentName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_lastcommandsentname|
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

- [msdyn_iotdevice_SyncErrors](#BKMK_msdyn_iotdevice_SyncErrors)
- [msdyn_iotdevice_DuplicateMatchingRecord](#BKMK_msdyn_iotdevice_DuplicateMatchingRecord)
- [msdyn_iotdevice_DuplicateBaseRecord](#BKMK_msdyn_iotdevice_DuplicateBaseRecord)
- [msdyn_iotdevice_AsyncOperations](#BKMK_msdyn_iotdevice_AsyncOperations)
- [msdyn_iotdevice_MailboxTrackingFolders](#BKMK_msdyn_iotdevice_MailboxTrackingFolders)
- [msdyn_iotdevice_ProcessSession](#BKMK_msdyn_iotdevice_ProcessSession)
- [msdyn_iotdevice_BulkDeleteFailures](#BKMK_msdyn_iotdevice_BulkDeleteFailures)
- [msdyn_iotdevice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotdevice_PrincipalObjectAttributeAccesses)
- [msdyn_iotdevice_connections1](#BKMK_msdyn_iotdevice_connections1)
- [msdyn_iotdevice_connections2](#BKMK_msdyn_iotdevice_connections2)
- [msdyn_iotdevice_Annotations](#BKMK_msdyn_iotdevice_Annotations)
- [msdyn_msdyn_iotdevice_msdyn_iotalert_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotalert_Device)
- [msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device)
- [msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device)
- [msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device](#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device)


### <a name="BKMK_msdyn_iotdevice_SyncErrors"></a> msdyn_iotdevice_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_iotdevice_SyncErrors](syncerror.md#BKMK_msdyn_iotdevice_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevice_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevice_DuplicateMatchingRecord"></a> msdyn_iotdevice_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_iotdevice_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_iotdevice_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevice_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevice_DuplicateBaseRecord"></a> msdyn_iotdevice_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_iotdevice_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_iotdevice_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevice_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevice_AsyncOperations"></a> msdyn_iotdevice_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_iotdevice_AsyncOperations](asyncoperation.md#BKMK_msdyn_iotdevice_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevice_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevice_MailboxTrackingFolders"></a> msdyn_iotdevice_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_iotdevice_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_iotdevice_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevice_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevice_ProcessSession"></a> msdyn_iotdevice_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_iotdevice_ProcessSession](processsession.md#BKMK_msdyn_iotdevice_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevice_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevice_BulkDeleteFailures"></a> msdyn_iotdevice_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_iotdevice_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_iotdevice_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevice_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevice_PrincipalObjectAttributeAccesses"></a> msdyn_iotdevice_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_iotdevice_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_iotdevice_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevice_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevice_connections1"></a> msdyn_iotdevice_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_iotdevice_connections1](connection.md#BKMK_msdyn_iotdevice_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevice_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevice_connections2"></a> msdyn_iotdevice_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_iotdevice_connections2](connection.md#BKMK_msdyn_iotdevice_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevice_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_iotdevice_Annotations"></a> msdyn_iotdevice_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_iotdevice_Annotations](annotation.md#BKMK_msdyn_iotdevice_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_iotdevice_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotalert_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotalert_Device

Same as msdyn_iotalert entity [msdyn_msdyn_iotdevice_msdyn_iotalert_Device](msdyn_iotalert.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotalert_Device) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotalert|
|ReferencingAttribute|msdyn_device|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_iotdevice_msdyn_iotalert_Device|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device

Same as msdyn_iotdevicecommand entity [msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevicecommand|
|ReferencingAttribute|msdyn_device|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_iotdevice_msdyn_iotdevicecommand_Device|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device

Same as msdyn_iotdeviceregistrationhistory entity [msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdeviceregistrationhistory|
|ReferencingAttribute|msdyn_device|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_iotdevice_msdyn_iotdeviceregistrationhistory_Device|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device"></a> msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device

Same as msdyn_iotdevicedatahistory entity [msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device](msdyn_iotdevicedatahistory.md#BKMK_msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevicedatahistory|
|ReferencingAttribute|msdyn_device|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_iotdevice_msdyn_iotdevicedatahistory_Device|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_iotdevice_createdby](#BKMK_lk_msdyn_iotdevice_createdby)
- [lk_msdyn_iotdevice_createdonbehalfby](#BKMK_lk_msdyn_iotdevice_createdonbehalfby)
- [lk_msdyn_iotdevice_modifiedby](#BKMK_lk_msdyn_iotdevice_modifiedby)
- [lk_msdyn_iotdevice_modifiedonbehalfby](#BKMK_lk_msdyn_iotdevice_modifiedonbehalfby)
- [user_msdyn_iotdevice](#BKMK_user_msdyn_iotdevice)
- [team_msdyn_iotdevice](#BKMK_team_msdyn_iotdevice)
- [business_unit_msdyn_iotdevice](#BKMK_business_unit_msdyn_iotdevice)
- [msdyn_account_msdyn_iotdevice_Account](#BKMK_msdyn_account_msdyn_iotdevice_Account)
- [msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category](#BKMK_msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category)
- [msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent)


### <a name="BKMK_lk_msdyn_iotdevice_createdby"></a> lk_msdyn_iotdevice_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotdevice_createdby](systemuser.md#BKMK_lk_msdyn_iotdevice_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdevice_createdonbehalfby"></a> lk_msdyn_iotdevice_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotdevice_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevice_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdevice_modifiedby"></a> lk_msdyn_iotdevice_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotdevice_modifiedby](systemuser.md#BKMK_lk_msdyn_iotdevice_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_iotdevice_modifiedonbehalfby"></a> lk_msdyn_iotdevice_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_iotdevice_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_iotdevice_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_iotdevice"></a> user_msdyn_iotdevice

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_iotdevice](systemuser.md#BKMK_user_msdyn_iotdevice) One-To-Many relationship.

### <a name="BKMK_team_msdyn_iotdevice"></a> team_msdyn_iotdevice

**Added by**: System Solution Solution

See team Entity [team_msdyn_iotdevice](team.md#BKMK_team_msdyn_iotdevice) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_iotdevice"></a> business_unit_msdyn_iotdevice

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_iotdevice](businessunit.md#BKMK_business_unit_msdyn_iotdevice) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_iotdevice_Account"></a> msdyn_account_msdyn_iotdevice_Account

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_iotdevice_Account](account.md#BKMK_msdyn_account_msdyn_iotdevice_Account) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category"></a> msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category

See msdyn_iotdevicecategory Entity [msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category](msdyn_iotdevicecategory.md#BKMK_msdyn_msdyn_iotdevicecategory_msdyn_iotdevice_Category) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent

See msdyn_iotdevicecommand Entity [msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_iotdevice_LastCommandSent) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_iotdevice?text=msdyn_iotdevice EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]