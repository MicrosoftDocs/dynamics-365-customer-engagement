---
title: "Task activity marketing template (msdyncrm_taskactivitymarketingtemplate) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Task activity marketing template (msdyncrm_taskactivitymarketingtemplate) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Task activity marketing template (msdyncrm_taskactivitymarketingtemplate) table/entity reference



## Messages

The following table lists the messages for the Task activity marketing template (msdyncrm_taskactivitymarketingtemplate) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_taskactivitymarketingtemplates(*msdyncrm_taskactivitymarketingtemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_taskactivitymarketingtemplates<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_taskactivitymarketingtemplates(*msdyncrm_taskactivitymarketingtemplateid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_taskactivitymarketingtemplates(*msdyncrm_taskactivitymarketingtemplateid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_taskactivitymarketingtemplates<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_taskactivitymarketingtemplates(*msdyncrm_taskactivitymarketingtemplateid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_taskactivitymarketingtemplates(*msdyncrm_taskactivitymarketingtemplateid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_taskactivitymarketingtemplates(*msdyncrm_taskactivitymarketingtemplateid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Task activity marketing template (msdyncrm_taskactivitymarketingtemplate) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Task activity marketing template (msdyncrm_taskactivitymarketingtemplate) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Task activity marketing template** |
| **DisplayCollectionName** | **Task activity marketing templates** |
| **SchemaName** | `msdyncrm_taskactivitymarketingtemplate` |
| **CollectionSchemaName** | `msdyncrm_taskactivitymarketingtemplates` |
| **EntitySetName** | `msdyncrm_taskactivitymarketingtemplates`|
| **LogicalName** | `msdyncrm_taskactivitymarketingtemplate` |
| **LogicalCollectionName** | `msdyncrm_taskactivitymarketingtemplates` |
| **PrimaryIdAttribute** | `msdyncrm_taskactivitymarketingtemplateid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_description](#BKMK_msdyncrm_description)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_prioritycode](#BKMK_msdyncrm_prioritycode)
- [msdyncrm_scheduleddurationminutes](#BKMK_msdyncrm_scheduleddurationminutes)
- [msdyncrm_scheduletype](#BKMK_msdyncrm_scheduletype)
- [msdyncrm_startdate](#BKMK_msdyncrm_startdate)
- [msdyncrm_startdelay](#BKMK_msdyncrm_startdelay)
- [msdyncrm_starttimehour](#BKMK_msdyncrm_starttimehour)
- [msdyncrm_starttimeminute](#BKMK_msdyncrm_starttimeminute)
- [msdyncrm_subject](#BKMK_msdyncrm_subject)
- [msdyncrm_taskactivitymarketingtemplateId](#BKMK_msdyncrm_taskactivitymarketingtemplateId)
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
|Description|**Sequence number of the import that created this record**|
|DisplayName|**Import sequence number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_description"></a> msdyncrm_description

|Property|Value|
|---|---|
|Description|**Enter additional information to describe the task**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyncrm_prioritycode"></a> msdyncrm_prioritycode

|Property|Value|
|---|---|
|Description|**Select the priority so that preferred customers or critical issues are handled quickly**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_prioritycode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyncrm_taskactivitymarketingtemplate_msdyncrm_prioritycode`|

#### msdyncrm_prioritycode Choices/Options

|Value|Label|
|---|---|
|0|**Low**|
|1|**Normal**|
|2|**High**|

### <a name="BKMK_msdyncrm_scheduleddurationminutes"></a> msdyncrm_scheduleddurationminutes

|Property|Value|
|---|---|
|Description|**Shows the expected duration of the task, in minutes.**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_scheduleddurationminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyncrm_scheduletype"></a> msdyncrm_scheduletype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Schedule type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_scheduletype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyncrm_scheduletype`|

#### msdyncrm_scheduletype Choices/Options

|Value|Label|
|---|---|
|0|**Fixed date**|
|1|**Delay (in days)**|

### <a name="BKMK_msdyncrm_startdate"></a> msdyncrm_startdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Start date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_startdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|DateOnly|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_startdelay"></a> msdyncrm_startdelay

|Property|Value|
|---|---|
|Description||
|DisplayName|**Start delay**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_startdelay`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyncrm_starttimehour"></a> msdyncrm_starttimehour

|Property|Value|
|---|---|
|Description||
|DisplayName|**Start-time hour**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_starttimehour`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_starttimehour`|

#### msdyncrm_starttimehour Choices/Options

|Value|Label|
|---|---|
|0|**00**|
|1|**01**|
|2|**02**|
|3|**03**|
|4|**04**|
|5|**05**|
|6|**06**|
|7|**07**|
|8|**08**|
|9|**09**|
|10|**10**|
|11|**11**|
|12|**12**|
|13|**13**|
|14|**14**|
|15|**15**|
|16|**16**|
|17|**17**|
|18|**18**|
|19|**19**|
|20|**20**|
|21|**21**|
|22|**22**|
|23|**23**|

### <a name="BKMK_msdyncrm_starttimeminute"></a> msdyncrm_starttimeminute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Start-time minute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_starttimeminute`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyncrm_starttimeminute`|

#### msdyncrm_starttimeminute Choices/Options

|Value|Label|
|---|---|
|0|**00**|
|15|**15**|
|30|**30**|
|45|**45**|

### <a name="BKMK_msdyncrm_subject"></a> msdyncrm_subject

|Property|Value|
|---|---|
|Description|**Enter a short description about the objective or primary topic of the task**|
|DisplayName|**Subject**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_subject`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplateId"></a> msdyncrm_taskactivitymarketingtemplateId

|Property|Value|
|---|---|
|Description|**Unique ID for entity instances**|
|DisplayName|**Task activity marketing template**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_taskactivitymarketingtemplateid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Date and time that the record was migrated**|
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
|Description|**Owner ID**|
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
|Description|**Status of the task activity marketing template**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_taskactivitymarketingtemplate_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the task activity marketing template**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_taskactivitymarketingtemplate_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|
|2|Label: **Inactive**<br />State:1<br />TransitionData: None|

### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|---|---|
|Description|**For internal use only**|
|DisplayName|**Time-zone rule version number**|
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
|Description|**Time-zone code that was in use when the record was created**|
|DisplayName|**UTC conversion time-zone code**|
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
|Description|**Indicates the person who created this.**|
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
|Description|**Date and time when the record was created**|
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
|Description|**Indicates the person who created this for another person.**|
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
|Description|**Indicates the person who modified this.**|
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
|Description|**Date and time when the record was modified**|
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
|Description|**Indicates the person who modified this for another person.**|
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
|Description|**Indicates the business unit that owns this.**|
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
|Description|**Indicates the team that owns this.**|
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
|Description|**Indicates the person who owns this.**|
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

- [business_unit_msdyncrm_taskactivitymarketingtemplate](#BKMK_business_unit_msdyncrm_taskactivitymarketingtemplate)
- [lk_msdyncrm_taskactivitymarketingtemplate_createdby](#BKMK_lk_msdyncrm_taskactivitymarketingtemplate_createdby)
- [lk_msdyncrm_taskactivitymarketingtemplate_createdonbehalfby](#BKMK_lk_msdyncrm_taskactivitymarketingtemplate_createdonbehalfby)
- [lk_msdyncrm_taskactivitymarketingtemplate_modifiedby](#BKMK_lk_msdyncrm_taskactivitymarketingtemplate_modifiedby)
- [lk_msdyncrm_taskactivitymarketingtemplate_modifiedonbehalfby](#BKMK_lk_msdyncrm_taskactivitymarketingtemplate_modifiedonbehalfby)
- [owner_msdyncrm_taskactivitymarketingtemplate](#BKMK_owner_msdyncrm_taskactivitymarketingtemplate)
- [team_msdyncrm_taskactivitymarketingtemplate](#BKMK_team_msdyncrm_taskactivitymarketingtemplate)
- [user_msdyncrm_taskactivitymarketingtemplate](#BKMK_user_msdyncrm_taskactivitymarketingtemplate)

### <a name="BKMK_business_unit_msdyncrm_taskactivitymarketingtemplate"></a> business_unit_msdyncrm_taskactivitymarketingtemplate

One-To-Many Relationship: [businessunit business_unit_msdyncrm_taskactivitymarketingtemplate](businessunit.md#BKMK_business_unit_msdyncrm_taskactivitymarketingtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_taskactivitymarketingtemplate_createdby"></a> lk_msdyncrm_taskactivitymarketingtemplate_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_taskactivitymarketingtemplate_createdby](systemuser.md#BKMK_lk_msdyncrm_taskactivitymarketingtemplate_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_taskactivitymarketingtemplate_createdonbehalfby"></a> lk_msdyncrm_taskactivitymarketingtemplate_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_taskactivitymarketingtemplate_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_taskactivitymarketingtemplate_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_taskactivitymarketingtemplate_modifiedby"></a> lk_msdyncrm_taskactivitymarketingtemplate_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_taskactivitymarketingtemplate_modifiedby](systemuser.md#BKMK_lk_msdyncrm_taskactivitymarketingtemplate_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_taskactivitymarketingtemplate_modifiedonbehalfby"></a> lk_msdyncrm_taskactivitymarketingtemplate_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_taskactivitymarketingtemplate_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_taskactivitymarketingtemplate_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_taskactivitymarketingtemplate"></a> owner_msdyncrm_taskactivitymarketingtemplate

One-To-Many Relationship: [owner owner_msdyncrm_taskactivitymarketingtemplate](owner.md#BKMK_owner_msdyncrm_taskactivitymarketingtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_taskactivitymarketingtemplate"></a> team_msdyncrm_taskactivitymarketingtemplate

One-To-Many Relationship: [team team_msdyncrm_taskactivitymarketingtemplate](team.md#BKMK_team_msdyncrm_taskactivitymarketingtemplate)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_taskactivitymarketingtemplate"></a> user_msdyncrm_taskactivitymarketingtemplate

One-To-Many Relationship: [systemuser user_msdyncrm_taskactivitymarketingtemplate](systemuser.md#BKMK_user_msdyncrm_taskactivitymarketingtemplate)

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

- [msdyncrm_msdyncrm_taskactivitymarketingtemplate_msdyncrm_taskactivity_tasktemplate](#BKMK_msdyncrm_msdyncrm_taskactivitymarketingtemplate_msdyncrm_taskactivity_tasktemplate)
- [msdyncrm_taskactivitymarketingtemplate_Annotations](#BKMK_msdyncrm_taskactivitymarketingtemplate_Annotations)
- [msdyncrm_taskactivitymarketingtemplate_AsyncOperations](#BKMK_msdyncrm_taskactivitymarketingtemplate_AsyncOperations)
- [msdyncrm_taskactivitymarketingtemplate_BulkDeleteFailures](#BKMK_msdyncrm_taskactivitymarketingtemplate_BulkDeleteFailures)
- [msdyncrm_taskactivitymarketingtemplate_connections1](#BKMK_msdyncrm_taskactivitymarketingtemplate_connections1)
- [msdyncrm_taskactivitymarketingtemplate_connections2](#BKMK_msdyncrm_taskactivitymarketingtemplate_connections2)
- [msdyncrm_taskactivitymarketingtemplate_DuplicateBaseRecord](#BKMK_msdyncrm_taskactivitymarketingtemplate_DuplicateBaseRecord)
- [msdyncrm_taskactivitymarketingtemplate_DuplicateMatchingRecord](#BKMK_msdyncrm_taskactivitymarketingtemplate_DuplicateMatchingRecord)
- [msdyncrm_taskactivitymarketingtemplate_Feedback](#BKMK_msdyncrm_taskactivitymarketingtemplate_Feedback)
- [msdyncrm_taskactivitymarketingtemplate_MailboxTrackingFolders](#BKMK_msdyncrm_taskactivitymarketingtemplate_MailboxTrackingFolders)
- [msdyncrm_taskactivitymarketingtemplate_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_taskactivitymarketingtemplate_PrincipalObjectAttributeAccesses)
- [msdyncrm_taskactivitymarketingtemplate_ProcessSession](#BKMK_msdyncrm_taskactivitymarketingtemplate_ProcessSession)
- [msdyncrm_taskactivitymarketingtemplate_QueueItems](#BKMK_msdyncrm_taskactivitymarketingtemplate_QueueItems)
- [msdyncrm_taskactivitymarketingtemplate_SyncErrors](#BKMK_msdyncrm_taskactivitymarketingtemplate_SyncErrors)

### <a name="BKMK_msdyncrm_msdyncrm_taskactivitymarketingtemplate_msdyncrm_taskactivity_tasktemplate"></a> msdyncrm_msdyncrm_taskactivitymarketingtemplate_msdyncrm_taskactivity_tasktemplate

Many-To-One Relationship: [msdyncrm_taskactivity msdyncrm_msdyncrm_taskactivitymarketingtemplate_msdyncrm_taskactivity_tasktemplate](msdyncrm_taskactivity.md#BKMK_msdyncrm_msdyncrm_taskactivitymarketingtemplate_msdyncrm_taskactivity_tasktemplate)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyncrm_taskactivity`|
|ReferencingAttribute|`msdyncrm_tasktemplate`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_msdyncrm_taskactivitymarketingtemplate_msdyncrm_taskactivity_tasktemplate`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_Annotations"></a> msdyncrm_taskactivitymarketingtemplate_Annotations

Many-To-One Relationship: [annotation msdyncrm_taskactivitymarketingtemplate_Annotations](annotation.md#BKMK_msdyncrm_taskactivitymarketingtemplate_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_AsyncOperations"></a> msdyncrm_taskactivitymarketingtemplate_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_taskactivitymarketingtemplate_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_taskactivitymarketingtemplate_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_BulkDeleteFailures"></a> msdyncrm_taskactivitymarketingtemplate_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_taskactivitymarketingtemplate_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_taskactivitymarketingtemplate_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_connections1"></a> msdyncrm_taskactivitymarketingtemplate_connections1

Many-To-One Relationship: [connection msdyncrm_taskactivitymarketingtemplate_connections1](connection.md#BKMK_msdyncrm_taskactivitymarketingtemplate_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_connections2"></a> msdyncrm_taskactivitymarketingtemplate_connections2

Many-To-One Relationship: [connection msdyncrm_taskactivitymarketingtemplate_connections2](connection.md#BKMK_msdyncrm_taskactivitymarketingtemplate_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_DuplicateBaseRecord"></a> msdyncrm_taskactivitymarketingtemplate_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_taskactivitymarketingtemplate_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyncrm_taskactivitymarketingtemplate_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_DuplicateMatchingRecord"></a> msdyncrm_taskactivitymarketingtemplate_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyncrm_taskactivitymarketingtemplate_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyncrm_taskactivitymarketingtemplate_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_Feedback"></a> msdyncrm_taskactivitymarketingtemplate_Feedback

Many-To-One Relationship: [feedback msdyncrm_taskactivitymarketingtemplate_Feedback](feedback.md#BKMK_msdyncrm_taskactivitymarketingtemplate_Feedback)

|Property|Value|
|---|---|
|ReferencingEntity|`feedback`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_Feedback`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 150<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_MailboxTrackingFolders"></a> msdyncrm_taskactivitymarketingtemplate_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_taskactivitymarketingtemplate_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_taskactivitymarketingtemplate_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_PrincipalObjectAttributeAccesses"></a> msdyncrm_taskactivitymarketingtemplate_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_taskactivitymarketingtemplate_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_taskactivitymarketingtemplate_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_ProcessSession"></a> msdyncrm_taskactivitymarketingtemplate_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_taskactivitymarketingtemplate_ProcessSession](processsession.md#BKMK_msdyncrm_taskactivitymarketingtemplate_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_QueueItems"></a> msdyncrm_taskactivitymarketingtemplate_QueueItems

Many-To-One Relationship: [queueitem msdyncrm_taskactivitymarketingtemplate_QueueItems](queueitem.md#BKMK_msdyncrm_taskactivitymarketingtemplate_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_taskactivitymarketingtemplate_SyncErrors"></a> msdyncrm_taskactivitymarketingtemplate_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_taskactivitymarketingtemplate_SyncErrors](syncerror.md#BKMK_msdyncrm_taskactivitymarketingtemplate_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_taskactivitymarketingtemplate_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

