---
title: Scheduling Operations Agent FAQ (preview)
description: Get answers to common questions about how the Scheduling Operations Agent in Dynamics 365 Field Service helps dispatchers improve technicians' schedules.
ms.date: 06/25/2026
ms.update-cycle: 180-days
ms.custom:
  - responsible-ai-faqs
  - ai-gen-docs-bap
  - bap-template
ms.topic: faq
author: andrewclear-ms
ms.author: anclear
ms.reviewer: puneetsingh
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Scheduling Operations Agent FAQ (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The Scheduling Operations Agent is a feature of Dynamics 365 Field Service that helps dispatchers improve the schedules of one or more technicians. This article answers common questions about how the agent works and its limitations.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## What is the Scheduling Operations Agent?

The [Scheduling Operations Agent](soa-overview.md) in Dynamics 365 Field Service makes it easy for dispatchers to optimize the schedules of one or more technicians throughout the workday. Traffic delays, double bookings, or last-minute cancellations often result in conflicts or gaps in a technician's schedule. Instead of manually adjusting the bookings one by one, the dispatcher can ask the agent to suggest an improved schedule. The agent supports [interactive optimizations](soa-interactive-optimizations.md) for in-the-moment adjustments and [batch optimizations](soa-batch-optimizations.md) for larger, asynchronous runs.

## What are the agent's capabilities?

The dispatcher launches the agent from the Copilot side pane, the schedule board, or a resource list, and selects one or more resources to optimize. From the Copilot side pane, the dispatcher types a prompt, such as "Suggest a schedule." If the prompt is related to scheduling, the agent presents [settings](soa-interactive-optimizations.md#adjust-the-settings-for-optimization-requests) that the dispatcher can adjust to influence the agent's suggested schedule. After the dispatcher selects **Suggest schedule**, the agent examines the existing bookings on the selected technicians' schedules, unfulfilled requirements that match the settings, and relevant characteristics of the technicians, such as working hours and skills, to suggest a new schedule that achieves the selected [goal](soa-goals.md). The goal defines the objectives and constraints that shape the result. The agent displays the original and suggested schedules for the dispatcher to review, and provides options to accept the modified schedule or discard it and try again with other settings.

For larger, asynchronous runs, the dispatcher configures a [batch optimization](soa-batch-optimizations.md) by combining a [scope](soa-scopes.md), a [goal](soa-goals.md), and a time range in a [plan](soa-plans.md), and then reviews and applies the results.

## What's the agent's intended use?

Dispatchers use the agent to optimize the schedules of one or more technicians interactively, review the agent's suggested schedule, and apply or cancel the suggestion. They can also configure batch optimizations that combine a scope, a goal, and a time range to optimize larger sets of resources, requirements, and bookings, and then review and apply the results.

## How was the agent tested and what metrics are used to measure its performance?

We tested the agent's ability to determine that the prompt is related to scheduling, in English. The optimization algorithms the agent uses to suggest a new schedule are language-agnostic; however, not all languages are supported. Check the list of supported languages in [Explore Copilot features by geography and languages](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

To check the agent's ability to suggest an improved schedule, we used metrics similar to the ones we used to evaluate the [Resource Scheduling Optimization add-in](rso-overview.md).

In our testing, the agent always suggested a schedule that was better than the original schedule. However, we did find some cases where the agent didn't detect that the prompt was related to scheduling.

## What are the limitations of the agent and how can I minimize their impact?

For a list of known limitations, see [Scheduling Operations Agent Known issues and limitations](soa-limits.md#known-issues-and-limitations). The Scheduling Operations Agent is still in preview, and Microsoft is working on improving it. You can help by providing feedback through the like or dislike buttons on the agent's suggested schedule. Microsoft uses this data to evaluate and improve the quality of the agent.

The agent only works online. You can't use it when you're offline.

## What operational factors and settings allow for effective and responsible use of the agent?

Administrators can turn the feature on or off for an environment. Learn more in [Set up the Scheduling Operations Agent](soa-setup.md#turn-on-the-scheduling-operations-agent). Administrators control who can configure and run optimizations by assigning the **Scheduling Operations Agent Administrator** and **Scheduling Operations Agent User** roles. They shape the agent's behavior by configuring [goals, objectives, and constraints](soa-goals.md). The agent doesn't collect any customer data when you use it.

## Next steps

- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
