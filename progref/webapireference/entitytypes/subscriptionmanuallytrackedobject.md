---
title: "Microsoft Dynamics 365 Customer Engagement subscriptionmanuallytrackedobject EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4ba6c822-29ae-42e5-bb56-cdb973099be6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API subscriptionmanuallytrackedobject entitytype."
---
# subscriptionmanuallytrackedobject EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/subscriptionmanuallytrackedobject.md](./descriptions/subscriptionmanuallytrackedobject.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]subscriptionmanuallytrackedobjects </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Subscription Manually Tracked Object</td></tr>
<tr><td><b>Primary Key:</b></td><td>subscriptionmanuallytrackedobjectid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The subscriptionmanuallytrackedobject EntityType:
* Has no lookup properties.
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|objectid|Edm.Guid|**Display Name**: Object Id<br />**Description**: Unique identifier of the object with which the subscription is associated.<br />|
|objecttypecode|Edm.String|**Description**: Type code of the object with which the subscription is associated.<br />|
|subscriptionid|Edm.Guid|**Display Name**: Subscription Id<br />**Description**: Unique identifier of the subscription.<br />|
|subscriptionmanuallytrackedobjectid|Edm.Guid|**Description**: For internal use only.<br />|
|track|Edm.Boolean|**Description**: Information that specifies if the object is tracked.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|versionnumber|Edm.Int64|**Display Name**: Version number<br />**Description**: Version number of the subscription manually tracked object.<br />Read-only<br />|  

[!INCLUDE[./remarks/subscriptionmanuallytrackedobject.md](./remarks/subscriptionmanuallytrackedobject.md)]

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