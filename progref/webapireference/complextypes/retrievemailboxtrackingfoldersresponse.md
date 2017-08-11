---
title: "RetrieveMailboxTrackingFoldersResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9a74b2ab-75eb-4808-a4af-030e8e4d3138
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveMailboxTrackingFoldersResponse ComplexType
[!INCLUDE[./descriptions/retrievemailboxtrackingfoldersresponse.md](./descriptions/retrievemailboxtrackingfoldersresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|MailboxTrackingFolderMappings|Collection([MailboxTrackingFolderMapping ComplexType](../complextypes/MailboxTrackingFolderMapping.md))||true|Collection of folder-level tracking rules for a mailbox containing Exchange folder and entity record mapping. | 

## Used by
The following use the RetrieveMailboxTrackingFoldersResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveMailboxTrackingFolders Function](../functions/retrievemailboxtrackingfolders.md)|ReturnType|[!INCLUDE[../functions/descriptions/retrievemailboxtrackingfolders.md](../functions/descriptions/retrievemailboxtrackingfolders.md)]|

[!INCLUDE[./remarks/retrievemailboxtrackingfoldersresponse.md](./remarks/retrievemailboxtrackingfoldersresponse.md)]

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