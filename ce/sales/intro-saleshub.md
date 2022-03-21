---
title: "Use the Sales Hub app to access Dynamics 365 Sales features | MicrosoftDocs"
description: "The Sales Hub app is preinstalled and preconfigured with several core sales and sales insights features to help you get started quickly"
ms.date: 02/01/2022
ms.topic: article

author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Use the Sales Hub app to access Dynamics 365 Sales features

Can't wait to explore Dynamics 365 quickly? Use the free Sales Hub app, which is preinstalled and preconfigured with several core sales and sales insights features to help you get started quickly.

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Salesperson and above <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## What's in the Sales Hub app? 

The Sales Hub app has a modern and interactive interface, designed to simplify your day-to-day sales activities. It shows you all the vital information in one place, and lets you focus on the key activities that require your attention.

Sales Hub is based on the Unified Interface framework. Some of the key highlights include:

-   A modern, seamless, and intuitive user interface.

-   An adaptive UI that renders content according to the device it runs on.

-   A built-in mobile app that lets you complete tasks on the go.

-   An app that's built with accessibility in mind.

## Why should you use the Sales Hub app?

Sales Hub is a Microsoft first-party app that's designed and configured for ideal seller experiences. When you use the Sales Hub app:

-   You get access to the preview features with minimal configuration.

-   You get access to the premium features, for a specific period, when they're made available.

-   You get access to standard sales and sales insights features almost instantly.

-   You can customize the app and configure the features as required.

-   You need not create custom documentation because the Microsoft documentation is based on the Sales Hub app.

> [!NOTE]
> The Sales Hub app can coexist with any custom sales apps that you might have in your organization. To learn the benefits of using the Sales Hub app versus a custom app, see [Guidance on Sales Hub and custom model driven apps](https://community.dynamics.com/365/dynamics-365-fasttrack/b/dynamics-365-fasttrack-blog/posts/guidance-on-sales-hub-and-custom-model-driven-apps).

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

## Access the Sales Hub app

Access your Dynamics 365 Sales environment, and select Sales Hub from the **Published Apps** page.

![Screenshot of the Sales Hub app card on the **Published apps** page](media/saleshubcard.png)

> [!NOTE]
> If you don't see the app, contact your administrator to grant you access. More information: [Grant access to the Sales Hub app](#grant-or-revoke-access-to-the-sales-hub-app).

For instructions on using the Sales Hub app on mobile devices, go to [Sign in and sign out from the app](sales-mobile/use-sales-mobile-app.md#sign-in-and-sign-out-from-the-app).
