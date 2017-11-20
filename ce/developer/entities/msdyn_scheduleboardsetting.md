---
title: "msdyn_scheduleboardsetting Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_scheduleboardsetting entity."
ms.date: 10/31/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_scheduleboardsetting Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

To store settings of SB by user & tabs

**Added by**: Unified Resource Scheduling Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Schedule Board Setting<br />
**DisplayCollectionName**: Schedule Board Settings<br />
**SchemaName**: msdyn_scheduleboardsetting<br />
**CollectionSchemaName**: msdyn_scheduleboardsettings<br />
**LogicalName**: msdyn_scheduleboardsetting<br />
**LogicalCollectionName**: msdyn_scheduleboardsettings<br />
**EntitySetName**: msdyn_scheduleboardsettinges<br />
**PrimaryIdAttribute**: msdyn_scheduleboardsettingid<br />
**PrimaryNameAttribute**: msdyn_tabname<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
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
- [msdyn_SAPartiallyAvailableColor](#BKMK_msdyn_SAPartiallyAvailableColor)
- [msdyn_SAPartiallyAvailableIcon](#BKMK_msdyn_SAPartiallyAvailableIcon)
- [msdyn_SAUnavailableColor](#BKMK_msdyn_SAUnavailableColor)
- [msdyn_SAUnavailableIcon](#BKMK_msdyn_SAUnavailableIcon)
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

**Description**: Shows the sequence number of the import that created this record.<br />
**DisplayName**: Import Sequence Number<br />
**LogicalName**: importsequencenumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_CustomTabName"></a> msdyn_CustomTabName

**Description**: <br />
**DisplayName**: Custom Tab Name<br />
**LogicalName**: msdyn_customtabname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_CustomTabWebResource"></a> msdyn_CustomTabWebResource

**Description**: <br />
**DisplayName**: Custom Tab Web Resource<br />
**LogicalName**: msdyn_customtabwebresource<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 255


### <a name="BKMK_msdyn_FilterLayout"></a> msdyn_FilterLayout

**Description**: <br />
**DisplayName**: Filter Layout<br />
**LogicalName**: msdyn_filterlayout<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_configuration


### <a name="BKMK_msdyn_FilterValues"></a> msdyn_FilterValues

**Description**: Storing filter values as Json string.<br />
**DisplayName**: Filter Values<br />
**LogicalName**: msdyn_filtervalues<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_FullyBookedColor"></a> msdyn_FullyBookedColor

**Description**: <br />
**DisplayName**: Fully Booked Color<br />
**LogicalName**: msdyn_fullybookedcolor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_HideCancelled"></a> msdyn_HideCancelled

**Description**: <br />
**DisplayName**: Hide Canceled<br />
**LogicalName**: msdyn_hidecancelled<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_IsPublic"></a> msdyn_IsPublic

**Description**: <br />
**DisplayName**: Is Public (Deprecated)<br />
**LogicalName**: msdyn_ispublic<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_IsSynchronizeResources"></a> msdyn_IsSynchronizeResources

**Description**: <br />
**DisplayName**: Is Synchronize Resources<br />
**LogicalName**: msdyn_issynchronizeresources<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_MapViewTabPlacement"></a> msdyn_MapViewTabPlacement

**Description**: <br />
**DisplayName**: Map View Tab Placement<br />
**LogicalName**: msdyn_mapviewtabplacement<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Details
- **FalseOption Value**: 0 **Label**: Filter

**DefaultValue**: False


### <a name="BKMK_msdyn_NotBookedColor"></a> msdyn_NotBookedColor

**Description**: <br />
**DisplayName**: Not Booked Color<br />
**LogicalName**: msdyn_notbookedcolor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OrderNumber"></a> msdyn_OrderNumber

**Description**: Tab index.<br />
**DisplayName**: Order Number<br />
**LogicalName**: msdyn_ordernumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 100<br />
**MinValue**: 0


### <a name="BKMK_msdyn_OrganizationalUnitTooltipsViewId"></a> msdyn_OrganizationalUnitTooltipsViewId

**Description**: <br />
**DisplayName**: Organizational Unit Tooltips View Id<br />
**LogicalName**: msdyn_organizationalunittooltipsviewid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OrganizationalUnitViewId"></a> msdyn_OrganizationalUnitViewId

**Description**: <br />
**DisplayName**: Organizational Unit View Id<br />
**LogicalName**: msdyn_organizationalunitviewid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OverbookedColor"></a> msdyn_OverbookedColor

**Description**: <br />
**DisplayName**: Overbooked Color<br />
**LogicalName**: msdyn_overbookedcolor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_PartiallyBookedColor"></a> msdyn_PartiallyBookedColor

**Description**: <br />
**DisplayName**: Partially Booked Color<br />
**LogicalName**: msdyn_partiallybookedcolor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ResourceCellTemplate"></a> msdyn_ResourceCellTemplate

**Description**: <br />
**DisplayName**: Resource Cell Template<br />
**LogicalName**: msdyn_resourcecelltemplate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_configuration


### <a name="BKMK_msdyn_RetrieveResourcesQuery"></a> msdyn_RetrieveResourcesQuery

**Description**: <br />
**DisplayName**: Retrieve Resources Query<br />
**LogicalName**: msdyn_retrieveresourcesquery<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_configuration


### <a name="BKMK_msdyn_SAAvailableColor"></a> msdyn_SAAvailableColor

**Description**: <br />
**DisplayName**: SA Available Color<br />
**LogicalName**: msdyn_saavailablecolor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_SAAvailableIcon"></a> msdyn_SAAvailableIcon

**Description**: <br />
**DisplayName**: SA Available Icon<br />
**LogicalName**: msdyn_saavailableicon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_msdyn_SAPartiallyAvailableColor"></a> msdyn_SAPartiallyAvailableColor

**Description**: <br />
**DisplayName**: SA Partially Available Color<br />
**LogicalName**: msdyn_sapartiallyavailablecolor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_SAPartiallyAvailableIcon"></a> msdyn_SAPartiallyAvailableIcon

**Description**: <br />
**DisplayName**: SA Partially Available Icon<br />
**LogicalName**: msdyn_sapartiallyavailableicon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_msdyn_SAUnavailableColor"></a> msdyn_SAUnavailableColor

**Description**: <br />
**DisplayName**: SA Unavailable Color<br />
**LogicalName**: msdyn_saunavailablecolor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_SAUnavailableIcon"></a> msdyn_SAUnavailableIcon

**Description**: <br />
**DisplayName**: SA Unavailable Icon<br />
**LogicalName**: msdyn_saunavailableicon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_msdyn_scheduleboardsettingId"></a> msdyn_scheduleboardsettingId

**Description**: Shows the entity instances.<br />
**DisplayName**: Schedule Board Setting<br />
**LogicalName**: msdyn_scheduleboardsettingid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_SchedulerAlertsView"></a> msdyn_SchedulerAlertsView

**Description**: <br />
**DisplayName**: Scheduler Alerts View<br />
**LogicalName**: msdyn_scheduleralertsview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_SchedulerBusinessUnitDetailsView"></a> msdyn_SchedulerBusinessUnitDetailsView

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Unit Details View (Deprecated)<br />
**LogicalName**: msdyn_schedulerbusinessunitdetailsview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 40


### <a name="BKMK_msdyn_SchedulerBusinessUnitTooltipView"></a> msdyn_SchedulerBusinessUnitTooltipView

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Business Unit Tooltips View (Deprecated)<br />
**LogicalName**: msdyn_schedulerbusinessunittooltipview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 40


### <a name="BKMK_msdyn_SchedulerCoreDetailsView"></a> msdyn_SchedulerCoreDetailsView

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Core Details View (Deprecated)<br />
**LogicalName**: msdyn_schedulercoredetailsview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SchedulerCoreSlotTextTemplate"></a> msdyn_SchedulerCoreSlotTextTemplate

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Core Slot Text Template (Deprecated)<br />
**LogicalName**: msdyn_schedulercoreslottexttemplate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 5000


### <a name="BKMK_msdyn_SchedulerCoreTooltipView"></a> msdyn_SchedulerCoreTooltipView

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Core Tooltip View (Deprecated)<br />
**LogicalName**: msdyn_schedulercoretooltipview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SchedulerFieldServiceDetailsView"></a> msdyn_SchedulerFieldServiceDetailsView

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Field Service Details View (Deprecated)<br />
**LogicalName**: msdyn_schedulerfieldservicedetailsview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 40


### <a name="BKMK_msdyn_SchedulerFieldServiceSlotTextTemplate"></a> msdyn_SchedulerFieldServiceSlotTextTemplate

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Field Service Slot Text Template (Deprecated)<br />
**LogicalName**: msdyn_schedulerfieldserviceslottexttemplate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 8000


### <a name="BKMK_msdyn_SchedulerFieldServiceTooltipView"></a> msdyn_SchedulerFieldServiceTooltipView

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Field Service Tooltip View (Deprecated)<br />
**LogicalName**: msdyn_schedulerfieldservicetooltipview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 40


### <a name="BKMK_msdyn_SchedulerResourceDetailsView"></a> msdyn_SchedulerResourceDetailsView

**Description**: <br />
**DisplayName**: Resource Details View<br />
**LogicalName**: msdyn_schedulerresourcedetailsview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 40


### <a name="BKMK_msdyn_SchedulerResourceTooltipView"></a> msdyn_SchedulerResourceTooltipView

**Description**: <br />
**DisplayName**: Resource Tooltips View<br />
**LogicalName**: msdyn_schedulerresourcetooltipview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 40


### <a name="BKMK_msdyn_Settings"></a> msdyn_Settings

**Description**: Shows the settings as a JSON string.<br />
**DisplayName**: Settings<br />
**LogicalName**: msdyn_settings<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_ShareType"></a> msdyn_ShareType

**Description**: Field is used to determine if Schedule Board Tab are Private, Public or Shareable<br />
**DisplayName**: Share Type<br />
**LogicalName**: msdyn_sharetype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 192350000 **Label**: Everyone
- **Value**: 192350001 **Label**: Just me
- **Value**: 192350002 **Label**: Specific people
- **Value**: 192350003 **Label**: System



### <a name="BKMK_msdyn_TabName"></a> msdyn_TabName

**Description**: Enter the tab name.<br />
**DisplayName**: Tab name.<br />
**LogicalName**: msdyn_tabname<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_UnscheduledRequirementsViewId"></a> msdyn_UnscheduledRequirementsViewId

**Description**: <br />
**DisplayName**: Requirements View Id<br />
**LogicalName**: msdyn_unscheduledrequirementsviewid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_UnscheduledViewId"></a> msdyn_UnscheduledViewId

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Unscheduled View (Deprecated)<br />
**LogicalName**: msdyn_unscheduledviewid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 40


### <a name="BKMK_msdyn_UnscheduledWOPageRecCount"></a> msdyn_UnscheduledWOPageRecCount

**Description**: Shows the number of records to be displayed per page in 'Resource Requirement' section.<br />
**DisplayName**: Resource Requirement View Page Record Count<br />
**LogicalName**: msdyn_unscheduledwopagereccount<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 1


### <a name="BKMK_msdyn_UnscheduledWOTooltipsViewId"></a> msdyn_UnscheduledWOTooltipsViewId

**Added by**: Field Service Solution<br />
**Description**: <br />
**DisplayName**: Unscheduled WO Tooltips View (Deprecated)<br />
**LogicalName**: msdyn_unscheduledwotooltipsviewid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 40


### <a name="BKMK_msdyn_WorkingHoursColor"></a> msdyn_WorkingHoursColor

**Description**: <br />
**DisplayName**: Working Hours Color<br />
**LogicalName**: msdyn_workinghourscolor<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: Recommended<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 10


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

**Description**: Shows the date and time that the record was migrated.<br />
**DisplayName**: Record Created On<br />
**LogicalName**: overriddencreatedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**IsValidForUpdate**: False<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateOnly


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Owner Id<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Owner<br />
**Targets**: systemuser,team


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Description**: Shows the owner ID type.<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Schedule Board Setting<br />
**DisplayName**: Status<br />
**LogicalName**: statecode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForCreate**: False<br />
**Type**: State<br />
**Options**:

- **Value**: 0 **Label**: Active **DefaultStatus**: 1 **InvariantName**: Active
- **Value**: 1 **Label**: Inactive **DefaultStatus**: 2 **InvariantName**: Inactive



### <a name="BKMK_statuscode"></a> statuscode

**Description**: Reason for the status of the Schedule Board Setting<br />
**DisplayName**: Status Reason<br />
**LogicalName**: statuscode<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Status<br />
**Options**:

- **Value**: 1 **Label**: Active **State**: 0
- **Value**: 2 **Label**: Inactive **State**: 1



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

**Description**: For internal use only.<br />
**DisplayName**: Time Zone Rule Version Number<br />
**LogicalName**: timezoneruleversionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

**Description**: Shows the time zone code that was in use when the record was created.<br />
**DisplayName**: UTC Conversion Time Zone Code<br />
**LogicalName**: utcconversiontimezonecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -1

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_FilterLayoutName](#BKMK_msdyn_FilterLayoutName)
- [msdyn_ResourceCellTemplateName](#BKMK_msdyn_ResourceCellTemplateName)
- [msdyn_RetrieveResourcesQueryName](#BKMK_msdyn_RetrieveResourcesQueryName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
**DisplayName**: Created By (Delegate)<br />
**LogicalName**: createdonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Shows who last updated the record on behalf of another user.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_FilterLayoutName"></a> msdyn_FilterLayoutName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_filterlayoutname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_ResourceCellTemplateName"></a> msdyn_ResourceCellTemplateName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_resourcecelltemplatename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RetrieveResourcesQueryName"></a> msdyn_RetrieveResourcesQueryName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_retrieveresourcesqueryname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Type the name of the owner.<br />
**DisplayName**: <br />
**LogicalName**: owneridname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Description**: Shows the Yomi name of the owner.<br />
**DisplayName**: <br />
**LogicalName**: owneridyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier for the business unit that owns the record<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier for the team that owns the record.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: Version Number<br />
**DisplayName**: Version Number<br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_scheduleboardsetting_SyncErrors](#BKMK_msdyn_scheduleboardsetting_SyncErrors)
- [msdyn_scheduleboardsetting_DuplicateMatchingRecord](#BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord)
- [msdyn_scheduleboardsetting_DuplicateBaseRecord](#BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord)
- [msdyn_scheduleboardsetting_AsyncOperations](#BKMK_msdyn_scheduleboardsetting_AsyncOperations)
- [msdyn_scheduleboardsetting_MailboxTrackingFolders](#BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders)
- [msdyn_scheduleboardsetting_UserEntityInstanceDatas](#BKMK_msdyn_scheduleboardsetting_UserEntityInstanceDatas)
- [msdyn_scheduleboardsetting_ProcessSession](#BKMK_msdyn_scheduleboardsetting_ProcessSession)
- [msdyn_scheduleboardsetting_BulkDeleteFailures](#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures)
- [msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid](#BKMK_msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid)


### <a name="BKMK_msdyn_scheduleboardsetting_SyncErrors"></a> msdyn_scheduleboardsetting_SyncErrors

Same as syncerror entity [msdyn_scheduleboardsetting_SyncErrors](syncerror.md#BKMK_msdyn_scheduleboardsetting_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_scheduleboardsetting_SyncErrors<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord"></a> msdyn_scheduleboardsetting_DuplicateMatchingRecord

Same as duplicaterecord entity [msdyn_scheduleboardsetting_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: duplicaterecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_scheduleboardsetting_DuplicateMatchingRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord"></a> msdyn_scheduleboardsetting_DuplicateBaseRecord

Same as duplicaterecord entity [msdyn_scheduleboardsetting_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord) Many-To-One relationship.

**ReferencingEntity**: duplicaterecord<br />
**ReferencingAttribute**: baserecordid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_scheduleboardsetting_DuplicateBaseRecord<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_scheduleboardsetting_AsyncOperations"></a> msdyn_scheduleboardsetting_AsyncOperations

Same as asyncoperation entity [msdyn_scheduleboardsetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_scheduleboardsetting_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_scheduleboardsetting_AsyncOperations<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders"></a> msdyn_scheduleboardsetting_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_scheduleboardsetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_scheduleboardsetting_MailboxTrackingFolders<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: Cascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: Cascade
- **Share**: Cascade
- **Unshare**: Cascade


### <a name="BKMK_msdyn_scheduleboardsetting_UserEntityInstanceDatas"></a> msdyn_scheduleboardsetting_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_scheduleboardsetting_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_scheduleboardsetting_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_scheduleboardsetting_UserEntityInstanceDatas<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_scheduleboardsetting_ProcessSession"></a> msdyn_scheduleboardsetting_ProcessSession

Same as processsession entity [msdyn_scheduleboardsetting_ProcessSession](processsession.md#BKMK_msdyn_scheduleboardsetting_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_scheduleboardsetting_ProcessSession<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: NoCascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures"></a> msdyn_scheduleboardsetting_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_scheduleboardsetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_scheduleboardsetting_BulkDeleteFailures<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses"></a> msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses<br />
**AssociatedMenuConfiguration**:

- **Behavior**: DoNotDisplay
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: Cascade
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid"></a> msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid

Same as msdyn_clientextension entity [msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid](msdyn_clientextension.md#BKMK_msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid) Many-To-One relationship.

**ReferencingEntity**: msdyn_clientextension<br />
**ReferencingAttribute**: msdyn_scheduleboardsettingid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 10000

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_scheduleboardsetting_createdby](#BKMK_lk_msdyn_scheduleboardsetting_createdby)
- [lk_msdyn_scheduleboardsetting_createdonbehalfby](#BKMK_lk_msdyn_scheduleboardsetting_createdonbehalfby)
- [lk_msdyn_scheduleboardsetting_modifiedby](#BKMK_lk_msdyn_scheduleboardsetting_modifiedby)
- [lk_msdyn_scheduleboardsetting_modifiedonbehalfby](#BKMK_lk_msdyn_scheduleboardsetting_modifiedonbehalfby)
- [user_msdyn_scheduleboardsetting](#BKMK_user_msdyn_scheduleboardsetting)
- [team_msdyn_scheduleboardsetting](#BKMK_team_msdyn_scheduleboardsetting)
- [business_unit_msdyn_scheduleboardsetting](#BKMK_business_unit_msdyn_scheduleboardsetting)
- [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout](#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout)
- [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate](#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate)
- [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery](#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery)


### <a name="BKMK_lk_msdyn_scheduleboardsetting_createdby"></a> lk_msdyn_scheduleboardsetting_createdby

See systemuser Entity [lk_msdyn_scheduleboardsetting_createdby](systemuser.md#BKMK_lk_msdyn_scheduleboardsetting_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_scheduleboardsetting_createdonbehalfby"></a> lk_msdyn_scheduleboardsetting_createdonbehalfby

See systemuser Entity [lk_msdyn_scheduleboardsetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_scheduleboardsetting_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_scheduleboardsetting_modifiedby"></a> lk_msdyn_scheduleboardsetting_modifiedby

See systemuser Entity [lk_msdyn_scheduleboardsetting_modifiedby](systemuser.md#BKMK_lk_msdyn_scheduleboardsetting_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_scheduleboardsetting_modifiedonbehalfby"></a> lk_msdyn_scheduleboardsetting_modifiedonbehalfby

See systemuser Entity [lk_msdyn_scheduleboardsetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_scheduleboardsetting_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_scheduleboardsetting"></a> user_msdyn_scheduleboardsetting

See systemuser Entity [user_msdyn_scheduleboardsetting](systemuser.md#BKMK_user_msdyn_scheduleboardsetting) One-To-Many relationship.

### <a name="BKMK_team_msdyn_scheduleboardsetting"></a> team_msdyn_scheduleboardsetting

See team Entity [team_msdyn_scheduleboardsetting](team.md#BKMK_team_msdyn_scheduleboardsetting) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_scheduleboardsetting"></a> business_unit_msdyn_scheduleboardsetting

See businessunit Entity [business_unit_msdyn_scheduleboardsetting](businessunit.md#BKMK_business_unit_msdyn_scheduleboardsetting) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout"></a> msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate"></a> msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery"></a> msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_scheduleboardsetting?text=msdyn_scheduleboardsetting EntityType" />