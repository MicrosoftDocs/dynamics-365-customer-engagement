---
title: "Use the new segmentation designer (Dynamics 365 Marketing) | Microsoft Docs "
description: "Lear how to use the new segmentation designer to create segments in Dynamics 365 Marketing"
ms.date: 08/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: e183f743-cc12-44f8-b8a0-09d06dcb6de0
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Early access: Create segments with the new segmentation designer

[!INCLUDE [cc-marketing-early-access-2019w2](../includes/cc-marketing-early-access-2019w2.md)]





<a name="create-segment"></a>


<a name="segment-profile"></a>



<a name="segment-interaction"></a>



<a name="segment-static"></a>



<a name="segment-compound"></a>



## Work with legacy segments

When you enable the new segment designer on an existing Marketing instance, all of your legacy segments will continue to work, but some types of legacy segments can't be displayed using the new segment designer. This mostly affects segments that include relations to non-contact entities because the new designer uses a different type of query statement to establish relations (the legacy designer used TRAVERSE, while the new designer uses RELATE). As a result, you may experience the following:

- On opening a legacy segment that includes TRAVERSE statements, it will open in the legacy designer, but will continue to function exactly as it did before the update. You can still edit, go live, and use these legacy segments.
- You can't paste older query strings that include TRAVERSE statements into the new segment designer. If you do, you'll see an error message. Please use the new designer to recreate these queries using the new standard.

### See also

[Working with segments](segmentation-lists-subscriptions.md)  
[Segments vs. lists](segments-vs-lists.md)  
[Design dynamic demographic or firmographic segments](segments-profile.md)  
[Design behavioral segments](segments-interaction.md)  
[Generate behavioral segments from journey results](generate-segment-from-journey.md)  
[Manage segment memberships from a contact record](manage-segments-from-contacts.md)  