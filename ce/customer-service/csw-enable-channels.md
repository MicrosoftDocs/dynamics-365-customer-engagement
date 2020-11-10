---
title: "Set up Omnichannel for Customer Service channels in Customer Service workspace | MicrosoftDocs"
description: "Learn how to configure Omnichannel for Customer Service channels in Customer Service workspace"
ms.date: 11/10/2020
ms.service: "dynamics-365-customerservice"
ms.topic: article
author: lalexms
ms.author: laalexan
manager: shujoshi
---

# Set up Omnichannel for Customer Service channels in Customer Service workspace

When your agents are working on cases, there may be times when you want them to also be able to have conversations with customers. Using Omnichannel for Customer Service add-on licensing, you can set up your Customer Service workspace environment so that agents are able to work on both cases and conversations without having to leave the Customer Service workspace app.

## Enable channel conversations in Customer Service workspace 

To enable agents to be able to have conversations in Customer Service workspace, do the following: 

1. Obtain Omnichannel for Customer Service add-on licenses and set up your Omnichannel environment. More information: [Provision Omnichannel](https://docs.microsoft.com/dynamics365/omnichannel/administrator/omnichannel-provision-license). 

2. Configure the following in the Omnichannel administrator app: 

    a. [Channels](https://docs.microsoft.com/dynamics365/omnichannel/administrator/channels)
    
    b. [Queues and users](https://docs.microsoft.com/dynamics365/omnichannel/administrator/queues-omnichannel)
    
    c. [Work streams](https://docs.microsoft.com/dynamics365/omnichannel/administrator/work-streams-introduction)
    
3. Assign the Omnichannel agent and/or Omnichannel supervisor roles to your users. More information: [Assign roles and enable users for Omnichannel for Customer Service](https://docs.microsoft.com/dynamics365/omnichannel/administrator/add-users-assign-roles).

## Set up profiles in App profile manager

Once you've completed the configurations above, go to App profile manager and complete the following:

1.	Create a new app profile or use the default, out-of-box **Customer Service workspace + Channels** profile. More information: [Create and use app profiles to manage apps](https://docs.microsoft.com/dynamics365/app-profile-manager/app-profile-manager).

2.	Assign the app profile you created to the agents and supervisors you want to work on both cases and conversations. More information: [Roles and permissions](https://docs.microsoft.com/dynamics365/app-profile-manager/security-roles).

3.	Verify that you've assigned Omnichannel for Customer Service-related roles to the agents and supervisors you want to work on both conversations and cases.

## Access Omnichannel for Customer Service dashboard views 

When configured, the following dashboards are available in Customer Service workspace:

For agents:
- Omnichannel Agent Dashboard
- Customer Service Representative Dashboard

For supervisors:
- Omnichannel Agent dashboard
- Omnichannel Ongoing Conversations Dashboard
- Intraday Insights
- Customer Service Representative Dashboard
- Customer Service Manager Dashboard


### Agent experience
Once you have configured the Omnichannel and App profile manager features, agents will have a user experience in Customer Service workspace that is similar to the following:

1.	The agent signs in to Customer Service workspace and can view the Omnichannel agent dashboard from the dashboard view.

2.	The agent can work on conversations by accepting or selecting a conversation from the dashboard, and all the functionality of Omnichannel for Customer Service is available to them, including:

    a.	Notifications - More information: [View notifications](https://docs.microsoft.com/dynamics365/omnichannel/agent/agent-oc/oc-notifications) <br>
    b.	Customer summary - More information: [View a customer summary to get information about a customer](https://docs.microsoft.com/dynamics365/omnichannel/agent/agent-oc/oc-customer-summary) <br>
    c.	Notes – More information: [Take notes specific to a conversation](https://docs.microsoft.com/en-us/dynamics365/omnichannel/agent/agent-oc/oc-take-notes) <br>
    d.	Conversation and session forms – More information: [View conversation and session forms](https://docs.microsoft.com/dynamics365/omnichannel/agent/agent-oc/oc-view-activity-types) <br>
    e.	Transcripts – More information: [Search transcripts](https://docs.microsoft.com/dynamics365/omnichannel/agent/agent-oc/oc-search-transcipts) <br>
    f.	Viewing customer summaries for conversation requests – More information: [View customer summaries for incoming conversation requests](https://docs.microsoft.com/dynamics365/omnichannel/agent/agent-oc/oc-view-customer-summary-incoming-conversation-request) <br>
    g.	Presence status – More information: [Manage presence status](https://docs.microsoft.com/dynamics365/omnichannel/agent/agent-oc/oc-manage-presence-status)

### Supervisor experience

When a supervisor signs in to Customer Service workspace, they can select a dashboard to do the following:

- Monitor agent conversations - More information: [Monitor and assign conversations](https://docs.microsoft.com/dynamics365/omnichannel/supervisor/monitor-conversations)
- Monitor ongoing conversations - More inforamtion: [View and understand Omnichannel Ongoing Conversations conversations dashboard](https://docs.microsoft.com/en-us/dynamics365/omnichannel/supervisor/ongoing-conversations-dashboard)
- View intraday insights - More information: [View and understand Omnichannel intraday insights dashboard](https://docs.microsoft.com/dynamics365/omnichannel/supervisor/intraday-insights-dashboard)
- View customer satisfaction levels - More information: [Sentiment monitoring](https://docs.microsoft.com/dynamics365/omnichannel/supervisor/supervisor-sentiment-monitoring)

### See also
- [App profile manager overview](https://docs.microsoft.com/dynamics365/app-profile-manager/overview) <br>
- [Roles and privileges associated with app profile manager](https://docs.microsoft.com/dynamics365/app-profile-manager/security-roles) <br>
- [Customer Service workspace overview](https://docs.microsoft.com/dynamics365/customer-service/csw-overview) <br>
- [Omnichannel agent overview](https://docs.microsoft.com/dynamics365/omnichannel/agent/omnichannel-agent-overview)<br>
- [Introduction to intraday supervisor experiences](https://docs.microsoft.com/en-us/dynamics365/omnichannel/supervisor/intro-intraday-insights-dashboard)
