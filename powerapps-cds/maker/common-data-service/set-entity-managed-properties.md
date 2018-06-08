---
title: "Set entity managed properties in PowerApps | MicrosoftDocs"
description: "Learn how to set managed properties of an entity"
ms.custom: ""
ms.date: 05/18/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
  - "powerapps"
author: "Mattp123"
ms.assetid: edaa7d4a-a95f-4d66-a9d9-2ad6051332f7
caps.latest.revision: 41
ms.author: "matp"
manager: "kvivek"
---
# Set managed properties for an entity

Managed properties only apply when you include an entity with a managed solution and import it into another environment. These settings allow a solution maker to have some control over the level of customization that they want to allow people who install their managed solution to have. 

> [!TIP]
> It is generally a good idea to allow people to extend entities in your solution that enable storing business data. This will allow them to tailor your solution to their needs in the same way that they can for standard entities.
>
>For entities that provide functionality to support your solution but do not contain business data, it is a good idea to limit what customizations are allowed.

Setting managed properties must be done using solution explorer.

[!INCLUDE [cc_navigate-solution-from-powerapps-portal](../../includes/cc_navigate-solution-from-powerapps-portal.md)]

## Set entity managed properties.

To set managed properties for an entity, select the entity and select **Managed Properties** on the menu bar.  This will open the **Set Managed Properties** dialog.

![Set entity managed properties](media/set-managed-properties.png)
  
  
Entities have more managed properties than any other type of solution component. If the entity is customizable, you can set the following options:  

|Option|Description|
|--|--|
|**Can be customized** |Controls all the other options. If this option is `False`, none of the other settings apply. When it is `True`, you can specify the other customization options. When `False`, it is equivalent to setting all other options to false.|
|**Display name can be modified**|Whether the entity display name can be modified.|
|**Can Change Additional Properties** |Applies to anything not covered by other options.|
|**New forms can be created**|Whether new forms can be created for the entity.|
|**New charts can be created**|Whether new charts can be created for the entity.|
|**New views can be created** |Whether new views can be created for the entity.|
|**Can Change Hierarchical Relationship**|Whether Hierarchial Relationships settings can be changed. More information: [Query and visualize hierarchically related data](query-visualize-hierarchical-data.md)|
|**Can Change Tracking Be Enabled** |Whether the entity **Change Tracking** property can be changed.|
|**Can Enable sync to external search index** |Whether the entity can be configured to enable relevance search. More information: [Configure Relevance Search to improve search results and performance](/dynamics365/customer-engagement/admin/configure-relevance-search-organization) |
 

 ### See also
[Entities and metadata in Common Data Service for Apps](create-edit-metadata.md)