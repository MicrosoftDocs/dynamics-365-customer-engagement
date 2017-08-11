---
title: "Microsoft Dynamics 365 Customer Engagement solution EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4dd9f73e-8d40-4f80-ade4-a65fabf7f7b8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API solution entitytype."
---
# solution EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/solution.md](./descriptions/solution.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]solutions </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Solution</td></tr>
<tr><td><b>Primary Key:</b></td><td>solutionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>friendlyname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The solution EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the solution was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the solution.<br />|
|friendlyname|Edm.String|**Display Name**: Display Name<br />**Description**: User display name for the solution.<br />|
|installedon|Edm.DateTimeOffset|**Display Name**: Installed On<br />**Description**: Date and time when the solution was installed/upgraded.<br />Read-only<br />|
|ismanaged|Edm.Boolean|**Display Name**: Package Type<br />**Description**: Indicates whether the solution is managed or unmanaged.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|isvisible|Edm.Boolean|**Display Name**: Is Visible Outside Platform<br />**Description**: Indicates whether the solution is visible outside of the platform.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the solution was last modified.<br />Read-only<br />|
|pinpointassetid|Edm.String|Read-only<br />|
|pinpointpublisherid|Edm.Int64|**Description**: Identifier of the publisher of this solution in Microsoft Pinpoint.<br />Read-only<br />|
|pinpointsolutiondefaultlocale|Edm.String|**Description**: Default locale of the solution in Microsoft Pinpoint.<br />Read-only<br />|
|pinpointsolutionid|Edm.Int64|**Description**: Identifier of the solution in Microsoft Pinpoint.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution Identifier<br />**Description**: Unique identifier of the solution.<br />|
|solutionpackageversion|Edm.String|**Display Name**: Solution Package Version<br />**Description**: Solution package source organization version<br />|
|solutiontype|Edm.Int32|**Display Name**: Solution Type<br />**Description**: Solution Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>1</td><td>Snapshot</td></tr><tr><td>2</td><td>Internal</td></tr><tbody></table>|
|uniquename|Edm.String|**Display Name**: Name<br />**Description**: The unique name of this solution<br />|
|updatedon|Edm.DateTimeOffset|**Display Name**: Updated On<br />**Description**: Date and time when the solution was updated.<br />Read-only<br />|
|version|Edm.String|**Display Name**: Version<br />**Description**: Solution version, used to identify a solution for upgrades and hotfixes.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_configurationpageid_value|configurationpageid<br />|A link to an optional configuration page for this solution.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the solution.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the solution.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the solution.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the solution.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the solution.|
|_parentsolutionid_value|parentsolutionid<br />|Unique identifier of the parent solution. Should only be non-null if this solution is a patch.|
|_publisherid_value|publisherid<br />|Unique identifier of the publisher.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|configurationpageid|[webresource EntityType](webresource.md)|solution_configuration_webresource|
|createdby|[systemuser EntityType](systemuser.md)|lk_solution_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_solutionbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_solution_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_solutionbase_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_solution|
|parentsolutionid|[solution EntityType](solution.md)|solution_parent_solution|
|publisherid|[publisher EntityType](publisher.md)|publisher_solution|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|solution_parent_solution|[solution EntityType](solution.md)|parentsolutionid|  
|solution_solutioncomponent|[solutioncomponent EntityType](solutioncomponent.md)|solutionid|  
|Solution_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_solution_syncerror|  

## Operations
The following operations can be used with the solution entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CloneAsPatch Action](../actions/cloneaspatch.md)|Not Bound|[!INCLUDE[../actions/descriptions/cloneaspatch.md](../actions/descriptions/cloneaspatch.md)]|  
|[CloneAsSolution Action](../actions/cloneassolution.md)|Not Bound|[!INCLUDE[../actions/descriptions/cloneassolution.md](../actions/descriptions/cloneassolution.md)]|  
|[DeleteAndPromote Action](../actions/deleteandpromote.md)|Not Bound|[!INCLUDE[../actions/descriptions/deleteandpromote.md](../actions/descriptions/deleteandpromote.md)]|    

[!INCLUDE[./remarks/solution.md](./remarks/solution.md)]

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