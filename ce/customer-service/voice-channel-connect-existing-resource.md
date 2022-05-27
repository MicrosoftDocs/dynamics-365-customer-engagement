---
title: "Connect to an existing Azure resource | MicrosoftDocs"
description: "Use this article to understand how to connect to Azure Communication Services using an existing Azure resource."
ms.date: 05/27/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Advanced: Connect to an existing Azure resource

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

You can use an existing Azure resource from any of your Azure subscriptions, *available under any tenant*, to connect with voice or SMS channels. If you had previously disconnected a resource and want to use it now, you can do so using this option.

## Prerequisites

Before you connect an existing Azure resource to Azure Communication Services, you must perform the following steps.

- If you're [using a trial phone number](voice-channel-manage-phone-numbers.md#use-trial-phone-number), you must end the trial to be able to see the options to connect to the existing Azure resource.

- Get the following details from the Azure portal.

    - Name and ID of your Azure resource. 
      
      To get the resource name and ID, open your resource on the Azure portal, go to **Settings** > **Properties**. Note the values of the **ACS Resource Name** and **ACS Resource ID** fields.

    - Connection string of your Azure resource. 
      
      To get the connection string, see [Access your connection string and endpoints](/azure/communication-services/quickstarts/create-communication-resource?tabs=windows&pivots=platform-azp#access-your-connection-strings-and-service-endpoints).

    - [Application ID and tenant ID for your registered app](voice-channel-resource-app-details.md#get-application-and-tenant-ids).
      
      To get the application ID and tenant ID for your registered app:
      1. Open the **Event Grid System Topics** service on the Azure portal.
      1. [Create and deploy an event grid system topic](/azure/event-grid/create-view-manage-system-topics#create-a-system-topic).
      1. On the **Event Grid System Topic** page that's created, select the **Subscription** link.
      1. In the resource subscription page, select **Settings** > **Resource providers**, and then check if the **Microsoft.EventGrid** provider is listed as **Registered**. If the event grid is not registered, select the record and then select **Re-register** to register it.

> [!Important]
>
> On the **Phone numbers** page, the **Get started** button to connect to an existing Azure resource will appear only in the following scenarios.
> - The trial has ended after the free calling time has elapsed.
> - You've manually ended the trial.
> - You've [disconnected from the Azure resource](voice-channel-acs-resource.md#disconnect-from-azure-communication-services-resource).

## Connect to an existing Azure resource

1. In Dynamics 365, go to one of the admin apps, and perform the following steps.
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    
    2. Select **Manage** for **Phone numbers**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

   - In the site map, under **General settings**, select **Phone numbers**, and then select **Get started**. The **Connect to Azure Communication Services** dialog opens.

2. Select **Use existing resource**.

3. In the **Use existing resource** dialog, fill in the following fields using the resource details retrieved from the Azure portal.
   - **ACS Resource Name**: Enter the resource name.
   - **ACS Resource ID**: Enter the resource ID.
   - **Connection string**: Enter the connection string.
   - **Event grid app ID**: Enter the application ID.
   - **Event grid app tenant ID**: Enter the tenant ID.

4. Select **Connect**.
   <!---> > [!div class="mx-imgBorder"]
    > ![Azure resource is connected to Azure Communication Services.](./media/voice-channel-acs-connection.png "Azure resource is connected to Azure Communication Services.")
   <--->
    Your existing resource is now connected to Azure Communication Services, and you can [acquire new phone numbers](voice-channel-manage-phone-numbers.md) for your organization via the resource. 

5. Select **Add number**. The **Add phone number** page is displayed.

6. [Add a new phone number](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers).

You can now configure the voice workstream settings for the phone number, and set up outbound and inbound calling to make and/or receive customer calls, and also [enable recording and SMS services](voice-channel-sub-endpoints.md).

### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect to a new Azure resource](voice-channel-connect-new-resource.md)  
[Enable recording and SMS services](voice-channel-sub-endpoints.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](voice-channel-route-queues.md) 
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]