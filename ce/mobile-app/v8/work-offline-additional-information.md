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

[!INCLUDE[cc-applies-to-update-8-2-0](../../includes/cc_applies_to_update_8_2_0.md)]

Your [[!INCLUDE[pn-microsoftcrm](../../includes/pn-microsoftcrm.md)] for phones and tablets users aren't always going to be connected to a network. Admins can enable and configure mobile offline so even when no network is available users can still be productive with up-to-date information at hand. 

## Mobile offline capabilities for administrators

[[!INCLUDE[pn-microsoftcrm](../../includes/pn-microsoftcrm.md)] for phones and tablets provides the following for administrators:

- Manage the offline capability for your org by provisioning and deprovisioning it.
- Control the right amount of data for mobile with the following filter capability: 
  - Mobile offline entity filter. Once admins enable an entity for mobile offline, they can set an entity filter to download the data to mobile middleware. 
    Note: if no rules are set on a mobile enabled entity data, users will not have any data available  offline for that entity.
  - Profile definition with filter. Admins can create a profile which will define the data available on user in mobile offline. These filters will be applied on the middleware data set available for your org based on the mobile offline entity filter. Admins must assign the profile to users and publish it, for the profile to become active.
    Note: only the mobile offline enabled entity can be part of the profile.  
    For more information, see [Filter your data for mobile offline usage on Microsoft Dynamics 365](https://blogs.msdn.microsoft.com/crm/2017/07/07/filter-your-data-for-mobile-offline-usage-on-microsoft-dynamics-365/).
- All the data will be downloaded to the mobile client based on user security access.
- If a user is following a record in [!INCLUDE [pn-crm-2016](../../includes/pn-crm-2016.md)] and the corresponding entity is part of the profile, then the record will be available to the user when offline. If the user stops following the record, it will be removed from offline in the mobile client.

## Mobile offline capabilities for end users

[[!INCLUDE[pn-microsoftcrm](../../includes/pn-microsoftcrm.md)] for phones and tablets provides the following for end users:
 
- Offline enabled entities: [[!INCLUDE[pn-microsoftcrm](../../includes/pn-microsoftcrm.md)] mobile-enabled entities can be enabled for mobile offline. 
  - Users can perform create, read, update, and delete (CRUD) operations on entities when offline based on the [[!INCLUDE[pn-microsoftcrm](../../includes/pn-microsoftcrm.md)] security model. 
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
  - Mobile offline honors the [[!INCLUDE[pn-microsoftcrm](../../includes/pn-microsoftcrm.md)] security model. It also supports the hierarchical security model.  
  - Field level security and attribute sharing are not supported for offline. 
- If user was working on a record and loose the network connection, the updates on the record will be saved in the offline mode and will be synchronized to [[!INCLUDE[pn-microsoftcrm](../../includes/pn-microsoftcrm.md)] once the user goes back online. The record, once synchronized to [[!INCLUDE[pn-microsoftcrm](../../includes/pn-microsoftcrm.md)], will follow the filter rule for availability in offline mode. 

For more information, see [Work offline in Dynamics 365 for phones and tablets](https://technet.microsoft.com/library/mt812230.aspx).

For a list of entities supported in mobile offline, see [Entities displayed in Dynamics 365 for phones and tablets](https://technet.microsoft.com/library/dn531159.aspx#Entities displayed in Dynamics 365 for phones and tablets).

## Other offline capabilities

- Offline data is refreshed periodically. Duration of the refresh depends on the mobile offline profile and amount of data that is enabled for offline.
- Automatic replay for offline actions. All the data created or modified by user in offline are replayed to [[!INCLUDE[pn-microsoftcrm](../../includes/pn-microsoftcrm.md)]  automatically without user intervention. 
- Actions are replayed from the offline sync in queue. The changes are played back in the same sequence as they were created/modified/ deleted. This ensure that the data state is maintained and there are no data mismatch on [[!INCLUDE[pn-microsoftcrm](../../includes/pn-microsoftcrm.md)]. 
- Mobile offline supports conflict detection and error resolution. Conflict error for any update and delete will be detected and users can resolve the error in the  [[!INCLUDE[pn-microsoftcrm](../../includes/pn-microsoftcrm.md)] web client and on the mobile client. Any other errors created in offline will also be available for users to edit and resubmit. 
- The org can enhance business functionality available in mobile offline using Xrm.Mobile.offline. For more information, see [Xrm.Mobile.offline (client-side reference)](https://msdn.microsoft.com/en-us/library/mt787123.aspx).

### Mobile offline blogs

- Feature overview: [The new full offline experience with mobile Dynamics CRM apps](https://blogs.technet.microsoft.com/lystavlen/2016/04/21/the-new-full-offline-experience-with-mobile-dynamics-crm-apps/)
- Filtering in mobile offline: [Filter your data for mobile offline usage on Microsoft Dynamics 365](https://blogs.msdn.microsoft.com/crm/2017/07/07/filter-your-data-for-mobile-offline-usage-on-microsoft-dynamics-365/)

### Mobile offline videos

- [Working offline with Dynamics 365](https://youtu.be/V-eIlZ04zQE)
- [Microsoft Dynamics CRM Online 2016 Update 1 New Features- Mobile Offline](https://youtu.be/GMlm3pnr-Z0)

## Work in disconnected mode with Dynamics 365 for phones and tablets 

### Download App Updates for offline 

### Offline Sync Status 

#### Status on footer

#### Status flyout 

#### Last Sync Time 

#### Status on sitemap 

### Offline data

### Offline indicator

### Working in offline mode

### Automatic playback

### Conflict resolution

### Background sync

## Support matrix














