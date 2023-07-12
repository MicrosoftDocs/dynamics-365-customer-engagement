---
title: Field Service (Preview) for Administrators
description: Learn about the Dynamics 365 Field Service (Preview) from an Administrator perspective.
ms.date: 07/11/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
---

# Field Service (Preview) for Administrators

[!INCLUDE[public-preview-banner](../../includes/public-preview-banner.md)]

As an administrator for your organization, the set up tasks for the Field Service (Preview) depends on which capabilities your organization chooses to use. You can use one or the other or both.

- Field Service (Preview) Outlook Add-in
- Field Service (Preview) Teams app

> [!div class="op_single_selector"]
> [Set up the Field Service (Preview) Outlook Add-in](#set-up-the-field-service-preview-outlook-add-in)
> [Set up the Field Service (Preview) Teams app](#set-up-field-service-preview-teams-app)

## Set up the Field Service (Preview) Outlook Add-in

As an admin, you can quickly enable the Field Service (Preview) Outlook Add-in for your organization and the frontline employees are ready to go. The Outlook add-in also includes copilot capabilities to create work orders in Outlook. If you want to opt out of using Copilot, please fill out the following form: https://go.microsoft.com/fwlink/?linkid=2240475.

> [!NOTE]
> Outlook Preview is not supported.

### Prerequisites

- Global admin or Exchange admin permissions in the Microsoft 365 Admin Center

### Enable the Field Service (Preview) Outlook Add-in (optional)

To set up the Field Service (Preview) Outlook capability for your organization, enable it as an Outlook Add-in. For more information, see [Install or remove add-ins for Outlook for your Exchange 2013 organization](/exchange/install-or-remove-outlook-add-ins-2013-help). If you choose not to enable the Outlook Add-in for your organization, each user can enable it.

1. Log into the [Microsoft 365 Admin Center](https://admin.microsoft.com/) as a global admin or Exchange admin.

1. In the left pane under the **Admin centers** section, select **Exchange**.

   > [!TIP]
   > You might need to select **Show all** to view the **Admin centers** section.

1. Under the **Organization** section, select **Add-ins**.

   :::image type="content" source="media/exchange-admin.png" alt-text="Microsoft Exchange admin center with Add-ins highlighted":::

1. Select **Add from App Store**.

1. Search for and select **Dynamics 365 Field Service for Outlook (Preview)**.

   :::image type="content" source="media/fsp-outlook-add-in.png" alt-text="Field Service (Preview) Outlook add-in card":::

1. Select **Get it now** and confirm your information.

   :::image type="content" source="media/fsp-outlook-add-users.png" alt-text="Field Service (Preview) Outlook Add users screenshot":::

1. Enable the add-in for the **Entire organization**.

1. Select **Next** and **Accept permissions**.

1. Select **Next** and **Finish deployment**. Then, select **Done**.

## Set up Field Service (Preview) Teams app

The Field Service (Preview) Teams app requires the following setup:

- [Create user groups](#create-user-groups), if they are not already set up
- [Deploy Teams Tab app](#deploy-teams-tab-app-package)
- [Select an environment](#select-an-environment)
- [Install and set up Viva Connections](#install-and-set-up-viva-connections), if it’s not already installed
- [Deploy Viva Connections Cards for Field Service (Preview)](#deploy-viva-connections-cards-for-field-service-preview)
- [Add Field Service (Preview) cards to the dashboard](#add-field-service-preview-cards-to-the-viva-connections-dashboard)
- [Assign audiences](#assign-security-roles-and-field-security-profiles)
- [Sync Azure Active Directory groups and Dataverse security roles](#sync-azure-active-directory-groups-and-dataverse-security-roles)

> [!NOTE]
> Teams Preview is not supported.

### Prerequisites

Admin permissions for the following apps:

- Microsoft Teams Admin Center
- Microsoft Teams
- Microsoft 365 Admin Center
- SharePoint Admin Center

### Create user groups

If you have not created user groups for your frontline workers and frontline managers, [create a group in the Microsoft 365 Admin Center](/microsoft-365/admin/create-groups/create-groups?view=o365-worldwide) or [create an Azure Active Directory group](/azure/active-directory/fundamentals/how-to-manage-groups).

### Deploy Teams Tab app package

Make the Field Service (Preview) app available in Teams.

1. Log in to the [Microsoft Teams Admin Center](https://admin.teams.microsoft.com/).

1. [Auto install the Dynamics 365 Field Service (Preview) Teams app](/microsoftteams/auto-install-approved-apps).

1. After the app is added, select the link to manage it.

   :::image type="content" source="media/fsp-teams-link-manage.png" alt-text="Teams screenshot highlighting select link to manage the app.":::

1. [Grant permissions to use the app](/microsoftteams/app-permissions-admin-center#view-resource-specific-consent-permissions-of-an-app).

1. Optionally, [pre-pin and pre-install the app](/microsoftteams/teams-app-setup-policies#pin-apps) for your organization.

The Field Service (Preview) app displays under **Built for your org** in Teams.

:::image type="content" source="media/fsp-teams-app.png" alt-text="Teams screenshot highlighting Field Service (Preview) app":::

### Select an environment

You must select your environment before you install and set up Viva Connections.

1. Log into [Microsoft Teams](https://teams.microsoft.com) as an admin.

1. Select **Apps**.

1. Select **Add** on the Field Service (Preview) app, and then **Add**.

1. Select the **Settings** tab, and then select your environment.

   :::image type="content" source="media/fsp-environment.png" alt-text="Teams screenshot highlighting Environment selection":::

### Install and set up Viva Connections

Viva Connections is included as part of Microsoft Teams license. If you do not have Viva Connections set up for your organization, install and set it up.

1. Log in to the [Microsoft Teams Admin Center](https://admin.teams.microsoft.com/).

1. [Add the Viva Connections app](/viva/connections/set-up-admin-center).

1. Log into [Microsoft Teams](https://teams.microsoft.com) as an admin.

1. Under **Apps**, search for and select the Viva Connections app. Then select **Add**.

1. Open the Viva Connections app in Teams.

1. On the dashboard, select **Edit**. Set up the dashboard for **Frontline workers** and **Information workers**.

1. Customize each dashboard with apps based on your organization’s needs.

### Deploy Viva Connections cards for Field Service (Preview)

Obtain the Viva Connections cards for Field Service (Preview) to make them available to your organization.

1. Log into the [SharePoint Admin Center](https://go.microsoft.com/fwlink/?linkid=2185219).

   :::image type="content" source="media/sharepoint-admin-center.png" alt-text="SharePoint screenshot highlighting More features and Open under Apps":::

1. [Add Dynamics 365 Field Service for Viva Connections - Preview from the SharePoint store](/sharepoint/use-app-catalog#add-apps-from-the-sharepoint-store).

1. Go to the **API access** page and click **Approve**. For more information, see [Manage API access](/sharepoint/api-access#approve-a-pending-request).

### Add Field Service (Preview) cards to the Viva Connections dashboard

You can set up the Field Service (Preview) cards to the Viva Connections dashboard through SharePoint or Viva Connections. There are four cards available for the Field Service (Preview) for Teams. For frontline managers, we recommend the **Work orders all in one place** and **Remote Assist** cards. For frontline workers we recommend the **Upcoming work order**, **Work orders assigned**, and **Remote Assist** cards.

If your organization has a SharePoint home site and wants to use it for Viva Connections or you already have Viva Connections with a home site, see [edit the dashboard and add cards using Viva Connections](/viva/connections/create-dashboard#how-to-edit-the-dashboard-from-sharepoint-when-you-have-a-home-site).

If your organization doesn't have a SharePoint home site and doesn't want one, see [Set up Viva Connections without a home site](/viva/connections/viva-connections-setup-guide#set-up-viva-connections-without-a-home-site).

To set up a home site, see the following steps:

1. In the [SharePoint Admin Center](https://go.microsoft.com/fwlink/?linkid=2185219), select **Sites** > **Active Sites**.

1. Find and select the Viva Connections site name you created when you set up Viva Connections. If you didn’t customize the name, look for a Communications Site called Viva Home.

1. Select **Settings** and then **Manage Viva Connections**.

   :::image type="content" source="media/fsp-sharepoint-vc-dashboard.png" alt-text="SharePoint screenshot of created Viva Connections dashboard":::

   > [!TIP]
   > An alternative is select the **Pages** tab and select **Dashboard.aspx**.

1. In the **Manage Viva Connections** pane, select **View Dashboard**.

   :::image type="content" source="media/fsp-sharepoint-manage-vc.png" alt-text="SharePoint screenshot of Manage Viva Connections pane":::

1. Select **Edit** and scroll to add a new card.

1. Select **Add a card**. Select and add each of the four Field Service (Preview) cards.

1. [Set the target audience](/viva/connections/use-audience-targeting-in-viva-connections) for each card.

1. Preview the experience and then select **Publish** or **Republish**.

### Assign security roles and field security profiles

Assign Azure Active Directory (AAD) permissions for your frontline managers and frontline workers in Field Service or Power Platform Admin Center. For the frontline manager, we recommend the default **Field Service - Dispatcher** or the **Field Service - Administrator** role. For the frontline worker, we recommend the default **Field Service - Resource** role.

For Field Service, see the following steps. For Power Platform Admin Center, see [Assign security roles and field security profiles](../view-user-accounts-security-roles.md#step-2-assign-security-roles-and-field-security-profiles). For more information about users and security roles, see [Set up users and security profiles](../view-user-accounts-security-roles.md).

1. Go to Field Service **Get Started** page and [set up your frontline workers](../frontline-worker-set-up.md#get-started).

1. Assign a **Security Role** and **Field Security** role. The other fields are optional.

### Sync Azure Active Directory groups and Dataverse security roles

Synchronize your AAD groups to the Dataverse security roles. Although this step is optional, we recommend you assign AAD permissions to ensure that adding and removing users is reflected in both Azure Active Directory and Power Platform. To automate the process using the Web API, see [Assign a security role to an AAD group team](/power-apps/developer/data-platform/aad-group-team#assign-a-security-role-to-an-aad-group-team).

1. Log into the [Microsoft 365 Admin Center](https://admin.microsoft.com/).

1. [Create a security group and add members to the security group](/power-platform/admin/control-user-access#create-a-security-group-and-add-members-to-the-security-group).

1. Associate a group with a security role using Field Service or the Power Platform Admin Center. For more information, see [Assign security roles and field security profiles](#assign-security-roles-and-field-security-profiles).

### Set up column level security (optional)

If some of the permissions of a user are inadequate to view or create work orders, you can grant the user an elevated security role or change the column-level security of the user’s security role. For more information, see [Set up users and security profiles](../view-user-accounts-security-roles.md) and [Security roles and privileges](/power-platform/admin/security-roles-privileges).

1. Depending on your environment go to Power Apps.

   - For Prod, go to [make.powerapps.com](https://make.powerapps.com/)
   - For Test, go to [make.test.powerapps.com](https://make.test.powerapps.com).
   - For PreProd, go to [make.preprod.powerapps.com](https://make.preprod.powerapps.com).

1. Select your environment in the top bar.

1. In the left navigation pane, select **Solutions**.

1. Find and select the **Default Solution**.

   :::image type="content" source="media/fsp-powerapps-default-solution.png" alt-text="PowerApps screenshot showing Default Solution":::

1. Under **Object**, select **Column security profiles**.

   :::image type="content" source="media/fsp-powerapps-column-security-profiles.png" alt-text="PowerApps screenshot showing Column security profiles selection":::

1. Edit the desired column level profiles.

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
