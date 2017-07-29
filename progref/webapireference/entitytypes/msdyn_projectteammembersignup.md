---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_projectteammembersignup EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8f8fe65a-5d53-4b09-a0dd-5f6533bd7e76
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_projectteammembersignup entitytype."
---
# msdyn_projectteammembersignup EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_projectteammembersignup.md](./descriptions/msdyn_projectteammembersignup.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_projectteammembersignups </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Project Team Member Sign-Up</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_projectteammembersignupid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Applied Date<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_membershipstatus|Edm.Int32|**Display Name**: Membership Status<br />**Description**: Select the membership status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Requested</td></tr><tr><td>2</td><td>Assigned</td></tr><tr><td>3</td><td>Declined</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Default Description<br />**Description**: Type a description of the entity.<br />|
|msdyn_projectteammembersignupid|Edm.Guid|**Display Name**: Project Team Member Sign-Up<br />**Description**: Unique identifier for entity instances<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Project Team Member Sign-Up<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Project Team Member Sign-Up<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_bookableresource_value|msdyn_BookableResource<br />|Shows the name of the resource signing up for this project team.|
|_msdyn_teammembership_value|msdyn_TeamMembership<br />|Shows the team membership for the person signing up for this project team.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectteammembersignup_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectteammembersignup_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectteammembersignup_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_projectteammembersignup_modifiedonbehalfby|
|msdyn_BookableResource|[bookableresource EntityType](bookableresource.md)|msdyn_bookableresource_msdyn_projectteammembersignup_BookableResource|
|msdyn_TeamMembership|[msdyn_projectteam EntityType](msdyn_projectteam.md)|msdyn_msdyn_projectteam_msdyn_projectteammembersignup_TeamMembership|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_projectteammembersignup|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_projectteammembersignup_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_projectteammembersignup|  
|msdyn_projectteammembersignup_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_projectteammembersignup|  
|msdyn_projectteammembersignup_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_projectteammembersignup|  
|msdyn_projectteammembersignup_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_projectteammembersignup|  
|msdyn_projectteammembersignup_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_projectteammembersignup|  
|msdyn_projectteammembersignup_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_projectteammembersignup|  

## Operations
The following operations can be used with the msdyn_projectteammembersignup entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[msdyn_ProjectTeamMemberSignupprocessaccept Action](../actions/msdyn_projectteammembersignupprocessaccept.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_projectteammembersignupprocessaccept.md](../actions/descriptions/msdyn_projectteammembersignupprocessaccept.md)]|  
|[msdyn_ProjectTeamUpdateMembershipStatus Action](../actions/msdyn_projectteamupdatemembershipstatus.md)|Entity|[!INCLUDE[../actions/descriptions/msdyn_projectteamupdatemembershipstatus.md](../actions/descriptions/msdyn_projectteamupdatemembershipstatus.md)]|  

## Solutions
The following solutions include the msdyn_projectteammembersignup entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_projectteammembersignup.md](./remarks/msdyn_projectteammembersignup.md)]

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