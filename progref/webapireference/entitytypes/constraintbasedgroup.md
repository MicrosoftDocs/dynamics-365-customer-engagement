---
title: "Microsoft Dynamics 365 Customer Engagement constraintbasedgroup EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e0af90c3-9975-4618-b2dc-fffe37b34cd7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API constraintbasedgroup entitytype."
---
# constraintbasedgroup EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/constraintbasedgroup.md](./descriptions/constraintbasedgroup.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]constraintbasedgroups </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Resource Group</td></tr>
<tr><td><b>Primary Key:</b></td><td>constraintbasedgroupid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The constraintbasedgroup entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|constraintbasedgroupid|Edm.Guid|**Display Name**: Resource Group<br />**Description**: Unique identifier of the resource group.<br />|
|constraints|Edm.String|**Display Name**: Constraints<br />**Description**: Shows the constraints defined for the users, equipment, teams, and other resource groups included as resources for the group, stored in XML format.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the resource group was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the resource group, such as the intended use or associated resource types.<br />|
|grouptypecode|Edm.Int32|**Display Name**: Group Type<br />**Description**: Shows whether the resource group is static, dynamic or hidden. Hidden groups are for system use only and are not viewable in Microsoft Dynamics 365.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Static</td></tr><tr><td>1</td><td>Dynamic</td></tr><tr><td>2</td><td>Hidden</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the resource group was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a title or name that describes the resource group.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_businessunitid_value|businessunitid_businessunit<br />businessunitid_systemuser<br />|Shows the business unit that the record owner belongs to.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the resource group.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the constraintbasedgroup.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the resource group.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the constraintbasedgroup.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the resource group.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|businessunitid_businessunit|[businessunit EntityType](businessunit.md)|business_unit_constraint_based_groups|
|businessunitid_systemuser|[systemuser EntityType](systemuser.md)|constraintbasedgroup_systemuser|
|createdby|[systemuser EntityType](systemuser.md)|lk_constraintbasedgroup_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_constraintbasedgroup_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_constraintbasedgroup_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_constraintbasedgroup_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_constraint_based_groups|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|constraint_based_group_resource_specs|[resourcespec EntityType](resourcespec.md)|groupobjectid_constraintbasedgroup|  
|ConstraintBasedGroup_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_constraintbasedgroup|  
|ConstraintBasedGroup_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_constraintbasedgroup|  
|constraintbasedgroup_connections1|[connection EntityType](connection.md)|record1id_constraintbasedgroup|  
|constraintbasedgroup_connections2|[connection EntityType](connection.md)|record2id_constraintbasedgroup|  
|constraintbasedgroup_resource_groups|[resourcegroup EntityType](resourcegroup.md)|resourcegroupid_constraintbasedgroup|  
|constraintbasedgroup_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_constraintbasedgroup|  

## Solutions
The following solutions include the constraintbasedgroup entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/constraintbasedgroup.md](./remarks/constraintbasedgroup.md)]

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