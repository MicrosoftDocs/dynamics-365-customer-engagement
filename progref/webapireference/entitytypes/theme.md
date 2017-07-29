---
title: "Microsoft Dynamics 365 Customer Engagement theme EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8f1eda24-1ca0-4c9e-9938-0a33b2631bfc
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API theme entitytype."
---
# theme EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/theme.md](./descriptions/theme.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]themes </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Theme</td></tr>
<tr><td><b>Primary Key:</b></td><td>themeid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The theme entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|accentcolor|Edm.String|**Display Name**: Accent Color<br />**Description**: Choose the Unified Interface secondary theme color to be used on the process control<br />|
|backgroundcolor|Edm.String|**Display Name**: Background Color<br />**Description**: For internal use only.<br />|
|controlborder|Edm.String|**Display Name**: Control Hover Border Color<br />**Description**: Choose the color that controls will use for borders<br />|
|controlshade|Edm.String|**Display Name**: Control Hover Fill Color<br />**Description**: Choose the background color for controls to use to indicate when you hover over items<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|defaultcustomentitycolor|Edm.String|**Display Name**: Default Custom Entity Color<br />**Description**: Choose the default custom entity color if no color is assigned<br />|
|defaultentitycolor|Edm.String|**Display Name**: Default Entity Color<br />**Description**: Choose the default color for system entities if no color is assigned<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the Theme with respect to the base currency.<br />Read-only<br />|
|globallinkcolor|Edm.String|**Display Name**: Link and Button Text Color<br />**Description**: Choose the color for all links, such as e-mail address and lookup links, and for all buttons that are in focus<br />|
|headercolor|Edm.String|**Display Name**: Title Text Color<br />**Description**: Choose the color for title text, such as form tab labels<br />|
|hoverlinkeffect|Edm.String|**Display Name**: Hover Link Color<br />**Description**: Choose the color that commands or lists will use to indicate hovered over items<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|isdefaulttheme|Edm.Boolean|**Display Name**: Default Theme<br />**Description**: Default status of theme.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|logotooltip|Edm.String|**Display Name**: Logo Tooltip<br />**Description**: Enter text that will be used as the tooltip and alt text for the logo.<br />|
|maincolor|Edm.String|**Display Name**: Main Color<br />**Description**: Choose the Unified Interface primary theme color to be used on main command bar, buttons and tabs<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Theme Name<br />**Description**: The name of the Theme Entity.<br />|
|navbarbackgroundcolor|Edm.String|**Display Name**: Navigation Bar Fill Color<br />**Description**: Choose the primary Navigation Bar background color<br />|
|navbarshelfcolor|Edm.String|**Display Name**: Navigation Bar Shelf Fill Color<br />**Description**: Choose the secondary Navigation Bar background color<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|pageheaderbackgroundcolor|Edm.String|**Display Name**: Page Header Fill Color<br />**Description**: Choose the page header background color<br />|
|panelheaderbackgroundcolor|Edm.String|**Display Name**: Panel Header Fill Color<br />**Description**: Choose the panel header background color<br />|
|processcontrolcolor|Edm.String|**Display Name**: Process Control Chevron Fill Color<br />**Description**: Choose the primary background color for process controls<br />|
|selectedlinkeffect|Edm.String|**Display Name**: Selected Link Color<br />**Description**: Choose the color that commands or lists will use to indicate selected items<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Theme<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Custom</td></tr><tr><td>1</td><td>System</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Theme<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Custom</td></tr><tr><td>2</td><td>System</td></tr><tbody></table>|
|themeid|Edm.Guid|**Display Name**: Theme<br />**Description**: Unique identifier for entity instances<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|type|Edm.Boolean|**Display Name**: Type<br />**Description**: Define type of theme.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Custom</td></tr><tr><td>0</td><td>System</td></tr><tbody></table>|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_logoid_value|logoimage<br />|Upload a web resource to use as a logo. Recommended dimensions are a height of 50 pixels and a maximum width of 400 pixels.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the Theme with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_theme_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_theme_createdonbehalfby|
|logoimage|[webresource EntityType](webresource.md)|lk_theme_logoid|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_theme_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_theme_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_theme|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_Theme|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|theme_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_theme|  
|theme_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_theme|  

## Operations
The following operations can be used with the theme entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[PublishTheme Action](../actions/publishtheme.md)|Entity|[!INCLUDE[../actions/descriptions/publishtheme.md](../actions/descriptions/publishtheme.md)]|    

[!INCLUDE[./remarks/theme.md](./remarks/theme.md)]

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