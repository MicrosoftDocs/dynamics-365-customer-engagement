---
title: "Microsoft Dynamics 365 Customer Engagement uom EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: eefd7d54-1cb8-4f95-88de-7f2a0ffc9e87
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API uom entitytype."
---
# uom EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/uom.md](./descriptions/uom.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]uoms </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Unit</td></tr>
<tr><td><b>Primary Key:</b></td><td>uomid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The uom entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the unit was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|isschedulebaseuom|Edm.Boolean|**Display Name**: Is Schedule Base Unit<br />**Description**: Tells whether the unit is the base unit for the associated unit group.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the unit was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a descriptive title or name for the unit of measure.<br />|
|organizationid|Edm.Guid|**Display Name**: Organization <br />**Description**: Unique identifier of the organization associated with the unit of measure.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|quantity|Edm.Decimal|**Display Name**: Quantity<br />**Description**: Unit quantity for the product.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|uomid|Edm.Guid|**Display Name**: Unit<br />**Description**: Unique identifier of the unit.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_baseuom_value|baseuom<br />|Choose the base or primary unit on which the unit is based.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the unit.|
|_createdbyexternalparty_value||Shows the external party who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the uom.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the unit.|
|_modifiedbyexternalparty_value||Shows the external party who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the uom.|
|_uomscheduleid_value|uomscheduleid<br />|Choose the ID of the unit group that the unit is associated with.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|baseuom|[uom EntityType](uom.md)|unit_of_measurement_base_unit|
|createdby|[systemuser EntityType](systemuser.md)|lk_uombase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_uombase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_uombase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_uombase_modifiedonbehalfby|
|uomscheduleid|[uomschedule EntityType](uomschedule.md)|unit_of_measure_schedule_conversions|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_uom_msdyn_actual_Unit|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_Unit|  
|msdyn_uom_msdyn_agreementbookingproduct_Unit|[msdyn_agreementbookingproduct EntityType](msdyn_agreementbookingproduct.md)|msdyn_unit|  
|msdyn_uom_msdyn_agreementbookingservice_Unit|[msdyn_agreementbookingservice EntityType](msdyn_agreementbookingservice.md)|msdyn_unit|  
|msdyn_uom_msdyn_agreementinvoiceproduct_Unit|[msdyn_agreementinvoiceproduct EntityType](msdyn_agreementinvoiceproduct.md)|msdyn_unit|  
|msdyn_uom_msdyn_estimateline_Unit|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_Unit|  
|msdyn_uom_msdyn_incidenttypeproduct_Unit|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_unit|  
|msdyn_uom_msdyn_incidenttypeservice_Unit|[msdyn_incidenttypeservice EntityType](msdyn_incidenttypeservice.md)|msdyn_unit|  
|msdyn_uom_msdyn_inventoryadjustmentproduct_Unit|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_unit|  
|msdyn_uom_msdyn_inventoryjournal_Unit|[msdyn_inventoryjournal EntityType](msdyn_inventoryjournal.md)|msdyn_unit|  
|msdyn_uom_msdyn_invoicelinetransaction_Unit|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_Unit|  
|msdyn_uom_msdyn_journalline_Unit|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_Unit|  
|msdyn_uom_msdyn_opportunitylinetransaction_Unit|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_Unit|  
|msdyn_uom_msdyn_orderinvoicingproduct_Unit|[msdyn_orderinvoicingproduct EntityType](msdyn_orderinvoicingproduct.md)|msdyn_Unit|  
|msdyn_uom_msdyn_orderlinetransaction_Unit|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_Unit|  
|msdyn_uom_msdyn_productinventory_Unit|[msdyn_productinventory EntityType](msdyn_productinventory.md)|msdyn_unit|  
|msdyn_uom_msdyn_purchaseorderproduct_Unit|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_unit|  
|msdyn_uom_msdyn_quotebookingproduct_Unit|[msdyn_quotebookingproduct EntityType](msdyn_quotebookingproduct.md)|msdyn_unit|  
|msdyn_uom_msdyn_quotebookingservice_Unit|[msdyn_quotebookingservice EntityType](msdyn_quotebookingservice.md)|msdyn_unit|  
|msdyn_uom_msdyn_quoteinvoicingproduct_Unit|[msdyn_quoteinvoicingproduct EntityType](msdyn_quoteinvoicingproduct.md)|msdyn_Unit|  
|msdyn_uom_msdyn_quotelinetransaction_Unit|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_Unit|  
|msdyn_uom_msdyn_resourcecategorypricelevel_PrimaryUnit|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_PrimaryUnit|  
|msdyn_uom_msdyn_resourcecategorypricelevel_Unit|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_Unit|  
|msdyn_uom_msdyn_rmaproduct_Unit|[msdyn_rmaproduct EntityType](msdyn_rmaproduct.md)|msdyn_unit|  
|msdyn_uom_msdyn_rtvproduct_Unit|[msdyn_rtvproduct EntityType](msdyn_rtvproduct.md)|msdyn_unit|  
|msdyn_uom_msdyn_transactioncategory_DefaultUnit|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_DefaultUnit|  
|msdyn_uom_msdyn_transactioncategorypricelevel_Unit|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|msdyn_Unit|  
|msdyn_uom_msdyn_transactiontype_DefaultUnit|[msdyn_transactiontype EntityType](msdyn_transactiontype.md)|msdyn_DefaultUnit|  
|msdyn_uom_msdyn_workorderproduct_Unit|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_unit|  
|msdyn_uom_msdyn_workorderservice_Unit|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_unit|  
|msdyn_uom_pricelevel_TimeUnit|[pricelevel EntityType](pricelevel.md)|msdyn_TimeUnit|  
|unit_of_measurement_base_unit|[uom EntityType](uom.md)|baseuom|  
|unit_of_measurement_contract_line_items|[contractdetail EntityType](contractdetail.md)|uomid|  
|unit_of_measurement_invoice_details|[invoicedetail EntityType](invoicedetail.md)|uomid|  
|unit_of_measurement_opportunity_products|[opportunityproduct EntityType](opportunityproduct.md)|uomid|  
|unit_of_measurement_order_details|[salesorderdetail EntityType](salesorderdetail.md)|uomid|  
|unit_of_measurement_product_price_levels|[productpricelevel EntityType](productpricelevel.md)|uomid|  
|unit_of_measurement_productassociation|[productassociation EntityType](productassociation.md)|uomid|  
|unit_of_measurement_products|[product EntityType](product.md)|defaultuomid|  
|unit_of_measurement_quote_details|[quotedetail EntityType](quotedetail.md)|uomid|  
|UoM_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_uom|  
|UoM_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_uom|  
|UoM_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_uom|  

## Solutions
The following solutions include the uom entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/uom.md](./remarks/uom.md)]

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