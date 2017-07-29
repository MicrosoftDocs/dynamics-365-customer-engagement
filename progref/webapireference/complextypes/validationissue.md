---
title: "ValidationIssue ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 30ecd0a1-cb3f-4c95-9de8-e3b9bd3bbd1d
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ValidationIssue ComplexType
[!INCLUDE[./descriptions/validationissue.md](./descriptions/validationissue.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ErrorType|[ErrorType EnumType](../enumtypes/ErrorType.md)|true|true|TODO: Add description for ValidationIssue.ErrorType property.| 
|Message|Edm.String|true|false|TODO: Add description for ValidationIssue.Message property.| 
|DisplayName|Edm.String|true|false|TODO: Add description for ValidationIssue.DisplayName property.| 
|ComponentId|Edm.Guid|true|true|TODO: Add description for ValidationIssue.ComponentId property.| 
|ComponentType|Edm.Int32|true|true|TODO: Add description for ValidationIssue.ComponentType property.| 
|ComponentSubType|Edm.Int32|true|true|TODO: Add description for ValidationIssue.ComponentSubType property.| 
|ParentEntityId|Edm.Guid|true|true|TODO: Add description for ValidationIssue.ParentEntityId property.| 
|ParentEntityName|Edm.String|true|false|TODO: Add description for ValidationIssue.ParentEntityName property.| 
|RequiredComponents|Collection([Component ComplexType](../complextypes/Component.md))||true|TODO: Add description for ValidationIssue.RequiredComponents property.| 
|CRMErrorCode|Edm.Int32|true|true|TODO: Add description for ValidationIssue.CRMErrorCode property.| 

## Used by
The following use the ValidationIssue ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[AppValidationResponse ComplexType](../complextypes/appvalidationresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/appvalidationresponse.md](../complextypes/descriptions/appvalidationresponse.md)]|

[!INCLUDE[./remarks/validationissue.md](./remarks/validationissue.md)]

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