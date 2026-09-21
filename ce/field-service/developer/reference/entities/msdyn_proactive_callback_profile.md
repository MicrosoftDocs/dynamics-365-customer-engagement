---
title: "Proactive Callback Profile (msdyn_proactive_callback_profile) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Proactive Callback Profile (msdyn_proactive_callback_profile) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: puneet-singh1
ms.author: puneetsingh
search.audienceType: 
  - developer
---

# Proactive Callback Profile (msdyn_proactive_callback_profile) table/entity reference (Microsoft Dynamics 365 Field Service)

Configuration entity for callback profiles used in direct and scheduled callback scenarios.

## Messages

The following table lists the messages for the Proactive Callback Profile (msdyn_proactive_callback_profile) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_proactive_callback_profiles(*msdyn_proactive_callback_profileid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_proactive_callback_profiles<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_proactive_callback_profiles(*msdyn_proactive_callback_profileid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_proactive_callback_profiles(*msdyn_proactive_callback_profileid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_proactive_callback_profiles<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_proactive_callback_profiles(*msdyn_proactive_callback_profileid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_proactive_callback_profiles(*msdyn_proactive_callback_profileid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_proactive_callback_profiles(*msdyn_proactive_callback_profileid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Proactive Callback Profile (msdyn_proactive_callback_profile) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Proactive Callback Profile** |
| **DisplayCollectionName** | **Proactive Callback Profiles** |
| **SchemaName** | `msdyn_proactive_callback_profile` |
| **CollectionSchemaName** | `msdyn_proactive_callback_profiles` |
| **EntitySetName** | `msdyn_proactive_callback_profiles`|
| **LogicalName** | `msdyn_proactive_callback_profile` |
| **LogicalCollectionName** | `msdyn_proactive_callback_profiles` |
| **PrimaryIdAttribute** | `msdyn_proactive_callback_profileid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_alternate_phone_number_terminating_key](#BKMK_msdyn_alternate_phone_number_terminating_key)
- [msdyn_ask_for_alternate_number](#BKMK_msdyn_ask_for_alternate_number)
- [msdyn_bot_user](#BKMK_msdyn_bot_user)
- [msdyn_call_outside_queue_hours](#BKMK_msdyn_call_outside_queue_hours)
- [msdyn_callback_bot_user](#BKMK_msdyn_callback_bot_user)
- [msdyn_callback_number_behavior](#BKMK_msdyn_callback_number_behavior)
- [msdyn_callback_offering_windows](#BKMK_msdyn_callback_offering_windows)
- [msdyn_callback_phone_number](#BKMK_msdyn_callback_phone_number)
- [msdyn_callback_type](#BKMK_msdyn_callback_type)
- [msdyn_delay_between_retries](#BKMK_msdyn_delay_between_retries)
- [msdyn_delay_between_retries_unit](#BKMK_msdyn_delay_between_retries_unit)
- [msdyn_duplicate_prevention_settings](#BKMK_msdyn_duplicate_prevention_settings)
- [msdyn_duplicate_resolution_action](#BKMK_msdyn_duplicate_resolution_action)
- [msdyn_fallback_action](#BKMK_msdyn_fallback_action)
- [msdyn_fallback_prompt_message](#BKMK_msdyn_fallback_prompt_message)
- [msdyn_max_callback_limit](#BKMK_msdyn_max_callback_limit)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_number_of_retries](#BKMK_msdyn_number_of_retries)
- [msdyn_proactive_callback_profileId](#BKMK_msdyn_proactive_callback_profileId)
- [msdyn_reattempt_rules](#BKMK_msdyn_reattempt_rules)
- [msdyn_repeat_message_interval_seconds](#BKMK_msdyn_repeat_message_interval_seconds)
- [msdyn_wait_time_limit_seconds](#BKMK_msdyn_wait_time_limit_seconds)
- [msdyn_wait_time_limit_unit](#BKMK_msdyn_wait_time_limit_unit)
- [msdyn_wait_time_window_seconds](#BKMK_msdyn_wait_time_window_seconds)
- [msdyn_wait_time_window_unit](#BKMK_msdyn_wait_time_window_unit)
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

### <a name="BKMK_msdyn_alternate_phone_number_terminating_key"></a> msdyn_alternate_phone_number_terminating_key

|Property|Value|
|---|---|
|Description|**The DTMF key used to terminate alternate phone number entry (e.g. \*, \#, \#\#).**|
|DisplayName|**Alternate Phone Number Terminating Key**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_alternate_phone_number_terminating_key`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ask_for_alternate_number"></a> msdyn_ask_for_alternate_number

|Property|Value|
|---|---|
|Description|**Whether to ask the customer for an alternate phone number for the callback.**|
|DisplayName|**Ask For Alternate Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ask_for_alternate_number`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_proactive_callback_profile_msdyn_ask_for_alternate_number`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_bot_user"></a> msdyn_bot_user

|Property|Value|
|---|---|
|Description|**The bot user assigned to handle callback conversations.**|
|DisplayName|**Bot User**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bot_user`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_call_outside_queue_hours"></a> msdyn_call_outside_queue_hours

|Property|Value|
|---|---|
|Description|**Whether callbacks can be executed outside queue operating hours.**|
|DisplayName|**Call Outside Queue Hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_call_outside_queue_hours`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_proactive_callback_profile_msdyn_call_outside_queue_hours`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_callback_bot_user"></a> msdyn_callback_bot_user

|Property|Value|
|---|---|
|Description|**The bot user assigned to handle callback orchestration scenarios.**|
|DisplayName|**Callback Bot User**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_callback_bot_user`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|systemuser|

### <a name="BKMK_msdyn_callback_number_behavior"></a> msdyn_callback_number_behavior

|Property|Value|
|---|---|
|Description|**Controls which outbound number is used for callbacks: the same number the customer called from or a specific configured number.**|
|DisplayName|**Callback Number Behavior**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_callback_number_behavior`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_proactive_callback_profile_msdyn_callback_number_behavior`|

#### msdyn_callback_number_behavior Choices/Options

|Value|Label|
|---|---|
|192350000|**Same Number**|
|192350001|**Specific Number**|

### <a name="BKMK_msdyn_callback_offering_windows"></a> msdyn_callback_offering_windows

|Property|Value|
|---|---|
|Description|**JSON-formatted offering windows for callback scheduling, converted to queue time zone (expected compact JSON array payload).**|
|DisplayName|**Callback Offering Windows**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_callback_offering_windows`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_callback_phone_number"></a> msdyn_callback_phone_number

|Property|Value|
|---|---|
|Description|**The outbound phone number for callbacks. If SameNumber behavior, this is the fallback number. If SpecificNumber, this is always used. Outbound voice numbers only.**|
|DisplayName|**Callback Phone Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_callback_phone_number`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_ocphonenumber|

### <a name="BKMK_msdyn_callback_type"></a> msdyn_callback_type

|Property|Value|
|---|---|
|Description|**Determines type of the callback profile**|
|DisplayName|**Callback Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_callback_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_callback_type`|

#### msdyn_callback_type Choices/Options

|Value|Label|
|---|---|
|192350000|**Direct Callback**|
|192350001|**Scheduled Callback**|

### <a name="BKMK_msdyn_delay_between_retries"></a> msdyn_delay_between_retries

|Property|Value|
|---|---|
|Description|**The delay between reattempts for callback delivery.**|
|DisplayName|**Delay Between Retries**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_delay_between_retries`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_delay_between_retries_unit"></a> msdyn_delay_between_retries_unit

|Property|Value|
|---|---|
|Description|**The unit for delayed reattempts (Second, Minute, Hour).**|
|DisplayName|**Delay Between Retries Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_delay_between_retries_unit`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_proactive_callback_profile_msdyn_delay_between_retries_unit`|

#### msdyn_delay_between_retries_unit Choices/Options

|Value|Label|
|---|---|
|192350000|**Second**|
|192350001|**Minute**|
|192350002|**Hour**|

### <a name="BKMK_msdyn_duplicate_prevention_settings"></a> msdyn_duplicate_prevention_settings

|Property|Value|
|---|---|
|Description|**Controls duplicate callback prevention scope.**|
|DisplayName|**Duplicate Prevention Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duplicate_prevention_settings`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_proactive_callback_profile_msdyn_duplicate_prevention_settings`|

#### msdyn_duplicate_prevention_settings Choices/Options

|Value|Label|
|---|---|
|192350000|**None**|
|192350001|**Same Queue**|
|192350002|**All Queues**|

### <a name="BKMK_msdyn_duplicate_resolution_action"></a> msdyn_duplicate_resolution_action

|Property|Value|
|---|---|
|Description|**Action to take when a duplicate callback is detected.**|
|DisplayName|**Duplicate Resolution Action**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duplicate_resolution_action`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_proactive_callback_profile_msdyn_duplicate_resolution_action`|

#### msdyn_duplicate_resolution_action Choices/Options

|Value|Label|
|---|---|
|192350000|**End Call**|
|192350001|**Wait In Queue**|

### <a name="BKMK_msdyn_fallback_action"></a> msdyn_fallback_action

|Property|Value|
|---|---|
|Description|**Determines the action to take when the callback bot fails. Hangup ends the call, Escalate transfers to a representative.**|
|DisplayName|**Fallback Action**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fallback_action`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_proactive_callback_profile_msdyn_fallback_action`|

#### msdyn_fallback_action Choices/Options

|Value|Label|
|---|---|
|192350000|**Hangup**|
|192350001|**Escalate**|

### <a name="BKMK_msdyn_fallback_prompt_message"></a> msdyn_fallback_prompt_message

|Property|Value|
|---|---|
|Description|**Text played to the caller when the AI agent is unavailable and the fallback action requires a prompt before hanging up.**|
|DisplayName|**Fallback Prompt Message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fallback_prompt_message`|
|RequiredLevel|None|
|Type|Memo|
|Format|TextArea|
|FormatName|TextArea|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_max_callback_limit"></a> msdyn_max_callback_limit

|Property|Value|
|---|---|
|Description|**The maximum number of concurrent callbacks allowed.**|
|DisplayName|**Maximum Callback Limit**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_max_callback_limit`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

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

### <a name="BKMK_msdyn_number_of_retries"></a> msdyn_number_of_retries

|Property|Value|
|---|---|
|Description|**The number of reattempts allowed for a callback delivery.**|
|DisplayName|**Number of Retries**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_number_of_retries`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_proactive_callback_profileId"></a> msdyn_proactive_callback_profileId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Proactive Callback Profile**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_proactive_callback_profileid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_reattempt_rules"></a> msdyn_reattempt_rules

|Property|Value|
|---|---|
|Description|**JSON-formatted reattempt configuration rules (expected compact JSON object payload).**|
|DisplayName|**Reattempt Rules**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reattempt_rules`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_repeat_message_interval_seconds"></a> msdyn_repeat_message_interval_seconds

|Property|Value|
|---|---|
|Description|**The interval in seconds at which to repeat the callback question to the customer.**|
|DisplayName|**Repeat Message Interval Seconds**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_repeat_message_interval_seconds`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|3600|
|MinValue|30|

### <a name="BKMK_msdyn_wait_time_limit_seconds"></a> msdyn_wait_time_limit_seconds

|Property|Value|
|---|---|
|Description|**The average wait time threshold value for callback throttling rules.**|
|DisplayName|**Wait Time Limit Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_wait_time_limit_seconds`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_wait_time_limit_unit"></a> msdyn_wait_time_limit_unit

|Property|Value|
|---|---|
|Description|**The unit of time for the wait time limit threshold.**|
|DisplayName|**Wait Time Limit Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_wait_time_limit_unit`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_proactive_callback_profile_msdyn_wait_time_limit_unit`|

#### msdyn_wait_time_limit_unit Choices/Options

|Value|Label|
|---|---|
|192350000|**Seconds**|
|192350001|**Minutes**|

### <a name="BKMK_msdyn_wait_time_window_seconds"></a> msdyn_wait_time_window_seconds

|Property|Value|
|---|---|
|Description|**The lookback window for calculating average wait time for callback throttling.**|
|DisplayName|**Wait Time Window Seconds**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_wait_time_window_seconds`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_wait_time_window_unit"></a> msdyn_wait_time_window_unit

|Property|Value|
|---|---|
|Description|**The unit of time for the wait time lookback window.**|
|DisplayName|**Wait Time Window Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_wait_time_window_unit`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_proactive_callback_profile_msdyn_wait_time_window_unit`|

#### msdyn_wait_time_window_unit Choices/Options

|Value|Label|
|---|---|
|192350000|**Seconds**|
|192350001|**Minutes**|
|192350002|**Hours**|

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
|Description|**Status of the Proactive Callback Profile**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_proactive_callback_profile_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Proactive Callback Profile**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_proactive_callback_profile_statuscode`|

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

### <a name="BKMK_msdyn_proactive_callback_profile_callback_phone_number_msdyn_ocphonenumber"></a> msdyn_proactive_callback_profile_callback_phone_number_msdyn_ocphonenumber

One-To-Many Relationship: [msdyn_ocphonenumber msdyn_proactive_callback_profile_callback_phone_number_msdyn_ocphonenumber](msdyn_ocphonenumber.md#BKMK_msdyn_proactive_callback_profile_callback_phone_number_msdyn_ocphonenumber)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_ocphonenumber`|
|ReferencedAttribute|`msdyn_ocphonenumberid`|
|ReferencingAttribute|`msdyn_callback_phone_number`|
|ReferencingEntityNavigationPropertyName|`msdyn_callback_phone_number`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

- [msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile](#BKMK_msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile)
- [msdyn_proactive_delivery_msdyn_proactive_callback_profileId_msdyn_proactive_callback_profile](#BKMK_msdyn_proactive_delivery_msdyn_proactive_callback_profileId_msdyn_proactive_callback_profile)

### <a name="BKMK_msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile"></a> msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile

Many-To-One Relationship: [msdyn_overflowactionconfig msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile](msdyn_overflowactionconfig.md#BKMK_msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_overflowactionconfig`|
|ReferencingAttribute|`msdyn_proactive_callback_profileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_overflowactionconfig_proactive_callback_profileId_msdyn_proactive_callback_profile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_delivery_msdyn_proactive_callback_profileId_msdyn_proactive_callback_profile"></a> msdyn_proactive_delivery_msdyn_proactive_callback_profileId_msdyn_proactive_callback_profile

Many-To-One Relationship: [msdyn_proactive_delivery msdyn_proactive_delivery_msdyn_proactive_callback_profileId_msdyn_proactive_callback_profile](msdyn_proactive_delivery.md#BKMK_msdyn_proactive_delivery_msdyn_proactive_callback_profileId_msdyn_proactive_callback_profile)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_delivery`|
|ReferencingAttribute|`msdyn_proactive_callback_profileid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_delivery_msdyn_proactive_callback_profileId_msdyn_proactive_callback_profile`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

