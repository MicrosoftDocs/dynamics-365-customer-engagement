---
title: "Connect to an existing Azure resource | MicrosoftDocs"
description: "Use this article to understand how to connect to Azure Communication Services using an existing Azure resource."
ms.date: 04/08/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Advanced: Connect to an existing Azure resource

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

You can also use an existing Azure resource to connect with voice or SMS channels. You can use a resource from any of your Azure subscriptions, *available under any tenant*. If you had previously disconnected a resource and want to use it now, you can do so using this option.

## Prerequisites

Before you connect an existing Azure resource to Azure Communication Services, you must do the following:

- If you're [using a trial phone number](voice-channel-manage-phone-numbers.md#use-trial-phone-number), you must end the trial to be able to see the options to connect to a new or existing Azure Communication Services resource.

Get the following details from the Azure portal.

- [Get the resource name and ID from the Azure portal](voice-channel-resource-app-details.md#get-resource-name-and-id).
- [Get the connection string from the Azure portal](voice-channel-resource-app-details.md#get-connection-string).
- [Get the application ID and tenant ID from the App registrations page on the Azure portal](voice-channel-resource-app-details.md#get-application-and-tenant-ids).

> [!Important]
>
> On the **Phone numbers** page, the **Get started** button to connect to an existing Azure resource will appear only in the following scenarios:
> - The trial has ended after the free calling time has elapsed.
> - You've manually ended the trial.
> - You've [disconnected from the Azure resource](voice-channel-acs-resource.md#disconnect-from-azure-communication-services-resource).

## Connect to an existing Azure resource

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    
    2. Select **Manage** for **Phone numbers**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

   - In the site map, under **General settings**, select **Phone numbers**, and then select **Get started**. The **Connect to Azure Communication Services** dialog opens.

2. Select **Use existing resource**.

3. Enter the following details, based on the resource details retrieved from the Azure portal.
   - **ACS Resource Name**: Enter the resource name.
   - **ACS Resource ID**: Enter the resource ID.
   - **Connection string**: [Enter the connection string](voice-channel-resource-app-details.md#get-connection-string).
   - **Event grip app ID**: [Enter the application ID](voice-channel-resource-app-details.md#get-application-and-tenant-ids).
   - **Event grip app tenant ID**: [Enter the tenant ID](voice-channel-resource-app-details.md#get-application-and-tenant-ids).

4. Select **Connect**.
    > [!div class="mx-imgBorder"]
    > ![Azure resource is connected to Azure Communication Services.](./media/voice-channel-acs-connection.png "Azure resource is connected to Azure Communication Services.")

    Your existing resource is now connected to Azure Communication Services, and you can [acquire new phone numbers](voice-channel-manage-phone-numbers.md) for your organization via the resource. 

5. Select **Add number**. The **Add phone number** page is displayed.

6. [Add a new phone number](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers).

You can now configure the voice workstream settings for the phone number, and also configure outbound and inbound calling to make and/or receive customer calls.

### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect to a new Azure resource](voice-channel-connect-new-resource.md)  
[Get resource and app registration details from Azure portal](voice-channel-resource-app-details.md)  
[Register event grid system topics](voice-channel-event-grid.md)  
[Create event subscription endpoints](voice-channel-sub-endpoints.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]