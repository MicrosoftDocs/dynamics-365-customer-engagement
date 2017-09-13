---
title: "Microsoft Dynamics 365 Customer Engagement actioncarduserstate EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4591f25d-0c8e-4e6b-8a11-144c7e5c2e4b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API actioncarduserstate entitytype."
---
# actioncarduserstate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/actioncarduserstate.md](./descriptions/actioncarduserstate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]actioncarduserstates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>ActionCardUserState</td></tr>
<tr><td><b>Primary Key:</b></td><td>actioncarduserstateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The actioncarduserstate EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|actioncarduserstateid|Edm.Guid|**Display Name**: ActionCardUserState<br />**Description**: Unique identifier for entity instances<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the ActionCardUserState with respect to the base currency.<br />Read-only<br />|
|startdate|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Shows the Start Date<br />|
|state|Edm.Int32|**Display Name**: Action Card State<br />**Description**: State of the Action Card<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Dismissed</td></tr><tr><td>2</td><td>Completed</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_actioncardid_value|actioncardid<br />|Parent ActionCard Id.|
|_ownerid_value||Unique identifier of the user or team who owns the state of this action card.|
|_owningbusinessunit_value||Unique identifier for the business unit that owns the record|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the ActionCardUserState with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|actioncardid|[actioncard EntityType](actioncard.md)|ActionCardUserState_ActionCard|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_ActionCardUserState|  

[!INCLUDE[./remarks/actioncarduserstate.md](./remarks/actioncarduserstate.md)]

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