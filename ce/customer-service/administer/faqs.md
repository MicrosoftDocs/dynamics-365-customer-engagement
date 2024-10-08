---
title: FAQ about Omnichannel for Customer Service
description: Learn about the frequently asked questions (FAQ) on the different features in Omnichannel for Customer Service and their requirements.
ms.date: 01/09/2024
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
---

# FAQ about Omnichannel for Customer Service

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## General

### What regions are supported?

See the list of supported regions at [International availability of Microsoft Dynamics 365](../implement/international-availability.md). 

### What platforms are supported?

You can find information about supported platforms and other prerequisites in [Prerequisites and system requirements of Omnichannel for Customer Service](../implement/system-requirements-omnichannel.md).

### Where can I submit an idea for a new feature or enhancement?

Submit your ideas and feedback on our [Ideas forum](https://experience.dynamics.com/ideas/categories/list/?category=31047c64-7e28-e911-a95a-000d3a4f3883&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad).

### Is there a forum for me to engage with and discuss issues with the broader community?

Yes, our [Community Forum](https://community.dynamics.com/forums/thread/?groupid=25cd05f7-e478-4843-beb5-9ecf4b3e1f74) is the place where you can engage with the community at large.

### How do I get help with the issues I face?

Contact [Dynamics support](https://dynamics.microsoft.com/contact-us/) to get help with your issues.

### What channels are supported with Omnichannel for Customer Service?

Some of the supported channels are WeChat, LINE, and Facebook. For the complete list of supported channels, see [Overview of channels](../use/channels.md).

### Are Chat and the associated Omnichannel for Customer Service capabilities available as part of my Dynamics 365 Customer Service license?

No, Chat and related capabilities in Omnichannel for Customer Service require a separate add-in. For more information about licenses and pricing, see the [Dynamics 365 licensing guide](https://go.microsoft.com/fwlink/p/?LinkId=866544). You can also purchase add-ins on the [Microsoft 365 admin center](https://go.microsoft.com/fwlink/?LinkId=866544). More information: [Buy add-ons](/microsoft-365/commerce/buy-or-edit-an-add-on?view=o365-worldwide&preserve-view=true)

### How do I get started?

If you would like to try out Chat for Dynamics 365 for free, sign up for a trial using these [Instructions](../use/channels.md). Find [Get started](../implement/introduction-omnichannel.md) and [Prerequisites](../implement/system-requirements-omnichannel.md#prerequisites) for setting up Omnichannel for Customer Service in your organization.

## Agent experience

### In which apps can I use Chat for Dynamics 365?

You can use Chat in the Omnichannel for Customer Service and Customer Service workspace apps.

### Can I work on cases along with chats?

Yes. You can work on cases alongside customer conversations in different sessions. You can open case sessions from the dashboards and grids using gestures. For more information on starting a session, see [Manage sessions in Omnichannel for Customer Service](../use/oc-manage-sessions.md#start-a-session).

### Can I work on third-party communication widgets built using Dynamics 365 Channel Integration Framework in the Omnichannel for Customer Service app module? 

Omnichannel for Customer Service supports Chat for Dynamics 365 and SMS channels. You should continue to use the third-party communication widgets in the single-session Unified Interface apps like Customer Service Hub. Support for integrating third-party channels is available in [Dynamics 365 Channel Integration Framework v2](../../channel-integration-framework/v1/administer/overview-channel-integration-framework.md).

### Can I open Omnichannel for Customer Service in multiple browser tabs and windows?

We recommend that you don't open Omnichannel for Customer Service in multiple browser tabs or windows. The app is inherently designed to help agents work in a multisession environment wherein each session has contextual application tabs. The sessions aren't synced across browser tabs.

### What happens if I accidentally close the browser, refresh the entire page, or the browser crashes?

If you accidentally close your browsers, your currently open sessions and tabs opened inside them are lost. However, if you entered some data on the model-driven forms where autosave is enabled, they are saved into model-driven apps.

Ongoing chat and voice conversations appear on your Omnichannel Agent Dashboard. You can pick the chat or [voice call](/dynamics365/contact-center/use/voice-channel-agent-experience#how-to-avoid-call-disconnection) from the dashboard and resume the conversation. The chat or voice call conversation is preserved, and you're able to see the previous chat messages. If you were working on case sessions, you can reopen them using the gestures. For information on starting a session, see [Manage sessions in Omnichannel for Customer Service](../use/oc-manage-sessions.md#start-a-session).

### Does consult only work for managers and supervisors?

No. You can consult with any available agent in the queue from which the chat originated. The consult list shows you agents in the queue who can take more chat requests.

### Can an agent who receives a consult also initiate a consult or transfer?

No. Only the primary agent of the chat can initiate transfers or consults. If the chat is transferred to another agent, the receiving agent becomes the primary agent and can initiate further transfers or consults.

### Why are my agents not receiving any new conversations?

New conversation requests are assigned to an agent when:

- A new chat request comes in.
- The incoming chat request is assigned to a queue that matches the agent’s assigned queues. You can see the queue and workstream for an incoming chat in the Omnichannel Conversation Dashboard.
- The agent presence is set to an **Allowed Presence** for the workstream.
- The agent has capacity to receive the incoming chat from the workstream. Remaining capacity can be checked by tallying up the items assigned on the agent’s dashboard – including **Active** and **Wrap-up** – against the agent’s configured maximum capacity.

### Who can see internal messages?

Only agents and supervisors can see internal messages.

### What does the timer in the communication panel represent?

The timer in the communication panel represents how long the current session tab has been open. If the chat moves into a wrap-up state, the timer is reset and incremented accordingly to show the wrap-up time. If the conversation is closed and reopened later, the timer is reset.

### How do I open chats on my dashboard?

For information about managing work items from your dashboard, see [View agent dashboard and agent work items](../use/oc-agent-dashboard.md).

### Where are conversations stored and how can I access them?

Conversations and sessions are stored as activity types within the model-driven apps. For more information, see [View conversation and session activity types in the Model-driven apps](../use/oc-view-activity-types.md).

## FAQ on agent presence

This section helps answer some of the questions on how presence works.

### When is the manual override of presence cleared?

The system clears your manual override when you become inactive or sign out from the application.

### If the agent is disconnected for less than 2.5 minutes, what does the system do?

If the agent is disconnected and signs in within 2.5 minutes, the system retains the presence that the agent had at the time of disconnection. After 2.5 minutes, the agent's presence is calculated afresh.

### What factors are considered in presence refresh?

If the default presence set by the administrator is "Away" or "Offline", then the system sets the agent presence to the default setting. Otherwise, the system calculates the presence based on the agent's used or released capacity.

## Administrator experience

### How does Automated Record Identification work with pre-chat fields?

If you're using multiple fields for automated record identification, they must all be an exact match. To learn more, see [Automatically identify customers using pre-chat responses](../administer/record-identification-rule.md).

### What do I do if the instance I want isn't available when I provision Omnichannel for Customer Service?

if you have instances in more than one region and provision Omnichannel for Customer Service without selecting the correct region, you might not see the instance you're looking for. To learn more, see [Instance unavailable to select on the provisioning application](/troubleshoot/dynamics-365/customer-service/omnichannel-for-customer-service/instance-unavailable-provision-omnichannel).

### What do I do if I get an error when provisioning Omnichannel for Customer Service?

If you get an error that says, "Unable to perform the requested operation..." or "Request validation failed" when provisioning Omnichannel for Customer Service, it might be caused by signing in on the child business unit rather than the root, or because you are missing read permissions. To learn more, see ["Unable to perform the requested operation..." or "Request validation failed" error when provisioning Omnichannel](/troubleshoot/dynamics-365/customer-service/omnichannel-for-customer-service/omnichannel-provision-fail-errors)

### What do I do if my dashboards (Omnichannel Agent Dashboard, Omnichannel Conversation Dashboard, Tier 1 Dashboard, Tier 2 Dashboard) aren’t showing up?

When you use the Omnichannel for Customer Service app on Unified Service Desk or on the web, the **Active Omnichannel Agent Dashboard** view doesn't show certain dashboards like **Tier 1 Dashboard**, **Tier 2 Dashboard**, **Knowledge Manager**, and **My Knowledge Dashboard**. To learn more, see [Dashboards don't appear in Omnichannel for Customer Service active dashboards view](../troubleshoot-omnichannel-customer-service.md#dashboards-do-not-appear-in-omnichannel-for-customer-service-active-dashboards-view).

### How long does a configuration change to the Omnichannel for Customer Service and unified routing settings take to update?

All configuration changes to a feature or setting, such as updating a queue membership or workstream setting, can take up to 15 minutes to reflect.

### How can I bring custom entities, forms, and dashboards into the Omnichannel for Customer Service app? 

The Omnichannel for Customer Service app can be customized to include custom dashboards and custom forms the same as any Unified Interface app module. The sitemaps can be updated to include custom entities, and default forms can be changed to load custom ones for the entities. All Microsoft Dataverse entities and pages are compatible with the Omnichannel for Customer Service app. 

### Can I customize the Conversation Summary form?

Yes. For a list of supported customizations, see [Customizations supported by the Conversation form](../administer/supported-customizations.md#customizations-supported-by-the-conversation-form).

### Why am I not able to see the Intraday Monitoring report and datasets in Power BI service while configuring intraday insights dashboard for supervisors?

Creation of the IntradayMonitoring report may take up to 15 mins to appear in your configured Power BI workspace. While configuring the Power BI workspace in admin app, ensure that you save the configurations before you exit the configuration form. When you select **Save**, the creation of the report and dataset is initiated. If you missed saving the configuration, initiate the configuration for Supervisor Experience again. To learn more, see [Configure Intraday insights for Omnichannel for Customer Service app on web](../implement/configure-intraday-dashboard-supervisor.md#configure-intraday-insights-for-omnichannel-for-customer-service).

### What is the application ID field on the application user form?

The application ID is a mandatory field for creating application users in Dataverse. You can copy any application ID for any valid (non-expired) application created in Microsoft Entra ID for the same tenant into this field.

## Supervisor experience

### Can I monitor conversations for all channels?

Yes, you can monitor conversations for the voice channel and all messaging channels, including async channels.

### Why am I not able to see the supervisor dashboards in my app?

Check the following:

- Make sure that the Omnichannel supervisor role is assigned to the user.
- For the Power BI intraday dashboard, ensure that the dashboard is shared with the user both on Power BI service and in the Omnichannel app.

For more information, see [Configure Intraday Insights dashboard](../implement/configure-intraday-dashboard-supervisor.md). 

### Why are my Chat Insights and Sentiment dashboard reports empty?

By default, the reports are installed with only a data connection. Once you start using chat and sentiment features, you see data come through.

### How far can I go back in the historical report?

A maximum of 12 months or the most recent 100,000 records. The limitation of 100,000 records is a Power BI data limitation.

### Can I customize reports?

Yes, you can customize the visualizations by editing the report in Power BI.

### How frequently does the data refresh?

The dataset for the Live Monitoring report is real time. If a report is refreshed or filters are changed, the data is updated as per the current state of the system.

The dataset refresh interval for Intraday and Chat Insights reports depends on your settings in Power BI. To learn more, see [Configure Intraday Insights dashboard](../implement/configure-intraday-dashboard-supervisor.md) and Chat Insights set-up. 

### Why am I not able to see more than 100 agents while using filters in Omnichannel Ongoing Conversations dashboard?

By default, the application only displays 100 agents at any given time while filtering the conversation on the **Omnichannel Ongoing Conversations** dashboard. The list of 100 agents is displayed alphabetically. For example, you have 200 agents in your organization, and 100 agents have names that start with the letters A through D, the application only displays these agents. The rest of the agents with names that start with letters E through Z are not listed.

### What controls are in place to limit the exposure of agent performance KPIs within my organization?

These controls are in place for exposing the data in reports:

- Access to the Power BI reports is controlled by Power BI access roles, and sharing within the Omnichannel app. To learn more, see [Configure Intraday Insights dashboard](../implement/configure-intraday-dashboard-supervisor.md)
- Access to the Ongoing Conversation dashboard is controlled by the **Omnichannel supervisor** Dynamics role.
- Sentiment can be turned on or off in Customer Service admin center. To learn more, see [Enable sentiment analysis](../administer/enable-sentiment-analysis.md) 

## Chat widgets

### Can I have the widget show on different pages or different websites?

The widget can show on any portal you want. You can copy the HTML script tag anywhere to make it appear on specific pages, a different Power Apps portals, or a custom portal as well. 

### If I have the widget on multiple pages or websites, what happens when I navigate across the pages with an ongoing chat?

The same widget persists the chat as you cross different pages or websites.

### If published to any external websites, does the live chat widget meet the Web Content Accessibility Guidelines?

Yes, the live chat widget meets Microsoft accessibility standards, which include the Web Content Accessibility Guidelines (WCAG). 
Learn more about Microsoft's accessibility policies in the [Trust Center](https://www.microsoft.com/en-us/trust-center/compliance/accessibility).

## Routing and work distribution

### Can I route chats based on custom variables that we pass through code on my portal?

Yes, you can create custom context variables and create routing rules based on them. For more information, see the following articles:

- [Understand and create workstreams](../administer/create-workstreams.md)
- [Configure assignment methods for queues](../administer/assignment-methods.md)
- [Manage custom context](../develop/send-context-starting-chat.md)

### Can routing in Omnichannel for Customer Service be used for other external channels (for example, my phone calls)?

Yes. In Omnichannel for Customer Service, routing can be used to route chat, SMS, and voice conversations.

## SMS

### What information from a TeleSign account do I need to enter while configuring the channel?

You need the customer ID, API key, and the phone number from your TeleSign account. More information: [Sign up for TeleSign account](../administer/configure-sms-channel.md#sign-up-for-telesign-account)

### Why am I unable to validate the TeleSign account information using the Validate API key option in the admin app?

The Validate API Key functionality validates the customer ID and API key by trying to send a test message to one of the numbers provided in the **SMS phone numbers** tab. Ensure that the customer ID and API key are entered correctly, and the numbers provided in the **SMS phone numbers** tab can receive the text messages that are sent for validation. The phone number should have the country code with no plus sign (+), spaces or special characters. For example, this format would be correct: 14251234567.

### How can I know if I can get a phone number from TeleSign in a specific country?

See the [TeleSign coverage map for Two-Way SMS](https://www.telesign.com). For any more queries, we recommend that you send an email request to support@telesign.com.

### Which phone number types are supported?

TeleSign supports long and short codes; the use of short codes with SMS messaging is supported as long as the customer is using an enterprise account.

### Can I have my customers send international texts?

Support for this scenario by TeleSign can vary based on geography. We recommend that you send an email request to support@telesign.com for your specific scenario if text messages need to be sent or received across countries.

### Can I communicate with customers using outbound SMS?

Yes. To send outbound SMS, you must first configure the SMS channel using Twilio, TeleSign, or Azure Communication Services. You can then create message templates, and use them to communicate with multiple customers. 

More information: [Configure an SMS channel for Twilio](../administer/Configure-sms-channel-twilio.md), [Configure an SMS channel for TeleSign](../administer/configure-sms-channel.md), [Configure an SMS channel using Azure Communication Services](../administer/configure-sms-channel-acs.md), [Create message templates](../administer/create-message-templates.md)

### Does the SMS channel automatically identify the customer?

Yes, Omnichannel system automatically identifies the customer based on the incoming phone number. It looks for phone numbers in the **Mobile Phone** field of Contact records or the **Phone field** of Account records. Ensure that the phone number in these fields has the country code along with the plus sign (+) without any spaces or special characters. For example, this format would be correct: +14251234567.

### Can I send automated SMS responses?

Yes. In Omnichannel for Customer Service, you can send automated messages based on system-triggered or user-defined events. More information: [Configure outbound messaging](../administer/outbound-messaging.md)

### Is there anything unique about the way SMS messages are routed to agents?

All channels integrated into Omnichannel for Customer Service have the same routing capabilities, including SMS. You can create routing rule items with conditions based on Account or Contact entities. Other entities (Case, Context variable, and SMS Engagement Context) aren't supported at this time and shouldn't be used for creating conditions in routing rule items in an SMS workstream.

## Bot

### Can a third-party bot be integrated with Omnichannel through this feature?

Only bots created through [Microsoft Bot Framework](https://dev.botframework.com/) can be integrated at this time.

### Related information

[Overview of Dynamics 365 Customer Service](../administer/overview.md)  
[Omnichannel for Customer Service system requirements](../implement/system-requirements-omnichannel.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
