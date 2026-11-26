---
title: "Optimization Plan (msdyn_schedulingoptimizationplan) table/entity reference (Microsoft Dynamics 365 Customer Service)"
description: "Includes schema information and supported messages for the Optimization Plan (msdyn_schedulingoptimizationplan) table/entity with Microsoft Dynamics 365 Customer Service."
ms.topic: generated-reference
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - developer
---

# Optimization Plan (msdyn_schedulingoptimizationplan) table/entity reference (Microsoft Dynamics 365 Customer Service)



## Messages

The following table lists the messages for the Optimization Plan (msdyn_schedulingoptimizationplan) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_schedulingoptimizationplans(*msdyn_schedulingoptimizationplanid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_schedulingoptimizationplans<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_schedulingoptimizationplans(*msdyn_schedulingoptimizationplanid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_schedulingoptimizationplans(*msdyn_schedulingoptimizationplanid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_schedulingoptimizationplans<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_schedulingoptimizationplans(*msdyn_schedulingoptimizationplanid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_schedulingoptimizationplans(*msdyn_schedulingoptimizationplanid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_schedulingoptimizationplans(*msdyn_schedulingoptimizationplanid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Optimization Plan (msdyn_schedulingoptimizationplan) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Optimization Plan** |
| **DisplayCollectionName** | **Optimization Plans** |
| **SchemaName** | `msdyn_schedulingoptimizationplan` |
| **CollectionSchemaName** | `msdyn_schedulingoptimizationplans` |
| **EntitySetName** | `msdyn_schedulingoptimizationplans`|
| **LogicalName** | `msdyn_schedulingoptimizationplan` |
| **LogicalCollectionName** | `msdyn_schedulingoptimizationplans` |
| **PrimaryIdAttribute** | `msdyn_schedulingoptimizationplanid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_Applymethod](#BKMK_msdyn_Applymethod)
- [msdyn_ConsecutiveFailureCount](#BKMK_msdyn_ConsecutiveFailureCount)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_IsScheduled](#BKMK_msdyn_IsScheduled)
- [msdyn_LastRunTime](#BKMK_msdyn_LastRunTime)
- [msdyn_Name](#BKMK_msdyn_Name)
- [msdyn_NextRunTime](#BKMK_msdyn_NextRunTime)
- [msdyn_optimizationRangeFixedStart](#BKMK_msdyn_optimizationRangeFixedStart)
- [msdyn_PlanStatus](#BKMK_msdyn_PlanStatus)
- [msdyn_Rangeduration](#BKMK_msdyn_Rangeduration)
- [msdyn_Rangeoffset](#BKMK_msdyn_Rangeoffset)
- [msdyn_Rangereference](#BKMK_msdyn_Rangereference)
- [msdyn_RecurrenceFrequency](#BKMK_msdyn_RecurrenceFrequency)
- [msdyn_RecurrenceHours](#BKMK_msdyn_RecurrenceHours)
- [msdyn_RecurrenceInterval](#BKMK_msdyn_RecurrenceInterval)
- [msdyn_RecurrenceMinutes](#BKMK_msdyn_RecurrenceMinutes)
- [msdyn_RecurrenceStartTime](#BKMK_msdyn_RecurrenceStartTime)
- [msdyn_RecurrenceTimeZone](#BKMK_msdyn_RecurrenceTimeZone)
- [msdyn_RecurrenceWeekDays](#BKMK_msdyn_RecurrenceWeekDays)
- [msdyn_ScheduleValidTo](#BKMK_msdyn_ScheduleValidTo)
- [msdyn_schedulinggoal](#BKMK_msdyn_schedulinggoal)
- [msdyn_schedulingoptimizationplanId](#BKMK_msdyn_schedulingoptimizationplanId)
- [msdyn_SchedulingScope](#BKMK_msdyn_SchedulingScope)
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

### <a name="BKMK_msdyn_Applymethod"></a> msdyn_Applymethod

|Property|Value|
|---|---|
|Description|**Specifies the method for applying the optimization plan**|
|DisplayName|**Apply method**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_applymethod`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|859530000|
|GlobalChoiceName|`msdyn_applymethod`|

#### msdyn_Applymethod Choices/Options

|Value|Label|
|---|---|
|859530000|**Review before apply**|
|859530001|**Apply automatically**|

### <a name="BKMK_msdyn_ConsecutiveFailureCount"></a> msdyn_ConsecutiveFailureCount

|Property|Value|
|---|---|
|Description|**Tracks consecutive failed scheduled runs. Incremented on Failed OR, reset to 0 on Applied/Skipped. When >= 5, Tier 3 auto-pause fires.**|
|DisplayName|**Consecutive Failure Count**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_consecutivefailurecount`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description||
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_IsScheduled"></a> msdyn_IsScheduled

|Property|Value|
|---|---|
|Description|**Enables or disables the recurrence schedule for this optimization plan.**|
|DisplayName|**Recurrence**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isscheduled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_schedulingoptimizationplan_msdyn_isscheduled`|
|DefaultValue|False|
|True Label|On|
|False Label|Off|

### <a name="BKMK_msdyn_LastRunTime"></a> msdyn_LastRunTime

|Property|Value|
|---|---|
|Description|**Timestamp of the most recent scheduled optimization run (stored in UTC).**|
|DisplayName|**Last Run Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastruntime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_Name"></a> msdyn_Name

|Property|Value|
|---|---|
|Description||
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
|MaxLength|850|

### <a name="BKMK_msdyn_NextRunTime"></a> msdyn_NextRunTime

|Property|Value|
|---|---|
|Description|**Calculated next execution time for the recurrence (stored in UTC). Source of truth is the background scheduler; this field is informational for the UI.**|
|DisplayName|**Next Run Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextruntime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_optimizationRangeFixedStart"></a> msdyn_optimizationRangeFixedStart

|Property|Value|
|---|---|
|Description|**Absolute datetime to use as the fixed start of the optimization range, overriding the calculated offset when set**|
|DisplayName|**Optimization Range Fixed Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_optimizationrangefixedstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_PlanStatus"></a> msdyn_PlanStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Plan Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_planstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|0|
|GlobalChoiceName|`msdyn_schedulingoptimizationplan_msdyn_planstatus`|

#### msdyn_PlanStatus Choices/Options

|Value|Label|
|---|---|
|0|**Ready**|
|1|**Running**|
|2|**Following schedule**|
|3|**Error**|

### <a name="BKMK_msdyn_Rangeduration"></a> msdyn_Rangeduration

|Property|Value|
|---|---|
|Description|**Duration in minutes for the time range**|
|DisplayName|**Range duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rangeduration`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|20160|
|MinValue|60|

### <a name="BKMK_msdyn_Rangeoffset"></a> msdyn_Rangeoffset

|Property|Value|
|---|---|
|Description|**Offset in minutes from the reference point**|
|DisplayName|**Range offset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rangeoffset`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|259200|
|MinValue|5|

### <a name="BKMK_msdyn_Rangereference"></a> msdyn_Rangereference

|Property|Value|
|---|---|
|Description|**Reference point for calculating the time range**|
|DisplayName|**Range reference**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rangereference`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|859530000|
|GlobalChoiceName|`msdyn_rangereference`|

#### msdyn_Rangereference Choices/Options

|Value|Label|
|---|---|
|859530000|**Optimization start time**|
|859530001|**Beginning of optimization's current day**|

### <a name="BKMK_msdyn_RecurrenceFrequency"></a> msdyn_RecurrenceFrequency

|Property|Value|
|---|---|
|Description|**Recurrence unit applied to the Interval (Minute, Hour, Day, Week, or Month). Maps to Jobs f/x unit field.**|
|DisplayName|**Frequency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrencefrequency`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|859530002|
|GlobalChoiceName|`msdyn_schedulingoptimizationplan_msdyn_recurrencefrequency`|

#### msdyn_RecurrenceFrequency Choices/Options

|Value|Label|
|---|---|
|859530000|**Minute**|
|859530001|**Hour**|
|859530002|**Day**|
|859530003|**Week**|
|859530004|**Month**|

### <a name="BKMK_msdyn_RecurrenceHours"></a> msdyn_RecurrenceHours

|Property|Value|
|---|---|
|Description|**Hours at which to run**|
|DisplayName|**At These Hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrencehours`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_schedulingoptimizationplan_msdyn_recurrencehours`|

#### msdyn_RecurrenceHours Choices/Options

|Value|Label|
|---|---|
|0|**0**|
|1|**1**|
|2|**2**|
|3|**3**|
|4|**4**|
|5|**5**|
|6|**6**|
|7|**7**|
|8|**8**|
|9|**9**|
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

### <a name="BKMK_msdyn_RecurrenceInterval"></a> msdyn_RecurrenceInterval

|Property|Value|
|---|---|
|Description|**Every X intervals (e.g., every 2 weeks). Min = 1. Max depends on frequency (Minute<=1440, Hour<=168, Day<=365, Week<=52, Month<=24); per-frequency cap enforced by client script and server plugin.**|
|DisplayName|**Interval**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrenceinterval`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_RecurrenceMinutes"></a> msdyn_RecurrenceMinutes

|Property|Value|
|---|---|
|Description|**Minutes within each hour at which to run. Only 15-minute increments allowed (0, 15, 30, 45). Default applied at enable time: \[0\] if empty.**|
|DisplayName|**At These Minutes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrenceminutes`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_schedulingoptimizationplan_msdyn_recurrenceminutes`|

#### msdyn_RecurrenceMinutes Choices/Options

|Value|Label|
|---|---|
|0|**0**|
|1|**1**|
|2|**2**|
|3|**3**|
|4|**4**|
|5|**5**|
|6|**6**|
|7|**7**|
|8|**8**|
|9|**9**|
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
|24|**24**|
|25|**25**|
|26|**26**|
|27|**27**|
|28|**28**|
|29|**29**|
|30|**30**|
|31|**31**|
|32|**32**|
|33|**33**|
|34|**34**|
|35|**35**|
|36|**36**|
|37|**37**|
|38|**38**|
|39|**39**|
|40|**40**|
|41|**41**|
|42|**42**|
|43|**43**|
|44|**44**|
|45|**45**|
|46|**46**|
|47|**47**|
|48|**48**|
|49|**49**|
|50|**50**|
|51|**51**|
|52|**52**|
|53|**53**|
|54|**54**|
|55|**55**|
|56|**56**|
|57|**57**|
|58|**58**|
|59|**59**|

### <a name="BKMK_msdyn_RecurrenceStartTime"></a> msdyn_RecurrenceStartTime

|Property|Value|
|---|---|
|Description|**Date and time the recurrence becomes active. For Minute and Hour frequencies this is the recurrence anchor; for Day, Week, and Month frequencies this is a 'no earlier than' boundary. If in the past when enabled, runs begin from current time (no backfill). Stored in UTC, displayed in the selected time zone.**|
|DisplayName|**Valid From**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrencestarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_RecurrenceTimeZone"></a> msdyn_RecurrenceTimeZone

|Property|Value|
|---|---|
|Description|**Dataverse timezone code (OOB timezone OptionSet) in which the recurrence is interpreted. Values are stored canonically in UTC.**|
|DisplayName|**Time Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrencetimezone`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1|

### <a name="BKMK_msdyn_RecurrenceWeekDays"></a> msdyn_RecurrenceWeekDays

|Property|Value|
|---|---|
|Description|**Days of the week on which to run when frequency is Week. At least one day must be selected when weekly recurrence is enabled.**|
|DisplayName|**On These Days**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrenceweekdays`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_schedulingoptimizationplan_msdyn_recurrenceweekdays`|

#### msdyn_RecurrenceWeekDays Choices/Options

|Value|Label|
|---|---|
|1|**Monday**|
|2|**Tuesday**|
|3|**Wednesday**|
|4|**Thursday**|
|5|**Friday**|
|6|**Saturday**|
|7|**Sunday**|

### <a name="BKMK_msdyn_ScheduleValidTo"></a> msdyn_ScheduleValidTo

|Property|Value|
|---|---|
|Description|**Optional date and time after which the recurrence is automatically disabled. Must be after Valid From if set. Stored in UTC, displayed in the selected time zone.**|
|DisplayName|**Valid To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulevalidto`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_schedulinggoal"></a> msdyn_schedulinggoal

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduling Goal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulinggoal`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_schedulinggoal|

### <a name="BKMK_msdyn_schedulingoptimizationplanId"></a> msdyn_schedulingoptimizationplanId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Optimization Plan**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulingoptimizationplanid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_SchedulingScope"></a> msdyn_SchedulingScope

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduling Scope**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulingscope`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_schedulingscope|

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
|Description|**Status of the Optimization Plan**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_schedulingoptimizationplan_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Optimization Plan**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_schedulingoptimizationplan_statuscode`|

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

- [business_unit_msdyn_schedulingoptimizationplan](#BKMK_business_unit_msdyn_schedulingoptimizationplan)
- [lk_msdyn_schedulingoptimizationplan_createdby](#BKMK_lk_msdyn_schedulingoptimizationplan_createdby)
- [lk_msdyn_schedulingoptimizationplan_createdonbehalfby](#BKMK_lk_msdyn_schedulingoptimizationplan_createdonbehalfby)
- [lk_msdyn_schedulingoptimizationplan_modifiedby](#BKMK_lk_msdyn_schedulingoptimizationplan_modifiedby)
- [lk_msdyn_schedulingoptimizationplan_modifiedonbehalfby](#BKMK_lk_msdyn_schedulingoptimizationplan_modifiedonbehalfby)
- [msdyn_schedulingoptimizationplan_schedulinggoal_msdyn_schedulinggoal](#BKMK_msdyn_schedulingoptimizationplan_schedulinggoal_msdyn_schedulinggoal)
- [msdyn_schedulingoptimizationplan_schedulingscope_msdyn_schedulingscope](#BKMK_msdyn_schedulingoptimizationplan_schedulingscope_msdyn_schedulingscope)
- [owner_msdyn_schedulingoptimizationplan](#BKMK_owner_msdyn_schedulingoptimizationplan)
- [team_msdyn_schedulingoptimizationplan](#BKMK_team_msdyn_schedulingoptimizationplan)
- [user_msdyn_schedulingoptimizationplan](#BKMK_user_msdyn_schedulingoptimizationplan)

### <a name="BKMK_business_unit_msdyn_schedulingoptimizationplan"></a> business_unit_msdyn_schedulingoptimizationplan

One-To-Many Relationship: [businessunit business_unit_msdyn_schedulingoptimizationplan](businessunit.md#BKMK_business_unit_msdyn_schedulingoptimizationplan)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_schedulingoptimizationplan_createdby"></a> lk_msdyn_schedulingoptimizationplan_createdby

One-To-Many Relationship: [systemuser lk_msdyn_schedulingoptimizationplan_createdby](systemuser.md#BKMK_lk_msdyn_schedulingoptimizationplan_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_schedulingoptimizationplan_createdonbehalfby"></a> lk_msdyn_schedulingoptimizationplan_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_schedulingoptimizationplan_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_schedulingoptimizationplan_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_schedulingoptimizationplan_modifiedby"></a> lk_msdyn_schedulingoptimizationplan_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_schedulingoptimizationplan_modifiedby](systemuser.md#BKMK_lk_msdyn_schedulingoptimizationplan_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_schedulingoptimizationplan_modifiedonbehalfby"></a> lk_msdyn_schedulingoptimizationplan_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_schedulingoptimizationplan_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_schedulingoptimizationplan_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingoptimizationplan_schedulinggoal_msdyn_schedulinggoal"></a> msdyn_schedulingoptimizationplan_schedulinggoal_msdyn_schedulinggoal

One-To-Many Relationship: [msdyn_schedulinggoal msdyn_schedulingoptimizationplan_schedulinggoal_msdyn_schedulinggoal](msdyn_schedulinggoal.md#BKMK_msdyn_schedulingoptimizationplan_schedulinggoal_msdyn_schedulinggoal)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulinggoal`|
|ReferencedAttribute|`msdyn_schedulinggoalid`|
|ReferencingAttribute|`msdyn_schedulinggoal`|
|ReferencingEntityNavigationPropertyName|`msdyn_schedulinggoal`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_schedulingoptimizationplan_schedulingscope_msdyn_schedulingscope"></a> msdyn_schedulingoptimizationplan_schedulingscope_msdyn_schedulingscope

One-To-Many Relationship: [msdyn_schedulingscope msdyn_schedulingoptimizationplan_schedulingscope_msdyn_schedulingscope](msdyn_schedulingscope.md#BKMK_msdyn_schedulingoptimizationplan_schedulingscope_msdyn_schedulingscope)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_schedulingscope`|
|ReferencedAttribute|`msdyn_schedulingscopeid`|
|ReferencingAttribute|`msdyn_schedulingscope`|
|ReferencingEntityNavigationPropertyName|`msdyn_SchedulingScope`|
|IsHierarchical||
|CascadeConfiguration|Archive: `RemoveLink`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_schedulingoptimizationplan"></a> owner_msdyn_schedulingoptimizationplan

One-To-Many Relationship: [owner owner_msdyn_schedulingoptimizationplan](owner.md#BKMK_owner_msdyn_schedulingoptimizationplan)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_schedulingoptimizationplan"></a> team_msdyn_schedulingoptimizationplan

One-To-Many Relationship: [team team_msdyn_schedulingoptimizationplan](team.md#BKMK_team_msdyn_schedulingoptimizationplan)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_schedulingoptimizationplan"></a> user_msdyn_schedulingoptimizationplan

One-To-Many Relationship: [systemuser user_msdyn_schedulingoptimizationplan](systemuser.md#BKMK_user_msdyn_schedulingoptimizationplan)

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

- [msdyn_schedulingoptimizationplan_AsyncOperations](#BKMK_msdyn_schedulingoptimizationplan_AsyncOperations)
- [msdyn_schedulingoptimizationplan_BulkDeleteFailures](#BKMK_msdyn_schedulingoptimizationplan_BulkDeleteFailures)
- [msdyn_schedulingoptimizationplan_MailboxTrackingFolders](#BKMK_msdyn_schedulingoptimizationplan_MailboxTrackingFolders)
- [msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest](#BKMK_msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest)
- [msdyn_schedulingoptimizationplan_PrincipalObjectAttributeAccesses](#BKMK_msdyn_schedulingoptimizationplan_PrincipalObjectAttributeAccesses)
- [msdyn_schedulingoptimizationplan_ProcessSession](#BKMK_msdyn_schedulingoptimizationplan_ProcessSession)
- [msdyn_schedulingoptimizationplan_SyncErrors](#BKMK_msdyn_schedulingoptimizationplan_SyncErrors)

### <a name="BKMK_msdyn_schedulingoptimizationplan_AsyncOperations"></a> msdyn_schedulingoptimizationplan_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_schedulingoptimizationplan_AsyncOperations](asyncoperation.md#BKMK_msdyn_schedulingoptimizationplan_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingoptimizationplan_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_schedulingoptimizationplan_BulkDeleteFailures"></a> msdyn_schedulingoptimizationplan_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_schedulingoptimizationplan_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_schedulingoptimizationplan_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingoptimizationplan_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_schedulingoptimizationplan_MailboxTrackingFolders"></a> msdyn_schedulingoptimizationplan_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_schedulingoptimizationplan_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_schedulingoptimizationplan_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingoptimizationplan_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest"></a> msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest

Many-To-One Relationship: [msdyn_optimizationrequest msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest](msdyn_optimizationrequest.md#BKMK_msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_optimizationrequest`|
|ReferencingAttribute|`msdyn_schedulingoptimizationplan`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingoptimizationplan_optimizationrequest_msdyn_optimizationrequest`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_schedulingoptimizationplan_PrincipalObjectAttributeAccesses"></a> msdyn_schedulingoptimizationplan_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_schedulingoptimizationplan_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_schedulingoptimizationplan_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingoptimizationplan_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_schedulingoptimizationplan_ProcessSession"></a> msdyn_schedulingoptimizationplan_ProcessSession

Many-To-One Relationship: [processsession msdyn_schedulingoptimizationplan_ProcessSession](processsession.md#BKMK_msdyn_schedulingoptimizationplan_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingoptimizationplan_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_schedulingoptimizationplan_SyncErrors"></a> msdyn_schedulingoptimizationplan_SyncErrors

Many-To-One Relationship: [syncerror msdyn_schedulingoptimizationplan_SyncErrors](syncerror.md#BKMK_msdyn_schedulingoptimizationplan_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_schedulingoptimizationplan_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

