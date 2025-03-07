---
title: View conversation and session forms, and activity types
description: Learn to view conversation and session forms in Omnichannel for Customer Service. Also learn about conversation and session activity types.
ms.date: 12/13/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
---

# View conversation and session forms

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

Your organization might have a classification where customer service representatives (service representatives or representatives) might use different apps. If you work on a model-driven app, and you need to analyze the conversation request from Omnichannel for Customer Service, you can find the information through **Activities** in the model-driven app.

Select the plus icon in the application tab to view the site map and select **Activities**.

Among the many activity types, look for **Conversation** and **Session** types.

### Conversation activity type

The Conversation activity type displays information about a conversation request.

> [!NOTE]
> The fields listed in the following table are supported for the Conversation activity type only.

| **Tab** | **Section**     | **Fields**        |
|---------|-----------------|-------------------|
| Details | Details         | <ul> <li>Title</li> <li>Customer</li> <li>Work stream </li> <li>Active agent</li> <li>Activity status</li> <li>Status reason</li> <li>Status updated on</li> <li>Regarding</li> <li>Queue</li> </ul>|
| Details | History         |<ul> <li>Created on</li> <li>Closed on</li> <li>Modified on</li> <li>Transfer count</li>  <li>Escalation count</li> <ul> |
| Details | Session Details |<ul> <li> Channel </li> <li>Date created</li> <li>Subject</li> <li>Date created</li> <ul>|
| Details | Chat Transcript |<ul> <li>Download</li> <ul>|

### Session activity type

The session activity type displays information about an individual session in a conversation request.

> [!NOTE]
> The fields listed in the following table are supported for the Session activity type only.

| **Tab** | **Section**          | **Field**          |
|---------|----------------------|--------------------|
| General | Header               | <ul> <li>Activity Status</li> </ul>|
| General | General              | <ul> <li>Subject</li> <li>Owner</li> <li>Conversation</li> <li>Channel</li> <li>Session Created On</li> <li>Session Closed On</li> <li>Agent Assigned On</li> <li>Agent Accepted On</li> <li>Regarding</li> <li>Name</li> <li>Created on</li> </ul> |
| General | Session Participants | <ul> <li>Agents</li> <li>Joined On</li> <li>Left On</li> <li>Mode</li> </ul> |

The Session Participants section lets you add a participant related to the session or add a session participant that already exists for the record you're working with.

### Related information

[View active conversations for an incoming conversation request](oc-view-customer-summary-incoming-conversation-request.md)  
[View customer information on Active Conversation form](oc-customer-summary.md)  
[Create a record](oc-create-record.md)  
[Search, link, and unlink a record](oc-search-link-unlink-record.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
