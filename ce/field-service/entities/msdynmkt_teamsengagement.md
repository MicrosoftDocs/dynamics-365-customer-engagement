---
title: "Teams Engagement (msdynmkt_teamsengagement) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Teams Engagement (msdynmkt_teamsengagement) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Teams Engagement (msdynmkt_teamsengagement) table/entity reference



## Messages

The following table lists the messages for the Teams Engagement (msdynmkt_teamsengagement) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdynmkt_teamsengagements(*msdynmkt_teamsengagementid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdynmkt_teamsengagements<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdynmkt_teamsengagements(*msdynmkt_teamsengagementid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdynmkt_teamsengagements(*msdynmkt_teamsengagementid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdynmkt_teamsengagements<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdynmkt_teamsengagements(*msdynmkt_teamsengagementid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdynmkt_teamsengagements(*msdynmkt_teamsengagementid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdynmkt_teamsengagements(*msdynmkt_teamsengagementid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Teams Engagement (msdynmkt_teamsengagement) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Teams Engagement (msdynmkt_teamsengagement) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Teams Engagement** |
| **DisplayCollectionName** | **Teams Engagements** |
| **SchemaName** | `msdynmkt_teamsengagement` |
| **CollectionSchemaName** | `msdynmkt_teamsengagements` |
| **EntitySetName** | `msdynmkt_teamsengagements`|
| **LogicalName** | `msdynmkt_teamsengagement` |
| **LogicalCollectionName** | `msdynmkt_teamsengagements` |
| **PrimaryIdAttribute** | `msdynmkt_teamsengagementid` |
| **PrimaryNameAttribute** |`msdynmkt_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdynmkt_audiencechoice](#BKMK_msdynmkt_audiencechoice)
- [msdynmkt_audienceparameters](#BKMK_msdynmkt_audienceparameters)
- [msdynmkt_audiencesegment](#BKMK_msdynmkt_audiencesegment)
- [msdynmkt_audiencetype](#BKMK_msdynmkt_audiencetype)
- [msdynmkt_deliverytime](#BKMK_msdynmkt_deliverytime)
- [msdynmkt_Email](#BKMK_msdynmkt_Email)
- [msdynmkt_engagementjourney](#BKMK_msdynmkt_engagementjourney)
- [msdynmkt_name](#BKMK_msdynmkt_name)
- [msdynmkt_sourcetemplateid](#BKMK_msdynmkt_sourcetemplateid)
- [msdynmkt_state](#BKMK_msdynmkt_state)
- [msdynmkt_teamsengagementId](#BKMK_msdynmkt_teamsengagementId)
- [msdynmkt_timingchoice](#BKMK_msdynmkt_timingchoice)
- [msdynmkt_timingparameters](#BKMK_msdynmkt_timingparameters)
- [msdynmkt_virtualeventid](#BKMK_msdynmkt_virtualeventid)
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

### <a name="BKMK_msdynmkt_audiencechoice"></a> msdynmkt_audiencechoice

|Property|Value|
|---|---|
|Description||
|DisplayName|**Audience Choice**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_audiencechoice`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_audienceparameters"></a> msdynmkt_audienceparameters

|Property|Value|
|---|---|
|Description||
|DisplayName|**Audience Parameters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_audienceparameters`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_audiencesegment"></a> msdynmkt_audiencesegment

|Property|Value|
|---|---|
|Description||
|DisplayName|**Audience Segment**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_audiencesegment`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_segment|

### <a name="BKMK_msdynmkt_audiencetype"></a> msdynmkt_audiencetype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Audience Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_audiencetype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_deliverytime"></a> msdynmkt_deliverytime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Delivery Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_deliverytime`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_Email"></a> msdynmkt_Email

|Property|Value|
|---|---|
|Description||
|DisplayName|**Engagement Email**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_email`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_email|

### <a name="BKMK_msdynmkt_engagementjourney"></a> msdynmkt_engagementjourney

|Property|Value|
|---|---|
|Description||
|DisplayName|**Engagement Journey**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_engagementjourney`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdynmkt_journey|

### <a name="BKMK_msdynmkt_name"></a> msdynmkt_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_name`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_sourcetemplateid"></a> msdynmkt_sourcetemplateid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Source Template Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_sourcetemplateid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_state"></a> msdynmkt_state

|Property|Value|
|---|---|
|Description||
|DisplayName|**Completion State**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_state`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdynmkt_teamsengagement_msdynmkt_state`|

#### msdynmkt_state Choices/Options

|Value|Label|
|---|---|
|534120000|**Template**|
|534120001|**Email**|
|534120002|**Audience**|
|534120003|**Time**|
|534120004|**Review**|

### <a name="BKMK_msdynmkt_teamsengagementId"></a> msdynmkt_teamsengagementId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**teamsengagement**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdynmkt_teamsengagementid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdynmkt_timingchoice"></a> msdynmkt_timingchoice

|Property|Value|
|---|---|
|Description||
|DisplayName|**Timing Parameters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_timingchoice`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdynmkt_timingparameters"></a> msdynmkt_timingparameters

|Property|Value|
|---|---|
|Description||
|DisplayName|**Timing Parameters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_timingparameters`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdynmkt_virtualeventid"></a> msdynmkt_virtualeventid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Virtual Event Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdynmkt_virtualeventid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

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
|Description|**Status of the Teams engagement**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_teamsengagement_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Teams engagement**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdynmkt_teamsengagement_statuscode`|

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
|DisplayName|**Business Unit**|
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

- [business_unit_msdynmkt_teamsengagement](#BKMK_business_unit_msdynmkt_teamsengagement)
- [lk_msdynmkt_teamsengagement_createdby](#BKMK_lk_msdynmkt_teamsengagement_createdby)
- [lk_msdynmkt_teamsengagement_createdonbehalfby](#BKMK_lk_msdynmkt_teamsengagement_createdonbehalfby)
- [lk_msdynmkt_teamsengagement_modifiedby](#BKMK_lk_msdynmkt_teamsengagement_modifiedby)
- [lk_msdynmkt_teamsengagement_modifiedonbehalfby](#BKMK_lk_msdynmkt_teamsengagement_modifiedonbehalfby)
- [msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email](#BKMK_msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email)
- [msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney](#BKMK_msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney)
- [msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment](#BKMK_msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment)
- [owner_msdynmkt_teamsengagement](#BKMK_owner_msdynmkt_teamsengagement)
- [team_msdynmkt_teamsengagement](#BKMK_team_msdynmkt_teamsengagement)
- [user_msdynmkt_teamsengagement](#BKMK_user_msdynmkt_teamsengagement)

### <a name="BKMK_business_unit_msdynmkt_teamsengagement"></a> business_unit_msdynmkt_teamsengagement

One-To-Many Relationship: [businessunit business_unit_msdynmkt_teamsengagement](businessunit.md#BKMK_business_unit_msdynmkt_teamsengagement)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_teamsengagement_createdby"></a> lk_msdynmkt_teamsengagement_createdby

One-To-Many Relationship: [systemuser lk_msdynmkt_teamsengagement_createdby](systemuser.md#BKMK_lk_msdynmkt_teamsengagement_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_teamsengagement_createdonbehalfby"></a> lk_msdynmkt_teamsengagement_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_teamsengagement_createdonbehalfby](systemuser.md#BKMK_lk_msdynmkt_teamsengagement_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_teamsengagement_modifiedby"></a> lk_msdynmkt_teamsengagement_modifiedby

One-To-Many Relationship: [systemuser lk_msdynmkt_teamsengagement_modifiedby](systemuser.md#BKMK_lk_msdynmkt_teamsengagement_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdynmkt_teamsengagement_modifiedonbehalfby"></a> lk_msdynmkt_teamsengagement_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdynmkt_teamsengagement_modifiedonbehalfby](systemuser.md#BKMK_lk_msdynmkt_teamsengagement_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email"></a> msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email

One-To-Many Relationship: [msdynmkt_email msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email](msdynmkt_email.md#BKMK_msdynmkt_msdynmkt_email_msdynmkt_teamsengagement_Email)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_email`|
|ReferencedAttribute|`msdynmkt_emailid`|
|ReferencingAttribute|`msdynmkt_email`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_Email`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney"></a> msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney

One-To-Many Relationship: [msdynmkt_journey msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney](msdynmkt_journey.md#BKMK_msdynmkt_msdynmkt_journey_msdynmkt_teamsengagement_engagementjourney)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_journey`|
|ReferencedAttribute|`msdynmkt_journeyid`|
|ReferencingAttribute|`msdynmkt_engagementjourney`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_engagementjourney`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment"></a> msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment

One-To-Many Relationship: [msdynmkt_segment msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment](msdynmkt_segment.md#BKMK_msdynmkt_msdynmkt_segment_msdynmkt_teamsengagement_audiencesegment)

|Property|Value|
|---|---|
|ReferencedEntity|`msdynmkt_segment`|
|ReferencedAttribute|`msdynmkt_segmentid`|
|ReferencingAttribute|`msdynmkt_audiencesegment`|
|ReferencingEntityNavigationPropertyName|`msdynmkt_audiencesegment`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdynmkt_teamsengagement"></a> owner_msdynmkt_teamsengagement

One-To-Many Relationship: [owner owner_msdynmkt_teamsengagement](owner.md#BKMK_owner_msdynmkt_teamsengagement)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdynmkt_teamsengagement"></a> team_msdynmkt_teamsengagement

One-To-Many Relationship: [team team_msdynmkt_teamsengagement](team.md#BKMK_team_msdynmkt_teamsengagement)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdynmkt_teamsengagement"></a> user_msdynmkt_teamsengagement

One-To-Many Relationship: [systemuser user_msdynmkt_teamsengagement](systemuser.md#BKMK_user_msdynmkt_teamsengagement)

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

- [msdynmkt_teamsengagement_AsyncOperations](#BKMK_msdynmkt_teamsengagement_AsyncOperations)
- [msdynmkt_teamsengagement_BulkDeleteFailures](#BKMK_msdynmkt_teamsengagement_BulkDeleteFailures)
- [msdynmkt_teamsengagement_DuplicateBaseRecord](#BKMK_msdynmkt_teamsengagement_DuplicateBaseRecord)
- [msdynmkt_teamsengagement_DuplicateMatchingRecord](#BKMK_msdynmkt_teamsengagement_DuplicateMatchingRecord)
- [msdynmkt_teamsengagement_MailboxTrackingFolders](#BKMK_msdynmkt_teamsengagement_MailboxTrackingFolders)
- [msdynmkt_teamsengagement_PrincipalObjectAttributeAccesses](#BKMK_msdynmkt_teamsengagement_PrincipalObjectAttributeAccesses)
- [msdynmkt_teamsengagement_ProcessSession](#BKMK_msdynmkt_teamsengagement_ProcessSession)
- [msdynmkt_teamsengagement_SyncErrors](#BKMK_msdynmkt_teamsengagement_SyncErrors)

### <a name="BKMK_msdynmkt_teamsengagement_AsyncOperations"></a> msdynmkt_teamsengagement_AsyncOperations

Many-To-One Relationship: [asyncoperation msdynmkt_teamsengagement_AsyncOperations](asyncoperation.md#BKMK_msdynmkt_teamsengagement_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_teamsengagement_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_teamsengagement_BulkDeleteFailures"></a> msdynmkt_teamsengagement_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdynmkt_teamsengagement_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdynmkt_teamsengagement_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_teamsengagement_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_teamsengagement_DuplicateBaseRecord"></a> msdynmkt_teamsengagement_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_teamsengagement_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdynmkt_teamsengagement_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_teamsengagement_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_teamsengagement_DuplicateMatchingRecord"></a> msdynmkt_teamsengagement_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdynmkt_teamsengagement_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdynmkt_teamsengagement_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_teamsengagement_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_teamsengagement_MailboxTrackingFolders"></a> msdynmkt_teamsengagement_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdynmkt_teamsengagement_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdynmkt_teamsengagement_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_teamsengagement_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_teamsengagement_PrincipalObjectAttributeAccesses"></a> msdynmkt_teamsengagement_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdynmkt_teamsengagement_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdynmkt_teamsengagement_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_teamsengagement_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_teamsengagement_ProcessSession"></a> msdynmkt_teamsengagement_ProcessSession

Many-To-One Relationship: [processsession msdynmkt_teamsengagement_ProcessSession](processsession.md#BKMK_msdynmkt_teamsengagement_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_teamsengagement_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdynmkt_teamsengagement_SyncErrors"></a> msdynmkt_teamsengagement_SyncErrors

Many-To-One Relationship: [syncerror msdynmkt_teamsengagement_SyncErrors](syncerror.md#BKMK_msdynmkt_teamsengagement_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdynmkt_teamsengagement_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

