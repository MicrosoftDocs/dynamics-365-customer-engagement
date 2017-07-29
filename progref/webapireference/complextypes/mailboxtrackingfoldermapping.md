---
title: "MailboxTrackingFolderMapping ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a50b0bfe-63f5-4397-98b5-9ad425df3b97
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# MailboxTrackingFolderMapping ComplexType
[!INCLUDE[./descriptions/mailboxtrackingfoldermapping.md](./descriptions/mailboxtrackingfoldermapping.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ExchangeFolderId|Edm.String|true|false|The ID of the Exchange folder in the folder-level tracking rule. | 
|ExchangeFolderName|Edm.String|true|false|The name of the Exchange folder in the folder-level tracking rule. | 
|RegardingObjectId|Edm.Guid|true|true|The ID of the entity record with which the Exchange folder is mapped. | 
|RegardingObjectName|Edm.String|true|false|The name of the entity represented by the RegardingObjectId property. | 
|RegardingObjectTypeCode|Edm.Int32|true|true|The entity type code of the entity represented by the RegardingObjectId property.| 
|IsFolderOnboarded|Edm.Boolean|true|true|Whether the tracking rule for the folder has run.| 

## Used by
The following use the MailboxTrackingFolderMapping ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveMailboxTrackingFoldersResponse ComplexType](../complextypes/retrievemailboxtrackingfoldersresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/retrievemailboxtrackingfoldersresponse.md](../complextypes/descriptions/retrievemailboxtrackingfoldersresponse.md)]|

[!INCLUDE[./remarks/mailboxtrackingfoldermapping.md](./remarks/mailboxtrackingfoldermapping.md)]

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