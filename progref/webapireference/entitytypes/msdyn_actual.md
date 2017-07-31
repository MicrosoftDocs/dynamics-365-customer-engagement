---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_actual EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a3d3d10e-4fc0-410b-bf64-f9601858ee9c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_actual entitytype."
---
# msdyn_actual EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_actual.md](./descriptions/msdyn_actual.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_actuals </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Actual</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_actualid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_description</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_actual entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_accountingdate|Edm.DateTimeOffset|**Display Name**: Accounting Date<br />|
|msdyn_actualid|Edm.Guid|**Display Name**: Actual<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_adjustmentstatus|Edm.Int32|**Display Name**: Adjustment Status ID<br />**Description**: Shows the adjustment status ID of the transaction.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>In Process</td></tr><tr><td>192350001</td><td>Adjusted</td></tr><tr><td>192350002</td><td>Unadjustable</td></tr><tbody></table>|
|msdyn_amount|Edm.Decimal|**Display Name**: Amount<br />**Description**: Enter the amount in transaction currency.<br />|
|msdyn_amount_base|Edm.Decimal|**Display Name**: Amount (Base currency)<br />**Description**: Enter the value of the amount in the base (organization) currency.<br />Read-only<br />|
|msdyn_amountmethod|Edm.Int32|**Display Name**: Amount Method ID<br />**Description**: Select the method by which the amount was computed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Tax Calculation</td></tr><tr><td>192350000</td><td>Multiply Quantity By Price</td></tr><tr><td>192350001</td><td>Fixed Price</td></tr><tr><td>192350002</td><td>Multiply Basis Quantity By Price</td></tr><tr><td>192350003</td><td>Multiply Basis Amount By Percent</td></tr><tbody></table>|
|msdyn_basisamount|Edm.Decimal|**Display Name**: Basis Amount<br />**Description**: Enter the cost amount of the sales transaction in the transaction currency.<br />|
|msdyn_basisamount_base|Edm.Decimal|**Display Name**: Basis Amount (Base currency)<br />**Description**: Enter the cost amount of the sales transaction in the base (organization) currency.<br />Read-only<br />|
|msdyn_basisprice|Edm.Decimal|**Display Name**: Basis Price<br />**Description**: Enter the cost price of the sales transaction in transaction currency.<br />|
|msdyn_basisprice_base|Edm.Decimal|**Display Name**: Basis Price (Base currency)<br />**Description**: Enter the cost price of the sales transaction in base (organization) currency.<br />Read-only<br />|
|msdyn_basisquantity|Edm.Decimal|**Display Name**: Basis Quantity<br />**Description**: Enter the cost quantity of the sales transaction in the base (organization) currency.<br />|
|msdyn_billingstatus|Edm.Int32|**Display Name**: Billing status ID<br />**Description**: Select the billing status ID.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Work order closed - posted</td></tr><tr><td>192350000</td><td>Unbilled Sales Created</td></tr><tr><td>192350001</td><td>Customer Invoice Created</td></tr><tr><td>192350002</td><td>Customer Invoice Posted</td></tr><tr><td>192350003</td><td>Canceled</td></tr><tbody></table>|
|msdyn_billingtype|Edm.Int32|**Display Name**: Billing type ID<br />**Description**: Select the billing type ID.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Non Chargeable</td></tr><tr><td>192350001</td><td>Chargeable</td></tr><tr><td>192350002</td><td>Complimentary</td></tr><tr><td>192350003</td><td>Not Available</td></tr><tbody></table>|
|msdyn_customertype|Edm.Int32|**Display Name**: Customer type ID<br />**Description**: Select the customer type ID.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350001</td><td>Account</td></tr><tr><td>192350002</td><td>Contact</td></tr><tbody></table>|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Type the record description.<br />|
|msdyn_documentdate|Edm.DateTimeOffset|**Display Name**: Document Date<br />**Description**: Enter the transaction date of the business event.<br />|
|msdyn_enddatetime|Edm.DateTimeOffset|**Display Name**: End Date/Time<br />**Description**: Enter the end date and time for this transaction.<br />|
|msdyn_exchangeratedate|Edm.DateTimeOffset|**Display Name**: Exchange Rate Date<br />**Description**: Enter the date of the exchange rate used for this transaction.<br />|
|msdyn_externaldescription|Edm.String|**Display Name**: External Description<br />**Description**: The external description of the business transaction.<br />|
|msdyn_externalreferencedate|Edm.DateTimeOffset|**Display Name**: External Reference Date<br />**Description**: Stores a date from an external system, such as a journal entry voucher date from an ERP system<br />|
|msdyn_externalreferenceid|Edm.String|**Display Name**: External Reference ID<br />**Description**: Stores an ID from an external system, such as the journal entry voucher number from an ERP system.<br />|
|msdyn_isjournalized|Edm.Boolean|**Display Name**: Is Journalized<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_journaltype|Edm.Int32|**Display Name**: Journal Type<br />**Description**: Type of journal for resource cost.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Working Hours</td></tr><tr><td>690970001</td><td>Break</td></tr><tr><td>690970002</td><td>Travel</td></tr><tr><td>690970003</td><td>Overtime</td></tr><tr><td>690970004</td><td>Business Closure</td></tr><tbody></table>|
|msdyn_percent|Edm.Decimal|**Display Name**: Percent<br />**Description**: Enter the percent.<br />|
|msdyn_price|Edm.Decimal|**Display Name**: Price<br />**Description**: Enter the price in the transaction currency.<br />|
|msdyn_price_base|Edm.Decimal|**Display Name**: Price (Base)<br />**Description**: Enter the price in the base (organization) currency.<br />Read-only<br />|
|msdyn_producttype|Edm.Int32|**Display Name**: Product Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Inventory</td></tr><tr><td>690970001</td><td>Non-Inventory</td></tr><tr><td>690970002</td><td>Service</td></tr><tbody></table>|
|msdyn_quantity|Edm.Decimal|**Display Name**: Quantity<br />**Description**: Enter the quantity.<br />|
|msdyn_salescontractline|Edm.String|**Display Name**: Project Contract Line<br />**Description**: Type the project contract line.<br />|
|msdyn_startdatetime|Edm.DateTimeOffset|**Display Name**: Start Date/Time<br />**Description**: Enter the start date and time.<br />|
|msdyn_transactionclassification|Edm.Int32|**Display Name**: Transaction Class<br />**Description**: Shows the transaction classification of this transaction.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Commission</td></tr><tr><td>690970001</td><td>Additional</td></tr><tr><td>690970002</td><td>Tax</td></tr><tr><td>192350000</td><td>Time</td></tr><tr><td>192350001</td><td>Expense</td></tr><tr><td>192350002</td><td>Material</td></tr><tr><td>192350003</td><td>Milestone</td></tr><tr><td>192350004</td><td>Fee</td></tr><tbody></table>|
|msdyn_transactiontypecode|Edm.Int32|**Display Name**: Transaction Type<br />**Description**: Shows the transaction type of this transaction.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Cost</td></tr><tr><td>192350004</td><td>Project Contract</td></tr><tr><td>192350005</td><td>Unbilled Sales</td></tr><tr><td>192350006</td><td>Billed Sales</td></tr><tr><td>192350007</td><td>Resourcing Unit Cost</td></tr><tr><td>192350008</td><td>Inter-Organizational Sales</td></tr><tbody></table>|
|msdyn_vendortype|Edm.Int32|**Display Name**: Vendor Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350001</td><td>Account</td></tr><tr><td>192350002</td><td>Contact</td></tr><tbody></table>|
|msdyn_worklocation|Edm.Int32|**Display Name**: Work Location<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Onsite</td></tr><tr><td>690970001</td><td>Depot</td></tr><tr><td>690970002</td><td>Location Agnostic</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Actual<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Actual<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_accountcustomer_value|msdyn_AccountCustomer<br />|Select the customer.|
|_msdyn_accountvendor_value|msdyn_AccountVendor<br />||
|_msdyn_agreement_value|msdyn_Agreement<br />||
|_msdyn_bookableresource_value|msdyn_bookableresource<br />|Shows the bookable resource for which the actual is recorded.|
|_msdyn_contactcustomer_value|msdyn_ContactCustomer<br />|Select the customer contact.|
|_msdyn_contactvendor_value|msdyn_ContactVendor<br />||
|_msdyn_contractorganizationalunitid_value|msdyn_contractorganizationalunitid<br />|Select the organizational unit ID for the contract.|
|_msdyn_incidenttype_value|msdyn_IncidentType<br />||
|_msdyn_invoice_value|msdyn_Invoice<br />|The unique identifier of an invoice.|
|_msdyn_pricelist_value|msdyn_PriceList<br />|Select the price list.|
|_msdyn_product_value|msdyn_Product<br />|Select the product ID.|
|_msdyn_project_value|msdyn_Project<br />|Select the project ID.|
|_msdyn_resourcecategory_value|msdyn_ResourceCategory<br />|Select the role ID of the resource performing the work.|
|_msdyn_resourceorganizationalunitid_value|msdyn_ResourceOrganizationalUnitId<br />|Organizational unit at the time the actual was registered of the resource who performed the work.|
|_msdyn_salescontract_value|msdyn_SalesContract<br />|Select the project contract.|
|_msdyn_serviceaccount_value|msdyn_ServiceAccount<br />|Account that was serviced|
|_msdyn_serviceterritory_value|msdyn_ServiceTerritory<br />||
|_msdyn_task_value|msdyn_Task<br />|Select the task.|
|_msdyn_taxcode_value|msdyn_TaxCode<br />||
|_msdyn_transactioncategory_value|msdyn_TransactionCategory<br />|Select the transaction category.|
|_msdyn_unit_value|msdyn_Unit<br />|Select the unit of measure.|
|_msdyn_unitschedule_value|msdyn_UnitSchedule<br />|Select the unit schedule.|
|_msdyn_warehouse_value|msdyn_Warehouse<br />||
|_msdyn_workorder_value|msdyn_WorkOrder<br />||
|_msdyn_workordertype_value|msdyn_WorkOrderType<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_actual_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_actual_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_actual_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_actual_modifiedonbehalfby|
|msdyn_AccountCustomer|[account EntityType](account.md)|msdyn_account_msdyn_actual_AccountCustomer|
|msdyn_AccountVendor|[account EntityType](account.md)|msdyn_account_msdyn_actual_AccountVendor|
|msdyn_Agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_msdyn_agreement_msdyn_actual_Agreement|
|msdyn_bookableresource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_actual_bookableresource|
|msdyn_ContactCustomer|[contact EntityType](contact.md)|msdyn_contact_msdyn_actual_ContactCustomer|
|msdyn_ContactVendor|[contact EntityType](contact.md)|msdyn_contact_msdyn_actual_ContactVendor|
|msdyn_contractorganizationalunitid|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_msdyn_organizationalunit_msdyn_actual_ContractOrganizationalUnitId|
|msdyn_IncidentType|[msdyn_incidenttype EntityType](msdyn_incidenttype.md)|msdyn_msdyn_incidenttype_msdyn_actual_IncidentType|
|msdyn_Invoice|[invoice EntityType](invoice.md)|msdyn_invoice_msdyn_actual_Invoice|
|msdyn_PriceList|[pricelevel EntityType](pricelevel.md)|msdyn_pricelevel_msdyn_actual_PriceList|
|msdyn_Product|[product EntityType](product.md)|msdyn_product_msdyn_actual_Product|
|msdyn_Project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_msdyn_actual_Project|
|msdyn_ResourceCategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory|
|msdyn_ResourceOrganizationalUnitId|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_actual|
|msdyn_SalesContract|[salesorder EntityType](salesorder.md)|msdyn_salesorder_msdyn_actual_SalesContract|
|msdyn_ServiceAccount|[account EntityType](account.md)|msdyn_account_msdyn_actual_ServiceAccount|
|msdyn_ServiceTerritory|[territory EntityType](territory.md)|msdyn_territory_msdyn_actual_ServiceTerritory|
|msdyn_Task|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_msdyn_projecttask_msdyn_actual_Task|
|msdyn_TaxCode|[msdyn_taxcode EntityType](msdyn_taxcode.md)|msdyn_msdyn_taxcode_msdyn_actual_TaxCode|
|msdyn_TransactionCategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory|
|msdyn_Unit|[uom EntityType](uom.md)|msdyn_uom_msdyn_actual_Unit|
|msdyn_UnitSchedule|[uomschedule EntityType](uomschedule.md)|msdyn_uomschedule_msdyn_actual_UnitSchedule|
|msdyn_Warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_msdyn_warehouse_msdyn_actual_Warehouse|
|msdyn_WorkOrder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_actual_WorkOrder|
|msdyn_WorkOrderType|[msdyn_workordertype EntityType](msdyn_workordertype.md)|msdyn_msdyn_workordertype_msdyn_actual_WorkOrderType|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_actual|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_actual|
|owningteam|[team EntityType](team.md)|team_msdyn_actual|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_actual|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_actual|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_actual_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_actual|  
|msdyn_actual_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_actual|  
|msdyn_actual_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_actual|  
|msdyn_actual_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_actual|  
|msdyn_actual_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_actual|  
|msdyn_actual_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_actual|  

## Operations
The following operations can be used with the msdyn_actual entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_actual entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_actual.md](./remarks/msdyn_actual.md)]

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