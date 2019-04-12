---
title: "What's new in Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn about the what's new in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 03/15/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: B8D892A6-C186-406F-AA68-A10903943EF1
ms.custom: 
---

# What's new in Omni-channel Engagement Hub

##  What's new in March 2019 Update

This topic contains information about updates in Omni-channel Engagement Hub available in this version.

## Administrator experience

### Data masking

You can block sensitive data such as credit card information, social security numbers (SSN), or even profanity in a conversation by using data masking. You can create a masking rule and define a regular expression in it to identify the sensitive information and replace it with the masking character. More information: [Create and manage data masking rules](administrator/data-masking-settings.md).

### Visitor location detection

You can configure your chat widget to detect a visitor's location based on their latitude and longitude. If you have enabled location detection, a visitor receives a prompt in their web browser when they start to chat. If a visitor allows the location to be shared, the location is detected. Agents can then use this information to provide a personalized support experience. More information: [Set up visitor location detection](administrator/geo-location-provider.md).

### Agent display name configuration

To protect an agent's privacy, you can configure your chat widget to display either full name, first name, last name, or nickname of an agent to the customers. If you would like to hide your agent's identity and anonymize, choose to display the nickname. More information: [Configure agent display name](administrator/agent-display-name.md).

### Simplified configuration experience for administrators

With this release, the administrators can now configure varied customer experiences separately for chat and entity channels.

More information:</br>
[Configure a chat channel](administrator/set-up-chat-widget.md) and
[Configure an entity channel](administrator/create-entity-channel.md)

Configure context variables and routing rules in work streams to ensure that conversations are distributed to appropriate agents. 

More information: 
[Understand and create work streams](administrator/work-streams-introduction.md) </br>

## Agent experience

### Unlink a record (case, contact, and account) from a conversation

You can unlink a record (case, contact, and account) from a conversation while you are interacting with the customer. You can unlink inline on the **Customer profile** and **Issue snapshot** form and link any other required record.

More information: [Unlink a record from the conversation](agent/agent-usd/link-unlink-record.md#unlink-a-record-from-the-conversation) and [Unlink a record from the conversation](agent/agent-csh/csh-link-unlink-record.md#unlink-a-record-from-the-conversation).

## Developer experience

Use the Live Chat JavaScript APIs to programmatically control the visibility of the live chat widget, pass additional user context and enable user identification when hosting the widget on custom websites or portals.