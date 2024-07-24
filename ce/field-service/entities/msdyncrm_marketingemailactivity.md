---
title: "Marketing Email Activity (msdyncrm_marketingemailactivity) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Marketing Email Activity (msdyncrm_marketingemailactivity) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Marketing Email Activity (msdyncrm_marketingemailactivity) table/entity reference



## Messages

The following table lists the messages for the Marketing Email Activity (msdyncrm_marketingemailactivity) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyncrm_marketingemailactivities(*msdyncrm_marketingemailactivityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyncrm_marketingemailactivities<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyncrm_marketingemailactivities(*msdyncrm_marketingemailactivityid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyncrm_marketingemailactivities(*msdyncrm_marketingemailactivityid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyncrm_marketingemailactivities<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyncrm_marketingemailactivities(*msdyncrm_marketingemailactivityid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyncrm_marketingemailactivities(*msdyncrm_marketingemailactivityid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyncrm_marketingemailactivities(*msdyncrm_marketingemailactivityid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Marketing Email Activity (msdyncrm_marketingemailactivity) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Marketing Email Activity (msdyncrm_marketingemailactivity) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Marketing Email Activity** |
| **DisplayCollectionName** | **Marketing Email Activity** |
| **SchemaName** | `msdyncrm_marketingemailactivity` |
| **CollectionSchemaName** | `msdyncrm_marketingemailactivities` |
| **EntitySetName** | `msdyncrm_marketingemailactivities`|
| **LogicalName** | `msdyncrm_marketingemailactivity` |
| **LogicalCollectionName** | `msdyncrm_marketingemailactivities` |
| **PrimaryIdAttribute** | `msdyncrm_marketingemailactivityid` |
| **PrimaryNameAttribute** |`msdyncrm_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyncrm_abtestdistributionversiona](#BKMK_msdyncrm_abtestdistributionversiona)
- [msdyncrm_abtestdistributionversionb](#BKMK_msdyncrm_abtestdistributionversionb)
- [msdyncrm_abtestdurationunit](#BKMK_msdyncrm_abtestdurationunit)
- [msdyncrm_abtestdurationvalue](#BKMK_msdyncrm_abtestdurationvalue)
- [msdyncrm_abtestid](#BKMK_msdyncrm_abtestid)
- [msdyncrm_abtestinconclusiveresult](#BKMK_msdyncrm_abtestinconclusiveresult)
- [msdyncrm_abtestingenabled](#BKMK_msdyncrm_abtestingenabled)
- [msdyncrm_abtestwinningmetric](#BKMK_msdyncrm_abtestwinningmetric)
- [msdyncrm_automateschedule](#BKMK_msdyncrm_automateschedule)
- [msdyncrm_dependencies](#BKMK_msdyncrm_dependencies)
- [msdyncrm_description](#BKMK_msdyncrm_description)
- [msdyncrm_emailid](#BKMK_msdyncrm_emailid)
- [msdyncrm_expiration](#BKMK_msdyncrm_expiration)
- [msdyncrm_expirationdate](#BKMK_msdyncrm_expirationdate)
- [msdyncrm_insightsdata](#BKMK_msdyncrm_insightsdata)
- [msdyncrm_marketingemailactivityId](#BKMK_msdyncrm_marketingemailactivityId)
- [msdyncrm_name](#BKMK_msdyncrm_name)
- [msdyncrm_permitteddays](#BKMK_msdyncrm_permitteddays)
- [msdyncrm_permittedtimeend](#BKMK_msdyncrm_permittedtimeend)
- [msdyncrm_permittedtimestart](#BKMK_msdyncrm_permittedtimestart)
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

### <a name="BKMK_msdyncrm_abtestdistributionversiona"></a> msdyncrm_abtestdistributionversiona

|Property|Value|
|---|---|
|Description||
|DisplayName|**A/B test distribution - version A**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_abtestdistributionversiona`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|1|

### <a name="BKMK_msdyncrm_abtestdistributionversionb"></a> msdyncrm_abtestdistributionversionb

|Property|Value|
|---|---|
|Description||
|DisplayName|**A/B test distribution - version B**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_abtestdistributionversionb`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_msdyncrm_abtestdurationunit"></a> msdyncrm_abtestdurationunit

|Property|Value|
|---|---|
|Description||
|DisplayName|**A/B test duration unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_abtestdurationunit`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyncrm_test_msdyncrm_abtestdurationunit`|

#### msdyncrm_abtestdurationunit Choices/Options

|Value|Label|
|---|---|
|192350000|**Hours**|
|192350001|**Days**|
|192350002|**Weeks**|

### <a name="BKMK_msdyncrm_abtestdurationvalue"></a> msdyncrm_abtestdurationvalue

|Property|Value|
|---|---|
|Description||
|DisplayName|**A/B test duration value**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_abtestdurationvalue`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_msdyncrm_abtestid"></a> msdyncrm_abtestid

|Property|Value|
|---|---|
|Description||
|DisplayName|**A/B test ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_abtestid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyncrm_marketingemailtest|

### <a name="BKMK_msdyncrm_abtestinconclusiveresult"></a> msdyncrm_abtestinconclusiveresult

|Property|Value|
|---|---|
|Description||
|DisplayName|**A/B test inconclusive result**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_abtestinconclusiveresult`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyncrm_test_msdyncrm_abtestinconclusiveresult`|

#### msdyncrm_abtestinconclusiveresult Choices/Options

|Value|Label|
|---|---|
|192350000|**Version A**|
|192350001|**Version B**|
|192350002|**Version A and Version B (50/50)**|

### <a name="BKMK_msdyncrm_abtestingenabled"></a> msdyncrm_abtestingenabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**A/B testing enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_abtestingenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingemailactivity_msdyncrm_abtestingenabled`|
|DefaultValue|False|
|True Label|A/B testing enabled|
|False Label|A/B testing disabled|

### <a name="BKMK_msdyncrm_abtestwinningmetric"></a> msdyncrm_abtestwinningmetric

|Property|Value|
|---|---|
|Description||
|DisplayName|**A/B test winning metric**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_abtestwinningmetric`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350001|
|GlobalChoiceName|`msdyncrm_test_msdyncrm_abtestwinningmetric`|

#### msdyncrm_abtestwinningmetric Choices/Options

|Value|Label|
|---|---|
|192350000|**Open rate**|
|192350001|**Click-through rate**|

### <a name="BKMK_msdyncrm_automateschedule"></a> msdyncrm_automateschedule

|Property|Value|
|---|---|
|Description||
|DisplayName|**Automate schedule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_automateschedule`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingemailactivity_msdyncrm_automateschedule`|
|DefaultValue|False|
|True Label|Automated scheduling enabled|
|False Label|Automated scheduling disabled|

### <a name="BKMK_msdyncrm_dependencies"></a> msdyncrm_dependencies

|Property|Value|
|---|---|
|Description|**Dependencies**|
|DisplayName|**Dependencies**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_dependencies`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyncrm_description"></a> msdyncrm_description

|Property|Value|
|---|---|
|Description||
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

### <a name="BKMK_msdyncrm_emailid"></a> msdyncrm_emailid

|Property|Value|
|---|---|
|Description|**ID of the Marketing Email**|
|DisplayName|**Marketing Email ID**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_emailid`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyncrm_marketingemail|

### <a name="BKMK_msdyncrm_expiration"></a> msdyncrm_expiration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Automate schedule**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_expiration`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyncrm_marketingemailactivity_msdyncrm_expiration`|
|DefaultValue|False|
|True Label|Email expiration enabled|
|False Label|Email expiration disabled|

### <a name="BKMK_msdyncrm_expirationdate"></a> msdyncrm_expirationdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Expiration date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_expirationdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_insightsdata"></a> msdyncrm_insightsdata

|Property|Value|
|---|---|
|Description||
|DisplayName|**Insights data**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_insightsdata`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyncrm_marketingemailactivityId"></a> msdyncrm_marketingemailactivityId

|Property|Value|
|---|---|
|Description|**ID of the Marketing Email Activity**|
|DisplayName|**Marketing Email Activity ID**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyncrm_marketingemailactivityid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyncrm_name"></a> msdyncrm_name

|Property|Value|
|---|---|
|Description|**The name of the email activity.**|
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

### <a name="BKMK_msdyncrm_permitteddays"></a> msdyncrm_permitteddays

|Property|Value|
|---|---|
|Description||
|DisplayName|**Permitted Days**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_permitteddays`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_days`|

#### msdyncrm_permitteddays Choices/Options

|Value|Label|
|---|---|
|192350000|**Monday**|
|192350001|**Tuesday**|
|192350002|**Wednesday**|
|192350003|**Thursday**|
|192350004|**Friday**|
|192350005|**Saturday**|
|192350006|**Sunday**|

### <a name="BKMK_msdyncrm_permittedtimeend"></a> msdyncrm_permittedtimeend

|Property|Value|
|---|---|
|Description||
|DisplayName|**Permitted hours: end**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_permittedtimeend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyncrm_permittedtimestart"></a> msdyncrm_permittedtimestart

|Property|Value|
|---|---|
|Description||
|DisplayName|**Permitted hours: start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyncrm_permittedtimestart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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
|Description|**Status**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingemailactivity_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status**|
|DisplayName|**Status reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyncrm_marketingemailactivity_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Active**<br />State:0<br />TransitionData: None|

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
|Description|**Unique ID of the user who created the record**|
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
|Description|**Unique ID of the delegate user who created the record**|
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
|Description|**Unique ID of the user who modified the record**|
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
|Description|**Unique ID of the delegate user who modified the record**|
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
|Description|**Unique ID of the business unit that owns the record**|
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
|Description|**Unique ID of the team that owns the record**|
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
|Description|**Unique ID of the team that owns the record**|
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

- [business_unit_msdyncrm_marketingemailactivity](#BKMK_business_unit_msdyncrm_marketingemailactivity)
- [lk_msdyncrm_marketingemailactivity_createdby](#BKMK_lk_msdyncrm_marketingemailactivity_createdby)
- [lk_msdyncrm_marketingemailactivity_createdonbehalfby](#BKMK_lk_msdyncrm_marketingemailactivity_createdonbehalfby)
- [lk_msdyncrm_marketingemailactivity_modifiedby](#BKMK_lk_msdyncrm_marketingemailactivity_modifiedby)
- [lk_msdyncrm_marketingemailactivity_modifiedonbehalfby](#BKMK_lk_msdyncrm_marketingemailactivity_modifiedonbehalfby)
- [msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid](#BKMK_msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid)
- [msdyncrm_msdyncrm_marketingemailtest_msdyncrm_marketingemailactivity_abtestid](#BKMK_msdyncrm_msdyncrm_marketingemailtest_msdyncrm_marketingemailactivity_abtestid)
- [owner_msdyncrm_marketingemailactivity](#BKMK_owner_msdyncrm_marketingemailactivity)
- [team_msdyncrm_marketingemailactivity](#BKMK_team_msdyncrm_marketingemailactivity)
- [user_msdyncrm_marketingemailactivity](#BKMK_user_msdyncrm_marketingemailactivity)

### <a name="BKMK_business_unit_msdyncrm_marketingemailactivity"></a> business_unit_msdyncrm_marketingemailactivity

One-To-Many Relationship: [businessunit business_unit_msdyncrm_marketingemailactivity](businessunit.md#BKMK_business_unit_msdyncrm_marketingemailactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailactivity_createdby"></a> lk_msdyncrm_marketingemailactivity_createdby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailactivity_createdby](systemuser.md#BKMK_lk_msdyncrm_marketingemailactivity_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailactivity_createdonbehalfby"></a> lk_msdyncrm_marketingemailactivity_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailactivity_createdonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingemailactivity_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailactivity_modifiedby"></a> lk_msdyncrm_marketingemailactivity_modifiedby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailactivity_modifiedby](systemuser.md#BKMK_lk_msdyncrm_marketingemailactivity_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyncrm_marketingemailactivity_modifiedonbehalfby"></a> lk_msdyncrm_marketingemailactivity_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyncrm_marketingemailactivity_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyncrm_marketingemailactivity_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid"></a> msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid

One-To-Many Relationship: [msdyncrm_marketingemail msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid](msdyncrm_marketingemail.md#BKMK_msdyncrm_msdyncrm_emailactivity_msdyncrm_marketingemail_msdyncrm_emailid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemail`|
|ReferencedAttribute|`msdyncrm_marketingemailid`|
|ReferencingAttribute|`msdyncrm_emailid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_emailid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyncrm_msdyncrm_marketingemailtest_msdyncrm_marketingemailactivity_abtestid"></a> msdyncrm_msdyncrm_marketingemailtest_msdyncrm_marketingemailactivity_abtestid

One-To-Many Relationship: [msdyncrm_marketingemailtest msdyncrm_msdyncrm_marketingemailtest_msdyncrm_marketingemailactivity_abtestid](msdyncrm_marketingemailtest.md#BKMK_msdyncrm_msdyncrm_marketingemailtest_msdyncrm_marketingemailactivity_abtestid)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyncrm_marketingemailtest`|
|ReferencedAttribute|`msdyncrm_marketingemailtestid`|
|ReferencingAttribute|`msdyncrm_abtestid`|
|ReferencingEntityNavigationPropertyName|`msdyncrm_abtestid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyncrm_marketingemailactivity"></a> owner_msdyncrm_marketingemailactivity

One-To-Many Relationship: [owner owner_msdyncrm_marketingemailactivity](owner.md#BKMK_owner_msdyncrm_marketingemailactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyncrm_marketingemailactivity"></a> team_msdyncrm_marketingemailactivity

One-To-Many Relationship: [team team_msdyncrm_marketingemailactivity](team.md#BKMK_team_msdyncrm_marketingemailactivity)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyncrm_marketingemailactivity"></a> user_msdyncrm_marketingemailactivity

One-To-Many Relationship: [systemuser user_msdyncrm_marketingemailactivity](systemuser.md#BKMK_user_msdyncrm_marketingemailactivity)

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

- [msdyncrm_marketingemailactivity_AsyncOperations](#BKMK_msdyncrm_marketingemailactivity_AsyncOperations)
- [msdyncrm_marketingemailactivity_BulkDeleteFailures](#BKMK_msdyncrm_marketingemailactivity_BulkDeleteFailures)
- [msdyncrm_marketingemailactivity_MailboxTrackingFolders](#BKMK_msdyncrm_marketingemailactivity_MailboxTrackingFolders)
- [msdyncrm_marketingemailactivity_PrincipalObjectAttributeAccesses](#BKMK_msdyncrm_marketingemailactivity_PrincipalObjectAttributeAccesses)
- [msdyncrm_marketingemailactivity_ProcessSession](#BKMK_msdyncrm_marketingemailactivity_ProcessSession)
- [msdyncrm_marketingemailactivity_SyncErrors](#BKMK_msdyncrm_marketingemailactivity_SyncErrors)

### <a name="BKMK_msdyncrm_marketingemailactivity_AsyncOperations"></a> msdyncrm_marketingemailactivity_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyncrm_marketingemailactivity_AsyncOperations](asyncoperation.md#BKMK_msdyncrm_marketingemailactivity_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailactivity_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailactivity_BulkDeleteFailures"></a> msdyncrm_marketingemailactivity_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyncrm_marketingemailactivity_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyncrm_marketingemailactivity_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailactivity_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailactivity_MailboxTrackingFolders"></a> msdyncrm_marketingemailactivity_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyncrm_marketingemailactivity_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyncrm_marketingemailactivity_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailactivity_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailactivity_PrincipalObjectAttributeAccesses"></a> msdyncrm_marketingemailactivity_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyncrm_marketingemailactivity_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyncrm_marketingemailactivity_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailactivity_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailactivity_ProcessSession"></a> msdyncrm_marketingemailactivity_ProcessSession

Many-To-One Relationship: [processsession msdyncrm_marketingemailactivity_ProcessSession](processsession.md#BKMK_msdyncrm_marketingemailactivity_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailactivity_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyncrm_marketingemailactivity_SyncErrors"></a> msdyncrm_marketingemailactivity_SyncErrors

Many-To-One Relationship: [syncerror msdyncrm_marketingemailactivity_SyncErrors](syncerror.md#BKMK_msdyncrm_marketingemailactivity_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyncrm_marketingemailactivity_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

