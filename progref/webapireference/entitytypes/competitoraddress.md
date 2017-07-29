---
title: "Microsoft Dynamics 365 Customer Engagement competitoraddress EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d7e22a03-84df-47d6-8574-7e495a2b5a5e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API competitoraddress entitytype."
---
# competitoraddress EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/competitoraddress.md](./descriptions/competitoraddress.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]competitoraddresses </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Competitor Address</td></tr>
<tr><td><b>Primary Key:</b></td><td>competitoraddressid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The competitoraddress entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|addressnumber|Edm.Int32|**Display Name**: Address Number<br />**Description**: Information about which competitor address is applicable.<br />|
|addresstypecode|Edm.Int32|**Display Name**: Address Type<br />**Description**: Type of address for the competitor, such as primary address.<br />|
|city|Edm.String|**Display Name**: City<br />**Description**: City name in the competitor address.<br />|
|competitoraddressid|Edm.Guid|**Display Name**: Competitor Address<br />**Description**: Unique identifier of the competitor address.<br />|
|composite|Edm.String|**Display Name**: Address<br />**Description**: Shows the complete address.<br />Read-only<br />|
|country|Edm.String|**Display Name**: Country/Region<br />**Description**: Country/region name in the competitor address.<br />|
|county|Edm.String|**Display Name**: County<br />**Description**: County name in the competitor address.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the competitor address was created.<br />Read-only<br />|
|fax|Edm.String|**Display Name**: Fax<br />**Description**: Fax number for the competitor address.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|latitude|Edm.Double|**Display Name**: Latitude<br />**Description**: Latitude for the competitor address.<br />|
|line1|Edm.String|**Display Name**: Street 1<br />**Description**: First line for entering address information.<br />|
|line2|Edm.String|**Display Name**: Street 2<br />**Description**: Second line for entering address information.<br />|
|line3|Edm.String|**Display Name**: Street 3<br />**Description**: Third line for entering address information.<br />|
|longitude|Edm.Double|**Display Name**: Longitude<br />**Description**: Longitude for the address for the competitor.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the competitor address was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Address Name<br />**Description**: Name used to identify the competitor address.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|postalcode|Edm.String|**Display Name**: ZIP/Postal Code<br />**Description**: ZIP Code or postal code in the competitor address.<br />|
|postofficebox|Edm.String|**Display Name**: Post Office Box<br />**Description**: Post office box number in the competitor address.<br />|
|shippingmethodcode|Edm.Int32|**Display Name**: Shipping Method<br />**Description**: Method of shipment for the competitor.<br />|
|stateorprovince|Edm.String|**Display Name**: State/Province<br />**Description**: State or province in the competitor address.<br />|
|telephone1|Edm.String|**Display Name**: Main Phone<br />**Description**: First telephone number for the competitor address.<br />|
|telephone2|Edm.String|**Display Name**: Phone 2<br />**Description**: Second telephone number for the competitor address.<br />|
|telephone3|Edm.String|**Display Name**: Phone 3<br />**Description**: Third telephone number for the competitor address.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|upszone|Edm.String|**Display Name**: UPS Zone<br />**Description**: United Parcel Service (UPS) zone for the address of the competitor.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|utcoffset|Edm.Int32|**Display Name**: UTC Offset<br />**Description**: UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the competitor address.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the competitor address.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the competitor address.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the competitor address.|
|_parentid_value|parentid<br />|Unique identifier of the parent object with which the competitor address is associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_competitoraddressbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_competitoraddress_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_competitoraddressbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_competitoraddress_modifiedonbehalfby|
|parentid|[competitor EntityType](competitor.md)|competitor_addresses|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|competitoraddress_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_competitoraddress|  
|competitoraddress_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_competitoraddress|  
|CompetitorAddress_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_competitoraddress_syncerror|  

## Solutions
The following solutions include the competitoraddress entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/competitoraddress.md](./remarks/competitoraddress.md)]

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