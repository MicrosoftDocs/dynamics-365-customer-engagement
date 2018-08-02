---
title: "msdyn_customerasset Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_customerasset entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_customerasset Entity Reference



**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_customerassets(*msdyn_customerassetid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_customerassets<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_customerassets(*msdyn_customerassetid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_customerassets(*msdyn_customerassetid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_customerassets<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_customerassets(*msdyn_customerassetid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_customerassets(*msdyn_customerassetid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_customerassets|
|DisplayCollectionName|Customer Assets|
|DisplayName|Customer Asset|
|EntitySetName|msdyn_customerassets|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_customerassets|
|LogicalName|msdyn_customerasset|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_customerassetid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_customerasset|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Account](#BKMK_msdyn_Account)
- [msdyn_customerassetId](#BKMK_msdyn_customerassetId)
- [msdyn_DeviceId](#BKMK_msdyn_DeviceId)
- [msdyn_LastCommandSent](#BKMK_msdyn_LastCommandSent)
- [msdyn_LastCommandSentTime](#BKMK_msdyn_LastCommandSentTime)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_MasterAsset](#BKMK_msdyn_MasterAsset)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ParentAsset](#BKMK_msdyn_ParentAsset)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_RegistrationStatus](#BKMK_msdyn_RegistrationStatus)
- [msdyn_WorkOrderProduct](#BKMK_msdyn_WorkOrderProduct)
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
|Description|Shows the sequence number of the import that created this record.|
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
|Description|Parent Customer of this Asset|
|DisplayName|Account|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_account|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_customerassetId"></a> msdyn_customerassetId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Customer Asset|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_customerassetid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_DeviceId"></a> msdyn_DeviceId

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution<br />

|Property|Value|
|--------|-----|
|Description|Device ID used to register with IoT hub. This will not be used if there are two or more connected devices for this asset.|
|DisplayName|Device ID|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deviceid|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_LastCommandSent"></a> msdyn_LastCommandSent

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution<br />

|Property|Value|
|--------|-----|
|Description|The last command sent to any of the connected devices for this asset.|
|DisplayName|Last Command Sent|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lastcommandsent|
|RequiredLevel|None|
|Targets|msdyn_iotdevicecommand|
|Type|Lookup|


### <a name="BKMK_msdyn_LastCommandSentTime"></a> msdyn_LastCommandSentTime

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution<br />

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|The timestamp of the last command sent for any of the connected devices for this asset.|
|DisplayName|Last Command Sent Time|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lastcommandsenttime|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Latitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_latitude|
|MaxValue|90|
|MinValue|-90|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Longitude|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_longitude|
|MaxValue|180|
|MinValue|-180|
|Precision|5|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_MasterAsset"></a> msdyn_MasterAsset

|Property|Value|
|--------|-----|
|Description|Top level Asset, (if this asset is a sub asset)|
|DisplayName|Master Asset|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_masterasset|
|RequiredLevel|None|
|Targets|msdyn_customerasset|
|Type|Lookup|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Enter the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_ParentAsset"></a> msdyn_ParentAsset

|Property|Value|
|--------|-----|
|Description|Parent Asset|
|DisplayName|Parent Asset|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_parentasset|
|RequiredLevel|None|
|Targets|msdyn_customerasset|
|Type|Lookup|


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

|Property|Value|
|--------|-----|
|Description|Reference to Product associated with this Asset|
|DisplayName|Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_product|
|RequiredLevel|None|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_msdyn_RegistrationStatus"></a> msdyn_RegistrationStatus

**Added by**: Connected Field Service for Microsoft Dynamics 365 Solution<br />

|Property|Value|
|--------|-----|
|Description|A status field that denotes whether all the devices connected to this asset are registered with the IoT hub.|
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



### <a name="BKMK_msdyn_WorkOrderProduct"></a> msdyn_WorkOrderProduct

|Property|Value|
|--------|-----|
|Description|Indicates a link to the Work Order Product from where this Asset was auto created by the system.|
|DisplayName|Work Order Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderproduct|
|RequiredLevel|None|
|Targets|msdyn_workorderproduct|
|Type|Lookup|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

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
|Description|Status of the Customer Asset|
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
|Description|Reason for the status of the Customer Asset|
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
|Description|Shows the time zone code that was in use when the record was created.|
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
- [msdyn_LastCommandSentName](#BKMK_msdyn_LastCommandSentName)
- [msdyn_MasterAssetName](#BKMK_msdyn_MasterAssetName)
- [msdyn_ParentAssetName](#BKMK_msdyn_ParentAssetName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_WorkOrderProductName](#BKMK_msdyn_WorkOrderProductName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

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


### <a name="BKMK_msdyn_MasterAssetName"></a> msdyn_MasterAssetName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_masterassetname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ParentAssetName"></a> msdyn_ParentAssetName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_parentassetname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ProductName"></a> msdyn_ProductName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_productname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderProductName"></a> msdyn_WorkOrderProductName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workorderproductname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

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

- [msdyn_customerasset_ActivityPointers](#BKMK_msdyn_customerasset_ActivityPointers)
- [msdyn_customerasset_msdyn_approvals](#BKMK_msdyn_customerasset_msdyn_approvals)
- [msdyn_customerasset_msdyn_bookingalerts](#BKMK_msdyn_customerasset_msdyn_bookingalerts)
- [msdyn_customerasset_SyncErrors](#BKMK_msdyn_customerasset_SyncErrors)
- [msdyn_customerasset_DuplicateMatchingRecord](#BKMK_msdyn_customerasset_DuplicateMatchingRecord)
- [msdyn_customerasset_DuplicateBaseRecord](#BKMK_msdyn_customerasset_DuplicateBaseRecord)
- [msdyn_customerasset_AsyncOperations](#BKMK_msdyn_customerasset_AsyncOperations)
- [msdyn_customerasset_MailboxTrackingFolders](#BKMK_msdyn_customerasset_MailboxTrackingFolders)
- [msdyn_customerasset_UserEntityInstanceDatas](#BKMK_msdyn_customerasset_UserEntityInstanceDatas)
- [msdyn_customerasset_ProcessSession](#BKMK_msdyn_customerasset_ProcessSession)
- [msdyn_customerasset_BulkDeleteFailures](#BKMK_msdyn_customerasset_BulkDeleteFailures)
- [msdyn_customerasset_PrincipalObjectAttributeAccesses](#BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses)
- [msdyn_customerasset_Appointments](#BKMK_msdyn_customerasset_Appointments)
- [msdyn_customerasset_Emails](#BKMK_msdyn_customerasset_Emails)
- [msdyn_customerasset_Faxes](#BKMK_msdyn_customerasset_Faxes)
- [msdyn_customerasset_Letters](#BKMK_msdyn_customerasset_Letters)
- [msdyn_customerasset_PhoneCalls](#BKMK_msdyn_customerasset_PhoneCalls)
- [msdyn_customerasset_Tasks](#BKMK_msdyn_customerasset_Tasks)
- [msdyn_customerasset_RecurringAppointmentMasters](#BKMK_msdyn_customerasset_RecurringAppointmentMasters)
- [msdyn_customerasset_SocialActivities](#BKMK_msdyn_customerasset_SocialActivities)
- [msdyn_customerasset_connections1](#BKMK_msdyn_customerasset_connections1)
- [msdyn_customerasset_connections2](#BKMK_msdyn_customerasset_connections2)
- [msdyn_customerasset_Annotations](#BKMK_msdyn_customerasset_Annotations)
- [msdyn_customerasset_ServiceAppointments](#BKMK_msdyn_customerasset_ServiceAppointments)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset)
- [msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset)


### <a name="BKMK_msdyn_customerasset_ActivityPointers"></a> msdyn_customerasset_ActivityPointers

Same as activitypointer entity [msdyn_customerasset_ActivityPointers](activitypointer.md#BKMK_msdyn_customerasset_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_customerasset_msdyn_approvals"></a> msdyn_customerasset_msdyn_approvals

Same as msdyn_approval entity [msdyn_customerasset_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_customerasset_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_msdyn_bookingalerts"></a> msdyn_customerasset_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_customerasset_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_customerasset_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_SyncErrors"></a> msdyn_customerasset_SyncErrors

Same as syncerror entity [msdyn_customerasset_SyncErrors](syncerror.md#BKMK_msdyn_customerasset_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_DuplicateMatchingRecord"></a> msdyn_customerasset_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_customerasset_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_customerasset_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_customerasset_DuplicateBaseRecord"></a> msdyn_customerasset_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_customerasset_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_customerasset_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_customerasset_AsyncOperations"></a> msdyn_customerasset_AsyncOperations

Same as asyncoperation entity [msdyn_customerasset_AsyncOperations](asyncoperation.md#BKMK_msdyn_customerasset_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_customerasset_MailboxTrackingFolders"></a> msdyn_customerasset_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_customerasset_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_customerasset_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_UserEntityInstanceDatas"></a> msdyn_customerasset_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_customerasset_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_customerasset_UserEntityInstanceDatas) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_UserEntityInstanceDatas|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_customerasset_ProcessSession"></a> msdyn_customerasset_ProcessSession

Same as processsession entity [msdyn_customerasset_ProcessSession](processsession.md#BKMK_msdyn_customerasset_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_customerasset_BulkDeleteFailures"></a> msdyn_customerasset_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_customerasset_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_customerasset_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses"></a> msdyn_customerasset_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_customerasset_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_customerasset_Appointments"></a> msdyn_customerasset_Appointments

Same as appointment entity [msdyn_customerasset_Appointments](appointment.md#BKMK_msdyn_customerasset_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_Emails"></a> msdyn_customerasset_Emails

Same as email entity [msdyn_customerasset_Emails](email.md#BKMK_msdyn_customerasset_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_Faxes"></a> msdyn_customerasset_Faxes

Same as fax entity [msdyn_customerasset_Faxes](fax.md#BKMK_msdyn_customerasset_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_Letters"></a> msdyn_customerasset_Letters

Same as letter entity [msdyn_customerasset_Letters](letter.md#BKMK_msdyn_customerasset_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_PhoneCalls"></a> msdyn_customerasset_PhoneCalls

Same as phonecall entity [msdyn_customerasset_PhoneCalls](phonecall.md#BKMK_msdyn_customerasset_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_Tasks"></a> msdyn_customerasset_Tasks

Same as task entity [msdyn_customerasset_Tasks](task.md#BKMK_msdyn_customerasset_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_RecurringAppointmentMasters"></a> msdyn_customerasset_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_customerasset_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_customerasset_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_SocialActivities"></a> msdyn_customerasset_SocialActivities

Same as socialactivity entity [msdyn_customerasset_SocialActivities](socialactivity.md#BKMK_msdyn_customerasset_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_connections1"></a> msdyn_customerasset_connections1

Same as connection entity [msdyn_customerasset_connections1](connection.md#BKMK_msdyn_customerasset_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_customerasset_connections2"></a> msdyn_customerasset_connections2

Same as connection entity [msdyn_customerasset_connections2](connection.md#BKMK_msdyn_customerasset_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_customerasset_Annotations"></a> msdyn_customerasset_Annotations

Same as annotation entity [msdyn_customerasset_Annotations](annotation.md#BKMK_msdyn_customerasset_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_customerasset_ServiceAppointments"></a> msdyn_customerasset_ServiceAppointments

Same as serviceappointment entity [msdyn_customerasset_ServiceAppointments](serviceappointment.md#BKMK_msdyn_customerasset_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_customerasset_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset

Same as msdyn_agreementbookingincident entity [msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingincident|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Customer Asset<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset

Same as msdyn_agreementbookingproduct entity [msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingproduct|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset

Same as msdyn_agreementbookingservice entity [msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservice|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset

Same as msdyn_agreementbookingservicetask entity [msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_agreementbookingservicetask|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset"></a> msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset

Same as msdyn_customerasset entity [msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_customerasset|
|ReferencingAttribute|msdyn_masterasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Items of Master Asset<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset"></a> msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset

Same as msdyn_customerasset entity [msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_customerasset|
|ReferencingAttribute|msdyn_parentasset|
|IsHierarchical|True|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset|
|AssociatedMenuConfiguration|Behavior: UseLabel<br />Group: Details<br />Label: Items of Parent Asset<br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset

Same as msdyn_quotebookingincident entity [msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingincident|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset

Same as msdyn_quotebookingproduct entity [msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset](msdyn_quotebookingproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingproduct|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset

Same as msdyn_quotebookingservice entity [msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset](msdyn_quotebookingservice.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservice|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset

Same as msdyn_quotebookingservicetask entity [msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset](msdyn_quotebookingservicetask.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotebookingservicetask|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset

Same as msdyn_rmaproduct entity [msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmaproduct|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset

Same as msdyn_workorder entity [msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](msdyn_workorder.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorder|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset

Same as msdyn_workorderincident entity [msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](msdyn_workorderincident.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderincident|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset

Same as msdyn_workorderproduct entity [msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderproduct|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset

Same as msdyn_workorderservice entity [msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](msdyn_workorderservice.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservice|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset

Same as msdyn_workorderservicetask entity [msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](msdyn_workorderservicetask.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderservicetask|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset

Same as msdyn_iotalert entity [msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset](msdyn_iotalert.md#BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotalert|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset

Same as msdyn_iotdevicecommand entity [msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_iotdevicecommand|
|ReferencingAttribute|msdyn_customerasset|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_customerasset_createdby](#BKMK_lk_msdyn_customerasset_createdby)
- [lk_msdyn_customerasset_createdonbehalfby](#BKMK_lk_msdyn_customerasset_createdonbehalfby)
- [lk_msdyn_customerasset_modifiedby](#BKMK_lk_msdyn_customerasset_modifiedby)
- [lk_msdyn_customerasset_modifiedonbehalfby](#BKMK_lk_msdyn_customerasset_modifiedonbehalfby)
- [user_msdyn_customerasset](#BKMK_user_msdyn_customerasset)
- [team_msdyn_customerasset](#BKMK_team_msdyn_customerasset)
- [business_unit_msdyn_customerasset](#BKMK_business_unit_msdyn_customerasset)
- [msdyn_account_msdyn_customerasset_Account](#BKMK_msdyn_account_msdyn_customerasset_Account)
- [msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset)
- [msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset)
- [msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct)
- [msdyn_product_msdyn_customerasset_Product](#BKMK_msdyn_product_msdyn_customerasset_Product)
- [msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent)


### <a name="BKMK_lk_msdyn_customerasset_createdby"></a> lk_msdyn_customerasset_createdby

See systemuser Entity [lk_msdyn_customerasset_createdby](systemuser.md#BKMK_lk_msdyn_customerasset_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_customerasset_createdonbehalfby"></a> lk_msdyn_customerasset_createdonbehalfby

See systemuser Entity [lk_msdyn_customerasset_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_customerasset_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_customerasset_modifiedby"></a> lk_msdyn_customerasset_modifiedby

See systemuser Entity [lk_msdyn_customerasset_modifiedby](systemuser.md#BKMK_lk_msdyn_customerasset_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_customerasset_modifiedonbehalfby"></a> lk_msdyn_customerasset_modifiedonbehalfby

See systemuser Entity [lk_msdyn_customerasset_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_customerasset_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_customerasset"></a> user_msdyn_customerasset

See systemuser Entity [user_msdyn_customerasset](systemuser.md#BKMK_user_msdyn_customerasset) One-To-Many relationship.

### <a name="BKMK_team_msdyn_customerasset"></a> team_msdyn_customerasset

See team Entity [team_msdyn_customerasset](team.md#BKMK_team_msdyn_customerasset) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_customerasset"></a> business_unit_msdyn_customerasset

See businessunit Entity [business_unit_msdyn_customerasset](businessunit.md#BKMK_business_unit_msdyn_customerasset) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_customerasset_Account"></a> msdyn_account_msdyn_customerasset_Account

See account Entity [msdyn_account_msdyn_customerasset_Account](account.md#BKMK_msdyn_account_msdyn_customerasset_Account) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset"></a> msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset"></a> msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct

See msdyn_workorderproduct Entity [msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_customerasset_Product"></a> msdyn_product_msdyn_customerasset_Product

See product Entity [msdyn_product_msdyn_customerasset_Product](product.md#BKMK_msdyn_product_msdyn_customerasset_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent

See msdyn_iotdevicecommand Entity [msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_customerasset?text=msdyn_customerasset EntityType" />