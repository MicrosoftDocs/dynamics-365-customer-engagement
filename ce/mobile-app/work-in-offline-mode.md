---
title: "Work Offline on your mobile device (Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
ms.custom: 
ms.date: 03/25/2019
ms.reviewer: kvivek
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement apps
  - Dynamics 365 for Customer Engagement apps Version 9.x
ms.assetid: 6828238b-1645-4710-a192-0014acb03196
caps.latest.revision: 97
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Sales
---

# Preview Feature: Work offline on your mobile device

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Seamless work offline with mobile offline synchronization. You can work with mobile app in offline mode when the device is disconnected from the internet. The app provides a rich offline experience which lets you to work with basic commands like create, read, update, and delete and business processes - so you always stay productive. Once you're back online, changes you've made are synchronized with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. 

When you're admin has enabled mobile offline, the next time that you access the mobile app, you will be prompted to download updates. Once you download the updates, you can start using the mobile app in offline mode.

1. When you see the **Offline Updates Available** dialog box, choose **Update**. 

   ![Download updates on your mobile device for mobile offline](media/DownloadUpdates.png "Download updates on your mobile device for mobile offline")
  
2. You'll see a progress indicator while the updates are being downloaded. When the download load is complete, it's a good idea to verify offline mode is available.

    ![Download updates progress bar](media/downloadingupdatesprogress.png "Download updates progress bar")


**See if offline mode is available**

When the updates have download, you can check to see if mobile offline is available.

1. From the nav bar, tap ![Dynamics 365 for Customer Engagement apps ellipsis](../mobile-app/media/mobile-ellipsis.png "Dynamics 365 for Customer Engagement apps ellipsis") and then tap, **Offline Status**.
  
   ![Mobile Offline Status](../mobile-app/media/OfflineStatusSettings.png "Mobile Offline Status")   

2. **Offline Status**, tracks offline status of the whole app, and also the status of each entity individually. When the status shows as  **Available**, it indicates offline is available and data has synced successfully.

   > [!NOTE] 
   > The status here can be **Not Available** due to an error or if you missed downlading offline updates. If the status is **Not Available** due to missing the latest offline updates, then try downloading the updates again.
 
   - **Entity Status**, provides the offline status of each entity individually. For the available entities you can also track the last time the entity synced.
 
     ![Mobile offline status](media/OfflineStatus.png "Mobile offline status")
 
   You can also track offline status of entities from the **Menu** ![Menu button](media/MenuButton.png "Menu button") button.

-  Green Wi-Fi icon next to the entity name indicates that it is available in offline mode.
-  Red Wi-Fi icon indicates that this entity is enabled for offline but is not available to work in offline mode due to an error or missing updates.
-  No Wi-Fi icon indicates that your admin has not enabled the entity to use in offline mode.

   ![Available entities for mobile offline](media/available_entites.png "Available entities for mobile offline")
