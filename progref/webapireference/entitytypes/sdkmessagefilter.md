---
title: "Microsoft Dynamics 365 Customer Engagement sdkmessagefilter EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: aa91a5d2-9cf9-40e3-9a7b-16e6ed15c5c8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API sdkmessagefilter entitytype."
---
# sdkmessagefilter EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/sdkmessagefilter.md](./descriptions/sdkmessagefilter.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]sdkmessagefilters </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Sdk Message Filter</td></tr>
<tr><td><b>Primary Key:</b></td><td>sdkmessagefilterid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The sdkmessagefilter EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|availability|Edm.Int32|**Display Name**: Availability<br />**Description**: Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.<br />|
|componentstate|Edm.Int32|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the SDK message filter was created.<br />Read-only<br />|
|customizationlevel|Edm.Int32|**Description**: Customization level of the SDK message filter.<br />Read-only<br />|
|introducedversion|Edm.String||
|iscustomprocessingstepallowed|Edm.Boolean|**Display Name**: Custom Processing Step Allowed<br />**Description**: Indicates whether a custom SDK message processing step is allowed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|isvisible|Edm.Boolean|**Description**: Indicates whether the filter should be visible.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the SDK message filter was last modified.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|Read-only<br />|
|primaryobjecttypecode|Edm.String|**Display Name**: Primary Object Type Code<br />**Description**: Type of entity with which the SDK message filter is primarily associated.<br />Read-only<br />|
|restrictionlevel|Edm.Int32|**Description**: For internal use only.<br />|
|sdkmessagefilterid|Edm.Guid|**Description**: Unique identifier of the SDK message filter entity.<br />|
|sdkmessagefilteridunique|Edm.Guid|**Description**: Unique identifier of the SDK message filter.<br />Read-only<br />|
|secondaryobjecttypecode|Edm.String|**Display Name**: Secondary Object Type Code<br />**Description**: Type of entity with which the SDK message filter is secondarily associated.<br />Read-only<br />|
|solutionid|Edm.Guid|Read-only<br />|
|versionnumber|Edm.Int64|Read-only<br />|
|workflowsdkstepenabled|Edm.Boolean|**Display Name**: WorkflowSdkStepEnabled<br />**Description**: Whether or not the SDK message can be called from a workflow.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the SDK message filter.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the sdkmessagefilter.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the SDK message filter.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the sdkmessagefilter.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the SDK message filter is associated.|
|_sdkmessageid_value|sdkmessageid<br />|Unique identifier of the related SDK message.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|createdby_sdkmessagefilter|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_sdkmessagefilter_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|modifiedby_sdkmessagefilter|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_sdkmessagefilter_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_sdkmessagefilter|
|sdkmessageid|[sdkmessage EntityType](sdkmessage.md)|sdkmessageid_sdkmessagefilter|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|sdkmessagefilterid_sdkmessageprocessingstep|[sdkmessageprocessingstep EntityType](sdkmessageprocessingstep.md)|sdkmessagefilterid|    

[!INCLUDE[./remarks/sdkmessagefilter.md](./remarks/sdkmessagefilter.md)]

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