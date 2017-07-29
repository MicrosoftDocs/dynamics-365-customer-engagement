---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_transactioncategory EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2c9820c2-57e3-43f5-beaa-bac16c4c156a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_transactioncategory entitytype."
---
# msdyn_transactioncategory EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_transactioncategory.md](./descriptions/msdyn_transactioncategory.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_transactioncategories </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Transaction Category</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_transactioncategoryid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_transactioncategory entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_billingtype|Edm.Int32|**Display Name**: Billing Type<br />**Description**: Select the default billing type of project transactions in this category. Valid values are Chargeable, Non chargeable or Complimentary. Only chargeable transactions will add to an invoice total<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Non Chargeable</td></tr><tr><td>192350001</td><td>Chargeable</td></tr><tr><td>192350002</td><td>Complimentary</td></tr><tr><td>192350003</td><td>Not Available</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|msdyn_transactioncategoryid|Edm.Guid|**Display Name**: Transaction Category<br />**Description**: Unique identifier for entity instances<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Transaction Category<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Transaction Category<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_defaultunit_value|msdyn_DefaultUnit<br />||
|_msdyn_unitgroup_value|msdyn_UnitGroup<br />|Select the unit schedule that is associated with the transaction category.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_transactioncategory_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_transactioncategory_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_transactioncategory_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_transactioncategory_modifiedonbehalfby|
|msdyn_DefaultUnit|[uom EntityType](uom.md)|msdyn_uom_msdyn_transactioncategory_DefaultUnit|
|msdyn_UnitGroup|[uomschedule EntityType](uomschedule.md)|msdyn_uomschedule_msdyn_transactioncategory_UnitGroup|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_transactioncategory|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory|[bookableresourcecategory EntityType](bookableresourcecategory.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_actual_TransactionCategory|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_estimateline_TransactionCategory|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_expensecatego|[msdyn_expensecategory EntityType](msdyn_expensecategory.md)|msdyn_ExpenseCategoryuId|  
|msdyn_msdyn_transactioncategory_msdyn_fact_TransactionCategory|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_invoicelinetransaction_TransactionCategory|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_journalline_TransactionCategory|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransaction_TransactionCategory|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_opportunitylinetransactioncategory_TransactionCategory|[msdyn_opportunitylinetransactioncategory EntityType](msdyn_opportunitylinetransactioncategory.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_orderlinetransaction_TransactionCategory|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_orderlinetransactioncategory_TransactionCategory|[msdyn_orderlinetransactioncategory EntityType](msdyn_orderlinetransactioncategory.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_projectapproval_TransactionCategory|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_projecttask_transactioncategory|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_transactioncategory|  
|msdyn_msdyn_transactioncategory_msdyn_projecttransactioncategory_TransactionCategory|[msdyn_projecttransactioncategory EntityType](msdyn_projecttransactioncategory.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_quotelineanalyticsbreakdown_TransactionCategory|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_quotelinetransaction_TransactionCategory|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_quotelinetransactioncategory_TransactionCategory|[msdyn_quotelinetransactioncategory EntityType](msdyn_quotelinetransactioncategory.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_msdyn_transactioncategoryclassification_transactioncategory|[msdyn_transactioncategoryclassification EntityType](msdyn_transactioncategoryclassification.md)|msdyn_transactioncategory|  
|msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ChildCategory|[msdyn_transactioncategoryhierarchyelement EntityType](msdyn_transactioncategoryhierarchyelement.md)|msdyn_ChildCategory|  
|msdyn_msdyn_transactioncategory_msdyn_transactioncategoryhierarchyelement_ParentCategory|[msdyn_transactioncategoryhierarchyelement EntityType](msdyn_transactioncategoryhierarchyelement.md)|msdyn_ParentCategory|  
|msdyn_msdyn_transactioncategory_msdyn_transactioncategorypricelevel_TransactionCategory|[msdyn_transactioncategorypricelevel EntityType](msdyn_transactioncategorypricelevel.md)|msdyn_TransactionCategory|  
|msdyn_msdyn_transactioncategory_product_TransactionCategory|[product EntityType](product.md)|msdyn_TransactionCategory|  
|msdyn_transactioncategory_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_transactioncategory|  
|msdyn_transactioncategory_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_transactioncategory|  
|msdyn_transactioncategory_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_transactioncategory|  
|msdyn_transactioncategory_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_transactioncategory|  
|msdyn_transactioncategory_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_transactioncategory|  
|msdyn_transactioncategory_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_transactioncategory|  

## Operations
The following operations can be used with the msdyn_transactioncategory entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_transactioncategory entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_transactioncategory.md](./remarks/msdyn_transactioncategory.md)]

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