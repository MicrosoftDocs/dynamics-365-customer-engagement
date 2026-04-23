---
title: Use Copilot Hub (preview)
description: Learn how to use Copilot Hub in Dynamics 365 Customer Service to manage your workload, ask questions, and get assistance on cases.
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.collection:
ms.date: 04/23/2026
ms.custom: bap-template
---

# Use Copilot Hub (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

> [!IMPORTANT]
> AI-generated content is a suggestion. Review and edit the content to ensure it's accurate and appropriate before taking action.

Copilot Hub is an AI-powered workspace that helps customer service representatives (service representatives, representatives) manage their caseload from a single location. It provides a prioritized view of cases, answers questions about your workload, and assists with case resolution-all from a full-screen Copilot experience.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Prerequisites

Your administrator enabled Copilot Immersive for your environment and your experience profile. Learn more in [Configure Copilot Hub](../administer/configure-copilot-hub.md).

## Open Copilot Hub

In **Copilot Service workspace** or **Contact Center**, select the **Copilot** button in the session bar.

Copilot Hub opens in a full-screen experience and replaces the Inbox view.

> [!NOTE]
> When you're using Copilot Hub, the Copilot help pane isn't displayed. The help pane remains available in other sessions.

## View your workload

When you open Copilot Hub without selecting a case, your workload appears.

Your workload:
- Shows a prioritized list of assigned cases  
- Evaluates cases using factors such as escalation risk, sentiment, and service level agreement (SLA) compliance

The cases that appear depend on the workload prompt assigned to your experience profile. Copilot evaluates each case using factors like escalation risk, sentiment, SLA compliance, and completeness. Copilot sorts the cases and displays highest priority cases first.

Copilot Hub displays up to 300 cases in the workload view.

## Refresh your workload

To update your workload:

- Select **Refresh** to manually update your cases.
- Wait for the session to refresh automatically. 

A visual indicator appears while the workload updates.

## Ask questions about your workload

You can ask analytical questions about your caseload without selecting a case.

To ask a question:
- Select a suggested prompt.  
- Open the **View prompts** menu.  
- Enter your own question.  

Examples:
- Show my cases with the highest escalation risk. 
- Which of my cases are stalled?  
- What's my SLA breach forecast for this week?
- How is case quality trending across my team?
- Which representatives have the most stalled cases?
- Show cases where the customer responded today.

Workload analytics is read-only. To take action on a case, open it and continue in case assistance.

## Work with cases

When you open a case in Copilot Service workspace, Copilot switches to case assistance.

Copilot gathers context from case data and related records, including emails, notes, contacts, activities, knowledge articles, and SLA details, and uses it to help resolve the case.

With case assistance, you can do the following tasks:

- **Ask questions about the case**: Ask Copilot about the case history, customer context, related communications, or SLA status, and get answers that Copilot takes from the cases data.
- **Ask follow-up questions**: Continue to work with Copilot to refine the answers. You can ask follow-up questions to guide it in a natural, conversational way.
- **Review and edit proposed actions**: When Copilot suggests an action that would modify data-such as updating case status or adding a note-it presents the details in an adaptive care. You can edit the proposed action, and then approve or dismiss it.  

Copilot doesn't make changes without your approval.

> [!NOTE]
> When you open a case from workload analytics, Copilot starts a fresh case assistance session. Your prior analytics conversation doesn't carry over. If you close the case and return to the workload view, your analytics session remains available.

## Use preconfigured prompts

Copilot Hub includes preconfigured prompts to help with common tasks. Your administrator can also create organization-level prompts. You can access prompts in two ways:

- Select a **suggested prompt pill** that appears in the Copilot Hub experience.
- Open the **View prompts** menu to see all available prompts.

Preconfigured prompt types include:
- **Workload prompts**: Define the cases that appear in your workload view and their prioritization.
- **Analytical prompts**: Answer common questions about your caseload, such as risk distribution, stalled cases, team health, and more.

## Save personal prompts

You can create and save your own workload and case prompts for personal use.

Saved prompts:
- Are available only to you
- Follow the same behavior as Copilot help pane prompts  
- Support up to 10,000 characters

## Approve or reject actions

Copilot automatically retrieves information to build context, but any action that modifies data requires your approval. When Copilot proposes an action, it presents the details in an adaptive card. You can:
1. Review the proposed action.
2. Optionally edit the details.
3. Approve to run the action, or dismiss it.
If you dismiss the action, you can provide more guidance and ask Copilot to propose an alternative.

## Provide feedback
To rate the usefulness of Copilot's responses, select the thumbs-up or thumbs-down icon at the bottom of each response. You can also provide written feedback through the feedback form in the Copilot experience.

## Related information

- [Configure Copilot Hub](../administer/configure-copilot-hub.md)
- [Copilot Hub FAQ](copilot-hub-faq)
