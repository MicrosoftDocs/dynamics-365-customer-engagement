---
title: Introduction to the chat channel
description: Learn how to use the chat channel in Dynamics 365 Customer Service and Dynamics 365 Contact Center to help customers with chat features such as quick replies, consult, transfer, whisper, and barge.
ms.date: 07/31/2026
ms.topic: overview
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.collection:
ms.custom: bap-template
---

# Introduction to the chat channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

Chat is a popular channel that customers use to contact customer support. Customers can chat with customer service representatives (service representatives) when self-service options don't resolve their issues.

Dynamics 365 Customer Service provides first-party chat capabilities that help customer service representatives support customers. Chat transcripts from Copilot Studio or their peers and pre-conversation survey data transfer to live representatives to maintain full context of the customer issue as it moves between channels and people. They can help customers in the language of their choice with real-time translation, and escalate to voice and video if a visual demonstration and audio are needed to help customers. Features such as quick replies, whisper, barge, consult, and transfer help representatives collaborate with other customer service representatives and manage customer conversations efficiently.

A chat widget lets your customers connect with your customer service representatives and resolve their queries quickly.

You'll learn how to:

- [Add a chat widget](add-chat-widget.md)
- [Configure agent display name](agent-display-name.md)
- [Configure a pre-conversation survey](configure-pre-chat-survey.md)
- [Configure file attachment capability](configure-file-attachment.md)
- [Embed chat widget in your website or portal](embed-chat-widget-portal.md)

> [!NOTE]
> The chat widget requires session storage and local storage to be functional in your customers’ browsers. Make sure to notify your customers to enable cookies in their browsers so these services can work properly.

## Telemetry and data collection

Microsoft automatically collects data to improve the reliability and performance of our products and to understand how the products are being used. This information is used to make improvements to the product capabilities over time. The live chat widget in Chat for Dynamics 365 collects telemetry automatically from end users to serve the same purposes. 

A few examples of data collected by the live chat widget are as follows.

| Data | Example value |
|---------------|------------------------|
| OrganizationId | 11bb11bb-cc22-dd33-ee44-55ff55ff55ff |
| Chat Widget Version | prod |
| BrowserName | Edge |
| OSName | Windows |
| Scrubbed IP address (last octet redacted) | 19.207.000.000 | 
    
No personally identifiable information (PII) is collected.  

If your organization is concerned about the data collected by this service, you have the option to turn off automatic data collection by adding an html attribute to the chat widget script. 

```html
data-enable-telemetry="false"
```
### Videos

Learn more about Omnichannel for Customer Service in [Videos](../use/videos.md).

## Next steps

[Add a chat widget](add-chat-widget.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
