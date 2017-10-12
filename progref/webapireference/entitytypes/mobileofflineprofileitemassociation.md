---
title: "Microsoft Dynamics 365 Customer Engagement mobileofflineprofileitemassociation EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e7a70b20-cf61-423c-b2b0-bf740cfd368a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API mobileofflineprofileitemassociation entitytype."
---
# mobileofflineprofileitemassociation EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/mobileofflineprofileitemassociation.md](./descriptions/mobileofflineprofileitemassociation.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]mobileofflineprofileitemassociations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Mobile Offline Profile Item Association</td></tr>
<tr><td><b>Primary Key:</b></td><td>mobileofflineprofileitemassociationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The mobileofflineprofileitemassociation EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the Mobile offline Profile Item Association is introduced.<br />|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|isvalidated|Edm.Boolean|**Display Name**: Is Valid For Mobile Offline<br />**Description**: Information about whether profile item association is validated or not<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|mobileofflineprofileitemassociationid|Edm.Guid|**Display Name**: Mobile Offline profileitemassociation<br />**Description**: Unique identifier of the mobile offline profile item associaition.<br />|
|mobileofflineprofileitemassociationidunique|Edm.Guid|**Display Name**: Unique Id<br />**Description**: For Internal Use Only<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Enter the name of the mobile offline profile item association.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|processid|Edm.Guid|**Display Name**: Process<br />**Description**: Shows the ID of the process.<br />|
|profileitemassociationentityfilter|Edm.String|**Display Name**: Profile item association entity filter<br />**Description**: Profile item association entity filter criteria.<br />|
|publishedon|Edm.DateTimeOffset|**Display Name**: Published On<br />**Description**: Displays the last published date time.<br />Read-only<br />|
|relationshipdata|Edm.String|**Display Name**: Internal Use Only<br />**Description**: Internal Use Only<br />|
|relationshipdisplayname|Edm.String|**Display Name**: Entity Relationship<br />**Description**: Entity relationship schema name<br />|
|relationshipid|Edm.Guid|**Display Name**: Shows the relationship<br />**Description**: Shows the relationship<br />|
|relationshipname|Edm.String|**Display Name**: Entity Relationship<br />**Description**: Display name of entity relationship<br />Read-only<br />|
|selectedrelationshipsschema|Edm.Int32|**Display Name**: Entity Relationship<br />**Description**: List of relationships of entity selected in parent profile item<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|stageid|Edm.Guid|**Display Name**: Process Stage<br />**Description**: Shows the ID of the stage.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: For internal use only.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the Mobile Offline profileitemassociation.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_mobileofflineprofileitemid_value|regardingobjectid<br />|Id of the parent profile item.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the Mobile Offline Profile Item Association.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_MobileOfflineProfileItemAssociation_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_mobileofflineprofileitemassociation_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_mobileofflineprofileitemassocaition_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_mobileofflineprofileitemassocaition_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|MobileOfflineProfileItemAssociation_organization|
|regardingobjectid|[mobileofflineprofileitem EntityType](mobileofflineprofileitem.md)|MobileOfflineProfileItem_MobileOfflineProfileItemAssociation|

## Operations
The following operations can be used with the mobileofflineprofileitemassociation entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveUnpublished Function](../functions/retrieveunpublished.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveunpublished.md](../functions/descriptions/retrieveunpublished.md)]|  
|[RetrieveUnpublishedMultiple Function](../functions/retrieveunpublishedmultiple.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveunpublishedmultiple.md](../functions/descriptions/retrieveunpublishedmultiple.md)]|    

[!INCLUDE[./remarks/mobileofflineprofileitemassociation.md](./remarks/mobileofflineprofileitemassociation.md)]

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