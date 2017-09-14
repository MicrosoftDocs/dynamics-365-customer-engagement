---
title: "Microsoft Dynamics 365 Customer Engagement adx_webfile EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1454bee4-f0b7-4875-92d3-473a56093a77
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_webfile entitytype."
---
# adx_webfile EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_webfile.md](./descriptions/adx_webfile.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]adx_webfiles </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Web File</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_webfileid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_webfile entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_alloworigin|Edm.String|**Display Name**: Allow Origin<br />**Description**: Defines CORS header Access-Control-Allow-Origin for cross origin requests.<br />|
|adx_cloudblobaddress|Edm.String|**Display Name**: Cloud Blob Address<br />|
|adx_contentdisposition|Edm.Int32|**Display Name**: Content-Disposition<br />**Description**: Shows the value to be applied to the HTTP Response Headers Content-Disposition.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>inline</td></tr><tr><td>756150001</td><td>attachment</td></tr><tbody></table>|
|adx_createdbyipaddress|Edm.String|**Display Name**: Created By IP Address<br />|
|adx_createdbyusername|Edm.String|**Display Name**: Created By Username<br />|
|adx_displaydate|Edm.DateTimeOffset|**Display Name**: Display Date<br />|
|adx_displayorder|Edm.Int32|**Display Name**: Display Order<br />|
|adx_enabletracking|Edm.Boolean|**Display Name**: Enable Tracking<br />**Description**: Select whether to enable logging of users' downloads of this web file.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_excludefromsearch|Edm.Boolean|**Display Name**: Exclude From Search<br />**Description**: Shows whether the web file is excluded from the portal search.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_expirationdate|Edm.DateTimeOffset|**Display Name**: Expiration Date<br />|
|adx_hiddenfromsitemap|Edm.Boolean|**Display Name**: Hidden From Sitemap<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_modifiedbyipaddress|Edm.String|**Display Name**: Modified By IP Address<br />|
|adx_modifiedbyusername|Edm.String|**Display Name**: Modified By Username<br />|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Shows the name of the custom entity.<br />|
|adx_partialurl|Edm.String|**Display Name**: Partial URL<br />|
|adx_releasedate|Edm.DateTimeOffset|**Display Name**: Release Date<br />|
|adx_summary|Edm.String|**Display Name**: Summary<br />|
|adx_title|Edm.String|**Display Name**: Title<br />|
|adx_webfileid|Edm.Guid|**Display Name**: Web File<br />**Description**: Unique identifier for entity instances<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows when the record was updated.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows when the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Web File<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Web File<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_masterwebfileid_value|adx_masterwebfileid<br />|Unique identifier for Web File associated with Web File.|
|_adx_parentpageid_value|adx_parentpageid<br />|Unique identifier for Web Page associated with Web File.|
|_adx_publishingstateid_value|adx_publishingstateid<br />|Unique identifier for Publishing State associated with Web File.|
|_adx_subjectid_value|adx_subjectid<br />|Unique identifier for Subject associated with Web File.|
|_adx_websiteid_value|adx_websiteid<br />|Unique identifier for Website associated with Web File.|
|_createdby_value|createdby<br />|Shows the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows the user who updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Shows the owner ID.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_masterwebfileid|[adx_webfile EntityType](adx_webfile.md)|adx_webfile_masterwebfile|
|adx_parentpageid|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_webfile|
|adx_publishingstateid|[adx_publishingstate EntityType](adx_publishingstate.md)|adx_publishingstate_webfile|
|adx_subjectid|[subject EntityType](subject.md)|adx_subject_webfile|
|adx_websiteid|[adx_website EntityType](adx_website.md)|adx_website_webfile|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_webfile_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webfile_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_webfile_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webfile_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_adx_webfile|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_adx_webfile|
|owningteam|[team EntityType](team.md)|team_adx_webfile|
|owninguser|[systemuser EntityType](systemuser.md)|user_adx_webfile|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_redirectwebfile_ad|[adx_ad EntityType](adx_ad.md)|adx_redirectwebfileid|  
|adx_webfile_ad|[adx_ad EntityType](adx_ad.md)|adx_webfileid|  
|adx_webfile_Annotations|[annotation EntityType](annotation.md)|objectid_adx_webfile|  
|adx_webfile_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_webfile|  
|adx_webfile_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_webfile|  
|adx_webfile_masterwebfile|[adx_webfile EntityType](adx_webfile.md)|adx_masterwebfileid|  
|adx_webfile_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_WebFileId|  
|adx_webfile_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_webfile|  
|adx_webfile_urlhistory|[adx_urlhistory EntityType](adx_urlhistory.md)|adx_webfileid|  
|adx_webfile_webfilelog|[adx_webfilelog EntityType](adx_webfilelog.md)|adx_webfileid|  
|adx_webfile_webpage_image|[adx_webpage EntityType](adx_webpage.md)|adx_image|  

## Operations
The following operations can be used with the adx_webfile entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the adx_webfile entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|  
|[Dynamics 365 Portals - Portal Dependencies Solution](../solutions/microsoftcrmportaldependencies.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportaldependencies.md](../solutions/descriptions/microsoftcrmportaldependencies.md)]|    

[!INCLUDE[./remarks/adx_webfile.md](./remarks/adx_webfile.md)]

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