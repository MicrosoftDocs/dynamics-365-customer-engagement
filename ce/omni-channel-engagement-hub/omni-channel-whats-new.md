---
title: "What's new in Omni-channel Engagement Hub | MicrosoftDocs"
description: "Learn about what's new in Omni-channel Engagement Hub."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 05/03/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: B8D892A6-C186-406F-AA68-A10903943EF1
ms.custom: 
---

# What's new in Omni-channel Engagement Hub

##  What's new in April 2019 update

This topic contains information about updates in Omni-channel Engagement Hub available in this version.

### Administrator experience

- **Upgrade Omni-channel Engagement Hub**: Upgrade to the latest version of Omni-channel Engagement Hub to unlock the benefits of new features. You can now upgrade to the latest release of Omni-channel Engagement Hub from the **Manage Instances** page in **Dynamics 365 Admin Center**. More information: [Upgrade Omni-channel Engagement Hub](administrator/upgrade-omni-channel.md)

- **Integrate a bot**: Integration of a bot built using Microsoft Bot Framework, with Omni-channel Engagement Hub helps to provide automated responses in a conversational manner to a customer. If required, the bot can also escalate the customer query to a customer service agent and provide the information collected from the customer to the agent. Using a bot will ease the load on your customer service agents by handling basic queries so they can work on more complex issues. More information: [Integrate a bot](administrator/configure-bot.md)

- **Configure an SMS channel**: Configure an SMS channel to connect to your customers by using text messages. Your customers can now send their queries as text messages and connect with an appropriate customer service agent. This provides your customers the flexibility to connect with their mobile devices even if there is no internet connection for connecting to a chat channel. To enable SMS channel in your organization, you must register and create your account with TeleSign. SMS channel uses public APIs of TeleSign to send and receive text messages. More information: [Configure an SMS channel](administrator/configure-sms-channel.md) 

- **Omni-channel Engagement Hub packages**

    - **Unified Service Desk - Omni-channel Engagement Hub - Preview - Add-on**: Use this sample package if you have an existing deployment of Unified Service Desk and want to start using Omni-channel Engagement Hub with it. This package installs Unified Service Desk solutions with minimal configuration data for Omni-channel Engagement Hub to work with an existing Unified Service Desk in the specified Customer Engagement organization.

    - **Unified Service Desk - Omni-channel Engagement Hub – Preview**: Use this sample package if you want to start using a new Unified Service Desk environment with Omni-channel. This package installs Unified service desk solutions and Omni-channel supported solutions (Web resources) that are required to work with Unified Service Desk in the specified Customer Engagement organization. This package provides basic configuration data.

More information: [Deploy Unified Service Desk - Omni-channel Engagement Hub package](administrator/omni-channel-engagement-hub-package.md)

### Agent experience

- **Omni-channel Engagement Hub Agent interface**: The Omni-channel Engagement Hub app for Dynamics is a cloud-based service that enables organizations to instantly connect and engage with their customers via channels like Live Chat and SMS. The app provides context rich multi-tasking experience across different customer interactions. Some of the key value propositions are as follows: 

    - **Unified experience**: The app provides unified and consistent experience for the agents to access Line-of-Business applications from within the Omni-channel Engagement Hub app.

    - **Multi-session and application management**: The app enables agents to handle multiple customer sessions and contextual applications related to the sessions with ease, which in-turn leads to faster case resolution and customer satisfaction.

    - **Single-view interface**: The app provides agents the a single-view experience where agents can view the customer information and communication details simultaneously and side-by-side.

    - **Operating system agnostic**: The app is agnostic operating systems and also works seamlessly on modern browsers like Microsoft Edge and Google Chrome.

   > [!div class=mx-imgBorder]
   > ![Omni-channel Engagement Hub app interface](media/oceh/oceh-whats-new.png "Omni-channel Engagement Hub app interface")

    The key features of agent interface are:

    - **Switch between multiple sessions**: As an agent, you might engage with several customers simultaneously but managing all the customer sessions is a challenge, especially switching between the sessions while understanding the context of the engagement. With Omni-channel Engagement Hub, the session panel helps you to switch between multiple customer sessions simultaneously while preserving customer context and resolve issues faster and achieve higher productivity.

    More information: [Manage sessions](agent/agent-oceh/oceh-manage-sessions.md)

    - **Enhance productivity using the application tab**: With a simplified experience, the application tab allows you to manage the applications like KB search, advanced search, access sitemap, within the context of the customer session. This helps the agents to switch between the customer sessions with relevant customer information and context leading to higher productivity.
    
    More information: [Manage applications](agent/agent-oceh/oceh-manage-applications.md)

More information: [Agents using Omni-channel Engagement Hub app](agent/agent-oceh/oceh-omni-channel-engagement-hub-agent.md)

- **Communication panel enhancements**

    - **Search for consulting participants**: In the communication panel, you can use the keyboard command to launch the consult fly-out. Once the fly-out is displayed, continue to type the agent name in the communication panel to quickly find and initiate consult.

    More information: [View communication panel](agent/agent-oceh/oceh-conversation-control.md#search-for-consulting-participants)

    - **Search agents or queues for the transfer of a conversation request**: In the communication panel, you can use the keyboard command to launch the transfer fly-out. Once the fly-out is displayed, continue to type the agent or queue name in the communication panel to quickly find and initiate the transfer of the conversation request.

    More information: [View communication panel](agent/agent-oceh/oceh-conversation-control.md#search-agents-or-queues-for-the-transfer-of-a-conversation-request)

### System customizer experience

- **Configure Omni-channel experience with the Add-On package**: When you deploy the Omni-channel Engagement Hub – Preview – Add-on package, you can configure the basic components for agents to use Omni-channel Engagement. Learn how to configure the following components:

    - [Omni-channel agent dashboard](customizer/configure-agent-dashboard.md)
    - [Advanced search](customizer/configure-advanced-search.md)
    - [Communication panel](customizer/configure-communication-panel.md)
    - [Customer summary](customizer/configure-customer-summary.md)
    - [Notifications](customizer/configure-notification-screen-pop-agents.md)
    - [Session name information](customizer/configure-session-name-information.md)
    - [Scriptlets to define the case and channel titles](customizer/configure-Scriptlets-define-case-channel-titles.md)

### Developer experience

- **Enable a bot to escalate and end conversation**: Omni-channel Engagement Hub provides developers the capability to integrate bots that can start a conversation with a customer and if required, programmatically escalate the conversation to a human agent. More information: [Enable a bot to escalate and end conversation](developer/bot-escalate-end-conversation.md).

- **Extend Omni-channel Engagement Hub app for agents:** The Omni-channel Engagement Hub app is built on the Unified Interface framework, which enables the developers to customize and extend the third-party applications. These applications are shown in the application tab menu.

##  What's new in March 2019 update

This topic contains information about updates in Omni-channel Engagement Hub available in this version.

### Administrator experience

- **Data masking**: You can block sensitive data such as credit card information, social security numbers (SSN), or even profanity in a conversation by using data masking. You can create a masking rule and define a regular expression in it to identify the sensitive information and replace it with the masking character. More information: [Create and manage data masking rules](administrator/data-masking-settings.md)

- **Visitor location detection**: You can configure your chat widget to detect a visitor's location based on their latitude and longitude. If you have enabled location detection, a visitor receives a prompt in their web browser when they start to chat. If a visitor allows the location to be shared, the location is detected. Agents can then use this information to provide a personalized support experience. More information: [Set up visitor location detection](administrator/geo-location-provider.md)

- **Agent display name configuration**: To protect an agent's privacy, you can configure your chat widget to display either full name, first name, last name, or nickname of an agent to the customers. If you would like to hide your agent's identity and anonymize, choose to display the nickname. More information: [Configure agent display name](administrator/agent-display-name.md)

- **Simplified configuration experience for administrators**: With this release, administrators can now configure varied customer experiences separately for chat and entity channels. More information: [Configure a chat channel](administrator/set-up-chat-widget.md) and [Configure an entity channel](administrator/create-entity-channel.md)

    Configure context variables and routing rules in work streams to ensure that conversations are distributed to appropriate agents. More information: [Understand and create work streams](administrator/work-streams-introduction.md)

### Agent experience

- **Unlink a record (case, contact, and account) from a conversation**: You can unlink a record (case, contact, and account) from a conversation while you are interacting with the customer. You can unlink inline on the **Customer profile** and **Issue snapshot** form and link any other required record. More information: [Unlink a record from the conversation](agent/agent-usd/link-unlink-record.md#unlink-a-record-from-the-conversation) and [Unlink a record from the conversation](agent/agent-oceh/oceh-search-link-unlink-record.md)


### Developer experience

- **Live chat SDK**: Use the Live Chat JavaScript APIs to programmatically control the visibility of the live chat widget, pass additional user context, and enable user identification when hosting the widget on custom websites or portals. More information: [Live chat SDK JavaScript API reference](developer/omni-channel-reference.md).

### See also

[Upgrade Omni-channel Engagement Hub](administrator/upgrade-omni-channel.md)
