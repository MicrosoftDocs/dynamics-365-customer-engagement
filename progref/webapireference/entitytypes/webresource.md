---
title: "Microsoft Dynamics 365 Customer Engagement webresource EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 0f732d46-1be8-42e4-abb0-24ed633958ac
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API webresource entitytype."
---
# webresource EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/webresource.md](./descriptions/webresource.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]webresourceset </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Web Resource</td></tr>
<tr><td><b>Primary Key:</b></td><td>webresourceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The webresource entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|canbedeleted|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Can Be Deleted<br />**Description**: Information that specifies whether this component can be deleted.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|content|Edm.String|**Description**: Bytes of the web resource, in Base64 format.<br />|
|content_binary|Edm.Binary|**Description**: Bytes of the web resource, in Base64 format.<br />|
|contentjson|Edm.String|**Description**: Json representation of the content of the resource.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the web resource was created.<br />Read-only<br />|
|dependencyxml|Edm.String|**Display Name**: DependencyXML<br />**Description**: For internal use only.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the web resource.<br />|
|displayname|Edm.String|**Display Name**: Display Name<br />**Description**: Display name of the web resource.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|isavailableformobileoffline|Edm.Boolean|**Display Name**: Is Available For Mobile Offline<br />**Description**: Information that specifies whether this web resource is available for mobile client in offline mode.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|isenabledformobileclient|Edm.Boolean|**Display Name**: Is Enabled For Mobile Client<br />**Description**: Information that specifies whether this web resource is enabled for mobile client.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ishidden|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Hidden<br />**Description**: Information that specifies whether this component should be hidden.<br />|
|ismanaged|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|languagecode|Edm.Int32|**Display Name**: Language<br />**Description**: Language of the web resource.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the web resource was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the web resource.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|silverlightversion|Edm.String|**Display Name**: Silverlight Version<br />**Description**: Silverlight runtime version number required by a silverlight web resource.<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|versionnumber|Edm.Int64|Read-only<br />|
|webresourceid|Edm.Guid|**Display Name**: Web Resource Identifier<br />**Description**: Unique identifier of the web resource.<br />|
|webresourceidunique|Edm.Guid|**Description**: For internal use only.<br />Read-only<br />|
|webresourcetype|Edm.Int32|**Display Name**: Type<br />**Description**: Drop-down list for selecting the type of the web resource.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Webpage (HTML)</td></tr><tr><td>2</td><td>Style Sheet (CSS)</td></tr><tr><td>3</td><td>Script (JScript)</td></tr><tr><td>4</td><td>Data (XML)</td></tr><tr><td>5</td><td>PNG format</td></tr><tr><td>6</td><td>JPG format</td></tr><tr><td>7</td><td>GIF format</td></tr><tr><td>8</td><td>Silverlight (XAP)</td></tr><tr><td>9</td><td>Style Sheet (XSL)</td></tr><tr><td>10</td><td>ICO format</td></tr><tr><td>11</td><td>Vector format (SVG)</td></tr><tr><td>12</td><td>String (RESX)</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the web resource.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the web resource.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the web resource.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the web resource.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the web resource.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|webresource_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_webresourcebase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|webresource_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_webresourcebase_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|webresource_organization|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|lk_theme_logoid|[theme EntityType](theme.md)|logoimage|  
|solution_configuration_webresource|[solution EntityType](solution.md)|configurationpageid|  
|webresource_savedqueryvisualizations|[savedqueryvisualization EntityType](savedqueryvisualization.md)|webresourceid|  
|webresource_userqueryvisualizations|[userqueryvisualization EntityType](userqueryvisualization.md)|webresourceid|  

## Operations
The following operations can be used with the webresource entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|    

[!INCLUDE[./remarks/webresource.md](./remarks/webresource.md)]

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