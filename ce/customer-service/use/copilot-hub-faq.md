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

This article provides answers to frequently asked questions regarding Copilot Hub, including its features, setup, workload management, analytics, case assistance, and known limitations.

## General

### What is Copilot Hub?

Copilot Hub is an AI-powered workspace in Customer Service that helps customer service representatives manage their caseload, analyze workload trends, and get assistance when working on cases. 

### How is Copilot Hub different from Copilot help pane?

The Copilot help pane focuses on answering questions and summarizing case data. Copilot Hub provides a full-screen experience that evaluates workload, prioritizes cases, and supports analytical queries across multiple cases. 

### Which licenses are required?

Dynamics 365 Customer Service Enterprise or Premium. 

## Setup and access

### Why can't I see Copilot Hub?

Confirm the following:

- Copilot Immersive is enabled in Customer Service admin center under **Productivity** > **Copilot settings**.  
- **Copilot help pane** is enabled in your experience profile.   
- **Copilot Immersive** is enabled in your experience profile.  
- You're using Copilot Service workspace.  

### Where do I find Copilot Hub?

Select the **Copilot** button in the session bar to open Copilot Hub. 

### Can I use Copilot Hub and the help pane at the same time?

Both can be enabled, but the help pane isn't displayed during a Copilot Hub session. 

## Workload

### How does Copilot decide which cases to show?

Copilot uses the workload prompt assigned to your profile to determine which cases appear and how they are prioritized. 

### Why don't I see all my cases?

Copilot Hub displays up to 300 cases in the workload view. 

### How do I refresh my workload?

Select **Refresh** or wait for the session to update. 

## Analytics

### What kinds of questions can I ask?

You can ask about trends, distributions, and outliers across your caseload, such as escalation risk, SLA forecasts, and team quality trends. 

### Can I take action from analytics?

No. Analytics is read-only. Open a case to take action. 

## Case assistance

### What information does Copilot use?

Copilot uses case data and related records, including emails, notes, contacts, activities, and knowledge articles. 

### Can Copilot modify data?

Only with your approval. Copilot presents actions for review before applying them. 

## Prompts

### What are preconfigured prompts?

Preconfigured prompts are built-in prompts that help you complete common tasks. 

### Can I create my own prompts?

Yes. You can create and save personal prompts for workload and case scenarios. 

### Why don't I see a prompt my colleague has?

Organization-level prompts might be configured for specific experiences. Saved prompts are personal and aren't shared. 

## Known limitations

- You can have a maximum of 300 cases in the workload view.
- Operations must complete within 2 minutes or the system times out.
- Saved prompts have a limit of 10,000 characters per prompt.

## Provide feedback

Select the feedback icons in Copilot responses to rate usefulness and provide comments. 

## Related information

- [Configure Copilot Hub](../administer/configure-copilot-hub.md)  
- [Use Copilot Hub](use-copilot-hub)
