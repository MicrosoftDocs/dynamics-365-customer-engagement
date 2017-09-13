---
title: "OrganizationDetail ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a91827a4-1abb-4726-8999-9fb577a8a23d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# OrganizationDetail ComplexType
[!INCLUDE[./descriptions/organizationdetail.md](./descriptions/organizationdetail.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|OrganizationId|Edm.Guid|true|true| The global unique identifier of the organization.| 
|FriendlyName|Edm.String|true|false|The friendly name of the organization. | 
|OrganizationVersion|Edm.String|true|false|The version of the organization.| 
|UrlName|Edm.String|true|false|The organization name used in the URL for the organization web service. | 
|UniqueName|Edm.String|true|false|The unique name of the organization. | 
|Endpoints|[EndpointCollection ComplexType](../complextypes/EndpointCollection.md)|true|true|Collection that identifies the service type and address for each endpoint of the organization. | 
|State|[OrganizationState EnumType](../enumtypes/OrganizationState.md)|true|true|The state of the organization. | 

## Used by
The following use the OrganizationDetail ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveCurrentOrganizationResponse ComplexType](../complextypes/retrievecurrentorganizationresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrievecurrentorganizationresponse.md](../complextypes/descriptions/retrievecurrentorganizationresponse.md)]|

[!INCLUDE[./remarks/organizationdetail.md](./remarks/organizationdetail.md)]

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