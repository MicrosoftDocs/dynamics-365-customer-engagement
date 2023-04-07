---
title: "Create or manage teams in Dynamics 365 Sales | MicrosoftDocs"
description: "Create a team with a group of users so they can share and collaborate on business records in Dynamics 365 Sales."
ms.date: 11/18/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - "dyn365-sales"
---

# Create or manage teams

A team is a group of users who share and collaborate on business records. A user can be associated with multiple teams.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Create a team

Depending on the Dynamics 365 Sales license you have, select one of the following tabs for specific information:

# [Sales Premium or Sales Enterprise](#tab/sales)

1. From the Sales Hub app, select the **Settings** icon ![Settings icon.](media/settings-icon.png "Settings icon"), and then **Advanced settings**. 

2. Follow the instructions in [Microsoft Dataverse teams management](/power-platform/admin/manage-teams) to create and manage teams.

# [Sales Professional](#tab/salespro)

**To create a team**:

1.  In the site map, select **Sales settings**.

2.  Under **Advanced settings**, select **Team management**.

3.  Select **Create a team**.

4.  In the **Add New Team** pane, enter the following details, and then select **Add**.

    -   **Team Name**: Name of the team.

    -   **Business Unit Name**: This defaults to your organization name.

    -   **Team Description**: Enter a description of what the team has been created for.

    -   **Select Team Administrator**: Select the person who will do the team administration, such as adding members to or removing members from the team.

      > [!div class="mx-imgBorder"]
      > ![Add New Team pane.](media/add-new-team-dialog-box.png "Add New Team pane")

### Add members to the team

1. On the **Team management** page, select the team you want to add members to.

2. In the **Team members** section, select **Add Existing User**.

3. In the **Lookup Records** panel, search for and select the required members, and then select **Add**.

### Remove members from the team

1. On the **Team Management** page, select the team you want to remove the members from

2. In the **Team members** section, select the members you want to remove, and then select **Remove**.

### Manage security roles

When a team is assigned a role, the team members are assigned the set of privileges associated with that role.

1.  Select the **Settings** icon ![Settings icon.](media/settings-icon.png "Settings icon"), and then select **Advanced settings**.

2. Select **Settings** > **Security** > **Teams**.

3.  Select a team you want to assign a role to, and then on the command bar, select **Manage Roles**.

4.  In the **Manage Team Roles** dialog box, select the security role you want for the team, and then select **OK**.

---

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]


### See also

[Admin settings overview](admin-settings-overview.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
