---
title: "Microsoft Dynamics 365 Customer Engagement role EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a65242dd-45c8-4059-810a-ef978894b897
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API role entitytype."
---
# role EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/role.md](./descriptions/role.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]roles </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Security Role</td></tr>
<tr><td><b>Primary Key:</b></td><td>roleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The role entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the role was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the role was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the role.<br />|
|organizationid|Edm.Guid|**Display Name**: Organization<br />**Description**: Unique identifier of the organization associated with the role.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|roleid|Edm.Guid|**Display Name**: Role<br />**Description**: Unique identifier of the role.<br />|
|roleidunique|Edm.Guid|**Display Name**: Unique Id<br />**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|versionnumber|Edm.Int64|**Display Name**: Version number<br />**Description**: Version number of the role.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_businessunitid_value|businessunitid<br />|Unique identifier of the business unit with which the role is associated.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the role.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the role.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the role.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the role.|
|_parentroleid_value|parentroleid<br />|Unique identifier of the parent role.|
|_parentrootroleid_value|parentrootroleid<br />|Unique identifier of the parent root role.|
|_roletemplateid_value|roletemplateid<br />|Unique identifier of the role template that is associated with the role.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|businessunitid|[businessunit EntityType](businessunit.md)|business_unit_roles|
|createdby|[systemuser EntityType](systemuser.md)|lk_rolebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_role_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_rolebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_role_modifiedonbehalfby|
|organizationid_organization|[organization EntityType](organization.md)|organization_roles|
|parentroleid|[role EntityType](role.md)|role_parent_role|
|parentrootroleid|[role EntityType](role.md)|role_parent_root_role|
|roletemplateid|[roletemplate EntityType](roletemplate.md)|role_template_roles|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|appmoduleroles_association|[appmodule EntityType](appmodule.md)|appmoduleroles_association|  
|Role_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_role|  
|Role_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_role|  
|role_parent_role|[role EntityType](role.md)|parentroleid|  
|role_parent_root_role|[role EntityType](role.md)|parentrootroleid|  
|Role_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_role_syncerror|  
|roleprivileges_association|[privilege EntityType](privilege.md)|roleprivileges_association|  
|systemuserroles_association|[systemuser EntityType](systemuser.md)|systemuserroles_association|  
|teamroles_association|[team EntityType](team.md)|teamroles_association|  

## Operations
The following operations can be used with the role entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[AddPrivilegesRole Action](../actions/addprivilegesrole.md)|Entity|[!INCLUDE[../actions/descriptions/addprivilegesrole.md](../actions/descriptions/addprivilegesrole.md)]|  
|[RemovePrivilegeRole Action](../actions/removeprivilegerole.md)|Entity|[!INCLUDE[../actions/descriptions/removeprivilegerole.md](../actions/descriptions/removeprivilegerole.md)]|  
|[ReplacePrivilegesRole Action](../actions/replaceprivilegesrole.md)|Entity|[!INCLUDE[../actions/descriptions/replaceprivilegesrole.md](../actions/descriptions/replaceprivilegesrole.md)]|  
|[RetrieveRolePrivilegesRole Function](../functions/retrieveroleprivilegesrole.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveroleprivilegesrole.md](../functions/descriptions/retrieveroleprivilegesrole.md)]|    

[!INCLUDE[./remarks/role.md](./remarks/role.md)]

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