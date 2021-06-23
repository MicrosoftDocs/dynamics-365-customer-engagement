---
title: "msdyn_fieldservicesetting Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_fieldservicesetting entity."
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
# msdyn_fieldservicesetting Entity Reference

Settings controlling functionality related to Field Service

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_fieldservicesettings|
|DisplayCollectionName|Field Service Settings|
|DisplayName|Field Service Setting|
|EntitySetName|msdyn_fieldservicesettings|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_fieldservicesettings|
|LogicalName|msdyn_fieldservicesetting|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_fieldservicesettingid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_fieldservicesetting|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdvancedSettings](#BKMK_msdyn_AdvancedSettings)
- [msdyn_AgreementPrefix](#BKMK_msdyn_AgreementPrefix)
- [msdyn_AgreementRecordGeneration](#BKMK_msdyn_AgreementRecordGeneration)
- [msdyn_AgreementStartingNumber](#BKMK_msdyn_AgreementStartingNumber)
- [msdyn_AutoAllocateEstimatedProducts](#BKMK_msdyn_AutoAllocateEstimatedProducts)
- [msdyn_AutoGenerateWOforAgreementBookings](#BKMK_msdyn_AutoGenerateWOforAgreementBookings)
- [msdyn_AutoGeoCodeAddresses](#BKMK_msdyn_AutoGeoCodeAddresses)
- [msdyn_BookingAlertTemplate](#BKMK_msdyn_BookingAlertTemplate)
- [msdyn_BreakPayType](#BKMK_msdyn_BreakPayType)
- [msdyn_BusinessClosurePayType](#BKMK_msdyn_BusinessClosurePayType)
- [msdyn_CancelCurrentSlotsWhenMoving](#BKMK_msdyn_CancelCurrentSlotsWhenMoving)
- [msdyn_CustomGPSData](#BKMK_msdyn_CustomGPSData)
- [msdyn_CustomGPSLatitudefield](#BKMK_msdyn_CustomGPSLatitudefield)
- [msdyn_CustomGPSLocationentity](#BKMK_msdyn_CustomGPSLocationentity)
- [msdyn_CustomGPSLongitudefield](#BKMK_msdyn_CustomGPSLongitudefield)
- [msdyn_CustomGPSResourcefield](#BKMK_msdyn_CustomGPSResourcefield)
- [msdyn_CustomGPSTimestampfield](#BKMK_msdyn_CustomGPSTimestampfield)
- [msdyn_DatabaseVersion](#BKMK_msdyn_DatabaseVersion)
- [msdyn_DeactivateBookingWhenCanceled](#BKMK_msdyn_DeactivateBookingWhenCanceled)
- [msdyn_DeactivateBookingWhenCompleted](#BKMK_msdyn_DeactivateBookingWhenCompleted)
- [msdyn_DeactivateWorkOrderWhenCanceled](#BKMK_msdyn_DeactivateWorkOrderWhenCanceled)
- [msdyn_DeactivateWorkOrderWhenPosted](#BKMK_msdyn_DeactivateWorkOrderWhenPosted)
- [msdyn_DefaultBookingDuration](#BKMK_msdyn_DefaultBookingDuration)
- [msdyn_DefaultCanceledBookingStatus](#BKMK_msdyn_DefaultCanceledBookingStatus)
- [msdyn_DefaultRadiusUnit](#BKMK_msdyn_DefaultRadiusUnit)
- [msdyn_DefaultRadiusValue](#BKMK_msdyn_DefaultRadiusValue)
- [msdyn_DefaultScheduledBookingStatus](#BKMK_msdyn_DefaultScheduledBookingStatus)
- [msdyn_DefaultWarehouse](#BKMK_msdyn_DefaultWarehouse)
- [msdyn_DefaultWorkOrderCompletedStatus](#BKMK_msdyn_DefaultWorkOrderCompletedStatus)
- [msdyn_DisableRemoteAssistBookingStatusChanges](#BKMK_msdyn_DisableRemoteAssistBookingStatusChanges)
- [msdyn_EnableAddressSuggestions](#BKMK_msdyn_EnableAddressSuggestions)
- [msdyn_EnableLegacyScheduleAssistant](#BKMK_msdyn_EnableLegacyScheduleAssistant)
- [msdyn_EnableSuggestedDuration](#BKMK_msdyn_EnableSuggestedDuration)
- [msdyn_EntityNumberLength](#BKMK_msdyn_EntityNumberLength)
- [msdyn_fieldservicesettingId](#BKMK_msdyn_fieldservicesettingId)
- [msdyn_GenerateAgreementInvoicesXDaysInAdvance](#BKMK_msdyn_GenerateAgreementInvoicesXDaysInAdvance)
- [msdyn_GenerateAgreementWOXDaysInAdvance](#BKMK_msdyn_GenerateAgreementWOXDaysInAdvance)
- [msdyn_GenerateBookingDatesXMonthsInAdvance](#BKMK_msdyn_GenerateBookingDatesXMonthsInAdvance)
- [msdyn_GenerateInvoiceDatesXMonthsInAdvance](#BKMK_msdyn_GenerateInvoiceDatesXMonthsInAdvance)
- [msdyn_GPSLocationExpiresAfterXMinutes](#BKMK_msdyn_GPSLocationExpiresAfterXMinutes)
- [msdyn_HistoricalDataFilter](#BKMK_msdyn_HistoricalDataFilter)
- [msdyn_InventoryAdjustmentPrefix](#BKMK_msdyn_InventoryAdjustmentPrefix)
- [msdyn_InventoryAdjustmentStartingNumber](#BKMK_msdyn_InventoryAdjustmentStartingNumber)
- [msdyn_InventoryTransferPrefix](#BKMK_msdyn_InventoryTransferPrefix)
- [msdyn_InventoryTransferStartingNumber](#BKMK_msdyn_InventoryTransferStartingNumber)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_NotificationTimeout](#BKMK_msdyn_NotificationTimeout)
- [msdyn_OvertimePayType](#BKMK_msdyn_OvertimePayType)
- [msdyn_PostponeNumberCleanupUntil](#BKMK_msdyn_PostponeNumberCleanupUntil)
- [msdyn_ProductCostOrder](#BKMK_msdyn_ProductCostOrder)
- [msdyn_PurchaseOrderApprovalRequired](#BKMK_msdyn_PurchaseOrderApprovalRequired)
- [msdyn_PurchaseOrderPrefix](#BKMK_msdyn_PurchaseOrderPrefix)
- [msdyn_PurchaseOrderStartingNumber](#BKMK_msdyn_PurchaseOrderStartingNumber)
- [msdyn_ResourcesSynchronizationTimeout](#BKMK_msdyn_ResourcesSynchronizationTimeout)
- [msdyn_RMAPrefix](#BKMK_msdyn_RMAPrefix)
- [msdyn_RMAStartingNumber](#BKMK_msdyn_RMAStartingNumber)
- [msdyn_RTVPrefix](#BKMK_msdyn_RTVPrefix)
- [msdyn_RTVStartingNumber](#BKMK_msdyn_RTVStartingNumber)
- [msdyn_SAAutoFilterServiceTerritory](#BKMK_msdyn_SAAutoFilterServiceTerritory)
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
- [msdyn_SchedulerUnscheduledView](#BKMK_msdyn_SchedulerUnscheduledView)
- [msdyn_sdkapimapkey](#BKMK_msdyn_sdkapimapkey)
- [msdyn_TravelChargeItemId](#BKMK_msdyn_TravelChargeItemId)
- [msdyn_TravelPayType](#BKMK_msdyn_TravelPayType)
- [msdyn_TravelTimeRescheduling](#BKMK_msdyn_TravelTimeRescheduling)
- [msdyn_UndefinedBookingLocation](#BKMK_msdyn_UndefinedBookingLocation)
- [msdyn_UnscheduledWOTooltipsViewId](#BKMK_msdyn_UnscheduledWOTooltipsViewId)
- [msdyn_UseofProductsOutofStock](#BKMK_msdyn_UseofProductsOutofStock)
- [msdyn_WorkOrderInvoiceCreation](#BKMK_msdyn_WorkOrderInvoiceCreation)
- [msdyn_WorkOrderPrefix](#BKMK_msdyn_WorkOrderPrefix)
- [msdyn_WorkOrderStartingNumber](#BKMK_msdyn_WorkOrderStartingNumber)
- [msdyn_WorkPayType](#BKMK_msdyn_WorkPayType)
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


### <a name="BKMK_msdyn_AdvancedSettings"></a> msdyn_AdvancedSettings

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Advanced Settings|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_advancedsettings|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_AgreementPrefix"></a> msdyn_AgreementPrefix

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Agreement Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementprefix|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AgreementRecordGeneration"></a> msdyn_AgreementRecordGeneration

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|This field defines the time of day when Work Orders and Invoices are generated by the Agreement Booking Setups and Agreement Invoice Setups where the timing was not defined on the related Agreement.|
|DisplayName|Agreement Record Generation Timing|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementrecordgeneration|
|RequiredLevel|Recommended|
|Type|DateTime|


### <a name="BKMK_msdyn_AgreementStartingNumber"></a> msdyn_AgreementStartingNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Agreement Starting Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementstartingnumber|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_AutoAllocateEstimatedProducts"></a> msdyn_AutoAllocateEstimatedProducts

|Property|Value|
|--------|-----|
|Description|If enabled then Allocated will be automatically set when entering a Work order Product with a Line Status of Estimate.|
|DisplayName|Auto Allocate Estimated Products|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_autoallocateestimatedproducts|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_AutoAllocateEstimatedProducts Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_AutoGenerateWOforAgreementBookings"></a> msdyn_AutoGenerateWOforAgreementBookings

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Auto Generate WO for Agreement Booking|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_autogeneratewoforagreementbooking|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_AutoGenerateWOforAgreementBookings Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_AutoGeoCodeAddresses"></a> msdyn_AutoGeoCodeAddresses

|Property|Value|
|--------|-----|
|Description|If set then the system will automatically geo code addresses when the address has been updated and the record is saved|
|DisplayName|Auto Geo Code Addresses|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_autogeocodeaddresses|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_AutoGeoCodeAddresses Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_BookingAlertTemplate"></a> msdyn_BookingAlertTemplate

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Booking Alert Template (Deprecated)|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bookingalerttemplate|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_BreakPayType"></a> msdyn_BreakPayType

|Property|Value|
|--------|-----|
|Description|Default Pay Type to be used for Break hours|
|DisplayName|Break Pay Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_breakpaytype|
|RequiredLevel|None|
|Targets|msdyn_resourcepaytype|
|Type|Lookup|


### <a name="BKMK_msdyn_BusinessClosurePayType"></a> msdyn_BusinessClosurePayType

|Property|Value|
|--------|-----|
|Description|Default Pay Type to be used for business closure work hours|
|DisplayName|Business Closure Pay Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_businessclosurepaytype|
|RequiredLevel|None|
|Targets|msdyn_resourcepaytype|
|Type|Lookup|


### <a name="BKMK_msdyn_CancelCurrentSlotsWhenMoving"></a> msdyn_CancelCurrentSlotsWhenMoving

|Property|Value|
|--------|-----|
|Description|Select whether, when moving open slots to the next day, to leave the old slots and change their status to "Cancel."|
|DisplayName|Cancel Current Slots When Moving (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_cancelcurrentslotswhenmoving|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_CancelCurrentSlotsWhenMoving Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_CustomGPSData"></a> msdyn_CustomGPSData

|Property|Value|
|--------|-----|
|Description|If enabled system will use custom entity for its source of Geo Locations for resources to be displayed on map view|
|DisplayName|Custom GPS Data (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customgpsdata|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_CustomGPSData Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_CustomGPSLatitudefield"></a> msdyn_CustomGPSLatitudefield

|Property|Value|
|--------|-----|
|Description|Shows the logical name of the latitude field to be used for geolocations.|
|DisplayName|Custom GPS Latitude field (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customgpslatitudefield|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CustomGPSLocationentity"></a> msdyn_CustomGPSLocationentity

|Property|Value|
|--------|-----|
|Description|Shows the logical name of custom entity to be used for geolocations.|
|DisplayName|Custom GPS Location entity (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customgpslocationentity|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CustomGPSLongitudefield"></a> msdyn_CustomGPSLongitudefield

|Property|Value|
|--------|-----|
|Description|Shows the logical name of the longitude field to be used for geolocations.|
|DisplayName|Custom GPS Longitude field (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customgpslongitudefield|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CustomGPSResourcefield"></a> msdyn_CustomGPSResourcefield

|Property|Value|
|--------|-----|
|Description|Shows the logical name of the resource field to be used for geolocations.|
|DisplayName|Custom GPS Resource field (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customgpsresourcefield|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_CustomGPSTimestampfield"></a> msdyn_CustomGPSTimestampfield

|Property|Value|
|--------|-----|
|Description|Shows the logical name of the timestamp field to be used for geolocations.|
|DisplayName|Custom GPS Timestamp field (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customgpstimestampfield|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DatabaseVersion"></a> msdyn_DatabaseVersion

|Property|Value|
|--------|-----|
|Description|For Internal Use|
|DisplayName|Database Version|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_databaseversion|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_DeactivateBookingWhenCanceled"></a> msdyn_DeactivateBookingWhenCanceled

|Property|Value|
|--------|-----|
|Description|Select whether the system should deactivate the resource booking when the system status is changed to "Canceled."|
|DisplayName|Deactivate Booking When Canceled (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deactivatebookingwhencanceled|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_DeactivateBookingWhenCanceled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_DeactivateBookingWhenCompleted"></a> msdyn_DeactivateBookingWhenCompleted

|Property|Value|
|--------|-----|
|Description|Select whether the system should deactivate the resource booking when the system status is changed to "Completed."|
|DisplayName|Deactivate Booking When Completed (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deactivatebookingwhencompleted|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_DeactivateBookingWhenCompleted Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_DeactivateWorkOrderWhenCanceled"></a> msdyn_DeactivateWorkOrderWhenCanceled

|Property|Value|
|--------|-----|
|Description|Select whether the system should deactivate the work order when the system status is changed to "Closed - Canceled."|
|DisplayName|Deactivate Work Order When Canceled (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deactivateworkorderwhencanceled|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_DeactivateWorkOrderWhenCanceled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_DeactivateWorkOrderWhenPosted"></a> msdyn_DeactivateWorkOrderWhenPosted

|Property|Value|
|--------|-----|
|Description|Select whether the system should deactivate the work order when the system status is changed to "Closed - Posted."|
|DisplayName|Deactivate Work Order When Posted (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_deactivateworkorderwhenposted|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_DeactivateWorkOrderWhenPosted Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_DefaultBookingDuration"></a> msdyn_DefaultBookingDuration

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Default Booking Duration (Deprecated)|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultbookingduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_DefaultCanceledBookingStatus"></a> msdyn_DefaultCanceledBookingStatus

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Default Canceled Booking Status (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultcanceledbookingstatus|
|RequiredLevel|None|
|Targets|bookingstatus|
|Type|Lookup|


### <a name="BKMK_msdyn_DefaultRadiusUnit"></a> msdyn_DefaultRadiusUnit

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Default Radius Unit (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultradiusunit|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_DefaultRadiusUnit Options

|Value|Label|
|-----|-----|
|1|mi|
|0|km|

**DefaultValue**: True



### <a name="BKMK_msdyn_DefaultRadiusValue"></a> msdyn_DefaultRadiusValue

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Default Radius Value (Deprecated)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultradiusvalue|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_DefaultScheduledBookingStatus"></a> msdyn_DefaultScheduledBookingStatus

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Default Scheduled Booking Status (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultscheduledbookingstatus|
|RequiredLevel|None|
|Targets|bookingstatus|
|Type|Lookup|


### <a name="BKMK_msdyn_DefaultWarehouse"></a> msdyn_DefaultWarehouse

|Property|Value|
|--------|-----|
|Description|Shows the warehouse associated with the field service setting.|
|DisplayName|Default Warehouse|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultwarehouse|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_warehouse|
|Type|Lookup|


### <a name="BKMK_msdyn_DefaultWorkOrderCompletedStatus"></a> msdyn_DefaultWorkOrderCompletedStatus

|Property|Value|
|--------|-----|
|Description|Select whether the default work order completed status is either "Completed" or "Posted."|
|DisplayName|Default Work Order Completed Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_defaultworkordercompletedstatus|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_DefaultWorkOrderCompletedStatus Options

|Value|Label|
|-----|-----|
|690970000|Open - Unscheduled|
|690970001|Open - Scheduled|
|690970002|Open - In Progress|
|690970003|Open - Completed|
|690970004|Closed - Posted|
|690970005|Closed - Canceled|



### <a name="BKMK_msdyn_DisableRemoteAssistBookingStatusChanges"></a> msdyn_DisableRemoteAssistBookingStatusChanges

|Property|Value|
|--------|-----|
|Description|Specifies whether users can make booking status changes in the Remote Assist application.|
|DisplayName|Disable Booking Status Changes on Remote Assist|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_disableremoteassistbookingstatuschanges|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_DisableRemoteAssistBookingStatusChanges Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_EnableAddressSuggestions"></a> msdyn_EnableAddressSuggestions

|Property|Value|
|--------|-----|
|Description|If enabled then address suggestions will be displayed when editing the address on the account, contact, user, or work order form.|
|DisplayName|Enable Address Suggestions|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enableaddresssuggestions|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_EnableAddressSuggestions Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_msdyn_EnableLegacyScheduleAssistant"></a> msdyn_EnableLegacyScheduleAssistant

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Enable Legacy Schedule Assistant (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enablelegacyscheduleassistant|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_EnableLegacyScheduleAssistant Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_EnableSuggestedDuration"></a> msdyn_EnableSuggestedDuration

|Property|Value|
|--------|-----|
|Description|Enable Suggested Duration for Incident Type. System will calculate Suggested Duration daily or on demand based on historical bookings|
|DisplayName|Enables the suggested duration functionality|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enablesuggestedduration|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_EnableSuggestedDuration Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_EntityNumberLength"></a> msdyn_EntityNumberLength

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Entity Number Length|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_entitynumberlength|
|MaxValue|10|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_fieldservicesettingId"></a> msdyn_fieldservicesettingId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Field Service Setting|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_fieldservicesettingid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_GenerateAgreementInvoicesXDaysInAdvance"></a> msdyn_GenerateAgreementInvoicesXDaysInAdvance

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Generate Agreement Invoices X Days In Advance|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_generateagreementinvoicesxdaysinadvance|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_GenerateAgreementWOXDaysInAdvance"></a> msdyn_GenerateAgreementWOXDaysInAdvance

|Property|Value|
|--------|-----|
|Description|Specify default how many days in advance of the Agreement Booking Date the system should automatically generate a Work Order|
|DisplayName|Generate Agreement WO X Days In Advance|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_generateagreementwoxdaysinadvance|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_GenerateBookingDatesXMonthsInAdvance"></a> msdyn_GenerateBookingDatesXMonthsInAdvance

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Generate Booking Dates X Months In Advance|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_generatebookingdatesxmonthsinadvance|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_msdyn_GenerateInvoiceDatesXMonthsInAdvance"></a> msdyn_GenerateInvoiceDatesXMonthsInAdvance

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Generate Invoice Dates X Months In Advance|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_generateinvoicedatesxmonthsinadvance|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|ApplicationRequired|
|Type|Integer|


### <a name="BKMK_msdyn_GPSLocationExpiresAfterXMinutes"></a> msdyn_GPSLocationExpiresAfterXMinutes

|Property|Value|
|--------|-----|
|Description||
|DisplayName|GPS Location Expires After X Minutes (Deprecated)|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_gpslocationexpiresafterxminutes|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_HistoricalDataFilter"></a> msdyn_HistoricalDataFilter

|Property|Value|
|--------|-----|
|Description|Choose the range of date to use for suggested duration calculation|
|DisplayName|Historical Data Filter|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_historicaldatafilter|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_HistoricalDataFilter Options

|Value|Label|
|-----|-----|
|100000000|Last 3 Months|
|100000001|Last 6 Months|
|100000002|Last 12 Months|
|100000003|All|



### <a name="BKMK_msdyn_InventoryAdjustmentPrefix"></a> msdyn_InventoryAdjustmentPrefix

|Property|Value|
|--------|-----|
|Description|Shows the prefix to be added to the inventory adjustment numbers.|
|DisplayName|Inventory Adjustment Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_inventoryadjustmentprefix|
|MaxLength|25|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_InventoryAdjustmentStartingNumber"></a> msdyn_InventoryAdjustmentStartingNumber

|Property|Value|
|--------|-----|
|Description|Shows the number to be used as the starting number for inventory adjustments.|
|DisplayName|Inventory Adjustment Starting Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_inventoryadjustmentstartingnumber|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_InventoryTransferPrefix"></a> msdyn_InventoryTransferPrefix

|Property|Value|
|--------|-----|
|Description|Shows the prefix to be added to the inventory transfer numbers.|
|DisplayName|Inventory Transfer Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_inventorytransferprefix|
|MaxLength|25|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_InventoryTransferStartingNumber"></a> msdyn_InventoryTransferStartingNumber

|Property|Value|
|--------|-----|
|Description|Shows the number to be used as the starting number for inventory transfers.|
|DisplayName|Inventory Transfer Starting Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_inventorytransferstartingnumber|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|Enter the name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_NotificationTimeout"></a> msdyn_NotificationTimeout

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Notification Timeout (In sec) (Deprecated)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_notificationtimeout|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_OvertimePayType"></a> msdyn_OvertimePayType

|Property|Value|
|--------|-----|
|Description|Default Pay Type to be used for overtime work hours|
|DisplayName|Overtime Pay Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_overtimepaytype|
|RequiredLevel|None|
|Targets|msdyn_resourcepaytype|
|Type|Lookup|


### <a name="BKMK_msdyn_PostponeNumberCleanupUntil"></a> msdyn_PostponeNumberCleanupUntil

|Property|Value|
|--------|-----|
|DateTimeBehavior|TimeZoneIndependent|
|Description|Shows the date when cleanup of unique numbers will occur.|
|DisplayName|Postpone Number Cleanup Until|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_postponenumbercleanupuntil|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_ProductCostOrder"></a> msdyn_ProductCostOrder

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Product Cost Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_productcostorder|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_ProductCostOrder Options

|Value|Label|
|-----|-----|
|690970000|Standard/Current|
|690970001|Current/Standard|



### <a name="BKMK_msdyn_PurchaseOrderApprovalRequired"></a> msdyn_PurchaseOrderApprovalRequired

|Property|Value|
|--------|-----|
|Description|Enable if a Purchase Order requires approval in order for the status to be changed to Submitted|
|DisplayName|Purchase Order Approval Required|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderapprovalrequired|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_PurchaseOrderApprovalRequired Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_PurchaseOrderPrefix"></a> msdyn_PurchaseOrderPrefix

|Property|Value|
|--------|-----|
|Description|Shows the prefix to be added to the purchase order numbers.|
|DisplayName|Purchase Order Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderprefix|
|MaxLength|25|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PurchaseOrderStartingNumber"></a> msdyn_PurchaseOrderStartingNumber

|Property|Value|
|--------|-----|
|Description|Shows the number to be used as starting number for the automatically generated purchase order number.|
|DisplayName|Purchase Order Starting Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderstartingnumber|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_ResourcesSynchronizationTimeout"></a> msdyn_ResourcesSynchronizationTimeout

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Resources Synchronization Timeout (Deprecated)|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcessynchronizationtimeout|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_RMAPrefix"></a> msdyn_RMAPrefix

|Property|Value|
|--------|-----|
|Description||
|DisplayName|RMA Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_rmaprefix|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RMAStartingNumber"></a> msdyn_RMAStartingNumber

|Property|Value|
|--------|-----|
|Description|Shows the number to be used as the starting number for the automatically generation RMA number.|
|DisplayName|RMA Starting Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_rmastartingnumber|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_RTVPrefix"></a> msdyn_RTVPrefix

|Property|Value|
|--------|-----|
|Description||
|DisplayName|RTV Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_rtvprefix|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_RTVStartingNumber"></a> msdyn_RTVStartingNumber

|Property|Value|
|--------|-----|
|Description|Shows the number to be used as the starting number for the automatically generated RTV number.|
|DisplayName|RTV Starting Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_rtvstartingnumber|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_SAAutoFilterServiceTerritory"></a> msdyn_SAAutoFilterServiceTerritory

|Property|Value|
|--------|-----|
|Description|Select whether the schedule assistant should automatically filter the results based on the territory set on the work order.|
|DisplayName|Auto Filter Service Territory (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_saautofilterserviceterritory|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_SAAutoFilterServiceTerritory Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_SchedulerBusinessUnitDetailsView"></a> msdyn_SchedulerBusinessUnitDetailsView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Business Unit Details View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerbusinessunitdetailsview|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerBusinessUnitTooltipView"></a> msdyn_SchedulerBusinessUnitTooltipView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Business Unit Tooltip View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerbusinessunittooltipview|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerCoreDetailsView"></a> msdyn_SchedulerCoreDetailsView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Core Details View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulercoredetailsview|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerCoreSlotTextTemplate"></a> msdyn_SchedulerCoreSlotTextTemplate

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Core Slot Text Template (Deprecated)|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulercoreslottexttemplate|
|MaxLength|5000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_SchedulerCoreTooltipView"></a> msdyn_SchedulerCoreTooltipView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Core Tooltip View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulercoretooltipview|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerFieldServiceDetailsView"></a> msdyn_SchedulerFieldServiceDetailsView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Field Service Details View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerfieldservicedetailsview|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerFieldServiceSlotTextTemplate"></a> msdyn_SchedulerFieldServiceSlotTextTemplate

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Field Service Slot Text Template (Deprecated)|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerfieldserviceslottexttemplate|
|MaxLength|5000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_SchedulerFieldServiceTooltipView"></a> msdyn_SchedulerFieldServiceTooltipView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Field Service Tooltip View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerfieldservicetooltipview|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerResourceDetailsView"></a> msdyn_SchedulerResourceDetailsView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Resource Details View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerresourcedetailsview|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerResourceTooltipView"></a> msdyn_SchedulerResourceTooltipView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Resource Tooltip View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerresourcetooltipview|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SchedulerUnscheduledView"></a> msdyn_SchedulerUnscheduledView

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Scheduler Unscheduled View (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_schedulerunscheduledview|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_sdkapimapkey"></a> msdyn_sdkapimapkey

|Property|Value|
|--------|-----|
|Description|Api key for map|
|DisplayName|Bing API Key (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_sdkapimapkey|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TravelChargeItemId"></a> msdyn_TravelChargeItemId

|Property|Value|
|--------|-----|
|Description|Product/Service to be used by the system for Travel Charges on Work Orders|
|DisplayName|Travel Charge Item|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_travelchargeitemid|
|RequiredLevel|None|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_msdyn_TravelPayType"></a> msdyn_TravelPayType

|Property|Value|
|--------|-----|
|Description|Default Pay Type to be used for Travel hours|
|DisplayName|Travel Pay Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_travelpaytype|
|RequiredLevel|None|
|Targets|msdyn_resourcepaytype|
|Type|Lookup|


### <a name="BKMK_msdyn_TravelTimeRescheduling"></a> msdyn_TravelTimeRescheduling

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Travel Time Rescheduling (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_traveltimerescheduling|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_TravelTimeRescheduling Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_UndefinedBookingLocation"></a> msdyn_UndefinedBookingLocation

|Property|Value|
|--------|-----|
|Description|Location for schedules where geo code info has not been defined|
|DisplayName|Undefined Booking Location (Deprecated)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_undefinedbookinglocation|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_UndefinedBookingLocation Options

|Value|Label|
|-----|-----|
|690970000|Previous Known Location|
|690970001|Ignore Location|



### <a name="BKMK_msdyn_UnscheduledWOTooltipsViewId"></a> msdyn_UnscheduledWOTooltipsViewId

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Unscheduled WO Tooltips View Id (Deprecated)|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unscheduledwotooltipsviewid|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_UseofProductsOutofStock"></a> msdyn_UseofProductsOutofStock

|Property|Value|
|--------|-----|
|Description|Specify how the system should react when trying to use products that are out of stock.|
|DisplayName|Use of Products Out of Stock|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_useofproductsoutofstock|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_UseofProductsOutofStock Options

|Value|Label|
|-----|-----|
|690970000|Confirm|
|690970001|Restrict|



### <a name="BKMK_msdyn_WorkOrderInvoiceCreation"></a> msdyn_WorkOrderInvoiceCreation

|Property|Value|
|--------|-----|
|Description|Specify whether the system should automatically generate an invoice for work orders.|
|DisplayName|Work Order Invoice Creation|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderinvoicecreation|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_WorkOrderInvoiceCreation Options

|Value|Label|
|-----|-----|
|690970000|Never|
|690970001|On Work Order Posted|



### <a name="BKMK_msdyn_WorkOrderPrefix"></a> msdyn_WorkOrderPrefix

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Work Order Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderprefix|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderStartingNumber"></a> msdyn_WorkOrderStartingNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Work Order Starting Number|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderstartingnumber|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_WorkPayType"></a> msdyn_WorkPayType

|Property|Value|
|--------|-----|
|Description|Default Pay Type to be used for regular work hours|
|DisplayName|Work Pay Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workpaytype|
|RequiredLevel|None|
|Targets|msdyn_resourcepaytype|
|Type|Lookup|


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
|Description|Status of the Field Service Setting|
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
|Description|Shows the reason for the status of the field service setting.|
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
- [msdyn_BreakPayTypeName](#BKMK_msdyn_BreakPayTypeName)
- [msdyn_BusinessClosurePayTypeName](#BKMK_msdyn_BusinessClosurePayTypeName)
- [msdyn_DefaultCanceledBookingStatusName](#BKMK_msdyn_DefaultCanceledBookingStatusName)
- [msdyn_DefaultScheduledBookingStatusName](#BKMK_msdyn_DefaultScheduledBookingStatusName)
- [msdyn_DefaultWarehouseName](#BKMK_msdyn_DefaultWarehouseName)
- [msdyn_OvertimePayTypeName](#BKMK_msdyn_OvertimePayTypeName)
- [msdyn_TravelChargeItemIdName](#BKMK_msdyn_TravelChargeItemIdName)
- [msdyn_TravelPayTypeName](#BKMK_msdyn_TravelPayTypeName)
- [msdyn_WorkPayTypeName](#BKMK_msdyn_WorkPayTypeName)
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
|Description|Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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
|Description|Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.|
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


### <a name="BKMK_msdyn_BreakPayTypeName"></a> msdyn_BreakPayTypeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_breakpaytypename|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_BusinessClosurePayTypeName"></a> msdyn_BusinessClosurePayTypeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_businessclosurepaytypename|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultCanceledBookingStatusName"></a> msdyn_DefaultCanceledBookingStatusName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultcanceledbookingstatusname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultScheduledBookingStatusName"></a> msdyn_DefaultScheduledBookingStatusName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultscheduledbookingstatusname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DefaultWarehouseName"></a> msdyn_DefaultWarehouseName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_defaultwarehousename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_OvertimePayTypeName"></a> msdyn_OvertimePayTypeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_overtimepaytypename|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TravelChargeItemIdName"></a> msdyn_TravelChargeItemIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_travelchargeitemidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TravelPayTypeName"></a> msdyn_TravelPayTypeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_travelpaytypename|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkPayTypeName"></a> msdyn_WorkPayTypeName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workpaytypename|
|MaxLength|200|
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

- [msdyn_fieldservicesetting_ActivityPointers](#BKMK_msdyn_fieldservicesetting_ActivityPointers)
- [msdyn_fieldservicesetting_msdyn_bookingalerts](#BKMK_msdyn_fieldservicesetting_msdyn_bookingalerts)
- [msdyn_fieldservicesetting_msdyn_approvals](#BKMK_msdyn_fieldservicesetting_msdyn_approvals)
- [msdyn_fieldservicesetting_SyncErrors](#BKMK_msdyn_fieldservicesetting_SyncErrors)
- [msdyn_fieldservicesetting_AsyncOperations](#BKMK_msdyn_fieldservicesetting_AsyncOperations)
- [msdyn_fieldservicesetting_MailboxTrackingFolders](#BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders)
- [msdyn_fieldservicesetting_ProcessSession](#BKMK_msdyn_fieldservicesetting_ProcessSession)
- [msdyn_fieldservicesetting_BulkDeleteFailures](#BKMK_msdyn_fieldservicesetting_BulkDeleteFailures)
- [msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses)
- [msdyn_fieldservicesetting_Appointments](#BKMK_msdyn_fieldservicesetting_Appointments)
- [msdyn_fieldservicesetting_Emails](#BKMK_msdyn_fieldservicesetting_Emails)
- [msdyn_fieldservicesetting_Faxes](#BKMK_msdyn_fieldservicesetting_Faxes)
- [msdyn_fieldservicesetting_Letters](#BKMK_msdyn_fieldservicesetting_Letters)
- [msdyn_fieldservicesetting_PhoneCalls](#BKMK_msdyn_fieldservicesetting_PhoneCalls)
- [msdyn_fieldservicesetting_Tasks](#BKMK_msdyn_fieldservicesetting_Tasks)
- [msdyn_fieldservicesetting_RecurringAppointmentMasters](#BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters)
- [msdyn_fieldservicesetting_SocialActivities](#BKMK_msdyn_fieldservicesetting_SocialActivities)
- [msdyn_fieldservicesetting_Annotations](#BKMK_msdyn_fieldservicesetting_Annotations)
- [msdyn_fieldservicesetting_ServiceAppointments](#BKMK_msdyn_fieldservicesetting_ServiceAppointments)


### <a name="BKMK_msdyn_fieldservicesetting_ActivityPointers"></a> msdyn_fieldservicesetting_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_fieldservicesetting_ActivityPointers](activitypointer.md#BKMK_msdyn_fieldservicesetting_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesetting_msdyn_bookingalerts"></a> msdyn_fieldservicesetting_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_fieldservicesetting_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_fieldservicesetting_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_fieldservicesetting_msdyn_approvals"></a> msdyn_fieldservicesetting_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_fieldservicesetting_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_fieldservicesetting_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_fieldservicesetting_SyncErrors"></a> msdyn_fieldservicesetting_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_fieldservicesetting_SyncErrors](syncerror.md#BKMK_msdyn_fieldservicesetting_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesetting_AsyncOperations"></a> msdyn_fieldservicesetting_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_fieldservicesetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_fieldservicesetting_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders"></a> msdyn_fieldservicesetting_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_fieldservicesetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesetting_ProcessSession"></a> msdyn_fieldservicesetting_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_fieldservicesetting_ProcessSession](processsession.md#BKMK_msdyn_fieldservicesetting_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesetting_BulkDeleteFailures"></a> msdyn_fieldservicesetting_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_fieldservicesetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_fieldservicesetting_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fieldservicesetting_Appointments"></a> msdyn_fieldservicesetting_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_fieldservicesetting_Appointments](appointment.md#BKMK_msdyn_fieldservicesetting_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_fieldservicesetting_Emails"></a> msdyn_fieldservicesetting_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_fieldservicesetting_Emails](email.md#BKMK_msdyn_fieldservicesetting_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_fieldservicesetting_Faxes"></a> msdyn_fieldservicesetting_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_fieldservicesetting_Faxes](fax.md#BKMK_msdyn_fieldservicesetting_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_fieldservicesetting_Letters"></a> msdyn_fieldservicesetting_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_fieldservicesetting_Letters](letter.md#BKMK_msdyn_fieldservicesetting_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_fieldservicesetting_PhoneCalls"></a> msdyn_fieldservicesetting_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_fieldservicesetting_PhoneCalls](phonecall.md#BKMK_msdyn_fieldservicesetting_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_fieldservicesetting_Tasks"></a> msdyn_fieldservicesetting_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_fieldservicesetting_Tasks](task.md#BKMK_msdyn_fieldservicesetting_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters"></a> msdyn_fieldservicesetting_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_fieldservicesetting_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_fieldservicesetting_SocialActivities"></a> msdyn_fieldservicesetting_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_fieldservicesetting_SocialActivities](socialactivity.md#BKMK_msdyn_fieldservicesetting_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_fieldservicesetting_Annotations"></a> msdyn_fieldservicesetting_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_fieldservicesetting_Annotations](annotation.md#BKMK_msdyn_fieldservicesetting_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_fieldservicesetting_ServiceAppointments"></a> msdyn_fieldservicesetting_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_fieldservicesetting_ServiceAppointments](serviceappointment.md#BKMK_msdyn_fieldservicesetting_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fieldservicesetting_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_fieldservicesetting_createdby](#BKMK_lk_msdyn_fieldservicesetting_createdby)
- [lk_msdyn_fieldservicesetting_createdonbehalfby](#BKMK_lk_msdyn_fieldservicesetting_createdonbehalfby)
- [lk_msdyn_fieldservicesetting_modifiedby](#BKMK_lk_msdyn_fieldservicesetting_modifiedby)
- [lk_msdyn_fieldservicesetting_modifiedonbehalfby](#BKMK_lk_msdyn_fieldservicesetting_modifiedonbehalfby)
- [user_msdyn_fieldservicesetting](#BKMK_user_msdyn_fieldservicesetting)
- [team_msdyn_fieldservicesetting](#BKMK_team_msdyn_fieldservicesetting)
- [business_unit_msdyn_fieldservicesetting](#BKMK_business_unit_msdyn_fieldservicesetting)
- [msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus](#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus)
- [msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus](#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType)
- [msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse)
- [msdyn_product_msdyn_fieldservicesetting](#BKMK_msdyn_product_msdyn_fieldservicesetting)


### <a name="BKMK_lk_msdyn_fieldservicesetting_createdby"></a> lk_msdyn_fieldservicesetting_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldservicesetting_createdby](systemuser.md#BKMK_lk_msdyn_fieldservicesetting_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesetting_createdonbehalfby"></a> lk_msdyn_fieldservicesetting_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldservicesetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicesetting_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesetting_modifiedby"></a> lk_msdyn_fieldservicesetting_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldservicesetting_modifiedby](systemuser.md#BKMK_lk_msdyn_fieldservicesetting_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesetting_modifiedonbehalfby"></a> lk_msdyn_fieldservicesetting_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fieldservicesetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicesetting_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_fieldservicesetting"></a> user_msdyn_fieldservicesetting

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_fieldservicesetting](systemuser.md#BKMK_user_msdyn_fieldservicesetting) One-To-Many relationship.

### <a name="BKMK_team_msdyn_fieldservicesetting"></a> team_msdyn_fieldservicesetting

**Added by**: System Solution Solution

See team Entity [team_msdyn_fieldservicesetting](team.md#BKMK_team_msdyn_fieldservicesetting) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_fieldservicesetting"></a> business_unit_msdyn_fieldservicesetting

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_fieldservicesetting](businessunit.md#BKMK_business_unit_msdyn_fieldservicesetting) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus"></a> msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus

**Added by**: Scheduling Solution

See bookingstatus Entity [msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus"></a> msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus

**Added by**: Scheduling Solution

See bookingstatus Entity [msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType

See msdyn_resourcepaytype Entity [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType](msdyn_resourcepaytype.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType

See msdyn_resourcepaytype Entity [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType](msdyn_resourcepaytype.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType

See msdyn_resourcepaytype Entity [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType](msdyn_resourcepaytype.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType

See msdyn_resourcepaytype Entity [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType](msdyn_resourcepaytype.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType

See msdyn_resourcepaytype Entity [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType](msdyn_resourcepaytype.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse"></a> msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_fieldservicesetting"></a> msdyn_product_msdyn_fieldservicesetting

**Added by**: Product Management Solution

See product Entity [msdyn_product_msdyn_fieldservicesetting](product.md#BKMK_msdyn_product_msdyn_fieldservicesetting) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_fieldservicesetting?text=msdyn_fieldservicesetting EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]