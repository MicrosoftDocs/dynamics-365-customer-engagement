---
title: Copilot Hub FAQ (preview)
description: Learn about frequently asked questions when using Copilot Hub to manage your workload, ask questions, and get assistance on cases.
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: faq
ms.collection:
ms.date: 04/23/2026
ms.custom: bap-template
---

# Copilot Hub FAQ (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

This article answers common questions about Copilot Hub, including features, setup, workload management, analytics, and case assistance.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## General

### What is Copilot Hub?

Copilot Hub (also known as Copilot Immersive) is an AI-powered workspace in Dynamics 365 Customer Service. Customer Service representatives (service representatives, representatives) can use it in Copilot Service workspace. It helps representatives manage their caseload, analyze workload trends, and get assistance when they work on cases.

### How is Copilot Hub different from the Copilot ask a question experience?

The Copilot **Ask a question** experience helps you find information from knowledge sources and get case summaries from the Copilot help pane. Copilot Hub provides a full-screen experience that evaluates workload, presents a prioritized case view, and supports analytical queries across multiple cases. 

### Which licenses are required?

Licensing requirements vary based on your organization's setup. Learn more in the [Dynamics 365 Licensing Guide](https://cdn-dynmedia-1.microsoft.com/is/content/microsoftcorp/microsoft/bade/documents/products-and-services/en-us/bizapps/Dynamics-365-Licensing-Guide-April-2026.pdf).

### Which languages are supported?

Copilot Hub is verified for English during the public preview. It might work in other languages, but quality is only validated for English.

### Which regions are supported?

All regions supported by Dynamics 365 Customer Service, excluding GCC, are supported. GCC support is expected to be available in a future release.

### Is Copilot Hub available for conversations, email, or voice?

No. Copilot Hub is currently usable for case records only. The entity selector in the admin configuration supports extensibility to additional entities, such as conversation and email. These features are planned for a future release.

## Setup and access

### How do I get access to Copilot Hub?

Your administrator must enable Copilot Immersive at the environment level and in your experience profile. Learn more in [Configure Copilot Hub](../administer/configure-copilot-hub.md).

### Why can't I view Copilot Hub?

To view Copilot Hub in your environment, confirm that your setup is as follows:

- Copilot Immersive is enabled in Customer Service admin center under **Productivity** > **Copilot settings**.  
- The Copilot help pane is enabled in your experience profile.   
- Copilot Immersive is enabled in your experience profile.  
- You're using Copilot Service workspace.

### Where do I find Copilot Hub?

Select the **Copilot** button in the session bar to open Copilot Hub. 

### Can I use Copilot Hub and the Copilot help pane at the same time?

Both can be enabled, but the help pane isn't displayed during a Copilot Hub session. The help pane remains available in other sessions outside of Copilot Hub.

## Workload

### How does Copilot decide which cases to show?

Copilot uses the workload prompt assigned to your profile to determine which cases appear and how they're prioritized. You can modify the prompt or create your own.

### Why don't I see all my cases?

Copilot Hub displays up to 300 cases in the workload view. The workload prompt's filtering and prioritization logic determine which 300 cases appear. A count indicator in the workload view shows how many cases are currently displayed.

### How do I refresh my workload?

Select **Refresh** or wait for the session to update. A timer shows how long since the last refresh occurred, and a visual indicator appears while the workload updates.

## Analytics

### What kinds of questions can I ask about my workload?

You can ask about trends, distributions, and outliers across your caseload, such as escalation risk, service level agreement (SLA) forecasts, and team quality trends. You can select a suggested prompt, choose a prompt from the **View prompts** menu, or type your own question.

### Can I take action from analytics?

No. Workload analytics is read-only. If you identify a case that needs action, Copilot offers to open it so you can switch to case assistance.

### Why did my analytics conversation disappear when I opened a case?

When you open a case from analytics, Copilot starts a case assistance session. Your analytics conversation doesn't carry over to the case context. However, if you close the case and return to the workload view, the system preserves your prior analytics session.

## Case assistance

### What information does Copilot use when I work on a case?

Copilot assembles context from the case record and related entities, including emails, notes, account information, contact details, activities, entitlements, knowledge articles, SLA items, and queue items. More entity types might be supported in a future release. 

### Can Copilot modify data?

Only with your approval. Copilot presents actions for review before applying them. Any action that creates, modifies, or deletes data appears in an adaptive card for your review. You can edit the proposed action before you approve it, or dismiss it entirely.

## Prompts

### What are preconfigured prompts?

Preconfigured prompts are built-in prompts that help you complete common tasks. Your administrator can also create organization-level prompts with a prompt alias, a "show-in-guide" setting, and a target surface (side pane, immersive, or both).

You can access suggested prompts in the Copilot Hub experience or from the **View prompts** menu.

### Can I create my own prompts?

Yes. You can create and save personal prompts for workload and case scenarios. Saved prompts are personal to you and have a 10,000-character limit. Personal prompts follow the same saving pattern as the ask a question feature.

### Why don't I see a prompt my colleague has?

Organization-level prompts might be configured for specific experiences. Saved prompts are personal and aren't shared between users. 

## What are the known limitations?

- You can have a maximum of 300 cases in the workload view.
- Operations must complete within 2 minutes or the system times out.
- Saved prompts have a limit of 10,000 characters per prompt.

## How do I provide feedback?

Select the thumbs-up or thumbs-down feedback icons in Copilot responses to rate usefulness and provide comments. You can also share feedback in the Copilot feedback form.

## Related information

- [Configure Copilot Hub](../administer/configure-copilot-hub.md)  
- [Use Copilot Hub](use-copilot-hub.md)
