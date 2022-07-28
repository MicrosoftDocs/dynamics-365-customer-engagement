---
title: "Set up outbound calling in the voice channel | MicrosoftDocs"
description: "Use this article to understand how you can set up outbound calling for phone numbers in your organization."
ms.date: 04/04/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.custom: 
  - intro-internal
---

# Set up outbound calling

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This article describes how you, as an administrator, can set up outbound calling for phone numbers in your organization. After you set up outbound calling, your agents can make calls to customers in the Omnichannel for Customer Service or Customer Service workspace app.

If you don't have any phone numbers provisioned for your business, then see [Acquire a new phone number](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers) to learn how you can acquire new phone numbers. Phone number calling plans must be provisioned to support making calls to be used for outbound voice.

## Prerequisites

Before you set up outbound voice calls for your business, you must perform the following steps.

- [Configure one or more phone numbers for outbound calling](#configure-phone-numbers-for-outbound-calling).
- [Create a voice type queue](voice-channel-inbound-calling.md#create-queues-for-voice-channels) or use an existing voice queue to associate with the outbound profile.
- [Configure capacity profiles and add users](#configure-capacity-profiles-and-assign-users).
- [Create outbound profiles](#create-outbound-profiles)

## Configure phone numbers for outbound calling

To check whether a phone number is enabled for outbound calling, go to **General settings** > **Phone numbers**, and check whether the number has **Make calls** mentioned in the **Calling** column. You can configure the calling plan for a phone number if it is not enabled for outbound calling.

1. In Dynamics 365, go to one of the apps, and perform the following steps.  
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    2. Select **Manage** for **Phone numbers**.
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    In the site map, select **Phone numbers** in **General settings**.
1. In the list of available phone numbers, select a phone number, and then select **Edit**.
1. In the **Edit number** dialog, in the **Calling plans** area, select the **Make calls** option, and then select **Upgrade**.
   Your phone number is now upgraded for outbound calling.

The phone number will now be displayed to your customers when your agents call them.

> [!NOTE]
> Though you can use the same queue for both inbound and outbound calling, we recommend that you create separate queues for inbound and outbound calling. This will help your supervisors monitor and gauge traffic and customer sentiment, specific to outbound calls.

## Configure capacity profiles and assign users

You must create or use existing capacity profiles to define and set the workload of your agents. For your agents to be able to make calls to customers, they must be assigned or added to an outbound capacity profile. If an agent is not assigned to a capacity profile associated with an outbound profile, then outbound calling features will not be available to the agent. So, ensure that after you create or update the capacity profile, you add users to the profile.

For detailed information on how to manage capacity profiles and add users, see [Create and manage capacity profiles](capacity-profiles.md).

For outbound calls, set the capacity profile fields as follows:

- **Work item limit**: Indicates the number of outbound calls an agent can make at a time. If the value is set to 1, it means that the agent can make only one call at a time, and cannot make a second call until the first call is ended. If the value is set to 3, it means that the agent can make 3 outbound calls at a time. 
- **Reset frequency**: Indicates whether the agent can immediately make another call when the current ends or has to wait until end of day. For voice calls, set this field to **Immediate** so that the agent will be able to make another call as soon as the current one has ended.
- **Assignment blocking**: Indicates whether you want to block any incoming calls when the agent is already on a call. Set this value to **Yes**, if you want to ensure the agent does not receive any incoming calls when an outbound call is in progress.

> [!Note]
>
> - When you name your capacity profiles, we recommend that you clearly indicate whether they're outbound, inbound, or both, in the capacity **Profile name** field, so it's easy for you to assign users or agents to the appropriate profile.
> - Though you can use the same capacity profile for both inbound and outbound calling, we recommend that you create separate profiles because the considerations and settings for outbound calling and inbound calling can differ.
> - If your agents are only assigned to receive customer calls and not assigned to any capacity profile used for outbound calling, calling features will not be displayed to the agent.

## Create outbound profiles

You can define the way outbound calls are made and also who can make them. To create an outbound profile, you'll need a phone number that's enabled for outbound calling. This means that in your calling plan for that number, the **Make calls** checkbox must be selected.

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   ### [Customer Service admin center](#tab/customerserviceadmincenter)    
     1. In the site map, select **Productivity** in **Agent experience**.
     2. On the **Productivity** page, select **Manage** for **Outbound profiles**.
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    In the site map, select **Agent experience** in **Advanced settings**, and then select **Manage** for **Outbound profiles**
1. Select **New profile**.
1. In the **Create outbound profile** dialog, enter the following details:
   - In the **Basic info** section, add the following details:
     - **Profile name**: Enter a profile name.
     - **Phone number**: Select a phone number from the dropdown list.
         > [!Note]
         > The phone numbers list shows only those numbers that are enabled for outbound calling and aren't used as a personal user phone number. If you don't see any numbers in the list, you'll need to [configure a number for outbound calling](#configure-phone-numbers-for-outbound-calling).
     - **Number label**: Indicates the label displayed with the phone number at the customer's end when you call a customer, indicating a business context such as Billing. This value is automatically populated with the phone name string but can be edited.
     - **Queue**: Select a queue from the dropdown list. The list shows only voice type queues, so if you don't see any queues in the list, you'll need to [create a voice type queue](voice-channel-inbound-calling.md#create-queues-for-voice-channels).
     - **Capacity**: Select one or more capacity profiles from the dropdown list.
     - **Hold music**: Select a music file that you want played when the customer is put on hold during a call.
     - **Wait music**: Select a music file that you want played when the customer is waiting to get into a call.
     - **Transcription and recording**: Select **None**, **Transcription only**, or **Transcription and recording**, based on your business scenarios and requirements. As an administrator, you may want to set the value to **None** for business transactions like customer billing where you don't want to record financial data.
     - **Start setting**: Indicates whether you want to start transcription and/or recording when the call begins. The default value is **Automatic**, which means transcription and recording will automatically begin at the start of the conversation.
     - **Allow agents to pause and resume**: Indicates whether you want to allow your agents to pause and resume call transcription and recording. The default value is **Yes** which means that your agents can choose when to pause or resume call transcription and recording in the conversation panel.
1. Select **Save and close**.

### Edit outbound profiles

1. On the **Outbound profiles** page, select a profile from the list and select **Edit**. In the **Edit outbound profile** dialog, update details in the **Basic info**, **Behaviors**, and **Advanced settings** sections.
   For information on session and notification templates, see [Manage session templates](../app-profile-manager/session-templates.md) and [Manage notification settings and templates](../app-profile-manager/notification-templates.md).
2. Select **Save and close**.

## Assign personal phone numbers to agents

You can assign personal phone numbers to agents to make outbound calls to customers.

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
    1. In the site map, select **Channels** in **Customer support**.
    1. On the **Channels** page, select **Manage** for **Phone numbers**.
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    In the site map, select **Phone numbers** in **General settings**.
2. On the **Phone numbers** page, select **Setup** in **Ready for setup**, and in the dialog that appears, select **Assign to user**. The **Omnichannel Users** page displays a list of all agents.
3. Select an agent to open the agent details page.
4. Select the **Omnichannel** tab and select a phone number from the **Omnichannel Phone** field.
   The phone number is now assigned exclusively to the agent to call customers.

> [!Note]
> Only local phone numbers can be assigned to agents as personal phone numbers; toll-free numbers can’t be assigned. Personal agent phone number calls always apply the default scoped outbound profile.

### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Set up inbound calling](voice-channel-inbound-calling.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
