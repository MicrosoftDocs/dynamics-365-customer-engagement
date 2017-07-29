---
title: "Microsoft Dynamics 365 Customer Engagement salesliteratureitem EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 12b02c2e-31ba-438b-b3d3-15606e21fb15
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API salesliteratureitem entitytype."
---
# salesliteratureitem EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/salesliteratureitem.md](./descriptions/salesliteratureitem.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]salesliteratureitems </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Sales Attachment</td></tr>
<tr><td><b>Primary Key:</b></td><td>salesliteratureitemid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The salesliteratureitem entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|abstract|Edm.String|**Display Name**: Abstract<br />**Description**: Abstract of the document.<br />|
|attacheddocumenturl|Edm.String|**Display Name**: Attached Document URL<br />**Description**: URL of the Website on which the document is located.<br />|
|authorname|Edm.String|**Display Name**: Author Name<br />**Description**: Author name for the document.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the document was created.<br />Read-only<br />|
|documentbody|Edm.String|**Description**: Shows the encoded contents of the sales literature document attachment.<br />|
|documentbody_binary|Edm.Binary|**Description**: Shows the encoded contents of the sales literature document attachment.<br />|
|filename|Edm.String|**Display Name**: File Name<br />**Description**: File name of the document.<br />|
|filesize|Edm.Int32|**Display Name**: File Size (Bytes)<br />**Description**: File size of the document.<br />Read-only<br />|
|filetypecode|Edm.Int32|**Display Name**: File Type<br />**Description**: Select the file type of the document.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Default Value</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|iscustomerviewable|Edm.Boolean|**Display Name**: Customer Viewable<br />**Description**: Tells whether the document can be shared with customers or is for internal use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|keywords|Edm.String|**Display Name**: Key Words<br />**Description**: Keywords to use for searches in documents.<br />|
|mimetype|Edm.String|**Display Name**: Mime Type<br />**Description**: Shows the file type of the sales literature document attachment, such as text or document.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the document was last modified.<br />Read-only<br />|
|organizationid|Edm.Guid|**Display Name**: Organization <br />**Description**: Unique identifier of the organization associated with the document.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|salesliteratureitemid|Edm.Guid|**Display Name**: Sales Literature Item<br />**Description**: Unique identifier for the document.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|title|Edm.String|**Display Name**: Title<br />**Description**: Type the title or name that describes the document.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the document.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the salesliteratureitem.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the document.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the salesliteratureitem.|
|_salesliteratureid_value|salesliteratureid<br />|Unique identifier of the sales literature that is associated with the individual item.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_salesliteratureitembase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_salesliteratureitem_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_salesliteratureitembase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_salesliteratureitem_modifiedonbehalfby|
|salesliteratureid|[salesliterature EntityType](salesliterature.md)|sales_literature_items|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|SalesLiteratureItem_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_salesliteratureitem|  
|SalesLiteratureItem_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_salesliteratureitem|  
|salesliteratureitem_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_salesliteratureitem|  

## Solutions
The following solutions include the salesliteratureitem entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|    

[!INCLUDE[./remarks/salesliteratureitem.md](./remarks/salesliteratureitem.md)]

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