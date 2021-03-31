---
title: "Configure a chat channel | MicrosoftDocs"
description: "Instructions to configure a chat channel in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 09/03/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Configure a chat channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Chat is a widely desired channel through which customers prefer to reach customer support. Customers appreciate being able to chat with human agents when self-service options don’t allow them to solve their own issues. 

Dynamics 365 Customer Service offers full featured, first-party chat capabilities for agents to support customers. Chat transcripts from Power Virtual Agents or other live agents and pre-conversation survey data transfers to live agents to maintain full context of the customer issue as it moves between channels and people. Agents can help customers in the language of their choice with real-time translation, and escalate to voice and video if a visual demonstration and audio are needed to help customers. Features like quick replies, whisper, barge, consult, and transfer to other agents ensure agents can handle any workflow while chatting with customers.  

A chat widget lets your customers connect with your customer service agents and resolve their queries quickly.

In this section, you will learn how to:

- [Add a chat widget](add-chat-widget.md)
- [Configure agent display name](agent-display-name.md)
- [Configure a pre-chat survey](configure-pre-chat-survey.md)
- [Configure file attachment capability](configure-file-attachment.md)
- [Embed chat widget in your website or portal](embed-chat-widget-portal.md)

> [!NOTE]
> The chat widget requires session storage and local storage to be functional in your customers’ browsers. Make sure to notify your customers to enable cookies in their browsers so these services can work properly.

## Disclaimer

Microsoft automatically collects data to improve the reliability and performance of our products and to understand how the products are being used. This information is used to make improvements to the product capabilities over time. The live chat widget in Chat for Dynamics 365 collects telemetry automatically from end users to serve the same purposes. 

Examples of data collected in the live chat widget:

| Data | Example value |
|---------------|------------------------|
| OrganizationId | 8e9071c2-4415-47aa-b1cb-693631e7fafb |
| Chat Widget Version | prod |
| BrowserName | Edge |
| OSName | Windows |
| Scrubbed IP Address (last octet redacted) | 19.207.000.000 | 
    
No personally identifiable information (PII) is collected.  

If your organization is concerned about the data collected by this service, you have the option to turn off automatic data collection by adding an html attribute to the chat widget script. 

`"data-enable-telemetry" = "false"`

### Videos

[Overview of Chat for Dynamics 365 Customer Service](https://go.microsoft.com/fwlink/p/?linkid=2097416)

To view more videos on Omnichannel for Customer Service, see [Videos](videos.md).


[!INCLUDE[footer-include](../includes/footer-banner.md)]
