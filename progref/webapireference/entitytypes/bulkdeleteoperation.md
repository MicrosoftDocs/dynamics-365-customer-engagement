---
title: "Microsoft Dynamics 365 Customer Engagement bulkdeleteoperation EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 217cf8dd-31de-4c7f-92b5-6488d32bbef7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API bulkdeleteoperation entitytype."
---
# bulkdeleteoperation EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/bulkdeleteoperation.md](./descriptions/bulkdeleteoperation.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]bulkdeleteoperations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Bulk Delete Operation</td></tr>
<tr><td><b>Primary Key:</b></td><td>bulkdeleteoperationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET,DELETE</td></tr>
</table>
  
The bulkdeleteoperation EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|bulkdeleteoperationid|Edm.Guid|**Display Name**: Bulk Deletion Job<br />**Description**: Unique identifier of the bulk deletion job.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Description**: Date and time when the bulk deletion job was created.<br />Read-only<br />|
|failurecount|Edm.Int32|**Display Name**: Failures<br />**Description**: Number of records that could not be deleted by the bulk deletion job.<br />Read-only<br />|
|isrecurring|Edm.Boolean|**Display Name**: Is Recurring<br />**Description**: Information about if recurrence is defined for the bulk deletion job.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the bulk deletion job record was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: System Job Name<br />**Description**: Name of the bulk deletion job.<br />Read-only<br />|
|nextrun|Edm.DateTimeOffset|**Display Name**: Next Run<br />**Description**: Next scheduled time for the bulk deletion job to run.<br />Read-only<br />|
|orderedquerysetxml|Edm.String|**Description**: Fetch XML of the ordered query set.<br />Read-only<br />|
|processingqeindex|Edm.Int32|**Display Name**: Query Index<br />**Description**: Index of the ordered query expression that defines the deletion set.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the bulk deletion job.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Ready</td></tr><tr><td>1</td><td>Suspended</td></tr><tr><td>2</td><td>Locked</td></tr><tr><td>3</td><td>Completed</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the bulk deletion job.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Waiting For Resources</td></tr><tr><td>10</td><td>Waiting</td></tr><tr><td>11</td><td>Retrying</td></tr><tr><td>12</td><td>Paused</td></tr><tr><td>20</td><td>In Progress</td></tr><tr><td>21</td><td>Pausing</td></tr><tr><td>22</td><td>Canceling</td></tr><tr><td>30</td><td>Succeeded</td></tr><tr><td>31</td><td>Failed</td></tr><tr><td>32</td><td>Canceled</td></tr><tbody></table>|
|successcount|Edm.Int32|**Display Name**: Deleted<br />**Description**: Number of records deleted by the bulk deletion job.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_asyncoperationid_value|asyncoperationid<br />|Unique identifier of the system job that created this record|
|_createdby_value|createdby<br />|Unique identifier of the user who created the bulk deletion job.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the bulkdeleteoperation.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the bulk deletion job.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the bulkdeleteoperation.|
|_ownerid_value||Unique identifier of the user or team who owns the bulk delete operation.|
|_owningbusinessunit_value|owningbusinessunit<br />|Business unit that owns the bulk deletion job.|
|_owninguser_value||Business user what owns the bulk delete operation.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|asyncoperationid|[asyncoperation EntityType](asyncoperation.md)|AsyncOperation_BulkDeleteOperation|
|createdby|[systemuser EntityType](systemuser.md)|lk_bulkdeleteoperationbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_bulkdeleteoperation_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_bulkdeleteoperationbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_bulkdeleteoperation_modifiedonbehalfby|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|BulkDeleteOperation_BusinessUnit|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|BulkDeleteOperation_BulkDeleteFailure|[bulkdeletefailure EntityType](bulkdeletefailure.md)|bulkdeleteoperationid|    

[!INCLUDE[./remarks/bulkdeleteoperation.md](./remarks/bulkdeleteoperation.md)]

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