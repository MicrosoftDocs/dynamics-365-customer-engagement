---
title: "Configure mobile offline synchronization for Dynamics 365 for phones and tablets | MicrosoftDocs"
ms.custom: 
ms.date: 12/18/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 720cf240-721d-48a0-bfc8-43afb1e1ba7c
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
# Configure mobile offline synchronization 

You can provide an enhanced offline experience for mobile users if your organization is using [!INCLUDE[pn-crm-8-1-0-online](../../../includes/pn-crm-8-1-0-online.md)]and meets one or both of the following licensing requirements:  
  
- At least 5 Professional [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] licenses OR  
  
- At least 1 Enterprise [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] license  
  
> [!NOTE]
>  Keep the following in mind when enabling mobile offline synchronization:  
> 
> - You need to make sure the licenses are assigned to a user before you can enable mobile offline synchronization. [!INCLUDE[pn-crm-shortest](../../../includes/pn-crm-shortest.md)] won’t recognize the licenses if they’re not in use.  
> - Mobile offline synchronization isn’t available for Trial, Preview  or sandbox [!INCLUDE[pn-crm-shortest](../../../includes/pn-crm-shortest.md)] organizations.  
> - Offline drafts mode (the existing offline experience) will continue to be available for all users if they aren’t using the new offline capabilities.  
  
 This offline experience uses [!INCLUDE[pn-windows-azure](../../../includes/pn-windows-azure.md)]  services to periodically synchronize entities with the [!INCLUDE[pn-microsoftcrm](../../../includes/pn-microsoftcrm.md)] for phones and tablets apps so synchronized records are available when users’ mobile devices are disconnected. To enable mobile offline synchronization in an eligible organization, you need to do the following:  
  
> [!NOTE]
> A user must have a security role that has Read permissions on the mobile offline profile to be able to use their mobile device in offline mode.

1. [Enable mobile offline synchronization](../../../mobile-app/v8/configure/enable-mobile-offline-synchronization.md)  
  
2. [Enable entities for mobile offline synchronization](../../../mobile-app/v8/configure/enable-entities-mobile-offline-synchronization.md)  
  
3. [Create a mobile offline profile](../../../mobile-app/v8/configure/create-mobile-offline-profile.md)  
  
4. [Add users to a mobile offline profile](../../../mobile-app/v8/configure/add-users-mobile-offline-profile.md)  
  
5. [Publish a mobile offline profile](../../../mobile-app/v8/configure/publish-mobile-offline-profile.md)  
  
   Here are a few things to keep in mind about mobile offline synchronization:  
  
- Mobile offline synchronization with mobile devices occurs periodically. A synchronization cycle could last for several minutes, depending on [!INCLUDE[pn-azure-shortest](../../../includes/pn-azure-shortest.md)] network latency, the volume of data that’s set for synchronization, and mobile network speed. Users can still use the mobile apps during synchronization.  
  
- Changes to a user’s security privileges are updated during the next synchronization cycle. Until that time, users can still continue accessing data according to their previous security privileges, but any changes they make will be validated during the synchronization to the [!INCLUDE[pn-crm-shortest](../../../includes/pn-crm-shortest.md)] server. If they no longer have privileges to make changes for a record, they will receive an error and the record won’t be created, updated, or deleted.  
  
- Any changes to a user’s privilege to view a record won’t take effect on the mobile device until the next synchronization cycle.  
  
> [!NOTE]
>  Once you’ve enabled mobile offline synchronization, metadata changes are pushed to the mobile apps when the changes are published, not just on app start-up. To keep mobile offline synchronization up-to-date, users should always accept the prompt to download metadata changes.  
  
