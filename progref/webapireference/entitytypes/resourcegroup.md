---
title: "Microsoft Dynamics 365 Customer Engagement resourcegroup EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bd8463c5-17ab-47f9-9f38-b910e856382b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API resourcegroup entitytype."
---
# resourcegroup EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/resourcegroup.md](./descriptions/resourcegroup.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]resourcegroups </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Scheduling Group</td></tr>
<tr><td><b>Primary Key:</b></td><td>resourcegroupid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|grouptypecode|Edm.Int32|**Display Name**: Group Type Code<br />**Description**: Scheduling group type code.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Static</td></tr><tr><td>1</td><td>Dynamic</td></tr><tr><td>2</td><td>Hidden</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the scheduling group.<br />|
|objecttypecode|Edm.String|**Display Name**: Entity<br />**Description**: Type of entity with which the scheduling group is associated.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|resourcegroupid|Edm.Guid|**Display Name**: Scheduling Group<br />**Description**: Unique identifier of the scheduling group.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_businessunitid_value|businessunitid<br />|Business Unit Id|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the scheduling group.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|businessunitid|[businessunit EntityType](businessunit.md)|business_unit_resource_groups|
|organizationid|[organization EntityType](organization.md)|organization_resource_groups|
|resourcegroupid_constraintbasedgroup|[constraintbasedgroup EntityType](constraintbasedgroup.md)|constraintbasedgroup_resource_groups|
|resourcegroupid_team|[team EntityType](team.md)|team_resource_groups|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ResourceGroup_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_resourcegroup|  
|ResourceGroup_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_resourcegroup|  
|resourcegroup_connections1|[connection EntityType](connection.md)|record1id_resourcegroup|  
|resourcegroup_connections2|[connection EntityType](connection.md)|record2id_resourcegroup|  
|ResourceGroup_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_resourcegroup|  
|ResourceGroup_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_resourcegroup|  
|ResourceGroup_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_resourcegroup_syncerror|  

## Operations
The following operations can be used with the resourcegroup entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[FindParentResourceGroup Function](../functions/findparentresourcegroup.md)|Entity|[!INCLUDE[../functions/descriptions/findparentresourcegroup.md](../functions/descriptions/findparentresourcegroup.md)]|  
|[RetrieveByGroupResource Function](../functions/retrievebygroupresource.md)|Entity|[!INCLUDE[../functions/descriptions/retrievebygroupresource.md](../functions/descriptions/retrievebygroupresource.md)]|  
|[RetrieveByResourceResourceGroup Function](../functions/retrievebyresourceresourcegroup.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievebyresourceresourcegroup.md](../functions/descriptions/retrievebyresourceresourcegroup.md)]|  
|[RetrieveParentGroupsResourceGroup Function](../functions/retrieveparentgroupsresourcegroup.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveparentgroupsresourcegroup.md](../functions/descriptions/retrieveparentgroupsresourcegroup.md)]|  
|[RetrieveSubGroupsResourceGroup Function](../functions/retrievesubgroupsresourcegroup.md)|Entity|[!INCLUDE[../functions/descriptions/retrievesubgroupsresourcegroup.md](../functions/descriptions/retrievesubgroupsresourcegroup.md)]|  

## Solutions
The following solutions include the resourcegroup entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/resourcegroup.md](./remarks/resourcegroup.md)]

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