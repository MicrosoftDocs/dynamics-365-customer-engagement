---
title: "Microsoft Dynamics 365 Customer Engagement monthlyfiscalcalendar EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ac0ae5fe-fde3-4e08-bd03-fe9ea8009855
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API monthlyfiscalcalendar entitytype."
---
# monthlyfiscalcalendar EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/monthlyfiscalcalendar.md](./descriptions/monthlyfiscalcalendar.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]monthlyfiscalcalendars </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Monthly Fiscal Calendar</td></tr>
<tr><td><b>Primary Key:</b></td><td>userfiscalcalendarid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The monthlyfiscalcalendar EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Description**: Date and time when the quota for the monthly fiscal calendar was modified.<br />Read-only<br />|
|effectiveon|Edm.DateTimeOffset|**Description**: Date and time when the monthly fiscal calendar sales quota takes effect.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the monthly fiscal calendar with respect to the base currency.<br />Read-only<br />|
|fiscalperiodtype|Edm.Int32|**Description**: Type of fiscal period used in the sales quota.<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Description**: Date and time when the quota for the monthly fiscal calendar was last modified.<br />Read-only<br />|
|month1|Edm.Decimal|**Description**: Sales quota for the first month in the fiscal year.<br />|
|month1_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the first month in the fiscal year.<br />Read-only<br />|
|month10|Edm.Decimal|**Description**: Sales quota for the tenth month in the fiscal year.<br />|
|month10_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the tenth month in the fiscal year.<br />Read-only<br />|
|month11|Edm.Decimal|**Description**: Sales quota for the eleventh month in the fiscal year.<br />|
|month11_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the eleventh month in the fiscal year.<br />Read-only<br />|
|month12|Edm.Decimal|**Description**: Sales quota for the twelfth month in the fiscal year.<br />|
|month12_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the twelfth month in the fiscal year.<br />Read-only<br />|
|month2|Edm.Decimal|**Description**: Sales quota for the second month in the fiscal year.<br />|
|month2_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the second month in the fiscal year.<br />Read-only<br />|
|month3|Edm.Decimal|**Description**: Sales quota for the third month in the fiscal year.<br />|
|month3_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the third month in the fiscal year.<br />Read-only<br />|
|month4|Edm.Decimal|**Description**: Sales quota for the fourth month in the fiscal year.<br />|
|month4_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the fourth month in the fiscal year.<br />Read-only<br />|
|month5|Edm.Decimal|**Description**: Sales quota for the fifth month in the fiscal year.<br />|
|month5_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the fifth month in the fiscal year.<br />Read-only<br />|
|month6|Edm.Decimal|**Description**: Sales quota for the sixth month in the fiscal year.<br />|
|month6_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the sixth month in the fiscal year.<br />Read-only<br />|
|month7|Edm.Decimal|**Description**: Sales quota for the seventh month in the fiscal year.<br />|
|month7_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the seventh month in the fiscal year.<br />Read-only<br />|
|month8|Edm.Decimal|**Description**: Sales quota for the eighth month in the fiscal year.<br />|
|month8_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the eighth month in the fiscal year.<br />Read-only<br />|
|month9|Edm.Decimal|**Description**: Sales quota for the ninth month in the fiscal year.<br />|
|month9_base|Edm.Decimal|**Description**: Base currency equivalent of the sales quota for the ninth month in the fiscal year.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|userfiscalcalendarid|Edm.Guid|**Description**: Unique identifier of the monthly fiscal calendar.<br />|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_businessunitid_value|||
|_createdby_value|createdby<br />|Unique identifier of the user who created the fiscal calendar.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the monthlyfiscalcalendar.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the quota for the monthly fiscal calendar.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the monthlyfiscalcalendar.|
|_salespersonid_value|salespersonid<br />|Unique identifier of the associated salesperson.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the monthly fiscal calendar.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_monthlyfiscalcalendar_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_monthlyfiscalcalendar_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_monthlyfiscalcalendar_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_monthlyfiscalcalendar_modifiedonbehalfby|
|salespersonid|[systemuser EntityType](systemuser.md)|lk_monthlyfiscalcalendar_salespersonid|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_monthlyfiscalcalendar|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|MonthlyFiscalCalendar_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_monthlyfiscalcalendar|  
|MonthlyFiscalCalendar_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_monthlyfiscalcalendar|    

[!INCLUDE[./remarks/monthlyfiscalcalendar.md](./remarks/monthlyfiscalcalendar.md)]

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