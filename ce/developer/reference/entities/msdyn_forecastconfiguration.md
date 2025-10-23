---
title: "Forecast Configuration (msdyn_forecastconfiguration) table/entity reference (Microsoft Dynamics 365)"
description: "Includes schema information and supported messages for the Forecast Configuration (msdyn_forecastconfiguration) table/entity with Microsoft Dynamics 365."
ms.topic: generated-reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# Forecast Configuration (msdyn_forecastconfiguration) table/entity reference (Microsoft Dynamics 365)



## Messages

The following table lists the messages for the Forecast Configuration (msdyn_forecastconfiguration) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_forecastconfigurations(*msdyn_forecastconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_forecastconfigurations<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_forecastconfigurations(*msdyn_forecastconfigurationid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_forecastconfigurations(*msdyn_forecastconfigurationid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_forecastconfigurations<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_forecastconfigurations(*msdyn_forecastconfigurationid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_forecastconfigurations(*msdyn_forecastconfigurationid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_forecastconfigurations(*msdyn_forecastconfigurationid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Forecast Configuration (msdyn_forecastconfiguration) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Forecast Configuration** |
| **DisplayCollectionName** | **Forecast configurations** |
| **SchemaName** | `msdyn_forecastconfiguration` |
| **CollectionSchemaName** | `msdyn_forecastconfigurations` |
| **EntitySetName** | `msdyn_forecastconfigurations`|
| **LogicalName** | `msdyn_forecastconfiguration` |
| **LogicalCollectionName** | `msdyn_forecastconfigurations` |
| **PrimaryIdAttribute** | `msdyn_forecastconfigurationid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_addedWeekIndex](#BKMK_msdyn_addedWeekIndex)
- [msdyn_additionalfilter](#BKMK_msdyn_additionalfilter)
- [msdyn_advancedsettings](#BKMK_msdyn_advancedsettings)
- [msdyn_CalendarTemplate](#BKMK_msdyn_CalendarTemplate)
- [msdyn_columns](#BKMK_msdyn_columns)
- [msdyn_enddate](#BKMK_msdyn_enddate)
- [msdyn_entitymetadata](#BKMK_msdyn_entitymetadata)
- [msdyn_errormessage](#BKMK_msdyn_errormessage)
- [msdyn_FiscalYearStartDate](#BKMK_msdyn_FiscalYearStartDate)
- [msdyn_forecastcategoryattribute](#BKMK_msdyn_forecastcategoryattribute)
- [msdyn_forecastconfigurationId](#BKMK_msdyn_forecastconfigurationId)
- [msdyn_hierarchyentity](#BKMK_msdyn_hierarchyentity)
- [msdyn_hierarchyfilter](#BKMK_msdyn_hierarchyfilter)
- [msdyn_hierarchyrelationship](#BKMK_msdyn_hierarchyrelationship)
- [msdyn_isdefault](#BKMK_msdyn_isdefault)
- [msdyn_issnapshotscheduled](#BKMK_msdyn_issnapshotscheduled)
- [msdyn_moneyattrcache](#BKMK_msdyn_moneyattrcache)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_numberofrecurrences](#BKMK_msdyn_numberofrecurrences)
- [msdyn_periodtype](#BKMK_msdyn_periodtype)
- [msdyn_permissionsdata](#BKMK_msdyn_permissionsdata)
- [msdyn_pivots](#BKMK_msdyn_pivots)
- [msdyn_previewFlags](#BKMK_msdyn_previewFlags)
- [msdyn_publisheddatetime](#BKMK_msdyn_publisheddatetime)
- [msdyn_relatedentities](#BKMK_msdyn_relatedentities)
- [msdyn_rollupdefaultviewid](#BKMK_msdyn_rollupdefaultviewid)
- [msdyn_rollupentity](#BKMK_msdyn_rollupentity)
- [msdyn_rootentityrecordid](#BKMK_msdyn_rootentityrecordid)
- [msdyn_snapshotschedule](#BKMK_msdyn_snapshotschedule)
- [msdyn_snapshottimezone](#BKMK_msdyn_snapshottimezone)
- [msdyn_startdate](#BKMK_msdyn_startdate)
- [msdyn_startingfiscalmonth](#BKMK_msdyn_startingfiscalmonth)
- [msdyn_startingfiscalquarter](#BKMK_msdyn_startingfiscalquarter)
- [msdyn_startingfiscalyear](#BKMK_msdyn_startingfiscalyear)
- [msdyn_templatetype](#BKMK_msdyn_templatetype)
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

### <a name="BKMK_msdyn_addedWeekIndex"></a> msdyn_addedWeekIndex

|Property|Value|
|---|---|
|Description||
|DisplayName|**addedWeekIndex**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_addedweekindex`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_additionalfilter"></a> msdyn_additionalfilter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Additional filters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_additionalfilter`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_advancedsettings"></a> msdyn_advancedsettings

|Property|Value|
|---|---|
|Description|**Forecast configuration settings**|
|DisplayName|**Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_advancedsettings`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_CalendarTemplate"></a> msdyn_CalendarTemplate

|Property|Value|
|---|---|
|Description|**Fiscal Year Calendar Template**|
|DisplayName|**Calendar Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_calendartemplate`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000003|
|GlobalChoiceName|`msdyn_msdyn_forecastconfiguration_msdyn_calendartemplate`|

#### msdyn_CalendarTemplate Choices/Options

|Value|Label|
|---|---|
|100000000|**4-4-5**|
|100000001|**4-5-4**|
|100000002|**5-4-4**|
|100000003|**Gregorian**|
|100000004|**Broadcast Calendar**|
|100000005|**3-3-3-4**|
|100000006|**3-3-4-3**|
|100000007|**3-4-3-3**|
|100000008|**4-3-3-3**|

### <a name="BKMK_msdyn_columns"></a> msdyn_columns

|Property|Value|
|---|---|
|Description||
|DisplayName|**Columns**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_columns`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_enddate"></a> msdyn_enddate

|Property|Value|
|---|---|
|Description||
|DisplayName|**End Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enddate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_entitymetadata"></a> msdyn_entitymetadata

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entities metadata**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitymetadata`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_errormessage"></a> msdyn_errormessage

|Property|Value|
|---|---|
|Description||
|DisplayName|**Error message**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_errormessage`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_FiscalYearStartDate"></a> msdyn_FiscalYearStartDate

|Property|Value|
|---|---|
|Description|**Fiscal Year Start Date**|
|DisplayName|**Fiscal Year Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fiscalyearstartdate`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_forecastcategoryattribute"></a> msdyn_forecastcategoryattribute

|Property|Value|
|---|---|
|Description||
|DisplayName|**Forecast category attribute**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastcategoryattribute`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_forecastconfigurationId"></a> msdyn_forecastconfigurationId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Forecast configuration id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_forecastconfigurationid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_hierarchyentity"></a> msdyn_hierarchyentity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Hierarchy entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hierarchyentity`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_hierarchyfilter"></a> msdyn_hierarchyfilter

|Property|Value|
|---|---|
|Description||
|DisplayName|**Hierarchy filters**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hierarchyfilter`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_hierarchyrelationship"></a> msdyn_hierarchyrelationship

|Property|Value|
|---|---|
|Description||
|DisplayName|**Relationship**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hierarchyrelationship`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_isdefault"></a> msdyn_isdefault

|Property|Value|
|---|---|
|Description|**Determine if FC is default**|
|DisplayName|**Is Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_isdefault`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_forecastconfiguration_msdyn_isdefault`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_issnapshotscheduled"></a> msdyn_issnapshotscheduled

|Property|Value|
|---|---|
|Description|**Enable scheduling for forecast snapshots**|
|DisplayName|**Enable Snapshot Scheduling**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issnapshotscheduled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_forecastconfiguration_msdyn_issnapshotscheduled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_moneyattrcache"></a> msdyn_moneyattrcache

|Property|Value|
|---|---|
|Description||
|DisplayName|**Nested dictionary containing base column name for given money column name for every entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_moneyattrcache`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**The name of the custom entity.**|
|DisplayName|**Forecast configuration name**|
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

### <a name="BKMK_msdyn_numberofrecurrences"></a> msdyn_numberofrecurrences

|Property|Value|
|---|---|
|Description|**Indicate the number of recurrences that the forecast will be generated.**|
|DisplayName|**Number of recurrences**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_numberofrecurrences`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|12|
|MinValue|1|

### <a name="BKMK_msdyn_periodtype"></a> msdyn_periodtype

|Property|Value|
|---|---|
|Description|**Select the type of period for which the forecast must be generated.**|
|DisplayName|**Forecast period**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_periodtype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|1|
|GlobalChoiceName|`msdyn_forecastconfiguration_msdyn_periodtype`|

#### msdyn_periodtype Choices/Options

|Value|Label|
|---|---|
|0|**Monthly**|
|1|**Quarterly**|
|2|**Weekly**|
|3|**Annually**|

### <a name="BKMK_msdyn_permissionsdata"></a> msdyn_permissionsdata

|Property|Value|
|---|---|
|Description||
|DisplayName|**Permissions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_permissionsdata`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_pivots"></a> msdyn_pivots

|Property|Value|
|---|---|
|Description||
|DisplayName|**Pivots**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pivots`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_previewFlags"></a> msdyn_previewFlags

|Property|Value|
|---|---|
|Description|**Feature Flags**|
|DisplayName|**previewFlags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_previewflags`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_publisheddatetime"></a> msdyn_publisheddatetime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Published date time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_publisheddatetime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_relatedentities"></a> msdyn_relatedentities

|Property|Value|
|---|---|
|Description||
|DisplayName|**Related entities**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_relatedentities`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1073741823|

### <a name="BKMK_msdyn_rollupdefaultviewid"></a> msdyn_rollupdefaultviewid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Rollup entity default view**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rollupdefaultviewid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_rollupentity"></a> msdyn_rollupentity

|Property|Value|
|---|---|
|Description||
|DisplayName|**Rollup entity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rollupentity`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|4000|

### <a name="BKMK_msdyn_rootentityrecordid"></a> msdyn_rootentityrecordid

|Property|Value|
|---|---|
|Description||
|DisplayName|**Root record Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rootentityrecordid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_snapshotschedule"></a> msdyn_snapshotschedule

|Property|Value|
|---|---|
|Description|**Schedule governing the forecast snapshot**|
|DisplayName|**Schedule governing the forecast snapshot**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_snapshotschedule`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_snapshottimezone"></a> msdyn_snapshottimezone

|Property|Value|
|---|---|
|Description|**Prefered timezone governing the scheduler of forecast snapshot**|
|DisplayName|**Prefered timezone governing the scheduler of forecast snapshot**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_forecasttimezone`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1000|

### <a name="BKMK_msdyn_startdate"></a> msdyn_startdate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Start Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startdate`|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|
|CanChangeDateTimeBehavior|False|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_startingfiscalmonth"></a> msdyn_startingfiscalmonth

|Property|Value|
|---|---|
|Description|**Select the fiscal month for the forecast configuration.**|
|DisplayName|**Starting Fiscal month**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startingfiscalmonth`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_forecastconfiguration_msdyn_startingfiscalmonth`|

#### msdyn_startingfiscalmonth Choices/Options

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

### <a name="BKMK_msdyn_startingfiscalquarter"></a> msdyn_startingfiscalquarter

|Property|Value|
|---|---|
|Description|**Select the fiscal quarter for the forecast configuration.**|
|DisplayName|**Starting Fiscal quarter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startingfiscalquarter`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_forecastconfiguration_msdyn_startingfiscalquarter`|

#### msdyn_startingfiscalquarter Choices/Options

|Value|Label|
|---|---|
|0|**Q1**|
|1|**Q2**|
|2|**Q3**|
|3|**Q4**|

### <a name="BKMK_msdyn_startingfiscalyear"></a> msdyn_startingfiscalyear

|Property|Value|
|---|---|
|Description|**Select the fiscal year for the forecast configuration.**|
|DisplayName|**Starting Fiscal year**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_startingfiscalyear`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_forecastconfiguration_msdyn_startingfiscalyear`|

#### msdyn_startingfiscalyear Choices/Options

|Value|Label|
|---|---|
|0|**FY2018**|
|1|**FY2019**|
|2|**FY2020**|
|3|**FY2021**|
|4|**FY2022**|
|5|**FY2023**|
|6|**FY2024**|
|7|**FY2025**|
|8|**FY2026**|
|9|**FY2027**|
|10|**FY2028**|

### <a name="BKMK_msdyn_templatetype"></a> msdyn_templatetype

|Property|Value|
|---|---|
|Description||
|DisplayName|**Template type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_templatetype`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
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
|Description|**Status of the Forecast Configuration**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_forecastconfiguration_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Forecast Configuration**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_forecastconfiguration_statuscode`|

#### statuscode Choices/Options

|Value|Details|
|---|---|
|1|Label: **Draft**<br />State:0<br />TransitionData: None|
|2|Label: **In progress**<br />State:0<br />TransitionData: None|
|3|Label: **Active**<br />State:0<br />TransitionData: None|
|4|Label: **Failed**<br />State:0<br />TransitionData: None|
|5|Label: **Inactive**<br />State:1<br />TransitionData: None|
|6|Label: **Archived**<br />State:1<br />TransitionData: None|
|7|Label: **Invalidated**<br />State:1<br />TransitionData: None|
|8|Label: **Reactivation in progress**<br />State:0<br />TransitionData: None|

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

- [business_unit_msdyn_forecastconfiguration](#BKMK_business_unit_msdyn_forecastconfiguration)
- [lk_msdyn_forecastconfiguration_createdby](#BKMK_lk_msdyn_forecastconfiguration_createdby)
- [lk_msdyn_forecastconfiguration_createdonbehalfby](#BKMK_lk_msdyn_forecastconfiguration_createdonbehalfby)
- [lk_msdyn_forecastconfiguration_modifiedby](#BKMK_lk_msdyn_forecastconfiguration_modifiedby)
- [lk_msdyn_forecastconfiguration_modifiedonbehalfby](#BKMK_lk_msdyn_forecastconfiguration_modifiedonbehalfby)
- [owner_msdyn_forecastconfiguration](#BKMK_owner_msdyn_forecastconfiguration)
- [team_msdyn_forecastconfiguration](#BKMK_team_msdyn_forecastconfiguration)
- [user_msdyn_forecastconfiguration](#BKMK_user_msdyn_forecastconfiguration)

### <a name="BKMK_business_unit_msdyn_forecastconfiguration"></a> business_unit_msdyn_forecastconfiguration

One-To-Many Relationship: [businessunit business_unit_msdyn_forecastconfiguration](businessunit.md#BKMK_business_unit_msdyn_forecastconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastconfiguration_createdby"></a> lk_msdyn_forecastconfiguration_createdby

One-To-Many Relationship: [systemuser lk_msdyn_forecastconfiguration_createdby](systemuser.md#BKMK_lk_msdyn_forecastconfiguration_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastconfiguration_createdonbehalfby"></a> lk_msdyn_forecastconfiguration_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastconfiguration_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastconfiguration_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastconfiguration_modifiedby"></a> lk_msdyn_forecastconfiguration_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_forecastconfiguration_modifiedby](systemuser.md#BKMK_lk_msdyn_forecastconfiguration_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_forecastconfiguration_modifiedonbehalfby"></a> lk_msdyn_forecastconfiguration_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_forecastconfiguration_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_forecastconfiguration_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_forecastconfiguration"></a> owner_msdyn_forecastconfiguration

One-To-Many Relationship: [owner owner_msdyn_forecastconfiguration](owner.md#BKMK_owner_msdyn_forecastconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_forecastconfiguration"></a> team_msdyn_forecastconfiguration

One-To-Many Relationship: [team team_msdyn_forecastconfiguration](team.md#BKMK_team_msdyn_forecastconfiguration)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_forecastconfiguration"></a> user_msdyn_forecastconfiguration

One-To-Many Relationship: [systemuser user_msdyn_forecastconfiguration](systemuser.md#BKMK_user_msdyn_forecastconfiguration)

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

- [msdyn_forecastconfiguration_Annotations](#BKMK_msdyn_forecastconfiguration_Annotations)
- [msdyn_forecastconfiguration_AsyncOperations](#BKMK_msdyn_forecastconfiguration_AsyncOperations)
- [msdyn_forecastconfiguration_BulkDeleteFailures](#BKMK_msdyn_forecastconfiguration_BulkDeleteFailures)
- [msdyn_forecastconfiguration_DuplicateBaseRecord](#BKMK_msdyn_forecastconfiguration_DuplicateBaseRecord)
- [msdyn_forecastconfiguration_DuplicateMatchingRecord](#BKMK_msdyn_forecastconfiguration_DuplicateMatchingRecord)
- [msdyn_forecastconfiguration_MailboxTrackingFolders](#BKMK_msdyn_forecastconfiguration_MailboxTrackingFolders)
- [msdyn_forecastconfiguration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_forecastconfiguration_PrincipalObjectAttributeAccesses)
- [msdyn_forecastconfiguration_ProcessSession](#BKMK_msdyn_forecastconfiguration_ProcessSession)
- [msdyn_forecastconfiguration_SyncErrors](#BKMK_msdyn_forecastconfiguration_SyncErrors)
- [msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid)
- [msdyn_msdyn_forecastconfiguration_msdyn_distributedlock_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_distributedlock_forecastconfigurationid)
- [msdyn_msdyn_forecastconfiguration_msdyn_fileuploadstatustracker_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_fileuploadstatustracker_forecastconfigurationid)
- [msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid)
- [msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid)
- [msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid)
- [msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictionstatus_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictionstatus_forecastconfigurationid)
- [msdyn_msdyn_forecastconfiguration_msdyn_recomputetracker_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_recomputetracker_forecastconfigurationid)
- [msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid)
- [msdyn_msdyn_forecastconfiguration_msdyn_shareasconfiguration_forecastconfigurationid](#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_shareasconfiguration_forecastconfigurationid)

### <a name="BKMK_msdyn_forecastconfiguration_Annotations"></a> msdyn_forecastconfiguration_Annotations

Many-To-One Relationship: [annotation msdyn_forecastconfiguration_Annotations](annotation.md#BKMK_msdyn_forecastconfiguration_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastconfiguration_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastconfiguration_AsyncOperations"></a> msdyn_forecastconfiguration_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_forecastconfiguration_AsyncOperations](asyncoperation.md#BKMK_msdyn_forecastconfiguration_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastconfiguration_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastconfiguration_BulkDeleteFailures"></a> msdyn_forecastconfiguration_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_forecastconfiguration_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_forecastconfiguration_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastconfiguration_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastconfiguration_DuplicateBaseRecord"></a> msdyn_forecastconfiguration_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_forecastconfiguration_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_forecastconfiguration_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastconfiguration_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastconfiguration_DuplicateMatchingRecord"></a> msdyn_forecastconfiguration_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_forecastconfiguration_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_forecastconfiguration_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastconfiguration_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastconfiguration_MailboxTrackingFolders"></a> msdyn_forecastconfiguration_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_forecastconfiguration_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_forecastconfiguration_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastconfiguration_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastconfiguration_PrincipalObjectAttributeAccesses"></a> msdyn_forecastconfiguration_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_forecastconfiguration_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_forecastconfiguration_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastconfiguration_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastconfiguration_ProcessSession"></a> msdyn_forecastconfiguration_ProcessSession

Many-To-One Relationship: [processsession msdyn_forecastconfiguration_ProcessSession](processsession.md#BKMK_msdyn_forecastconfiguration_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastconfiguration_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_forecastconfiguration_SyncErrors"></a> msdyn_forecastconfiguration_SyncErrors

Many-To-One Relationship: [syncerror msdyn_forecastconfiguration_SyncErrors](syncerror.md#BKMK_msdyn_forecastconfiguration_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_forecastconfiguration_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid

Many-To-One Relationship: [msdyn_adjustmenthistory msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid](msdyn_adjustmenthistory.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_adjustmenthistory`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastconfiguration_msdyn_adjustmenthistory_forecastconfigurationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_distributedlock_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_distributedlock_forecastconfigurationid

Many-To-One Relationship: [msdyn_distributedlock msdyn_msdyn_forecastconfiguration_msdyn_distributedlock_forecastconfigurationid](msdyn_distributedlock.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_distributedlock_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_distributedlock`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastconfiguration_msdyn_distributedlock_forecastconfigurationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_fileuploadstatustracker_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_fileuploadstatustracker_forecastconfigurationid

Many-To-One Relationship: [msdyn_fileuploadstatustracker msdyn_msdyn_forecastconfiguration_msdyn_fileuploadstatustracker_forecastconfigurationid](msdyn_fileuploadstatustracker.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_fileuploadstatustracker_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_fileuploadstatustracker`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastconfiguration_msdyn_fileuploadstatustracker_forecastconfigurationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid

Many-To-One Relationship: [msdyn_forecast msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid](msdyn_forecast.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecast`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastconfiguration_msdyn_forecast_forecastconfigurationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid

Many-To-One Relationship: [msdyn_forecastinsight msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid](msdyn_forecastinsight.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastinsight`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastconfiguration_msdyn_forecastinsight_forecastconfigurationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid

Many-To-One Relationship: [msdyn_forecastpredictiondata msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid](msdyn_forecastpredictiondata.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastpredictiondata`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictiondata_forecastconfigurationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictionstatus_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictionstatus_forecastconfigurationid

Many-To-One Relationship: [msdyn_forecastpredictionstatus msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictionstatus_forecastconfigurationid](msdyn_forecastpredictionstatus.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictionstatus_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_forecastpredictionstatus`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastconfiguration_msdyn_forecastpredictionstatus_forecastconfigurationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_recomputetracker_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_recomputetracker_forecastconfigurationid

Many-To-One Relationship: [msdyn_recomputetracker msdyn_msdyn_forecastconfiguration_msdyn_recomputetracker_forecastconfigurationid](msdyn_recomputetracker.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_recomputetracker_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recomputetracker`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastconfiguration_msdyn_recomputetracker_forecastconfigurationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid

Many-To-One Relationship: [msdyn_recurrence msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid](msdyn_recurrence.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_recurrence`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastconfiguration_msdyn_recurrence_forecastconfigurationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_forecastconfiguration_msdyn_shareasconfiguration_forecastconfigurationid"></a> msdyn_msdyn_forecastconfiguration_msdyn_shareasconfiguration_forecastconfigurationid

Many-To-One Relationship: [msdyn_shareasconfiguration msdyn_msdyn_forecastconfiguration_msdyn_shareasconfiguration_forecastconfigurationid](msdyn_shareasconfiguration.md#BKMK_msdyn_msdyn_forecastconfiguration_msdyn_shareasconfiguration_forecastconfigurationid)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_shareasconfiguration`|
|ReferencingAttribute|`msdyn_forecastconfigurationid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_forecastconfiguration_msdyn_shareasconfiguration_forecastconfigurationid`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

