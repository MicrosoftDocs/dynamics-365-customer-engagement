---
title: "OrganizationResources ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 53fdd153-3d24-41fe-af99-b75f69f6eedd
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# OrganizationResources ComplexType
[!INCLUDE[./descriptions/organizationresources.md](./descriptions/organizationresources.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|CurrentNumberOfActiveUsers|Edm.Int32|true|true|The current number of active users. | 
|MaxNumberOfActiveUsers|Edm.Int32|true|true|The maximum number of active users. | 
|CurrentNumberOfNonInteractiveUsers|Edm.Int32|true|true|The current number of interactive users | 
|MaxNumberOfNonInteractiveUsers|Edm.Int32|true|true|The maximum number of interactive users. | 
|CurrentNumberOfCustomEntities|Edm.Int32|true|true|The current number of custom entities. | 
|MaxNumberOfCustomEntities|Edm.Int32|true|true|The maximum number of custom entities. | 
|CurrentNumberOfPublishedWorkflows|Edm.Int32|true|true|The current number of published workflows| 
|MaxNumberOfPublishedWorkflows|Edm.Int32|true|true|The maximum number of published workflows| 
|CurrentStorage|Edm.Int32|true|true|The current storage used by the organization| 
|MaxStorage|Edm.Int32|true|true| The maximum storage allowed for the organization | 

## Used by
The following use the OrganizationResources ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveOrganizationResourcesResponse ComplexType](../complextypes/retrieveorganizationresourcesresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrieveorganizationresourcesresponse.md](../complextypes/descriptions/retrieveorganizationresourcesresponse.md)]|

[!INCLUDE[./remarks/organizationresources.md](./remarks/organizationresources.md)]

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