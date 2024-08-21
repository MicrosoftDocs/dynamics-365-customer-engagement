---
title: "Quote Booking Setup (msdyn_quotebookingsetup) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Quote Booking Setup (msdyn_quotebookingsetup) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/21/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Quote Booking Setup (msdyn_quotebookingsetup) table/entity reference

Specify the maintenance bookings for the agreement.

## Messages

The following table lists the messages for the Quote Booking Setup (msdyn_quotebookingsetup) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_quotebookingsetups<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_quotebookingsetups<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_quotebookingsetups(*msdyn_quotebookingsetupid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Quote Booking Setup (msdyn_quotebookingsetup) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Quote Booking Setup (msdyn_quotebookingsetup) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Quote Booking Setup** |
| **DisplayCollectionName** | **Quote Booking Setups** |
| **SchemaName** | `msdyn_quotebookingsetup` |
| **CollectionSchemaName** | `msdyn_quotebookingsetups` |
| **EntitySetName** | `msdyn_quotebookingsetups`|
| **LogicalName** | `msdyn_quotebookingsetup` |
| **LogicalCollectionName** | `msdyn_quotebookingsetups` |
| **PrimaryIdAttribute** | `msdyn_quotebookingsetupid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_autogeneratebooking](#BKMK_msdyn_autogeneratebooking)
- [msdyn_autogenerateworkorder](#BKMK_msdyn_autogenerateworkorder)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_EstimatedCost](#BKMK_msdyn_EstimatedCost)
- [msdyn_estimatedduration](#BKMK_msdyn_estimatedduration)
- [msdyn_EstimatedMargin](#BKMK_msdyn_EstimatedMargin)
- [msdyn_EstimatedMarginPerWO](#BKMK_msdyn_EstimatedMarginPerWO)
- [msdyn_EstimatedProductCost](#BKMK_msdyn_EstimatedProductCost)
- [msdyn_EstimatedProductRevenue](#BKMK_msdyn_EstimatedProductRevenue)
- [msdyn_EstimatedRevenue](#BKMK_msdyn_EstimatedRevenue)
- [msdyn_EstimatedRevenuePerWO](#BKMK_msdyn_EstimatedRevenuePerWO)
- [msdyn_EstimatedServiceCost](#BKMK_msdyn_EstimatedServiceCost)
- [msdyn_EstimatedServiceRevenue](#BKMK_msdyn_EstimatedServiceRevenue)
- [msdyn_generateworkorderdaysinadvance](#BKMK_msdyn_generateworkorderdaysinadvance)
- [msdyn_Internalflags](#BKMK_msdyn_Internalflags)
- [msdyn_Latitude](#BKMK_msdyn_Latitude)
- [msdyn_Longitude](#BKMK_msdyn_Longitude)
- [msdyn_Margin](#BKMK_msdyn_Margin)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_NumberOfWO](#BKMK_msdyn_NumberOfWO)
- [msdyn_postbookingflexibility](#BKMK_msdyn_postbookingflexibility)
- [msdyn_postponegenerationuntil](#BKMK_msdyn_postponegenerationuntil)
- [msdyn_prebookingflexibility](#BKMK_msdyn_prebookingflexibility)
- [msdyn_preferredresource](#BKMK_msdyn_preferredresource)
- [msdyn_preferredstarttime](#BKMK_msdyn_preferredstarttime)
- [msdyn_priority](#BKMK_msdyn_priority)
- [msdyn_quote](#BKMK_msdyn_quote)
- [msdyn_quotebookingsetupId](#BKMK_msdyn_quotebookingsetupId)
- [msdyn_quotedetail](#BKMK_msdyn_quotedetail)
- [msdyn_QuoteDetailId](#BKMK_msdyn_QuoteDetailId)
- [msdyn_recurrencesettings](#BKMK_msdyn_recurrencesettings)
- [msdyn_revision](#BKMK_msdyn_revision)
- [msdyn_timewindowend](#BKMK_msdyn_timewindowend)
- [msdyn_timewindowstart](#BKMK_msdyn_timewindowstart)
- [msdyn_WorkLocation](#BKMK_msdyn_WorkLocation)
- [msdyn_workordersummary](#BKMK_msdyn_workordersummary)
- [msdyn_workordertype](#BKMK_msdyn_workordertype)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [processid](#BKMK_processid)
- [stageid](#BKMK_stageid)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
- [traversedpath](#BKMK_traversedpath)
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

### <a name="BKMK_msdyn_autogeneratebooking"></a> msdyn_autogeneratebooking

|Property|Value|
|---|---|
|Description|**Enable if the system should automatically generate Order Bookings for the Booking Dates of this Booking Setup**|
|DisplayName|**Auto Generate Booking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autogeneratebooking`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_quotebookingsetup_msdyn_autogeneratebooking`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_autogenerateworkorder"></a> msdyn_autogenerateworkorder

|Property|Value|
|---|---|
|Description|**Enable if the system should automatically generate Work Orders for the Booking Dates of this Booking Setup**|
|DisplayName|**Auto Generate Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_autogenerateworkorder`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_quotebookingsetup_msdyn_autogenerateworkorder`|
|DefaultValue|True|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|---|---|
|Description|**Type a description of this booking setup.**|
|DisplayName|**Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_description`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|200|

### <a name="BKMK_msdyn_EstimatedCost"></a> msdyn_EstimatedCost

|Property|Value|
|---|---|
|Description||
|DisplayName|**Estimated Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_estimatedduration"></a> msdyn_estimatedduration

|Property|Value|
|---|---|
|Description|**Shows the duration of the booking.**|
|DisplayName|**Estimated Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_EstimatedMargin"></a> msdyn_EstimatedMargin

|Property|Value|
|---|---|
|Description|**The estimated margin for this Quote Booking Setup**|
|DisplayName|**EstimatedMargin**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedmargin`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_EstimatedMarginPerWO"></a> msdyn_EstimatedMarginPerWO

|Property|Value|
|---|---|
|Description||
|DisplayName|**EstimatedMarginPerWO**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedmarginperwo`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_EstimatedProductCost"></a> msdyn_EstimatedProductCost

|Property|Value|
|---|---|
|Description|**Estimated Costs of all Products that are associated to this Quote Booking Setup**|
|DisplayName|**EstimatedProductCost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedproductcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_EstimatedProductRevenue"></a> msdyn_EstimatedProductRevenue

|Property|Value|
|---|---|
|Description|**The sum of estimated revenue of all products that are associated to this quote booking setup**|
|DisplayName|**EstimatedProductRevenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedproductrevenue`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_EstimatedRevenue"></a> msdyn_EstimatedRevenue

|Property|Value|
|---|---|
|Description||
|DisplayName|**Estimated Revenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedrevenue`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_EstimatedRevenuePerWO"></a> msdyn_EstimatedRevenuePerWO

|Property|Value|
|---|---|
|Description|**The Estimated Revenue per Work Order**|
|DisplayName|**EstimatedRevenuePerWO**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedrevenueperwo`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_EstimatedServiceCost"></a> msdyn_EstimatedServiceCost

|Property|Value|
|---|---|
|Description|**The sum of the estimated costs of all quote booking services that are associated to this quote booking setup**|
|DisplayName|**EstimatedServiceCost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedservicecost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_EstimatedServiceRevenue"></a> msdyn_EstimatedServiceRevenue

|Property|Value|
|---|---|
|Description|**The sum of estimated revenue of all services that are associated to this quote booking setup**|
|DisplayName|**EstimatedServiceRevenue**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedservicerevenue`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|922337203685477|
|MinValue|0|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_generateworkorderdaysinadvance"></a> msdyn_generateworkorderdaysinadvance

|Property|Value|
|---|---|
|Description|**Specify how many days in advance of the Booking Date the system should automatically generate a Work Order**|
|DisplayName|**Generate Work Order Days In Advance**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_generateworkorderdaysinadvance`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Internalflags"></a> msdyn_Internalflags

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Internal Flags**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_Internalflags`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_Latitude"></a> msdyn_Latitude

|Property|Value|
|---|---|
|Description|**Only used when Work Location is a Facility. Latitude is used when trying to locate nearby facilities.**|
|DisplayName|**Latitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_latitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|90|
|MinValue|-90|
|Precision|5|

### <a name="BKMK_msdyn_Longitude"></a> msdyn_Longitude

|Property|Value|
|---|---|
|Description|**Only used when Work Location is a Facility. Longitude is used when trying to locate nearby facilities.**|
|DisplayName|**Longitude**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_longitude`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|180|
|MinValue|-180|
|Precision|5|

### <a name="BKMK_msdyn_Margin"></a> msdyn_Margin

|Property|Value|
|---|---|
|Description||
|DisplayName|**Margin**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_margin`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Auto|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyn_NumberOfWO"></a> msdyn_NumberOfWO

|Property|Value|
|---|---|
|Description||
|DisplayName|**NumberOfWO**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_numberofwo`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_postbookingflexibility"></a> msdyn_postbookingflexibility

|Property|Value|
|---|---|
|Description|**Shows the flexibility of days after the booking date.**|
|DisplayName|**Post Booking Flexibility**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postbookingflexibility`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_postponegenerationuntil"></a> msdyn_postponegenerationuntil

|Property|Value|
|---|---|
|Description|**Shows the date until which Work Order generation can be postponed. Intended for internal use. Manipulating values in this field is not supported and can lead to unexpected system behavior.**|
|DisplayName|**Postpone Generation Until**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_postponegenerationuntil`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|TimeZoneIndependent|
|Format|DateAndTime|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_prebookingflexibility"></a> msdyn_prebookingflexibility

|Property|Value|
|---|---|
|Description|**Shows the flexibility of days prior to the booking date.**|
|DisplayName|**Pre Booking Flexibility**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_prebookingflexibility`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_preferredresource"></a> msdyn_preferredresource

|Property|Value|
|---|---|
|Description|**Preferred Resource to booked**|
|DisplayName|**Preferred Resource**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_preferredresource`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresource|

### <a name="BKMK_msdyn_preferredstarttime"></a> msdyn_preferredstarttime

|Property|Value|
|---|---|
|Description|**Shows the preferred time to booking.**|
|DisplayName|**Preferred Start Time**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_preferredstarttime`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Auto|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_priority"></a> msdyn_priority

|Property|Value|
|---|---|
|Description|**Booking Priority**|
|DisplayName|**Priority**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_priority`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_priority|

### <a name="BKMK_msdyn_quote"></a> msdyn_quote

|Property|Value|
|---|---|
|Description|**Quote this Booking Setup relates to**|
|DisplayName|**Quote**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quote`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|quote|

### <a name="BKMK_msdyn_quotebookingsetupId"></a> msdyn_quotebookingsetupId

|Property|Value|
|---|---|
|Description|**Unique identifier for entity instances**|
|DisplayName|**Quote Booking Setup**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_quotebookingsetupid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

### <a name="BKMK_msdyn_quotedetail"></a> msdyn_quotedetail

|Property|Value|
|---|---|
|Description|**Relationship between Quote Detail and Quote Booking Setup**|
|DisplayName|**Relationship between Quote Detail and Quote Booking Setup**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quotedetail_msdyn_quotebookingset`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|quotedetail|

### <a name="BKMK_msdyn_QuoteDetailId"></a> msdyn_QuoteDetailId

|Property|Value|
|---|---|
|Description||
|DisplayName|**QuoteDetailId**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quotedetailid`|
|RequiredLevel|ApplicationRequired|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|100|

### <a name="BKMK_msdyn_recurrencesettings"></a> msdyn_recurrencesettings

|Property|Value|
|---|---|
|Description|**Stores the booking recurrence settings.**|
|DisplayName|**Recurrence Settings**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_recurrencesettings`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1048576|

### <a name="BKMK_msdyn_revision"></a> msdyn_revision

|Property|Value|
|---|---|
|Description|**For internal use only.**|
|DisplayName|**Revision**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_revision`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|1|

### <a name="BKMK_msdyn_timewindowend"></a> msdyn_timewindowend

|Property|Value|
|---|---|
|Description|**Shows the time window up until when this can be booked.**|
|DisplayName|**Time Window End**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timewindowend`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_timewindowstart"></a> msdyn_timewindowstart

|Property|Value|
|---|---|
|Description|**Shows the time window from when this can be booked.**|
|DisplayName|**Time Window Start**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_timewindowstart`|
|RequiredLevel|None|
|Type|DateTime|
|CanChangeDateTimeBehavior|True|
|DateTimeBehavior|UserLocal|
|Format|DateOnly|
|ImeMode|Inactive|
|SourceTypeMask|0|

### <a name="BKMK_msdyn_WorkLocation"></a> msdyn_WorkLocation

|Property|Value|
|---|---|
|Description||
|DisplayName|**Work Location**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_worklocation`|
|RequiredLevel|None|
|Type|Picklist|
|DefaultFormValue|690970000|
|GlobalChoiceName|`msdyn_worklocation`|

#### msdyn_WorkLocation Choices/Options

|Value|Label|
|---|---|
|690970000|**Onsite**|
|690970001|**Facility**|
|690970002|**Location Agnostic**|

### <a name="BKMK_msdyn_workordersummary"></a> msdyn_workordersummary

|Property|Value|
|---|---|
|Description|**Shows the work order summary to be set on the work orders generated.**|
|DisplayName|**Work Order Summary**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workordersummary`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|8000|

### <a name="BKMK_msdyn_workordertype"></a> msdyn_workordertype

|Property|Value|
|---|---|
|Description|**Work Order Type to be used on generated Work Orders**|
|DisplayName|**Work Order Type**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workordertype`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_workordertype|

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

### <a name="BKMK_processid"></a> processid

|Property|Value|
|---|---|
|Description|**Contains the id of the process associated with the entity.**|
|DisplayName|**Process Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`processid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_stageid"></a> stageid

|Property|Value|
|---|---|
|Description|**Contains the id of the stage where the entity is located.**|
|DisplayName|**Stage Id**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`stageid`|
|RequiredLevel|None|
|Type|Uniqueidentifier|

### <a name="BKMK_statecode"></a> statecode

|Property|Value|
|---|---|
|Description|**Status of the Quote Booking Setup**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_quotebookingsetup_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Quote Booking Setup**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_quotebookingsetup_statuscode`|

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

### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

|Property|Value|
|---|---|
|Description|**Unique identifier of the currency associated with the entity.**|
|DisplayName|**Currency**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`transactioncurrencyid`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|transactioncurrency|

### <a name="BKMK_traversedpath"></a> traversedpath

|Property|Value|
|---|---|
|Description|**A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.**|
|DisplayName|**Traversed Path**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`traversedpath`|
|RequiredLevel|None|
|Type|String|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|1250|

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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_estimatedcost_Base](#BKMK_msdyn_estimatedcost_Base)
- [msdyn_estimatedproductcost_Base](#BKMK_msdyn_estimatedproductcost_Base)
- [msdyn_estimatedproductrevenue_Base](#BKMK_msdyn_estimatedproductrevenue_Base)
- [msdyn_estimatedrevenue_Base](#BKMK_msdyn_estimatedrevenue_Base)
- [msdyn_estimatedrevenueperwo_Base](#BKMK_msdyn_estimatedrevenueperwo_Base)
- [msdyn_estimatedservicecost_Base](#BKMK_msdyn_estimatedservicecost_Base)
- [msdyn_estimatedservicerevenue_Base](#BKMK_msdyn_estimatedservicerevenue_Base)
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

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Exchange rate for the currency associated with the entity with respect to the base currency.**|
|DisplayName|**Exchange Rate**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`exchangerate`|
|RequiredLevel|None|
|Type|Decimal|
|ImeMode|Disabled|
|MaxValue|100000000000|
|MinValue|1E-10|
|Precision|10|
|SourceTypeMask|0|

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

### <a name="BKMK_msdyn_estimatedcost_Base"></a> msdyn_estimatedcost_Base

|Property|Value|
|---|---|
|Description|**Value of the Estimated Cost in base currency.**|
|DisplayName|**Estimated Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_estimatedproductcost_Base"></a> msdyn_estimatedproductcost_Base

|Property|Value|
|---|---|
|Description|**Value of the EstimatedProductCost in base currency.**|
|DisplayName|**EstimatedProductCost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedproductcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_estimatedproductrevenue_Base"></a> msdyn_estimatedproductrevenue_Base

|Property|Value|
|---|---|
|Description|**Value of the EstimatedProductRevenue in base currency.**|
|DisplayName|**EstimatedProductRevenue (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedproductrevenue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_estimatedrevenue_Base"></a> msdyn_estimatedrevenue_Base

|Property|Value|
|---|---|
|Description|**Value of the Estimated Revenue in base currency.**|
|DisplayName|**Estimated Revenue (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedrevenue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_estimatedrevenueperwo_Base"></a> msdyn_estimatedrevenueperwo_Base

|Property|Value|
|---|---|
|Description|**Value of the EstimatedRevenuePerWO in base currency.**|
|DisplayName|**EstimatedRevenuePerWO (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedrevenueperwo_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_estimatedservicecost_Base"></a> msdyn_estimatedservicecost_Base

|Property|Value|
|---|---|
|Description|**Value of the EstimatedServiceCost in base currency.**|
|DisplayName|**EstimatedServiceCost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedservicecost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

### <a name="BKMK_msdyn_estimatedservicerevenue_Base"></a> msdyn_estimatedservicerevenue_Base

|Property|Value|
|---|---|
|Description|**Value of the EstimatedServiceRevenue in base currency.**|
|DisplayName|**EstimatedServiceRevenue (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatedservicerevenue_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2 (TransactionCurrency.CurrencyPrecision)|

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

- [business_unit_msdyn_quotebookingsetup](#BKMK_business_unit_msdyn_quotebookingsetup)
- [lk_msdyn_quotebookingsetup_createdby](#BKMK_lk_msdyn_quotebookingsetup_createdby)
- [lk_msdyn_quotebookingsetup_createdonbehalfby](#BKMK_lk_msdyn_quotebookingsetup_createdonbehalfby)
- [lk_msdyn_quotebookingsetup_modifiedby](#BKMK_lk_msdyn_quotebookingsetup_modifiedby)
- [lk_msdyn_quotebookingsetup_modifiedonbehalfby](#BKMK_lk_msdyn_quotebookingsetup_modifiedonbehalfby)
- [msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource](#BKMK_msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource)
- [msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority](#BKMK_msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority)
- [msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType](#BKMK_msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType)
- [msdyn_quote_msdyn_quotebookingsetup_Quote](#BKMK_msdyn_quote_msdyn_quotebookingsetup_Quote)
- [msdyn_quotedetail_msdyn_quotebookingsetup](#BKMK_msdyn_quotedetail_msdyn_quotebookingsetup)
- [owner_msdyn_quotebookingsetup](#BKMK_owner_msdyn_quotebookingsetup)
- [processstage_msdyn_quotebookingsetup](#BKMK_processstage_msdyn_quotebookingsetup)
- [team_msdyn_quotebookingsetup](#BKMK_team_msdyn_quotebookingsetup)
- [TransactionCurrency_msdyn_quotebookingsetup](#BKMK_TransactionCurrency_msdyn_quotebookingsetup)
- [user_msdyn_quotebookingsetup](#BKMK_user_msdyn_quotebookingsetup)

### <a name="BKMK_business_unit_msdyn_quotebookingsetup"></a> business_unit_msdyn_quotebookingsetup

One-To-Many Relationship: [businessunit business_unit_msdyn_quotebookingsetup](businessunit.md#BKMK_business_unit_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingsetup_createdby"></a> lk_msdyn_quotebookingsetup_createdby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingsetup_createdby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingsetup_createdonbehalfby"></a> lk_msdyn_quotebookingsetup_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingsetup_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingsetup_modifiedby"></a> lk_msdyn_quotebookingsetup_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingsetup_modifiedby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_quotebookingsetup_modifiedonbehalfby"></a> lk_msdyn_quotebookingsetup_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_quotebookingsetup_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_quotebookingsetup_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource"></a> msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource

One-To-Many Relationship: [bookableresource msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_quotebookingsetup_PreferredResource)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresource`|
|ReferencedAttribute|`bookableresourceid`|
|ReferencingAttribute|`msdyn_preferredresource`|
|ReferencingEntityNavigationPropertyName|`msdyn_preferredresource`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority"></a> msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority

One-To-Many Relationship: [msdyn_priority msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority](msdyn_priority.md#BKMK_msdyn_msdyn_priority_msdyn_quotebookingsetup_Priority)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_priority`|
|ReferencedAttribute|`msdyn_priorityid`|
|ReferencingAttribute|`msdyn_priority`|
|ReferencingEntityNavigationPropertyName|`msdyn_priority`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType"></a> msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType

One-To-Many Relationship: [msdyn_workordertype msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType](msdyn_workordertype.md#BKMK_msdyn_msdyn_workordertype_msdyn_quotebookingsetup_WorkOrderType)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workordertype`|
|ReferencedAttribute|`msdyn_workordertypeid`|
|ReferencingAttribute|`msdyn_workordertype`|
|ReferencingEntityNavigationPropertyName|`msdyn_workordertype`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_quote_msdyn_quotebookingsetup_Quote"></a> msdyn_quote_msdyn_quotebookingsetup_Quote

One-To-Many Relationship: [quote msdyn_quote_msdyn_quotebookingsetup_Quote](quote.md#BKMK_msdyn_quote_msdyn_quotebookingsetup_Quote)

|Property|Value|
|---|---|
|ReferencedEntity|`quote`|
|ReferencedAttribute|`quoteid`|
|ReferencingAttribute|`msdyn_quote`|
|ReferencingEntityNavigationPropertyName|`msdyn_quote`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_quotedetail_msdyn_quotebookingsetup"></a> msdyn_quotedetail_msdyn_quotebookingsetup

One-To-Many Relationship: [quotedetail msdyn_quotedetail_msdyn_quotebookingsetup](quotedetail.md#BKMK_msdyn_quotedetail_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencedEntity|`quotedetail`|
|ReferencedAttribute|`quotedetailid`|
|ReferencingAttribute|`msdyn_quotedetail_msdyn_quotebookingset`|
|ReferencingEntityNavigationPropertyName|`msdyn_quotedetail_msdyn_quotebookingset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_quotebookingsetup"></a> owner_msdyn_quotebookingsetup

One-To-Many Relationship: [owner owner_msdyn_quotebookingsetup](owner.md#BKMK_owner_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_processstage_msdyn_quotebookingsetup"></a> processstage_msdyn_quotebookingsetup

One-To-Many Relationship: [processstage processstage_msdyn_quotebookingsetup](processstage.md#BKMK_processstage_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencedEntity|`processstage`|
|ReferencedAttribute|`processstageid`|
|ReferencingAttribute|`stageid`|
|ReferencingEntityNavigationPropertyName|`stageid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_quotebookingsetup"></a> team_msdyn_quotebookingsetup

One-To-Many Relationship: [team team_msdyn_quotebookingsetup](team.md#BKMK_team_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msdyn_quotebookingsetup"></a> TransactionCurrency_msdyn_quotebookingsetup

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_quotebookingsetup](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_quotebookingsetup)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_quotebookingsetup"></a> user_msdyn_quotebookingsetup

One-To-Many Relationship: [systemuser user_msdyn_quotebookingsetup](systemuser.md#BKMK_user_msdyn_quotebookingsetup)

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

- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup)
- [msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup](#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup)
- [msdyn_quotebookingsetup_AsyncOperations](#BKMK_msdyn_quotebookingsetup_AsyncOperations)
- [msdyn_quotebookingsetup_BulkDeleteFailures](#BKMK_msdyn_quotebookingsetup_BulkDeleteFailures)
- [msdyn_quotebookingsetup_DuplicateBaseRecord](#BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord)
- [msdyn_quotebookingsetup_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord)
- [msdyn_quotebookingsetup_MailboxTrackingFolders](#BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders)
- [msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingsetup_ProcessSession](#BKMK_msdyn_quotebookingsetup_ProcessSession)
- [msdyn_quotebookingsetup_SyncErrors](#BKMK_msdyn_quotebookingsetup_SyncErrors)

### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup

Many-To-One Relationship: [msdyn_quotebookingincident msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup](msdyn_quotebookingincident.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingincident`|
|ReferencingAttribute|`msdyn_quotebookingsetup`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_quotebookingsetup_msdyn_quotebookingincident_QuoteBookingSetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup

Many-To-One Relationship: [msdyn_quotebookingproduct msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup](msdyn_quotebookingproduct.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingproduct`|
|ReferencingAttribute|`msdyn_quotebookingsetup`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_quotebookingsetup_msdyn_quotebookingproduct_QuoteBookingSetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup

Many-To-One Relationship: [msdyn_quotebookingservice msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup](msdyn_quotebookingservice.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservice`|
|ReferencingAttribute|`msdyn_quotebookingsetup`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservice_QuoteBookingSetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup"></a> msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup

Many-To-One Relationship: [msdyn_quotebookingservicetask msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup](msdyn_quotebookingservicetask.md#BKMK_msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_quotebookingservicetask`|
|ReferencingAttribute|`msdyn_quotebookingsetup`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_quotebookingsetup_msdyn_quotebookingservicetask_QuoteBookingSetup`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingsetup_AsyncOperations"></a> msdyn_quotebookingsetup_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_quotebookingsetup_AsyncOperations](asyncoperation.md#BKMK_msdyn_quotebookingsetup_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingsetup_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingsetup_BulkDeleteFailures"></a> msdyn_quotebookingsetup_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_quotebookingsetup_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_quotebookingsetup_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingsetup_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord"></a> msdyn_quotebookingsetup_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_quotebookingsetup_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingsetup_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord"></a> msdyn_quotebookingsetup_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_quotebookingsetup_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingsetup_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders"></a> msdyn_quotebookingsetup_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_quotebookingsetup_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingsetup_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingsetup_ProcessSession"></a> msdyn_quotebookingsetup_ProcessSession

Many-To-One Relationship: [processsession msdyn_quotebookingsetup_ProcessSession](processsession.md#BKMK_msdyn_quotebookingsetup_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingsetup_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_quotebookingsetup_SyncErrors"></a> msdyn_quotebookingsetup_SyncErrors

Many-To-One Relationship: [syncerror msdyn_quotebookingsetup_SyncErrors](syncerror.md#BKMK_msdyn_quotebookingsetup_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_quotebookingsetup_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

