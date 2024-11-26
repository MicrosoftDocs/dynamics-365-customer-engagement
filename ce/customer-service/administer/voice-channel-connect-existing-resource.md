---
title: Connect using an existing Azure resource
description: Learn how to connect your voice and SMS channels to Azure Communication Services using an existing Azure resource.
ms.date: 08/26/2024
ms.custom: bap-template
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
---

# Connect using an existing Azure resource

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[azure-ad-rename](../../includes/cc-azure-ad-rename.md)]

You can connect your voice or SMS channels to Azure Communication Services using an existing Azure resource from any of your Azure subscriptions within the same tenant. If you disconnected a resource and want to use it now, you can do so using this option.

## Prerequisites

- The organization that you're using isn't a trial version.
- The **Get started** button that connects to an existing Azure resource is visible on the **Phone numbers** page of Customer Service admin center or Contact Center admin center. The **Get Started** button appears only when:
  - The trial ended after the free calling time elapsed.
  - You manually [ended the trial](voice-channel-trial-phone-numbers.md#end-the-trial).
  - You [disconnected from the Azure resource](voice-channel-disconnect-from-acs.md). 
- Your active Azure subscription is in the same tenant as your Dynamics 365 account in the enhanced voice experience.
- Your role has **Contributor** privileges.

### Get Azure resource information

Before you connect an existing Azure resource to Azure Communication Services, you must retrieve the following information from the [Azure portal](https://ms.portal.azure.com/):

1. Go to **Resource groups** and select the required resource group where your Azure Communication Services resource is located.
 
   :::image type="content" source="../media/acs-resource-existing-mini.png" alt-text="image showing how to add a resource" lightbox="../media/acs-existing-resource.png":::
   
1. Select **Properties** in **Settings**.
1. On the **Properties** page, copy the **Name** and **Resource ID** field values, which you must specify as **ACS Resource Name** and **ACS Resource ID** values in Customer Service admin center or Contact Center admin center.
   :::image type="content" source="../media/acs-property-records-mini.png" alt-text="image showing the resource id values" lightbox="../media/acs-property-records.png":::
   
1. Find the Communication Service for the Resource Group, and then select **Keys in Settings**.
1. On the **Keys**, copy the **Connection string** in **Primary key**. You use this value as the value of **Connection string** in Customer Service admin center or Contact Center admin center.

   :::image type="content" source="../media/acs-resource-keys.png" alt-text="image showing resource keys":::

> [!NOTE]
> If you regenerate the connection string in Azure Communication Services after establishing connectivity to the Azure Communication Services resource, the existing connection string in the Contact Center admin center app becomes invalid. An error message is also displayed in the connection string filed in the admin center. To resolve the error, copy the correction connection string from the Azure portal, and then paste it in the **Connection string** field in **Channels** > **Phone numbers** > **Advanced** > **Manage Azure Communication Services** in the Contact Center admin center app. The application displays a success message if the connection is successful.

### Get Event Grid application and tenant IDs from the Azure portal

You need to specify the values of **Application (client) ID** and **Directory (tenant) ID** in **Event grid app id** and **Event grid app tenant id** in Contact Center admin center or Customer Service admin center. Perform the following steps to get these values:

1. On the Azure portal, open the **App registrations** page. If you're registering your app on the Azure portal for the first time, then perform the following steps. Otherwise, select the registered app and go to step 2:

    1. On the **Register an application** page, enter the following details:

        - **Name**: Enter a name for your application.
        - **Supported account types**: Select **Accounts in any organizational directory (Any Microsoft Entra ID - Multitenant)**.

    1. Select **Register**.
       :::image type="content" source="../media/acs-resource-register.png" alt-text="resource keys" :::

1. Select the value of the **Application (client) ID** field, and then select **Copy to clipboard**. You enter this value for **Event grid app id** in Contact Center admin center or Customer Service admin center.

1. Select the value of the **Directory (tenant) ID** field, select the **Copy to clipboard** button, and then note the value. You enter this value for **Event grid app tenant id** in Contact Center admin center or Customer Service admin center.
   
1. Select **Owners** and add your account as the application owner.  

## Connect using an existing Azure resource

1. In the site map of Contact Center admin center or Customer Service admin center, under **Customer support**, select **Channels**.
1. Select **Manage** for **Phone numbers**.
1. Select **Use existing resource** and specify the following:
     - Paste the values you copied in the [Get Azure resource information](#get-azure-resource-information) section in the following fields:
       - **ACS Resource name** and **ACS Resource ID**: The **Name** and **Resource ID** field values.
       - **Connection String**: The **Connection string** field value.
     - Paste the values you copied in [Get application and tenant IDs](#get-event-grid-application-and-tenant-ids-from-the-azure-portal) in the following fields:
     
       - **Event grid app id**: The value of the **Application (client) ID** 
       - **Event grid app tenant id**: The value of the **Directory (tenant) ID**

       :::image type="content" source="../media/event-grid-app-tenant-id.png" alt-text="Values copied in Get application and tenant IDs" :::  

     - Select the checkbox to confirm that the Azure Communication Services resource is connected to this Dynamics 365 Contact Center or Customer Service instance only.

1. Select **Connect** to connect the resource to Azure Communication Services.

After you configure the Azure Communication Services resource, the **Manage Azure Communication Services** page displays the following:
 -  **Event grid app id**
 - **Event grid app tenant id**
 - **Recording Web Hook Endpoint**
 - **SMS Web Hook Endpoint**
 -  **Incoming call Web Hook Endpoint (preview)**.

You can copy the subscriber endpoint values such as **Recording Web Hook Endpoint**, **SMS Web Hook Endpoint**, and **Incoming call Web Hook Endpoint (preview)** to use them in [Set up incoming call, call recording, and SMS services](voice-channel-configure-services.md).

> [!NOTE]
> **Incoming call Web Hook Endpoint (preview)** is available only if the enhanced voice experience is deployed in your region.


## Next steps

[Set up incoming call, call recording, and SMS services](voice-channel-configure-services.md]
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[configure voice workstream settings](create-workstreams.md)  
[Configure inbound calling](voice-channel-inbound-calling.md)  
[Configure outbound calling](voice-channel-outbound-calling.md)    

### Related information

[Overview of the voice channel](voice-channel.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect using a new Azure resource](voice-channel-connect-new-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](../voice-channel-route-queues.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  
[Configure call recording and transcription for a voice workstream](voice-channel-configure-transcripts.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
