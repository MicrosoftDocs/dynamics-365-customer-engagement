---
title:  Enable voice call experiences
description: Learn how to configure agent call quality feedback and automatically remove a customer from hold.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.collection: 
ms.date: 11/25/2024
ms.custom: bap-template 
---

# Enable voice call experiences

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Use the **Voice call experiences** page in Contact Center admin center or Customer Service admin center to configure the following features:

- [Configure agent call quality feedback survey](#configure-agent-call-quality-feedback-survey)
- [Disable taking a customer off hold automatically](#disable-taking-a-customer-off-hold-automatically)

## Configure agent call quality feedback survey 

Agents can rate and provide feedback on their voice calling experience after the call ends using the agent call quality survey. The survey helps you evaluate call quality beyond technical factors such as audio and video bitrate, jitter, and latency, enabling you to understand if the agent had a satisfactory experience. You can analyze the survey data in Azure logs to gain insights and identify areas that require improvement.

## Enable agent call quality surveys

Perform the following steps to enable agent call quality surveys:

1. In Customer Service admin center or Contact Center admin center, select **Workspaces** and then select **Voice call experiences**. You can enable the survey from **Voice settings** in voice workstreams. 
3. Switch the **Agent call quality survey** toggle to **On**.
4. Specify the frequency at which the survey should be presented to the agent. Optionally, you can also switch the **Set survey duration** toggle to **On** and specify the duration during which the survey must appear for the agent.

 :::image type="content" source="../media/voice-configure-rating.png" alt-text="Screen shot of the Agent call quality survey page." :::

### Store and view survey data

You must enable the Call Survey Logs [Diagnostic Setting](/azure/communication-services/concepts/analytics/enable-logging) in Azure Monitor to send the [log data](/azure/communication-services/concepts/analytics/logs/end-of-call-survey-logs) of your surveys to a Log Analytics workspace, Event Hubs, or an Azure storage account to receive and analyze your survey data. If you don't send survey data to one of these options your survey data isn't stored and can be lost.

**Sample query**

You can modify any of the out-of-the-box queries to get the required call id information. Here's a sample query to see the audio issues column chart.

```

// Audio issues 
// Query the call survey data and show the audio issues column chart. 
ACSCallSurvey
| where isempty(AudioIssues) == false
//Comma separated issues when multiple issues are reported
| project audio =  split(AudioIssues,','), CallId, TimeGenerated, VideoIssues, AudioIssues, ScreenshareIssues, OverallCallIssues
| mv-expand audio to typeof(string)

```

## Disable taking a customer off hold automatically

When you transfer a call to another agent, the customer is automatically put on hold. The customer is removed from hold automatically when the secondary agent accepts the transferred call. To disable this behavior, and manually take the customer off hold, perform the following steps:
- In Customer Service admin center or Contact Center admin center, select **Workspaces** and then select **Voice call experiences**.
- Turn off the **Un-hold customer after agent transfer is accepted** toggle. 

## Next steps

[Share feedback on call quality](/dynamics365/contact-center/use/voice-channel-agent-experience#share-feedback-on-call-quality)  
