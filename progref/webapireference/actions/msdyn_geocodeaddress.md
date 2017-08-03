---
title: "msdyn_GeocodeAddress Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: f7443738-74e3-4164-b2c4-99927a7b4c17
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_GeocodeAddress Action
[!INCLUDE[./descriptions/msdyn_geocodeaddress.md](./descriptions/msdyn_geocodeaddress.md)]

The msdyn_GeocodeAddress action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[organization EntityType](../entitytypes/organization.md)|true|true||
|Line1|Edm.String|false|false||
|City|Edm.String|false|false||
|StateOrProvince|Edm.String|false|false||
|PostalCode|Edm.String|false|false||
|Country|Edm.String|false|false||
|Lcid|Edm.Int32|true|true||

## Return Type
The msdyn_GeocodeAddress action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msdyn_GeocodeAddressResponse ComplexType](../complextypes/msdyn_GeocodeAddressResponse.md)|false|msdyn_GeocodeAddressResponse|



[!INCLUDE[./remarks/msdyn_geocodeaddress.md](./remarks/msdyn_geocodeaddress.md)]

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