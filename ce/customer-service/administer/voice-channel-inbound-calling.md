---
title: Set up inbound calling for the voice channel
description: Learn about how to set up workstreams and queues for inbound calling in the voice channel in Dynamics 365 Contact Center.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.date: 12/14/2024
ms.topic: how-to
ms.custom: bap-template 
---

# Set up inbound calling


[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

Configure inbound calling to set up the voice channel in Dynamics 365. You can enable your customer service representatives to communicate with customers on the phone to resolve issues using the voice channel.

## Prerequisites

Ensure that the following prerequisites are met:

- Voice channel is provisioned. Learn more in [Provision channels](/dynamics365/contact-center/implement/provision-channels#set-up-channels)
- Unified routing is enabled. Learn more in [Provision unified routing](provision-unified-routing.md)
- Acquire a phone number. See: [Manage phone numbers](voice-channel-manage-phone-numbers.md).

## Set up a voice workstream

> [!IMPORTANT]
> If the enhanced voice experience is available for your region, you can create new workstreams that support the [voice-enabled Copilots](/microsoft-copilot-studio/voice-overview). For existing deployments, make sure that you [update your existing workstreams](migrate-voice-workstream.md) to support voice Copilots.

Do the following to configure a workstream for voice:

1. On the left pane, select **Workstreams**, and then on the **Create a workstream** dialog, enter the following.

2. Enter the following details for the workstream:

    - **Name:** An intuitive name, such as Contoso voice workstream.
    - **Type:** Select **Voice**.

    > [!Note]
    > By default, **Owner** and **Channel** are predefined and unavailable, and only push is available for work distribution mode.

3. Select **Create**. The workstream that you created is displayed.

    ![Workstream for voice](../media/voice-workstream.png "Workstream for voice")

## Configure a voice channel

To configure the voice channel, you need to associate the workstream with a phone number for routing the calls. You can view the list of available phone numbers by selecting **Phone numbers** in the left pane. 

1. Go to the workstream that you created, and on the page that appears, select **Set up voice**.

2. On the **Phone number** page, select a number from the list, and select **Next**.

    > [!NOTE]
    >
    > - Only those numbers are displayed that have inbound calls enabled and are not already associated with any other workstream. Use the steps in [Acquire a phone number](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers) if you want to configure a new number.    
    > - The voice channel supports anonymous inbound calls on those numbers only that are configured via Azure Communication Services direct routing.

3. On the **Language** page, select **Add primary language** and perform the steps to configure the primary language. Learn more in [Allow customers to choose a language](#add-a-phone-number-to-the-workstream-and-configure-language-settings).

4. On the **Behaviors** tab, turn on the **Customer wait time** toggle, and select the following options:

   - Notify position in queue [Notify position in queue](show-queue.md)
   - Notify average wait time [Notify average wait time](average-wait-time.md)

5. Turn on the **Channel operating hours** toggle, and select an operating hour record. Learn more in [Configure operating hours for your business](create-operating-hours.md)

6. Configure the settings for transcription and recording of the calls in the **Transcription and recording** area. Learn more in [Configure call recordings and transcripts](voice-channel-configure-transcripts.md)

7. Select **Add** for **Custom automated messages**, then select a default template message as the trigger, and then enter the custom automated message text. For information about automated messages, see [Configure automated messages](configure-automated-message.md)

8. Turn on the toggle for the customer service representatives (service representatives or representatives) to be able to transfer calls and consult with external numbers and Microsoft Teams users.  See [Transfer calls to external numbers and Teams users](#transfer-calls-to-external-numbers-and-teams-users).

10. On the **Summary** page, select **Save and close**.

The phone number is associated with the workstream.

:::image type="content" source="../media/voice-workstream-configured.png" alt-text="Configured workstream for voice":::

## Add a phone number to the workstream and configure language settings

1. In the Customer Service admin center or Contact Center admin center app, go to the voice workstreams, and then select the workstream to configure the phone number.

1. Select **Edit** next to the pencil icon, and then on the **Voice settings** page, select the number to add to the workstream, and then select **Next**.

1. On the **Language** tab, select **Add primary language**. A language page is displayed, where you set the primary language for the channel. You can add more languages to this voice channel, and each language has its own settings.
   The **Primary language** is the first language the agent uses to greet the customer. Your organization can have one phone number that services multiple languages, rather than have multiple phone numbers, each with one language, and then ask customers to call the right number.

1. Select the type of hold and wait music you want the customer to hear.

1. In Voice profile, select a voice, voice style, speaking speed, and pitch for the agent.

   > [!IMPORTANT]
   > Make sure that you select a neural voice because standard voice is deprecated as on August 31, 2024. For existing voice workstreams, Microsoft Dynamics 365 team would have migrated the settings for you automatically by end of July, 2024. Learn more in [Upgrade to Text-to-Speech Neural Voice  by 31 August 2024](https://azure.microsoft.com/updates/we-re-retiring-the-standard-voice-on-31-august-2024/)
1. Turn on the **Post-call survey** toggle if you want the agent to present a survey to the customer at the end of the call. If this feature is turned on, the call will automatically get transferred to the survey agent after the representative hangs up.

1. After you finish configuring the settings, select **Confirm**.

## Transfer calls to external numbers and Teams users

You see the following transfer and consult options:

- **Enhanced voice options**: Actions available for workstreams created in or migrated to the enhanced voice experience.
- **Existing voice options**: Actions available for workstreams that aren't migrated to the enhanced voice channel.

> [!NOTE]
> In the embedded and standalone experiences of Dynamics 365 Contact Center, the enhanced voice options only are available.


### [Enhanced voice](#tab/enhancedvoice)


  1. Set the toggles for **External phone number** and **External Microsoft Teams users** in **Consult** and **Transfer**. This allows representatives to consult with other representatives or Teams subject matter experts during an ongoing call, and also enables them to transfer calls.
  2. Select the **Use bridged transfers** checkbox. The following actions occur when a representative transfers a call to an external phone number or a Microsoft Teams user:
     - Call ends for the primary representative as soon as the secondary representative or Teams user accepts or rejects a call.
     - The caller ID on the call to the external number is the Dynamics phone number.
     - The customer hears a transfer message followed by hold music. The original call continues.
     - The recording and transcription continue when the call is transferred.
     - Customers can't send Dual Tone Multi Frequency (DTMF) inputs to external numbers. 
     - Post conversation survey, if configured, is triggered once the external representative or Teams user hangs up.<br>
  3. If the **Use bridged transfers** checkbox isn't selected, the following actions occur when a representative transfers a call to an external phone number or a Microsoft Teams user:
     - Call ends for the primary representative as soon as the secondary representative or Teams user accepts or rejects a call.
     - The caller ID on the call to the external user is the customer's phone number.
     - The customer hears a transfer message followed by ringing. A new call begins.
     - Customers can send DTMF inputs to external numbers. 
     - The recording and transcription is stopped.
     - Post conversation call survey isn't sent to the customer.

> [!NOTE]
> If you are a Direct Routing customer, when the **Use bridged transfers** checkbox isn't selected you need to configure your Session Border Controller to accept a "REFER-TO: sip.pstnhub.microsoft.com", and convert it to an INVITE that's sent back to sip.pstnhub.microsoft.com for the transfer to complete. Learn more at [Call Transfer](/azure/communication-services/concepts/telephony/direct-routing-sip-specification#call-transfer).
   
### [Existing voice](#tab/existingvoice)

 Turn on the **Call transfer to external phone number** toggle to allow representatives to transfer the call to an external number.

   :::image type="content" source="../media/voice-channel-workstream-summary.png" alt-text="Summary settings of the voice channel workstream":::

 Turn on the toggle for **Consult with Microsoft Teams user** to enable the representatives to consult other representatives on Microsoft Teams. Learn more in [Voice consult with a Microsoft Teams user](voice-consult-microsoft-teams-user.md)

---

## Create queues for voice channels

In Dynamics 365 Contact Center or Dynamics 365 Customer Service, work items are assigned to a queue and representative with the help of unified routing. Unified routing is an intelligent, scalable, and enterprise grade routing and assignment capability that can assign the incoming work item to the best suited queue and representative while adhering to work item requirements and matching them with the representative's capabilities using round robin routing. Learn more in [Overview of unified routing](overview-unified-routing.md)

In this section, we cover information on how to create a queue for the voice channel and routing rules to evaluate conditions and assign work items.

### Create a queue for the voice channel

In the left pane, select **Queues**, and then complete the following steps to create a queue for the voice channel:

1. On the **Queues** page, select **New**, and on **Create a queue** dialog, enter the following details.

    - **Name**: Specify a name.
    - **Type**: Select **Voice**.
    - **Group number**: Enter a number.

1. Select **Create**. The queue is created.

1. On the queue page, select **Add users**, and on the **Add users** flyout menu that appears, select the users and select **Add**.


   > [!NOTE]
   >  - You can add only those users who are configured for unified routing.
   >  - After 20 minutes of being added to a queue, representatives must refresh their dashboards to be able to receive calls.

   ![Configure queue for voice.](../media/queue-for-voice.png "Configure queue for voice")

## Configure user input recognition

The Voice channel supports DTMF recognition to allow representatives to provide input to IVR and service representatives using the phone keypad. This is supported through Azure Communication Services. Learn more in [Gathering user input with Recognize action](/azure/communication-services/how-tos/call-automation/recognize-action?pivots=programming-language-csharp) to configure DTMF recognition.

The supported configurations for the voice channel are as follows:

- representatives can send DTMF input to a phone number in the E.164 format only.
- representatives must use the dialpad icon to send DTMF input.
   :::image type="content" source="../media/transfer-dtmf.png" alt-text="Screenshot of external dialpad icon":::
- Representatives can send the following DTMF tones:

   ```

    private readonly static HashSet<string> ValidDTMFValues = new HashSet<string> 

    { 

     "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "#", "A", "B", "C", "D" 

    }; 
 
  ```

 > [!NOTE]
 > The DTMF input isn't supported if the call is transferred to an external phone number in the existing voice experience.

### Configure call overflow for the voice queue

With call overflow, you can reduce the wait time for customer calls by setting options for voice queues. Learn more in [Manage overflow](manage-overflow.md)

### Assignment rules for a queue

By default, the assignment method for a voice queue is round robin. In the round robin method, work items are prioritized in the order they enter the queue. Among the representatives who match skills, presence, and capacity, work is assigned to representatives in the order they're listed. The representative listed on the top is assigned first. You can also choose highest capacity or create custom assignment methods. Learn more in [Assignment methods](assignment-methods.md)

For a simple and quick voice call routing, you don't need to set up any rules for unified routing. By default, all the incoming voice calls are routed to the "default voice queue" and will be assigned to the representatives with the round robin assignment method.

## Configure routing rules for the voice workstream

Go to the workstream for which you've configured the voice channel and do the following steps:

1. In the **Routing rules** area, in the **Route to queues** option, select **Create ruleset**.

2. On the **Created route-to-queues ruleset** dialog, provide a name and description, and then select **Create**.

3. On the page that appears, select **Create rule**.

4. On the **Create rule** page, enter a rule name, and in **Conditions**, define the set of conditions using the conversation entity and related entity attributes.

5. In **Route to queues**, select the queue that you created and to which the voice call must be routed when the conditions specified are met.


6. To configure percentage-based distribution of work items, see [Percentage-based allocation of work to queues](configure-route-to-queue-rules.md#percentage-based-allocation-of-work-to-queues)

7. Select **Create**. The rule is created and appears in the list of rules.

8. Create as many rules as your business requires.

## Configure work classification rules

You can configure work classification rules for the voice workstream to add detailed information to incoming work items. This information can be used to route the calls optimally. Learn more in [Configure work classification](configure-work-classification.md)

### Related information

[Overview of voice channel](voice-channel.md)  
[Overview of unified routing](overview-unified-routing.md)  
[Assignment methods](assignment-methods.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Configure outbound and inbound profiles](configure-outbound-inbound-profiles.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Use voicemail to handle overflow of calls](voice-channel-voicemail.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
