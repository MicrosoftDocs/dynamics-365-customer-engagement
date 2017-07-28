---
title: "Microsoft Dynamics 365 Customer Engagement webwizard EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5db5649b-a6d9-4885-8119-84c82f5ef1ea
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API webwizard entitytype."
---
# webwizard EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/webwizard.md](./descriptions/webwizard.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]webwizards </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Web Wizard</td></tr>
<tr><td><b>Primary Key:</b></td><td>webwizardid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The webwizard EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|accessprivileges|Edm.String|**Display Name**: Access Privileges<br />**Description**: Privileges required to use this wizard, separated with commas (,).<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the wizard definition was created.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the component is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Information that specifies whether this component is managed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|isstaticpagesequence|Edm.Boolean|**Display Name**: Is Static Page Sequence<br />**Description**: Information about whether all pages for this wizard are statically defined.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the wizard definition was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the wizard<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|startpagesequencenumber|Edm.Int32|**Display Name**: Start Page Sequence Number<br />**Description**: Sequence number of the first page of this wizard.<br />|
|titleresourcestring|Edm.String|**Display Name**: Title<br />**Description**: Title of the wizard.<br />|
|versionnumber|Edm.Int64|Read-only<br />|
|webwizardid|Edm.Guid|**Display Name**: Web Wizard<br />**Description**: Unique identifier of the wizard.<br />|
|webwizardidunique|Edm.Guid|**Description**: Unique identifier of the Web Wizard.<br />Read-only<br />|
|wizardpageheight|Edm.Int32|**Display Name**: Page Height<br />**Description**: Window height for the wizard.<br />|
|wizardpagewidth|Edm.Int32|**Display Name**: Page Width<br />**Description**: Window width for the wizard.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the wizard definition.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the webwizard.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the wizard definition.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the webwizard.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_webwizard_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_webwizard_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_webwizard_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_webwizard_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_webwizard|  

[!INCLUDE[./remarks/webwizard.md](./remarks/webwizard.md)]

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