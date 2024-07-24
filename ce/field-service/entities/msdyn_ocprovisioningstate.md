---
title: "Provisioning State (msdyn_ocprovisioningstate) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Provisioning State (msdyn_ocprovisioningstate) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Provisioning State (msdyn_ocprovisioningstate) table/entity reference

Provisioning state

## Messages

The following table lists the messages for the Provisioning State (msdyn_ocprovisioningstate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_ocprovisioningstates(*msdyn_ocprovisioningstateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_ocprovisioningstates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_ocprovisioningstates(*msdyn_ocprovisioningstateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_ocprovisioningstates(*msdyn_ocprovisioningstateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_ocprovisioningstates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_ocprovisioningstates(*msdyn_ocprovisioningstateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_ocprovisioningstates(*msdyn_ocprovisioningstateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_ocprovisioningstates(*msdyn_ocprovisioningstateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Provisioning State (msdyn_ocprovisioningstate) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Provisioning State (msdyn_ocprovisioningstate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Provisioning State** |
| **DisplayCollectionName** | **Provisioning States** |
| **SchemaName** | `msdyn_ocprovisioningstate` |
| **CollectionSchemaName** | `msdyn_ocprovisioningstates` |
| **EntitySetName** | `msdyn_ocprovisioningstates`|
| **LogicalName** | `msdyn_ocprovisioningstate` |
| **LogicalCollectionName** | `msdyn_ocprovisioningstates` |
| **PrimaryIdAttribute** | `msdyn_ocprovisioningstateid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_communicationprovidersettingid](#BKMK_msdyn_communicationprovidersettingid)
- [msdyn_errormessage](#BKMK_msdyn_errormessage)
- [msdyn_exceptiondetails](#BKMK_msdyn_exceptiondetails)
- [msdyn_gatekeeperstatus](#BKMK_msdyn_gatekeeperstatus)
- [msdyn_gatekeeperstatusreason](#BKMK_msdyn_gatekeeperstatusreason)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_ocfbapplicationid](#BKMK_msdyn_ocfbapplicationid)
- [msdyn_ocfbpageid](#BKMK_msdyn_ocfbpageid)
- [msdyn_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfigid)
- [msdyn_ocprovisioningstateId](#BKMK_msdyn_ocprovisioningstateId)
- [msdyn_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfigid)
- [msdyn_ocwhatsappchannelaccountId](#BKMK_msdyn_ocwhatsappchannelaccountId)
- [msdyn_phonenumberid](#BKMK_msdyn_phonenumberid)
- [msdyn_provisioningresponse](#BKMK_msdyn_provisioningresponse)
- [msdyn_voicechannelsettingid](#BKMK_msdyn_voicechannelsettingid)
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
|Description|**Sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_communicationprovidersettingid"></a> msdyn_communicationprovidersettingid

|Property|Value|
|---|---|
|Description|**Related Communication Provider Settings**|
|DisplayName|**CommunicationProviderSettings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_communicationprovidersettingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_occommunicationprovidersetting|

### <a name="BKMK_msdyn_errormessage"></a> msdyn_errormessage

|Property|Value|
|---|---|
|Description|**Additional details**|
|DisplayName|**Additional details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errormessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8192|

### <a name="BKMK_msdyn_exceptiondetails"></a> msdyn_exceptiondetails

|Property|Value|
|---|---|
|Description|**Exception Details during channel provisioning**|
|DisplayName|**Error Message (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_exceptiondetails`|
|RequiredLevel|ApplicationRequired|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8192|

### <a name="BKMK_msdyn_gatekeeperstatus"></a> msdyn_gatekeeperstatus

|Property|Value|
|---|---|
|Description|**Provisioning Status for GateKeeper**|
|DisplayName|**GateKeeper Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gatekeeperstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocprovisioningstate_msdyn_gatekeeperstatus`|

#### msdyn_gatekeeperstatus Choices/Options

|Value|Label|
|---|---|
|715240000|**Active**|
|715240001|**Inactive**|

### <a name="BKMK_msdyn_gatekeeperstatusreason"></a> msdyn_gatekeeperstatusreason

|Property|Value|
|---|---|
|Description|**Provisioning Status Reason for GateKeeper**|
|DisplayName|**GateKeeper Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gatekeeperstatusreason`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_ocprovisioningstate_msdyn_gatekeeperstatusreason`|

#### msdyn_gatekeeperstatusreason Choices/Options

|Value|Label|
|---|---|
|0|**Running**|
|1|**Error**|
|2|**Deprovisioned**|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
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

### <a name="BKMK_msdyn_ocfbapplicationid"></a> msdyn_ocfbapplicationid

|Property|Value|
|---|---|
|Description|**Related Facebook application**|
|DisplayName|**Facebook Application**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfbapplicationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocfbapplication|

### <a name="BKMK_msdyn_ocfbpageid"></a> msdyn_ocfbpageid

|Property|Value|
|---|---|
|Description|**Related Facebook page**|
|DisplayName|**Facebook Page**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocfbpageid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocfbpage|

### <a name="BKMK_msdyn_oclinechannelconfigid"></a> msdyn_oclinechannelconfigid

|Property|Value|
|---|---|
|Description|**Related Line Channel**|
|DisplayName|**Line Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_oclinechannelconfigid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_oclinechannelconfig|

### <a name="BKMK_msdyn_ocprovisioningstateId"></a> msdyn_ocprovisioningstateId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Provisioning State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_ocprovisioningstateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_octeamschannelconfigid"></a> msdyn_octeamschannelconfigid

|Property|Value|
|---|---|
|Description|**Related Teams Channel**|
|DisplayName|**Teams Channel**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_octeamschannelconfigid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_octeamschannelconfig|

### <a name="BKMK_msdyn_ocwhatsappchannelaccountId"></a> msdyn_ocwhatsappchannelaccountId

|Property|Value|
|---|---|
|Description|**Related WhatsApp Account**|
|DisplayName|**WhatsApp Account**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ocwhatsappchannelaccountid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocwhatsappchannelaccount|

### <a name="BKMK_msdyn_phonenumberid"></a> msdyn_phonenumberid

|Property|Value|
|---|---|
|Description|**Related Phone Number**|
|DisplayName|**Phone Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_phonenumberid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocphonenumber|

### <a name="BKMK_msdyn_provisioningresponse"></a> msdyn_provisioningresponse

|Property|Value|
|---|---|
|Description|**Response for the provisioning action**|
|DisplayName|**msdyn_provisioningresponse**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_provisioningresponse`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_voicechannelsettingid"></a> msdyn_voicechannelsettingid

|Property|Value|
|---|---|
|Description||
|DisplayName|**voicechannelsettingsid**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_voicechannelsettingid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocvoicechannelsetting|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
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
|Description|**Status of the Provisioning State**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocprovisioningstate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 192350001<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 192350003<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Provisioning State**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_ocprovisioningstate_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|192350001|Label: **Draft**<br />State:0<br />TransitionData: None|
|192350002|Label: **Processing**<br />State:0<br />TransitionData: None|
|192350003|Label: **Running**<br />State:0<br />TransitionData: None|
|192350004|Label: **Error**<br />State:0<br />TransitionData: None|
|192350005|Label: **Deprovisioning**<br />State:0<br />TransitionData: None|
|192350006|Label: **Deprovisioned**<br />State:1<br />TransitionData: None|

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
|Description|**Time zone code that was in use when the record was created.**|
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
|Description|**Date and time when the record was created.**|
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
|Description|**Unique identifier of the delegate user who created the record.**|
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
|Description|**Date and time when the record was modified.**|
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
|Description|**Unique identifier of the delegate user who modified the record.**|
|DisplayName|**Modified By (Delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

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

- [business_unit_msdyn_ocprovisioningstate](#BKMK_business_unit_msdyn_ocprovisioningstate)
- [lk_msdyn_ocprovisioningstate_createdby](#BKMK_lk_msdyn_ocprovisioningstate_createdby)
- [lk_msdyn_ocprovisioningstate_createdonbehalfby](#BKMK_lk_msdyn_ocprovisioningstate_createdonbehalfby)
- [lk_msdyn_ocprovisioningstate_modifiedby](#BKMK_lk_msdyn_ocprovisioningstate_modifiedby)
- [lk_msdyn_ocprovisioningstate_modifiedonbehalfby](#BKMK_lk_msdyn_ocprovisioningstate_modifiedonbehalfby)
- [msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid](#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid)
- [msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate](#BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate)
- [msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate](#BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate)
- [msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid](#BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid)
- [msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid](#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid)
- [msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid](#BKMK_msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid)
- [msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid](#BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid)
- [msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId](#BKMK_msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId)
- [owner_msdyn_ocprovisioningstate](#BKMK_owner_msdyn_ocprovisioningstate)
- [team_msdyn_ocprovisioningstate](#BKMK_team_msdyn_ocprovisioningstate)
- [user_msdyn_ocprovisioningstate](#BKMK_user_msdyn_ocprovisioningstate)

### <a name="BKMK_business_unit_msdyn_ocprovisioningstate"></a> business_unit_msdyn_ocprovisioningstate

One-To-Many Relationship: [businessunit business_unit_msdyn_ocprovisioningstate](businessunit.md#BKMK_business_unit_msdyn_ocprovisioningstate)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocprovisioningstate_createdby"></a> lk_msdyn_ocprovisioningstate_createdby

One-To-Many Relationship: [systemuser lk_msdyn_ocprovisioningstate_createdby](systemuser.md#BKMK_lk_msdyn_ocprovisioningstate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocprovisioningstate_createdonbehalfby"></a> lk_msdyn_ocprovisioningstate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocprovisioningstate_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_ocprovisioningstate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocprovisioningstate_modifiedby"></a> lk_msdyn_ocprovisioningstate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_ocprovisioningstate_modifiedby](systemuser.md#BKMK_lk_msdyn_ocprovisioningstate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_ocprovisioningstate_modifiedonbehalfby"></a> lk_msdyn_ocprovisioningstate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_ocprovisioningstate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_ocprovisioningstate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid"></a> msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid

One-To-Many Relationship: [msdyn_occommunicationprovidersetting msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid](msdyn_occommunicationprovidersetting.md#BKMK_msdyn_msdyn_occommunicationprovidersetting_msdyn_ocprovisioningstate_communicationprovidersettingid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_occommunicationprovidersetting`|
|ReferencedAttribute|`msdyn_occommunicationprovidersettingid`|
|ReferencingAttribute|`msdyn_communicationprovidersettingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_communicationprovidersettingid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate"></a> msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate

One-To-Many Relationship: [msdyn_ocfbapplication msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate](msdyn_ocfbapplication.md#BKMK_msdyn_msdyn_ocfbapplication_msdyn_ocprovisioningstate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbapplication`|
|ReferencedAttribute|`msdyn_ocfbapplicationid`|
|ReferencingAttribute|`msdyn_ocfbapplicationid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocfbapplicationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate"></a> msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate

One-To-Many Relationship: [msdyn_ocfbpage msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate](msdyn_ocfbpage.md#BKMK_msdyn_msdyn_ocfbpage_msdyn_ocprovisioningstate)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocfbpage`|
|ReferencedAttribute|`msdyn_ocfbpageid`|
|ReferencingAttribute|`msdyn_ocfbpageid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocfbpageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid"></a> msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid

One-To-Many Relationship: [msdyn_ocphonenumber msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid](msdyn_ocphonenumber.md#BKMK_msdyn_msdyn_ocphonenumber_msdyn_ocprovisioningstate_phonenumberid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonenumber`|
|ReferencedAttribute|`msdyn_ocphonenumberid`|
|ReferencingAttribute|`msdyn_phonenumberid`|
|ReferencingEntityNavigationPropertyName|`msdyn_phonenumberid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid"></a> msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid

One-To-Many Relationship: [msdyn_ocvoicechannelsetting msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid](msdyn_ocvoicechannelsetting.md#BKMK_msdyn_msdyn_ocvoicechannelsetting_msdyn_ocprovisioningstate_voicechannelsettingid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocvoicechannelsetting`|
|ReferencedAttribute|`msdyn_ocvoicechannelsettingid`|
|ReferencingAttribute|`msdyn_voicechannelsettingid`|
|ReferencingEntityNavigationPropertyName|`msdyn_voicechannelsettingid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid"></a> msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid

One-To-Many Relationship: [msdyn_oclinechannelconfig msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid](msdyn_oclinechannelconfig.md#BKMK_msdyn_oclinechannelconfig_msdyn_ocprovisioningstate_oclinechannelconfigid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_oclinechannelconfig`|
|ReferencedAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingAttribute|`msdyn_oclinechannelconfigid`|
|ReferencingEntityNavigationPropertyName|`msdyn_oclinechannelconfigid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid"></a> msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid

One-To-Many Relationship: [msdyn_octeamschannelconfig msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid](msdyn_octeamschannelconfig.md#BKMK_msdyn_octeamschannelconfig_msdyn_ocprovisioningstate_octeamschannelconfigid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_octeamschannelconfig`|
|ReferencedAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingAttribute|`msdyn_octeamschannelconfigid`|
|ReferencingEntityNavigationPropertyName|`msdyn_octeamschannelconfigid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId"></a> msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId

One-To-Many Relationship: [msdyn_ocwhatsappchannelaccount msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId](msdyn_ocwhatsappchannelaccount.md#BKMK_msdyn_ocwhatsappchannelaccount_msdyn_ocprovisioningstate_msdyn_ocwhatsappchannelaccountId)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocwhatsappchannelaccount`|
|ReferencedAttribute|`msdyn_ocwhatsappchannelaccountid`|
|ReferencingAttribute|`msdyn_ocwhatsappchannelaccountid`|
|ReferencingEntityNavigationPropertyName|`msdyn_ocwhatsappchannelaccountId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_ocprovisioningstate"></a> owner_msdyn_ocprovisioningstate

One-To-Many Relationship: [owner owner_msdyn_ocprovisioningstate](owner.md#BKMK_owner_msdyn_ocprovisioningstate)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_ocprovisioningstate"></a> team_msdyn_ocprovisioningstate

One-To-Many Relationship: [team team_msdyn_ocprovisioningstate](team.md#BKMK_team_msdyn_ocprovisioningstate)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_ocprovisioningstate"></a> user_msdyn_ocprovisioningstate

One-To-Many Relationship: [systemuser user_msdyn_ocprovisioningstate](systemuser.md#BKMK_user_msdyn_ocprovisioningstate)

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

- [msdyn_ocprovisioningstate_AsyncOperations](#BKMK_msdyn_ocprovisioningstate_AsyncOperations)
- [msdyn_ocprovisioningstate_BulkDeleteFailures](#BKMK_msdyn_ocprovisioningstate_BulkDeleteFailures)
- [msdyn_ocprovisioningstate_DuplicateBaseRecord](#BKMK_msdyn_ocprovisioningstate_DuplicateBaseRecord)
- [msdyn_ocprovisioningstate_DuplicateMatchingRecord](#BKMK_msdyn_ocprovisioningstate_DuplicateMatchingRecord)
- [msdyn_ocprovisioningstate_MailboxTrackingFolders](#BKMK_msdyn_ocprovisioningstate_MailboxTrackingFolders)
- [msdyn_ocprovisioningstate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_ocprovisioningstate_PrincipalObjectAttributeAccesses)
- [msdyn_ocprovisioningstate_ProcessSession](#BKMK_msdyn_ocprovisioningstate_ProcessSession)
- [msdyn_ocprovisioningstate_SyncErrors](#BKMK_msdyn_ocprovisioningstate_SyncErrors)

### <a name="BKMK_msdyn_ocprovisioningstate_AsyncOperations"></a> msdyn_ocprovisioningstate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_ocprovisioningstate_AsyncOperations](asyncoperation.md#BKMK_msdyn_ocprovisioningstate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocprovisioningstate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocprovisioningstate_BulkDeleteFailures"></a> msdyn_ocprovisioningstate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_ocprovisioningstate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_ocprovisioningstate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocprovisioningstate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocprovisioningstate_DuplicateBaseRecord"></a> msdyn_ocprovisioningstate_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocprovisioningstate_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_ocprovisioningstate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocprovisioningstate_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocprovisioningstate_DuplicateMatchingRecord"></a> msdyn_ocprovisioningstate_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_ocprovisioningstate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_ocprovisioningstate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocprovisioningstate_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocprovisioningstate_MailboxTrackingFolders"></a> msdyn_ocprovisioningstate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_ocprovisioningstate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_ocprovisioningstate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocprovisioningstate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocprovisioningstate_PrincipalObjectAttributeAccesses"></a> msdyn_ocprovisioningstate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_ocprovisioningstate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_ocprovisioningstate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocprovisioningstate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocprovisioningstate_ProcessSession"></a> msdyn_ocprovisioningstate_ProcessSession

Many-To-One Relationship: [processsession msdyn_ocprovisioningstate_ProcessSession](processsession.md#BKMK_msdyn_ocprovisioningstate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocprovisioningstate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_ocprovisioningstate_SyncErrors"></a> msdyn_ocprovisioningstate_SyncErrors

Many-To-One Relationship: [syncerror msdyn_ocprovisioningstate_SyncErrors](syncerror.md#BKMK_msdyn_ocprovisioningstate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_ocprovisioningstate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

