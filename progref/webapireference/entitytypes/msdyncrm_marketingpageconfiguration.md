---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_marketingpageconfiguration EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 517356cc-c786-4418-9514-49125e3aa2b9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_marketingpageconfiguration entitytype."
---
# msdyncrm_marketingpageconfiguration EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_marketingpageconfiguration.md](./descriptions/msdyncrm_marketingpageconfiguration.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyncrm_marketingpageconfigurations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Marketing Page Configuration</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_marketingpageconfigurationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_marketingpageconfiguration entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_contactcampaignattribute|Edm.String|**Display Name**: Contact Campaign Attribute<br />|
|msdyncrm_contactemailattribute|Edm.String|**Display Name**: Contact Email Attribute<br />|
|msdyncrm_contactmarketingformattribute|Edm.String|**Display Name**: Contact Form Attribute<br />|
|msdyncrm_contactmarketingpageattribute|Edm.String|**Display Name**: Contact Landing Page Attribute<br />|
|msdyncrm_default|Edm.Boolean|**Display Name**: Default<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_entityupdatebehavioronsubmit|Edm.Int32|**Display Name**: Update Contacts/Leads<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Contacts and Leads</td></tr><tr><td>1</td><td>Only Contacts</td></tr><tr><td>2</td><td>Only Leads</td></tr><tbody></table>|
|msdyncrm_insertprivacybanner|Edm.Boolean|**Display Name**: Insert privacy banner<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_leadcampaignattribute|Edm.String|**Display Name**: Lead Campaign Attribute<br />|
|msdyncrm_leadcontactattribute|Edm.String|**Display Name**: Lead Contact Attribute<br />|
|msdyncrm_leademailattribute|Edm.String|**Display Name**: Lead Email Attribute<br />|
|msdyncrm_leadmarketingformattribute|Edm.String|**Display Name**: Lead Form Attribute<br />|
|msdyncrm_leadmarketingpageattribute|Edm.String|**Display Name**: Lead Landing Page Attribute<br />|
|msdyncrm_marketingpageconfigurationid|Edm.Guid|**Display Name**: Marketing Page Configuration<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyncrm_privacybannertext|Edm.String|**Display Name**: Privacy banner text<br />|
|msdyncrm_privacypolicylinktext|Edm.String|**Display Name**: Privacy policy link text<br />|
|msdyncrm_privacypolicylinkurl|Edm.String|**Display Name**: Privacy policy link URL<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Marketing Page Configuration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Marketing Page Configuration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyncrm_contactmatchingstrategy_value|msdyncrm_contactmatchingstrategy<br />||
|_msdyncrm_leadmatchingstrategy_value|msdyncrm_leadmatchingstrategy<br />||
|_msdyncrm_portalsparentpage_value|msdyncrm_portalsparentpage<br />||
|_msdyncrm_portalswebsite_value|msdyncrm_portalswebsite<br />||
|_msdyncrm_portalswebsitelanguage_value|msdyncrm_portalswebsitelanguage<br />||
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingpageconfiguration_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingpageconfiguration_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingpageconfiguration_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingpageconfiguration_modifiedonbehalfby|
|msdyncrm_contactmatchingstrategy|[msdyncrm_matchingstrategy EntityType](msdyncrm_matchingstrategy.md)|msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_contactmatchingstrategy|
|msdyncrm_leadmatchingstrategy|[msdyncrm_matchingstrategy EntityType](msdyncrm_matchingstrategy.md)|msdyncrm_msdyncrm_matchingstrategy_msdyncrm_marketingpageconfiguration_leadmatchingstrategy|
|msdyncrm_portalsparentpage|[adx_webpage EntityType](adx_webpage.md)|msdyncrm_adx_webpage_msdyncrm_marketingpageconfiguration_portalsparentpage|
|msdyncrm_portalswebsite|[adx_website EntityType](adx_website.md)|msdyncrm_adx_website_msdyncrm_marketingpageconfiguration_portalswebsite|
|msdyncrm_portalswebsitelanguage|[adx_websitelanguage EntityType](adx_websitelanguage.md)|msdyncrm_adx_websitelanguage_msdyncrm_marketingpageconfiguration_portalswebsitelanguage|
|organizationid|[organization EntityType](organization.md)|organization_msdyncrm_marketingpageconfiguration|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_marketingpageconfiguration_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_marketingpageconfiguration|  
|msdyncrm_marketingpageconfiguration_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_marketingpageconfiguration|  
|msdyncrm_marketingpageconfiguration_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_marketingpageconfiguration|  

## Operations
The following operations can be used with the msdyncrm_marketingpageconfiguration entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyncrm_marketingpageconfiguration entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Portals link Solution](../solutions/microsoftdynamicsmarketingportalslinksolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingportalslinksolution.md](../solutions/descriptions/microsoftdynamicsmarketingportalslinksolution.md)]|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|    

[!INCLUDE[./remarks/msdyncrm_marketingpageconfiguration.md](./remarks/msdyncrm_marketingpageconfiguration.md)]

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