---
title: "CheckIncomingEmail Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 15273b69-a375-4015-9ea0-eac89566f157
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CheckIncomingEmail Function
[!INCLUDE[./descriptions/checkincomingemail.md](./descriptions/checkincomingemail.md)]

The CheckIncomingEmail function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|MessageId|Edm.String|false|false|ID of the email message stored in the email header.|
|Subject|Edm.String|true|false|Subject line for the email message.|
|From|Edm.String|false|false|The from address for the email message.|
|To|Edm.String|false|false|The addresses of the recipients of the email message.|
|Cc|Edm.String|false|false|Addresses of the carbon copy (Cc) recipients for the email message.|
|Bcc|Edm.String|false|false|Addresses of the blind carbon copy (Bcc) recipients for the email message.|
|ExtraProperties|[email EntityType](../entitytypes/email.md)|true|true|For internal use only.|

## Return Type
The CheckIncomingEmail function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[CheckIncomingEmailResponse ComplexType](../complextypes/CheckIncomingEmailResponse.md)|false|Contains the response from the CheckIncomingEmail function.|

## Entities
Use the CheckIncomingEmail function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[email Entitytype](../entitytypes/email.md)|[!INCLUDE[../entitytypes/descriptions/email.md](../entitytypes/descriptions/email.md)]|

[!INCLUDE[./remarks/checkincomingemail.md](./remarks/checkincomingemail.md)]

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