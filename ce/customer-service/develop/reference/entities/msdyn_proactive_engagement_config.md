---
title: "Proactive Engagement Configuration (msdyn_proactive_engagement_config) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Proactive Engagement Configuration (msdyn_proactive_engagement_config) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Proactive Engagement Configuration (msdyn_proactive_engagement_config) table/entity reference (Microsoft Dynamics 365 Customer Service)



## Messages

The following table lists the messages for the Proactive Engagement Configuration (msdyn_proactive_engagement_config) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_proactive_engagement_configs(*msdyn_proactive_engagement_configid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_proactive_engagement_configs<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_proactive_engagement_configs(*msdyn_proactive_engagement_configid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_proactive_engagement_configs(*msdyn_proactive_engagement_configid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_proactive_engagement_configs<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_proactive_engagement_configs(*msdyn_proactive_engagement_configid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_proactive_engagement_configs(*msdyn_proactive_engagement_configid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_proactive_engagement_configs(*msdyn_proactive_engagement_configid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Proactive Engagement Configuration (msdyn_proactive_engagement_config) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Proactive Engagement Configuration** |
| **DisplayCollectionName** | **Proactive Engagement Configuration** |
| **SchemaName** | `msdyn_proactive_engagement_config` |
| **CollectionSchemaName** | `msdyn_proactive_engagement_configs` |
| **EntitySetName** | `msdyn_proactive_engagement_configs`|
| **LogicalName** | `msdyn_proactive_engagement_config` |
| **LogicalCollectionName** | `msdyn_proactive_engagement_configs` |
| **PrimaryIdAttribute** | `msdyn_proactive_engagement_configid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [IsCustomizable](#BKMK_IsCustomizable)
- [msdyn_bot_failure_treatment_rate_threshold](#BKMK_msdyn_bot_failure_treatment_rate_threshold)
- [msdyn_bot_failure_treatment_type](#BKMK_msdyn_bot_failure_treatment_type)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_dialmode_type](#BKMK_msdyn_dialmode_type)
- [msdyn_first_response_timeout_mins](#BKMK_msdyn_first_response_timeout_mins)
- [msdyn_ignore_queue_hours](#BKMK_msdyn_ignore_queue_hours)
- [msdyn_intentid](#BKMK_msdyn_intentid)
- [msdyn_max_calls_per_agent](#BKMK_msdyn_max_calls_per_agent)
- [msdyn_max_concurrent_calls](#BKMK_msdyn_max_concurrent_calls)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_priority](#BKMK_msdyn_priority)
- [msdyn_proactive_engagement_configId](#BKMK_msdyn_proactive_engagement_configId)
- [msdyn_processing_order](#BKMK_msdyn_processing_order)
- [msdyn_queue](#BKMK_msdyn_queue)
- [msdyn_queue_allotment](#BKMK_msdyn_queue_allotment)
- [msdyn_reserve_agent_capacity](#BKMK_msdyn_reserve_agent_capacity)
- [msdyn_throttle_adjustment_percentage](#BKMK_msdyn_throttle_adjustment_percentage)
- [msdyn_throttle_control_period](#BKMK_msdyn_throttle_control_period)
- [msdyn_throttle_control_period_2](#BKMK_msdyn_throttle_control_period_2)
- [msdyn_throttle_metric](#BKMK_msdyn_throttle_metric)
- [msdyn_throttle_metric_2](#BKMK_msdyn_throttle_metric_2)
- [msdyn_throttle_threshold](#BKMK_msdyn_throttle_threshold)
- [msdyn_throttle_threshold_2](#BKMK_msdyn_throttle_threshold_2)
- [msdyn_type](#BKMK_msdyn_type)
- [msdyn_workstream](#BKMK_msdyn_workstream)
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

### <a name="BKMK_IsCustomizable"></a> IsCustomizable

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Is Customizable**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`iscustomizable`|
|RequiredLevel|SystemRequired|
|Type|ManagedProperty|

### <a name="BKMK_msdyn_bot_failure_treatment_rate_threshold"></a> msdyn_bot_failure_treatment_rate_threshold

|Property|Value|
|---|---|
|Description|**This indicates Proactive Engagement can continue making calls until the rate of failure reaches this threshold.**|
|DisplayName|**Bot Failure Treatment Rate Threshold**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bot_failure_treatment_rate_threshold`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|0|

### <a name="BKMK_msdyn_bot_failure_treatment_type"></a> msdyn_bot_failure_treatment_type

|Property|Value|
|---|---|
|Description|**Determines how bot failures should affect Proactive Engagement dispatching behavior.**|
|DisplayName|**Bot Failure Treatment Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bot_failure_treatment_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192360000|
|GlobalChoiceName|`msdyn_proactive_engagement_config_msdyn_bot_failure_treatment_type`|

#### msdyn_bot_failure_treatment_type Choices/Options

|Value|Label|
|---|---|
|192360000|**None**|
|192360001|**Suspend**|
|192360002|**Threshold**|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**A short description of this Proactive Engagement Configuration.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_dialmode_type"></a> msdyn_dialmode_type

|Property|Value|
|---|---|
|Description|**The dial model for this Proactive Engagement Configuration.**|
|DisplayName|**Dial mode type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_dialmode_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_proactive_engagement_config_msdyn_dialmode_type`|

#### msdyn_dialmode_type Choices/Options

|Value|Label|
|---|---|
|100000000|**Copilot**|
|100000001|**Progressive**|
|100000002|**Preview**|
|100000003|**Predictive**|

### <a name="BKMK_msdyn_first_response_timeout_mins"></a> msdyn_first_response_timeout_mins

|Property|Value|
|---|---|
|Description|**First response timeout for SMS engagements**|
|DisplayName|**First Response Timeout (Minutes)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_first_response_timeout_mins`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_ignore_queue_hours"></a> msdyn_ignore_queue_hours

|Property|Value|
|---|---|
|Description|**Determines if deliveries should only be made during the hours defined on the Queue.**|
|DisplayName|**Ignore Queue Hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ignore_queue_hours`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_proactive_engagement_config_msdyn_ignore_queue_hours`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_intentid"></a> msdyn_intentid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Intent Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_intentid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_max_calls_per_agent"></a> msdyn_max_calls_per_agent

|Property|Value|
|---|---|
|Description|**The maximum calls Proactive Engagement should have in flight per available agent.**|
|DisplayName|**Maximum Calls per Agent**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_max_calls_per_agent`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_max_concurrent_calls"></a> msdyn_max_concurrent_calls

|Property|Value|
|---|---|
|Description|**The maximum concurrent calls Proactive Engagement should have in flight at any point.**|
|DisplayName|**Maximum Concurrent Calls**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_max_concurrent_calls`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

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

### <a name="BKMK_msdyn_priority"></a> msdyn_priority

|Property|Value|
|---|---|
|Description|**The processing priority of this Proactive Engagement Configuration relative to others within this organization.**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_priority`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_proactive_engagement_config_msdyn_priority`|

#### msdyn_priority Choices/Options

|Value|Label|
|---|---|
|1|**Critical**|
|2|**High**|
|3|**Normal**|

### <a name="BKMK_msdyn_proactive_engagement_configId"></a> msdyn_proactive_engagement_configId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Proactive Engagement Configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_proactive_engagement_configid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_processing_order"></a> msdyn_processing_order

|Property|Value|
|---|---|
|Description|**The order in which Proactive Engagement should process records that are ready to send.**|
|DisplayName|**Processing Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_processing_order`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|700610000|
|GlobalChoiceName|`msdyn_proactive_engagement_config_msdyn_processing_order`|

#### msdyn_processing_order Choices/Options

|Value|Label|
|---|---|
|700610000|**Earliest Scheduled Date**|
|700610001|**First In, First Out**|
|700610002|**Last In, First Out**|

### <a name="BKMK_msdyn_queue"></a> msdyn_queue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Queue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queue`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|queue|

### <a name="BKMK_msdyn_queue_allotment"></a> msdyn_queue_allotment

|Property|Value|
|---|---|
|Description|**The percentage allocation of the agent queue.**|
|DisplayName|**Queue Allotment Percentage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_queue_allotment`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|1|

### <a name="BKMK_msdyn_reserve_agent_capacity"></a> msdyn_reserve_agent_capacity

|Property|Value|
|---|---|
|Description|**Determine whether or not Proactive Engagement should reserve agents before placing calls in certain dial modes.**|
|DisplayName|**Reserve Agent Capacity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_reserve_agent_capacity`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_proactive_engagement_config_msdyn_reserve_agent_capacity`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_throttle_adjustment_percentage"></a> msdyn_throttle_adjustment_percentage

|Property|Value|
|---|---|
|Description|**The percentage the existing rate should be adjusted up or down based on the value of the metric relative to the threshold.**|
|DisplayName|**Throttle Adjustment Percentage**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_throttle_adjustment_percentage`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|100|
|MinValue|1|

### <a name="BKMK_msdyn_throttle_control_period"></a> msdyn_throttle_control_period

|Property|Value|
|---|---|
|Description|**The number of minutes to consider when calculating the value for the metric.**|
|DisplayName|**Throttle Control Period**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_throttle_control_period`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_throttle_control_period_2"></a> msdyn_throttle_control_period_2

|Property|Value|
|---|---|
|Description|**The number of minutes to consider when calculating the value for the metric.**|
|DisplayName|**Throttle Control Period 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_throttle_control_period_2`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_throttle_metric"></a> msdyn_throttle_metric

|Property|Value|
|---|---|
|Description|**The metric that throttling should be based off of.**|
|DisplayName|**Throttle Metric**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_throttle_metric`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_proactive_engagement_config_msdyn_throttle_metric`|

#### msdyn_throttle_metric Choices/Options

|Value|Label|
|---|---|
|192360000|**Avg.  Escalation Wait Time**|
|192360001|**Escalation Count**|
|192360002|**Abandonment Rate**|
|192360003|**Open Escalation Count**|

### <a name="BKMK_msdyn_throttle_metric_2"></a> msdyn_throttle_metric_2

|Property|Value|
|---|---|
|Description|**The metric that throttling should be based off of.**|
|DisplayName|**Throttle Metric 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_throttle_metric_2`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_proactive_engagement_config_msdyn_throttle_metric_2`|

#### msdyn_throttle_metric_2 Choices/Options

|Value|Label|
|---|---|
|192360000|**Avg. Escalation Wait Time**|
|192360001|**Escalation Count**|
|192360002|**Abandonment Rate**|
|192360003|**Open Escalation Count**|

### <a name="BKMK_msdyn_throttle_threshold"></a> msdyn_throttle_threshold

|Property|Value|
|---|---|
|Description|**The threshold for the metric, if below we increment rate, if above we decrement rate.**|
|DisplayName|**Throttle Threshold**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_throttle_threshold`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_throttle_threshold_2"></a> msdyn_throttle_threshold_2

|Property|Value|
|---|---|
|Description|**The threshold for the metric, if below we increment rate, if above we decrement rate.**|
|DisplayName|**Throttle Threshold 2**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_throttle_threshold_2`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_type"></a> msdyn_type

|Property|Value|
|---|---|
|Description||
|DisplayName|**Proactive outreach type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_type`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_proactive_engagement_config_msdyn_type`|

#### msdyn_type Choices/Options

|Value|Label|
|---|---|
|100000000|**Voice**|
|100000001|**SMS**|

### <a name="BKMK_msdyn_workstream"></a> msdyn_workstream

|Property|Value|
|---|---|
|Description||
|DisplayName|**Workstream**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workstream`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_liveworkstream|

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
|Description|**Status of the Proactive Engagement Configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_proactive_engagement_config_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Proactive Engagement Configuration**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_proactive_engagement_config_statuscode`|

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

- [ComponentIdUnique](#BKMK_ComponentIdUnique)
- [ComponentState](#BKMK_ComponentState)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [IsManaged](#BKMK_IsManaged)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [OverwriteTime](#BKMK_OverwriteTime)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [SolutionId](#BKMK_SolutionId)
- [SupportingSolutionId](#BKMK_SupportingSolutionId)
- [VersionNumber](#BKMK_VersionNumber)

### <a name="BKMK_ComponentIdUnique"></a> ComponentIdUnique

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Row id unique**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentidunique`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_ComponentState"></a> ComponentState

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Component State**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`componentstate`|
|RequiredLevel|SystemRequired|
|Type|Picklist|
|DefaultFormValue||
|GlobalChoiceName|`componentstate`|

#### ComponentState Choices/Options

|Value|Label|
|---|---|
|0|**Published**|
|1|**Unpublished**|
|2|**Deleted**|
|3|**Deleted Unpublished**|

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

### <a name="BKMK_IsManaged"></a> IsManaged

|Property|Value|
|---|---|
|Description|**Indicates whether the solution component is part of a managed solution.**|
|DisplayName|**Is Managed**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`ismanaged`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`ismanaged`|
|DefaultValue|False|
|True Label|Managed|
|False Label|Unmanaged|

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

### <a name="BKMK_OverwriteTime"></a> OverwriteTime

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Record Overwrite Time**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`overwritetime`|
|RequiredLevel|SystemRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

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
|RequiredLevel|SystemRequired|
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

### <a name="BKMK_SolutionId"></a> SolutionId

|Property|Value|
|---|---|
|Description|**Unique identifier of the associated solution.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`solutionid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_SupportingSolutionId"></a> SupportingSolutionId

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Solution**|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|`supportingsolutionid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

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

- [business_unit_msdyn_proactive_engagement_config](#BKMK_business_unit_msdyn_proactive_engagement_config)
- [lk_msdyn_proactive_engagement_config_createdby](#BKMK_lk_msdyn_proactive_engagement_config_createdby)
- [lk_msdyn_proactive_engagement_config_createdonbehalfby](#BKMK_lk_msdyn_proactive_engagement_config_createdonbehalfby)
- [lk_msdyn_proactive_engagement_config_modifiedby](#BKMK_lk_msdyn_proactive_engagement_config_modifiedby)
- [lk_msdyn_proactive_engagement_config_modifiedonbehalfby](#BKMK_lk_msdyn_proactive_engagement_config_modifiedonbehalfby)
- [msdyn_liveworkstream_msdyn_proactive_engagement_config_workstream](#BKMK_msdyn_liveworkstream_msdyn_proactive_engagement_config_workstream)
- [msdyn_proactive_engagement_config_queue_queue](#BKMK_msdyn_proactive_engagement_config_queue_queue)
- [owner_msdyn_proactive_engagement_config](#BKMK_owner_msdyn_proactive_engagement_config)
- [team_msdyn_proactive_engagement_config](#BKMK_team_msdyn_proactive_engagement_config)
- [user_msdyn_proactive_engagement_config](#BKMK_user_msdyn_proactive_engagement_config)

### <a name="BKMK_business_unit_msdyn_proactive_engagement_config"></a> business_unit_msdyn_proactive_engagement_config

One-To-Many Relationship: [businessunit business_unit_msdyn_proactive_engagement_config](businessunit.md#BKMK_business_unit_msdyn_proactive_engagement_config)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_engagement_config_createdby"></a> lk_msdyn_proactive_engagement_config_createdby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_engagement_config_createdby](systemuser.md#BKMK_lk_msdyn_proactive_engagement_config_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_engagement_config_createdonbehalfby"></a> lk_msdyn_proactive_engagement_config_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_engagement_config_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_proactive_engagement_config_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_engagement_config_modifiedby"></a> lk_msdyn_proactive_engagement_config_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_engagement_config_modifiedby](systemuser.md#BKMK_lk_msdyn_proactive_engagement_config_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_proactive_engagement_config_modifiedonbehalfby"></a> lk_msdyn_proactive_engagement_config_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_proactive_engagement_config_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_proactive_engagement_config_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_liveworkstream_msdyn_proactive_engagement_config_workstream"></a> msdyn_liveworkstream_msdyn_proactive_engagement_config_workstream

One-To-Many Relationship: [msdyn_liveworkstream msdyn_liveworkstream_msdyn_proactive_engagement_config_workstream](msdyn_liveworkstream.md#BKMK_msdyn_liveworkstream_msdyn_proactive_engagement_config_workstream)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_liveworkstream`|
|ReferencedAttribute|`msdyn_liveworkstreamid`|
|ReferencingAttribute|`msdyn_workstream`|
|ReferencingEntityNavigationPropertyName|`msdyn_workstream`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_proactive_engagement_config_queue_queue"></a> msdyn_proactive_engagement_config_queue_queue

One-To-Many Relationship: [queue msdyn_proactive_engagement_config_queue_queue](queue.md#BKMK_msdyn_proactive_engagement_config_queue_queue)

|Property|Value|
|---|---|
|ReferencedEntity|`queue`|
|ReferencedAttribute|`queueid`|
|ReferencingAttribute|`msdyn_queue`|
|ReferencingEntityNavigationPropertyName|`msdyn_queue`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_proactive_engagement_config"></a> owner_msdyn_proactive_engagement_config

One-To-Many Relationship: [owner owner_msdyn_proactive_engagement_config](owner.md#BKMK_owner_msdyn_proactive_engagement_config)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_proactive_engagement_config"></a> team_msdyn_proactive_engagement_config

One-To-Many Relationship: [team team_msdyn_proactive_engagement_config](team.md#BKMK_team_msdyn_proactive_engagement_config)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_proactive_engagement_config"></a> user_msdyn_proactive_engagement_config

One-To-Many Relationship: [systemuser user_msdyn_proactive_engagement_config](systemuser.md#BKMK_user_msdyn_proactive_engagement_config)

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

- [msdyn_proactive_eng_config_characteristic_proactive_engagement_configuration_msdyn_proactive_engagem](#BKMK_msdyn_proactive_eng_config_characteristic_proactive_engagement_configuration_msdyn_proactive_engagem)
- [msdyn_proactive_engagement_config_AsyncOperations](#BKMK_msdyn_proactive_engagement_config_AsyncOperations)
- [msdyn_proactive_engagement_config_BulkDeleteFailures](#BKMK_msdyn_proactive_engagement_config_BulkDeleteFailures)
- [msdyn_proactive_engagement_config_DuplicateBaseRecord](#BKMK_msdyn_proactive_engagement_config_DuplicateBaseRecord)
- [msdyn_proactive_engagement_config_DuplicateMatchingRecord](#BKMK_msdyn_proactive_engagement_config_DuplicateMatchingRecord)
- [msdyn_proactive_engagement_config_MailboxTrackingFolders](#BKMK_msdyn_proactive_engagement_config_MailboxTrackingFolders)
- [msdyn_proactive_engagement_config_msdyn_proactive_delivery_batch](#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_delivery_batch)
- [msdyn_proactive_engagement_config_msdyn_proactive_engagement_config_attribute](#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_config_attribute)
- [msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config](#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config)
- [msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config](#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config)
- [msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses](#BKMK_msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses)
- [msdyn_proactive_engagement_config_ProcessSession](#BKMK_msdyn_proactive_engagement_config_ProcessSession)
- [msdyn_proactive_engagement_config_status_msdyn_proactive_engagement_config_msdyn_proactive](#BKMK_msdyn_proactive_engagement_config_status_msdyn_proactive_engagement_config_msdyn_proactive)
- [msdyn_proactive_engagement_config_SyncErrors](#BKMK_msdyn_proactive_engagement_config_SyncErrors)

### <a name="BKMK_msdyn_proactive_eng_config_characteristic_proactive_engagement_configuration_msdyn_proactive_engagem"></a> msdyn_proactive_eng_config_characteristic_proactive_engagement_configuration_msdyn_proactive_engagem

Many-To-One Relationship: [msdyn_proactive_eng_config_characteristic msdyn_proactive_eng_config_characteristic_proactive_engagement_configuration_msdyn_proactive_engagem](msdyn_proactive_eng_config_characteristic.md#BKMK_msdyn_proactive_eng_config_characteristic_proactive_engagement_configuration_msdyn_proactive_engagem)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_eng_config_characteristic`|
|ReferencingAttribute|`msdyn_proactive_engagement_configuration`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_eng_config_characteristic_proactive_engagement_configuration_msdyn_proactive_engagem`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_AsyncOperations"></a> msdyn_proactive_engagement_config_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_proactive_engagement_config_AsyncOperations](asyncoperation.md#BKMK_msdyn_proactive_engagement_config_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_BulkDeleteFailures"></a> msdyn_proactive_engagement_config_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_proactive_engagement_config_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_proactive_engagement_config_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_DuplicateBaseRecord"></a> msdyn_proactive_engagement_config_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_proactive_engagement_config_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_proactive_engagement_config_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_DuplicateMatchingRecord"></a> msdyn_proactive_engagement_config_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_proactive_engagement_config_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_proactive_engagement_config_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_MailboxTrackingFolders"></a> msdyn_proactive_engagement_config_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_proactive_engagement_config_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_proactive_engagement_config_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_msdyn_proactive_delivery_batch"></a> msdyn_proactive_engagement_config_msdyn_proactive_delivery_batch

Many-To-One Relationship: [msdyn_proactive_delivery_batch msdyn_proactive_engagement_config_msdyn_proactive_delivery_batch](msdyn_proactive_delivery_batch.md#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_delivery_batch)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_delivery_batch`|
|ReferencingAttribute|`msdyn_proactive_engagement_config`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_msdyn_proactive_delivery_batch`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_config_attribute"></a> msdyn_proactive_engagement_config_msdyn_proactive_engagement_config_attribute

Many-To-One Relationship: [msdyn_proactive_engagement_config_attribute msdyn_proactive_engagement_config_msdyn_proactive_engagement_config_attribute](msdyn_proactive_engagement_config_attribute.md#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_config_attribute)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config_attribute`|
|ReferencingAttribute|`msdyn_proactive_engagement_config`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_msdyn_proactive_engagement_config_attribute`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config"></a> msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config

Many-To-One Relationship: [msdyn_proactive_engagement_planner_config msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config](msdyn_proactive_engagement_planner_config.md#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_planner_config`|
|ReferencingAttribute|`msdyn_proactive_engagement_config_id`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_engagement_config`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config"></a> msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config

Many-To-One Relationship: [msdyn_proactive_engagement_planner_config msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config](msdyn_proactive_engagement_planner_config.md#BKMK_msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_planner_config`|
|ReferencingAttribute|`msdyn_fallback_engagement_config_id`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_msdyn_proactive_engagement_planner_config_fallback_engagement_config`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses"></a> msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_ProcessSession"></a> msdyn_proactive_engagement_config_ProcessSession

Many-To-One Relationship: [processsession msdyn_proactive_engagement_config_ProcessSession](processsession.md#BKMK_msdyn_proactive_engagement_config_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_status_msdyn_proactive_engagement_config_msdyn_proactive"></a> msdyn_proactive_engagement_config_status_msdyn_proactive_engagement_config_msdyn_proactive

Many-To-One Relationship: [msdyn_proactive_engagement_config_status msdyn_proactive_engagement_config_status_msdyn_proactive_engagement_config_msdyn_proactive](msdyn_proactive_engagement_config_status.md#BKMK_msdyn_proactive_engagement_config_status_msdyn_proactive_engagement_config_msdyn_proactive)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_proactive_engagement_config_status`|
|ReferencingAttribute|`msdyn_proactive_engagement_config`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_status_msdyn_proactive_engagement_config_msdyn_proactive`|
|IsCustomizable|`False`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_proactive_engagement_config_SyncErrors"></a> msdyn_proactive_engagement_config_SyncErrors

Many-To-One Relationship: [syncerror msdyn_proactive_engagement_config_SyncErrors](syncerror.md#BKMK_msdyn_proactive_engagement_config_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_proactive_engagement_config_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

