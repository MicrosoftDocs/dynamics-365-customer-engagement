---
title: Field Service troubleshooting
description: Learn how to troubleshoot issues in Dynamics 365 Field Service.
ms.date: 12/12/2023
ms.topic: troubleshooting
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Field Service troubleshooting

## As an administrator, I can't find users when setting up frontline workers in the Field Service web app

### Prerequisites

You have administrator permissions in Dynamics 365 Field Service.

### Symptoms

I'm trying to [assign security roles to my users](flw-admin.md#assign-security-roles-and-field-security-profiles) in a new Field Service environment. I can't find one of my users in the **Users** lookup field.

   :::image type="content" source="media/fsp-assign-roles.png" alt-text="Screenshot of adding frontline workers in Dynamics 365 Field Service.":::

### Resolution

1. Ask the user to sign in to the environment. Continue to the next step whether or not the user succeeds.

1. Reload the page and search for the user again.

1. If the user still doesn't appear in the list, make sure the user is set up and active in the [Microsoft 365 admin center](https://admin.microsoft.com/).

## As a dispatcher, I'm getting a "does not have Create permissions" error when I try to create work orders

### Prerequisites

You must have administrator permissions in Dynamics 365 Field Service.

### Symptom

When I try to create work orders, I get the following error:

`An error occurred: Caller user with ID {ID number} does not have Create permissions for the msdyn_timefrompromised attribute in the msdyn_workorder entity. Count secured attributes in entity 11. user has 0 secured attribute privileges.`

### Resolution

An admin must update the [Column level security](flw-admin.md#set-up-column-level-security-optional) for the dispatcher role and provide **Create** permission for - **Time Promised (from)** and **Time Promised (to)**.

## As a user, I can't change my theme in Outlook on the web after installing the Field Service for Outlook add-in

### Symptom

Outlook on the web doesn't support themes with add-ins. If you want to use themes, use Outlook on the desktop.

## As a frontline manager or worker, my Viva Connections dashboard doesn't have the correct Field Service tiles

### Symptom

When I open Viva Connections, I don't see the Field Service tiles I expect to see.

### Resolution

If you signed in to Teams with one account and then switched to another one, your dashboard tiles might not display correctly. Sign out of both accounts and close the Teams desktop app or browser completely. Then open Teams and sign in with the other account.

## As a frontline manager or worker, I can't find a work order using the work order ID

### Symptoms

When I search for a work order by ID using the **Find by ID** box, it's not found. I'm sure the ID I'm entering is correct.

### Resolution

You might have applied one or more filters that are narrowing the results too much. Clear any filters and then try the search again.

## As an administrator, I can't identify the user ID in an error message

### Symptoms

A user ID is listed in an error message and I can't identify the user.

### Resolution

[!INCLUDE [azure-ad-to-microsoft-entra-id](../includes/azure-ad-to-microsoft-entra-id.md)]

In errors that are related to Dataverse, and thus to Dynamics 365, the user ID refers to the Field Service user ID, not the Microsoft Entra ID. The Dataverse user ID is specific to the environment.

1. Go to your Field Service environment.

1. On the bottom left, select **Settings** > **Users**.

1. Look at the end of the URL. For example, id=########-####-####-####-############.

## Length of the work order summary exceeded the maximum length error

### Symptoms

An error message displays indicating the **Work order summary** field exceeded the maximum length of 8000 characters.

### Resolution

Rewrite the summary so that it is less than 8000 characters.

## Currency isn't the same as the price list error

### Symptoms

An error message displays indicating the currency entered on the work order doesn't match the currency on the price list.

### Resolution

Change the currency on the work order to match the price list. Or contact your admin to check the [settings on the specific price list](create-price-list.md) on the Field Service Web.

## User has not been assigned any roles error

### Prerequisites

Administrator permissions in Dynamics 365 Field Service

### Symptoms

An error message displays indicating the user has not been granted the correct privileges.

### Resolution

An admin must [assign the correct security role and field security profile](flw-admin.md#assign-security-roles-and-field-security-profiles).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
