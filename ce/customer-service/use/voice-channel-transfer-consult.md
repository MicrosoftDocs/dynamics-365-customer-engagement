---
title: Transfer calls and consult with users
description: Use this article to understand how the agent can use the transfer and consult options to make and receive customer calls.
ms.date: 04/12/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---

# Transfer calls and consult with users in the voice channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

You can transfer calls or consult with other agents or supervisors to collaborate with them on questions that you might have when you're on a call with a customer. 

To familiarize yourself with the call controls, see [Understand how to use the agent dashboard and call controls](/dynamics365/contact-center/use/voice-channel-agent-experience).

## Prerequisite

The settings to transfer the calls and consult with another agent is enabled by your administrator.

## Transfer calls

When you receive an incoming call, you can transfer the call to an agent, a queue, a public switched telephone network (PSTN) Teams user, or an external PSTN number. After you transfer the call, the following actions occur:

 - The customer is automatically put on hold. Hold music plays for the customer. 
 - By default, the customer is automatically removed from hold once a secondary agent accepts the transferred call. If the **Un-hold customer after agent transfer is accepted** setting is disabled, the primary agent must manually remove the customer from hold.

1. Select **Transfer** in the call window. 

    :::image type="content" source="../media/oc-transfer-scn.png" alt-text="A screenshot of the transfer option.":::
   
   The **Transfer** dialog appears. The **Queue**, **Teams**, and **Number pad** tabs are displayed.
  
    :::image type="content" source="../media/oc-transfer-options.png" alt-text="A screenshot of the transfer to options.":::

1. Based on your requirement, perform one of the following steps.

    - **Transfer to a queue**: Select **Queue**, search for the queue you want to transfer the call to, and then select **Transfer**. The customer is put on hold. The agent who picks up the transferred call becomes the primary agent and you become the secondary agent and are removed from the call.<br>
      > [!NOTE]
      > - When you transfer a call to a queue that doesn't have any agents, the application automatically ends the call and sets the status to Closed.
      > - If you transfer a call from a phone number linked to an inbound or outbound profile to a queue with a Copilot Studio agent, the agent can only speak to the customer and end the call. The agent can't transfer the call to another agent or external number, even when you have configured the Escalation topic in Copilot Studio.

        :::image type="content" source="../media/oceh-cc-transfer-queue-list.png" alt-text="A screenshot of the transfer to queue.":::
    
    - **Transfer to an external PSTN number or Teams user**: Select **Number pad**. On the number pad that appears, enter the customer's area or region code, phone number, and then select **Call** to make your call. 
    -  **Transfer to Teams user**: Select **Teams**, and use the search option to search for a Microsoft Teams user. The results are filtered based on the name and the live presence of the users in Microsoft Teams. <br> 
    
    The transfer and consult behaviors depend on the voice channel experience your administrator configured.

    > [!NOTE]
    > In the embedded and standalone experiences of Dynamics 365 Contact Center, the enhanced voice options only are available.


    ### [Enhanced voice](#tab/enhancedvoicestack)

    When you initiate a transfer, the application ends the call for you as soon as the Teams user or user with the external number accepts or rejects the call. You don't need to press a button to leave the call. To make sure that the secondary agent answers the call, you can use the **Consult** option to collaborate with the secondary agent before transferring the call.
     
    The customer hears a transfer message and the following actions occur based on the **Use bridged transfers** setting:
    - **Enabled**
       - Customer hears hold music.
       - The original call continues. 
       - If the external user doesn't accept the call, customers hear a system message before the call ends.
       - Post call survey is sent to the customer if the external user or Teams user ends the call.
    - **Disabled**
       - Customer hears ringing.
       - The original call ends and a new call begins.
       - Customers don't hear a message before the call ends if the external user doesn't accept the call.

    ### [Existing voice](#tab/existingvoicestack)
 
    If you selected the external PSTN number or Teams to transfer the call, you can speak with the secondary agent who picks up the call, while the customer is on hold. To complete the call transfer, you must select the transfer button next to the secondary agent name in the call window. The secondary agent is now the primary agent and you're removed from the call. However, the secondary agent is disconnected from the call if you as the primary agent don't complete the transfer within eight minutes.
     
    > [!NOTE]
    > The call recording and transcript of the conversation with the Teams user after transfer is saved in the application for reporting and compliance.


## Use consult to collaborate with other agents or supervisors

The consult option allows you to collaborate with another agent, a supervisor, or an external participant (either a PSTN number or a Teams PSTN number). You can initiate a chat, a call consult, or both.

When you initiate a consult, the following actions occur:
- You're the primary agent. 
- You can search for agents to consult within the same queue or other queues. Additionally, you can filter agents within a queue based on their skills. The application displays the agents whose skills match the selected criteria in full or partially, along with their name, and current presence status.
- The customer is automatically put on hold. Hold music plays for the customer.
- When the invited collaborator joins the call, they have a consult role. Consulting on a call doesn't affect the collaborator's available capacity.
- The primary agent must manually remove the customer from hold. During a consult, the primary agent can choose to transfer the call to the new participant. 
- If the primary agent ends the call, the call ends for everyone. 
- If the primary agent refreshes their browser, all the participants are placed on hold until the primary agent returns to the call. 

**Consult with another user**

1. Select **Consult** in the call window. 

    > [!div class="mx-imgBorder"]
    > ![Image of consult icon on the call controls](../media/oc-consult-btn.png)<br>
   
   The **Consult** dialog box appears. The **Agent**, **Teams**, and **External number** tabs are displayed.
    > [!div class="mx-imgBorder"]
    > ![Available Consult options](../media/oc-consult-optns.png)<br>

1. Based on your requirement, perform one of the following steps.

    - **Consult with an internal agent or supervisor**: Select **Agent**. You can either have a call or chat with an internal agent or supervisor. Select the conversation channel and then search for the agent you'd like to consult with.<br>

   - **Consult with external PSTN number**: Select the **Number Pad**. On the number pad that appears, enter the customer's area code, phone number, and then select **Call** to make your call. 
     By default, the consultation is private. The customer is on hold while the primary agent speaks with the new participant. You can also have a public consultation, where the customer is actively involved in the conversation by taking them off hold. <br>

   - **Consult with Teams user**: Select **Teams** and use the search option to search for and select the Microsoft Teams user you'd like to consult with. Learn more at [Enable voice consult with Microsoft Teams users](../administer/voice-consult-microsoft-teams-user.md).

        > [!div class="mx-imgBorder"]
        > ![Screenshot of Teams consult](../media/oc-consult-teams.png)<br>

   - **Consult, then transfer**: The primary agent who initiated the consult can transfer the call to any participant involved in the consult. To transfer a conversation to the consulting agent in the conversation, perform the following steps:
       - If the consult is with an external participant (PSTN or Teams user), select **Transfer** next to the external phone number or Teams user name at the top of the call window. If your administrator didn't enable **Use bridged transfers**, the external user receives a new call request from the customer, and the customer hears a message that they're being transferred, then the ringing sound.  If your administrator enabled **Use bridged transfers**, the current call continues between the external user and the customer, and the original agent is dropped from the call.
       - If the consult is with an internal agent or a supervisor, select **Transfer** on the call controls. The application displays the **Agent** tab with the agent or supervisor in the consult. 
    
    The call recording and transcript of the conversation with the Teams user during consult is saved in the application for reporting and compliance.

### Related information

[Overview of the voice channel](../administer/voice-channel.md)  
[Enable voice consult with Microsoft Teams users](../administer/voice-consult-microsoft-teams-user.md)  
[Call a customer](voice-channel-call-customer.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
