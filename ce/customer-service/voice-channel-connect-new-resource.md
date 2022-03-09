---
title: "Connect to a new Azure resource | MicrosoftDocs"
description: "Use this topic to understand how to connect to Azure Communication Services using a new Azure resource."
ms.date: 03/10/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---
# Quickstart: Connect to a new Azure resource

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction


## Prerequisites

Before you connect to an Azure resource, ensure you have the following details:

- An Azure subscription that's in the same tenant as your Dynamics 365 account. Ensure that your Azure subscription meets the [Subscription eligibility and number capabilities](/azure/communication-services/concepts/numbers/sub-eligibility-number-capability) requirements.
- At least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal. You'll be able to deploy your Azure Communication Services resource only if you have contributor-level permissions.

> [!Important]
> - If you're [using a trial phone number](voice-channel-manage-phone-numbers.md#use-trial-phone-number), you must end the trial to be able to see the options to connect to a new or existing Azure Communication Services resource. 
> - The **Get started** button to connect to a new or existing Azure Communication Services resource will appear only when the trial has ended after the free calling time has elapsed, or when you've manually ended the trial, or when you've [disconnected from the Azure resource](voice-channel-acs-resource.md#disconnect-from-azure-communication-services-resource).

## Connect to a new Azure resource

1.  In Dynamics 365, go to one of the apps, and perform the following steps.
    ### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)
     
     > [!IMPORTANT]
     > The Customer Service admin center app is in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    
    2. Select **Manage** for **Phone numbers**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

   - In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**, and then select **Get started**. The **Connect to Azure Communication Services** dialog opens.

2. Select **Create new resource** and enter the following details:
   - **Azure subscription**: Select a subscription from the dropdown list.
   - **Azure resource group**: Select an existing resource group or select **Create new**, and enter a name for a new resource group.
      > [!NOTE]
      > The resource group name should be unique within a subscription.
   - **Resource name**: Enter a name for the resource. The resource name can contain only letters, numbers, and hyphens.
3. Select **Deploy** to create and deploy the resource.
    > [!div class="mx-imgBorder"]
    > ![Create new resource.](./media/voice-channel-number-mgmt-azure-create-new-resource.png "Create new resource.")

Your new Azure resource is now connected to Azure Communication Services, and you can [acquire new phone numbers](voice-channel-manage-phone-numbers.md) for your organization via the new resource. However, to acquire or purchase phone numbers, you'll need to contact or wait to be contacted by a Microsoft voice program manager to be added to the Azure Communication Services allowlist.

### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to an existing Azure resource](voice-channel-connect-existing-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
