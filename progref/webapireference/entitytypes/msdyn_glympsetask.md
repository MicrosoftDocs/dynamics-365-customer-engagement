---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_glympsetask EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1bca9f79-cd32-4d1e-98ca-bb6d5ebbde07
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_glympsetask entitytype."
---
# msdyn_glympsetask EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_glympsetask.md](./descriptions/msdyn_glympsetask.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_glympsetasks </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Glympse Task</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_glympsetaskid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_description</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_glympsetask entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_addressline1|Edm.String|**Display Name**: Address line 1<br />**Description**: First line of the customer’s address in Glympse.<br />|
|msdyn_addressline2|Edm.String|**Display Name**: Address line 2<br />**Description**: Second line of the address in Glympse.<br />|
|msdyn_addressline3|Edm.String|**Display Name**: Address line 3<br />**Description**: Third line of the customer’s address in Glympse.<br />|
|msdyn_city|Edm.String|**Display Name**: City<br />**Description**: City name for the customer’s address in Glympse.<br />|
|msdyn_countryregion|Edm.String|**Display Name**: Country/Region<br />**Description**: Country or region name for the customer’s address in Glympse.<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Information about the work to be completed.<br />|
|msdyn_destinationaddress|Edm.String|**Display Name**: Destination address<br />**Description**: The customer’s full address.<br />|
|msdyn_destinationname|Edm.String|**Display Name**: Destination name<br />**Description**: The customer's destination name.<br />|
|msdyn_duration|Edm.Int32|**Display Name**: Duration<br />**Description**: The duration of the customer's task.<br />|
|msdyn_endtime|Edm.DateTimeOffset|**Display Name**: End time<br />**Description**: Scheduled completion time of the task.<br />|
|msdyn_foreignid|Edm.String|**Display Name**: Foreign Id<br />**Description**: Identifier for the Dynamics 365 entity that is associated with the task.<br />|
|msdyn_foreignidentitylogicalname|Edm.String|**Display Name**: Foreign Id Entity Logical Name<br />**Description**: Name of the Dynamics 365 entity that is associated with the task.<br />|
|msdyn_glympsetaskid|Edm.Guid|**Display Name**: Record Id<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_inviteid|Edm.Int32|**Display Name**: Invite Id<br />**Description**: Identifier for the Glympse invitation sent to the customer<br />|
|msdyn_inviteurl|Edm.String|**Display Name**: Invite url<br />**Description**: URL the customer can use to access the Glympse invitation relevant to the task.<br />|
|msdyn_postalcode|Edm.String|**Display Name**: Postal code<br />**Description**: Postal code for the customer’s address in Glympse.<br />|
|msdyn_scheduledtime|Edm.DateTimeOffset|**Display Name**: Scheduled time<br />**Description**: Scheduled start time of the task.<br />|
|msdyn_starttime|Edm.DateTimeOffset|**Display Name**: Start time<br />**Description**: Actual time when the task was started.<br />|
|msdyn_stateprovince|Edm.String|**Display Name**: State/Province<br />**Description**: State or province of the customer’s address in Glympse.<br />|
|msdyn_taskid|Edm.Int32|**Display Name**: Task Id<br />**Description**: Number that uniquely identifies the task in Glympse.<br />|
|msdyn_taskphase|Edm.Int32|**Display Name**: Task phase<br />**Description**: The status of this task.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350005</td><td>NotStarted</td></tr><tr><td>192350000</td><td>Pre</td></tr><tr><td>192350001</td><td>Eta</td></tr><tr><td>192350002</td><td>Live</td></tr><tr><td>192350003</td><td>Completed</td></tr><tr><td>192350004</td><td>Canceled</td></tr><tbody></table>|
|msdyn_ticketid|Edm.String|**Display Name**: Ticket Id<br />**Description**: The ticket number assigned to this task.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Glympse Task<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Glympse Task<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_glympseagentid_value|msdyn_glympseagentId<br />|Unique system identifier for the agent.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympsetask_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympsetask_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympsetask_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_glympsetask_modifiedonbehalfby|
|msdyn_glympseagentId|[msdyn_glympseagent EntityType](msdyn_glympseagent.md)|msdyn_msdyn_glympseagent_msdyn_glympsetask|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_glympsetask|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_glympsetask|
|owningteam|[team EntityType](team.md)|team_msdyn_glympsetask|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_glympsetask|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_glympsetask_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_glympsetask|  
|msdyn_glympsetask_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_glympsetask|  
|msdyn_glympsetask_connections1|[connection EntityType](connection.md)|record1id_msdyn_glympsetask|  
|msdyn_glympsetask_connections2|[connection EntityType](connection.md)|record2id_msdyn_glympsetask|  
|msdyn_glympsetask_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_glympsetask|  
|msdyn_glympsetask_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_glympsetask|  
|msdyn_glympsetask_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_glympsetask|  
|msdyn_msdyn_glympsetask_bookableresourcebooking|[bookableresourcebooking EntityType](bookableresourcebooking.md)|msdyn_glympsetaskId|  

## Operations
The following operations can be used with the msdyn_glympsetask entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_glympsetask entity type.


|Name|Description |  
|----|------------|  
|[Integration with Glympse Solution](../solutions/glympse.md)|[!INCLUDE[../solutions/descriptions/glympse.md](../solutions/descriptions/glympse.md)]|    

[!INCLUDE[./remarks/msdyn_glympsetask.md](./remarks/msdyn_glympsetask.md)]

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