---
title: Set Up Graph API for Dynamics 365 Mail App
description: Discover how to manually create a settings entity and configure the Dynamics 365 Mail App for seamless integration with Graph API.
author: shwetamurkute
ms.author: smurkute
ms.reviewer: smurkute
ms.date: 12/16/2025
ms.topic: how-to
---

# Set up Graph API support for Dynamics 365 Mail App

This article shows you how to configure Graph API support for the Dynamics 365 Mail App by creating a custom settings solution. You create a new solution, add a settings entity, and configure the necessary fields to store your Graph API credentials. This setup lets the Mail App authenticate and communicate with Microsoft Graph services.

## Prerequisites

Before you begin, ensure you have the following:

- Administrative access to your Dynamics 365 environment
- An Azure AD app registration with the app ID
- Your Azure tenant ID
- Appropriate security permissions to create solutions and entities.

## Create the Dynamics 365 Mail App settings solution

Create a new solution in your Dynamics 365 environment to house the Mail App configuration settings.

1. Go to your Dynamics 365 environment.
1. Create a new solution with the following details:
   - **Display name**: Dynamics 365 Mail App settings
   - **Name**: D365MailAppsettings
   - Add a new publisher that allows the customer to create entities with the prefix **mailapp**.
   - **Version**: 1.0.0.0

## Add the settings entity

Add a custom entity to store the Mail App configuration values.

1. In the D365MailAppsettings solution, add a new entity.
1. Set the entity **Name** to **mailapp_setting**, **Display Name** to **MailApp Settings**, and **Plural Name** to **Settings**.

## Configure entity fields

Add new fields in the mailapp_setting entity.

- **mailapp_name**: Stores the name of each configuration setting.
- **mailapp_settingvalue**: Stores the corresponding value for each setting.

## Add the Graph API app ID to the Dynamics 365 Mail App settings

1. To access the entity with the setting, go to `https://<org_domain>/main.aspx?pagetype=entitylist&etn=mailapp_setting`.
1. Create a new record in the mailapp_setting entity with the following values:
   - **Name**: graph_appid
   - **Setting value**: Enter the App ID from your Azure AD App registration.

## Add your Azure tenant ID

Add your Azure tenant ID to complete the authentication setup.

1. Create a new record in the mailapp_setting entity with these values:
   - **Name**: azure_tenantid
   - **Setting value**: Enter your Azure tenant ID

## Configure security permissions

Grant read permissions for the settings entity so users can access the Mail App configuration.

1. Go to **Settings** > **Security** > **Security roles**.
1. For each security role that needs access to the Mail App, grant read permissions for the `mailapp_setting` entity.

## Next steps

After you complete this setup, the Dynamics 365 Mail App can authenticate by using Graph API and access Microsoft Graph services on behalf of your users.