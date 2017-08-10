---
title: "Microsoft Dynamics 365 Customer Engagement sitemap EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2f5bc38f-ca1a-492c-a799-919d3b866935
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API sitemap entitytype."
---
# sitemap EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/sitemap.md](./descriptions/sitemap.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]sitemaps </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Site Map</td></tr>
<tr><td><b>Primary Key:</b></td><td>sitemapid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The sitemap EntityType:
* Has no collection-valued navigation properties.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|isappaware|Edm.Boolean|**Display Name**: IsAppAware<br />**Description**: Information about whether the site map is associated with app module.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|Read-only<br />|
|sitemapid|Edm.Guid|Read-only<br />|
|sitemapidunique|Edm.Guid|Read-only<br />|
|sitemapname|Edm.String||
|sitemapnameunique|Edm.String||
|sitemapxml|Edm.String||
|solutionid|Edm.Guid|Read-only<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|SiteMap_createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|SiteMap_createdonbehalfby<br />|Shows who created the record on behalfÂ of another user.|
|_modifiedby_value|SiteMap_modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|SiteMap_modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />||


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|organizationid|[organization EntityType](organization.md)|organization_sitemap|
|SiteMap_createdby|[systemuser EntityType](systemuser.md)|systemuser_SiteMap_createdby|
|SiteMap_createdonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_SiteMap_createdonbehalfby|
|SiteMap_modifiedby|[systemuser EntityType](systemuser.md)|systemuser_SiteMap_modifiedby|
|SiteMap_modifiedonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_SiteMap_modifiedonbehalfby|

## Operations
The following operations can be used with the sitemap entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|    

[!INCLUDE[./remarks/sitemap.md](./remarks/sitemap.md)]

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