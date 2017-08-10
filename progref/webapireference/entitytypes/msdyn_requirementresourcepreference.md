---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_requirementresourcepreference EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 67107c9c-191a-476a-9042-652613c89253
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_requirementresourcepreference entitytype."
---
# msdyn_requirementresourcepreference EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_requirementresourcepreference.md](./descriptions/msdyn_requirementresourcepreference.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_requirementresourcepreferences </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Requirement Resource Preference</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_requirementresourcepreferenceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_requirementresourcepreference entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_cascade|Edm.Boolean|**Display Name**: Cascade<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_expirationdate|Edm.DateTimeOffset|**Display Name**: Expiration Date<br />**Description**: The date and time when a restricted resource is no longer restricted.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_preferencetype|Edm.Int32|**Display Name**: Preference Type<br />**Description**: Preference Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>690970000</td><td>Preferred</td></tr><tr><td>690970001</td><td>Restricted</td></tr><tbody></table>|
|msdyn_requirementresourcepreferenceid|Edm.Guid|**Display Name**: Requirement Resource Preference<br />**Description**: The unique identifier for an entity instance.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Requirement Resource Preference<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Requirement Resource Preference<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_account_value|msdyn_Account<br />||
|_msdyn_bookableresource_value|msdyn_BookableResource<br />|Bookable Resource|
|_msdyn_resourcerequirement_value|msdyn_ResourceRequirement<br />|Resource Requirement|
|_msdyn_workorder_value|msdyn_WorkOrder<br />|Unique identifier for Work Order associated with Requirement Resource Preference.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_requirementresourcepreference_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_requirementresourcepreference_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_requirementresourcepreference_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_requirementresourcepreference_modifiedonbehalfby|
|msdyn_Account|[account EntityType](account.md)|msdyn_account_msdyn_requirementresourcepreference_Account|
|msdyn_BookableResource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_requirementresourcepreference_BookableResource|
|msdyn_ResourceRequirement|[msdyn_resourcerequirement EntityType](msdyn_resourcerequirement.md)|msdyn_resourcerequirement_requirementresourcepreference_ResourceRequirement|
|msdyn_WorkOrder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_msdyn_workorder_msdyn_requirementresourcepreference_WorkOrder|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_requirementresourcepreference|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_requirementresourcepreference|
|owningteam|[team EntityType](team.md)|team_msdyn_requirementresourcepreference|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_requirementresourcepreference|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_requirementresourcepreference_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_requirementresourcepreference|  
|msdyn_requirementresourcepreference_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_requirementresourcepreference|  
|msdyn_requirementresourcepreference_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_requirementresourcepreference|  
|msdyn_requirementresourcepreference_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_requirementresourcepreference|  
|msdyn_requirementresourcepreference_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_requirementresourcepreference|  
|msdyn_requirementresourcepreference_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_requirementresourcepreference|  

## Operations
The following operations can be used with the msdyn_requirementresourcepreference entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_requirementresourcepreference entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|  
|[Unified Resource Scheduling Solution](../solutions/microsoftdynamicsscheduling.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsscheduling.md](../solutions/descriptions/microsoftdynamicsscheduling.md)]|    

[!INCLUDE[./remarks/msdyn_requirementresourcepreference.md](./remarks/msdyn_requirementresourcepreference.md)]

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