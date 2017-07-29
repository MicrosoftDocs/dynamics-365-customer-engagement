---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_quotelinetransaction EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f1dd02b8-6cbd-4621-b6a6-6e2d65c8b9d7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_quotelinetransaction entitytype."
---
# msdyn_quotelinetransaction EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_quotelinetransaction.md](./descriptions/msdyn_quotelinetransaction.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_quotelinetransactions </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Quote Line Detail</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_quotelinetransactionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_description</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_quotelinetransaction entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_accountingdate|Edm.DateTimeOffset|**Display Name**: Accounting Date<br />|
|msdyn_amount|Edm.Decimal|**Display Name**: Amount<br />**Description**: Enter the amount on the quote line estimate.<br />|
|msdyn_amount_after_tax|Edm.Decimal|**Display Name**: amount_after_tax<br />Computed<br />Read-only<br />|
|msdyn_amount_after_tax_base|Edm.Decimal|**Display Name**: amount_after_tax (Base)<br />**Description**: Value of the amount_after_tax in base currency.<br />Computed<br />Read-only<br />|
|msdyn_amount_base|Edm.Decimal|**Display Name**: Amount (Base)<br />**Description**: Value of the Amount in base currency.<br />Read-only<br />|
|msdyn_amountmethod|Edm.Int32|**Display Name**: Amount calculation method<br />**Description**: Select the calculation method used for the amount on the estimate line. Valid methods are: Multiply Quantity By Price, Fixed Price, Multiply Basis Quantity By Price, Multiply Basis Amount By Percent<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Tax Calculation</td></tr><tr><td>192350000</td><td>Multiply Quantity By Price</td></tr><tr><td>192350001</td><td>Fixed Price</td></tr><tr><td>192350002</td><td>Multiply Basis Quantity By Price</td></tr><tr><td>192350003</td><td>Multiply Basis Amount By Percent</td></tr><tbody></table>|
|msdyn_basisamount|Edm.Decimal|**Display Name**: Basis Amount<br />|
|msdyn_basisamount_base|Edm.Decimal|**Display Name**: Basis Amount (Base)<br />**Description**: Value of the Basis Amount in base currency.<br />Read-only<br />|
|msdyn_basisprice|Edm.Decimal|**Display Name**: Basis Price<br />|
|msdyn_basisprice_base|Edm.Decimal|**Display Name**: Basis Price (Base)<br />**Description**: Value of the Basis Price in base currency.<br />Read-only<br />|
|msdyn_basisquantity|Edm.Decimal|**Display Name**: Basis Quantity<br />|
|msdyn_billingtype|Edm.Int32|**Display Name**: Billing Type<br />**Description**: Select whether this quote line estimate will be charged to the customer or not. Only chargeable transactions will add to the invoice total<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Non Chargeable</td></tr><tr><td>192350001</td><td>Chargeable</td></tr><tr><td>192350002</td><td>Complimentary</td></tr><tr><td>192350003</td><td>Not Available</td></tr><tbody></table>|
|msdyn_customertype|Edm.Int32|**Display Name**: Customer Type<br />**Description**: Select whether the customer is an account or a contact <br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350001</td><td>Account</td></tr><tr><td>192350002</td><td>Contact</td></tr><tbody></table>|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Type the name of the custom entity.<br />|
|msdyn_documentdate|Edm.DateTimeOffset|**Display Name**: Document Date<br />**Description**: Enter the date that the invoice is sent to the customer. Only relevant on invoice and invoice line transactions<br />|
|msdyn_enddatetime|Edm.DateTimeOffset|**Display Name**: End Date Time<br />**Description**: Enter the end date of the work being estimated on the quote line estimate.<br />|
|msdyn_exchangeratedate|Edm.DateTimeOffset|**Display Name**: Exchange Rate Date<br />|
|msdyn_isdataimport|Edm.Boolean|**Display Name**: isdataimport<br />**Description**: Indicates if this record was created via import. It's purpose is to support data import.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_percent|Edm.Decimal|**Display Name**: Percent<br />**Description**: Enter the amount, in percent, to multiply the basis by. This field is relevant when the amount calculation method is "Multiply basis amount by percent."<br />|
|msdyn_price|Edm.Decimal|**Display Name**: Price<br />**Description**: Enter the price on the quote line estimate.<br />|
|msdyn_price_base|Edm.Decimal|**Display Name**: Price (Base)<br />**Description**: Value of the Price in base currency.<br />Read-only<br />|
|msdyn_quantity|Edm.Decimal|**Display Name**: Quantity<br />**Description**: Enter the quantity on the quote line estimate.<br />|
|msdyn_quoteline|Edm.String|**Display Name**: Quote Line<br />**Description**: Type the quote line to which this estimate line belongs to.<br />|
|msdyn_quotelinetransactionid|Edm.Guid|**Display Name**: Quote Line Detail<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_startdatetime|Edm.DateTimeOffset|**Display Name**: Start Date Time<br />**Description**: Enter the estimated start of the work being estimated on the quote line estimate.<br />|
|msdyn_tax|Edm.Decimal|**Display Name**: Tax<br />|
|msdyn_tax_base|Edm.Decimal|**Display Name**: tax (Base)<br />**Description**: Value of the tax in base currency.<br />Read-only<br />|
|msdyn_transactionclassification|Edm.Int32|**Display Name**: Transaction Class<br />**Description**: Transaction classification for the quote line<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Commission</td></tr><tr><td>690970001</td><td>Additional</td></tr><tr><td>690970002</td><td>Tax</td></tr><tr><td>192350000</td><td>Time</td></tr><tr><td>192350001</td><td>Expense</td></tr><tr><td>192350002</td><td>Material</td></tr><tr><td>192350003</td><td>Milestone</td></tr><tr><td>192350004</td><td>Fee</td></tr><tbody></table>|
|msdyn_transactiontypecode|Edm.Int32|**Display Name**: Transaction Type<br />**Description**: Shows the transaction type for this quote line.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Cost</td></tr><tr><td>192350004</td><td>Project Contract</td></tr><tr><td>192350005</td><td>Unbilled Sales</td></tr><tr><td>192350006</td><td>Billed Sales</td></tr><tr><td>192350007</td><td>Resourcing Unit Cost</td></tr><tr><td>192350008</td><td>Inter-Organizational Sales</td></tr><tbody></table>|
|msdyn_vendortype|Edm.Int32|**Display Name**: Vendor Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350001</td><td>Account</td></tr><tr><td>192350002</td><td>Contact</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Quote Line Detail<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Quote Line Detail<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_accountcustomer_value|msdyn_AccountCustomer<br />|Select the name of the customer account.|
|_msdyn_accountvendor_value|msdyn_AccountVendor<br />||
|_msdyn_bookableresource_value|msdyn_bookableresource<br />|Shows the resource.|
|_msdyn_contactcustomer_value|msdyn_ContactCustomer<br />|Select the contact customer on the quote.|
|_msdyn_contactvendor_value|msdyn_ContactVendor<br />||
|_msdyn_origin_value|msdyn_Origin<br />|Points to the quote line detail that originated an entry. For example, a revenue entry points to its related cost entry.|
|_msdyn_pricelist_value|msdyn_PriceList<br />|Select the price List used to default price on the estimate line.|
|_msdyn_product_value|msdyn_Product<br />|Select the product on the quote line estimate.|
|_msdyn_project_value|msdyn_Project<br />|Select the project being referenced by the quote line estimate.|
|_msdyn_quoteid_value|msdyn_QuoteId<br />|Select the denormalized reference to the quote. This is used for performance improvements and to allow the use of Power BI on a quote.|
|_msdyn_resourcecategory_value|msdyn_ResourceCategory<br />|Select the role on the quote line estimate.|
|_msdyn_resourceorganizationalunitid_value|msdyn_ResourceOrganizationalUnitId<br />|Select the organizational unit of the resource who should perform the work.|
|_msdyn_task_value|msdyn_Task<br />|Select the project work breakdown structure (WBS) task referenced by the quote line estimate.|
|_msdyn_transactioncategory_value|msdyn_TransactionCategory<br />|Select the category on the quote line estimate.|
|_msdyn_unit_value|msdyn_Unit<br />|Select the unit that the quantity is estimated in on this quote line estimate.|
|_msdyn_unitschedule_value|msdyn_UnitSchedule<br />|Select the unit schedule associated with the estimate line.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotelinetransaction_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotelinetransaction_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotelinetransaction_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotelinetransaction_modifiedonbehalfby|
|msdyn_AccountCustomer|[account EntityType](account.md)|msdyn_account_msdyn_quotelinetransaction_AccountCustomer|
|msdyn_AccountVendor|[account EntityType](account.md)|msdyn_account_msdyn_quotelinetransaction_AccountVendor|
|msdyn_bookableresource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_quotelinetransaction_bookableresource|
|msdyn_ContactCustomer|[contact EntityType](contact.md)|msdyn_contact_msdyn_quotelinetransaction_ContactCustomer|
|msdyn_ContactVendor|[contact EntityType](contact.md)|msdyn_contact_msdyn_quotelinetransaction_ContactVendor|
|msdyn_Origin|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_msdyn_quotelinetransaction_msdyn_quotelinetransaction_Origin|
|msdyn_PriceList|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_quotelinetransaction_PriceList|
|msdyn_Product|[product EntityType](product.md)|msdyn_product_msdyn_quotelinetransaction_Product|
|msdyn_Project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_msdyn_quotelinetransaction_Project|
|msdyn_QuoteId|[quote EntityType](quote.md)|msdyn_quote_msdyn_quotelinetransaction|
|msdyn_ResourceCategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory|
|msdyn_ResourceOrganizationalUnitId|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_quotelinetransaction|
|msdyn_Task|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_msdyn_projecttask_msdyn_quotelinetransaction_Task|
|msdyn_TransactionCategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory|
|msdyn_Unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_quotelinetransaction_Unit|
|msdyn_UnitSchedule|[uomschedule EntityType](uomschedule.md)|msdyn_uomschedule_msdyn_quotelinetransaction_UnitSchedule|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_quotelinetransaction|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_quotelinetransaction|
|owningteam|[team EntityType](team.md)|team_msdyn_quotelinetransaction|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_quotelinetransaction|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_quotelinetransaction|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|msdyn_QuoteLineDetail|  
|msdyn_msdyn_quotelinetransaction_msdyn_quotelinetransaction_Origin|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_Origin|  
|msdyn_quotelinetransaction_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_quotelinetransaction|  
|msdyn_quotelinetransaction_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_quotelinetransaction|  
|msdyn_quotelinetransaction_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_quotelinetransaction|  
|msdyn_quotelinetransaction_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_quotelinetransaction|  
|msdyn_quotelinetransaction_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_quotelinetransaction|  
|msdyn_quotelinetransaction_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_quotelinetransaction|  

## Operations
The following operations can be used with the msdyn_quotelinetransaction entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_quotelinetransaction entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_quotelinetransaction.md](./remarks/msdyn_quotelinetransaction.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />