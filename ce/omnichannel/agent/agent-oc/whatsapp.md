---
title: "WhatsApp channel agent experience in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about WhatsApp channel through Twilio agent experience in Omnichannel for Customer Service."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 04/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Use WhatsApp channel

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## WhatsApp channel overview

When you sign in to Omnichannel for Customer Service, you can see your work items in Omnichannel Agent Dashboard. To learn more see [View agent dashboard and agent conversations (work items)](oc-agent-dashboard).

## Prerequisite

Make sure your administrator has configured a WhatsApp channel through Twilio.

### Incoming WhatsApp notification

You receive a notification for a WhatsApp conversation request. When you accept the WhatsApp request, a session is started, and the communication panel appears where you can exchange messages with the customer.

> [!div class=mx-imgBorder]
> ![WhatsApp chat agent notification](../../media/fb-agent-notif.png "WhatsApp chat agent notification")

In Omnichannel for Customer Service, you can:

- [View customer summary](agent/agent-oc/oc-customer-summary.md)
- [View communication panel](agent/agent-oc/oc-conversation-control.md)
- [Use call options and visual engagement in live chat](agent/agent-oc/call-options-visual-engagement.md)
- [Monitor real-time customer sentiment](agent/agent-oc/oc-monitor-real-time-customer-sentiment-sessions.md)
- [Manage sessions](agent/agent-oc/oc-manage-sessions.md)
- [Manage applications](agent/agent-oc/oc-manage-applications.md)
- Use productivity tools
    - [Use agent scripts](agent/agent-oc/oc-agent-scripts.md)
    - [View Smart assist](agent/agent-oc/oc-smart-assist.md)
    - [Use productivity pane](agent/agent-oc/oc-productivity-pane.md)
- [Create a record](agent/agent-oc/oc-create-record.md)
- [Search, link, and unlink a record](agent/agent-oc/oc-search-link-unlink-record.md)
- [Search for and share knowledge articles](agent/agent-oc/oc-search-knowledge-articles.md)
- [Take notes specific to conversation](agent/agent-oc/oc-take-notes.md)
- [Understand conversation states](agent/agent-oc/oc-conversation-state.md)
- [Manage presence status](agent/agent-oc/oc-manage-presence-status.md)
- [Search for transcripts](agent/agent-oc/oc-search-transcipts.md)
- [View conversation and session forms](agent/agent-oc/oc-view-activity-types.md)
- [View customer summary for an incoming conversation request](agent/agent-oc/oc-view-customer-summary-incoming-conversation-request.md)
- [Search for transcripts](agent/agent-oc/oc-search-transcipts.md)

## WhatsApp message type and 24 hours session rule

- **Session messages:** According to WhatsApp, session messages is a type of message that are incoming messages from a customer, or outgoing replies that you send to the incoming messages, within 24-hours. A messaging session starts when you receive a message from a customer, and lasts for 24 hours from the most recently received message. Session messages do not need to follow a template, and can include media attachments.

- **24 hours session rule:** A messaging session is starts when you receive a message from a customer or replies to the incoming message from the customer. When the customer sends a message, from the time you received it, you have 24 hours to reply to the customer. However, after 24 hours, if you try to send a message to the customer, an error is displayed - **This conversation has exceeded the 24 hour limit to respond to the customer.**.

## See also

[Configure a WhatsApp channel](../../administrator/configure-whatsapp-channel.md)