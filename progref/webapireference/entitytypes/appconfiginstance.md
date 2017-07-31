---
title: "Microsoft Dynamics 365 Customer Engagement appconfiginstance EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2b72cb4f-805c-4823-aeaa-cab034393ff2
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API appconfiginstance entitytype."
---
# appconfiginstance EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/appconfiginstance.md](./descriptions/appconfiginstance.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]appconfiginstances </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>App Configuration Instance</td></tr>
<tr><td><b>Primary Key:</b></td><td>appconfiginstanceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The appconfiginstance EntityType:
* Has no collection-valued navigation properties.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|appconfigidunique|Edm.Guid|**Display Name**: App Config ID Unique<br />**Description**: Enter the App Configuration unique identifier of AppConfig entity for which this customization belongs.<br />|
|appconfiginstanceid|Edm.Guid|**Display Name**: AppConfig Instance ID<br />**Description**: System-Populated App Configuration instance identifier.<br />Read-only<br />|
|appconfiginstanceidunique|Edm.Guid|**Display Name**: AppConfigInstanceIdUnique<br />**Description**: System-populated App Configuration Instance unique identifier.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: System-Populated Published or UnPublished state of App Configuration Instance.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|componenttype|Edm.String|**Display Name**: Enter the componenet type of the artifact (Form/View etc.) for which customization is to be created.<br />**Description**: ComponentType<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: For internal use only.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Shows the version in which the App Configuration Instance is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: Shows whether the App Configuration Instance is managed or not.<br />**Description**: Is Managed<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|objectid|Edm.Guid|**Display Name**: Enter the object identifier for the artifact (Form/View etc.) for which customization is to be created.<br />**Description**: ObjectId<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time when the record was migrated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Overwrite Time<br />**Description**: Shows the last overwrite time for the App Configuration Instance.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: SolutionId<br />**Description**: Set the solution idenfitier for associated solution.<br />Read-only<br />|
|value|Edm.String|**Display Name**: Value<br />**Description**: Enter a value for the customization property that is valid as per the validator XML specified in the app configuration master record.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_appconfigid_value|appconfiginstance_appconfig<br />|System-calculated App Configuration unique identifier.|
|_appconfigmasterid_value|appconfiginstance_appconfigmaster<br />|System-calculated App Configuration Master identifier.|
|_createdby_value|appconfiginstance_createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|appconfiginstance_createdonbehalfby<br />|Shows who created the record on behalfÂ of another user.|
|_modifiedby_value|appconfiginstance_modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|appconfiginstance_modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organization_appconfiginstance_appconfiginstance<br />|System-calculated field for Organization identifier.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|appconfiginstance_appconfig|[appconfig EntityType](appconfig.md)|appconfig_appconfiginstance|
|appconfiginstance_appconfigmaster|[appconfigmaster EntityType](appconfigmaster.md)|appconfigmaster_appconfiginstance|
|appconfiginstance_createdby|[systemuser EntityType](systemuser.md)|systemuser_appconfiginstance_createdby|
|appconfiginstance_createdonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_appconfiginstance_createdonbehalfby|
|appconfiginstance_modifiedby|[systemuser EntityType](systemuser.md)|systemuser_appconfiginstance_modifiedby|
|appconfiginstance_modifiedonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_appconfiginstance_modifiedonbehalfby|
|organization_appconfiginstance_appconfiginstance|[organization EntityType](organization.md)|organization_appconfiginstance|

## Operations
The following operations can be used with the appconfiginstance entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|    

[!INCLUDE[./remarks/appconfiginstance.md](./remarks/appconfiginstance.md)]

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