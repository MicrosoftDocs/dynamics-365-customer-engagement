---
title: "Manage phone numbers | MicrosoftDocs"
description: "Use this topic to understand how you can add new phone numbers, and also edit and release existing phone numbers in Omnichannel for Customer Service."
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

## Create a new phone number

To add new phone numbers to your business, you must do the following:

- Create a resource or use an existing one to connect to Azure Communication Services. You can also use a resource that you previously disconnected or unlinked from Azure Communication Services, and reuse it now.
- Deploy the resource through Dynamics 365.
- Add a new phone number.

## Additional notes

You can use only one ACS resource for number management.

### See also

[Overview of the voice channel](voice-channel.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
