---
title: Set up Microsoft Teams for conversation intelligence
description: Learn how to set up conversation intelligence with Microsoft Teams in Dynamics 365 Sales.
ms.date: 05/15/2023
ms.custom: bap-template
ms.topic: how-to
ms.service: dynamics-365-sales
ms.assetid: 3e099e3a-f6cb-42cf-b84e-9f8b0c6ee9db
author: lavanyakr01
ms.author: lavanyakr
---

# Set up Microsoft Teams for conversation intelligence

Using Teams together with conversation intelligence in Dynamics 365 Sales helps organizations transform customer interactions into revenue. Calling with Teams allows sellers to view business-critical insights both during the call&mdash;in real-time&mdash;and after.

As an administrator, you can configure conversation intelligence with Microsoft Teams in your sales app. Enable Microsoft Teams call recording for conversation intelligence, select storage, grant app permissions, and define organization-level tracked keywords and competitors. After that, you can [configure sales team-level settings](configure-sales-team-level-settings.md).

If you have the Dynamics 365 Sales Enterprise license, you can enable Teams call recording through quick setup. Go to the **Get started with digital sales** page under **App Settings** in your sales app. Your sellers will get three hours of conversation intelligence per month.

[Learn more about conversation intelligence for Sales Enterprise license](digital-selling-microsoft-teams-calls.md).

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Prerequisites

- Your organization has a Microsoft Teams Phone System installed and a valid license to use it. [Set up your phone system](/microsoftteams/setting-up-your-phone-system).
- You have a license to use Teams. [Learn more about Microsoft Teams add-on licenses](/microsoftteams/teams-add-on-licensing/microsoft-teams-add-on-licensing?tabs=small-business).

## Enable calling with Teams

Before you configure Teams with conversation intelligence, you must [enable and configure the Teams dialer for your organization](/dynamics365/sales-enterprise/configure-microsoft-teams-dialer).

<a name="teams-tenant-admin-contact"></a>
A Teams administrator must set up the phone system and Teams for your organization.

## Configure Microsoft Teams call recording

1. Sign in to Dynamics 365 Sales Hub as an administrator.

1. Select the **change area** in the lower-left corner of the page, and then select **Sales Insights settings**.  

1. Under **Productivity**, select **Conversation intelligence** to open the **Microsoft Teams call recordings** page.

    :::image type="content" source="media/ci-admin-enable-teams-preview.png" alt-text="Screenshot of the Microsoft Teams call recordings page in Sales Insights settings.":::

1. Turn on **Microsoft Teams call recordings**, and then configure the other settings as described in the following table.

    | Option | Description |
    |--------|-------------|
    | Enable recording for | Specifies the security roles that have permission to record calls placed using the Teams dialer. By default, this permission is granted to all security roles in your organization. To allow only specific roles to record calls, select **Specific security roles**, and then use the lookup to select the roles.<br>**Tips:**<br><ul><li>To implement the feature in your entire organization, select all security roles.</li><li>For a phased implementation in your organization, create different security roles for each group of users and then assign the security role accordingly.</li></ul><br>**Note:**<br><ul><li>Make sure that the users who need to record calls are [assigned to the selected security roles](/power-platform/admin/assign-security-roles).</li><li>Make sure that the selected security roles [have read privileges](/power-platform/admin/security-roles-privileges) to **Recording** records.</li></ul> |
    | Call recording options | Select an option for initiating call recordings:<br><ul><li>**Manual recording**: Select this option to allow sellers to manually start or stop the recording when they place a call. Select **Automatically start recording the sellers** to record sellers automatically when a call begins. Sellers can start or stop recording the customer at any time.</li><li>**Automatic recording**: Select this option to automatically record calls. Select **Allow sellers to manually stop recording** to allow sellers to stop the recording at any time.</li></ul> |
    | Recording notification for customers | Select this option to notify customers when call recording starts. |  

    >[!NOTE]
    > Unless this is the first time you're setting up conversation intelligence for Teams, the remaining steps are optional. You can complete them now or later as needed.

1. (Optional) Under **Call recording storage**, configure the storage-related options as described in the following table.

    | Option | Description |
    |--------|-------------|
    | Storage for call recordings | Select an option to store your call recordings for analysis:<br><ul><li>**Microsoft provided storage**: Select this option to use storage provided by Microsoft. This option is selected by default, and we recommend that you don't change it unless you need to retain call recording data for longer than 90 days.</li><li>**Your own Azure storage**: Select this option to use your custom Azure storage. You must select this option to retain call recording data for longer than 90 days. After you select this option, enter the **Storage connection string** and **Container name**.</li></ul>[Learn how to configure conversation intelligence to connect call data](configure-conversation-intelligence-call-data.md). |
    | Retention policy | Select how long to retain call recording data. The application deletes the data when it reaches the time limit. [Learn more about data retention and access](data-retention-deletion-policy.md).<br>For Microsoft-provided storage, the available retention periods are 30 days and 90 days. If your organization requires a longer retention period, you'll need to use your own storage. |

    :::image type="content" source="media/ci-admin-teams-choose-storage-retention-policy.png" alt-text="Screenshot of call recording storage settings.":::

1. Under **Business settings**, configure the following settings:

    - In the **Conversation tracking** section, add the keywords and competitors that your organization wants to track during calls.

        Adding keywords and competitors is a required global setting that's applied to all sales calls in the organization. To enable conversation intelligence, you must set at least one keyword and at least one competitor. You can update keywords and competitors later if necessary. [Learn more about configuring keywords and competitors in conversation content](configure-keywords-competitors.md).

    - In the **Automated summaries** section, leave **Enable call summary** selected to let your sellers view the notes after their calls. [Learn more about the call summary page](view-and-understand-call-summary-sales-app.md).

    - In the **My languages** section, add the languages your sellers use during their calls with customers to ensure accurate transcription, keyword tracking, analysis, insights, and KPIs.

    :::image type="content" source="media/ci-admin-conversation-trackers.png" alt-text="Screenshot of business settings.":::

1. (Optional) In the **Data consent and privacy** section, select **Allow read-only access to data** to allow Microsoft to improve the quality of insights by giving read-only access to your organization's conversation intelligence data.  

    :::image type="content" source="media/ci-admin-enable-privacy.png" alt-text="Screenshot of data consent settings.":::

1. In the **License usage** section, you can view information about the total call recording processing hours that have been used and how many of your monthly hours remain.

    :::image type="content" source="media/ci-admin-license-usage.png" alt-text="Screenshot of license usage information.":::

1. (Optional) In the **New and upcoming features** section, select the preview features that you want to enable for your Dynamics 365 org.

1. Select **Publish**. In the message that appears, read the terms and conditions and the privacy statement, and then select **Get started**.  

## Hide personal data (preview)

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

To comply with Payment Card Industry regulations, organizations must protect personal data shared by customers during calls. When you enable the option to hide personal data, credit card details such as the account number, expiration date, and CVV are masked before the call transcript is saved.

- In step 9 above, select **Hide credit card info in transcripts** to mask credit card information in the transcripts of future calls before they're saved. Currently, the credit card number mentions in the audio are not redacted.

    :::image type="content" source="media/hide-pii.png" alt-text="Screenshot of the hide personal data option.":::



#### Enable call categorization for short calls (preview)

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

If you have chosen **Automatic recording** to record all customer calls, you can enable call categorization to help your sales team to quickly identify calls that don't have useful content such as calls that went to voicemail and calls that were not answered. More information: [View categorization tag for short duration calls (Preview)](view-and-understand-call-summary-sales-app.md#view-categorization-tag-for-short-duration-calls-preview)

1. Follow steps 1 through 4 in the [Configure Microsoft Teams call recording](#configure-microsoft-teams-call-recording) to open the Teams call recording options.

1. Go to the **New and upcoming features** section, select **Call categorization (preview)**, select the type of calls you want the system to detect and tag.  

    :::image type="content" source="media/call-categorization-preview.png" alt-text="Screenshot of the New and upcoming features section with the toggle to enable preview features":::

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Introduction to administering conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)  
[Prerequisites to configure conversation intelligence](prereq-sales-insights-app.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]


