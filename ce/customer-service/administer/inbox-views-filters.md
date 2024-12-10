---
title: Inbox out of box views and filters
description: Learn about the inbox views and filters that are available out of the box.
ms.date: 09/13/2024
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.collection:
ms.topic: how-to
ms.custom: bap-template
---

# Views and filters for the inbox

The following tables contain details about the views and filters that are available by default for the inbox.

## Inbox views

| View name | Description | Tables | Table filters |
|----------|------------|----------|------------|
| My work items | Shows all work items the agent can take action on. Actionable items can include assigned conversations, assigned cases, and emails with the agent listed in the **To**, **Cc**, or **Bcc** field, or listed as the owner, and voicemails assigned to the agent. | Case, Conversation<sup>1</sup>, Email, Voicemail<sup>1</sup> | Case:<br><ul><li>Work items assigned to me</li></ul>Conversation:<ul><li>Assigned</li></ul><br>Email:<ul><li>Emails assigned to me</li><li>Emails sent to me</li></ul>Voicemail:<ul><li>Assigned</li></ul> |
| Open work items | Shows work items that are available for the agent to pick up. Work items can include cases that are assigned to a team or apart of private queues the agent is a member of, open conversations, emails owned by a team or private queue that the agent is a member of, and unassigned voicemails. | Case, Conversation<sup>1</sup>, Email, Voicemail<sup>1</sup> | Case:<br><ul><li>Work items in my teams</li><li>Work items in my queues</li></ul>Conversation:<ul><li>Unassigned</li></ul>Email:<ul><li>Emails in my teams</li><li>Emails in my queues |
| Closed work items | Shows work items already acted on. Work items already acted on can include cases in the closed state, conversations that are resolved, and voicemails that are resolved. | Case, Conversation<sup>1</sup>, Voicemail<sup>1</sup> | Case:<br><ul><li>Resolved work items assigned to me</li></ul>Conversation:<ul><li>Resolved</li></ul>Voicemail:<ul><li>Resolved</li></ul>|

<sup>1</sup> Applies if provisioned in and configured for the environment.

## Inbox filters

| Table | Inbox filter | Description | Applied Conditions (AND) |
|----------|------------|----------|------------|
| Case, task, custom | Work items assigned to me | **Owner** OR **Worked by** field of the record is set to the current user, and the state of the record is active. | <ul><li>**Owner** is equal to current user OR **Worked by** is equal to current user.</li><li>**Status** of record is active.</li></ul> |
| Case, task, custom | Work items in my teams | **Owner** field of the record is set to a team that the user is a member of. | <ul><li>**Owner** is equal to current user OR **Worked by** is equal to current user.</li><li>**Status** of record is active.</li></ul> |
| Case, task, custom | Work items in my queues | Record is added to a private queue that user is a member of. | <ul><li>Record is added to a private queue that the user is a member of.</li><li>**Status** of the queue that the record is a part of is active.</li><li>**Worked by** isn't set.</li><li>**Owner** of the record isn't set as the current user.</li><li>**Status** of the record is active.</li><ul> |
| Case, task, custom | Resolved work items assigned to me | **Owner** field of the record is set to the current user and the state of the record is inactive. | <ul><li>**Owner** is equal to current user OR **Worked by** is equal to current user.</li><li>**Status** of the record is inactive.</li></ul> |
| Conversation | Assigned | **Active Agent** field of the conversation is set to the current user, and the status field is set to active, waiting, or wrap-up. |<ul><li>**Active Agent** is set to the current user.</li><li>**Status Reason** is set to one of the following values: **Active**, **Waiting**, **Wrap-up**.</li></ul> |
| Conversation | Unassigned | Conversation belongs to a queue that the user is a member of, and the **Status** field is set to **Open**. | <ul><li>**Queue** is set to a queue that the user is a member of.</li><li>**Status Reason** is set to **Open**.</li></ul> |
| Conversation | Resolved | The status field of the conversation is set to **Closed**. | <ul><li>**Status Reason** is set to **Closed**.</li></ul> |
| Email | Emails sent to me | The user is a recipient of the email by being listed on of the following fields: **To**, **Cc**, or **Bcc**. | <ul><li>The user is listed in the **Activity Party Types** for the **To**, **Cc**, or **Bcc** field.</li></ul> |
| Email | Emails assigned to me | The **Owner** or **Worked by** field of the record is set to the current user. | <ul><li>The **Owner** field is equal to the current user, or the **Worked by** field is equal to the current user.</li></ul> |
| Email | Emails in my team | The **Owner** field of the record is set to a team that the user is a member of. | <ul><li>The **Owner** field is equal to a team that the current user is a member of.</li></ul> |
| Email | Emails in my queue | The record is added to a private queue that the user is a member of. | <ul><li>The record is added to a private queue that the user is a member of.</li><li>The **Status** of the queue that the record is part of is active.</li><li>The **Worked by** field isn't set.</li><li>The **Owner** field of the record isn't set as the current user.</li></ul> |
| Email | Emails in a shared mailbox | The admin specifies an email address that can be used to show emails sent to that address. | <ul><li>Emails that are sent using the **To** field for the specified email address. Doesn't apply to the **Cc** or **Bcc** fields.</li></ul> |
| Voicemail | Assigned | The **Owner** or **Worked by** field of the record is set to the current user, and the **Status Reason** field is set to **Active**. |<ul><li>The **Owner** or **Worked by** field is equal to the current user.</li><li>The record's **Status Reason** is set to **Open**.</li></ui> |
| Voicemail | Unassigned | The **Owner** field isn't set to current user, and the **Worked by** field isn't set. |<ul><li>The **Owner** field isn't equal to the current user.</li><li>The **Worked by** field isn't set.</li><li>The record's **Status Reason** is set to **Open**.
| Voicemail | Resolved | The **Owner** or **Worked by** field of the record is set to the current user, and the **Status Reason** field is set to **Closed**. |<ul><li>The **Owner** or **Worked by** field of the record is equal to the current user.</li><li>The **Status Reason** of the record is set to **Closed**.</li></ui> |

## Applied filters (non-table specific)

- Last 90 days, based on the **Modified on** field.
- Top 500 records, descending in order by the **Modified on** field.

### Related information
[Configure the inbox](configure-inbox.md)  
[Use the inbox](../use/use-inbox.md)  
