---
title: "Microsoft Dynamics 365 Customer Engagement publisheraddress EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: cab09bfd-d731-4450-9a43-feb53775e824
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API publisheraddress entitytype."
---
# publisheraddress EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/publisheraddress.md](./descriptions/publisheraddress.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]publisheraddresses </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Publisher Address</td></tr>
<tr><td><b>Primary Key:</b></td><td>publisheraddressid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The publisheraddress EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|addressnumber|Edm.Int32|**Display Name**: Address Number<br />**Description**: Specifies which publisher address is applicable.<br />|
|addresstypecode|Edm.Int32|**Display Name**: Address Type<br />**Description**: Type of address for the publisher, such as billing, shipping, or primary address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Bill To</td></tr><tr><td>2</td><td>Ship To</td></tr><tr><td>3</td><td>Primary</td></tr><tr><td>4</td><td>Other</td></tr><tbody></table>|
|city|Edm.String|**Display Name**: City<br />**Description**: City name in the publisher address.<br />|
|country|Edm.String|**Display Name**: Country<br />**Description**: Country/region name in the publisher address.<br />|
|county|Edm.String|**Display Name**: County<br />**Description**: County name in the publisher address.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the publisher address was created.<br />Read-only<br />|
|fax|Edm.String|**Display Name**: Fax<br />**Description**: Fax number for the publisher address.<br />|
|freighttermscode|Edm.Int32|**Display Name**: Freight Terms<br />**Description**: Freight terms for the publisher address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>FOB</td></tr><tr><td>2</td><td>No Charge</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|latitude|Edm.Double|**Display Name**: Latitude<br />**Description**: Latitude for the publisher address.<br />|
|line1|Edm.String|**Display Name**: Street 1<br />**Description**: First line for entering address information.<br />|
|line2|Edm.String|**Display Name**: Street 2<br />**Description**: Second line for entering address information.<br />|
|line3|Edm.String|**Display Name**: Street 3<br />**Description**: Third line for entering address information.<br />|
|longitude|Edm.Double|**Display Name**: Longitude<br />**Description**: Longitude for the publisher address.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the publisher address was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Address Name<br />**Description**: Name used to identify the publisher address.<br />|
|postalcode|Edm.String|**Display Name**: ZIP/Postal Code<br />**Description**: ZIP Code or postal code in the publisher address.<br />|
|postofficebox|Edm.String|**Display Name**: Post Office Box<br />**Description**: Post office box number in the publisher address.<br />|
|primarycontactname|Edm.String|**Display Name**: Address Contact<br />**Description**: Name of the primary contact at the publisher address.<br />|
|publisheraddressid|Edm.Guid|**Display Name**: Address<br />**Description**: Unique identifier of the publisher address.<br />|
|shippingmethodcode|Edm.Int32|**Display Name**: Shipping Method<br />**Description**: Method of shipment for the publisher address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default</td></tr><tbody></table>|
|stateorprovince|Edm.String|**Display Name**: State/Province<br />**Description**: State or province in the publisher address.<br />|
|telephone1|Edm.String|**Display Name**: Main Phone<br />**Description**: First telephone number for the publisher address.<br />|
|telephone2|Edm.String|**Display Name**: Phone 2<br />**Description**: Second telephone number for the publisher address.<br />|
|telephone3|Edm.String|**Display Name**: Telephone 3<br />**Description**: Third telephone number for the publisher address.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|upszone|Edm.String|**Display Name**: UPS Zone<br />**Description**: United Parcel Service (UPS) zone for the address of the publisher.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|utcoffset|Edm.Int32|**Display Name**: UTC Offset<br />**Description**: UTC offset for the address. This is the difference between local time and standard Coordinated Universal Time.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the publisher address.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the publisher address.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the publisher address.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the publisher address.|
|_parentid_value|parentid<br />|Unique identifier of the parent object with which the publisher address is associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_publisheraddressbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_publisheraddressbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_publisheraddressbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_publisheraddressbase_modifiedonbehalfby|
|parentid|[publisher EntityType](publisher.md)|Publisher_PublisherAddress|  

[!INCLUDE[./remarks/publisheraddress.md](./remarks/publisheraddress.md)]

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