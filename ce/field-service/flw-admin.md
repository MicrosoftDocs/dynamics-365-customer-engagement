---
title: Field Service (Preview) for Administrators
description: Learn about the Dynamics 365 Field Service (Preview) from an Administrator perspective.
ms.date: 07/31/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
---

# Field Service (Preview) for Administrators

[!INCLUDE[public-preview-banner](../includes/public-preview-banner.md)]

As an administrator for your organization, the set up tasks for the Field Service (Preview) depends on which capabilities your organization chooses to use. You can use one or the other or both.

## [Field Service (Preview) Outlook](#tab/outlook)

As an admin, you can quickly enable the Field Service (Preview) Outlook Add-in for your organization and the frontline employees are ready to go.

The Outlook add-in also includes copilot capabilities to create work orders in Outlook. Copilot adheres to [responsible AI guidelines](faqs-wo-flw-copilot.md). If you want to opt out of using Copilot, please fill out the following form: https://go.microsoft.com/fwlink/?linkid=2240475.

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

1. Select **+ (New)** > **Add from AppSource**.

1. Search for and select **Dynamics 365 Field Service for Outlook (Preview)**.

   :::image type="content" source="media/fsp-outlook-add-in.png" alt-text="Field Service (Preview) Outlook add-in card":::

1. Select **Get it now** and confirm your information.

1. On the **Add users** page, select **Entire organization** to enable the add-in for your organization.

   :::image type="content" source="media/fsp-outlook-add-users.png" alt-text="Field Service (Preview) Outlook Add users screenshot":::

1. Select **Next** and **Accept permissions**.

1. Select **Next** and **Finish deployment**. Then, select **Done**.

## [Field Service (Preview) Teams](#tab/teams)

The Field Service (Preview) Teams app requires the following setup:

- [Create user groups](#create-user-groups), if they are not already set up
- [Deploy Field Service (Preview) Teams app](#deploy-field-service-preview-teams-app)
- [Deploy Field Service (Preview) for Viva Connections](#deploy-field-service-preview-for-viva-connections)
- [Install and pin the apps in Teams](#install-and-pin-the-apps-in-teams)
- [Add Field Service (Preview) cards to the dashboard](#add-field-service-preview-cards-to-the-viva-connections-dashboard)
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

If you have not created user groups for your frontline workers and frontline managers, [create a group in the Microsoft 365 Admin Center](/microsoft-365/admin/create-groups/create-groups) or [create an Azure Active Directory group](/azure/active-directory/fundamentals/how-to-manage-groups).

### Deploy Field Service (Preview) Teams app

Make the Field Service (Preview) app available in Teams.

1. Log into [Microsoft Teams Admin Center](https://admin.teams.microsoft.com/).

1. Navigate to **Teams apps** > **Manage apps**.

1. From the Teams App Store, search for **Field Service (Preview)**

   :::image type="content" source="media/fsp-teams-app-admin.png" alt-text="Screenshot showing search for Field Service (Preview)":::

1. Select **Add**.

1. Select the **Permissions** tab and [grant permissions to use the app](/microsoftteams/app-permissions-admin-center#view-resource-specific-consent-permissions-of-an-app).

1. Select **Add** to add the application.

1. Log into [Microsoft Teams](https://teams.microsoft.com) as an admin.

1. Open **Field Service (Preview)**.

1. On the **Settings** tab, select your environment.

   :::image type="content" source="media/fsp-environment.png" alt-text="Field Service (Preview) Teams Settings tab.":::

   > [!NOTE]
   > You must select your environment and have it validated before deploying Field Service (Preview) for Viva Connections.

### Deploy Field Service (Preview) for Viva Connections

Viva Connections is included as part of Microsoft Teams license. If you do not have Viva Connections set up for your organization, [install and set it up](/viva/connections/set-up-admin-center) before continuing. Then, make Field Service (Preview) for Viva Connections available in Teams.

1. Log into [Microsoft AppSource](https://appsource.microsoft.com/).

1. Search for **Dynamics 365 Field Service for Viva Connections**.

   :::image type="content" source="media/fsp-viva-connections-appsource.png" alt-text="Dynamics 365 Field Service (Preview) for Viva Connections tile showing Get it now.":::

1. Select **Get it now** and confirm your information. Microsoft SharePoint is launched.

1. In SharePoint, select **Add to Apps site**.

   :::image type="content" source="media/fsp-viva-connections-add.png" alt-text="Dynamics 365 Field Service (Preview) for Viva Connections showing Add.":::

1. On **Confirm data access**, select **Enable this app and add it to all sites**, and then select **Add**.

   :::image type="content" source="media/fsp-viva-confirm-access.png" alt-text="Confirm data access dialog box to enable the app to all sites.":::

1. On the **Approve access** dialog box, select **Go to API access page**.

1. On the **API access** page, select the pending request for **Dynamics 365 Field Service for Viva Connections**, and then select **Approve**. Confirm your approval. For more information, see [Manage API access](/sharepoint/api-access#approve-a-pending-request).

### Install and pin the apps in Teams

1. Log into [Microsoft Teams Admin Center](https://admin.teams.microsoft.com/).

1. Select **Teams apps** > **Set up policies**.

1. Select **Global (Org-side default)**.

   > [!TIP]
   > This default policy applies to all users in your organization unless you assign another policy. If you don't want to the apps set up globally, [set up a new policy](/microsoftteams/teams-app-setup-policies) adding both **Field Service (Preview)** and **Viva Connections**.

1. [Install both apps](/microsoftteams/teams-app-setup-policies#install-apps).

1. [Pin both the apps and arrange them](/microsoftteams/teams-app-setup-policies#pin-apps).

### Add Field Service (Preview) cards to the Viva Connections dashboard

There are four cards available for the Field Service (Preview) for Teams. For frontline managers, we recommend the **Work orders all in one place** and **Remote Assist** cards. For frontline workers we recommend the **Upcoming work order**, **Work orders assigned**, and **Remote Assist** cards.

1. Log into [Microsoft Teams](https://teams.microsoft.com) as an admin.

1. Open the Viva Connections app in Teams.

   :::image type="content" source="media/fsp-viva-connections-dashboard.png" alt-text="Viva Connections dashboard":::

1. On the dashboard, select **Edit**. Set up the dashboard for **Frontline workers** or **Information workers**.

1. Select **Add a card**. Select and add each of the four Field Service (Preview) cards.

   :::image type="content" source="media/fsp-cards.png" alt-text="Set of cards to add":::

1. [Set the target audience](/viva/connections/use-audience-targeting-in-viva-connections) for each card.

   > [!NOTE]
   > If you don't set up the target audience for each card, the card will be available to all workers.

1. Preview the experience and then select **Publish** or **Republish**.

### Assign security roles and field security profiles

Assign Azure Active Directory (AAD) permissions for your frontline managers and frontline workers in Field Service or Power Platform Admin Center. For the frontline manager, we recommend the default **Field Service - Dispatcher** or the **Field Service - Administrator** role. For the frontline worker, we recommend the default **Field Service - Resource** role.

For Field Service, see the following steps. For Power Platform Admin Center, see [Assign security roles and field security profiles](view-user-accounts-security-roles.md#step-2-assign-security-roles-and-field-security-profiles). For more information about users and security roles, see [Set up users and security profiles](view-user-accounts-security-roles.md).

1. Go to Field Service **Get Started** page and [set up your frontline workers](frontline-worker-set-up.md#get-started).

1. Assign a **Security Role** and **Field Security** role. The other fields are optional.

### Sync Azure Active Directory groups and Dataverse security roles

Synchronize your AAD groups to the Dataverse security roles. Although this step is optional, we recommend you assign AAD permissions to ensure that adding and removing users is reflected in both Azure Active Directory and Power Platform. To automate the process using the Web API, see [Assign a security role to an AAD group team](/power-apps/developer/data-platform/aad-group-team#assign-a-security-role-to-an-aad-group-team).

1. Log into the [Microsoft 365 Admin Center](https://admin.microsoft.com/).

1. [Create a security group and add members to the security group](/power-platform/admin/control-user-access#create-a-security-group-and-add-members-to-the-security-group).

1. Associate a group with a security role using Field Service or the Power Platform Admin Center. For more information, see [Assign security roles and field security profiles](#assign-security-roles-and-field-security-profiles).

### Set up column level security (optional)

If some of the permissions of a user are inadequate to view or create work orders, you can grant the user an elevated security role or change the column-level security of the user’s security role. For more information, see [Set up users and security profiles](view-user-accounts-security-roles.md) and [Security roles and privileges](/power-platform/admin/security-roles-privileges).

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

---

[!INCLUDE[footer-include](../includes/footer-banner.md)]
