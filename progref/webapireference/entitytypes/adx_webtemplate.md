---
title: "Microsoft Dynamics 365 Customer Engagement adx_webtemplate EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 97755787-7cc4-4346-bd6a-ebb75fbe9389
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_webtemplate entitytype."
---
# adx_webtemplate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_webtemplate.md](./descriptions/adx_webtemplate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]adx_webtemplates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Web Template</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_webtemplateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_webtemplate entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_mimetype|Edm.String|**Display Name**: MIME Type<br />**Description**: Shows the MIME type of the web template content.<br />|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|adx_source|Edm.String|**Display Name**: Source<br />|
|adx_webtemplateid|Edm.Guid|**Display Name**: Web Template<br />**Description**: Shows the entity instance.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Web Template<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the web template's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_websiteid_value|adx_websiteid<br />|Unique identifier for Website associated with Web Template|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Shows the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_websiteid|[adx_website EntityType](adx_website.md)|adx_website_adx_webtemplate|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_webtemplate_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webtemplate_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_webtemplate_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webtemplate_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_adx_webtemplate|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_webtemplate_ad|[adx_ad EntityType](adx_ad.md)|adx_webtemplateid|  
|adx_webtemplate_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|adx_webtemplateid|  
|adx_webtemplate_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_webtemplate|  
|adx_webtemplate_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_webtemplate|  
|adx_webtemplate_pagetemplate|[adx_pagetemplate EntityType](adx_pagetemplate.md)|adx_webtemplateid|  
|adx_webtemplate_poll|[adx_poll EntityType](adx_poll.md)|adx_webtemplateid|  
|adx_webtemplate_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_webtemplateid|  
|adx_webtemplate_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_webtemplate|  
|adx_webtemplate_website_footer|[adx_website EntityType](adx_website.md)|adx_footerwebtemplateid|  
|adx_webtemplate_website_header|[adx_website EntityType](adx_website.md)|adx_headerwebtemplateid|  
|msdyncrm_adx_webtemplate_msdyncrm_marketingpage_portalswebtemplate|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_portalswebtemplate|  

## Operations
The following operations can be used with the adx_webtemplate entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the adx_webtemplate entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|    

[!INCLUDE[./remarks/adx_webtemplate.md](./remarks/adx_webtemplate.md)]

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