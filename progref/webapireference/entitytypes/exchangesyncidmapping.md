---
title: "Microsoft Dynamics 365 Customer Engagement exchangesyncidmapping EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 45e4ab03-bb03-4a5d-bdab-ff67ece5be87
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API exchangesyncidmapping entitytype."
---
# exchangesyncidmapping EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/exchangesyncidmapping.md](./descriptions/exchangesyncidmapping.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]exchangesyncidmappings </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Exchange Sync Id Mapping</td></tr>
<tr><td><b>Primary Key:</b></td><td>exchangesyncidmappingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The exchangesyncidmapping EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangeentryid|Edm.String||
|exchangesyncidmappingid|Edm.Guid||
|fromcrmchangetype|Edm.Int32||
|isdeletedinexchange|Edm.Boolean|**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isunlinkedincrm|Edm.Boolean|**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lastsyncerror|Edm.String||
|lastsyncerrorcode|Edm.Int32||
|lastsyncerroroccurredon|Edm.DateTimeOffset|**Display Name**: Last Sync Error Time<br />**Description**: Last Sync Error Time<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|objectid|Edm.Guid||
|objecttypecode|Edm.Int32||
|retries|Edm.Int32||
|tocrmchangetype|Edm.Int32||
|userdecision|Edm.Int32||
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_ownerid_value|ownerid<br />||
|_owningbusinessunit_value|owningbusinessunit<br />||
|_owningteam_value|owningteam<br />||
|_owninguser_value|owninguser<br />||


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|ownerid|[principal EntityType](principal.md)|owner_exchangesyncidmapping|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_exchangesyncidmapping|
|owningteam|[team EntityType](team.md)|team_exchangesyncidmapping|
|owninguser|[systemuser EntityType](systemuser.md)|user_exchangesyncidmapping|  

[!INCLUDE[./remarks/exchangesyncidmapping.md](./remarks/exchangesyncidmapping.md)]

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