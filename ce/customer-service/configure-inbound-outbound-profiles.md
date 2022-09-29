---
title: "Configure inbound and outbound profiles | MicrosoftDocs"
description: "Use this article to understand how you can configure inbound and outbound profiles in your organization."
ms.date: 10/03/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.custom: 
  - intro-internal
---

# Configure inbound and outbound profiles

## Create inbound profiles

1. In Customer Service admin center, In the site map, select **Productivity** in **Agent experience**.

1. On the **Productivity** page, select **Manage** for **Outbound and inbound profiles**.

1. Select **New profile**.

1. On the **Create new profile** dialog, enter a profile name, select the profile type as **Inbound**, and then select **Next**.

1. On the **Phone number** page, select a personal number in the **Number** list, and select **Next**.

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

You can define the way outbound calls are made and also who can make them. To create an outbound profile, you'll need a phone number that's enabled for outbound calling. This means that in your calling plan for that number, the **Make calls** checkbox must be selected.

1. In Dynamics 365, go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)    
   
     1. In the site map, select **Productivity** in **Agent experience**.
     2. On the **Productivity** page, select **Manage** for **Outbound and inbound profiles**.
   
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
    - In the site map, select **Agent experience** in **Advanced settings**, and then select **Manage** for **Outbound and inbound profiles**

1. Select **New profile**.

1. On the **Create new profile** dialog, in the **Profile settings** section, enter a profile name in **Profile name**, select **Outbound** in **Profile type**, and select **Next**.

1. In **Phone number**, select a phone number in the **Shared numbers** list, and select **Next**.
    
  > [!Note]
  > The phone numbers list shows only those numbers that are enabled for outbound calling and aren't used as a personal user phone number. If you don't see any numbers in the list, you'll need to [configure a number for outbound calling](#configure-phone-numbers-for-outbound-calling).

1. In **Outbound info**, do the following:
   
   - **Number label**: Indicates the label displayed with the phone number at the agent end when you call a customer, indicating a business context such as Billing. This value is automatically populated with the phone name string on the agent dialer and can be edited.
    - **Queue**: Select a queue from the dropdown list. The list shows only voice type queues, so if you don't see any queues in the list, you'll need to [create a voice type queue](voice-channel-inbound-calling.md#create-queues-for-voice-channels).
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

### Edit profiles

1. On the **Outbound and inbound profiles** page, select a profile from the list and select **Edit**. On the **Edit profile settings** dialog, update details in the required sections.

1. The **Advanced settings** section that's available only after you save a profile, select the default templates for session, consult notification, and transfer notification. For information on session and notification templates, see [Manage session templates](../app-profile-manager/session-templates.md) and [Manage notification settings and templates](../app-profile-manager/notification-templates.md).

1. Select **Save and close**.

### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Set up inbound calling](voice-channel-inbound-calling.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
