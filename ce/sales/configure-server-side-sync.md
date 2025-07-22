---
title: Configure server-side synchronization for Opportunity Research Agent
description: 
ms.date: 07/09/2025
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure server-side synchronization for Opportunity Research Agent

The Opportunity Research Agent in Dynamics 365 Sales requires server-side synchronization to access emails and meetings of sellers who own the opportunities it handles. This is essential for gathering insights and updating sales records effectively.

## Prerequisites

Ensure that you have the following roles:

- System Administrator for your Dynamics 365 organization.
- Office 365 Global Administrator or Exchange Administrator in Microsoft Office 365 admin portal.

## Enable server-side synchronization for seller mailboxes

1. In the Dynamics 365 Sales org, go to **Advanced Settings**.
1. Go to **System** > **Email Configuration** > **Mailboxes**.
1. Change the view to **All Mailboxes** and select the mailboxes associated with sellers who own the opportunities that the agent will work on.
1. Select **Approve Email**.
1. Select **Test & Enable Mailbox** to verify that the server-side sync is established successfully for the email. When successful, the incoming and outgoing email status display Success under the Configuration Status section.


