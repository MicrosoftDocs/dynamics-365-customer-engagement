---
title: "Microsoft Dynamics 365 Customer Engagement resourcespec EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 95753eb6-6eb6-4105-86b9-6e88e71c5077
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API resourcespec entitytype."
---
# resourcespec EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/resourcespec.md](./descriptions/resourcespec.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]resourcespecs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Resource Specification</td></tr>
<tr><td><b>Primary Key:</b></td><td>resourcespecid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The resourcespec entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|constraints|Edm.String|**Display Name**: Constraints<br />**Description**: Additional constraints, specified as expressions, which are used to filter a set of valid resources.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the resource specification was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Selection rule that allows the scheduling engine to select a number of resources from a pool of resources. The rules can be associated with a service.<br />|
|effortrequired|Edm.Double|**Display Name**: Effort Required<br />**Description**: Number that specifies the minimal effort required from resources.<br />|
|groupobjectid|Edm.Guid|**Display Name**: Group Object<br />**Description**: Unique identifier of the scheduling group with which the resource specification is associated.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the resource specification was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the resource specification.<br />|
|objectiveexpression|Edm.String|**Display Name**: Objective Expression<br />**Description**: Search strategy to use for the resource specification.<br />|
|objecttypecode|Edm.String|**Display Name**: Object Type <br />**Description**: Type of entity with which the resource specification is associated.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|requiredcount|Edm.Int32|**Display Name**: Required Count<br />**Description**: Required number of resources that must be available. Use -1 to indicate all resources.<br />|
|resourcespecid|Edm.Guid|**Display Name**: Resource Spec<br />**Description**: Unique identifier of the resource specification.<br />|
|samesite|Edm.Boolean|**Display Name**: Same Site<br />**Description**: Value that specifies that all valid and available resources must be in the same site.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_businessunitid_value|businessunitid<br />|Unique identifier of the business unit with which the resource specification is associated.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the resource specification.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the resourcespec.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the resource specification.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the resourcespec.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the resource specification is associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|businessunitid|[businessunit EntityType](businessunit.md)|business_unit_resource_specs|
|createdby|[systemuser EntityType](systemuser.md)|lk_resourcespec_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_resourcespec_createdonbehalfby|
|groupobjectid_constraintbasedgroup|[constraintbasedgroup EntityType](constraintbasedgroup.md)|constraint_based_group_resource_specs|
|groupobjectid_team|[team EntityType](team.md)|team_resource_specs|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_resourcespec_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_resourcespec_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_resource_specs|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ActivityPartyResourceSpec|[activityparty EntityType](activityparty.md)|resourcespecid|  
|resource_spec_services|[service EntityType](service.md)|resourcespecid|  
|ResourceSpec_Annotation|[annotation EntityType](annotation.md)|objectid_resourcespec|  
|ResourceSpec_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_resourcespec|  
|ResourceSpec_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_resourcespec|  
|resourcespec_resources|[resource EntityType](resource.md)|resourceid_resourcespec|  
|resourcespec_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_resourcespec|  

## Solutions
The following solutions include the resourcespec entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/resourcespec.md](./remarks/resourcespec.md)]

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