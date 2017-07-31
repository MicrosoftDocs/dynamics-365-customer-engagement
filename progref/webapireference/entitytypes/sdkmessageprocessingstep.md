---
title: "Microsoft Dynamics 365 Customer Engagement sdkmessageprocessingstep EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8b4d5a48-8d82-4c43-a83c-220452bb1ae0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API sdkmessageprocessingstep entitytype."
---
# sdkmessageprocessingstep EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/sdkmessageprocessingstep.md](./descriptions/sdkmessageprocessingstep.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]sdkmessageprocessingsteps </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Sdk Message Processing Step</td></tr>
<tr><td><b>Primary Key:</b></td><td>sdkmessageprocessingstepid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The sdkmessageprocessingstep EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|asyncautodelete|Edm.Boolean|**Display Name**: Asynchronous Automatic Delete<br />**Description**: Indicates whether the asynchronous system job is automatically deleted on completion.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|canusereadonlyconnection|Edm.Boolean|**Display Name**: Intent<br />**Description**: Identifies whether a SDK Message Processing Step type will be ReadOnly or Read Write. false - ReadWrite, true - ReadOnly <br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|configuration|Edm.String|**Display Name**: Configuration<br />**Description**: Step-specific configuration for the plug-in type. Passed to the plug-in constructor at run time.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the SDK message processing step was created.<br />Read-only<br />|
|customizationlevel|Edm.Int32|**Description**: Customization level of the SDK message processing step.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the SDK message processing step.<br />|
|eventexpander|Edm.String|**Display Name**: EventExpander<br />**Description**: Configuration for sending pipeline events to the Event Expander service.<br />|
|filteringattributes|Edm.String|**Display Name**: Filtering Attributes<br />**Description**: Comma-separated list of attributes. If at least one of these attributes is modified, the plug-in should execute.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)||
|ishidden|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Hidden<br />**Description**: Information that specifies whether this component should be hidden.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Information that specifies whether this component is managed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|mode|Edm.Int32|**Display Name**: Execution Mode<br />**Description**: Run-time mode of execution, for example, synchronous or asynchronous.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Synchronous</td></tr><tr><td>1</td><td>Asynchronous</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the SDK message processing step was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of SdkMessage processing step.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|rank|Edm.Int32|**Display Name**: Execution Order<br />**Description**: Processing order within the stage.<br />|
|sdkmessageprocessingstepid|Edm.Guid|**Description**: Unique identifier of the SDK message processing step entity.<br />|
|sdkmessageprocessingstepidunique|Edm.Guid|**Description**: Unique identifier of the SDK message processing step.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|stage|Edm.Int32|**Display Name**: Execution Stage<br />**Description**: Stage in the execution pipeline that the SDK message processing step is in.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>5</td><td>Initial Pre-operation (For internal use only)</td></tr><tr><td>10</td><td>Pre-validation</td></tr><tr><td>15</td><td>Internal Pre-operation Before External Plugins (For internal use only)</td></tr><tr><td>20</td><td>Pre-operation</td></tr><tr><td>25</td><td>Internal Pre-operation After External Plugins (For internal use only)</td></tr><tr><td>30</td><td>Main Operation (For internal use only)</td></tr><tr><td>35</td><td>Internal Post-operation Before External Plugins (For internal use only)</td></tr><tr><td>40</td><td>Post-operation</td></tr><tr><td>45</td><td>Internal Post-operation After External Plugins (For internal use only)</td></tr><tr><td>50</td><td>Post-operation (Deprecated)</td></tr><tr><td>55</td><td>Final Post-operation (For internal use only)</td></tr><tbody></table>|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the SDK message processing step.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Enabled</td></tr><tr><td>1</td><td>Disabled</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the SDK message processing step.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Enabled</td></tr><tr><td>2</td><td>Disabled</td></tr><tbody></table>|
|supporteddeployment|Edm.Int32|**Display Name**: Deployment<br />**Description**: Deployment that the SDK message processing step should be executed on; server, client, or both.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Server Only</td></tr><tr><td>1</td><td>Microsoft Dynamics 365 Client for Outlook Only</td></tr><tr><td>2</td><td>Both</td></tr><tbody></table>|
|versionnumber|Edm.Int64|**Description**: Number that identifies a specific revision of the SDK message processing step. <br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the SDK message processing step.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the sdkmessageprocessingstep.|
|_eventhandler_value|eventhandler_plugintype<br />eventhandler_serviceendpoint<br />|Unique identifier of the associated event handler.|
|_impersonatinguserid_value|impersonatinguserid<br />|Unique identifier of the user to impersonate context when step is executed.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the SDK message processing step.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the sdkmessageprocessingstep.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the SDK message processing step is associated.|
|_sdkmessagefilterid_value|sdkmessagefilterid<br />|Unique identifier of the SDK message filter.|
|_sdkmessageid_value|sdkmessageid<br />|Unique identifier of the SDK message.|
|_sdkmessageprocessingstepsecureconfigid_value|sdkmessageprocessingstepsecureconfigid<br />|Unique identifier of the Sdk message processing step secure configuration.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|createdby_sdkmessageprocessingstep|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_sdkmessageprocessingstep_createdonbehalfby|
|eventhandler_plugintype|[plugintype EntityType](plugintype.md)|plugintype_sdkmessageprocessingstep|
|eventhandler_serviceendpoint|[serviceendpoint EntityType](serviceendpoint.md)|serviceendpoint_sdkmessageprocessingstep|
|impersonatinguserid|[systemuser EntityType](systemuser.md)|impersonatinguserid_sdkmessageprocessingstep|
|modifiedby|[systemuser EntityType](systemuser.md)|modifiedby_sdkmessageprocessingstep|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_sdkmessageprocessingstep_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_sdkmessageprocessingstep|
|plugintypeid|[plugintype EntityType](plugintype.md)|plugintypeid_sdkmessageprocessingstep|
|sdkmessagefilterid|[sdkmessagefilter EntityType](sdkmessagefilter.md)|sdkmessagefilterid_sdkmessageprocessingstep|
|sdkmessageid|[sdkmessage EntityType](sdkmessage.md)|sdkmessageid_sdkmessageprocessingstep|
|sdkmessageprocessingstepsecureconfigid|[sdkmessageprocessingstepsecureconfig EntityType](sdkmessageprocessingstepsecureconfig.md)|sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|SdkMessageProcessingStep_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|owningextensionid|  
|sdkmessageprocessingstepid_sdkmessageprocessingstepimage|[sdkmessageprocessingstepimage EntityType](sdkmessageprocessingstepimage.md)|sdkmessageprocessingstepid|    

[!INCLUDE[./remarks/sdkmessageprocessingstep.md](./remarks/sdkmessageprocessingstep.md)]

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