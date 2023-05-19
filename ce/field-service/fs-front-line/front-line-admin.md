---
title: Field Service (Preview) for Administrators
description: Learn about the Dynamics 365 Field Service (Preview) from an Administer perspective.
ms.date: 05/19/2023
ms.topic: how-to
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
---

# Field Service (Preview) for Administrators

As an administrator for your organization, set up tasks for the Field Service (Preview) depends on which capabilities your organization chooses to use. You can use one or the other or both.

- Set up the Field Service (Preview) Outlook Add-in
- Set up the Field Service (Preview) Teams app

## Set up the Field Service (Preview) Outlook Add-in

The Field Service (Preview) Outlook Add-in requires the add-in to be enabled. You can quickly enable the Outlook Add-in for your organization and the frontline employees are ready to go.

### Enable the Field Service (Preview) Outlook Add-in

To use the Field Service (Preview) Outlook capability, enable it as an Outlook Add-in. For more information, see [Install or remove add-ins for Outlook for your Exchange 2013 organization](/exchange/install-or-remove-outlook-add-ins-2013-help).

1. Log into the [Microsoft 365 Admin Center](https://admin.microsoft.com/) as a global admin or Exchange admin.

1. In the left pane under the **Admin centers** section, select **Exchange**.

1. Under the **Organization** section, select Add-ins.

1. Select **Add from URL** and select your manifest file for the Outlook Add-in.

1. Select **Install**.

   If you choose not to enable the Outlook Add-in for your organization, each user can enable it.

## Set up Field Service (Preview) Teams app

The Field Service (Preview) Teams app requires the following setup:

- Install and set up Viva Connections, if it’s not already installed
- Create user groups, if they are not already set up
- Deploy Viva Connections Cards for Field Service (Preview)
- Add Field Service (Preview) cards to the dashboard
- Deploy Teams Tab app package
- Assign audiences
- Sync Azure Active Directory groups and Dataverse security roles

### Install and set up Viva Connections

Viva Connections is included as part of Microsoft Teams license. If you do not have Viva Connections set up for your organization, install and set it up.

1. Log into the [Microsoft Teams Admin Center](https://admin.teams.microsoft.com/).

1. [Add the Viva Connections app](/viva/connections/add-viva-connections-app), customize it, and make it available to your organization.

1. Log into Teams as an admin and select **Add** for **Viva Connections**.

1. Set up the dashboard. Choose between **Frontline workers** and **Information workers**.

1. Customize the dashboard with apps based on your organization’s needs.

### Create user groups

If you have not created user groups for your frontline workers and frontline managers, [create a group in the Microsoft 365 Admin Center](/microsoft-365/admin/create-groups/create-groups?view=o365-worldwide) or [create an Azure Active Directory group](/azure/active-directory/fundamentals/how-to-manage-groups).

### Deploy Viva Connections cards for Field Service (Preview)

Obtain the Viva Connections cards for Field Service (Preview) to make them available to your organization.

1. Log into the [SharePoint Admin Center](https://go.microsoft.com/fwlink/?linkid=2185219).

1. [Add apps from the SharePoint store](/sharepoint/use-app-catalog#add-apps-from-the-sharepoint-store).

### Add Field Service (Preview) cards to the Viva Connections dashboard

You can set up the Field Service (Preview) cards to the Viva Connections Dashboard through SharePoint or Viva Connections. There are four cards available for the Field Service (Preview) for Teams. Determine the audience for each type of card. For frontline managers, we recommend the **Work orders all in one place** and **Remote Assist** cards. For frontline workers we recommend the **Upcoming work order**, **Work orders assigned**, and **Remote Assist** cards.

If you organization has a SharePoint home site and wants to use it for Viva Connections or you already have Viva Connections with a home site, see [edit the dashboard and add cards using Viva Connections](/viva/connections/create-dashboard#how-to-edit-the-dashboard-from-sharepoint-when-you-have-a-home-site).

For SharePoint, see the following steps.

1. In the [SharePoint Admin Center](https://go.microsoft.com/fwlink/?linkid=2185219), select **Sites** > **Active Sites**.

1. Find and select the Viva Connection dashboard you created when you set up Viva Connections.

1. Select **Settings** and then **Manage Viva Connections**.

1. In the **Manage Viva Connections** pane, select **View Dashboard**.

1. Select **Edit** and scroll to add a new card.

1. Select **Add card**. Add all four of the Field Service (Preview) cards.

1. Select the audience for each of the cards. Select the card to add it. For more information about audience targeting, see [Use audience targeting](/viva/connections/use-audience-targeting-in-viva-connections).

1. Preview the experience and then select **Publish** or **Republish**.

### Deploy Teams Tab app package

Make the Field Service (Preview) app available in Teams.

1. Log into the [Microsoft Teams Admin Center](https://admin.teams.microsoft.com/).

1. [Auto install the Field Service (Preview) Teams app](/microsoftteams/auto-install-approved-apps).

1. After the app is added, select the link to manage it.

1. [Grant permissions to use the app](/microsoftteams/app-permissions-admin-center#view-resource-specific-consent-permissions-of-an-app).

The Field Service (Preview) app displays under **Built for your org** in Teams.

### Assign security roles and field security profiles

Assign Azure Active Directory (AAD) permissions for your frontline managers and frontline workers in Field Service or Power Platform Admin Center. Although this step is optional, we recommend you assign AAD permissions to ensure that adding and removing users is reflected in both Azure Active Directory and Power Platform. For Field Service, see the following steps. For Power Platform Admin Center, see [Assign security roles and field security profiles](../view-user-accounts-security-roles.md#step-2-assign-security-roles-and-field-security-profiles). For more information about users and security roles, see [Set up users and security profiles](../view-user-accounts-security-roles.md).

1. Go to Field Service **Get Started** page and [set up your frontline workers](../frontline-worker-set-up.md#get-started).
1. Assign a **Security Role** and **Field Security** role. The other fields are optional.

### Sync Azure Active Directory groups and Dataverse security roles

Synchronize your AAD groups to the Dataverse security roles. To automate the process using the Web API, see [Assign a security role to an AAD group team](/power-apps/developer/data-platform/aad-group-team#assign-a-security-role-to-an-aad-group-team).

1. Log into the [Microsoft 365 Admin Center](https://admin.microsoft.com/).

1. [Create a security group and add members to the security group](/power-platform/admin/control-user-access#create-a-security-group-and-add-members-to-the-security-group).

1. Associate a group with a security role using Field Service or the Power Platform Admin Center. For more information, see [Assign security roles and field security profiles](#assign-security-roles-and-field-security-profiles).

### Set up column level security (optional)

If some of the permissions of a user are inadequate to view or create work orders, you can grant the user an elevated security role or change the column-level security of the user’s security role. For more information, see [Set up users and security profiles](../view-user-accounts-security-roles.md) and [Security roles and privileges](/power-platform/admin/security-roles-privileges).

1. Depending on your environment go to Power Apps.

   - For Prod, go to [make.powerapps.com](https://make.powerapps.com/)
   - For Test, go to [make.test.powerapps.com](make.test.powerapps.com).
   - For PreProd, go to [make.preprod.powerapps.com](make.preprod.powerapps.com).

1. Select your environment in the top bar.

1. In the left navigation pane, select **Solutions**.

1. Find and select the **Default Solution**.

1. Select Column security profiles.

1. Edit the desired column level profiles.


