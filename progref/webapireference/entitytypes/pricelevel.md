---
title: "Microsoft Dynamics 365 Customer Engagement pricelevel EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 6f354983-cd33-4abb-aea5-245762f120bd
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API pricelevel entitytype."
---
# pricelevel EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/pricelevel.md](./descriptions/pricelevel.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]pricelevels </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Price List</td></tr>
<tr><td><b>Primary Key:</b></td><td>pricelevelid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|begindate|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Date on which the price list becomes effective.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the price list.<br />|
|enddate|Edm.DateTimeOffset|**Display Name**: End Date<br />**Description**: Date that is the last day the price list is valid.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|freighttermscode|Edm.Int32|**Display Name**: Freight Terms<br />**Description**: Freight terms for the price list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_breakhoursbillable|Edm.Boolean|**Display Name**: Break Hours Billable<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_entity|Edm.Int32|**Display Name**: Entity<br />**Description**: Select the entity for this price level.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Organization</td></tr><tr><td>192350001</td><td>Customer</td></tr><tr><td>192350002</td><td>Sales document</td></tr><tr><td>192350003</td><td>Project</td></tr><tbody></table>|
|msdyn_module|Edm.Int32|**Display Name**: Context<br />**Description**: Select the context for this price level i.e whether it is sales prices, cost prices or purchase prices<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Cost</td></tr><tr><td>192350001</td><td>Purchase</td></tr><tr><td>192350002</td><td>Sales</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the price list.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|paymentmethodcode|Edm.Int32|**Display Name**: Payment Method <br />**Description**: Payment terms to use with the price list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|pricelevelid|Edm.Guid|**Display Name**: Price List<br />**Description**: Unique identifier of the price list.<br />|
|shippingmethodcode|Edm.Int32|**Display Name**: Shipping Method<br />**Description**: Method of shipment for products in the price list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|statecode|Edm.Int32|**Display Name**: Status <br />**Description**: Status of the price list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the price list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100001</td><td>Active</td></tr><tr><td>100002</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the price list.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the pricelevel.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the price list.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the pricelevel.|
|_msdyn_copiedfrompricelevel_value|msdyn_CopiedFromPriceLevel<br />|Shows the price level that this price level was copied from.|
|_msdyn_timeunit_value|msdyn_TimeUnit<br />|Select the default unit of role based time on this price list|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the price level.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_pricelevelbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_pricelevelbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_pricelevelbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_pricelevelbase_modifiedonbehalfby|
|msdyn_CopiedFromPriceLevel|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_pricelevel_CopiedFromPriceLevel|
|msdyn_TimeUnit|[uom EntityType](uom.md)|msdyn_uom_pricelevel_TimeUnit|
|organizationid|[organization EntityType](organization.md)|organization_price_levels|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_pricelevel|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_organizationalunit_pricelevel|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_pricelevel|  
|msdyn_pricelevel_msdyn_accountpricelist_PriceList|[msdyn_accountpricelist EntityType](msdyn_accountpricelist.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_actual_PriceList|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_agreement_PriceList|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_agreementbookingproduct_PriceList|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_agreementbookingservice_PriceList|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_agreementinvoiceproduct_PriceList|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_contactpricelist_PriceList|[msdyn_contactpricelist EntityType](msdyn_contactpricelist.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_estimateline_PriceList|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_fieldservicepricelistitem_PriceList|[msdyn_fieldservicepricelistitem EntityType](msdyn_fieldservicepricelistitem.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_invoicelinetransaction_PriceList|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_journalline_PriceList|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_opportunitylinetransaction_PriceList|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_opportunitypricelist_PriceList|[msdyn_opportunitypricelist EntityType](msdyn_opportunitypricelist.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_orderlinetransaction_PriceList|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_orderpricelist_PriceList|[msdyn_orderpricelist EntityType](msdyn_orderpricelist.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_projectparameterpricelist_PriceList|[msdyn_projectparameterpricelist EntityType](msdyn_projectparameterpricelist.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_projectpricelist_PriceList|[msdyn_projectpricelist EntityType](msdyn_projectpricelist.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_quotebookingproduct_PriceList|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_quotebookingservice_PriceList|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_quotelinetransaction_PriceList|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_quotepricelist_PriceList|[msdyn_quotepricelist EntityType](msdyn_quotepricelist.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_resourcecategorypricelevel_PriceList|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_rma_PriceList|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_rmaproduct_PriceList|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_transactioncategorypricelevel_PriceList|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|msdyn_PriceList|  
|msdyn_pricelevel_msdyn_workorder_PriceList|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_workorderproduct_PriceList|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_workorderservice_PriceList|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_pricelist|  
|msdyn_pricelevel_msdyn_workordertype_PriceList|[msdyn_workordertype EntityType](msdyn_workordertype.md)|msdyn_pricelist|  
|msdyn_pricelevel_opportunityproduct_PriceList|[opportunityproduct EntityType](opportunityproduct.md)|msdyn_pricelist|  
|msdyn_pricelevel_pricelevel_CopiedFromPriceLevel|[pricelevel EntityType](pricelevel.md)|msdyn_CopiedFromPriceLevel|  
|msdyn_pricelevel_quotedetail_PriceList|[quotedetail EntityType](quotedetail.md)|msdyn_PriceList|  
|price_level_accounts|[account EntityType](account.md)|defaultpricelevelid|  
|price_level_contacts|[contact EntityType](contact.md)|defaultpricelevelid|  
|price_level_invoices|[invoice EntityType](invoice.md)|pricelevelid|  
|price_level_opportunties|[opportunity EntityType](opportunity.md)|pricelevelid|  
|price_level_orders|[salesorder EntityType](salesorder.md)|pricelevelid|  
|price_level_product_price_levels|[productpricelevel EntityType](productpricelevel.md)|pricelevelid|  
|price_level_products|[product EntityType](product.md)|pricelevelid|  
|price_level_quotes|[quote EntityType](quote.md)|pricelevelid|  
|PriceLevel_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_pricelevel|  
|PriceLevel_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_pricelevel|  
|pricelevel_connections1|[connection EntityType](connection.md)|record1id_pricelevel|  
|pricelevel_connections2|[connection EntityType](connection.md)|record2id_pricelevel|  
|PriceLevel_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_pricelevel_syncerror|  
|PriceList_Campaigns|[campaign EntityType](campaign.md)|pricelistid|  

## Operations
The following operations can be used with the pricelevel entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GetDefaultPriceLevel Function](../functions/getdefaultpricelevel.md)|Collection|[!INCLUDE[../functions/descriptions/getdefaultpricelevel.md](../functions/descriptions/getdefaultpricelevel.md)]|  

## Solutions
The following solutions include the pricelevel entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/pricelevel.md](./remarks/pricelevel.md)]

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