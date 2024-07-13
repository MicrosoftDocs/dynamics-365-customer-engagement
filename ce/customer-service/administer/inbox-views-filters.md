---
title: Inbox out of box views and filters
description: Learn about the inbox views and filters that are available out of the box.
ms.date: 07/15/2024
author: lalexms
ms.author: laalexan
ms.reviewer: shujoshi
ms.collection:
ms.topic: how-to
ms.custom: bap-template
---

# Inbox out-of-the-box views and filters

The following tables contain details about the out-of-the-box views and filters that are available for the inbox.

## Out-of-the-box views

| View name | Description | Entities | Entity filters |
|----------|------------|----------|------------|
| My work items | Shows all of the work items that are considered actionable for the agent. This includes assigned conversations, assigned cases, and emails that are sent to the agent (To, Cc, or Bcc) or owned by the agent (owner field set), and voicemails assigned to the agent. | Case, Conversation<sup>1</sup>, Email, Voicemail<sup>1</sup> | Case: Work items assigned to me<br></br>Conversation: Assigned<br></br>Email: Emails assigned to me;</br>Emails sent to me<br></br>Voicemail: Assigned |
| Open work items | Shows work items that are available for the agent to pick up. This includes cases that are assigned to a team or apart of private queues the agent is a member of, open conversations, emails that are owned by a team or private queue that the agent is a member of, and voicemails that are unassigned. | Case, Conversation<sup>1</sup>, Email, Voicemail<sup>1</sup> | Case: Work items in my teams;</br>Work items in my queues<br></br>Conversation: Unassigned<br></br>Email: Emails in my teams;<br>Emails in my queues
| Closed work items | Shows work items that have already been acted on. This includes cases in the closed state, conversations that are resolved, and voicemails that are resolved. | Case, Conversation<sup>1</sup>, Voicemail<sup>1</sup> | Case: Resolved work items assigned to me <br></br>Conversation: Resolved<br></br>Voicemail: Resolved|

<sup>1</sup> Applies if provisioned in and configured for the environment.



## Out-of-the-box filters

| Entity | Inbox filter | Description | Applied Conditions (AND) |
|----------|------------|----------|------------|
| Case/task/custom | Work items assigned to me | **Owner** OR **Worked by** field of the record is set to the current user, and the state of the record is active. | <ul><li>**Owner** is equal to current user OR **Worked by** is equal to current user.</li><li>**Status** of record is active.</li></ul> |
| Case/task/custom | Work items in my teams | **Owner** field of the record is set to a team that the user is a member of. | <ul><li>**Owner** is equal to current user OR **Worked by** is equal to current user.</li><li>**Status** of record is active.</li></ul> |
| Case/task/custom | Work items in my queues | Record is added to a private queue that user is a member of. | <ul><li>Record is added to a private queue that the user is a member of.</li><li>**Status** of the queue that the record is a part of is active.</li><li>**Worked by** isn't set.</li><li>**Owner** of the record isn't set as the current user.</li><li>**Status** of the record is active.</li><ul> |
| Case/task/custom | Resolved work items assigned to me | **Owner** field of the record is set to the current user and the state of the record is inactive. | <ul><li>**Owner** is equal to current user OR **Worked by** is equal to current user.</li><li>**Status** of the record is inactive.</li></ul> |
| Conversation | Assigned | **Active Agent** field of the conversation is set to the current user, and the status field is set to active, waiting, or wrap-up. |<ul><li>**Active Agent** is set to the current user.</li><li>**Status Reason** is set to one of the following values: **Active**, **Waiting**, **Wrap-up**.</li></ul> |
| Conversation | Unassigned | Conversation belongs to a queue that the user is a member of, and the **Status** field is set to **Open**. | <ul><li>**Queue** is set to a queue that the user is a member of.</li><li>**Status Reason** is set to **Open**.</li></ul> |
| Conversation | Resolved | The status filed of the conversation is set to **Closed**. | **Status Reason** is set to **Closed**. |
| Email | Emails sent to me | The user is a recipient of the email by being listed on of the following fields: **To**, **Cc**, or **Bcc**. | The user is listed in the Activity Party Types for the **To**, **Cc**, or **Bcc** field. |
| Email | Emails assigned to me | The **Owner** or **Worked by** field of the record is set to the current user. | The **Owner** field is equal to the current user, or the **Worked by** field is equal to the current user. |
| Email | Emails in my team(s) | The **Owner** field of the record is set to a team that the user is a member of. | The **Owner** field is equal to a team that the current user is a member of. |
| Email | Emails in my queue(s) | The record is added to a private queue that the user is a member of. | <ul><li>The record is added to a private queue that the user is a member of.</li><li>The **Status** of the queue that the record is part of is active.</li><li>The **Worked by** field is not set.</li><li>The **Owner** field of the record is not set as the current user.</li></ul> |





