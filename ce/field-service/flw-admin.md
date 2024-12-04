---
title: Set up Microsoft 365 integration for Field Service
description: Learn how to integrate Dynamics 365 Field Service with Outlook, Teams, and Viva Connections for your organization, including setting up user groups, deploying apps, and assigning security roles.
ms.date: 04/11/2024
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Set up Microsoft 365 integration for Field Service

As an administrator, your tasks to set up Microsoft 365 integrations for Dynamics 365 Field Service depend on which capabilities your organization decides to use:

- Microsoft Outlook
- Microsoft Teams
- Microsoft Viva Connection and Teams
- Any combination or all three

<!--- Tab 1 Outlook --->

## [Set up Field Service for Outlook](#tab/outlook)

As an admin, you can enable the Field Service for Outlook add-in for your organization or for specific users and groups.

Field Service for Outlook includes copilot AI capabilities to create work orders in Outlook. Copilot adheres to [responsible AI guidelines.](faqs-wo-flw-copilot.md) To opt out of using Copilot, see [Give consent to use Copilot in Field Service for Outlook](#give-consent-to-use-copilot-in-field-service-for-outlook).

### Prerequisites

- You have Exchange admin permissions in the Microsoft 365 admin center
- Your environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages)

### Deploy the Field Service for Outlook add-in

To set up Field Service for Outlook capability for your organization, enable it as an Outlook Add-in. For more information, see [Install or remove add-ins for Outlook for your Exchange 2013 organization](/exchange/install-or-remove-outlook-add-ins-2013-help).

1. Sign in to the [Microsoft 365 admin center](https://admin.microsoft.com/).

1. Select **Settings** > **Integrated apps**, and then select **Get apps**. For more information, see [Deploy an Office Add-in using the admin center.](/microsoft-365/admin/manage/manage-deployment-of-add-ins?#deploy-an-office-add-in-using-the-admin-center)

   :::image type="content" source="media/fsp-integrated-apps.png" alt-text="Microsoft admin center with Integrated apps highlighted":::

1. Search for and select **Dynamics 365 Field Service for Outlook**.

   :::image type="content" source="media/fsp-outlook-add-in.png" alt-text="Field Service Outlook add-in card":::

1. Select **Add**, **Get it now**, or **Update**. Confirm your information.

1. On the **Add users** page, under **Assign users**, select **Entire organization**.

   :::image type="content" source="media/fsp-outlook-add-users.png" alt-text="Field Service Outlook Add users screenshot":::

1. Select **Next**, **Accept permissions**, **Next**, and **Finish deployment**.

Users might need to relaunch Microsoft 365 to view the add-in icon on the app ribbon. Outlook add-ins can take up to 24 hours to appear on app ribbons.

### Give consent to use Copilot in Field Service for Outlook

As an admin, you can enable or disable the use of copilot capabilities in Field Service for Outlook. When enabled, you agree that data may be stored and processed outside of your tenant's geographic region or compliance boundary.

1. In the Field Service app, change to the **Settings** area.

1. In the **General** section, select **Field Service** Settings.

1. Select the **Features** tab.

   :::image type="content" source="media/fsp-fs-copilot-consent.png" alt-text="Field Service Settings page with Outlook Add-in Copilot highlighted.":::

1. To give consent to use copilot to create work orders, enable  **Copilot in Microsoft Outlook**.

1. To use copilot to generate email responses, enable **Generate email responses in Microsoft Outlook**.

1. Select **Save**.


<!--- Tab 2 Teams --->

## [Set up Field Service for Teams](#tab/teams)

### Prerequisites

- You have admin permissions for the Microsoft Teams admin center and Microsoft Teams.
- Your environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages).

### Deploy the Field Service for Teams app

[!INCLUDE [fsp-deploy-teams](../includes/fsp-deploy-teams.md)]

### Install and pin the app

1. Sign in to the [Microsoft Teams admin center](https://admin.teams.microsoft.com/).

1. Select **Teams apps** > **Set up policies**, and then select **Global (Org-wide default)**.

   > [!TIP]
   > The **Global (Org-wide default)** applies to all users in your organization unless you assign another one. If you don't want the app set up the app for all users, [create a policy](/microsoftteams/teams-app-setup-policies) that installs the app only for the users who should have it.

1. [Install the app](/microsoftteams/teams-app-setup-policies#install-apps).

1. [Pin the app](/microsoftteams/teams-app-setup-policies#pin-apps).


<!--- Tab 3 Viva Connections and Teams --->

## [Set up Field Service for Viva Connections and Teams](#tab/viva)

To integrate Field Service for Viva Connections (Preview) and Teams, you need to complete the following tasks:

- [Create user groups](#create-user-groups), if they aren't already set up.
- [Set up the Field Service for Teams app](#set-up-the-field-service-for-teams-app).
- [Set up the Field Service for Viva Connections SharePoint app](#set-up-the-field-service-for-viva-connections-sharepoint-app).
- [Add Field Service cards to the Viva Connections dashboard](#add-field-service-cards-to-the-viva-connections-dashboard).
- [Sync Microsoft Entra groups and Dataverse security roles](#sync-microsoft-entra-groups-and-dataverse-security-roles).

### Prerequisites

- You have admin permissions for the following apps:
  - Microsoft Teams Admin Center
  - Microsoft Teams
  - Microsoft 365 Admin Center
  - SharePoint Admin Center
- Your environment is in a [supported geography, region, and language](flw-overview.md#supported-geographies-regions-and-languages).
- Viva Connections is [installed and set up for your organization](/viva/connections/set-up-admin-center).
- Preview versions of Teams aren't supported.

### Create user groups

[!INCLUDE [azure-ad-to-microsoft-entra-id](../includes/azure-ad-to-microsoft-entra-id.md)]

If you haven't created user groups for your frontline workers and frontline managers, [create a group in the Microsoft 365 Admin Center](/microsoft-365/admin/create-groups/create-groups) or [create a Microsoft Entra group](/azure/active-directory/fundamentals/how-to-manage-groups).

### Set up the Field Service for Teams app

1. [Deploy the Field Service Teams app](#deploy-the-field-service-for-teams-app).

1. [Install and pin the app](#install-and-pin-the-app).

1. Open the Field Service app in Teams and select your environment.

### Set up the Field Service for Viva Connections SharePoint app

Viva Connections is included in your Microsoft Teams license. Field Service for Viva Connections is a SharePoint app that runs in Teams.

> [!NOTE]
> You must select your environment in Teams and see a validation message before deploying Field Service for Viva Connections.

1. In [Microsoft AppSource](https://appsource.microsoft.com/), search for and select **Dynamics 365 Field Service for Viva Connections**.

   :::image type="content" source="media/fsp-viva-connections-appsource.png" alt-text="Dynamics 365 Field Service for Viva Connections tile showing Get it now.":::

1. Select **Add**, **Get it now** or **Update** and confirm your information.

1. On the **SharePoint apps** page, **SharePoint Store** tab, select **Add to Apps site**.

   :::image type="content" source="media/fsp-viva-connections-add.png" alt-text="Screenshot of the SharePoint Store tab showing the Dynamics 365 Field Service for Viva Connections app, with the Add to Apps site button highlighted.":::

1. In the data access confirmation, select **Enable this app and add it to all sites**, and then select **Add**.

1. In the access approval confirmation, select **Go to API access page**.

1. On the **API access** page, select the pending request for **Dynamics 365 Field Service for Viva Connections**, and then select **Approve**. Confirm your approval.

   API access is at the tenant level and is given to all environments in the tenant. [Learn more about managing API access](/sharepoint/api-access#approve-a-pending-request).

### Add Field Service cards to the Viva Connections dashboard

The Field Service app provides four cards that you can add to the Viva Connections dashboard. For frontline managers, we recommend the **Work orders all in one place** and **Remote Assist** cards. For frontline workers, we recommend the **Upcoming work order**, **Work orders assigned**, and **Remote Assist** cards.

1. Sign in to [Microsoft Teams](https://teams.microsoft.com) as an admin and open the Viva Connections app.

1. On the dashboard, select **Edit**.

   :::image type="content" source="media/fsp-viva-connections-dashboard.png" alt-text="Screenshot of the Viva Connections dashboard, with the Edit button highlighted.":::

1. Set up the dashboard for **Frontline workers**, and then select **Continue**.

1. Select **Add a card**. Select and add each of the four Field Service cards.

   :::image type="content" source="media/fsp-cards.png" alt-text="Screenshot of the four Field Service cards to add to the Viva Connections dashboard.":::

1. [Set the target audience](/viva/connections/use-audience-targeting-in-viva-connections) for each card.

   If you don't set up the target audience for each card, the card will be available to all workers.

1. Preview the experience and then select **Publish** or **Republish**.

### Assign security roles and field security profiles

Assign Microsoft Entra ID permissions for your frontline managers and frontline workers in Field Service or Power Platform admin center. For frontline managers, we recommend the default **Field Service - Dispatcher** or the **Field Service - Administrator** role. For frontline workers, we recommend the default **Field Service - Resource** role.

To assign security roles in Field Service, go to the Field Service **Get Started** page and [set up your frontline workers](frontline-worker-set-up.md). Assign a **Security Role** and **Field Security** role. The other fields are optional. [Learn more about users and security roles and profiles](view-user-accounts-security-roles.md).

### Sync Microsoft Entra groups and Dataverse security roles

Synchronize your Microsoft Entra groups to the Dataverse security roles. Although this step is optional, we recommend that you assign Microsoft Entra ID permissions to ensure that adding and removing users is reflected in both Microsoft Entra ID and Power Platform. To automate the process using the Web API, see [Assign a security role to a Microsoft Entra group team](/power-apps/developer/data-platform/aad-group-team#assign-a-security-role-to-an-aad-group-team).

1. Sign in to the [Microsoft 365 admin center](https://admin.microsoft.com/).

1. [Create a security group and add members to it](/power-platform/admin/control-user-access#create-a-security-group-and-add-members-to-the-security-group).

1. [Assign a security role to the group](#assign-security-roles-and-field-security-profiles).

### Set up column level security (optional)

If some of the user's permissions are inadequate to view or create work orders, you can grant the user an elevated security role or change the column-level security of the user’s security role. For more information, see [Set up users and security profiles](users-licenses-permissions.md) and [Security roles and privileges](/power-platform/admin/security-roles-privileges).

1. Go to [Power Apps](https://make.powerapps.com/).

1. Select your environment in the top bar.

1. In the left navigation pane, select **Solutions**, and then find and select the **Default Solution**.

   :::image type="content" source="media/fsp-powerapps-default-solution.png" alt-text="PowerApps screenshot showing Default Solution":::

1. Under **Object**, select **Column security profiles**.

   :::image type="content" source="media/fsp-powerapps-column-security-profiles.png" alt-text="PowerApps screenshot showing Column security profiles selection":::

1. Edit the desired column level profiles.

---

## Next steps

- [Customize the experience](flw-customization.md)
- [Set up the Dynamics 365 Field Service Plugin for Microsoft Copilot](flw-copilot-setup.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
