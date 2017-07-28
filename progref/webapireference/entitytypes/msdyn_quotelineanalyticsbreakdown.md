---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_quotelineanalyticsbreakdown EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3522f74f-374c-4d8d-9a91-f27b8b7c1f98
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_quotelineanalyticsbreakdown entitytype."
---
# msdyn_quotelineanalyticsbreakdown EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_quotelineanalyticsbreakdown.md](./descriptions/msdyn_quotelineanalyticsbreakdown.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_quotelineanalyticsbreakdowns </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Quote Line Analytics Breakdown</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_quotelineanalyticsbreakdownid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_quotelineanalyticsbreakdown entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_amount|Edm.Decimal|**Display Name**: Amount<br />**Description**: Enter the amount on the quote line estimate.<br />|
|msdyn_amount_base|Edm.Decimal|**Display Name**: Amount (Base)<br />**Description**: Value of the Amount in base currency.<br />Read-only<br />|
|msdyn_billingtype|Edm.Int32|**Display Name**: Billing Type<br />**Description**: Select whether the quote line estimate will be charged to the customer. Valid values are Chargeable, Non-chargeable and Complimentary. Only chargeable transactions will affect the invoice totals.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Non Chargeable</td></tr><tr><td>192350001</td><td>Chargeable</td></tr><tr><td>192350002</td><td>Complimentary</td></tr><tr><td>192350003</td><td>Not Available</td></tr><tbody></table>|
|msdyn_enddatetime|Edm.DateTimeOffset|**Display Name**: End Date Time<br />**Description**: Enter the estimated end date of the quote line estimate.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Type a description of the entity breakdown.<br />|
|msdyn_price|Edm.Decimal|**Display Name**: Price<br />**Description**: Enter the unit price on the quote line estimate.<br />|
|msdyn_price_base|Edm.Decimal|**Display Name**: Price (Base)<br />**Description**: Value of the Price in base currency.<br />Read-only<br />|
|msdyn_quotelineanalyticsbreakdownid|Edm.Guid|**Display Name**: Quote Line Analytics Breakdown<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_startdatetime|Edm.DateTimeOffset|**Display Name**: Start Date Time<br />**Description**: Enter the estimated start date of the quote line estimate.<br />|
|msdyn_transactionclassification|Edm.Int32|**Display Name**: Transaction Class<br />**Description**: Transaction classification of  Project quote analytics<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Commission</td></tr><tr><td>690970001</td><td>Additional</td></tr><tr><td>690970002</td><td>Tax</td></tr><tr><td>192350000</td><td>Time</td></tr><tr><td>192350001</td><td>Expense</td></tr><tr><td>192350002</td><td>Material</td></tr><tr><td>192350003</td><td>Milestone</td></tr><tr><td>192350004</td><td>Fee</td></tr><tbody></table>|
|msdyn_transactiontypecode|Edm.Int32|**Display Name**: Transaction Type<br />**Description**: Transaction type of the Project quote analytics<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Cost</td></tr><tr><td>192350004</td><td>Project Contract</td></tr><tr><td>192350005</td><td>Unbilled Sales</td></tr><tr><td>192350006</td><td>Billed Sales</td></tr><tr><td>192350007</td><td>Resourcing Unit Cost</td></tr><tr><td>192350008</td><td>Inter-Organizational Sales</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Quote Line Analytics Breakdown<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Quote Line Analytics Breakdown<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_quote_value|msdyn_Quote<br />|Select the quote that this quote line estimate belongs to.|
|_msdyn_quotelinedetail_value|msdyn_QuoteLineDetail<br />|Select the quote line estimate.|
|_msdyn_quotelinescheduleofvalue_value|msdyn_QuoteLineScheduleOfValue<br />|Shows the billing milestone for the quote line.|
|_msdyn_resourcecategory_value|msdyn_ResourceCategory<br />|Select the role that is estimated on the quote line.|
|_msdyn_transactioncategory_value|msdyn_TransactionCategory<br />|Select the category identified on the quote line estimate.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotelineanalyticsbreakdown_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotelineanalyticsbreakdown_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotelineanalyticsbreakdown_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_quotelineanalyticsbreakdown_modifiedonbehalfby|
|msdyn_Quote|[quote EntityType](quote.md)|msdyn_quote_msdyn_quotelineanalyticsbreakdown_Quote|
|msdyn_QuoteLineDetail|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_msdyn_quotelinetransaction_msdyn_quotelineanalyticsbreakdown_QuoteLineDetail|
|msdyn_QuoteLineScheduleOfValue|[msdyn_quotelinescheduleofvalue EntityType](msdyn_quotelinescheduleofvalue.md)|msdyn_msdyn_quotelinescheduleofvalue_msdyn_quotelineanalyticsbreakdown_QuoteLineScheduleOfValue|
|msdyn_ResourceCategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory|
|msdyn_TransactionCategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_quotelineanalyticsbreakdown|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_quotelineanalyticsbreakdown|
|owningteam|[team EntityType](team.md)|team_msdyn_quotelineanalyticsbreakdown|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_quotelineanalyticsbreakdown|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_quotelineanalyticsbreakdown|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_quotelineanalyticsbreakdown_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_quotelineanalyticsbreakdown|  
|msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_quotelineanalyticsbreakdown|  
|msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_quotelineanalyticsbreakdown|  
|msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_quotelineanalyticsbreakdown|  
|msdyn_quotelineanalyticsbreakdown_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_quotelineanalyticsbreakdown|  

## Operations
The following operations can be used with the msdyn_quotelineanalyticsbreakdown entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_quotelineanalyticsbreakdown entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_quotelineanalyticsbreakdown.md](./remarks/msdyn_quotelineanalyticsbreakdown.md)]

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