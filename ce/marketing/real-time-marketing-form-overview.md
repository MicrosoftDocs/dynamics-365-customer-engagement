---
title: Overview of real-time marketing forms
description: Overview of real-time marketing forms in Dynamics 365 Marketing.
ms.date: 07/20/2023
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

# Overview of real-time marketing forms

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE5dqbE]

A marketing form is an inbound communication channel that allows your customers to register for newsletters, ask for quotations, etc. The form is defined by a set of input fields arranged into a form layout.

Each marketing form is made from a collection of fields, buttons, graphical elements, and a few configuration settings. Each field included in your form is linked to an attribute of an entity in Dynamics 365 Marketing.

The real-time marketing form editor allows you to easily and quickly create and publish forms. You can choose a template or start from scratch. You can also design form content using drag-and-drop elements and preview options. Once your form is ready, you can publish the form in one quick step.

> [IMPORTANT]
> There's a limit of 2,000 requests/minute per org. The request limit includes visits, lookup, CAPTCHA, and form submission. The limit allows around 100 to 500 submissions/minute, depending on the form.

## Comparison of real-time and outbound marketing forms

- The main difference between real-time and outbound marketing forms is that real-time marketing forms can update only one entity (typically a Lead or Contact). Targeting a single entity makes the form configuration and maintenance easier and it allows you to build properly targeted journeys.
- There's no need to create Marketing fields for real-time marketing forms. All entity attributes are already available as fields to be used in a form. That includes all custom attributes you created for your lead or contact entities.
- You're no longer required to create a form page to embed your form into a web page. You can generate the form embedding code snippet with one action.
- Published real-time marketing forms are hosted on Content Delivery Network (CDN), which significantly reduces the form load time for the page visitor.
- Real-time marketing journey orchestration: Use the "Marketing Form Submitted" trigger for journeys based on real-time marketing forms. The trigger for outbound marketing forms has been renamed to "Marketing Form Submitted (Outbound)".
- It's not possible to edit outbound marketing forms in the real-time marketing form editor and vice versa.

### Form types comparison

The following table summarizes the types of forms currently available in real-time marketing. More form types will be available soon.

| Form type in outbound marketing | Form type in real-time marketing |  
|---|---|
| Landing page form  | Marketing form  |
| Subscription center form | Preference center (will be available as part of Consent configuration) |
| Event registration form | N/A |
| External form submission capture | N/A |
| Refer to friend | N/A |

## Security notice

Security is an important aspect of forms. Dynamics 365 Marketing takes the following precautions to avoid any security risks:

- The Marketing app accepts form submissions only from domains allowed for external form hosting.
- The Marketing app infrastructure contains necessary precautions to minimize the impact of a possible DDoS attack.

## Next steps

- [Create real-time marketing forms](real-time-marketing-form-create.md)
- [Manage real-time marketing forms](real-time-marketing-manage-forms.md)
- [Troubleshooting real-time marketing forms](real-time-marketing-troubleshooting-forms.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
