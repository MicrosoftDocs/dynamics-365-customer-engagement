---
title: "Microsoft Dynamics 365 Customer Engagement documenttemplate EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 93bce111-c779-4328-a2af-e0db9f3f5db2
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API documenttemplate entitytype."
---
# documenttemplate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/documenttemplate.md](./descriptions/documenttemplate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]documenttemplates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Document Template</td></tr>
<tr><td><b>Primary Key:</b></td><td>documenttemplateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The documenttemplate EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|associatedentitytypecode|Edm.String|**Display Name**: Associated Entity Type Code<br />**Description**: Associated Entity Type Code.<br />|
|clientdata|Edm.String|**Display Name**: Client Data<br />**Description**: Client data regarding this document template.<br />|
|content|Edm.String|**Display Name**: Content<br />**Description**: Bytes of the document template.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the document template was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Additional information to describe the Document Template<br />|
|documenttemplateid|Edm.Guid|**Display Name**: Document Template Identifier<br />**Description**: Unique identifier of the document template.<br />|
|documenttype|Edm.Int32|**Display Name**: Type<br />**Description**: Option set for selecting the type of the document template<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Microsoft Excel</td></tr><tr><td>2</td><td>Microsoft Word</td></tr><tbody></table>|
|languagecode|Edm.Int32|**Display Name**: Language<br />**Description**: Language of Document Template.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the document template was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the document template.<br />|
|status|Edm.Boolean|**Display Name**: Status<br />**Description**: Information about whether the document template is active.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Draft</td></tr><tr><td>0</td><td>Activated</td></tr><tbody></table>|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the document template.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the document template.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the document template.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the document template.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the web resource.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_documenttemplatebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_documenttemplatebase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_documenttemplatebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_documenttemplatebase_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|lk_documenttemplatebase_organization|

## Solutions
The following solutions include the documenttemplate entity type.


|Name|Description |  
|----|------------|  
|[AppCommon Solution](../solutions/appcommon.md)|[!INCLUDE[../solutions/descriptions/appcommon.md](../solutions/descriptions/appcommon.md)]|    

[!INCLUDE[./remarks/documenttemplate.md](./remarks/documenttemplate.md)]

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