---
title: Configure outbound and inbound profiles
description: Configure outbound and inbound profiles with various settings, such as caller ID, language, and wait music for the voice channel.
ms.date: 12/16/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
ms.custom: bap-template
---

# Configure outbound and inbound profiles

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


Use the information in this article to create profiles that are used for direct inward dialing to specific customer service representatives (service representative or representative) and outbound calling. These profiles help you configure settings, such as language, wait music, and transcription settings for these calls. The profiles that you create are listed on the **Outbound and inbound profiles** page. The **Profile type** column helps distinguish the profiles.

Inbound profiles enable direct inward dialing to individual service representatives, and they differ from workstreams that are used to define how inbound calls are routed and assigned to service representatives via queues. Direct inward dialing doesn't use unified routing and therefore the direct calls to service representatives aren't tracked in unified routing historical analytics.

## Prerequisites

Make sure that the following prerequisites are in place:

- To create inbound profiles, you have configured and enabled a geographic type of personal number to receive calls and assigned to the representative via the **Omnichannel** tab in user settings. More information: [Manage phone numbers](voice-channel-manage-phone-numbers.md)
- To create outbound profiles, you have configured and enabled shared or geographic type numbers for outbound calls. In your calling plan for the number, the **Make calls** checkbox is selected.
- You have configured [capacity profiles](capacity-profiles.md).
- You have configured [voice queues](voice-channel-inbound-calling.md#create-a-queue-for-the-voice-channel).

## Create inbound profiles

1. In the Customer Service admin center or Contact Center admin center site map, select **Productivity** in **Agent experience**.

1. On the **Productivity** page, select **Manage** for **Outbound and inbound profiles**.

1. Select **New profile**.

1. On the **Create new profile** dialog, enter a profile name, select the profile type as **Inbound**, and then select **Next**.

1. On the **Phone number** page, select a personal number in the **Number** list, and select **Next**. You can add only one phone number at a time while creating a profile.

1. In **Inbound info**, select a queue and one or more capacity profiles in the **Queue** and **Capacity** dropdown lists, and then select **Next**.

1. In **Inbound behaviors**, configure the following settings:

   - **Language**: Accept the default language as **English - United States** or select a language from the list.
   - **Hold music**: Select a music file to play when the call is on hold.
   - **Wait music**: Select a music file to play when the call is in waiting.
   - **Call transfer to external phone number**: Set the toggle to **On** if you want the representatives to transfer the call to a phone number outside of your organization.
   - **Consult with Microsoft Teams user**: Set the toggle to **On** if you want the representatives to consult or transfer the voice calls to subject matter experts on Microsoft Teams.
   - **Transcription and recording**: Select whether you want to transcript the call and record it. Select **None** if you don't want to.
     - **Start setting**: Is enabled when you select transcript or transcription and recording. Set to **Automatic** if the call recording and transcription needs to start immediately.
      - **Allow agents to pause and resume**: Is enabled when you set the **Start setting** to **Automatic**. Set to **Yes** to let representatives pause and resume the recording and transcription.

1. Select **Next**, verify the settings, and select **Save and close**.

## Create outbound profiles

You can define how representatives use the outbound calls and which representatives can make those calls. If you want a caller ID number that's displayed to customers to be different from the outbound profile number, configure an alternative number. It's useful when some settings differ based on the representative's role while the caller ID number still lists consistently for a business. You must configure the alternative number other than the default number as a workstream channel or as an outbound profile number before you can use it. For details, see [assign a personal phone number to service representatives](voice-channel-outbound-calling.md#assign-personal-phone-numbers-to-representatives).

1. Perform the steps 1 through 3 in [Create inbound profiles](#create-inbound-profiles).

1. On the **Create new profile** dialog, in the **Profile settings** section, enter a profile name in **Profile name**, select **Outbound** in **Profile type**, and select **Next**.

1. In **Phone number**, select a phone number in the **Shared numbers** list, and select **Next**.
    
   > [!Note]
   > The phone numbers list shows only those numbers that are enabled for outbound calling and aren't used as a personal phone number. If you don't see any numbers in the list, [configure a number for outbound calling](voice-channel-outbound-calling.md#configure-phone-numbers-for-outbound-calling).

1. In **Outbound info**, do the following:
   
    - **Number label**: Enter a label to denote the business context, like Billing, that's displayed with the phone number at the representative end when they call a customer. This value is automatically populated with the phone name string on the agent dialer that the representative can edit.

      > [!NOTE]
      > This label is used in the agent dialer only, and isn't a caller name delivery (CNAM) label that can be displayed to customers, as CNAM isn't supported.

    - **Queue**: Select a queue from the dropdown list.
    - **Capacity**: Select one or more capacity profiles from the dropdown list.
    - **Caller ID number**: Select a number from the list. The **(Profile Number)** label against the number indicates that the caller ID displays the same number as the profile number. It's also the default setting.<br>
      If you select a caller ID that's different from the profile number, make sure the number has an outbound profile so that agent settings are created.
1. In **Outbound behaviors**, do the following: 
    - **Allow list for countries/regions**: Select the countries or regions whose numbers your representatives can call. If representatives have multiple outbound profiles, they'll see a list of countries or regions that are selected in all profiles.
      > [!NOTE]
      > The **Allow list for countries/regions** is an early access feature. You can opt in early to enable these features in your environment, which will allow you to test these features and then adopt them across your environments. For information about how to enable these features, see [Opt in to early access updates](/power-platform/admin/opt-in-early-access-updates).
    - **Hold music**: Select a music file that you want played when the customer is put on hold during a call.
    - **Wait music**: Select a music file that you want played when the customer is waiting to get into a call.
    - **Call transfer to external phone number**: Set the toggle to **On** if you want the representatives to transfer the call to a phone number outside of your organization.
    - **Consult with Microsoft Teams user**: Set the toggle to **On** if you want the representatives to consult or transfer the voice calls to subject matter experts on Microsoft Teams.
    - **Transcription and recording**: Select **None**, **Transcription only**, or **Transcription and recording**, based on your business scenarios and requirements. As an administrator, you may want to set the value to **None** for business transactions like customer billing where you don't want to record financial data.
    - **Start setting**: Indicates whether you want to start transcription and/or recording when the call begins. The default value is **Automatic**, which means transcription and recording will automatically begin at the start of the conversation.
    - **Allow agents to pause and resume**: Indicates whether you want to allow your representatives to pause and resume call transcription and recording. The default value is **Yes** which means that your representatives can choose when to pause or resume call transcription and recording in the conversation panel.

1. Select **Save and close**.

   :::image type="content" source="../media/outbound-inbound-voice-call-profiles.png" alt-text="Outbound and inbound profiles for voice calls.":::

### Default profiles

The default profiles are available out of the box if you use the first-run experience in the new organization. Some of the features are as follows:

- The default profiles are used as fallback profiles when representatives aren't assigned a profile.
- You can edit the behavior and templates only but not the profile type for the default profiles.
- The locale settings for the default profiles should be same. The locale settings can be edited in one of the default profiles only and the setting will be applicable to both the default profiles.
- The phone number column for the default inbound profile is "undefined" because it's used as a default for all calls to service representatives phone numbers. When a customer calls, if no other inbound profile exists, the default profile is used to route the call to the service representative whose phone number is enabled for inbound calling and their capacity matches the capacity profile that's set for the default profile.

### Edit profiles

Edit the profiles to update the behavior and advanced settings. You can delete profiles that aren't required.

1. On the **Outbound and inbound profiles** page, select a profile from the list and select **Edit**. On the **Edit profile settings** dialog, update details in the required sections.

1. The **Advanced settings** section that's available only after you save a profile, select the default templates for session, consult notification, and transfer notification. For information on session and notification templates, see [Manage session templates](session-templates.md) and [Manage notification settings and templates](notification-templates.md).

1. Select **Save and close**.

### Related information

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Set up inbound calling](voice-channel-inbound-calling.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
