---
title: "Microsoft Dynamics 365 Customer Engagement attachment EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f5de83e4-424c-44b9-91e3-8262c4a34770
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API attachment entitytype."
---
# attachment EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/attachment.md](./descriptions/attachment.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]attachments </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Attachment</td></tr>
<tr><td><b>Primary Key:</b></td><td>attachmentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>filename</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The attachment EntityType:
* Has no lookup properties.
* Has no single-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|attachmentid|Edm.Guid|**Display Name**: Attachment<br />**Description**: Unique identifier of the attachment.<br />|
|body|Edm.String|**Display Name**: Body<br />**Description**: Contents of the attachment.<br />|
|body_binary|Edm.Binary|**Description**: Contents of the attachment.<br />|
|filename|Edm.String|**Display Name**: File Name<br />**Description**: File name of the attachment.<br />|
|filesize|Edm.Int32|**Display Name**: File Size (Bytes)<br />**Description**: File size of the attachment.<br />Read-only<br />|
|mimetype|Edm.String|**Display Name**: MIME Type<br />**Description**: MIME type of the attachment.<br />|
|subject|Edm.String|**Display Name**: Subject<br />**Description**: Subject associated with the attachment.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the attachment.<br />Read-only<br />|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|attachment_activity_mime_attachments|[activitymimeattachment EntityType](activitymimeattachment.md)|attachmentid|  
|Attachment_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_attachment_syncerror|    

[!INCLUDE[./remarks/attachment.md](./remarks/attachment.md)]

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