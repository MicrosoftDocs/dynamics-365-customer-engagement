---
title: "Microsoft Dynamics 365 Customer Engagement pluginassembly EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 6f44af15-6283-4a5c-98d0-2951ea931f97
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API pluginassembly entitytype."
---
# pluginassembly EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/pluginassembly.md](./descriptions/pluginassembly.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]pluginassemblies </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Plug-in Assembly</td></tr>
<tr><td><b>Primary Key:</b></td><td>pluginassemblyid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The pluginassembly EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|authtype|Edm.Int32|**Display Name**: Specifies mode of authentication with web sources<br />**Description**: Specifies mode of authentication with web sources like WebApp<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>BasicAuth</td></tr><tbody></table>|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|content|Edm.String|**Description**: Bytes of the assembly, in Base64 format.<br />|
|content_binary|Edm.Binary|**Description**: Bytes of the assembly, in Base64 format.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the plug-in assembly was created.<br />Read-only<br />|
|culture|Edm.String|**Display Name**: Culture<br />**Description**: Culture code for the plug-in assembly.<br />|
|customizationlevel|Edm.Int32|**Description**: Customization Level.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the plug-in assembly.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|ishidden|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Hidden<br />**Description**: Information that specifies whether this component should be hidden.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Information that specifies whether this component is managed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|isolationmode|Edm.Int32|**Display Name**: Isolation Mode<br />**Description**: Information about how the plugin assembly is to be isolated at execution time; None / Sandboxed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>None</td></tr><tr><td>2</td><td>Sandbox</td></tr><tr><td>3</td><td>External</td></tr><tbody></table>|
|major|Edm.Int32|**Description**: Major of the assembly version.<br />Read-only<br />|
|minor|Edm.Int32|**Description**: Minor of the assembly version.<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the plug-in assembly was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the plug-in assembly.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|password|Edm.String|**Display Name**: User Password<br />**Description**: User Password<br />|
|path|Edm.String|**Display Name**: Path<br />**Description**: File name of the plug-in assembly. Used when the source type is set to 1.<br />|
|pluginassemblyid|Edm.Guid|**Description**: Unique identifier of the plug-in assembly.<br />|
|pluginassemblyidunique|Edm.Guid|**Description**: Unique identifier of the plug-in assembly.<br />Read-only<br />|
|publickeytoken|Edm.String|**Display Name**: Public Key Token<br />**Description**: Public key token of the assembly. This value can be obtained from the assembly by using reflection.<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|sourcehash|Edm.String|**Description**: Hash of the source of the assembly.<br />|
|sourcetype|Edm.Int32|**Display Name**: Source Type<br />**Description**: Location of the assembly, for example 0=database, 1=on-disk.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Database</td></tr><tr><td>1</td><td>Disk</td></tr><tr><td>2</td><td>Normal</td></tr><tr><td>3</td><td>AzureWebApp</td></tr><tbody></table>|
|url|Edm.String|**Display Name**: Web Url<br />**Description**: Web Url<br />|
|username|Edm.String|**Display Name**: User Name<br />**Description**: User Name<br />|
|version|Edm.String|**Display Name**: Version<br />**Description**: Version number of the assembly. The value can be obtained from the assembly through reflection.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the plug-in assembly.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the pluginassembly.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the plug-in assembly.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the pluginassembly.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the plug-in assembly is associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|createdby_pluginassembly|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_pluginassembly_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|modifiedby_pluginassembly|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_pluginassembly_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_pluginassembly|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|pluginassembly_plugintype|[plugintype EntityType](plugintype.md)|pluginassemblyid|    

[!INCLUDE[./remarks/pluginassembly.md](./remarks/pluginassembly.md)]

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