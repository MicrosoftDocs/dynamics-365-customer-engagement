---
title: "Frequently asked questions (FAQs) about Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about the frequently asked questions (FAQs) for Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2020
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Frequently asked questions (FAQs) about Omnichannel for Customer Service

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## General

### What regions are supported?

See the list of supported regions at [International availability of Microsoft Dynamics 365](international-availability.md). 

### What platforms are supported?

You can find information about supported platforms and other prerequisites in [Prerequisites and system requirements of Omnichannel for Customer Service](system-requirements-omnichannel.md).

### Where can I submit an idea for a new feature or to enhance a feature?

Submit your ideas and feedback on our [Ideas forum](https://experience.dynamics.com/ideas/categories/list/?category=31047c64-7e28-e911-a95a-000d3a4f3883&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad).

### Is there a forum for me to engage with and discuss issues with the broader community?

Yes, our [Community Forum](https://community.dynamics.com/365/customerservice/f/763) is the place where you can engage with the community at large.

### How do I get help with the issues I face?

Contact [Dynamics support](https://dynamics.microsoft.com/contact-us/) to get help with your issues.

### What channels are supported with Omnichannel for Customer Service?

Some of the supported channels are WeChat, LINE, and Facebook. For the complete list of supported channels, see [Overview of channels](channels.md).

### Are Chat and the associated Omnichannel for Customer Service capabilities available as part of my Dynamics 365 Customer Service license?

No, Chat and related Omnichannel for Customer Service capabilities require a separate add-in. For additional details on pricing, see [Customer Service overview](https://dynamics.microsoft.com/customer-service/overview/).

### How do I get started?

If you would like to try out Chat for Dynamics 365 for free, sign up for a trial using these [Instructions](https://go.microsoft.com/fwlink/p/?linkid=2097211). Find [Get started](introduction-omnichannel.md) and [Prerequisites](system-requirements-omnichannel.md#prerequisites) for setting up Omnichannel in your organization.

## Agent experiences

### Can I use Chat for Dynamics 365 in the Customer Service Hub app module or any custom app module?

No. You can only use Chat in the **Omnichannel for Customer Service** app. The app module is available to users who have been provisioned as **Omnichannel agent**. To learn more, see [Sign in to Omnichannel for Customer Service](oc-sign-in-omnichannel.md).

### Can I work on cases along with chats?

Yes. You can work on cases alongside customer conversations in different sessions. You can open case sessions from the dashboards and grids using gestures. For more information on starting a session, see [Manage sessions in Omnichannel for Customer Service](oc-manage-sessions.md#start-a-session).

### Can I work on third-party communication widgets built using Dynamics 365 Channel Integration Framework in the Omnichannel for Customer Service app module? 

Omnichannel for Customer Service supports Chat for Dynamics 365 and SMS channels. You should continue to use the third-party communication widgets in the single-session Unified Interface apps like Customer Service Hub. Support for integrating third-party channels will come with [Dynamics 365 Channel Integration Framework v2](https://docs.microsoft.com/dynamics365-release-plan/2019wave2/dynamics365-customer-service/channel-integration-framework-v2).

### Can I open Omnichannel for Customer Service in multiple browser tabs and windows?

We recommend that you do not open Omnichannel for Customer Service in multiple browser tabs or windows. The app is inherently designed to help agents work in a multisession environment wherein each session has contextual application tabs. The sessions are not synced across browser tabs.

### What happens if I accidentally close the browser, refresh the entire page, or the browser crashes?

If you accidentally close your browsers, your currently open sessions and tabs opened inside them are lost; however, if you have entered some data on the model-driven forms where autosave has been enabled, they will be saved into model-driven apps.

Ongoing chat conversations appear on your Omnichannel Agent Dashboard. You can pick the chat from that dashboard and resume the conversation. The chat conversation is preserved, and you will be able to see the previous messages. If you were working on case sessions, you can reopen them using the gestures. For more information on starting a session, see [Manage sessions in Omnichannel for Customer Service](oc-manage-sessions.md#start-a-session).

### Does consult only work for managers/supervisors?

No. You can consult with any available agent in the queue from which the chat originated. The consult list shows you agents in the queue who can take additional chat requests.

### Can an agent who receives a consult also initiate a consult or transfer?

No. Only the primary agent of the chat can initiate transfers or consults. If the chat is transferred to another agent, the receiving agent will become primary and can initiate further transfers or consults.

### Why are my agents not receiving any new chats?

New conversation (chat) requests will be assigned to an agent when:

- There is a new incoming chat request.
- The incoming chat request is assigned to a queue that matches the agent’s assigned queues. You can see the queue and work stream for an incoming chat in the Omnichannel Conversation Dashboard.
- The agent present is set to an **Allowed Presence** for the workstream.
- The agent has capacity to receive the incoming chat from the workstream. Remaining capacity can be checked by tallying up the items assigned on the agent’s dashboard – including **Active** and **Wrap-up** – against the agent’s configured maximum capacity.

If more than one agent meets the above conditions, they will be assigned chats in this order:

-	The agent with the most remaining capacity will receive the chat first.
-	If multiple agents have the same remaining capacity, the agent who has not been assigned work item for a longer duration will receive the new conversation request.

### Who can see internal messages?

Agents and supervisors can see internal messages. The customer can’t see internal messages.

### What does the timer in the communication panel represent?

The timer in the communication panel represents how long the current session tab has been open. If the chat has moved into a wrap state, the timer will reset and increment accordingly to show the wrap time. If the conversation is closed and reopened later, the timer will reset.

### How do I open chats on my dashboard?

For information about managing work items from your dashboard, see [View agent dashboard and agent work items](oc-agent-dashboard.md).

### Where are conversations stored and how can I access them?

Conversations and sessions are stored as activity types within the Model-driven apps. For more information, see [View conversation and session activity types in the Model-driven apps](oc-view-activity-types.md).

## Administration

### How does Automated Record Identification work with pre-chat fields?

If you are using multiple fields for automated record identification, they must all be an exact match. To learn more, see [Automatically identify customers using pre-chat responses](record-identification-rule.md).

### What do I do if my dashboards (Omnichannel Agent Dashboard, Omnichannel Conversation Dashboard, Tier 1 Dashboard, Tier 2 Dashboard) aren’t showing up?

When you use the Omnichannel for Customer Service app on Unified Service Desk or on the web, the **Active Omnichannel Agent Dashboard** view doesn't show certain dashboards like **Tier 1 Dashboard**, **Tier 2 Dashboard**, **Knowledge Manager**, and **My Knowledge Dashboard**. To learn more, see [Dashboards don't appear in Omnichannel for Customer Service active dashboards view](troubleshoot-omnichannel-customer-service.md#dashboards-do-not-appear-in-omnichannel-for-customer-service-active-dashboards-view).

### How long do configuration changes to Omnichannel for Customer Service settings take to update?

Changes made by administrators within the Omnichannel Administration application can take up to 15 minutes to reflect.

### How can I bring custom entities, forms, and dashboards into the Omnichannel for Customer Service app? 

The Omnichannel for Customer Service app can be customized to include custom dashboards and custom forms the same as any Unified Interface app module. The sitemaps can be updated to include custom entities, and default forms can be changed to load custom ones for the entities. All Microsoft Dataverse entities and pages are compatible with the Omnichannel for Customer Service app. 

### Can I customize the Conversation Summary form?

This is currently not supported. Enabling customizations for the Conversation Summary Form is on our roadmap. 

### Why am I not able to see the Intraday Monitoring report and datasets in Power BI service while configuring intraday insights dashboard for supervisors?

Creation of the IntradayMonitoring report may take up to 15 mins to appear in your configured Power BI workspace. While configuring the Power BI workspace in Omnichannel Administration app, ensure that you have saved the configurations before you exit the configuration form. When you select Save, the creation of the report and dataset is initiated. If you missed to save the configuration, initiate the configuration for Supervisor Experience again. To learn more, see [Configure Intraday insights for Omnichannel for Customer Service app on web](configure-intraday-dashboard-supervisor.md#configure-intraday-insights-for-omnichannel-for-customer-service).

### What is the application ID field on the application user form?

The application ID is a mandatory field for creating application users in Dataverse. You can copy any application ID for any valid (non-expired) application created in Azure Active Directory for the same tenant into this field. 

## Supervisor experience

### Can I monitor conversations for all channels?

As of today, only chat conversations can be silently monitored by a supervisor.

### Why am I not able to see the supervisor dashboards in my app?

Check the following:

- Make sure that the Omnichannel supervisor role is assigned to the user.
- For the Power BI intraday dashboard, ensure that the dashboard is shared with the user both on Power BI service as well as in the Omnichannel app.

For more information, see [Configure Intraday Insights dashboard](configure-intraday-dashboard-supervisor.md). 

### Why are my Chat Insights and Sentiment dashboard reports empty?

By default, the reports are installed with only a data connection. Once you start using chat and sentiment features, you will see data come through.

### How far can I go back in the historical report?

A maximum of 12 months or the most recent 100,000 records. The limitation of 100,000 records is a Power BI data limitation.

### Can I customize reports?

Yes, you can customize the visualizations by editing the report in Power BI.

### How frequently does the data refresh?

The dataset for the Live Monitoring report is real time; if a report is refreshed or filters are changed, the data will be updated as per the current state of the system.

The dataset refresh interval for Intraday and Chat Insights reports depends on your settings in Power BI. To learn more, see [Configure Intraday Insights dashboard](configure-intraday-dashboard-supervisor.md) and Chat Insights set-up. 

### Why am I not able to see more than 100 agents while using filters in Omnichannel Ongoing Conversations dashboard?

By default, the application only displays 100 agents at any given time while filtering the conversation on the **Omnichannel Ongoing Conversations** dashboard. The list of 100 agents is displayed alphabetically. For example, you have 200 agents in your organization, and 100 agents have names that start with the letters A through D, the application only displays these agents. The rest of the agents with names that start with letters E through Z are not listed.

### What controls are in place to limit the exposure of agent performance KPIs within my organization?

These controls are in place for exposing the data in reports:

- Access to the Power BI reports is controlled by Power BI access roles, and sharing within the Omnichannel app. To learn more, see [Configure Intraday Insights dashboard](configure-intraday-dashboard-supervisor.md)
- Access to the Ongoing Conversation dashboard is controlled by the **Omnichannel supervisor** Dynamics role.
- Sentiment can be turned on or off in the Omnichannel Administration app. To learn more, see [Enable sentiment analysis](enable-sentiment-analysis.md) 

## Chat widgets

### Can we have the widget show on different pages or different websites?

The widget can show on any portal you want. You can copy the HTML script tag anywhere to make it appear on specific pages, a different Power Apps portals, or a custom portal as well. 

### If I have the widget on multiple pages or websites, what happens when I navigate across the pages with an ongoing chat?

The same widget will persist the chat as you cross different pages or websites.

## Routing and work distribution

### Can I route chats based on custom variables that we pass through code on my portal?

Yes, you can create custom context variables and create routing rules based on them. For more information, see the following:

- [Understand and create workstreams](work-streams-introduction.md)
- [Create and manage routing rules](/routing-rules.md)
- [Manage custom context](send-context-starting-chat.md)

### Can Omnichannel routing be used for other external channels (for example, my phone calls)?

No. Omnichannel routing can be used to route chat or SMS requests (in preview) only.

## SMS

### What information from a TeleSign account do I need to enter in the Omnichannel Administrator app?

You will need the customer ID, API key, and the phone number from your TeleSign account. This information needs to be provided in the Omnichannel Administrator app when you create or set up an SMS workstream.

### I get an error when I try to use the Validate API Key to validate the TeleSign account information entered in the Omnichannel Administration app. What should I do?

The Validate API Key functionality will validate the customer ID and the API key by trying to send a test SMS message to one of the numbers provided in the SMS Numbers tab. Ensure that the customer ID and API key are entered correctly, and the numbers provided in the SMS Numbers tab can receive the text messages that are sent for validation. The phone number should have the country code with no plus sign (+), spaces or special characters; for example, this would be correct: 14251234567

### How can I know if I can get a phone number from TeleSign in a specific country?

See the [TeleSign coverage map for Two-Way SMS](https://www.telesign.com/coverage-map/). For any additional queries, we recommend that you send an email request to support@telesign.com.

### Which phone number types are supported?

TeleSign supports long and short codes; the use of short codes with SMS messaging is supported as long as the customer is using an enterprise account.

### Can I have my customers send international texts?

Support for this scenario by TeleSign can vary based on geography. We recommend that you send an email request to support@telesign.com for your specific scenario if text messages need to be sent or received across countries.

### Can we communicate with customers using outbound SMS?

You can send messages to a customer only after the customer has initiated the conversation by sending a text message to the support number. If the conversation is not closed, you can send messages to the customer by opening the conversation.

### Does the SMS channel automatically identify the customer?

Yes, Omnichannel system will automatically identify the customer based on the incoming phone number. It will look for phone numbers in the Mobile Phone field of Contact records or the Phone field of Account records. Ensure that the phone number in these field has the country code along with the plus sign (+) without any spaces or special characters; for example: +14251234567

### Can we send automated SMS responses?

There are Power Automate connectors from SMS providers that can be used for automated SMS responses. For example, [TeleSign](https://preview.flow.microsoft.com/connectors/shared_telesignsms/telesign-sms/) has a connector for these scenarios.

### Is there anything unique about the way SMS messages are routed to agents?

All channels integrated into Omnichannel have the same routing capabilities, including SMS. You can create Routing rule items with conditions based on Account or Contact entities. Other entities (Case, Context variable, and SMS Engagement Context) are not supported at this time and should not be used for creating conditions in Routing rules items in an SMS workstream.

## Bot

### Can a third-party bot be integrated with Omnichannel through this feature?

Only bots created through [Microsoft Bot Framework](https://dev.botframework.com/) can be integrated at this time.


[!INCLUDE[footer-include](../includes/footer-banner.md)]