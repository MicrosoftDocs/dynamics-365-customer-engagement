---
title: View analytics for Copilot impact (preview)
description: Learn how to view and understand Copilot metrics in Microsoft Dynamics 365 Customer Service.
ms.date: 07/24/2023
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
---

# View analytics for Copilot impact (preview)

[This article is prerelease documentation and is subject to change.]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

Copilot in Dynamics 365 Customer Service helps agents to complete tasks related to conversations, cases, and email more easily. With the Copilot report in Customer Service historical analytics, supervisors and customer service managers can identify the impact that Copilot is having across their customer service operation.

To view the Copilot report, open Customer Service historical analytics and select the **Copilot (preview)** tab.

## Copilot report

You can use filters to focus on the information that's important to you:

- **Duration**: Filters the data by the selected value of day, week, or month.
- **Time zone**: Filters the data for the selected time zone.

The Copilot report displays the following metrics.

:::image type="content" source="media/copilot-analytics-report.png" alt-text="A screenshot of the Copilot report for cases.":::

### Usage

| Metric | Description |
|--------|---------|
| Daily active users | The number of unique agents who used Copilot at least once in the last day |
| Total copilot AI responses | The total number of responses that Copilot provided |
| Number of responses used | The number of times that text from a Copilot response was copied |
| Percentage of copilot AI responses used | The percentage of responses that were copied |

### Productivity: Cases

| Metric | Description |
|--------|---------|
| Total cases resolved | The number of cases that were resolved when Copilot was available for use |
| Number of cases resolved using copilot AI | The number of cases that were resolved when Copilot was used |
| Percentage of cases resolved using copilot AI | The percentage of cases that were resolved when Copilot was used |
| Avg. days to close for cases | The average time that elapsed after the case was created and until it was resolved; displays data when Copilot was used and when it wasn't used |
| Case throughput | The number of cases that were resolved on average per day; displays data when Copilot was used and when it wasn't used |

### Productivity: Conversations

| Metric | Description |
|--------|---------|
| Total conversations | The total number of conversations in which the agent engaged with the customer at least once while Copilot was available; doesn't include email and voice |
| Number of conversations using copilot AI | The number of engaged conversations that have used Copilot; lists only conversations that have ended |
| Percentage of conversations using copilot AI | The percentage of engaged conversations that have used Copilot |
| Avg conversation handle time | The average time that elapsed after a conversation started until it ended; displays data when Copilot was used and when it wasn't used |
| Conversation throughput | The number of conversations, excluding email and voice, completed on average per day; displays data when Copilot was used and when it wasn't used |

### Satisfaction

| Metric | Description |
| -------|---------|
| Agent ratings | The number of times agents rated a Copilot response positively or negatively |

### See also

[Use Copilot features](use-copilot-features.md)  
[Configure copilot](configure-copilot-features.md)  
[Enable historical analytics for Copilot](configure-cs-historical-analytics-csh.md#enable-historical-analytics-for-copilot-preview)
