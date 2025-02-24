---
title: "Field Service Setting (msdyn_fieldservicesetting) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Field Service Setting (msdyn_fieldservicesetting) table/entity with Microsoft Dynamics 365 Field Service."
ms.topic: generated-reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Field Service Setting (msdyn_fieldservicesetting) table/entity reference (Microsoft Dynamics 365 Field Service)

Settings controlling functionality related to Field Service

## Messages

The following table lists the messages for the Field Service Setting (msdyn_fieldservicesetting) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Associate`<br />Event: True |[Associate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Associate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-associate-method-or-associaterequest)|
| `BulkRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Create`<br />Event: True |`POST` /msdyn_fieldservicesettings<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `Disassociate`<br />Event: True |[Disassociate records](/power-apps/developer/data-platform/webapi/associate-disassociate-entities-using-web-api) |[Disassociate records](/power-apps/developer/data-platform/org-service/entity-operations-associate-disassociate#use-the-disassociate-method-or-disassociaterequest)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `PurgeRetainedContent`<br />Event: True |<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Restore`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Restore?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retrieve`<br />Event: True |`GET` /msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_fieldservicesettings<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `RollbackRetain`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `SetState`<br />Event: True |`PATCH` /msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_fieldservicesettings(*msdyn_fieldservicesettingid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|
| `ValidateRetentionConfig`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Field Service Setting (msdyn_fieldservicesetting) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Field Service Setting** |
| **DisplayCollectionName** | **Field Service Settings** |
| **SchemaName** | `msdyn_fieldservicesetting` |
| **CollectionSchemaName** | `msdyn_fieldservicesettings` |
| **EntitySetName** | `msdyn_fieldservicesettings`|
| **LogicalName** | `msdyn_fieldservicesetting` |
| **LogicalCollectionName** | `msdyn_fieldservicesettings` |
| **PrimaryIdAttribute** | `msdyn_fieldservicesettingid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdvancedSettings](#BKMK_msdyn_AdvancedSettings)
- [msdyn_AgreementPrefix](#BKMK_msdyn_AgreementPrefix)
- [msdyn_AgreementRecordGeneration](#BKMK_msdyn_AgreementRecordGeneration)
- [msdyn_AgreementStartingNumber](#BKMK_msdyn_AgreementStartingNumber)
- [msdyn_AnalyticsIngestDataInXDays](#BKMK_msdyn_AnalyticsIngestDataInXDays)
- [msdyn_AnalyticsPostponeIngestionUntil](#BKMK_msdyn_AnalyticsPostponeIngestionUntil)
- [msdyn_AnalyticsSpreadOutPostponeIngestionUntil](#BKMK_msdyn_AnalyticsSpreadOutPostponeIngestionUntil)
- [msdyn_AutoAllocateEstimatedProducts](#BKMK_msdyn_AutoAllocateEstimatedProducts)
- [msdyn_AutoGenerateWOforAgreementBookings](#BKMK_msdyn_AutoGenerateWOforAgreementBookings)
- [msdyn_AutoGeoCodeAddresses](#BKMK_msdyn_AutoGeoCodeAddresses)
- [msdyn_AutoNumberingOptIn](#BKMK_msdyn_AutoNumberingOptIn)
- [msdyn_BookingAlertTemplate](#BKMK_msdyn_BookingAlertTemplate)
- [msdyn_BreakPayType](#BKMK_msdyn_BreakPayType)
- [msdyn_BusinessClosurePayType](#BKMK_msdyn_BusinessClosurePayType)
- [msdyn_CalculateCost](#BKMK_msdyn_CalculateCost)
- [msdyn_CalculatePrice](#BKMK_msdyn_CalculatePrice)
- [msdyn_CalculateTax](#BKMK_msdyn_CalculateTax)
- [msdyn_CancelCurrentSlotsWhenMoving](#BKMK_msdyn_CancelCurrentSlotsWhenMoving)
- [msdyn_CustomGPSData](#BKMK_msdyn_CustomGPSData)
- [msdyn_CustomGPSLatitudefield](#BKMK_msdyn_CustomGPSLatitudefield)
- [msdyn_CustomGPSLocationentity](#BKMK_msdyn_CustomGPSLocationentity)
- [msdyn_CustomGPSLongitudefield](#BKMK_msdyn_CustomGPSLongitudefield)
- [msdyn_CustomGPSResourcefield](#BKMK_msdyn_CustomGPSResourcefield)
- [msdyn_CustomGPSTimestampfield](#BKMK_msdyn_CustomGPSTimestampfield)
- [msdyn_DatabaseVersion](#BKMK_msdyn_DatabaseVersion)
- [msdyn_datepopulationtype](#BKMK_msdyn_datepopulationtype)
- [msdyn_DeactivateBookingWhenCanceled](#BKMK_msdyn_DeactivateBookingWhenCanceled)
- [msdyn_DeactivateBookingWhenCompleted](#BKMK_msdyn_DeactivateBookingWhenCompleted)
- [msdyn_DeactivateWorkOrderWhenCanceled](#BKMK_msdyn_DeactivateWorkOrderWhenCanceled)
- [msdyn_DeactivateWorkOrderWhenPosted](#BKMK_msdyn_DeactivateWorkOrderWhenPosted)
- [msdyn_DefaultBookingDuration](#BKMK_msdyn_DefaultBookingDuration)
- [msdyn_DefaultCanceledBookingStatus](#BKMK_msdyn_DefaultCanceledBookingStatus)
- [msdyn_DefaultCrewStrategy](#BKMK_msdyn_DefaultCrewStrategy)
- [msdyn_DefaultRadiusUnit](#BKMK_msdyn_DefaultRadiusUnit)
- [msdyn_DefaultRadiusValue](#BKMK_msdyn_DefaultRadiusValue)
- [msdyn_DefaultScheduledBookingStatus](#BKMK_msdyn_DefaultScheduledBookingStatus)
- [msdyn_DefaultWarehouse](#BKMK_msdyn_DefaultWarehouse)
- [msdyn_DefaultWorkOrderCompletedStatus](#BKMK_msdyn_DefaultWorkOrderCompletedStatus)
- [msdyn_disablecustomerassetvalidation](#BKMK_msdyn_disablecustomerassetvalidation)
- [msdyn_DisableRemoteAssistBookingStatusChanges](#BKMK_msdyn_DisableRemoteAssistBookingStatusChanges)
- [msdyn_EnableAddressSuggestions](#BKMK_msdyn_EnableAddressSuggestions)
- [msdyn_EnableIncidentTypeRecommendation](#BKMK_msdyn_EnableIncidentTypeRecommendation)
- [msdyn_EnableLegacyScheduleAssistant](#BKMK_msdyn_EnableLegacyScheduleAssistant)
- [msdyn_EnableMainFormDialogForSubgrids](#BKMK_msdyn_EnableMainFormDialogForSubgrids)
- [msdyn_EnableNTE](#BKMK_msdyn_EnableNTE)
- [msdyn_EnableSuggestedDuration](#BKMK_msdyn_EnableSuggestedDuration)
- [msdyn_EnhancedBackgroundProcessing](#BKMK_msdyn_EnhancedBackgroundProcessing)
- [msdyn_EntityNumberLength](#BKMK_msdyn_EntityNumberLength)
- [msdyn_fieldservicesettingId](#BKMK_msdyn_fieldservicesettingId)
- [msdyn_GenerateActuals](#BKMK_msdyn_GenerateActuals)
- [msdyn_GenerateAgreementInvoicesXDaysInAdvance](#BKMK_msdyn_GenerateAgreementInvoicesXDaysInAdvance)
- [msdyn_GenerateAgreementWOXDaysInAdvance](#BKMK_msdyn_GenerateAgreementWOXDaysInAdvance)
- [msdyn_GenerateBookingDatesXMonthsInAdvance](#BKMK_msdyn_GenerateBookingDatesXMonthsInAdvance)
- [msdyn_GenerateInvoiceDatesXMonthsInAdvance](#BKMK_msdyn_GenerateInvoiceDatesXMonthsInAdvance)
- [msdyn_GPSLocationExpiresAfterXMinutes](#BKMK_msdyn_GPSLocationExpiresAfterXMinutes)
- [msdyn_HistoricalDataFilter](#BKMK_msdyn_HistoricalDataFilter)
- [msdyn_InspectionAnalyticsEnabled](#BKMK_msdyn_InspectionAnalyticsEnabled)
- [msdyn_InspectionAnalyticsEnabledOn](#BKMK_msdyn_InspectionAnalyticsEnabledOn)
- [msdyn_InspectionAnalyticsFrequency](#BKMK_msdyn_InspectionAnalyticsFrequency)
- [msdyn_InspectionAnalyticsRecommendedTime](#BKMK_msdyn_InspectionAnalyticsRecommendedTime)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_InventoryAdjustmentPrefix](#BKMK_msdyn_InventoryAdjustmentPrefix)
- [msdyn_InventoryAdjustmentStartingNumber](#BKMK_msdyn_InventoryAdjustmentStartingNumber)
- [msdyn_InventoryTransferPrefix](#BKMK_msdyn_InventoryTransferPrefix)
- [msdyn_InventoryTransferStartingNumber](#BKMK_msdyn_InventoryTransferStartingNumber)
- [msdyn_LastRunOfIncidentTypeRecommendation](#BKMK_msdyn_LastRunOfIncidentTypeRecommendation)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_NotificationTimeout](#BKMK_msdyn_NotificationTimeout)
- [msdyn_OvertimePayType](#BKMK_msdyn_OvertimePayType)
- [msdyn_PostponeNumberCleanupUntil](#BKMK_msdyn_PostponeNumberCleanupUntil)
- [msdyn_ProductCostOrder](#BKMK_msdyn_ProductCostOrder)
- [msdyn_PurchaseOrderApprovalRequired](#BKMK_msdyn_PurchaseOrderApprovalRequired)
- [msdyn_PurchaseOrderPrefix](#BKMK_msdyn_PurchaseOrderPrefix)
- [msdyn_PurchaseOrderStartingNumber](#BKMK_msdyn_PurchaseOrderStartingNumber)
- [msdyn_ResourcesSynchronizationTimeout](#BKMK_msdyn_ResourcesSynchronizationTimeout)
- [msdyn_ReturnTopXRecommendations](#BKMK_msdyn_ReturnTopXRecommendations)
- [msdyn_RMAPrefix](#BKMK_msdyn_RMAPrefix)
- [msdyn_RMAStartingNumber](#BKMK_msdyn_RMAStartingNumber)
- [msdyn_RTVPrefix](#BKMK_msdyn_RTVPrefix)
- [msdyn_RTVStartingNumber](#BKMK_msdyn_RTVStartingNumber)
- [msdyn_RunFrequencyOfIncidentTypeRecommendation](#BKMK_msdyn_RunFrequencyOfIncidentTypeRecommendation)
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
- [msdyn_ShowSimplifiedWorkOrderCommands](#BKMK_msdyn_ShowSimplifiedWorkOrderCommands)
- [msdyn_suggestreparentingcustomerassets](#BKMK_msdyn_suggestreparentingcustomerassets)
- [msdyn_TimeCostActualsSource](#BKMK_msdyn_TimeCostActualsSource)
- [msdyn_TimeEntryGenerationStrategy](#BKMK_msdyn_TimeEntryGenerationStrategy)
- [msdyn_TimestampFrequency](#BKMK_msdyn_TimestampFrequency)
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

### <a name="BKMK_msdyn_AdvancedSettings"></a> msdyn_AdvancedSettings

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Advanced Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_advancedsettings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_AgreementPrefix"></a> msdyn_AgreementPrefix

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agreement Prefix (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementprefix`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_AgreementRecordGeneration"></a> msdyn_AgreementRecordGeneration

|Property|Value|
|---|---|
|Description|**This field defines the time of day when Work Orders and Invoices are generated by the Agreement Booking Setups and Agreement Invoice Setups where the timing was not defined on the related Agreement.**|
|DisplayName|**Agreement Record Generation Timing**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementrecordgeneration`|
|RequiredLevel|Recommended|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_AgreementStartingNumber"></a> msdyn_AgreementStartingNumber

|Property|Value|
|---|---|
|Description||
|DisplayName|**Agreement Starting Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementstartingnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_AnalyticsIngestDataInXDays"></a> msdyn_AnalyticsIngestDataInXDays

|Property|Value|
|---|---|
|Description||
|DisplayName|**Analytics Ingestion in X Days**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_analyticsingestdatainxdays`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|365|
|MinValue|1|

### <a name="BKMK_msdyn_AnalyticsPostponeIngestionUntil"></a> msdyn_AnalyticsPostponeIngestionUntil

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduled Analytics Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_analyticspostponeingestionuntil`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_AnalyticsSpreadOutPostponeIngestionUntil"></a> msdyn_AnalyticsSpreadOutPostponeIngestionUntil

|Property|Value|
|---|---|
|Description||
|DisplayName|**Spread Out Scheduled Analytics Date**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_analyticsspreadoutpostponeingestionuntil`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_AutoAllocateEstimatedProducts"></a> msdyn_AutoAllocateEstimatedProducts

|Property|Value|
|---|---|
|Description|**If enabled then Allocated will be automatically set when entering a Work order Product with a Line Status of Estimate.**|
|DisplayName|**Auto Allocate Estimated Products**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autoallocateestimatedproducts`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_autoallocateestimatedproducts`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_AutoGenerateWOforAgreementBookings"></a> msdyn_AutoGenerateWOforAgreementBookings

|Property|Value|
|---|---|
|Description||
|DisplayName|**Auto Generate WO for Agreement Booking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autogeneratewoforagreementbooking`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_autogeneratewoforagreementbooking`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_AutoGeoCodeAddresses"></a> msdyn_AutoGeoCodeAddresses

|Property|Value|
|---|---|
|Description|**If set then the system will automatically geo code addresses when the address has been updated and the record is saved**|
|DisplayName|**Auto Geo Code Addresses**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autogeocodeaddresses`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_autogeocodeaddresses`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_AutoNumberingOptIn"></a> msdyn_AutoNumberingOptIn

|Property|Value|
|---|---|
|Description|**For Internal Use. If Yes the org is opted in for use of latest autonumbering implementation. If No the org is not opted in.**|
|DisplayName|**Auto-Numbering Opt In**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autonumberingoptin`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_autonumberingoptin`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_BookingAlertTemplate"></a> msdyn_BookingAlertTemplate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Booking Alert Template (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_bookingalerttemplate`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_BreakPayType"></a> msdyn_BreakPayType

|Property|Value|
|---|---|
|Description|**Default Pay Type to be used for Break hours**|
|DisplayName|**Break Pay Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_breakpaytype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_resourcepaytype|

### <a name="BKMK_msdyn_BusinessClosurePayType"></a> msdyn_BusinessClosurePayType

|Property|Value|
|---|---|
|Description|**Default Pay Type to be used for business closure work hours**|
|DisplayName|**Business Closure Pay Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_businessclosurepaytype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_resourcepaytype|

### <a name="BKMK_msdyn_CalculateCost"></a> msdyn_CalculateCost

|Property|Value|
|---|---|
|Description|**When disabled, all cost calculation logic on work orders, work order products, and work order services will be disabled and relevant cost fields will be hidden.**|
|DisplayName|**Calculate Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_calculatecost`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_fieldservicesetting_msdyn_calculatecost`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_CalculatePrice"></a> msdyn_CalculatePrice

|Property|Value|
|---|---|
|Description|**When disabled, all price calculation logic on work orders, work order products, and work order services will be disabled and relevant pricing fields will be hidden.**|
|DisplayName|**Calculate Price**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_calculateprice`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_fieldservicesetting_msdyn_calculateprice`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_CalculateTax"></a> msdyn_CalculateTax

|Property|Value|
|---|---|
|Description|**On disabling, all tax related fields will be removed and no tax calculations will be performed.**|
|DisplayName|**Calculate Tax**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_calculatetax`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_fieldservicesetting_msdyn_calculatetax`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_CancelCurrentSlotsWhenMoving"></a> msdyn_CancelCurrentSlotsWhenMoving

|Property|Value|
|---|---|
|Description|**Select whether, when moving open slots to the next day, to leave the old slots and change their status to "Cancel."**|
|DisplayName|**Cancel Current Slots When Moving (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_cancelcurrentslotswhenmoving`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_cancelcurrentslotswhenmoving`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_CustomGPSData"></a> msdyn_CustomGPSData

|Property|Value|
|---|---|
|Description|**If enabled system will use custom entity for its source of Geo Locations for resources to be displayed on map view**|
|DisplayName|**Custom GPS Data (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customgpsdata`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_customgpsdata`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_CustomGPSLatitudefield"></a> msdyn_CustomGPSLatitudefield

|Property|Value|
|---|---|
|Description|**Shows the logical name of the latitude field to be used for geolocations.**|
|DisplayName|**Custom GPS Latitude field (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customgpslatitudefield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CustomGPSLocationentity"></a> msdyn_CustomGPSLocationentity

|Property|Value|
|---|---|
|Description|**Shows the logical name of custom entity to be used for geolocations.**|
|DisplayName|**Custom GPS Location entity (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customgpslocationentity`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CustomGPSLongitudefield"></a> msdyn_CustomGPSLongitudefield

|Property|Value|
|---|---|
|Description|**Shows the logical name of the longitude field to be used for geolocations.**|
|DisplayName|**Custom GPS Longitude field (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customgpslongitudefield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CustomGPSResourcefield"></a> msdyn_CustomGPSResourcefield

|Property|Value|
|---|---|
|Description|**Shows the logical name of the resource field to be used for geolocations.**|
|DisplayName|**Custom GPS Resource field (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customgpsresourcefield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_CustomGPSTimestampfield"></a> msdyn_CustomGPSTimestampfield

|Property|Value|
|---|---|
|Description|**Shows the logical name of the timestamp field to be used for geolocations.**|
|DisplayName|**Custom GPS Timestamp field (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customgpstimestampfield`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_DatabaseVersion"></a> msdyn_DatabaseVersion

|Property|Value|
|---|---|
|Description|**For Internal Use**|
|DisplayName|**Database Version**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_databaseversion`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_datepopulationtype"></a> msdyn_datepopulationtype

|Property|Value|
|---|---|
|Description|**Pre/Post Booking Flexibility Date Field Population.**|
|DisplayName|**Pre/Post Booking Flexibility Date Field Population**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_datepopulationtype`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_fieldservicesetting_msdyn_datepopulationtype`|
|DefaultValue|False|
|True Label|Populate Time From Promised/Time To Promised|
|False Label|Populate Date Window Start/Date Window End|

### <a name="BKMK_msdyn_DeactivateBookingWhenCanceled"></a> msdyn_DeactivateBookingWhenCanceled

|Property|Value|
|---|---|
|Description|**Select whether the system should deactivate the resource booking when the system status is changed to "Canceled."**|
|DisplayName|**Deactivate Booking When Canceled (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_deactivatebookingwhencanceled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_deactivatebookingwhencanceled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DeactivateBookingWhenCompleted"></a> msdyn_DeactivateBookingWhenCompleted

|Property|Value|
|---|---|
|Description|**Select whether the system should deactivate the resource booking when the system status is changed to "Completed."**|
|DisplayName|**Deactivate Booking When Completed (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_deactivatebookingwhencompleted`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_deactivatebookingwhencompleted`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DeactivateWorkOrderWhenCanceled"></a> msdyn_DeactivateWorkOrderWhenCanceled

|Property|Value|
|---|---|
|Description|**Select whether the system should deactivate the work order when the system status is changed to "Closed - Canceled."**|
|DisplayName|**Deactivate Work Order When Canceled (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_deactivateworkorderwhencanceled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_deactivateworkorderwhencanceled`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DeactivateWorkOrderWhenPosted"></a> msdyn_DeactivateWorkOrderWhenPosted

|Property|Value|
|---|---|
|Description|**Select whether the system should deactivate the work order when the system status is changed to "Closed - Posted."**|
|DisplayName|**Deactivate Work Order When Posted (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_deactivateworkorderwhenposted`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_deactivateworkorderwhenposted`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DefaultBookingDuration"></a> msdyn_DefaultBookingDuration

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default Booking Duration (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultbookingduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_DefaultCanceledBookingStatus"></a> msdyn_DefaultCanceledBookingStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default Canceled Booking Status (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultcanceledbookingstatus`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookingstatus|

### <a name="BKMK_msdyn_DefaultCrewStrategy"></a> msdyn_DefaultCrewStrategy

|Property|Value|
|---|---|
|Description|**Default Crew Strategy**|
|DisplayName|**Default Crew Strategy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultcrewstrategy`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|-1|
|GlobalChoiceName|`msdyn_crewstrategy`|

#### msdyn_DefaultCrewStrategy Choices/Options

|Value|Label|
|---|---|
|192350000|**Cascade and Accept Cascade Completely \(Not Recommended\)**|
|192350001|**Crew Leader Management**|
|192350002|**Crew Member Self\-Management**|

### <a name="BKMK_msdyn_DefaultRadiusUnit"></a> msdyn_DefaultRadiusUnit

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default Radius Unit (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultradiusunit`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_defaultradiusunit`|
|DefaultValue|True|
|True Label|mi|
|False Label|km|

### <a name="BKMK_msdyn_DefaultRadiusValue"></a> msdyn_DefaultRadiusValue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default Radius Value (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultradiusvalue`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_DefaultScheduledBookingStatus"></a> msdyn_DefaultScheduledBookingStatus

|Property|Value|
|---|---|
|Description||
|DisplayName|**Default Scheduled Booking Status (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultscheduledbookingstatus`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookingstatus|

### <a name="BKMK_msdyn_DefaultWarehouse"></a> msdyn_DefaultWarehouse

|Property|Value|
|---|---|
|Description|**Shows the warehouse associated with the field service setting.**|
|DisplayName|**Default Warehouse**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultwarehouse`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_warehouse|

### <a name="BKMK_msdyn_DefaultWorkOrderCompletedStatus"></a> msdyn_DefaultWorkOrderCompletedStatus

|Property|Value|
|---|---|
|Description|**Select whether the default work order completed status is either "Completed" or "Posted."**|
|DisplayName|**Default Work Order Completed Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_defaultworkordercompletedstatus`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970003|
|GlobalChoiceName|`msdyn_wosystemstatus`|

#### msdyn_DefaultWorkOrderCompletedStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Unscheduled**|
|690970001|**Scheduled**|
|690970002|**In Progress**|
|690970003|**Completed**|
|690970004|**Posted**|
|690970005|**Canceled**|

### <a name="BKMK_msdyn_disablecustomerassetvalidation"></a> msdyn_disablecustomerassetvalidation

|Property|Value|
|---|---|
|Description|**This field turns off validation on customer asset for service account**|
|DisplayName|**Disable Customer Asset Validation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_disablecustomerassetvalidation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_fieldservicesetting_msdyn_disablecustomerassetvalidation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DisableRemoteAssistBookingStatusChanges"></a> msdyn_DisableRemoteAssistBookingStatusChanges

|Property|Value|
|---|---|
|Description|**Specifies whether users can make booking status changes in the Remote Assist application.**|
|DisplayName|**Disable Booking Status Changes on Remote Assist**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_disableremoteassistbookingstatuschanges`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_disableremoteassistbookingstatuschanges`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableAddressSuggestions"></a> msdyn_EnableAddressSuggestions

|Property|Value|
|---|---|
|Description|**If enabled then address suggestions will be displayed when editing the address on the account, contact, user, or work order form.**|
|DisplayName|**Enable Address Suggestions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableaddresssuggestions`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_enableaddresssuggestions`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableIncidentTypeRecommendation"></a> msdyn_EnableIncidentTypeRecommendation

|Property|Value|
|---|---|
|Description|**Enable Incident Type Suggestion. When enabled, the system will generate suggestions to improve Incident Types based on completed Work Orders.**|
|DisplayName|**Enable Incident Type Suggestion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enableincidenttyperecommendation`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_enableincidenttyperecommendation`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableLegacyScheduleAssistant"></a> msdyn_EnableLegacyScheduleAssistant

|Property|Value|
|---|---|
|Description||
|DisplayName|**Enable Legacy Schedule Assistant (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablelegacyscheduleassistant`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_enablelegacyscheduleassistant`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableMainFormDialogForSubgrids"></a> msdyn_EnableMainFormDialogForSubgrids

|Property|Value|
|---|---|
|Description|**When enabled, specific Work Order subgrid records open in a pop-up within the context of the parent (WO Service Task, WO Product, WO Service, WO Incident, Booking, and Time Entry).**|
|DisplayName|**Work Order Subgrid Records Open as Popups**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablemainformdialogforsubgrids`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_fieldservicesetting_msdyn_enablemainformdialogforsubgrids`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableNTE"></a> msdyn_EnableNTE

|Property|Value|
|---|---|
|Description|**Identifies whether not-to-exceed capability is enabled in Field Service application.**|
|DisplayName|**Enable not-to-exceed**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablente`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_enablente`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnableSuggestedDuration"></a> msdyn_EnableSuggestedDuration

|Property|Value|
|---|---|
|Description|**Enable Suggested Duration for Incident Type. System will calculate Suggested Duration daily or on demand based on historical bookings**|
|DisplayName|**Enables the suggested duration functionality**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enablesuggestedduration`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_enablesuggestedduration`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EnhancedBackgroundProcessing"></a> msdyn_EnhancedBackgroundProcessing

|Property|Value|
|---|---|
|Description|**When this option is enabled, all asynchronous Field Service background processes will be processed through Flow or asynchronous plugins instead of the historic Field Service workflows. See documentation for more details.**|
|DisplayName|**Use Enhanced Background Processing (Preview)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_enhancedbackgroundprocessing`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_enhancedbackgroundprocessing`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_EntityNumberLength"></a> msdyn_EntityNumberLength

|Property|Value|
|---|---|
|Description||
|DisplayName|**Entity Number Length  (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitynumberlength`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|10|
|MinValue|0|

### <a name="BKMK_msdyn_fieldservicesettingId"></a> msdyn_fieldservicesettingId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Field Service Setting**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_fieldservicesettingid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_GenerateActuals"></a> msdyn_GenerateActuals

|Property|Value|
|---|---|
|Description|**On disabling, actuals will not be generated.**|
|DisplayName|**Generate Actuals**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_generateactuals`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_fieldservicesetting_msdyn_generateactuals`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_GenerateAgreementInvoicesXDaysInAdvance"></a> msdyn_GenerateAgreementInvoicesXDaysInAdvance

|Property|Value|
|---|---|
|Description||
|DisplayName|**Generate Agreement Invoices X Days In Advance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_generateagreementinvoicesxdaysinadvance`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_GenerateAgreementWOXDaysInAdvance"></a> msdyn_GenerateAgreementWOXDaysInAdvance

|Property|Value|
|---|---|
|Description|**Specify default how many days in advance of the Agreement Booking Date the system should automatically generate a Work Order**|
|DisplayName|**Generate Agreement WO X Days In Advance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_generateagreementwoxdaysinadvance`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_GenerateBookingDatesXMonthsInAdvance"></a> msdyn_GenerateBookingDatesXMonthsInAdvance

|Property|Value|
|---|---|
|Description||
|DisplayName|**Generate Booking Dates X Months In Advance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_generatebookingdatesxmonthsinadvance`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_GenerateInvoiceDatesXMonthsInAdvance"></a> msdyn_GenerateInvoiceDatesXMonthsInAdvance

|Property|Value|
|---|---|
|Description||
|DisplayName|**Generate Invoice Dates X Months In Advance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_generateinvoicedatesxmonthsinadvance`|
|RequiredLevel|ApplicationRequired|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_GPSLocationExpiresAfterXMinutes"></a> msdyn_GPSLocationExpiresAfterXMinutes

|Property|Value|
|---|---|
|Description||
|DisplayName|**GPS Location Expires After X Minutes (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_gpslocationexpiresafterxminutes`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_HistoricalDataFilter"></a> msdyn_HistoricalDataFilter

|Property|Value|
|---|---|
|Description|**Choose the range of date to use for suggested duration calculation**|
|DisplayName|**Historical Data Filter**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_historicaldatafilter`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_historicaldatafilter`|

#### msdyn_HistoricalDataFilter Choices/Options

|Value|Label|
|---|---|
|100000000|**Last 3 Months**|
|100000001|**Last 6 Months**|
|100000002|**Last 12 Months**|
|100000003|**All**|

### <a name="BKMK_msdyn_InspectionAnalyticsEnabled"></a> msdyn_InspectionAnalyticsEnabled

|Property|Value|
|---|---|
|Description||
|DisplayName|**Analytics Enabled**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inspectionanalyticsenabled`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_inspectionanalyticsenabled`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_InspectionAnalyticsEnabledOn"></a> msdyn_InspectionAnalyticsEnabledOn

|Property|Value|
|---|---|
|Description||
|DisplayName|**Analytics Enabled On**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inspectionanalyticsenabledon`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_InspectionAnalyticsFrequency"></a> msdyn_InspectionAnalyticsFrequency

|Property|Value|
|---|---|
|Description||
|DisplayName|**Analytics Frequency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inspectionanalyticsfrequency`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|100000000|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_inspectionanalyticsfrequency`|

#### msdyn_InspectionAnalyticsFrequency Choices/Options

|Value|Label|
|---|---|
|100000000|**Daily**|
|100000001|**Immediately**|
|100000002|**Custom**|

### <a name="BKMK_msdyn_InspectionAnalyticsRecommendedTime"></a> msdyn_InspectionAnalyticsRecommendedTime

|Property|Value|
|---|---|
|Description||
|DisplayName|**Analytics Ingestion Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inspectionanalyticsrecommendedtime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|---|---|
|Description|**For Field Service internal use only.**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_InventoryAdjustmentPrefix"></a> msdyn_InventoryAdjustmentPrefix

|Property|Value|
|---|---|
|Description|**Shows the prefix to be added to the inventory adjustment numbers.**|
|DisplayName|**Inventory Adjustment Prefix (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inventoryadjustmentprefix`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|25|

### <a name="BKMK_msdyn_InventoryAdjustmentStartingNumber"></a> msdyn_InventoryAdjustmentStartingNumber

|Property|Value|
|---|---|
|Description|**Shows the number to be used as the starting number for inventory adjustments.**|
|DisplayName|**Inventory Adjustment Starting Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inventoryadjustmentstartingnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_InventoryTransferPrefix"></a> msdyn_InventoryTransferPrefix

|Property|Value|
|---|---|
|Description|**Shows the prefix to be added to the inventory transfer numbers.**|
|DisplayName|**Inventory Transfer Prefix (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inventorytransferprefix`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|25|

### <a name="BKMK_msdyn_InventoryTransferStartingNumber"></a> msdyn_InventoryTransferStartingNumber

|Property|Value|
|---|---|
|Description|**Shows the number to be used as the starting number for inventory transfers.**|
|DisplayName|**Inventory Transfer Starting Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_inventorytransferstartingnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_LastRunOfIncidentTypeRecommendation"></a> msdyn_LastRunOfIncidentTypeRecommendation

|Property|Value|
|---|---|
|Description|**Shows when the last run of incident type suggestion happens.**|
|DisplayName|**Last Run Of Incident Type Suggestion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lastrunofincidenttyperecommendation`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
|DisplayName|**Name**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_name`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_NotificationTimeout"></a> msdyn_NotificationTimeout

|Property|Value|
|---|---|
|Description||
|DisplayName|**Notification Timeout (In sec) (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_notificationtimeout`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_OvertimePayType"></a> msdyn_OvertimePayType

|Property|Value|
|---|---|
|Description|**Default Pay Type to be used for overtime work hours**|
|DisplayName|**Overtime Pay Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_overtimepaytype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_resourcepaytype|

### <a name="BKMK_msdyn_PostponeNumberCleanupUntil"></a> msdyn_PostponeNumberCleanupUntil

|Property|Value|
|---|---|
|Description|**Shows the date when cleanup of unique numbers will occur.**|
|DisplayName|**Postpone Number Cleanup Until**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postponenumbercleanupuntil`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_ProductCostOrder"></a> msdyn_ProductCostOrder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Product Cost Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_productcostorder`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970000|
|GlobalChoiceName|`msdyn_productcostorder`|

#### msdyn_ProductCostOrder Choices/Options

|Value|Label|
|---|---|
|690970000|**Standard/Current**|
|690970001|**Current/Standard**|

### <a name="BKMK_msdyn_PurchaseOrderApprovalRequired"></a> msdyn_PurchaseOrderApprovalRequired

|Property|Value|
|---|---|
|Description|**Enable if a Purchase Order requires approval in order for the status to be changed to Submitted**|
|DisplayName|**Purchase Order Approval Required**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_purchaseorderapprovalrequired`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_purchaseorderapprovalrequired`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_PurchaseOrderPrefix"></a> msdyn_PurchaseOrderPrefix

|Property|Value|
|---|---|
|Description|**Shows the prefix to be added to the purchase order numbers.**|
|DisplayName|**Purchase Order Prefix (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_purchaseorderprefix`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|25|

### <a name="BKMK_msdyn_PurchaseOrderStartingNumber"></a> msdyn_PurchaseOrderStartingNumber

|Property|Value|
|---|---|
|Description|**Shows the number to be used as starting number for the automatically generated purchase order number.**|
|DisplayName|**Purchase Order Starting Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_purchaseorderstartingnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_ResourcesSynchronizationTimeout"></a> msdyn_ResourcesSynchronizationTimeout

|Property|Value|
|---|---|
|Description||
|DisplayName|**Resources Synchronization Timeout (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_resourcessynchronizationtimeout`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_ReturnTopXRecommendations"></a> msdyn_ReturnTopXRecommendations

|Property|Value|
|---|---|
|Description|**Return Top X suggstion result from last run.**|
|DisplayName|**Return Top X Suggestions**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_returntopxrecommendations`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|20|
|MinValue|1|

### <a name="BKMK_msdyn_RMAPrefix"></a> msdyn_RMAPrefix

|Property|Value|
|---|---|
|Description||
|DisplayName|**RMA Prefix (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rmaprefix`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_RMAStartingNumber"></a> msdyn_RMAStartingNumber

|Property|Value|
|---|---|
|Description|**Shows the number to be used as the starting number for the automatically generation RMA number.**|
|DisplayName|**RMA Starting Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rmastartingnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_RTVPrefix"></a> msdyn_RTVPrefix

|Property|Value|
|---|---|
|Description||
|DisplayName|**RTV Prefix (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rtvprefix`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_RTVStartingNumber"></a> msdyn_RTVStartingNumber

|Property|Value|
|---|---|
|Description|**Shows the number to be used as the starting number for the automatically generated RTV number.**|
|DisplayName|**RTV Starting Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_rtvstartingnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_RunFrequencyOfIncidentTypeRecommendation"></a> msdyn_RunFrequencyOfIncidentTypeRecommendation

|Property|Value|
|---|---|
|Description|**Specify the run frequency of incident type suggestion.**|
|DisplayName|**Run Frequency Of Incident Type Suggestion**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_runfrequencyofincidenttyperecommendation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350000|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_runfrequencyofincidenttyperecommendation`|

#### msdyn_RunFrequencyOfIncidentTypeRecommendation Choices/Options

|Value|Label|
|---|---|
|192350000|**Once a Week**|

### <a name="BKMK_msdyn_SAAutoFilterServiceTerritory"></a> msdyn_SAAutoFilterServiceTerritory

|Property|Value|
|---|---|
|Description|**Select whether the schedule assistant should automatically filter the results based on the territory set on the work order.**|
|DisplayName|**Auto Filter Service Territory (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_saautofilterserviceterritory`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_saautofilterserviceterritory`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_SchedulerBusinessUnitDetailsView"></a> msdyn_SchedulerBusinessUnitDetailsView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduler Business Unit Details View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerbusinessunitdetailsview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_SchedulerBusinessUnitTooltipView"></a> msdyn_SchedulerBusinessUnitTooltipView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduler Business Unit Tooltip View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerbusinessunittooltipview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_SchedulerCoreDetailsView"></a> msdyn_SchedulerCoreDetailsView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduler Core Details View (Deprecated)**|
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
|DisplayName|**Scheduler Core Slot Text Template (Deprecated)**|
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
|DisplayName|**Scheduler Core Tooltip View (Deprecated)**|
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
|DisplayName|**Scheduler Field Service Details View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerfieldservicedetailsview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_SchedulerFieldServiceSlotTextTemplate"></a> msdyn_SchedulerFieldServiceSlotTextTemplate

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduler Field Service Slot Text Template (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerfieldserviceslottexttemplate`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|5000|

### <a name="BKMK_msdyn_SchedulerFieldServiceTooltipView"></a> msdyn_SchedulerFieldServiceTooltipView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduler Field Service Tooltip View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerfieldservicetooltipview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_SchedulerResourceDetailsView"></a> msdyn_SchedulerResourceDetailsView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduler Resource Details View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerresourcedetailsview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_SchedulerResourceTooltipView"></a> msdyn_SchedulerResourceTooltipView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduler Resource Tooltip View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerresourcetooltipview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_SchedulerUnscheduledView"></a> msdyn_SchedulerUnscheduledView

|Property|Value|
|---|---|
|Description||
|DisplayName|**Scheduler Unscheduled View (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_schedulerunscheduledview`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_sdkapimapkey"></a> msdyn_sdkapimapkey

|Property|Value|
|---|---|
|Description|**Api key for map**|
|DisplayName|**Bing API Key (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_sdkapimapkey`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_ShowSimplifiedWorkOrderCommands"></a> msdyn_ShowSimplifiedWorkOrderCommands

|Property|Value|
|---|---|
|Description|**Enable/disable out of the box logic to show or hide commands on the Work Order form and list view. If yes, only the most relevant buttons will be displayed.**|
|DisplayName|**Show Simplified Work Order Commands**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_showsimplifiedworkordercommands`|
|RequiredLevel|SystemRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_fieldservicesetting_msdyn_showsimplifiedworkordercommands`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_suggestreparentingcustomerassets"></a> msdyn_suggestreparentingcustomerassets

|Property|Value|
|---|---|
|Description|**On enabling provides a dialog on change on customer asset/service account of workorder to make the account of customer asset same as service account of work order**|
|DisplayName|**Suggest Reparenting Customer Assets**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_suggestreparentingcustomerassets`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_fieldservicesetting_msdyn_suggestreparentingcustomerassets`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_TimeCostActualsSource"></a> msdyn_TimeCostActualsSource

|Property|Value|
|---|---|
|Description|**The Field Service solution automatically generates Actuals records. Actuals with a Transaction Type of "Cost" and a Transaction Class of "Time" can be generated when the Work Order is set to Closed-Posted from the related Booking's Booking Journals (Booking Journals on Post of Work Order) or when a Work Order related Time Entry is marked as Approved (Work Order Time Entry Approval).**|
|DisplayName|**Time Cost Actuals Source**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timecostactualssource`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192354000|
|GlobalChoiceName|`msdyn_timecostactualssource`|

#### msdyn_TimeCostActualsSource Choices/Options

|Value|Label|
|---|---|
|192354000|**Booking Journals on Post of Work Order**|
|192354001|**Work Order Time Entry Approval**|

### <a name="BKMK_msdyn_TimeEntryGenerationStrategy"></a> msdyn_TimeEntryGenerationStrategy

|Property|Value|
|---|---|
|Description|**Field Service organizations that do not intend to use Time Entry or that wish to generate them via a custom or manual process should set to 'Manual.' Otherwise, setting to "Auto-Generate from Booking Timestamps" will ensure that Time Entries are automatically created when a Booking is complete for each span of time between Booking Timestamps.**|
|DisplayName|**Time Entry Generation Strategy**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timeentrygenerationstrategy`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192355200|
|GlobalChoiceName|`msdyn_timeentrygenerationstrategy`|

#### msdyn_TimeEntryGenerationStrategy Choices/Options

|Value|Label|
|---|---|
|192355200|**Manual**|
|192355201|**Auto\-Generate from Booking Timestamps**|

### <a name="BKMK_msdyn_TimestampFrequency"></a> msdyn_TimestampFrequency

|Property|Value|
|---|---|
|Description|**The Timestamp Frequency setting controls the generation of Booking Timestamps as Bookings progress through Booking Statuses. Timestamps can either generate every time a Booking Status is changed (Per Booking Status) or when changing the Booking Status results in a new underlying Field Service Status (Per Field Service Status).**|
|DisplayName|**Timestamp Frequency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timestampfrequency`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|192350001|
|GlobalChoiceName|`msdyn_timestampfrequency`|

#### msdyn_TimestampFrequency Choices/Options

|Value|Label|
|---|---|
|192350000|**Per Booking Status Change**|
|192350001|**Per Field Service Status Change**|

### <a name="BKMK_msdyn_TravelChargeItemId"></a> msdyn_TravelChargeItemId

|Property|Value|
|---|---|
|Description|**Product to be used by the system for Travel Charges on Work Orders**|
|DisplayName|**Travel Charge Item**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_travelchargeitemid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_msdyn_TravelPayType"></a> msdyn_TravelPayType

|Property|Value|
|---|---|
|Description|**Default Pay Type to be used for Travel hours**|
|DisplayName|**Travel Pay Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_travelpaytype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_resourcepaytype|

### <a name="BKMK_msdyn_TravelTimeRescheduling"></a> msdyn_TravelTimeRescheduling

|Property|Value|
|---|---|
|Description||
|DisplayName|**Travel Time Rescheduling (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_traveltimerescheduling`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_traveltimerescheduling`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_UndefinedBookingLocation"></a> msdyn_UndefinedBookingLocation

|Property|Value|
|---|---|
|Description|**Location for schedules where geo code info has not been defined**|
|DisplayName|**Undefined Booking Location (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_undefinedbookinglocation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970000|
|GlobalChoiceName|`msdyn_fieldservicesetting_msdyn_undefinedbookinglocation`|

#### msdyn_UndefinedBookingLocation Choices/Options

|Value|Label|
|---|---|
|690970000|**Previous Known Location**|
|690970001|**Ignore Location**|

### <a name="BKMK_msdyn_UnscheduledWOTooltipsViewId"></a> msdyn_UnscheduledWOTooltipsViewId

|Property|Value|
|---|---|
|Description||
|DisplayName|**Unscheduled WO Tooltips View Id (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unscheduledwotooltipsviewid`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|50|

### <a name="BKMK_msdyn_UseofProductsOutofStock"></a> msdyn_UseofProductsOutofStock

|Property|Value|
|---|---|
|Description|**Specify how the system should react when trying to use products that are out of stock.**|
|DisplayName|**Use of Products Out of Stock**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_useofproductsoutofstock`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970000|
|GlobalChoiceName|`msdyn_outofstockoptions`|

#### msdyn_UseofProductsOutofStock Choices/Options

|Value|Label|
|---|---|
|690970000|**Confirm**|
|690970001|**Restrict**|

### <a name="BKMK_msdyn_WorkOrderInvoiceCreation"></a> msdyn_WorkOrderInvoiceCreation

|Property|Value|
|---|---|
|Description|**Specify whether the system should automatically generate an invoice for work orders.**|
|DisplayName|**Work Order Invoice Creation**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderinvoicecreation`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|690970001|
|GlobalChoiceName|`msdyn_autocreateinvoices`|

#### msdyn_WorkOrderInvoiceCreation Choices/Options

|Value|Label|
|---|---|
|690970000|**Never**|
|690970001|**On Work Order Posted**|

### <a name="BKMK_msdyn_WorkOrderPrefix"></a> msdyn_WorkOrderPrefix

|Property|Value|
|---|---|
|Description||
|DisplayName|**Work Order Prefix (Deprecated)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderprefix`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_WorkOrderStartingNumber"></a> msdyn_WorkOrderStartingNumber

|Property|Value|
|---|---|
|Description||
|DisplayName|**Work Order Starting Number**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderstartingnumber`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_WorkPayType"></a> msdyn_WorkPayType

|Property|Value|
|---|---|
|Description|**Default Pay Type to be used for regular work hours**|
|DisplayName|**Work Pay Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workpaytype`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_resourcepaytype|

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
|Description|**Status of the Field Service Setting**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_fieldservicesetting_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Field Service Setting**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_fieldservicesetting_statuscode`|

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

- [msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus](#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus)
- [msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus](#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType)
- [msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType](#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType)
- [msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse)
- [msdyn_product_msdyn_fieldservicesetting](#BKMK_msdyn_product_msdyn_fieldservicesetting)

### <a name="BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus"></a> msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus

One-To-Many Relationship: [bookingstatus msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultCanceledBookingStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`bookingstatus`|
|ReferencedAttribute|`bookingstatusid`|
|ReferencingAttribute|`msdyn_defaultcanceledbookingstatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_defaultcanceledbookingstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus"></a> msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus

One-To-Many Relationship: [bookingstatus msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus](bookingstatus.md#BKMK_msdyn_bookingstatus_msdyn_fieldservicesetting_DefaultScheduledBookingStatus)

|Property|Value|
|---|---|
|ReferencedEntity|`bookingstatus`|
|ReferencedAttribute|`bookingstatusid`|
|ReferencingAttribute|`msdyn_defaultscheduledbookingstatus`|
|ReferencingEntityNavigationPropertyName|`msdyn_defaultscheduledbookingstatus`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType](msdyn_resourcepaytype.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BreakPayType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`msdyn_breakpaytype`|
|ReferencingEntityNavigationPropertyName|`msdyn_breakpaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType](msdyn_resourcepaytype.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_BusinessClosurePayType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`msdyn_businessclosurepaytype`|
|ReferencingEntityNavigationPropertyName|`msdyn_businessclosurepaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType](msdyn_resourcepaytype.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_OvertimePayType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`msdyn_overtimepaytype`|
|ReferencingEntityNavigationPropertyName|`msdyn_overtimepaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType](msdyn_resourcepaytype.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_TravelPayType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`msdyn_travelpaytype`|
|ReferencingEntityNavigationPropertyName|`msdyn_travelpaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType"></a> msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType

One-To-Many Relationship: [msdyn_resourcepaytype msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType](msdyn_resourcepaytype.md#BKMK_msdyn_msdyn_resourcepaytype_msdyn_fieldservicesetting_WorkPayType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_resourcepaytype`|
|ReferencedAttribute|`msdyn_resourcepaytypeid`|
|ReferencingAttribute|`msdyn_workpaytype`|
|ReferencingEntityNavigationPropertyName|`msdyn_workpaytype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse"></a> msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse

One-To-Many Relationship: [msdyn_warehouse msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_fieldservicesetting_DefaultWarehouse)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`msdyn_defaultwarehouse`|
|ReferencingEntityNavigationPropertyName|`msdyn_defaultwarehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_product_msdyn_fieldservicesetting"></a> msdyn_product_msdyn_fieldservicesetting

One-To-Many Relationship: [product msdyn_product_msdyn_fieldservicesetting](product.md#BKMK_msdyn_product_msdyn_fieldservicesetting)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_travelchargeitemid`|
|ReferencingEntityNavigationPropertyName|`msdyn_travelchargeitemid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|


## One-to-Many relationships

These relationships are one-to-many. Listed by **SchemaName**.

### <a name="BKMK_msdyn_fieldservicesetting_msdyn_bookingalerts"></a> msdyn_fieldservicesetting_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_fieldservicesetting_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_fieldservicesetting_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_fieldservicesetting_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](/power-apps/developer/data-platform/reference/about-entity-reference)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

