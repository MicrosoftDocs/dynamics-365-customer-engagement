---
title: "Microsoft Dynamics 365 Customer Engagement campaignactivityitem EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d8e2ca9a-7bc8-4143-9f7d-b119baee344c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API campaignactivityitem entitytype."
---
# campaignactivityitem EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/campaignactivityitem.md](./descriptions/campaignactivityitem.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]campaignactivityitems </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Campaign Activity Item</td></tr>
<tr><td><b>Primary Key:</b></td><td>campaignactivityitemid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,DELETE</td></tr>
</table>
  
The campaignactivityitem entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|campaignactivityitemid|Edm.Guid|**Description**: Unique identifier of the campaign activity item.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|itemid|Edm.Guid|**Description**: Unique identifier of the item.<br />|
|itemobjecttypecode|Edm.String|**Description**: Identification of the type of the campaign activity item.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: name<br />**Description**: name<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|owningbusinessunit|Edm.Guid|**Description**: Unique identifier of the business unit that owns the campaign activity item.<br />Read-only<br />|
|owninguser|Edm.Guid|**Description**: Unique identifier of the user that owns the campaign activity item.<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_campaignactivityid_value|campaignactivityid<br />|Unique identifier of the campaign activity for the item.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value||Unique identifier of the user or team who owns the campaign activity item.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|campaignactivityid|[activitypointer EntityType](activitypointer.md)|ActivityPointer_CampaignActivityItems|
|createdby|[systemuser EntityType](systemuser.md)|lk_campaignactivityitem_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_campaignactivityitem_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_campaignactivityitem_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_campaignactivityitem_modifiedonbehalfby|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|campaignactivityitem_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_campaignactivityitem|  
|campaignactivityitem_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_campaignactivityitem|  

## Solutions
The following solutions include the campaignactivityitem entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics CRM Marketing Solution](../solutions/marketing.md)|[!INCLUDE[../solutions/descriptions/marketing.md](../solutions/descriptions/marketing.md)]|    

[!INCLUDE[./remarks/campaignactivityitem.md](./remarks/campaignactivityitem.md)]

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