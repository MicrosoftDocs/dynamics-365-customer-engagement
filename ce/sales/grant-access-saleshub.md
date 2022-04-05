---
title: "Use the Sales Hub app to access Dynamics 365 Sales features | MicrosoftDocs"
description: "The Sales Hub app is preinstalled and preconfigured with several core sales and sales insights features to help you get started quickly"
ms.date: 03/31/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
## Grant or revoke access to the Sales Hub app

As an administrator, you can decide which users or security roles should have access to the Sales Hub app. The app will honor the access permissions defined in the security role of the user. For example, if the security role allows access to only opportunities and quotes, the app will display only those entities for the user.

If your organization has opted in for early access as described in the [Opt in to early access updates](/power-platform/admin/opt-in-early-access-updates) page, the Sales Hub app is enabled by default for the following roles:

-   System Administrator

-   System Customizer

-   Sales, Enterprise app access

-   Salesperson

-   Sales Manager

-   Vice President of Sales

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

As an administrator, you can either grant or revoke access to a security role or to specific users. If you want to hide the app from all the users and roles, follow the instructions in [Hide a model-driven app from users](/powerapps/maker/model-driven-apps/deactivate-app).   

**To grant or revoke access:**

1.  On the **Published Apps** page, select the **More Options (...)** icon in the **Sales Hub** card, and then select **Manage Roles**.

    ![Screenshot depicting the navigation to Manage Roles](media/saleshub-manageroles.png)

    The security roles that already have the access are highlighted in blue, as shown in the preceding screenshot.

2. On the **Manage Roles – Sales Hub** pane, do the following:
 
    
    - To grant or revoke access to all the users of a security role, select the security role.
    
    - To grant access to specific users, assign the **Sales, Enterprise app access** role to the users. To revoke access, remove the role for the user. For more information on adding or removing users from a security role, see [Assign security roles to users](security-roles-for-sales.md#assign-security-roles-to-users).

If you've granted access, the users will see the Sales Hub app in their published apps page. If you've revoked access, the app will be removed from published apps page of the users.
