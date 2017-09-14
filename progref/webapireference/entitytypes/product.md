---
title: "Microsoft Dynamics 365 Customer Engagement product EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: add70313-8b8b-4656-b5b0-8ed13eed867a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API product entitytype."
---
# product EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/product.md](./descriptions/product.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]products </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Product</td></tr>
<tr><td><b>Primary Key:</b></td><td>productid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|currentcost|Edm.Decimal|**Display Name**: Current Cost<br />**Description**: Current cost for the product item. Used in price calculations.<br />|
|currentcost_base|Edm.Decimal|**Display Name**: Current Cost (Base)<br />**Description**: Value of the Current Cost in base currency.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the product.<br />|
|dmtimportstate|Edm.Int32|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: Shows the default image for the record.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the product with respect to the base currency.<br />Read-only<br />|
|hierarchypath|Edm.String|**Display Name**: Hierarchy Path<br />**Description**: Hierarchy path of the product.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|iskit|Edm.Boolean|**Display Name**: Is Kit<br />**Description**: Information that specifies whether the product is a kit.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isstockitem|Edm.Boolean|**Display Name**: Stock Item<br />**Description**: Information about whether the product is a stock item.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_converttocustomerasset|Edm.Boolean|**Display Name**: Convert to Customer Asset<br />**Description**: Specify whether a product is to be converted to a customer asset. When a product is used on a work order, the system will automatically convert it into a customer asset when the work order is closed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_fieldserviceproducttype|Edm.Int32|**Display Name**: Field Service Product Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Inventory</td></tr><tr><td>690970001</td><td>Non-Inventory</td></tr><tr><td>690970002</td><td>Service</td></tr><tbody></table>|
|msdyn_purchasename|Edm.String|**Display Name**: Purchase Name<br />**Description**: Type the name for the product when used on a purchase order.<br />|
|msdyn_taxable|Edm.Boolean|**Display Name**: Taxable<br />**Description**: Select whether the item is taxable. If an item is set as not taxable, it won't be taxable even on a taxable work order.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_upccode|Edm.String|**Display Name**: UPC Code<br />**Description**: Shows the UPC Code for product. Used for bar code scanning.<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the product.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|price|Edm.Decimal|**Display Name**: List Price<br />**Description**: List price of the product.<br />|
|price_base|Edm.Decimal|**Display Name**: List Price (Base)<br />**Description**: Value of the List Price in base currency.<br />Read-only<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|productid|Edm.Guid|**Display Name**: Product<br />**Description**: Unique identifier of the product.<br />|
|productnumber|Edm.String|**Display Name**: Product ID<br />**Description**: User-defined product ID.<br />|
|productstructure|Edm.Int32|**Display Name**: Product Structure<br />**Description**: Product Structure.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Product</td></tr><tr><td>2</td><td>Product Family</td></tr><tr><td>3</td><td>Product Bundle</td></tr><tbody></table>|
|producttypecode|Edm.Int32|**Display Name**: Product Type<br />**Description**: Type of product.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Sales Inventory</td></tr><tr><td>2</td><td>Miscellaneous Charges</td></tr><tr><td>3</td><td>Services</td></tr><tr><td>4</td><td>Flat Fees</td></tr><tbody></table>|
|producturl|Edm.String|**Display Name**: URL<br />**Description**: URL for the Website associated with the product.<br />|
|quantitydecimal|Edm.Int32|**Display Name**: Decimals Supported<br />**Description**: Number of decimal places that can be used in monetary amounts for the product.<br />|
|quantityonhand|Edm.Decimal|**Display Name**: Quantity On Hand<br />**Description**: Quantity of the product in stock.<br />|
|size|Edm.String|**Display Name**: Size<br />**Description**: Product size.<br />|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|standardcost|Edm.Decimal|**Display Name**: Standard Cost<br />**Description**: Standard cost of the product.<br />|
|standardcost_base|Edm.Decimal|**Display Name**: Standard Cost (Base)<br />**Description**: Value of the Standard Cost in base currency.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the product.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Retired</td></tr><tr><td>2</td><td>Draft</td></tr><tr><td>3</td><td>Under Revision</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the product.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Retired</td></tr><tr><td>0</td><td>Draft</td></tr><tr><td>3</td><td>Under Revision</td></tr><tbody></table>|
|stockvolume|Edm.Decimal|**Display Name**: Stock Volume<br />**Description**: Stock volume of the product.<br />|
|stockweight|Edm.Decimal|**Display Name**: Stock Weight<br />**Description**: Stock weight of the product.<br />|
|suppliername|Edm.String|**Display Name**: Supplier Name<br />**Description**: Name of the product's supplier.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|validfromdate|Edm.Date|**Display Name**: Valid From<br />**Description**: Date from which this product is valid.<br />|
|validtodate|Edm.Date|**Display Name**: Valid To<br />**Description**: Date to which this product is valid.<br />|
|vendorid|Edm.String|**Display Name**: Vendor ID<br />**Description**: Unique identifier of vendor supplying the product.<br />|
|vendorname|Edm.String|**Display Name**: Vendor<br />**Description**: Name of the product vendor.<br />|
|vendorpartnumber|Edm.String|**Display Name**: Vendor Name<br />**Description**: Unique part identifier in vendor catalog of this product.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the product.|
|_createdbyexternalparty_value||Shows the external party who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the product.|
|_defaultuomid_value|defaultuomid<br />|Default unit for the product.|
|_defaultuomscheduleid_value|defaultuomscheduleid<br />|Default unit group for the product.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the product.|
|_modifiedbyexternalparty_value||Shows the external party who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the product.|
|_msdyn_defaultvendor_value|msdyn_defaultvendor<br />|Default vendor that supplies this product|
|_msdyn_transactioncategory_value|msdyn_TransactionCategory<br />|Select the transaction category for this product.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_parentproductid_value|parentproductid<br />|Specifies the parent product family hierarchy.|
|_pricelevelid_value|pricelevelid<br />|Select the default price list for the product.|
|_subjectid_value|subjectid<br />|Select a category for the product.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the product.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_productbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_productbase_createdonbehalfby|
|defaultuomid|[uom EntityType](uom.md)|unit_of_measurement_products|
|defaultuomscheduleid|[uomschedule EntityType](uomschedule.md)|unit_of_measurement_schedule_products|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_productbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_productbase_modifiedonbehalfby|
|msdyn_defaultvendor|[account EntityType](account.md)|msdyn_account_product_DefaultVendor|
|msdyn_TransactionCategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_msdyn_transactioncategory_product_TransactionCategory|
|organizationid|[organization EntityType](organization.md)|organization_products|
|parentproductid|[product EntityType](product.md)|product_parent_product|
|pricelevelid|[pricelevel EntityType](pricelevel.md)|price_level_products|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_products|
|subjectid|[subject EntityType](subject.md)|subject_products|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_product|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|campaignproduct_association|[campaign EntityType](campaign.md)|campaignproduct_association|  
|competitorproduct_association|[competitor EntityType](competitor.md)|competitorproduct_association|  
|leadproduct_association|[lead EntityType](lead.md)|leadproduct_association|  
|msdyn_product_msdyn_actual_Product|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_Product|  
|msdyn_product_msdyn_agreementbookingproduct_Product|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_product|  
|msdyn_product_msdyn_agreementbookingservice_Service|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_service|  
|msdyn_product_msdyn_agreementinvoiceproduct_Product|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_product|  
|msdyn_product_msdyn_customerasset_Product|[msdyn_customerasset EntityType](msdyn_customerasset.md)|msdyn_product|  
|msdyn_product_msdyn_estimateline_Product|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_Product|  
|msdyn_product_msdyn_fact_Product|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_Product|  
|msdyn_product_msdyn_fieldcomputation_ProductId|[msdyn_fieldcomputation EntityType](msdyn_fieldcomputation.md)|msdyn_ProductId|  
|msdyn_product_msdyn_fieldservicepricelistitem_ProductService|[msdyn_fieldservicepricelistitem EntityType](msdyn_fieldservicepricelistitem.md)|msdyn_productservice|  
|msdyn_product_msdyn_fieldservicesetting|[msdyn_fieldservicesetting EntityType](msdyn_fieldservicesetting.md)|msdyn_travelchargeitemid|  
|msdyn_product_msdyn_incidenttypeproduct_Product|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_product|  
|msdyn_product_msdyn_incidenttypeservice_Service|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_service|  
|msdyn_product_msdyn_inventoryadjustmentproduct_Product|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_product|  
|msdyn_product_msdyn_inventoryjournal_Product|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_product|  
|msdyn_product_msdyn_invoicelinetransaction_Product|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_Product|  
|msdyn_product_msdyn_journalline_Product|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_Product|  
|msdyn_product_msdyn_opportunitylinetransaction_Product|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_Product|  
|msdyn_product_msdyn_orderinvoicingproduct_Product|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|msdyn_Product|  
|msdyn_product_msdyn_orderlinetransaction_Product|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_Product|  
|msdyn_product_msdyn_productinventory_Product|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_product|  
|msdyn_product_msdyn_purchaseorderproduct_Product|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_product|  
|msdyn_product_msdyn_quotebookingproduct_Product|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_product|  
|msdyn_product_msdyn_quotebookingservice_Service|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_Service|  
|msdyn_product_msdyn_quoteinvoicingproduct_Product|[msdyn_quoteinvoicingproduct EntityType](msdyn_quoteinvoicingproduct.md)|msdyn_Product|  
|msdyn_product_msdyn_quotelinetransaction_Product|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_Product|  
|msdyn_product_msdyn_rmaproduct_Product|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_product|  
|msdyn_product_msdyn_rtvproduct_Product|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_product|  
|msdyn_product_msdyn_workorderproduct_Product|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_product|  
|msdyn_product_msdyn_workorderservice_Service|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_service|  
|opportunity_products|[opportunityproduct EntityType](opportunityproduct.md)|productid|  
|Product_Annotation|[annotation EntityType](annotation.md)|objectid_product|  
|Product_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_product|  
|Product_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_product|  
|product_connections1|[connection EntityType](connection.md)|record1id_product|  
|product_connections2|[connection EntityType](connection.md)|record2id_product|  
|product_contract_line_items|[contractdetail EntityType](contractdetail.md)|productid|  
|Product_DynamicProperty|[dynamicproperty EntityType](dynamicproperty.md)|regardingobjectid_product|  
|Product_DynamicPropertyAssociation|[dynamicpropertyassociation EntityType](dynamicpropertyassociation.md)|regardingobjectid_product|  
|product_entitlement_association|[entitlement EntityType](entitlement.md)|product_entitlement_association|  
|product_entitlementtemplate_association|[entitlementtemplate EntityType](entitlementtemplate.md)|product_entitlementtemplate_association|  
|product_incidents|[incident EntityType](incident.md)|productid|  
|product_invoice_details|[invoicedetail EntityType](invoicedetail.md)|productid|  
|product_order_details|[salesorderdetail EntityType](salesorderdetail.md)|productid|  
|product_parent_product|[product EntityType](product.md)|parentproductid|  
|product_price_levels|[productpricelevel EntityType](productpricelevel.md)|productid|  
|Product_ProductAssociation_AssocProd|[productassociation EntityType](productassociation.md)|associatedproduct|  
|Product_ProductAssociation_Prod|[productassociation EntityType](productassociation.md)|productid|  
|product_ProductSubstitute_productid|[productsubstitute EntityType](productsubstitute.md)|productid|  
|product_ProductSubstitute_substitutedproductid|[productsubstitute EntityType](productsubstitute.md)|substitutedproductid|  
|product_quote_details|[quotedetail EntityType](quotedetail.md)|productid|  
|Product_SharepointDocumentLocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_product|  
|Product_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_product_syncerror|  
|productsalesliterature_association|[salesliterature EntityType](salesliterature.md)|productsalesliterature_association|  

## Operations
The following operations can be used with the product entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[AddItemCampaign Action](../actions/additemcampaign.md)|Entity|[!INCLUDE[../actions/descriptions/additemcampaign.md](../actions/descriptions/additemcampaign.md)]|  
|[CloneProduct Action](../actions/cloneproduct.md)|Entity|[!INCLUDE[../actions/descriptions/cloneproduct.md](../actions/descriptions/cloneproduct.md)]|  
|[PublishProductHierarchy Action](../actions/publishproducthierarchy.md)|Entity|[!INCLUDE[../actions/descriptions/publishproducthierarchy.md](../actions/descriptions/publishproducthierarchy.md)]|  
|[RetrieveByTopIncidentProductKbArticle Function](../functions/retrievebytopincidentproductkbarticle.md)|Entity|[!INCLUDE[../functions/descriptions/retrievebytopincidentproductkbarticle.md](../functions/descriptions/retrievebytopincidentproductkbarticle.md)]|  
|[RevertProduct Action](../actions/revertproduct.md)|Not Bound|[!INCLUDE[../actions/descriptions/revertproduct.md](../actions/descriptions/revertproduct.md)]|  

## Solutions
The following solutions include the product entity type.


|Name|Description |  
|----|------------|  
|[Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicseventmanagementsolution.md](../solutions/descriptions/microsoftdynamicseventmanagementsolution.md)]|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/product.md](./remarks/product.md)]

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