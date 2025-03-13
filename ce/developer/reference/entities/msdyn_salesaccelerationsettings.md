---
title: "Sales Acceleration settings (msdyn_salesaccelerationsettings) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Sales Acceleration settings (msdyn_salesaccelerationsettings) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Sales Acceleration settings (msdyn_salesaccelerationsettings) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Sales Acceleration settings (msdyn_salesaccelerationsettings) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_salesaccelerationsettingset<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_salesaccelerationsettingset(*msdyn_salesaccelerationsettingsid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_salesaccelerationsettingset(*msdyn_salesaccelerationsettingsid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_salesaccelerationsettingset<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_salesaccelerationsettingset(*msdyn_salesaccelerationsettingsid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_salesaccelerationsettingset(*msdyn_salesaccelerationsettingsid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_salesaccelerationsettingset(*msdyn_salesaccelerationsettingsid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Sales Acceleration settings (msdyn_salesaccelerationsettings) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Sales Acceleration settings** |
| **DisplayCollectionName** | **Sales Acceleration settings set** |
| **SchemaName** | `msdyn_salesaccelerationsettings` |
| **CollectionSchemaName** | `msdyn_salesaccelerationsettingses` |
| **EntitySetName** | `msdyn_salesaccelerationsettingset`|
| **LogicalName** | `msdyn_salesaccelerationsettings` |
| **LogicalCollectionName** | `msdyn_salesaccelerationsettingses` |
| **PrimaryIdAttribute** | `msdyn_salesaccelerationsettingsid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `OrganizationOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_CalendarType](#BKMK_msdyn_CalendarType)
- [msdyn_DisableWQAutoRefreshOnMarkComplete](#BKMK_msdyn_DisableWQAutoRefreshOnMarkComplete)
- [msdyn_EntityConfiguration](#BKMK_msdyn_EntityConfiguration)
- [msdyn_IsAutoCreatePhoneCallEnabled](#BKMK_msdyn_IsAutoCreatePhoneCallEnabled)
- [msdyn_IsDefaultSetting](#BKMK_msdyn_IsDefaultSetting)
- [msdyn_IsFCCEnabled](#BKMK_msdyn_IsFCCEnabled)
- [msdyn_IsSignalRNotificationEnabled](#BKMK_msdyn_IsSignalRNotificationEnabled)
- [msdyn_iswaittimecomputationenabled](#BKMK_msdyn_iswaittimecomputationenabled)
- [msdyn_IsWorkScheduleEnabled](#BKMK_msdyn_IsWorkScheduleEnabled)
- [msdyn_linkingconfiguration](#BKMK_msdyn_linkingconfiguration)
- [msdyn_LinkSequenceStepToActivity](#BKMK_msdyn_LinkSequenceStepToActivity)
- [msdyn_MigrationStatus](#BKMK_msdyn_MigrationStatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_RecommendationSecurityRoles](#BKMK_msdyn_RecommendationSecurityRoles)
- [msdyn_salesaccelerationsettingsId](#BKMK_msdyn_salesaccelerationsettingsId)
- [msdyn_SecurityRoles](#BKMK_msdyn_SecurityRoles)
- [msdyn_SecurityRolesAssignmentRules](#BKMK_msdyn_SecurityRolesAssignmentRules)
- [msdyn_SecurityRolesNew](#BKMK_msdyn_SecurityRolesNew)
- [msdyn_SequenceConfiguration](#BKMK_msdyn_SequenceConfiguration)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
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

### <a name="BKMK_msdyn_CalendarType"></a> msdyn_CalendarType

|Property|Value|
|---|---|
|Description|**Type of calendar to honour availability**|
|DisplayName|**Calendar type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_calendartype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_calendartype_options`|

#### msdyn_CalendarType Choices/Options

|Value|Label|
|---|---|
|0|**CRM**|
|1|**Outlook**|

### <a name="BKMK_msdyn_DisableWQAutoRefreshOnMarkComplete"></a> msdyn_DisableWQAutoRefreshOnMarkComplete

|Property|Value|
|---|---|
|Description|**Indicates whether when Mark Complete is done on a step/manual activity, is the WQ to be refreshed or not**|
|DisplayName|**Should disable auto WQ refresh on Mark Complete**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_disablewqautorefreshonmarkcomplete`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_salesaccelerationsettings_msdyn_disablewqautorefreshonmarkcomplete`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_EntityConfiguration"></a> msdyn_EntityConfiguration

|Property|Value|
|---|---|
|Description|**Entity configuration for the work queue**|
|DisplayName|**Entity configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entityconfiguration`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_IsAutoCreatePhoneCallEnabled"></a> msdyn_IsAutoCreatePhoneCallEnabled

|Property|Value|
|---|---|
|Description|**Indicates whether automatic creation of phonecall activity record is enabled.**|
|DisplayName|**Is Auto Create PhoneCall Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isautocreatephonecallenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_salesaccelerationsettings_msdyn_isautocreatephonecallenabled`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_IsDefaultSetting"></a> msdyn_IsDefaultSetting

|Property|Value|
|---|---|
|Description|**Indicates whether the settings record is default.**|
|DisplayName|**Is default setting**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdefaultsetting`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_salesaccelerationsettings_msdyn_isdefaultsetting`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_IsFCCEnabled"></a> msdyn_IsFCCEnabled

|Property|Value|
|---|---|
|Description|**Indicates whether FCC enabled.**|
|DisplayName|**Is FCC Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isfccenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_salesaccelerationsettings_msdyn_isfccenabled`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_IsSignalRNotificationEnabled"></a> msdyn_IsSignalRNotificationEnabled

|Property|Value|
|---|---|
|Description|**Indicates whether receiving notifications from signalR is enabled or not.**|
|DisplayName|**Is notification with SignalR enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issignalrnotificationenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_salesaccelerationsettings_msdyn_issignalrnotificationenabled`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_iswaittimecomputationenabled"></a> msdyn_iswaittimecomputationenabled

|Property|Value|
|---|---|
|Description|**Indicates whether wait time computation setting is enabled to honor seller availability based on bussiness days.**|
|DisplayName|**Indicates whether wait time computation setting is enabled to honor seller availability based on bussiness days.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_iswaittimecomputationenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_salesaccelerationsettings_msdyn_iswaittimecomputationenabled`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_IsWorkScheduleEnabled"></a> msdyn_IsWorkScheduleEnabled

|Property|Value|
|---|---|
|Description|**Indicates whether work schedule setting is enabled.**|
|DisplayName|**Indicates whether work schedule setting is enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isworkscheduleenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_salesaccelerationsettings_msdyn_isworkscheduleenabled`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_linkingconfiguration"></a> msdyn_linkingconfiguration

|Property|Value|
|---|---|
|Description|**Admin configuration of linking between sequence step and activities**|
|DisplayName|**Linking configuration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_linkingconfiguration`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_LinkSequenceStepToActivity"></a> msdyn_LinkSequenceStepToActivity

|Property|Value|
|---|---|
|Description|**Indicates whether sequence step should be linked to activity created from it.**|
|DisplayName|**Should link sequence step to activity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_linksequencesteptoactivity`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_salesaccelerationsettings_msdyn_linksequencesteptoactivity`|
|DefaultValue|False|
|True Label||
|False Label||

### <a name="BKMK_msdyn_MigrationStatus"></a> msdyn_MigrationStatus

|Property|Value|
|---|---|
|Description|**Status of Migration**|
|DisplayName|**Migration Staus**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_migrationstatus`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the Sales Acceleration settings instance.**|
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

### <a name="BKMK_msdyn_RecommendationSecurityRoles"></a> msdyn_RecommendationSecurityRoles

|Property|Value|
|---|---|
|Description|**Suggestion Security roles enabled for the settings instance**|
|DisplayName|**Suggestion Security role list**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recommendationsecurityroles`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_salesaccelerationsettingsId"></a> msdyn_salesaccelerationsettingsId

|Property|Value|
|---|---|
|Description|**Unique identifier for Sales Acceleration settings instance**|
|DisplayName|**Sales Acceleration setting ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_salesaccelerationsettingsid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_SecurityRoles"></a> msdyn_SecurityRoles

|Property|Value|
|---|---|
|Description|**Security roles enabled for the settings instance**|
|DisplayName|**Security role list**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_securityroles`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_SecurityRolesAssignmentRules"></a> msdyn_SecurityRolesAssignmentRules

|Property|Value|
|---|---|
|Description|**Security roles list for assignment rules**|
|DisplayName|**Security role list for assignment rules**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_securityrolesassignmentrules`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_SecurityRolesNew"></a> msdyn_SecurityRolesNew

|Property|Value|
|---|---|
|Description|**Security roles (new) enabled for the settings instance**|
|DisplayName|**Security role list (new)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_securityrolesnew`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000000|

### <a name="BKMK_msdyn_SequenceConfiguration"></a> msdyn_SequenceConfiguration

|Property|Value|
|---|---|
|Description|**Sequence configurations**|
|DisplayName|**Sequence configurations**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sequenceconfiguration`|
|RequiredLevel|None|
|Type|String|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

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

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Sales Acceleration settings**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesaccelerationsettings_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Open**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Closed**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Sales Acceleration settings**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_salesaccelerationsettings_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Saved**<br />State:0<br />TransitionData: None|
|2|Label: **Published**<br />State:1<br />TransitionData: None|
|3|Label: **Assignment Rules Published**<br />State:1<br />TransitionData: None|

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
- [OrganizationId](#BKMK_OrganizationId)
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

### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|---|---|
|Description|**Unique identifier for the organization**|
|DisplayName|**Organization Id**|
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

- [lk_msdyn_salesaccelerationsettings_createdby](#BKMK_lk_msdyn_salesaccelerationsettings_createdby)
- [lk_msdyn_salesaccelerationsettings_createdonbehalfby](#BKMK_lk_msdyn_salesaccelerationsettings_createdonbehalfby)
- [lk_msdyn_salesaccelerationsettings_modifiedby](#BKMK_lk_msdyn_salesaccelerationsettings_modifiedby)
- [lk_msdyn_salesaccelerationsettings_modifiedonbehalfby](#BKMK_lk_msdyn_salesaccelerationsettings_modifiedonbehalfby)
- [organization_msdyn_salesaccelerationsettings](#BKMK_organization_msdyn_salesaccelerationsettings)

### <a name="BKMK_lk_msdyn_salesaccelerationsettings_createdby"></a> lk_msdyn_salesaccelerationsettings_createdby

One-To-Many Relationship: [systemuser lk_msdyn_salesaccelerationsettings_createdby](systemuser.md#BKMK_lk_msdyn_salesaccelerationsettings_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesaccelerationsettings_createdonbehalfby"></a> lk_msdyn_salesaccelerationsettings_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesaccelerationsettings_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_salesaccelerationsettings_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesaccelerationsettings_modifiedby"></a> lk_msdyn_salesaccelerationsettings_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_salesaccelerationsettings_modifiedby](systemuser.md#BKMK_lk_msdyn_salesaccelerationsettings_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_salesaccelerationsettings_modifiedonbehalfby"></a> lk_msdyn_salesaccelerationsettings_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_salesaccelerationsettings_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_salesaccelerationsettings_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_organization_msdyn_salesaccelerationsettings"></a> organization_msdyn_salesaccelerationsettings

One-To-Many Relationship: [organization organization_msdyn_salesaccelerationsettings](organization.md#BKMK_organization_msdyn_salesaccelerationsettings)

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

- [msdyn_salesaccelerationsettings_AsyncOperations](#BKMK_msdyn_salesaccelerationsettings_AsyncOperations)
- [msdyn_salesaccelerationsettings_BulkDeleteFailures](#BKMK_msdyn_salesaccelerationsettings_BulkDeleteFailures)
- [msdyn_salesaccelerationsettings_DuplicateBaseRecord](#BKMK_msdyn_salesaccelerationsettings_DuplicateBaseRecord)
- [msdyn_salesaccelerationsettings_DuplicateMatchingRecord](#BKMK_msdyn_salesaccelerationsettings_DuplicateMatchingRecord)
- [msdyn_salesaccelerationsettings_MailboxTrackingFolders](#BKMK_msdyn_salesaccelerationsettings_MailboxTrackingFolders)
- [msdyn_salesaccelerationsettings_PrincipalObjectAttributeAccesses](#BKMK_msdyn_salesaccelerationsettings_PrincipalObjectAttributeAccesses)
- [msdyn_salesaccelerationsettings_ProcessSession](#BKMK_msdyn_salesaccelerationsettings_ProcessSession)
- [msdyn_salesaccelerationsettings_SyncErrors](#BKMK_msdyn_salesaccelerationsettings_SyncErrors)

### <a name="BKMK_msdyn_salesaccelerationsettings_AsyncOperations"></a> msdyn_salesaccelerationsettings_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_salesaccelerationsettings_AsyncOperations](asyncoperation.md#BKMK_msdyn_salesaccelerationsettings_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesaccelerationsettings_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesaccelerationsettings_BulkDeleteFailures"></a> msdyn_salesaccelerationsettings_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_salesaccelerationsettings_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_salesaccelerationsettings_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesaccelerationsettings_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesaccelerationsettings_DuplicateBaseRecord"></a> msdyn_salesaccelerationsettings_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_salesaccelerationsettings_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_salesaccelerationsettings_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesaccelerationsettings_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesaccelerationsettings_DuplicateMatchingRecord"></a> msdyn_salesaccelerationsettings_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_salesaccelerationsettings_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_salesaccelerationsettings_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesaccelerationsettings_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesaccelerationsettings_MailboxTrackingFolders"></a> msdyn_salesaccelerationsettings_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_salesaccelerationsettings_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_salesaccelerationsettings_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesaccelerationsettings_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesaccelerationsettings_PrincipalObjectAttributeAccesses"></a> msdyn_salesaccelerationsettings_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_salesaccelerationsettings_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_salesaccelerationsettings_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesaccelerationsettings_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesaccelerationsettings_ProcessSession"></a> msdyn_salesaccelerationsettings_ProcessSession

Many-To-One Relationship: [processsession msdyn_salesaccelerationsettings_ProcessSession](processsession.md#BKMK_msdyn_salesaccelerationsettings_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesaccelerationsettings_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_salesaccelerationsettings_SyncErrors"></a> msdyn_salesaccelerationsettings_SyncErrors

Many-To-One Relationship: [syncerror msdyn_salesaccelerationsettings_SyncErrors](syncerror.md#BKMK_msdyn_salesaccelerationsettings_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_salesaccelerationsettings_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

