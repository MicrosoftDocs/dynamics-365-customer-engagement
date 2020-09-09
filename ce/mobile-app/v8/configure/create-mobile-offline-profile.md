---
title: "Create a mobile offline profile for Dynamics 365 for phones and tablets | MicrosoftDocs"
ms.custom: 
ms.date: 12/18/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: c463347e-a057-4230-951a-1cca07b213f0
caps.latest.revision: 7
ms.author: mkaur
author: mduelae
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Sales
---
# Create a mobile offline profile 

You need to create mobile offline profiles for users to configure filters that determine how much of an entity's data (and related entities' data) will be available to the user while offline.  
  
1. Go to **Settings > Mobile Offline**.  
  
2. Click **Mobile Offline Profiles**.  
  
3. Click **New** to create a new mobile offline profile. If you already have one that you want to edit, select it from the list.  
  
4. Enter a name and description for your mobile offline profile.  
  
5. Click **Save** to create the mobile offline profile so you can continue editing it.  
  
6. In the **Mobile Offline Profile Item Details** area, click **+** to create a new mobile offline profile item. You need to create a mobile offline profile item for each entity you want to make available for this mobile offline profile.  
  
7. Enter a name and select an entity. Only entities that you enabled for mobile offline appear in this list.  
  
8. Select a data download filter based on the ownership type for the entity:  
  
    **User or Team**  
  
   - **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
  
   - **All records**. Make all records for this entity available offline.  
  
   - **Other records**. Make only the specified records for this entity available offline.  
  
     If you select **Other records**, you can choose from the following:  
  
   - **Download my records**. Make only your records available offline.  
  
   - **Download my team’s records**. Make your team’s records available offline.  
  
   - **Download my business unit’s records**. Make your business unit’s records available offline.  
  
     **Organization**  
  
   - **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
  
   - **All records**. Make all records for this entity available offline.  
  
     **Business**  
  
   - **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
  
   - **All records**. Make all records for this entity available offline.  
  
   - **Other records**. Make only the specified records for this entity available offline.  
  
     If you select **Other records**, you can choose from the following:  
  
   - **Download my business unit’s records**. Make your business unit’s records available offline.  
  
     **None**  
  
   - **Download related data only**. Make related data for this entity available offline. If you don’t set any relationships, no records for this entity will be available.  
  
9. Click **Save** to create the mobile offline profile item so you can continue editing it.  
  
10. In the **Mobile Offline Profile Item Association Details** area, click **+** to create a new mobile offline profile item association. You need to create a mobile offline profile item association for each related record you want to make available offline. In addition, you need to include any related entities in this mobile offline profile.  
  
     For example, if you create a mobile offline profile item association from the Lead entity, you need to add the Lead entity to this mobile offline profile.  
  
11. Enter a name for the mobile offline profile item association, select a relationship, and then click **Save & Close**.  
  
12. When you’re done adding mobile offline profile item associations to the mobile offline profile item, click **Save & Close** at the top of the **Mobile Offline Profile Item** screen.  
  
13. When you’re done adding mobile offline profile item details to the mobile offline profile item, click the **Save** button at the bottom right corner of the **Mobile Offline Profile** window.  
  
## Enhanced sync filters  
 Admins can choose what information to sync to user's devices. This can help minimize impact to user's device's memory.  
  
> [!NOTE]
> Make sure that you’re using the latest version of the mobile app For Advanced Filters to work offline.  
  
 Admins can define a custom filter based on the following rules. You can create filters up to three levels.  
  
|      |  
|------|  
|equal|  
|not equal|  
|gt – greater than|  
|ge – greater than or equal to|  
|le – less than or equal to|  
|lt – less than|  
|like|  
|not-like|  
|in|  
|not-in|  
|null|  
|not-null|  
|eq-userid|  
|ne-userid|  
|eq-userteams|  
|eq-useroruserteams|  
|eq-useroruserhierarchy|  
|eq-useroruserhierarchyandteams|  
|eq-businessid|  
|ne-businessid|  
|eq-userlanguage|  
|begins-with|  
|not-begin-with|  
|ends-with|  
|not-end-with|  

## For admins: Enhanced sync status for provisioning  

**About enhanced sync status:**  
  
-   Admins can see the status of provisioning and de-provisioning.  
-   The mobile offline configuration page is auto-refreshed at regular intervals to show updated status messages during provisioning and de-provisioning.  
-   You can stop provisioning at any stage during provisioning.  
-   You can de-provision your organization only when the provisioning is complete.  
-   De-provisioning of an organization can't be stopped once initiated.  
-   You can initiate provisioning again only when de-provisioning is complete.  
-   In  case of a provisioning or de-provisioning failure, consider retrying your provisioning before contacting support.  
-   All the provisioning and de-provisioning messages will be shown on the mobile offline configuration page along with the date and timestamp of when the status was last checked.  
  
