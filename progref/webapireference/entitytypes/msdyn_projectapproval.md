---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_projectapproval EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 939a5d4b-9a6e-4ed3-b2aa-a9af4e846f81
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_projectapproval entitytype."
---
# msdyn_projectapproval EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_projectapproval.md](./descriptions/msdyn_projectapproval.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_projectapprovals </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Project Approval</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_projectapprovalid</td></tr>
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
|msdyn_approvedon|Edm.DateTimeOffset|**Display Name**: Approved On<br />**Description**: Shows the date of the approval.<br />|
|msdyn_billingtype|Edm.Int32|**Display Name**: Billing Type<br />**Description**: Billing type for the project approval line.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Non Chargeable</td></tr><tr><td>192350001</td><td>Chargeable</td></tr><tr><td>192350002</td><td>Complimentary</td></tr><tr><td>192350003</td><td>Not Available</td></tr><tbody></table>|
|msdyn_costamount|Edm.Decimal|**Display Name**: Cost Amount<br />**Description**: Shows the cost amount of the transaction.<br />Computed<br />Read-only<br />|
|msdyn_costamount_base|Edm.Decimal|**Display Name**: Cost Amount (Base)<br />**Description**: Value of the Cost Amount in base currency.<br />Computed<br />Read-only<br />|
|msdyn_costprice|Edm.Decimal|**Display Name**: Cost Price<br />**Description**: Shows the cost price of the transaction.<br />|
|msdyn_costprice_base|Edm.Decimal|**Display Name**: Cost Price (Base)<br />**Description**: Value of the Cost Price in base currency.<br />Read-only<br />|
|msdyn_costquantity|Edm.Decimal|**Display Name**: Submitted (hrs)<br />**Description**: Shows the hours submitted for the transaction.<br />|
|msdyn_date|Edm.DateTimeOffset|**Display Name**: Date<br />**Description**: Shows the date of the transaction.<br />|
|msdyn_entrytype|Edm.Int32|**Display Name**: Entry Type<br />**Description**: Shows the entry type of the transaction.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Time</td></tr><tr><td>1</td><td>Expense</td></tr><tbody></table>|
|msdyn_externalcomments|Edm.String|**Display Name**: External Comments<br />**Description**: Shows the external comments entered for the transaction.<br />|
|msdyn_hasreceipt|Edm.Boolean|**Display Name**: Has Receipt<br />**Description**: Shows whether the transaction has a receipt.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_internalcomments|Edm.String|**Display Name**: Internal Comments<br />**Description**: Shows the internal comments entered for the transaction.<br />|
|msdyn_journaltransaction|Edm.String|**Display Name**: JournalTransaction<br />**Description**: Shows whether the transaction was entered by a journal.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_projectapprovalid|Edm.Guid|**Display Name**: ApprovalsTable<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_recordstage|Edm.Int32|**Display Name**: Record Stage<br />**Description**: Shows the stage of the record.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>3</td><td>Pending</td></tr><tr><td>0</td><td>Submitted</td></tr><tr><td>1</td><td>Rejected</td></tr><tr><td>2</td><td>Approved</td></tr><tbody></table>|
|msdyn_referenceexpenseid|Edm.String|**Display Name**: Reference expense id<br />**Description**: Shows the reference ID for the expense entry.<br />|
|msdyn_referencetimeid|Edm.String|**Display Name**: Reference time id<br />|
|msdyn_salesamount|Edm.Decimal|**Display Name**: Sales Amount<br />**Description**: Shows the sales amount of the transaction.<br />Computed<br />Read-only<br />|
|msdyn_salesamount_base|Edm.Decimal|**Display Name**: Sales Amount (Base)<br />**Description**: Value of the Sales Amount in base currency.<br />Computed<br />Read-only<br />|
|msdyn_salesprice|Edm.Decimal|**Display Name**: Sales Price<br />**Description**: Shows the sales price of the transaction.<br />|
|msdyn_salesprice_base|Edm.Decimal|**Display Name**: Sales Price (Base)<br />**Description**: Value of the Sales Price in base currency.<br />Read-only<br />|
|msdyn_salesquantity|Edm.Decimal|**Display Name**: Billable (hrs)<br />**Description**: Shows the billable hours for the transaction.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the ApprovalsTable<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the ApprovalsTable<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_approvedby_value|msdyn_ApprovedBy<br />|Shows the name of the approver.|
|_msdyn_bookableresource_value|msdyn_bookableresource<br />|Shows the resource that the entry is submitted for.|
|_msdyn_expensecategory_value|msdyn_ExpenseCategory<br />|Shows the expense category of the transaction.|
|_msdyn_expenseentry_value|msdyn_ExpenseEntry<br />|Expense Entry Id.|
|_msdyn_manager_value|msdyn_Manager<br />|Shows the manager of the person who submitted the transaction.|
|_msdyn_project_value|msdyn_Project<br />|Shows the project for the transaction.|
|_msdyn_projecttask_value|msdyn_ProjectTask<br />|Shows the project task for the transaction.|
|_msdyn_referencejournalline_value|msdyn_referencejournalline<br />|Shows the journal line ID for the journal transaction.|
|_msdyn_resourcecategory_value|msdyn_ResourceCategory<br />|Shows the role for the resource for this transaction.|
|_msdyn_submittedby_value|msdyn_SubmittedBy<br />|Resource that has submitted the entry for approval.|
|_msdyn_timeentry_value|msdyn_TimeEntry<br />|Time Entry Id.|
|_msdyn_transactioncategory_value|msdyn_TransactionCategory<br />|Shows the transaction category.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Shows the currency associated with the entity.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectapproval_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectapproval_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectapproval_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectapproval_modifiedonbehalfby|
|msdyn_ApprovedBy|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_projectapproval_ApprovedBy|
|msdyn_bookableresource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_projectapproval_bookableresource|
|msdyn_ExpenseCategory|[msdyn_expensecategory EntityType](msdyn_expensecategory.md)|msdyn_msdyn_expensecategory_msdyn_projectapproval_ExpenseCategory|
|msdyn_ExpenseEntry|[msdyn_expense EntityType](msdyn_expense.md)|msdyn_msdyn_expense_msdyn_projectapproval_ExpenseEntry|
|msdyn_Manager|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_projectapproval_Manager|
|msdyn_Project|[msdyn_project EntityType](msdyn_project.md)|msdyn_msdyn_project_msdyn_projectapproval_Project|
|msdyn_ProjectTask|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_msdyn_projecttask_msdyn_projectapproval_ProjectTask|
|msdyn_referencejournalline|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_msdyn_journalline_msdyn_projectapproval_referencejournalline|
|msdyn_ResourceCategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory|
|msdyn_SubmittedBy|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_projectapproval_SubmittedBy|
|msdyn_TimeEntry|[msdyn_timeentry EntityType](msdyn_timeentry.md)|msdyn_msdyn_timeentry_msdyn_projectapproval_TimeEntry|
|msdyn_TransactionCategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_projectapproval|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_projectapproval|
|owningteam|[team EntityType](team.md)|team_msdyn_projectapproval|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_projectapproval|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_msdyn_projectapproval|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_projectapproval_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_projectapproval|  
|msdyn_projectapproval_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_projectapproval|  
|msdyn_projectapproval_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_projectapproval|  
|msdyn_projectapproval_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_projectapproval|  
|msdyn_projectapproval_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_projectapproval|  
|msdyn_projectapproval_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_projectapproval|  

## Operations
The following operations can be used with the msdyn_projectapproval entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[msdyn_ApprovalStatusApprove Action](../actions/msdyn_approvalstatusapprove.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_approvalstatusapprove.md](../actions/descriptions/msdyn_approvalstatusapprove.md)]|  
|[msdyn_ApprovalStatusReject Action](../actions/msdyn_approvalstatusreject.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_approvalstatusreject.md](../actions/descriptions/msdyn_approvalstatusreject.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_projectapproval entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_projectapproval.md](./remarks/msdyn_projectapproval.md)]

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