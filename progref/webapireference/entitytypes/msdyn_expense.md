---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_expense EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5f240686-d19d-427c-abfb-e83a06404447
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_expense entitytype."
---
# msdyn_expense EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_expense.md](./descriptions/msdyn_expense.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_expenses </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Expense</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_expenseid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the entity with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_amount|Edm.Decimal|**Display Name**: Amount<br />**Description**: Enter the total amount for expense.<br />|
|msdyn_amount_base|Edm.Decimal|**Display Name**: Amount (Base)<br />**Description**: Value of the Amount in base currency.<br />Read-only<br />|
|msdyn_expenseid|Edm.Guid|**Display Name**: Expense<br />**Description**: Shows the entity instances.<br />|
|msdyn_expensestatus|Edm.Int32|**Display Name**: Expense Status<br />**Description**: Shows the status of the expense entry.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>Submitted</td></tr><tr><td>192350002</td><td>Approved</td></tr><tr><td>192350003</td><td>Rejected</td></tr><tr><td>192350004</td><td>Posted</td></tr><tr><td>192350005</td><td>Paid</td></tr><tbody></table>|
|msdyn_externaldescription|Edm.String|**Display Name**: External Comments<br />**Description**: The external comments of the expense entry.<br />|
|msdyn_name|Edm.String|**Display Name**: Expense Purpose<br />**Description**: Enter the expense's purpose.<br />|
|msdyn_salestaxamount|Edm.Decimal|**Display Name**: Sales tax amount<br />**Description**: Enter the sales tax amount.<br />|
|msdyn_salestaxamount_base|Edm.Decimal|**Display Name**: Sales tax amount (Base)<br />**Description**: Value of the Sales tax amount in base currency.<br />Read-only<br />|
|msdyn_targetexpensestatus|Edm.Int32|**Display Name**: Target Expense Status<br />**Description**: Shows the status that the record will be transitioned to asynchronously. Currently, this is only implemented from submission to approved.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>Submitted</td></tr><tr><td>192350002</td><td>Approved</td></tr><tr><td>192350003</td><td>Rejected</td></tr><tr><td>192350004</td><td>Posted</td></tr><tr><td>192350005</td><td>Paid</td></tr><tbody></table>|
|msdyn_totalamount|Edm.Decimal|**Display Name**: Total Amount<br />**Description**: Shows the total amount of the expense entry.<br />Computed<br />Read-only<br />|
|msdyn_totalamount_base|Edm.Decimal|**Display Name**: Total Amount (Base)<br />**Description**: Enter the value of the total amount in the base currency.<br />Computed<br />Read-only<br />|
|msdyn_transactiondate|Edm.DateTimeOffset|**Display Name**: Transaction Date<br />**Description**: Enter the date of the expense transaction.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Expense<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Expense<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>867380000</td><td>Draft</td></tr><tr><td>867380001</td><td>Rejected</td></tr><tr><td>867380002</td><td>Submitted</td></tr><tr><td>867380003</td><td>Approved</td></tr><tr><td>867380004</td><td>Posted</td></tr><tr><td>867380005</td><td>Paid</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
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
|_msdyn_bookableresource_value|msdyn_bookableresource<br />|Shows the bookable resource..|
|_msdyn_expensecategory_value|msdyn_ExpenseCategory<br />|Enter the expense category.|
|_msdyn_manager_value|msdyn_manager<br />|Select the manager of the expense user. This field is used for approval.|
|_msdyn_project_value|msdyn_Project<br />|Enter the project.|
|_msdyn_resourceorganizationalunitid_value|msdyn_ResourceOrganizationalUnitId<br />|Select the organizational unit at the time the entry was registered of the resource who had the expense.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_stageid_value|stageid<br />|Contains the id of the stage where the entity is located.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_expense_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_expense_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_expense_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_expense_modifiedonbehalfby|
|msdyn_bookableresource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_expense_bookableresource|
|msdyn_ExpenseCategory|[msdyn_expensecategory EntityType](msdyn_expensecategory.md)|msdyn_msdyn_expensecategory_msdyn_expense_ExpenseCategory|
|msdyn_manager|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_expense_manager|
|msdyn_Project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_msdyn_expense_Project|
|msdyn_ResourceOrganizationalUnitId|[msdyn_organizationalunit EntityType](msdyn_organizationalunit.md)|msdyn_organizationalunit_expense|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_expense|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_expense|
|owningteam|[team EntityType](team.md)|team_msdyn_expense|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_expense|
|stageid|[processstage EntityType](processstage.md)|processstage_msdyn_expense|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_expense|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_expense_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_expense|  
|msdyn_expense_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_expense|  
|msdyn_expense_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_expense|  
|msdyn_expense_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_expense|  
|msdyn_expense_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_expense|  
|msdyn_expense_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_msdyn_expense|  
|msdyn_expense_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_expense|  
|msdyn_msdyn_expense_msdyn_expensereceipt_ExpenseId|[msdyn_expensereceipt EntityType](msdyn_expensereceipt.md)|msdyn_ExpenseId|  
|msdyn_msdyn_expense_msdyn_projectapproval_ExpenseEntry|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_ExpenseEntry|  

## Operations
The following operations can be used with the msdyn_expense entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_ExpenseApproveAction Action](../actions/msdyn_expenseapproveaction.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_expenseapproveaction.md](../actions/descriptions/msdyn_expenseapproveaction.md)]|  
|[msdyn_ExpenseRejectAction Action](../actions/msdyn_expenserejectaction.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_expenserejectaction.md](../actions/descriptions/msdyn_expenserejectaction.md)]|  
|[msdyn_ExpenseSubmitAction Action](../actions/msdyn_expensesubmitaction.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_expensesubmitaction.md](../actions/descriptions/msdyn_expensesubmitaction.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_expense entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_expense.md](./remarks/msdyn_expense.md)]

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