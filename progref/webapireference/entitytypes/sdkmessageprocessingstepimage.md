---
title: "Microsoft Dynamics 365 Customer Engagement sdkmessageprocessingstepimage EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: afe0ada2-0512-43f1-8e79-106147f70cbe
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API sdkmessageprocessingstepimage entitytype."
---
# sdkmessageprocessingstepimage EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/sdkmessageprocessingstepimage.md](./descriptions/sdkmessageprocessingstepimage.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]sdkmessageprocessingstepimages </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Sdk Message Processing Step Image</td></tr>
<tr><td><b>Primary Key:</b></td><td>sdkmessageprocessingstepimageid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The sdkmessageprocessingstepimage EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|attributes|Edm.String|**Display Name**: Attributes<br />**Description**: Comma-separated list of attributes that are to be passed into the SDK message processing step image.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the SDK message processing step image was created.<br />Read-only<br />|
|customizationlevel|Edm.Int32|**Description**: Customization level of the SDK message processing step image.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the SDK message processing step image.<br />|
|entityalias|Edm.String|**Display Name**: Entity Alias<br />**Description**: Key name used to access the pre-image or post-image property bags in a step.<br />|
|imagetype|Edm.Int32|**Display Name**: Image Type<br />**Description**: Type of image requested.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>PreImage</td></tr><tr><td>1</td><td>PostImage</td></tr><tr><td>2</td><td>Both</td></tr><tbody></table>|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|ismanaged|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|messagepropertyname|Edm.String|**Display Name**: Message Property Name<br />**Description**: Name of the property on the Request message.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified By<br />**Description**: Date and time when the SDK message processing step was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of SdkMessage processing step image.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|relatedattributename|Edm.String|**Display Name**: Related Attribute Name<br />**Description**: Name of the related entity.<br />|
|sdkmessageprocessingstepimageid|Edm.Guid|**Description**: Unique identifier of the SDK message processing step image entity.<br />|
|sdkmessageprocessingstepimageidunique|Edm.Guid|**Description**: Unique identifier of the SDK message processing step image.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|versionnumber|Edm.Int64|**Description**: Number that identifies a specific revision of the step image. <br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the SDK message processing step image.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the sdkmessageprocessingstepimage.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the SDK message processing step.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the sdkmessageprocessingstepimage.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the SDK message processing step is associated.|
|_sdkmessageprocessingstepid_value|sdkmessageprocessingstepid<br />|Unique identifier of the SDK message processing step.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|createdby_sdkmessageprocessingstepimage|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_sdkmessageprocessingstepimage_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|modifiedby_sdkmessageprocessingstepimage|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_sdkmessageprocessingstepimage_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_sdkmessageprocessingstepimage|
|sdkmessageprocessingstepid|[sdkmessageprocessingstep EntityType](sdkmessageprocessingstep.md)|sdkmessageprocessingstepid_sdkmessageprocessingstepimage|  

[!INCLUDE[./remarks/sdkmessageprocessingstepimage.md](./remarks/sdkmessageprocessingstepimage.md)]

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