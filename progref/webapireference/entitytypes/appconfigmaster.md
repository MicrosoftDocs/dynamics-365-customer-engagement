---
title: "Microsoft Dynamics 365 Customer Engagement appconfigmaster EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 088db9d7-e994-4451-bade-a810f739c2c0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API appconfigmaster entitytype."
---
# appconfigmaster EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/appconfigmaster.md](./descriptions/appconfigmaster.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]appconfigmasters </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>App Config Master</td></tr>
<tr><td><b>Primary Key:</b></td><td>appconfigmasterid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The appconfigmaster EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|appconfigmasterid|Edm.Guid|**Display Name**: AppConfigMasterId<br />**Description**: System-Populated App Configuration instance identifier.<br />Read-only<br />|
|configtype|Edm.String|**Display Name**: ConfigType<br />**Description**: Enter the App Configuration and Setting property data type.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|defaultvalue|Edm.String|**Display Name**: DefaultValue<br />**Description**: Enter the default value of the App Configuration and Setting property.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: For internal use only.<br />Read-only<br />|
|isnavigationsetting|Edm.Int32|**Display Name**: Is Nagivation Setting<br />**Description**: Enter whether this App Configuration and Setting is Navigation Setting.<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the App Configuration and Setting property with which this customization will be identified.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time when the record was migrated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|parentappconfigmasterid|Edm.String|**Display Name**: Enter the parent of App Configuration customization property.<br />**Description**: ParentAppConfigMasterId<br />Read-only<br />|
|validator|Edm.String|**Display Name**: Enter the validator configuration xml which will validate against its value when creating AppConfigInstance.<br />**Description**: Validator<br />Read-only<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|appconfigmaster_createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|appconfigmaster_createdonbehalfby<br />|Shows who created the record on behalfÂ of another user.|
|_modifiedby_value|appconfigmaster_modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|appconfigmaster_modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organization_appconfigmaster_appconfigmaster<br />|System-calculated field for Organization identifier.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|appconfigmaster_createdby|[systemuser EntityType](systemuser.md)|systemuser_appconfigmaster_createdby|
|appconfigmaster_createdonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_appconfigmaster_createdonbehalfby|
|appconfigmaster_modifiedby|[systemuser EntityType](systemuser.md)|systemuser_appconfigmaster_modifiedby|
|appconfigmaster_modifiedonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_appconfigmaster_modifiedonbehalfby|
|organization_appconfigmaster_appconfigmaster|[organization EntityType](organization.md)|organization_appconfigmaster|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|appconfigmaster_appconfiginstance|[appconfiginstance EntityType](appconfiginstance.md)|appconfiginstance_appconfigmaster|    

[!INCLUDE[./remarks/appconfigmaster.md](./remarks/appconfigmaster.md)]

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