---
title: Introduction to the chat channel
description: Learn about the chat channel to quickly resolve customer queries with features like quick replies, whisper, barge, consult, and transfer.
ms.date: 02/05/2025
ms.topic: conceptual
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.collection:
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/28/2023
---

# Introduction to the chat channel

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

Chat is a widely desired channel through which customers prefer to reach customer support. Customers appreciate being able to chat with customer service representatives (service representatives or representatives) when self-service options don’t allow them to solve their own issues.

Dynamics 365 Customer Service offers full featured, first-party chat capabilities for service representatives to support customers. Chat transcripts from Copilot Studio or other live representatives and pre-conversation survey data transfers to live agents to maintain full context of the customer issue as it moves between channels and people. Agents can help customers in the language of their choice with real-time translation, and escalate to voice and video if a visual demonstration and audio are needed to help customers. Features like quick replies, whisper, barge, consult, and transfer to other agents ensure agents can handle any workflow while chatting with customers.

A chat widget lets your customers connect with your customer service agents and resolve their queries quickly.

You'll learn how to:

- [Add a chat widget](add-chat-widget.md)
- [Configure agent display name](agent-display-name.md)
- [Configure a pre-conversation survey](configure-pre-chat-survey.md)
- [Configure file attachment capability](configure-file-attachment.md)
- [Embed chat widget in your website or portal](embed-chat-widget-portal.md)

> [!NOTE]
> The chat widget requires session storage and local storage to be functional in your customers’ browsers. Make sure to notify your customers to enable cookies in their browsers so these services can work properly.

## Disclaimer

Microsoft automatically collects data to improve the reliability and performance of our products and to understand how the products are being used. This information is used to make improvements to the product capabilities over time. The live chat widget in Chat for Dynamics 365 collects telemetry automatically from end users to serve the same purposes. 

A few examples of data collected by the live chat widget are as follows.

| Data | Example value |
|---------------|------------------------|
| OrganizationId | 11bb11bb-cc22-dd33-ee44-55ff55ff55ff |
| Chat Widget Version | prod |
| BrowserName | Edge |
| OSName | Windows |
| Scrubbed IP Address (last octet redacted) | 19.207.000.000 | 
    
No personally identifiable information (PII) is collected.  

If your organization is concerned about the data collected by this service, you have the option to turn off automatic data collection by adding an html attribute to the chat widget script. 

`"data-enable-telemetry" = "false"`

### Videos

To view videos on Omnichannel for Customer Service, see [Videos](../use/videos.md).

## Next steps

[Add a chat widget](add-chat-widget.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
