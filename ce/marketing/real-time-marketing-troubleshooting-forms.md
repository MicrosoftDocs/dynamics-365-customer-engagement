---
title: Troubleshooting real-time marketing forms
description: Learn how to troubleshoot real-time marketing forms in Dynamics 365 Marketing.
ms.date: 05/12/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: petrjantac
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Troubleshooting real-time marketing forms

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

This article explains how troubleshoot forms in real-time marketing.

## My embedded form isn't visible on my page

Make sure that your domain is allowed for external form hosting. You don't need to finish the domain authentication process to enable external form hosting for your domain. Learn more about [domain authentication](domain-authentication.md).

## Publishing a form as a standalone page fails

This feature uploads a page with form on CDN. If the operation fails, try to run it again after few minutes.

## Form editor removed my custom JavaScript or other custom code from the HTML body

The form editor can remove unknown code from the body. [Learn more](real-time-marketing-manage-forms.md#add-custom-javascript-to-your-form) about how to customize your form using JavaScript.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
