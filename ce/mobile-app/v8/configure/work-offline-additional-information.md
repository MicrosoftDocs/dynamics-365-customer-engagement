---
title: "Work offline with Dynamics 365 for phones and tablets - additional information | MicrosoftDocs"
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
ms.assetid: 2069f1bb-9f35-4cdf-855c-318da477ba84
caps.latest.revision: 7
ms.author: "jimholtz"
manager: "brycho"
---
# Work offline with Dynamics 365 for phones and tablets - additional information

[!INCLUDE[cc-applies-to-update-8-2-0](../../../includes/cc_applies_to_update_8_2_0.md)]

Your [!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)] for phones and tablets users aren't always going to be connected to a network. Admins can enable and configure mobile offline so even when no network is available users can still be productive with up-to-date information at hand. 

## Mobile offline capabilities for administrators

[!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)] for phones and tablets provides the following for administrators:

- Manage the offline capability for your org by provisioning and deprovisioning it.
- Control the right amount of data for mobile with the following filter capability: 
  - Mobile offline entity filter. Once admins enable an entity for mobile offline, they can set an entity filter to download the data to mobile middleware. 
    Note: if no rules are set on a mobile enabled entity data, users will not have any data available  offline for that entity.
  - Profile definition with filter. Admins can create a profile which will define the data available on user in mobile offline. These filters will be applied on the middleware data set available for your org based on the mobile offline entity filter. Admins must assign the profile to users and publish it, for the profile to become active.
    Note: only the mobile offline enabled entity can be part of the profile.  
    For more information, see [Filter your data for mobile offline usage on Microsoft Dynamics 365](https://blogs.msdn.microsoft.com/crm/2017/07/07/filter-your-data-for-mobile-offline-usage-on-microsoft-dynamics-365/).
- All the data will be downloaded to the mobile client based on user security access.
- If a user is following a record in [!INCLUDE [pn-crm-2016](../../../includes/pn-crm-2016.md)] and the corresponding entity is part of the profile, then the record will be available to the user when offline. If the user stops following the record, it will be removed from offline in the mobile client.

## Mobile offline capabilities for end users

[!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)] for phones and tablets provides the following for end users:
 
- Offline enabled entities: [!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)] mobile-enabled entities can be enabled for mobile offline. 
  - Users can perform create, read, update, and delete (CRUD) operations on entities when offline based on the [!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)] security model. 
  - Business process flows are supported in offline mode. Users can move the business process stage when offline for a single entity. 
  - Business process flows with multiple entities or business process flows with child processes are not supported. 
  - Other than create, read, update, and delete operations in offline mode, users can perform before commands:
    -  Business process: Next/Previous stage commands, Set Active commands
    -  Lead entity: Qualify and Disqualify commands 
    -  Opportunity entity: Command to perform Close as won\lost  
    -  Case entity: Command to Resolve case 
    -  Activity: Convert to opportunity command, Close activity through ‘Mark Complete’ command in Activity form and Activity Grid
- Lookup supported to offline records: Look up are supported for the entities that are mobile offline enabled.  All the entities participating in the lookup should be mobile offline enabled. 
- Offline views: Only system views are supported in mobile offline. There are limitation of Views supported in offline.
- Offline search:
  - Available only for offline entities. User can only search one entity at a time. Only categorized search is supported in offline and not relevant search.
  - Date field not available for mobile offline search. 
- Security modelling:
  - Mobile offline honors the [!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)] security model. It also supports the hierarchical security model.  
  - Field level security and attribute sharing are not supported for offline. 
- If user was working on a record and loose the network connection, the updates on the record will be saved in the offline mode and will be synchronized to [!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)] once the user goes back online. The record, once synchronized to [!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)], will follow the filter rule for availability in offline mode. 

For more information, see [Work offline in Dynamics 365 for phones and tablets](https://technet.microsoft.com/library/mt812230.aspx).

For a list of entities supported in mobile offline, see [Entities displayed in Dynamics 365 for phones and tablets](https://technet.microsoft.com/library/dn531159.aspx#Entities displayed in Dynamics 365 for phones and tablets).

## Other offline capabilities

- Offline data is refreshed periodically. Duration of the refresh depends on the mobile offline profile and amount of data that is enabled for offline.
- Automatic replay for offline actions. All the data created or modified by user in offline are replayed to [!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)]  automatically without user intervention. 
- Actions are replayed from the offline synchronization in queue. The changes are played back in the same sequence as they were created/modified/ deleted. This ensure that the data state is maintained and there are no data mismatch on [!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)]. 
- Mobile offline supports conflict detection and error resolution. Conflict error for any update and delete will be detected and users can resolve the error in the  [!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)] web client and on the mobile client. Any other errors created in offline will also be available for users to edit and resubmit. 
- The org can enhance business functionality available in mobile offline using Xrm.Mobile.offline. For more information, see [Xrm.Mobile.offline (client-side reference)](https://msdn.microsoft.com/en-us/library/mt787123.aspx).

### Mobile offline blogs

- Feature overview: [The new full offline experience with mobile Dynamics CRM apps](https://blogs.technet.microsoft.com/lystavlen/2016/04/21/the-new-full-offline-experience-with-mobile-dynamics-crm-apps/)
- Filtering in mobile offline: [Filter your data for mobile offline usage on Microsoft Dynamics 365](https://blogs.msdn.microsoft.com/crm/2017/07/07/filter-your-data-for-mobile-offline-usage-on-microsoft-dynamics-365/)

### Mobile offline videos

- [Working offline with Dynamics 365](https://youtu.be/V-eIlZ04zQE)
- [Microsoft Dynamics CRM Online 2016 Update 1 New Features- Mobile Offline](https://youtu.be/GMlm3pnr-Z0)

## Work in disconnected mode with Dynamics 365 for phones and tablets 

You can continue to work in the mobile apps when the device is disconnected from the internet when you've enabled mobile offline synchronization.

With mobile offline synchronization enabled, the app provides a rich offline experience. You can work with all the basic commands like create, read, update, delete in addition to certain business processes. Upon reconnecting, these offline changes will be automatically synchronize to Dynamics 365. The data is periodically synchronized from Dynamics 365 to your device for offline usage based on the sync profile configured by administrator.  

### Download app updates for offline 

When you log onto the Dynamics 365 mobile app, you will see the list of app modules that you have access to. When you navigate to any app module that your admin has configured for offline, you'll receive a prompt to download these config updates to setup your app to work in offline mode.  

### Offline synchronization status 

#### Status on footer

To verify offline synchronization is enabled on your app look at the offline synchronization status in the footer of the app. The status also lets you know the entities that are available in offline and, for each of these available entities, when the data is last synchronized with Dynamics 365.  

![Status on footer](../../media/offline-status.png "Status on footer")

The following table lists the various status icons and what they mean.

|Mobile offline synchronization status icon |Status |Description  |
|---------|---------|---------|
|![Available](../../media/green-icon.png "Available")     |Available         |Offline synchronization is available as the device database is available.         |
|![Available warning ](../../media/green-icon-exclamation.png "Available warning")     |Available          |Warning due to metadata mismatch. You can tap on the link in the status to download the metadata if it's pending from Dynamics 365.|
|![Not available](../../media/red-icon.png "Not available")     |Initializing         |Offline database is being setup.         |
|![Not available](../../media/red-icon.png "Not available")      |Not available         |Offline synchronization is not available as the database is not created on your mobile device.        |
|![Not available warning](../../media/red-icon-exclamation.png)     |Not available         |Offline synchronization is not available. A background fix is in process.          |
|![Not available](../../media/red-icon.png "Not available")      |Error         |The database is not available.         |

> [!NOTE]
> If there is no status in the footer, offline synchronization is not enabled for your app or the user has not been added to the mobile offline profile.

#### Status flyout 

You can check the reason for the offline synchronization status by clicking on this status. This opens a flyout which shows the number of entities enabled for offline along with status reasons, if any. 

| |  |
|---------|---------|
|![Number of entities enabled](../../media/flyout-entities-enabled.png "[Number of entities enabled")     |![Status reasons](../../media/flyout-status-reasons.png "Status reasons")         |

#### Last Sync Time 

For offline available entities, when you navigate to the entities grid or form, you can check in the footer when data is last synchronized with Dynamics 365.

![Last sync time](../../media/last-sync-time.png "Last sync time")

#### Status on sitemap 

You can also check the status of entities enabled for offline on the sitemap. A vertical rectangle on right side of the entity’s image represents the offline status.  

- Green – entity is enabled for offline and is available to work in when offline 
- Red – entity is enabled for offline but is not available to work in when offline due to an error
- No rectangle – entity is not enabled for offline  

![Status on sitemap](../../media/status-on-sitemap.png "Status on sitemap")

### Offline data

Users will have the following data in offline mode:
- Data of all available entities as per the filters defined by admin in the profile. 
- Any records of offline available entities that you follow on Dynamics 365 will be available in when offline. 
- Any records of offline available entities that you are working on when you lose the connectivity will be available when offline, and you can continue working on these records. The changes in these records will be synchronized to Dynamics 365 when you reconnect and will be available when offline again as per your filters.    

### Offline indicator

As soon as the application is disconnected from the server you will see an indication on the application that it is offline. Once you have reconnected to your phone service or internet, tap this offline indicator to reconnect to Dynamics 365.

| |  |
|---------|---------|
|![Tap offline](../../media/tap-offline.png "Tap offline")     |![Tap reconnect](../../media/tap-reconnect.png "Tap reconnect")         |
  
### Working in offline mode

You can seamlessly work in offline mode with all available entities. In offline mode you have support for:

- Create, read, update, and delete (CRUD) actions
- Business processes:
  -  Next Stage 
  - Previous Stage 
  - Set Active
- Commands 
  - Lead – Qualify\Disqualify 
  - Opportunity – Close as won\lost 
  - Case – Resolve 
  - Activity – Convert to opportunity  
  - Close activity through Mark Complete command in Activity form and Activity grid.  
- Entity Views 
- Search 
- Lookup for offline records 

> [!NOTE]
> See [Dynamics 365 Customer Engagement Readme / Known Issues](../../../admin/readme-9.md#mobile-offline) to understand limitations in offline mode.

Watch a short [video](https://go.microsoft.com/fwlink/p/?linkid=837630) (3:06) about working offline with Dynamics 365. 

### Automatic playback

On reconnecting to the Dynamics 365, all offline actions are automatically played back to the Dynamics 365. Any errors during this automatic play back are captured and stored in the Sync Error entity.  

### Conflict resolution

### Background sync

## Support matrix














