---
title: "Microsoft Dynamics 365 Customer Engagement plugintracelog EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b0333c2b-5067-4ab1-b5a7-604ece226c60
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API plugintracelog entitytype."
---
# plugintracelog EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/plugintracelog.md](./descriptions/plugintracelog.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]plugintracelogs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Plug-in Trace Log</td></tr>
<tr><td><b>Primary Key:</b></td><td>plugintracelogid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>typename</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET,DELETE</td></tr>
</table>
  
The plugintracelog EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|configuration|Edm.String|**Display Name**: Configuration<br />**Description**: Unsecured configuration for the plug-in trace log.<br />Read-only<br />|
|correlationid|Edm.Guid|**Display Name**: Correlation Id<br />**Description**: Unique identifier for tracking plug-in or custom workflow activity execution.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|depth|Edm.Int32|**Display Name**: Depth<br />**Description**: Depth of execution of the plug-in or custom workflow activity.<br />Read-only<br />|
|exceptiondetails|Edm.String|**Display Name**: Exception Details<br />**Description**: Details of the exception.<br />Read-only<br />|
|issystemcreated|Edm.Boolean|**Display Name**: System Created<br />**Description**: Where the event originated. Set to true if it's a system trace; otherwise, false.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|messageblock|Edm.String|**Display Name**: Message Block<br />**Description**: Trace text from the plug-in.<br />Read-only<br />|
|messagename|Edm.String|**Display Name**: Message Name<br />**Description**: Name of the message that triggered this plug-in.<br />Read-only<br />|
|mode|Edm.Int32|**Display Name**: Mode<br />**Description**: Type of execution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Synchronous</td></tr><tr><td>1</td><td>Asynchronous</td></tr><tbody></table>|
|operationtype|Edm.Int32|**Display Name**: Operation Type<br />**Description**: Type of custom code.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Unknown</td></tr><tr><td>1</td><td>Plug-in</td></tr><tr><td>2</td><td>Workflow Activity</td></tr><tbody></table>|
|organizationid|Edm.Guid|**Display Name**: Organization Id<br />**Description**: Unique identifier for the organization.<br />Read-only<br />|
|performanceconstructorduration|Edm.Int32|**Display Name**: Constructor Duration<br />**Description**: Time, in milliseconds, to construct.<br />Read-only<br />|
|performanceconstructorstarttime|Edm.DateTimeOffset|**Display Name**: Constructor Start Time<br />**Description**: Date and time when constructed.<br />Read-only<br />|
|performanceexecutionduration|Edm.Int32|**Display Name**: Execution Duration<br />**Description**: Time, in milliseconds, to execute the request.<br />Read-only<br />|
|performanceexecutionstarttime|Edm.DateTimeOffset|**Display Name**: Execution Start Time<br />**Description**: Time, in milliseconds, to execute the request.<br />Read-only<br />|
|persistencekey|Edm.Guid|**Display Name**: Persistence Key<br />**Description**: Asynchronous workflow persistence key.<br />Read-only<br />|
|pluginstepid|Edm.Guid|**Display Name**: Plugin Step ID<br />**Description**: ID of the plug-in registration step.<br />Read-only<br />|
|plugintracelogid|Edm.Guid|**Display Name**: Plug-in Trace Log<br />**Description**: Unique identifier for an entity instance.<br />Read-only<br />|
|primaryentity|Edm.String|**Display Name**: Primary Entity<br />**Description**: Entity, if any, that the plug-in is executed against.<br />Read-only<br />|
|profile|Edm.String|**Display Name**: Profile<br />**Description**: Plug-in profile formatted as serialized text.<br />Read-only<br />|
|requestid|Edm.Guid|**Display Name**: Request ID<br />**Description**: Unique identifier of the message request.<br />Read-only<br />|
|secureconfiguration|Edm.String|**Display Name**: Secure Configuration<br />**Description**: Secured configuration for the plug-in trace log.<br />Read-only<br />|
|typename|Edm.String|**Display Name**: Type Name<br />**Description**: Class name of the plug-in.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the delegate user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|createdby_plugintracelog|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_plugintracelogbase_createdonbehalfby|  

[!INCLUDE[./remarks/plugintracelog.md](./remarks/plugintracelog.md)]

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