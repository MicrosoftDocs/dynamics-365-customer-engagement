---
title: "Microsoft Dynamics 365 Customer Engagement semiannualfiscalcalendar EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 84a64b37-1c22-4244-aa6a-ce91c205fcf4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API semiannualfiscalcalendar entitytype."
---
# semiannualfiscalcalendar EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/semiannualfiscalcalendar.md](./descriptions/semiannualfiscalcalendar.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]semiannualfiscalcalendars </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Semiannual Fiscal Calendar</td></tr>
<tr><td><b>Primary Key:</b></td><td>userfiscalcalendarid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The semiannualfiscalcalendar EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Description**: Date and time when the quota for the semiannual fiscal calendar was created.<br />Read-only<br />|
|effectiveon|Edm.DateTimeOffset|**Description**: Date and time when the semiannual fiscal calendar sales quota takes effect.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the semiannual fiscal calendar with respect to the base currency.<br />Read-only<br />|
|firsthalf|Edm.Decimal|**Description**: Sales quota for the first half of the fiscal year.<br />|
|firsthalf_base|Edm.Decimal|**Description**: Base currency equivalent for the sales quota for the first half of the fiscal year.<br />Read-only<br />|
|fiscalperiodtype|Edm.Int32|**Description**: Type of fiscal period used in the sales quota.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Description**: Date and time when the semiannual fiscal calendar was last modified.<br />Read-only<br />|
|secondhalf|Edm.Decimal|**Description**: Sales quota for the second half of the fiscal year.<br />|
|secondhalf_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the second half of the fiscal year.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|userfiscalcalendarid|Edm.Guid|**Description**: Unique identifier for the user who created the semiannual fiscal calendar.<br />|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_businessunitid_value||Unique identifier of the business unit with which the calendar is associated.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the semiannual fiscal calendar.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the semiannualfiscalcalendar.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the semiannual fiscal calendar.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the semiannualfiscalcalendar.|
|_salespersonid_value|salespersonid<br />|Unique identifier of the associated salesperson.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the semiannual fiscal calendar.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_semiannualfiscalcalendar_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_semiannualfiscalcalendar_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_semiannualfiscalcalendar_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_semiannualfiscalcalendar_modifiedonbehalfby|
|salespersonid|[systemuser EntityType](systemuser.md)|lk_semiannualfiscalcalendar_salespersonid|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_semiannualfiscalcalendar|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|SemiAnnualFiscalCalendar_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_semiannualfiscalcalendar|  
|SemiAnnualFiscalCalendar_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_semiannualfiscalcalendar|    

[!INCLUDE[./remarks/semiannualfiscalcalendar.md](./remarks/semiannualfiscalcalendar.md)]

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