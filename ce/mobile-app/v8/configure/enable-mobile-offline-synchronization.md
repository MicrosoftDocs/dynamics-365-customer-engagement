---
title: "Enable mobile offline synchronization for Dynamics 365 for phones and tablets | MicrosoftDocs"
ms.custom: 
ms.date: 12/18/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 19eb9378-3eb0-4964-98d8-5c674a0c746b
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
# Enable mobile offline synchronization

Enable mobile offline synchronization so users can stay productive wherever they are.
  
1. In the web app, go to **Settings > Mobile Offline**. If you don’t see this option, your organization might not meet the requirements for enabling mobile offline synchronization.  
  
2. Click **Mobile Offline Configuration**.  
  
3. Click **Continue** to accept the terms of the disclaimer and allow data to be shared with an external system on [!INCLUDE[pn-azure-shortest](../../../includes/pn-azure-shortest.md)] services.  
  
4. Select **Enable** and click **Save**. This starts the provisioning process for mobile offline. When it completes, your mobile users will automatically experience the new mobile offline capabilities. Users can opt out by choosing **Settings > Disable Sync** in their mobile app.  
  
> [!WARNING]
>  If your user count falls below 1 Enterprise or 5 Professional licenses, mobile offline synchronization will be disabled for your organization.  
  
> [!IMPORTANT]
>  **Recommendation for changing data centers or geo locations**  
>   
>  If you decide to move your org to a different data center or geo location, you need to disable and then enable mobile offline synchronization for your org after the move is complete:  
>   
> 1.  Go to **Settings > Mobile Offline.**  
> 2.  Click **Mobile Offline Configuration**.  
> 3.  Click **Continue**.  
> 4.  Select **Disable**, click **Save**, and then click **OK**. This starts the de-provisioning process. If this option isn’t available, mobile offline synchronization was disabled during the move to a different data center or geo location, and you can continue to the next step. When the de-provisioning is complete, select **Enable**, and then click **Save**.  
  
