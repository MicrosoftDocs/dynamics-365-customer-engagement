---
title: Field Service (Preview) known issues
description: Learn about the known issues in Dynamics 365 Field Service (Preview).
ms.date: 05/24/2023
ms.topic: faq
author: jasonxian-msft
ms.author: jasonxian
ms.reviewer: v-wendysmith
ms.custom: bap-template
---

# Field Service (Preview) known issues

## Unable to find a work order with the work order ID

- When a filter is applied and then you search for a work order by ID using the **Find by ID** box, no results display. Clear the filters and try again.
- The **Find by ID** box uses a strict match between what is typed in the box and the work order number. For example, “10” won’t find work order ID “00010”.  

## Dispatcher role can't create work orders

For the **Field Service - Dispatcher** role to create work orders, an admin must update the [Column level security](front-line-admin.md#set-up-column-level-security-optional) for the role and provide **Create** permission for:
- **Time Promised (from)**
- **Time Promised (to)**

## User has not been assigned any roles error

This error indicates the user has not been granted the correct privileges. An admin must [assign the correct security role and field security profile](front-line-admin.md#assign-security-roles-and-field-security-profiles).

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
