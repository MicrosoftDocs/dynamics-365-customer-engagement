---
title: "Connect to Azure Communication Services | MicrosoftDocs"
description: "Use this topic to understand how to connect to Azure Communication Services using new or existing Azure resources."
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

# Connect to Azure Communication Services

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Before you can provision phone numbers for your business in Omnichannel Customer Service, you must first establish connection with the Azure Communication Services. You can [connect to a new Azure resource](#connect-to-a-new-azure-resource) or [use an existing one](#use-an-existing-azure-resource), and then deploy the resource through Dynamics 365.

## Connect to a new Azure resource

Before you connect to a new Azure resource, check whether you have the following:
- A valid Azure subscription that's in the same tenant as your Dynamics 365 account.
- At least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal.
**To create a new Azure resource**

1. In Omnichannel admin center, under **General settings**, select **Phone numbers**, and then select **Get started**.
   
   The **Connect to Azure Communication Services** dialog opens.

2. Select **Create new resource** and enter the following details:
   - Azure subscription: 
   - Azure resource group:
      > [!NOTE]
      > The resource group name should be unique within a given subscription.
   - Resource name: 
   

## Connect to an existing Azure resource

You can also use an Azure Communication Services resource to connect with voice or SMS channels. You can use an existing resource from any of your Azure subscriptions, available under any tenant.

If you had previously unlinked a resource and want to use it now, you can do so using this option.

Before you proceed with adding an existing resource to Azure Communication Services, do the following:

1. Open your existing resource from the Azure portal in a new window or tab.
2. Select **Settings** > **Properties**, and get ready to copy the resource values (using the Copy to clipboard button) from this resource to Omnichannel admin center.

**To connect to an existing Azure resource**

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
