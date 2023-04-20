---
title: Grant or revoke access to the Sales Hub app
description: Grant or revoke access to Sales Hub to a security role or to specific users.
ms.date: 04/26/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---
# Grant or revoke access to the Sales Hub app

As an administrator, you decide which users or security roles should have access to the Sales Hub app. The app will honor the access permissions defined in the user's security role. For example, if the security role allows access to only opportunities and quotes, the app will display only those entities for the user.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

If your organization has [opted in to early access updates](/power-platform/admin/opt-in-early-access-updates), Sales Hub is turned on by default for the following roles:

- System Administrator

- System Customizer

- Sales, Enterprise app access

- Salesperson

- Sales Manager

- Vice President of Sales

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

To hide the app from all users and roles, follow the instructions in [Hide a model-driven app from users](/powerapps/maker/model-driven-apps/deactivate-app).

## Grant or revoke access

As an administrator, you can either grant or revoke access to a security role or to specific users.

1. On the **Published Apps** page, locate the **Sales Hub** card. Select **...** (**More options**), and then select **Manage Roles**.

    :::image type="content" source="media/saleshub-manageroles.png" alt-text="Screenshot showing the Manage Roles pane, with roles that already have access highlighted in blue.":::

    The security roles that already have access are highlighted in blue.

1. Take one of the following actions:

    - To grant or revoke access to all the users of a security role, select the security role.

    - To grant access to specific users, assign the **Sales, Enterprise app access** role to them.

    - To revoke access for specific users, remove the role from them.

For more information on adding and removing users from a security role, see [Assign security roles to users](security-roles-for-sales.md#assign-security-roles-to-users).

Users to whom you've granted access see the Sales Hub app on their **Published Apps** page. Users for whom you've revoked access don't see the app on that page.

### See also

- [Why should you use the Sales Hub app?](intro-saleshub.md#why-should-you-use-the-sales-hub-app)
- [Access the Sales Hub app](intro-saleshub.md#access-the-sales-hub-app)
