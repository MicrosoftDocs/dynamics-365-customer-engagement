---
title: "Microsoft Dynamics 365 Customer Engagement navigationsetting EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 2f9ca6b9-2abc-41b9-9f04-67b52ea4b4de
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API navigationsetting entitytype."
---
# navigationsetting EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/navigationsetting.md](./descriptions/navigationsetting.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]navigationsettings </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Navigation Setting</td></tr>
<tr><td><b>Primary Key:</b></td><td>navigationsettingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The navigationsetting EntityType:
* Has no collection-valued navigation properties.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|advancedsettingorder|Edm.Int32|**Display Name**: AdvancedOrder<br />**Description**: Enter the position of this NavigationSetting as it should appear within its group in the Advanced Setup menu.<br />|
|appconfigidunique|Edm.Guid|**Display Name**: AppConfigIdUnique<br />**Description**: For system use only.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type a description that describes that Navigation Setting in detail.<br />|
|groupname|Edm.String|**Display Name**: Group Name<br />**Description**: Type the name of the group represented by this Navigation Setting record.<br />|
|iconresourceid|Edm.Guid|**Display Name**: IconResourceId<br />**Description**: The web resource identifier of the icon to be used for a navigation setting area or sub area.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the similarity rule is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a title or name that describes the Navigation Setting so it can be identified in Dynamics CRM views.<br />|
|navigationsettingid|Edm.Guid|**Display Name**: NavigationSettingId<br />**Description**: Identifies a single setting page or group of pages configured for use in a single app.<br />|
|navigationsettingidunique|Edm.Guid|**Display Name**: NavigationSettingIdUnique<br />**Description**: For system use only.<br />|
|objecttypecode|Edm.Int32|**Display Name**: EntityObjectTypeCode<br />**Description**: Enter the Object Type Code of the entity associated whose page this Navigation Setting record represents.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|pageurl|Edm.String|**Display Name**: Page Url<br />**Description**: Type the URL which locates the page associated with this Navigation Setting record.<br />|
|parentnavigationsettingid|Edm.Guid|**Display Name**: Parent Navigation Setting Id<br />**Description**: The Navigation Setting record that represents the group that this record belongs to.<br />|
|privileges|Edm.Int32|**Display Name**: Privileges<br />**Description**: Enter the Privilege Mask for the entity associated with this navigation setting page that will be the minimum requirement for the page to be made available to a user.<br />|
|progressstate|Edm.Boolean|**Display Name**: Progress State<br />**Description**: Select the setup completion level for this Navigation Setting page.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Visited</td></tr><tr><td>0</td><td>Not Visited</td></tr><tbody></table>|
|quicksettingorder|Edm.Int32|**Display Name**: QuickOrder<br />**Description**: Enter the position of this NavigationSetting as it should appear in the Quick Setup menu.<br />|
|resourceid|Edm.Guid|**Display Name**: Resource Id<br />**Description**: The Web Resource that will be associated with this Navigation Setting record.<br />|
|settingtype|Edm.Int32|**Display Name**: Group Type<br />**Description**: Select the type of group this Navigation Setting record represents. This determines which of the three in-app customization menus will contain this group.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Advanced Setup</td></tr><tr><td>1</td><td>Basic Setup</td></tr><tr><td>2</td><td>Advanced Setup Summary</td></tr><tr><td>3</td><td>Basic Setup Summary</td></tr><tbody></table>|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_appconfigid_value|navigationsetting_appconfig<br />|Enter the App Config record that this Navigation Setting is associated with.|
|_createdby_value|navigationsetting_createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|navigationsetting_createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|navigationsetting_modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|navigationsetting_modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organization_navigationsetting_navigationsetting<br />|System-populated field that identifies the organization that owns this Navigation Setting record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|navigationsetting_appconfig|[appconfig EntityType](appconfig.md)|appconfig_navigationsetting|
|navigationsetting_createdby|[systemuser EntityType](systemuser.md)|systemuser_navigationsetting_createdby|
|navigationsetting_createdonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_navigationsetting_createdonbehalfby|
|navigationsetting_modifiedby|[systemuser EntityType](systemuser.md)|systemuser_navigationsetting_modifiedby|
|navigationsetting_modifiedonbehalfby|[systemuser EntityType](systemuser.md)|systemuser_navigationsetting_modifiedonbehalfby|
|organization_navigationsetting_navigationsetting|[organization EntityType](organization.md)|organization_navigationsetting|

## Operations
The following operations can be used with the navigationsetting entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|    

[!INCLUDE[./remarks/navigationsetting.md](./remarks/navigationsetting.md)]

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