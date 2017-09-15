---
title: Image Entity Types (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: Image data is typically uploaded into Azure blobs and associated with primary entity types to enrich the user-interface experience.
keywords: Customer Insights; type; GetImageUploadUrlInput; ImageDefintion
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 05/26/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 9b710937-579f-4e96-968e-ae1f65810f83
---

Image Entity Types
==================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Image data is typically uploaded into Azure blobs and associated with primary entity types, such as [Profile](./profile.md) and [Interaction](./interaction.md), to enrich the 
user-interface experience. The type GetImageUploadUrlInput contains the information to associate an uploaded image to an existing type; whereas ImageDefintion contains 
the full details needed to retrieve that image. 


## GetImageUploadUrlInput properties

### Properties
|**Property**|**JSON type**|**Description**|  
| --------------- | ---------- | ------------- |
|entityType|string|Entity type that the image is associated with, currently ["Profile" \| "Interaction"]|
|entityTypeName|string|Name of the specific type to associate the image to|
|relativePath|string|Relative path used to store/retrieve/reference the image|
| | | |


### JSON example
```{json}
{ 
    "entityType": "Profile1", 
    "entityTypeName":"Contact1", 
    "relativePath":"myimages/image1.jpeg" 
}
```

<br/>


## ImageDefintion properties

### Properties

|**Property**|**JSON type**|**Description**|  
| --------------- | ---------- | ------------- |
|contentUrl|string|Shared Access Signature (SAS) URI of the blob with create and write permissions|
|imageExists|boolean|True if the image already exists at the specified blob location, otherwise False|
|relativePath|string|Relative path used to store/retrieve/reference the image|
| | | |


### JSON example
```{json}
{   
    "contentUrl":
        "https://storageaccountname.blob.core.windows.net/media/entitytypeimage/<hubGuid>/<EntityType>/<EntityTypeName>/<RelativePath>", 
    "imageExists":"false", 
    "relativePath":"myimages/image1.jpeg" }
```

