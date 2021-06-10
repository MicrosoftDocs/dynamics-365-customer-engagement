---
title: "msdyn_fact Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_fact entity."
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
# msdyn_fact Entity Reference

Aggregated fact entity for actual transactions.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_facts(*msdyn_factid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_facts<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_facts(*msdyn_factid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_facts(*msdyn_factid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_facts<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_facts(*msdyn_factid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_facts(*msdyn_factid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_facts|
|DisplayCollectionName|Facts|
|DisplayName|Fact|
|EntitySetName|msdyn_facts|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_facts|
|LogicalName|msdyn_fact|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_factid|
|PrimaryNameAttribute|msdyn_name|
|SchemaName|msdyn_fact|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AccountCustomer](#BKMK_msdyn_AccountCustomer)
- [msdyn_AccountVendor](#BKMK_msdyn_AccountVendor)
- [msdyn_ActChargeableBilledSalesAmount](#BKMK_msdyn_ActChargeableBilledSalesAmount)
- [msdyn_ActChargeableBilledSalesQuantity](#BKMK_msdyn_ActChargeableBilledSalesQuantity)
- [msdyn_ActChargeableCostAmount](#BKMK_msdyn_ActChargeableCostAmount)
- [msdyn_ActChargeableCostQuantity](#BKMK_msdyn_ActChargeableCostQuantity)
- [msdyn_ActChargeableUnbilledSalesAmount](#BKMK_msdyn_ActChargeableUnbilledSalesAmount)
- [msdyn_ActChargeableUnbilledSalesQuantity](#BKMK_msdyn_ActChargeableUnbilledSalesQuantity)
- [msdyn_ActNoChargeBilledSalesAmount](#BKMK_msdyn_ActNoChargeBilledSalesAmount)
- [msdyn_ActNoChargeBilledSalesQuantity](#BKMK_msdyn_ActNoChargeBilledSalesQuantity)
- [msdyn_ActNoChargeCostAmount](#BKMK_msdyn_ActNoChargeCostAmount)
- [msdyn_ActNoChargeCostQuantity](#BKMK_msdyn_ActNoChargeCostQuantity)
- [msdyn_ActNoChargeUnbilledSalesAmount](#BKMK_msdyn_ActNoChargeUnbilledSalesAmount)
- [msdyn_ActNoChargeUnbilledSalesQuantity](#BKMK_msdyn_ActNoChargeUnbilledSalesQuantity)
- [msdyn_ActNonChargeableCostAmount](#BKMK_msdyn_ActNonChargeableCostAmount)
- [msdyn_ActNonChargeableCostQuantity](#BKMK_msdyn_ActNonChargeableCostQuantity)
- [msdyn_ActNonChargeableUnbilledSalesAmount](#BKMK_msdyn_ActNonChargeableUnbilledSalesAmount)
- [msdyn_ActNonChargeableUnbilledSalesQuantity](#BKMK_msdyn_ActNonChargeableUnbilledSalesQuantity)
- [msdyn_bookableresource](#BKMK_msdyn_bookableresource)
- [msdyn_ContactCustomer](#BKMK_msdyn_ContactCustomer)
- [msdyn_ContactVendor](#BKMK_msdyn_ContactVendor)
- [msdyn_CustomerType](#BKMK_msdyn_CustomerType)
- [msdyn_DocumentDate](#BKMK_msdyn_DocumentDate)
- [msdyn_EndDate](#BKMK_msdyn_EndDate)
- [msdyn_EstChargeableBilledSalesAmount](#BKMK_msdyn_EstChargeableBilledSalesAmount)
- [msdyn_EstChargeableBilledSalesQuantity](#BKMK_msdyn_EstChargeableBilledSalesQuantity)
- [msdyn_EstChargeableCostAmount](#BKMK_msdyn_EstChargeableCostAmount)
- [msdyn_EstChargeableCostQuantity](#BKMK_msdyn_EstChargeableCostQuantity)
- [msdyn_EstChargeableUnbilledSalesAmount](#BKMK_msdyn_EstChargeableUnbilledSalesAmount)
- [msdyn_EstChargeableUnbilledSalesQuantity](#BKMK_msdyn_EstChargeableUnbilledSalesQuantity)
- [msdyn_Estimate](#BKMK_msdyn_Estimate)
- [msdyn_estimatelineid](#BKMK_msdyn_estimatelineid)
- [msdyn_EstNoChargeBilledSalesAmount](#BKMK_msdyn_EstNoChargeBilledSalesAmount)
- [msdyn_EstNoChargeBilledSalesQuantity](#BKMK_msdyn_EstNoChargeBilledSalesQuantity)
- [msdyn_EstNoChargeCostAmount](#BKMK_msdyn_EstNoChargeCostAmount)
- [msdyn_EstNoChargeCostQuantity](#BKMK_msdyn_EstNoChargeCostQuantity)
- [msdyn_EstNoChargeUnbilledSalesAmount](#BKMK_msdyn_EstNoChargeUnbilledSalesAmount)
- [msdyn_EstNoChargeUnbilledSalesQuantity](#BKMK_msdyn_EstNoChargeUnbilledSalesQuantity)
- [msdyn_EstNonChargeableCostAmount](#BKMK_msdyn_EstNonChargeableCostAmount)
- [msdyn_EstNonChargeableCostQuantity](#BKMK_msdyn_EstNonChargeableCostQuantity)
- [msdyn_EstNonChargeableUnbilledSalesAmount](#BKMK_msdyn_EstNonChargeableUnbilledSalesAmount)
- [msdyn_EstNonChargeableUnbilledSalesQuantity](#BKMK_msdyn_EstNonChargeableUnbilledSalesQuantity)
- [msdyn_factId](#BKMK_msdyn_factId)
- [msdyn_FactType](#BKMK_msdyn_FactType)
- [msdyn_name](#BKMK_msdyn_name)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_Project](#BKMK_msdyn_Project)
- [msdyn_ResourceCategory](#BKMK_msdyn_ResourceCategory)
- [msdyn_SalesContract](#BKMK_msdyn_SalesContract)
- [msdyn_SalesContractLine](#BKMK_msdyn_SalesContractLine)
- [msdyn_SalesContractLineId](#BKMK_msdyn_SalesContractLineId)
- [msdyn_StartDate](#BKMK_msdyn_StartDate)
- [msdyn_Task](#BKMK_msdyn_Task)
- [msdyn_TransactionCategory](#BKMK_msdyn_TransactionCategory)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
- [msdyn_VendorType](#BKMK_msdyn_VendorType)
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
|Description|Sequence number of the import that created this record.|
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


### <a name="BKMK_msdyn_AccountCustomer"></a> msdyn_AccountCustomer

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_accountcustomer|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_AccountVendor"></a> msdyn_AccountVendor

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Vendor|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_accountvendor|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_ActChargeableBilledSalesAmount"></a> msdyn_ActChargeableBilledSalesAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual Chargeable Billed Sales Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actchargeablebilledsalesamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_ActChargeableBilledSalesQuantity"></a> msdyn_ActChargeableBilledSalesQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual Chargeable Billed Sales Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actchargeablebilledsalesquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_ActChargeableCostAmount"></a> msdyn_ActChargeableCostAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual Chargeable Cost Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actchargeablecostamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_ActChargeableCostQuantity"></a> msdyn_ActChargeableCostQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual Chargeable Cost Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actchargeablecostquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_ActChargeableUnbilledSalesAmount"></a> msdyn_ActChargeableUnbilledSalesAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual Chargeable Unbilled Sales Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actchargeableunbilledsalesamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_ActChargeableUnbilledSalesQuantity"></a> msdyn_ActChargeableUnbilledSalesQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual Chargeable Unbilled Sales Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actchargeableunbilledsalesquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_ActNoChargeBilledSalesAmount"></a> msdyn_ActNoChargeBilledSalesAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual No Charge Billed Sales Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnochargebilledsalesamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_ActNoChargeBilledSalesQuantity"></a> msdyn_ActNoChargeBilledSalesQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual No Charge Billed Sales Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnochargebilledsalesquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_ActNoChargeCostAmount"></a> msdyn_ActNoChargeCostAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual No Charge Cost Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnochargecostamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_ActNoChargeCostQuantity"></a> msdyn_ActNoChargeCostQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual No Charge Cost Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnochargecostquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_ActNoChargeUnbilledSalesAmount"></a> msdyn_ActNoChargeUnbilledSalesAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual No Charge Unbilled Sales Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnochargeunbilledsalesamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_ActNoChargeUnbilledSalesQuantity"></a> msdyn_ActNoChargeUnbilledSalesQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual No Charge Unbilled Sales Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnochargeunbilledsalesquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_ActNonChargeableCostAmount"></a> msdyn_ActNonChargeableCostAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual Non Chargeable Cost Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnonchargeablecostamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_ActNonChargeableCostQuantity"></a> msdyn_ActNonChargeableCostQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual Non Chargeable Cost Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnonchargeablecostquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_ActNonChargeableUnbilledSalesAmount"></a> msdyn_ActNonChargeableUnbilledSalesAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual Non Chargeable Unbilled Sales Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnonchargeableunbilledsalesamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_ActNonChargeableUnbilledSalesQuantity"></a> msdyn_ActNonChargeableUnbilledSalesQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Actual Non Chargeable Unbilled Sales Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnonchargeableunbilledsalesquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_bookableresource"></a> msdyn_bookableresource

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Bookable Resource|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_bookableresource|
|RequiredLevel|None|
|Targets|bookableresource|
|Type|Lookup|


### <a name="BKMK_msdyn_ContactCustomer"></a> msdyn_ContactCustomer

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contactcustomer|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_msdyn_ContactVendor"></a> msdyn_ContactVendor

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Vendor|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_contactvendor|
|RequiredLevel|None|
|Targets|contact|
|Type|Lookup|


### <a name="BKMK_msdyn_CustomerType"></a> msdyn_CustomerType

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Customer Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_customertype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_CustomerType Options

|Value|Label|
|-----|-----|
|192350001|Account|
|192350002|Contact|



### <a name="BKMK_msdyn_DocumentDate"></a> msdyn_DocumentDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the transaction date of the business event.|
|DisplayName|Document Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_documentdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_EndDate"></a> msdyn_EndDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the end date for this transaction.|
|DisplayName|End Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enddate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_EstChargeableBilledSalesAmount"></a> msdyn_EstChargeableBilledSalesAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Chargeable Billed Sales Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estchargeablebilledsalesamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstChargeableBilledSalesQuantity"></a> msdyn_EstChargeableBilledSalesQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Chargeable Billed Sales Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estchargeablebilledsalesquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_EstChargeableCostAmount"></a> msdyn_EstChargeableCostAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Chargeable Cost Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estchargeablecostamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstChargeableCostQuantity"></a> msdyn_EstChargeableCostQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Chargeable Cost Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estchargeablecostquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_EstChargeableUnbilledSalesAmount"></a> msdyn_EstChargeableUnbilledSalesAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Chargeable Unbilled Sales Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estchargeableunbilledsalesamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstChargeableUnbilledSalesQuantity"></a> msdyn_EstChargeableUnbilledSalesQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Chargeable Unbilled Sales Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estchargeableunbilledsalesquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_Estimate"></a> msdyn_Estimate

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimate|
|RequiredLevel|None|
|Targets|msdyn_estimate|
|Type|Lookup|


### <a name="BKMK_msdyn_estimatelineid"></a> msdyn_estimatelineid

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimate Line|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimatelineid|
|RequiredLevel|None|
|Targets|msdyn_estimateline|
|Type|Lookup|


### <a name="BKMK_msdyn_EstNoChargeBilledSalesAmount"></a> msdyn_EstNoChargeBilledSalesAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated No Charge Billed Sales Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnochargebilledsalesamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstNoChargeBilledSalesQuantity"></a> msdyn_EstNoChargeBilledSalesQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated No Charge Billed Sales Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnochargebilledsalesquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_EstNoChargeCostAmount"></a> msdyn_EstNoChargeCostAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated No Charge Cost Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnochargecostamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstNoChargeCostQuantity"></a> msdyn_EstNoChargeCostQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated No Charge Cost Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnochargecostquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_EstNoChargeUnbilledSalesAmount"></a> msdyn_EstNoChargeUnbilledSalesAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated No Charge Unbilled Sales Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnochargeunbilledsalesamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstNoChargeUnbilledSalesQuantity"></a> msdyn_EstNoChargeUnbilledSalesQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated No Charge Unbilled Sales Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnochargeunbilledsalesquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_EstNonChargeableCostAmount"></a> msdyn_EstNonChargeableCostAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Non Chargeable Cost Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnonchargeablecostamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstNonChargeableCostQuantity"></a> msdyn_EstNonChargeableCostQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Non Chargeable Cost Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnonchargeablecostquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_EstNonChargeableUnbilledSalesAmount"></a> msdyn_EstNonChargeableUnbilledSalesAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Non Chargeable Unbilled Sales Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnonchargeableunbilledsalesamount|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_EstNonChargeableUnbilledSalesQuantity"></a> msdyn_EstNonChargeableUnbilledSalesQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Estimated Non Chargeable Unbilled Sales Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnonchargeableunbilledsalesquantity|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_factId"></a> msdyn_factId

|Property|Value|
|--------|-----|
|Description|Unique identifier for entity instances|
|DisplayName|Fact|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_factid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_FactType"></a> msdyn_FactType

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Fact Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_facttype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_FactType Options

|Value|Label|
|-----|-----|
|192350000|Actual|
|192350001|Estimate|



### <a name="BKMK_msdyn_name"></a> msdyn_name

|Property|Value|
|--------|-----|
|Description|The name of the custom entity.|
|DisplayName|Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_name|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Product|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_product|
|RequiredLevel|None|
|Targets|product|
|Type|Lookup|


### <a name="BKMK_msdyn_Project"></a> msdyn_Project

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Project|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_project|
|RequiredLevel|None|
|Targets|msdyn_project|
|Type|Lookup|


### <a name="BKMK_msdyn_ResourceCategory"></a> msdyn_ResourceCategory

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Role|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecategory|
|RequiredLevel|None|
|Targets|bookableresourcecategory|
|Type|Lookup|


### <a name="BKMK_msdyn_SalesContract"></a> msdyn_SalesContract

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Project Contract|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salescontract|
|RequiredLevel|None|
|Targets|salesorder|
|Type|Lookup|


### <a name="BKMK_msdyn_SalesContractLine"></a> msdyn_SalesContractLine

|Property|Value|
|--------|-----|
|Description|(Deprecated)|
|DisplayName|(Deprecated) Project Contract Line|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salescontractline|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SalesContractLineId"></a> msdyn_SalesContractLineId

|Property|Value|
|--------|-----|
|Description|Unique identifier for Project Contract Line associated with Fact.|
|DisplayName|Project Contract Line|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_salescontractlineid|
|RequiredLevel|None|
|Targets|salesorderdetail|
|Type|Lookup|


### <a name="BKMK_msdyn_StartDate"></a> msdyn_StartDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the start date.|
|DisplayName|Start Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_startdate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_Task"></a> msdyn_Task

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Task|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_task|
|RequiredLevel|None|
|Targets|msdyn_projecttask|
|Type|Lookup|


### <a name="BKMK_msdyn_TransactionCategory"></a> msdyn_TransactionCategory

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Transaction Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategory|
|RequiredLevel|None|
|Targets|msdyn_transactioncategory|
|Type|Lookup|


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Transaction Classification|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactionclassification|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_TransactionClassification Options

|Value|Label|
|-----|-----|
|192350000|Time|
|192350001|Expense|
|192350002|Material|
|192350003|Milestone|
|192350004|Fee|
|690970000|Commission|
|690970001|Additional|
|690970002|Tax|



### <a name="BKMK_msdyn_VendorType"></a> msdyn_VendorType

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Vendor Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_vendortype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_VendorType Options

|Value|Label|
|-----|-----|
|192350001|Account|
|192350002|Contact|



### <a name="BKMK_OverriddenCreatedOn"></a> OverriddenCreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time that the record was migrated.|
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
|Description|Status of the Fact|
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
|Description|Reason for the status of the Fact|
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
|Description|Shows the currency associated with the entity.|
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
|Description|Time zone code that was in use when the record was created.|
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
- [msdyn_AccountCustomerName](#BKMK_msdyn_AccountCustomerName)
- [msdyn_AccountCustomerYomiName](#BKMK_msdyn_AccountCustomerYomiName)
- [msdyn_AccountVendorName](#BKMK_msdyn_AccountVendorName)
- [msdyn_AccountVendorYomiName](#BKMK_msdyn_AccountVendorYomiName)
- [msdyn_actchargeablebilledsalesamount_Base](#BKMK_msdyn_actchargeablebilledsalesamount_Base)
- [msdyn_actchargeablecostamount_Base](#BKMK_msdyn_actchargeablecostamount_Base)
- [msdyn_actchargeableunbilledsalesamount_Base](#BKMK_msdyn_actchargeableunbilledsalesamount_Base)
- [msdyn_actnochargebilledsalesamount_Base](#BKMK_msdyn_actnochargebilledsalesamount_Base)
- [msdyn_actnochargecostamount_Base](#BKMK_msdyn_actnochargecostamount_Base)
- [msdyn_actnochargeunbilledsalesamount_Base](#BKMK_msdyn_actnochargeunbilledsalesamount_Base)
- [msdyn_actnonchargeablecostamount_Base](#BKMK_msdyn_actnonchargeablecostamount_Base)
- [msdyn_actnonchargeableunbilledsalesamount_Base](#BKMK_msdyn_actnonchargeableunbilledsalesamount_Base)
- [msdyn_bookableresourceName](#BKMK_msdyn_bookableresourceName)
- [msdyn_ContactCustomerName](#BKMK_msdyn_ContactCustomerName)
- [msdyn_ContactCustomerYomiName](#BKMK_msdyn_ContactCustomerYomiName)
- [msdyn_ContactVendorName](#BKMK_msdyn_ContactVendorName)
- [msdyn_ContactVendorYomiName](#BKMK_msdyn_ContactVendorYomiName)
- [msdyn_earnedrevenue](#BKMK_msdyn_earnedrevenue)
- [msdyn_earnedrevenue_Base](#BKMK_msdyn_earnedrevenue_Base)
- [msdyn_estchargeablebilledsalesamount_Base](#BKMK_msdyn_estchargeablebilledsalesamount_Base)
- [msdyn_estchargeablecostamount_Base](#BKMK_msdyn_estchargeablecostamount_Base)
- [msdyn_estchargeableunbilledsalesamount_Base](#BKMK_msdyn_estchargeableunbilledsalesamount_Base)
- [msdyn_estimatelineidName](#BKMK_msdyn_estimatelineidName)
- [msdyn_EstimateName](#BKMK_msdyn_EstimateName)
- [msdyn_estnochargebilledsalesamount_Base](#BKMK_msdyn_estnochargebilledsalesamount_Base)
- [msdyn_estnochargecostamount_Base](#BKMK_msdyn_estnochargecostamount_Base)
- [msdyn_estnochargeunbilledsalesamount_Base](#BKMK_msdyn_estnochargeunbilledsalesamount_Base)
- [msdyn_estnonchargeablecostamount_Base](#BKMK_msdyn_estnonchargeablecostamount_Base)
- [msdyn_estnonchargeableunbilledsalesamount_Base](#BKMK_msdyn_estnonchargeableunbilledsalesamount_Base)
- [msdyn_grossmargin](#BKMK_msdyn_grossmargin)
- [msdyn_grossmargin_Base](#BKMK_msdyn_grossmargin_Base)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_ProjectName](#BKMK_msdyn_ProjectName)
- [msdyn_ResourceCategoryName](#BKMK_msdyn_ResourceCategoryName)
- [msdyn_SalesContractLineIdName](#BKMK_msdyn_SalesContractLineIdName)
- [msdyn_SalesContractName](#BKMK_msdyn_SalesContractName)
- [msdyn_TaskName](#BKMK_msdyn_TaskName)
- [msdyn_totalcost](#BKMK_msdyn_totalcost)
- [msdyn_totalcost_Base](#BKMK_msdyn_totalcost_Base)
- [msdyn_totalhours](#BKMK_msdyn_totalhours)
- [msdyn_TransactionCategoryName](#BKMK_msdyn_TransactionCategoryName)
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
|Description|Date and time when the record was created.|
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
|Description|Unique identifier of the delegate user who created the record.|
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
|Description|Exchange rate for the currency associated with the entity with respect to the base currency.|
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
|Description|Date and time when the record was modified.|
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
|Description|Unique identifier of the delegate user who modified the record.|
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


### <a name="BKMK_msdyn_AccountCustomerName"></a> msdyn_AccountCustomerName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_accountcustomername|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AccountCustomerYomiName"></a> msdyn_AccountCustomerYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_accountcustomeryominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AccountVendorName"></a> msdyn_AccountVendorName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_accountvendorname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_AccountVendorYomiName"></a> msdyn_AccountVendorYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_accountvendoryominame|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_actchargeablebilledsalesamount_Base"></a> msdyn_actchargeablebilledsalesamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Actual Chargeable Billed Sales Amount in base currency.|
|DisplayName|Actual Chargeable Billed Sales Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actchargeablebilledsalesamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_actchargeablecostamount_Base"></a> msdyn_actchargeablecostamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Actual Chargeable Cost Amount in base currency.|
|DisplayName|Actual Chargeable Cost Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actchargeablecostamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_actchargeableunbilledsalesamount_Base"></a> msdyn_actchargeableunbilledsalesamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Actual Chargeable Unbilled Sales Amount in base currency.|
|DisplayName|Actual Chargeable Unbilled Sales Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actchargeableunbilledsalesamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_actnochargebilledsalesamount_Base"></a> msdyn_actnochargebilledsalesamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Actual No Charge Billed Sales Amount in base currency.|
|DisplayName|Actual No Charge Billed Sales Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnochargebilledsalesamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_actnochargecostamount_Base"></a> msdyn_actnochargecostamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Actual No Charge Cost Amount in base currency.|
|DisplayName|Actual No Charge Cost Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnochargecostamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_actnochargeunbilledsalesamount_Base"></a> msdyn_actnochargeunbilledsalesamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Actual No Charge Unbilled Sales Amount in base currency.|
|DisplayName|Actual No Charge Unbilled Sales Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnochargeunbilledsalesamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_actnonchargeablecostamount_Base"></a> msdyn_actnonchargeablecostamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Actual Non Chargeable Cost Amount in base currency.|
|DisplayName|Actual Non Chargeable Cost Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnonchargeablecostamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_actnonchargeableunbilledsalesamount_Base"></a> msdyn_actnonchargeableunbilledsalesamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Actual Non Chargeable Unbilled Sales Amount in base currency.|
|DisplayName|Actual Non Chargeable Unbilled Sales Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_actnonchargeableunbilledsalesamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_bookableresourceName"></a> msdyn_bookableresourceName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_bookableresourcename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ContactCustomerName"></a> msdyn_ContactCustomerName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_contactcustomername|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ContactCustomerYomiName"></a> msdyn_ContactCustomerYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_contactcustomeryominame|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ContactVendorName"></a> msdyn_ContactVendorName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_contactvendorname|
|MaxLength|160|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ContactVendorYomiName"></a> msdyn_ContactVendorYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_contactvendoryominame|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_earnedrevenue"></a> msdyn_earnedrevenue

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Earned Revenue|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_earnedrevenue|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_earnedrevenue_Base"></a> msdyn_earnedrevenue_Base

|Property|Value|
|--------|-----|
|Description|Value of the Earned Revenue in base currency.|
|DisplayName|Earned Revenue (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_earnedrevenue_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estchargeablebilledsalesamount_Base"></a> msdyn_estchargeablebilledsalesamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimated Chargeable Billed Sales Amount in base currency.|
|DisplayName|Estimated Chargeable Billed Sales Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estchargeablebilledsalesamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estchargeablecostamount_Base"></a> msdyn_estchargeablecostamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimated Chargeable Cost Amount in base currency.|
|DisplayName|Estimated Chargeable Cost Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estchargeablecostamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estchargeableunbilledsalesamount_Base"></a> msdyn_estchargeableunbilledsalesamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimated Chargeable Unbilled Sales Amount in base currency.|
|DisplayName|Estimated Chargeable Unbilled Sales Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estchargeableunbilledsalesamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estimatelineidName"></a> msdyn_estimatelineidName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_estimatelineidname|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_EstimateName"></a> msdyn_EstimateName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_estimatename|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_estnochargebilledsalesamount_Base"></a> msdyn_estnochargebilledsalesamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimated No Charge Billed Sales Amount in base currency.|
|DisplayName|Estimated No Charge Billed Sales Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnochargebilledsalesamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estnochargecostamount_Base"></a> msdyn_estnochargecostamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimated No Charge Cost Amount in base currency.|
|DisplayName|Estimated No Charge Cost Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnochargecostamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estnochargeunbilledsalesamount_Base"></a> msdyn_estnochargeunbilledsalesamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimated No Charge Unbilled Sales Amount in base currency.|
|DisplayName|Estimated No Charge Unbilled Sales Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnochargeunbilledsalesamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estnonchargeablecostamount_Base"></a> msdyn_estnonchargeablecostamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimated Non Chargeable Cost Amount in base currency.|
|DisplayName|Estimated Non Chargeable Cost Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnonchargeablecostamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_estnonchargeableunbilledsalesamount_Base"></a> msdyn_estnonchargeableunbilledsalesamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Estimated Non Chargeable Unbilled Sales Amount in base currency.|
|DisplayName|Estimated Non Chargeable Unbilled Sales Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estnonchargeableunbilledsalesamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_grossmargin"></a> msdyn_grossmargin

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Gross Margin|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_grossmargin|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_grossmargin_Base"></a> msdyn_grossmargin_Base

|Property|Value|
|--------|-----|
|Description|Value of the Gross Margin in base currency.|
|DisplayName|Gross Margin (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_grossmargin_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


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


### <a name="BKMK_msdyn_ProjectName"></a> msdyn_ProjectName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_projectname|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_ResourceCategoryName"></a> msdyn_ResourceCategoryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecategoryname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SalesContractLineIdName"></a> msdyn_SalesContractLineIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_salescontractlineidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_SalesContractName"></a> msdyn_SalesContractName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_salescontractname|
|MaxLength|300|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_TaskName"></a> msdyn_TaskName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_taskname|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_totalcost"></a> msdyn_totalcost

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Total Cost|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalcost|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_totalcost_Base"></a> msdyn_totalcost_Base

|Property|Value|
|--------|-----|
|Description|Value of the Total Cost in base currency.|
|DisplayName|Total Cost (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalcost_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|2|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_totalhours"></a> msdyn_totalhours

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Total Hours|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_totalhours|
|MaxValue|100000000000|
|MinValue|-100000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_TransactionCategoryName"></a> msdyn_TransactionCategoryName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategoryname|
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

- [msdyn_fact_SyncErrors](#BKMK_msdyn_fact_SyncErrors)
- [msdyn_fact_DuplicateMatchingRecord](#BKMK_msdyn_fact_DuplicateMatchingRecord)
- [msdyn_fact_DuplicateBaseRecord](#BKMK_msdyn_fact_DuplicateBaseRecord)
- [msdyn_fact_AsyncOperations](#BKMK_msdyn_fact_AsyncOperations)
- [msdyn_fact_MailboxTrackingFolders](#BKMK_msdyn_fact_MailboxTrackingFolders)
- [msdyn_fact_ProcessSession](#BKMK_msdyn_fact_ProcessSession)
- [msdyn_fact_BulkDeleteFailures](#BKMK_msdyn_fact_BulkDeleteFailures)
- [msdyn_fact_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fact_PrincipalObjectAttributeAccesses)
- [msdyn_fact_Annotations](#BKMK_msdyn_fact_Annotations)


### <a name="BKMK_msdyn_fact_SyncErrors"></a> msdyn_fact_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_fact_SyncErrors](syncerror.md#BKMK_msdyn_fact_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fact_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fact_DuplicateMatchingRecord"></a> msdyn_fact_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_fact_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_fact_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fact_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fact_DuplicateBaseRecord"></a> msdyn_fact_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_fact_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_fact_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fact_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fact_AsyncOperations"></a> msdyn_fact_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_fact_AsyncOperations](asyncoperation.md#BKMK_msdyn_fact_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fact_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fact_MailboxTrackingFolders"></a> msdyn_fact_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_fact_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_fact_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fact_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fact_ProcessSession"></a> msdyn_fact_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_fact_ProcessSession](processsession.md#BKMK_msdyn_fact_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fact_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fact_BulkDeleteFailures"></a> msdyn_fact_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_fact_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_fact_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fact_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fact_PrincipalObjectAttributeAccesses"></a> msdyn_fact_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_fact_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_fact_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fact_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_fact_Annotations"></a> msdyn_fact_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_fact_Annotations](annotation.md#BKMK_msdyn_fact_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_fact_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_fact_createdby](#BKMK_lk_msdyn_fact_createdby)
- [lk_msdyn_fact_createdonbehalfby](#BKMK_lk_msdyn_fact_createdonbehalfby)
- [lk_msdyn_fact_modifiedby](#BKMK_lk_msdyn_fact_modifiedby)
- [lk_msdyn_fact_modifiedonbehalfby](#BKMK_lk_msdyn_fact_modifiedonbehalfby)
- [user_msdyn_fact](#BKMK_user_msdyn_fact)
- [team_msdyn_fact](#BKMK_team_msdyn_fact)
- [business_unit_msdyn_fact](#BKMK_business_unit_msdyn_fact)
- [TransactionCurrency_msdyn_fact](#BKMK_TransactionCurrency_msdyn_fact)
- [msdyn_account_msdyn_fact_AccountCustomer](#BKMK_msdyn_account_msdyn_fact_AccountCustomer)
- [msdyn_account_msdyn_fact_AccountVendor](#BKMK_msdyn_account_msdyn_fact_AccountVendor)
- [msdyn_bookableresource_msdyn_fact_bookableresource](#BKMK_msdyn_bookableresource_msdyn_fact_bookableresource)
- [msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory)
- [msdyn_contact_msdyn_fact_ContactCustomer](#BKMK_msdyn_contact_msdyn_fact_ContactCustomer)
- [msdyn_contact_msdyn_fact_ContactVendor](#BKMK_msdyn_contact_msdyn_fact_ContactVendor)
- [msdyn_msdyn_estimate_msdyn_fact_Estimate](#BKMK_msdyn_msdyn_estimate_msdyn_fact_Estimate)
- [msdyn_msdyn_estimateline_msdyn_fact_estimatelineid](#BKMK_msdyn_msdyn_estimateline_msdyn_fact_estimatelineid)
- [msdyn_msdyn_project_msdyn_fact_Project](#BKMK_msdyn_msdyn_project_msdyn_fact_Project)
- [msdyn_msdyn_projecttask_msdyn_fact_Task](#BKMK_msdyn_msdyn_projecttask_msdyn_fact_Task)
- [msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory)
- [msdyn_product_msdyn_fact_Product](#BKMK_msdyn_product_msdyn_fact_Product)
- [msdyn_salesorder_msdyn_fact_SalesContract](#BKMK_msdyn_salesorder_msdyn_fact_SalesContract)
- [msdyn_salesorderdetail_msdyn_fact](#BKMK_msdyn_salesorderdetail_msdyn_fact)


### <a name="BKMK_lk_msdyn_fact_createdby"></a> lk_msdyn_fact_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fact_createdby](systemuser.md#BKMK_lk_msdyn_fact_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fact_createdonbehalfby"></a> lk_msdyn_fact_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fact_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_fact_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fact_modifiedby"></a> lk_msdyn_fact_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fact_modifiedby](systemuser.md#BKMK_lk_msdyn_fact_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_fact_modifiedonbehalfby"></a> lk_msdyn_fact_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_fact_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_fact_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_fact"></a> user_msdyn_fact

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_fact](systemuser.md#BKMK_user_msdyn_fact) One-To-Many relationship.

### <a name="BKMK_team_msdyn_fact"></a> team_msdyn_fact

**Added by**: System Solution Solution

See team Entity [team_msdyn_fact](team.md#BKMK_team_msdyn_fact) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_fact"></a> business_unit_msdyn_fact

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_fact](businessunit.md#BKMK_business_unit_msdyn_fact) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_fact"></a> TransactionCurrency_msdyn_fact

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_fact](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_fact) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_fact_AccountCustomer"></a> msdyn_account_msdyn_fact_AccountCustomer

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_fact_AccountCustomer](account.md#BKMK_msdyn_account_msdyn_fact_AccountCustomer) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_fact_AccountVendor"></a> msdyn_account_msdyn_fact_AccountVendor

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_fact_AccountVendor](account.md#BKMK_msdyn_account_msdyn_fact_AccountVendor) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_fact_bookableresource"></a> msdyn_bookableresource_msdyn_fact_bookableresource

**Added by**: Scheduling Solution

See bookableresource Entity [msdyn_bookableresource_msdyn_fact_bookableresource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_fact_bookableresource) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory

**Added by**: Scheduling Solution

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_fact_ContactCustomer"></a> msdyn_contact_msdyn_fact_ContactCustomer

**Added by**: System Solution Solution

See contact Entity [msdyn_contact_msdyn_fact_ContactCustomer](contact.md#BKMK_msdyn_contact_msdyn_fact_ContactCustomer) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_fact_ContactVendor"></a> msdyn_contact_msdyn_fact_ContactVendor

**Added by**: System Solution Solution

See contact Entity [msdyn_contact_msdyn_fact_ContactVendor](contact.md#BKMK_msdyn_contact_msdyn_fact_ContactVendor) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_estimate_msdyn_fact_Estimate"></a> msdyn_msdyn_estimate_msdyn_fact_Estimate

See msdyn_estimate Entity [msdyn_msdyn_estimate_msdyn_fact_Estimate](msdyn_estimate.md#BKMK_msdyn_msdyn_estimate_msdyn_fact_Estimate) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_estimateline_msdyn_fact_estimatelineid"></a> msdyn_msdyn_estimateline_msdyn_fact_estimatelineid

See msdyn_estimateline Entity [msdyn_msdyn_estimateline_msdyn_fact_estimatelineid](msdyn_estimateline.md#BKMK_msdyn_msdyn_estimateline_msdyn_fact_estimatelineid) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_msdyn_fact_Project"></a> msdyn_msdyn_project_msdyn_fact_Project

See msdyn_project Entity [msdyn_msdyn_project_msdyn_fact_Project](msdyn_project.md#BKMK_msdyn_msdyn_project_msdyn_fact_Project) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projecttask_msdyn_fact_Task"></a> msdyn_msdyn_projecttask_msdyn_fact_Task

See msdyn_projecttask Entity [msdyn_msdyn_projecttask_msdyn_fact_Task](msdyn_projecttask.md#BKMK_msdyn_msdyn_projecttask_msdyn_fact_Task) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_fact_Product"></a> msdyn_product_msdyn_fact_Product

**Added by**: Product Management Solution

See product Entity [msdyn_product_msdyn_fact_Product](product.md#BKMK_msdyn_product_msdyn_fact_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_salesorder_msdyn_fact_SalesContract"></a> msdyn_salesorder_msdyn_fact_SalesContract

**Added by**: Sales Solution

See salesorder Entity [msdyn_salesorder_msdyn_fact_SalesContract](salesorder.md#BKMK_msdyn_salesorder_msdyn_fact_SalesContract) One-To-Many relationship.

### <a name="BKMK_msdyn_salesorderdetail_msdyn_fact"></a> msdyn_salesorderdetail_msdyn_fact

**Added by**: Sales Solution

See salesorderdetail Entity [msdyn_salesorderdetail_msdyn_fact](salesorderdetail.md#BKMK_msdyn_salesorderdetail_msdyn_fact) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_fact?text=msdyn_fact EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]