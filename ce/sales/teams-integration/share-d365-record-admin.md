---
title: Enable sales teams to share and act on Dynamics 365 records within Microsoft Teams conversations
description: Learn about enabling sales teams to share and act on Dynamics 365 records within Microsoft Teams conversations.
ms.date: 05/09/2023
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
---

# Enable sales teams to work with Dynamics 365 records within Teams conversations (production-ready preview)

> [!IMPORTANT]
> - This topic is prerelease documentation and is subject to change.
> - Preview features designated as production-ready employ privacy and security measures typically present in generally available features, as further explained in our [preview terms](https://go.microsoft.com/fwlink/?linkid=2105274).

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | <ul><li>Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, Dynamics 365 Sales Professional, or any Dynamics 365 customer engagement app license</li> <li>Microsoft Teams license</li></ul>  <br>More information: <ul><li>[Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/)</li><li>[Microsoft Teams pricing](https://www.microsoft.com/microsoft-teams/compare-microsoft-teams-options?activetab=pivot:primaryr2&rtc=1)</li><li>[Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)</li></ul> |
| **Security roles** | System Administrator<br>  More information: [Predefined security roles for Sales](../security-roles-for-sales.md)|

## Overview

The Dynamics 365 app for Microsoft Teams allows sellers to share and update Dynamics 365 records, as an interactive card, within Teams conversations. 

While business users can access the feature themselves by adding, signing in, and setting up the Dynamics 365 app for Teams, you can drive faster and more seamless adoption by:

- Familiarizing yourself with the feature.
- Understanding how the information is displayed in the interactive card.
- Preinstalling and pinning the app for business users who can benefit from the feature.
- Encouraging business users to sign in and set up the app.

## Dynamics 365 app for Teams auto-install

In order to enhance the Teams experience for Dynamics 365 users, the Dynamics 365 app for Teams will be automatically installed to all the active Dynamics 365 users.

> [!NOTE]
> A user is considered as active after they successfully sign in to one of the Dynamics 365 applications or a model-driven Power Apps app. 

With the Dynamics 365 app for Teams, users will have their collaboration in Teams enhanced with: 

- Dynamics 365 links will automatically unfurl, showing useful record details.
- Users will be able to view Dynamics 365 data in Teams, while continuing their chats.
- Users can search, connect, and update Dynamics 365 records directly in Teams.

The Dynamics 365 app for Teams will be installed automatically in all environments that have not disabled the installation of the Dynamics 365 app. For infomation to disable auto-install of Dynamics 365 app for Teams, see [Disable auto-install of Dynamics 365 app for Teams](#disable-auto-install-of-dynamics-365-app-for-teams).

## Familiarize yourself with the feature

It's important to become familiar with the feature to understand the nuances of how it works and identify the business users for whom preinstalling and pinning the app will add value. 

**To familiarize yourself with the feature**:

1. [Add the Dynamics 365 app for Teams](access-d365-app.md#add-the-dynamics-365-app)

2. [Access and sign in to the Dynamics 365 app for Teams](access-d365-app.md#access-the-dynamics-365-app)

3. [Set up the Dynamics 365 app for Teams](access-d365-app.md#set-up-the-dynamics-365-app) 

4. [Share a record in a Teams chat and channel by pasting its URL](share-dynamics-records-in-teams.md#share-a-record-through-url)

5. [Share a Dynamics 365 record through search](share-dynamics-records-in-teams.md#share-a-dynamics-365-record-through-search)

6. [View and update record details](view-update-dynamics-records.md)

7. [Add chat messages to Dynamics 365 as notes or tasks](add-chat-d365.md)


## How is the information displayed in the interactive card?

The information in the interactive card is displayed using the view of type **Quick Find View** of a table. You must validate and edit the columns in the **Quick Find View** view to ensure that interactive cards display the right information. To change the information that the cards display, you can [edit the columns](/power-apps/maker/model-driven-apps/choose-and-configure-columns) in the [**Quick Find View**](/power-apps/maker/model-driven-apps/create-edit-views#system-views) view of a table as per the requirement.

## Preinstall and pin the Dynamics 365 app in Microsoft Teams

Preinstalling and pinning the Dynamics 365 app in Teams increases the discoverability of the app by business users and encourages them to share records in a secure way. It requires creating a custom Teams app policy and assigning the policy to users.

> [!NOTE]
> - The ability [to preinstall and pin apps for users by managing app policies](/microsoftteams/teams-app-setup-policies) is available as part of Microsoft Teams and is not a feature of Microsoft Dynamics 365. This document details how to use the Microsoft Teams feature to preinstall the Dynamics 365 app for Teams.
> - You need to be a Teams administrator to preinstall and pin the Dynamics 365 app for Teams for business users. For more information on Teams administrator roles, refer to [Use Microsoft Teams administrator roles to manage Teams](/microsoftteams/using-admin-roles).

### Create a custom Teams app setup policy

1.  Sign in to [Microsoft Teams admin center](https://admin.teams.microsoft.com/).

2.  In the left pane, go to **Teams apps** &gt; **Setup policies**.

3.  Under the **Manage policies** tab, select **Add**.

    ![Add a setup policy](media/teams-admin-setup-policy.png "Add a setup policy")

4.  Enter a name and description for the policy.

5.  Turn on **User pinning**.

6.  Under **Installed apps**, select **Add apps**.

    ![Add apps](media/teams-admin-add-app.png "Add apps")

7.  In the **Add installed apps** panel, search for the **Dynamics 365** app, and then select **Add**. You can also filter apps by app permission policy.

    ![Add the Dynamics 365 app](media/teams-admin-add-d365-app.png "Add the Dynamics 365 app")

8. Select **Add**.

9.  Under **Pinned apps**, select **Add apps**.

    ![Pin an app](media/teams-admin-pin-app.png "Pin an app")

10.  In the **Add pinned apps** panel, search for the **Dynamics 365** app, and then select **Add**. You can also filter apps by app permission policy.

        ![Pin the Dynamics 365 app](media/teams-admin-pin-d365-app.png "Pin the Dynamics 365 app")

11. Select **Add**.

12. Under the **App bar** or **Messaging extensions**, arrange the apps in the order that you want them to appear in Teams.

    ![Arrange pinned apps](media/teams-admin-add-arrange-app.png "Arrange pinned apps")

13. Select **Save**.

### Assign the custom Teams app setup policy to a user group

Policy assignment to groups lets you assign a policy to a group of users, such as a security group, an organizational unit, or a distribution list.

1.  Sign in to [Microsoft Teams admin center](https://admin.teams.microsoft.com/).

2.  In the left pane, go to **Teams apps** &gt; **Setup policies**.

3.  Under the **Group policy assignment** tab, select **Add**.

    ![Group policy](media/teams-admin-group-policy.png "Group policy")

4.  In the **Assign policy to group** panel, do the following:

    1.  Search for and add the group you want to assign the policy to. Ideally this would be the group to which sellers, service agents, and other Dynamics 365 users belong to. If you have Dynamics 365 users spread across multiple groups, you'll have to create multiple group policy assignments.

    2.  Set the ranking for the group assignment.

    3.  Select the policy created earlier – to preinstall and pin the Dynamics 365 app for Teams.

    4.  Select **Apply**.

    ![Assign a group policy](media/teams-admin-group-policy-assign.png "Assign a group policy")

> [!NOTE]
> - To learn more about assignment policies on Teams, go to [Assign policies to users and groups](/microsoftteams/assign-policies-users-and-groups#assign-a-policy-to-individual-users).
> - You can also [assign the policy to individual users](/microsoftteams/assign-policies-users-and-groups#assign-a-policy-to-individual-users).


## Encourage business users to sign in and set up the app

After you create a custom policy and assign it to users, you must encourage your users to sign in to the Dynamics 365 app for Teams to view, share, and update Dynamics 365 records in Microsoft Teams chats and channels. They need to sign in only once. and signing in provides a seamless user experience. When users have the app installed but haven't signed in, they'll see this message displayed in the interactive card when they access the Dynamics 365 record in Teams:

:::image type="content" source="media/sign-in-msg.png" alt-text="Sign in to Dynamics 365 app":::

For information on how to sign in to the Dynamics 365 app, see [Sign in and set up the Dynamics 365 app for Teams](access-d365-app.md#set-up-the-dynamics-365-app).

## Disable auto-install of Dynamics 365 app for Teams

The installation of the Dynamics 365 app can be disabled from Power Platform admin center or Microsoft Teams admin center.

### Power Platform admin center

Power Platform admin center allows you to  disable the auto-installation of the Dynamics 365 app in Teams. This will prevent the app from being installed for all users in your organization. However, users can still install the app from the Teams app store.

1. Go to **Environments** > **Settings** > **Product** > **Collaboration**.

2. Under **Teams Integration**, turn off the **Install the Dynamics 365 app for Teams for users in the organization. Lets people in your org see business data while working in Teams** toggle.

3. Select **Save**.

    :::image type="content" source="media/auto-install-d365-ppac.png" alt-text="Disbale auto-install from Power Platform admin center":::

### Microsoft Teams admin center

Microsoft Teams admin center allows you to disable the auto-installation of the Dynamics 365 app in Teams and prevent users from manually installing it from the Teams app store.

1. In the left navigation pane, go to **Teams apps** > **Manage apps**.

2. Search for the Dynamics 365 app, and select it.

3. Turn off the **Status** toggle.

    :::image type="content" source="media/auto-install-d365-teams-admin.png" alt-text="Disbale auto-install from Teams admin center":::

### See also

[Share and update Dynamics 365 records within Microsoft Teams conversations](share-d365-record-overview.md)   
