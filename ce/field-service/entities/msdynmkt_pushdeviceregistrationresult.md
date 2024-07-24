---
title: "Push device registration result (msdynmkt_pushdeviceregistrationresult) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Push device registration result (msdynmkt_pushdeviceregistrationresult) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Push device registration result (msdynmkt_pushdeviceregistrationresult) table/entity reference



## Messages

The following table lists the messages for the Push device registration result (msdynmkt_pushdeviceregistrationresult) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_pushdeviceregistrationresults(*msdynmkt_pushdeviceregistrationresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_pushdeviceregistrationresults<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_pushdeviceregistrationresults(*msdynmkt_pushdeviceregistrationresultid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_pushdeviceregistrationresults(*msdynmkt_pushdeviceregistrationresultid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_pushdeviceregistrationresults<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_pushdeviceregistrationresults(*msdynmkt_pushdeviceregistrationresultid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_pushdeviceregistrationresults(*msdynmkt_pushdeviceregistrationresultid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_pushdeviceregistrationresults(*msdynmkt_pushdeviceregistrationresultid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Push device registration result (msdynmkt_pushdeviceregistrationresult) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Push device registration result (msdynmkt_pushdeviceregistrationresult) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Push device registration result** |
| **DisplayCollectionName** | **Push device registration results** |
| **SchemaName** | `msdynmkt_pushdeviceregistrationresult` |
| **CollectionSchemaName** | `msdynmkt_pushdeviceregistrationresults` |
| **EntitySetName** | `msdynmkt_pushdeviceregistrationresults`|
| **LogicalName** | `msdynmkt_pushdeviceregistrationresult` |
| **LogicalCollectionName** | `msdynmkt_pushdeviceregistrationresults` |
| **PrimaryIdAttribute** | `msdynmkt_pushdeviceregistrationresultid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_details](#BKMK_msdynmkt_details)
- [msdynmkt_failedreason](#BKMK_msdynmkt_failedreason)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_pushdeviceregistrationresultId](#BKMK_msdynmkt_pushdeviceregistrationresultId)
- [msdynmkt_pushmobiledeviceid](#BKMK_msdynmkt_pushmobiledeviceid)
- [msdynmkt_registrationresult](#BKMK_msdynmkt_registrationresult)
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
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdynmkt_details"></a> msdynmkt_details

|Property|Value|
|---|---|
|Description|**Details of the device registration result**|
|DisplayName|**Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_details`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|20000|

### <a name="BKMK_msdynmkt_failedreason"></a> msdynmkt_failedreason

|Property|Value|
|---|---|
|Description||
|DisplayName|**Failed Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_failedreason`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_pushdeviceregistrationresultId"></a> msdynmkt_pushdeviceregistrationresultId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Push device registration result**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_pushdeviceregistrationresultid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_pushmobiledeviceid"></a> msdynmkt_pushmobiledeviceid

|Property|Value|
|---|---|
|Description|**Unique identifier for push mobile device associated with Push device registration result.**|
|DisplayName|**Push mobile device Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_pushmobiledeviceid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_pushmobiledevice|

### <a name="BKMK_msdynmkt_registrationresult"></a> msdynmkt_registrationresult

|Property|Value|
|---|---|
|Description|**Registration result of the device registration**|
|DisplayName|**Registration result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_registrationresult`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_pushdeviceregistrationresult_registrationresult`|

#### msdynmkt_registrationresult Choices/Options

|Value|Details|
|---|---|
|1|Label: **Success**<br />State:0<br />TransitionData: None|
|2|Label: **Failed**<br />State:1<br />TransitionData: None|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated.**|
|DisplayName|**Record created on**|
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
|Description|**Status of the push device registration results**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_pushdeviceregistrationresult_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Status of the push device registration results**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_pushdeviceregistrationresult_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Time zone rule version number**|
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
|DisplayName|**UTC conversion time zone code**|
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
|DisplayName|**Created by**|
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
|DisplayName|**Created on**|
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
|DisplayName|**Created by (delegate)**|
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
|DisplayName|**Modified by**|
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
|DisplayName|**Modified on**|
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
|DisplayName|**Modified by (delegate)**|
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
|DisplayName|**Owning business unit**|
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
|DisplayName|**Owning team**|
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
|DisplayName|**Owning user**|
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

- [business_unit_msdynmkt_pushdeviceregistrationresult](#BKMK_business_unit_msdynmkt_pushdeviceregistrationresult)
- [lk_msdynmkt_pushdeviceregistrationresult_createdby](#BKMK_lk_msdynmkt_pushdeviceregistrationresult_createdby)
- [lk_msdynmkt_pushdeviceregistrationresult_createdonbehalfby](#BKMK_lk_msdynmkt_pushdeviceregistrationresult_createdonbehalfby)
- [lk_msdynmkt_pushdeviceregistrationresult_modifiedby](#BKMK_lk_msdynmkt_pushdeviceregistrationresult_modifiedby)
- [lk_msdynmkt_pushdeviceregistrationresult_modifiedonbehalfby](#BKMK_lk_msdynmkt_pushdeviceregistrationresult_modifiedonbehalfby)
- [msdynmkt_pushmobiledevice_deviceregistrationresult](#BKMK_msdynmkt_pushmobiledevice_deviceregistrationresult)
- [owner_msdynmkt_pushdeviceregistrationresult](#BKMK_owner_msdynmkt_pushdeviceregistrationresult)
- [team_msdynmkt_pushdeviceregistrationresult](#BKMK_team_msdynmkt_pushdeviceregistrationresult)
- [user_msdynmkt_pushdeviceregistrationresult](#BKMK_user_msdynmkt_pushdeviceregistrationresult)

### <a name="BKMK_business_unit_msdynmkt_pushdeviceregistrationresult"></a> business_unit_msdynmkt_pushdeviceregistrationresult

One-To-Many Relationship: [businessunit business_unit_msdynmkt_pushdeviceregistrationresult](businessunit.md#BKMK_business_unit_msdynmkt_pushdeviceregistrationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_pushdeviceregistrationresult_createdby"></a> lk_msdynmkt_pushdeviceregistrationresult_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_pushdeviceregistrationresult_createdby](systemuser.md#BKMK_lk_msdynmkt_pushdeviceregistrationresult_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_pushdeviceregistrationresult_createdonbehalfby"></a> lk_msdynmkt_pushdeviceregistrationresult_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_pushdeviceregistrationresult_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_pushdeviceregistrationresult_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_pushdeviceregistrationresult_modifiedby"></a> lk_msdynmkt_pushdeviceregistrationresult_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_pushdeviceregistrationresult_modifiedby](systemuser.md#BKMK_lk_msdynmkt_pushdeviceregistrationresult_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_pushdeviceregistrationresult_modifiedonbehalfby"></a> lk_msdynmkt_pushdeviceregistrationresult_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_pushdeviceregistrationresult_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_pushdeviceregistrationresult_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_pushmobiledevice_deviceregistrationresult"></a> msdynmkt_pushmobiledevice_deviceregistrationresult

One-To-Many Relationship: [msdynmkt_pushmobiledevice msdynmkt_pushmobiledevice_deviceregistrationresult](msdynmkt_pushmobiledevice.md#BKMK_msdynmkt_pushmobiledevice_deviceregistrationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_pushmobiledevice`|
|ReferencedAttribute|`msdynmkt_pushmobiledeviceid`|
|ReferencingAttribute|`msdynmkt_pushmobiledeviceid`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_pushmobiledeviceid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_pushdeviceregistrationresult"></a> owner_msdynmkt_pushdeviceregistrationresult

One-To-Many Relationship: [owner owner_msdynmkt_pushdeviceregistrationresult](owner.md#BKMK_owner_msdynmkt_pushdeviceregistrationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_pushdeviceregistrationresult"></a> team_msdynmkt_pushdeviceregistrationresult

One-To-Many Relationship: [team team_msdynmkt_pushdeviceregistrationresult](team.md#BKMK_team_msdynmkt_pushdeviceregistrationresult)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_pushdeviceregistrationresult"></a> user_msdynmkt_pushdeviceregistrationresult

One-To-Many Relationship: [systemuser user_msdynmkt_pushdeviceregistrationresult](systemuser.md#BKMK_user_msdynmkt_pushdeviceregistrationresult)

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

- [msdynmkt_pushdeviceregistrationresult_AsyncOperations](#BKMK_msdynmkt_pushdeviceregistrationresult_AsyncOperations)
- [msdynmkt_pushdeviceregistrationresult_BulkDeleteFailures](#BKMK_msdynmkt_pushdeviceregistrationresult_BulkDeleteFailures)
- [msdynmkt_pushdeviceregistrationresult_DuplicateBaseRecord](#BKMK_msdynmkt_pushdeviceregistrationresult_DuplicateBaseRecord)
- [msdynmkt_pushdeviceregistrationresult_DuplicateMatchingRecord](#BKMK_msdynmkt_pushdeviceregistrationresult_DuplicateMatchingRecord)
- [msdynmkt_pushdeviceregistrationresult_MailboxTrackingFolders](#BKMK_msdynmkt_pushdeviceregistrationresult_MailboxTrackingFolders)
- [msdynmkt_pushdeviceregistrationresult_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_pushdeviceregistrationresult_PrincipalObjectAttributeAccesses)
- [msdynmkt_pushdeviceregistrationresult_ProcessSession](#BKMK_msdynmkt_pushdeviceregistrationresult_ProcessSession)
- [msdynmkt_pushdeviceregistrationresult_SyncErrors](#BKMK_msdynmkt_pushdeviceregistrationresult_SyncErrors)

### <a name="BKMK_msdynmkt_pushdeviceregistrationresult_AsyncOperations"></a> msdynmkt_pushdeviceregistrationresult_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_pushdeviceregistrationresult_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_pushdeviceregistrationresult_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_pushdeviceregistrationresult_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_pushdeviceregistrationresult_BulkDeleteFailures"></a> msdynmkt_pushdeviceregistrationresult_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_pushdeviceregistrationresult_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_pushdeviceregistrationresult_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_pushdeviceregistrationresult_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_pushdeviceregistrationresult_DuplicateBaseRecord"></a> msdynmkt_pushdeviceregistrationresult_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_pushdeviceregistrationresult_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_pushdeviceregistrationresult_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_pushdeviceregistrationresult_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_pushdeviceregistrationresult_DuplicateMatchingRecord"></a> msdynmkt_pushdeviceregistrationresult_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_pushdeviceregistrationresult_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_pushdeviceregistrationresult_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_pushdeviceregistrationresult_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_pushdeviceregistrationresult_MailboxTrackingFolders"></a> msdynmkt_pushdeviceregistrationresult_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_pushdeviceregistrationresult_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_pushdeviceregistrationresult_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_pushdeviceregistrationresult_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_pushdeviceregistrationresult_PrincipalObjectAttributeAccesses"></a> msdynmkt_pushdeviceregistrationresult_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_pushdeviceregistrationresult_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_pushdeviceregistrationresult_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_pushdeviceregistrationresult_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_pushdeviceregistrationresult_ProcessSession"></a> msdynmkt_pushdeviceregistrationresult_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_pushdeviceregistrationresult_ProcessSession](processsession.md#BKMK_msdynmkt_pushdeviceregistrationresult_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_pushdeviceregistrationresult_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_pushdeviceregistrationresult_SyncErrors"></a> msdynmkt_pushdeviceregistrationresult_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_pushdeviceregistrationresult_SyncErrors](syncerror.md#BKMK_msdynmkt_pushdeviceregistrationresult_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_pushdeviceregistrationresult_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

