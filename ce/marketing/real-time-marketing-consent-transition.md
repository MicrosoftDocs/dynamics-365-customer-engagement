---
title: Consent management and double opt-in transition guidance
description: Learn the capabilities of consent management in Dynamics 365 Marketing and how to use them in specific scenarios.
ms.date: 07/27/2023
ms.topic: article
author: petkra
ms.author: petkra
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Consent management and double opt-in transition guidance

More functionality and features are added Dynamics 365 Marketing each month. Currently, there are two engines to engage customers in the Marketing app: outbound marketing  and real-time marketing. The two engines work differently, so feature parity can come in different forms. You should consider this when transitioning from outbound marketing to real-time marketing.

When it comes to consent management and related topics, the two Marketing engines have their own concepts:

> [!div class="mx-imgBorder"]
> ![Comparison of outbound and real-time consent.](media/real-time-marketing-consent-transition-1.png)

To determine if a message was sent out to a contact or lead, the following processing takes place:

In outbound marketing, the journey verifies the information within the indicated content settings to identify the relevant subscription center and use that information to start email processing. The system then checks the attributes **DoNotBulkEmail** and **DoNotEmail** on the contact profile before proceeding to an evaluation of the contact’s consent level versus the consent level indicated for the journey.

In real-time marketing, the processing is different. As the journey starts and when a message is to be processed, it checks against the compliance profile selected for the message to be sent. Real-time marketing uses two types of compliance profiles (preference center and subscription center), which are configured by an administrator depending on the type of consent management page to be used in the message. With both types of compliance profiles, processing checks the attributes **DoNotBulkEmail** and **DoNotEmail** on the contact profile and uses the information on the topic and purpose for the compliance profile to finish preparing and eventually send the message.

> [!div class="mx-imgBorder"]
> ![Outbound versus real-time consent processing chart.](media/real-time-marketing-consent-transition-2.png)

One characteristic to note is that the use of the **DoNotBulkEmail** and **DoNotEmail** attributes on the contact profile is common to both outbound and real-time marketing. Additionally, real-time marketing is able to use subscription centers as the page where consent can be captured, making the transition from outbound marketing to real-time marketing easier.

One important consideration with outbound marketing is that the consent given by a contact is tracked on contact level, which has the following consequences:

- It's not possible to distinguish between two different marketing communications, for example, for two different products.
- There's no support to manage consent for other channels within the product.

The real-time marketing module follows a different concept from the beginning, allowing marketeers to use channels other than email. For example, you can instead use text message or push notifications. A contact (or lead) potentially can receive messages through multiple channels and all the different contact points can have different consent preferences. For example, the contact allows commercial marketing through email, but doesn't want commercial marketing through text messages.

As of today, the outbound and real-time modules both respect the settings on the contact level in the attributes **DoNotBulkEmail** and **DoNotEmail**, which reflect a general opt-in or opt-out (see also [Consent Preview](real-time-marketing-email-text-consent-preview.md)). While real-time marketing checks the **DoNotEmail** and **DoNotBulkEmail** fields on the contact entity, updates made to consent from real-time messages don't update the **DoNotEmail** and **DoNotBulkEmail** fields on the contact. Updates from real-time messages only update the contact point consent records for the email address. This means that outbound marketing messages won't be affected by changes made to consent records based on messages sent by real-time marketing.

## Double opt-in and GDPR

In certain geographies, to be able to execute marketing campaigns and target customers, it's required that those customers agree (opt-in) to that communication.
According to [the general data protection regulation (GDPR)](https://gdpr-info.eu/), only a single opt-in is required to comply with the regulation. However, this is probably not the only legislation that needs to be considered. Companies also have to comply with additional local regulations or internal policies that can be stricter than the GDPR and require double opt-in (see, for example, [Is double opt-in really required for email marketing in Germany? | Demodia](https://www.demodia.com/articles/data-processes/is-double-opt-in-really-required-for-email-marketing-in-germany)).

Customers provide their consent typically through a form and a checkbox, which explicitly needs to be checked by the customer to submit the form (single opt-in). In situations where double opt-in is required, the submission of the form alone doesn't satisfy the privacy requirements. Companies are required to send a confirmation email that their customers must open and click on a confirmation link to verify that it was indeed their idea to opt in.

> [!div class="mx-imgBorder"]
> ![Double opt-in process chart.](media/real-time-marketing-consent-transition-3.png)

This process applies too on the update of marketing preferences (opt-in or opt-out).

## Global vs. form-based double opt-in

Management of double opt-in is currently only available using outbound marketing features. However, it's possible to use real-time marketing with the double opt-in settings in outbound marketing. This means that customers can use real-time marketing for the execution of their marketing campaigns while using outbound marketing to manage the double opt-in process. As described previously, both engines provide an evaluation marketing preferences attributes on a contact level (**DoNotBulkEmail** and **DoNotEmail**). [This article](https://community.dynamics.com/blogs/post/?postid=24df8cbc-5724-4734-b898-24cfe57d3c33) describes how to set everything up to use double opt-in in real-time marketing.

When global double opt-in is enabled, a customer always receives an email message to confirm a new subscription or if a change of consent occurs. This could also be set up for specific forms only (instead of globally).

## Real-time marketing enhancements to consent

Compliance profiles summarize and bundle specific consent settings. There's always at least one compliance profile in the system. Compliance profiles for real-time marketing are linked to a preference center – a customizable form, which provides the ability to change the consent settings. Compliance profiles allow an organization to define consent settings using purposes. One compliance profile can contain different consent purposes, which represent a reason for which consent is collected, typically **Commercial**, **Transactional**, or **Tracking**. These are created by default when a new compliance profile is created.

For **Transactional** and **Commercial** purposes, it's also possible to define topics. Topics allow you to further refine the communication preferences. For each commercial purpose, it's possible to add general topics such as “Newsletter” or “Daily Deals.” Topics can be seen as a successor of subscription lists.

The following picture shows the connection between these entities.

> [!div class="mx-imgBorder"]
> ![Compliance profiles flow chart.](media/real-time-marketing-consent-transition-4.png)

It's possible for an organization to have multiple compliance profiles in place, for example, for each subsidiary or country and each with different consent purposes.

## Scenarios

Now that we've discussed the differences between opt-ins and the capabilities in the product, let’s take a look at some scenarios and how compliance settings can be utilized.

### Migrate consent from outbound marketing

Real-time marketing stores the contact point consent information in the consent center, which is available as a menu item in the site map. To migrate consent settings from outbound marketing, there's a **Load consent** button, which initiates a copy of the consent settings to the real-time marketing consent center. With the enhanced options in real-time marketing mentioned above, it's possible to copy the outbound marketing consent information to a specific compliance profile and define which commercial and transactional purpose the data should be copied. For the commercial purpose, it's also possible to optionally define a topic to store the consent for. This results in a contact point consent record of type **topic** and could potentially be used to migrate a subscription list to a real-time marketing topic.

This can be used for the following procedures:

1. Copy contact consent to a specific purpose or topic for a purpose.
1. Copy lead consent to a specific purpose or topic for a purpose.
1. Copy the opt-in information of a subscription list to a purpose or a topic for a purpose.

The following picture shows the different settings:

> [!div class="mx-imgBorder"]
> ![Comparison of contact versus subscription list settings.](media/real-time-marketing-consent-transition-5.png)

The **Load consent** function loads the data from the **DoNotBulkEmail** and **DoNotEmail** attributes for contact and lead consent. The function should be used when the contact point consent center is populated because real-time marketing relies on those settings. The function can also be used multiple times, for example, if multiple subscription lists should be migrated to different topics in real-time marketing. See also: [Adding consent data to real-time marketing](ce/marketing/real-time-marketing-migrate-consent)

Because the contact point consent settings are only updated when using preference centers, outbound marketing forms and pages that update consent shouldn't be used once the migration has been done.

### Implement double opt-in and real-time marketing at the same time, contact level consent is required

As mentioned above, double opt-in is currently provided only through outbound marketing. The functionality will be implemented later to be natively available in real-time marketing. If possible, it's best to wait for this functionality to become available natively in real-time marketing. If that isn't an option, it's possible to set up double opt-in in outbound marketing and make use of those settings in real-time marketing. In this scenario, it's important that you understand how the two modules work together:

1. Forms and double opt-in must be set up in outbound marketing.
1. If double opt-in is enabled on an outbound marketing form, any contact that gets created won't actually be in the system until the link is clicked in the confirmation email triggered by completing the form.
    - This means that you can "trust" that a contact has double opted-in if they were created from a form that requires double opt-in.
    - As part of the form, they could sign up for various subscription lists, or just have **DoNotBulkEmail** and **DoNotEmail** fields set to **0** (equals **Allow**), depending on whether the customer is using subscription lists.
    - If subscription lists are used and the customer decides to opt into additional subscription lists using the subscription center and **Global Double Opt-in** is enabled, any changes a customer makes to join a new subscription list will trigger a confirmation email.
1. Real-time marketing respects the **DoNotBulkEmail** and **DoNotEmail** fields on the contact.
1. If a customer unsubscribes from a subscription list that is used to create a segment in a real-time marketing journey, the customer won't receive messages from the journey.

Using both modules (outbound and real-time) at the same time is considered as a temporary solution until double opt-in becomes available in real-time marketing. There are situations where double opt-in is only required the first time. In that case, the setup is still the same as described above. In addition, it's possible to use real-time marketing features like purposes and topics. It's also possible to use the real-time marketing preference center that allows customers to opt in for new topics. In that case, the corresponding real-time marketing email won't require a second (double) opt-in.

### Use real-time marketing and lead consent, manage consent on contact point level

In this scenario, real-time marketing compliance settings must be used since contact point level consent isn't available in outbound marketing. Managing consent for leads is also not available in outbound marketing. Purposes and topics should be used to handle the consent. The process of creating the required artifacts is described here: [Manage consent for email and text messages in real-time marketing](real-time-marketing-email-text-consent.md). Once the consent is available in real-time marketing and leads are able to change their consent using a preference center, no outbound marketing artifacts like forms should be used anymore.

### Multiple brands and consent by topic

In this scenario, a customer has multiple brands, each one needing to capture consent for their own purposes and would like to have their own topics to which consumers can opt in or out. This can be achieved by creating multiple compliance profiles, one for each of the involved brands. Within the compliance profiles, each brand can define their own topics that are appropriate for their communication. Once topics are set, they can be added to the brand’s preference center to allow customers to opt in or out for the areas that are of interest.  

### Operating in multiple countries and/or requiring preference centers in multiple languages

This is similar to the multiple brand scenario, but in this scenario, the company is looking to structure around the multiple geographies it operates in rather than by the brands used. This too can be addressed with multiple compliance profiles created for each country. Once defined, each compliance profile has its own preference center page with content written in the appropriate language and referencing the appropriate supporting material.