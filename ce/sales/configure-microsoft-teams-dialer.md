---
title: Configure Microsoft Teams dialer in Dynamics 365 Sales
description: Configure Microsoft Teams dialer to enable sellers to make and receive calls from Dynamics 365.
ms.date: 07/16/2024
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.collection:
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/16/2023
---
# Configure Microsoft Teams dialer

Microsoft Teams dialer helps sellers make Teams calls to customers directly from within Dynamics 365 Sales.

> [!NOTE]
> You can also enable Teams dialer through quick setup (with the Dynamics 365 Sales Enterprise license). More information: [Microsoft Teams calls with conversation intelligence](digital-selling-microsoft-teams-calls.md)

## How to configure the dialer?

As an administrator, you must configure Microsoft Teams dialer to enable sellers to make and receive calls from Dynamics 365.

1. [Review the prerequisites](#review-the-prerequisites).
2. [Configure the dialer](#configure-the-dialer).

## Review the prerequisites

Ensure that you meet the following requirements before you configure Microsoft Teams dialer in the Sales Hub app:

- A license for using Microsoft Teams. [Learn more about Microsoft Teams add-on licenses.](/MicrosoftTeams/teams-add-on-licensing/microsoft-teams-add-on-licensing?tabs=small-business)  

- A phone system installed and configured, with a valid license to use it. [Learn more about how to set up a phone system.](/MicrosoftTeams/setting-up-your-phone-system)  
- A valid public switched telephone network (PSTN) connection through a Teams calling plan, your own PSTN carrier, or direct routing. [Learn more about PSTN connectivity options.](/microsoftteams/pstn-connectivity?source=recommendations)  
- An assigned phone number. [Learn more about how to manage telephone numbers for your organization.](/microsoftteams/manage-phone-numbers-landing-page)  

Additionally, you must grant the following permissions to your users:

- If you're planning to enable the dialer for specific security roles, ensure that users who need access to the dialer are assigned to one of those security roles. [Learn more about how to assign security roles to users.](security-roles-for-sales.md#assign-security-roles-to-users)
- Ensure that the security roles of users who will be accessing the Teams dialer have read privileges to the following records:

    - Under the **Core Records** tab, read access to **Note**
    - Under the **Custom Entities** tab, read access to **Teams Dialer Admin settings**

    For more information about how to verify privileges and edit a security role, see [Edit a security role](/power-platform/admin/create-edit-security-role#edit-a-security-role).

    > [!NOTE]
    > When you enable Microsoft Teams dialer, other telephony systems that are connected to the Dynamics 365 app through Dynamics 365 Channel Integration Framework will stop working for users to whom Teams dialer is enabled. As an administrator, you can deactivate or delete the phone system in the Channel Integration Framework app.

## Configure the dialer

1. In the Sales Hub app, go to **App settings**, and under **General settings**, select **Teams calls**.

    > [!NOTE]
    > If you are a Sales Professional customer, append the following parameters to your Dynamics 365 org URL to open the Teams calls configuration page:
    >
    > `pagetype=control&controlName=MscrmControls.TeamsDialerSettings.DialerSettingsHostControl`
    >
    > Example: `https://contoso.crm.dynamics.com/main.aspx?pagetype=control&controlName=MscrmControls.TeamsDialerSettings.DialerSettingsHostControl`
    >
    > Alternatively, you can add the configuration page to your Sales Professional app's sitemap by [adding a subarea](/power-apps/maker/model-driven-apps/create-site-map-app#add-a-subarea-to-a-group-in-the-site-map).

1. Turn on **Teams calls**.

    By default, the following options are turned on:

    - **Answer incoming calls in Dynamics 365**

        Allows sellers to receive Teams calls in Dynamics 365 Sales. If you turn it off, sellers can only make outgoing Teams calls from within Dynamics 365.

    - **Internal call will ring only in the Teams app, not in Dynamics 365**

        Indicates that calls from internal users won't ring and won't be tracked in Dynamics 365. In this case, calls from external contacts will ring in Dynamics 365 and internal calls will ring only in Teams. You can clear the checkbox if you want sellers to receive both external and internal calls in Dynamics 365.

    - **Display missed calls in the Dynamics 365 in-app notification center**

        Allows sellers to see missed calls in the in-app notification center in Dynamics 365. Before you enable this feature, complete the following actions:  
            - [Allow in-app notifications for the app](/power-apps/developer/model-driven-apps/clientapi/send-in-app-notifications?tabs=clientapi#enable-the-in-app-notification-feature).  
            - Grant read permissions for the **Notification** entity under the **Custom entity** tab, for the security roles that need to see the notifications.
                :::image type="content" source="media/notification-entity.png" alt-text="Screenshot of the Custom entity tab, with the Notification entity highlighted":::

    <a name="teams-call-transfer"></a>

    - **Transfer calls (preview)**

        [!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

        [!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

        Allows sellers to transfer a Teams call to another colleague or their phone number, either directly or after consultation with the recipient.

        More information:

        [Transfer a Teams call (preview)](call-using-microsoft-teams.md#transfer-a-teams-call-preview)  
        [Consult and transfer a Teams call (preview)](call-using-microsoft-teams.md#consult-and-transfer-a-teams-call-preview)

    <a name="teams-add-people-to-call"></a>

    - **Add people to calls (preview)**

        [!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

        [!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

        Allows sellers to add another participant to an ongoing Teams call. The added participant can be an internal user or an external contact. 

        **More information:** [Add a participant to an ongoing Teams call (preview)](call-using-microsoft-teams.md#add-a-participant-to-an-ongoing-teams-call-preview)

    <a name="teams-call-from-views"></a>
    - **Call from views**
    
        Allows Dynamics 365 to use Teams dialer when sellers click on a phone number link on list views. If you already have an integration with the browser's Call event, we recommend turning this option off.

        **More information:** [Call a customer from the list view](call-using-microsoft-teams.md#call-from-list-view)

    <a name="teams-call-attempts"></a>
    - **Document call attempts**
    
        Specifies that call attempts of unanswered calls should also be recorded in the activity history. By default, this option is turned off.

        **More information**: [View phone call activities](call-using-microsoft-teams.md#view-phone-call-activities)

1. In the **Security role** section, select one of the following options to provide permissions to users to access Microsoft Teams dialer.

    | Option | Description |
    |--------|-------------|
    | All security roles | Allows all the security roles to access Microsoft Teams dialer. |
    | Specific security roles | <p>Allows only the selected security roles to access Microsoft Teams dialer.</p><p>**Note**: Ensure that the security roles you've selected are associated with the root business unit (top level in the business unit hierarchy). Otherwise, the users won't see the Teams dialer in the Sales Hub app. More information: [Create or edit business units](/power-platform/admin/create-edit-business-units)</p> |

1. Select **Advanced options**, and in the **Select app** drop-down list, select the apps in which you want to make the dialer available. By default, **Sales Hub** is selected.

    > [!NOTE]
    > Teams dialer is not supported for Dynamics 365 canvas apps.

1. (Optional) Enable call recording and get real-time transcription and insights through conversation intelligence:

    1. Turn on **Recording with real-time transcription and insights**.
    1. Select the security roles for which you want to enable recording.
    1. Select **Go to advanced conversation intelligence settings** to configure more options related call recording, keyword to track, call summary and so on. For more information, see [First-run setup in conversation intelligence app](fre-setup-sales-insight-app.md).

1. Save and publish the configuration.

    A confirmation message is displayed, and the Microsoft Teams dialer is enabled in your organization for selected security roles in the selected app.

    > [!NOTE]
    > - You must refresh the configuration page to make the changes available in the application. Users must refresh their page to see the dialer.
    > - If the dialer doesn't show up in a custom app that you've added it to, remove it from the app, save the changes, and then add the dialer again.
    > - The dialer isn't supported for custom entities. Though the phone icon appears on the custom entity forms, the dialer doesn't work.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Microsoft Teams integration](../teams-integration/teams-integration.md)  
[Call using Microsoft Teams](call-using-microsoft-teams.md)  
[Call a customer](/dynamics365/ai/sales/connect-with-customers#call-a-customer)  
[View and understand call summary pages](/dynamics365/ai/sales/view-and-understand-call-summary)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
