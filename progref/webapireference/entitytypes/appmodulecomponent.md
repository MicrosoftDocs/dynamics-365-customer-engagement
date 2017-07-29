---
title: "Microsoft Dynamics 365 Customer Engagement appmodulecomponent EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2b4de416-40f8-4aaf-b618-7a6b66a7e9a4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API appmodulecomponent entitytype."
---
# appmodulecomponent EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/appmodulecomponent.md](./descriptions/appmodulecomponent.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]appmodulecomponents </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>App Module Component</td></tr>
<tr><td><b>Primary Key:</b></td><td>appmodulecomponentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The appmodulecomponent EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|appmodulecomponentid|Edm.Guid|**Display Name**: App Module Component<br />**Description**: Unique identifier for entity instances<br />|
|appmodulecomponentidunique|Edm.Guid|**Display Name**: Application Component Unique Id<br />**Description**: Unique identifier of the Application Component used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook<br />|
|componenttype|Edm.Int32|**Display Name**: Object Type Code<br />**Description**: The object type code of the component.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Entities</td></tr><tr><td>26</td><td>Views</td></tr><tr><td>29</td><td>Business Process Flows</td></tr><tr><td>48</td><td>Command (Ribbon) for Forms, Grids, sub grids</td></tr><tr><td>59</td><td>Charts</td></tr><tr><td>60</td><td>Forms</td></tr><tr><td>62</td><td>Sitemap</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the Application Component with respect to the base currency.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the application component record is introduced.<br />|
|isdefault|Edm.Boolean|**Display Name**: Is Default<br />**Description**: Is Default<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismetadata|Edm.Boolean|**Display Name**: Is Metadata<br />**Description**: Is Metadata<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Metadata</td></tr><tr><td>0</td><td>Data</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|objectid|Edm.Guid|**Display Name**: Object<br />**Description**: Object Id<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|rootappmodulecomponentid|Edm.Guid|**Display Name**: Root App Module Component<br />**Description**: The parent ID of the subcomponent, which will be a root<br />|
|rootcomponentbehavior|Edm.Int32|**Display Name**: Root Component Behavior<br />**Description**: Indicates the include behavior of the root component.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Include Subcomponents</td></tr><tr><td>1</td><td>Do not include subcomponents</td></tr><tr><td>2</td><td>Include As Shell Only</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_appmoduleidunique_value|appmoduleid<br />|The App Module Id Unique|
|_createdby_value|appmodulecomponent_createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|appmodulecomponent_modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|appmodulecomponent_createdby|[systemuser EntityType](systemuser.md)|appmodulecomponent_createdby|
|appmodulecomponent_modifiedby|[systemuser EntityType](systemuser.md)|appmodulecomponent_modifiedby|
|appmoduleid|[appmodule EntityType](appmodule.md)|appmodule_appmodulecomponent|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_appmodulecomponent_createdonbehalfby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_appmodulecomponent_modifiedonbehalfby|  

[!INCLUDE[./remarks/appmodulecomponent.md](./remarks/appmodulecomponent.md)]

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