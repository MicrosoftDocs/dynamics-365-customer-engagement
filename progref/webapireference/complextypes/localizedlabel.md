---
title: "LocalizedLabel ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: be2da0a2-f21c-486f-9f69-84b161a18d78
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# LocalizedLabel ComplexType
[!INCLUDE[./descriptions/localizedlabel.md](./descriptions/localizedlabel.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Label|Edm.String|true|false|The localized label string. | 
|LanguageCode|Edm.Int32|true|true|The language code for the label. | 
|IsManaged|Edm.Boolean|true|true| Whether the label is managed. | 
|MetadataId|Edm.Guid|true|true|A unique identifier for the metadata item.| 
|HasChanged|Edm.Boolean|true|true|Whether the item of metadata has changed. | 

## Used by
The following use the LocalizedLabel ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[SetLocLabels Action](../actions/setloclabels.md)|Parameter|[!INCLUDE[../actions/descriptions/setloclabels.md](../actions/descriptions/setloclabels.md)]|
|[Label ComplexType](../complextypes/label.md)|Property|[!INCLUDE[../complextypes/descriptions/label.md](../complextypes/descriptions/label.md)]|

[!INCLUDE[./remarks/localizedlabel.md](./remarks/localizedlabel.md)]

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