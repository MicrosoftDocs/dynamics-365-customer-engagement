---
title: "Work offline in Dynamics 365 for phones and tablets | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-11-01"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
  - "Dynamics CRM Online"
author: "jimholtz"
ms.assetid: b1055e07-8868-4a79-a1c4-699ffa7a649f
caps.latest.revision: 67
ms.author: "mkaur"
manager: "brycho"
---
# Work offline in Dynamics 365 for phones and tablets
horizontaltabbed  
  
### Offline synchronization vs. Offline drafts  
 You’ll have one of two possible offline experiences, depending on which one your admin set up:  
  
-   **Seamless mobile offline synchronization**. You can view, edit, and create records while you're disconnected from the Internet. Once you're back online, changes you've made are synchronized with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
     \- OR -  
  
-   **Offline drafts**. This experience is available to everyone. In this case, the app keeps records you’ve used recently, so you can still access them when you’re disconnected.  
  
     You can also capture new information by creating drafts of new records - like accounts, contacts, and activities - and save the records the next time you go online.  
  
     Your offline experience might look a little different than your online experience, because charts and some images aren’t available offline.  
  
 [Watch a short video (3:06) about working offline with Dynamics 365](https://go.microsoft.com/fwlink/p/?linkid=837630).  
  
<a name="bkmk1"></a>   
##### Working with offline drafts  
 You can view and create records offline and save them as drafts. Once you’re reconnected, save them as soon as you can. Unsaved drafts are available only on your mobile device.  
  
1.  From the menu, tap **Draft Records**.  
  
     ![Dynamics Dynamics 365 for phones save offline drafts](../mobile-imports/media/mobile-offline-save-drafts.png "Dynamics Dynamics 365 for phones save offline drafts")  
  
2.  Select each record individually and tap **Save**.  
  
###### A few things to note about offline drafts  
  
-   While offline, you can only create and edit new records. To edit existing records, you need to be connected.  
  
-   While offline, you can only create standalone records or associate records to those that are available for offline access on your device. For example, you can create an opportunity for an account only if that account was created before you went offline, and if it’s available for offline access. You can’t create an opportunity for an account while offline if you also created the account while offline.  
  
-   While offline, you can’t set the value for lookup fields. If you create a record that is associated with another record, such as adding a phone call to a contact, some lookup fields might populate automatically (in this case, the To and From fields might pre-populate). You need to fill these fields in once you re-connect while you review and save your drafts.  
  
###### About cached data  
 The records you’ve recently used are kept on your mobile device, and are also known as cached data. Cached data is specific to your device, so if you use both the phone and tablet apps, the cached data on each device will be different, depending on the records you’ve viewed on each one.  
  
> [!WARNING]
>  Cached data is not encrypted. You can use BitLocker to encrypt the entire hard drive on a [!INCLUDE[pn_windows8](../includes/pn-windows8.md)] or [!INCLUDE[pn_windows_10](../includes/pn-windows-10.md)] device.  
  
<a name="bkmk2"></a>   
###### If you’re prompted to sign in while you’re disconnected  
 If you’re prompted to sign in while you’re offline, tap the **Back** button on the sign-in page and you’ll still be able to work in offline mode on [!INCLUDE[tn_ipad](../includes/tn-ipad.md)] and [!INCLUDE[pn_windows8](../includes/pn-windows8.md)] tablets until you can reconnect. On all other phones and [!INCLUDE[tn_android](../includes/tn-android.md)] tablets, however, you can no longer work in offline mode and will be redirected to the **Let’s get started** page until you can reconnect and sign in again.  
  
<a name="bkmk3"></a>   
###### Working offline with on-premises  deployments  
 If you’re using the mobile app with [!INCLUDE[pn_crm_2015](../includes/pn-crm-2015.md)] (on-premises) or later, you can continue to use [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] while disconnected. However, with the [!INCLUDE[pn_windows8](../includes/pn-windows8.md)] app, once you close the app (like when you start another app), you can’t use it until you can connect to the Internet. With the [!INCLUDE[pn_windows_8_1](../includes/pn-windows-8-1.md)] app, you can continue to access your data even if you close the app. If you’re not sure whether your organization has an on-premises deployment, contact your Dynamics 365 admin to find out.  
  
 Note that offline synchronization is not supported by on-premises deployments.  
  
<a name="bkmk1BGS"></a>   
##### Background sync  
 Background sync is enabled even when the app is minimized so long as a network connection is detected. But when the app is in the background, metadata changes will not be accepted automatically. When you bring the app to the foreground, you will be prompted to accept the metadata changes.  
  
 **About background sync:**  
  
-   Sync will run until you  sign in to the mobile app.  
  
-   While the app is running in the background, sync is automatically enabled   when a network is detected .  
  
-   While the app is running in the background, sync is automatically disabled when a network is disabled  
  
-   When you bring the app to the  foreground, regular sync is detected and enabled.  
  
-   Background sync is disabled when the device is locked and enabled when the device is unlocked.  
  
-   While the app is running in the background,  metadata changes will not be accepted automatically. The mobile app will stop the background sync.  
  
-   When you bring the app to the  foreground, you are prompted to accept the metadata changes.  
  
-   While the app is running in the foreground, after metadata is updated, the app will switch to regular sync.  
  
 Background sync will be disabled if:  
  
-   Your user token expires in the background.  
  
-   The application closes for some reason.  
  
-   Your device locks.  
  
 Background sync is available on all supported devices. See [TechNet: Support for Dynamics 365 for phones and Dynamics 365 for tablets](https://technet.microsoft.com/library/dn531131.aspx).  
  
<a name="bkmkSyncConfRes"></a>   
##### Sync conflict resolution  
 If multiple entries are made in the same field by offline users (for example, two or more “close by” dates), the conflict is clearly marked and you can choose the correct entry.  
  
 If a record has changed on the server between the time your device retrieved the record and when it tries to update or delete that record,   you'll see an exclamation mark   ("!”) by the relevant field, and will need to resubmit your  updated changes.  
  
<a name="bkmk_EnhancedSyncFilters"></a>   
##### Enhanced sync filters  
 Admins  can choose what information to sync to user's devices. This can help minimize impact to user's device's memory.  
  
> [!NOTE]
>  Make sure that you’re using the latest version of the mobile app For Advanced Filters to work offline.  
  
 Admins can define a custom filter based on the following rules. You can create filters up to three levels.  
  
||  
|-|  
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
  
### Reconnect to go back online  
 Once you have phone service or Internet again, tap the offline indicator on your device to reconnect.  
  
 ![Offline indicator: tap to reconnect](../mobile-imports/media/mobile-offline-indicator.png "Offline indicator: tap to reconnect")  
  
 You’ll need to save your drafts to make them available in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
### For admins: Enhanced sync status for provisioning  
 **About enhanced sync status:**  
  
-   Admins can see the status of provisioning and de-provisioning.  
  
-   The mobile offline configuration page is auto-refreshed at regular intervals to show updated status messages during provisioning and de-provisioning.  
  
-   You can stop provisioning at any stage during provisioning.  
  
-   You can de-provision your organization only when the provisioning is complete.  
  
-   De-provisioning of an organization can't be stopped once initiated.  
  
-   You can initiate provisioning again only when de-provisioning is complete.  
  
-   In  case of a provisioning or de-provisioning failure, consider retrying your provisioning before contacting support.  
  
-   All the provisioning and de-provisioning messages will be shown on the mobile offline configuration page along with the date and timestamp of when the status was last checked.  
  
## See Also  
 [Dynamics 365 for Phones and Tablets User's Guide](../mobile-imports/dynamics-365-phones-tablets-users-guide.md)