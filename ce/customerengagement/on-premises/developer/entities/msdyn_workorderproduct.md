---
title: "msdyn_workorderproduct Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_workorderproduct entity."
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
# msdyn_workorderproduct Entity Reference

In this entity you record all the products proposed and used for a work order

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderproducts(*msdyn_workorderproductid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_workorderproducts<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_workorderproducts(*msdyn_workorderproductid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_workorderproducts(*msdyn_workorderproductid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_workorderproducts<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderproducts(*msdyn_workorderproductid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderproducts(*msdyn_workorderproductid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_workorderproducts|
|DisplayCollectionName|Work Order Products|
|DisplayName|Work Order Product|
|EntitySetName|msdyn_workorderproducts|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_workorderproducts|
|LogicalName|msdyn_workorderproduct|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_workorderproductid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_workorderproduct|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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


### <a name="BKMK_msdyn_AdditionalCost"></a> msdyn_AdditionalCost

|Property|Value|
|--------|-----|
|Description|Enter any additional costs associated with this product. The values are manually entered. Note: additional cost is not unit dependent.|
|DisplayName|Additional Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_additionalcost|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_AgreementBookingProduct"></a> msdyn_AgreementBookingProduct

|Property|Value|
|--------|-----|
|Description|Agreement Booking Product linked to this Work Order Product|
|DisplayName|Agreement Booking Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingproduct|
|RequiredLevel|None|
|Targets|msdyn_agreementbookingproduct|
|Type|Lookup|


### <a name="BKMK_msdyn_Allocated"></a> msdyn_Allocated

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Allocated|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_allocated|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_Allocated Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

|Property|Value|
|--------|-----|
|Description|The booking where this product was added|
|DisplayName|Booking|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_booking|
|RequiredLevel|None|
|Targets|bookableresourcebooking|
|Type|Lookup|


### <a name="BKMK_msdyn_CommissionCosts"></a> msdyn_CommissionCosts

|Property|Value|
|--------|-----|
|Description|Enter the commission costs associated with this product. The value is manually specified and isn't automatically calculated.|
|DisplayName|Commission Costs|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_commissioncosts|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_CustomerAsset"></a> msdyn_CustomerAsset

|Property|Value|
|--------|-----|
|Description|Unique identifier for Customer Asset associated with Work Order Product.|
|DisplayName|Customer Asset|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customerasset|
|RequiredLevel|None|
|Targets|msdyn_customerasset|
|Type|Lookup|


### <a name="BKMK_msdyn_Description"></a> msdyn_Description

|Property|Value|
|--------|-----|
|Description|Enter the description of the product as presented to the customer. The value defaults to the description defined on the product.|
|DisplayName|Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_DisableEntitlement"></a> msdyn_DisableEntitlement

|Property|Value|
|--------|-----|
|Description|Choose whether to disable entitlement selection for this work order product.|
|DisplayName|Disable Entitlement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_disableentitlement|
|RequiredLevel|None|
|Type|Boolean|

#### msdyn_DisableEntitlement Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_DiscountAmount"></a> msdyn_DiscountAmount

|Property|Value|
|--------|-----|
|Description|Specify any discount amount on this product. Note: If you enter a discount amount you cannot enter a discount %|
|DisplayName|Discount Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_discountamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_DiscountPercent"></a> msdyn_DiscountPercent

|Property|Value|
|--------|-----|
|Description|Specify any discount % on this product. Note: If you enter a discount % it will overwrite the discount $|
|DisplayName|Discount %|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_discountpercent|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_Entitlement"></a> msdyn_Entitlement

|Property|Value|
|--------|-----|
|Description|Entitlement to apply to the Work Order Product.|
|DisplayName|Entitlement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_entitlement|
|RequiredLevel|None|
|Targets|entitlement|
|Type|Lookup|


### <a name="BKMK_msdyn_EstimateDiscountAmount"></a> msdyn_EstimateDiscountAmount

|Property|Value|
|--------|-----|
|Description|Enter a discount amount on the subtotal amount. Note: If you enter a discount amount you cannot enter a discount %|
|DisplayName|Estimate Discount Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatediscountamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstimateDiscountPercent"></a> msdyn_EstimateDiscountPercent

|Property|Value|
|--------|-----|
|Description|Enter a discount % on the subtotal amount. Note: If you enter a discount % it will overwrite the discount $|
|DisplayName|Estimate Discount %|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatediscountpercent|
|MaxValue|100|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_EstimateQuantity"></a> msdyn_EstimateQuantity

|Property|Value|
|--------|-----|
|Description|Enter the estimated required quantity of this product.|
|DisplayName|Estimate Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatequantity|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_EstimateSubtotal"></a> msdyn_EstimateSubtotal

|Property|Value|
|--------|-----|
|Description|Shows the total amount for this product, excluding discounts.|
|DisplayName|Estimate Subtotal|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatesubtotal|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstimateTotalAmount"></a> msdyn_EstimateTotalAmount

|Property|Value|
|--------|-----|
|Description|Shows the estimated total amount of this product, including discounts.|
|DisplayName|Estimate Total Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatetotalamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstimateTotalCost"></a> msdyn_EstimateTotalCost

|Property|Value|
|--------|-----|
|Description|Shows the estimated total cost of this product.|
|DisplayName|Estimate Total Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatetotalcost|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstimateUnitAmount"></a> msdyn_EstimateUnitAmount

|Property|Value|
|--------|-----|
|Description|Shows the estimated sale amount per unit.|
|DisplayName|Estimate Unit Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimateunitamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstimateUnitCost"></a> msdyn_EstimateUnitCost

|Property|Value|
|--------|-----|
|Description|Shows the estimated cost amount per unit.|
|DisplayName|Estimate Unit Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimateunitcost|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_InternalDescription"></a> msdyn_InternalDescription

|Property|Value|
|--------|-----|
|Description|Enter any internal notes you want to track on this product.|
|DisplayName|Internal Description|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_internaldescription|
|MaxLength|2000|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_InternalFlags"></a> msdyn_InternalFlags

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Internal Flags|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_internalflags|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_LineOrder"></a> msdyn_LineOrder

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Line Order|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_lineorder|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_LineStatus"></a> msdyn_LineStatus

|Property|Value|
|--------|-----|
|Description|Enter the current status of the line, estimate or used.|
|DisplayName|Line Status|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_linestatus|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_LineStatus Options

|Value|Label|
|-----|-----|
|690970000|Estimated|
|690970001|Used|



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
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|--------|-----|
|Description|Price List that determines the pricing for this product|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pricelist|
|RequiredLevel|ApplicationRequired|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

|Property|Value|
|--------|-----|
|Description|Product to use|
|DisplayName|Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_product|
|RequiredLevel|ApplicationRequired|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_msdyn_PurchaseOrderReceiptProduct"></a> msdyn_PurchaseOrderReceiptProduct

|Property|Value|
|--------|-----|
|Description|Purchase Order Receipt Product linked to this Work Order Product|
|DisplayName|Purchase Order Receipt Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderreceiptproduct|
|RequiredLevel|None|
|Targets|msdyn_purchaseorderreceiptproduct|
|Type|Lookup|


### <a name="BKMK_msdyn_QtyToBill"></a> msdyn_QtyToBill

|Property|Value|
|--------|-----|
|Description|Enter the quantity you wish to bill the customer for. By default, this will default to the same value as "Quantity."|
|DisplayName|Quantity To Bill|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_qtytobill|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|ApplicationRequired|
|Type|Double|


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

|Property|Value|
|--------|-----|
|Description|Shows the actual quantity of the product.|
|DisplayName|Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quantity|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|ApplicationRequired|
|Type|Double|


### <a name="BKMK_msdyn_Subtotal"></a> msdyn_Subtotal

|Property|Value|
|--------|-----|
|Description|Enter the total amount excluding discounts.|
|DisplayName|Subtotal|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_subtotal|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|ApplicationRequired|
|Type|Money|


### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

|Property|Value|
|--------|-----|
|Description|Specify if product is taxable. If you do not wish to charge tax set this field to No.|
|DisplayName|Taxable|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_taxable|
|RequiredLevel|ApplicationRequired|
|Type|Boolean|

#### msdyn_Taxable Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_msdyn_TotalAmount"></a> msdyn_TotalAmount

|Property|Value|
|--------|-----|
|Description|Enter the total amount charged to the customer.|
|DisplayName|Total Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|ApplicationRequired|
|Type|Money|


### <a name="BKMK_msdyn_TotalCost"></a> msdyn_TotalCost

|Property|Value|
|--------|-----|
|Description|Shows the total cost of this product. This is calculated by (Unit Cost * Units) + Additional Cost + Commission Costs.|
|DisplayName|Total Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalcost|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|ApplicationRequired|
|Type|Money|


### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

|Property|Value|
|--------|-----|
|Description|The unit that determines the pricing and final quantity for this product|
|DisplayName|Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unit|
|RequiredLevel|ApplicationRequired|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_msdyn_UnitAmount"></a> msdyn_UnitAmount

|Property|Value|
|--------|-----|
|Description|Enter the amount you want to charge the customer per unit. By default, this is calculated based on the selected price list. The amount can be changed.|
|DisplayName|Unit Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|ApplicationRequired|
|Type|Money|


### <a name="BKMK_msdyn_UnitCost"></a> msdyn_UnitCost

|Property|Value|
|--------|-----|
|Description|Shows the actual cost per unit.|
|DisplayName|Unit Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitcost|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|ApplicationRequired|
|Type|Money|


### <a name="BKMK_msdyn_Warehouse"></a> msdyn_Warehouse

|Property|Value|
|--------|-----|
|Description|Warehouse this product is being retrieved from|
|DisplayName|Warehouse|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_warehouse|
|RequiredLevel|None|
|Targets|msdyn_warehouse|
|Type|Lookup|


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|--------|-----|
|Description|Unique identifier for Work Order associated with Work Order Product.|
|DisplayName|Work Order|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorder|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_workorder|
|Type|Lookup|


### <a name="BKMK_msdyn_WorkOrderIncident"></a> msdyn_WorkOrderIncident

|Property|Value|
|--------|-----|
|Description|The Incident related to this product|
|DisplayName|Work Order Incident|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_workorderincident|
|RequiredLevel|None|
|Targets|msdyn_workorderincident|
|Type|Lookup|


### <a name="BKMK_msdyn_workorderproductId"></a> msdyn_workorderproductId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Work Order Product|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_workorderproductid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


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
|Description|Status of the Work Order Product|
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
|Description|Reason for the status of the Work Order Product|
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


### <a name="BKMK_TransactionCurrencyId"></a> TransactionCurrencyId

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Unique identifier of the currency associated with the entity.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|transactioncurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


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
- [ExchangeRate](#BKMK_ExchangeRate)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [msdyn_additionalcost_Base](#BKMK_msdyn_additionalcost_Base)
- [msdyn_AgreementBookingProductName](#BKMK_msdyn_AgreementBookingProductName)
- [msdyn_BookingName](#BKMK_msdyn_BookingName)
- [msdyn_commissioncosts_Base](#BKMK_msdyn_commissioncosts_Base)
- [msdyn_CustomerAssetName](#BKMK_msdyn_CustomerAssetName)
- [msdyn_discountamount_Base](#BKMK_msdyn_discountamount_Base)
- [msdyn_EntitlementName](#BKMK_msdyn_EntitlementName)
- [msdyn_estimatediscountamount_Base](#BKMK_msdyn_estimatediscountamount_Base)
- [msdyn_estimatesubtotal_Base](#BKMK_msdyn_estimatesubtotal_Base)
- [msdyn_estimatetotalamount_Base](#BKMK_msdyn_estimatetotalamount_Base)
- [msdyn_estimatetotalcost_Base](#BKMK_msdyn_estimatetotalcost_Base)
- [msdyn_estimateunitamount_Base](#BKMK_msdyn_estimateunitamount_Base)
- [msdyn_estimateunitcost_Base](#BKMK_msdyn_estimateunitcost_Base)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_PurchaseOrderReceiptProductName](#BKMK_msdyn_PurchaseOrderReceiptProductName)
- [msdyn_subtotal_Base](#BKMK_msdyn_subtotal_Base)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [msdyn_totalcost_Base](#BKMK_msdyn_totalcost_Base)
- [msdyn_unitamount_Base](#BKMK_msdyn_unitamount_Base)
- [msdyn_unitcost_Base](#BKMK_msdyn_unitcost_Base)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_WarehouseName](#BKMK_msdyn_WarehouseName)
- [msdyn_WorkOrderIncidentName](#BKMK_msdyn_WorkOrderIncidentName)
- [msdyn_WorkOrderName](#BKMK_msdyn_WorkOrderName)
- [OwnerIdName](#BKMK_OwnerIdName)
- [OwnerIdYomiName](#BKMK_OwnerIdYomiName)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)
- [TransactionCurrencyIdName](#BKMK_TransactionCurrencyIdName)
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


### <a name="BKMK_ExchangeRate"></a> ExchangeRate

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description|Shows the exchange rate for the currency associated with the entity with respect to the base currency.|
|DisplayName|Exchange Rate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|exchangerate|
|MaxValue|100000000000|
|MinValue|0.0000000001|
|Precision|10|
|RequiredLevel|None|
|Type|Decimal|


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


### <a name="BKMK_msdyn_additionalcost_Base"></a> msdyn_additionalcost_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the additional cost in the base currency.|
|DisplayName|Additional Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_additionalcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_AgreementBookingProductName"></a> msdyn_AgreementBookingProductName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingproductname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_BookingName"></a> msdyn_BookingName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_bookingname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_commissioncosts_Base"></a> msdyn_commissioncosts_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the commission costs in the base currency.|
|DisplayName|Commission Costs (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_commissioncosts_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_CustomerAssetName"></a> msdyn_CustomerAssetName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_customerassetname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_discountamount_Base"></a> msdyn_discountamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the discount amount in the base currency.|
|DisplayName|Discount Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_discountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EntitlementName"></a> msdyn_EntitlementName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_entitlementname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_estimatediscountamount_Base"></a> msdyn_estimatediscountamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the estimate discount amount in the base currency.|
|DisplayName|Estimate Discount Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatediscountamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatesubtotal_Base"></a> msdyn_estimatesubtotal_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the estimate subtotal in the base currency.|
|DisplayName|Estimate Subtotal (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatesubtotal_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatetotalamount_Base"></a> msdyn_estimatetotalamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the estimate total amount in the base currency.|
|DisplayName|Estimate Total Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatetotalamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatetotalcost_Base"></a> msdyn_estimatetotalcost_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the estimate total cost in the base currency.|
|DisplayName|Estimate Total Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatetotalcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimateunitamount_Base"></a> msdyn_estimateunitamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the estimate unit amount in the base currency.|
|DisplayName|Estimate Unit Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimateunitamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimateunitcost_Base"></a> msdyn_estimateunitcost_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the estimate unit cost in the base currency.|
|DisplayName|Estimate Unit Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimateunitcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_PriceListName"></a> msdyn_PriceListName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_pricelistname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ProductName"></a> msdyn_ProductName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_productname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_PurchaseOrderReceiptProductName"></a> msdyn_PurchaseOrderReceiptProductName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_purchaseorderreceiptproductname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_subtotal_Base"></a> msdyn_subtotal_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the subtotal in the base currency.|
|DisplayName|Subtotal (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_subtotal_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_totalamount_Base"></a> msdyn_totalamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the total amount in the base currency.|
|DisplayName|Total Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_totalcost_Base"></a> msdyn_totalcost_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the total cost in the base currency.|
|DisplayName|Total Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_unitamount_Base"></a> msdyn_unitamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the unit amount in the base currency.|
|DisplayName|Unit Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_unitcost_Base"></a> msdyn_unitcost_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the unit cost in the base currency.|
|DisplayName|Unit Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_UnitName"></a> msdyn_UnitName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_unitname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WarehouseName"></a> msdyn_WarehouseName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_warehousename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderIncidentName"></a> msdyn_WorkOrderIncidentName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workorderincidentname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_WorkOrderName"></a> msdyn_WorkOrderName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_workordername|
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


### <a name="BKMK_TransactionCurrencyIdName"></a> TransactionCurrencyIdName

**Added by**: Active Solution Solution

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|transactioncurrencyidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


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

- [msdyn_workorderproduct_ActivityPointers](#BKMK_msdyn_workorderproduct_ActivityPointers)
- [msdyn_workorderproduct_msdyn_bookingalerts](#BKMK_msdyn_workorderproduct_msdyn_bookingalerts)
- [msdyn_workorderproduct_msdyn_approvals](#BKMK_msdyn_workorderproduct_msdyn_approvals)
- [msdyn_workorderproduct_SyncErrors](#BKMK_msdyn_workorderproduct_SyncErrors)
- [msdyn_workorderproduct_SharePointDocumentLocations](#BKMK_msdyn_workorderproduct_SharePointDocumentLocations)
- [msdyn_workorderproduct_AsyncOperations](#BKMK_msdyn_workorderproduct_AsyncOperations)
- [msdyn_workorderproduct_MailboxTrackingFolders](#BKMK_msdyn_workorderproduct_MailboxTrackingFolders)
- [msdyn_workorderproduct_ProcessSession](#BKMK_msdyn_workorderproduct_ProcessSession)
- [msdyn_workorderproduct_BulkDeleteFailures](#BKMK_msdyn_workorderproduct_BulkDeleteFailures)
- [msdyn_workorderproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses)
- [msdyn_workorderproduct_Appointments](#BKMK_msdyn_workorderproduct_Appointments)
- [msdyn_workorderproduct_Emails](#BKMK_msdyn_workorderproduct_Emails)
- [msdyn_workorderproduct_Faxes](#BKMK_msdyn_workorderproduct_Faxes)
- [msdyn_workorderproduct_Letters](#BKMK_msdyn_workorderproduct_Letters)
- [msdyn_workorderproduct_PhoneCalls](#BKMK_msdyn_workorderproduct_PhoneCalls)
- [msdyn_workorderproduct_Tasks](#BKMK_msdyn_workorderproduct_Tasks)
- [msdyn_workorderproduct_RecurringAppointmentMasters](#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters)
- [msdyn_workorderproduct_SocialActivities](#BKMK_msdyn_workorderproduct_SocialActivities)
- [msdyn_workorderproduct_connections1](#BKMK_msdyn_workorderproduct_connections1)
- [msdyn_workorderproduct_connections2](#BKMK_msdyn_workorderproduct_connections2)
- [msdyn_workorderproduct_Annotations](#BKMK_msdyn_workorderproduct_Annotations)
- [msdyn_workorderproduct_ServiceAppointments](#BKMK_msdyn_workorderproduct_ServiceAppointments)
- [msdyn_msdyn_workorderproduct_invoicedetail](#BKMK_msdyn_msdyn_workorderproduct_invoicedetail)
- [msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct)
- [msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct)
- [msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct)
- [msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct](#BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct)


### <a name="BKMK_msdyn_workorderproduct_ActivityPointers"></a> msdyn_workorderproduct_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_workorderproduct_ActivityPointers](activitypointer.md#BKMK_msdyn_workorderproduct_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderproduct_msdyn_bookingalerts"></a> msdyn_workorderproduct_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_workorderproduct_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorderproduct_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_msdyn_approvals"></a> msdyn_workorderproduct_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_workorderproduct_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_workorderproduct_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_SyncErrors"></a> msdyn_workorderproduct_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_workorderproduct_SyncErrors](syncerror.md#BKMK_msdyn_workorderproduct_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderproduct_SharePointDocumentLocations"></a> msdyn_workorderproduct_SharePointDocumentLocations

**Added by**: System Solution Solution

Same as sharepointdocumentlocation entity [msdyn_workorderproduct_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_workorderproduct_SharePointDocumentLocations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_SharePointDocumentLocations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_AsyncOperations"></a> msdyn_workorderproduct_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_workorderproduct_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderproduct_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderproduct_MailboxTrackingFolders"></a> msdyn_workorderproduct_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_workorderproduct_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderproduct_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderproduct_ProcessSession"></a> msdyn_workorderproduct_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_workorderproduct_ProcessSession](processsession.md#BKMK_msdyn_workorderproduct_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderproduct_BulkDeleteFailures"></a> msdyn_workorderproduct_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_workorderproduct_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderproduct_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses"></a> msdyn_workorderproduct_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_workorderproduct_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderproduct_Appointments"></a> msdyn_workorderproduct_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_workorderproduct_Appointments](appointment.md#BKMK_msdyn_workorderproduct_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_Emails"></a> msdyn_workorderproduct_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_workorderproduct_Emails](email.md#BKMK_msdyn_workorderproduct_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_Faxes"></a> msdyn_workorderproduct_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_workorderproduct_Faxes](fax.md#BKMK_msdyn_workorderproduct_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_Letters"></a> msdyn_workorderproduct_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_workorderproduct_Letters](letter.md#BKMK_msdyn_workorderproduct_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_PhoneCalls"></a> msdyn_workorderproduct_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_workorderproduct_PhoneCalls](phonecall.md#BKMK_msdyn_workorderproduct_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_Tasks"></a> msdyn_workorderproduct_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_workorderproduct_Tasks](task.md#BKMK_msdyn_workorderproduct_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_RecurringAppointmentMasters"></a> msdyn_workorderproduct_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_workorderproduct_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorderproduct_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_SocialActivities"></a> msdyn_workorderproduct_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_workorderproduct_SocialActivities](socialactivity.md#BKMK_msdyn_workorderproduct_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_connections1"></a> msdyn_workorderproduct_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_workorderproduct_connections1](connection.md#BKMK_msdyn_workorderproduct_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderproduct_connections2"></a> msdyn_workorderproduct_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_workorderproduct_connections2](connection.md#BKMK_msdyn_workorderproduct_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderproduct_Annotations"></a> msdyn_workorderproduct_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_workorderproduct_Annotations](annotation.md#BKMK_msdyn_workorderproduct_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderproduct_ServiceAppointments"></a> msdyn_workorderproduct_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_workorderproduct_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorderproduct_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderproduct_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_workorderproduct_invoicedetail"></a> msdyn_msdyn_workorderproduct_invoicedetail

Same as invoicedetail entity [msdyn_msdyn_workorderproduct_invoicedetail](invoicedetail.md#BKMK_msdyn_msdyn_workorderproduct_invoicedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|msdyn_workorderproductid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorderproduct_invoicedetail|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct

Same as msdyn_customerasset entity [msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct](msdyn_customerasset.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_customerasset|
|ReferencingAttribute|msdyn_workorderproduct|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorderproduct_msdyn_customerasset_WorkOrderProduct|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct

Same as msdyn_inventoryjournal entity [msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct](msdyn_inventoryjournal.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_inventoryjournal|
|ReferencingAttribute|msdyn_workorderproduct|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorderproduct_msdyn_inventoryjournal_WorkOrderProduct|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct"></a> msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct

Same as msdyn_rmaproduct entity [msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct](msdyn_rmaproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rmaproduct|
|ReferencingAttribute|msdyn_woproduct|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorderproduct_msdyn_rmaproduct_WOProduct|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct"></a> msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct

Same as msdyn_rtvproduct entity [msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct](msdyn_rtvproduct.md#BKMK_msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_rtvproduct|
|ReferencingAttribute|msdyn_workorderproduct|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorderproduct_msdyn_rtvproduct_WorkOrderProduct|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_workorderproduct_createdby](#BKMK_lk_msdyn_workorderproduct_createdby)
- [lk_msdyn_workorderproduct_createdonbehalfby](#BKMK_lk_msdyn_workorderproduct_createdonbehalfby)
- [lk_msdyn_workorderproduct_modifiedby](#BKMK_lk_msdyn_workorderproduct_modifiedby)
- [lk_msdyn_workorderproduct_modifiedonbehalfby](#BKMK_lk_msdyn_workorderproduct_modifiedonbehalfby)
- [user_msdyn_workorderproduct](#BKMK_user_msdyn_workorderproduct)
- [team_msdyn_workorderproduct](#BKMK_team_msdyn_workorderproduct)
- [business_unit_msdyn_workorderproduct](#BKMK_business_unit_msdyn_workorderproduct)
- [TransactionCurrency_msdyn_workorderproduct](#BKMK_TransactionCurrency_msdyn_workorderproduct)
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


### <a name="BKMK_lk_msdyn_workorderproduct_createdby"></a> lk_msdyn_workorderproduct_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderproduct_createdby](systemuser.md#BKMK_lk_msdyn_workorderproduct_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderproduct_createdonbehalfby"></a> lk_msdyn_workorderproduct_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderproduct_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderproduct_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderproduct_modifiedby"></a> lk_msdyn_workorderproduct_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderproduct_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderproduct_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderproduct_modifiedonbehalfby"></a> lk_msdyn_workorderproduct_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderproduct_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderproduct_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_workorderproduct"></a> user_msdyn_workorderproduct

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_workorderproduct](systemuser.md#BKMK_user_msdyn_workorderproduct) One-To-Many relationship.

### <a name="BKMK_team_msdyn_workorderproduct"></a> team_msdyn_workorderproduct

**Added by**: System Solution Solution

See team Entity [team_msdyn_workorderproduct](team.md#BKMK_team_msdyn_workorderproduct) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_workorderproduct"></a> business_unit_msdyn_workorderproduct

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_workorderproduct](businessunit.md#BKMK_business_unit_msdyn_workorderproduct) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_workorderproduct"></a> TransactionCurrency_msdyn_workorderproduct

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_workorderproduct](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_workorderproduct) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderproduct_Booking) One-To-Many relationship.

### <a name="BKMK_msdyn_entitlement_msdyn_workorderproduct_Entitlement"></a> msdyn_entitlement_msdyn_workorderproduct_Entitlement

**Added by**: Service Solution

See entitlement Entity [msdyn_entitlement_msdyn_workorderproduct_Entitlement](entitlement.md#BKMK_msdyn_entitlement_msdyn_workorderproduct_Entitlement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct"></a> msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct

See msdyn_agreementbookingproduct Entity [msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct](msdyn_agreementbookingproduct.md#BKMK_msdyn_msdyn_agreementbookingproduct_msdyn_workorderproduct_AgreementBookingProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderproduct_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct"></a> msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct

See msdyn_purchaseorderreceiptproduct Entity [msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_msdyn_purchaseorderreceiptproduct_msdyn_workorderproduct_PurchaseOrderReceiptProduct) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse"></a> msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse

See msdyn_warehouse Entity [msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse](msdyn_warehouse.md#BKMK_msdyn_msdyn_warehouse_msdyn_workorderproduct_Warehouse) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderproduct_WorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident

See msdyn_workorderincident Entity [msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident](msdyn_workorderincident.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderproduct_WorkOrderIncident) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList"></a> msdyn_pricelevel_msdyn_workorderproduct_PriceList

**Added by**: Product Management Solution

See pricelevel Entity [msdyn_pricelevel_msdyn_workorderproduct_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_workorderproduct_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_workorderproduct_Product"></a> msdyn_product_msdyn_workorderproduct_Product

**Added by**: Product Management Solution

See product Entity [msdyn_product_msdyn_workorderproduct_Product](product.md#BKMK_msdyn_product_msdyn_workorderproduct_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_workorderproduct_Unit"></a> msdyn_uom_msdyn_workorderproduct_Unit

**Added by**: Product Management Solution

See uom Entity [msdyn_uom_msdyn_workorderproduct_Unit](uom.md#BKMK_msdyn_uom_msdyn_workorderproduct_Unit) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_workorderproduct?text=msdyn_workorderproduct EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]