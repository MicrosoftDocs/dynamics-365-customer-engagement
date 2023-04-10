---
title: "Troubleshoot email campaigns (Dynamics 365 Marketing) | Microsoft Docs"
description: "Troubleshooting and frequently asked questions for email campaigns in Dynamics 365 Marketing."
ms.date: 10/05/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
ms.reviewer: renwe
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Troubleshoot email campaigns

## What types of lookup fields are supported?

Dynamics 365 Marketing uses the [same lookup types as other Dynamics 365 Customer Engagement apps](../customerengagement/on-premises/customize/types-of-fields.md#different-types-of-lookups). When creating an email template containing [dynamic content](dynamic-email-content.md) that will be used in customer journeys, however, you should make note of what entity type any **Customer** lookup field is referring to.

**Customer** lookup fields may reference a *contact* or an *account* entity, but not both. For example, you might create an email template containing the following dynamic content:
- "Hello {{contact.contact_contact_parentcustomerid.firstname}}”

The email's dynamic content references a *contact* entity. If you create a customer journey with segment members comprised of *contact* and *account* entities from **Customer** lookup fields, the above email template will only deliver to the *contact* entities. Any *account* entities in the segment will be blocked. 

To avoid blocked emails, the customer journey should filter segment members by the relationship to the *contact* entity or the *account* entity so that each segment member can be sent to the email template with the appropriate dynamic content.

## How do I use Marketing attributes on links and buttons in raw HTML?

If you're updating or creating links in raw HTML, you should understand the meaning of some internal attributes that the Marketing email engine uses.

- The `data-msdyn-tracking-id` attribute is handy if you want the tracking service to consider two links as the same thing. You would typically use this attribute when you create two physical links in HTML, but only one is shown for users based on the email client used. For such a scenario, the `data-msdyn-tracking-id` attribute should have the same value for both links. When the attribute has the same value, only one link will be displayed in the email insights, and link clicked interactions will be the same for both links. Below is an example of two links using the same attribute.

    ```
    <!--[if gte mso 9]><v:shape xmlns:v="urn:schemas-microsoft-com:vml" data-msdyn-tracking-id="a50219d489b91583158608851" href="https://www.microsoft.com">LINK TEXT</v:shape><![endif]-->
    <!--[if !mso]> <!----><a class="buttonClass" data-msdyn-tracking-id="a50219d489b91583158608851" href="https://www.microsoft.com">LINK TEXT</a><!--<![endif]-->
    ```

    Both of the links above will create the same link clicked interactions. The first link will be visible in Outlook. The second link will be visible in non-Outlook clients such as Gmail.

- Another important attribute is `data-msdyn-tracking`. This Boolean attribute controls link tracking. If it's set to *false*, the link won't be tracked, and you won't see whether a user has clicked the link.
