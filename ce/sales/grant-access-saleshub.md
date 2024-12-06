---
title: Grant or revoke access to the Sales Hub app
description: Grant or revoke access to Sales Hub to a security role or to specific users so that sellers can access the app and use its features.
ms.date: 06/25/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---
# Grant or revoke access to the Sales Hub app

As an administrator, you decide which users or security roles should have access to the Sales Hub app. The app will honor the access permissions defined in the user's security role. For example, if the security role allows access to only opportunities and quotes, the app will display only those entities for the user.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

Sales Hub is turned on by default for the following roles:

- System Administrator

- System Customizer

- Sales, Enterprise app access

- Salesperson

- Sales Manager

- Vice President of Sales

To hide the app from all users and roles, follow the instructions in [Hide a model-driven app from users](/powerapps/maker/model-driven-apps/deactivate-app).

## Grant or revoke access

As an administrator, you can either grant or revoke access to a security role or to specific users.

1. On the Dynamics 365 apps page, locate the **Sales Hub** card under **Published apps** section. Select **...** (**More options**), and then select **Manage Roles**.

    :::image type="content" source="media/saleshub-manageroles.png" alt-text="Screenshot showing the Manage Roles pane, with roles that already have access highlighted in blue.":::

    The security roles that already have access are highlighted in blue.

1. Take one of the following actions:

    - To grant or revoke access to all the users of a security role, select the security role.

    - To grant access to specific users, assign the **Sales, Enterprise app access** role to them.

    - To revoke access for specific users, remove the role from them.

For more information on adding and removing users from a security role, see [Assign a security role to a user](/power-platform/admin/assign-security-roles).

Users to whom you've granted access see the Sales Hub app on their **Published Apps** page. Users for whom you've revoked access don't see the app on that page.

## Related information

- [Why should you use the Sales Hub app?](intro-saleshub.md#why-should-you-use-the-sales-hub-app)
- [Access the Sales Hub app](intro-saleshub.md#access-the-sales-hub-app)
