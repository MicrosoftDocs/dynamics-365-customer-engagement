---
title: "Microsoft Dynamics 365 Customer Engagement customcontroldefaultconfig EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7a9da537-7cb4-4d35-8ba1-a0c146061402
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API customcontroldefaultconfig entitytype."
---
# customcontroldefaultconfig EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/customcontroldefaultconfig.md](./descriptions/customcontroldefaultconfig.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]customcontroldefaultconfigs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Custom Control Default Config</td></tr>
<tr><td><b>Primary Key:</b></td><td>customcontroldefaultconfigid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The customcontroldefaultconfig EntityType:
* Has no collection-valued navigation properties.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|controldescriptionjson|Edm.String|**Display Name**: Custom control configuration data in JSON format.<br />**Description**: Custom control configuration data in JSON format.<br />|
|controldescriptionxml|Edm.String|**Display Name**: ControlDescriptionXML<br />**Description**: controlDescriptionXML of the custom control default config.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|customcontroldefaultconfigid|Edm.Guid|**Display Name**: Custom Control Default Config Identifier<br />**Description**: Unique identifier of the Custom Control Default Config for the Microsoft Dynamics 365.<br />|
|customcontroldefaultconfigidunique|Edm.Guid|**Description**: For internal use only.<br />Read-only<br />|
|eventsxml|Edm.String|**Display Name**: Events XML<br />**Description**: The events XML of the custom control default config.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|ismanaged|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|primaryentitytypecode|Edm.String|**Display Name**: Entity Type Code of the Custom Control Default Config<br />**Description**: Entity Type Code of the Custom Control Default Config.<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the Custom Control Default Config.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the web resource.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_customcontroldefaultconfig_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_customcontroldefaultconfig_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_customcontroldefaultconfig_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_customcontroldefaultconfig_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|customcontroldefaultconfig_organization|

## Operations
The following operations can be used with the customcontroldefaultconfig entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|    

[!INCLUDE[./remarks/customcontroldefaultconfig.md](./remarks/customcontroldefaultconfig.md)]

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