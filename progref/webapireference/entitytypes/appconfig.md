---
title: "Microsoft Dynamics 365 Customer Engagement appconfig EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4e3e3100-c04a-4725-8262-93db8b34d1cb
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API appconfig entitytype."
---
# appconfig EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/appconfig.md](./descriptions/appconfig.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]appconfigs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>App Configuration</td></tr>
<tr><td><b>Primary Key:</b></td><td>appconfigid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The appconfig entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|appconfigid|Edm.Guid|Read-only<br />|
|appconfigidunique|Edm.Guid|**Display Name**: App Config ID Unique<br />**Description**: System-populated app configuration unique ID.<br />|
|appconfigimportxml|Edm.String|**Description**: The App Config diff computed for managed solutions containing the AppConfig entity. For internal use only.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: For internal use only.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the similarity rule is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: Indicates whether this is part of a managed solution.<br />**Description**: Is Managed<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time when the record was migrated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Overwrite Time<br />**Description**: Internal use only<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the app configuration is Active or Inactive. Inactive records are read-only and can't be edited unless they are reactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_appmoduleid_value|appmodule_appconfig<br />|Choose the app module to associate with the app configuration.|
|_createdby_value|appconfig_createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|appconfig_createdonbehalfby<br />|Shows who created the record on behalfÂ of another user.|
|_modifiedby_value|appconfig_modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|appconfig_modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organization_appconfig<br />|Unique identifier for the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|appconfig_createdby|[systemuser EntityType](systemuser.md)|systemuser_appconfig_createdby|
|appconfig_createdonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_appconfig_createdonbehalfby|
|appconfig_modifiedby|[systemuser EntityType](systemuser.md)|systemuser_appconfig_modifiedby|
|appconfig_modifiedonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_appconfig_modifiedonbehalfby|
|appmodule_appconfig|[appmodule EntityType](appmodule.md)|appmodule_appconfig|
|organization_appconfig|[organization EntityType](organization.md)|organization_appconfig|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|appconfig_appconfiginstance|[appconfiginstance EntityType](appconfiginstance.md)|appconfiginstance_appconfig|  
|appconfig_navigationsetting|[navigationsetting EntityType](navigationsetting.md)|navigationsetting_appconfig|  

## Operations
The following operations can be used with the appconfig entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|    

[!INCLUDE[./remarks/appconfig.md](./remarks/appconfig.md)]

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