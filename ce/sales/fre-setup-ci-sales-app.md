---
title: "First-run setup experience for conversation intelligence in sales app"
description: "First-run configuration of conversation intelligence for Microsoft Teams for your Dynamics 365 Sales environment."
ms.date: 07/12/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# First-run setup experience of Microsoft Teams for conversation intelligence

> [!IMPORTANT]
> - The enhanced experience for Microsoft Teams together with conversation intelligence is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)] 

You can configure conversation intelligence with Microsoft Teams. After you sign in to your sales app as an administrator, you can configure the complete application&mdash;enable Microsoft Teams call recording for conversation intelligence preview, select storage, grant app permissions, and define organization-level tracked keywords and competitors to be used by conversation intelligence.

After configuring conversation intelligence, a sales manager or a seller can view the data and settings that are relevant to them. More information: [Configure sales team level settings](configure-sales-team-level-settings.md)

> [!NOTE]
> You can also enable call recording through quick setup (with the Dynamics 365 Sales Enterprise license). In this case, you'll get three hours of conversation intelligence per month. To also enable call recording through quick setup, you must go to the **Get started with digital sales** page under **App Settings**. More information: [Microsoft Teams calls with conversation intelligence](digital-selling.md#microsoft-teams-calls-with-conversation-intelligence)

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Microsoft Teams for conversation intelligence

Using Teams together with conversation intelligence in Dynamics 365 Sales for calls, helps organizations transform customer interactions into revenue. Using conversation intelligence with Teams allows business-critical insights to be surfaced both in real time (during the call) and post-call, insights that are seamlessly tied to the relevant Dynamics 365 records.

## Review the prerequisites

Review the following requirements before you configure Teams recording for conversation intelligence:

- **For Teams calls:** Your organization has a Teams phone system installed with a valid license to use it. More information: [Set up Phone System in your organization](/microsoftteams/setting-up-your-phone-system)

- You have a license to use Teams. More information: [Microsoft Teams add-on licenses](/microsoftteams/teams-add-on-licensing/microsoft-teams-add-on-licensing?tabs=small-business)
- Your organization has enabled the Teams dialer for phone calls recording. More information: [Configure Microsoft Teams dialer](configure-microsoft-teams-dialer)

<a name="teams-tenant-admin-contact"></a>
> [!NOTE]
> To set up the phone system and Teams for your organization, contact your Teams administrator.
 
## Configure Microsoft Teams recording

1.	In the Sales Hub app, select the **Change area** ![change area.](media/change-area-icon.png) in the lower-left corner of the page, and then select **Sales Insights settings**.  
    
3.	On the site map, under **Productivity**, select **Conversation intelligence**.     
    The Conversation intelligence page opens. The **Call providers** section will list **Teams** if Teams dialer is already configured. If the **Call providers** section is blank, ensure that you meet the [prerequisites](#review-the-prerequisites). 

4.	(Optional), In the **Teams** card, select the ellipses (three-dots) and then select **Configure Teams calls** if you want to review or modify the Teams call configuration.
5. Select the **Teams** card to create a recording policy for Teams calls. A recording policy defines what you want to record, who you want to record, and which role has the permissions to record. The following screenshot illustrates a sample recording policy:  
    
        :::image type="content" source="media/new-recording-policy.png" alt-text="A screenshot of the new recording policy pane"::: 
5. Configure the settings as described in the following table.


    | Option | Description |
    |--------|-------------|
    |Policy name | Specifies a name for the recording policy. If you're planning to create multiple recording policies with different configurations, specify a name that identifies the policy well. 
    | Enable recording for | Specifies what you want to record. Currently, you can only record a Teams call.
    | Recording options | Select an option for initiating call recordings:<br><ul><li>**Manually record all participants**: Select this option to allow sellers to manually start or stop the recording after a call is initiated.</li><li>**Manually record all participants, sellers are recorded automatically**: Select this option to record the seller automatically after the call is initiated. However, sellers can start or stop the recording of the customer anytime during the call. </li><li>**Automatically record all participants**: Select this option if you want automatically record all the participants after a call is initiated. </li><li>**Automatically record all participants, sellers can stop recording**: Select this option to record all the participants after a call is initiated. Sellers can manually stop the recording anytime during the call.</li></ul>|
    | Enable recording policy for | Specifies the security roles who have the permission to record Teams calls. By default, this permission is granted to all the security roles in your organization. To allow only specific roles to record, select **Specific security roles**, and then use the lookup to select the roles.<br> **Tips:**<br><ul><li>To implement the feature in your entire organization, select all security roles.</li><li>For a phased implementation in your organization, create different security roles for each group of users and then assign the security role accordingly.</li></ul><br>**Note:**<br><ul><li>Ensure that the users who need to record calls are assigned to the selected security roles. More information: [Assign a security role to a user](/power-platform/admin/assign-security-roles)</li><li>Ensure that the selected security roles have read privileges to **Recording** records under the **Custom Entities** tab in manage security roles page. More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges)</li></ul>|

    >[!NOTE]
    >You only need to configure call provider and recording settings for first-time onboarding to conversation intelligence. All remaining steps are optional. You can choose to configure them now or later, as needed.

5.	Under **Call recording storage**, configure the storage-related options as described in the following table.

    | Option | Description |
    |--------|-------------|
    | Storage for call recordings | Specify where you want to store the call recordings. To provide analysis and insights for calls, conversation intelligence must be able to access these call recordings. <br><ul><li>**Microsoft provided storage**:  Select this option to use storage provided by Microsoft. We recommend that you use this option for Teams calls.</li><li>**Your own Azure storage**: Select this option if you want to use your own Azure storage. After you select this option, enter the **Storage connection string** and **Container name**.</li></ul>More information: [Configure conversation intelligence to connect call data](configure-conversation-intelligence-call-data.md) |
    | Retention policy | Choose a retention time limit. The application retains call recording data for the specified time limit, and deletes it when the time limit is reached. More information: [Data retention and access through Privacy settings](data-retention-deletion-policy.md). |   

    >[!NOTE]
    >For Microsoft-provided storage, the available retention periods are 30 days and 90 days. If your organization requires longer retention periods, do consider using your own storage.

6.	Under **Conversation tracking**, add the keywords and competitors that your organization wishes to track during calls, and add the languages used by sellers during calls with customers. Conversation intelligence can track the competitors and keywords mentioned and report on the number of times they were mentioned during a call.

    This is a required global setting that will be applied to all sales calls in the organization. To enable conversation intelligence, you must set at least one global keyword and at least one global competitor. You can update these keywords and competitors later if necessary. More information: [Configure keywords and competitors in conversation content](configure-keywords-competitors.md)
        
    > [!div class="mx-imgBorder"]
    > ![Configure conversation tracking.](media/ci-admin-conversation-trackers.png "Configure conversation tracking")

7.	(Optional) In the **Data consent and privacy** section, you can select the **Allow read-only access to data** checkbox to allow Microsoft to improve the quality of insights by giving read-only access to your organization's data in conversation intelligence.  

8.	In the **License usage** section, you can view information about the total call processing hours, and the hours used, and hours left.

    > [!div class="mx-imgBorder"]
    > ![View license usage information.](media/ci-admin-license-usage.png "View license usage information")

9.	(Optional) In the **New and upcoming features** section, select the **Enable call summary (preview)** checkbox to view the call summaries for each call. For more information on what's available in the call summary, see [View and understand call summary page in Sales Hub app](view-and-understand-call-summary-sales-app.md).

    If you don't want to enable preview features for your organization, skip this step. You can always enable them later. More information: [Enable coming soon features](../sales/enable-preview-features-sales-insights-app.md)  

    > [!div class="mx-imgBorder"]
    > ![Enable coming soon features.](media/ci-admin-coming-soon-features.png "Enable coming soon features")  

10.	Select **Publish**. In the message that appears, read the terms and conditions and the privacy statement. Select **Agree and continue**.      

    > [!div class="mx-imgBorder"]
    > ![Agree to terms and conditions to publish the configurations.](media/ci-admin-agree-terms-conditions-to-publish.png "Agree to terms and conditions to publish the configurations")    

Teams call recording with conversation intelligence is now configured and ready for use in your organization.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Introduction to administering conversation intelligence](intro-admin-guide-sales-insights.md#administer-conversation-intelligence)  
[Prerequisites to configure conversation intelligence](prereq-sales-insights-app.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]