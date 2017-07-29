---
title: "Microsoft Dynamics 365 Customer Engagement post EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4317bfe0-8935-4139-9cac-3db88b67ac38
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API post entitytype."
---
# post EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/post.md](./descriptions/post.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]posts </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Post</td></tr>
<tr><td><b>Primary Key:</b></td><td>postid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>text</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,DELETE</td></tr>
</table>
  
The post entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|postid|Edm.Guid|**Display Name**: Post<br />**Description**: Unique identifier for entity instances<br />|
|source|Edm.Int32|**Display Name**: Source<br />**Description**: Select whether the post was created manually or automatically.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Auto Post</td></tr><tr><td>2</td><td>Manual Post</td></tr><tr><td>3</td><td>ActionHub Post</td></tr><tbody></table>|
|text|Edm.String|**Display Name**: Text<br />**Description**: Shows the text of a post. If this is a manual post, it appears in plain text. If this is an auto post, it appears in XML.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|type|Edm.Int32|**Display Name**: Type<br />**Description**: Select the post type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Check-in</td></tr><tr><td>2</td><td>Idea</td></tr><tr><td>3</td><td>News</td></tr><tr><td>4</td><td>Private Message</td></tr><tr><td>5</td><td>Question</td></tr><tr><td>6</td><td>Re-post</td></tr><tr><td>7</td><td>Status</td></tr><tbody></table>|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the solution.|
|_regardingobjectid_value||Choose the parent record for the post to identify the customer, opportunity, case, or other record that the post most closely relates to.|
|_regardingobjectownerid_value||Unique identifier of the user or team who owns the regarding object.|
|_regardingobjectowningbusinessunit_value||Unique identifier of the business unit that owns the regarding object.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_post_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_post_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_post_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_post_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_post|
|postregardingid|[postregarding EntityType](postregarding.md)|post_PostRegardings|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|post_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_post|  
|post_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_post|  
|Post_Comments|[postcomment EntityType](postcomment.md)|postid|  
|Post_Likes|[postlike EntityType](postlike.md)|postid|  

## Operations
The following operations can be used with the post entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrievePersonalWall Function](../functions/retrievepersonalwall.md)|Collection|[!INCLUDE[../functions/descriptions/retrievepersonalwall.md](../functions/descriptions/retrievepersonalwall.md)]|  
|[RetrieveRecordWall Function](../functions/retrieverecordwall.md)|Collection|[!INCLUDE[../functions/descriptions/retrieverecordwall.md](../functions/descriptions/retrieverecordwall.md)]|    

[!INCLUDE[./remarks/post.md](./remarks/post.md)]

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