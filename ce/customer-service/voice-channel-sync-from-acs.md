---
title: "Sync from Azure Communication Services | MicrosoftDocs"
description: "Understand how you can import phone numbers that you purchased or acquired earlier via Azure Communication Services resources into Omnichannel for Customer Service."
ms.date: 06/09/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Sync from Azure Communication Services

You can import phone numbers that you purchased or acquired earlier via Azure Communication Services resources into Omnichannel for Customer Service. 

1. In Dynamics 365, go to one of the admin apps, and perform the following steps. 
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.    
    2. Select **Manage** for **Phone numbers**.
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    In the site map, select **Phone numbers** in **General settings**.
2. Select **Advanced** on the menu.
3. Select **Sync** for **Sync from Azure**. A dialog requesting you to confirm the sync action is displayed.
4. Select **Sync**.

   After you perform the sync, all the phone numbers that were acquired previously are listed on the **Phone numbers** page with the numbers that have been acquired in Omnichannel for Customer Service.

### See also
 
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Disconnect from Azure Communication Services](voice-channel-disconnect-from-acs.md)  
[Integrate a third-party IVR system with voice channel](voice-channel-contextual-transfer-external-ivr.md)  
[Supported cloud locations, languages, and locale codes](voice-channel-region-availability.md)  
[Port a phone number](/azure/communication-services/quickstarts/telephony/port-phone-number)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
