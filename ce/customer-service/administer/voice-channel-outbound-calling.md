---
title: Set up outbound calling in the voice channel
description: Learn how you can set up outbound calling for phone numbers in your organization.
ms.date: 12/14/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Set up outbound calling

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


This article describes how you, as an administrator, can set up outbound calling for phone numbers in your organization. After you set up outbound calling, your customer service representatives (service representatives or representatives) can make calls to customers in the Customer Service workspace or Contact Center workspace app.

If you don't have any phone numbers provisioned for your business, then see [Acquire a new phone number](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers) to learn how you can acquire new phone numbers. Phone number calling plans must be provisioned to support making calls to be used for outbound voice.


## Prerequisites

Before you set up outbound voice calls for your business, you must perform the following steps.

1. [Configure one or more phone numbers for outbound calling](#configure-phone-numbers-for-outbound-calling).
1. [Create a voice type queue](voice-channel-inbound-calling.md#create-queues-for-voice-channels) or use an existing voice queue to associate with the outbound profile.
1. [Configure capacity profiles and add users](#configure-capacity-profiles-and-assign-users).
1. [Create outbound profiles](configure-outbound-inbound-profiles.md#create-outbound-profiles)

## Configure phone numbers for outbound calling

To check whether a phone number is enabled for outbound calling, go to **General settings** > **Phone numbers**, and check whether the number has **Make calls** mentioned in the **Calling** column. You can configure the calling plan for a phone number if it isn't enabled for outbound calling.

1. In the site map of Customer Service admin center or Contact Center admin center, select **Channels** in **Customer support**. The **Channels** page appears.
    
1. Select **Manage** for **Phone numbers**.
   
1. In the **Edit number** dialog, in the **Calling plans** area, select the **Make calls** option, and then select **Upgrade**.
   Your phone number is now upgraded for outbound calling.

The phone number is displayed to your customers when your representatives call them.

> [!NOTE]
> - Though you can use the same queue for both inbound and outbound calling, we recommend that you create separate queues for inbound and outbound calling. This helps your supervisors to monitor and gauge traffic and customer sentiment, specific to outbound calls.
> - To configure call transfer to an external number to manage overflow, outbound calling must be enabled.

## Configure capacity profiles and assign users

You must create or use existing capacity profiles to define and set the workload of your representatives. For your representatives to be able to make calls to customers, they must be assigned or added to an outbound capacity profile. If a representative isn't assigned to a capacity profile associated with an outbound profile, then outbound calling features aren't available to the service representative. So, make sure that after you create or update the capacity profile, you add users to the profile.

For detailed information on how to manage capacity profiles and add users, see [Create and manage capacity profiles](capacity-profiles.md).

For outbound calls, set the capacity profile fields as follows:

- **Work item limit**: Indicates the number of outbound calls a representative can make at a time. If the value is set to 1, it means that the representative can make only one call at a time, and can't make a second call until the first call is ended. If the value is set to 3, it means that the representative can make 3 outbound calls at a time. 
- **Reset frequency**: Indicates whether the representative can immediately make another call when the current ends or has to wait until end of day. For voice calls, set this field to **Immediate** so that the representative can make another call after the current call is over.
- **Assignment blocking**: Indicates whether you want to block any incoming calls when the representative is already on a call. Set this value to **Yes**, if you want to ensure the representative doesn't receive any incoming calls when an outbound call is in progress.

> [!NOTE]
>
> - When you name your capacity profiles, we recommend that you clearly indicate in the capacity **Profile name** field whether they're outbound, inbound, or both, so it's easy for you to assign users or representatives to the appropriate profile.
> - Though you can use the same capacity profile for both inbound and outbound calling, we recommend that you create separate profiles because the considerations and settings for outbound calling and inbound calling can differ.
> - If your representatives are assigned to receive customer calls only and not assigned to any capacity profile used for outbound calling, call features aren't displayed to the representative.

## Assign personal phone numbers to representatives

Personal numbers allow representatives to exclusively make calls from the chosen number. These are different from outbound profile numbers as personal numbers are linked to specific user records, not profiles. 

You can assign personal phone numbers to representativess to make outbound calls to customers as long as the number isn't toll-free. To configure a personal phone number:

1. Acquire a geographic phone number in Customer Service admin center or Contact Center admin center. For details on how to acquire a phone number, see [Manage phone numbers](voice-channel-manage-phone-numbers.md).

1. On the **Phone numbers** page, select **Setup** in **Ready for setup**, and in the dialog that appears, select **Assign to user**. The **Omnichannel Users** page displays a list of all representatives.

1. Select a representative to open the agent details page.

1. Select **Omnichannel** and in **Omnichannel Phone**, search for your geographic number by using +1. 
1. Select the number in the results and then select **Save**. The phone number is now assigned exclusively to the representatives to call customers.

> [!NOTE]
> - You can assign to representatives local phone numbers only as personal phone numbers; toll-free numbers can’t be assigned. Personal service representative phone number calls always apply the default scoped outbound profile.
> - You can add only those users who are configured for unified routing.
> - After you add representatives to a queue, they must refresh their dashboards after 20 minutes to be able to make calls.

### Related information

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Configure outbound and inbound profiles](configure-outbound-inbound-profiles.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Set up inbound calling](voice-channel-inbound-calling.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
