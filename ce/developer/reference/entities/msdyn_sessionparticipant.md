---
title: "Session participant (msdyn_sessionparticipant) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Session participant (msdyn_sessionparticipant) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Session participant (msdyn_sessionparticipant) table/entity reference (Microsoft Dynamics 365)

Users in a session interacting with the customer

## Messages

The following table lists the messages for the Session participant (msdyn_sessionparticipant) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_sessionparticipants(*msdyn_sessionparticipantid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_sessionparticipants<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_sessionparticipants(*msdyn_sessionparticipantid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_sessionparticipants(*msdyn_sessionparticipantid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_sessionparticipants<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_sessionparticipants(*msdyn_sessionparticipantid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_sessionparticipants(*msdyn_sessionparticipantid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_sessionparticipants(*msdyn_sessionparticipantid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Session participant (msdyn_sessionparticipant) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Session participant** |
| **DisplayCollectionName** | **Session participants** |
| **SchemaName** | `msdyn_sessionparticipant` |
| **CollectionSchemaName** | `msdyn_sessionparticipants` |
| **EntitySetName** | `msdyn_sessionparticipants`|
| **LogicalName** | `msdyn_sessionparticipant` |
| **LogicalCollectionName** | `msdyn_sessionparticipants` |
| **PrimaryIdAttribute** | `msdyn_sessionparticipantid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_activechattime](#BKMK_msdyn_activechattime)
- [msdyn_activedirectoryuserid](#BKMK_msdyn_activedirectoryuserid)
- [msdyn_activetime](#BKMK_msdyn_activetime)
- [msdyn_activewrapuptime](#BKMK_msdyn_activewrapuptime)
- [msdyn_addedon](#BKMK_msdyn_addedon)
- [msdyn_agentid](#BKMK_msdyn_agentid)
- [msdyn_assignreason](#BKMK_msdyn_assignreason)
- [msdyn_cdsqueueid](#BKMK_msdyn_cdsqueueid)
- [msdyn_consultmode](#BKMK_msdyn_consultmode)
- [msdyn_conversationaccess](#BKMK_msdyn_conversationaccess)
- [msdyn_externalparticipantchannel](#BKMK_msdyn_externalparticipantchannel)
- [msdyn_externalparticipantchanneltype](#BKMK_msdyn_externalparticipantchanneltype)
- [msdyn_holdtime](#BKMK_msdyn_holdtime)
- [msdyn_idletime](#BKMK_msdyn_idletime)
- [msdyn_inactivetime](#BKMK_msdyn_inactivetime)
- [msdyn_joinedon](#BKMK_msdyn_joinedon)
- [msdyn_lastupdatedon](#BKMK_msdyn_lastupdatedon)
- [msdyn_lefton](#BKMK_msdyn_lefton)
- [msdyn_leftonreason](#BKMK_msdyn_leftonreason)
- [msdyn_mode](#BKMK_msdyn_mode)
- [msdyn_modifiedon](#BKMK_msdyn_modifiedon)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_omnichannelsession](#BKMK_msdyn_omnichannelsession)
- [msdyn_sessionparticipantId](#BKMK_msdyn_sessionparticipantId)
- [msdyn_startactivetime](#BKMK_msdyn_startactivetime)
- [msdyn_startactivewrapuptime](#BKMK_msdyn_startactivewrapuptime)
- [msdyn_startholdtime](#BKMK_msdyn_startholdtime)
- [msdyn_startidletime](#BKMK_msdyn_startidletime)
- [msdyn_startinactivetime](#BKMK_msdyn_startinactivetime)
- [msdyn_starttalktime](#BKMK_msdyn_starttalktime)
- [msdyn_talktime](#BKMK_msdyn_talktime)
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

### <a name="BKMK_msdyn_activechattime"></a> msdyn_activechattime

|Property|Value|
|---|---|
|Description|**Active chat time for an agent in the session**|
|DisplayName|**Active chat time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activechattime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_activedirectoryuserid"></a> msdyn_activedirectoryuserid

|Property|Value|
|---|---|
|Description|**Unique identifier of Active Directory User participating in session.**|
|DisplayName|**Active Directory User Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activedirectoryuserid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_activetime"></a> msdyn_activetime

|Property|Value|
|---|---|
|Description|**Active time for agent on the session**|
|DisplayName|**Active time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activetime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_activewrapuptime"></a> msdyn_activewrapuptime

|Property|Value|
|---|---|
|Description|**Active wrapup time for an agent on the session**|
|DisplayName|**Active wrapup time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_activewrapuptime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_addedon"></a> msdyn_addedon

|Property|Value|
|---|---|
|Description|**Date and time when agent assigned to the session.**|
|DisplayName|**Added On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_addedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_agentid"></a> msdyn_agentid

|Property|Value|
|---|---|
|Description|**Unique identifier of System User participating in session.**|
|DisplayName|**Agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agentid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_assignreason"></a> msdyn_assignreason

|Property|Value|
|---|---|
|Description|**The agent assignment reason (This is for internal use only. Customers are advised to not use this property)**|
|DisplayName|**Assign Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_assignreason`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_cdsqueueid"></a> msdyn_cdsqueueid

|Property|Value|
|---|---|
|Description|**Unique identifier for Queue associated with Session Participant.**|
|DisplayName|**Queue Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cdsqueueid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|queue|

### <a name="BKMK_msdyn_consultmode"></a> msdyn_consultmode

|Property|Value|
|---|---|
|Description|**Consultation mode of the participant**|
|DisplayName|**Consult Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_consultmode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_consultmodetype`|

#### msdyn_consultmode Choices/Options

|Value|Label|
|---|---|
|0|**Chat**|
|1|**Chat And Voice**|
|2|**Voice**|

### <a name="BKMK_msdyn_conversationaccess"></a> msdyn_conversationaccess

|Property|Value|
|---|---|
|Description|**This field denotes the level of access a participant has in a conversation**|
|DisplayName|**Conversation Access**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_conversationaccess`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_conversationaccesstype`|

#### msdyn_conversationaccess Choices/Options

|Value|Label|
|---|---|
|0|**Default**|
|1|**Public**|
|2|**Private**|

### <a name="BKMK_msdyn_externalparticipantchannel"></a> msdyn_externalparticipantchannel

|Property|Value|
|---|---|
|Description||
|DisplayName|**External channel of participant**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_externalparticipantchannel`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_externalparticipantchanneltype"></a> msdyn_externalparticipantchanneltype

|Property|Value|
|---|---|
|Description|**Channel type of external participant**|
|DisplayName|**Channel type of external participant**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_externalparticipantchanneltype`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_externalparticipantchanneltype`|

#### msdyn_externalparticipantchanneltype Choices/Options

|Value|Label|
|---|---|
|426120000|**Phone Number**|

### <a name="BKMK_msdyn_holdtime"></a> msdyn_holdtime

|Property|Value|
|---|---|
|Description|**Hold time for an agent on the session**|
|DisplayName|**Hold time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_holdtime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_idletime"></a> msdyn_idletime

|Property|Value|
|---|---|
|Description|**Idle time for agent on the session**|
|DisplayName|**Idle time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_idletime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_inactivetime"></a> msdyn_inactivetime

|Property|Value|
|---|---|
|Description|**Inactive time for agent on the session**|
|DisplayName|**Inactive time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inactivetime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_joinedon"></a> msdyn_joinedon

|Property|Value|
|---|---|
|Description|**Date and time when agent accepted the session.**|
|DisplayName|**Joined On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_joinedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_lastupdatedon"></a> msdyn_lastupdatedon

|Property|Value|
|---|---|
|Description|**Last Updated On timestamp for the record**|
|DisplayName|**Last Updated On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastupdatedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_lefton"></a> msdyn_lefton

|Property|Value|
|---|---|
|Description|**Date and time when agent left the session.**|
|DisplayName|**Left On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lefton`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_leftonreason"></a> msdyn_leftonreason

|Property|Value|
|---|---|
|Description|**The agent left on reason (This is for internal use only. Customers are advised to not use this property)**|
|DisplayName|**LeftOn Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_leftonreason`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_mode"></a> msdyn_mode

|Property|Value|
|---|---|
|Description|**Mode of Agent participation i.e. primary, consult, monitor, preview etc.**|
|DisplayName|**Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mode`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_sessionparticipant_msdyn_mode`|

#### msdyn_mode Choices/Options

|Value|Label|
|---|---|
|192350002|**Primary**|
|192350003|**Consult**|
|192350004|**Monitor**|
|192350005|**Preview**|

### <a name="BKMK_msdyn_modifiedon"></a> msdyn_modifiedon

|Property|Value|
|---|---|
|Description|**Date and time when session participant information was last modified.**|
|DisplayName|**Session Participant Modified On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_modifiedon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

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
|MaxLength|200|

### <a name="BKMK_msdyn_omnichannelsession"></a> msdyn_omnichannelsession

|Property|Value|
|---|---|
|Description|**Unique identifier of the session associated to the participant.**|
|DisplayName|**Omni Channel Session**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_omnichannelsession`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_ocsession|

### <a name="BKMK_msdyn_sessionparticipantId"></a> msdyn_sessionparticipantId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Session participant**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_sessionparticipantid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_startactivetime"></a> msdyn_startactivetime

|Property|Value|
|---|---|
|Description|**Start active time for agent on the session**|
|DisplayName|**Start active time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startactivetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_startactivewrapuptime"></a> msdyn_startactivewrapuptime

|Property|Value|
|---|---|
|Description|**Start active wrapup time for an agent on the session**|
|DisplayName|**Start active wrapup time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startactivewrapuptime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_startholdtime"></a> msdyn_startholdtime

|Property|Value|
|---|---|
|Description|**Start hold time for an agent on the session**|
|DisplayName|**Start hold time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startholdtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_startidletime"></a> msdyn_startidletime

|Property|Value|
|---|---|
|Description|**Start idle time for agent on the session**|
|DisplayName|**Start idle time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startidletime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_startinactivetime"></a> msdyn_startinactivetime

|Property|Value|
|---|---|
|Description|**Start inactive time for agent on the session**|
|DisplayName|**Start inactive time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startinactivetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_starttalktime"></a> msdyn_starttalktime

|Property|Value|
|---|---|
|Description|**Start talk time for an agent on the session**|
|DisplayName|**Start talk time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_starttalktime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_talktime"></a> msdyn_talktime

|Property|Value|
|---|---|
|Description|**Talk time for an agent on the session**|
|DisplayName|**Talk time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_talktime`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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
|Description|**Status of the Session participant**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sessionparticipant_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Session participant**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_sessionparticipant_statuscode`|

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

- [business_unit_msdyn_sessionparticipant](#BKMK_business_unit_msdyn_sessionparticipant)
- [lk_msdyn_sessionparticipant_createdby](#BKMK_lk_msdyn_sessionparticipant_createdby)
- [lk_msdyn_sessionparticipant_createdonbehalfby](#BKMK_lk_msdyn_sessionparticipant_createdonbehalfby)
- [lk_msdyn_sessionparticipant_modifiedby](#BKMK_lk_msdyn_sessionparticipant_modifiedby)
- [lk_msdyn_sessionparticipant_modifiedonbehalfby](#BKMK_lk_msdyn_sessionparticipant_modifiedonbehalfby)
- [msdyn_ocsession_sessionparticipant_nested](#BKMK_msdyn_ocsession_sessionparticipant_nested)
- [msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid](#BKMK_msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid)
- [msdyn_systemuser_msdyn_sessionparticipant_agentid](#BKMK_msdyn_systemuser_msdyn_sessionparticipant_agentid)
- [owner_msdyn_sessionparticipant](#BKMK_owner_msdyn_sessionparticipant)
- [team_msdyn_sessionparticipant](#BKMK_team_msdyn_sessionparticipant)
- [user_msdyn_sessionparticipant](#BKMK_user_msdyn_sessionparticipant)

### <a name="BKMK_business_unit_msdyn_sessionparticipant"></a> business_unit_msdyn_sessionparticipant

One-To-Many Relationship: [businessunit business_unit_msdyn_sessionparticipant](businessunit.md#BKMK_business_unit_msdyn_sessionparticipant)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sessionparticipant_createdby"></a> lk_msdyn_sessionparticipant_createdby

One-To-Many Relationship: [systemuser lk_msdyn_sessionparticipant_createdby](systemuser.md#BKMK_lk_msdyn_sessionparticipant_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sessionparticipant_createdonbehalfby"></a> lk_msdyn_sessionparticipant_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sessionparticipant_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_sessionparticipant_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sessionparticipant_modifiedby"></a> lk_msdyn_sessionparticipant_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_sessionparticipant_modifiedby](systemuser.md#BKMK_lk_msdyn_sessionparticipant_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_sessionparticipant_modifiedonbehalfby"></a> lk_msdyn_sessionparticipant_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_sessionparticipant_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_sessionparticipant_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_ocsession_sessionparticipant_nested"></a> msdyn_ocsession_sessionparticipant_nested

One-To-Many Relationship: [msdyn_ocsession msdyn_ocsession_sessionparticipant_nested](msdyn_ocsession.md#BKMK_msdyn_ocsession_sessionparticipant_nested)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocsession`|
|ReferencedAttribute|`activityid`|
|ReferencingAttribute|`msdyn_omnichannelsession`|
|ReferencingEntityNavigationPropertyName|`msdyn_omnichannelsession`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid"></a> msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid

One-To-Many Relationship: [queue msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid](queue.md#BKMK_msdyn_queue_msdyn_sessionparticipant_msdyn_cdsqueueid)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_cdsqueueid`|
|ReferencingEntityNavigationPropertyName|`msdyn_cdsqueueid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_systemuser_msdyn_sessionparticipant_agentid"></a> msdyn_systemuser_msdyn_sessionparticipant_agentid

One-To-Many Relationship: [systemuser msdyn_systemuser_msdyn_sessionparticipant_agentid](systemuser.md#BKMK_msdyn_systemuser_msdyn_sessionparticipant_agentid)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`msdyn_agentid`|
|ReferencingEntityNavigationPropertyName|`msdyn_agentid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_sessionparticipant"></a> owner_msdyn_sessionparticipant

One-To-Many Relationship: [owner owner_msdyn_sessionparticipant](owner.md#BKMK_owner_msdyn_sessionparticipant)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_sessionparticipant"></a> team_msdyn_sessionparticipant

One-To-Many Relationship: [team team_msdyn_sessionparticipant](team.md#BKMK_team_msdyn_sessionparticipant)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_sessionparticipant"></a> user_msdyn_sessionparticipant

One-To-Many Relationship: [systemuser user_msdyn_sessionparticipant](systemuser.md#BKMK_user_msdyn_sessionparticipant)

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

- [msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid](#BKMK_msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid)
- [msdyn_msdyn_sessionparticipant_msdyn_ocsessionparticipantevent_sessionparticipantid](#BKMK_msdyn_msdyn_sessionparticipant_msdyn_ocsessionparticipantevent_sessionparticipantid)
- [msdyn_sessionparticipant_AsyncOperations](#BKMK_msdyn_sessionparticipant_AsyncOperations)
- [msdyn_sessionparticipant_BulkDeleteFailures](#BKMK_msdyn_sessionparticipant_BulkDeleteFailures)
- [msdyn_sessionparticipant_DuplicateBaseRecord](#BKMK_msdyn_sessionparticipant_DuplicateBaseRecord)
- [msdyn_sessionparticipant_DuplicateMatchingRecord](#BKMK_msdyn_sessionparticipant_DuplicateMatchingRecord)
- [msdyn_sessionparticipant_MailboxTrackingFolders](#BKMK_msdyn_sessionparticipant_MailboxTrackingFolders)
- [msdyn_sessionparticipant_PrincipalObjectAttributeAccesses](#BKMK_msdyn_sessionparticipant_PrincipalObjectAttributeAccesses)
- [msdyn_sessionparticipant_ProcessSession](#BKMK_msdyn_sessionparticipant_ProcessSession)
- [msdyn_sessionparticipant_SyncErrors](#BKMK_msdyn_sessionparticipant_SyncErrors)

### <a name="BKMK_msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid"></a> msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid](msdyn_ocliveworkitem.md#BKMK_msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`msdyn_activesessionparticipantid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_sessionparticipant_msdyn_ocliveworkitem_activesessionparticipantid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_sessionparticipant_msdyn_ocsessionparticipantevent_sessionparticipantid"></a> msdyn_msdyn_sessionparticipant_msdyn_ocsessionparticipantevent_sessionparticipantid

Many-To-One Relationship: [msdyn_ocsessionparticipantevent msdyn_msdyn_sessionparticipant_msdyn_ocsessionparticipantevent_sessionparticipantid](msdyn_ocsessionparticipantevent.md#BKMK_msdyn_msdyn_sessionparticipant_msdyn_ocsessionparticipantevent_sessionparticipantid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsessionparticipantevent`|
|ReferencingAttribute|`msdyn_sessionparticipantid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_sessionparticipant_msdyn_ocsessionparticipantevent_sessionparticipantid`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sessionparticipant_AsyncOperations"></a> msdyn_sessionparticipant_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_sessionparticipant_AsyncOperations](asyncoperation.md#BKMK_msdyn_sessionparticipant_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sessionparticipant_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sessionparticipant_BulkDeleteFailures"></a> msdyn_sessionparticipant_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_sessionparticipant_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_sessionparticipant_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sessionparticipant_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sessionparticipant_DuplicateBaseRecord"></a> msdyn_sessionparticipant_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_sessionparticipant_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_sessionparticipant_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sessionparticipant_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sessionparticipant_DuplicateMatchingRecord"></a> msdyn_sessionparticipant_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_sessionparticipant_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_sessionparticipant_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sessionparticipant_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sessionparticipant_MailboxTrackingFolders"></a> msdyn_sessionparticipant_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_sessionparticipant_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_sessionparticipant_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sessionparticipant_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sessionparticipant_PrincipalObjectAttributeAccesses"></a> msdyn_sessionparticipant_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_sessionparticipant_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_sessionparticipant_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sessionparticipant_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sessionparticipant_ProcessSession"></a> msdyn_sessionparticipant_ProcessSession

Many-To-One Relationship: [processsession msdyn_sessionparticipant_ProcessSession](processsession.md#BKMK_msdyn_sessionparticipant_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sessionparticipant_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_sessionparticipant_SyncErrors"></a> msdyn_sessionparticipant_SyncErrors

Many-To-One Relationship: [syncerror msdyn_sessionparticipant_SyncErrors](syncerror.md#BKMK_msdyn_sessionparticipant_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_sessionparticipant_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

