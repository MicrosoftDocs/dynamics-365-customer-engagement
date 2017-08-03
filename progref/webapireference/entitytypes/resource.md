---
title: "Microsoft Dynamics 365 Customer Engagement resource EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 47cfa220-5a0f-4fff-ab23-bac85d479464
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API resource entitytype."
---
# resource EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/resource.md](./descriptions/resource.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]resources </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Resource</td></tr>
<tr><td><b>Primary Key:</b></td><td>resourceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|calendarid|Edm.Guid|**Display Name**: Calendar<br />**Description**: Unique identifier of the calendar for the resource.<br />|
|displayinserviceviews|Edm.Boolean|**Display Name**: Display in Service Views<br />**Description**: For internal use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: Shows the default image for the record.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|isdisabled|Edm.Boolean|**Display Name**: Is Disabled<br />**Description**: Information about whether the resource is enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the resource.<br />|
|objecttypecode|Edm.String|**Display Name**: Object Type <br />**Description**: Type of entity with which the resource is associated.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|resourceid|Edm.Guid|**Display Name**: Resource<br />**Description**: Unique identifier of the resource.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_businessunitid_value|businessunitid<br />|Business Unit Id|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the resource is associated.|
|_siteid_value|siteid<br />|Unique identifier of the site at which the resource is located.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|businessunitid|[businessunit EntityType](businessunit.md)|business_unit_resources|
|organizationid|[organization EntityType](organization.md)|organization_resources|
|resourceid_equipment|[equipment EntityType](equipment.md)|equipment_resources|
|resourceid_resourcespec|[resourcespec EntityType](resourcespec.md)|resourcespec_resources|
|resourceid_systemuser|[systemuser EntityType](systemuser.md)|systemuser_resources|
|siteid|[site EntityType](site.md)|site_resources|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|Resource_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_resource|  
|Resource_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_resource|  
|Resource_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_resource_syncerror|  

## Operations
The following operations can be used with the resource entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveByGroupResource Function](../functions/retrievebygroupresource.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievebygroupresource.md](../functions/descriptions/retrievebygroupresource.md)]|  
|[RetrieveByResourceResourceGroup Function](../functions/retrievebyresourceresourcegroup.md)|Entity|[!INCLUDE[../functions/descriptions/retrievebyresourceresourcegroup.md](../functions/descriptions/retrievebyresourceresourcegroup.md)]|  

## Solutions
The following solutions include the resource entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/resource.md](./remarks/resource.md)]

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