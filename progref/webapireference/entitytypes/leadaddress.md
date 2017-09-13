---
title: "Microsoft Dynamics 365 Customer Engagement leadaddress EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 811ff3a9-d448-48b0-8dc1-2da31ac2a3c9
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API leadaddress entitytype."
---
# leadaddress EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/leadaddress.md](./descriptions/leadaddress.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]leadaddresses </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Lead Address</td></tr>
<tr><td><b>Primary Key:</b></td><td>leadaddressid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The leadaddress entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|addressnumber|Edm.Int32|**Display Name**: Address Number<br />**Description**: Information about the address for the lead.<br />|
|addresstypecode|Edm.Int32|**Display Name**: Address Type<br />**Description**: Type of address for the lead address.<br />|
|city|Edm.String|**Display Name**: City<br />**Description**: City name in the address for the lead.<br />|
|composite|Edm.String|**Display Name**: Address<br />**Description**: Shows the complete address.<br />Read-only<br />|
|country|Edm.String|**Display Name**: Country/Region<br />**Description**: Country/region name in the address for the lead.<br />|
|county|Edm.String|**Display Name**: County<br />**Description**: County name in the address for the lead.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the lead address was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the leadaddress with respect to the base currency.<br />Read-only<br />|
|fax|Edm.String|**Display Name**: Fax<br />**Description**: Fax number for the address for the lead.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|latitude|Edm.Double|**Display Name**: Latitude<br />**Description**: Latitude for the address for the lead.<br />|
|leadaddressid|Edm.Guid|**Display Name**: Address<br />**Description**: Unique identifier of the lead address.<br />|
|line1|Edm.String|**Display Name**: Street 1<br />**Description**: First line for entering address information.<br />|
|line2|Edm.String|**Display Name**: Street 2<br />**Description**: Second line for entering address information.<br />|
|line3|Edm.String|**Display Name**: Street 3<br />**Description**: Third line for entering address information.<br />|
|longitude|Edm.Double|**Display Name**: Longitude<br />**Description**: Longitude for the address for the lead.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the lead address was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Address Name<br />**Description**: Name used to identify the lead address.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|postalcode|Edm.String|**Display Name**: ZIP/Postal Code<br />**Description**: ZIP Code or postal code in the address for the lead.<br />|
|postofficebox|Edm.String|**Display Name**: Post Office Box<br />**Description**: Post office box number in the address for the lead.<br />|
|shippingmethodcode|Edm.Int32|**Display Name**: Shipping Method<br />**Description**: Method of shipment for the lead.<br />|
|stateorprovince|Edm.String|**Display Name**: State/Province<br />**Description**: State or province in the address for the lead.<br />|
|telephone1|Edm.String|**Display Name**: Main Phone<br />**Description**: First telephone number for the lead address.<br />|
|telephone2|Edm.String|**Display Name**: Phone 2<br />**Description**: Second telephone number for the lead address.<br />|
|telephone3|Edm.String|**Display Name**: Telephone 3<br />**Description**: Third telephone number for the lead address.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|upszone|Edm.String|**Display Name**: UPS Zone<br />**Description**: United Parcel Service (UPS) zone for the address of the lead.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|utcoffset|Edm.Int32|**Display Name**: UTC Offset<br />**Description**: UTC offset for the lead address. This is the difference between local time and standard Coordinated Universal Time.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the lead address.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the leadaddress.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the lead address.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the leadaddress.|
|_parentid_value|parentid<br />|Unique identifier of the parent object with which the lead address is associated.|
|_transactioncurrencyid_value||Unique identifier of the currency associated with the leadaddress.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_leadaddressbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_leadaddressbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_leadaddressbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_leadaddressbase_modifiedonbehalfby|
|parentid|[lead EntityType](lead.md)|lead_addresses|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|leadaddress_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_leadaddress|  
|leadaddress_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_leadaddress|  
|LeadAddress_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_leadaddress|  

## Solutions
The following solutions include the leadaddress entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Lead Management Workload Solution](../solutions/leadmanagement.md)|[!INCLUDE[../solutions/descriptions/leadmanagement.md](../solutions/descriptions/leadmanagement.md)]|    

[!INCLUDE[./remarks/leadaddress.md](./remarks/leadaddress.md)]

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