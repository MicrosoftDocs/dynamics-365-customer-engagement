---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_fact EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: aba4ce6e-dcec-4cc8-847d-ac3b936986ed
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_fact entitytype."
---
# msdyn_fact EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_fact.md](./descriptions/msdyn_fact.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_facts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Fact</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_factid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_fact entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_actchargeablebilledsalesamount|Edm.Decimal|**Display Name**: Actual Chargeable Billed Sales Amount<br />|
|msdyn_actchargeablebilledsalesamount_base|Edm.Decimal|**Display Name**: Actual Chargeable Billed Sales Amount (Base)<br />**Description**: Value of the Actual Chargeable Billed Sales Amount in base currency.<br />Read-only<br />|
|msdyn_actchargeablebilledsalesquantity|Edm.Decimal|**Display Name**: Actual Chargeable Billed Sales Quantity<br />|
|msdyn_actchargeablecostamount|Edm.Decimal|**Display Name**: Actual Chargeable Cost Amount<br />|
|msdyn_actchargeablecostamount_base|Edm.Decimal|**Display Name**: Actual Chargeable Cost Amount (Base)<br />**Description**: Value of the Actual Chargeable Cost Amount in base currency.<br />Read-only<br />|
|msdyn_actchargeablecostquantity|Edm.Decimal|**Display Name**: Actual Chargeable Cost Quantity<br />|
|msdyn_actchargeableunbilledsalesamount|Edm.Decimal|**Display Name**: Actual Chargeable Unbilled Sales Amount<br />|
|msdyn_actchargeableunbilledsalesamount_base|Edm.Decimal|**Display Name**: Actual Chargeable Unbilled Sales Amount (Base)<br />**Description**: Value of the Actual Chargeable Unbilled Sales Amount in base currency.<br />Read-only<br />|
|msdyn_actchargeableunbilledsalesquantity|Edm.Decimal|**Display Name**: Actual Chargeable Unbilled Sales Quantity<br />|
|msdyn_actnochargebilledsalesamount|Edm.Decimal|**Display Name**: Actual No Charge Billed Sales Amount<br />|
|msdyn_actnochargebilledsalesamount_base|Edm.Decimal|**Display Name**: Actual No Charge Billed Sales Amount (Base)<br />**Description**: Value of the Actual No Charge Billed Sales Amount in base currency.<br />Read-only<br />|
|msdyn_actnochargebilledsalesquantity|Edm.Decimal|**Display Name**: Actual No Charge Billed Sales Quantity<br />|
|msdyn_actnochargecostamount|Edm.Decimal|**Display Name**: Actual No Charge Cost Amount<br />|
|msdyn_actnochargecostamount_base|Edm.Decimal|**Display Name**: Actual No Charge Cost Amount (Base)<br />**Description**: Value of the Actual No Charge Cost Amount in base currency.<br />Read-only<br />|
|msdyn_actnochargecostquantity|Edm.Decimal|**Display Name**: Actual No Charge Cost Quantity<br />|
|msdyn_actnochargeunbilledsalesamount|Edm.Decimal|**Display Name**: Actual No Charge Unbilled Sales Amount<br />|
|msdyn_actnochargeunbilledsalesamount_base|Edm.Decimal|**Display Name**: Actual No Charge Unbilled Sales Amount (Base)<br />**Description**: Value of the Actual No Charge Unbilled Sales Amount in base currency.<br />Read-only<br />|
|msdyn_actnochargeunbilledsalesquantity|Edm.Decimal|**Display Name**: Actual No Charge Unbilled Sales Quantity<br />|
|msdyn_actnonchargeablecostamount|Edm.Decimal|**Display Name**: Actual Non Chargeable Cost Amount<br />|
|msdyn_actnonchargeablecostamount_base|Edm.Decimal|**Display Name**: Actual Non Chargeable Cost Amount (Base)<br />**Description**: Value of the Actual Non Chargeable Cost Amount in base currency.<br />Read-only<br />|
|msdyn_actnonchargeablecostquantity|Edm.Decimal|**Display Name**: Actual Non Chargeable Cost Quantity<br />|
|msdyn_actnonchargeableunbilledsalesamount|Edm.Decimal|**Display Name**: Actual Non Chargeable Unbilled Sales Amount<br />|
|msdyn_actnonchargeableunbilledsalesamount_base|Edm.Decimal|**Display Name**: Actual Non Chargeable Unbilled Sales Amount (Base)<br />**Description**: Value of the Actual Non Chargeable Unbilled Sales Amount in base currency.<br />Read-only<br />|
|msdyn_actnonchargeableunbilledsalesquantity|Edm.Decimal|**Display Name**: Actual Non Chargeable Unbilled Sales Quantity<br />|
|msdyn_customertype|Edm.Int32|**Display Name**: Customer Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350001</td><td>Account</td></tr><tr><td>192350002</td><td>Contact</td></tr><tbody></table>|
|msdyn_documentdate|Edm.DateTimeOffset|**Display Name**: Document Date<br />**Description**: Enter the transaction date of the business event.<br />|
|msdyn_earnedrevenue|Edm.Decimal|**Display Name**: Earned Revenue<br />Computed<br />Read-only<br />|
|msdyn_earnedrevenue_base|Edm.Decimal|**Display Name**: Earned Revenue (Base)<br />**Description**: Value of the Earned Revenue in base currency.<br />Computed<br />Read-only<br />|
|msdyn_enddate|Edm.DateTimeOffset|**Display Name**: End Date<br />**Description**: Enter the end date for this transaction.<br />|
|msdyn_estchargeablebilledsalesamount|Edm.Decimal|**Display Name**: Estimated Chargeable Billed Sales Amount<br />|
|msdyn_estchargeablebilledsalesamount_base|Edm.Decimal|**Display Name**: Estimated Chargeable Billed Sales Amount (Base)<br />**Description**: Value of the Estimated Chargeable Billed Sales Amount in base currency.<br />Read-only<br />|
|msdyn_estchargeablebilledsalesquantity|Edm.Decimal|**Display Name**: Estimated Chargeable Billed Sales Quantity<br />|
|msdyn_estchargeablecostamount|Edm.Decimal|**Display Name**: Estimated Chargeable Cost Amount<br />|
|msdyn_estchargeablecostamount_base|Edm.Decimal|**Display Name**: Estimated Chargeable Cost Amount (Base)<br />**Description**: Value of the Estimated Chargeable Cost Amount in base currency.<br />Read-only<br />|
|msdyn_estchargeablecostquantity|Edm.Decimal|**Display Name**: Estimated Chargeable Cost Quantity<br />|
|msdyn_estchargeableunbilledsalesamount|Edm.Decimal|**Display Name**: Estimated Chargeable Unbilled Sales Amount<br />|
|msdyn_estchargeableunbilledsalesamount_base|Edm.Decimal|**Display Name**: Estimated Chargeable Unbilled Sales Amount (Base)<br />**Description**: Value of the Estimated Chargeable Unbilled Sales Amount in base currency.<br />Read-only<br />|
|msdyn_estchargeableunbilledsalesquantity|Edm.Decimal|**Display Name**: Estimated Chargeable Unbilled Sales Quantity<br />|
|msdyn_estnochargebilledsalesamount|Edm.Decimal|**Display Name**: Estimated No Charge Billed Sales Amount<br />|
|msdyn_estnochargebilledsalesamount_base|Edm.Decimal|**Display Name**: Estimated No Charge Billed Sales Amount (Base)<br />**Description**: Value of the Estimated No Charge Billed Sales Amount in base currency.<br />Read-only<br />|
|msdyn_estnochargebilledsalesquantity|Edm.Decimal|**Display Name**: Estimated No Charge Billed Sales Quantity<br />|
|msdyn_estnochargecostamount|Edm.Decimal|**Display Name**: Estimated No Charge Cost Amount<br />|
|msdyn_estnochargecostamount_base|Edm.Decimal|**Display Name**: Estimated No Charge Cost Amount (Base)<br />**Description**: Value of the Estimated No Charge Cost Amount in base currency.<br />Read-only<br />|
|msdyn_estnochargecostquantity|Edm.Decimal|**Display Name**: Estimated No Charge Cost Quantity<br />|
|msdyn_estnochargeunbilledsalesamount|Edm.Decimal|**Display Name**: Estimated No Charge Unbilled Sales Amount<br />|
|msdyn_estnochargeunbilledsalesamount_base|Edm.Decimal|**Display Name**: Estimated No Charge Unbilled Sales Amount (Base)<br />**Description**: Value of the Estimated No Charge Unbilled Sales Amount in base currency.<br />Read-only<br />|
|msdyn_estnochargeunbilledsalesquantity|Edm.Decimal|**Display Name**: Estimated No Charge Unbilled Sales Quantity<br />|
|msdyn_estnonchargeablecostamount|Edm.Decimal|**Display Name**: Estimated Non Chargeable Cost Amount<br />|
|msdyn_estnonchargeablecostamount_base|Edm.Decimal|**Display Name**: Estimated Non Chargeable Cost Amount (Base)<br />**Description**: Value of the Estimated Non Chargeable Cost Amount in base currency.<br />Read-only<br />|
|msdyn_estnonchargeablecostquantity|Edm.Decimal|**Display Name**: Estimated Non Chargeable Cost Quantity<br />|
|msdyn_estnonchargeableunbilledsalesamount|Edm.Decimal|**Display Name**: Estimated Non Chargeable Unbilled Sales Amount<br />|
|msdyn_estnonchargeableunbilledsalesamount_base|Edm.Decimal|**Display Name**: Estimated Non Chargeable Unbilled Sales Amount (Base)<br />**Description**: Value of the Estimated Non Chargeable Unbilled Sales Amount in base currency.<br />Read-only<br />|
|msdyn_estnonchargeableunbilledsalesquantity|Edm.Decimal|**Display Name**: Estimated Non Chargeable Unbilled Sales Quantity<br />|
|msdyn_factid|Edm.Guid|**Display Name**: Fact<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_facttype|Edm.Int32|**Display Name**: Fact Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Actual</td></tr><tr><td>192350001</td><td>Estimate</td></tr><tbody></table>|
|msdyn_grossmargin|Edm.Decimal|**Display Name**: Gross Margin<br />Computed<br />Read-only<br />|
|msdyn_grossmargin_base|Edm.Decimal|**Display Name**: Gross Margin (Base)<br />**Description**: Value of the Gross Margin in base currency.<br />Computed<br />Read-only<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_salescontractline|Edm.String|**Display Name**: Project Contract Line<br />|
|msdyn_startdate|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Enter the start date.<br />|
|msdyn_totalcost|Edm.Decimal|**Display Name**: Total Cost<br />Computed<br />Read-only<br />|
|msdyn_totalcost_base|Edm.Decimal|**Display Name**: Total Cost (Base)<br />**Description**: Value of the Total Cost in base currency.<br />Computed<br />Read-only<br />|
|msdyn_totalhours|Edm.Decimal|**Display Name**: Total Hours<br />Computed<br />Read-only<br />|
|msdyn_transactionclassification|Edm.Int32|**Display Name**: Transaction Classification<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Commission</td></tr><tr><td>690970001</td><td>Additional</td></tr><tr><td>690970002</td><td>Tax</td></tr><tr><td>192350000</td><td>Time</td></tr><tr><td>192350001</td><td>Expense</td></tr><tr><td>192350002</td><td>Material</td></tr><tr><td>192350003</td><td>Milestone</td></tr><tr><td>192350004</td><td>Fee</td></tr><tbody></table>|
|msdyn_vendortype|Edm.Int32|**Display Name**: Vendor Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350001</td><td>Account</td></tr><tr><td>192350002</td><td>Contact</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Fact<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Fact<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_accountcustomer_value|msdyn_AccountCustomer<br />||
|_msdyn_accountvendor_value|msdyn_AccountVendor<br />||
|_msdyn_bookableresource_value|msdyn_bookableresource<br />||
|_msdyn_contactcustomer_value|msdyn_ContactCustomer<br />||
|_msdyn_contactvendor_value|msdyn_ContactVendor<br />||
|_msdyn_estimate_value|msdyn_Estimate<br />||
|_msdyn_estimatelineid_value|msdyn_estimatelineid<br />||
|_msdyn_product_value|msdyn_Product<br />||
|_msdyn_project_value|msdyn_Project<br />||
|_msdyn_resourcecategory_value|msdyn_ResourceCategory<br />||
|_msdyn_salescontract_value|msdyn_SalesContract<br />||
|_msdyn_task_value|msdyn_Task<br />||
|_msdyn_transactioncategory_value|msdyn_TransactionCategory<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_fact_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_fact_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_fact_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_fact_modifiedonbehalfby|
|msdyn_AccountCustomer|[account EntityType](account.md)|msdyn_account_msdyn_fact_AccountCustomer|
|msdyn_AccountVendor|[account EntityType](account.md)|msdyn_account_msdyn_fact_AccountVendor|
|msdyn_bookableresource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_fact_bookableresource|
|msdyn_ContactCustomer|[contact EntityType](contact.md)|msdyn_contact_msdyn_fact_ContactCustomer|
|msdyn_ContactVendor|[contact EntityType](contact.md)|msdyn_contact_msdyn_fact_ContactVendor|
|msdyn_Estimate|[msdyn_estimate EntityType](msdyn_estimate.md)|msdyn_msdyn_estimate_msdyn_fact_Estimate|
|msdyn_estimatelineid|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_msdyn_estimateline_msdyn_fact_estimatelineid|
|msdyn_Product|[product EntityType](product.md)|msdyn_product_msdyn_fact_Product|
|msdyn_Project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_msdyn_fact_Project|
|msdyn_ResourceCategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory|
|msdyn_SalesContract|[salesorder EntityType](salesorder.md)|msdyn_salesorder_msdyn_fact_SalesContract|
|msdyn_Task|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_msdyn_projecttask_msdyn_fact_Task|
|msdyn_TransactionCategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_fact|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_fact|
|owningteam|[team EntityType](team.md)|team_msdyn_fact|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_fact|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_fact|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_fact_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_fact|  
|msdyn_fact_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_fact|  
|msdyn_fact_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_fact|  
|msdyn_fact_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_fact|  
|msdyn_fact_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_fact|  
|msdyn_fact_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_fact|  

## Operations
The following operations can be used with the msdyn_fact entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_fact entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_fact.md](./remarks/msdyn_fact.md)]

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