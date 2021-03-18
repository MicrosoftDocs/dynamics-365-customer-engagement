---
title: "Add or manage users in Dynamics 365 Sales Professional | MicrosoftDocs"
description: "Create a user account for every person in the organization, and assign roles so they can access the Dynamics 365 Sales Professional app."
ms.date: 05/17/2020
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: annbe
---

# Add or manage users in Dynamics 365 Sales Professional

> [!IMPORTANT]
> This capability is introduced in the Dynamics 365 Sales Professional app version 9.1.0.0.

To sign in to Dynamics 365 Sales Professional, every user in your organization must have a user account. Create a user account for each user to give them access to the Sales app.

When you create a user in the Sales app, you can define a user ID, generate a password, and assign a license and security role in a single step.

After you provide these details and select **Add**, a user is automatically created in Azure Active Directory, and the user account is available in Microsoft 365 and the Sales app.

## Create a user account

1.  Make sure you have the global administrator role in Microsoft 365 and the System Administrator role in Dynamics 365 Sales Professional.

2.  In the site map, select **Sales Settings**.

3.  Under **Standard Settings** > **Manage Users**.

    > [!div class="mx-imgBorder"]
    > ![Manage Users in Standard settings](media/manage-users-standard-settings.png "Manage users in Standard settings")

4.  Select **Add a new user**.

5.  Follow the instructions in the **Confirm user account creation** dialog box.

    The **Add New User** pane appears.

    > [!div class="mx-imgBorder"]
    > ![Add New User dialog box](media/add-new-user-dialog.box.png "Add New User dialog box")

6.  Enter the following details:

    -   **First Name**

    -   **Last Name**

    -   **Display Name** (required). This is automatically populated based on the first name and last name, and can be changed.

    -   **Username** (required). This must be a unique name. A domain name, which is usually the organization name, is appended to the username. For example: xyz\@contoso.com

    -   **User email address**

7.  In the **Role** drop-down list, select a role that you want to assign to the user. You must assign at least one role to the user at this time. To assign multiple roles, see "Assign a security role to the user."

    >[!IMPORTANT] 
    >Assign a role with only the privileges the user needs.

8.  Under **Password**, select the **User must create a new password when signing in for the first time** check box if you want the user to enter a new
    password when they sign in.

9.  Select **Contact information** to provide more details about the user.

10.  Select **Add**.

>[!NOTE] 
>If there’s a single license type for your organization, a license is automatically assigned to users. If there are no licenses left, a user will be created but no license will be assigned. The user will not be able to use Dynamics 365 Sales Professional until a license is assigned.

## Assign a security role to a user

Security roles control a user’s access to data through a set of access levels and privileges. The combination of access levels and privileges that are included in a specific security role sets limits on the user’s view of data and on the actions that the user can perform with that data.

Dynamics 365 Sales Professional provides a default set of security roles:

-  Sales Professional

-  Sales Professional Manager

-  System Administrator

-  System Customizer

-  Sales Professional app access (available in Sales Professional version number 9.1.2101.1501 and later) 

You can assign more than one security role to a user. The effect of multiple security roles is cumulative, which means that the user has the permissions associated with all security roles assigned to that user.

> [!IMPORTANT] 
> To allow users access to Dynamics 365 Sales Professional, you must assign the 'Sales Professional app access' security role (if Sales Professional version is 9.1.2101.1501 or later) and at least one more security role to the users. 

To assign a role in Dynamics 365 Sales Professional:

1.  Under **Standard Settings**, select **Manage users**.

2.  Select a user you want to assign a role to, and then on the command bar, select **Manage Roles.**

3.  In the **Manage User Roles** dialog box, select the security role or roles you want for the user or users, and then select **OK**.

    > [!div class="mx-imgBorder"]
    > ![Manage User Roles dialog box](media/manage-use-roles-dialog-box.png "Manage User Roles dialog box")

## Join teams

Teams are a collection of users. Teams let users across an organization
collaborate and share information. To add users to a team:

1.  Select the users you want to add to the team, and then on the command bar, select **Join Teams**.

2.  In the **Join Team** dialog box, select the teams you want to add the users
    to, and then select **OK**.

## Change the manager

Assign a manager or change an existing manager. The manager is responsible for administering the work of a group of users.

1.  Select the users you want to change, and then on the command bar, select **Change Manager**.

2.  In the **Change Manager** dialog box, select the **Lookup** button to choose a manager, and then select **OK**.

### See also

[Admin settings overview](admin-settings-overview.md)  
[Add or manage teams](manage-teams.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]