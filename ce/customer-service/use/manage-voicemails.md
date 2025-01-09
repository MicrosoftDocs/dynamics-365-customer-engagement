---
title: Manage voicemails
description: Use this article to know about how to access and listen to voicemails as a customer service representative.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.date: 03/07/2024
ms.custom: bap-template
---
# Manage voicemails

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

As a customer service representative, you can access the voicemails recorded by customers on your direct inward dial number or through work items that have been routed to you.

## Manage the voicemails that you receive

You can view the voicemails in one of the following ways:

- On the **Customer Service Agent Dashboard**, in **My Open Activities**, select the vertical ellipses, and then select **Other Activities** > **Voicemail**.
- On the **Omnichannel Agent Dashboard**, in **Open work items**, select the vertical ellipses for your number, and then select **Assign to me**.
- If an inbox is configured for you, you can view the assigned and unassigned voicemails. Go to your inbox, and select **Assigned voicemails**, and then select the voicemail that you want to hear. If you access an unassigned voicemail and then close it, you won't be able to access it again.

:::image type="content" source="../media/open-voicemail.png" alt-text="View and listen to voicemails":::

You can do the following tasks for the voicemail that you open:

- **Regarding**: Set the regarding of the voicemail. If you create a case from the voicemail, the application displays the case in this field.
- **Customer**: If the customer isn't automatically identified, set the customer of the voicemail.
- **Save**: Save changes to the voicemail. Some settings require an explicit save action.
- **Close Voicemail**: Moves the voicemail to the closed state.
- **Return Call**: Displays a dialer with the customer number automatically filled in if you have outbound profiles configured. More information: [Outbound profiles](../administer/configure-outbound-inbound-profiles.md)
- **Add to Queue**: Add the voicemail to a different queue. If the voicemail is routed to a pick workstream, it will be available as a pick item in the new queue.  If the voicemail is routed to a push workstream, it will be assigned to a customer service representative in the new queue.
- **Convert to Case (preview)**: <br>

  [This option is in preview and is subject to change.] <br>

  > [!IMPORTANT]
  > - This is a preview feature. 
  > - Preview features aren’t meant for production use and may have restricted functionality. These features are available before an official release so that customers can get early access and provide feedback. <br>

  Creates a case from a voicemail in open state. The application displays the case form and enables you to specify the relevant details required to create a case. You can see the case in the **Regarding** field. The state of the voicemail doesn't change when you create a case. The voicemail remains in the open state until you close it. If you create more than one case from the same voicemail, only the latest case is shown.<br>

- **Call Recording**: Select the tab to view the original voice call recording that preceded the voicemail. If the call goes straight to voicemail and the customer didn't talk to a bot, a recording or transcript won't be available on this tab.  Additionally, if your voice workstream was set to  have transcription only and the customer talked to a bot, you won't see a call recording here, only the transcript will be available.
- **Download audio**: Select to download the voicemail.
- **Share**: Select to email or copy the link to the voicemail. You can also manage the user access to the voicemail.

## Next steps

[Transfer calls and consult with other users](voice-channel-transfer-consult.md)  
[View call recordings and transcripts](voice-channel-call-recordings-transcripts.md)  
