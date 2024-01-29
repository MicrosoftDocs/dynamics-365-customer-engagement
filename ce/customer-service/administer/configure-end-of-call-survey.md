---
title:  Configure survey for call quality feedback (preview)
description: Learn how to configure end of call surveys.
author: gandhamm
ms.author: mgandham
ms.topic: how-to
ms.collection: 
ms.date: 01/29/2024
ms.custom: bap-template 
---

# Configure survey for call quality feedback (preview)

> [!Important]
> - This is an early access feature. 
> - Early access features aren't meant for production use and may have restricted functionality. These features are available before an official release so that customers can [get early access](/power-platform/admin/opt-in-early-access-updates) and provide feedback.

Agents can rate and provide feedback on their voice calling experience after the call ends using the end-of-call survey. The survey helps you evaluate call quality beyond technical factors such as audio and video bitrate, jitter, and latency, enabling you to understand if the agent had a satisfactory experience. You can analyze the survey data in Azure logs to gain insights and identify areas that require improvement.

## Enable end-of-call surveys

Perform the following steps to enable end-of-call surveys:

1. In Customer Service admin center, select **Workspaces** and then select **Agent call quality survey (preview)**. You can enable the survey from **Voice settings** in voice workstreams. 
3. Set the **Agent call quality survey** toggle to **On**.
4. Specify the frequency at which the survey should be presented to the agent. Optionally, you can also set **Set survey duration** toggle to **On** and specify the duration during which the survey must appear for the agent.

 :::image type="content" source="../media/voice-configure-rating.png" alt-text="Screen shot of the Agent call quality survey page." :::

## Store and view survey data

You must enable a [Diagnostic Setting](/azure/communication-services/concepts/analytics/enable-logging) in Azure Monitor to send the [log data](/azure/communication-services/concepts/analytics/logs/end-of-call-survey-logs) of your surveys to a Log Analytics workspace, Event Hubs, or an Azure storage account to receive and analyze your survey data. If you don't send survey data to one of these options your survey data isn't stored and can be lost.

## Next steps

[Share feedback on call quality](../use/voice-channel-agent-experience.md#share-feedback-on-call-quality-preview)
