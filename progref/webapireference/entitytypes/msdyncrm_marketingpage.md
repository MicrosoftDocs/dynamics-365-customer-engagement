---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_marketingpage EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 26ba894e-4e46-444b-99bc-e3e380e6fd94
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_marketingpage entitytype."
---
# msdyncrm_marketingpage EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_marketingpage.md](./descriptions/msdyncrm_marketingpage.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyncrm_marketingpages </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Marketing Page</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_marketingpageid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_marketingpage entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_alloweddomains|Edm.String|**Display Name**: Known Domains<br />|
|msdyncrm_content|Edm.String|**Display Name**: Content<br />|
|msdyncrm_contenttype|Edm.Int32|**Display Name**: Content type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Structural</td></tr><tr><td>1</td><td>Product launch</td></tr><tr><td>2</td><td>Product information</td></tr><tr><td>3</td><td>Company background</td></tr><tr><td>4</td><td>Event information</td></tr><tr><td>5</td><td>Offers and discounts</td></tr><tbody></table>|
|msdyncrm_formpagemapping|Edm.String|**Display Name**: Form page mapping<br />|
|msdyncrm_full_page_url|Edm.String|**Display Name**: Full page URL<br />|
|msdyncrm_insightssubmissions|Edm.String|**Display Name**: Insights Submissions<br />|
|msdyncrm_insightssummarykpi|Edm.String|**Display Name**: Insights Summary KPI<br />|
|msdyncrm_insightssummarypies|Edm.String|**Display Name**: Insights Summary Pies<br />|
|msdyncrm_insightsvisits|Edm.String|**Display Name**: Insights Visits<br />|
|msdyncrm_lastpublisheddate|Edm.DateTimeOffset|**Display Name**: Last Published Date<br />**Description**: Date and time that the Marketing Page was published last time.<br />|
|msdyncrm_lastunpublisheddate|Edm.DateTimeOffset|**Display Name**: Last Unpublished Date<br />**Description**: Date and time that the Marketing Page was unpublished last time.<br />|
|msdyncrm_marketingpageid|Edm.Guid|**Display Name**: Marketing Page<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_markettype|Edm.Int32|**Display Name**: Market type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Enterprise</td></tr><tr><td>1</td><td>Consumer</td></tr><tr><td>2</td><td>All</td></tr><tbody></table>|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyncrm_optimizedfor|Edm.Int32|**Display Name**: Optimized for<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Desktop</td></tr><tr><td>1</td><td>Tablet</td></tr><tr><td>2</td><td>Mobile</td></tr><tbody></table>|
|msdyncrm_partialurl|Edm.String|**Display Name**: Partial Url<br />|
|msdyncrm_purpose|Edm.Int32|**Display Name**: Purpose<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Contact capture</td></tr><tr><td>1</td><td>Newsletter subscription</td></tr><tr><td>2</td><td>Lead generation</td></tr><tr><td>3</td><td>Collateral download</td></tr><tr><td>4</td><td>Event registration</td></tr><tr><td>5</td><td>Event feedback</td></tr><tbody></table>|
|msdyncrm_remote_websiteid|Edm.String|**Display Name**: Remote Website ID<br />**Description**: Unique identifier for remote entity instances<br />|
|msdyncrm_type|Edm.Int32|**Display Name**: Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Landing page</td></tr><tr><td>1</td><td>Subscription center</td></tr><tr><td>2</td><td>Forward to friend</td></tr><tbody></table>|
|msdyncrm_visualstyle|Edm.Int32|**Display Name**: Visual style<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Light</td></tr><tr><td>1</td><td>Dark</td></tr><tr><td>2</td><td>Colorful</td></tr><tr><td>3</td><td>Other</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Marketing Page<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Marketing Page<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>Live</td></tr><tr><td>192350002</td><td>Stopped</td></tr><tr><td>192350003</td><td>Live editable</td></tr><tr><td>192350004</td><td>Expired</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_msdyncrm_marketingpagetemplate_value|msdyncrm_marketingpagetemplate<br />||
|_msdyncrm_marketingwebsite_value|msdyncrm_marketingwebsite<br />||
|_msdyncrm_portalspagetemplate_value|msdyncrm_portalspagetemplate<br />||
|_msdyncrm_portalsparentpage_value|msdyncrm_portalsparentpage<br />||
|_msdyncrm_portalswebpage_value|msdyncrm_portalswebpage<br />||
|_msdyncrm_portalswebsite_value|msdyncrm_portalswebsite<br />||
|_msdyncrm_portalswebsitelanguage_value|msdyncrm_portalswebsitelanguage<br />||
|_msdyncrm_portalswebtemplate_value|msdyncrm_portalswebtemplate<br />||
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingpage_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingpage_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingpage_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingpage_modifiedonbehalfby|
|msdyncrm_marketingpagetemplate|[msdyncrm_marketingpagetemplate EntityType](msdyncrm_marketingpagetemplate.md)|msdyncrm_marketingpage_marketingpagetemplate|
|msdyncrm_marketingwebsite|[msdyncrm_website EntityType](msdyncrm_website.md)|msdyncrm_msdyncrm_website_msdyncrm_marketingpage_marketingwebsite|
|msdyncrm_portalspagetemplate|[adx_pagetemplate EntityType](adx_pagetemplate.md)|msdyncrm_adx_pagetemplate_msdyncrm_marketingpage_portalspagetemplate|
|msdyncrm_portalsparentpage|[adx_webpage EntityType](adx_webpage.md)|msdyncrm_adx_webpage_msdyncrm_marketingpage_portalsparentpage|
|msdyncrm_portalswebpage|[adx_webpage EntityType](adx_webpage.md)|msdyncrm_adx_webpage_msdyncrm_marketingpage_portalswebpage|
|msdyncrm_portalswebsite|[adx_website EntityType](adx_website.md)|msdyncrm_adx_website_msdyncrm_marketingpage_portalswebsite|
|msdyncrm_portalswebsitelanguage|[adx_websitelanguage EntityType](adx_websitelanguage.md)|msdyncrm_adx_websitelanguage_msdyncrm_marketingpage_portalswebsitelanguage|
|msdyncrm_portalswebtemplate|[adx_webtemplate EntityType](adx_webtemplate.md)|msdyncrm_adx_webtemplate_msdyncrm_marketingpage_portalswebtemplate|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_marketingpage|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_marketingpage|
|owningteam|[team EntityType](team.md)|team_msdyncrm_marketingpage|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_marketingpage|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_marketingpage_Annotations|[annotation EntityType](annotation.md)|objectid_msdyncrm_marketingpage|  
|msdyncrm_marketingpage_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_marketingpage|  
|msdyncrm_marketingpage_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_marketingpage|  
|msdyncrm_marketingpage_marketingemail|[msdyncrm_marketingemail EntityType](msdyncrm_marketingemail.md)|msdyncrm_marketingpage_marketingemail|  
|msdyncrm_marketingpage_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_marketingpage|  
|msdyncrm_msdyncrm_marketingpage_contact_marketingpageid|[contact EntityType](contact.md)|msdyncrm_marketingpageid|  
|msdyncrm_msdyncrm_marketingpage_lead_marketingpageid|[lead EntityType](lead.md)|msdyncrm_marketingpageid|  
|msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_msdyncrm_marketingpage_msdyncrm_customerj|  
|msdyncrm_msdyncrm_marketingpage_msdyncrm_formpage|[msdyncrm_formpage EntityType](msdyncrm_formpage.md)|msdyncrm_marketingpageid|  
|msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin|[msdyncrm_geopin EntityType](msdyncrm_geopin.md)|msdyncrm_MarketingPageGeoPinsId|  

## Operations
The following operations can be used with the msdyncrm_marketingpage entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_marketingpage entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Portals link Solution](../solutions/microsoftdynamicsmarketingportalslinksolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingportalslinksolution.md](../solutions/descriptions/microsoftdynamicsmarketingportalslinksolution.md)]|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|    

[!INCLUDE[./remarks/msdyncrm_marketingpage.md](./remarks/msdyncrm_marketingpage.md)]

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