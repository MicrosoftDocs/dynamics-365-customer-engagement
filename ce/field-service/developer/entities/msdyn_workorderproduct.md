---
title: "Work Order Product (msdyn_workorderproduct) table/entity reference (Microsoft Dynamics 365 Field Service)"
description: "Includes schema information and supported messages for the Work Order Product (msdyn_workorderproduct) table/entity with Microsoft Dynamics 365 Field Service."
ms.date: 08/26/2024
ms.service: powerapps
ms.topic: reference
author: m-hartmann
ms.author: mhart
search.audienceType: 
  - developer
---

# Work Order Product (msdyn_workorderproduct) table/entity reference

In this entity you record all the products proposed and used for a work order

## Messages

The following table lists the messages for the Work Order Product (msdyn_workorderproduct) table.
Messages represent operations that can be performed on the table. They may also be events.

| Name <br />Is Event? |Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `Assign`<br />Event: True |`PATCH` /msdyn_workorderproducts(*msdyn_workorderproductid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `ownerid` property. |<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
| `Create`<br />Event: True |`POST` /msdyn_workorderproducts<br />See [Create](/powerapps/developer/data-platform/webapi/create-entity-web-api) |[Create records](/power-apps/developer/data-platform/org-service/entity-operations-create#basic-create)|
| `CreateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.CreateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.CreateMultipleRequest>|
| `Delete`<br />Event: True |`DELETE` /msdyn_workorderproducts(*msdyn_workorderproductid*)<br />See [Delete](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-delete) |[Delete records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-delete)|
| `DeleteMultiple`<br />Event: True | |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `GrantAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.GrantAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
| `IsValidStateTransition`<br />Event: False |<xref:Microsoft.Dynamics.CRM.IsValidStateTransition?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
| `ModifyAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.ModifyAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
| `Retrieve`<br />Event: True |`GET` /msdyn_workorderproducts(*msdyn_workorderproductid*)<br />See [Retrieve](/powerapps/developer/data-platform/webapi/retrieve-entity-using-web-api) |[Retrieve records](/power-apps/developer/data-platform/org-service/entity-operations-retrieve)|
| `RetrieveMultiple`<br />Event: True |`GET` /msdyn_workorderproducts<br />See [Query data](/power-apps/developer/data-platform/webapi/query-data-web-api) |[Query data](/power-apps/developer/data-platform/org-service/entity-operations-query-data)|
| `RetrievePrincipalAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrievePrincipalAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
| `RetrieveSharedPrincipalsAndAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
| `RevokeAccess`<br />Event: True |<xref:Microsoft.Dynamics.CRM.RevokeAccess?displayProperty=nameWithType /> |<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
| `SetState`<br />Event: True |`PATCH` /msdyn_workorderproducts(*msdyn_workorderproductid*)<br />[Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) the `statecode` and `statuscode` properties. |<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
| `Update`<br />Event: True |`PATCH` /msdyn_workorderproducts(*msdyn_workorderproductid*)<br />See [Update](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#basic-update) |[Update records](/power-apps/developer/data-platform/org-service/entity-operations-update-delete#basic-update)|
| `UpdateMultiple`<br />Event: True |<xref:Microsoft.Dynamics.CRM.UpdateMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpdateMultipleRequest>|
| `Upsert`<br />Event: False |`PATCH` /msdyn_workorderproducts(*msdyn_workorderproductid*)<br />See [Upsert a table row](/powerapps/developer/data-platform/webapi/update-delete-entities-using-web-api#upsert-a-table-row) |<xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest>|
| `UpsertMultiple`<br />Event: False |<xref:Microsoft.Dynamics.CRM.UpsertMultiple?displayProperty=nameWithType /> |<xref:Microsoft.Xrm.Sdk.Messages.UpsertMultipleRequest>|


## Events

The following table lists the events for the Work Order Product (msdyn_workorderproduct) table.
Events are messages that exist so that you can subscribe to them. Unless you added the event, you shouldn't invoke the message, only subscribe to it.

|Name|Web API Operation |SDK for .NET |
| ---- | ----- |----- |
| `BulkRetain`|<xref:Microsoft.Dynamics.CRM.BulkRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `PurgeRetainedContent`|<xref:Microsoft.Dynamics.CRM.PurgeRetainedContent?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `Retain`|<xref:Microsoft.Dynamics.CRM.Retain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `RollbackRetain`|<xref:Microsoft.Dynamics.CRM.RollbackRetain?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|
| `ValidateRetentionConfig`|<xref:Microsoft.Dynamics.CRM.ValidateRetentionConfig?displayProperty=nameWithType /> |[Learn to use messages with the SDK for .NET](/power-apps/developer/data-platform/org-service/use-messages)|

## Properties

The following table lists selected properties for the Work Order Product (msdyn_workorderproduct) table.

|Property|Value|
| --- | --- |
| **DisplayName** | **Work Order Product** |
| **DisplayCollectionName** | **Work Order Products** |
| **SchemaName** | `msdyn_workorderproduct` |
| **CollectionSchemaName** | `msdyn_workorderproducts` |
| **EntitySetName** | `msdyn_workorderproducts`|
| **LogicalName** | `msdyn_workorderproduct` |
| **LogicalCollectionName** | `msdyn_workorderproducts` |
| **PrimaryIdAttribute** | `msdyn_workorderproductid` |
| **PrimaryNameAttribute** |`msdyn_name` |
| **TableType** | `Standard` |
| **OwnershipType** | `UserOwned` |

## Writable columns/attributes

These columns/attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AdditionalCost](#BKMK_msdyn_AdditionalCost)
- [msdyn_AgreementBookingProduct](#BKMK_msdyn_AgreementBookingProduct)
- [msdyn_Allocated](#BKMK_msdyn_Allocated)
- [msdyn_Booking](#BKMK_msdyn_Booking)
- [msdyn_CommissionCosts](#BKMK_msdyn_CommissionCosts)
- [msdyn_CustomerAsset](#BKMK_msdyn_CustomerAsset)
- [msdyn_Description](#BKMK_msdyn_Description)
- [msdyn_DisableEntitlement](#BKMK_msdyn_DisableEntitlement)
- [msdyn_DiscountAmount](#BKMK_msdyn_DiscountAmount)
- [msdyn_DiscountPercent](#BKMK_msdyn_DiscountPercent)
- [msdyn_Entitlement](#BKMK_msdyn_Entitlement)
- [msdyn_EstimateDiscountAmount](#BKMK_msdyn_EstimateDiscountAmount)
- [msdyn_EstimateDiscountPercent](#BKMK_msdyn_EstimateDiscountPercent)
- [msdyn_EstimateQuantity](#BKMK_msdyn_EstimateQuantity)
- [msdyn_EstimateSubtotal](#BKMK_msdyn_EstimateSubtotal)
- [msdyn_EstimateTotalAmount](#BKMK_msdyn_EstimateTotalAmount)
- [msdyn_EstimateTotalCost](#BKMK_msdyn_EstimateTotalCost)
- [msdyn_EstimateUnitAmount](#BKMK_msdyn_EstimateUnitAmount)
- [msdyn_EstimateUnitCost](#BKMK_msdyn_EstimateUnitCost)
- [msdyn_InternalDescription](#BKMK_msdyn_InternalDescription)
- [msdyn_InternalFlags](#BKMK_msdyn_InternalFlags)
- [msdyn_LineOrder](#BKMK_msdyn_LineOrder)
- [msdyn_LineStatus](#BKMK_msdyn_LineStatus)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_PurchaseOrderReceiptProduct](#BKMK_msdyn_PurchaseOrderReceiptProduct)
- [msdyn_QtyToBill](#BKMK_msdyn_QtyToBill)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_Subtotal](#BKMK_msdyn_Subtotal)
- [msdyn_Taxable](#BKMK_msdyn_Taxable)
- [msdyn_TotalAmount](#BKMK_msdyn_TotalAmount)
- [msdyn_TotalCost](#BKMK_msdyn_TotalCost)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitAmount](#BKMK_msdyn_UnitAmount)
- [msdyn_UnitCost](#BKMK_msdyn_UnitCost)
- [msdyn_Warehouse](#BKMK_msdyn_Warehouse)
- [msdyn_WorkOrder](#BKMK_msdyn_WorkOrder)
- [msdyn_WorkOrderIncident](#BKMK_msdyn_WorkOrderIncident)
- [msdyn_workorderproductId](#BKMK_msdyn_workorderproductId)
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
|Description|**Enter any additional costs associated with this product. The values are manually entered. Note: additional cost is not unit dependent.**|
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

### <a name="BKMK_msdyn_AgreementBookingProduct"></a> msdyn_AgreementBookingProduct

|Property|Value|
|---|---|
|Description|**Agreement Booking Product linked to this Work Order Product**|
|DisplayName|**Agreement Booking Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_agreementbookingproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_agreementbookingproduct|

### <a name="BKMK_msdyn_Allocated"></a> msdyn_Allocated

|Property|Value|
|---|---|
|Description||
|DisplayName|**Allocated**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_allocated`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_workorderproduct_msdyn_allocated`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

|Property|Value|
|---|---|
|Description|**The booking where this product was added**|
|DisplayName|**Booking**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_booking`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|bookableresourcebooking|

### <a name="BKMK_msdyn_CommissionCosts"></a> msdyn_CommissionCosts

|Property|Value|
|---|---|
|Description|**Enter the commission costs associated with this product. The value is manually specified and isn't automatically calculated.**|
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
|Description|**Unique identifier for Customer Asset associated with Work Order Product.**|
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
|Description|**Enter the description of the product as presented to the customer. The value defaults to the description defined on the product.**|
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
|Description|**Choose whether to disable entitlement selection for this work order product.**|
|DisplayName|**Disable Entitlement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_disableentitlement`|
|RequiredLevel|None|
|Type|Boolean|
|GlobalChoiceName|`msdyn_msdyn_workorderproduct_msdyn_disableentitlement`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_DiscountAmount"></a> msdyn_DiscountAmount

|Property|Value|
|---|---|
|Description|**Specify any discount amount on this product. Note: If you enter a discount amount you cannot enter a discount %**|
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
|Description|**Specify any discount % on this product. Note: If you enter a discount % it will overwrite the discount $**|
|DisplayName|**Discount %**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_discountpercent`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|100|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_Entitlement"></a> msdyn_Entitlement

|Property|Value|
|---|---|
|Description|**Entitlement to apply to the Work Order Product.**|
|DisplayName|**Entitlement**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_entitlement`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|entitlement|

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
|MaxValue|100|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_EstimateQuantity"></a> msdyn_EstimateQuantity

|Property|Value|
|---|---|
|Description|**Enter the estimated required quantity of this product.**|
|DisplayName|**Estimate Quantity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_estimatequantity`|
|RequiredLevel|None|
|Type|Double|
|ImeMode|Auto|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_EstimateSubtotal"></a> msdyn_EstimateSubtotal

|Property|Value|
|---|---|
|Description|**Shows the total amount for this product, excluding discounts.**|
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
|Description|**Shows the estimated total amount of this product, including discounts.**|
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
|Description|**Shows the estimated total cost of this product.**|
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
|Description|**Enter any internal notes you want to track on this product.**|
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
|Description|**For internal use only.**|
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
|Description|**Price List that determines the pricing for this product**|
|DisplayName|**Price List**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_pricelist`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|pricelevel|

### <a name="BKMK_msdyn_Product"></a> msdyn_Product

|Property|Value|
|---|---|
|Description|**Product to use**|
|DisplayName|**Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_product`|
|RequiredLevel|ApplicationRequired|
|Type|Lookup|
|Targets|product|

### <a name="BKMK_msdyn_PurchaseOrderReceiptProduct"></a> msdyn_PurchaseOrderReceiptProduct

|Property|Value|
|---|---|
|Description|**Purchase Order Receipt Product linked to this Work Order Product**|
|DisplayName|**Purchase Order Receipt Product**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_purchaseorderreceiptproduct`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_purchaseorderreceiptproduct|

### <a name="BKMK_msdyn_QtyToBill"></a> msdyn_QtyToBill

|Property|Value|
|---|---|
|Description|**Enter the quantity you wish to bill the customer for. By default, this will default to the same value as "Quantity."**|
|DisplayName|**Quantity To Bill**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_qtytobill`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

|Property|Value|
|---|---|
|Description|**Shows the actual quantity of the product.**|
|DisplayName|**Quantity**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_quantity`|
|RequiredLevel|ApplicationRequired|
|Type|Double|
|ImeMode|Disabled|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|

### <a name="BKMK_msdyn_Subtotal"></a> msdyn_Subtotal

|Property|Value|
|---|---|
|Description|**Enter the total amount excluding discounts.**|
|DisplayName|**Subtotal**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_subtotal`|
|RequiredLevel|ApplicationRequired|
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
|Description|**Specify if product is taxable. If you do not wish to charge tax set this field to No.**|
|DisplayName|**Taxable**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_taxable`|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|
|GlobalChoiceName|`msdyn_workorderproduct_msdyn_taxable`|
|DefaultValue|False|
|True Label|Yes|
|False Label|No|

### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

|Property|Value|
|---|---|
|Description|**Enter the total amount charged to the customer.**|
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
|Description|**Shows the total cost of this product. This is calculated by (Unit Cost * Units) + Additional Cost + Commission Costs.**|
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
|Description|**The unit that determines the pricing and final quantity for this product**|
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
|RequiredLevel|ApplicationRequired|
|Type|Money|
|ImeMode|Auto|
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

### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

|Property|Value|
|---|---|
|Description|**Warehouse this product is being retrieved from**|
|DisplayName|**Warehouse**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`msdyn_warehouse`|
|RequiredLevel|None|
|Type|Lookup|
|Targets|msdyn_warehouse|

### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|---|---|
|Description|**Unique identifier for Work Order associated with Work Order Product.**|
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

### <a name="BKMK_msdyn_workorderproductId"></a> msdyn_workorderproductId

|Property|Value|
|---|---|
|Description|**Shows the entity instances.**|
|DisplayName|**Work Order Product**|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|`msdyn_workorderproductid`|
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
|Description|**Status of the Work Order Product**|
|DisplayName|**Status**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statecode`|
|RequiredLevel|SystemRequired|
|Type|State|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workorderproduct_statecode`|

#### statecode Choices/Options

|Value|Details|
|---|---|
|0|Label: **Active**<br />DefaultStatus: 1<br />InvariantName: `Active`|
|1|Label: **Inactive**<br />DefaultStatus: 2<br />InvariantName: `Inactive`|

### <a name="BKMK_statuscode"></a> statuscode

|Property|Value|
|---|---|
|Description|**Reason for the status of the Work Order Product**|
|DisplayName|**Status Reason**|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|`statuscode`|
|RequiredLevel|None|
|Type|Status|
|DefaultFormValue||
|GlobalChoiceName|`msdyn_workorderproduct_statuscode`|

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
- [msdyn_commissioncosts_Base](#BKMK_msdyn_commissioncosts_Base)
- [msdyn_discountamount_Base](#BKMK_msdyn_discountamount_Base)
- [msdyn_estimatediscountamount_Base](#BKMK_msdyn_estimatediscountamount_Base)
- [msdyn_estimatesubtotal_Base](#BKMK_msdyn_estimatesubtotal_Base)
- [msdyn_estimatetotalamount_Base](#BKMK_msdyn_estimatetotalamount_Base)
- [msdyn_estimatetotalcost_Base](#BKMK_msdyn_estimatetotalcost_Base)
- [msdyn_estimateunitamount_Base](#BKMK_msdyn_estimateunitamount_Base)
- [msdyn_estimateunitcost_Base](#BKMK_msdyn_estimateunitcost_Base)
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
|Description|**Shows the value of the discount amount in the base currency.**|
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

- [business_unit_msdyn_workorderproduct](#BKMK_business_unit_msdyn_workorderproduct)
- [lk_msdyn_workorderproduct_createdby](#BKMK_lk_msdyn_workorderproduct_createdby)
- [lk_msdyn_workorderproduct_createdonbehalfby](#BKMK_lk_msdyn_workorderproduct_createdonbehalfby)
- [lk_msdyn_workorderproduct_modifiedby](#BKMK_lk_msdyn_workorderproduct_modifiedby)
- [lk_msdyn_workorderproduct_modifiedonbehalfby](#BKMK_lk_msdyn_workorderproduct_modifiedonbehalfby)
- [msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking)
- [msdyn_entitlement_msdyn_workorderproduct_Entitlement](#BKMK_msdyn_entitlement_msdyn_workorderproduct_Entitlement)
- [msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct](#BKMK_msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct)
- [msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset)
- [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct](#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct)
- [msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse](#BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse)
- [msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder)
- [msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident)
- [msdyn_pricelevel_msdyn_workorderproduct_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList)
- [msdyn_product_msdyn_workorderproduct_Product](#BKMK_msdyn_product_msdyn_workorderproduct_Product)
- [msdyn_uom_msdyn_workorderproduct_Unit](#BKMK_msdyn_uom_msdyn_workorderproduct_Unit)
- [owner_msdyn_workorderproduct](#BKMK_owner_msdyn_workorderproduct)
- [team_msdyn_workorderproduct](#BKMK_team_msdyn_workorderproduct)
- [TransactionCurrency_msdyn_workorderproduct](#BKMK_TransactionCurrency_msdyn_workorderproduct)
- [user_msdyn_workorderproduct](#BKMK_user_msdyn_workorderproduct)

### <a name="BKMK_business_unit_msdyn_workorderproduct"></a> business_unit_msdyn_workorderproduct

One-To-Many Relationship: [businessunit business_unit_msdyn_workorderproduct](businessunit.md#BKMK_business_unit_msdyn_workorderproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`businessunit`|
|ReferencedAttribute|`businessunitid`|
|ReferencingAttribute|`owningbusinessunit`|
|ReferencingEntityNavigationPropertyName|`owningbusinessunit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderproduct_createdby"></a> lk_msdyn_workorderproduct_createdby

One-To-Many Relationship: [systemuser lk_msdyn_workorderproduct_createdby](systemuser.md#BKMK_lk_msdyn_workorderproduct_createdby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdby`|
|ReferencingEntityNavigationPropertyName|`createdby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderproduct_createdonbehalfby"></a> lk_msdyn_workorderproduct_createdonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_workorderproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderproduct_createdonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`createdonbehalfby`|
|ReferencingEntityNavigationPropertyName|`createdonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderproduct_modifiedby"></a> lk_msdyn_workorderproduct_modifiedby

One-To-Many Relationship: [systemuser lk_msdyn_workorderproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderproduct_modifiedby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedby`|
|ReferencingEntityNavigationPropertyName|`modifiedby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_lk_msdyn_workorderproduct_modifiedonbehalfby"></a> lk_msdyn_workorderproduct_modifiedonbehalfby

One-To-Many Relationship: [systemuser lk_msdyn_workorderproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderproduct_modifiedonbehalfby)

|Property|Value|
|---|---|
|ReferencedEntity|`systemuser`|
|ReferencedAttribute|`systemuserid`|
|ReferencingAttribute|`modifiedonbehalfby`|
|ReferencingEntityNavigationPropertyName|`modifiedonbehalfby`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking

One-To-Many Relationship: [bookableresourcebooking msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking)

|Property|Value|
|---|---|
|ReferencedEntity|`bookableresourcebooking`|
|ReferencedAttribute|`bookableresourcebookingid`|
|ReferencingAttribute|`msdyn_booking`|
|ReferencingEntityNavigationPropertyName|`msdyn_booking`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_entitlement_msdyn_workorderproduct_Entitlement"></a> msdyn_entitlement_msdyn_workorderproduct_Entitlement

One-To-Many Relationship: [entitlement msdyn_entitlement_msdyn_workorderproduct_Entitlement](entitlement.md#BKMK_msdyn_entitlement_msdyn_workorderproduct_Entitlement)

|Property|Value|
|---|---|
|ReferencedEntity|`entitlement`|
|ReferencedAttribute|`entitlementid`|
|ReferencingAttribute|`msdyn_entitlement`|
|ReferencingEntityNavigationPropertyName|`msdyn_Entitlement`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct"></a> msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct

One-To-Many Relationship: [msdyn_agreementbookingproduct msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_agreementbookingproduct`|
|ReferencedAttribute|`msdyn_agreementbookingproductid`|
|ReferencingAttribute|`msdyn_agreementbookingproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_agreementbookingproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset

One-To-Many Relationship: [msdyn_customerasset msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_customerasset`|
|ReferencedAttribute|`msdyn_customerassetid`|
|ReferencingAttribute|`msdyn_customerasset`|
|ReferencingEntityNavigationPropertyName|`msdyn_customerasset`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct"></a> msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct

One-To-Many Relationship: [msdyn_purchaseorderreceiptproduct msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_purchaseorderreceiptproduct`|
|ReferencedAttribute|`msdyn_purchaseorderreceiptproductid`|
|ReferencingAttribute|`msdyn_purchaseorderreceiptproduct`|
|ReferencingEntityNavigationPropertyName|`msdyn_purchaseorderreceiptproduct`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse

One-To-Many Relationship: [msdyn_warehouse msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_warehouse`|
|ReferencedAttribute|`msdyn_warehouseid`|
|ReferencingAttribute|`msdyn_warehouse`|
|ReferencingEntityNavigationPropertyName|`msdyn_warehouse`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder

One-To-Many Relationship: [msdyn_workorder msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorder`|
|ReferencedAttribute|`msdyn_workorderid`|
|ReferencingAttribute|`msdyn_workorder`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorder`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `Cascade`<br />Delete: `Cascade`<br />Merge: `NoCascade`<br />Reparent: `Cascade`<br />RollupView: `NoCascade`<br />Share: `Cascade`<br />Unshare: `Cascade`|

### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident

One-To-Many Relationship: [msdyn_workorderincident msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident](msdyn_workorderincident.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident)

|Property|Value|
|---|---|
|ReferencedEntity|`msdyn_workorderincident`|
|ReferencedAttribute|`msdyn_workorderincidentid`|
|ReferencingAttribute|`msdyn_workorderincident`|
|ReferencingEntityNavigationPropertyName|`msdyn_workorderincident`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList"></a> msdyn_pricelevel_msdyn_workorderproduct_PriceList

One-To-Many Relationship: [pricelevel msdyn_pricelevel_msdyn_workorderproduct_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList)

|Property|Value|
|---|---|
|ReferencedEntity|`pricelevel`|
|ReferencedAttribute|`pricelevelid`|
|ReferencingAttribute|`msdyn_pricelist`|
|ReferencingEntityNavigationPropertyName|`msdyn_pricelist`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_product_msdyn_workorderproduct_Product"></a> msdyn_product_msdyn_workorderproduct_Product

One-To-Many Relationship: [product msdyn_product_msdyn_workorderproduct_Product](product.md#BKMK_msdyn_product_msdyn_workorderproduct_Product)

|Property|Value|
|---|---|
|ReferencedEntity|`product`|
|ReferencedAttribute|`productid`|
|ReferencingAttribute|`msdyn_product`|
|ReferencingEntityNavigationPropertyName|`msdyn_product`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_msdyn_uom_msdyn_workorderproduct_Unit"></a> msdyn_uom_msdyn_workorderproduct_Unit

One-To-Many Relationship: [uom msdyn_uom_msdyn_workorderproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_workorderproduct_Unit)

|Property|Value|
|---|---|
|ReferencedEntity|`uom`|
|ReferencedAttribute|`uomid`|
|ReferencingAttribute|`msdyn_unit`|
|ReferencingEntityNavigationPropertyName|`msdyn_unit`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `RemoveLink`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_owner_msdyn_workorderproduct"></a> owner_msdyn_workorderproduct

One-To-Many Relationship: [owner owner_msdyn_workorderproduct](owner.md#BKMK_owner_msdyn_workorderproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`owner`|
|ReferencedAttribute|`ownerid`|
|ReferencingAttribute|`ownerid`|
|ReferencingEntityNavigationPropertyName|`ownerid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_team_msdyn_workorderproduct"></a> team_msdyn_workorderproduct

One-To-Many Relationship: [team team_msdyn_workorderproduct](team.md#BKMK_team_msdyn_workorderproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`team`|
|ReferencedAttribute|`teamid`|
|ReferencingAttribute|`owningteam`|
|ReferencingEntityNavigationPropertyName|`owningteam`|
|IsHierarchical||
|CascadeConfiguration|Archive: `NoCascade`<br />Assign: `NoCascade`<br />Delete: `NoCascade`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_TransactionCurrency_msdyn_workorderproduct"></a> TransactionCurrency_msdyn_workorderproduct

One-To-Many Relationship: [transactioncurrency TransactionCurrency_msdyn_workorderproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_workorderproduct)

|Property|Value|
|---|---|
|ReferencedEntity|`transactioncurrency`|
|ReferencedAttribute|`transactioncurrencyid`|
|ReferencingAttribute|`transactioncurrencyid`|
|ReferencingEntityNavigationPropertyName|`transactioncurrencyid`|
|IsHierarchical||
|CascadeConfiguration|Archive: `Restrict`<br />Assign: `NoCascade`<br />Delete: `Restrict`<br />Merge: `NoCascade`<br />Reparent: `NoCascade`<br />RollupView: `NoCascade`<br />Share: `NoCascade`<br />Unshare: `NoCascade`|

### <a name="BKMK_user_msdyn_workorderproduct"></a> user_msdyn_workorderproduct

One-To-Many Relationship: [systemuser user_msdyn_workorderproduct](systemuser.md#BKMK_user_msdyn_workorderproduct)

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

- [msdyn_msdyn_workorderproduct_invoicedetail](#BKMK_msdyn_msdyn_workorderproduct_invoicedetail)
- [msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct)
- [msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct)
- [msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct)
- [msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct)
- [msdyn_workorderproduct_ActivityPointers](#BKMK_msdyn_workorderproduct_ActivityPointers)
- [msdyn_workorderproduct_adx_inviteredemptions](#BKMK_msdyn_workorderproduct_adx_inviteredemptions)
- [msdyn_workorderproduct_adx_portalcomments](#BKMK_msdyn_workorderproduct_adx_portalcomments)
- [msdyn_workorderproduct_Annotations](#BKMK_msdyn_workorderproduct_Annotations)
- [msdyn_workorderproduct_Appointments](#BKMK_msdyn_workorderproduct_Appointments)
- [msdyn_workorderproduct_AsyncOperations](#BKMK_msdyn_workorderproduct_AsyncOperations)
- [msdyn_workorderproduct_BulkDeleteFailures](#BKMK_msdyn_workorderproduct_BulkDeleteFailures)
- [msdyn_workorderproduct_chats](#BKMK_msdyn_workorderproduct_chats)
- [msdyn_workorderproduct_connections1](#BKMK_msdyn_workorderproduct_connections1)
- [msdyn_workorderproduct_connections2](#BKMK_msdyn_workorderproduct_connections2)
- [msdyn_workorderproduct_Emails](#BKMK_msdyn_workorderproduct_Emails)
- [msdyn_workorderproduct_Faxes](#BKMK_msdyn_workorderproduct_Faxes)
- [msdyn_workorderproduct_Letters](#BKMK_msdyn_workorderproduct_Letters)
- [msdyn_workorderproduct_MailboxTrackingFolders](#BKMK_msdyn_workorderproduct_MailboxTrackingFolders)
- [msdyn_workorderproduct_msdyn_bookingalerts](#BKMK_msdyn_workorderproduct_msdyn_bookingalerts)
- [msdyn_workorderproduct_msdyn_copilottranscripts](#BKMK_msdyn_workorderproduct_msdyn_copilottranscripts)
- [msdyn_workorderproduct_msdyn_ocliveworkitems](#BKMK_msdyn_workorderproduct_msdyn_ocliveworkitems)
- [msdyn_workorderproduct_msdyn_ocsessions](#BKMK_msdyn_workorderproduct_msdyn_ocsessions)
- [msdyn_workorderproduct_msfp_alerts](#BKMK_msdyn_workorderproduct_msfp_alerts)
- [msdyn_workorderproduct_msfp_surveyinvites](#BKMK_msdyn_workorderproduct_msfp_surveyinvites)
- [msdyn_workorderproduct_msfp_surveyresponses](#BKMK_msdyn_workorderproduct_msfp_surveyresponses)
- [msdyn_workorderproduct_PhoneCalls](#BKMK_msdyn_workorderproduct_PhoneCalls)
- [msdyn_workorderproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses)
- [msdyn_workorderproduct_ProcessSession](#BKMK_msdyn_workorderproduct_ProcessSession)
- [msdyn_workorderproduct_RecurringAppointmentMasters](#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters)
- [msdyn_workorderproduct_ServiceAppointments](#BKMK_msdyn_workorderproduct_ServiceAppointments)
- [msdyn_workorderproduct_SharePointDocumentLocations](#BKMK_msdyn_workorderproduct_SharePointDocumentLocations)
- [msdyn_workorderproduct_SocialActivities](#BKMK_msdyn_workorderproduct_SocialActivities)
- [msdyn_workorderproduct_SyncErrors](#BKMK_msdyn_workorderproduct_SyncErrors)
- [msdyn_workorderproduct_Tasks](#BKMK_msdyn_workorderproduct_Tasks)

### <a name="BKMK_msdyn_msdyn_workorderproduct_invoicedetail"></a> msdyn_msdyn_workorderproduct_invoicedetail

Many-To-One Relationship: [invoicedetail msdyn_msdyn_workorderproduct_invoicedetail](invoicedetail.md#BKMK_msdyn_msdyn_workorderproduct_invoicedetail)

|Property|Value|
|---|---|
|ReferencingEntity|`invoicedetail`|
|ReferencingAttribute|`msdyn_workorderproductid`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorderproduct_invoicedetail`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Sales`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct

Many-To-One Relationship: [msdyn_customerasset msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](msdyn_customerasset.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_customerasset`|
|ReferencingAttribute|`msdyn_workorderproduct`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct

Many-To-One Relationship: [msdyn_inventoryjournal msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_inventoryjournal`|
|ReferencingAttribute|`msdyn_workorderproduct`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct"></a> msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct

Many-To-One Relationship: [msdyn_rmaproduct msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rmaproduct`|
|ReferencingAttribute|`msdyn_woproduct`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct

Many-To-One Relationship: [msdyn_rtvproduct msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_rtvproduct`|
|ReferencingAttribute|`msdyn_workorderproduct`|
|ReferencedEntityNavigationPropertyName|`msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 10000<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_ActivityPointers"></a> msdyn_workorderproduct_ActivityPointers

Many-To-One Relationship: [activitypointer msdyn_workorderproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_workorderproduct_ActivityPointers)

|Property|Value|
|---|---|
|ReferencingEntity|`activitypointer`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_ActivityPointers`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_adx_inviteredemptions"></a> msdyn_workorderproduct_adx_inviteredemptions

Many-To-One Relationship: [adx_inviteredemption msdyn_workorderproduct_adx_inviteredemptions](adx_inviteredemption.md#BKMK_msdyn_workorderproduct_adx_inviteredemptions)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_inviteredemption`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_adx_inviteredemptions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_adx_portalcomments"></a> msdyn_workorderproduct_adx_portalcomments

Many-To-One Relationship: [adx_portalcomment msdyn_workorderproduct_adx_portalcomments](adx_portalcomment.md#BKMK_msdyn_workorderproduct_adx_portalcomments)

|Property|Value|
|---|---|
|ReferencingEntity|`adx_portalcomment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_adx_portalcomments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_Annotations"></a> msdyn_workorderproduct_Annotations

Many-To-One Relationship: [annotation msdyn_workorderproduct_Annotations](annotation.md#BKMK_msdyn_workorderproduct_Annotations)

|Property|Value|
|---|---|
|ReferencingEntity|`annotation`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_Annotations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_Appointments"></a> msdyn_workorderproduct_Appointments

Many-To-One Relationship: [appointment msdyn_workorderproduct_Appointments](appointment.md#BKMK_msdyn_workorderproduct_Appointments)

|Property|Value|
|---|---|
|ReferencingEntity|`appointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_Appointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_AsyncOperations"></a> msdyn_workorderproduct_AsyncOperations

Many-To-One Relationship: [asyncoperation msdyn_workorderproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderproduct_AsyncOperations)

|Property|Value|
|---|---|
|ReferencingEntity|`asyncoperation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_AsyncOperations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_BulkDeleteFailures"></a> msdyn_workorderproduct_BulkDeleteFailures

Many-To-One Relationship: [bulkdeletefailure msdyn_workorderproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderproduct_BulkDeleteFailures)

|Property|Value|
|---|---|
|ReferencingEntity|`bulkdeletefailure`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_BulkDeleteFailures`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_chats"></a> msdyn_workorderproduct_chats

Many-To-One Relationship: [chat msdyn_workorderproduct_chats](chat.md#BKMK_msdyn_workorderproduct_chats)

|Property|Value|
|---|---|
|ReferencingEntity|`chat`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_chats`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_connections1"></a> msdyn_workorderproduct_connections1

Many-To-One Relationship: [connection msdyn_workorderproduct_connections1](connection.md#BKMK_msdyn_workorderproduct_connections1)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record1id`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_connections1`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `UseCollectionName`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: 100<br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_connections2"></a> msdyn_workorderproduct_connections2

Many-To-One Relationship: [connection msdyn_workorderproduct_connections2](connection.md#BKMK_msdyn_workorderproduct_connections2)

|Property|Value|
|---|---|
|ReferencingEntity|`connection`|
|ReferencingAttribute|`record2id`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_connections2`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_Emails"></a> msdyn_workorderproduct_Emails

Many-To-One Relationship: [email msdyn_workorderproduct_Emails](email.md#BKMK_msdyn_workorderproduct_Emails)

|Property|Value|
|---|---|
|ReferencingEntity|`email`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_Emails`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_Faxes"></a> msdyn_workorderproduct_Faxes

Many-To-One Relationship: [fax msdyn_workorderproduct_Faxes](fax.md#BKMK_msdyn_workorderproduct_Faxes)

|Property|Value|
|---|---|
|ReferencingEntity|`fax`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_Faxes`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_Letters"></a> msdyn_workorderproduct_Letters

Many-To-One Relationship: [letter msdyn_workorderproduct_Letters](letter.md#BKMK_msdyn_workorderproduct_Letters)

|Property|Value|
|---|---|
|ReferencingEntity|`letter`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_Letters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_MailboxTrackingFolders"></a> msdyn_workorderproduct_MailboxTrackingFolders

Many-To-One Relationship: [mailboxtrackingfolder msdyn_workorderproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderproduct_MailboxTrackingFolders)

|Property|Value|
|---|---|
|ReferencingEntity|`mailboxtrackingfolder`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_MailboxTrackingFolders`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_msdyn_bookingalerts"></a> msdyn_workorderproduct_msdyn_bookingalerts

Many-To-One Relationship: [msdyn_bookingalert msdyn_workorderproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorderproduct_msdyn_bookingalerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_bookingalert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_msdyn_bookingalerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_msdyn_copilottranscripts"></a> msdyn_workorderproduct_msdyn_copilottranscripts

Many-To-One Relationship: [msdyn_copilottranscript msdyn_workorderproduct_msdyn_copilottranscripts](msdyn_copilottranscript.md#BKMK_msdyn_workorderproduct_msdyn_copilottranscripts)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_copilottranscript`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_msdyn_copilottranscripts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_msdyn_ocliveworkitems"></a> msdyn_workorderproduct_msdyn_ocliveworkitems

Many-To-One Relationship: [msdyn_ocliveworkitem msdyn_workorderproduct_msdyn_ocliveworkitems](msdyn_ocliveworkitem.md#BKMK_msdyn_workorderproduct_msdyn_ocliveworkitems)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocliveworkitem`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_msdyn_ocliveworkitems`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_msdyn_ocsessions"></a> msdyn_workorderproduct_msdyn_ocsessions

Many-To-One Relationship: [msdyn_ocsession msdyn_workorderproduct_msdyn_ocsessions](msdyn_ocsession.md#BKMK_msdyn_workorderproduct_msdyn_ocsessions)

|Property|Value|
|---|---|
|ReferencingEntity|`msdyn_ocsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_msdyn_ocsessions`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_msfp_alerts"></a> msdyn_workorderproduct_msfp_alerts

Many-To-One Relationship: [msfp_alert msdyn_workorderproduct_msfp_alerts](msfp_alert.md#BKMK_msdyn_workorderproduct_msfp_alerts)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_alert`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_msfp_alerts`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_msfp_surveyinvites"></a> msdyn_workorderproduct_msfp_surveyinvites

Many-To-One Relationship: [msfp_surveyinvite msdyn_workorderproduct_msfp_surveyinvites](msfp_surveyinvite.md#BKMK_msdyn_workorderproduct_msfp_surveyinvites)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyinvite`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_msfp_surveyinvites`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_msfp_surveyresponses"></a> msdyn_workorderproduct_msfp_surveyresponses

Many-To-One Relationship: [msfp_surveyresponse msdyn_workorderproduct_msfp_surveyresponses](msfp_surveyresponse.md#BKMK_msdyn_workorderproduct_msfp_surveyresponses)

|Property|Value|
|---|---|
|ReferencingEntity|`msfp_surveyresponse`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_msfp_surveyresponses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_PhoneCalls"></a> msdyn_workorderproduct_PhoneCalls

Many-To-One Relationship: [phonecall msdyn_workorderproduct_PhoneCalls](phonecall.md#BKMK_msdyn_workorderproduct_PhoneCalls)

|Property|Value|
|---|---|
|ReferencingEntity|`phonecall`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_PhoneCalls`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses"></a> msdyn_workorderproduct_PrincipalObjectAttributeAccesses

Many-To-One Relationship: [principalobjectattributeaccess msdyn_workorderproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses)

|Property|Value|
|---|---|
|ReferencingEntity|`principalobjectattributeaccess`|
|ReferencingAttribute|`objectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_PrincipalObjectAttributeAccesses`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_ProcessSession"></a> msdyn_workorderproduct_ProcessSession

Many-To-One Relationship: [processsession msdyn_workorderproduct_ProcessSession](processsession.md#BKMK_msdyn_workorderproduct_ProcessSession)

|Property|Value|
|---|---|
|ReferencingEntity|`processsession`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_ProcessSession`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_RecurringAppointmentMasters"></a> msdyn_workorderproduct_RecurringAppointmentMasters

Many-To-One Relationship: [recurringappointmentmaster msdyn_workorderproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters)

|Property|Value|
|---|---|
|ReferencingEntity|`recurringappointmentmaster`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_RecurringAppointmentMasters`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_ServiceAppointments"></a> msdyn_workorderproduct_ServiceAppointments

Many-To-One Relationship: [serviceappointment msdyn_workorderproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorderproduct_ServiceAppointments)

|Property|Value|
|---|---|
|ReferencingEntity|`serviceappointment`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_ServiceAppointments`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_SharePointDocumentLocations"></a> msdyn_workorderproduct_SharePointDocumentLocations

Many-To-One Relationship: [sharepointdocumentlocation msdyn_workorderproduct_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_workorderproduct_SharePointDocumentLocations)

|Property|Value|
|---|---|
|ReferencingEntity|`sharepointdocumentlocation`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_SharePointDocumentLocations`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_SocialActivities"></a> msdyn_workorderproduct_SocialActivities

Many-To-One Relationship: [socialactivity msdyn_workorderproduct_SocialActivities](socialactivity.md#BKMK_msdyn_workorderproduct_SocialActivities)

|Property|Value|
|---|---|
|ReferencingEntity|`socialactivity`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_SocialActivities`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_SyncErrors"></a> msdyn_workorderproduct_SyncErrors

Many-To-One Relationship: [syncerror msdyn_workorderproduct_SyncErrors](syncerror.md#BKMK_msdyn_workorderproduct_SyncErrors)

|Property|Value|
|---|---|
|ReferencingEntity|`syncerror`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_SyncErrors`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|

### <a name="BKMK_msdyn_workorderproduct_Tasks"></a> msdyn_workorderproduct_Tasks

Many-To-One Relationship: [task msdyn_workorderproduct_Tasks](task.md#BKMK_msdyn_workorderproduct_Tasks)

|Property|Value|
|---|---|
|ReferencingEntity|`task`|
|ReferencingAttribute|`regardingobjectid`|
|ReferencedEntityNavigationPropertyName|`msdyn_workorderproduct_Tasks`|
|IsCustomizable|`True`|
|AssociatedMenuConfiguration|AvailableOffline: True<br />Behavior: `DoNotDisplay`<br />Group: `Details`<br />Label: <br />MenuId: null<br />Order: <br />QueryApi: null<br />ViewId: `00000000-0000-0000-0000-000000000000`|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   

