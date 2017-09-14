---
title: "Microsoft Dynamics 365 Customer Engagement plugintype EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a75e415c-022a-4304-9c48-6dc4dfe9b698
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API plugintype entitytype."
---
# plugintype EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/plugintype.md](./descriptions/plugintype.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]plugintypes </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Plug-in Type</td></tr>
<tr><td><b>Primary Key:</b></td><td>plugintypeid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The plugintype EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|assemblyname|Edm.String|**Display Name**: Assembly Name<br />**Description**: Full path name of the plug-in assembly.<br />Read-only<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the plug-in type was created.<br />Read-only<br />|
|culture|Edm.String|**Display Name**: Culture<br />**Description**: Culture code for the plug-in assembly.<br />Read-only<br />|
|customizationlevel|Edm.Int32|**Description**: Customization level of the plug-in type.<br />Read-only<br />|
|customworkflowactivityinfo|Edm.String|**Display Name**: Custom Workflow Activity Info<br />**Description**: Serialized Custom Activity Type information, including required arguments. For more information, see SandboxCustomActivityInfo.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the plug-in type.<br />|
|friendlyname|Edm.String|**Display Name**: Display Name<br />**Description**: User friendly name for the plug-in.<br />|
|ismanaged|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|isworkflowactivity|Edm.Boolean|**Display Name**: Is Workflow Activity<br />**Description**: Indicates if the plug-in is a custom activity for workflows.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|major|Edm.Int32|**Display Name**: Version major<br />**Description**: Major of the version number of the assembly for the plug-in type.<br />Read-only<br />|
|minor|Edm.Int32|**Display Name**: Version minor<br />**Description**: Minor of the version number of the assembly for the plug-in type.<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the plug-in type was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the plug-in type.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|plugintypeid|Edm.Guid|**Display Name**: Plug-in Type<br />**Description**: Unique identifier of the plug-in type.<br />|
|plugintypeidunique|Edm.Guid|**Description**: Unique identifier of the plug-in type.<br />Read-only<br />|
|publickeytoken|Edm.String|**Display Name**: Public Key Token<br />**Description**: Public key token of the assembly for the plug-in type.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|typename|Edm.String|**Display Name**: Type Name<br />**Description**: Fully qualified type name of the plug-in type.<br />|
|version|Edm.String|**Display Name**: Version<br />**Description**: Version number of the assembly for the plug-in type.<br />Read-only<br />|
|versionnumber|Edm.Int64|Read-only<br />|
|workflowactivitygroupname|Edm.String|**Display Name**: Workflow Activity Group Name<br />**Description**: Group name of workflow custom activity.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the plug-in type.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the plugintype.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the plug-in type.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the plugintype.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the plug-in type is associated.|
|_pluginassemblyid_value|pluginassemblyid<br />|Unique identifier of the plug-in assembly that contains this plug-in type.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|createdby_plugintype|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_plugintype_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|modifiedby_plugintype|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_plugintype_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_plugintype|
|pluginassemblyid|[pluginassembly EntityType](pluginassembly.md)|pluginassembly_plugintype|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|plugin_type_service|[service EntityType](service.md)|strategyid|  
|plugintype_sdkmessageprocessingstep|[sdkmessageprocessingstep EntityType](sdkmessageprocessingstep.md)|eventhandler_plugintype|  
|plugintypeid_sdkmessageprocessingstep|[sdkmessageprocessingstep EntityType](sdkmessageprocessingstep.md)|plugintypeid|    

[!INCLUDE[./remarks/plugintype.md](./remarks/plugintype.md)]

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