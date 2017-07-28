---
title: "Microsoft Dynamics 365 Customer Engagement subscriptionstatisticsoutlook EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4113173a-a1b4-4e91-b07b-80c84c5e664a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API subscriptionstatisticsoutlook entitytype."
---
# subscriptionstatisticsoutlook EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/subscriptionstatisticsoutlook.md](./descriptions/subscriptionstatisticsoutlook.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]subscriptionstatisticsoutlookset </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Subscription Statistic Outlook</td></tr>
<tr><td><b>Primary Key:</b></td><td>subscriptionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>None</td></tr>
</table>
  
The subscriptionstatisticsoutlook EntityType:
* Has no lookup properties.
* Has no single-valued navigation properties.
* Has no collection-valued navigation properties.
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|fullsyncrequired|Edm.Boolean|**Display Name**: FullSyncRequired<br />**Description**: Is full sync required or not<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|objecttypecode|Edm.Int32|**Display Name**: ObjectTypeCode<br />**Description**: Entity object type code<br />|
|subscriptionid|Edm.Guid|**Display Name**: SubscriptionId<br />**Description**: Subscription Id<br />|  

[!INCLUDE[./remarks/subscriptionstatisticsoutlook.md](./remarks/subscriptionstatisticsoutlook.md)]

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