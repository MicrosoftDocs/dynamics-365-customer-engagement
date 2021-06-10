---
title: "msdyn_workorderservice Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_workorderservice entity."
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
# msdyn_workorderservice Entity Reference

Record all services proposed and performed for work order

**Added by**: Field Service Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderservices(*msdyn_workorderserviceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_workorderservices<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_workorderservices(*msdyn_workorderserviceid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_workorderservices(*msdyn_workorderserviceid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_workorderservices<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderservices(*msdyn_workorderserviceid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_workorderservices(*msdyn_workorderserviceid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_workorderservices|
|DisplayCollectionName|Work Order Services|
|DisplayName|Work Order Service|
|EntitySetName|msdyn_workorderservices|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_workorderservices|
|LogicalName|msdyn_workorderservice|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_workorderserviceid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_workorderservice|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

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
|Description|Enter any additional costs associated with this service. The values are manually entered. Note: additional cost is not unit dependent.|
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


### <a name="BKMK_msdyn_AgreementBookingService"></a> msdyn_AgreementBookingService

|Property|Value|
|--------|-----|
|Description|Agreement Booking Service linked to this Work Order Service|
|DisplayName|Agreement Booking Service|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingservice|
|RequiredLevel|None|
|Targets|msdyn_agreementbookingservice|
|Type|Lookup|


### <a name="BKMK_msdyn_Booking"></a> msdyn_Booking

|Property|Value|
|--------|-----|
|Description|Shows the resource booking detail where this product was added.|
|DisplayName|Booking|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_booking|
|RequiredLevel|None|
|Targets|bookableresourcebooking|
|Type|Lookup|


### <a name="BKMK_msdyn_CalculatedUnitAmount"></a> msdyn_CalculatedUnitAmount

|Property|Value|
|--------|-----|
|Description|Shows the sale amount per unit calculated by the system considering the minimum charge, if applicable.|
|DisplayName|Calculated Unit Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_calculatedunitamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_CommissionCosts"></a> msdyn_CommissionCosts

|Property|Value|
|--------|-----|
|Description|Enter the commission costs associated with this service. The value is manually specified and isn't automatically calculated.|
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
|Description|Unique identifier for Customer Asset associated with Work Order Service.|
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
|Description|Enter the description of the service as presented to the customer. The value defaults to the description defined on the service.|
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
|Description|Choose whether to disable entitlement selection for this work order service.|
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
|Description|Specify any discount amount on this service. Note: If you enter a discount amount you cannot enter a discount %|
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
|Description|Specify any discount % on this service. Note: If you enter a discount % it will overwrite the discount $|
|DisplayName|Discount %|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_discountpercent|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_Duration"></a> msdyn_Duration

|Property|Value|
|--------|-----|
|Description|Shows the actual duration of service.|
|DisplayName|Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_duration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_DurationToBill"></a> msdyn_DurationToBill

|Property|Value|
|--------|-----|
|Description|Enter the quantity you wish to bill the customer for. By default, this will default to the same value as "Quantity."|
|DisplayName|Duration To Bill|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_durationtobill|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_Entitlement"></a> msdyn_Entitlement

|Property|Value|
|--------|-----|
|Description|Entitlement to apply to the Work Order Service.|
|DisplayName|Entitlement|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_entitlement|
|RequiredLevel|None|
|Targets|entitlement|
|Type|Lookup|


### <a name="BKMK_msdyn_EstimateCalculatedUnitAmount"></a> msdyn_EstimateCalculatedUnitAmount

|Property|Value|
|--------|-----|
|Description|Shows the estimated sale amount per unit calculated by the system considering the initial charge (if applicable).|
|DisplayName|Estimate Calculated Unit Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatecalculatedunitamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


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
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|RequiredLevel|None|
|Type|Double|


### <a name="BKMK_msdyn_EstimateDuration"></a> msdyn_EstimateDuration

|Property|Value|
|--------|-----|
|Description|Enter the estimated duration of this service.|
|DisplayName|Estimate Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimateduration|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_EstimateSubtotal"></a> msdyn_EstimateSubtotal

|Property|Value|
|--------|-----|
|Description|Shows the total amount for this service, excluding discounts.|
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
|Description|Shows the estimated total amount of this service, including discounts.|
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
|Description|Shows the estimated total cost of this service.|
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
|Description|Enter any internal notes you want to track on this service.|
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
|Description||
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



### <a name="BKMK_msdyn_MinimumChargeAmount"></a> msdyn_MinimumChargeAmount

|Property|Value|
|--------|-----|
|Description|Enter the amount charged as a minimum charge.|
|DisplayName|Minimum Charge Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_minimumchargeamount|
|MaxValue|1000000000|
|MinValue|0|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_MinimumChargeDuration"></a> msdyn_MinimumChargeDuration

|Property|Value|
|--------|-----|
|Description|Enter the duration of up to how long the minimum charge applies.|
|DisplayName|Minimum Charge Duration|
|Format|Duration|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_minimumchargeduration|
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
|MaxLength|200|
|RequiredLevel|ApplicationRequired|
|Type|String|


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|--------|-----|
|Description|Price List that determines the pricing for this service|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pricelist|
|RequiredLevel|ApplicationRequired|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_msdyn_Service"></a> msdyn_Service

|Property|Value|
|--------|-----|
|Description|Service proposed or used for this work order|
|DisplayName|Service|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_service|
|RequiredLevel|ApplicationRequired|
|Targets|product|
|Type|Lookup|


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
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_Taxable"></a> msdyn_Taxable

|Property|Value|
|--------|-----|
|Description|Specify if service is taxable. If you do not wish to charge tax set this field to No.|
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
|Description||
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
|Description|Shows the total cost of this service. This is calculated by (Unit Cost * Units) + Additional Cost + Commission Costs.|
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
|Description|The unit that determines the final quantity for this service|
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


### <a name="BKMK_msdyn_WorkOrder"></a> msdyn_WorkOrder

|Property|Value|
|--------|-----|
|Description|The work order this service relates to|
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


### <a name="BKMK_msdyn_workorderserviceId"></a> msdyn_workorderserviceId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Work Order Service|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_workorderserviceid|
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
|Description|Status of the Work Order Service|
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
|Description|Reason for the status of the Work Order Service|
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
- [msdyn_AgreementBookingServiceName](#BKMK_msdyn_AgreementBookingServiceName)
- [msdyn_BookingName](#BKMK_msdyn_BookingName)
- [msdyn_calculatedunitamount_Base](#BKMK_msdyn_calculatedunitamount_Base)
- [msdyn_commissioncosts_Base](#BKMK_msdyn_commissioncosts_Base)
- [msdyn_CustomerAssetName](#BKMK_msdyn_CustomerAssetName)
- [msdyn_discountamount_Base](#BKMK_msdyn_discountamount_Base)
- [msdyn_entitlementName](#BKMK_msdyn_entitlementName)
- [msdyn_estimatecalculatedunitamount_Base](#BKMK_msdyn_estimatecalculatedunitamount_Base)
- [msdyn_estimatediscountamount_Base](#BKMK_msdyn_estimatediscountamount_Base)
- [msdyn_estimatesubtotal_Base](#BKMK_msdyn_estimatesubtotal_Base)
- [msdyn_estimatetotalamount_Base](#BKMK_msdyn_estimatetotalamount_Base)
- [msdyn_estimatetotalcost_Base](#BKMK_msdyn_estimatetotalcost_Base)
- [msdyn_estimateunitamount_Base](#BKMK_msdyn_estimateunitamount_Base)
- [msdyn_estimateunitcost_Base](#BKMK_msdyn_estimateunitcost_Base)
- [msdyn_minimumchargeamount_Base](#BKMK_msdyn_minimumchargeamount_Base)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_ServiceName](#BKMK_msdyn_ServiceName)
- [msdyn_subtotal_Base](#BKMK_msdyn_subtotal_Base)
- [msdyn_totalamount_Base](#BKMK_msdyn_totalamount_Base)
- [msdyn_totalcost_Base](#BKMK_msdyn_totalcost_Base)
- [msdyn_unitamount_Base](#BKMK_msdyn_unitamount_Base)
- [msdyn_unitcost_Base](#BKMK_msdyn_unitcost_Base)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
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


### <a name="BKMK_msdyn_AgreementBookingServiceName"></a> msdyn_AgreementBookingServiceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_agreementbookingservicename|
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


### <a name="BKMK_msdyn_calculatedunitamount_Base"></a> msdyn_calculatedunitamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the calculated unit amount in the base currency.|
|DisplayName|Calculated Unit Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_calculatedunitamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


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
|Description|Shows the value of the discount Amount in the base currency.|
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


### <a name="BKMK_msdyn_entitlementName"></a> msdyn_entitlementName

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


### <a name="BKMK_msdyn_estimatecalculatedunitamount_Base"></a> msdyn_estimatecalculatedunitamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the estimate calculated unit amount in the base currency.|
|DisplayName|Estimate Calculated Unit Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatecalculatedunitamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|1|
|RequiredLevel|None|
|Type|Money|


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


### <a name="BKMK_msdyn_minimumchargeamount_Base"></a> msdyn_minimumchargeamount_Base

|Property|Value|
|--------|-----|
|Description|Shows the value of the minimum charge amount in the base currency.|
|DisplayName|Minimum Charge Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_minimumchargeamount_base|
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


### <a name="BKMK_msdyn_ServiceName"></a> msdyn_ServiceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_servicename|
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

- [msdyn_workorderservice_ActivityPointers](#BKMK_msdyn_workorderservice_ActivityPointers)
- [msdyn_workorderservice_msdyn_bookingalerts](#BKMK_msdyn_workorderservice_msdyn_bookingalerts)
- [msdyn_workorderservice_msdyn_approvals](#BKMK_msdyn_workorderservice_msdyn_approvals)
- [msdyn_workorderservice_SyncErrors](#BKMK_msdyn_workorderservice_SyncErrors)
- [msdyn_workorderservice_DuplicateMatchingRecord](#BKMK_msdyn_workorderservice_DuplicateMatchingRecord)
- [msdyn_workorderservice_DuplicateBaseRecord](#BKMK_msdyn_workorderservice_DuplicateBaseRecord)
- [msdyn_workorderservice_SharePointDocumentLocations](#BKMK_msdyn_workorderservice_SharePointDocumentLocations)
- [msdyn_workorderservice_AsyncOperations](#BKMK_msdyn_workorderservice_AsyncOperations)
- [msdyn_workorderservice_MailboxTrackingFolders](#BKMK_msdyn_workorderservice_MailboxTrackingFolders)
- [msdyn_workorderservice_ProcessSession](#BKMK_msdyn_workorderservice_ProcessSession)
- [msdyn_workorderservice_BulkDeleteFailures](#BKMK_msdyn_workorderservice_BulkDeleteFailures)
- [msdyn_workorderservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses)
- [msdyn_workorderservice_Appointments](#BKMK_msdyn_workorderservice_Appointments)
- [msdyn_workorderservice_Emails](#BKMK_msdyn_workorderservice_Emails)
- [msdyn_workorderservice_Faxes](#BKMK_msdyn_workorderservice_Faxes)
- [msdyn_workorderservice_Letters](#BKMK_msdyn_workorderservice_Letters)
- [msdyn_workorderservice_PhoneCalls](#BKMK_msdyn_workorderservice_PhoneCalls)
- [msdyn_workorderservice_Tasks](#BKMK_msdyn_workorderservice_Tasks)
- [msdyn_workorderservice_RecurringAppointmentMasters](#BKMK_msdyn_workorderservice_RecurringAppointmentMasters)
- [msdyn_workorderservice_SocialActivities](#BKMK_msdyn_workorderservice_SocialActivities)
- [msdyn_workorderservice_connections1](#BKMK_msdyn_workorderservice_connections1)
- [msdyn_workorderservice_connections2](#BKMK_msdyn_workorderservice_connections2)
- [msdyn_workorderservice_QueueItems](#BKMK_msdyn_workorderservice_QueueItems)
- [msdyn_workorderservice_Annotations](#BKMK_msdyn_workorderservice_Annotations)
- [msdyn_workorderservice_ServiceAppointments](#BKMK_msdyn_workorderservice_ServiceAppointments)
- [msdyn_msdyn_workorderservice_invoicedetail](#BKMK_msdyn_msdyn_workorderservice_invoicedetail)


### <a name="BKMK_msdyn_workorderservice_ActivityPointers"></a> msdyn_workorderservice_ActivityPointers

**Added by**: System Solution Solution

Same as activitypointer entity [msdyn_workorderservice_ActivityPointers](activitypointer.md#BKMK_msdyn_workorderservice_ActivityPointers) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|activitypointer|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_ActivityPointers|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_msdyn_bookingalerts"></a> msdyn_workorderservice_msdyn_bookingalerts

**Added by**: Active Solution Solution

Same as msdyn_bookingalert entity [msdyn_workorderservice_msdyn_bookingalerts](msdyn_bookingalert.md#BKMK_msdyn_workorderservice_msdyn_bookingalerts) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bookingalert|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_msdyn_bookingalerts|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_msdyn_approvals"></a> msdyn_workorderservice_msdyn_approvals

**Added by**: Active Solution Solution

Same as msdyn_approval entity [msdyn_workorderservice_msdyn_approvals](msdyn_approval.md#BKMK_msdyn_workorderservice_msdyn_approvals) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_approval|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_msdyn_approvals|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_SyncErrors"></a> msdyn_workorderservice_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_workorderservice_SyncErrors](syncerror.md#BKMK_msdyn_workorderservice_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_DuplicateMatchingRecord"></a> msdyn_workorderservice_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_workorderservice_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_workorderservice_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_DuplicateBaseRecord"></a> msdyn_workorderservice_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_workorderservice_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_workorderservice_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_SharePointDocumentLocations"></a> msdyn_workorderservice_SharePointDocumentLocations

**Added by**: System Solution Solution

Same as sharepointdocumentlocation entity [msdyn_workorderservice_SharePointDocumentLocations](sharepointdocumentlocation.md#BKMK_msdyn_workorderservice_SharePointDocumentLocations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocumentlocation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_SharePointDocumentLocations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_AsyncOperations"></a> msdyn_workorderservice_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_workorderservice_AsyncOperations](asyncoperation.md#BKMK_msdyn_workorderservice_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_MailboxTrackingFolders"></a> msdyn_workorderservice_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_workorderservice_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_workorderservice_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_ProcessSession"></a> msdyn_workorderservice_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_workorderservice_ProcessSession](processsession.md#BKMK_msdyn_workorderservice_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_BulkDeleteFailures"></a> msdyn_workorderservice_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_workorderservice_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_workorderservice_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses"></a> msdyn_workorderservice_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_workorderservice_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_Appointments"></a> msdyn_workorderservice_Appointments

**Added by**: System Solution Solution

Same as appointment entity [msdyn_workorderservice_Appointments](appointment.md#BKMK_msdyn_workorderservice_Appointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_Appointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_Emails"></a> msdyn_workorderservice_Emails

**Added by**: System Solution Solution

Same as email entity [msdyn_workorderservice_Emails](email.md#BKMK_msdyn_workorderservice_Emails) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|email|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_Emails|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_Faxes"></a> msdyn_workorderservice_Faxes

**Added by**: System Solution Solution

Same as fax entity [msdyn_workorderservice_Faxes](fax.md#BKMK_msdyn_workorderservice_Faxes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fax|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_Faxes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_Letters"></a> msdyn_workorderservice_Letters

**Added by**: System Solution Solution

Same as letter entity [msdyn_workorderservice_Letters](letter.md#BKMK_msdyn_workorderservice_Letters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|letter|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_Letters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_PhoneCalls"></a> msdyn_workorderservice_PhoneCalls

**Added by**: System Solution Solution

Same as phonecall entity [msdyn_workorderservice_PhoneCalls](phonecall.md#BKMK_msdyn_workorderservice_PhoneCalls) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonecall|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_PhoneCalls|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_Tasks"></a> msdyn_workorderservice_Tasks

**Added by**: System Solution Solution

Same as task entity [msdyn_workorderservice_Tasks](task.md#BKMK_msdyn_workorderservice_Tasks) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|task|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_Tasks|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_RecurringAppointmentMasters"></a> msdyn_workorderservice_RecurringAppointmentMasters

**Added by**: System Solution Solution

Same as recurringappointmentmaster entity [msdyn_workorderservice_RecurringAppointmentMasters](recurringappointmentmaster.md#BKMK_msdyn_workorderservice_RecurringAppointmentMasters) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recurringappointmentmaster|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_RecurringAppointmentMasters|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_SocialActivities"></a> msdyn_workorderservice_SocialActivities

**Added by**: System Solution Solution

Same as socialactivity entity [msdyn_workorderservice_SocialActivities](socialactivity.md#BKMK_msdyn_workorderservice_SocialActivities) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialactivity|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_SocialActivities|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_connections1"></a> msdyn_workorderservice_connections1

**Added by**: System Solution Solution

Same as connection entity [msdyn_workorderservice_connections1](connection.md#BKMK_msdyn_workorderservice_connections1) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record1id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_connections1|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 100|
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_connections2"></a> msdyn_workorderservice_connections2

**Added by**: System Solution Solution

Same as connection entity [msdyn_workorderservice_connections2](connection.md#BKMK_msdyn_workorderservice_connections2) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connection|
|ReferencingAttribute|record2id|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_connections2|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_QueueItems"></a> msdyn_workorderservice_QueueItems

**Added by**: System Solution Solution

Same as queueitem entity [msdyn_workorderservice_QueueItems](queueitem.md#BKMK_msdyn_workorderservice_QueueItems) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_QueueItems|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_workorderservice_Annotations"></a> msdyn_workorderservice_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_workorderservice_Annotations](annotation.md#BKMK_msdyn_workorderservice_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_workorderservice_ServiceAppointments"></a> msdyn_workorderservice_ServiceAppointments

**Added by**: Service Solution

Same as serviceappointment entity [msdyn_workorderservice_ServiceAppointments](serviceappointment.md#BKMK_msdyn_workorderservice_ServiceAppointments) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceappointment|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_workorderservice_ServiceAppointments|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_workorderservice_invoicedetail"></a> msdyn_msdyn_workorderservice_invoicedetail

Same as invoicedetail entity [msdyn_msdyn_workorderservice_invoicedetail](invoicedetail.md#BKMK_msdyn_msdyn_workorderservice_invoicedetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|invoicedetail|
|ReferencingAttribute|msdyn_workorderserviceid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_workorderservice_invoicedetail|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Sales<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: NoCascade<br />Delete: RemoveLink<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_workorderservice_createdby](#BKMK_lk_msdyn_workorderservice_createdby)
- [lk_msdyn_workorderservice_createdonbehalfby](#BKMK_lk_msdyn_workorderservice_createdonbehalfby)
- [lk_msdyn_workorderservice_modifiedby](#BKMK_lk_msdyn_workorderservice_modifiedby)
- [lk_msdyn_workorderservice_modifiedonbehalfby](#BKMK_lk_msdyn_workorderservice_modifiedonbehalfby)
- [user_msdyn_workorderservice](#BKMK_user_msdyn_workorderservice)
- [team_msdyn_workorderservice](#BKMK_team_msdyn_workorderservice)
- [business_unit_msdyn_workorderservice](#BKMK_business_unit_msdyn_workorderservice)
- [TransactionCurrency_msdyn_workorderservice](#BKMK_TransactionCurrency_msdyn_workorderservice)
- [msdyn_bookableresourcebooking_msdyn_workorderservice_Booking](#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking)
- [msdyn_entitlement_msdyn_workorderservice_entitlement](#BKMK_msdyn_entitlement_msdyn_workorderservice_entitlement)
- [msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService](#BKMK_msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService)
- [msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset)
- [msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder](#BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder)
- [msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident](#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident)
- [msdyn_pricelevel_msdyn_workorderservice_PriceList](#BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList)
- [msdyn_product_msdyn_workorderservice_Service](#BKMK_msdyn_product_msdyn_workorderservice_Service)
- [msdyn_uom_msdyn_workorderservice_Unit](#BKMK_msdyn_uom_msdyn_workorderservice_Unit)


### <a name="BKMK_lk_msdyn_workorderservice_createdby"></a> lk_msdyn_workorderservice_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderservice_createdby](systemuser.md#BKMK_lk_msdyn_workorderservice_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderservice_createdonbehalfby"></a> lk_msdyn_workorderservice_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderservice_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderservice_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderservice_modifiedby"></a> lk_msdyn_workorderservice_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderservice_modifiedby](systemuser.md#BKMK_lk_msdyn_workorderservice_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_workorderservice_modifiedonbehalfby"></a> lk_msdyn_workorderservice_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_workorderservice_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_workorderservice_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_workorderservice"></a> user_msdyn_workorderservice

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_workorderservice](systemuser.md#BKMK_user_msdyn_workorderservice) One-To-Many relationship.

### <a name="BKMK_team_msdyn_workorderservice"></a> team_msdyn_workorderservice

**Added by**: System Solution Solution

See team Entity [team_msdyn_workorderservice](team.md#BKMK_team_msdyn_workorderservice) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_workorderservice"></a> business_unit_msdyn_workorderservice

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_workorderservice](businessunit.md#BKMK_business_unit_msdyn_workorderservice) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_workorderservice"></a> TransactionCurrency_msdyn_workorderservice

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_workorderservice](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_workorderservice) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking"></a> msdyn_bookableresourcebooking_msdyn_workorderservice_Booking

**Added by**: Scheduling Solution

See bookableresourcebooking Entity [msdyn_bookableresourcebooking_msdyn_workorderservice_Booking](bookableresourcebooking.md#BKMK_msdyn_bookableresourcebooking_msdyn_workorderservice_Booking) One-To-Many relationship.

### <a name="BKMK_msdyn_entitlement_msdyn_workorderservice_entitlement"></a> msdyn_entitlement_msdyn_workorderservice_entitlement

**Added by**: Service Solution

See entitlement Entity [msdyn_entitlement_msdyn_workorderservice_entitlement](entitlement.md#BKMK_msdyn_entitlement_msdyn_workorderservice_entitlement) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService"></a> msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService

See msdyn_agreementbookingservice Entity [msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService](msdyn_agreementbookingservice.md#BKMK_msdyn_msdyn_agreementbookingservice_msdyn_workorderservice_AgreementBookingService) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset"></a> msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset

See msdyn_customerasset Entity [msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset](msdyn_customerasset.md#BKMK_msdyn_msdyn_customerasset_msdyn_workorderservice_CustomerAsset) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder"></a> msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder

See msdyn_workorder Entity [msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder](msdyn_workorder.md#BKMK_msdyn_msdyn_workorder_msdyn_workorderservice_WorkOrder) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident"></a> msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident

See msdyn_workorderincident Entity [msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident](msdyn_workorderincident.md#BKMK_msdyn_msdyn_workorderincident_msdyn_workorderservice_WorkOrderIncident) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList"></a> msdyn_pricelevel_msdyn_workorderservice_PriceList

**Added by**: Product Management Solution

See pricelevel Entity [msdyn_pricelevel_msdyn_workorderservice_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_workorderservice_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_workorderservice_Service"></a> msdyn_product_msdyn_workorderservice_Service

**Added by**: Product Management Solution

See product Entity [msdyn_product_msdyn_workorderservice_Service](product.md#BKMK_msdyn_product_msdyn_workorderservice_Service) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_workorderservice_Unit"></a> msdyn_uom_msdyn_workorderservice_Unit

**Added by**: Product Management Solution

See uom Entity [msdyn_uom_msdyn_workorderservice_Unit](uom.md#BKMK_msdyn_uom_msdyn_workorderservice_Unit) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_workorderservice?text=msdyn_workorderservice EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]