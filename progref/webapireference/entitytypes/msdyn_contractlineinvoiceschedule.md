---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_contractlineinvoiceschedule EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 91508c25-8cf2-43b2-8bac-f49f627753d1
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_contractlineinvoiceschedule entitytype."
---
# msdyn_contractlineinvoiceschedule EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_contractlineinvoiceschedule.md](./descriptions/msdyn_contractlineinvoiceschedule.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_contractlineinvoiceschedules </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Project Contract Line Invoice Schedule</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_contractlineinvoicescheduleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_contractlineinvoiceschedule entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_contractline|Edm.String|**Display Name**: Project Contract Line<br />**Description**: Shows the associated project contract line for this invoice schedule.<br />|
|msdyn_contractlineinvoicescheduleid|Edm.Guid|**Display Name**: Project Contract Line Invoice Schedule<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_invoicerundate|Edm.DateTimeOffset|**Display Name**: Invoice Run Date<br />**Description**: Enter the date on which invoice should get created<br />|
|msdyn_invoicerunstatus|Edm.Int32|**Display Name**: Milestone status<br />**Description**: Select the milestone status, for example, Not Ready to Invoice, Ready to Invoice, On an invoice, or Invoiced.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Not Run</td></tr><tr><td>192350001</td><td>Run Successful</td></tr><tr><td>192350002</td><td>Run Failed</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|msdyn_transactioncutoffdate|Edm.DateTimeOffset|**Display Name**: Transaction Cut Off Date<br />**Description**: Enter the date before or on which the transaction will be picked for invoicing by the invoice creation job.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the project contract line invoice schedule<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the project contract line invoice schedule<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_contractlinescheduleofvalue_value|msdyn_ContractLineScheduleOfValue<br />|Select the billing milestone for a project contract line.|
|_msdyn_invoice_value|msdyn_Invoice<br />|Select the Invoice associated with Project contract line invoice schedule.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_contractlineinvoiceschedule_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_contractlineinvoiceschedule_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_contractlineinvoiceschedule_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_contractlineinvoiceschedule_modifiedonbehalfby|
|msdyn_ContractLineScheduleOfValue|[msdyn_contractlinescheduleofvalue EntityType](msdyn_contractlinescheduleofvalue.md)|msdyn_contractlinescheduleofvalue_msdyn_contractlineinvoiceschedule|
|msdyn_Invoice|[invoice EntityType](invoice.md)|msdyn_invoice_msdyn_contractlineinvoiceschedule_Invoice|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_contractlineinvoiceschedule|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_contractlineinvoiceschedule_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_contractlineinvoiceschedule|  
|msdyn_contractlineinvoiceschedule_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_contractlineinvoiceschedule|  
|msdyn_contractlineinvoiceschedule_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_contractlineinvoiceschedule|  
|msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_contractlineinvoiceschedule|  
|msdyn_contractlineinvoiceschedule_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_contractlineinvoiceschedule|  

## Operations
The following operations can be used with the msdyn_contractlineinvoiceschedule entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_contractlineinvoiceschedule entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_contractlineinvoiceschedule.md](./remarks/msdyn_contractlineinvoiceschedule.md)]

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