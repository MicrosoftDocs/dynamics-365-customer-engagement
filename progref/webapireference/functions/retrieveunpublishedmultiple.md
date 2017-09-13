---
title: "RetrieveUnpublishedMultiple Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4ea21be4-fe0e-4fcf-afe9-0d428ee36210
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveUnpublishedMultiple Function
[!INCLUDE[./descriptions/retrieveunpublishedmultiple.md](./descriptions/retrieveunpublishedmultiple.md)]

The RetrieveUnpublishedMultiple function does not require any parameters.

## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[savedqueryvisualization Entitytype](../entitytypes/savedqueryvisualization.md)|collection|
|[systemform Entitytype](../entitytypes/systemform.md)|collection|
|[customcontroldefaultconfig Entitytype](../entitytypes/customcontroldefaultconfig.md)|collection|
|[webresource Entitytype](../entitytypes/webresource.md)|collection|
|[sitemap Entitytype](../entitytypes/sitemap.md)|collection|
|[savedquery Entitytype](../entitytypes/savedquery.md)|collection|
|[mobileofflineprofileitem Entitytype](../entitytypes/mobileofflineprofileitem.md)|collection|
|[mobileofflineprofile Entitytype](../entitytypes/mobileofflineprofile.md)|collection|
|[appconfig Entitytype](../entitytypes/appconfig.md)|collection|
|[appconfiginstance Entitytype](../entitytypes/appconfiginstance.md)|collection|
|[navigationsetting Entitytype](../entitytypes/navigationsetting.md)|collection|
|[appmodule Entitytype](../entitytypes/appmodule.md)|collection|



## Return Type
The RetrieveUnpublishedMultiple function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([savedqueryvisualization EntityType](../entitytypes/savedqueryvisualization.md))|false|Contains the response from the RetrieveUnpublishedMultiple function.|

## Entities
Use the RetrieveUnpublishedMultiple function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[mobileofflineprofileitemassociation Entitytype](../entitytypes/mobileofflineprofileitemassociation.md)|[!INCLUDE[../entitytypes/descriptions/mobileofflineprofileitemassociation.md](../entitytypes/descriptions/mobileofflineprofileitemassociation.md)]|

[!INCLUDE[./remarks/retrieveunpublishedmultiple.md](./remarks/retrieveunpublishedmultiple.md)]

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