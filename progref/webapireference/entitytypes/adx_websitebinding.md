---
title: "Microsoft Dynamics 365 Customer Engagement adx_websitebinding EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8de9391c-8cb5-4104-a153-1b238f86cbbf
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_websitebinding entitytype."
---
# adx_websitebinding EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_websitebinding.md](./descriptions/adx_websitebinding.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]adx_websitebindings </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Website Binding</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_websitebindingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_websitebinding entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_expirationdate|Edm.DateTimeOffset|**Display Name**: Expiration Date<br />|
|adx_hostname|Edm.String|**Display Name**: Host Name<br />|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|adx_port|Edm.Int32|**Display Name**: Port<br />|
|adx_releasedate|Edm.DateTimeOffset|**Display Name**: Release Date<br />|
|adx_sitename|Edm.String|**Display Name**: Site Name<br />|
|adx_urlmask|Edm.String|**Display Name**: URL Mask<br />|
|adx_virtualpath|Edm.String|**Display Name**: Virtual Path<br />|
|adx_websitebindingid|Edm.Guid|**Display Name**: Website Binding<br />**Description**: Shows the entity instance.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Website Binding<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the website binding's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_websiteid_value|adx_websiteid<br />|Unique identifier for Website associated with Website Binding.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Shows the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_websiteid|[adx_website EntityType](adx_website.md)|adx_website_websitebinding|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_websitebinding_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_websitebinding_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_websitebinding_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_websitebinding_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_adx_websitebinding|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_websitebinding_Annotations|[annotation EntityType](annotation.md)|objectid_adx_websitebinding|  
|adx_websitebinding_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_websitebinding|  
|adx_websitebinding_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_websitebinding|  
|adx_websitebinding_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_adx_websitebinding|  
|adx_websitebinding_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_adx_websitebinding|  
|adx_websitebinding_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_websitebinding|  

## Operations
The following operations can be used with the adx_websitebinding entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the adx_websitebinding entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|    

[!INCLUDE[./remarks/adx_websitebinding.md](./remarks/adx_websitebinding.md)]

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