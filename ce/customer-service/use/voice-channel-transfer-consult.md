---
title: Transfer calls and consult with users
description: Use this article to understand how customer service representatives can use transfer and consult options to make and receive customer calls in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
ms.date: 10/20/2025
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# Transfer calls and consult with users in the voice channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

You can transfer calls or consult with other service representatives or supervisors to collaborate with them on questions that you might have when you're on a call with a customer. 

To familiarize yourself with the call controls, see [Understand how to use the agent dashboard and call controls](/dynamics365/contact-center/use/voice-channel-agent-experience).

## Prerequisites

- To transfer the calls to another service representative, the [transfer to representative](../administer/enable-transfer-consult.md) setting is enabled by your administrator.
- To transfer calls to an external PSTN number or a Teams user, the transfer settings must be enabled in the voice channel instance settings.

## Transfer calls

When you receive an incoming call, you can transfer the call to a service representative, a queue, a public switched telephone network (PSTN) Teams user, or an external PSTN number. After you transfer the call, the following actions occur:

- The customer is automatically put on hold. Hold music plays for the customer.
- By default, the customer is automatically removed from hold after a secondary service representative accepts the transferred call. If the **Un-hold customer after representative transfer is accepted** setting is disabled, the primary service representative must manually remove the customer from hold.

1. Select **Transfer** in the call window.

    :::image type="content" source="../media/oc-transfer-scn.png" alt-text="A screenshot of the transfer option.":::
   
   The **Transfer** dialog displays **Representatives**, **Queue**, **Teams**, and **External number** tabs.   

1. Based on your requirement, perform one of the following steps.

    - **Transfer to a representative**: On the **Representative** tab, search for the representative you want to transfer the call to. Select the representative from the search results, and then select **Transfer**. The customer is put on hold. The representative who picks up the transferred call becomes the primary representative and you become the secondary representative and are removed from the call. Your capacity and presence status are updated accordingly.
    - **Transfer to a queue**: Select **Queue**, search for the queue you want to transfer the call to, and then select **Transfer**. The customer is put on hold. The representative who picks up the transferred call becomes the primary representative and you become the secondary and are removed from the call.
    
      > [!NOTE]
      > - When you transfer a call to a queue that doesn't have any service representatives, the application automatically ends the call and sets the status to Closed.
      > - If you transfer a call from a phone number linked to an inbound or outbound profile to a queue with a Copilot agent, the agent can only speak to the customer and end the call. The agent can't transfer the call to another agent or external number, even when you have configured the Escalation topic in Copilot Studio.

        :::image type="content" source="../media/voice-call-transfer-to-representative-mini.png" alt-text="Screenshot of selecting a representative to transfer the call." lightbox="../media/voice-call-transfer-to-representative.png":::
    
    - **Transfer to an external PSTN number or Teams user**: Select **External number**. On the number pad that appears, enter the customer's area or region code, phone number, and then select **Call** to make your call. 
    -  **Transfer to Teams user**: Select **Teams**, and use the search option to search for a Microsoft Teams user. The results are filtered based on the name and the live presence of the users in Microsoft Teams. <br> 
    
    The transfer and consult behaviors depend on the voice channel experience your administrator configured.

    > [!NOTE]
    > In the embedded and standalone experiences of Dynamics 365 Contact Center, the enhanced voice options only are available.

    ### [Enhanced voice](#tab/enhancedvoicestack)

    When you initiate a transfer, the application ends the call for you as soon as the Teams user or user with the external number accepts or rejects the call. You don't need to press a button to leave the call. To make sure that the secondary service representative answers the call, you can use the **Consult** option to collaborate with the secondary representative before transferring the call.
     
    The following actions occur based on the **Use bridged transfers** setting:
    - **Enabled**
       - Customer hears hold music.
       - The original call continues.
       - Recording and transcription continue if they aren't manually paused.
       - If the external user doesn't accept the call, customers hear a system message before the call ends.
       - Post call survey is sent to the customer if the external user or Teams user ends the call.
       - The external user receives the call from the caller ID of the contact center phone number the customer originally called.
       - DTMF tones aren't sent from the customer to the external phone number.
    - **Disabled**
       - Customer hears ringing.
       - The original call ends and a new call begins.
       - The new call isn't recorded and transcribed.
       - Customers don't hear a message before the call ends if the external user doesn't accept the call.
       - The external user receives the call from the caller ID of the customer.
       - DTMF tones are sent from the customer to the external phone number.

    ### [Existing voice](#tab/existingvoicestack)
 
    If you selected the external PSTN number or Teams to transfer the call, you can speak with the secondary representative who picks up the call, while the customer is on hold. To complete the call transfer, you must select the transfer button next to the secondary representative name in the call window. The secondary representative is now the primary representative and you're removed from the call. However, the secondary representative is disconnected from the call if you as the primary service representative don't complete the transfer within eight minutes.
     
    > [!NOTE]
    > The call recording and transcript of the conversation with the Teams user after transfer is saved in the application for reporting and compliance.

## Use consult to collaborate with other representatives or supervisors

The consult option allows you to collaborate with another representative, a supervisor, or an external participant (a PSTN number or a Teams PSTN number). You can initiate a chat, a call consult, or both.

When you initiate a consult, the following actions occur:
- You're the primary representative.
- You can search for representatives to consult within the same queue or other queues. Additionally, you can filter representatives within a queue based on their skills. The application shows representatives whose skills fully or partially match the selected criteria, along with their name and current presence status. You can add multiple representatives to the consult.
- The customer is automatically put on hold. Hold music plays for the customer.
- When the invited collaborator joins the call, they have a consult role. Consulting on a call doesn't affect the collaborator's available capacity. You can also add multiple collaborators to the consult.
- When you have multiple participants in a consult, you can manage each participant individually:
    - Place consulting representative on hold. Select the hold control next to any consulting participant to place them on hold individually. The consulting representative hears hold music while on hold.
    - Transfer to specific consulting representatives. Use the transfer controls positioned next to each consulting participant to transfer the call directly to that specific representative within the consult. 
    - When you initiate a consult with an external participant, the system allows Dual-tone multi frequency inputs. The primary representative can also remove the consulting external participant from the call. 
- The primary representative must manually remove the customer from hold. During a consult, the primary representative can choose to transfer the call to the new participant.  When more than one participant joins a consult, the system shows the customer as "off hold" to all representatives who aren't currently on hold in the consult.
- If the primary representative or customer ends the call, the call ends for everyone. 
- If the primary representative refreshes their browser, all the participants are placed on hold until the primary representative returns to the call. 


**Consult with another user**

1. Select **Consult** in the call window. 

    :::image type="content" source="../media/oc-consult-btn.png" alt-text="Image of consult icon on the call controls.":::
   
   The **Consult** dialog box appears. The **Agent**, **Teams**, and **External number** tabs are displayed.

   :::image type="content" source="../media/oc-consult-optns.png" alt-text="Screenshot of available consult options.":::

1. Based on your requirement, perform one of the following steps.

    - **Consult with an internal agent or supervisor**: Select **Agent**. You can either have a call or chat with an internal agent or supervisor. Select the conversation channel and then search for the representative you'd like to consult with.<br>

   - **Consult with external PSTN number**: Select the **Number Pad**. On the number pad that appears, enter the customer's area code, phone number, and then select **Call** to make your call. 
     By default, the consultation is private. The customer is on hold while the primary representative speaks with the new participant. You can also have a public consultation, where the customer is actively involved in the conversation by taking them off hold. <br>

   - **Consult with Teams user**: Select **Teams** and use the search option to search for and select the Microsoft Teams user you'd like to consult with. Learn more at [Enable voice consult with Microsoft Teams users](../administer/voice-consult-microsoft-teams-user.md). If you've migrated to the enhanced voice experience, PSTN doesn't appear on the Teams tab. Enter the phone number of the Teams user directly in the external transfer tab.

   - **Consult, then transfer**: The primary representative who initiated the consult can transfer the call to any participant involved in the consult. To transfer a conversation to the consulting representative in the conversation, perform the following steps:
       - If the consult is with an external participant (PSTN or Teams user), select **Transfer** next to the external phone number or Teams user name at the top of the call window. If your administrator didn't enable **Use bridged transfers**, the external user receives a new call request from the customer, and the customer hears a message that they're being transferred, then the ringing sound.  If your administrator enabled **Use bridged transfers**, the current call continues between the external user and the customer, and the original representative is dropped from the call.
       - If the consult is with an internal representative or a supervisor, select **Transfer** on the call controls. The application displays the **Agent** tab with the representative or supervisor in the consult. 
    
    The call recording and transcript of the conversation with the Teams user during consult is saved in the application for reporting and compliance.

### Related information

[Overview of the voice channel](../administer/voice-channel.md)  
[Enable voice consult with Microsoft Teams users](../administer/voice-consult-microsoft-teams-user.md)  
[Call a customer](voice-channel-call-customer.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
