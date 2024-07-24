---
title: "Customer Asset (msdyn_customerasset) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Customer Asset (msdyn_customerasset) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Customer Asset (msdyn_customerasset) table/entity reference

Specify Customer Asset.

## Messages

The following table lists the messages for the Customer Asset (msdyn_customerasset) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_customerassets(*msdyn_customerassetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_customerassets<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_customerassets(*msdyn_customerassetid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_customerassets(*msdyn_customerassetid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_customerassets<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_customerassets(*msdyn_customerassetid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_customerassets(*msdyn_customerassetid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_customerassets(*msdyn_customerassetid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Customer Asset (msdyn_customerasset) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Customer Asset (msdyn_customerasset) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Customer Asset** |
| **DisplayCollectionName** | **Customer Assets** |
| **SchemaName** | `msdyn_customerasset` |
| **CollectionSchemaName** | `msdyn_customerassets` |
| **EntitySetName** | `msdyn_customerassets`|
| **LogicalName** | `msdyn_customerasset` |
| **LogicalCollectionName** | `msdyn_customerassets` |
| **PrimaryIdAttribute** | `msdyn_customerassetid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Account](#BKMK_msdyn_Account)
- [msdyn_AssetTag](#BKMK_msdyn_AssetTag)
- [msdyn_CustomerAssetCategory](#BKMK_msdyn_CustomerAssetCategory)
- [msdyn_customerassetId](#BKMK_msdyn_customerassetId)
- [msdyn_DeviceId](#BKMK_msdyn_DeviceId)
- [msdyn_FunctionalLocation](#BKMK_msdyn_FunctionalLocation)
- [msdyn_LastCommandSent](#BKMK_msdyn_LastCommandSent)
- [msdyn_LastCommandSentTime](#BKMK_msdyn_LastCommandSentTime)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_ManufacturingDate](#BKMK_msdyn_ManufacturingDate)
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
|---|---|
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_Account"></a> msdyn_Account

|Property|Value|
|---|---|
|Description|**Parent Customer of this Asset**|
|DisplayName|**Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_account`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|account|

### <a name="BKMK_msdyn_AssetTag"></a> msdyn_AssetTag

|Property|Value|
|---|---|
|Description||
|DisplayName|**Asset Tag**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assettag`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CustomerAssetCategory"></a> msdyn_CustomerAssetCategory

|Property|Value|
|---|---|
|Description|**The category of the customer asset**|
|DisplayName|**Category**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerassetcategory`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerassetcategory|

### <a name="BKMK_msdyn_customerassetId"></a> msdyn_customerassetId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Customer Asset**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_customerassetid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_DeviceId"></a> msdyn_DeviceId

|Property|Value|
|---|---|
|Description|**Device ID used to register with the IoT provider. This will not be used if there are two or more connected devices for this asset. This value will be updated based on the connected devices.**|
|DisplayName|**Device ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_deviceid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_FunctionalLocation"></a> msdyn_FunctionalLocation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Functional Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_functionallocation`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_functionallocation|

### <a name="BKMK_msdyn_LastCommandSent"></a> msdyn_LastCommandSent

|Property|Value|
|---|---|
|Description|**The last command sent to any of the connected devices for this asset.**|
|DisplayName|**Last Command Sent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastcommandsent`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_iotdevicecommand|

### <a name="BKMK_msdyn_LastCommandSentTime"></a> msdyn_LastCommandSentTime

|Property|Value|
|---|---|
|Description|**The timestamp of the last command sent for any of the connected devices for this asset.**|
|DisplayName|**Last Command Sent Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastcommandsenttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

|Property|Value|
|---|---|
|Description||
|DisplayName|**Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_msdyn_ManufacturingDate"></a> msdyn_ManufacturingDate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Manufacturing Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_manufacturingdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_MasterAsset"></a> msdyn_MasterAsset

|Property|Value|
|---|---|
|Description|**Top-Level Asset, (if this asset is a sub asset)**|
|DisplayName|**Top-Level Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_masterasset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerasset|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ParentAsset"></a> msdyn_ParentAsset

|Property|Value|
|---|---|
|Description|**Parent Asset**|
|DisplayName|**Parent Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_parentasset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerasset|

### <a name="BKMK_msdyn_Product"></a> msdyn_Product

|Property|Value|
|---|---|
|Description|**Reference to Product associated with this Asset**|
|DisplayName|**Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_product`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_msdyn_RegistrationStatus"></a> msdyn_RegistrationStatus

|Property|Value|
|---|---|
|Description|**A status field that denotes whether all the devices connected to this asset are registered with the IoT provider.**|
|DisplayName|**Registration Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_registrationstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_customerasset_msdyn_registrationstatus`|

#### msdyn_RegistrationStatus Choices/Options

|Value|Label|
|---|---|
|192350000|**Unknown**|
|192350001|**Unregistered**|
|192350002|**In Progress**|
|192350003|**Registered**|
|192350004|**Error**|

### <a name="BKMK_msdyn_WorkOrderProduct"></a> msdyn_WorkOrderProduct

|Property|Value|
|---|---|
|Description|**Indicates a link to the Work Order Product from where this Asset was auto created by the system.**|
|DisplayName|**Work Order Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorderproduct|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
|DisplayName|**Record Created On**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overriddencreatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|---|---|
|Description|**Owner Id**|
|DisplayName|**Owner**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`ownerid`|
|RequiredLevel|SystemRequired|
|Type|Owner|
|Targets|systemuser, team|

### <a name="BKMK_OwnerIdType"></a> OwnerIdType

|Property|Value|
|---|---|
|Description|**Owner Id Type**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridtype`|
|RequiredLevel|SystemRequired|
|Type|EntityName|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Customer Asset**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_customerasset_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Customer Asset**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_customerasset_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time Zone Rule Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`timezoneruleversionnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|

### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|---|---|
|Description|**Shows the time zone code that was in use when the record was created.**|
|DisplayName|**UTC Conversion Time Zone Code**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`utcconversiontimezonecode`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-1|


## Read-only columns/attributes

These columns/attributes return false for both **IsValidForCreate** and **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_alert](#BKMK_msdyn_alert)
- [msdyn_alertcount](#BKMK_msdyn_alertcount)
- [msdyn_alertcount_Date](#BKMK_msdyn_alertcount_Date)
- [msdyn_alertcount_State](#BKMK_msdyn_alertcount_State)
- [msdyn_LastAlertTime](#BKMK_msdyn_LastAlertTime)
- [msdyn_LastAlertTime_Date](#BKMK_msdyn_LastAlertTime_Date)
- [msdyn_LastAlertTime_State](#BKMK_msdyn_LastAlertTime_State)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record.**|
|DisplayName|**Created By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
|DisplayName|**Created On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Shows who created the record on behalf of another user.**|
|DisplayName|**Created By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`createdonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who modified the record.**|
|DisplayName|**Modified By**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
|DisplayName|**Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|---|---|
|Description|**Shows who last updated the record on behalf of another user.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_alert"></a> msdyn_alert

|Property|Value|
|---|---|
|Description|**If active parent alerts exist for the customer asset**|
|DisplayName|**Active or in-progress alerts**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_alert`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_customerasset_msdyn_alert`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_alertcount"></a> msdyn_alertcount

|Property|Value|
|---|---|
|Description|**Count of parent alerts for this customer asset**|
|DisplayName|**Alert Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_alertcount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_alertcount_Date"></a> msdyn_alertcount_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Alert Count.**|
|DisplayName|**Alert Count (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_alertcount_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_alertcount_State"></a> msdyn_alertcount_State

|Property|Value|
|---|---|
|Description|**State of rollup field Alert Count.**|
|DisplayName|**Alert Count (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_alertcount_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_LastAlertTime"></a> msdyn_LastAlertTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last active alert time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastalerttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_LastAlertTime_Date"></a> msdyn_LastAlertTime_Date

|Property|Value|
|---|---|
|Description|**Last Updated time of rollup field Last active alert time.**|
|DisplayName|**Last active alert time (Last Updated On)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastalerttime_date`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_LastAlertTime_State"></a> msdyn_LastAlertTime_State

|Property|Value|
|---|---|
|Description|**State of rollup field Last active alert time.**|
|DisplayName|**Last active alert time (State)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastalerttime_state`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_OwnerIdName"></a> OwnerIdName

|Property|Value|
|---|---|
|Description|**Name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridname`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

|Property|Value|
|---|---|
|Description|**Yomi name of the owner**|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owneridyominame`|
|RequiredLevel|SystemRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|---|---|
|Description|**Unique identifier for the business unit that owns the record**|
|DisplayName|**Owning Business Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`owningbusinessunit`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|businessunit|

### <a name="BKMK_OwningTeam"></a> OwningTeam

|Property|Value|
|---|---|
|Description|**Unique identifier for the team that owns the record.**|
|DisplayName|**Owning Team**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owningteam`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|team|

### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|---|---|
|Description|**Unique identifier for the user that owns the record.**|
|DisplayName|**Owning User**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`owninguser`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|---|---|
|Description|**Version Number**|
|DisplayName|**Version Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`versionnumber`|
|RequiredLevel|None|
|Type|BigInt|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|

## Many-to-One relationships

These relationships are many-to-one. Listed by **SchemaName**.

- [business_unit_msdyn_customerasset](#BKMK_business_unit_msdyn_customerasset)
- [lk_msdyn_customerasset_createdby](#BKMK_lk_msdyn_customerasset_createdby)
- [lk_msdyn_customerasset_createdonbehalfby](#BKMK_lk_msdyn_customerasset_createdonbehalfby)
- [lk_msdyn_customerasset_modifiedby](#BKMK_lk_msdyn_customerasset_modifiedby)
- [lk_msdyn_customerasset_modifiedonbehalfby](#BKMK_lk_msdyn_customerasset_modifiedonbehalfby)
- [msdyn_account_msdyn_customerasset_Account](#BKMK_msdyn_account_msdyn_customerasset_Account)
- [msdyn_customerasset_FunctionalLocation_ms](#BKMK_msdyn_customerasset_FunctionalLocation_ms)
- [msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset-many-to-one)
- [msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset-many-to-one)
- [msdyn_msdyn_customerassetcategory_msdyn_customerasset_CustomerAssetCategory](#BKMK_msdyn_msdyn_customerassetcategory_msdyn_customerasset_CustomerAssetCategory)
- [msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent](#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent)
- [msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct)
- [msdyn_product_msdyn_customerasset_Product](#BKMK_msdyn_product_msdyn_customerasset_Product)
- [owner_msdyn_customerasset](#BKMK_owner_msdyn_customerasset)
- [team_msdyn_customerasset](#BKMK_team_msdyn_customerasset)
- [user_msdyn_customerasset](#BKMK_user_msdyn_customerasset)

### <a name="BKMK_business_unit_msdyn_customerasset"></a> business_unit_msdyn_customerasset

One-To-Many Relationship: [businessunit business_unit_msdyn_customerasset](businessunit.md#BKMK_business_unit_msdyn_customerasset)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_customerasset_createdby"></a> lk_msdyn_customerasset_createdby

One-To-Many Relationship: [systemuser lk_msdyn_customerasset_createdby](systemuser.md#BKMK_lk_msdyn_customerasset_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_customerasset_createdonbehalfby"></a> lk_msdyn_customerasset_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_customerasset_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_customerasset_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_customerasset_modifiedby"></a> lk_msdyn_customerasset_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_customerasset_modifiedby](systemuser.md#BKMK_lk_msdyn_customerasset_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_customerasset_modifiedonbehalfby"></a> lk_msdyn_customerasset_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_customerasset_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_customerasset_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_account_msdyn_customerasset_Account"></a> msdyn_account_msdyn_customerasset_Account

One-To-Many Relationship: [account msdyn_account_msdyn_customerasset_Account](account.md#BKMK_msdyn_account_msdyn_customerasset_Account)

|Property|Value|
|---|---|
|ReferencedEntity|`account`|
|ReferencedAttribute|`accountid`|
|ReferencingAttribute|`msdyn_account`|
|ReferencingEntityNavigationPropertyName|`msdyn_account`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `Cascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_customerasset_FunctionalLocation_ms"></a> msdyn_customerasset_FunctionalLocation_ms

One-To-Many Relationship: [msdyn_functionallocation msdyn_customerasset_FunctionalLocation_ms](msdyn_functionallocation.md#BKMK_msdyn_customerasset_FunctionalLocation_ms)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_functionallocation`|
|ReferencedAttribute|`msdyn_functionallocationid`|
|ReferencingAttribute|`msdyn_functionallocation`|
|ReferencingEntityNavigationPropertyName|`msdyn_FunctionalLocation`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset-many-to-one"></a> msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_masterasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_masterasset_msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset-many-to-one"></a> msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset-one-to-many)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_parentasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_parentasset_msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerassetcategory_msdyn_customerasset_CustomerAssetCategory"></a> msdyn_msdyn_customerassetcategory_msdyn_customerasset_CustomerAssetCategory

One-To-Many Relationship: [msdyn_customerassetcategory msdyn_msdyn_customerassetcategory_msdyn_customerasset_CustomerAssetCategory](msdyn_customerassetcategory.md#BKMK_msdyn_msdyn_customerassetcategory_msdyn_customerasset_CustomerAssetCategory)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerassetcategory`|
|ReferencedAttribute|`msdyn_customerassetcategoryid`|
|ReferencingAttribute|`msdyn_customerassetcategory`|
|ReferencingEntityNavigationPropertyName|`msdyn_CustomerAssetCategory`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent"></a> msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent

One-To-Many Relationship: [msdyn_iotdevicecommand msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_iotdevicecommand_msdyn_customerasset_LastCommandSent)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_iotdevicecommand`|
|ReferencedAttribute|`msdyn_iotdevicecommandid`|
|ReferencingAttribute|`msdyn_lastcommandsent`|
|ReferencingEntityNavigationPropertyName|`msdyn_LastCommandSent`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct

One-To-Many Relationship: [msdyn_workorderproduct msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderproduct`|
|ReferencedAttribute|`msdyn_workorderproductid`|
|ReferencingAttribute|`msdyn_workorderproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_product_msdyn_customerasset_Product"></a> msdyn_product_msdyn_customerasset_Product

One-To-Many Relationship: [product msdyn_product_msdyn_customerasset_Product](product.md#BKMK_msdyn_product_msdyn_customerasset_Product)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_product`|
|ReferencingEntityNavigationPropertyName|`msdyn_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_customerasset"></a> owner_msdyn_customerasset

One-To-Many Relationship: [owner owner_msdyn_customerasset](owner.md#BKMK_owner_msdyn_customerasset)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_customerasset"></a> team_msdyn_customerasset

One-To-Many Relationship: [team team_msdyn_customerasset](team.md#BKMK_team_msdyn_customerasset)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_customerasset"></a> user_msdyn_customerasset

One-To-Many Relationship: [systemuser user_msdyn_customerasset](systemuser.md#BKMK_user_msdyn_customerasset)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`owninguser`|
|ReferencingEntityNavigationPropertyName|`owninguser`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_customerasset_ActivityPointers](#BKMK_msdyn_customerasset_ActivityPointers)
- [msdyn_customerasset_adx_alertsubscriptions](#BKMK_msdyn_customerasset_adx_alertsubscriptions)
- [msdyn_customerasset_adx_inviteredemptions](#BKMK_msdyn_customerasset_adx_inviteredemptions)
- [msdyn_customerasset_adx_portalcomments](#BKMK_msdyn_customerasset_adx_portalcomments)
- [msdyn_customerasset_Annotations](#BKMK_msdyn_customerasset_Annotations)
- [msdyn_customerasset_Appointments](#BKMK_msdyn_customerasset_Appointments)
- [msdyn_customerasset_AsyncOperations](#BKMK_msdyn_customerasset_AsyncOperations)
- [msdyn_customerasset_BulkDeleteFailures](#BKMK_msdyn_customerasset_BulkDeleteFailures)
- [msdyn_customerasset_chats](#BKMK_msdyn_customerasset_chats)
- [msdyn_customerasset_connections1](#BKMK_msdyn_customerasset_connections1)
- [msdyn_customerasset_connections2](#BKMK_msdyn_customerasset_connections2)
- [msdyn_customerasset_DuplicateBaseRecord](#BKMK_msdyn_customerasset_DuplicateBaseRecord)
- [msdyn_customerasset_DuplicateMatchingRecord](#BKMK_msdyn_customerasset_DuplicateMatchingRecord)
- [msdyn_customerasset_Emails](#BKMK_msdyn_customerasset_Emails)
- [msdyn_customerasset_Faxes](#BKMK_msdyn_customerasset_Faxes)
- [msdyn_customerasset_Letters](#BKMK_msdyn_customerasset_Letters)
- [msdyn_customerasset_li_inmails](#BKMK_msdyn_customerasset_li_inmails)
- [msdyn_customerasset_li_messages](#BKMK_msdyn_customerasset_li_messages)
- [msdyn_customerasset_li_pointdrivepresentationvieweds](#BKMK_msdyn_customerasset_li_pointdrivepresentationvieweds)
- [msdyn_customerasset_MailboxTrackingFolders](#BKMK_msdyn_customerasset_MailboxTrackingFolders)
- [msdyn_customerasset_msdyn_bookingalerts](#BKMK_msdyn_customerasset_msdyn_bookingalerts)
- [msdyn_customerasset_msdyn_copilottranscripts](#BKMK_msdyn_customerasset_msdyn_copilottranscripts)
- [msdyn_customerasset_msdyn_ocliveworkitems](#BKMK_msdyn_customerasset_msdyn_ocliveworkitems)
- [msdyn_customerasset_msdyn_ocoutboundmessages](#BKMK_msdyn_customerasset_msdyn_ocoutboundmessages)
- [msdyn_customerasset_msdyn_ocsessions](#BKMK_msdyn_customerasset_msdyn_ocsessions)
- [msdyn_customerasset_msdyn_ocvoicemails](#BKMK_msdyn_customerasset_msdyn_ocvoicemails)
- [msdyn_customerasset_msfp_alerts](#BKMK_msdyn_customerasset_msfp_alerts)
- [msdyn_customerasset_msfp_surveyinvites](#BKMK_msdyn_customerasset_msfp_surveyinvites)
- [msdyn_customerasset_msfp_surveyresponses](#BKMK_msdyn_customerasset_msfp_surveyresponses)
- [msdyn_customerasset_OpportunityCloses](#BKMK_msdyn_customerasset_OpportunityCloses)
- [msdyn_customerasset_OrderCloses](#BKMK_msdyn_customerasset_OrderCloses)
- [msdyn_customerasset_PhoneCalls](#BKMK_msdyn_customerasset_PhoneCalls)
- [msdyn_customerasset_PrincipalObjectAttributeAccesses](#BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses)
- [msdyn_customerasset_ProcessSession](#BKMK_msdyn_customerasset_ProcessSession)
- [msdyn_customerasset_QuoteCloses](#BKMK_msdyn_customerasset_QuoteCloses)
- [msdyn_customerasset_RecurringAppointmentMasters](#BKMK_msdyn_customerasset_RecurringAppointmentMasters)
- [msdyn_customerasset_ServiceAppointments](#BKMK_msdyn_customerasset_ServiceAppointments)
- [msdyn_customerasset_SocialActivities](#BKMK_msdyn_customerasset_SocialActivities)
- [msdyn_customerasset_SyncErrors](#BKMK_msdyn_customerasset_SyncErrors)
- [msdyn_customerasset_Tasks](#BKMK_msdyn_customerasset_Tasks)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_assettemplateassociation_customerasset](#BKMK_msdyn_msdyn_customerasset_msdyn_assettemplateassociation_customerasset)
- [msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset-one-to-many)
- [msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset-one-to-many)
- [msdyn_msdyn_customerasset_msdyn_customerassetattachment_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerassetattachment_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset](#BKMK_msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset)
- [msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid](#BKMK_msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid)
- [msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_problematicasset_asset](#BKMK_msdyn_msdyn_customerasset_msdyn_problematicasset_asset)
- [msdyn_msdyn_customerasset_msdyn_propertyassetassociation_customerasset](#BKMK_msdyn_msdyn_customerasset_msdyn_propertyassetassociation_customerasset)
- [msdyn_msdyn_customerasset_msdyn_propertylog_customerasset](#BKMK_msdyn_msdyn_customerasset_msdyn_propertylog_customerasset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset)
- [msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset)

### <a name="BKMK_msdyn_customerasset_ActivityPointers"></a> msdyn_customerasset_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_customerasset_ActivityPointers](activitypointer.md#BKMK_msdyn_customerasset_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_adx_alertsubscriptions"></a> msdyn_customerasset_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msdyn_customerasset_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msdyn_customerasset_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_adx_inviteredemptions"></a> msdyn_customerasset_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_customerasset_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_customerasset_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_adx_portalcomments"></a> msdyn_customerasset_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_customerasset_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_customerasset_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_Annotations"></a> msdyn_customerasset_Annotations

Many-To-One Relationship: [annotation msdyn_customerasset_Annotations](annotation.md#BKMK_msdyn_customerasset_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_Appointments"></a> msdyn_customerasset_Appointments

Many-To-One Relationship: [appointment msdyn_customerasset_Appointments](appointment.md#BKMK_msdyn_customerasset_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_AsyncOperations"></a> msdyn_customerasset_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_customerasset_AsyncOperations](asyncoperation.md#BKMK_msdyn_customerasset_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_BulkDeleteFailures"></a> msdyn_customerasset_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_customerasset_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_customerasset_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_chats"></a> msdyn_customerasset_chats

Many-To-One Relationship: [chat msdyn_customerasset_chats](chat.md#BKMK_msdyn_customerasset_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_connections1"></a> msdyn_customerasset_connections1

Many-To-One Relationship: [connection msdyn_customerasset_connections1](connection.md#BKMK_msdyn_customerasset_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_connections2"></a> msdyn_customerasset_connections2

Many-To-One Relationship: [connection msdyn_customerasset_connections2](connection.md#BKMK_msdyn_customerasset_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_DuplicateBaseRecord"></a> msdyn_customerasset_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_customerasset_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_customerasset_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_DuplicateMatchingRecord"></a> msdyn_customerasset_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_customerasset_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_customerasset_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_Emails"></a> msdyn_customerasset_Emails

Many-To-One Relationship: [email msdyn_customerasset_Emails](email.md#BKMK_msdyn_customerasset_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_Faxes"></a> msdyn_customerasset_Faxes

Many-To-One Relationship: [fax msdyn_customerasset_Faxes](fax.md#BKMK_msdyn_customerasset_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_Letters"></a> msdyn_customerasset_Letters

Many-To-One Relationship: [letter msdyn_customerasset_Letters](letter.md#BKMK_msdyn_customerasset_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_li_inmails"></a> msdyn_customerasset_li_inmails

Many-To-One Relationship: [li_inmail msdyn_customerasset_li_inmails](li_inmail.md#BKMK_msdyn_customerasset_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_li_messages"></a> msdyn_customerasset_li_messages

Many-To-One Relationship: [li_message msdyn_customerasset_li_messages](li_message.md#BKMK_msdyn_customerasset_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_li_pointdrivepresentationvieweds"></a> msdyn_customerasset_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msdyn_customerasset_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msdyn_customerasset_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_MailboxTrackingFolders"></a> msdyn_customerasset_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_customerasset_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_customerasset_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_msdyn_bookingalerts"></a> msdyn_customerasset_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_customerasset_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_customerasset_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_msdyn_copilottranscripts"></a> msdyn_customerasset_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_customerasset_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_customerasset_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_msdyn_ocliveworkitems"></a> msdyn_customerasset_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_customerasset_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_customerasset_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_msdyn_ocoutboundmessages"></a> msdyn_customerasset_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msdyn_customerasset_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msdyn_customerasset_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_msdyn_ocoutboundmessages`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_msdyn_ocsessions"></a> msdyn_customerasset_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_customerasset_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_customerasset_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_msdyn_ocvoicemails"></a> msdyn_customerasset_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msdyn_customerasset_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msdyn_customerasset_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_msfp_alerts"></a> msdyn_customerasset_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_customerasset_msfp_alerts](msfp_alert.md#BKMK_msdyn_customerasset_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_msfp_surveyinvites"></a> msdyn_customerasset_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_customerasset_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_customerasset_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_msfp_surveyresponses"></a> msdyn_customerasset_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_customerasset_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_customerasset_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_OpportunityCloses"></a> msdyn_customerasset_OpportunityCloses

Many-To-One Relationship: [opportunityclose msdyn_customerasset_OpportunityCloses](opportunityclose.md#BKMK_msdyn_customerasset_OpportunityCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`opportunityclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_OpportunityCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_OrderCloses"></a> msdyn_customerasset_OrderCloses

Many-To-One Relationship: [orderclose msdyn_customerasset_OrderCloses](orderclose.md#BKMK_msdyn_customerasset_OrderCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`orderclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_OrderCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_PhoneCalls"></a> msdyn_customerasset_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_customerasset_PhoneCalls](phonecall.md#BKMK_msdyn_customerasset_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses"></a> msdyn_customerasset_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_customerasset_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_ProcessSession"></a> msdyn_customerasset_ProcessSession

Many-To-One Relationship: [processsession msdyn_customerasset_ProcessSession](processsession.md#BKMK_msdyn_customerasset_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_QuoteCloses"></a> msdyn_customerasset_QuoteCloses

Many-To-One Relationship: [quoteclose msdyn_customerasset_QuoteCloses](quoteclose.md#BKMK_msdyn_customerasset_QuoteCloses)

|Property|Value|
|---|---|
|ReferencingEntity|`quoteclose`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_QuoteCloses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_RecurringAppointmentMasters"></a> msdyn_customerasset_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_customerasset_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_customerasset_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_ServiceAppointments"></a> msdyn_customerasset_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_customerasset_ServiceAppointments](serviceappointment.md#BKMK_msdyn_customerasset_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_SocialActivities"></a> msdyn_customerasset_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_customerasset_SocialActivities](socialactivity.md#BKMK_msdyn_customerasset_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_SyncErrors"></a> msdyn_customerasset_SyncErrors

Many-To-One Relationship: [syncerror msdyn_customerasset_SyncErrors](syncerror.md#BKMK_msdyn_customerasset_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_customerasset_Tasks"></a> msdyn_customerasset_Tasks

Many-To-One Relationship: [task msdyn_customerasset_Tasks](task.md#BKMK_msdyn_customerasset_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_customerasset_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset

Many-To-One Relationship: [msdyn_agreementbookingincident msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset](msdyn_agreementbookingincident.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingincident`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_agreementbookingincident_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Customer Asset<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset

Many-To-One Relationship: [msdyn_agreementbookingproduct msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingproduct`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_agreementbookingproduct_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset

Many-To-One Relationship: [msdyn_agreementbookingservice msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservice`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_agreementbookingservice_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset

Many-To-One Relationship: [msdyn_agreementbookingservicetask msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset](msdyn_agreementbookingservicetask.md#BKMK_msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_agreementbookingservicetask`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_agreementbookingservicetask_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_assettemplateassociation_customerasset"></a> msdyn_msdyn_customerasset_msdyn_assettemplateassociation_customerasset

Many-To-One Relationship: [msdyn_assettemplateassociation msdyn_msdyn_customerasset_msdyn_assettemplateassociation_customerasset](msdyn_assettemplateassociation.md#BKMK_msdyn_msdyn_customerasset_msdyn_assettemplateassociation_customerasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_assettemplateassociation`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_assettemplateassociation_customerasset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10001<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset-one-to-many"></a> msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset

Many-To-One Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerasset`|
|ReferencingAttribute|`msdyn_masterasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_customerasset_MasterAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Items of Master Asset<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset-one-to-many"></a> msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset

Many-To-One Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset-many-to-one)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerasset`|
|ReferencingAttribute|`msdyn_parentasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_customerasset_ParentAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Items of Parent Asset<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_customerassetattachment_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_customerassetattachment_CustomerAsset

Many-To-One Relationship: [msdyn_customerassetattachment msdyn_msdyn_customerasset_msdyn_customerassetattachment_CustomerAsset](msdyn_customerassetattachment.md#BKMK_msdyn_msdyn_customerasset_msdyn_customerassetattachment_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerassetattachment`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_customerassetattachment_CustomerAsset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset"></a> msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset

Many-To-One Relationship: [msdyn_entitlementapplication msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset](msdyn_entitlementapplication.md#BKMK_msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_entitlementapplication`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_entitlementapplication_customerasset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid"></a> msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid

Many-To-One Relationship: [msdyn_inspectioninstance msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid](msdyn_inspectioninstance.md#BKMK_msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inspectioninstance`|
|ReferencingAttribute|`msdyn_customerassetid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_inspectioninstance_customerassetid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset

Many-To-One Relationship: [msdyn_iotalert msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset](msdyn_iotalert.md#BKMK_msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotalert`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_iotalert_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset

Many-To-One Relationship: [msdyn_iotdevicecommand msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset](msdyn_iotdevicecommand.md#BKMK_msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_iotdevicecommand`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_iotdevicecommand_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_problematicasset_asset"></a> msdyn_msdyn_customerasset_msdyn_problematicasset_asset

Many-To-One Relationship: [msdyn_problematicasset msdyn_msdyn_customerasset_msdyn_problematicasset_asset](msdyn_problematicasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_problematicasset_asset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_problematicasset`|
|ReferencingAttribute|`msdyn_asset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_problematicasset_asset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_propertyassetassociation_customerasset"></a> msdyn_msdyn_customerasset_msdyn_propertyassetassociation_customerasset

Many-To-One Relationship: [msdyn_propertyassetassociation msdyn_msdyn_customerasset_msdyn_propertyassetassociation_customerasset](msdyn_propertyassetassociation.md#BKMK_msdyn_msdyn_customerasset_msdyn_propertyassetassociation_customerasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertyassetassociation`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_propertyassetassociation_customerasset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10002<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_propertylog_customerasset"></a> msdyn_msdyn_customerasset_msdyn_propertylog_customerasset

Many-To-One Relationship: [msdyn_propertylog msdyn_msdyn_customerasset_msdyn_propertylog_customerasset](msdyn_propertylog.md#BKMK_msdyn_msdyn_customerasset_msdyn_propertylog_customerasset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_propertylog`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_propertylog_customerasset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset

Many-To-One Relationship: [msdyn_quotebookingincident msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingincident`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_quotebookingincident_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset

Many-To-One Relationship: [msdyn_quotebookingproduct msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset](msdyn_quotebookingproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_quotebookingproduct_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset

Many-To-One Relationship: [msdyn_quotebookingservice msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset](msdyn_quotebookingservice.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_quotebookingservice_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset

Many-To-One Relationship: [msdyn_quotebookingservicetask msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset](msdyn_quotebookingservicetask.md#BKMK_msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservicetask`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_quotebookingservicetask_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset

Many-To-One Relationship: [msdyn_rmaproduct msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_rmaproduct_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset

Many-To-One Relationship: [msdyn_workorder msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset](msdyn_workorder.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorder`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorder_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset

Many-To-One Relationship: [msdyn_workorderincident msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset](msdyn_workorderincident.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderincident`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorderincident_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset

Many-To-One Relationship: [msdyn_workorderproduct msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](msdyn_workorderproduct.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderproduct`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset

Many-To-One Relationship: [msdyn_workorderresolution msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset](msdyn_workorderresolution.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderresolution`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorderresolution_CustomerAsset`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset

Many-To-One Relationship: [msdyn_workorderservice msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](msdyn_workorderservice.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservice`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset

Many-To-One Relationship: [msdyn_workorderservicetask msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset](msdyn_workorderservicetask.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_workorderservicetask`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_workorderservicetask_CustomerAsset`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|


## Many-to-Many relationships

These relationships are many-to-many. Listed by **SchemaName**.

- [msdyn_customerasset_knowledgebaserecord](#BKMK_msdyn_customerasset_knowledgebaserecord)
- [msdyn_incident_msdyn_customerasset](#BKMK_msdyn_incident_msdyn_customerasset)
- [msdyn_msdyn_customerasset_knowledgearticle](#BKMK_msdyn_msdyn_customerasset_knowledgearticle)
- [msdyn_msdyn_customerasset_msdyn_3dmodel](#BKMK_msdyn_msdyn_customerasset_msdyn_3dmodel)
- [msdyn_msdyn_warranty_msdyn_customerasset](#BKMK_msdyn_msdyn_warranty_msdyn_customerasset)

### <a name="BKMK_msdyn_customerasset_knowledgebaserecord"></a> msdyn_customerasset_knowledgebaserecord

See [knowledgebaserecord msdyn_customerasset_knowledgebaserecord Many-To-Many Relationship](knowledgebaserecord.md#BKMK_msdyn_customerasset_knowledgebaserecord)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_customerasset_knowledgebasere`|
|IsCustomizable|True|
|SchemaName|`msdyn_customerasset_knowledgebaserecord`|
|IntersectAttribute|`msdyn_customerassetid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_incident_msdyn_customerasset"></a> msdyn_incident_msdyn_customerasset

See [incident msdyn_incident_msdyn_customerasset Many-To-Many Relationship](incident.md#BKMK_msdyn_incident_msdyn_customerasset)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_incident_msdyn_customerasset`|
|IsCustomizable|True|
|SchemaName|`msdyn_incident_msdyn_customerasset`|
|IntersectAttribute|`msdyn_customerassetid`|
|NavigationPropertyName|`msdyn_incident_msdyn_customerasset`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_knowledgearticle"></a> msdyn_msdyn_customerasset_knowledgearticle

See [knowledgearticle msdyn_msdyn_customerasset_knowledgearticle Many-To-Many Relationship](knowledgearticle.md#BKMK_msdyn_msdyn_customerasset_knowledgearticle)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_customerasset_knowledgearticl`|
|IsCustomizable|True|
|SchemaName|`msdyn_msdyn_customerasset_knowledgearticle`|
|IntersectAttribute|`msdyn_customerassetid`|
|NavigationPropertyName|``|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_3dmodel"></a> msdyn_msdyn_customerasset_msdyn_3dmodel

See [msdyn_3dmodel msdyn_msdyn_customerasset_msdyn_3dmodel Many-To-Many Relationship](msdyn_3dmodel.md#BKMK_msdyn_msdyn_customerasset_msdyn_3dmodel)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_customerasset_msdyn_3dmodel`|
|IsCustomizable|False|
|SchemaName|`msdyn_msdyn_customerasset_msdyn_3dmodel`|
|IntersectAttribute|`msdyn_customerassetid`|
|NavigationPropertyName|`msdyn_msdyn_customerasset_msdyn_3dmodel`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_warranty_msdyn_customerasset"></a> msdyn_msdyn_warranty_msdyn_customerasset

See [msdyn_warranty msdyn_msdyn_warranty_msdyn_customerasset Many-To-Many Relationship](msdyn_warranty.md#BKMK_msdyn_msdyn_warranty_msdyn_customerasset)

|Property|Value|
|---|---|
|IntersectEntityName|`msdyn_msdyn_warranty_msdyn_customerasset`|
|IsCustomizable|False|
|SchemaName|`msdyn_msdyn_warranty_msdyn_customerasset`|
|IntersectAttribute|`msdyn_customerassetid`|
|NavigationPropertyName|`msdyn_msdyn_warranty_msdyn_customerasset`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

