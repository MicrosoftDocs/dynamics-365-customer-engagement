---
title: "Microsoft Dynamics 365 Customer Engagement bookableresourcecategory EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b3e15d91-244c-4344-aa8a-b95d0cbf9ada
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API bookableresourcecategory entitytype."
---
# bookableresourcecategory EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/bookableresourcecategory.md](./descriptions/bookableresourcecategory.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]bookableresourcecategories </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Bookable Resource Category</td></tr>
<tr><td><b>Primary Key:</b></td><td>bookableresourcecategoryid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The bookableresourcecategory entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bookableresourcecategoryid|Edm.Guid|**Display Name**: Resource Category<br />**Description**: Unique identifier of the resource category.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type a detailed description of what the categorization is about.<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the bookableresourcecategory with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_billingtype|Edm.Int32|**Display Name**: Billing Type<br />**Description**: Select the billing type for this resource role.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Non Chargeable</td></tr><tr><td>192350001</td><td>Chargeable</td></tr><tr><td>192350002</td><td>Complimentary</td></tr><tr><td>192350003</td><td>Not Available</td></tr><tbody></table>|
|msdyn_targetutilization|Edm.Int32|**Display Name**: Target Utilization<br />**Description**: Enter the target usage rate for this resource role.<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the resource category.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Resource Category<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Resource Category<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdbyname<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfbyname<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedbyname<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfbyname<br />|Unique identifier of the delegate user who modified the record.|
|_msdyn_transactioncategory_value|msdyn_TransactionCategory<br />|Enter the default transaction category for this resource role.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the BookableResourceCategory with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcecategory_createdby|
|createdonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcecategory_createdonbehalfby|
|modifiedbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcecategory_modifiedby|
|modifiedonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_bookableresourcecategory_modifiedonbehalfby|
|msdyn_TransactionCategory|[msdyn_transactioncategory EntityType](msdyn_transactioncategory.md)|msdyn_msdyn_transactioncategory_bookableresourcecategory_TransactionCategory|
|ownerid|[principal EntityType](principal.md)|owner_bookableresourcecategory|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_bookableresourcecategory|
|owningteam|[team EntityType](team.md)|team_bookableresourcecategory|
|owninguser|[systemuser EntityType](systemuser.md)|user_bookableresourcecategory|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_bookableresourcecategory|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|bookableresourcecategory_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_bookableresourcecategory|  
|bookableresourcecategory_bookableresourcecategoryassn_ResourceCategory|[bookableresourcecategoryassn EntityType](bookableresourcecategoryassn.md)|ResourceCategory|  
|bookableresourcecategory_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_bookableresourcecategory|  
|bookableresourcecategory_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_bookableresourcecategory|  
|bookableresourcecategory_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_bookableresourcecategory|  
|BookableResourceCategory_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_bookableresourcecategory_syncerror|  
|msdyn_bookableresourcecategory_bookableresourcebooking_resourcecategoryid|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_resourcecategoryid|  
|msdyn_bookableresourcecategory_bookableresourcebookingheader_resourcecategoryid|[bookableresourcebookingheader EntityType](bookableresourcebookingheader.md)|msdyn_resourcecategoryid|  
|msdyn_bookableresourcecategory_msdyn_actual_ResourceCategory|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_estimateline_ResourceCategory|[msdyn_estimateline EntityType](msdyn_estimateline.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_fact_ResourceCategory|[msdyn_fact EntityType](msdyn_fact.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_invoicelinetransaction_ResourceCategory|[msdyn_invoicelinetransaction EntityType](msdyn_invoicelinetransaction.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_journalline_ResourceCategory|[msdyn_journalline EntityType](msdyn_journalline.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_opportunitylineresourcecategory_ResourceCategory|[msdyn_opportunitylineresourcecategory EntityType](msdyn_opportunitylineresourcecategory.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_opportunitylinetransaction_ResourceCategory|[msdyn_opportunitylinetransaction EntityType](msdyn_opportunitylinetransaction.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_orderlineresourcecategory_ResourceCategory|[msdyn_orderlineresourcecategory EntityType](msdyn_orderlineresourcecategory.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_orderlinetransaction_ResourceCategory|[msdyn_orderlinetransaction EntityType](msdyn_orderlinetransaction.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_projectapproval_ResourceCategory|[msdyn_projectapproval EntityType](msdyn_projectapproval.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole|[msdyn_projectparameter EntityType](msdyn_projectparameter.md)|msdyn_projectmanagerrole|  
|msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole|[msdyn_projectparameter EntityType](msdyn_projectparameter.md)|msdyn_teammemberrole|  
|msdyn_bookableresourcecategory_msdyn_projecttask_resourcecategory|[msdyn_projecttask EntityType](msdyn_projecttask.md)|msdyn_resourcecategory|  
|msdyn_bookableresourcecategory_msdyn_projectteam_resourcecategory|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_resourcecategory|  
|msdyn_bookableresourcecategory_msdyn_quotelineanalyticsbreakdown_ResourceCategory|[msdyn_quotelineanalyticsbreakdown EntityType](msdyn_quotelineanalyticsbreakdown.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_quotelineresourcecategory_ResourceCategory|[msdyn_quotelineresourcecategory EntityType](msdyn_quotelineresourcecategory.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_quotelinetransaction_ResourceCategory|[msdyn_quotelinetransaction EntityType](msdyn_quotelinetransaction.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_resourcecategorypricelevel_ResourceCategory|[msdyn_resourcecategorypricelevel EntityType](msdyn_resourcecategorypricelevel.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_msdyn_resourcerequest_roleid|[msdyn_resourcerequest EntityType](msdyn_resourcerequest.md)|msdyn_roleid|  
|msdyn_bookableresourcecategory_msdyn_rolecompetencyrequirement_resourcecategory|[msdyn_rolecompetencyrequirement EntityType](msdyn_rolecompetencyrequirement.md)|msdyn_resourcecategory|  
|msdyn_bookableresourcecategory_msdyn_roleutilization_role|[msdyn_roleutilization EntityType](msdyn_roleutilization.md)|msdyn_role|  
|msdyn_bookableresourcecategory_msdyn_timeentry_resourceCategory|[msdyn_timeentry EntityType](msdyn_timeentry.md)|msdyn_resourceCategory|  
|msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory|[msdyn_requirementresourcecategory EntityType](msdyn_requirementresourcecategory.md)|msdyn_ResourceCategory|  
|msdyn_bookableresourcecategory_resourcerequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_roleid|  

## Operations
The following operations can be used with the bookableresourcecategory entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the bookableresourcecategory entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Microsoft Dynamics Scheduling Workload Solution](../solutions/scheduling.md)|[!INCLUDE[../solutions/descriptions/scheduling.md](../solutions/descriptions/scheduling.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/bookableresourcecategory.md](./remarks/bookableresourcecategory.md)]

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