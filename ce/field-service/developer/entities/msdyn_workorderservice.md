---
title: "Work Order Service (msdyn_workorderservice) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Work Order Service (msdyn_workorderservice) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Work Order Service (msdyn_workorderservice) table/entity reference (Microsoft Dynamics 365 Field Service)

Record all services proposed and performed for work order

## Messages

The following table lists the messages for the Work Order Service (msdyn_workorderservice) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_workorderservices(*msdyn_workorderserviceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_workorderservices<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_workorderservices(*msdyn_workorderserviceid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_workorderservices(*msdyn_workorderserviceid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_workorderservices<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_workorderservices(*msdyn_workorderserviceid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_workorderservices(*msdyn_workorderserviceid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_workorderservices(*msdyn_workorderserviceid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Work Order Service (msdyn_workorderservice) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Work Order Service (msdyn_workorderservice) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Work Order Service** |
| **DisplayCollectionName** | **Work Order Services** |
| **SchemaName** | `msdyn_workorderservice` |
| **CollectionSchemaName** | `msdyn_workorderservices` |
| **EntitySetName** | `msdyn_workorderservices`|
| **LogicalName** | `msdyn_workorderservice` |
| **LogicalCollectionName** | `msdyn_workorderservices` |
| **PrimaryIdAttribute** | `msdyn_workorderserviceid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdditionalCost](#BKMK_msdyn_AdditionalCost)
- [msdyn_AgreementBookingService](#BKMK_msdyn_AgreementBookingService)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_CalculatedUnitAmount](#BKMK_msdyn_CalculatedUnitAmount)
- [msdyn_CommissionCosts](#BKMK_msdyn_CommissionCosts)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_DisableEntitlement](#BKMK_msdyn_DisableEntitlement)
- [msdyn_DiscountAmount](#BKMK_msdyn_DiscountAmount)
- [msdyn_DiscountPercent](#BKMK_msdyn_DiscountPercent)
- [msdyn_Duration](#BKMK_msdyn_Duration)
- [msdyn_DurationToBill](#BKMK_msdyn_DurationToBill)
- [msdyn_Entitlement](#BKMK_msdyn_Entitlement)
- [msdyn_EstimateCalculatedUnitAmount](#BKMK_msdyn_EstimateCalculatedUnitAmount)
- [msdyn_EstimateDiscountAmount](#BKMK_msdyn_EstimateDiscountAmount)
- [msdyn_EstimateDiscountPercent](#BKMK_msdyn_EstimateDiscountPercent)
- [msdyn_EstimateDuration](#BKMK_msdyn_EstimateDuration)
- [msdyn_EstimateSubtotal](#BKMK_msdyn_EstimateSubtotal)
- [msdyn_EstimateTotalAmount](#BKMK_msdyn_EstimateTotalAmount)
- [msdyn_EstimateTotalCost](#BKMK_msdyn_EstimateTotalCost)
- [msdyn_EstimateUnitAmount](#BKMK_msdyn_EstimateUnitAmount)
- [msdyn_EstimateUnitCost](#BKMK_msdyn_EstimateUnitCost)
- [msdyn_InternalDescription](#BKMK_msdyn_InternalDescription)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_LineStatus](#BKMK_msdyn_LineStatus)
- [msdyn_MinimumChargeAmount](#BKMK_msdyn_MinimumChargeAmount)
- [msdyn_MinimumChargeDuration](#BKMK_msdyn_MinimumChargeDuration)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_Service](#BKMK_msdyn_Service)
- [msdyn_Subtotal](#BKMK_msdyn_Subtotal)
- [msdyn_Taxable](#BKMK_msdyn_Taxable)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
- [msdyn_TotalCost](#BKMK_msdyn_TotalCost)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitAmount](#BKMK_msdyn_UnitAmount)
- [msdyn_UnitCost](#BKMK_msdyn_UnitCost)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_WorkOrderIncident](#BKMK_msdyn_WorkOrderIncident)
- [msdyn_workorderserviceId](#BKMK_msdyn_workorderserviceId)
- [OverriddenCreatedOn](#BKMK_OverriddenCreatedOn)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [statecode](#BKMK_statecode)
- [statuscode](#BKMK_statuscode)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TransactionCurrencyId](#BKMK_TransactionCurrencyId)
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

### <a name="BKMK_msdyn_AdditionalCost"></a> msdyn_AdditionalCost

|Property|Value|
|---|---|
|Description|**Enter any additional costs associated with this service. The values are manually entered. Note: additional cost is not unit dependent.**|
|DisplayName|**Additional Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_additionalcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_AgreementBookingService"></a> msdyn_AgreementBookingService

|Property|Value|
|---|---|
|Description|**Agreement Booking Service linked to this Work Order Service**|
|DisplayName|**Agreement Booking Service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementbookingservice`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreementbookingservice|

### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

|Property|Value|
|---|---|
|Description|**Shows the resource booking detail where this product was added.**|
|DisplayName|**Booking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_booking`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresourcebooking|

### <a name="BKMK_msdyn_CalculatedUnitAmount"></a> msdyn_CalculatedUnitAmount

|Property|Value|
|---|---|
|Description|**Shows the sale amount per unit calculated by the system considering the minimum charge, if applicable.**|
|DisplayName|**Calculated Unit Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_calculatedunitamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_CommissionCosts"></a> msdyn_CommissionCosts

|Property|Value|
|---|---|
|Description|**Enter the commission costs associated with this service. The value is manually specified and isn't automatically calculated.**|
|DisplayName|**Commission Costs**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_commissioncosts`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

|Property|Value|
|---|---|
|Description|**Unique identifier for Customer Asset associated with Work Order Service.**|
|DisplayName|**Customer Asset**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_customerasset`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_customerasset|

### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|---|---|
|Description|**Enter the description of the service as presented to the customer. The value defaults to the description defined on the service.**|
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

### <a name="BKMK_msdyn_DisableEntitlement"></a> msdyn_DisableEntitlement

|Property|Value|
|---|---|
|Description|**Choose whether to disable entitlement selection for this work order service.**|
|DisplayName|**Disable Entitlement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_disableentitlement`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_workorderservice_msdyn_disableentitlement`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DiscountAmount"></a> msdyn_DiscountAmount

|Property|Value|
|---|---|
|Description|**Specify any discount amount on this service. Note: If you enter a discount amount you cannot enter a discount %**|
|DisplayName|**Discount Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_discountamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_DiscountPercent"></a> msdyn_DiscountPercent

|Property|Value|
|---|---|
|Description|**Specify any discount % on this service. Note: If you enter a discount % it will overwrite the discount $**|
|DisplayName|**Discount %**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_discountpercent`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

|Property|Value|
|---|---|
|Description|**Shows the actual duration of service.**|
|DisplayName|**Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_duration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_DurationToBill"></a> msdyn_DurationToBill

|Property|Value|
|---|---|
|Description|**Enter the quantity you wish to bill the customer for. By default, this will default to the same value as "Quantity."**|
|DisplayName|**Duration To Bill**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_durationtobill`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_Entitlement"></a> msdyn_Entitlement

|Property|Value|
|---|---|
|Description|**Entitlement to apply to the Work Order Service.**|
|DisplayName|**Entitlement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitlement`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|entitlement|

### <a name="BKMK_msdyn_EstimateCalculatedUnitAmount"></a> msdyn_EstimateCalculatedUnitAmount

|Property|Value|
|---|---|
|Description|**Shows the estimated sale amount per unit calculated by the system considering the initial charge (if applicable).**|
|DisplayName|**Estimate Calculated Unit Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatecalculatedunitamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_EstimateDiscountAmount"></a> msdyn_EstimateDiscountAmount

|Property|Value|
|---|---|
|Description|**Enter a discount amount on the subtotal amount. Note: If you enter a discount amount you cannot enter a discount %**|
|DisplayName|**Estimate Discount Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatediscountamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_EstimateDiscountPercent"></a> msdyn_EstimateDiscountPercent

|Property|Value|
|---|---|
|Description|**Enter a discount % on the subtotal amount. Note: If you enter a discount % it will overwrite the discount $**|
|DisplayName|**Estimate Discount %**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatediscountpercent`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_EstimateDuration"></a> msdyn_EstimateDuration

|Property|Value|
|---|---|
|Description|**Enter the estimated duration of this service.**|
|DisplayName|**Estimate Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimateduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_EstimateSubtotal"></a> msdyn_EstimateSubtotal

|Property|Value|
|---|---|
|Description|**Shows the total amount for this service, excluding discounts.**|
|DisplayName|**Estimate Subtotal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatesubtotal`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_EstimateTotalAmount"></a> msdyn_EstimateTotalAmount

|Property|Value|
|---|---|
|Description|**Shows the estimated total amount of this service, including discounts.**|
|DisplayName|**Estimate Total Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatetotalamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_EstimateTotalCost"></a> msdyn_EstimateTotalCost

|Property|Value|
|---|---|
|Description|**Shows the estimated total cost of this service.**|
|DisplayName|**Estimate Total Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatetotalcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_EstimateUnitAmount"></a> msdyn_EstimateUnitAmount

|Property|Value|
|---|---|
|Description|**Shows the estimated sale amount per unit.**|
|DisplayName|**Estimate Unit Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimateunitamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_EstimateUnitCost"></a> msdyn_EstimateUnitCost

|Property|Value|
|---|---|
|Description|**Shows the estimated cost amount per unit.**|
|DisplayName|**Estimate Unit Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimateunitcost`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_InternalDescription"></a> msdyn_InternalDescription

|Property|Value|
|---|---|
|Description|**Enter any internal notes you want to track on this service.**|
|DisplayName|**Internal Description**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_internaldescription`|
|RequiredLevel|None|
|Type|Memo|
|Format|Text|
|FormatName|Text|
|ImeMode|Auto|
|IsLocalizable|False|
|MaxLength|2000|

### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|---|---|
|Description||
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

### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

|Property|Value|
|---|---|
|Description||
|DisplayName|**Line Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_lineorder`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|-2147483648|

### <a name="BKMK_msdyn_LineStatus"></a> msdyn_LineStatus

|Property|Value|
|---|---|
|Description|**Enter the current status of the line, estimate or used.**|
|DisplayName|**Line Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_linestatus`|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|
|DefaultFormValue|690970000|
|GlobalChoiceName|`msdyn_productservicestatus`|

#### msdyn_LineStatus Choices/Options

|Value|Label|
|---|---|
|690970000|**Estimated**|
|690970001|**Used**|

### <a name="BKMK_msdyn_MinimumChargeAmount"></a> msdyn_MinimumChargeAmount

|Property|Value|
|---|---|
|Description|**Enter the amount charged as a minimum charge.**|
|DisplayName|**Minimum Charge Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_minimumchargeamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_MinimumChargeDuration"></a> msdyn_MinimumChargeDuration

|Property|Value|
|---|---|
|Description|**Enter the duration of up to how long the minimum charge applies.**|
|DisplayName|**Minimum Charge Duration**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_minimumchargeduration`|
|RequiredLevel|None|
|Type|Integer|
|MaxValue|2147483647|
|MinValue|0|

### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|---|---|
|Description|**Enter the name of the custom entity.**|
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
|MaxLength|200|

### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|---|---|
|Description|**Price List that determines the pricing for this service**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelist`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_Service"></a> msdyn_Service

|Property|Value|
|---|---|
|Description|**Service proposed or used for this work order**|
|DisplayName|**Service**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_service`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_msdyn_Subtotal"></a> msdyn_Subtotal

|Property|Value|
|---|---|
|Description|**Enter the total amount excluding discounts.**|
|DisplayName|**Subtotal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_subtotal`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

|Property|Value|
|---|---|
|Description|**Specify if service is taxable. If you do not wish to charge tax set this field to No.**|
|DisplayName|**Taxable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taxable`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_workorderservice_msdyn_taxable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

|Property|Value|
|---|---|
|Description||
|DisplayName|**Total Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalamount`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_TotalCost"></a> msdyn_TotalCost

|Property|Value|
|---|---|
|Description|**Shows the total cost of this service. This is calculated by (Unit Cost * Units) + Additional Cost + Commission Costs.**|
|DisplayName|**Total Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalcost`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

|Property|Value|
|---|---|
|Description|**The unit that determines the final quantity for this service**|
|DisplayName|**Unit**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unit`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|uom|

### <a name="BKMK_msdyn_UnitAmount"></a> msdyn_UnitAmount

|Property|Value|
|---|---|
|Description|**Enter the amount you want to charge the customer per unit. By default, this is calculated based on the selected price list. The amount can be changed.**|
|DisplayName|**Unit Amount**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unitamount`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_UnitCost"></a> msdyn_UnitCost

|Property|Value|
|---|---|
|Description|**Shows the actual cost per unit.**|
|DisplayName|**Unit Cost**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unitcost`|
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Auto|
|IsBaseCurrency|False|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|---|---|
|Description|**The work order this service relates to**|
|DisplayName|**Work Order**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorder`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|msdyn_workorder|

### <a name="BKMK_msdyn_WorkOrderIncident"></a> msdyn_WorkOrderIncident

|Property|Value|
|---|---|
|Description|**The Incident related to this product**|
|DisplayName|**Work Order Incident**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderincident`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_workorderincident|

### <a name="BKMK_msdyn_workorderserviceId"></a> msdyn_workorderserviceId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Work Order Service**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderserviceid`|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|

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
|Description|**Status of the Work Order Service**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workorderservice_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Work Order Service**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workorderservice_statuscode`|

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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [msdyn_additionalcost_Base](#BKMK_msdyn_additionalcost_Base)
- [msdyn_calculatedunitamount_Base](#BKMK_msdyn_calculatedunitamount_Base)
- [msdyn_commissioncosts_Base](#BKMK_msdyn_commissioncosts_Base)
- [msdyn_discountamount_Base](#BKMK_msdyn_discountamount_Base)
- [msdyn_estimatecalculatedunitamount_Base](#BKMK_msdyn_estimatecalculatedunitamount_Base)
- [msdyn_estimatediscountamount_Base](#BKMK_msdyn_estimatediscountamount_Base)
- [msdyn_estimatesubtotal_Base](#BKMK_msdyn_estimatesubtotal_Base)
- [msdyn_estimatetotalamount_Base](#BKMK_msdyn_estimatetotalamount_Base)
- [msdyn_estimatetotalcost_Base](#BKMK_msdyn_estimatetotalcost_Base)
- [msdyn_estimateunitamount_Base](#BKMK_msdyn_estimateunitamount_Base)
- [msdyn_estimateunitcost_Base](#BKMK_msdyn_estimateunitcost_Base)
- [msdyn_minimumchargeamount_Base](#BKMK_msdyn_minimumchargeamount_Base)
- [msdyn_subtotal_Base](#BKMK_msdyn_subtotal_Base)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [msdyn_totalcost_Base](#BKMK_msdyn_totalcost_Base)
- [msdyn_unitamount_Base](#BKMK_msdyn_unitamount_Base)
- [msdyn_unitcost_Base](#BKMK_msdyn_unitcost_Base)
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
|Description|**Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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

### <a name="BKMK_ExchangeRate"></a> ExchangeRate

|Property|Value|
|---|---|
|Description|**Shows the exchange rate for the currency associated with the entity with respect to the base currency.**|
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
|Description|**Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.**|
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

### <a name="BKMK_msdyn_additionalcost_Base"></a> msdyn_additionalcost_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the additional cost in the base currency.**|
|DisplayName|**Additional Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_additionalcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_calculatedunitamount_Base"></a> msdyn_calculatedunitamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the calculated unit amount in the base currency.**|
|DisplayName|**Calculated Unit Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_calculatedunitamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_commissioncosts_Base"></a> msdyn_commissioncosts_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the commission costs in the base currency.**|
|DisplayName|**Commission Costs (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_commissioncosts_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_discountamount_Base"></a> msdyn_discountamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the discount Amount in the base currency.**|
|DisplayName|**Discount Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_discountamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_estimatecalculatedunitamount_Base"></a> msdyn_estimatecalculatedunitamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the estimate calculated unit amount in the base currency.**|
|DisplayName|**Estimate Calculated Unit Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatecalculatedunitamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_estimatediscountamount_Base"></a> msdyn_estimatediscountamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the estimate discount amount in the base currency.**|
|DisplayName|**Estimate Discount Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatediscountamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_estimatesubtotal_Base"></a> msdyn_estimatesubtotal_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the estimate subtotal in the base currency.**|
|DisplayName|**Estimate Subtotal (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatesubtotal_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_estimatetotalamount_Base"></a> msdyn_estimatetotalamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the estimate total amount in the base currency.**|
|DisplayName|**Estimate Total Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatetotalamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_estimatetotalcost_Base"></a> msdyn_estimatetotalcost_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the estimate total cost in the base currency.**|
|DisplayName|**Estimate Total Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatetotalcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_estimateunitamount_Base"></a> msdyn_estimateunitamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the estimate unit amount in the base currency.**|
|DisplayName|**Estimate Unit Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimateunitamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_estimateunitcost_Base"></a> msdyn_estimateunitcost_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the estimate unit cost in the base currency.**|
|DisplayName|**Estimate Unit Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimateunitcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_minimumchargeamount_Base"></a> msdyn_minimumchargeamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the minimum charge amount in the base currency.**|
|DisplayName|**Minimum Charge Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_minimumchargeamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_subtotal_Base"></a> msdyn_subtotal_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the subtotal in the base currency.**|
|DisplayName|**Subtotal (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_subtotal_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_totalamount_Base"></a> msdyn_totalamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the total amount in the base currency.**|
|DisplayName|**Total Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_totalcost_Base"></a> msdyn_totalcost_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the total cost in the base currency.**|
|DisplayName|**Total Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_totalcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_unitamount_Base"></a> msdyn_unitamount_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the unit amount in the base currency.**|
|DisplayName|**Unit Amount (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unitamount_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

### <a name="BKMK_msdyn_unitcost_Base"></a> msdyn_unitcost_Base

|Property|Value|
|---|---|
|Description|**Shows the value of the unit cost in the base currency.**|
|DisplayName|**Unit Cost (Base)**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_unitcost_base`|
|RequiredLevel|None|
|Type|Money|
|ImeMode|Disabled|
|IsBaseCurrency|True|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1 (Organization.PricingDecimalPrecision)|

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

- [business_unit_msdyn_workorderservice](#BKMK_business_unit_msdyn_workorderservice)
- [lk_msdyn_workorderservice_createdby](#BKMK_lk_msdyn_workorderservice_createdby)
- [lk_msdyn_workorderservice_createdonbehalfby](#BKMK_lk_msdyn_workorderservice_createdonbehalfby)
- [lk_msdyn_workorderservice_modifiedby](#BKMK_lk_msdyn_workorderservice_modifiedby)
- [lk_msdyn_workorderservice_modifiedonbehalfby](#BKMK_lk_msdyn_workorderservice_modifiedonbehalfby)
- [msdyn_bookableresourcebooking_msdyn_workorderservice_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking)
- [msdyn_entitlement_msdyn_workorderservice_entitlement](#BKMK_msdyn_entitlement_msdyn_workorderservice_entitlement)
- [msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService](#BKMK_msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService)
- [msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset)
- [msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder)
- [msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident)
- [msdyn_pricelevel_msdyn_workorderservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList)
- [msdyn_product_msdyn_workorderservice_Service](#BKMK_msdyn_product_msdyn_workorderservice_Service)
- [msdyn_uom_msdyn_workorderservice_Unit](#BKMK_msdyn_uom_msdyn_workorderservice_Unit)
- [owner_msdyn_workorderservice](#BKMK_owner_msdyn_workorderservice)
- [team_msdyn_workorderservice](#BKMK_team_msdyn_workorderservice)
- [TransactionCurrency_msdyn_workorderservice](#BKMK_TransactionCurrency_msdyn_workorderservice)
- [user_msdyn_workorderservice](#BKMK_user_msdyn_workorderservice)

### <a name="BKMK_business_unit_msdyn_workorderservice"></a> business_unit_msdyn_workorderservice

One-To-Many Relationship: [businessunit business_unit_msdyn_workorderservice](businessunit.md#BKMK_business_unit_msdyn_workorderservice)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderservice_createdby"></a> lk_msdyn_workorderservice_createdby

One-To-Many Relationship: [systemuser lk_msdyn_workorderservice_createdby](systemuser.md#BKMK_lk_msdyn_workorderservice_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderservice_createdonbehalfby"></a> lk_msdyn_workorderservice_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_workorderservice_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderservice_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderservice_modifiedby"></a> lk_msdyn_workorderservice_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_workorderservice_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderservice_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderservice_modifiedonbehalfby"></a> lk_msdyn_workorderservice_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_workorderservice_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderservice_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderservice_Booking

One-To-Many Relationship: [bookableresourcebooking msdyn_bookableresourcebooking_msdyn_workorderservice_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`msdyn_booking`|
|ReferencingEntityNavigationPropertyName|`msdyn_booking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entitlement_msdyn_workorderservice_entitlement"></a> msdyn_entitlement_msdyn_workorderservice_entitlement

One-To-Many Relationship: [entitlement msdyn_entitlement_msdyn_workorderservice_entitlement](entitlement.md#BKMK_msdyn_entitlement_msdyn_workorderservice_entitlement)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`msdyn_entitlement`|
|ReferencingEntityNavigationPropertyName|`msdyn_entitlement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService"></a> msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService

One-To-Many Relationship: [msdyn_agreementbookingservice msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingservice`|
|ReferencedAttribute|`msdyn_agreementbookingserviceid`|
|ReferencingAttribute|`msdyn_agreementbookingservice`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreementbookingservice`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident

One-To-Many Relationship: [msdyn_workorderincident msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident](msdyn_workorderincident.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`msdyn_workorderincident`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList"></a> msdyn_pricelevel_msdyn_workorderservice_PriceList

One-To-Many Relationship: [pricelevel msdyn_pricelevel_msdyn_workorderservice_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencingEntityNavigationPropertyName|`msdyn_pricelist`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_product_msdyn_workorderservice_Service"></a> msdyn_product_msdyn_workorderservice_Service

One-To-Many Relationship: [product msdyn_product_msdyn_workorderservice_Service](product.md#BKMK_msdyn_product_msdyn_workorderservice_Service)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_service`|
|ReferencingEntityNavigationPropertyName|`msdyn_service`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uom_msdyn_workorderservice_Unit"></a> msdyn_uom_msdyn_workorderservice_Unit

One-To-Many Relationship: [uom msdyn_uom_msdyn_workorderservice_Unit](uom.md#BKMK_msdyn_uom_msdyn_workorderservice_Unit)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencingEntityNavigationPropertyName|`msdyn_unit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_workorderservice"></a> owner_msdyn_workorderservice

One-To-Many Relationship: [owner owner_msdyn_workorderservice](owner.md#BKMK_owner_msdyn_workorderservice)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_workorderservice"></a> team_msdyn_workorderservice

One-To-Many Relationship: [team team_msdyn_workorderservice](team.md#BKMK_team_msdyn_workorderservice)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msdyn_workorderservice"></a> TransactionCurrency_msdyn_workorderservice

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_workorderservice](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_workorderservice)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_workorderservice"></a> user_msdyn_workorderservice

One-To-Many Relationship: [systemuser user_msdyn_workorderservice](systemuser.md#BKMK_user_msdyn_workorderservice)

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

- [msdyn_msdyn_workorderservice_invoicedetail](#BKMK_msdyn_msdyn_workorderservice_invoicedetail)
- [msdyn_workorderservice_ActivityPointers](#BKMK_msdyn_workorderservice_ActivityPointers)
- [msdyn_workorderservice_adx_inviteredemptions](#BKMK_msdyn_workorderservice_adx_inviteredemptions)
- [msdyn_workorderservice_adx_portalcomments](#BKMK_msdyn_workorderservice_adx_portalcomments)
- [msdyn_workorderservice_Annotations](#BKMK_msdyn_workorderservice_Annotations)
- [msdyn_workorderservice_Appointments](#BKMK_msdyn_workorderservice_Appointments)
- [msdyn_workorderservice_AsyncOperations](#BKMK_msdyn_workorderservice_AsyncOperations)
- [msdyn_workorderservice_BulkDeleteFailures](#BKMK_msdyn_workorderservice_BulkDeleteFailures)
- [msdyn_workorderservice_chats](#BKMK_msdyn_workorderservice_chats)
- [msdyn_workorderservice_connections1](#BKMK_msdyn_workorderservice_connections1)
- [msdyn_workorderservice_connections2](#BKMK_msdyn_workorderservice_connections2)
- [msdyn_workorderservice_DuplicateBaseRecord](#BKMK_msdyn_workorderservice_DuplicateBaseRecord)
- [msdyn_workorderservice_DuplicateMatchingRecord](#BKMK_msdyn_workorderservice_DuplicateMatchingRecord)
- [msdyn_workorderservice_Emails](#BKMK_msdyn_workorderservice_Emails)
- [msdyn_workorderservice_Faxes](#BKMK_msdyn_workorderservice_Faxes)
- [msdyn_workorderservice_Letters](#BKMK_msdyn_workorderservice_Letters)
- [msdyn_workorderservice_MailboxTrackingFolders](#BKMK_msdyn_workorderservice_MailboxTrackingFolders)
- [msdyn_workorderservice_msdyn_bookingalerts](#BKMK_msdyn_workorderservice_msdyn_bookingalerts)
- [msdyn_workorderservice_msdyn_copilottranscripts](#BKMK_msdyn_workorderservice_msdyn_copilottranscripts)
- [msdyn_workorderservice_msdyn_ocliveworkitems](#BKMK_msdyn_workorderservice_msdyn_ocliveworkitems)
- [msdyn_workorderservice_msdyn_ocsessions](#BKMK_msdyn_workorderservice_msdyn_ocsessions)
- [msdyn_workorderservice_msfp_alerts](#BKMK_msdyn_workorderservice_msfp_alerts)
- [msdyn_workorderservice_msfp_surveyinvites](#BKMK_msdyn_workorderservice_msfp_surveyinvites)
- [msdyn_workorderservice_msfp_surveyresponses](#BKMK_msdyn_workorderservice_msfp_surveyresponses)
- [msdyn_workorderservice_PhoneCalls](#BKMK_msdyn_workorderservice_PhoneCalls)
- [msdyn_workorderservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses)
- [msdyn_workorderservice_ProcessSession](#BKMK_msdyn_workorderservice_ProcessSession)
- [msdyn_workorderservice_QueueItems](#BKMK_msdyn_workorderservice_QueueItems)
- [msdyn_workorderservice_RecurringAppointmentMasters](#BKMK_msdyn_workorderservice_RecurringAppointmentMasters)
- [msdyn_workorderservice_ServiceAppointments](#BKMK_msdyn_workorderservice_ServiceAppointments)
- [msdyn_workorderservice_SharePointDocumentLocations](#BKMK_msdyn_workorderservice_SharePointDocumentLocations)
- [msdyn_workorderservice_SocialActivities](#BKMK_msdyn_workorderservice_SocialActivities)
- [msdyn_workorderservice_SyncErrors](#BKMK_msdyn_workorderservice_SyncErrors)
- [msdyn_workorderservice_Tasks](#BKMK_msdyn_workorderservice_Tasks)

### <a name="BKMK_msdyn_msdyn_workorderservice_invoicedetail"></a> msdyn_msdyn_workorderservice_invoicedetail

Many-To-One Relationship: [invoicedetail msdyn_msdyn_workorderservice_invoicedetail](invoicedetail.md#BKMK_msdyn_msdyn_workorderservice_invoicedetail)

|Property|Value|
|---|---|
|ReferencingEntity|`invoicedetail`|
|ReferencingAttribute|`msdyn_workorderserviceid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorderservice_invoicedetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_ActivityPointers"></a> msdyn_workorderservice_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_workorderservice_ActivityPointers](activitypointer.md#BKMK_msdyn_workorderservice_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_adx_inviteredemptions"></a> msdyn_workorderservice_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_workorderservice_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_workorderservice_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_adx_portalcomments"></a> msdyn_workorderservice_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_workorderservice_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_workorderservice_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_Annotations"></a> msdyn_workorderservice_Annotations

Many-To-One Relationship: [annotation msdyn_workorderservice_Annotations](annotation.md#BKMK_msdyn_workorderservice_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_Appointments"></a> msdyn_workorderservice_Appointments

Many-To-One Relationship: [appointment msdyn_workorderservice_Appointments](appointment.md#BKMK_msdyn_workorderservice_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_AsyncOperations"></a> msdyn_workorderservice_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_workorderservice_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderservice_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_BulkDeleteFailures"></a> msdyn_workorderservice_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_workorderservice_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderservice_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_chats"></a> msdyn_workorderservice_chats

Many-To-One Relationship: [chat msdyn_workorderservice_chats](chat.md#BKMK_msdyn_workorderservice_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_connections1"></a> msdyn_workorderservice_connections1

Many-To-One Relationship: [connection msdyn_workorderservice_connections1](connection.md#BKMK_msdyn_workorderservice_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_connections2"></a> msdyn_workorderservice_connections2

Many-To-One Relationship: [connection msdyn_workorderservice_connections2](connection.md#BKMK_msdyn_workorderservice_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_DuplicateBaseRecord"></a> msdyn_workorderservice_DuplicateBaseRecord

Many-To-One Relationship: [duplicaterecord msdyn_workorderservice_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorderservice_DuplicateBaseRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`baserecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_DuplicateBaseRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_DuplicateMatchingRecord"></a> msdyn_workorderservice_DuplicateMatchingRecord

Many-To-One Relationship: [duplicaterecord msdyn_workorderservice_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorderservice_DuplicateMatchingRecord)

|Property|Value|
|---|---|
|ReferencingEntity|`duplicaterecord`|
|ReferencingAttribute|`duplicaterecordid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_DuplicateMatchingRecord`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_Emails"></a> msdyn_workorderservice_Emails

Many-To-One Relationship: [email msdyn_workorderservice_Emails](email.md#BKMK_msdyn_workorderservice_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_Faxes"></a> msdyn_workorderservice_Faxes

Many-To-One Relationship: [fax msdyn_workorderservice_Faxes](fax.md#BKMK_msdyn_workorderservice_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_Letters"></a> msdyn_workorderservice_Letters

Many-To-One Relationship: [letter msdyn_workorderservice_Letters](letter.md#BKMK_msdyn_workorderservice_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_MailboxTrackingFolders"></a> msdyn_workorderservice_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_workorderservice_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderservice_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_msdyn_bookingalerts"></a> msdyn_workorderservice_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_workorderservice_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorderservice_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_msdyn_copilottranscripts"></a> msdyn_workorderservice_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_workorderservice_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_workorderservice_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_msdyn_ocliveworkitems"></a> msdyn_workorderservice_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_workorderservice_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_workorderservice_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_msdyn_ocsessions"></a> msdyn_workorderservice_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_workorderservice_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_workorderservice_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_msfp_alerts"></a> msdyn_workorderservice_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_workorderservice_msfp_alerts](msfp_alert.md#BKMK_msdyn_workorderservice_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_msfp_surveyinvites"></a> msdyn_workorderservice_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_workorderservice_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_workorderservice_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_msfp_surveyresponses"></a> msdyn_workorderservice_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_workorderservice_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_workorderservice_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_PhoneCalls"></a> msdyn_workorderservice_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_workorderservice_PhoneCalls](phonecall.md#BKMK_msdyn_workorderservice_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses"></a> msdyn_workorderservice_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_workorderservice_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_ProcessSession"></a> msdyn_workorderservice_ProcessSession

Many-To-One Relationship: [processsession msdyn_workorderservice_ProcessSession](processsession.md#BKMK_msdyn_workorderservice_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_QueueItems"></a> msdyn_workorderservice_QueueItems

Many-To-One Relationship: [queueitem msdyn_workorderservice_QueueItems](queueitem.md#BKMK_msdyn_workorderservice_QueueItems)

|Property|Value|
|---|---|
|ReferencingEntity|`queueitem`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_QueueItems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_RecurringAppointmentMasters"></a> msdyn_workorderservice_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_workorderservice_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorderservice_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_ServiceAppointments"></a> msdyn_workorderservice_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_workorderservice_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorderservice_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_SharePointDocumentLocations"></a> msdyn_workorderservice_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_workorderservice_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_workorderservice_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_SocialActivities"></a> msdyn_workorderservice_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_workorderservice_SocialActivities](socialactivity.md#BKMK_msdyn_workorderservice_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_SyncErrors"></a> msdyn_workorderservice_SyncErrors

Many-To-One Relationship: [syncerror msdyn_workorderservice_SyncErrors](syncerror.md#BKMK_msdyn_workorderservice_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderservice_Tasks"></a> msdyn_workorderservice_Tasks

Many-To-One Relationship: [task msdyn_workorderservice_Tasks](task.md#BKMK_msdyn_workorderservice_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderservice_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

