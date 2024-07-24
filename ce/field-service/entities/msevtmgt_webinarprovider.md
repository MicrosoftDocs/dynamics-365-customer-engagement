---
title: "Webinar provider (msevtmgt_WebinarProvider) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Webinar provider (msevtmgt_WebinarProvider) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Webinar provider (msevtmgt_WebinarProvider) table/entity reference

A company that provides the infrastrucutre needed for hosting a webinar

## Messages

The following table lists the messages for the Webinar provider (msevtmgt_WebinarProvider) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Create`<br />Event: True |`POST` /msevtmgt_webinarproviders<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msevtmgt_webinarproviders(*msevtmgt_webinarproviderid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msevtmgt_webinarproviders(*msevtmgt_webinarproviderid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msevtmgt_webinarproviders<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `SetState`<br />Event: True |`PATCH` /msevtmgt_webinarproviders(*msevtmgt_webinarproviderid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msevtmgt_webinarproviders(*msevtmgt_webinarproviderid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msevtmgt_webinarproviders(*msevtmgt_webinarproviderid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Webinar provider (msevtmgt_WebinarProvider) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Webinar provider (msevtmgt_WebinarProvider) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Webinar provider** |
| **DisplayCollectionName** | **Webinar providers** |
| **SchemaName** | `msevtmgt_WebinarProvider` |
| **CollectionSchemaName** | `msevtmgt_WebinarProviders` |
| **EntitySetName** | `msevtmgt_webinarproviders`|
| **LogicalName** | `msevtmgt_webinarprovider` |
| **LogicalCollectionName** | `msevtmgt_webinarproviders` |
| **PrimaryIdAttribute** | `msevtmgt_webinarproviderid` |
| **PrimaryNameAttribute** |`msevtmgt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msevtmgt_base_service_url](#BKMK_msevtmgt_base_service_url)
- [msevtmgt_clientid](#BKMK_msevtmgt_clientid)
- [msevtmgt_clientsecret](#BKMK_msevtmgt_clientsecret)
- [msevtmgt_IsDefaultProvider](#BKMK_msevtmgt_IsDefaultProvider)
- [msevtmgt_MaxDurationInMinutes](#BKMK_msevtmgt_MaxDurationInMinutes)
- [msevtmgt_name](#BKMK_msevtmgt_name)
- [msevtmgt_privacypolicy](#BKMK_msevtmgt_privacypolicy)
- [msevtmgt_termsofservice](#BKMK_msevtmgt_termsofservice)
- [msevtmgt_updatecredentials](#BKMK_msevtmgt_updatecredentials)
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

### <a name="BKMK_msevtmgt_base_service_url"></a> msevtmgt_base_service_url

|Property|Value|
|---|---|
|Description||
|DisplayName|**Base service URL**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_base_service_url`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msevtmgt_clientid"></a> msevtmgt_clientid

|Property|Value|
|---|---|
|Description|**The client ID that identifies this Dynamics 365 organization to the webinar provider. The webinar provider generates this ID.**|
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

### <a name="BKMK_msevtmgt_clientsecret"></a> msevtmgt_clientsecret

|Property|Value|
|---|---|
|Description|**The client secret**|
|DisplayName|**Client secret**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_clientsecret`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|500|

### <a name="BKMK_msevtmgt_IsDefaultProvider"></a> msevtmgt_IsDefaultProvider

|Property|Value|
|---|---|
|Description|**If the value is set to 'Yes', the webinar provider comes out of the box and it's preconfigured by Microsoft.**|
|DisplayName|**Is default provider**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_isdefaultprovider`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_webinarprovider_msevtmgt_isdefaultprovider`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_MaxDurationInMinutes"></a> msevtmgt_MaxDurationInMinutes

|Property|Value|
|---|---|
|Description||
|DisplayName|**Max. duration in minutes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_maxdurationinminutes`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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

### <a name="BKMK_msevtmgt_privacypolicy"></a> msevtmgt_privacypolicy

|Property|Value|
|---|---|
|Description|**Privacy policy URL**|
|DisplayName|**Privacy policy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_privacypolicy`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msevtmgt_termsofservice"></a> msevtmgt_termsofservice

|Property|Value|
|---|---|
|Description|**Terms of service URL**|
|DisplayName|**Terms of service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_termsofservice`|
|RequiredLevel|None|
|Type|String|
|Format|Url|
|FormatName|Url|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msevtmgt_updatecredentials"></a> msevtmgt_updatecredentials

|Property|Value|
|---|---|
|Description||
|DisplayName|**Update credentials**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msevtmgt_updatecredentials`|
|RequiredLevel|Recommended|
|Type|Boolean|
|GlobalChoiceName|`msevtmgt_webinarprovider_msevtmgt_updatecredentials`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msevtmgt_WebinarProviderId"></a> msevtmgt_WebinarProviderId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Webinar provider**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msevtmgt_webinarproviderid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the webinar provider**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_webinarprovider_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the webinar provider**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msevtmgt_webinarprovider_statuscode`|

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

- [lk_msevtmgt_webinarprovider_createdby](#BKMK_lk_msevtmgt_webinarprovider_createdby)
- [lk_msevtmgt_webinarprovider_createdonbehalfby](#BKMK_lk_msevtmgt_webinarprovider_createdonbehalfby)
- [lk_msevtmgt_webinarprovider_modifiedby](#BKMK_lk_msevtmgt_webinarprovider_modifiedby)
- [lk_msevtmgt_webinarprovider_modifiedonbehalfby](#BKMK_lk_msevtmgt_webinarprovider_modifiedonbehalfby)
- [organization_msevtmgt_webinarprovider](#BKMK_organization_msevtmgt_webinarprovider)

### <a name="BKMK_lk_msevtmgt_webinarprovider_createdby"></a> lk_msevtmgt_webinarprovider_createdby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinarprovider_createdby](systemuser.md#BKMK_lk_msevtmgt_webinarprovider_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webinarprovider_createdonbehalfby"></a> lk_msevtmgt_webinarprovider_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinarprovider_createdonbehalfby](systemuser.md#BKMK_lk_msevtmgt_webinarprovider_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webinarprovider_modifiedby"></a> lk_msevtmgt_webinarprovider_modifiedby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinarprovider_modifiedby](systemuser.md#BKMK_lk_msevtmgt_webinarprovider_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msevtmgt_webinarprovider_modifiedonbehalfby"></a> lk_msevtmgt_webinarprovider_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msevtmgt_webinarprovider_modifiedonbehalfby](systemuser.md#BKMK_lk_msevtmgt_webinarprovider_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msevtmgt_webinarprovider"></a> organization_msevtmgt_webinarprovider

One-To-Many Relationship: [organization organization_msevtmgt_webinarprovider](organization.md#BKMK_organization_msevtmgt_webinarprovider)

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

- [msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId](#BKMK_msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId)
- [msevtmgt_webinarprovider_ActivityPointers](#BKMK_msevtmgt_webinarprovider_ActivityPointers)
- [msevtmgt_webinarprovider_adx_alertsubscriptions](#BKMK_msevtmgt_webinarprovider_adx_alertsubscriptions)
- [msevtmgt_webinarprovider_adx_inviteredemptions](#BKMK_msevtmgt_webinarprovider_adx_inviteredemptions)
- [msevtmgt_webinarprovider_adx_portalcomments](#BKMK_msevtmgt_webinarprovider_adx_portalcomments)
- [msevtmgt_webinarprovider_Annotations](#BKMK_msevtmgt_webinarprovider_Annotations)
- [msevtmgt_webinarprovider_Appointments](#BKMK_msevtmgt_webinarprovider_Appointments)
- [msevtmgt_webinarprovider_AsyncOperations](#BKMK_msevtmgt_webinarprovider_AsyncOperations)
- [msevtmgt_webinarprovider_BulkDeleteFailures](#BKMK_msevtmgt_webinarprovider_BulkDeleteFailures)
- [msevtmgt_webinarprovider_chats](#BKMK_msevtmgt_webinarprovider_chats)
- [msevtmgt_webinarprovider_Emails](#BKMK_msevtmgt_webinarprovider_Emails)
- [msevtmgt_webinarprovider_Faxes](#BKMK_msevtmgt_webinarprovider_Faxes)
- [msevtmgt_webinarprovider_Letters](#BKMK_msevtmgt_webinarprovider_Letters)
- [msevtmgt_webinarprovider_li_inmails](#BKMK_msevtmgt_webinarprovider_li_inmails)
- [msevtmgt_webinarprovider_li_messages](#BKMK_msevtmgt_webinarprovider_li_messages)
- [msevtmgt_webinarprovider_li_pointdrivepresentationvieweds](#BKMK_msevtmgt_webinarprovider_li_pointdrivepresentationvieweds)
- [msevtmgt_webinarprovider_MailboxTrackingFolders](#BKMK_msevtmgt_webinarprovider_MailboxTrackingFolders)
- [msevtmgt_webinarprovider_msdyn_bookingalerts](#BKMK_msevtmgt_webinarprovider_msdyn_bookingalerts)
- [msevtmgt_webinarprovider_msdyn_copilottranscripts](#BKMK_msevtmgt_webinarprovider_msdyn_copilottranscripts)
- [msevtmgt_webinarprovider_msdyn_ocliveworkitems](#BKMK_msevtmgt_webinarprovider_msdyn_ocliveworkitems)
- [msevtmgt_webinarprovider_msdyn_ocoutboundmessages](#BKMK_msevtmgt_webinarprovider_msdyn_ocoutboundmessages)
- [msevtmgt_webinarprovider_msdyn_ocsessions](#BKMK_msevtmgt_webinarprovider_msdyn_ocsessions)
- [msevtmgt_webinarprovider_msdyn_ocvoicemails](#BKMK_msevtmgt_webinarprovider_msdyn_ocvoicemails)
- [msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov](#BKMK_msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov)
- [msevtmgt_webinarprovider_msfp_alerts](#BKMK_msevtmgt_webinarprovider_msfp_alerts)
- [msevtmgt_webinarprovider_msfp_surveyinvites](#BKMK_msevtmgt_webinarprovider_msfp_surveyinvites)
- [msevtmgt_webinarprovider_msfp_surveyresponses](#BKMK_msevtmgt_webinarprovider_msfp_surveyresponses)
- [msevtmgt_webinarprovider_PhoneCalls](#BKMK_msevtmgt_webinarprovider_PhoneCalls)
- [msevtmgt_webinarprovider_PrincipalObjectAttributeAccesses](#BKMK_msevtmgt_webinarprovider_PrincipalObjectAttributeAccesses)
- [msevtmgt_webinarprovider_ProcessSession](#BKMK_msevtmgt_webinarprovider_ProcessSession)
- [msevtmgt_webinarprovider_RecurringAppointmentMasters](#BKMK_msevtmgt_webinarprovider_RecurringAppointmentMasters)
- [msevtmgt_webinarprovider_ServiceAppointments](#BKMK_msevtmgt_webinarprovider_ServiceAppointments)
- [msevtmgt_webinarprovider_SocialActivities](#BKMK_msevtmgt_webinarprovider_SocialActivities)
- [msevtmgt_webinarprovider_SyncErrors](#BKMK_msevtmgt_webinarprovider_SyncErrors)
- [msevtmgt_webinarprovider_Tasks](#BKMK_msevtmgt_webinarprovider_Tasks)
- [msevtmgt_webinarprovider_webinarconsent](#BKMK_msevtmgt_webinarprovider_webinarconsent)

### <a name="BKMK_msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId"></a> msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId

Many-To-One Relationship: [msevtmgt_webinartype msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId](msevtmgt_webinartype.md#BKMK_msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_webinartype`|
|ReferencingAttribute|`msevtmgt_webinarproviderid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_msevtmgt_webinarprovider_msevtmgt_webinartype_WebinarProviderId`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_ActivityPointers"></a> msevtmgt_webinarprovider_ActivityPointers

Many-To-One Relationship: [activitypointer msevtmgt_webinarprovider_ActivityPointers](activitypointer.md#BKMK_msevtmgt_webinarprovider_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_adx_alertsubscriptions"></a> msevtmgt_webinarprovider_adx_alertsubscriptions

Many-To-One Relationship: [adx_alertsubscription msevtmgt_webinarprovider_adx_alertsubscriptions](adx_alertsubscription.md#BKMK_msevtmgt_webinarprovider_adx_alertsubscriptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_alertsubscription`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_adx_alertsubscriptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_adx_inviteredemptions"></a> msevtmgt_webinarprovider_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msevtmgt_webinarprovider_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msevtmgt_webinarprovider_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_adx_portalcomments"></a> msevtmgt_webinarprovider_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msevtmgt_webinarprovider_adx_portalcomments](adx_portalcomment.md#BKMK_msevtmgt_webinarprovider_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_Annotations"></a> msevtmgt_webinarprovider_Annotations

Many-To-One Relationship: [annotation msevtmgt_webinarprovider_Annotations](annotation.md#BKMK_msevtmgt_webinarprovider_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_Appointments"></a> msevtmgt_webinarprovider_Appointments

Many-To-One Relationship: [appointment msevtmgt_webinarprovider_Appointments](appointment.md#BKMK_msevtmgt_webinarprovider_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_AsyncOperations"></a> msevtmgt_webinarprovider_AsyncOperations

Many-To-One Relationship: [asyncoperation msevtmgt_webinarprovider_AsyncOperations](asyncoperation.md#BKMK_msevtmgt_webinarprovider_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_BulkDeleteFailures"></a> msevtmgt_webinarprovider_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msevtmgt_webinarprovider_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msevtmgt_webinarprovider_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_chats"></a> msevtmgt_webinarprovider_chats

Many-To-One Relationship: [chat msevtmgt_webinarprovider_chats](chat.md#BKMK_msevtmgt_webinarprovider_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_Emails"></a> msevtmgt_webinarprovider_Emails

Many-To-One Relationship: [email msevtmgt_webinarprovider_Emails](email.md#BKMK_msevtmgt_webinarprovider_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_Faxes"></a> msevtmgt_webinarprovider_Faxes

Many-To-One Relationship: [fax msevtmgt_webinarprovider_Faxes](fax.md#BKMK_msevtmgt_webinarprovider_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_Letters"></a> msevtmgt_webinarprovider_Letters

Many-To-One Relationship: [letter msevtmgt_webinarprovider_Letters](letter.md#BKMK_msevtmgt_webinarprovider_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_li_inmails"></a> msevtmgt_webinarprovider_li_inmails

Many-To-One Relationship: [li_inmail msevtmgt_webinarprovider_li_inmails](li_inmail.md#BKMK_msevtmgt_webinarprovider_li_inmails)

|Property|Value|
|---|---|
|ReferencingEntity|`li_inmail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_li_inmails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_li_messages"></a> msevtmgt_webinarprovider_li_messages

Many-To-One Relationship: [li_message msevtmgt_webinarprovider_li_messages](li_message.md#BKMK_msevtmgt_webinarprovider_li_messages)

|Property|Value|
|---|---|
|ReferencingEntity|`li_message`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_li_messages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_li_pointdrivepresentationvieweds"></a> msevtmgt_webinarprovider_li_pointdrivepresentationvieweds

Many-To-One Relationship: [li_pointdrivepresentationviewed msevtmgt_webinarprovider_li_pointdrivepresentationvieweds](li_pointdrivepresentationviewed.md#BKMK_msevtmgt_webinarprovider_li_pointdrivepresentationvieweds)

|Property|Value|
|---|---|
|ReferencingEntity|`li_pointdrivepresentationviewed`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_li_pointdrivepresentationvieweds`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_MailboxTrackingFolders"></a> msevtmgt_webinarprovider_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msevtmgt_webinarprovider_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msevtmgt_webinarprovider_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_msdyn_bookingalerts"></a> msevtmgt_webinarprovider_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msevtmgt_webinarprovider_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msevtmgt_webinarprovider_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_msdyn_copilottranscripts"></a> msevtmgt_webinarprovider_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msevtmgt_webinarprovider_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msevtmgt_webinarprovider_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_msdyn_ocliveworkitems"></a> msevtmgt_webinarprovider_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msevtmgt_webinarprovider_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msevtmgt_webinarprovider_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_msdyn_ocoutboundmessages"></a> msevtmgt_webinarprovider_msdyn_ocoutboundmessages

Many-To-One Relationship: [msdyn_ocoutboundmessage msevtmgt_webinarprovider_msdyn_ocoutboundmessages](msdyn_ocoutboundmessage.md#BKMK_msevtmgt_webinarprovider_msdyn_ocoutboundmessages)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocoutboundmessage`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_msdyn_ocoutboundmessages`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_msdyn_ocsessions"></a> msevtmgt_webinarprovider_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msevtmgt_webinarprovider_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msevtmgt_webinarprovider_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_msdyn_ocvoicemails"></a> msevtmgt_webinarprovider_msdyn_ocvoicemails

Many-To-One Relationship: [msdyn_ocvoicemail msevtmgt_webinarprovider_msdyn_ocvoicemails](msdyn_ocvoicemail.md#BKMK_msevtmgt_webinarprovider_msdyn_ocvoicemails)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocvoicemail`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_msdyn_ocvoicemails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov"></a> msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov

Many-To-One Relationship: [msevtmgt_webinarconfiguration msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov](msevtmgt_webinarconfiguration.md#BKMK_msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_webinarconfiguration`|
|ReferencingAttribute|`msevtmgt_webinarproviderid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_msevtmgt_webinarconf_Prov`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_msfp_alerts"></a> msevtmgt_webinarprovider_msfp_alerts

Many-To-One Relationship: [msfp_alert msevtmgt_webinarprovider_msfp_alerts](msfp_alert.md#BKMK_msevtmgt_webinarprovider_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_msfp_surveyinvites"></a> msevtmgt_webinarprovider_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msevtmgt_webinarprovider_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msevtmgt_webinarprovider_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_msfp_surveyresponses"></a> msevtmgt_webinarprovider_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msevtmgt_webinarprovider_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msevtmgt_webinarprovider_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_PhoneCalls"></a> msevtmgt_webinarprovider_PhoneCalls

Many-To-One Relationship: [phonecall msevtmgt_webinarprovider_PhoneCalls](phonecall.md#BKMK_msevtmgt_webinarprovider_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_PrincipalObjectAttributeAccesses"></a> msevtmgt_webinarprovider_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msevtmgt_webinarprovider_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msevtmgt_webinarprovider_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_ProcessSession"></a> msevtmgt_webinarprovider_ProcessSession

Many-To-One Relationship: [processsession msevtmgt_webinarprovider_ProcessSession](processsession.md#BKMK_msevtmgt_webinarprovider_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_RecurringAppointmentMasters"></a> msevtmgt_webinarprovider_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msevtmgt_webinarprovider_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msevtmgt_webinarprovider_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_ServiceAppointments"></a> msevtmgt_webinarprovider_ServiceAppointments

Many-To-One Relationship: [serviceappointment msevtmgt_webinarprovider_ServiceAppointments](serviceappointment.md#BKMK_msevtmgt_webinarprovider_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_SocialActivities"></a> msevtmgt_webinarprovider_SocialActivities

Many-To-One Relationship: [socialactivity msevtmgt_webinarprovider_SocialActivities](socialactivity.md#BKMK_msevtmgt_webinarprovider_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_SyncErrors"></a> msevtmgt_webinarprovider_SyncErrors

Many-To-One Relationship: [syncerror msevtmgt_webinarprovider_SyncErrors](syncerror.md#BKMK_msevtmgt_webinarprovider_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_Tasks"></a> msevtmgt_webinarprovider_Tasks

Many-To-One Relationship: [task msevtmgt_webinarprovider_Tasks](task.md#BKMK_msevtmgt_webinarprovider_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msevtmgt_webinarprovider_webinarconsent"></a> msevtmgt_webinarprovider_webinarconsent

Many-To-One Relationship: [msevtmgt_webinarconsent msevtmgt_webinarprovider_webinarconsent](msevtmgt_webinarconsent.md#BKMK_msevtmgt_webinarprovider_webinarconsent)

|Property|Value|
|---|---|
|ReferencingEntity|`msevtmgt_webinarconsent`|
|ReferencingAttribute|`msevtmgt_webinarprovider`|
|ReferencedEntityNavigationPropertyName|`msevtmgt_webinarprovider_webinarconsent`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

