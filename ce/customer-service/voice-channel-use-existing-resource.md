---
title: "Use existing Azure Communication Service resources | MicrosoftDocs"
description: "Use this topic to understand how you can use existing Azure Communication Services resources  new phone numbers, and also edit and release existing phone numbers in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/01/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---
<!--  
i.	Number management[Neeraja]  i) Connecting to ACS ii) acquire, release, update numbers, Kos wants more screenshots iii) Bring your own number; see the notes for point 3 a
ii.	Connect to existing ACS resource (existing today, but needs a lot more details)[Neeraja] Jaya received a demo from Debashish. Video effort post GA; Kos and Jaya to have a follow up about it. 
i.	Number management[Neeraja]  i) Connecting to ACS ii) acquire, release, update numbers, Kos wants more screenshots iii) Bring your own number; see the notes for point 3 a
ii.	Connect to existing ACS resource (existing today, but needs a lot more details)[Neeraja] Jaya received a demo from Debashish. Video effort post GA; Kos and Jaya to have a follow up about it. 

-->
# Manage phone numbers

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Service helps you enable and use voice and SMS services in a seamless, integrated way within Dynamics 365. As an administrator, you can purchase phone numbers and call plans, decide whether you want to avail call and/or SMS services, or whether you'd like to set up inbound or outbound calling options for your business.

## Use phone number included with the voice channel

The voice channel includes a trial phone number that comes with 60 minutes of free calling. With this trial number, you don't need to connect to Azure Communication Services. However, when the 60 minutes of free calling time elapses, you must purchase a new number based on your own Azure subscription, and cannot reuse or purchase the trial number.

## Prerequisites

- A valid Azure subscription that's in the same tenant as your Dynamics 365 account.
- At least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal.

## Acquire a new phone number

To add new phone numbers to your business, you must do the following:

- Create a resource or use an existing one to connect to Azure Communication Services. You can also use a resource that you previously disconnected or unlinked from Azure Communication Services, and reuse it now.
- Deploy the resource through Dynamics 365.
- Add a new phone number.

[!Note]
You can use only one Azure Communications resource to add, edit, or release phone numbers.

### Use existing resource

If you already have an Azure Communication Services resource that you'd like to use to connect with voice or SMS channels, you can use the **Use existing resource** option to connect to Azure Communication Services. Also, if you had previously unlinked a resource and wish to use it now, you can do so using this option. You can use an existing resource from any of your Azure subscriptions, available under *any* tenant.

Before you proceed with adding an existing resource to Azure Communication Services, do the following:

1. Open your existing resource from the Azure portal in a new window or tab.
2. Select **Settings** > **Properties**, and get ready to copy the resource values (using the Copy to clipboard button) from this resource to Omnichannel admin center.

**To use an existing resource**

1. In Omnichannel admin center, under **General settings**, select **Phone numbers**, and then select **Get started**.

   The **Connect to Azure Communication Services** dialog opens.

2. Select **Use existing resource** and enter the following details:
   - ACS Resource Name: Copy the name from your existing resource here.
   - ACS Resource ID
   - Connection String
   - Event grip app ID
   - Event grip app tenant ID



### See also

[Overview of the voice channel](voice-channel.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
