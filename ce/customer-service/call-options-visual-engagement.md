---
title: "Call options and visual engagement in live chat in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn how to use visual engagement, such as co-browse and screen sharing, and elevating a chat conversation to voice and video call in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 05/26/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Call options and visual engagement in live chat

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Call options in live chat

With calling options in a live chat conversation, you can initiate a voice or video call while you're communicating with the customer over chat.

As an agent, you exchange a lot of information when you communicate with a customer via chat. This can slow down your effort to resolve the customer's issue. The customer might prefer to show you the problem and explain the issue by using a physical product. In these scenarios, you might want to initiate a voice or video call during the chat conversation to resolve the issue quickly. The calling options in the communication panel help you to easily make these calls.

### Advantages of voice and video call in live chat

With calling options in live chat, you can:

- Resolve customer issues quickly.
- Reduce your average handling time (AHT) and improve your productivity.
- Improve customer satisfaction.
- Develop a positive relationship with customers.

## Prerequisites

Make sure that the following prerequisites are met:

- **Browser:** Latest version of Microsoft Edge or Google Chrome. For more information, see the [Supported browsers for live chat widget](system-requirements-omnichannel.md#browsers-for-chat).
- **Internet bandwidth:**
  - **Minimum:** 500 KBps upload speed; 1 MBps download speed
  - **Recommended:** 1 MBps  upload speed; 2 MBps download speed

### Initiate voice and video call

When you're chatting with the customer, you can initiate a voice or video call. In the communication panel, beside the **End** button, select More commands ![More commands](media/ellipsis.png "More commands"). The **Voice Call** and **Video Call** options are displayed. (Depending on your system configuration, you might see **Voice Call** and **Video Call**, or just **Voice call**.)

> [!div class=mx-imgBorder]
> ![Voice and video call](media/chat-voice-video-call.png "Voice and video call")

When you initiate a voice call, you can view the flyout call control, which includes the following buttons.

|Button | Name | Description |
|----------------------|-------------------------|-----------------------------|
|![Turn on or off video](media/turn-on-off-video.png "Turn on or off video")| Turn on video / Turn off video |  Use this button to turn on or off the video while in a call with the customer.|
|![Mute and unmute](media/mute-unmute.png "Mute and unmute")| Mute / Unmute | Use this button to mute or unmute the call while in a call with the customer. |
|![End call](media/end-call.png "End call")| End call | Use this button to end the call. |

> [!div class=mx-imgBorder]
> ![Agent experience of a voice call during live chat](media/chat-voice-call.png "Agent experience of a voice call during live chat")

> [!Note]
> If your organization is in the Government Community Cloud (GCC) region, the audio and video calls will be transmitted via a North American data center. 

### Capacity of the agent

When you initiate a voice or video call, your capacity is consumed, and you can't take any conversation requests until you hang up. However, your supervisor can still assign conversations to you.

### Site permissions

As an agent, you need to enable camera and microphone access in the browser to make a video and audio call, respectively.

## Customer experience

When a customer on the portal receives a call, they can accept the voice call with audio, accept the voice call with video, or reject the call.

> [!div class=mx-imgBorder]
> ![Customer experience of a voice call during live chat](media/call-accept.png "Customer experience of a voice call during live chat")

After accepting the call, the customers can view and use the following options.

|Button | Name |
|----------------------|-------------------------|
|![Turn on or off video](media/turn-on-off-video.png "Turn on or off video")| Turn on video / Turn off video | 
|![Mute and unmute](media/mute-unmute.png "Mute and unmute")| Mute / Unmute | 
|![End call](media/end-call.png "End call")| End call | 


After accepting the call, the customer can turn on or off the video, mute or unmute the conversation, and end the call.

> [!div class=mx-imgBorder]
> ![Customer experience of a video call during live chat](media/calling2.png "Customer experience of a video call during live chat")

### Site permissions

Customers need to provide the camera and microphone access in the browser.

## Co-browse and screen share in live chat

The co-browsing and screen sharing features help you quickly and easily understand the customer's issue while communicating with the customer via chat channel. These visual engagement channels allow agents to interact with customers within their browsers for a precise and effective support experience. This integration capability allows agents to initiate a third-party co-browse or screen sharing session from the chat conversation. 

> [!Important]
> Third-party providers of co-browse or screen share capabilities may have separate pricing and licensing requirements. Before enabling and using these features through third-party applications, ensure you understand the terms of using these applications.

## Prerequisite

To use the co-browsing and screen sharing features, your administrator must have selected a third party screen sharing and/or co-browse provider.

### Initiate a co-browsing or screen sharing session

When you're chatting with a customer, you can initiate a co-browsing or screen sharing session by doing the following: 

1. Select the computer icon (co-browse or screen share) next to the **End** button in the communication panel. 

    An app tab opens, providing a way to sign in to the third-party provider and create a new session.

   > [!Note]
   > The sign-in experience will vary depending upon the co-browse or screen share provider selected by your administrator. Refer to the third-party provider's documentation for more information about initiating co-browsing or screen sharing sessions.

3. In the communication panel, share the password or pin with the customer that you received from the provider. 

4. Ask the customer to enter the password or PIN, if applicable, and accept the invitation to co-browse or share their screen.

    > [!div class=mx-imgBorder]
    > ![Agent requests a co-browse session during live chat](media/third-party-co-browse-agent-chat.png "Agent requests a co-browse session during live chat")

Once the customer accepts your invitation, you will be able to see the customer's screen and more accurately diagnose the issue.

When you enter a co-browse session, you can:

- See the customer's screen.
- Use a laser pointer to call attention to important items.
- Navigate and make changes within the customer's browser.

When you enter a screen sharing session, you can:

- See the customer's screen.
- Use a laser pointer to call attention to important items. 

The customer experience will vary depending upon the co-browse or screen share provider selected by your administrator.

## See also

[Add a chat widget](add-chat-widget.md)
