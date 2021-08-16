---
title: "Use the voice channel in the agent dashboard | MicrosoftDocs"
description: "Use this topic to understand agent experience in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/13/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ROBOTS: NOINDEX,NOFOLLOW
---

# Preview: Use the voice channel in the agent dashboard 

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
>
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>
> [!INCLUDE[cc-preview-features-send-us-feedback](../includes/cc-preview-features-send-us-feedback.md)]>

## Call controls

The conversation panel in the agent interface includes the following controls that you can use when you call or answer a phone call from a customer.

> [!div class="mx-imgBorder"]
> ![Screenshot of call controls](./media/voice-channel-call-controls.png)

- **Mute** - Select to mute your microphone so your voice is not audible to the customer.
- **Hold** - Select to put the customer on hold; the customer hears the hold music.
- **Consult** - Select to consult or bring in another agent or supervisor into the call. You can have a *public* consult where the customer is actively involved in the conversation; you can also have a *private* consult where you can put the customer on hold before you talk to your peers or supervisor.
- **Transfer (to agent or queue)** - Select to transfer the call to another agent or queue. During a transfer to queue, the customer is automatically put on hold.
- **End** - Select to end the call.
- **More actions (...)** - This dropdown includes the following controls:
    - **Show number pad** - Select to open the number pad, so you can view or dial a number.
    - **Mark number as spam** - Select to [report the incoming call as spam](#report-a-phone-number-as-spam). If you happened to accidentally mark a number as spam, you can select the **Unmark as spam** option.
    - **Device settings**
    - **Take notes** - You can take any important or specific notes regarding your conversation with the customer. Note that this is in addition to the call recording and transcription that happen during the conversation.
    - **Pause transcription** - If you do not want to capture some details of the conversation, such as bank details, billing, or payment information, you can temporarily pause the transcription and later resume it.
    - **Knowledge Articles** - Select this option to get a list of knowledge base articles pertaining to the conversation, that you can use to resolve the customer issue.
    - **Link to conversation**

## Report a phone number as spam

When you receive a phone call and you want to report the number as spam *while on the call*, you can do so immediately via the call controls on your conversation panel. A notification is then sent to your administrator for review and further action.

To report a phone number as spam, select the ellipsis to open more actions and select **Mark number as spam**.

You can add notes that'll help your administrator review and block numbers. After you mark a number as spam, it goes into the pending review tab on the **Blocked numbers (preview)** page.

### See also

[Overview of the voice channel](voice-channel.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
