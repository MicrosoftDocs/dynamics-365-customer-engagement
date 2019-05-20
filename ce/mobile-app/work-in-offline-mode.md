---
title: "Work offline on your mobile device (Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
ms.custom: 
ms.date: 05/20/2019
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

# Work offline on your mobile device

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Work with your data even in disconnected mode on your mobile device with mobile offline. The app provides a rich offline experience that lets you work with commands like create, read, update, and delete along with some special commands—so you always stay productive. Once you're back online, changes you've made are synchronized with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  

When your admin has enabled mobile offline, the next time you access the mobile app, you will be prompted to download offline updates. Once you download the updates, you can start using the mobile app in offline mode.

> [!Note]
> - The mobile offline feature is only available for iOS and Android devices.
> - To use the mobile offline feature, download the latest version of the Dynamics 365 for phones and tablet app from the app store. For iOS, version 13.19043.32 or later is supported; for Android, version 4.3.19043.33 or later supported.


<!--Seems like this needs an introductory sentence to explain what the steps are for. Also, is the first line (When you see ...) part of the steps? It isn't numbered like the rest.-->



- When you see the **Offline Updates Available** dialog box, choose **Update**. 

   ![Download updates on your mobile device for mobile offline](media/DownloadUpdates.png "Download updates on your mobile device for mobile offline")

If you choose **Skip for now**, you will not be able to use the app in offline mode unless you download the updates. 

1. To manually download the updates later, select the **ellipses (…)** > **Offline Status**.

  ![Manually download updates](media/downloadupdates_1.png "Manually download updates")

2. On the offline status page, choose **Download Customizations** to download the updates.

  ![Download Customization](media/DownloadCustomization.png "Download Customization")



<!--Should "update" (below) be **Update**? "...on the dialog above..." is confusing. Should it be "... in the dialog box..." ? --> 


3. Once you select update on the dialog above or download customizations from the offline status page, you'll see a progress indicator while the updates are being downloaded. When the download is complete, it's a good idea to verify offline mode is available.

    ![Download updates progress bar](media/downloadingupdatesprogress.png "Download updates progress bar")



<!--Suggest changing this to a heading 2-->

**See if offline mode is available**

When the updates have downloaded, you can check to see if mobile offline is available.

From the nav bar, select ![Dynamics 365 for Customer Engagement apps ellipsis](../mobile-app/media/mobile-ellipsis.png "Dynamics 365 for Customer Engagement apps ellipsis") and then select **Offline Status**.
  
![Mobile Offline Status](../mobile-app/media/OfflineStatusSettings.png "Mobile Offline Status")   

- *Offline Status* tracks the offline status of the whole app, and also the status of each entity individually. When the status shows as  **Available**, it indicates offline is available and data has synced successfully.

   > [!NOTE] 
   > The status here can be **Not Available** due to an error or if you missed downloading offline updates. If the status is **Not Available** due to missing the latest offline updates, then try downloading the updates again.
 
- *Entity Status* provides the offline status of each entity individually. For the available entities, you can also track the last time the entity synced. Data is synced periodically in the background to ensure that you have access to the latest data whenever you go offline.
   
- *Sync time* indicates the last time your data was synced with the server.
 
  ![Mobile offline status](media/OfflineStatus.png "Mobile offline status")
 
You can also track the offline status of entities from the **Menu** ![Menu button](media/MenuButton.png "Menu button") button.

-  A green Wi-Fi icon next to the entity name indicates that it is available in offline mode.
-  A red Wi-Fi icon indicates that this entity is enabled for offline use but is not available to work in offline mode due to an error or missing updates.
-  If no Wi-Fi icon is visible, it means your admin has not enabled the entity to use in offline mode.

   ![Available entities for mobile offline](media/available_entites.png "Available entities for mobile offline")
   


<!--Suggest changing this to a heading 2-->

**Sync conflict resolution**

Based on the settings done by the admin, conflict errors will be resolved. If your admin has set the conflict resolution to **No**, client values win and there will be no sync errors. 

If your admin has set the conflict resolution to **Yes**, server values win. In this case, while syncing changes to the server, you might see some errors that are automatically resolved. Client changes are overwritten by server values.


<!--Suggest changing this to a heading 2-->


**Clear cache from the device**

If you used the mobile app on a phone or tablet temporarily and want to remove all your cached data before giving the device to someone else, you need to reconfigure the app.

- Select ![Dynamics 365 for Customer Engagement apps ellipsis](../mobile-app/media/mobile-ellipsis.png "Dynamics 365 for Customer Engagement apps ellipsis")  > **User Information** > **Reconfigure**. 

Reconfiguring deletes all data and metadata from the cache, though you shouldn't rely on this as a security measure.

<!--Why can't you count on that as a security measure?-->


If you sign out of one organization and sign in to another, and then use the Reconfigure option on the organization you signed in to, your metadata will remain for the organization you signed out of. To remove your metadata from the organization you signed out of, you’ll need to sign in to it and use the Reconfigure option there, as well. 



<!--Suggest changing this to a heading 2-->


**Capabilities available in offline mode**

Dynamics 365 for Customer Engagement for phones and tablets provides the capabilities listed below in offline mode for the end users.

These entities and corresponding commands are available in offline mode.


<!--In the 7th entity below, is "address" supposed to be there twice? In the 12th entity, should it be "Custom" or "Customer"?-->


|Entities |Commands|  
|-------------|---------|  
|Account|	Create, Read, Update, Delete|
|Activity Pointer|Read, Delete|
|Appointment|	Create, Read, Update, Delete, Convert ActivityCase|
|Attachment	|Read only|
|Case|Create, Read, Update, Delete|
|Competitor|Create, Read, Update, Delete	|
|Competitor Address Address|Create, Read, Update, Delete	|
|Connection|Read only|
|Connection Role|Read only|
|Contact|Create, Read, Update, Delete	|
|Currency|Create, Read, Update, Delete|
|Custome Entity|Create, Read, Update, Delete	|
|Email|Read only	|
|Lead|Create, Read, Update, Delete, Qualify/Disqualify	|
|Opportunity|Create, Read, Update, Delete|
|Opportunity Product|Create, Read, Update, Delete	|
|Phone Call|Create, Read, Update, Delete	|
|Position|Create, Read, Update, Delete	|
|Product|Create, Read, Update, Delete|
|Task |Create, Read, Update, Delete|
|Team |Read only	|
|User |Read only	|

**Lookup support**: Lookups are supported for the entities that are mobile offline-enabled. All the entities participating in the lookup should also be offline-enabled.

**Offline views**: Only system views are supported in mobile offline. 

**Offline search**: Available only for offline entities. User can only search one entity at a time. Only categorized search is supported in offline mode and not relevant search.

> [!NOTE]
> The **Date** field is not available for mobile offline search.
   
**Security modeling**: Mobile offline honors the Dynamics 365 for Customer Engagement security model. It also supports the hierarchical security model.


<!--For offline "use"?-->

Field level security and attribute sharing are not supported for offline use.

If a user was working on a record and lost network connection, any updates made to the record are saved in offline mode and will be synchronized to the Customer Engagement app once the user is back online. When the record is synchronized with the app, it follows the filter rule for availability in offline mode.

> [!NOTE]
> - Actions from offline mode are replayed automatically. The changes are played back in the same sequence as they were created, modified, or deleted. This ensures that the data state is maintained and there are no data mismatches on the Dynamics 365 for Customer Engagement app.
> - The org can enhance business functionality available in mobile offline using Xrm.Mobile.offline. For more information, see Xrm.Mobile.offline (client-side reference).

## Known Issues

**Qualify a lead**:

- Users cannot see the qualify button after selecting a lead from the grid. As a workaround, they can open the lead record to qualify. 

- The Qualify button does show up on the lead form, if any custom status codes are added against the qualify state of the lead. 

- When a lead created in mobile offline is qualified and when the user goes online, the business process stage will still show the  qualify stage. The user will have to manually click **Next stage** to move to the next stage.

**Disqualify a lead**: Users will not be able to disqualify a lead in mobile offline. Selecting the Disqualify button from the lead’s grid or from the lead form gives an error.

**Close opportunity**: Users cannot close an opportunity as won or lost from mobile offline. When users select **Close as won** or **Close as lost**, the close dialog will open but the OK and Cancel buttons are disabled. 

**Views** are not supported for the following entities in offline mode: 

- Email

- Task

- Appointment

- Fax

- Phonecall

- Letter

- Serviceappointment

- Campaignresponse

- Campaignactivity

- Recurringappointmentmaster

- Socialactivity

Any views that have linked entities (related entity) that are not available offline are also not supported. 

