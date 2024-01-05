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



[!INCLUDE [footer-include](../includes/footer-banner.md)]
