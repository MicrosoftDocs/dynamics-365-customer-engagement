---
title: Field Service troubleshooting
description: Learn how to troubleshoot issues in Dynamics 365 Field Service.
ms.date: 12/14/2023
ms.topic: troubleshooting
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Field Service troubleshooting

## As a user, I can't change my theme in Outlook on the web after installing the Field Service for Outlook add-in

### Resolution

Certain versions of Outlook on the web don't support themes with add-ins. If you want to use themes, use Outlook on the desktop.

## As a frontline manager or worker, my Viva Connections dashboard doesn't have the correct Field Service tiles

### Symptom

When I open Viva Connections, I don't see the Field Service tiles I expect to see.

### Resolution

If you signed in to Teams with one account and then switched to another one, your dashboard tiles might not display correctly. Sign out of both accounts and close the Teams desktop app or browser completely. Then open Teams and sign in with the other account.

## As a frontline manager or worker, I can't find a work order using the work order ID

### Symptoms

When I search for a work order by ID using the **Find by ID** box, no results appear. I'm sure the ID I'm entering is correct.

### Resolution

If you applied one or more filters, they might be narrowing the results too much. Clear any filters and then try the search again.

## As a frontline manager, I'm getting a "length exceeded maximum length" error when I try to create a work order

### Symptoms

When I try to create a work order, I get an error that says the **Work order summary** field exceeded the maximum length of 8,000 characters.

### Resolution

The **Work order summary** field has a limit on the number of characters you can enter. Make your summary shorter.

## As a frontline manager, I'm getting a "currency isn't the same as the price list" error when I try to create a work order

### Symptoms

When I try to create a work order, I get an error that says the currency entered in the work order doesn't match the currency in the price list.

### Resolution

Change the currency in the work order to match the price list, or ask your admin to make sure the currency is set properly in [the price list settings](create-price-list.md) in Dynamics 365 Field Service.

## As a dispatcher, I'm getting a "doesn't have Create permissions" error when I try to create work orders

### Prerequisites

You must have administrator permissions in Dynamics 365 Field Service.

### Symptom

When I try to create work orders, I get the following error:

`An error occurred: Caller user with ID {ID number} does not have Create permissions for the msdyn_timefrompromised attribute in the msdyn_workorder entity. Count secured attributes in entity 11. user has 0 secured attribute privileges.`

### Resolution

Edit the [Column level security](flw-admin.md#set-up-column-level-security-optional) for the Field Service - Dispatcher role and allow Create permission to the `Time To Promised`(`msdyn_timetopromised`) and `Time From Promised`(`msdyn_timefrompromised`). If the error persists, check the security role:

1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com/).

1. Find the environment the dispatcher is trying to use in Outlook.

1. Select **Settings** > **Users + permissions** > **Security roles**.

1. Select the Field Service - Dispatcher role.

1. Scroll to the **Work Order** table. Change the **Create** permission so that it isn't set to **None**.

## As a frontline manager or administrator, I'm getting a "user hasn't been assigned any roles" error when I try to access work orders

### Prerequisites

Administrator permissions in Dynamics 365 Field Service

### Symptoms

An error message displays indicating the user doesn't have the correct privileges.

### Resolution

[Assign the correct security role and field security profile](flw-admin.md#assign-security-roles-and-field-security-profiles) to the user.

## As an administrator, I can't find a user when I'm setting up frontline workers in the Field Service web app

### Prerequisites

You have administrator permissions in Dynamics 365 Field Service.

### Symptoms

I'm trying to [assign security roles to my users](flw-admin.md#assign-security-roles-and-field-security-profiles) in a new Field Service environment. I can't find one of my users in the **Users** lookup field.

   :::image type="content" source="media/fsp-assign-roles.png" alt-text="Screenshot of adding frontline workers in Dynamics 365 Field Service.":::

### Resolution

1. Ask the user to sign in to the environment. Continue to the next step whether or not the user succeeds.

1. Reload the page and search for the user again.

1. If the user still doesn't appear in the list, make sure the user is set up and active in the [Microsoft 365 admin center](https://admin.microsoft.com/).

## As an administrator, I can't identify the user ID in an error message

### Prerequisites

You have administrator permissions in Dynamics 365 Field Service.

### Symptoms

A user ID is listed in an error message from Dataverse and I can't identify the user.

### Resolution

[!INCLUDE [azure-ad-to-microsoft-entra-id](../includes/azure-ad-to-microsoft-entra-id.md)]

Dataverse errors relating to a user show the Field Service user ID, not the Microsoft Entra ID. The Dataverse user ID is specific to the environment. To identify the user:

1. In the Field Service app, select your Field Service environment.

1. On the bottom left, select **Settings** > **Users**.

1. Select any user so that the `systemuser&id` appears at the end of the URL.

   :::image type="content" source="media/fs-user-id.png" alt-text="Screenshot of Field Service Settings Users page with the systemuser&id highlighted.":::

1. Replace the ID number with the ID in the error message and press **Enter**. The user's account tied to this ID appears.

[!INCLUDE [footer-include](../includes/footer-banner.md)]
