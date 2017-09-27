---
title: "Enable mobile offline synchronization in Dynamics 365 for phones and tablets | MicrosoftDocs"
ms.custom: ""
ms.date: 11/01/2016
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 2208604c-4f7d-448b-bfd9-c5b7163fa351
caps.latest.revision: 7
ms.author: "mkaur"
manager: "brycho"
---
# Enable an enhanced offline experience for your mobile users
You can provide an enhanced offline experience for mobile users if your organization is using [!INCLUDE[pn_crm_8_1_0_online](../includes/pn-crm-8-1-0-online.md)] or later and meets one or both of the following licensing requirements:  
  
-   At least 5 Professional [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] licenses OR  
  
-   At least 1 Enterprise [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] license  
  
> [!NOTE]
>  -   You need to make sure the licenses are assigned to users before you can enable mobile offline synchronization. [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] won’t recognize the licenses if they’re not in use.  
> -   Mobile offline synchronization isn’t available for Trial, Preview, or sandbox [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organizations.  
> -   Offline drafts mode (the existing offline experience) will continue to be available for all users if they aren’t using the new offline capabilities.  
  
#### To enable mobile offline sync  
  
1.  In the web app, go to **Settings > Mobile Offline**. If you don’t see this option, your organization might not meet the requirements for enabling mobile offline synchronization.  
  
2.  Click **Mobile Offline Configuration**.  
  
3.  Click **Continue** to accept the terms of the disclaimer and allow data to be shared with an external system on [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] services.  
  
4.  Select **Enable** and click **Save**. This starts the provisioning process for mobile offline. When it completes, your mobile users will automatically experience the new mobile offline capabilities. Users can opt out by choosing **Settings > Disable Sync** in their mobile app.  
  
> [!WARNING]
>  If your user count falls below 1 Enterprise or 5 Professional licenses, mobile offline synchronization will be disabled for your organization.  
  
> [!IMPORTANT]
> **Recommendation for changing data centers or geo locations**  
>   
>  If you decide to move your org to a different data center or geo location, you need to disable and then enable mobile offline synchronization for your org after the move is complete:  
>   
> 1.  Go to **Settings > Mobile Offline.**  
> 2.  Click **Mobile Offline Configuration**.  
> 3.  Click **Continue**.  
> 4.  Select **Disable**, click **Save**, and then click **OK**. This starts the de-provisioning process. If this option isn’t available, mobile offline synchronization was disabled during the move to a different data center or geo location, and you can continue to the next step. When the de-provisioning is complete, select **Enable**, and then click **Save**.  
  
### See also  
 [Configure mobile offline synchronization](configure-mobile-offline-synchronization-dynamics-365-phones-tablets.md)
