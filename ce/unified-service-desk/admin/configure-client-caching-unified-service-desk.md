---
title: "Configure client caching in Unified Service Desk for Dynamics 365 Customer Engagement | MicrosoftDocs"
description: "Learn how to set client caching."
ms.custom:
  - dyn365-USD, dyn365-admin
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: 4aab0a03-2d52-4ced-b6cf-9694d1edbdb7
caps.latest.revision: 6
author: kabala123
ms.author: kabala
manager: sakudes
tags: 
 - "MigrationHO"
---
# Client caching overview
Client caching enables you to reduce the amount of bandwidth required at the startup of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client on the call center agent’s computers, and over the life cycle of the client application. Client caching provides a means to cache the majority of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration data locally on the call center agent’s computer, thereby reducing the need for common data to be retrieved from the server. This capability provides a noticeable increase in the startup performance of [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].  
  
> [!IMPORTANT]
>  This feature has privacy impact because enabling client caching in [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] leads to some of your data being stored locally on the user’s computer, which is outside the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] services boundary.  
  
<a name="WhenToUse"></a>   
## When should you use client caching?  
 Client caching can provide a significant improvement in startup times, a reduction in overall bandwidth, and a significant reduction in queries to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server for common [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] data.  
  
 Client caching is best employed in performance testing, training, and production environments. It isn’t recommended for development environments because changes are only replicated when the control cache key is updated.  
  
<a name="HowItWorks"></a>   
## How client caching works  
 When you enable client caching, the following process is executed when you log on using the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application:  
  
1.  The **Options** and **User Settings** entities are queried for the startup keys to determine if client caching is enabled.  
  
2.  If it is enabled, resolve client cache version number and any cache modifications.  
  
3.  If client caching is enabled and a version number is available, locate the local cache store and determine the cache version key.  
  
    1.  If cache version number is current, decrypt and load the cache store into memory.  
  
    2.  If the cache version number is incorrect, delete the cache object.  
  
<a name="EnableCaching"></a>   
## Enable client caching  
  
1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]  
  
3. Click **Options**.  
  
4. Click **New** on the command bar to create a new option.  
  
5. For the new option, type **ClientCacheVersionNumber** in the **Name** box, and an alphanumeric number in the **Value** box. The alphanumeric value is used as the cache key for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].  
  
6. Click **Save**.  
  
   When the option is present and populated, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] will activate the client caching.  
  
<a name="CachingStoreLocation"></a>   
## Client caching store location  
 When enabled, client caching stores its files in a compressed and encrypted format in the users roaming directory: %appData%\Microsoft\USD  
  
 For example, for a user called agent1 running the client application on [!INCLUDE[pn_windows8](../../includes/pn-windows8.md)], the client caching files will be available at c:\Users\agent1\AppData\Roaming\Microsoft\USD.  
  
 Information in this directory can only be accessed by the user account that created it.  
  
<a name="PushUpdatetoAllClients"></a>   
## Push an update to clients  
 To push an update to all the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] clients, you must edit the value of the **ClientCacheVersionNumber** that you created earlier to a different alphanumeric value. Next time when a call center agent logs in using the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client, it will detect the different value for the **ClientCacheVersionNumber** option key, and read all settings from the server before starting up.  
  
<a name="DisableClientCachingforUser"></a>   
## Disable client caching for a specific user  
 At times it may be necessary to exclude some users from client caching such as limited testing of new configurations in production, production, or troubleshooting where a cache problem is suspected, or the need to do rapid updates to a configuration where you want to revert your changes back to the currently cached objects.  
  
1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]  
  
3. Click **User Settings**.  
  
4. Click **New** on the command bar to create a new setting.  
  
5. On the **New User Setting** page:  
  
   1.  In the **User** field, type or select the name of the user for which you want to disable client caching.  
  
   2.  In the **Name** field, type **DisableCaching**. Leave the **Value** field empty.  
  
   ![Disable client caching for a user](../../unified-service-desk/media/usd-disable-client-caching-user.PNG "Disable client caching for a user")  
  
6. Click **Save**.  
  
   When the user next signs in using the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client, client caching isn’t used. However, it doesn’t delete or refresh the client cache store for the user. When the **DisableCaching** key is removed for the user, the user will return to using the previously stored client cache store.  
  
<a name="ForceCacheReset"></a>   
## Force a cache reset for a specific user  
 At times, it may be necessary to force a cache reset for a specific user to clear and reset the cache store. You can do this in two ways: From the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server or by using the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application on the user’s computer.  
  
<a name="UsingCRMServer"></a>   
### Using the Dynamics 365 Server  
  
1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]  
  
3. Click **User Settings**.  
  
4. Click **New** on the command bar to create a new setting.  
  
5. On the **New User Setting** page:  
  
   1.  In the **User** field, type or select the name of the user that you want to disable client caching for.  
  
   2.  In the **Name** field, type **ResetDesktopCache**. Leave the **Value** field empty.  
  
6. Click **Save**.  
  
   The ResetDesktopCache setting causes the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application to delete its local cache store and rebuild it from the server.  
  
   To complete the cache reset process, two restarts of the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client are required.  
  
7. After the first [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application restart, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client loads data from the existing cache. Afterwards, the existing cache is deleted and the ResetDesktopCache setting is disabled.  
  
8. After the second [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application restart, the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client loads the configuration directly from the server and re-creates the cache.  Notice that the time it takes for the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client to load during this time can increase significantly.  
  
### Using the Unified Service Desk client  
 You can invoke a reset from the client application using a hidden UII action called **ResetLocalCache** on the **Global Manager** hosted control type. You’ll need to create the UII action on the Global Manager hosted control type before you can use it.  
  
1. Sign in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)].  
  
2. [!INCLUDE[proc_settings_usd](../../includes/proc-settings-usd.md)]  
  
3. Click **Hosted Controls**.  
  
4. Locate the **Dynamics 365 Global Manager** hosted control, and click its name in the **Name** column to open it for editing.  
  
   > [!NOTE]
   > **Dynamics 365 Global Manager** is the name of the hosted control in the sample [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] applications. If you have named your Global Manager hosted control something else, select it instead. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Global Manager (Hosted Control)](../../unified-service-desk/global-manager-hosted-control.md)  
  
5. On the nav bar, click the down arrow next to the **Dynamics 365 Global Manager** hosted control, and then select **UII Actions**.  
  
   ![Navigation to UII Actions for hosted control](../../unified-service-desk/media/usd-hosted-contro-uii-action.png "Navigation to UII Actions for hosted control")  
  
6. On the next page, click **Add New UII Action**.  
  
7. On the **New UII Action** page, type **ResetLocalCache** in the **Name** field, and then click **Save**. Close the UII Action and the hosted control.  
  
    Next, we will add an action call to call the UII action that we just created.  
  
8. On the nav bar, click **Settings** > **Unified Service Desk** > **Action Calls**.  
  
9. On the action calls page, Click **New**.  
  
10. On the **New Action Call** page:  
  
    1. In the **Name** field, type **ResetClientCache**.  
  
    2. In the **Hosted Control** field, specify the **Dynamics 365 Global Manager**.  
  
       > [!NOTE]
       > **Dynamics 365 Global Manager** is the name of the hosted control in the sample [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] applications. If you have named your Global Manager hosted control something else, select it instead. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Global Manager (Hosted Control)](../../unified-service-desk/global-manager-hosted-control.md)  
  
    3. In the **Action** field, specify **ResetLocalCache**.  
  
11. Click **Save** and then close the action call.  
  
    After you have set up the UII action and the action call, you can add a toolbar button, event, or code to directly invoke the action call from the client application. This creates a **RestDesktopCache** setting in the **User Settings** area, which triggers the reset behavior as described earlier in [Using the Dynamics 365 Server](../../unified-service-desk/admin/configure-client-caching-unified-service-desk.md#UsingCRMServer).  
  
## See also  
 [Sample Unified Service Desk applications](../../unified-service-desk/admin/sample-unified-service-desk-applications.md)   
 [Administer and manage Unified Service Desk](../../unified-service-desk/admin/administer-manage-unified-service-desk.md)   
 [Add a UII action to a hosted control](../../unified-service-desk/add-uii-action-hosted-control.md)   
 
