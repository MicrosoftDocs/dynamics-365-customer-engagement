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



[!INCLUDE [footer-include](../includes/footer-banner.md)]
