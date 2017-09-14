---
title: "Microsoft Dynamics 365 Customer Engagement duplicaterule EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 68670041-fa3c-45eb-ac36-b71141544e3a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API duplicaterule entitytype."
---
# duplicaterule EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/duplicaterule.md](./descriptions/duplicaterule.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]duplicaterules </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Duplicate Detection Rule</td></tr>
<tr><td><b>Primary Key:</b></td><td>duplicateruleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The duplicaterule entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|baseentitymatchcodetable|Edm.String|**Display Name**: Base Record Type Match Code Table<br />**Description**: Database table that stores match codes for the record type being evaluated for potential duplicates.<br />Read-only<br />|
|baseentityname|Edm.String|**Display Name**: Base Record Type<br />**Description**: Record type of the record being evaluated for potential duplicates.<br />|
|baseentitytypecode|Edm.Int32|**Display Name**: Base Record Type<br />**Description**: Record type of the record being evaluated for potential duplicates.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Default Value</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the duplicate detection rule was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the duplicate detection rule.<br />|
|duplicateruleid|Edm.Guid|**Display Name**: Duplicate Detection Rule<br />**Description**: Unique identifier of the duplicate detection rule.<br />|
|excludeinactiverecords|Edm.Boolean|**Display Name**: Exclude Inactive Records<br />**Description**: Determines whether to flag inactive records as duplicates<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|iscasesensitive|Edm.Boolean|**Display Name**: Case Sensitive<br />**Description**: Indicates if the operator is case-sensitive.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|matchingentitymatchcodetable|Edm.String|**Display Name**: Matching Record Type Match Code Table<br />**Description**: Database table that stores match codes for potential duplicate records.<br />Read-only<br />|
|matchingentityname|Edm.String|**Display Name**: Matching Record Type<br />**Description**: Record type of the records being evaluated as potential duplicates.<br />|
|matchingentitytypecode|Edm.Int32|**Display Name**: Matching Record Type<br />**Description**: Record type of the records being evaluated as potential duplicates.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Default Value</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the duplicate detection rule was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Rule Name<br />**Description**: Name of the duplicate detection rule.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the duplicate detection rule.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Inactive</td></tr><tr><td>1</td><td>Active</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the duplicate detection rule.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Unpublished</td></tr><tr><td>1</td><td>Publishing</td></tr><tr><td>2</td><td>Published</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the duplicate detection rule.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the duplicaterule.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the duplicate detection rule.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the duplicaterule.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the duplicate detection rule.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns duplicate detection rule.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the duplicate detection rule.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the duplicate detection rule.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_duplicaterulebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_duplicaterule_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_duplicaterulebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_duplicaterule_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_duplicaterules|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|BusinessUnit_DuplicateRules|
|owningteam|[team EntityType](team.md)|team_DuplicateRules|
|owninguser|[systemuser EntityType](systemuser.md)|SystemUser_DuplicateRules|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|DuplicateRule_Annotation|[annotation EntityType](annotation.md)|objectid_duplicaterule|  
|DuplicateRule_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicateruleid|  
|DuplicateRule_DuplicateRuleConditions|[duplicaterulecondition EntityType](duplicaterulecondition.md)|regardingobjectid|  
|DuplicateRule_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_duplicaterule_syncerror|  

## Operations
The following operations can be used with the duplicaterule entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CompoundUpdateDuplicateDetectionRule Action](../actions/compoundupdateduplicatedetectionrule.md)|Not Bound|[!INCLUDE[../actions/descriptions/compoundupdateduplicatedetectionrule.md](../actions/descriptions/compoundupdateduplicatedetectionrule.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[PublishDuplicateRule Action](../actions/publishduplicaterule.md)|Entity|[!INCLUDE[../actions/descriptions/publishduplicaterule.md](../actions/descriptions/publishduplicaterule.md)]|  
|[PublishXml Action](../actions/publishxml.md)|Not Bound|[!INCLUDE[../actions/descriptions/publishxml.md](../actions/descriptions/publishxml.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[UnpublishDuplicateRule Action](../actions/unpublishduplicaterule.md)|Not Bound|[!INCLUDE[../actions/descriptions/unpublishduplicaterule.md](../actions/descriptions/unpublishduplicaterule.md)]|    

[!INCLUDE[./remarks/duplicaterule.md](./remarks/duplicaterule.md)]

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