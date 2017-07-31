---
title: "Microsoft Dynamics 365 Customer Engagement slaitem EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3dcb4125-028d-44a4-874f-62eeef593d62
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API slaitem entitytype."
---
# slaitem EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/slaitem.md](./descriptions/slaitem.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]slaitems </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>SLA Item</td></tr>
<tr><td><b>Primary Key:</b></td><td>slaitemid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The slaitem entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|applicablewhenxml|Edm.String|**Display Name**: ApplicableWhenXml<br />**Description**: Condition for SLA item<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the SLA Item<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate between the currency associated with the SLA Item record and the base currency.<br />Read-only<br />|
|failureafter|Edm.Int32|**Display Name**: Failure After<br />**Description**: Select how soon the success criteria must be met until the SLA item is considered failed and failure actions are initiated. The actual duration is based on the business hours as specified in the associated SLA record.<br />|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a descriptive name of the service level agreement (SLA) item.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|relatedfield|Edm.String|**Display Name**: Related Case Field<br />**Description**: Select the service level agreement (SLA) key performance indicator (KPI) that this SLA Item is created for.<br />|
|sequencenumber|Edm.Int32|**Display Name**: Sequence<br />**Description**: Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.<br />|
|slaitemid|Edm.Guid|**Display Name**: SLA Item<br />**Description**: Unique identifier of the SLA Item.<br />|
|slaitemidunique|Edm.Guid|**Display Name**: Unique Id<br />**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|successconditionsxml|Edm.String|**Display Name**: SuccessConditionsXml<br />**Description**: Condition for SLA item<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the SLA Item.<br />Read-only<br />|
|warnafter|Edm.Int32|**Display Name**: Warn After<br />**Description**: Select how soon the success criteria must be met before warning actions are initiated. The actual duration is based on the business hours as specified in the associated SLA record.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who created the record on behalf of another user.|
|_ownerid_value||Enter the user or team who owns the SLA. This field is updated every time the item is assigned to a different user.|
|_owningbusinessunit_value||Unique identifier for the business unit that owns the record|
|_owninguser_value||Unique identifier of the user who owns the SLA Item record.|
|_slaid_value|slaid<br />|Unique identifier for SLA associated with SLA Item.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the SLA Item record.|
|_workflowid_value|workflowid<br />|Workflow associated with the SLA Item.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_slaitembase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_slaitembase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_slaitembase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_slaitembase_modifiedonbehalfby|
|slaid|[sla EntityType](sla.md)|sla_slaitem_slaId|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_SLAItem|
|workflowid|[workflow EntityType](workflow.md)|slaitembase_workflowid|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|SLAItem_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_slaitem_syncerror|  

## Solutions
The following solutions include the slaitem entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics CRM Service Level Agreement (SLA) Solution](../solutions/servicelevelagreement.md)|[!INCLUDE[../solutions/descriptions/servicelevelagreement.md](../solutions/descriptions/servicelevelagreement.md)]|    

[!INCLUDE[./remarks/slaitem.md](./remarks/slaitem.md)]

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