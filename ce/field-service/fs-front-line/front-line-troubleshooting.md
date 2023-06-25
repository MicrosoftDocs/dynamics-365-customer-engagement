---
title: Field Service (Preview) troubleshooting
description: Learn how to troubleshoot issues in Dynamics 365 Field Service (Preview).
ms.date: 06/13/2023
ms.topic: troubleshooting
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
---

# Field Service (Preview) troubleshooting

[!INCLUDE[public-preview-banner](../../includes/public-preview-banner.md)]

## As an admin, I can't find users when setting up frontline workers in the Field Service web app

### Prerequisites

Administrator permissions in Dynamics 365 Field Service (Preview)

### Symptoms

As an admin, when using a new Field Service environment and trying to [assign security roles for my users](front-line-admin.md#assign-security-roles-and-field-security-profiles), I can't find a user in the **Users** field.

   :::image type="content" source="media/fsp-assign-roles.png" alt-text="Screenshot of adding frontline workers in Field Service.":::

### Resolution

1. Ask the user to log into the Field Service environment. Even if the user can't access the environment, continue to the next step.

1. As an admin, refresh your screen and try searching for the user again.

1. If you still can't find the user, check if the user is set up in the [Microsoft 365 Admin Center](https://admin.microsoft.com/).

## As a dispatcher, I can't create work orders

### Prerequisites

Administrator permissions in Dynamics 365 Field Service (Preview)

### Symptom

As a Field Service dispatcher, I can't create work orders.

### Resolution

An admin must update the [Column level security](front-line-admin.md#set-up-column-level-security-optional) for the dispatcher role and provide **Create** permission for - **Time Promised (from)** and **Time Promised (to)**.

## I can't change my Outlook Web theme in the Field Service (Preview) Outlook Add-in

### Symptom

Outlook add-ins on the Outlook Web don't support themes.

### Resolution

If you want to use themes, use the Outlook Desktop.

## My Viva Connections dashboard doesn't have the correct Field Service (Preview) tiles

### Symptom

If you signed into Teams as one user and switched to another user, your dashboard tiles may display incorrectly.

### Resolution

Sign out of the original account and close the Teams app or browser completely. Then open Teams and sign in as the other user.

## I can't find a work order with the work order ID

### Symptoms

I search for a work order by ID using the **Find by ID** box, but no results display.

### Resolution

- The **Find by ID** box uses a strict match between what is typed in the box and the work order number. For example, “10” won’t find work order ID “00010”. Enter the full work order ID.
- If a filter is applied before you search, clear the filters and then try the search again.

## I don't know the user ID in an error message

### Symptoms

As an admin, a user ID is listed in an error message that I can't identify.

### Resolution

The user ID in Dataverse-related errors is the Field Service user ID, not the Azure Active Directory ID. The user ID is specific to the environment.

1. Go to your specific Field Service environment.

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

Change the currency on the work order to match the price list. Or contact your admin to check the [settings on the specific price list](../create-price-list.md) on the Field Service Web.

## User has not been assigned any roles error

### Prerequisites

Administrator permissions in Dynamics 365 Field Service (Preview)

### Symptoms

An error message displays indicating the user has not been granted the correct privileges.

### Resolution

An admin must [assign the correct security role and field security profile](front-line-admin.md#assign-security-roles-and-field-security-profiles).

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
