---
title: "Schedule Board Setting (msdyn_scheduleboardsetting) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Schedule Board Setting (msdyn_scheduleboardsetting) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Schedule Board Setting (msdyn_scheduleboardsetting) table/entity reference (Microsoft Dynamics 365 Field Service)

To store settings of SB by user & tabs

## Messages

The following table lists the messages for the Schedule Board Setting (msdyn_scheduleboardsetting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_scheduleboardsettinges<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_scheduleboardsettinges<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Schedule Board Setting (msdyn_scheduleboardsetting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Schedule Board Setting** |
| **DisplayCollectionName** | **Schedule Board Settings** |
| **SchemaName** | `msdyn_scheduleboardsetting` |
| **CollectionSchemaName** | `msdyn_scheduleboardsettings` |
| **EntitySetName** | `msdyn_scheduleboardsettinges`|
| **LogicalName** | `msdyn_scheduleboardsetting` |
| **LogicalCollectionName** | `msdyn_scheduleboardsettings` |
| **PrimaryIdAttribute** | `msdyn_scheduleboardsettingid` |
| **PrimaryNameAttribute** |`msdyn_tabname` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_BookBasedOn](#BKMK_msdyn_BookBasedOn)
- [msdyn_CustomTabName](#BKMK_msdyn_CustomTabName)
- [msdyn_CustomTabWebResource](#BKMK_msdyn_CustomTabWebResource)
- [msdyn_FilterLayout](#BKMK_msdyn_FilterLayout)
- [msdyn_FilterValues](#BKMK_msdyn_FilterValues)
- [msdyn_FullyBookedColor](#BKMK_msdyn_FullyBookedColor)
- [msdyn_HideCancelled](#BKMK_msdyn_HideCancelled)
- [msdyn_IsPublic](#BKMK_msdyn_IsPublic)
- [msdyn_IsSynchronizeResources](#BKMK_msdyn_IsSynchronizeResources)
- [msdyn_MapViewTabPlacement](#BKMK_msdyn_MapViewTabPlacement)
- [msdyn_NotBookedColor](#BKMK_msdyn_NotBookedColor)
- [msdyn_OrderNumber](#BKMK_msdyn_OrderNumber)
- [msdyn_OrganizationalUnitTooltipsViewId](#BKMK_msdyn_OrganizationalUnitTooltipsViewId)
- [msdyn_OrganizationalUnitViewId](#BKMK_msdyn_OrganizationalUnitViewId)
- [msdyn_OverbookedColor](#BKMK_msdyn_OverbookedColor)
- [msdyn_PartiallyBookedColor](#BKMK_msdyn_PartiallyBookedColor)
- [msdyn_ResourceCellTemplate](#BKMK_msdyn_ResourceCellTemplate)
- [msdyn_RetrieveResourcesQuery](#BKMK_msdyn_RetrieveResourcesQuery)
- [msdyn_SAAvailableColor](#BKMK_msdyn_SAAvailableColor)
- [msdyn_SAAvailableIcon](#BKMK_msdyn_SAAvailableIcon)
- [msdyn_SAAvailableIconDefault](#BKMK_msdyn_SAAvailableIconDefault)
- [msdyn_SAPartiallyAvailableColor](#BKMK_msdyn_SAPartiallyAvailableColor)
- [msdyn_SAPartiallyAvailableIcon](#BKMK_msdyn_SAPartiallyAvailableIcon)
- [msdyn_SAPartiallyAvailableIconDefault](#BKMK_msdyn_SAPartiallyAvailableIconDefault)
- [msdyn_SAUnavailableColor](#BKMK_msdyn_SAUnavailableColor)
- [msdyn_SAUnavailableIcon](#BKMK_msdyn_SAUnavailableIcon)
- [msdyn_SAUnavailableIconDefault](#BKMK_msdyn_SAUnavailableIconDefault)
- [msdyn_scheduleboardsettingId](#BKMK_msdyn_scheduleboardsettingId)
- [msdyn_SchedulerAlertsView](#BKMK_msdyn_SchedulerAlertsView)
- [msdyn_SchedulerBusinessUnitDetailsView](#BKMK_msdyn_SchedulerBusinessUnitDetailsView)
- [msdyn_SchedulerBusinessUnitTooltipView](#BKMK_msdyn_SchedulerBusinessUnitTooltipView)
- [msdyn_SchedulerCoreDetailsView](#BKMK_msdyn_SchedulerCoreDetailsView)
- [msdyn_SchedulerCoreSlotTextTemplate](#BKMK_msdyn_SchedulerCoreSlotTextTemplate)
- [msdyn_SchedulerCoreTooltipView](#BKMK_msdyn_SchedulerCoreTooltipView)
- [msdyn_SchedulerFieldServiceDetailsView](#BKMK_msdyn_SchedulerFieldServiceDetailsView)
- [msdyn_SchedulerFieldServiceSlotTextTemplate](#BKMK_msdyn_SchedulerFieldServiceSlotTextTemplate)
- [msdyn_SchedulerFieldServiceTooltipView](#BKMK_msdyn_SchedulerFieldServiceTooltipView)
- [msdyn_SchedulerResourceDetailsView](#BKMK_msdyn_SchedulerResourceDetailsView)
- [msdyn_SchedulerResourceTooltipView](#BKMK_msdyn_SchedulerResourceTooltipView)
- [msdyn_Settings](#BKMK_msdyn_Settings)
- [msdyn_ShareType](#BKMK_msdyn_ShareType)
- [msdyn_TabName](#BKMK_msdyn_TabName)
- [msdyn_UnscheduledRequirementsViewId](#BKMK_msdyn_UnscheduledRequirementsViewId)
- [msdyn_UnscheduledViewId](#BKMK_msdyn_UnscheduledViewId)
- [msdyn_UnscheduledWOPageRecCount](#BKMK_msdyn_UnscheduledWOPageRecCount)
- [msdyn_UnscheduledWOTooltipsViewId](#BKMK_msdyn_UnscheduledWOTooltipsViewId)
- [msdyn_WorkingHoursColor](#BKMK_msdyn_WorkingHoursColor)
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
|Description|**Shows the sequence number of the import that created this record.**|
|DisplayName|**Import Sequence Number**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`importsequencenumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_BookBasedOn"></a> msdyn_BookBasedOn

|Property|Value|
|---|---|
|Description||
|DisplayName|**Book Based On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookbasedon`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_scheduleboardsetting_msdyn_bookbasedon`|
|DefaultValue|True|
|True Label|Estimated Arrival|
|False Label|Start of Travel|

### <a name="BKMK_msdyn_CustomTabName"></a> msdyn_CustomTabName

|Property|Value|
|---|---|
|Description||
|DisplayName|**Custom Tab Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customtabname`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CustomTabWebResource"></a> msdyn_CustomTabWebResource

|Property|Value|
|---|---|
|Description||
|DisplayName|**Custom Tab Web Resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customtabwebresource`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|255|

### <a name="BKMK_msdyn_FilterLayout"></a> msdyn_FilterLayout

|Property|Value|
|---|---|
|Description||
|DisplayName|**Filter Layout**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_filterlayout`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_configuration|

### <a name="BKMK_msdyn_FilterValues"></a> msdyn_FilterValues

|Property|Value|
|---|---|
|Description|**Storing filter values as Json string.**|
|DisplayName|**Filter Values**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_filtervalues`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_FullyBookedColor"></a> msdyn_FullyBookedColor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Fully Booked Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_fullybookedcolor`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_HideCancelled"></a> msdyn_HideCancelled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Hide Canceled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_hidecancelled`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_scheduleboardsetting_msdyn_hidecancelled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IsPublic"></a> msdyn_IsPublic

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Public (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ispublic`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_scheduleboardsetting_msdyn_ispublic`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_IsSynchronizeResources"></a> msdyn_IsSynchronizeResources

|Property|Value|
|---|---|
|Description||
|DisplayName|**Is Synchronize Resources**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_issynchronizeresources`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_scheduleboardsetting_msdyn_issynchronizeresources`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_MapViewTabPlacement"></a> msdyn_MapViewTabPlacement

|Property|Value|
|---|---|
|Description||
|DisplayName|**Map View Tab Placement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_mapviewtabplacement`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_scheduleboardsetting_msdyn_mapviewtabplacement`|
|DefaultValue|False|
|True Label|Details|
|False Label|Filter|

### <a name="BKMK_msdyn_NotBookedColor"></a> msdyn_NotBookedColor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Not Booked Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_notbookedcolor`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_OrderNumber"></a> msdyn_OrderNumber

|Property|Value|
|---|---|
|Description|**Tab index.**|
|DisplayName|**Order Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_ordernumber`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|10000|
|MinValue|0|

### <a name="BKMK_msdyn_OrganizationalUnitTooltipsViewId"></a> msdyn_OrganizationalUnitTooltipsViewId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Organizational Unit Tooltips View Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_organizationalunittooltipsviewid`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_OrganizationalUnitViewId"></a> msdyn_OrganizationalUnitViewId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Organizational Unit View Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_organizationalunitviewid`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_OverbookedColor"></a> msdyn_OverbookedColor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Overbooked Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_overbookedcolor`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_PartiallyBookedColor"></a> msdyn_PartiallyBookedColor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Partially Booked Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_partiallybookedcolor`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ResourceCellTemplate"></a> msdyn_ResourceCellTemplate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Resource Cell Template**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resourcecelltemplate`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_configuration|

### <a name="BKMK_msdyn_RetrieveResourcesQuery"></a> msdyn_RetrieveResourcesQuery

|Property|Value|
|---|---|
|Description||
|DisplayName|**Retrieve Resources Query**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_retrieveresourcesquery`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_configuration|

### <a name="BKMK_msdyn_SAAvailableColor"></a> msdyn_SAAvailableColor

|Property|Value|
|---|---|
|Description||
|DisplayName|**SA Available Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_saavailablecolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_SAAvailableIcon"></a> msdyn_SAAvailableIcon

|Property|Value|
|---|---|
|Description||
|DisplayName|**SA Available Icon**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_saavailableicon`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyn_SAAvailableIconDefault"></a> msdyn_SAAvailableIconDefault

|Property|Value|
|---|---|
|Description|**Is available icon inheriting from default setting.**|
|DisplayName|**SA Available Icon Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_saavailableicondefault`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_scheduleboardsetting_msdyn_saavailableicondefault`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_SAPartiallyAvailableColor"></a> msdyn_SAPartiallyAvailableColor

|Property|Value|
|---|---|
|Description||
|DisplayName|**SA Partially Available Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sapartiallyavailablecolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_SAPartiallyAvailableIcon"></a> msdyn_SAPartiallyAvailableIcon

|Property|Value|
|---|---|
|Description||
|DisplayName|**SA Partially Available Icon**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sapartiallyavailableicon`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyn_SAPartiallyAvailableIconDefault"></a> msdyn_SAPartiallyAvailableIconDefault

|Property|Value|
|---|---|
|Description|**Is partially available icon inheriting from default setting.**|
|DisplayName|**SA Partially Available Icon Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sapartiallyavailableicondefault`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_scheduleboardsetting_msdyn_sapartiallyavailableicondefault`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_SAUnavailableColor"></a> msdyn_SAUnavailableColor

|Property|Value|
|---|---|
|Description||
|DisplayName|**SA Unavailable Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_saunavailablecolor`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_SAUnavailableIcon"></a> msdyn_SAUnavailableIcon

|Property|Value|
|---|---|
|Description||
|DisplayName|**SA Unavailable Icon**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_saunavailableicon`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|256|

### <a name="BKMK_msdyn_SAUnavailableIconDefault"></a> msdyn_SAUnavailableIconDefault

|Property|Value|
|---|---|
|Description|**Is unavailable icon inheriting from default setting.**|
|DisplayName|**SA Unavailable Icon Default**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_saunavailableicondefault`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_scheduleboardsetting_msdyn_saunavailableicondefault`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_scheduleboardsettingId"></a> msdyn_scheduleboardsettingId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Schedule Board Setting**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_scheduleboardsettingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_SchedulerAlertsView"></a> msdyn_SchedulerAlertsView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduler Alerts View**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_scheduleralertsview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_SchedulerBusinessUnitDetailsView"></a> msdyn_SchedulerBusinessUnitDetailsView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Unit Details View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerbusinessunitdetailsview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|40|

### <a name="BKMK_msdyn_SchedulerBusinessUnitTooltipView"></a> msdyn_SchedulerBusinessUnitTooltipView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Business Unit Tooltips View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerbusinessunittooltipview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|40|

### <a name="BKMK_msdyn_SchedulerCoreDetailsView"></a> msdyn_SchedulerCoreDetailsView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Core Details View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulercoredetailsview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_SchedulerCoreSlotTextTemplate"></a> msdyn_SchedulerCoreSlotTextTemplate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Core Slot Text Template (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulercoreslottexttemplate`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msdyn_SchedulerCoreTooltipView"></a> msdyn_SchedulerCoreTooltipView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Core Tooltip View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulercoretooltipview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_SchedulerFieldServiceDetailsView"></a> msdyn_SchedulerFieldServiceDetailsView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Field Service Details View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerfieldservicedetailsview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|40|

### <a name="BKMK_msdyn_SchedulerFieldServiceSlotTextTemplate"></a> msdyn_SchedulerFieldServiceSlotTextTemplate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Field Service Slot Text Template (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerfieldserviceslottexttemplate`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_SchedulerFieldServiceTooltipView"></a> msdyn_SchedulerFieldServiceTooltipView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Field Service Tooltip View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerfieldservicetooltipview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|40|

### <a name="BKMK_msdyn_SchedulerResourceDetailsView"></a> msdyn_SchedulerResourceDetailsView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Resource Details View**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerresourcedetailsview`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|40|

### <a name="BKMK_msdyn_SchedulerResourceTooltipView"></a> msdyn_SchedulerResourceTooltipView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Resource Tooltips View**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerresourcetooltipview`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|40|

### <a name="BKMK_msdyn_Settings"></a> msdyn_Settings

|Property|Value|
|---|---|
|Description|**Shows the settings as a JSON string.**|
|DisplayName|**Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_settings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_ShareType"></a> msdyn_ShareType

|Property|Value|
|---|---|
|Description|**Field is used to determine if Schedule Board Tab are Private, Public or Shareable**|
|DisplayName|**Share Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sharetype`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|192350001|
|GlobalChoiceName|`msdyn_scheduleboardsetting_msdyn_sharetype`|

#### msdyn_ShareType Choices/Options

|Value|Label|
|---|---|
|192350000|**Everyone**|
|192350001|**Just me**|
|192350002|**Specific people**|
|192350003|**System**|

### <a name="BKMK_msdyn_TabName"></a> msdyn_TabName

|Property|Value|
|---|---|
|Description|**Enter the tab name.**|
|DisplayName|**Tab name.**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_tabname`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_UnscheduledRequirementsViewId"></a> msdyn_UnscheduledRequirementsViewId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Requirements View Id**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unscheduledrequirementsviewid`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_UnscheduledViewId"></a> msdyn_UnscheduledViewId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Unscheduled View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unscheduledviewid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|40|

### <a name="BKMK_msdyn_UnscheduledWOPageRecCount"></a> msdyn_UnscheduledWOPageRecCount

|Property|Value|
|---|---|
|Description|**Shows the number of records to be displayed per page in 'Resource Requirement' section.**|
|DisplayName|**Resource Requirement View Page Record Count**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unscheduledwopagereccount`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_UnscheduledWOTooltipsViewId"></a> msdyn_UnscheduledWOTooltipsViewId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Unscheduled WO Tooltips View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unscheduledwotooltipsviewid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|40|

### <a name="BKMK_msdyn_WorkingHoursColor"></a> msdyn_WorkingHoursColor

|Property|Value|
|---|---|
|Description||
|DisplayName|**Non-Working Hours Color**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workinghourscolor`|
|RequiredLevel|Recommended|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|10|

### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|---|---|
|Description|**Shows the date and time that the record was migrated.**|
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
|Description|**Status of the Schedule Board Setting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_scheduleboardsetting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Schedule Board Setting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_scheduleboardsetting_statuscode`|

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
|Description|**Shows the time zone code that was in use when the record was created.**|
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.**|
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
|Description|**Shows who created the record on behalf of another user.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.**|
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
|Description|**Shows who last updated the record on behalf of another user.**|
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



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

