---
title: "View omnichannel conversation and session activity types in the Model-driven apps | MicrosoftDocs"
description: "Learn about the omnichannel conversation and session activity types that users (agents and supervisors) can see under the Activities in the Model-driven apps."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 12/27/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# View conversation and session activity types in the model-driven apps

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Your organization might have a classification where certain agents work in the contact center, which uses Omnichannel for Customer Service on the web and certain agents work in another contact center, which uses model-driven apps. In this case, if you are an agent who works on model-driven apps and you need to analyze the conversation request from Omnichannel for Customer Service on the web, you can find the information through **Activities** in model-driven apps.

Select the plus icon in the application tab to view the sitemap and select **Activities**.

> [!div class=mx-imgBorder]
> ![Select activities in the sitemap to view the list of activity types](../../media/oceh-oc-activities.png "Select activities in the sitemap")

You can find the following activity types in model-driven apps:

- Conversation

- Session

> [!div class=mx-imgBorder]
> ![Select activities in the sitemap to view the list of activity types](../../media/oceh-oc-activities-list.png "Select activities in the sitemap")

### Conversation activity type

The Conversation activity type displays information about an conversation request.

![Omnichannel conversation form](../../media/oceh-oc-conversation-form.png "Omnichannel conversation form")  

| **Tab** | **Section**     | **Fields**        |
|---------|-----------------|-------------------|
| Details | Details         | <ul> <li>Title</li> <li>Customer</li> <li>Work stream </li> <li>Active agent</li> <li>Activity status</li> <li>Status reason</li> <li>Status updated on</li> <li>Regarding</li> <li>Queue</li> </ul>|
| Details | History         |<ul> Create on</li> <li>Closed on</li> <li>Modified on</li> <li>Transfer count</li>  <li>Escalation count</li> <ul>
| Details | Session Details |<ul> <li>Subject</li> <li>Date created</li> <ul>|
| Details | Chat Transcript |<ul> <li>Download</li> <ul>|

### Session activity type

The session activity type displays information about a individual session in a conversation request.

![Omnichannel session form](../../media/oceh-oc-session-form.png "Omnichannel session form")  

| **Tab** | **Section**          | **Field**          |
|---------|----------------------|--------------------|
| General | Header               | <ul> <li>Activity Status</li> </ul>|
| General | General              | <ul> <li>Subject</li> <li>Owner</li> <li>Conversation id</li> <li>Session Created On</li> <li>Session Closed On</li> <li>Agent Assigned On</li> <li>Agent Accepted On</li> <li>Regarding</li> <li>Name</li> <li>Created on</li> </ul> |
| General | Session Participants | <ul> <li>Agents</li> <li>Joined On</li> <li>Left On</li> <li>Mode</li> </ul> |

The Session Participants section lets you add a participant related to the session or add a session participant that already exists for the record you are working with.

> [!div class="nextstepaction"]
> [Next topic: View customer summary for an incoming conversation request](oc-view-customer-summary-incoming-conversation-request.md)

## See also

- [View customer summary](oc-customer-summary.md)
- [Create a record](oc-create-record.md)
- [Search, link, and unlink a record](oc-search-link-unlink-record.md)
