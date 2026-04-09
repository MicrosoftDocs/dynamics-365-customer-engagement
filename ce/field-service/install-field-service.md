---
title: Install Dynamics 365 Field Service
description: Learn how to install Dynamics 365 Field Service on a Power Platform environment.
ms.topic: how-to
ms.date: 03/30/2026
ms.author: jacoh
author: jasonccohen
---

# Install Dynamics 365 Field Service

After purchasing licenses for Field Service, an administrator installs the application on a Power Platform environment.

## Requirements

When installing Field Service, you must meet these requirements:

- You have the **System Administrator** or **Dynamics 365 admin** security role.
- The environment has an attached **Dataverse data store**. The installation process explains how to create a new environment. Field Service isn't supported on a bare Common Data Service (CDS) instance.
- **Enable Dynamics 365 apps** is turned on in the environment settings. The installation process explains how to enable this setting.
- The environment isn't a developer or sandbox environment created without a database.

## Install on a new environment

[Create a Power Platform environment with an attached **Dataverse data store** and turn on the **Enable Dynamics 365 apps** setting](/power-platform/admin/create-environment).

Installing Field Service on an environment that doesn't meet these requirements isn't supported.

## Install on an existing environment

If your organization already maintains environments, you can [install the app on an existing environment with a database](/power-platform/admin/manage-apps#install-an-app) and **Enable Dynamics 365 apps** turned on. If your environment doesn't meet these requirements, [create a Power Platform environment with an attached **Dataverse data store** and turn on the **Enable Dynamics 365 apps** setting](/power-platform/admin/create-environment).

## Install a trial

When you [get a free trial](trial-signup.md), the Field Service application installs automatically on a new environment. After purchasing a license, you can [change the environment type to a production environment](/power-platform/admin/switch-environment).

## Access Field Service

Once the installation is complete, the *Field Service* and *Field Service Mobile* apps appear in the list of apps when you sign in to your Dynamics 365 organization. You can find these apps by going to:

```https://[your-environment-URL].crm.dynamics.com/apps```

:::image type="content" source="media/admin-apps.svg" alt-text="Screenshot of Field Service apps.":::

## Install and set up the Dynamics 365 Field Service mobile app

[Set up the mobile app](mobile/set-up-field-service-mobile.md) for frontline workers to use to view and complete work orders in the field.

## Next steps

After installing Field Service and the Field Service mobile app, see the following articles to configure the system to create, schedule, view, and complete work orders.

- [Set up users and security roles](users-licenses-permissions.md)
- [Create a bookable resource](set-up-bookable-resources.md)
- [Get started with Dynamics 365 Field Service](field-service-get-started.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
