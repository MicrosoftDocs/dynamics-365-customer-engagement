---
title: Concept topic template #Required; page title displayed in search results. Don't enclose in quotation marks.
description: Concept description #Required; article description that's displayed in search results. Don't enclose in quotation marks. Do end with a period.
author: rhanajoy #Required; your GitHub user alias, with correct capitalization.
ms.author: rhcassid #Required; your Microsoft alias; optional team alias.
ms.reviewer: kfend #Required; Microsoft alias of content publishing team member.
ms.topic: conceptual #Required; don't change.
ms.collection: get-started #Required; If this isn't a getting started article, don't remove the attribute, but leave the value blank. The values for this attribute will be updated over time.
ms.date: 08/06/2024
ms.custom: bap-template #Required; don't change.
---


# Configure a WhatsApp channel through Twilio

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

You can use the WhatsApp channel feature to engage with customers who prefer to communicate using WhatsApp.

The success of social media customer service, like all other customer service, depends on the quality of care provided. Communications from agents should be timely, accurate, sensitive, brief, and friendly, which ultimately improves the customer satisfaction and brand loyalty.

## WhatsApp message types and 24-hour session rule

- **Template messages:** Are the outbound messages that agents send one of the preapproved templates? They're typically transactional messages, such as delivery alerts and appointment reminders, sent to users who have opted in to receive messages from your organization. For messages requiring localization, you must get the message approved by WhatsApp in each language. For more information about WhatsApp message templates, see [WhatsApp documentation](https://developers.facebook.com/docs/whatsapp/message-templates/).

- **Session messages:** According to WhatsApp, session messages are incoming messages from a customer or outgoing replies by an agent to the incoming messages, within 24 hours. A messaging session starts when agents receive a message from a customer. It lasts for 24 hours from the most recently received message. Session messages don't need to follow a template, and can include media attachments.

- **24 hours session rule:** A messaging session starts when an agent receives a message from a customer or replies to the incoming message from the customer. When the customer sends a message, the agent has 24 hours to reply from the time the agent received it. However, after 24 hours, the agent can send a message to customer only by using a predefined and approved template.

## Configure WhatsApp channel

You can configure WhatsApp channel through Twilio or Azure Communication Services. You can do this in the following ways:

- [Configure a WhatsApp channel through Twilio](../administer/configure-whatsapp-channel-twilio.md)
- [Configure a WhatsApp channel through Azure Communication Services](../administer/configure-whatsapp-acs.md)

