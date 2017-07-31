---
title: "Microsoft Dynamics 365 Customer Engagement postcomment EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e6a478e4-834b-4029-99e6-7b1cff37ca99
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API postcomment entitytype."
---
# postcomment EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/postcomment.md](./descriptions/postcomment.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]postcomments </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Comment</td></tr>
<tr><td><b>Primary Key:</b></td><td>postcommentid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>text</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,DELETE</td></tr>
</table>
  
The postcomment EntityType:
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|postcommentid|Edm.Guid|**Display Name**: PostComment<br />**Description**: Shows the ID of the post comment.<br />|
|text|Edm.String|**Display Name**: Text<br />**Description**: Text of the comment.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the solution.|
|_postid_value|postid<br />|Unique identifier of the post with which the comment is associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_postcomment_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_postcomment_createdonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_PostComment|
|postid|[post EntityType](post.md)|Post_Comments|  

[!INCLUDE[./remarks/postcomment.md](./remarks/postcomment.md)]

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