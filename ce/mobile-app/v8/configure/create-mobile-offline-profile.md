---
title: "Create a mobile offline profile for Dynamics 365 for phones and tablets | MicrosoftDocs"
ms.custom: ""
ms.date: 12/18/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 8.x"
ms.assetid: c463347e-a057-4230-951a-1cca07b213f0
caps.latest.revision: 7
ms.author: "jimholtz"
manager: "brycho"
---
# Create a mobile offline profile

[!INCLUDE[cc-applies-to-update-8-2-0](../../../includes/cc_applies_to_update_8_2_0.md)]

You need to create mobile offline profiles for users to configure filters that determine how much of an entity's data (and related entities' data) will be available to the user while offline.  
  
1.  Go to **Settings > Mobile Offline**.  
  
2.  Click **Mobile Offline Profiles**.  
  
3.  Click **New** to create a new mobile offline profile. If you already have one that you want to edit, select it from the list.  
  
4.  Enter a name and description for your mobile offline profile.  
  
5.  Click **Save** to create the mobile offline profile so you can continue editing it.  
  
6.  In the **Mobile Offline Profile Item Details** area, click **+** to create a new mobile offline profile item. You need to create a mobile offline profile item for each entity you want to make available for this mobile offline profile.  
  
7.  Enter a name and select an entity. Only entities that you enabled for mobile offline appear in this list.  
  
8.  Select a data download filter based on the ownership type for the entity:  
  
     **User or Team**  
  
    -   **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
  
    -   **All records**. Make all records for this entity available offline.  
  
    -   **Other records**. Make only the specified records for this entity available offline.  
  
     If you select **Other records**, you can choose from the following:  
  
    -   **Download my records**. Make only your records available offline.  
  
    -   **Download my team’s records**. Make your team’s records available offline.  
  
    -   **Download my business unit’s records**. Make your business unit’s records available offline.  
  
     **Organization**  
  
    -   **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
  
    -   **All records**. Make all records for this entity available offline.  
  
     **Business**  
  
    -   **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
  
    -   **All records**. Make all records for this entity available offline.  
  
    -   **Other records**. Make only the specified records for this entity available offline.  
  
     If you select **Other records**, you can choose from the following:  
  
    -   **Download my business unit’s records**. Make your business unit’s records available offline.  
  
     **None**  
  
    -   **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
  
9. Click **Save** to create the mobile offline profile item so you can continue editing it.  
  
10. In the **Mobile Offline Profile Item Association Details** area, click **+** to create a new mobile offline profile item association. You need to create a mobile offline profile item association for each related record you want to make available offline. In addition, you need to include any related entities in this mobile offline profile.  
  
     For example, if you create a mobile offline profile item association from the Lead entity, you need to add the Lead entity to this mobile offline profile.  
  
11. Enter a name for the mobile offline profile item association, select a relationship, and then click **Save & Close**.  
  
12. When you’re done adding mobile offline profile item associations to the mobile offline profile item, click **Save & Close** at the top of the **Mobile Offline Profile Item** screen.  
  
13. When you’re done adding mobile offline profile item details to the mobile offline profile item, click the **Save** button at the bottom right corner of the **Mobile Offline Profile** window.  
  