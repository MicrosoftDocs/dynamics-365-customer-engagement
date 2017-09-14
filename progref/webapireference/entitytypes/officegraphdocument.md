---
title: "Microsoft Dynamics 365 Customer Engagement officegraphdocument EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a80fdc45-3f1a-4f78-b3cb-44da64b949b0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API officegraphdocument entitytype."
---
# officegraphdocument EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/officegraphdocument.md](./descriptions/officegraphdocument.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]officegraphdocuments </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Office Graph Document</td></tr>
<tr><td><b>Primary Key:</b></td><td>officegraphdocumentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET (RetrieveMultiple Only)</td></tr>
</table>
  
The officegraphdocument EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|authornames|Edm.String|**Display Name**: Author Names<br />**Description**: Shows Author Names of Office Graph Document.<br />Read-only<br />|
|createdby|Edm.String|**Display Name**: Created By<br />**Description**: Shows Created By of Office Graph Document.<br />Read-only<br />|
|createdtime|Edm.DateTimeOffset|**Display Name**: Created Time<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|documentid|Edm.String|**Display Name**: Document Id<br />**Description**: Document Id.<br />|
|documentlastmodifiedby|Edm.String|**Display Name**: Document Last Modified By<br />**Description**: Document Last Modified By<br />Read-only<br />|
|documentlastmodifiedon|Edm.DateTimeOffset|**Display Name**: Document Last Modified On<br />**Description**: Document Last Modified On<br />Read-only<br />|
|documentpreviewmetadata|Edm.String|**Display Name**: document preview metadata<br />**Description**: document preview metadata<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the Office Graph Document with respect to the base currency.<br />Read-only<br />|
|fileextension|Edm.String|**Display Name**: File Extension<br />**Description**: File Extension of Office Graph Document.<br />Read-only<br />|
|filetype|Edm.String|**Display Name**: File Type<br />**Description**: Shows the File Type of Office Graph Document.<br />Read-only<br />|
|modifiedby|Edm.String|**Display Name**: Modified By<br />**Description**: Shows modified by of Office Graph Document.<br />Read-only<br />|
|modifiedtime|Edm.DateTimeOffset|**Display Name**: Modified Time<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|officegraphdocumentid|Edm.Guid|**Display Name**: OfficeGraphDocument<br />**Description**: Unique identifier for entity instances<br />|
|previewimageurl|Edm.String|**Display Name**: Preview Image Url<br />**Description**: Shows the Preview Image Url Office Graph Document.<br />Read-only<br />|
|querytype|Edm.Int32|**Display Name**: Query Type<br />**Description**: Shows Query Type of child folders<br />Read-only<br />|
|rank|Edm.Int32|**Display Name**: Relevancy Rank of the Document<br />**Description**: The relevancy rank of the document retrieved<br />Read-only<br />|
|readurl|Edm.String|**Display Name**: Read Url<br />**Description**: The online read url<br />Read-only<br />|
|secondaryfileextension|Edm.String|**Display Name**: Secondary File Extension<br />**Description**: Secondary File Extension of Office Graph Document.<br />Read-only<br />|
|sitetitle|Edm.String|**Display Name**: Parent Site Title<br />**Description**: The title of the parent document site<br />Read-only<br />|
|siteurl|Edm.String|**Display Name**: Site Url<br />**Description**: The site url for the parent document site<br />Read-only<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|title|Edm.String|**Display Name**: Title<br />**Description**: The title of the entity.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|Read-only<br />|
|viewcount|Edm.Int32|**Display Name**: View Count<br />**Description**: Shows View Count of child folders.<br />Read-only<br />|
|weblocationurl|Edm.String|**Display Name**: Web Location Url<br />**Description**: Shows the Web Location Url of Office Graph Document.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the Office Graph Document with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_officegraphdocument_createdonbehalfby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_officegraphdocument_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_officegraphdocument|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_officegraphdocument|  

[!INCLUDE[./remarks/officegraphdocument.md](./remarks/officegraphdocument.md)]

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