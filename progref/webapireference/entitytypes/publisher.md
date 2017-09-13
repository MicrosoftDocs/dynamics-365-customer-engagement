---
title: "Microsoft Dynamics 365 Customer Engagement publisher EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: cd4621de-1642-41cf-96bb-1f16dcf0baa0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API publisher entitytype."
---
# publisher EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/publisher.md](./descriptions/publisher.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]publishers </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Publisher</td></tr>
<tr><td><b>Primary Key:</b></td><td>publisherid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>friendlyname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The publisher EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|address1_addressid|Edm.Guid|**Display Name**: Address 1: ID<br />**Description**: Unique identifier for address 1.<br />|
|address1_addresstypecode|Edm.Int32|**Display Name**: Address 1: Address Type<br />**Description**: Type of address for address 1, such as billing, shipping, or primary address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address1_city|Edm.String|**Display Name**: City<br />**Description**: City name for address 1.<br />|
|address1_country|Edm.String|**Display Name**: Country/Region<br />**Description**: Country/region name for address 1.<br />|
|address1_county|Edm.String|**Display Name**: Address 1: County<br />**Description**: County name for address 1.<br />|
|address1_fax|Edm.String|**Display Name**: Address 1: Fax<br />**Description**: Fax number for address 1.<br />|
|address1_latitude|Edm.Double|**Display Name**: Address 1: Latitude<br />**Description**: Latitude for address 1.<br />|
|address1_line1|Edm.String|**Display Name**: Street 1<br />**Description**: First line for entering address 1 information.<br />|
|address1_line2|Edm.String|**Display Name**: Street 2<br />**Description**: Second line for entering address 1 information.<br />|
|address1_line3|Edm.String|**Display Name**: Street 3<br />**Description**: Third line for entering address 1 information.<br />|
|address1_longitude|Edm.Double|**Display Name**: Address 1: Longitude<br />**Description**: Longitude for address 1.<br />|
|address1_name|Edm.String|**Display Name**: Address 1: Name<br />**Description**: Name to enter for address 1.<br />|
|address1_postalcode|Edm.String|**Display Name**: ZIP/Postal Code<br />**Description**: ZIP Code or postal code for address 1.<br />|
|address1_postofficebox|Edm.String|**Display Name**: Address 1: Post Office Box<br />**Description**: Post office box number for address 1.<br />|
|address1_shippingmethodcode|Edm.Int32|**Display Name**: Address 1: Shipping Method<br />**Description**: Method of shipment for address 1.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address1_stateorprovince|Edm.String|**Display Name**: State/Province<br />**Description**: State or province for address 1.<br />|
|address1_telephone1|Edm.String|**Display Name**: Phone<br />**Description**: First telephone number associated with address 1.<br />|
|address1_telephone2|Edm.String|**Display Name**: Address 1: Telephone 2<br />**Description**: Second telephone number associated with address 1.<br />|
|address1_telephone3|Edm.String|**Display Name**: Address 1: Telephone 3<br />**Description**: Third telephone number associated with address 1.<br />|
|address1_upszone|Edm.String|**Display Name**: Address 1: UPS Zone<br />**Description**: United Parcel Service (UPS) zone for address 1.<br />|
|address1_utcoffset|Edm.Int32|**Display Name**: Address 1: UTC Offset<br />**Description**: UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.<br />|
|address2_addressid|Edm.Guid|**Display Name**: Address 2: ID<br />**Description**: Unique identifier for address 2.<br />|
|address2_addresstypecode|Edm.Int32|**Display Name**: Address 2: Address Type<br />**Description**: Type of address for address 2. such as billing, shipping, or primary address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_city|Edm.String|**Display Name**: Address 2: City<br />**Description**: City name for address 2.<br />|
|address2_country|Edm.String|**Display Name**: Address 2: Country/Region<br />**Description**: Country/region name for address 2.<br />|
|address2_county|Edm.String|**Display Name**: Address 2: County<br />**Description**: County name for address 2.<br />|
|address2_fax|Edm.String|**Display Name**: Address 2: Fax<br />**Description**: Fax number for address 2.<br />|
|address2_latitude|Edm.Double|**Display Name**: Address 2: Latitude<br />**Description**: Latitude for address 2.<br />|
|address2_line1|Edm.String|**Display Name**: Address 2: Street 1<br />**Description**: First line for entering address 2 information.<br />|
|address2_line2|Edm.String|**Display Name**: Address 2: Street 2<br />**Description**: Second line for entering address 2 information.<br />|
|address2_line3|Edm.String|**Display Name**: Address 2: Street 3<br />**Description**: Third line for entering address 2 information.<br />|
|address2_longitude|Edm.Double|**Display Name**: Address 2: Longitude<br />**Description**: Longitude for address 2.<br />|
|address2_name|Edm.String|**Display Name**: Address 2: Name<br />**Description**: Name to enter for address 2.<br />|
|address2_postalcode|Edm.String|**Display Name**: Address 2: ZIP/Postal Code<br />**Description**: ZIP Code or postal code for address 2.<br />|
|address2_postofficebox|Edm.String|**Display Name**: Address 2: Post Office Box<br />**Description**: Post office box number for address 2.<br />|
|address2_shippingmethodcode|Edm.Int32|**Display Name**: Address 2: Shipping Method<br />**Description**: Method of shipment for address 2.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|address2_stateorprovince|Edm.String|**Display Name**: Address 2: State/Province<br />**Description**: State or province for address 2.<br />|
|address2_telephone1|Edm.String|**Display Name**: Address 2: Telephone 1<br />**Description**: First telephone number associated with address 2.<br />|
|address2_telephone2|Edm.String|**Display Name**: Address 2: Telephone 2<br />**Description**: Second telephone number associated with address 2.<br />|
|address2_telephone3|Edm.String|**Display Name**: Address 2: Telephone 3<br />**Description**: Third telephone number associated with address 2.<br />|
|address2_upszone|Edm.String|**Display Name**: Address 2: UPS Zone<br />**Description**: United Parcel Service (UPS) zone for address 2.<br />|
|address2_utcoffset|Edm.Int32|**Display Name**: Address 2: UTC Offset<br />**Description**: UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the publisher was created.<br />Read-only<br />|
|customizationoptionvalueprefix|Edm.Int32|**Display Name**: Option Value Prefix<br />**Description**: Default option value prefix used for newly created options for solutions associated with this publisher.<br />|
|customizationprefix|Edm.String|**Display Name**: Prefix<br />**Description**: Prefix used for new entities, attributes, and entity relationships for solutions associated with this publisher.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the solution.<br />|
|emailaddress|Edm.String|**Display Name**: Email<br />**Description**: Email address for the publisher.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: Shows the default image for the record.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|friendlyname|Edm.String|**Display Name**: Display Name<br />**Description**: User display name for this publisher.<br />|
|isreadonly|Edm.Boolean|**Display Name**: Is Read-Only Publisher<br />**Description**: Indicates whether the publisher was created as part of a managed solution installation.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the publisher was last modified.<br />Read-only<br />|
|pinpointpublisherdefaultlocale|Edm.String|**Description**: Default locale of the publisher in Microsoft Pinpoint.<br />Read-only<br />|
|pinpointpublisherid|Edm.Int64|**Description**: Identifier of the publisher in Microsoft Pinpoint.<br />Read-only<br />|
|publisherid|Edm.Guid|**Display Name**: Publisher Identifier<br />**Description**: Unique identifier of the publisher.<br />|
|supportingwebsiteurl|Edm.String|**Display Name**: Website<br />**Description**: URL for the supporting website of this publisher.<br />|
|uniquename|Edm.String|**Display Name**: Name<br />**Description**: The unique name of this publisher.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the publisher.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the publisher.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the publisher.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the publisher.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the publisher.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_publisher_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_publisherbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_publisher_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_publisherbase_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_publisher|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|publisher_appmodule|[appmodule EntityType](appmodule.md)|publisher_appmodule_appmodule|  
|Publisher_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_publisher|  
|Publisher_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_publisher|  
|Publisher_PublisherAddress|[publisheraddress EntityType](publisheraddress.md)|parentid|  
|publisher_solution|[solution EntityType](solution.md)|publisherid|  
|Publisher_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_publisher_syncerror|    

[!INCLUDE[./remarks/publisher.md](./remarks/publisher.md)]

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