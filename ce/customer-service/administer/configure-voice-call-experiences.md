---
title: Enable voice call experiences
description: Learn how to configure representative call quality feedback and automatically remove a customer from hold.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.collection: 
ms.date: 03/23/2026
ms.custom: bap-template 
---

# Enable voice call experiences

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

Use the **Voice call experiences** page in Copilot Service admin center to configure the following features:

- [Configure representative call quality feedback survey](#configure-representative-call-quality-feedback-survey)
- [Disable taking a customer off hold automatically](#disable-taking-a-customer-off-hold-automatically)
- [Allow DTMF input broadcast across all participants during a call](#allow-dtmf-input-broadcast-across-all-participants-during-a-call)
- [Set up secured experience for consult with and transfer to external contact]

## Configure representative call quality feedback survey

Customer service representatives (service representatives or representatives) can rate and provide feedback on their voice calling experience after the call ends using the representative call quality survey. The survey helps you evaluate call quality beyond technical factors such as audio and video bitrate, jitter, and latency, enabling you to understand if the service representative had a satisfactory experience. You can analyze the survey data in Azure logs to gain insights and identify areas that require improvement.

### Enable representative call quality surveys

Perform the following steps to enable representative call quality surveys:

1. In Copilot Service admin center, select **Workspaces** in **Support experience** and then select **Voice call experiences**. You can enable the survey from **Voice settings** in voice workstreams. 
1. Switch the **Customer service representative call quality survey** toggle to **On**.
1. Specify the frequency at which the survey should be presented to the representative. Optionally, you can also switch the **Set survey duration** toggle to **On** and specify the duration during which the survey must appear for the representative.

 :::image type="content" source="../media/voice-configure-rating.png" alt-text="Screen shot of the Customer service representative call quality survey page." :::

### Store and view survey data

You must enable the Call Survey Logs [Diagnostic Setting](/azure/communication-services/concepts/analytics/enable-logging) in Azure Monitor to send the [log data](/azure/communication-services/concepts/analytics/logs/end-of-call-survey-logs) of your surveys to a Log Analytics workspace, Event Hubs, or an Azure storage account to receive and analyze your survey data. If you don't send survey data to one of these options, your survey data isn't stored and can be lost.

**Sample query**

You can modify any of the out-of-the-box queries to get the required call ID information. Here's a sample query to see the audio issues column chart.

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

When you transfer a call to another representative, the customer is automatically put on hold. The customer is removed from hold automatically when the secondary representative accepts the transferred call.

To manually take the customer off hold, turn off this behavior by performing the following steps:

1. In Copilot Service admin center, select **Workspaces** and then select **Voice call experiences**.
1. Turn off the **Un-hold customer after representative transfer is accepted** toggle.

## Allow DTMF input broadcast across all participants during a call

After you enable dual-tone multi-frequency (DTMF) input broadcast, the keypad input is sent faster and more reliably from representatives to all parties in the call. In transfer scenarios, after the representative transfers the call to an external participant, the external participant also receives any keypad input that customers send.

1. In Copilot Service admin center, select **Workspaces** > **Voice call experiences** > **Manage**.
1. Turn on the toggle for **Allow DTMF to be broadcasted across all participants during a call** and save the changes.

## Set up secured experience for consult with and transfer to external contacts (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

Configure the system to enforce security for recording, transcription, and hold settings during consultation with or transfer to external contacts, such as payment gateways and verification service numbers. Learn how the security settings affect consultation and transfer experiences in [Consult with external contacts and transfer a call securely](../use/voice-channel-transfer-consult.md#)

> [!NOTE]
> If you don't configure the secure settings, recording and transcription continue during consultation or after bridged transfer to external contacts.

1. In Copilot Service admin center, select **Workspaces** > **Voice call experiences** > **Manage**. The **Voice call experiences** page appears.

1. In the **External Contact Settings (preview)** section, select **New**. The **Add new external contact** pane appears.
1. Enter the following details for the external contact. Optionally, use **Search contact**. The system populates the details when you select a contact from the search results.  
   - **First name**  
   - **Last name**  
   - **Mobile number**  
   - Under **Privacy & security** > **Consult** and **Privacy & security** > **Bridged transfer**, set how calls need to be handled:  
     - **Transcription & recording**: Select one of the following options for **Consult** and **Bridged transfer** to indicate how the system should handle recording and transcription when consulting with or transferring a call to this external contact.
          - **Follow workstream settings**: Inherits the workstream configuration for transcription and recording. You can use this option when you don’t need a override for this number. Learn more in [Enable call recording and transcription for voice](voice-channel-configure-transcripts.md#enable-call-recording-and-transcription-for-voice).
          - **Turn off recording (keep transcription if active)**: Stops audio recording but continues transcription. This option is useful when audio storage isn’t allowed, but text transcripts are allowed for auditing.
          - **Turn off transcription & recording**: Recording and transcription are disabled. This setting is ideal for highly sensitive calls where data capture isn't allowed.  
     - **Hold**: This setting is applicable to consult only. Select one of the following options to indicate how the system should handle hold settings when consult is in progress with this external contact.
          - **Customer on hold**: The customer is automatically placed on hold during the secure consult, and the hold cannot be removed by the representative.
          - **Agent on hold**: The customer service representative is automatically placed on hold during the secure consult, and the hold cannot be removed by the representative. If multiple service representatives are on the call, they are all placed on hold.
          - **Follow workstream settings**: Inherits the workstream configuration setting.
1. Save and close. The external contact is listed with the configured options.

Manage the external contact to edit the options or delete the contact.

> [!NOTE]
> Secure settings apply to all bridged transfers, including those initiated from AI agents or Overflow actions.

## Related information

[Share feedback on call quality](/dynamics365/contact-center/use/voice-channel-agent-experience#share-feedback-on-call-quality)  
[Configure user input recognition](voice-channel-inbound-calling.md#configure-user-input-recognition)  
