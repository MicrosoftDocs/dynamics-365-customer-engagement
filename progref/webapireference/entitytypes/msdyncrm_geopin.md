---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_geopin EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9c35015a-9dd5-425b-831c-b5a96894a65d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_geopin entitytype."
---
# msdyncrm_geopin EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_geopin.md](./descriptions/msdyncrm_geopin.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyncrm_geopins </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Geo Pin</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_geopinid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_geopin entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_centerlatitude|Edm.Decimal|**Display Name**: Center Latitude<br />|
|msdyncrm_centerlongitude|Edm.Decimal|**Display Name**: Center Longitude<br />|
|msdyncrm_city|Edm.String|**Display Name**: City<br />**Description**: City<br />|
|msdyncrm_country|Edm.String|**Display Name**: Country<br />**Description**: Country<br />|
|msdyncrm_geopinid|Edm.Guid|**Display Name**: Geo Pin<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_kpi_email_clicked_count|Edm.Double|**Display Name**: KPI Email Clicked Count<br />|
|msdyncrm_kpi_email_opened_count|Edm.Double|**Display Name**: KPI Email Opened Count<br />|
|msdyncrm_kpi_form_submitted_count|Edm.Double||
|msdyncrm_kpi_redirect_link_clicked_count|Edm.Double|**Display Name**: KPI Redirect Link Clicked Count<br />|
|msdyncrm_kpi_website_clicked_count|Edm.Double|**Display Name**: KPI Website Clicked Count<br />|
|msdyncrm_kpi_website_visited_count|Edm.Double|**Display Name**: KPI Website Visited Count<br />|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyncrm_northwestlatitude|Edm.Decimal|**Display Name**: Northwest Latitude<br />|
|msdyncrm_northwestlongitude|Edm.Decimal|**Display Name**: Northwest Longitude<br />|
|msdyncrm_postalcode|Edm.String|**Display Name**: Postal Code<br />**Description**: Postal Code<br />|
|msdyncrm_requestbuilderservice_mktgeopins|Edm.String|**Display Name**: Mkt Interactions<br />|
|msdyncrm_resultparserservice_mktgeopins|Edm.String|**Display Name**: Mkt Interactions<br />|
|msdyncrm_serverid_marketing|Edm.String|**Display Name**: serverId_marketing<br />|
|msdyncrm_southeastlatitude|Edm.Decimal|**Display Name**: Southeast Latitude<br />|
|msdyncrm_southeastlongitude|Edm.Decimal|**Display Name**: Southeast Longitude<br />|
|msdyncrm_state|Edm.String|**Display Name**: State<br />**Description**: State<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Geo Pin<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Geo Pin<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyncrm_campaigngeopinsid_value||Unique identifier for Campaign associated with Geo Pin.|
|_msdyncrm_contactgeopinsid_value|msdyncrm_ContactGeoPinsId<br />|Unique identifier for Contact associated with Geo Pin.|
|_msdyncrm_leadgeopinsid_value|msdyncrm_LeadGeoPinsId<br />|Unique identifier for Lead associated with Geo Pin.|
|_msdyncrm_marketingemailgeopinsid_value|msdyncrm_MarketingEmailGeoPinsId<br />|Unique identifier for Marketing Email associated with Geo Pin.|
|_msdyncrm_marketingformgeopinsid_value|msdyncrm_marketingformGeoPinsId<br />|Unique identifier for Marketing Form associated with Geo Pin.|
|_msdyncrm_marketingpagegeopinsid_value|msdyncrm_MarketingPageGeoPinsId<br />|Unique identifier for Marketing Page associated with Geo Pin.|
|_msdyncrm_redirecturlgeopinsid_value|msdyncrm_RedirectURLGeoPinsId<br />|Unique identifier for Redirect URL associated with Geo Pin.|
|_msdyncrm_websitegeopinsid_value|msdyncrm_WebsiteGeoPinsId<br />|Unique identifier for Website associated with Geo Pin.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_geopin_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_geopin_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_geopin_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_geopin_modifiedonbehalfby|
|msdyncrm_ContactGeoPinsId|[contact EntityType](contact.md)|msdyncrm_contact_msdyncrm_geopin|
|msdyncrm_LeadGeoPinsId|[lead EntityType](lead.md)|msdyncrm_lead_msdyncrm_geopin|
|msdyncrm_MarketingEmailGeoPinsId|[msdyncrm_marketingemail EntityType](msdyncrm_marketingemail.md)|msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin|
|msdyncrm_marketingformGeoPinsId|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|msdyncrm_msdyncrm_marketingform_msdyncrm_geopin|
|msdyncrm_MarketingPageGeoPinsId|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_msdyncrm_marketingpage_msdyncrm_geopin|
|msdyncrm_RedirectURLGeoPinsId|[msdyncrm_redirecturl EntityType](msdyncrm_redirecturl.md)|msdyncrm_msdyncrm_redirecturl_msdyncrm_geopin|
|msdyncrm_WebsiteGeoPinsId|[msdyncrm_website EntityType](msdyncrm_website.md)|msdyncrm_msdyncrm_website_msdyncrm_geopin|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_geopin|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_geopin|
|owningteam|[team EntityType](team.md)|team_msdyncrm_geopin|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_geopin|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_geopin_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_geopin|  
|msdyncrm_geopin_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_geopin|  
|msdyncrm_geopin_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_geopin|  

## Operations
The following operations can be used with the msdyncrm_geopin entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_geopin entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|    

[!INCLUDE[./remarks/msdyncrm_geopin.md](./remarks/msdyncrm_geopin.md)]

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