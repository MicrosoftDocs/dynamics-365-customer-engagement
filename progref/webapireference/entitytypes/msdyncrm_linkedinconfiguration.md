---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_linkedinconfiguration EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9f59a83e-580e-4997-81b1-1d209b2d9aa1
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_linkedinconfiguration entitytype."
---
# msdyncrm_linkedinconfiguration EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_linkedinconfiguration.md](./descriptions/msdyncrm_linkedinconfiguration.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyncrm_linkedinconfigurations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>LinkedIn LeadGen Integration Configuration</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_linkedinconfigurationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_redirecturl</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_linkedinconfiguration entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncr2_synchronizecampaigns|Edm.Boolean|**Display Name**: Synchronize campaigns<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_authenticationresource|Edm.String|**Display Name**: Authentication Resource<br />|
|msdyncrm_authenticationtokenendpoint|Edm.String|**Display Name**: Authentication Token Endpoint<br />|
|msdyncrm_authenticationtype|Edm.Int32|**Display Name**: Authentication Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Bearer Authentication</td></tr><tr><td>192350001</td><td>Basic Authentication</td></tr><tbody></table>|
|msdyncrm_clientid|Edm.String|**Display Name**: Client ID<br />**Description**: Client ID<br />|
|msdyncrm_configcacheexpirationdate|Edm.DateTimeOffset|**Display Name**: Expiration date<br />**Description**: Expiration date<br />|
|msdyncrm_configcacheexpirationperiodinms|Edm.Int32|**Display Name**: Expiration (in milliseconds)<br />**Description**: Expiration (in milliseconds)<br />|
|msdyncrm_discoveryendpointurl|Edm.String|**Display Name**: Discovery endpoint for the configuration<br />**Description**: Discovery endpoint for the configuration<br />|
|msdyncrm_linkedinconfigurationid|Edm.Guid|**Display Name**: LinkedIn Configuration<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_onmatchingfail|Edm.Int32|**Display Name**: On Matching Fail<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Ignore</td></tr><tr><td>192350001</td><td>Create new lead</td></tr><tbody></table>|
|msdyncrm_organization_config|Edm.String|**Display Name**: Organization configuration<br />**Description**: Organization configuration<br />|
|msdyncrm_redirecturl|Edm.String|**Display Name**: Redirect URL<br />**Description**: Redirect URL<br />|
|msdyncrm_s2sinboundconfigurl|Edm.String|**Display Name**: S2S Inbound Configuration URL<br />|
|msdyncrm_servicepublicid|Edm.String|**Display Name**: Service Public Id<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the LinkedIn Configuration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the LinkedIn Configuration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinconfiguration_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinconfiguration_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinconfiguration_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_linkedinconfiguration_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_linkedinconfiguration|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_linkedinconfiguration|
|owningteam|[team EntityType](team.md)|team_msdyncrm_linkedinconfiguration|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_linkedinconfiguration|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_linkedinconfiguration_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_linkedinconfiguration|  
|msdyncrm_linkedinconfiguration_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_linkedinconfiguration|  
|msdyncrm_linkedinconfiguration_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyncrm_linkedinconfiguration|  
|msdyncrm_linkedinconfiguration_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyncrm_linkedinconfiguration|  
|msdyncrm_linkedinconfiguration_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_linkedinconfiguration|  

## Operations
The following operations can be used with the msdyncrm_linkedinconfiguration entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_linkedinconfiguration entity type.


|Name|Description |  
|----|------------|  
|[LinkedIn Lead Gen Forms (Link to Marketing) Solution](../solutions/linkedinleadgenintegrationlink.md)|[!INCLUDE[../solutions/descriptions/linkedinleadgenintegrationlink.md](../solutions/descriptions/linkedinleadgenintegrationlink.md)]|  
|[LinkedIn Lead Gen Forms Solution](../solutions/linkedinleadgenintegration.md)|[!INCLUDE[../solutions/descriptions/linkedinleadgenintegration.md](../solutions/descriptions/linkedinleadgenintegration.md)]|    

[!INCLUDE[./remarks/msdyncrm_linkedinconfiguration.md](./remarks/msdyncrm_linkedinconfiguration.md)]

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