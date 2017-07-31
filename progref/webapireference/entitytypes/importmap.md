---
title: "Microsoft Dynamics 365 Customer Engagement importmap EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: aeef38c6-2438-4163-9fe9-4222304d498d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API importmap entitytype."
---
# importmap EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/importmap.md](./descriptions/importmap.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]importmaps </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Data Map</td></tr>
<tr><td><b>Primary Key:</b></td><td>importmapid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The importmap entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the data map, such as the intended use or data source.<br />|
|entitiesperfile|Edm.Int32|**Display Name**: Entities Per File<br />**Description**: Choose whether a data file can contain data for one or more record types.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Single Entity Per File</td></tr><tr><td>2</td><td>Multiple Entities Per File</td></tr><tbody></table>|
|importmapid|Edm.Guid|**Display Name**: Data Map<br />**Description**: Unique identifier of the data map.<br />|
|importmapidunique|Edm.Guid|**Description**: Unique identifier of the ImortMap.<br />Read-only<br />|
|importmaptype|Edm.Int32|**Display Name**: Map Type<br />**Description**: Select the type of data map to distinguish out-of-the-box data maps from custom maps.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Standard</td></tr><tr><td>2</td><td>Out of Box</td></tr><tr><td>3</td><td>In Process</td></tr><tbody></table>|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the component is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Information that specifies whether this component is managed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|isvalidforimport|Edm.Boolean|**Display Name**: Is Valid For Import<br />**Description**: Information about whether the data map is valid for use with data import.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|iswizardcreated|Edm.Boolean|**Display Name**: Is Wizard-Created<br />**Description**: Information about whether this data map was created by the Data Migration Manager.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|mapcustomizations|Edm.String|**Display Name**: Map Customizations<br />**Description**: Customizations XML<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Map Name<br />**Description**: Type a descriptive name for the data map.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|source|Edm.String|**Display Name**: Source<br />**Description**: Type the name of the migration source that this data map is used for.<br />|
|sourcetype|Edm.Int32|**Display Name**: Source System Type<br />**Description**: Select the migration source type that this data map is used for.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Map For SalesForce.com Full Data Export</td></tr><tr><td>2</td><td>Map For SalesForce.com Report Export</td></tr><tr><td>3</td><td>Map For SalesForce.com Contact and Account Report Export</td></tr><tr><td>4</td><td>Microsoft Office Outlook 2010 with Business Contact Manager</td></tr><tr><td>5</td><td>Generic Map for Contact and Account</td></tr><tbody></table>|
|sourceuseridentifierforsourcecrmuserlink|Edm.String|**Display Name**: Source User Value<br />**Description**: Source user value for source Microsoft Dynamics 365 user link.<br />|
|sourceuseridentifierforsourcedatasourceuserlink|Edm.String|**Display Name**: Source User Identifier<br />**Description**: Column in the source file that uniquely identifies a user.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the data map is active or inactive. Inactive data maps are read-only and can't be edited.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the data map's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|targetentity|Edm.Int32|**Display Name**: Record Type<br />**Description**: Select the name of the Microsoft Dynamics 365 record type that this data map is defined for.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Default Value</td></tr><tbody></table>|
|targetuseridentifierforsourcecrmuserlink|Edm.String|**Display Name**: Target User Value<br />**Description**: Microsoft Dynamics 365 user.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Business unit that owns the data map.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the data map.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the data map.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_importmapbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_importmap_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_importmapbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_importmap_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_importmaps|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|BusinessUnit_ImportMaps|
|owningteam|[team EntityType](team.md)|team_ImportMaps|
|owninguser|[systemuser EntityType](systemuser.md)|SystemUser_ImportMaps|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ImportEntityMapping_ImportMap|[importentitymapping EntityType](importentitymapping.md)|importmapid|  
|ImportMap_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_importmap|  
|ImportMap_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_importmap|  
|ImportMap_ImportFile|[importfile EntityType](importfile.md)|importmapid|  
|ImportMap_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_importmap_syncerror|  

## Operations
The following operations can be used with the importmap entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[ExportMappingsImportMap Action](../actions/exportmappingsimportmap.md)|Entity|[!INCLUDE[../actions/descriptions/exportmappingsimportmap.md](../actions/descriptions/exportmappingsimportmap.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ImportMappingsImportMap Action](../actions/importmappingsimportmap.md)|Not Bound|[!INCLUDE[../actions/descriptions/importmappingsimportmap.md](../actions/descriptions/importmappingsimportmap.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|    

[!INCLUDE[./remarks/importmap.md](./remarks/importmap.md)]

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