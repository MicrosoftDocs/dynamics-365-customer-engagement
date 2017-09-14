---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_glympsesetting EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 98d5820f-ba39-45ef-91d6-1774cb337154
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_glympsesetting entitytype."
---
# msdyn_glympsesetting EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_glympsesetting.md](./descriptions/msdyn_glympsesetting.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_glympsesettings </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Glympse Setting</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_glympsesettingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_glympsesetting entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_bearertoken|Edm.String|**Display Name**: Bearer token<br />**Description**: Code that Glympse uses for authentication.<br />|
|msdyn_clientid|Edm.String|**Display Name**: Client Id<br />**Description**: Client identifier that Glympse uses for customer authentication.<br />|
|msdyn_clientsecret|Edm.String|**Display Name**: Client Secret<br />**Description**: Client secret that Glympse uses for customer authentication.<br />|
|msdyn_glympsesettingid|Edm.Guid|**Display Name**: Glympse Setting<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_glympsewebsiteurl|Edm.String|**Display Name**: Get a Linkage Code<br />**Description**: The Glympse website URL.<br />|
|msdyn_linkagecode|Edm.String|**Display Name**: Linkage Code<br />**Description**: Code that enables communication between Dynamics 365 and Glympse. Please contact Glympse to get a linkage code.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_organizationid|Edm.Int32|**Display Name**: Organization Id<br />**Description**: Identifier for the Glympse organization.<br />|
|msdyn_refreshtoken|Edm.String|**Display Name**: Refresh token<br />**Description**: Token that is generated automatically and used by the system to renew Bearer tokens.<br />|
|msdyn_tokenexpirationdate|Edm.DateTimeOffset|**Display Name**: Token expiration date<br />**Description**: Date on which the Bearer token expires.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Glympse Setting<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Glympse Setting<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympsesetting_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympsesetting_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympsesetting_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympsesetting_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_glympsesetting|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_glympsesetting|
|owningteam|[team EntityType](team.md)|team_msdyn_glympsesetting|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_glympsesetting|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_glympsesetting_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_glympsesetting|  
|msdyn_glympsesetting_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_glympsesetting|  
|msdyn_glympsesetting_connections1|[connection EntityType](connection.md)|record1id_msdyn_glympsesetting|  
|msdyn_glympsesetting_connections2|[connection EntityType](connection.md)|record2id_msdyn_glympsesetting|  
|msdyn_glympsesetting_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_glympsesetting|  
|msdyn_glympsesetting_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_glympsesetting|  
|msdyn_glympsesetting_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_glympsesetting|  

## Operations
The following operations can be used with the msdyn_glympsesetting entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_glympsesetting entity type.


|Name|Description |  
|----|------------|  
|[Integration with Glympse Solution](../solutions/glympse.md)|[!INCLUDE[../solutions/descriptions/glympse.md](../solutions/descriptions/glympse.md)]|    

[!INCLUDE[./remarks/msdyn_glympsesetting.md](./remarks/msdyn_glympsesetting.md)]

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