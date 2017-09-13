---
title: "Microsoft Dynamics 365 Customer Engagement dataperformance EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0e56cc60-594d-42b3-8ca5-4f792801c410
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API dataperformance entitytype."
---
# dataperformance EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/dataperformance.md](./descriptions/dataperformance.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]dataperformances </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Data Performance Dashboard</td></tr>
<tr><td><b>Primary Key:</b></td><td>dataperformanceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The dataperformance EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|anyoptimizationapplied|Edm.Boolean|**Display Name**: Any Optimization Applied<br />**Description**: An internal state which indicates whether at least one optimization is applied.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|anyoptimizationavailable|Edm.Boolean|**Display Name**: Any Optimization Available<br />**Description**: An internal state which indicates whether at least one optimization is available for this record.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|component|Edm.String|**Display Name**: Component<br />**Description**: Name of the component<br />Read-only<br />|
|count|Edm.Int32|**Display Name**: Count<br />**Description**: Number of times a queries were executed (Aggregated)<br />Read-only<br />|
|dataperformanceid|Edm.Guid|**Display Name**: Id<br />**Description**: Unique identifier of the performance suggestion.<br />|
|entity|Edm.String|**Display Name**: Entity<br />**Description**: Primary entity<br />Read-only<br />|
|estimatedoptimizationimpact|Edm.Decimal|**Display Name**: Estimated Optimization Impact<br />**Description**: The expected average cost benefit of an optimization.<br />Read-only<br />|
|executionperiod|Edm.String|**Display Name**: Execution Period<br />**Description**: The execution period for which the performance metrics are calculated.<br />Read-only<br />|
|lastactionresult|Edm.String|**Display Name**: Last Action Result<br />**Description**: An internal state which shows the result of the last action that was taken on this record.<br />Read-only<br />|
|lastoptimizationdate|Edm.DateTimeOffset|**Display Name**: Last Optimization Date<br />**Description**: Last time an optimization was applied.<br />Read-only<br />|
|maxtime|Edm.Decimal|**Display Name**: Max Time<br />**Description**: Maximum execution time in seconds. (Aggregated)<br />Read-only<br />|
|mediantime|Edm.Decimal|**Display Name**: Median Time<br />**Description**: Average execution time in seconds. (Aggregated)<br />Read-only<br />|
|mintime|Edm.Decimal|**Display Name**: Min Time<br />**Description**: Minimum execution time in seconds. (Aggregated)<br />Read-only<br />|
|operation|Edm.String|**Display Name**: Operation<br />**Description**: Data operation that triggered the query (Retrieve Multiple, etc.)<br />Read-only<br />|
|optimizationstatus|Edm.String|**Display Name**: Optimization Status<br />**Description**: Current optimization status of the record, showed to the customer.<br />Read-only<br />|
|optimizationstorage|Edm.Decimal|**Display Name**: Optimization Storage<br />**Description**: Storage consumed by the optimization. (MB)<br />Read-only<br />|
|realizedoptimizationimpact|Edm.String|**Display Name**: Optimization Impact (%)<br />**Description**: Actual performance change after taking an optimization action on the record.<br />Read-only<br />|
|solution|Edm.String|**Display Name**: Solution<br />**Description**: Name of the solution that owns the component<br />Read-only<br />|
|weight|Edm.Decimal|**Display Name**: Weight<br />**Description**: Query Weight of the component. Factored with the Optimization Impact to determine the overall importance of applying an optimization. (P2)<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|organizationid|[organization EntityType](organization.md)|lk_dataperformance_organizationid|  

[!INCLUDE[./remarks/dataperformance.md](./remarks/dataperformance.md)]

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