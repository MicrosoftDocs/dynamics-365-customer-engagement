---
title: "Microsoft Dynamics 365 Customer Engagement adx_webpageaccesscontrolrule EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5f62c644-ba17-4198-a177-af4b16fc3c65
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_webpageaccesscontrolrule entitytype."
---
# adx_webpageaccesscontrolrule EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_webpageaccesscontrolrule.md](./descriptions/adx_webpageaccesscontrolrule.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]adx_webpageaccesscontrolrules </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Web Page Access Control Rule</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_webpageaccesscontrolruleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_webpageaccesscontrolrule entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_description|Edm.String|**Display Name**: Description<br />|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|adx_right|Edm.Int32|**Display Name**: Right<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Grant Change</td></tr><tr><td>2</td><td>Restrict Read</td></tr><tbody></table>|
|adx_scope|Edm.Int32|**Display Name**: Scope<br />**Description**: All child web files directly related to this web page will be excluded from security validation. This does not exclude the children's descendants.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>All content</td></tr><tr><td>2</td><td>Exclude direct child web files</td></tr><tbody></table>|
|adx_webpageaccesscontrolruleid|Edm.Guid|**Display Name**: Webpage Access Control Rule<br />**Description**: Shows the entity instance.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Web Page Access Control Rule<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the webpage access control rule's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_webpageid_value|adx_webpageid<br />|Unique identifier for Web Page associated with Web Page Access Control Rule.|
|_adx_websiteid_value|adx_websiteid<br />|Unique identifier for Website associated with Web Page Access Control Rule.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_webpageid|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_webpageaccesscontrolrule|
|adx_websiteid|[adx_website EntityType](adx_website.md)|adx_website_webpageaccesscontrolrule|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_webpageaccesscontrolrule_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webpageaccesscontrolrule_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_webpageaccesscontrolrule_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webpageaccesscontrolrule_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_adx_webpageaccesscontrolrule|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_adx_webpageaccesscontrolrule|
|owningteam|[team EntityType](team.md)|team_adx_webpageaccesscontrolrule|
|owninguser|[systemuser EntityType](systemuser.md)|user_adx_webpageaccesscontrolrule|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_accesscontrolrule_publishingstate|[adx_publishingstate EntityType](adx_publishingstate.md)|adx_accesscontrolrule_publishingstate|  
|adx_webpageaccesscontrolrule_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_webpageaccesscontrolrule|  
|adx_webpageaccesscontrolrule_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_webpageaccesscontrolrule|  
|adx_webpageaccesscontrolrule_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_webpageaccesscontrolrule|  
|adx_webpageaccesscontrolrule_webrole|[adx_webrole EntityType](adx_webrole.md)|adx_webpageaccesscontrolrule_webrole|  

## Operations
The following operations can be used with the adx_webpageaccesscontrolrule entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the adx_webpageaccesscontrolrule entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|    

[!INCLUDE[./remarks/adx_webpageaccesscontrolrule.md](./remarks/adx_webpageaccesscontrolrule.md)]

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