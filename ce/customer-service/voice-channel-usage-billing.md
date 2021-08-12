---
title: "View Usage and Billing in the Voice channel | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/13/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---


# Preview: View usage and billing

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>
> [!INCLUDE[cc-preview-features-send-us-feedback](../includes/cc-preview-features-send-us-feedback.md)]

## Introduction

The Voice usage report lets Omnichannel administrators view a PowerBI report in Omnichannel admin center, which tells them how many minutes of the voice quota have been consumed by the voice channel, and helps them to get insights where they can pinpoint to control the consumption. The following areas are covered: 

- How many minutes this org has already consumed (with quota limits in mind)?

- Is there any abnormal daily usage (regarding consumed minutes) over time that needs attention? 

- After identifying the abnormal usage, determine where those call minutes have been consumed. Is it related to a specific workstream, queue,  phone number, or call type (inbound and outbound)?

- Is it consumed in specific conversations?

- What's happened in the conversation that caused the problem?

## Prerequisites

The voice channel should be configured and in use for the report to display data.

## View the voice usage report

To view the voice usage report, go to the Omnichannel admin center app, and in the site map, under **Insights**, select **Voice usage (Preview)**.

> ![The voice usage report.](media/voice-usage-report.png "The voice usage report.")

The following table explains the metrics.

|Metric|Description|
|--------|------|
|Call intelligence minutes|How many minutes of calls from the quota limits this org has already consumed? (with quota limits in mind)  |
|Intelligent voicebot minutes|How many minutes of calls from the quota limits this org has already consumed?|
|Usage over time|Is there any abnormal daily minutes that need more attention over time? |
|||

### Slice metrics by time

The Duration option lets you filter the report details and affects all metrics in the report.


### See also

[Overview of voice channel in Omnichannel for Customer Service](voice-channel.md)  