---
title: Set up conversation intelligence
description: Learn how to set up conversation intelligence with Microsoft Teams or third-party dialers in Dynamics 365 Sales.
ms.date: 07/03/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
---

# Set up conversation intelligence

Using Microsoft Teams or other third-party dialers together with conversation intelligence in Dynamics 365 Sales helps organizations transform customer interactions into revenue. Calling with these dialers allows sellers to view business-critical insights both during the call&mdash;in real-time&mdash;and after.

As an administrator, configure conversation intelligence for the dialer that your sellers use.  

If you have the Dynamics 365 Sales Enterprise license, you can enable Teams call recording through quick setup. Go to the **Get started with digital sales** page under **App Settings** in your sales app. Your sellers will get three hours of conversation intelligence per month.

[Learn more about conversation intelligence for Sales Enterprise license](digital-selling-microsoft-teams-calls.md).

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Prerequisites for Microsoft Teams

- An installation of Microsoft Teams Phone System along with a valid license to use it. [Set up your phone system](/microsoftteams/setting-up-your-phone-system).
- A license to use Teams. [Learn more about Microsoft Teams add-on licenses](/microsoftteams/teams-add-on-licensing/microsoft-teams-add-on-licensing?tabs=small-business).

- [Teams dialer enabled and configured for your organization](configure-microsoft-teams-dialer.md)

## Prerequisites for third-party dialers

- A valid license and subscription to use the third-party dialers. Refer to your telephony provider's documentation to set up the phone system and dialer.

- [Integrate the third-party dialer with Dynamics 365 Sales](ci-third-party-sp-integration.md).  

## Open the conversation intelligence settings page

1. Select **Change area** in the lower-left corner of the page, and then select **Sales Insights settings**.  

1. Under **Productivity**, select **Conversation intelligence**.

## Create or edit a recording policy

Recording policies define the call provider, security roles, and recording options. You can create multiple recording policies and assign them to different security roles. For example, you can create a recording policy for your sales managers that allows them to record calls automatically and another one for your sales representatives that allows them to record calls manually. If your sellers use multiple call providers, you can create a recording policy for each provider.

1. [Open the **Conversation intelligence settings** page](#open-the-conversation-intelligence-settings-page).

1. In the **Call providers and recording** section, select your call provider. For example, select **Teams** to create a recording policy for your Teams calls. To edit an existing policy, select the policy from the **Recording policies** table in this section.

    > [!NOTE]
    > This section lists only those providers that are configured and integrated. If you don't see your provider listed, verify the prerequisites listed in this article.  

    :::image type="content" source="media/ci-call-providers.png" alt-text="Screenshot of the call providers and recording page in Conversation intelligence settings." lightbox="media/ci-call-providers.png":::

1. In the **New recording policy** pane, specify a unique name for the policy. 
1. Configure the security roles and recording options as described in the following table.

    | Option | Description |
    |--------|-------------|
    |Recording options | Select an option for initiating call recordings:<br><ul><li>**Manually record all participants**: Select this option to allow sellers to manually start the recording when a call begins and record all participants.</li> <li>**Manually record all participants, sellers are automatically recorded**: Select this option to record sellers automatically when a call begins. Sellers can start or stop recording the customer at any time.</li><li>**Automatically record all participants**: Select this option to automatically record all the participants in the call.</li> <li>**Automatically record all participants, sellers can stop recording**: Select this option to automatically record all the participants in the call. Sellers can stop the recording at any time.</li></ul> | 
    |Recording notification for customers | Turn on this option to notify customers when call recording starts.|
    | Enable recording policy for | Specifies the security roles that the policy is applicable for. Make sure that the selected security roles [have read privileges](/power-platform/admin/security-roles-privileges) to **Recording** records. <br>**Tips:**<br><ul><li>To implement the feature for your entire organization, select all security roles.</li><li>For a phased implementation, create different security roles for each group of users and then [assign the security role](/power-platform/admin/assign-security-roles) accordingly.</li></ul>|

1. Save the changes. If you're configuring conversation intelligence for the first time, continue with the next section to configure the conversation intelligence settings.

## Configure conversation intelligence settings

Configure the settings to specify where your call recording data is stored, the retention period, and the keywords and competitors that you want to track during calls. 

1. [Open the **Conversation intelligence settings** page](#open-the-conversation-intelligence-settings-page).

1. In the **Call recording storage** section, configure the storage-related options as described in the following table.

    | Option | Description |
    |--------|-------------|
    | Storage for call recordings | Select an option to store your call recordings for analysis:<br><ul><li>**Microsoft provided storage**: Select this option to use storage provided by Microsoft. This option is selected by default, and we recommend that you don't change it unless you need to retain call recording data for longer than 90 days.</li><li>**Your own Azure storage**: Select this option to use your [custom Azure storage](create-azure-repo.md). You must select this option to retain call recording data for longer than 90 days. After you select this option, enter the **Storage connection string** and **Container name** of your Azure storage. <br> </li></ul>|
    | Retention policy | Select how long to retain call recording data. The application deletes the data when it reaches the time limit. [Learn more about data retention and access](data-retention-deletion-policy.md).<br>For Microsoft-provided storage, the available retention periods are 30 days and 90 days. If your organization requires a longer retention period, you'll need to use your own storage. |

1. Under **Business settings**, configure the following settings:

    - In the **Conversation tracking** section, add the keywords and competitors that your organization wants to track during calls. Adding keywords and competitors is a required global setting that's applied to all sales calls in the organization. To enable conversation intelligence, you must set at least one keyword and at least one competitor. You can update keywords and competitors later if necessary. [Learn more about configuring keywords and competitors in conversation content](configure-keywords-competitors.md).

    - In the **Automated summaries** section, leave **Enable call summary** selected to let your sellers view the notes after their calls. [Learn more about the call summary page](view-and-understand-call-summary-sales-app.md).

    - In the **My languages** section, add the languages your sellers use during their calls with customers to ensure accurate transcription, keyword tracking, analysis, insights, and KPIs.

    :::image type="content" source="media/ci-admin-conversation-trackers.png" alt-text="Screenshot of business settings.":::

1. (Optional) In the **Data consent and privacy** section, select **Allow read-only access to data** to allow Microsoft to improve the quality of insights by giving read-only access to your organization's conversation intelligence data.  

1. In the **License usage** section, you can view information about the total call recording processing hours that have been used and how many of your monthly hours remain.

    :::image type="content" source="media/ci-admin-license-usage.png" alt-text="Screenshot of license usage information.":::

1. (Optional) In the **New and upcoming features** section, select the preview features that you want to enable for your Dynamics 365 org. [Learn more about enabling new and upcoming features](#enable-new-and-upcoming-features).

1. Select **Publish**. In the message that appears, read the terms and conditions and the privacy statement, and then select **Get started**.  

You can [monitor the call processing status](monitor-call-processing-sales-app.md) to see how many calls have been processed and how many are pending. It may take up to 12 hours for the calls to be processed.


## Enable new and upcoming features

The following preview features are available for conversation intelligence:

- [Hide personal data (preview)](#hide-personal-data-preview)
- [Enable call categorization for short calls (preview)](#enable-call-categorization-for-short-calls-preview)

### Hide personal data (preview)

To comply with the Payment Card Industry (PCI) regulations, organizations must protect personal data shared by customers during calls. When you enable the option to hide personal data, credit card details such as credit card number, expiry date, and CVV will be masked before saving a transcript.  Learn more about [call transcripts](view-and-understand-call-summary-sales-app.md#call-transcript-and-translation). 

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

To comply with Payment Card Industry regulations, organizations must protect personal data shared by customers during calls. When you enable the option to hide personal data, credit card details such as the account number, expiration date, and CVV are masked before the call transcript is saved.

1. [Open the **Conversation intelligence settings** page](#open-the-conversation-intelligence-settings-page).

1. Go to the **New and upcoming features** section, select **Hide credit card info in transcripts** to mask credit card information in the transcripts of future calls before they're saved. Currently, the credit card number mentions in the audio are not redacted.
    :::image type="content" source="media/call-categorization-preview.png" alt-text="Screenshot of the New and upcoming features section with the toggle to enable preview features and the hide credit card info option.":::



### Enable call categorization for short calls (preview)

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

If you have chosen **Automatic recording** to record all customer calls, you can enable call categorization to help your sales team to quickly identify calls that don't have useful content such as calls that went to voicemail and calls that were not answered. More information: [View categorization tag for short duration calls (Preview)](view-and-understand-call-summary-sales-app.md#view-categorization-tag-for-short-duration-calls-preview)

1. [Open the **Conversation intelligence settings** page](#open-the-conversation-intelligence-settings-page).

1. Go to the **New and upcoming features** section, select **Call categorization (preview)**, select the type of calls you want the system to detect and tag.  

    :::image type="content" source="media/call-categorization-preview.png" alt-text="Screenshot of the New and upcoming features section with the toggle to enable preview features and call categorization options":::


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

- [Configure sales team-level settings](configure-sales-team-level-settings.md)  
- [Introduction to administering conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)  
- [Prerequisites to configure conversation intelligence](prereq-sales-insights-app.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
