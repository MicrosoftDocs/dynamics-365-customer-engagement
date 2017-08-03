---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_contractlinescheduleofvalue EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 723faf43-b534-49dd-88ae-02612e5ff216
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_contractlinescheduleofvalue entitytype."
---
# msdyn_contractlinescheduleofvalue EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_contractlinescheduleofvalue.md](./descriptions/msdyn_contractlinescheduleofvalue.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_contractlinescheduleofvalues </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Project Contract Line Milestone</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_contractlinescheduleofvalueid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_contractlinescheduleofvalue entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_amount|Edm.Decimal|**Display Name**: Milestone Amount<br />**Description**: Enter the value of the milestone.<br />|
|msdyn_amount_after_tax|Edm.Decimal|**Display Name**: amount_after_tax<br />Computed<br />Read-only<br />|
|msdyn_amount_after_tax_base|Edm.Decimal|**Display Name**: amount_after_tax (Base)<br />**Description**: Value of the amount_after_tax in base currency.<br />Computed<br />Read-only<br />|
|msdyn_amount_base|Edm.Decimal|**Display Name**: Amount (Base)<br />**Description**: Value of the Amount in base currency.<br />Read-only<br />|
|msdyn_contractline|Edm.String|**Display Name**: Project Contract Line<br />**Description**: Shows the project contract line that has this milestone<br />|
|msdyn_contractlinedescription|Edm.String|**Display Name**: Project Contract Line Description<br />**Description**: Enter a description of the project contract line that has this milestone.<br />|
|msdyn_contractlinescheduleofvalueid|Edm.Guid|**Display Name**: Project Contract Line Milestone<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_description|Edm.String|**Display Name**: Milestone Description<br />**Description**: Type a description of the milestone.<br />|
|msdyn_externaldescription|Edm.String|**Display Name**: External Description<br />**Description**: Description of the project contract line milestone<br />|
|msdyn_invoicedate|Edm.DateTimeOffset|**Display Name**: Milestone Date<br />**Description**: Enter the date of which this milestone should be achieved<br />|
|msdyn_invoicestatus|Edm.Int32|**Display Name**: Invoice Status<br />**Description**: Select the status of invoicing of this milestone<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Not Ready for invoicing</td></tr><tr><td>192350001</td><td>Ready for invoicing</td></tr><tr><td>192350002</td><td>Customer invoice created</td></tr><tr><td>192350003</td><td>Customer invoice posted</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Milestone Name<br />**Description**: Type the name of the milestone.<br />|
|msdyn_price|Edm.Decimal|**Display Name**: Price<br />**Description**: Enter the price of the transaction.<br />|
|msdyn_price_base|Edm.Decimal|**Display Name**: Price (Base)<br />**Description**: Value of the Price in base currency.<br />Read-only<br />|
|msdyn_startdatetime|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Date of project contract line milestone<br />|
|msdyn_tax|Edm.Decimal|**Display Name**: tax<br />|
|msdyn_tax_base|Edm.Decimal|**Display Name**: tax (Base)<br />**Description**: Value of the tax in base currency.<br />Read-only<br />|
|msdyn_transactionclassification|Edm.Int32|**Display Name**: Transaction Class<br />**Description**: Transaction classification of the project contract line milestone<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Commission</td></tr><tr><td>690970001</td><td>Additional</td></tr><tr><td>690970002</td><td>Tax</td></tr><tr><td>192350000</td><td>Time</td></tr><tr><td>192350001</td><td>Expense</td></tr><tr><td>192350002</td><td>Material</td></tr><tr><td>192350003</td><td>Milestone</td></tr><tr><td>192350004</td><td>Fee</td></tr><tbody></table>|
|msdyn_transactiontypecode|Edm.Int32|**Display Name**: Transaction Type<br />**Description**: Transaction type of the project contract line milestone<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Cost</td></tr><tr><td>192350004</td><td>Project Contract</td></tr><tr><td>192350005</td><td>Unbilled Sales</td></tr><tr><td>192350006</td><td>Billed Sales</td></tr><tr><td>192350007</td><td>Resourcing Unit Cost</td></tr><tr><td>192350008</td><td>Inter-Organizational Sales</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the project contract line milestone.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the project contract line milestone.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_contract_value|msdyn_contract<br />|Select the project contract associated with this milestone.|
|_msdyn_project_value|msdyn_project<br />|Select the project that is tracking the work required to achieve this milestone.|
|_msdyn_projecttask_value|msdyn_projecttask<br />|Select the project work breakdown structure (WBS) task that is tracking the work for this milestone.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_contractlinescheduleofvalue_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_contractlinescheduleofvalue_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_contractlinescheduleofvalue_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_contractlinescheduleofvalue_modifiedonbehalfby|
|msdyn_contract|[salesorder EntityType](salesorder.md)|msdyn_salesorder_msdyn_contractlinescheduleofvalue_contract|
|msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_msdyn_contractlinescheduleofvalue_project|
|msdyn_projecttask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_msdyn_projecttask_msdyn_contractlinescheduleofvalue_projecttask|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_contractlinescheduleofvalue|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_contractlinescheduleofvalue|
|owningteam|[team EntityType](team.md)|team_msdyn_contractlinescheduleofvalue|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_contractlinescheduleofvalue|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_contractlinescheduleofvalue|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_contractlinescheduleofvalue_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_contractlinescheduleofvalue|  
|msdyn_contractlinescheduleofvalue_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_contractlinescheduleofvalue|  
|msdyn_contractlinescheduleofvalue_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_contractlinescheduleofvalue|  
|msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_contractlinescheduleofvalue|  
|msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule|[msdyn_contractlineinvoiceschedule EntityType](msdyn_contractlineinvoiceschedule.md)|msdyn_ContractLineScheduleOfValue|  
|msdyn_contractlinescheduleofvalue_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_contractlinescheduleofvalue|  

## Operations
The following operations can be used with the msdyn_contractlinescheduleofvalue entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_contractlinescheduleofvalue entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_contractlinescheduleofvalue.md](./remarks/msdyn_contractlinescheduleofvalue.md)]

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