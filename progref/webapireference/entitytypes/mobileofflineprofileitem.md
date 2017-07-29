---
title: "Microsoft Dynamics 365 Customer Engagement mobileofflineprofileitem EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f980579b-e236-470f-bc14-1a3373d51dd7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API mobileofflineprofileitem entitytype."
---
# mobileofflineprofileitem EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/mobileofflineprofileitem.md](./descriptions/mobileofflineprofileitem.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]mobileofflineprofileitems </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Mobile Offline Profile Item</td></tr>
<tr><td><b>Primary Key:</b></td><td>mobileofflineprofileitemid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The mobileofflineprofileitem entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|entityobjecttypecode|Edm.Int32|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the Mobile offline Profile Item is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|isvalidated|Edm.Boolean|**Display Name**: Is Valid For Mobile Offline<br />**Description**: Information about whether profile item is validated or not<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isvisibleingrid|Edm.Boolean|**Display Name**: Is Visible In Grid<br />**Description**: Information about whether the mobile offline profile item is visible in the Profile Item subgrid.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|mobileofflineprofileitemid|Edm.Guid|**Display Name**: Mobile Offline Profile Item<br />**Description**: Unique identifier of the mobile offline profile item.<br />|
|mobileofflineprofileitemidunique|Edm.Guid|**Display Name**: Unique Id<br />**Description**: For Internal Use Only<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the mobile offline profile item.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|processid|Edm.Guid|**Display Name**: Process<br />**Description**: Shows the ID of the process.<br />|
|profileitementityfilter|Edm.String|**Display Name**: Profile item entity filter<br />**Description**: Profile item entity filter criteria<br />|
|publishedon|Edm.DateTimeOffset|**Display Name**: Published On<br />**Description**: Displays the last published date time.<br />Read-only<br />|
|recorddistributioncriteria|Edm.Int32|**Display Name**: Data Download Filter<br />**Description**: Specify data download filter for selected entity<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Download related data only</td></tr><tr><td>1</td><td>All records</td></tr><tr><td>2</td><td>Other data filter</td></tr><tr><td>3</td><td>Custom data filter</td></tr><tbody></table>|
|recordsownedbyme|Edm.Boolean|**Display Name**: Download my records<br />**Description**: Download my records<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|recordsownedbymybusinessunit|Edm.Boolean|**Display Name**: Download my business unit's records<br />**Description**: Download my business unit's records<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|recordsownedbymyteam|Edm.Boolean|**Display Name**: Download my team's records<br />**Description**: Download my team's records<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|relationshipdata|Edm.String|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />|
|selectedentitymetadata|Edm.String|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />Read-only<br />|
|selectedentitytypecode|Edm.String|**Display Name**: Entity<br />**Description**: Mobile offline enabled entity<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|stageid|Edm.Guid|**Display Name**: Process Stage<br />**Description**: Shows the ID of the stage.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: For internal use only.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the Mobile Offline Profile Item.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the Mobile Offline Profile Item.|
|_regardingobjectid_value|regardingobjectid<br />|Items contained with a particular Profile.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_MobileOfflineProfileItem_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_mobileofflineprofileitem_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_mobileofflineprofileitem_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_mobileofflineprofileitem_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|MobileOfflineProfileItem_organization|
|profileitemrule|[savedquery EntityType](savedquery.md)|lk_mobileofflineprofileitem_savedquery|
|regardingobjectid|[mobileofflineprofile EntityType](mobileofflineprofile.md)|MobileOfflineProfile_MobileOfflineProfileItem|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|MobileOfflineProfileItem_MobileOfflineProfileItemAssociation|[mobileofflineprofileitemassociation EntityType](mobileofflineprofileitemassociation.md)|regardingobjectid|  

## Operations
The following operations can be used with the mobileofflineprofileitem entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Collection|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|    

[!INCLUDE[./remarks/mobileofflineprofileitem.md](./remarks/mobileofflineprofileitem.md)]

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