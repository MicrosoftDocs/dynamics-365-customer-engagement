---
title: "Configure outbound and inbound profiles | MicrosoftDocs"
description: "Use this article to understand how you can configure outbound and inbound profiles in your organization."
ms.date: 10/03/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.collection: get-started
---

# Configure outbound and inbound profiles

Use the information in this article to create profiles that'll be used during inbound and outbound calls directly to or from agents. These profiles help you configure settings, such as language, wait music, and transcription settings, for the calls. The profiles that you create will be listed on the **Outbound and inbound profiles** page that can be accessed through **Productivity** in the site map. The **Profile type** column helps distinguish the profiles.

Inbound profiles enable direct calls to individual agents and therefore differ from workstreams that are used to define how inbound calls are routed and assigned to agents via queues. Direct inbound calling doesn't use unified routing and therefore the direct calls won't be tracked in unified routing historical analytics.

## Prerequisites

The following prerequisites must be met:

- To create inbound profiles, a personal number of geographic type and enabled to receive calls must be provisioned and assigned to the agent via the **Omnichannel** tab in user settings. More information: [Manage phone numbers](voice-channel-manage-phone-numbers.md)
- To create outbound profiles, shared or geographic type numbers enabled for outbound calls must be configured and available in the system. In your calling plan for the number, the **Make calls** checkbox must be selected.
- Capacity profiles to be used in profiles must be configured. [Manage capacity profiles](capacity-profiles.md)
- Voice queues must be configured. More information: [Configure voice queues](voice-channel-inbound-calling.md#create-a-queue-for-the-voice-channel)

## Create inbound profiles

1. In Customer Service admin center, In the site map, select **Productivity** in **Agent experience**.

1. On the **Productivity** page, select **Manage** for **Outbound and inbound profiles**.

1. Select **New profile**.

1. On the **Create new profile** dialog, enter a profile name, select the profile type as **Inbound**, and then select **Next**.

1. On the **Phone number** page, select a personal number in the **Number** list, and select **Next**. You can add only one phone number at a time while creating a profile.

1. In **Inbound info**, select a queue and one or more capacity profiles in the **Queue** and **Capacity** dropdown lists, and then select **Next**.

1. In **Inbound behaviors**, configure the following settings:

  - **Language**: Accept the default language as **English - United States** or select a language from the list.
  - **Hold music**: Select a music to play when the call is on hold.
  - **Wait music**: Select a music to play when the call is in waiting.
  - **Call transfer to external phone number**: Set the toggle to **On** if you want the agents to transfer the call to a phone number outside of your organization.
  - **Consult with Microsoft Teams user**: Set the toggle to **On** if you want the agents to consult or transfer the voice calls to subject matter experts on Microsoft Teams.
  - **Transcription and recording**: Select whether you want to transcript the call and record it. Select **None** if you don't want to.
    - **Start setting**: Is enabled when you select transcript or transcription and recording. Set to Automatic if the call recording and transcription needs to start immediately.
      - **Allow agents to pause and resume**: Is enabled when you set the **Start setting** to automatic. Set to **Yes** to let agents pause and resume the recording and transcription.

1. Select **Next**, verify the settings, and select **Save and close**.

## Create outbound profiles

You can define the way outbound calls are made and also who can make them.

1. Perform the steps 1 through 3 in [Create inbound profiles](#create-inbound-profiles).

1. On the **Create new profile** dialog, in the **Profile settings** section, enter a profile name in **Profile name**, select **Outbound** in **Profile type**, and select **Next**.

1. In **Phone number**, select a phone number in the **Shared numbers** list, and select **Next**.
    
   > [!Note]
   > The phone numbers list shows only those numbers that are enabled for outbound calling and aren't used as a personal phone number. If you don't see any numbers in the list, [configure a number for outbound calling](voice-channel-outbound-calling.md#configure-phone-numbers-for-outbound-calling).

1. In **Outbound info**, do the following:
   
    - **Number label**: Enter a label to denote the business context, like Billing, that's displayed with the phone number at the agent end when they call a customer. This value is automatically populated with the phone name string on the agent dialer that the agent can edit.
    - **Queue**: Select a queue from the dropdown list.
    - **Capacity**: Select one or more capacity profiles from the dropdown list.
1. In **Outbound behaviors**, do the following:
    - **Hold music**: Select a music file that you want played when the customer is put on hold during a call.
    - **Wait music**: Select a music file that you want played when the customer is waiting to get into a call.
    - **Call transfer to external phone number**: Set the toggle to **On** if you want the agents to transfer the call to a phone number outside of your organization.
    - **Consult with Microsoft Teams user**: Set the toggle to **On** if you want the agents to consult or transfer the voice calls to subject matter experts on Microsoft Teams.
    - **Transcription and recording**: Select **None**, **Transcription only**, or **Transcription and recording**, based on your business scenarios and requirements. As an administrator, you may want to set the value to **None** for business transactions like customer billing where you don't want to record financial data.
    - **Start setting**: Indicates whether you want to start transcription and/or recording when the call begins. The default value is **Automatic**, which means transcription and recording will automatically begin at the start of the conversation.
    - **Allow agents to pause and resume**: Indicates whether you want to allow your agents to pause and resume call transcription and recording. The default value is **Yes** which means that your agents can choose when to pause or resume call transcription and recording in the conversation panel.

1. Select **Save and close**.

:::image type="content" source="media/outbound-inbound-voice-call-profiles.png" alt-text="Outbound and inbound profiles for voice calls.":::

### Default profiles

The default profiles are available out of the box if you use the first-run experience in the new org. Some of the features are as follows:

- The default profiles are used as fallback profiles when agents are not assigned a profile.
- You can edit the behavior and templates only but not the profile type for the default profiles.
- The locale settings for the default profiles should be same. The locale settings can be edited in one of the default profiles only and the setting will be applicable to both the default profiles.
- The phone number column for the default inbound profile will always be "undefined" because it's used as a default for all calls to agent phone numbers unless specifically configured. When a customer calls, if no other inbound profile exists, the default profile will be used and routed to the agent whose phone number is enabled for inbound calling and their capacity matches the capacity profile condition of the default profile.

### Edit profiles

Edit the profiles to update the behavior and advanced settings. You can delete profiles that are not required.

1. On the **Outbound and inbound profiles** page, select a profile from the list and select **Edit**. On the **Edit profile settings** dialog, update details in the required sections.

1. The **Advanced settings** section that's available only after you save a profile, select the default templates for session, consult notification, and transfer notification. For information on session and notification templates, see [Manage session templates](../app-profile-manager/session-templates.md) and [Manage notification settings and templates](../app-profile-manager/notification-templates.md).

1. Select **Save and close**.

### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Set up inbound calling](voice-channel-inbound-calling.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
