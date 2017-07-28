---
title: "Microsoft Dynamics 365 Customer Engagement appmodule EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f95d3037-475c-4641-8a4a-6a5307cffa12
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API appmodule entitytype."
---
# appmodule EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/appmodule.md](./descriptions/appmodule.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]appmodules </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>App</td></tr>
<tr><td><b>Primary Key:</b></td><td>appmoduleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The appmodule entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|appmoduleid|Edm.Guid|**Display Name**: AppModuleId<br />**Description**: Unique identifier for entity instances<br />|
|appmoduleidunique|Edm.Guid|**Display Name**: App Module Unique Id<br />**Description**: Unique identifier of the App Module used when synchronizing customizations for the Microsoft Dynamics 365 client for Outlook<br />|
|appmoduleversion|Edm.String|**Display Name**: App Module Version<br />**Description**: App Module Version<br />|
|appmodulexmlmanaged|Edm.String|**Description**: App Module Xml Managed<br />|
|clienttype|Edm.Int32|**Display Name**: Client Type<br />**Description**: Client Type such as Web or UCI<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|configxml|Edm.String|**Description**: Contains configuration XML<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description for entity<br />|
|descriptor|Edm.String|**Display Name**: Descriptor<br />**Description**: App Module Descriptor<br />Read-only<br />|
|formfactor|Edm.Int32|**Display Name**: Form Factor<br />**Description**: Form Factor<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the similarity rule is introduced.<br />|
|isdefault|Edm.Boolean|**Display Name**: Is Default<br />**Description**: Is Default<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isfeatured|Edm.Boolean|**Display Name**: IsFeatured<br />**Description**: Is Featured<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|**Display Name**: IsManaged<br />**Description**: Is Managed<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of App Module<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Overwrite Time<br />**Description**: Internal use only<br />Read-only<br />|
|publishedon|Edm.DateTimeOffset|**Display Name**: Published On<br />**Description**: Date and time when the record was published.<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|uniquename|Edm.String|**Display Name**: Unique Name<br />**Description**: Unique Name of App Module<br />|
|url|Edm.String|**Display Name**: URL<br />**Description**: Contains URL<br />|
|versionnumber|Edm.Int64|Read-only<br />|
|webresourceid|Edm.Guid|**Display Name**: Web Resource Id<br />**Description**: Unique identifier of the Web Resource<br />|
|welcomepageid|Edm.Guid|**Display Name**: Welcome Page Id<br />**Description**: Unique identifier of the Web Resource as Welcome Page Id<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|appmodule_createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|appmodule_createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|appmodule_modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|appmodule_modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organization_appmodule_appmodule<br />|Unique identifier of the organization associated with the app.|
|_publisherid_value|publisher_appmodule_appmodule<br />|Unique identifier of the publisher.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|appmodule_createdby|[systemuser EntityType](systemuser.md)|systemuser_appmodule_createdby|
|appmodule_createdonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_appmodule_createdonbehalfby|
|appmodule_modifiedby|[systemuser EntityType](systemuser.md)|systemuser_appmodule_modifiedby|
|appmodule_modifiedonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_appmodule_modifiedonbehalfby|
|organization_appmodule_appmodule|[organization EntityType](organization.md)|organization_appmodule|
|publisher_appmodule_appmodule|[publisher EntityType](publisher.md)|publisher_appmodule|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|appmodule_appconfig|[appconfig EntityType](appconfig.md)|appmodule_appconfig|  
|appmodule_appmodulecomponent|[appmodulecomponent EntityType](appmodulecomponent.md)|appmoduleid|  
|appmoduleroles_association|[role EntityType](role.md)|appmoduleroles_association|  

## Operations
The following operations can be used with the appmodule entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[AddAppComponents Action](../actions/addappcomponents.md)|Not Bound|[!INCLUDE[../actions/descriptions/addappcomponents.md](../actions/descriptions/addappcomponents.md)]|  
|[RemoveAppComponents Action](../actions/removeappcomponents.md)|Not Bound|[!INCLUDE[../actions/descriptions/removeappcomponents.md](../actions/descriptions/removeappcomponents.md)]|  
|[RetrieveAppComponents Function](../functions/retrieveappcomponents.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveappcomponents.md](../functions/descriptions/retrieveappcomponents.md)]|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|  
|[ValidateApp Function](../functions/validateapp.md)|Not Bound|[!INCLUDE[../functions/descriptions/validateapp.md](../functions/descriptions/validateapp.md)]|    

[!INCLUDE[./remarks/appmodule.md](./remarks/appmodule.md)]

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