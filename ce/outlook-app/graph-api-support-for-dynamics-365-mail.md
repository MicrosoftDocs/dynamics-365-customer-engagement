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

This article shows you how to configure Graph API support for the Dynamics 365 Mail App by creating a custom settings solution. You'll create a new solution, add a settings entity, and configure the necessary fields to store your Graph API credentials. This setup enables the Mail App to authenticate and communicate with Microsoft Graph services.

## Prerequisites

Before you begin, ensure you have:

- Administrative access to your Dynamics 365 environment
- An Azure AD App registration with the App ID
- Your Azure tenant ID
- Appropriate security permissions to create solutions and entities

## Create the D365 Mail App settings solution

Create a new solution in your Dynamics 365 environment to house the Mail App configuration settings.

1. Navigate to your Dynamics 365 environment.
1. Create a new solution with the following details:
   - **Name**: D365MailAppsettings
   - **Version**: 1.0.0.0

## Add the settings entity

Add a custom entity to store the Mail App configuration values.

1. In the D365MailAppsettings solution, add a new entity.
1. Set the entity name to **mailapp_setting**.

## Configure entity fields

Add the required fields to store setting names and values.

1. In the mailapp_setting entity, add the following new fields:
   - **mailapp_name**: Stores the name of each configuration setting
   - **mailapp_settingvalue**: Stores the corresponding value for each setting

## Add the Graph API App ID

Configure the App ID from your Azure AD App registration.

1. Create a new record in the mailapp_setting entity with the following values:
   - **Name**: graph_appid
   - **Setting value**: Enter the App ID from your Azure AD App registration

## Add the Azure tenant ID

Configure your Azure tenant ID to complete the authentication setup.

1. Create a new record in the mailapp_setting entity with the following values:
   - **Name**: azure_tenantid
   - **Setting value**: Enter your Azure tenant ID

## Configure security permissions

Grant read permissions for the settings entity to ensure users can access the Mail App configuration.

1. Navigate to **Settings** > **Security** > **Security roles**.
1. For each security role that needs access to the Mail App, grant read permissions for the mailapp_setting entity.

## Next steps

After completing this setup, the Dynamics 365 Mail App will be able to authenticate using Graph API and access Microsoft Graph services on behalf of your users.