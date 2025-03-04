---
title: FAQ about Scheduling Operations Agent (preview)
description: Get answers to common questions about how the AI-powered Scheduling Operations Agent feature in Dynamics 365 Field Service helps you quickly improve the schedule of a single technician.
ms.date: 03/06/2025
ms.custom:
  - responsible-ai-faqs
  - ai-gen-docs-bap
  - bap-template
ms.topic: faq
author: anilmur
ms.author: anilmur
ms.reviewer: mhart
ms.collection: bap-ai-copilot 
---

# FAQ about Scheduling Operations Agent (preview)

The Scheduling Operations Agent is a new functionality for Dynamics 365 Field Service that allows dispatchers to improve the schedule of a single technician quickly and efficiently. In this article, you get answers to common questions about how this agent works and its limitations.

## What is the Scheduling Operations Agent?

The [Scheduling Operations Agent](soa-overview.md) in Dynamics 365 Field Service enables dispatchers to ensure optimized schedules for technicians throughout the workday. For example, they can account for issues such as traffic delays, double bookings, or last-minute cancellations that often result in conflicts or gaps. Instead of manually adjusting the bookings on the technician's schedule one by one, the dispatcher can use natural language to ask the agent to suggest an improved schedule.

## What are the agent's capabilities?

The agent can be invoked via the Copilot sidecar by typing a prompt such as **Suggest a schedule**. If the prompt is related to scheduling, then the agent shows a settings pane which you can use to adjust the various [settings](soa-run.md#adjust-the-settings-for-optimization-requests) available. After selecting **Suggest schedule**, the agent examines the existing bookings on the selected technician's schedule, available unfulfilled requirements as specified in the schedule suggestion settings, and relevant properties of the technician such as work hours, skills/characteristics in order to suggest a new schedule that achieves the selected scheduling goal. The agent renders a dialog with the original and the suggested schedule for the dispatcher to review, and providing the option to either accept the modifications, or discard them and trying again with other settings.

## What is the agent's intended use?

You can use agent to quickly optimize the schedule of a single technician, view the suggestion provided by the agent, and decide to apply or cancel the suggestion.

## How was the agent tested and what metrics are used to measure its performance?

We tested the ability of the agent to determine that the prompt is related to scheduling, in English. The optimization algorithms used by the agent to suggest a new schedule is language agnostic. For detailed information on the supported languages, [Explore Copilot features by geography and languages](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

We checked the agent's ability to suggest an improved schedule using metrics similar to the ones used to evaluate the [Resource Scheduling Optimization](rso-overview.md) add-in.

We didn't find any cases where the agent suggested a schedule that wasn't better than the original schedule. However, we did find some cases where the agent didn't deduce that the prompt submitted was related to scheduling.

## What are the limitations of the agent and how can I minimize their impact?

The Scheduling Operations Agent is still in preview, and we're working on improving it. You can help us by giving us feedback using the like/dislike buttons on the suggested schedule. We use this data to evaluate and improve the quality of the agent. The known limitations of the agent are documented [here](soa-tips.md#limitation-and-known-issues).

The feature only works online. You can't use it when you're offline.

## What operational factors and settings allow for effective and responsible use of the agent?

Administrators can enable or disable the feature for your environment by using the steps documented [here](soa-setup.md#enable-the-scheduling-operations-agent). No customer data is collected when this agent is used.

### See also

- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]