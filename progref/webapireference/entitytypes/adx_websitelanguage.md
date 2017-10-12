---
title: "Microsoft Dynamics 365 Customer Engagement adx_websitelanguage EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7d466338-9b8d-400b-ab8c-bc9ecee7e3c8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_websitelanguage entitytype."
---
# adx_websitelanguage EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_websitelanguage.md](./descriptions/adx_websitelanguage.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]adx_websitelanguages </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Website Language</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_websitelanguageid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_websitelanguage entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|adx_websitelanguageid|Edm.Guid|**Display Name**: Website Language<br />**Description**: Unique identifier for entity instances<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Website Language<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Website Language<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_portallanguageid_value|adx_PortalLanguageId<br />|lookup to Portal Language - one of the 43 supported Dynamics 365 languages that this website/language instance will use|
|_adx_publishingstate_value|adx_PublishingState<br />|Lookup to Publishing State - publishing state of this website/language instance (draft/published)|
|_adx_websiteid_value|adx_WebsiteId<br />|Lookup to Website|
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_PortalLanguageId|[adx_portallanguage EntityType](adx_portallanguage.md)|adx_adx_portallanguage_adx_websitelanguage|
|adx_PublishingState|[adx_publishingstate EntityType](adx_publishingstate.md)|adx_adx_publishingstate_adx_websitelanguage_PublishingState|
|adx_WebsiteId|[adx_website EntityType](adx_website.md)|adx_adx_website_adx_websitelanguage|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_websitelanguage_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_websitelanguage_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_websitelanguage_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_websitelanguage_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_adx_websitelanguage|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_adx_websitelanguage|
|owningteam|[team EntityType](team.md)|team_adx_websitelanguage|
|owninguser|[systemuser EntityType](systemuser.md)|user_adx_websitelanguage|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_adx_websitelanguage_adx_website_DefaultLanguage|[adx_website EntityType](adx_website.md)|adx_DefaultLanguage|  
|adx_websitelanguage_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_websitelanguage|  
|adx_websitelanguage_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_websitelanguage|  
|adx_websitelanguage_contentsnippet_contentsnippetlanguageid|[adx_contentsnippet EntityType](adx_contentsnippet.md)|adx_contentsnippetlanguageid|  
|adx_websitelanguage_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_websitelanguage|  
|adx_websitelanguage_weblinkset|[adx_weblinkset EntityType](adx_weblinkset.md)|adx_websitelanguageid|  
|adx_websitelanguage_webpage_webpagelanguageid|[adx_webpage EntityType](adx_webpage.md)|adx_webpagelanguageid|  
|msdyncrm_adx_websitelanguage_msdyncrm_marketingpage_portalswebsitelanguage|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_portalswebsitelanguage|  
|msdyncrm_adx_websitelanguage_msdyncrm_marketingpageconfiguration_portalswebsitelanguage|[msdyncrm_marketingpageconfiguration EntityType](msdyncrm_marketingpageconfiguration.md)|msdyncrm_portalswebsitelanguage|  

## Operations
The following operations can be used with the adx_websitelanguage entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the adx_websitelanguage entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|    

[!INCLUDE[./remarks/adx_websitelanguage.md](./remarks/adx_websitelanguage.md)]

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