---
title: "msdyn_fieldservicesetting Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_fieldservicesetting entity."
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
# msdyn_fieldservicesetting Entity Reference

Settings controlling functionality related to Field Service

**Added by**: Field Service Solution<br />

## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />[Update](../webapi/update-delete-entities-using-web-api.md#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

**DisplayName**: Field Service Setting<br />
**DisplayCollectionName**: Field Service Settings<br />
**SchemaName**: msdyn_fieldservicesetting<br />
**CollectionSchemaName**: msdyn_fieldservicesettings<br />
**LogicalName**: msdyn_fieldservicesetting<br />
**LogicalCollectionName**: msdyn_fieldservicesettings<br />
**EntitySetName**: msdyn_fieldservicesettings<br />
**PrimaryIdAttribute**: msdyn_fieldservicesettingid<br />
**PrimaryNameAttribute**: msdyn_name<br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdvancedSettings](#BKMK_msdyn_AdvancedSettings)
- [msdyn_AgreementPrefix](#BKMK_msdyn_AgreementPrefix)
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
- [msdyn_EnableLegacyScheduleAssistant](#BKMK_msdyn_EnableLegacyScheduleAssistant)
- [msdyn_EntityNumberLength](#BKMK_msdyn_EntityNumberLength)
- [msdyn_fieldservicesettingId](#BKMK_msdyn_fieldservicesettingId)
- [msdyn_GenerateAgreementInvoicesXDaysInAdvance](#BKMK_msdyn_GenerateAgreementInvoicesXDaysInAdvance)
- [msdyn_GenerateAgreementWOXDaysInAdvance](#BKMK_msdyn_GenerateAgreementWOXDaysInAdvance)
- [msdyn_GenerateBookingDatesXMonthsInAdvance](#BKMK_msdyn_GenerateBookingDatesXMonthsInAdvance)
- [msdyn_GenerateInvoiceDatesXMonthsInAdvance](#BKMK_msdyn_GenerateInvoiceDatesXMonthsInAdvance)
- [msdyn_GPSLocationExpiresAfterXMinutes](#BKMK_msdyn_GPSLocationExpiresAfterXMinutes)
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


### <a name="BKMK_msdyn_AdvancedSettings"></a> msdyn_AdvancedSettings

**Description**: For internal use only.<br />
**DisplayName**: Advanced Settings<br />
**LogicalName**: msdyn_advancedsettings<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 1048576


### <a name="BKMK_msdyn_AgreementPrefix"></a> msdyn_AgreementPrefix

**Description**: <br />
**DisplayName**: Agreement Prefix<br />
**LogicalName**: msdyn_agreementprefix<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_AgreementStartingNumber"></a> msdyn_AgreementStartingNumber

**Description**: <br />
**DisplayName**: Agreement Starting Number<br />
**LogicalName**: msdyn_agreementstartingnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_AutoAllocateEstimatedProducts"></a> msdyn_AutoAllocateEstimatedProducts

**Description**: If enabled then Allocated will be automatically set when entering a Work order Product with a Line Status of Estimate.<br />
**DisplayName**: Auto Allocate Estimated Products<br />
**LogicalName**: msdyn_autoallocateestimatedproducts<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_AutoGenerateWOforAgreementBookings"></a> msdyn_AutoGenerateWOforAgreementBookings

**Description**: <br />
**DisplayName**: Auto Generate WO for Agreement Booking<br />
**LogicalName**: msdyn_autogeneratewoforagreementbooking<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


### <a name="BKMK_msdyn_AutoGeoCodeAddresses"></a> msdyn_AutoGeoCodeAddresses

**Description**: If set then the system will automatically geo code addresses when the address has been updated and the record is saved<br />
**DisplayName**: Auto Geo Code Addresses<br />
**LogicalName**: msdyn_autogeocodeaddresses<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


### <a name="BKMK_msdyn_BookingAlertTemplate"></a> msdyn_BookingAlertTemplate

**Description**: <br />
**DisplayName**: Booking Alert Template (Deprecated)<br />
**LogicalName**: msdyn_bookingalerttemplate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 2000


### <a name="BKMK_msdyn_BreakPayType"></a> msdyn_BreakPayType

**Description**: Default Pay Type to be used for Break hours<br />
**DisplayName**: Break Pay Type<br />
**LogicalName**: msdyn_breakpaytype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_resourcepaytype


### <a name="BKMK_msdyn_BusinessClosurePayType"></a> msdyn_BusinessClosurePayType

**Description**: Default Pay Type to be used for business closure work hours<br />
**DisplayName**: Business Closure Pay Type<br />
**LogicalName**: msdyn_businessclosurepaytype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_resourcepaytype


### <a name="BKMK_msdyn_CancelCurrentSlotsWhenMoving"></a> msdyn_CancelCurrentSlotsWhenMoving

**Description**: Select whether, when moving open slots to the next day, to leave the old slots and change their status to "Cancel."<br />
**DisplayName**: Cancel Current Slots When Moving (Deprecated)<br />
**LogicalName**: msdyn_cancelcurrentslotswhenmoving<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_CustomGPSData"></a> msdyn_CustomGPSData

**Description**: If enabled system will use custom entity for its source of Geo Locations for resources to be displayed on map view<br />
**DisplayName**: Custom GPS Data (Deprecated)<br />
**LogicalName**: msdyn_customgpsdata<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_CustomGPSLatitudefield"></a> msdyn_CustomGPSLatitudefield

**Description**: Shows the logical name of the latitude field to be used for geolocations.<br />
**DisplayName**: Custom GPS Latitude field (Deprecated)<br />
**LogicalName**: msdyn_customgpslatitudefield<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_CustomGPSLocationentity"></a> msdyn_CustomGPSLocationentity

**Description**: Shows the logical name of custom entity to be used for geolocations.<br />
**DisplayName**: Custom GPS Location entity (Deprecated)<br />
**LogicalName**: msdyn_customgpslocationentity<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_CustomGPSLongitudefield"></a> msdyn_CustomGPSLongitudefield

**Description**: Shows the logical name of the longitude field to be used for geolocations.<br />
**DisplayName**: Custom GPS Longitude field (Deprecated)<br />
**LogicalName**: msdyn_customgpslongitudefield<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_CustomGPSResourcefield"></a> msdyn_CustomGPSResourcefield

**Description**: Shows the logical name of the resource field to be used for geolocations.<br />
**DisplayName**: Custom GPS Resource field (Deprecated)<br />
**LogicalName**: msdyn_customgpsresourcefield<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_CustomGPSTimestampfield"></a> msdyn_CustomGPSTimestampfield

**Description**: Shows the logical name of the timestamp field to be used for geolocations.<br />
**DisplayName**: Custom GPS Timestamp field (Deprecated)<br />
**LogicalName**: msdyn_customgpstimestampfield<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_DatabaseVersion"></a> msdyn_DatabaseVersion

**Description**: For Internal Use<br />
**DisplayName**: Database Version<br />
**LogicalName**: msdyn_databaseversion<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_DeactivateBookingWhenCanceled"></a> msdyn_DeactivateBookingWhenCanceled

**Description**: Select whether the system should deactivate the resource booking when the system status is changed to "Canceled."<br />
**DisplayName**: Deactivate Booking When Canceled<br />
**LogicalName**: msdyn_deactivatebookingwhencanceled<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_DeactivateBookingWhenCompleted"></a> msdyn_DeactivateBookingWhenCompleted

**Description**: Select whether the system should deactivate the resource booking when the system status is changed to "Completed."<br />
**DisplayName**: Deactivate Booking When Completed<br />
**LogicalName**: msdyn_deactivatebookingwhencompleted<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_DeactivateWorkOrderWhenCanceled"></a> msdyn_DeactivateWorkOrderWhenCanceled

**Description**: Select whether the system should deactivate the work order when the system status is changed to "Closed - Canceled."<br />
**DisplayName**: Deactivate Work Order When Canceled<br />
**LogicalName**: msdyn_deactivateworkorderwhencanceled<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: True


### <a name="BKMK_msdyn_DeactivateWorkOrderWhenPosted"></a> msdyn_DeactivateWorkOrderWhenPosted

**Description**: Select whether the system should deactivate the work order when the system status is changed to "Closed - Posted."<br />
**DisplayName**: Deactivate Work Order When Posted<br />
**LogicalName**: msdyn_deactivateworkorderwhenposted<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_DefaultBookingDuration"></a> msdyn_DefaultBookingDuration

**Description**: <br />
**DisplayName**: Default Booking Duration (Deprecated)<br />
**LogicalName**: msdyn_defaultbookingduration<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_DefaultCanceledBookingStatus"></a> msdyn_DefaultCanceledBookingStatus

**Description**: <br />
**DisplayName**: Default Canceled Booking Status (Deprecated)<br />
**LogicalName**: msdyn_defaultcanceledbookingstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookingstatus


### <a name="BKMK_msdyn_DefaultRadiusUnit"></a> msdyn_DefaultRadiusUnit

**Description**: <br />
**DisplayName**: Default Radius Unit (Deprecated)<br />
**LogicalName**: msdyn_defaultradiusunit<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: mi
- **FalseOption Value**: 0 **Label**: km

**DefaultValue**: True


### <a name="BKMK_msdyn_DefaultRadiusValue"></a> msdyn_DefaultRadiusValue

**Description**: <br />
**DisplayName**: Default Radius Value (Deprecated)<br />
**LogicalName**: msdyn_defaultradiusvalue<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: -2147483648


### <a name="BKMK_msdyn_DefaultScheduledBookingStatus"></a> msdyn_DefaultScheduledBookingStatus

**Description**: <br />
**DisplayName**: Default Scheduled Booking Status (Deprecated)<br />
**LogicalName**: msdyn_defaultscheduledbookingstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: bookingstatus


### <a name="BKMK_msdyn_DefaultWarehouse"></a> msdyn_DefaultWarehouse

**Description**: Shows the warehouse associated with the field service setting.<br />
**DisplayName**: Default Warehouse<br />
**LogicalName**: msdyn_defaultwarehouse<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Lookup<br />
**Targets**: msdyn_warehouse


### <a name="BKMK_msdyn_DefaultWorkOrderCompletedStatus"></a> msdyn_DefaultWorkOrderCompletedStatus

**Description**: Select whether the default work order completed status is either "Completed" or "Posted."<br />
**DisplayName**: Default Work Order Completed Status<br />
**LogicalName**: msdyn_defaultworkordercompletedstatus<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Open - Unscheduled
- **Value**: 690970001 **Label**: Open - Scheduled
- **Value**: 690970002 **Label**: Open - In Progress
- **Value**: 690970003 **Label**: Open - Completed
- **Value**: 690970004 **Label**: Closed - Posted
- **Value**: 690970005 **Label**: Closed - Canceled



### <a name="BKMK_msdyn_EnableLegacyScheduleAssistant"></a> msdyn_EnableLegacyScheduleAssistant

**Description**: <br />
**DisplayName**: Enable Legacy Schedule Assistant<br />
**LogicalName**: msdyn_enablelegacyscheduleassistant<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_EntityNumberLength"></a> msdyn_EntityNumberLength

**Description**: <br />
**DisplayName**: Entity Number Length<br />
**LogicalName**: msdyn_entitynumberlength<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 10<br />
**MinValue**: 0


### <a name="BKMK_msdyn_fieldservicesettingId"></a> msdyn_fieldservicesettingId

**Description**: Shows the entity instances.<br />
**DisplayName**: Field Service Setting<br />
**LogicalName**: msdyn_fieldservicesettingid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_msdyn_GenerateAgreementInvoicesXDaysInAdvance"></a> msdyn_GenerateAgreementInvoicesXDaysInAdvance

**Description**: <br />
**DisplayName**: Generate Agreement Invoices X Days In Advance<br />
**LogicalName**: msdyn_generateagreementinvoicesxdaysinadvance<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_GenerateAgreementWOXDaysInAdvance"></a> msdyn_GenerateAgreementWOXDaysInAdvance

**Description**: Specify default how many days in advance of the Agreement Booking Date the system should automatically generate a Work Order<br />
**DisplayName**: Generate Agreement WO X Days In Advance<br />
**LogicalName**: msdyn_generateagreementwoxdaysinadvance<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_GenerateBookingDatesXMonthsInAdvance"></a> msdyn_GenerateBookingDatesXMonthsInAdvance

**Description**: <br />
**DisplayName**: Generate Booking Dates X Months In Advance<br />
**LogicalName**: msdyn_generatebookingdatesxmonthsinadvance<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 1


### <a name="BKMK_msdyn_GenerateInvoiceDatesXMonthsInAdvance"></a> msdyn_GenerateInvoiceDatesXMonthsInAdvance

**Description**: <br />
**DisplayName**: Generate Invoice Dates X Months In Advance<br />
**LogicalName**: msdyn_generateinvoicedatesxmonthsinadvance<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 1


### <a name="BKMK_msdyn_GPSLocationExpiresAfterXMinutes"></a> msdyn_GPSLocationExpiresAfterXMinutes

**Description**: <br />
**DisplayName**: GPS Location Expires After X Minutes (Deprecated)<br />
**LogicalName**: msdyn_gpslocationexpiresafterxminutes<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: Duration<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_InventoryAdjustmentPrefix"></a> msdyn_InventoryAdjustmentPrefix

**Description**: Shows the prefix to be added to the inventory adjustment numbers.<br />
**DisplayName**: Inventory Adjustment Prefix<br />
**LogicalName**: msdyn_inventoryadjustmentprefix<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 25


### <a name="BKMK_msdyn_InventoryAdjustmentStartingNumber"></a> msdyn_InventoryAdjustmentStartingNumber

**Description**: Shows the number to be used as the starting number for inventory adjustments.<br />
**DisplayName**: Inventory Adjustment Starting Number<br />
**LogicalName**: msdyn_inventoryadjustmentstartingnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_InventoryTransferPrefix"></a> msdyn_InventoryTransferPrefix

**Description**: Shows the prefix to be added to the inventory transfer numbers.<br />
**DisplayName**: Inventory Transfer Prefix<br />
**LogicalName**: msdyn_inventorytransferprefix<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 25


### <a name="BKMK_msdyn_InventoryTransferStartingNumber"></a> msdyn_InventoryTransferStartingNumber

**Description**: Shows the number to be used as the starting number for inventory transfers.<br />
**DisplayName**: Inventory Transfer Starting Number<br />
**LogicalName**: msdyn_inventorytransferstartingnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_name"></a> msdyn_name

**Description**: Enter the name of the custom entity.<br />
**DisplayName**: Name<br />
**LogicalName**: msdyn_name<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_NotificationTimeout"></a> msdyn_NotificationTimeout

**Description**: <br />
**DisplayName**: Notification Timeout (In sec) (Deprecated)<br />
**LogicalName**: msdyn_notificationtimeout<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 1


### <a name="BKMK_msdyn_OvertimePayType"></a> msdyn_OvertimePayType

**Description**: Default Pay Type to be used for overtime work hours<br />
**DisplayName**: Overtime Pay Type<br />
**LogicalName**: msdyn_overtimepaytype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_resourcepaytype


### <a name="BKMK_msdyn_PostponeNumberCleanupUntil"></a> msdyn_PostponeNumberCleanupUntil

**Description**: Shows the date when cleanup of unique numbers will occur.<br />
**DisplayName**: Postpone Number Cleanup Until<br />
**LogicalName**: msdyn_postponenumbercleanupuntil<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: TimeZoneIndependent<br />
**Format**: DateAndTime


### <a name="BKMK_msdyn_ProductCostOrder"></a> msdyn_ProductCostOrder

**Description**: <br />
**DisplayName**: Product Cost Order<br />
**LogicalName**: msdyn_productcostorder<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Standard/Current
- **Value**: 690970001 **Label**: Current/Standard



### <a name="BKMK_msdyn_PurchaseOrderApprovalRequired"></a> msdyn_PurchaseOrderApprovalRequired

**Description**: Enable if a Purchase Order requires approval in order for the status to be changed to Submitted<br />
**DisplayName**: Purchase Order Approval Required<br />
**LogicalName**: msdyn_purchaseorderapprovalrequired<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_PurchaseOrderPrefix"></a> msdyn_PurchaseOrderPrefix

**Description**: Shows the prefix to be added to the purchase order numbers.<br />
**DisplayName**: Purchase Order Prefix<br />
**LogicalName**: msdyn_purchaseorderprefix<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 25


### <a name="BKMK_msdyn_PurchaseOrderStartingNumber"></a> msdyn_PurchaseOrderStartingNumber

**Description**: Shows the number to be used as starting number for the automatically generated purchase order number.<br />
**DisplayName**: Purchase Order Starting Number<br />
**LogicalName**: msdyn_purchaseorderstartingnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_ResourcesSynchronizationTimeout"></a> msdyn_ResourcesSynchronizationTimeout

**Description**: <br />
**DisplayName**: Resources Synchronization Timeout (Deprecated)<br />
**LogicalName**: msdyn_resourcessynchronizationtimeout<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 1


### <a name="BKMK_msdyn_RMAPrefix"></a> msdyn_RMAPrefix

**Description**: <br />
**DisplayName**: RMA Prefix<br />
**LogicalName**: msdyn_rmaprefix<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RMAStartingNumber"></a> msdyn_RMAStartingNumber

**Description**: Shows the number to be used as the starting number for the automatically generation RMA number.<br />
**DisplayName**: RMA Starting Number<br />
**LogicalName**: msdyn_rmastartingnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_RTVPrefix"></a> msdyn_RTVPrefix

**Description**: <br />
**DisplayName**: RTV Prefix<br />
**LogicalName**: msdyn_rtvprefix<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_RTVStartingNumber"></a> msdyn_RTVStartingNumber

**Description**: Shows the number to be used as the starting number for the automatically generated RTV number.<br />
**DisplayName**: RTV Starting Number<br />
**LogicalName**: msdyn_rtvstartingnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_SAAutoFilterServiceTerritory"></a> msdyn_SAAutoFilterServiceTerritory

**Description**: Select whether the schedule assistant should automatically filter the results based on the territory set on the work order.<br />
**DisplayName**: Auto Filter Service Territory (Deprecated)<br />
**LogicalName**: msdyn_saautofilterserviceterritory<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_SchedulerBusinessUnitDetailsView"></a> msdyn_SchedulerBusinessUnitDetailsView

**Description**: <br />
**DisplayName**: Scheduler Business Unit Details View (Deprecated)<br />
**LogicalName**: msdyn_schedulerbusinessunitdetailsview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SchedulerBusinessUnitTooltipView"></a> msdyn_SchedulerBusinessUnitTooltipView

**Description**: <br />
**DisplayName**: Scheduler Business Unit Tooltip View (Deprecated)<br />
**LogicalName**: msdyn_schedulerbusinessunittooltipview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SchedulerCoreDetailsView"></a> msdyn_SchedulerCoreDetailsView

**Description**: <br />
**DisplayName**: Scheduler Core Details View (Deprecated)<br />
**LogicalName**: msdyn_schedulercoredetailsview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SchedulerCoreSlotTextTemplate"></a> msdyn_SchedulerCoreSlotTextTemplate

**Description**: <br />
**DisplayName**: Scheduler Core Slot Text Template (Deprecated)<br />
**LogicalName**: msdyn_schedulercoreslottexttemplate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 5000


### <a name="BKMK_msdyn_SchedulerCoreTooltipView"></a> msdyn_SchedulerCoreTooltipView

**Description**: <br />
**DisplayName**: Scheduler Core Tooltip View (Deprecated)<br />
**LogicalName**: msdyn_schedulercoretooltipview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SchedulerFieldServiceDetailsView"></a> msdyn_SchedulerFieldServiceDetailsView

**Description**: <br />
**DisplayName**: Scheduler Field Service Details View (Deprecated)<br />
**LogicalName**: msdyn_schedulerfieldservicedetailsview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SchedulerFieldServiceSlotTextTemplate"></a> msdyn_SchedulerFieldServiceSlotTextTemplate

**Description**: <br />
**DisplayName**: Scheduler Field Service Slot Text Template (Deprecated)<br />
**LogicalName**: msdyn_schedulerfieldserviceslottexttemplate<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Memo<br />
**Format**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 5000


### <a name="BKMK_msdyn_SchedulerFieldServiceTooltipView"></a> msdyn_SchedulerFieldServiceTooltipView

**Description**: <br />
**DisplayName**: Scheduler Field Service Tooltip View (Deprecated)<br />
**LogicalName**: msdyn_schedulerfieldservicetooltipview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SchedulerResourceDetailsView"></a> msdyn_SchedulerResourceDetailsView

**Description**: <br />
**DisplayName**: Scheduler Resource Details View (Deprecated)<br />
**LogicalName**: msdyn_schedulerresourcedetailsview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SchedulerResourceTooltipView"></a> msdyn_SchedulerResourceTooltipView

**Description**: <br />
**DisplayName**: Scheduler Resource Tooltip View (Deprecated)<br />
**LogicalName**: msdyn_schedulerresourcetooltipview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_SchedulerUnscheduledView"></a> msdyn_SchedulerUnscheduledView

**Description**: <br />
**DisplayName**: Scheduler Unscheduled View (Deprecated)<br />
**LogicalName**: msdyn_schedulerunscheduledview<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_sdkapimapkey"></a> msdyn_sdkapimapkey

**Description**: Api key for map<br />
**DisplayName**: Bing API Key (Deprecated)<br />
**LogicalName**: msdyn_sdkapimapkey<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_TravelChargeItemId"></a> msdyn_TravelChargeItemId

**Description**: Product/Service to be used by the system for Travel Charges on Work Orders<br />
**DisplayName**: Travel Charge Item<br />
**LogicalName**: msdyn_travelchargeitemid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: product


### <a name="BKMK_msdyn_TravelPayType"></a> msdyn_TravelPayType

**Description**: Default Pay Type to be used for Travel hours<br />
**DisplayName**: Travel Pay Type<br />
**LogicalName**: msdyn_travelpaytype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_resourcepaytype


### <a name="BKMK_msdyn_TravelTimeRescheduling"></a> msdyn_TravelTimeRescheduling

**Description**: <br />
**DisplayName**: Travel Time Rescheduling (Deprecated)<br />
**LogicalName**: msdyn_traveltimerescheduling<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_msdyn_UndefinedBookingLocation"></a> msdyn_UndefinedBookingLocation

**Description**: Location for schedules where geo code info has not been defined<br />
**DisplayName**: Undefined Booking Location (Deprecated)<br />
**LogicalName**: msdyn_undefinedbookinglocation<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Previous Known Location
- **Value**: 690970001 **Label**: Ignore Location



### <a name="BKMK_msdyn_UnscheduledWOTooltipsViewId"></a> msdyn_UnscheduledWOTooltipsViewId

**Description**: <br />
**DisplayName**: Unscheduled WO Tooltips View Id (Deprecated)<br />
**LogicalName**: msdyn_unscheduledwotooltipsviewid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 50


### <a name="BKMK_msdyn_UseofProductsOutofStock"></a> msdyn_UseofProductsOutofStock

**Description**: Specify how the system should react when trying to use products that are out of stock.<br />
**DisplayName**: Use of Products Out of Stock<br />
**LogicalName**: msdyn_useofproductsoutofstock<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Confirm
- **Value**: 690970001 **Label**: Restrict



### <a name="BKMK_msdyn_WorkOrderInvoiceCreation"></a> msdyn_WorkOrderInvoiceCreation

**Description**: Specify whether the system should automatically generate an invoice for work orders.<br />
**DisplayName**: Work Order Invoice Creation<br />
**LogicalName**: msdyn_workorderinvoicecreation<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Picklist<br />
**Options**:

- **Value**: 690970000 **Label**: Never
- **Value**: 690970001 **Label**: On Work Order Posted



### <a name="BKMK_msdyn_WorkOrderPrefix"></a> msdyn_WorkOrderPrefix

**Description**: <br />
**DisplayName**: Work Order Prefix<br />
**LogicalName**: msdyn_workorderprefix<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_WorkOrderStartingNumber"></a> msdyn_WorkOrderStartingNumber

**Description**: <br />
**DisplayName**: Work Order Starting Number<br />
**LogicalName**: msdyn_workorderstartingnumber<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_msdyn_WorkPayType"></a> msdyn_WorkPayType

**Description**: Default Pay Type to be used for regular work hours<br />
**DisplayName**: Work Pay Type<br />
**LogicalName**: msdyn_workpaytype<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: msdyn_resourcepaytype


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

**Description**: Owner Id Type<br />
**DisplayName**: <br />
**LogicalName**: owneridtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: EntityName<br />


### <a name="BKMK_statecode"></a> statecode

**Description**: Status of the Field Service Setting<br />
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

**Description**: Shows the reason for the status of the field service setting.<br />
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


### <a name="BKMK_msdyn_BreakPayTypeName"></a> msdyn_BreakPayTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_breakpaytypename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_BusinessClosurePayTypeName"></a> msdyn_BusinessClosurePayTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_businessclosurepaytypename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_DefaultCanceledBookingStatusName"></a> msdyn_DefaultCanceledBookingStatusName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultcanceledbookingstatusname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_DefaultScheduledBookingStatusName"></a> msdyn_DefaultScheduledBookingStatusName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultscheduledbookingstatusname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_DefaultWarehouseName"></a> msdyn_DefaultWarehouseName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_defaultwarehousename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_OvertimePayTypeName"></a> msdyn_OvertimePayTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_overtimepaytypename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_TravelChargeItemIdName"></a> msdyn_TravelChargeItemIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_travelchargeitemidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_msdyn_TravelPayTypeName"></a> msdyn_TravelPayTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_travelpaytypename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_msdyn_WorkPayTypeName"></a> msdyn_WorkPayTypeName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: msdyn_workpaytypename<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 200


### <a name="BKMK_OwnerIdName"></a> OwnerIdName

**Description**: Name of the owner<br />
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

**Description**: Yomi name of the owner<br />
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

- [msdyn_fieldservicesetting_ActivityPointers](#BKMK_msdyn_fieldservicesetting_ActivityPointers)
- [msdyn_fieldservicesetting_msdyn_approvals](#BKMK_msdyn_fieldservicesetting_msdyn_approvals)
- [msdyn_fieldservicesetting_msdyn_bookingalerts](#BKMK_msdyn_fieldservicesetting_msdyn_bookingalerts)
- [msdyn_fieldservicesetting_SyncErrors](#BKMK_msdyn_fieldservicesetting_SyncErrors)
- [msdyn_fieldservicesetting_AsyncOperations](#BKMK_msdyn_fieldservicesetting_AsyncOperations)
- [msdyn_fieldservicesetting_MailboxTrackingFolders](#BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders)
- [msdyn_fieldservicesetting_UserEntityInstanceDatas](#BKMK_msdyn_fieldservicesetting_UserEntityInstanceDatas)
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

Same as activitypointer entity [msdyn_fieldservicesetting_ActivityPointers](activitypointer.md#BKMK_msdyn_fieldservicesetting_ActivityPointers) Many-To-One relationship.

**ReferencingEntity**: activitypointer<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_ActivityPointers<br />
**AssociatedMenuConfiguration**:

- **Behavior**: UseCollectionName
- **Group**: Details
- **Label**: 
- **Order**: 

**CascadeConfiguration**:

- **Assign**: NoCascade
- **Delete**: RemoveLink
- **Merge**: NoCascade
- **Reparent**: NoCascade
- **Share**: NoCascade
- **Unshare**: NoCascade


### <a name="BKMK_msdyn_fieldservicesetting_msdyn_approvals"></a> msdyn_fieldservicesetting_msdyn_approvals

Same as msdyn_approval entity [msdyn_fieldservicesetting_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_fieldservicesetting_msdyn_approvals) Many-To-One relationship.

**ReferencingEntity**: msdyn_approval<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_msdyn_approvals<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_msdyn_bookingalerts"></a> msdyn_fieldservicesetting_msdyn_bookingalerts

Same as msdyn_bookingalert entity [msdyn_fieldservicesetting_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_fieldservicesetting_msdyn_bookingalerts) Many-To-One relationship.

**ReferencingEntity**: msdyn_bookingalert<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_msdyn_bookingalerts<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_SyncErrors"></a> msdyn_fieldservicesetting_SyncErrors

Same as syncerror entity [msdyn_fieldservicesetting_SyncErrors](syncerror.md#BKMK_msdyn_fieldservicesetting_SyncErrors) Many-To-One relationship.

**ReferencingEntity**: syncerror<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_SyncErrors<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_AsyncOperations"></a> msdyn_fieldservicesetting_AsyncOperations

Same as asyncoperation entity [msdyn_fieldservicesetting_AsyncOperations](asyncoperation.md#BKMK_msdyn_fieldservicesetting_AsyncOperations) Many-To-One relationship.

**ReferencingEntity**: asyncoperation<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_AsyncOperations<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders"></a> msdyn_fieldservicesetting_MailboxTrackingFolders

Same as mailboxtrackingfolder entity [msdyn_fieldservicesetting_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders) Many-To-One relationship.

**ReferencingEntity**: mailboxtrackingfolder<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_MailboxTrackingFolders<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_UserEntityInstanceDatas"></a> msdyn_fieldservicesetting_UserEntityInstanceDatas

Same as userentityinstancedata entity [msdyn_fieldservicesetting_UserEntityInstanceDatas](userentityinstancedata.md#BKMK_msdyn_fieldservicesetting_UserEntityInstanceDatas) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_UserEntityInstanceDatas<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_ProcessSession"></a> msdyn_fieldservicesetting_ProcessSession

Same as processsession entity [msdyn_fieldservicesetting_ProcessSession](processsession.md#BKMK_msdyn_fieldservicesetting_ProcessSession) Many-To-One relationship.

**ReferencingEntity**: processsession<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_ProcessSession<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_BulkDeleteFailures"></a> msdyn_fieldservicesetting_BulkDeleteFailures

Same as bulkdeletefailure entity [msdyn_fieldservicesetting_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_fieldservicesetting_BulkDeleteFailures) Many-To-One relationship.

**ReferencingEntity**: bulkdeletefailure<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_BulkDeleteFailures<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses

Same as principalobjectattributeaccess entity [msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses) Many-To-One relationship.

**ReferencingEntity**: principalobjectattributeaccess<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_Appointments"></a> msdyn_fieldservicesetting_Appointments

Same as appointment entity [msdyn_fieldservicesetting_Appointments](appointment.md#BKMK_msdyn_fieldservicesetting_Appointments) Many-To-One relationship.

**ReferencingEntity**: appointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_Appointments<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_Emails"></a> msdyn_fieldservicesetting_Emails

Same as email entity [msdyn_fieldservicesetting_Emails](email.md#BKMK_msdyn_fieldservicesetting_Emails) Many-To-One relationship.

**ReferencingEntity**: email<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_Emails<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_Faxes"></a> msdyn_fieldservicesetting_Faxes

Same as fax entity [msdyn_fieldservicesetting_Faxes](fax.md#BKMK_msdyn_fieldservicesetting_Faxes) Many-To-One relationship.

**ReferencingEntity**: fax<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_Faxes<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_Letters"></a> msdyn_fieldservicesetting_Letters

Same as letter entity [msdyn_fieldservicesetting_Letters](letter.md#BKMK_msdyn_fieldservicesetting_Letters) Many-To-One relationship.

**ReferencingEntity**: letter<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_Letters<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_PhoneCalls"></a> msdyn_fieldservicesetting_PhoneCalls

Same as phonecall entity [msdyn_fieldservicesetting_PhoneCalls](phonecall.md#BKMK_msdyn_fieldservicesetting_PhoneCalls) Many-To-One relationship.

**ReferencingEntity**: phonecall<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_PhoneCalls<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_Tasks"></a> msdyn_fieldservicesetting_Tasks

Same as task entity [msdyn_fieldservicesetting_Tasks](task.md#BKMK_msdyn_fieldservicesetting_Tasks) Many-To-One relationship.

**ReferencingEntity**: task<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_Tasks<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters"></a> msdyn_fieldservicesetting_RecurringAppointmentMasters

Same as recurringappointmentmaster entity [msdyn_fieldservicesetting_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_fieldservicesetting_RecurringAppointmentMasters) Many-To-One relationship.

**ReferencingEntity**: recurringappointmentmaster<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_RecurringAppointmentMasters<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_SocialActivities"></a> msdyn_fieldservicesetting_SocialActivities

Same as socialactivity entity [msdyn_fieldservicesetting_SocialActivities](socialactivity.md#BKMK_msdyn_fieldservicesetting_SocialActivities) Many-To-One relationship.

**ReferencingEntity**: socialactivity<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_SocialActivities<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_Annotations"></a> msdyn_fieldservicesetting_Annotations

Same as annotation entity [msdyn_fieldservicesetting_Annotations](annotation.md#BKMK_msdyn_fieldservicesetting_Annotations) Many-To-One relationship.

**ReferencingEntity**: annotation<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_Annotations<br />
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


### <a name="BKMK_msdyn_fieldservicesetting_ServiceAppointments"></a> msdyn_fieldservicesetting_ServiceAppointments

Same as serviceappointment entity [msdyn_fieldservicesetting_ServiceAppointments](serviceappointment.md#BKMK_msdyn_fieldservicesetting_ServiceAppointments) Many-To-One relationship.

**ReferencingEntity**: serviceappointment<br />
**ReferencingAttribute**: regardingobjectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: True<br />
**ReferencedEntityNavigationPropertyName**: msdyn_fieldservicesetting_ServiceAppointments<br />
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

See systemuser Entity [lk_msdyn_fieldservicesetting_createdby](systemuser.md#BKMK_lk_msdyn_fieldservicesetting_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesetting_createdonbehalfby"></a> lk_msdyn_fieldservicesetting_createdonbehalfby

See systemuser Entity [lk_msdyn_fieldservicesetting_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicesetting_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesetting_modifiedby"></a> lk_msdyn_fieldservicesetting_modifiedby

See systemuser Entity [lk_msdyn_fieldservicesetting_modifiedby](systemuser.md#BKMK_lk_msdyn_fieldservicesetting_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fieldservicesetting_modifiedonbehalfby"></a> lk_msdyn_fieldservicesetting_modifiedonbehalfby

See systemuser Entity [lk_msdyn_fieldservicesetting_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_fieldservicesetting_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_fieldservicesetting"></a> user_msdyn_fieldservicesetting

See systemuser Entity [user_msdyn_fieldservicesetting](systemuser.md#BKMK_user_msdyn_fieldservicesetting) One-To-Many relationship.

### <a name="BKMK_team_msdyn_fieldservicesetting"></a> team_msdyn_fieldservicesetting

See team Entity [team_msdyn_fieldservicesetting](team.md#BKMK_team_msdyn_fieldservicesetting) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_fieldservicesetting"></a> business_unit_msdyn_fieldservicesetting

See businessunit Entity [business_unit_msdyn_fieldservicesetting](businessunit.md#BKMK_business_unit_msdyn_fieldservicesetting) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus"></a> msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus

See bookingstatus Entity [msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus"></a> msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus

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

See product Entity [msdyn_product_msdyn_fieldservicesetting](product.md#BKMK_msdyn_product_msdyn_fieldservicesetting) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_fieldservicesetting?text=msdyn_fieldservicesetting EntityType" />