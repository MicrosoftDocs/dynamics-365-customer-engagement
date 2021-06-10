---
title: "msdyn_scheduleboardsetting Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_scheduleboardsetting entity."
ms.date: 04/02/2019
ms.service: "crm-online"
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
manager: "annbe"
search.audienceType: 
  - developer

---
# msdyn_scheduleboardsetting Entity Reference

To store settings of SB by user & tabs

**Added by**: Universal Resource Scheduling Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_scheduleboardsettinges(*msdyn_scheduleboardsettingid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_scheduleboardsettings|
|DisplayCollectionName|Schedule Board Settings|
|DisplayName|Schedule Board Setting|
|EntitySetName|msdyn_scheduleboardsettinges|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_scheduleboardsettings|
|LogicalName|msdyn_scheduleboardsetting|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_scheduleboardsettingid|
|PrimaryNameAttribute|msdyn_tabname|
|SchemaName|msdyn_scheduleboardsetting|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|--------|-----|
|Description|Shows the sequence number of the import that created this record.|
|DisplayName|Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|importsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_BookBasedOn"></a> msdyn_BookBasedOn

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Book Based On|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bookbasedon|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_BookBasedOn Options

|Value|Label|
|-----|-----|
|1|Estimated Arrival|
|0|Start of Travel|

**DefaultValue**: True



### <a name="BKMK_msdyn_CustomTabName"></a> msdyn_CustomTabName

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Custom Tab Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customtabname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CustomTabWebResource"></a> msdyn_CustomTabWebResource

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Custom Tab Web Resource|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customtabwebresource|
|MaxLength|255|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_FilterLayout"></a> msdyn_FilterLayout

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Filter Layout|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_filterlayout|
|RequiredLevel|None|
|Targets|msdyn_configuration|
|Type|Lookup|


### <a name="BKMK_msdyn_FilterValues"></a> msdyn_FilterValues

|Property|Value|
|--------|-----|
|Description|Storing filter values as Json string.|
|DisplayName|Filter Values|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_filtervalues|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_FullyBookedColor"></a> msdyn_FullyBookedColor

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Fully Booked Color|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_fullybookedcolor|
|MaxLength|100|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_HideCancelled"></a> msdyn_HideCancelled

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Hide Canceled|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_hidecancelled|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_HideCancelled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_IsPublic"></a> msdyn_IsPublic

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Public (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ispublic|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_IsPublic Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_IsSynchronizeResources"></a> msdyn_IsSynchronizeResources

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Is Synchronize Resources|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_issynchronizeresources|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_IsSynchronizeResources Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_MapViewTabPlacement"></a> msdyn_MapViewTabPlacement

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Map View Tab Placement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_mapviewtabplacement|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_MapViewTabPlacement Options

|Value|Label|
|-----|-----|
|1|Details|
|0|Filter|

**DefaultValue**: False



### <a name="BKMK_msdyn_NotBookedColor"></a> msdyn_NotBookedColor

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Not Booked Color|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_notbookedcolor|
|MaxLength|100|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_OrderNumber"></a> msdyn_OrderNumber

|Property|Value|
|--------|-----|
|Description|Tab index.|
|DisplayName|Order Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_ordernumber|
|MaxValue|100|
|MinValue|0|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_msdyn_OrganizationalUnitTooltipsViewId"></a> msdyn_OrganizationalUnitTooltipsViewId

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Organizational Unit Tooltips View Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_organizationalunittooltipsviewid|
|MaxLength|100|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_OrganizationalUnitViewId"></a> msdyn_OrganizationalUnitViewId

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Organizational Unit View Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_organizationalunitviewid|
|MaxLength|100|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_OverbookedColor"></a> msdyn_OverbookedColor

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Overbooked Color|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_overbookedcolor|
|MaxLength|100|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_PartiallyBookedColor"></a> msdyn_PartiallyBookedColor

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Partially Booked Color|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_partiallybookedcolor|
|MaxLength|100|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_ResourceCellTemplate"></a> msdyn_ResourceCellTemplate

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Resource Cell Template|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecelltemplate|
|RequiredLevel|None|
|Targets|msdyn_configuration|
|Type|Lookup|


### <a name="BKMK_msdyn_RetrieveResourcesQuery"></a> msdyn_RetrieveResourcesQuery

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Retrieve Resources Query|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_retrieveresourcesquery|
|RequiredLevel|None|
|Targets|msdyn_configuration|
|Type|Lookup|


### <a name="BKMK_msdyn_SAAvailableColor"></a> msdyn_SAAvailableColor

|Property|Value|
|--------|-----|
|Description||
|DisplayName|SA Available Color|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_saavailablecolor|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SAAvailableIcon"></a> msdyn_SAAvailableIcon

|Property|Value|
|--------|-----|
|Description||
|DisplayName|SA Available Icon|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_saavailableicon|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SAAvailableIconDefault"></a> msdyn_SAAvailableIconDefault

|Property|Value|
|--------|-----|
|Description|Is available icon inheriting from default setting.|
|DisplayName|SA Available Icon Default|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_saavailableicondefault|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_SAAvailableIconDefault Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_SAPartiallyAvailableColor"></a> msdyn_SAPartiallyAvailableColor

|Property|Value|
|--------|-----|
|Description||
|DisplayName|SA Partially Available Color|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_sapartiallyavailablecolor|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SAPartiallyAvailableIcon"></a> msdyn_SAPartiallyAvailableIcon

|Property|Value|
|--------|-----|
|Description||
|DisplayName|SA Partially Available Icon|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_sapartiallyavailableicon|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SAPartiallyAvailableIconDefault"></a> msdyn_SAPartiallyAvailableIconDefault

|Property|Value|
|--------|-----|
|Description|Is partially available icon inheriting from default setting.|
|DisplayName|SA Partially Available Icon Default|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_sapartiallyavailableicondefault|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_SAPartiallyAvailableIconDefault Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_SAUnavailableColor"></a> msdyn_SAUnavailableColor

|Property|Value|
|--------|-----|
|Description||
|DisplayName|SA Unavailable Color|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_saunavailablecolor|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SAUnavailableIcon"></a> msdyn_SAUnavailableIcon

|Property|Value|
|--------|-----|
|Description||
|DisplayName|SA Unavailable Icon|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_saunavailableicon|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SAUnavailableIconDefault"></a> msdyn_SAUnavailableIconDefault

|Property|Value|
|--------|-----|
|Description|Is unavailable icon inheriting from default setting.|
|DisplayName|SA Unavailable Icon Default|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_saunavailableicondefault|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_SAUnavailableIconDefault Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_scheduleboardsettingId"></a> msdyn_scheduleboardsettingId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Schedule Board Setting|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_scheduleboardsettingid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_SchedulerAlertsView"></a> msdyn_SchedulerAlertsView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Alerts View|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_scheduleralertsview|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerBusinessUnitDetailsView"></a> msdyn_SchedulerBusinessUnitDetailsView

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Unit Details View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerbusinessunitdetailsview|
|MaxLength|40|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerBusinessUnitTooltipView"></a> msdyn_SchedulerBusinessUnitTooltipView

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Business Unit Tooltips View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerbusinessunittooltipview|
|MaxLength|40|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerCoreDetailsView"></a> msdyn_SchedulerCoreDetailsView

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Core Details View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulercoredetailsview|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerCoreSlotTextTemplate"></a> msdyn_SchedulerCoreSlotTextTemplate

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Core Slot Text Template (Deprecated)|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulercoreslottexttemplate|
|MaxLength|5000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_SchedulerCoreTooltipView"></a> msdyn_SchedulerCoreTooltipView

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Core Tooltip View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulercoretooltipview|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerFieldServiceDetailsView"></a> msdyn_SchedulerFieldServiceDetailsView

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Field Service Details View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerfieldservicedetailsview|
|MaxLength|40|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerFieldServiceSlotTextTemplate"></a> msdyn_SchedulerFieldServiceSlotTextTemplate

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Field Service Slot Text Template (Deprecated)|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerfieldserviceslottexttemplate|
|MaxLength|8000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_SchedulerFieldServiceTooltipView"></a> msdyn_SchedulerFieldServiceTooltipView

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Field Service Tooltip View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerfieldservicetooltipview|
|MaxLength|40|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerResourceDetailsView"></a> msdyn_SchedulerResourceDetailsView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Resource Details View|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerresourcedetailsview|
|MaxLength|40|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_SchedulerResourceTooltipView"></a> msdyn_SchedulerResourceTooltipView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Resource Tooltips View|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerresourcetooltipview|
|MaxLength|40|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_Settings"></a> msdyn_Settings

|Property|Value|
|--------|-----|
|Description|Shows the settings as a JSON string.|
|DisplayName|Settings|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_settings|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_ShareType"></a> msdyn_ShareType

|Property|Value|
|--------|-----|
|Description|Field is used to determine if Schedule Board Tab are Private, Public or Shareable|
|DisplayName|Share Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_sharetype|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_ShareType Options

|Value|Label|
|-----|-----|
|192350000|Everyone|
|192350001|Just me|
|192350002|Specific people|
|192350003|System|



### <a name="BKMK_msdyn_TabName"></a> msdyn_TabName

|Property|Value|
|--------|-----|
|Description|Enter the tab name.|
|DisplayName|Tab name.|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_tabname|
|MaxLength|100|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_UnscheduledRequirementsViewId"></a> msdyn_UnscheduledRequirementsViewId

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Requirements View Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unscheduledrequirementsviewid|
|MaxLength|100|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_msdyn_UnscheduledViewId"></a> msdyn_UnscheduledViewId

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Unscheduled View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unscheduledviewid|
|MaxLength|40|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_UnscheduledWOPageRecCount"></a> msdyn_UnscheduledWOPageRecCount

|Property|Value|
|--------|-----|
|Description|Shows the number of records to be displayed per page in 'Resource Requirement' section.|
|DisplayName|Resource Requirement View Page Record Count|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unscheduledwopagereccount|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_msdyn_UnscheduledWOTooltipsViewId"></a> msdyn_UnscheduledWOTooltipsViewId

**Added by**: Field Service Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Unscheduled WO Tooltips View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unscheduledwotooltipsviewid|
|MaxLength|40|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkingHoursColor"></a> msdyn_WorkingHoursColor

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Working Hours Color|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workinghourscolor|
|MaxLength|10|
|RequiredLevel|Recommended|
|Type|String|


### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time that the record was migrated.|
|DisplayName|Record Created On|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|overriddencreatedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_OwnerId"></a> OwnerId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id|
|DisplayName|Owner|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Owner|


### <a name="BKMK_OwnerIdType"></a> OwnerIdType

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Owner Id Type|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|--------|-----|
|Description|Status of the Schedule Board Setting|
|DisplayName|Status|
|IsValidForCreate|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statecode|
|RequiredLevel|SystemRequired|
|Type|State|

#### statecode Options

|Value|Label|DefaultStatus|InvariantName|
|-----|-----|-------------|-------------|
|0|Active|1|Active|
|1|Inactive|2|Inactive|



### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|--------|-----|
|Description|Reason for the status of the Schedule Board Setting|
|DisplayName|Status Reason|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|statuscode|
|RequiredLevel|None|
|Type|Status|

#### statuscode Options

|Value|Label|State|
|-----|-----|-----|
|1|Active|0|
|2|Inactive|1|



### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Shows the time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|

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

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows who last updated the record on behalf of another user.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_msdyn_FilterLayoutName"></a> msdyn_FilterLayoutName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_filterlayoutname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ResourceCellTemplateName"></a> msdyn_ResourceCellTemplateName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecelltemplatename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RetrieveResourcesQueryName"></a> msdyn_RetrieveResourcesQueryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_retrieveresourcesqueryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwnerIdYomiName"></a> OwnerIdYomiName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Yomi name of the owner|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owneridyominame|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the business unit that owns the record|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|None|
|Targets|businessunit|
|Type|Lookup|


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the team that owns the record.|
|DisplayName|Owning Team|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningteam|
|RequiredLevel|None|
|Targets|team|
|Type|Lookup|


### <a name="BKMK_OwningUser"></a> OwningUser

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Version Number|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [msdyn_scheduleboardsetting_SyncErrors](#BKMK_msdyn_scheduleboardsetting_SyncErrors)
- [msdyn_scheduleboardsetting_DuplicateMatchingRecord](#BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord)
- [msdyn_scheduleboardsetting_DuplicateBaseRecord](#BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord)
- [msdyn_scheduleboardsetting_AsyncOperations](#BKMK_msdyn_scheduleboardsetting_AsyncOperations)
- [msdyn_scheduleboardsetting_MailboxTrackingFolders](#BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders)
- [msdyn_scheduleboardsetting_ProcessSession](#BKMK_msdyn_scheduleboardsetting_ProcessSession)
- [msdyn_scheduleboardsetting_BulkDeleteFailures](#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures)
- [msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses)
- [msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid](#BKMK_msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid)


### <a name="BKMK_msdyn_scheduleboardsetting_SyncErrors"></a> msdyn_scheduleboardsetting_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_scheduleboardsetting_SyncErrors](syncerror.md#BKMK_msdyn_scheduleboardsetting_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_scheduleboardsetting_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord"></a> msdyn_scheduleboardsetting_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_scheduleboardsetting_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_scheduleboardsetting_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord"></a> msdyn_scheduleboardsetting_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_scheduleboardsetting_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_scheduleboardsetting_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_scheduleboardsetting_AsyncOperations"></a> msdyn_scheduleboardsetting_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_scheduleboardsetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_scheduleboardsetting_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_scheduleboardsetting_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders"></a> msdyn_scheduleboardsetting_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_scheduleboardsetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_scheduleboardsetting_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_scheduleboardsetting_ProcessSession"></a> msdyn_scheduleboardsetting_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_scheduleboardsetting_ProcessSession](processsession.md#BKMK_msdyn_scheduleboardsetting_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_scheduleboardsetting_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures"></a> msdyn_scheduleboardsetting_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_scheduleboardsetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_scheduleboardsetting_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses"></a> msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid"></a> msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid

Same as msdyn_clientextension entity [msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid](msdyn_clientextension.md#BKMK_msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_clientextension|
|ReferencingAttribute|msdyn_scheduleboardsettingid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_scheduleboardsetting_msdyn_clientextension_scheduleboardsettingid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

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

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_scheduleboardsetting_createdby](systemuser.md#BKMK_lk_msdyn_scheduleboardsetting_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_scheduleboardsetting_createdonbehalfby"></a> lk_msdyn_scheduleboardsetting_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_scheduleboardsetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_scheduleboardsetting_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_scheduleboardsetting_modifiedby"></a> lk_msdyn_scheduleboardsetting_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_scheduleboardsetting_modifiedby](systemuser.md#BKMK_lk_msdyn_scheduleboardsetting_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_scheduleboardsetting_modifiedonbehalfby"></a> lk_msdyn_scheduleboardsetting_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_scheduleboardsetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_scheduleboardsetting_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_scheduleboardsetting"></a> user_msdyn_scheduleboardsetting

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_scheduleboardsetting](systemuser.md#BKMK_user_msdyn_scheduleboardsetting) One-To-Many relationship.

### <a name="BKMK_team_msdyn_scheduleboardsetting"></a> team_msdyn_scheduleboardsetting

**Added by**: System Solution Solution

See team Entity [team_msdyn_scheduleboardsetting](team.md#BKMK_team_msdyn_scheduleboardsetting) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_scheduleboardsetting"></a> business_unit_msdyn_scheduleboardsetting

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_scheduleboardsetting](businessunit.md#BKMK_business_unit_msdyn_scheduleboardsetting) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout"></a> msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_FilterLayout) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate"></a> msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_ResourceCellTemplate) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery"></a> msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery

See msdyn_configuration Entity [msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery](msdyn_configuration.md#BKMK_msdyn_msdyn_configuration_msdyn_scheduleboardsetting_RetrieveResourcesQuery) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_scheduleboardsetting?text=msdyn_scheduleboardsetting EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]