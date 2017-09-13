---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_glympseagent EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 569f1e41-69f6-43b0-b204-cfa5fc9bf999
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_glympseagent entitytype."
---
# msdyn_glympseagent EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_glympseagent.md](./descriptions/msdyn_glympseagent.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_glympseagents </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Glympse Agent</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_glympseagentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_email</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_glympseagent entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|entityimage|Edm.Binary|**Display Name**: Avatar<br />**Description**: Glympse Agent Avatar.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_agentid|Edm.Int32|**Display Name**: Agent Id<br />**Description**: The agent's Glympse ID.<br />|
|msdyn_email|Edm.String|**Display Name**: E-mail<br />**Description**: The agent’s email address.<br />|
|msdyn_foreignid|Edm.String|**Display Name**: Foreign Id<br />**Description**: Identifier for the Dynamics 365 entity that is associated with the Glympse agent.<br />|
|msdyn_foreignidentitylogicalname|Edm.String|**Display Name**: Foreign Id Entity Logical Name<br />**Description**: Name of the Dynamics 365 entity that is associated with the Glympse agent.<br />|
|msdyn_glympseagentid|Edm.Guid|**Display Name**: Glympse Agent<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_glympsepassword|Edm.String|**Display Name**: Glympse password<br />**Description**: Field that stores the Glympse account password for this agent.<br />|
|msdyn_glympseusername|Edm.String|**Display Name**: Glympse username<br />**Description**: Field that stores the Glympse account username for this agent.<br />|
|msdyn_isresetglympsepassword|Edm.Boolean|**Display Name**: Reset Glympse password<br />**Description**: Field that indicates if the Glympse password needs to be reset<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The agent’s full name.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Glympse Agent<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Glympse Agent<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympseagent_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympseagent_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympseagent_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympseagent_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_glympseagent|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_glympseagent|
|owningteam|[team EntityType](team.md)|team_msdyn_glympseagent|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_glympseagent|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_glympseagent_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_glympseagent|  
|msdyn_glympseagent_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_glympseagent|  
|msdyn_glympseagent_connections1|[connection EntityType](connection.md)|record1id_msdyn_glympseagent|  
|msdyn_glympseagent_connections2|[connection EntityType](connection.md)|record2id_msdyn_glympseagent|  
|msdyn_glympseagent_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_glympseagent|  
|msdyn_glympseagent_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_glympseagent|  
|msdyn_glympseagent_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_glympseagent|  
|msdyn_msdyn_glympseagent_bookableresource_GlympseAgent|[bookableresource EntityType](bookableresource.md)|msdyn_glympseagent|  
|msdyn_msdyn_glympseagent_msdyn_glympsetask|[msdyn_glympsetask EntityType](msdyn_glympsetask.md)|msdyn_glympseagentId|  

## Operations
The following operations can be used with the msdyn_glympseagent entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_glympseagent entity type.


|Name|Description |  
|----|------------|  
|[Integration with Glympse Solution](../solutions/glympse.md)|[!INCLUDE[../solutions/descriptions/glympse.md](../solutions/descriptions/glympse.md)]|    

[!INCLUDE[./remarks/msdyn_glympseagent.md](./remarks/msdyn_glympseagent.md)]

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