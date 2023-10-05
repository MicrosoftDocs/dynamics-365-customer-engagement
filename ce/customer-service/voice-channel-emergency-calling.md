---
title: Emergency calls in the voice channel
description: Use this article to understand how emergency calls work and how you can set up email recipients for emergency calls in Omnichannel for Customer Service.
author: gandhamm
ms.author: mgandham
ms.reviewer: nenellim
ms.date: 10/05/2023
ms.topic: how-to
ms.custom: bap-template
ms.collection:
---

# Emergency calls in the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This article describes how emergency calling works in Customer Service when agents dial an emergency number during crisis situations.

> [!NOTE]
>
> - Emergency calling is currently supported in the United States, Puerto Rico, and Canada only where the emergency calling number is 911.
> - If the [**Customize active conversation**](add-customer-summary-settings.md#manage-active-conversation-form-settings) form is enabled and an agent initiates an outbound call to emergency services, the active conversation form doesn't display the **Save** and **Refresh** options. 

## Prerequisites

Make sure that the following prerequisites are complete so that the emergency calls work properly:

- The omnichannel agent user has a capacity profile associated with a voice outbound profile. For more information, see [Configure capacity profiles](voice-channel-outbound-calling.md#configure-capacity-profiles-and-assign-users) and [Create outbound profiles](configure-outbound-inbound-profiles.md#create-outbound-profiles).
- Browser location setting is enabled, and set to United States or Puerto Rico.
- For the email notification, the [mailbox for the agents](/power-platform/admin/create-forward-mailboxes-edit-mailboxes) is enabled.
- For the emergency call to be handled, one of the following conditions must be fulfilled:
   - The number from which it originates must be a Microsoft calling plan number.
   - When the Azure Communication Services resource (tenant) has both direct routing (third-party public switched telephone network (PSTN) carrier number) and at least one direct offer (Microsoft calling plan number) enabled and there's no direct routing rule for the emergency number, the call will follow the direct offer path and will be routed to our direct offer emergency calling service. More information: [Voice routing considersations](/azure/communication-services/concepts/telephony/direct-routing-provisioning#voice-routing-considerations)

## How emergency calls work

In Customer Service workspace or Omnichannel for Customer Service, agents can use the dialer to call the emergency number during a crisis.

Here's how the emergency calls work:

1. The agent calls the emergency number such as 911 in the United States or Puerto Rico.
1. The agent status automatically changes to "Do not disturb," irrespective of the current status.
1. A temporary callback number is assigned to the agent for a duration of 60 minutes. 
1. If the emergency call is dropped or gets disconnected, then the emergency responder can call back the agent via this callback number. The emergency callback gets the highest priority, bypassing all configured routing rules, capacity profiles, and presence settings.
1. During the ongoing emergency conversation, the **Communication Panel** displays the device settings and the **End call** button only. An alert appears indicating that an emergency call is in progress.
1. To ensure confidentiality, the application doesn't record or store the outgoing and incoming emergency calls as activities in call history.
1. If you configure emergency contacts, an automated email message goes out to the contacts when the agent dials the emergency number.
1. When the agent ends the emergency call, the agent presence changes back to the prior status.

> [!NOTE]
> If you use a third-party PSTN carrier, discuss the behavior with the carrier and then configure.

## Set up email recipients

When the agent makes an emergency call, the system can send an automated email to their supervisors or whoever needs to be informed about the call to ensure efficient emergency responder access. The system uses the **Emergency Call Notification Template** to send the email. You can use the **Editor** to modify the template.

1. In the Customer Service admin center, go to **User management** under **Customer support**, and for **Users**, select **Manage**.
1. On the page that appears, select the **Omnichannel Users** view, and then select the user that you want to update.
1. Select the **Omnichannel** tab, and in **Emergency Call Notifications**, add the email addresses of the recipients separated by a semicolon.
1. Save the changes.


### See also

[Set up outbound calling in the voice channel](voice-channel-outbound-calling.md)  
[Set up inbound calling in the voice channel](voice-channel-inbound-calling.md)  
[Customize email template using template editor](/power-apps/user/cs-template-options?context=%2Fdynamics365%2Fcontext%2Fcustomer-service-context)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
