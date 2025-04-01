---
title: Connect using a new Azure resource 
description: Use this article to understand how to connect to Azure Communication Services using a new Azure resource in Customer Service admin center.
ms.date: 08/29/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---
# Quickstart: Connect using a new Azure resource


[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

In the voice channel, you can quickly connect to Azure Communication Services, provision phone numbers, and set up outbound and inbound calling for your business by creating and deploying a new Azure resource. For more information, see [Azure Communication Services](/azure/communication-services/overview).

## Prerequisites

Before you connect an Azure resource to Azure Communication Services, you must perform the following steps.

- Check whether the **Get started** button to connect to an existing Azure resource is visible on the **Phone numbers** page. The **Get Started** button appears only in the following scenarios.
    - The trial ends after the free calling time elapses.
    - You manually ended the trial.
    - You disconnected from the Azure resource. For more information, refer to [Disconnect from Azure Communication Services resource](voice-channel-disconnect-from-acs.md).
- Have an Azure subscription that's in the same tenant as your Dynamics 365 account. Ensure that your Azure subscription meets the [Subscription eligibility and number capabilities](/azure/communication-services/concepts/numbers/sub-eligibility-number-capability) requirements.
- Have at least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal. You can deploy your Azure Communication Services resource only if you have contributor-level permissions.
 
## Connect using a new Azure resource

1. In the site map of Customer Service admin center or Contact Center admin center, select **Channels** in **Customer support**. The **Channels** page appears.

1. Select **Manage** for **Phone numbers**.

1. Select **Get started**. The **Connect to Azure Communication Services** dialog opens.

1. Select **Create new resource**, and then enter the following details.
   - **Azure subscription**: Select a subscription from the dropdown list.
   - **Azure resource group**: Select an existing resource group or select **Create new**, and then enter a name for a new resource group.
  
        :::image type="content" source="../media/create-new-azure-resource.png" alt-text="Create new Azure resource" lightbox="../media/create-new-azure-resource.png":::

        > [!NOTE]
        > You might be prompted to add an Event Grid app ID for your resource. If you see this option, refer to [Get Event Grid application and tenant IDS from the Azure portal](voice-channel-connect-existing-resource.md#get-event-grid-application-and-tenant-ids-from-the-azure-portal) for information about these values.
      
       :::image type="content" source="../media/add-event-grid-app-id.png" alt-text="Add Event Grid app ID" lightbox="../media/add-event-grid-app-id.png":::

       > [!NOTE]
       > The resource name should be unique within a description.
      
   - **Resource name**: Enter a name for the resource. The resource name can contain only letters, numbers, and hyphens.
     
1. Select **Deploy** to create and deploy the resource.

Your new Azure resource is connected to Azure Communication Services. You can now [acquire new phone numbers](voice-channel-manage-phone-numbers.md) for your organization via the new resource and also [enable call recording and SMS services](voice-channel-configure-services.md).

### Related information

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect using an existing Azure resource](voice-channel-connect-existing-resource.md)  
[Disconnect from Azure Communication Services](voice-channel-disconnect-from-acs.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](../voice-channel-route-queues.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)   
[Import phone numbers](voice-channel-sync-from-acs.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
