---
title: "Optimization Schedule (msdyn_routingprofileconfiguration) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Optimization Schedule (msdyn_routingprofileconfiguration) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 07.24.2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Optimization Schedule (msdyn_routingprofileconfiguration) table/entity reference

Plan for carrying out recurring resource scheduling optimization executions.

## Messages

The following table lists the messages for the Optimization Schedule (msdyn_routingprofileconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_routingprofileconfigurations(*msdyn_routingprofileconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_routingprofileconfigurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_routingprofileconfigurations(*msdyn_routingprofileconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_routingprofileconfigurations(*msdyn_routingprofileconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_routingprofileconfigurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_routingprofileconfigurations(*msdyn_routingprofileconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_routingprofileconfigurations(*msdyn_routingprofileconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_routingprofileconfigurations(*msdyn_routingprofileconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Optimization Schedule (msdyn_routingprofileconfiguration) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Optimization Schedule (msdyn_routingprofileconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Optimization Schedule** |
| **DisplayCollectionName** | **Optimization Schedules** |
| **SchemaName** | `msdyn_routingprofileconfiguration` |
| **CollectionSchemaName** | `msdyn_routingprofileconfigurations` |
| **EntitySetName** | `msdyn_routingprofileconfigurations`|
| **LogicalName** | `msdyn_routingprofileconfiguration` |
| **LogicalCollectionName** | `msdyn_routingprofileconfigurations` |
| **PrimaryIdAttribute** | `msdyn_routingprofileconfigurationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_daysofmonth](#BKMK_msdyn_daysofmonth)
- [msdyn_daysofweek](#BKMK_msdyn_daysofweek)
- [msdyn_EngineConfiguration](#BKMK_msdyn_EngineConfiguration)
- [msdyn_errormessage](#BKMK_msdyn_errormessage)
- [msdyn_FilterTimeZone](#BKMK_msdyn_FilterTimeZone)
- [msdyn_hours](#BKMK_msdyn_hours)
- [msdyn_Interval](#BKMK_msdyn_Interval)
- [msdyn_IntervalFrom](#BKMK_msdyn_IntervalFrom)
- [msdyn_JobConfiguration](#BKMK_msdyn_JobConfiguration)
- [msdyn_minutes](#BKMK_msdyn_minutes)
- [msdyn_months](#BKMK_msdyn_months)
- [msdyn_multiselectdaysofmonth](#BKMK_msdyn_multiselectdaysofmonth)
- [msdyn_multiselectdaysofweek](#BKMK_msdyn_multiselectdaysofweek)
- [msdyn_multiselecthours](#BKMK_msdyn_multiselecthours)
- [msdyn_multiselectminutes](#BKMK_msdyn_multiselectminutes)
- [msdyn_multiselectmonths](#BKMK_msdyn_multiselectmonths)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_NextScheduledRunAt](#BKMK_msdyn_NextScheduledRunAt)
- [msdyn_publishdate](#BKMK_msdyn_publishdate)
- [msdyn_routingprofileconfigurationId](#BKMK_msdyn_routingprofileconfigurationId)
- [msdyn_runassimulation](#BKMK_msdyn_runassimulation)
- [msdyn_status](#BKMK_msdyn_status)
- [msdyn_ValidTimeFrom](#BKMK_msdyn_ValidTimeFrom)
- [msdyn_ValidTimeTo](#BKMK_msdyn_ValidTimeTo)
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

### <a name="BKMK_msdyn_daysofmonth"></a> msdyn_daysofmonth

|Property|Value|
|---|---|
|Description|**Days of the month a schedule will run. (Deprecated)**|
|DisplayName|**Days of Month (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_daysofmonth`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_daysofweek"></a> msdyn_daysofweek

|Property|Value|
|---|---|
|Description|**Days of the week that resource scheduling optimization will run. (Deprecated)**|
|DisplayName|**Days of Week (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_daysofweek`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_EngineConfiguration"></a> msdyn_EngineConfiguration

|Property|Value|
|---|---|
|Description|**Set of objectives and constraints that the resource scheduling optimization will target when running a job.**|
|DisplayName|**Goal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_engineconfiguration`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_routingengineconfiguration|

### <a name="BKMK_msdyn_errormessage"></a> msdyn_errormessage

|Property|Value|
|---|---|
|Description|**Contains the error details from publishing.**|
|DisplayName|**Error Details**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errormessage`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_FilterTimeZone"></a> msdyn_FilterTimeZone

|Property|Value|
|---|---|
|Description|**Specifies the time zone for the schedule's filter.**|
|DisplayName|**Filter Time Zone**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_filtertimezone`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|1500|
|MinValue|-1500|

### <a name="BKMK_msdyn_hours"></a> msdyn_hours

|Property|Value|
|---|---|
|Description|**Hours on which a schedule will run. (Deprecated)**|
|DisplayName|**Hours (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hours`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_Interval"></a> msdyn_Interval

|Property|Value|
|---|---|
|Description|**How frequently a schedule will run. Execution times also depend on the selected timer mode.**|
|DisplayName|**Timer**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_interval`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_IntervalFrom"></a> msdyn_IntervalFrom

|Property|Value|
|---|---|
|Description|**Reference point from when the schedule will start the defined timer.**|
|DisplayName|**Timer Mode**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_intervalfrom`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350001|
|GlobalChoiceName|`msdyn_routingprofileconfiguration_msdyn_intervalfrom`|

#### msdyn_IntervalFrom Choices/Options

|Value|Label|
|---|---|
|192350000|**Fixed**|
|192350001|**After Job Completion**|

### <a name="BKMK_msdyn_JobConfiguration"></a> msdyn_JobConfiguration

|Property|Value|
|---|---|
|Description|**Set of resource requirements that the resource scheduling optimization will optimize when running a job.**|
|DisplayName|**Scope**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_jobconfiguration`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_routingjobconfiguration|

### <a name="BKMK_msdyn_minutes"></a> msdyn_minutes

|Property|Value|
|---|---|
|Description|**Minutes on which a schedule will run. (Deprecated)**|
|DisplayName|**Minutes (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_minutes`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_months"></a> msdyn_months

|Property|Value|
|---|---|
|Description|**Months in which a schedule will run. (Deprecated)**|
|DisplayName|**Months (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_months`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_multiselectdaysofmonth"></a> msdyn_multiselectdaysofmonth

|Property|Value|
|---|---|
|Description|**Days of the month a schedule will run.**|
|DisplayName|**Days Of Month**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_multiselectdaysofmonth`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_daysofmonth`|

#### msdyn_multiselectdaysofmonth Choices/Options

|Value|Label|
|---|---|
|0|**1st**|
|1|**2nd**|
|2|**3rd**|
|3|**4th**|
|4|**5th**|
|5|**6th**|
|6|**7th**|
|7|**8th**|
|8|**9th**|
|9|**10th**|
|10|**11th**|
|11|**12th**|
|12|**13th**|
|13|**14th**|
|14|**15th**|
|15|**16th**|
|16|**17th**|
|17|**18th**|
|18|**19th**|
|19|**20th**|
|20|**21st**|
|21|**22nd**|
|22|**23rd**|
|23|**24th**|
|24|**25th**|
|25|**26th**|
|26|**27th**|
|27|**28th**|
|28|**29th**|
|29|**30th**|
|30|**31st**|

### <a name="BKMK_msdyn_multiselectdaysofweek"></a> msdyn_multiselectdaysofweek

|Property|Value|
|---|---|
|Description|**Days of the week that resource scheduling optimization will run.**|
|DisplayName|**Days Of Week**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_multiselectdaysofweek`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_daysofweek`|

#### msdyn_multiselectdaysofweek Choices/Options

|Value|Label|
|---|---|
|0|**Monday**|
|1|**Tuesday**|
|2|**Wednesday**|
|3|**Thursday**|
|4|**Friday**|
|5|**Saturday**|
|6|**Sunday**|

### <a name="BKMK_msdyn_multiselecthours"></a> msdyn_multiselecthours

|Property|Value|
|---|---|
|Description|**Hours on which a schedule will run.**|
|DisplayName|**Hours**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_multiselecthours`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_hours`|

#### msdyn_multiselecthours Choices/Options

|Value|Label|
|---|---|
|0|**12:00 AM**|
|1|**1:00 AM**|
|2|**2:00 AM**|
|3|**3:00 AM**|
|4|**4:00 AM**|
|5|**5:00 AM**|
|6|**6:00 AM**|
|7|**7:00 AM**|
|8|**8:00 AM**|
|9|**9:00 AM**|
|10|**10:00 AM**|
|11|**11:00 AM**|
|12|**12:00 PM**|
|13|**1:00 PM**|
|14|**2:00 PM**|
|15|**3:00 PM**|
|16|**4:00 PM**|
|17|**5:00 PM**|
|18|**6:00 PM**|
|19|**7:00 PM**|
|20|**8:00 PM**|
|21|**9:00 PM**|
|22|**10:00 PM**|
|23|**11:00 PM**|

### <a name="BKMK_msdyn_multiselectminutes"></a> msdyn_multiselectminutes

|Property|Value|
|---|---|
|Description|**Minutes on which a schedule will run.**|
|DisplayName|**Minutes**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_multiselectminutes`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_minutes`|

#### msdyn_multiselectminutes Choices/Options

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

### <a name="BKMK_msdyn_multiselectmonths"></a> msdyn_multiselectmonths

|Property|Value|
|---|---|
|Description|**Months in which a schedule will run.**|
|DisplayName|**Months**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_multiselectmonths`|
|RequiredLevel|None|
|Type|MultiSelectPicklist|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_months`|

#### msdyn_multiselectmonths Choices/Options

|Value|Label|
|---|---|
|0|**January**|
|1|**February**|
|2|**March**|
|3|**April**|
|4|**May**|
|5|**June**|
|6|**July**|
|7|**August**|
|8|**September**|
|9|**October**|
|10|**November**|
|11|**December**|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Name of a schedule.**|
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

### <a name="BKMK_msdyn_NextScheduledRunAt"></a> msdyn_NextScheduledRunAt

|Property|Value|
|---|---|
|Description|**Next scheduled run time, based on the schedule frequency that is set up, but that is not guaranteed due to potential conflicts and timer settings.**|
|DisplayName|**Next Scheduled Run At**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_nextscheduledrunat`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_publishdate"></a> msdyn_publishdate

|Property|Value|
|---|---|
|Description|**Last date and time a schedule was published.**|
|DisplayName|**Last Publish Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_publishdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_routingprofileconfigurationId"></a> msdyn_routingprofileconfigurationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Scheduling Optimization Profile Configuration**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_routingprofileconfigurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_runassimulation"></a> msdyn_runassimulation

|Property|Value|
|---|---|
|Description|**Select if the optimization should be run as simulation.**|
|DisplayName|**Run as simulation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_runassimulation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_routingprofileconfiguration_msdyn_runassimulation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_status"></a> msdyn_status

|Property|Value|
|---|---|
|Description|**Status of this schedule.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_status`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_routingprofileconfiguration_msdyn_status`|

#### msdyn_status Choices/Options

|Value|Label|
|---|---|
|192350000|**Unpublished**|
|192350001|**Publishing**|
|192350002|**Published**|
|192350003|**Failed**|
|192350004|**Out of Sync**|
|192350005|**Under Maintenance**|
|192350006|**Unpublishing**|

### <a name="BKMK_msdyn_ValidTimeFrom"></a> msdyn_ValidTimeFrom

|Property|Value|
|---|---|
|Description|**First date and time when a schedule can run.**|
|DisplayName|**Valid From**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validtimefrom`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_ValidTimeTo"></a> msdyn_ValidTimeTo

|Property|Value|
|---|---|
|Description|**Last date and time when a schedule will run.**|
|DisplayName|**Valid To**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_validtimeto`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

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
|Description|**Status of the scheduling optimization profile configuration.**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_routingprofileconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of a scheduling optimization profile configuration.**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_routingprofileconfiguration_statuscode`|

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

- [business_unit_msdyn_routingprofileconfiguration](#BKMK_business_unit_msdyn_routingprofileconfiguration)
- [lk_msdyn_routingprofileconfiguration_createdby](#BKMK_lk_msdyn_routingprofileconfiguration_createdby)
- [lk_msdyn_routingprofileconfiguration_createdonbehalfby](#BKMK_lk_msdyn_routingprofileconfiguration_createdonbehalfby)
- [lk_msdyn_routingprofileconfiguration_modifiedby](#BKMK_lk_msdyn_routingprofileconfiguration_modifiedby)
- [lk_msdyn_routingprofileconfiguration_modifiedonbehalfby](#BKMK_lk_msdyn_routingprofileconfiguration_modifiedonbehalfby)
- [msdyn_msdyn_routingengineconfiguration_msdyn_routingprofileconfiguration_EngineConfiguration](#BKMK_msdyn_msdyn_routingengineconfiguration_msdyn_routingprofileconfiguration_EngineConfiguration)
- [msdyn_msdyn_routingjobconfiguration_msdyn_routingprofileconfiguration_JobConfiguration](#BKMK_msdyn_msdyn_routingjobconfiguration_msdyn_routingprofileconfiguration_JobConfiguration)
- [owner_msdyn_routingprofileconfiguration](#BKMK_owner_msdyn_routingprofileconfiguration)
- [team_msdyn_routingprofileconfiguration](#BKMK_team_msdyn_routingprofileconfiguration)
- [user_msdyn_routingprofileconfiguration](#BKMK_user_msdyn_routingprofileconfiguration)

### <a name="BKMK_business_unit_msdyn_routingprofileconfiguration"></a> business_unit_msdyn_routingprofileconfiguration

One-To-Many Relationship: [businessunit business_unit_msdyn_routingprofileconfiguration](businessunit.md#BKMK_business_unit_msdyn_routingprofileconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_routingprofileconfiguration_createdby"></a> lk_msdyn_routingprofileconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msdyn_routingprofileconfiguration_createdby](systemuser.md#BKMK_lk_msdyn_routingprofileconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_routingprofileconfiguration_createdonbehalfby"></a> lk_msdyn_routingprofileconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_routingprofileconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_routingprofileconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_routingprofileconfiguration_modifiedby"></a> lk_msdyn_routingprofileconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_routingprofileconfiguration_modifiedby](systemuser.md#BKMK_lk_msdyn_routingprofileconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_routingprofileconfiguration_modifiedonbehalfby"></a> lk_msdyn_routingprofileconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_routingprofileconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_routingprofileconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_routingengineconfiguration_msdyn_routingprofileconfiguration_EngineConfiguration"></a> msdyn_msdyn_routingengineconfiguration_msdyn_routingprofileconfiguration_EngineConfiguration

One-To-Many Relationship: [msdyn_routingengineconfiguration msdyn_msdyn_routingengineconfiguration_msdyn_routingprofileconfiguration_EngineConfiguration](msdyn_routingengineconfiguration.md#BKMK_msdyn_msdyn_routingengineconfiguration_msdyn_routingprofileconfiguration_EngineConfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_routingengineconfiguration`|
|ReferencedAttribute|`msdyn_routingengineconfigurationid`|
|ReferencingAttribute|`msdyn_engineconfiguration`|
|ReferencingEntityNavigationPropertyName|`msdyn_EngineConfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_routingjobconfiguration_msdyn_routingprofileconfiguration_JobConfiguration"></a> msdyn_msdyn_routingjobconfiguration_msdyn_routingprofileconfiguration_JobConfiguration

One-To-Many Relationship: [msdyn_routingjobconfiguration msdyn_msdyn_routingjobconfiguration_msdyn_routingprofileconfiguration_JobConfiguration](msdyn_routingjobconfiguration.md#BKMK_msdyn_msdyn_routingjobconfiguration_msdyn_routingprofileconfiguration_JobConfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_routingjobconfiguration`|
|ReferencedAttribute|`msdyn_routingjobconfigurationid`|
|ReferencingAttribute|`msdyn_jobconfiguration`|
|ReferencingEntityNavigationPropertyName|`msdyn_JobConfiguration`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_routingprofileconfiguration"></a> owner_msdyn_routingprofileconfiguration

One-To-Many Relationship: [owner owner_msdyn_routingprofileconfiguration](owner.md#BKMK_owner_msdyn_routingprofileconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_routingprofileconfiguration"></a> team_msdyn_routingprofileconfiguration

One-To-Many Relationship: [team team_msdyn_routingprofileconfiguration](team.md#BKMK_team_msdyn_routingprofileconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_routingprofileconfiguration"></a> user_msdyn_routingprofileconfiguration

One-To-Many Relationship: [systemuser user_msdyn_routingprofileconfiguration](systemuser.md#BKMK_user_msdyn_routingprofileconfiguration)

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

- [msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule](#BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule)
- [msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source](#BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source)
- [msdyn_routingprofileconfiguration_AsyncOperations](#BKMK_msdyn_routingprofileconfiguration_AsyncOperations)
- [msdyn_routingprofileconfiguration_BulkDeleteFailures](#BKMK_msdyn_routingprofileconfiguration_BulkDeleteFailures)
- [msdyn_routingprofileconfiguration_DuplicateBaseRecord](#BKMK_msdyn_routingprofileconfiguration_DuplicateBaseRecord)
- [msdyn_routingprofileconfiguration_DuplicateMatchingRecord](#BKMK_msdyn_routingprofileconfiguration_DuplicateMatchingRecord)
- [msdyn_routingprofileconfiguration_MailboxTrackingFolders](#BKMK_msdyn_routingprofileconfiguration_MailboxTrackingFolders)
- [msdyn_routingprofileconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_routingprofileconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_routingprofileconfiguration_ProcessSession](#BKMK_msdyn_routingprofileconfiguration_ProcessSession)
- [msdyn_routingprofileconfiguration_SyncErrors](#BKMK_msdyn_routingprofileconfiguration_SyncErrors)

### <a name="BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule"></a> msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule

Many-To-One Relationship: [msdyn_routingoptimizationrequest msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule](msdyn_routingoptimizationrequest.md#BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingoptimizationrequest`|
|ReferencingAttribute|`msdyn_blockingschedule`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_BlockingSchedule`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseLabel`<br />Group: `Details`<br />Label: Blocked Requests of Other Schedules<br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source"></a> msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source

Many-To-One Relationship: [msdyn_routingoptimizationrequest msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source](msdyn_routingoptimizationrequest.md#BKMK_msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_routingoptimizationrequest`|
|ReferencingAttribute|`msdyn_sourceautoroutingschedule`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_routingprofileconfiguration_msdyn_routingoptimizationrequest_Source`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingprofileconfiguration_AsyncOperations"></a> msdyn_routingprofileconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_routingprofileconfiguration_AsyncOperations](asyncoperation.md#BKMK_msdyn_routingprofileconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingprofileconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingprofileconfiguration_BulkDeleteFailures"></a> msdyn_routingprofileconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_routingprofileconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_routingprofileconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingprofileconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingprofileconfiguration_DuplicateBaseRecord"></a> msdyn_routingprofileconfiguration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_routingprofileconfiguration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_routingprofileconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingprofileconfiguration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingprofileconfiguration_DuplicateMatchingRecord"></a> msdyn_routingprofileconfiguration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_routingprofileconfiguration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_routingprofileconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingprofileconfiguration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingprofileconfiguration_MailboxTrackingFolders"></a> msdyn_routingprofileconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_routingprofileconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_routingprofileconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingprofileconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingprofileconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_routingprofileconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_routingprofileconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_routingprofileconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingprofileconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingprofileconfiguration_ProcessSession"></a> msdyn_routingprofileconfiguration_ProcessSession

Many-To-One Relationship: [processsession msdyn_routingprofileconfiguration_ProcessSession](processsession.md#BKMK_msdyn_routingprofileconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingprofileconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_routingprofileconfiguration_SyncErrors"></a> msdyn_routingprofileconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msdyn_routingprofileconfiguration_SyncErrors](syncerror.md#BKMK_msdyn_routingprofileconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_routingprofileconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

