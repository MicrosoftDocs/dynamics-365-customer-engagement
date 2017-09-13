---
title: "Microsoft Dynamics 365 Customer Engagement connectionrole EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 55399f96-e93e-4ad7-983b-d237620b36c4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API connectionrole entitytype."
---
# connectionrole EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/connectionrole.md](./descriptions/connectionrole.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]connectionroles </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Connection Role</td></tr>
<tr><td><b>Primary Key:</b></td><td>connectionroleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The connectionrole EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|category|Edm.Int32|**Display Name**: Connection Role Category<br />**Description**: Categories for connection roles.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Business</td></tr><tr><td>2</td><td>Family</td></tr><tr><td>3</td><td>Social</td></tr><tr><td>4</td><td>Sales</td></tr><tr><td>5</td><td>Other</td></tr><tr><td>1000</td><td>Stakeholder</td></tr><tr><td>1001</td><td>Sales Team</td></tr><tr><td>1002</td><td>Service</td></tr><tbody></table>|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: State of the component.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|connectionroleid|Edm.Guid|**Display Name**: Connection Role<br />**Description**: Unique identifier of the connection role.<br />|
|connectionroleidunique|Edm.Guid|**Display Name**: Unique ID<br />**Description**: Unique identifier of the published or unpublished connection role record.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the connection role was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the connection role.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the connection role was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the connection role.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Overwritten On<br />**Description**: Date and time when the record was last overwritten.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the connection role.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the connection role.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the connection role.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the relationship role.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the relationship role.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the connection role.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the relationship role.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization that this connection role belongs to.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|createdby_connection_role|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_connectionrolebase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|modifiedby_connection_role|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_connectionrolebase_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_connection_roles|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|Connection_Role_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_connectionrole|  
|connection_role_connections1|[connection EntityType](connection.md)|record1roleid|  
|connection_role_connections2|[connection EntityType](connection.md)|record2roleid|  
|ConnectionRole_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_connectionrole_syncerror|  
|connectionroleassociation_association|[connectionrole EntityType](connectionrole.md)|connectionroleassociation_association_referenced|  
|connectionroleassociation_association_referenced|[connectionrole EntityType](connectionrole.md)|connectionroleassociation_association|    

[!INCLUDE[./remarks/connectionrole.md](./remarks/connectionrole.md)]

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