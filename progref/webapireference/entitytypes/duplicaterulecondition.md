---
title: "Microsoft Dynamics 365 Customer Engagement duplicaterulecondition EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c78dbc01-42dc-4d0d-aa04-1f42f6949b24
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API duplicaterulecondition entitytype."
---
# duplicaterulecondition EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/duplicaterulecondition.md](./descriptions/duplicaterulecondition.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]duplicateruleconditions </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Duplicate Rule Condition</td></tr>
<tr><td><b>Primary Key:</b></td><td>duplicateruleconditionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The duplicaterulecondition EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|baseattributename|Edm.String|**Display Name**: Base Field<br />**Description**: Field that is being compared.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the condition was created.<br />Read-only<br />|
|duplicateruleconditionid|Edm.Guid|**Display Name**: Duplicate Rule Condition<br />**Description**: Unique identifier of the condition.<br />|
|ignoreblankvalues|Edm.Boolean|**Display Name**: Ignore Blank Values<br />**Description**: Determines whether to consider blank values as non-duplicate values<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|matchingattributename|Edm.String|**Display Name**: Matching Field<br />**Description**: Field that is being compared with the base field.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the condition was last modified.<br />Read-only<br />|
|operatorcode|Edm.Int32|**Display Name**: Operator Code<br />**Description**: Operator for this rule condition.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Exact Match</td></tr><tr><td>1</td><td>Same First Characters</td></tr><tr><td>2</td><td>Same Last Characters</td></tr><tr><td>3</td><td>Same Date</td></tr><tr><td>4</td><td>Same Date and Time</td></tr><tr><td>5</td><td>Exact Match (Pick List Label)</td></tr><tr><td>6</td><td>Exact Match (Pick List Value)</td></tr><tbody></table>|
|operatorparam|Edm.Int32|**Display Name**: Operator Parameter<br />**Description**: Parameter value of N if the operator is Same First Characters or Same Last Characters.<br />|
|owningbusinessunit|Edm.Guid|**Display Name**: Owning Business Unit<br />**Description**: Unique identifier of the business unit that owns the condition.<br />Read-only<br />|
|owninguser|Edm.Guid|**Display Name**: Owning User<br />**Description**: Unique identifier of the user who owns the condition.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the condition.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the duplicate rule condition.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the condition.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the duplicate rule condition.|
|_ownerid_value||Unique identifier of the user or team who owns the duplicate rule condition.|
|_regardingobjectid_value|regardingobjectid<br />|Unique identifier of the object with which the condition is associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_duplicateruleconditionbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_duplicaterulecondition_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_duplicateruleconditionbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_duplicaterulecondition_modifiedonbehalfby|
|regardingobjectid|[duplicaterule EntityType](duplicaterule.md)|DuplicateRule_DuplicateRuleConditions|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|DuplicateRuleCondition_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_duplicaterulecondition_syncerror|  

## Operations
The following operations can be used with the duplicaterulecondition entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CompoundUpdateDuplicateDetectionRule Action](../actions/compoundupdateduplicatedetectionrule.md)|Not Bound|[!INCLUDE[../actions/descriptions/compoundupdateduplicatedetectionrule.md](../actions/descriptions/compoundupdateduplicatedetectionrule.md)]|    

[!INCLUDE[./remarks/duplicaterulecondition.md](./remarks/duplicaterulecondition.md)]

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