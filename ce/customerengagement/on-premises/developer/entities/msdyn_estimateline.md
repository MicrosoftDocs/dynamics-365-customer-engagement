---
title: "msdyn_estimateline Entity Reference (Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the msdyn_estimateline entity."
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
# msdyn_estimateline Entity Reference

Estimates on a per day timescale.

**Added by**: Project Service Automation Solution


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Assign|PATCH [*org URI*]/api/data/v9.0/msdyn_estimatelines(*msdyn_estimatelineid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `ownerid` property.|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|POST [*org URI*]/api/data/v9.0/msdyn_estimatelines<br />See [Create](/powerapps/developer/common-data-service/webapi/create-entity-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/msdyn_estimatelines(*msdyn_estimatelineid*)<br />See [Delete](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref href="Microsoft.Dynamics.CRM.GrantAccess?text=GrantAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|IsValidStateTransition|<xref href="Microsoft.Dynamics.CRM.IsValidStateTransition?text=IsValidStateTransition Function" />|<xref:Microsoft.Crm.Sdk.Messages.IsValidStateTransitionRequest>|
|ModifyAccess|<xref href="Microsoft.Dynamics.CRM.ModifyAccess?text=ModifyAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|GET [*org URI*]/api/data/v9.0/msdyn_estimatelines(*msdyn_estimatelineid*)<br />See [Retrieve](/powerapps/developer/common-data-service/webapi/retrieve-entity-using-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/msdyn_estimatelines<br />See [Query Data](/powerapps/developer/common-data-service/webapi/query-data-web-api)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref href="Microsoft.Dynamics.CRM.RetrievePrincipalAccess?text=RetrievePrincipalAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref href="Microsoft.Dynamics.CRM.RetrieveSharedPrincipalsAndAccess?text=RetrieveSharedPrincipalsAndAccess Function" />|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref href="Microsoft.Dynamics.CRM.RevokeAccess?text=RevokeAccess Action" />|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|PATCH [*org URI*]/api/data/v9.0/msdyn_estimatelines(*msdyn_estimatelineid*)<br />[Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update) `statecode` and `statuscode` properties.|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|PATCH [*org URI*]/api/data/v9.0/msdyn_estimatelines(*msdyn_estimatelineid*)<br />See [Update](/powerapps/developer/common-data-service/webapi/update-delete-entities-using-web-api#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|msdyn_estimatelines|
|DisplayCollectionName|Estimate Lines|
|DisplayName|Estimate Line|
|EntitySetName|msdyn_estimatelines|
|IsBPFEntity|False|
|LogicalCollectionName|msdyn_estimatelines|
|LogicalName|msdyn_estimateline|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|msdyn_estimatelineid|
|PrimaryNameAttribute|msdyn_description|
|SchemaName|msdyn_estimateline|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ImportSequenceNumber](#BKMK_ImportSequenceNumber)
- [msdyn_AccountCustomer](#BKMK_msdyn_AccountCustomer)
- [msdyn_AccountingDate](#BKMK_msdyn_AccountingDate)
- [msdyn_AccountVendor](#BKMK_msdyn_AccountVendor)
- [msdyn_Amount](#BKMK_msdyn_Amount)
- [msdyn_AmountMethod](#BKMK_msdyn_AmountMethod)
- [msdyn_BasisAmount](#BKMK_msdyn_BasisAmount)
- [msdyn_BasisPrice](#BKMK_msdyn_BasisPrice)
- [msdyn_BasisQuantity](#BKMK_msdyn_BasisQuantity)
- [msdyn_BillingType](#BKMK_msdyn_BillingType)
- [msdyn_bookableresource](#BKMK_msdyn_bookableresource)
- [msdyn_ContactCustomer](#BKMK_msdyn_ContactCustomer)
- [msdyn_ContactVendor](#BKMK_msdyn_ContactVendor)
- [msdyn_CustomerType](#BKMK_msdyn_CustomerType)
- [msdyn_description](#BKMK_msdyn_description)
- [msdyn_DocumentDate](#BKMK_msdyn_DocumentDate)
- [msdyn_EndDateTime](#BKMK_msdyn_EndDateTime)
- [msdyn_Estimate](#BKMK_msdyn_Estimate)
- [msdyn_estimatelineId](#BKMK_msdyn_estimatelineId)
- [msdyn_estimateperdaylines](#BKMK_msdyn_estimateperdaylines)
- [msdyn_ExchangeRateDate](#BKMK_msdyn_ExchangeRateDate)
- [msdyn_numberofresources](#BKMK_msdyn_numberofresources)
- [msdyn_Percent](#BKMK_msdyn_Percent)
- [msdyn_Price](#BKMK_msdyn_Price)
- [msdyn_PriceList](#BKMK_msdyn_PriceList)
- [msdyn_Product](#BKMK_msdyn_Product)
- [msdyn_Project](#BKMK_msdyn_Project)
- [msdyn_Quantity](#BKMK_msdyn_Quantity)
- [msdyn_ResourceCategory](#BKMK_msdyn_ResourceCategory)
- [msdyn_ResourceOrganizationalUnitId](#BKMK_msdyn_ResourceOrganizationalUnitId)
- [msdyn_StartDateTime](#BKMK_msdyn_StartDateTime)
- [msdyn_Task](#BKMK_msdyn_Task)
- [msdyn_TransactionCategory](#BKMK_msdyn_TransactionCategory)
- [msdyn_TransactionClassification](#BKMK_msdyn_TransactionClassification)
- [msdyn_TransactionTypeCode](#BKMK_msdyn_TransactionTypeCode)
- [msdyn_Unit](#BKMK_msdyn_Unit)
- [msdyn_UnitSchedule](#BKMK_msdyn_UnitSchedule)
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
|Description|Shows the customer for the estimate line.|
|DisplayName|Customer|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_accountcustomer|
|RequiredLevel|None|
|Targets|account|
|Type|Lookup|


### <a name="BKMK_msdyn_AccountingDate"></a> msdyn_AccountingDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName|Accounting Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_accountingdate|
|RequiredLevel|None|
|Type|DateTime|


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


### <a name="BKMK_msdyn_Amount"></a> msdyn_Amount

|Property|Value|
|--------|-----|
|Description|Shows the amount on the estimate line.|
|DisplayName|Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amount|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_AmountMethod"></a> msdyn_AmountMethod

|Property|Value|
|--------|-----|
|Description|Shows the calculation method used to determine the amount on the estimate line. |
|DisplayName|Amount Method|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amountmethod|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_AmountMethod Options

|Value|Label|
|-----|-----|
|192350000|Multiply Quantity By Price|
|192350001|Fixed Price|
|192350002|Multiply Basis Quantity By Price|
|192350003|Multiply Basis Amount By Percent|
|690970000|Tax Calculation|



### <a name="BKMK_msdyn_BasisAmount"></a> msdyn_BasisAmount

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Basis Amount|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_basisamount|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_BasisPrice"></a> msdyn_BasisPrice

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Basis Price|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_basisprice|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_BasisQuantity"></a> msdyn_BasisQuantity

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Basis Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_basisquantity|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_BillingType"></a> msdyn_BillingType

|Property|Value|
|--------|-----|
|Description|Shows whether this estimate line is charged to the customer. |
|DisplayName|Billing Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_billingtype|
|RequiredLevel|None|
|Type|Picklist|

#### msdyn_BillingType Options

|Value|Label|
|-----|-----|
|192350000|Non Chargeable|
|192350001|Chargeable|
|192350002|Complimentary|
|192350003|Not Available|



### <a name="BKMK_msdyn_bookableresource"></a> msdyn_bookableresource

|Property|Value|
|--------|-----|
|Description|Shows the bookable resource for which estimates are generated.|
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
|Description|Shows the name of the customer contact.|
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
|Description|Select the type of customer.|
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



### <a name="BKMK_msdyn_description"></a> msdyn_description

|Property|Value|
|--------|-----|
|Description|Type the name of the custom entity.|
|DisplayName|Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_description|
|MaxLength|450|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_msdyn_DocumentDate"></a> msdyn_DocumentDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the transaction date of the estimate line.|
|DisplayName|Document Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_documentdate|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_msdyn_EndDateTime"></a> msdyn_EndDateTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Enter the end date and time.|
|DisplayName|End Date/Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_enddatetime|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_msdyn_Estimate"></a> msdyn_Estimate

|Property|Value|
|--------|-----|
|Description|Shows the name of the estimate line.|
|DisplayName|Estimate|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimate|
|RequiredLevel|ApplicationRequired|
|Targets|msdyn_estimate|
|Type|Lookup|


### <a name="BKMK_msdyn_estimatelineId"></a> msdyn_estimatelineId

|Property|Value|
|--------|-----|
|Description|Shows the entity instances.|
|DisplayName|Estimate Line|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|msdyn_estimatelineid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_msdyn_estimateperdaylines"></a> msdyn_estimateperdaylines

|Property|Value|
|--------|-----|
|Description|Stores the estimate per day detail lines.|
|DisplayName|Estimate Per Day Lines|
|Format|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_estimateperdaylines|
|MaxLength|1048576|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_msdyn_ExchangeRateDate"></a> msdyn_ExchangeRateDate

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description||
|DisplayName|Exchange Rate Date|
|Format|DateOnly|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_exchangeratedate|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_msdyn_numberofresources"></a> msdyn_numberofresources

|Property|Value|
|--------|-----|
|Description|Shows the estimate of the number of resources intended to be staffed for this task.|
|DisplayName|Number of resources|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_numberofresources|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_msdyn_Percent"></a> msdyn_Percent

|Property|Value|
|--------|-----|
|Description|Shows the percent for the estimate line.|
|DisplayName|Percent|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_percent|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_Price"></a> msdyn_Price

|Property|Value|
|--------|-----|
|Description|Shows the price for this estimate line.|
|DisplayName|Price|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_price|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_PriceList"></a> msdyn_PriceList

|Property|Value|
|--------|-----|
|Description|Shows the price list used in this estimate line.|
|DisplayName|Price List|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_pricelist|
|RequiredLevel|None|
|Targets|pricelevel|
|Type|Lookup|


### <a name="BKMK_msdyn_Product"></a> msdyn_Product

|Property|Value|
|--------|-----|
|Description|Select the product.|
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
|Description|Shows the project for this estimate line.|
|DisplayName|Project|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_project|
|RequiredLevel|None|
|Targets|msdyn_project|
|Type|Lookup|


### <a name="BKMK_msdyn_Quantity"></a> msdyn_Quantity

|Property|Value|
|--------|-----|
|Description|Enter the estimated quantity of work, cost, and sales.|
|DisplayName|Quantity|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_quantity|
|MaxValue|1000000000|
|MinValue|-1000000000|
|Precision|2|
|RequiredLevel|None|
|Type|Decimal|


### <a name="BKMK_msdyn_ResourceCategory"></a> msdyn_ResourceCategory

|Property|Value|
|--------|-----|
|Description|Shows the role of this resource on the estimate line.|
|DisplayName|Role|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourcecategory|
|RequiredLevel|None|
|Targets|bookableresourcecategory|
|Type|Lookup|


### <a name="BKMK_msdyn_ResourceOrganizationalUnitId"></a> msdyn_ResourceOrganizationalUnitId

|Property|Value|
|--------|-----|
|Description|Select the organizational unit at the time the estimate line was registered of the resource who should perform the work.|
|DisplayName|Resourcing Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_resourceorganizationalunitid|
|RequiredLevel|Recommended|
|Targets|msdyn_organizationalunit|
|Type|Lookup|


### <a name="BKMK_msdyn_StartDateTime"></a> msdyn_StartDateTime

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Shows the start date and time for the task for this estimate line.|
|DisplayName|Start Date/Time|
|Format|DateAndTime|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_startdatetime|
|RequiredLevel|ApplicationRequired|
|Type|DateTime|


### <a name="BKMK_msdyn_Task"></a> msdyn_Task

|Property|Value|
|--------|-----|
|Description|Shows the task related to this estimate line.|
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
|Description|Select the type of transaction.|
|DisplayName|Category|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactioncategory|
|RequiredLevel|None|
|Targets|msdyn_transactioncategory|
|Type|Lookup|


### <a name="BKMK_msdyn_TransactionClassification"></a> msdyn_TransactionClassification

|Property|Value|
|--------|-----|
|Description|Shows the transaction classification for this estimate line.|
|DisplayName|Transaction Class|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactionclassification|
|RequiredLevel|ApplicationRequired|
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



### <a name="BKMK_msdyn_TransactionTypeCode"></a> msdyn_TransactionTypeCode

|Property|Value|
|--------|-----|
|Description|Shows the transaction type for this estimate line.|
|DisplayName|Transaction Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_transactiontypecode|
|RequiredLevel|ApplicationRequired|
|Type|Picklist|

#### msdyn_TransactionTypeCode Options

|Value|Label|
|-----|-----|
|192350000|Cost|
|192350004|Project Contract|
|192350005|Unbilled Sales|
|192350006|Billed Sales|
|192350007|Resourcing Unit Cost|
|192350008|Inter-Organizational Sales|



### <a name="BKMK_msdyn_Unit"></a> msdyn_Unit

|Property|Value|
|--------|-----|
|Description|Shows the unit of measurement for this estimate line.|
|DisplayName|Unit|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unit|
|RequiredLevel|None|
|Targets|uom|
|Type|Lookup|


### <a name="BKMK_msdyn_UnitSchedule"></a> msdyn_UnitSchedule

|Property|Value|
|--------|-----|
|Description|Select the unit of measure for the estimate quantity.|
|DisplayName|Unit Schedule|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_unitschedule|
|RequiredLevel|None|
|Targets|uomschedule|
|Type|Lookup|


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
|Description|Status of the Estimate Line|
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
|Description|Reason for the status of the Estimate Line|
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
- [msdyn_amount_Base](#BKMK_msdyn_amount_Base)
- [msdyn_basisamount_Base](#BKMK_msdyn_basisamount_Base)
- [msdyn_basisprice_Base](#BKMK_msdyn_basisprice_Base)
- [msdyn_bookableresourceName](#BKMK_msdyn_bookableresourceName)
- [msdyn_ContactCustomerName](#BKMK_msdyn_ContactCustomerName)
- [msdyn_ContactCustomerYomiName](#BKMK_msdyn_ContactCustomerYomiName)
- [msdyn_ContactVendorName](#BKMK_msdyn_ContactVendorName)
- [msdyn_ContactVendorYomiName](#BKMK_msdyn_ContactVendorYomiName)
- [msdyn_EstimateName](#BKMK_msdyn_EstimateName)
- [msdyn_price_Base](#BKMK_msdyn_price_Base)
- [msdyn_PriceListName](#BKMK_msdyn_PriceListName)
- [msdyn_ProductName](#BKMK_msdyn_ProductName)
- [msdyn_ProjectName](#BKMK_msdyn_ProjectName)
- [msdyn_ResourceCategoryName](#BKMK_msdyn_ResourceCategoryName)
- [msdyn_ResourceOrganizationalUnitIdName](#BKMK_msdyn_ResourceOrganizationalUnitIdName)
- [msdyn_TaskName](#BKMK_msdyn_TaskName)
- [msdyn_TransactionCategoryName](#BKMK_msdyn_TransactionCategoryName)
- [msdyn_UnitName](#BKMK_msdyn_UnitName)
- [msdyn_UnitScheduleName](#BKMK_msdyn_UnitScheduleName)
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


### <a name="BKMK_msdyn_amount_Base"></a> msdyn_amount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Amount in base currency.|
|DisplayName|Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_amount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_basisamount_Base"></a> msdyn_basisamount_Base

|Property|Value|
|--------|-----|
|Description|Value of the Basis Amount in base currency.|
|DisplayName|Basis Amount (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_basisamount_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
|RequiredLevel|None|
|Type|Money|


### <a name="BKMK_msdyn_basisprice_Base"></a> msdyn_basisprice_Base

|Property|Value|
|--------|-----|
|Description|Value of the Basis Price in base currency.|
|DisplayName|Basis Price (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_basisprice_base|
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


### <a name="BKMK_msdyn_price_Base"></a> msdyn_price_Base

|Property|Value|
|--------|-----|
|Description|Value of the Price in base currency.|
|DisplayName|Price (Base)|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|msdyn_price_base|
|MaxValue|922337203685477|
|MinValue|-922337203685477|
|Precision|4|
|PrecisionSource|2|
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


### <a name="BKMK_msdyn_ResourceOrganizationalUnitIdName"></a> msdyn_ResourceOrganizationalUnitIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_resourceorganizationalunitidname|
|MaxLength|100|
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


### <a name="BKMK_msdyn_UnitScheduleName"></a> msdyn_UnitScheduleName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|msdyn_unitschedulename|
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

- [msdyn_estimateline_SyncErrors](#BKMK_msdyn_estimateline_SyncErrors)
- [msdyn_estimateline_DuplicateMatchingRecord](#BKMK_msdyn_estimateline_DuplicateMatchingRecord)
- [msdyn_estimateline_DuplicateBaseRecord](#BKMK_msdyn_estimateline_DuplicateBaseRecord)
- [msdyn_estimateline_AsyncOperations](#BKMK_msdyn_estimateline_AsyncOperations)
- [msdyn_estimateline_MailboxTrackingFolders](#BKMK_msdyn_estimateline_MailboxTrackingFolders)
- [msdyn_estimateline_ProcessSession](#BKMK_msdyn_estimateline_ProcessSession)
- [msdyn_estimateline_BulkDeleteFailures](#BKMK_msdyn_estimateline_BulkDeleteFailures)
- [msdyn_estimateline_PrincipalObjectAttributeAccesses](#BKMK_msdyn_estimateline_PrincipalObjectAttributeAccesses)
- [msdyn_estimateline_Annotations](#BKMK_msdyn_estimateline_Annotations)
- [msdyn_msdyn_estimateline_msdyn_fact_estimatelineid](#BKMK_msdyn_msdyn_estimateline_msdyn_fact_estimatelineid)


### <a name="BKMK_msdyn_estimateline_SyncErrors"></a> msdyn_estimateline_SyncErrors

**Added by**: System Solution Solution

Same as syncerror entity [msdyn_estimateline_SyncErrors](syncerror.md#BKMK_msdyn_estimateline_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_estimateline_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_estimateline_DuplicateMatchingRecord"></a> msdyn_estimateline_DuplicateMatchingRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_estimateline_DuplicateMatchingRecord](duplicaterecord.md#BKMK_msdyn_estimateline_DuplicateMatchingRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|duplicaterecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_estimateline_DuplicateMatchingRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_estimateline_DuplicateBaseRecord"></a> msdyn_estimateline_DuplicateBaseRecord

**Added by**: System Solution Solution

Same as duplicaterecord entity [msdyn_estimateline_DuplicateBaseRecord](duplicaterecord.md#BKMK_msdyn_estimateline_DuplicateBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|duplicaterecord|
|ReferencingAttribute|baserecordid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_estimateline_DuplicateBaseRecord|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_estimateline_AsyncOperations"></a> msdyn_estimateline_AsyncOperations

**Added by**: System Solution Solution

Same as asyncoperation entity [msdyn_estimateline_AsyncOperations](asyncoperation.md#BKMK_msdyn_estimateline_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_estimateline_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_estimateline_MailboxTrackingFolders"></a> msdyn_estimateline_MailboxTrackingFolders

**Added by**: System Solution Solution

Same as mailboxtrackingfolder entity [msdyn_estimateline_MailboxTrackingFolders](mailboxtrackingfolder.md#BKMK_msdyn_estimateline_MailboxTrackingFolders) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_estimateline_MailboxTrackingFolders|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_estimateline_ProcessSession"></a> msdyn_estimateline_ProcessSession

**Added by**: System Solution Solution

Same as processsession entity [msdyn_estimateline_ProcessSession](processsession.md#BKMK_msdyn_estimateline_ProcessSession) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|processsession|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_estimateline_ProcessSession|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_estimateline_BulkDeleteFailures"></a> msdyn_estimateline_BulkDeleteFailures

**Added by**: System Solution Solution

Same as bulkdeletefailure entity [msdyn_estimateline_BulkDeleteFailures](bulkdeletefailure.md#BKMK_msdyn_estimateline_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_estimateline_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_estimateline_PrincipalObjectAttributeAccesses"></a> msdyn_estimateline_PrincipalObjectAttributeAccesses

**Added by**: System Solution Solution

Same as principalobjectattributeaccess entity [msdyn_estimateline_PrincipalObjectAttributeAccesses](principalobjectattributeaccess.md#BKMK_msdyn_estimateline_PrincipalObjectAttributeAccesses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_estimateline_PrincipalObjectAttributeAccesses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_msdyn_estimateline_Annotations"></a> msdyn_estimateline_Annotations

**Added by**: System Solution Solution

Same as annotation entity [msdyn_estimateline_Annotations](annotation.md#BKMK_msdyn_estimateline_Annotations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|annotation|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_estimateline_Annotations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_msdyn_msdyn_estimateline_msdyn_fact_estimatelineid"></a> msdyn_msdyn_estimateline_msdyn_fact_estimatelineid

Same as msdyn_fact entity [msdyn_msdyn_estimateline_msdyn_fact_estimatelineid](msdyn_fact.md#BKMK_msdyn_msdyn_estimateline_msdyn_fact_estimatelineid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fact|
|ReferencingAttribute|msdyn_estimatelineid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|msdyn_msdyn_estimateline_msdyn_fact_estimatelineid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: 10000|
|CascadeConfiguration|Assign: Cascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_msdyn_estimateline_createdby](#BKMK_lk_msdyn_estimateline_createdby)
- [lk_msdyn_estimateline_createdonbehalfby](#BKMK_lk_msdyn_estimateline_createdonbehalfby)
- [lk_msdyn_estimateline_modifiedby](#BKMK_lk_msdyn_estimateline_modifiedby)
- [lk_msdyn_estimateline_modifiedonbehalfby](#BKMK_lk_msdyn_estimateline_modifiedonbehalfby)
- [user_msdyn_estimateline](#BKMK_user_msdyn_estimateline)
- [team_msdyn_estimateline](#BKMK_team_msdyn_estimateline)
- [business_unit_msdyn_estimateline](#BKMK_business_unit_msdyn_estimateline)
- [TransactionCurrency_msdyn_estimateline](#BKMK_TransactionCurrency_msdyn_estimateline)
- [msdyn_account_msdyn_estimateline_AccountCustomer](#BKMK_msdyn_account_msdyn_estimateline_AccountCustomer)
- [msdyn_account_msdyn_estimateline_AccountVendor](#BKMK_msdyn_account_msdyn_estimateline_AccountVendor)
- [msdyn_bookableresource_msdyn_estimateline_bookableresource](#BKMK_msdyn_bookableresource_msdyn_estimateline_bookableresource)
- [msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory](#BKMK_msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory)
- [msdyn_contact_msdyn_estimateline_ContactCustomer](#BKMK_msdyn_contact_msdyn_estimateline_ContactCustomer)
- [msdyn_contact_msdyn_estimateline_ContactVendor](#BKMK_msdyn_contact_msdyn_estimateline_ContactVendor)
- [msdyn_msdyn_estimate_msdyn_estimateline_Estimate](#BKMK_msdyn_msdyn_estimate_msdyn_estimateline_Estimate)
- [msdyn_msdyn_project_msdyn_estimateline_Project](#BKMK_msdyn_msdyn_project_msdyn_estimateline_Project)
- [msdyn_msdyn_projecttask_msdyn_estimateline_Task](#BKMK_msdyn_msdyn_projecttask_msdyn_estimateline_Task)
- [msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory](#BKMK_msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory)
- [msdyn_organizationalunit_estimateline](#BKMK_msdyn_organizationalunit_estimateline)
- [msdyn_pricelevel_msdyn_estimateline_PriceList](#BKMK_msdyn_pricelevel_msdyn_estimateline_PriceList)
- [msdyn_product_msdyn_estimateline_Product](#BKMK_msdyn_product_msdyn_estimateline_Product)
- [msdyn_uom_msdyn_estimateline_Unit](#BKMK_msdyn_uom_msdyn_estimateline_Unit)
- [msdyn_uomschedule_msdyn_estimateline_UnitSchedule](#BKMK_msdyn_uomschedule_msdyn_estimateline_UnitSchedule)


### <a name="BKMK_lk_msdyn_estimateline_createdby"></a> lk_msdyn_estimateline_createdby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_estimateline_createdby](systemuser.md#BKMK_lk_msdyn_estimateline_createdby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_estimateline_createdonbehalfby"></a> lk_msdyn_estimateline_createdonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_estimateline_createdonbehalfby](systemuser.md#BKMK_lk_msdyn_estimateline_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_estimateline_modifiedby"></a> lk_msdyn_estimateline_modifiedby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_estimateline_modifiedby](systemuser.md#BKMK_lk_msdyn_estimateline_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_msdyn_estimateline_modifiedonbehalfby"></a> lk_msdyn_estimateline_modifiedonbehalfby

**Added by**: System Solution Solution

See systemuser Entity [lk_msdyn_estimateline_modifiedonbehalfby](systemuser.md#BKMK_lk_msdyn_estimateline_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_user_msdyn_estimateline"></a> user_msdyn_estimateline

**Added by**: System Solution Solution

See systemuser Entity [user_msdyn_estimateline](systemuser.md#BKMK_user_msdyn_estimateline) One-To-Many relationship.

### <a name="BKMK_team_msdyn_estimateline"></a> team_msdyn_estimateline

**Added by**: System Solution Solution

See team Entity [team_msdyn_estimateline](team.md#BKMK_team_msdyn_estimateline) One-To-Many relationship.

### <a name="BKMK_business_unit_msdyn_estimateline"></a> business_unit_msdyn_estimateline

**Added by**: System Solution Solution

See businessunit Entity [business_unit_msdyn_estimateline](businessunit.md#BKMK_business_unit_msdyn_estimateline) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_msdyn_estimateline"></a> TransactionCurrency_msdyn_estimateline

**Added by**: System Solution Solution

See transactioncurrency Entity [TransactionCurrency_msdyn_estimateline](transactioncurrency.md#BKMK_TransactionCurrency_msdyn_estimateline) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_estimateline_AccountCustomer"></a> msdyn_account_msdyn_estimateline_AccountCustomer

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_estimateline_AccountCustomer](account.md#BKMK_msdyn_account_msdyn_estimateline_AccountCustomer) One-To-Many relationship.

### <a name="BKMK_msdyn_account_msdyn_estimateline_AccountVendor"></a> msdyn_account_msdyn_estimateline_AccountVendor

**Added by**: System Solution Solution

See account Entity [msdyn_account_msdyn_estimateline_AccountVendor](account.md#BKMK_msdyn_account_msdyn_estimateline_AccountVendor) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresource_msdyn_estimateline_bookableresource"></a> msdyn_bookableresource_msdyn_estimateline_bookableresource

**Added by**: Scheduling Solution

See bookableresource Entity [msdyn_bookableresource_msdyn_estimateline_bookableresource](bookableresource.md#BKMK_msdyn_bookableresource_msdyn_estimateline_bookableresource) One-To-Many relationship.

### <a name="BKMK_msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory"></a> msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory

**Added by**: Scheduling Solution

See bookableresourcecategory Entity [msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory](bookableresourcecategory.md#BKMK_msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_estimateline_ContactCustomer"></a> msdyn_contact_msdyn_estimateline_ContactCustomer

**Added by**: System Solution Solution

See contact Entity [msdyn_contact_msdyn_estimateline_ContactCustomer](contact.md#BKMK_msdyn_contact_msdyn_estimateline_ContactCustomer) One-To-Many relationship.

### <a name="BKMK_msdyn_contact_msdyn_estimateline_ContactVendor"></a> msdyn_contact_msdyn_estimateline_ContactVendor

**Added by**: System Solution Solution

See contact Entity [msdyn_contact_msdyn_estimateline_ContactVendor](contact.md#BKMK_msdyn_contact_msdyn_estimateline_ContactVendor) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_estimate_msdyn_estimateline_Estimate"></a> msdyn_msdyn_estimate_msdyn_estimateline_Estimate

See msdyn_estimate Entity [msdyn_msdyn_estimate_msdyn_estimateline_Estimate](msdyn_estimate.md#BKMK_msdyn_msdyn_estimate_msdyn_estimateline_Estimate) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_project_msdyn_estimateline_Project"></a> msdyn_msdyn_project_msdyn_estimateline_Project

See msdyn_project Entity [msdyn_msdyn_project_msdyn_estimateline_Project](msdyn_project.md#BKMK_msdyn_msdyn_project_msdyn_estimateline_Project) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_projecttask_msdyn_estimateline_Task"></a> msdyn_msdyn_projecttask_msdyn_estimateline_Task

See msdyn_projecttask Entity [msdyn_msdyn_projecttask_msdyn_estimateline_Task](msdyn_projecttask.md#BKMK_msdyn_msdyn_projecttask_msdyn_estimateline_Task) One-To-Many relationship.

### <a name="BKMK_msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory"></a> msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory

See msdyn_transactioncategory Entity [msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory](msdyn_transactioncategory.md#BKMK_msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_estimateline"></a> msdyn_organizationalunit_estimateline

**Added by**: Universal Resource Scheduling Solution

See msdyn_organizationalunit Entity [msdyn_organizationalunit_estimateline](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_estimateline) One-To-Many relationship.

### <a name="BKMK_msdyn_pricelevel_msdyn_estimateline_PriceList"></a> msdyn_pricelevel_msdyn_estimateline_PriceList

**Added by**: Product Management Solution

See pricelevel Entity [msdyn_pricelevel_msdyn_estimateline_PriceList](pricelevel.md#BKMK_msdyn_pricelevel_msdyn_estimateline_PriceList) One-To-Many relationship.

### <a name="BKMK_msdyn_product_msdyn_estimateline_Product"></a> msdyn_product_msdyn_estimateline_Product

**Added by**: Product Management Solution

See product Entity [msdyn_product_msdyn_estimateline_Product](product.md#BKMK_msdyn_product_msdyn_estimateline_Product) One-To-Many relationship.

### <a name="BKMK_msdyn_uom_msdyn_estimateline_Unit"></a> msdyn_uom_msdyn_estimateline_Unit

**Added by**: Product Management Solution

See uom Entity [msdyn_uom_msdyn_estimateline_Unit](uom.md#BKMK_msdyn_uom_msdyn_estimateline_Unit) One-To-Many relationship.

### <a name="BKMK_msdyn_uomschedule_msdyn_estimateline_UnitSchedule"></a> msdyn_uomschedule_msdyn_estimateline_UnitSchedule

**Added by**: Product Management Solution

See uomschedule Entity [msdyn_uomschedule_msdyn_estimateline_UnitSchedule](uomschedule.md#BKMK_msdyn_uomschedule_msdyn_estimateline_UnitSchedule) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.msdyn_estimateline?text=msdyn_estimateline EntityType" />

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]