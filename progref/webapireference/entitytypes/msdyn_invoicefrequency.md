---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_invoicefrequency EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9922d84e-f63e-4884-8927-bc4fb5288433
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_invoicefrequency entitytype."
---
# msdyn_invoicefrequency EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_invoicefrequency.md](./descriptions/msdyn_invoicefrequency.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_invoicefrequencies </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Invoice Frequency</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_invoicefrequencyid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_invoicefrequency entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_daysofrun|Edm.Int32|**Display Name**: Setup of runs<br />**Description**: Describes how the run days per period interval are setup. As weekdays (Monday, Tuesday...) or day of period (1st, 2nd…) <br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Day of period</td></tr><tr><td>192350001</td><td>Weekday of period</td></tr><tbody></table>|
|msdyn_invoicefrequencyid|Edm.Guid|**Display Name**: Invoice Frequency<br />**Description**: Shows the entity instances.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|msdyn_period|Edm.Int32|**Display Name**: Period<br />**Description**: Select the period used for the setup of invoice frequency: supported values are Monthly, Weekly or Bi Weekly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Weekly</td></tr><tr><td>192350001</td><td>Monthly</td></tr><tr><td>192350002</td><td>Biweekly</td></tr><tbody></table>|
|msdyn_runspermonth|Edm.Int32|**Display Name**: Runs per period<br />**Description**: Select the number of times invoicing should run in a period.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>1</td></tr><tr><td>2</td><td>2</td></tr><tr><td>3</td><td>3</td></tr><tr><td>4</td><td>4</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Invoice Frequency<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Invoice Frequency<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_invoicefrequency_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_invoicefrequency_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_invoicefrequency_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_invoicefrequency_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_invoicefrequency|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_invoicefrequency_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_invoicefrequency|  
|msdyn_invoicefrequency_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_invoicefrequency|  
|msdyn_invoicefrequency_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_invoicefrequency|  
|msdyn_invoicefrequency_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_invoicefrequency|  
|msdyn_invoicefrequency_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_invoicefrequency|  
|msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency|[msdyn_invoicefrequencydetail EntityType](msdyn_invoicefrequencydetail.md)|msdyn_invoicefrequency|  
|msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency|[msdyn_projectparameter EntityType](msdyn_projectparameter.md)|msdyn_invoicefrequency|  
|msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency|[quotedetail EntityType](quotedetail.md)|msdyn_invoicefrequency|  
|msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency|[salesorderdetail EntityType](salesorderdetail.md)|msdyn_invoicefrequency|  

## Operations
The following operations can be used with the msdyn_invoicefrequency entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_invoicefrequency entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_invoicefrequency.md](./remarks/msdyn_invoicefrequency.md)]

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