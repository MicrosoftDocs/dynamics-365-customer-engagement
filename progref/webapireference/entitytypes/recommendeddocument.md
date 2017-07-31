---
title: "Microsoft Dynamics 365 Customer Engagement recommendeddocument EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 977933ea-f44b-4bf8-8d33-95ec4b3f4894
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API recommendeddocument entitytype."
---
# recommendeddocument EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/recommendeddocument.md](./descriptions/recommendeddocument.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]recommendeddocuments </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Document Suggestions</td></tr>
<tr><td><b>Primary Key:</b></td><td>recommendeddocumentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET (RetrieveMultiple Only)</td></tr>
</table>
  
The recommendeddocument EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|absoluteurl|Edm.String|**Display Name**: Absolute URL<br />**Description**: Type the URL where the recommended document is located.<br />Read-only<br />|
|associatedrecordname|Edm.String|**Display Name**: Associated Record Name<br />**Description**: Shows the associated record name of the recommended document.<br />|
|author|Edm.String|**Display Name**: Author<br />**Description**: Shows the name of the author of the recommended document.<br />|
|contenttype|Edm.String|**Display Name**: Content Type<br />**Description**: Select the document content type.<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|editurl|Edm.String|**Display Name**: Edit Web App URL<br />**Description**: Shows the Edit URL of the recommended document.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Shows the exchange rate for the currency associated with the recommended document with respect to the base currency.<br />Read-only<br />|
|externaldocumentid|Edm.String|**Display Name**: External Document ID<br />**Description**: Shows the external document.<br />|
|externalmodifiedby|Edm.String|**Display Name**: Modified by<br />**Description**: Shows who last updated the document record.<br />|
|filesize|Edm.Int32|**Display Name**: File Size<br />**Description**: Shows the file size.<br />Read-only<br />|
|filetype|Edm.String|**Display Name**: File Type<br />**Description**: Shows the file type.<br />Read-only<br />|
|fullname|Edm.String|**Display Name**: Name<br />**Description**: Shows the full name of the recommended document.<br />Read-only<br />|
|iconclassname|Edm.String|**Display Name**: Icon Class Name<br />**Description**: Stores the Icon Class name of the recommended document.<br />Read-only<br />|
|location|Edm.String|**Display Name**: Path<br />**Description**: Shows the location of the recommended document.<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|readurl|Edm.String|**Display Name**: Read Web App URL<br />**Description**: Shows the Read URL of the recommended document.<br />Read-only<br />|
|recommendeddocumentid|Edm.Guid|**Display Name**: Recommended Document<br />**Description**: Shows the recommended document record.<br />|
|source|Edm.String|**Display Name**: Source<br />**Description**: Shows the source storage of the recommended document.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|title|Edm.String|**Display Name**: Title<br />**Description**: Type a title for the entity.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|version|Edm.String|**Display Name**: Recommended Document Version<br />**Description**: Shows the recommended document version.<br />Read-only<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdbyname<br />|Shows the user who created the record.|
|_createdonbehalfby_value|createdonbehalfbyname<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedbyname<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfbyname<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Shows the organization.|
|_regardingobjectid_value||Choose the parent record that the recommended document record is associated with.|
|_transactioncurrencyid_value|transactioncurrencyidname<br />|Shows the exchange rate for the currency associated with the recommended document with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdbyname|[systemuser EntityType](systemuser.md)|lk_recommendeddocument_createdby|
|createdonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_recommendeddocument_createdonbehalfby|
|modifiedbyname|[systemuser EntityType](systemuser.md)|lk_recommendeddocument_modifiedby|
|modifiedonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_recommendeddocument_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_recommendeddocument|
|transactioncurrencyidname|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_recommendeddocument|  

[!INCLUDE[./remarks/recommendeddocument.md](./remarks/recommendeddocument.md)]

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