---
title: "msevtmgt_CheckWebinarCredentials Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 335acdab-e33a-4515-867e-d7d6e089eb88
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msevtmgt_CheckWebinarCredentials Action
[!INCLUDE[./descriptions/msevtmgt_checkwebinarcredentials.md](./descriptions/msevtmgt_checkwebinarcredentials.md)]

This action is added by the [Event Management for Dynamics 365 Solution](../solutions/microsoftdynamicseventmanagementsolution.md).

The msevtmgt_CheckWebinarCredentials action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|AccessTokenKey|Edm.String|false|false|TODO: Add description for msevtmgt_CheckWebinarCredentials AccessTokenKey parameter.|
|AccessTokenSecret|Edm.String|false|false|TODO: Add description for msevtmgt_CheckWebinarCredentials AccessTokenSecret parameter.|
|ClientId|Edm.String|false|false|TODO: Add description for msevtmgt_CheckWebinarCredentials ClientId parameter.|
|Key|Edm.String|false|false|TODO: Add description for msevtmgt_CheckWebinarCredentials Key parameter.|
|WebinarProvider|[msevtmgt_webinarprovider EntityType](../entitytypes/msevtmgt_webinarprovider.md)|false|true|TODO: Add description for msevtmgt_CheckWebinarCredentials WebinarProvider parameter.|
|ConfigurationId|Edm.String|false|false|TODO: Add description for msevtmgt_CheckWebinarCredentials ConfigurationId parameter.|
|BusinessProcessFlowId|Edm.String|true|false|TODO: Add description for msevtmgt_CheckWebinarCredentials BusinessProcessFlowId parameter.|
|BusinessProcessFlowInstanceId|Edm.String|true|false|TODO: Add description for msevtmgt_CheckWebinarCredentials BusinessProcessFlowInstanceId parameter.|
|ActionStepId|Edm.String|true|false|TODO: Add description for msevtmgt_CheckWebinarCredentials ActionStepId parameter.|

## Return Type
The msevtmgt_CheckWebinarCredentials action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msevtmgt_CheckWebinarCredentialsResponse ComplexType](../complextypes/msevtmgt_CheckWebinarCredentialsResponse.md)|false|TODO: Add description for msevtmgt_CheckWebinarCredentials return type.|



[!INCLUDE[./remarks/msevtmgt_checkwebinarcredentials.md](./remarks/msevtmgt_checkwebinarcredentials.md)]

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