---
title: "Microsoft Dynamics 365 Customer Engagement fixedmonthlyfiscalcalendar EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 14f9b797-7b68-4b1e-b077-97a6f23c2b36
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API fixedmonthlyfiscalcalendar entitytype."
---
# fixedmonthlyfiscalcalendar EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/fixedmonthlyfiscalcalendar.md](./descriptions/fixedmonthlyfiscalcalendar.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]fixedmonthlyfiscalcalendars </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Fixed Monthly Fiscal Calendar</td></tr>
<tr><td><b>Primary Key:</b></td><td>userfiscalcalendarid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The fixedmonthlyfiscalcalendar EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Description**: Date and time when the quota for the fixed monthly fiscal calendar was created.<br />Read-only<br />|
|effectiveon|Edm.DateTimeOffset|**Description**: Date and time when the fixed monthly fiscal calendar sales quota takes effect.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the fixed monthly fiscal calendar with respect to the base currency.<br />Read-only<br />|
|fiscalperiodtype|Edm.Int32|**Description**: Type of fiscal period used in the fixed monthly fiscal calendar sales quota.<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Description**: Date and time when the fixed monthly fiscal calendar was last modified.<br />Read-only<br />|
|period1|Edm.Decimal|**Description**: Sales quota for the first period in the fiscal year.<br />|
|period1_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the first period in the fiscal year.<br />Read-only<br />|
|period10|Edm.Decimal|**Description**: Sales quota for the tenth period in the fiscal year.<br />|
|period10_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the tenth period in the fiscal year.<br />Read-only<br />|
|period11|Edm.Decimal|**Description**: Sales quota for the eleventh period in the fiscal year.<br />|
|period11_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the eleventh period in the fiscal year.<br />Read-only<br />|
|period12|Edm.Decimal|**Description**: Sales quota for the twelfth period in the fiscal year.<br />|
|period12_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the twelfth period in the fiscal year.<br />Read-only<br />|
|period13|Edm.Decimal|**Description**: Sales quota for the thirteenth period in the fiscal year.<br />|
|period13_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the thirteenth period in the fiscal year.<br />Read-only<br />|
|period2|Edm.Decimal|**Description**: Sales quota for the second period in the fiscal year.<br />|
|period2_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the second period in the fiscal year.<br />Read-only<br />|
|period3|Edm.Decimal|**Description**: Sales quota for the third period in the fiscal year.<br />|
|period3_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the third period in the fiscal year.<br />Read-only<br />|
|period4|Edm.Decimal|**Description**: Sales quota for the fourth period in the fiscal year.<br />|
|period4_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the fourth period in the fiscal year.<br />Read-only<br />|
|period5|Edm.Decimal|**Description**: Sales quota for the fifth period in the fiscal year.<br />|
|period5_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the fifth period in the fiscal year.<br />Read-only<br />|
|period6|Edm.Decimal|**Description**: Sales quota for the sixth period in the fiscal year.<br />|
|period6_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the sixth period in the fiscal year.<br />Read-only<br />|
|period7|Edm.Decimal|**Description**: Sales quota for the seventh period in the fiscal year.<br />|
|period7_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the seventh period in the fiscal year.<br />Read-only<br />|
|period8|Edm.Decimal|**Description**: Sales quota for the eighth period in the fiscal year.<br />|
|period8_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the eighth period in the fiscal year.<br />Read-only<br />|
|period9|Edm.Decimal|**Description**: Sales quota for the ninth period in the fiscal year.<br />|
|period9_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the ninth period in the fiscal year.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|userfiscalcalendarid|Edm.Guid|**Description**: Unique identifier of the user of the fiscal calendar.<br />|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_businessunitid_value||Business unit responsible for the quota associated with this calendar.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the fiscal calendar.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the fixedmonthlyfiscalcalendar.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the fixed monthly fiscal calendar.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the fixedmonthlyfiscalcalendar.|
|_salespersonid_value|salespersonid<br />|Unique identifier of the associated salesperson.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the fixed monthly fiscal calendar.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_fixedmonthlyfiscalcalendar_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_fixedmonthlyfiscalcalendar_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_fixedmonthlyfiscalcalendar_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby|
|salespersonid|[systemuser EntityType](systemuser.md)|lk_fixedmonthlyfiscalcalendar_salespersonid|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_fixedmonthlyfiscalcalendar|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|FixedMonthlyFiscalCalendar_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_fixedmonthlyfiscalcalendar|  
|FixedMonthlyFiscalCalendar_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_fixedmonthlyfiscalcalendar|    

[!INCLUDE[./remarks/fixedmonthlyfiscalcalendar.md](./remarks/fixedmonthlyfiscalcalendar.md)]

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