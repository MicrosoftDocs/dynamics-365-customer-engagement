---
title: "Microsoft Dynamics 365 Customer Engagement activitymimeattachment EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 909d47b2-5d0e-43b9-b71b-4aaf34c56283
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API activitymimeattachment entitytype."
---
# activitymimeattachment EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/activitymimeattachment.md](./descriptions/activitymimeattachment.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]activitymimeattachments </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Attachment</td></tr>
<tr><td><b>Primary Key:</b></td><td>activitymimeattachmentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>filename</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The activitymimeattachment entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|activitymimeattachmentid|Edm.Guid|**Display Name**: Activity Mime Attachment<br />**Description**: Unique identifier of the attachment.<br />|
|activitymimeattachmentidunique|Edm.Guid|**Description**: For internal use only.<br />|
|activitysubject|Edm.String|**Description**: Descriptive subject for the activity.<br />Read-only<br />|
|anonymouslink|Edm.String|**Display Name**: For internal use only.<br />**Description**: anonymous link<br />Read-only<br />|
|attachmentcontentid|Edm.String|**Display Name**: Content Id<br />**Description**: For internal use only<br />|
|attachmentnumber|Edm.Int32|**Display Name**: Attachment Number<br />**Description**: Number of the attachment.<br />|
|body|Edm.String|**Display Name**: Body<br />**Description**: Contents of the attachment.<br />|
|body_binary|Edm.Binary|**Description**: Contents of the attachment.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|filename|Edm.String|**Display Name**: File Name<br />**Description**: File name of the attachment.<br />|
|filesize|Edm.Int32|**Display Name**: File Size (Bytes)<br />**Description**: File size of the attachment.<br />Read-only<br />|
|isfollowed|Edm.Boolean|**Display Name**: Followed<br />**Description**: Indicates if this attachment is followed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|mimetype|Edm.String|**Display Name**: Mime Type<br />**Description**: MIME type of the attachment.<br />|
|objecttypecode|Edm.String|**Display Name**: Entity<br />**Description**: Object Type Code of the entity that is associated with the attachment.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|subject|Edm.String|**Display Name**: Subject<br />**Description**: Descriptive subject for the attachment.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the activity mime attachment.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_attachmentid_value|attachmentid<br />|Unique identifier of the attachment with which this activitymimeattachment is associated.|
|_objectid_value|objectid_activitypointer<br />objectid_template<br />|Unique identifier of the record with which the attachment is associated|
|_ownerid_value||Unique identifier of the user or team who owns the activity_mime_attachment.|
|_owningbusinessunit_value||Unique identifier of the business unit that owns the activity mime attachment.|
|_owninguser_value||Unique identifier of the user who owns the activity mime attachment.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|attachmentid|[attachment EntityType](attachment.md)|attachment_activity_mime_attachments|
|objectid_activitypointer|[activitypointer EntityType](activitypointer.md)|activity_pointer_activity_mime_attachment|
|objectid_appointment|[appointment EntityType](appointment.md)|appointment_activity_mime_attachment|
|objectid_email|[email EntityType](email.md)|email_activity_mime_attachment|
|objectid_template|[template EntityType](template.md)|template_activity_mime_attachments|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ActivityMimeAttachment_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_activitymimeattachment|  
|ActivityMimeAttachment_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_activitymimeattachment|  
|ActivityMimeAttachment_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_activitymimeattachment_syncerror|  

## Solutions
The following solutions include the activitymimeattachment entity type.


|Name|Description |  
|----|------------|  
|[Activities Solution](../solutions/activities.md)|[!INCLUDE[../solutions/descriptions/activities.md](../solutions/descriptions/activities.md)]|    

[!INCLUDE[./remarks/activitymimeattachment.md](./remarks/activitymimeattachment.md)]

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