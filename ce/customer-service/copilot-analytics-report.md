---
title: View analytics for Copilot impact (preview)
description: Learn about copilot metrics in Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 06/23/2023
ms.custom: bap-template
---

# View analytics for Copilot impact (preview)

[This article is prerelease documentation and is subject to change.]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

The Copilot report in Customer Service historical analytics empowers supervisors and customer service managers to identify the impact that Copilot helps create across their entire customer service operation. With Copilot, customer service agents are able to complete various tasks related to conversations, cases, and email more easily.

You can view the Copilot report by opening Customer Service historical analytics. The Copilot (preview) tab lists the various metrics.

## Copilot report

The Copilot report can be filtered on the following fields:

- **Duration**: Filters the data by the selected value of day, week, or month.
- **Time zone**: Filters the data for the selected time zone.

The Copilot report displays the following metrics.

:::image type="content" source="media/copilot-analytics-report.png" alt-text="A screenshot of the Copilot report for cases.":::

### Usage

|Metric  |Description  |Derivation  |
|---------|---------|---------|
|Daily active users| The number of unique agents who used Copilot at least once in the last one day. ||
|Total copilot AI responses| The total number of responses that Copilot provided. ||
|Number of responses used| The number of times text from a copilot response was used.||
|Percentage of copilot AI responses used| The percentage of responses that were used. ||

### Productivity: Cases

|Metric  |Description  |Derivation  |
|---------|---------|---------|
|Total cases resolved| The number of cases that were resolved when Copilot was available for use.||
|Number of cases resolved using copilot AI| The number of cases that were resolved when Copilot was used.||
|Percentage of cases resolved using copilot AI|The percentage of cases that were resolved when Copilot was used.||
|Avg. days to close for cases|The Average time that elapsed after case was created and until it was resolved. The chart displays data when Copilot was used and when it wasn't used.||
|Case throughput|The number of cases that were resolved on an average per day. The chart displays data when Copilot was used and when it wasn't used.||

### Productivity: Conversations

|Metric  |Description  |Derivation  |
|---------|---------|---------|
|Total conversations|The total number of conversations in which the agent engaged with the customer at least once while Copilot was available. Doesn't include email and voice.||
|Number of conversations using copilot AI| The number of engaged conversations that have used Copilot. Lists only those conversations that have ended.||
|Percentage of conversations using copilot AI| The percentage of engaged conversations that have used Copilot.||
|Avg conversation handle time|The average time that elapsed after conversation started until it ended. The chart displays data when Copilot was used and when it wasn't used.||
|Conversation throughput|The number of conversations, excluding email and voice, completed on an average per day. The chart displays data when Copilot was used and when it wasn't used. ||

### Satisfaction

|Metric  |Description  |Derivation  |
|---------|---------|---------|
|Agent ratings| The graph displays the number of times agents rated a copilot response positively or negatively  ||

### See also

[Use copilot features](use-copilot-features.md)  
[Configure copilot](configure-copilot-features.md)  
[Enable historical analytics for Copilot](configure-cs-historical-analytics-csh.md#enable-historical-analytics-for-copilot-preview)
