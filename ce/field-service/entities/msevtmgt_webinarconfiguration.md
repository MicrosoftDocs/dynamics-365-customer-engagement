---
title: "Webinar configuration (msevtmgt_webinarconfiguration) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Webinar configuration (msevtmgt_webinarconfiguration) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Webinar configuration (msevtmgt_webinarconfiguration) table/entity reference



## Messages

The following table lists the messages for the Webinar configuration (msevtmgt_webinarconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msevtmgt_webinarconfigurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_webinarconfigurations(*msevtmgt_webinarconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_webinarconfigurations(*msevtmgt_webinarconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_webinarconfigurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_webinarconfigurations(*msevtmgt_webinarconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_webinarconfigurations(*msevtmgt_webinarconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_webinarconfigurations(*msevtmgt_webinarconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Webinar configuration (msevtmgt_webinarconfiguration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Webinar configuration (msevtmgt_webinarconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Webinar configuration** |
| **DisplayCollectionName** | **Webinar configurations** |
| **SchemaName** | `msevtmgt_webinarconfiguration` |
| **CollectionSchemaName** | `msevtmgt_webinarconfigurations` |
| **EntitySetName** | `msevtmgt_webinarconfigurations`|
| **LogicalName** | `msevtmgt_webinarconfiguration` |
| **LogicalCollectionName** | `msevtmgt_webinarconfigurations` |
| **PrimaryIdAttribute** | `msevtmgt_webinarconfigurationid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_accesstoken](#BKMK_msevtmgt_accesstoken)
- [msevtmgt_AccessTokenKey](#BKMK_msevtmgt_AccessTokenKey)
- [msevtmgt_AccessTokenSecret](#BKMK_msevtmgt_AccessTokenSecret)
- [msevtmgt_appURL](#BKMK_msevtmgt_appURL)
- [msevtmgt_authorized](#BKMK_msevtmgt_authorized)
- [msevtmgt_ClientId](#BKMK_msevtmgt_ClientId)
- [msevtmgt_LastUpdateDateTime](#BKMK_msevtmgt_LastUpdateDateTime)
- [msevtmgt_Message](#BKMK_msevtmgt_Message)
- [msevtmgt_name](#BKMK_msevtmgt_name)
- [msevtmgt_providerservicestatus](#BKMK_msevtmgt_providerservicestatus)
- [msevtmgt_UpdateCredentials](#BKMK_msevtmgt_UpdateCredentials)
- [msevtmgt_webinarconfigurationId](#BKMK_msevtmgt_webinarconfigurationId)
- [msevtmgt_WebinarProviderId](#BKMK_msevtmgt_WebinarProviderId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)

### <a name="BKMK_ImportSequenceNumber"></a> ImportSequenceNumber

|Property|Value|
|---|---|
|Description|**The sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msevtmgt_accesstoken"></a> msevtmgt_accesstoken

|Property|Value|
|---|---|
|Description||
|DisplayName|**Access token**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_accesstoken`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_AccessTokenKey"></a> msevtmgt_AccessTokenKey

|Property|Value|
|---|---|
|Description||
|DisplayName|**Access token key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_accesstokenkey`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_AccessTokenSecret"></a> msevtmgt_AccessTokenSecret

|Property|Value|
|---|---|
|Description||
|DisplayName|**Access token secret**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_accesstokensecret`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|130|

### <a name="BKMK_msevtmgt_appURL"></a> msevtmgt_appURL

|Property|Value|
|---|---|
|Description||
|DisplayName|**App URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_appurl`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_authorized"></a> msevtmgt_authorized

|Property|Value|
|---|---|
|Description|**Tells whether the credentials in this webinar configuration have been authenticated with the provider**|
|DisplayName|**Authenticated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_authorized`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_webinarconfiguration_msevtmgt_authorized`|

#### msevtmgt_authorized Choices/Options

|Value|Label|
|---|---|
|100000000|**Yes**|
|100000001|**No**|
|100000002|**Token expired**|

### <a name="BKMK_msevtmgt_ClientId"></a> msevtmgt_ClientId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Client ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_clientid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_LastUpdateDateTime"></a> msevtmgt_LastUpdateDateTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Last metrics update**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_lastupdatedatetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msevtmgt_Message"></a> msevtmgt_Message

|Property|Value|
|---|---|
|Description||
|DisplayName|**Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_message`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msevtmgt_name"></a> msevtmgt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msevtmgt_providerservicestatus"></a> msevtmgt_providerservicestatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Provider service status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_providerservicestatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msevtmgt_providerservicestatus`|

#### msevtmgt_providerservicestatus Choices/Options

|Value|Label|
|---|---|
|100000000|**Healthy**|
|100000001|**Not authenticated**|
|100000002|**Forbidden**|
|100000003|**Unhealthy**|

### <a name="BKMK_msevtmgt_UpdateCredentials"></a> msevtmgt_UpdateCredentials

|Property|Value|
|---|---|
|Description||
|DisplayName|**Update credentials?**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_updatecredentials`|
|RequiredLevel|Recommended|
|Type|Picklist|
|DefaultFormValue|100000001|
|GlobalChoiceName|`msevtmgt_yesorno`|

#### msevtmgt_UpdateCredentials Choices/Options

|Value|Label|
|---|---|
|100000001|**Yes**|
|100000002|**No**|

### <a name="BKMK_msevtmgt_webinarconfigurationId"></a> msevtmgt_webinarconfigurationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Webinar configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarconfigurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msevtmgt_WebinarProviderId"></a> msevtmgt_WebinarProviderId

|Property|Value|
|---|---|
|Description|**Unique identifier for the webinar provider associated with the webinar configuration**|
|DisplayName|**Webinar provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarproviderid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msevtmgt_webinarprovider|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**The date and time when the record was migrated**|
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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the webinar configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_webinarconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the webinar configuration**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_webinarconfiguration_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
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
|Description|**The time zone code that was in use when the record was created**|
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
- [OrganizationId](#BKMK_OrganizationId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|---|---|
|Description|**Unique identifier of the user who created the record**|
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
|Description|**The date and time when the record was created**|
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
|Description|**Unique identifier of the delegate user who created the record**|
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
|Description|**Unique identifier of the user who modified the record**|
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
|Description|**The date and time when the record was modified**|
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
|Description|**Unique identifier of the delegate user who modified the record**|
|DisplayName|**Modified by (delegate)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`modifiedonbehalfby`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`organizationid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|organization|

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

- [lk_msevtmgt_webinarconfiguration_createdby](#BKMK_lk_msevtmgt_webinarconfiguration_createdby)
- [lk_msevtmgt_webinarconfiguration_createdonbehalfby](#BKMK_lk_msevtmgt_webinarconfiguration_createdonbehalfby)
- [lk_msevtmgt_webinarconfiguration_modifiedby](#BKMK_lk_msevtmgt_webinarconfiguration_modifiedby)
- [lk_msevtmgt_webinarconfiguration_modifiedonbehalfby](#BKMK_lk_msevtmgt_webinarconfiguration_modifiedonbehalfby)
- [msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov](#BKMK_msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov)
- [organization_msevtmgt_webinarconfiguration](#BKMK_organization_msevtmgt_webinarconfiguration)

### <a name="BKMK_lk_msevtmgt_webinarconfiguration_createdby"></a> lk_msevtmgt_webinarconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinarconfiguration_createdby](systemuser.md#BKMK_lk_msevtmgt_webinarconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webinarconfiguration_createdonbehalfby"></a> lk_msevtmgt_webinarconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinarconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_webinarconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webinarconfiguration_modifiedby"></a> lk_msevtmgt_webinarconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinarconfiguration_modifiedby](systemuser.md#BKMK_lk_msevtmgt_webinarconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webinarconfiguration_modifiedonbehalfby"></a> lk_msevtmgt_webinarconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinarconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_webinarconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov"></a> msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov

One-To-Many Relationship: [msevtmgt_webinarprovider msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov](msevtmgt_webinarprovider.md#BKMK_msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov)

|Property|Value|
|---|---|
|ReferencedEntity|`msevtmgt_webinarprovider`|
|ReferencedAttribute|`msevtmgt_webinarproviderid`|
|ReferencingAttribute|`msevtmgt_webinarproviderid`|
|ReferencingEntityNavigationPropertyName|`msevtmgt_WebinarProviderId`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msevtmgt_webinarconfiguration"></a> organization_msevtmgt_webinarconfiguration

One-To-Many Relationship: [organization organization_msevtmgt_webinarconfiguration](organization.md#BKMK_organization_msevtmgt_webinarconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`organization`|
|ReferencedAttribute|`organizationid`|
|ReferencingAttribute|`organizationid`|
|ReferencingEntityNavigationPropertyName|`organizationid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration](#BKMK_msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration)
- [msevtmgt_webinarconfiguration_ActivityPointers](#BKMK_msevtmgt_webinarconfiguration_ActivityPointers)
- [msevtmgt_webinarconfiguration_adx_alertsubscriptions](#BKMK_msevtmgt_webinarconfiguration_adx_alertsubscriptions)
- [msevtmgt_webinarconfiguration_adx_inviteredemptions](#BKMK_msevtmgt_webinarconfiguration_adx_inviteredemptions)
- [msevtmgt_webinarconfiguration_adx_portalcomments](#BKMK_msevtmgt_webinarconfiguration_adx_portalcomments)
- [msevtmgt_webinarconfiguration_Annotations](#BKMK_msevtmgt_webinarconfiguration_Annotations)
- [msevtmgt_webinarconfiguration_Appointments](#BKMK_msevtmgt_webinarconfiguration_Appointments)
- [msevtmgt_webinarconfiguration_AsyncOperations](#BKMK_msevtmgt_webinarconfiguration_AsyncOperations)
- [msevtmgt_webinarconfiguration_BulkDeleteFailures](#BKMK_msevtmgt_webinarconfiguration_BulkDeleteFailures)
- [msevtmgt_webinarconfiguration_chats](#BKMK_msevtmgt_webinarconfiguration_chats)
- [msevtmgt_webinarconfiguration_Emails](#BKMK_msevtmgt_webinarconfiguration_Emails)
- [msevtmgt_webinarconfiguration_Faxes](#BKMK_msevtmgt_webinarconfiguration_Faxes)
- [msevtmgt_webinarconfiguration_Letters](#BKMK_msevtmgt_webinarconfiguration_Letters)
- [msevtmgt_webinarconfiguration_li_inmails](#BKMK_msevtmgt_webinarconfiguration_li_inmails)
- [msevtmgt_webinarconfiguration_li_messages](#BKMK_msevtmgt_webinarconfiguration_li_messages)
- [msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds)
- [msevtmgt_webinarconfiguration_MailboxTrackingFolders](#BKMK_msevtmgt_webinarconfiguration_MailboxTrackingFolders)
- [msevtmgt_webinarconfiguration_msdyn_bookingalerts](#BKMK_msevtmgt_webinarconfiguration_msdyn_bookingalerts)
- [msevtmgt_webinarconfiguration_msdyn_copilottranscripts](#BKMK_msevtmgt_webinarconfiguration_msdyn_copilottranscripts)
- [msevtmgt_webinarconfiguration_msdyn_ocliveworkitems](#BKMK_msevtmgt_webinarconfiguration_msdyn_ocliveworkitems)
- [msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages](#BKMK_msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages)
- [msevtmgt_webinarconfiguration_msdyn_ocsessions](#BKMK_msevtmgt_webinarconfiguration_msdyn_ocsessions)
- [msevtmgt_webinarconfiguration_msdyn_ocvoicemails](#BKMK_msevtmgt_webinarconfiguration_msdyn_ocvoicemails)
- [msevtmgt_webinarconfiguration_msevtmgt_event_Web](#BKMK_msevtmgt_webinarconfiguration_msevtmgt_event_Web)
- [msevtmgt_webinarconfiguration_msevtmgt_session_Web](#BKMK_msevtmgt_webinarconfiguration_msevtmgt_session_Web)
- [msevtmgt_webinarconfiguration_msfp_alerts](#BKMK_msevtmgt_webinarconfiguration_msfp_alerts)
- [msevtmgt_webinarconfiguration_msfp_surveyinvites](#BKMK_msevtmgt_webinarconfiguration_msfp_surveyinvites)
- [msevtmgt_webinarconfiguration_msfp_surveyresponses](#BKMK_msevtmgt_webinarconfiguration_msfp_surveyresponses)
- [msevtmgt_webinarconfiguration_PhoneCalls](#BKMK_msevtmgt_webinarconfiguration_PhoneCalls)
- [msevtmgt_webinarconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_webinarconfiguration_PrincipalObjectAttributeAccesses)
- [msevtmgt_webinarconfiguration_ProcessSession](#BKMK_msevtmgt_webinarconfiguration_ProcessSession)
- [msevtmgt_webinarconfiguration_RecurringAppointmentMasters](#BKMK_msevtmgt_webinarconfiguration_RecurringAppointmentMasters)
- [msevtmgt_webinarconfiguration_ServiceAppointments](#BKMK_msevtmgt_webinarconfiguration_ServiceAppointments)
- [msevtmgt_webinarconfiguration_SocialActivities](#BKMK_msevtmgt_webinarconfiguration_SocialActivities)
- [msevtmgt_webinarconfiguration_SyncErrors](#BKMK_msevtmgt_webinarconfiguration_SyncErrors)
- [msevtmgt_webinarconfiguration_Tasks](#BKMK_msevtmgt_webinarconfiguration_Tasks)

### <a name="BKMK_msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration"></a> msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration

Many-To-One Relationship: [msevtmgt_webinartype msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration](msevtmgt_webinartype.md#BKMK_msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_webinartype`|
|ReferencingAttribute|`msevtmgt_webinarconfiguration`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_webinarconfiguration_msevtmgt_webinartype_webinarconfiguration`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_ActivityPointers"></a> msevtmgt_webinarconfiguration_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_webinarconfiguration_ActivityPointers](activitypointer.md#BKMK_msevtmgt_webinarconfiguration_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_adx_alertsubscriptions"></a> msevtmgt_webinarconfiguration_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_webinarconfiguration_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_webinarconfiguration_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_adx_inviteredemptions"></a> msevtmgt_webinarconfiguration_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_webinarconfiguration_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_webinarconfiguration_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_adx_portalcomments"></a> msevtmgt_webinarconfiguration_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_webinarconfiguration_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_webinarconfiguration_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_Annotations"></a> msevtmgt_webinarconfiguration_Annotations

Many-To-One Relationship: [annotation msevtmgt_webinarconfiguration_Annotations](annotation.md#BKMK_msevtmgt_webinarconfiguration_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_Appointments"></a> msevtmgt_webinarconfiguration_Appointments

Many-To-One Relationship: [appointment msevtmgt_webinarconfiguration_Appointments](appointment.md#BKMK_msevtmgt_webinarconfiguration_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_AsyncOperations"></a> msevtmgt_webinarconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_webinarconfiguration_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_webinarconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_BulkDeleteFailures"></a> msevtmgt_webinarconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_webinarconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_webinarconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_chats"></a> msevtmgt_webinarconfiguration_chats

Many-To-One Relationship: [chat msevtmgt_webinarconfiguration_chats](chat.md#BKMK_msevtmgt_webinarconfiguration_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_Emails"></a> msevtmgt_webinarconfiguration_Emails

Many-To-One Relationship: [email msevtmgt_webinarconfiguration_Emails](email.md#BKMK_msevtmgt_webinarconfiguration_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_Faxes"></a> msevtmgt_webinarconfiguration_Faxes

Many-To-One Relationship: [fax msevtmgt_webinarconfiguration_Faxes](fax.md#BKMK_msevtmgt_webinarconfiguration_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_Letters"></a> msevtmgt_webinarconfiguration_Letters

Many-To-One Relationship: [letter msevtmgt_webinarconfiguration_Letters](letter.md#BKMK_msevtmgt_webinarconfiguration_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_li_inmails"></a> msevtmgt_webinarconfiguration_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_webinarconfiguration_li_inmails](li_inmail.md#BKMK_msevtmgt_webinarconfiguration_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_li_messages"></a> msevtmgt_webinarconfiguration_li_messages

Many-To-One Relationship: [li_message msevtmgt_webinarconfiguration_li_messages](li_message.md#BKMK_msevtmgt_webinarconfiguration_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds"></a> msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_MailboxTrackingFolders"></a> msevtmgt_webinarconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_webinarconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_webinarconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msdyn_bookingalerts"></a> msevtmgt_webinarconfiguration_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_webinarconfiguration_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_webinarconfiguration_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msdyn_copilottranscripts"></a> msevtmgt_webinarconfiguration_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_webinarconfiguration_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_webinarconfiguration_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msdyn_ocliveworkitems"></a> msevtmgt_webinarconfiguration_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_webinarconfiguration_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_webinarconfiguration_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages"></a> msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msdyn_ocsessions"></a> msevtmgt_webinarconfiguration_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_webinarconfiguration_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_webinarconfiguration_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msdyn_ocvoicemails"></a> msevtmgt_webinarconfiguration_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_webinarconfiguration_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_webinarconfiguration_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msevtmgt_event_Web"></a> msevtmgt_webinarconfiguration_msevtmgt_event_Web

Many-To-One Relationship: [msevtmgt_event msevtmgt_webinarconfiguration_msevtmgt_event_Web](msevtmgt_event.md#BKMK_msevtmgt_webinarconfiguration_msevtmgt_event_Web)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_event`|
|ReferencingAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_msevtmgt_event_Web`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msevtmgt_session_Web"></a> msevtmgt_webinarconfiguration_msevtmgt_session_Web

Many-To-One Relationship: [msevtmgt_session msevtmgt_webinarconfiguration_msevtmgt_session_Web](msevtmgt_session.md#BKMK_msevtmgt_webinarconfiguration_msevtmgt_session_Web)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_session`|
|ReferencingAttribute|`msevtmgt_webinarconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_msevtmgt_session_Web`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msfp_alerts"></a> msevtmgt_webinarconfiguration_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_webinarconfiguration_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_webinarconfiguration_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msfp_surveyinvites"></a> msevtmgt_webinarconfiguration_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_webinarconfiguration_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_webinarconfiguration_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_msfp_surveyresponses"></a> msevtmgt_webinarconfiguration_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_webinarconfiguration_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_webinarconfiguration_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_PhoneCalls"></a> msevtmgt_webinarconfiguration_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_webinarconfiguration_PhoneCalls](phonecall.md#BKMK_msevtmgt_webinarconfiguration_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_PrincipalObjectAttributeAccesses"></a> msevtmgt_webinarconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_webinarconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_webinarconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_ProcessSession"></a> msevtmgt_webinarconfiguration_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_webinarconfiguration_ProcessSession](processsession.md#BKMK_msevtmgt_webinarconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_RecurringAppointmentMasters"></a> msevtmgt_webinarconfiguration_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_webinarconfiguration_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_webinarconfiguration_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_ServiceAppointments"></a> msevtmgt_webinarconfiguration_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_webinarconfiguration_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_webinarconfiguration_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_SocialActivities"></a> msevtmgt_webinarconfiguration_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_webinarconfiguration_SocialActivities](socialactivity.md#BKMK_msevtmgt_webinarconfiguration_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_SyncErrors"></a> msevtmgt_webinarconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_webinarconfiguration_SyncErrors](syncerror.md#BKMK_msevtmgt_webinarconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarconfiguration_Tasks"></a> msevtmgt_webinarconfiguration_Tasks

Many-To-One Relationship: [task msevtmgt_webinarconfiguration_Tasks](task.md#BKMK_msevtmgt_webinarconfiguration_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarconfiguration_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

