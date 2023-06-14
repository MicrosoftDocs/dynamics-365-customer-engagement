---
title: Migrate consent records to real-time marketing
description: Learn how to migrate existing consent records to real-time marketing from outbound marketing and other sources.
ms.date: 07/01/2023
ms.custom: 
  - dyn365-marketing
ms.topic: reference
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Adding consent data to Real-time marketing

When you install real-time marketing, the real-time marketing consent center (**Real-time marketing** > **Audience** > **Consent center**) contains no records, even if you already gathered consent in outbound marketing. You don't need to reenter contact consent data from outbound marketing if you plan to run real-time journeys for contacts. If you want to reuse contact consent data for leads or profiles, or wish to add new consents, you can use one of three methods:

- Add new consent records for email and text messages manually by selecting the corresponding option from the top ribbon.

> [!div class="mx-imgBorder"]
> ![Email and text consent entry screenshot.](media/real-time-marketing-email-text-consent2.png "Email and text consent entry screenshot")

- Import consent settings from an Excel file.

> [!TIP]
> If you don't see the **Import from Excel** option in the top ribbon, you might have to select the three dots on the right side of the ribbon to see more items.

- Load consent information that was already captured for contacts or leads in Dynamics 365 Marketing.

## Loading consent from contacts, leads and subscription lists

> [!IMPORTANT]
> If you segregate data across business units, you need to load consent from your sources (Contacts, Leads, and/or subscription lists) into each business unit's compliance profile(s) individually. This will ensure that valid consent records are created for each business unit and compliance profile combination.

The **Load consent** button loads consent information for email addresses that are stored in contact, lead, or subscription list records in Dynamics 365 Marketing and set up in the audience configuration in settings. It's not intended to load consent from other data sources.

The following message appears:

> [!div class="mx-imgBorder"]
> ![Load consent screenshot.](media/real-time-marketing-load-consent.png "Load consent screenshot")

To load consent from contacts or leads, the following conditions apply:

1. Only one email address from a contact or lead record is loaded. This field is defined in the [Audience configuration](real-time-marketing-audience-data.md) and an administrator can change it.
1. For the Commercial purpose, the system checks whether the Contact has both the Bulk Email and Email fields set to *Allow*. If either of those fields is set to *Do Not Allow*, the contact point consent record is set to *Opted out*.
1. If you load consent from Contacts, new "Tracking" consent records are created based on the value in the Tracking field on the contact.
1. If two or more contacts or leads share the same email address, consent for the email is set to *Opted in* **only** when all contacts or leads contain the value *Bulk email=Allow*. In all other cases, consent for the email address is set to *Opted out*.
1. If consent for the email already exists in real-time marketing, the above-listed rule applies. The email address is only opted in if **both** email consent values are set to *Allow* **and** all consent records from contacts that share the same email address are set to *Allow*.

Consent loaded from contacts and leads relates to the email set in audience configuration and includes the following fields: *Allow email*, *Allow bulk email*, and *Allow tracking*.

Loading consent allows you to choose the Compliance profile and the Purpose where the consent should be loaded. Typically, you want to load consent from contacts or leads into the Commercial and Transactional purposes for the Compliance profile with a Preference center.

## Loading consent from Subscription lists

Subscription lists in Outbound marketing typically map to Topics within a specific Purpose. For instance, if you had two subscription lists you should create two Topics within the Commercial purpose of your Compliance profile and then load consent from the Subscription lists directly into the topics.

In addition, if you used Outbound marketing Subscription lists as "do not email" lists, you can load those records into the topics as "Opted out" records to preserve that behavior.

Loading consent from subscription lists doesn't look at the Bulk email or Email fields on the contact or lead. It simply replicates the Subscription list membership into the chosen Purpose or Topic with the selected consent value.

## Scenarios

### Loading contact or lead Bulk email, Email, and Tracking consent

> [!NOTE]
> Leads do not contain a field for Tracking consent, so Real-time marketing Tracking consent records will not be created.

1. Choose whether you're loading consent from Contacts or Leads
1. Choose the appropriate Compliance profile, which is likely a new profile with a Preference center.
1. Choose the purpose that should reflect the Bulk email field. Typically, this is the Commercial purpose if it hasn't been renamed
1. Choose the purpose that should reflect the Email field. Typically, this is the Transactional purpose if it hasn't been renamed.

### Loading contact and subscription list consent records into Real-time marketing

If you managed consent in Outbound marketing using Subscription lists while also allowing people to opt-out of communications using the Bulk email and Email fields on contacts or leads, this scenario may apply.

1. First, load consent records from your Subscription lists into the Topics that replace those lists. This creates the equivalent consent records in Real-time marketing.
1. Next, load consent records from either the Contacts or Leads into the parent purpose of those Topics. This ensures that the existing Bulk email and Email field values are respected.

### Loading "do not contact" Subscription lists

If you have set up a Subscription list to track individuals who don't wish to be contacted, you can migrate this data in a couple of ways

1. If you have one Subscription list that tracks everyone who has opted out of marketing messages, you should load that as "Opted out" into the Commercial purpose of the Compliance profile
1. If you have one Subscription list that tracks everyone who doesn't want to receive any messages, you should load that as "Opted out" into the Commercial and Transactional purpose of the Compliance profile
1. If you have multiple Subscription lists that track individuals who have opted out of specific communication themes or topics, you should load those as "Opted out" into the equivalent Topics within the Commercial Purpose of the Compliance profile

> [!IMPORTANT]
> If you store consent data for contacts in a field other than **Allow bulk email**, you'll need to use the **Import from Excel** option to load consent data to the consent center first. Only then will you be able to send commercial email in a real-time customer journey.

> [!IMPORTANT]
> If you restore data in real-time marketing, all consent records will be returned to the state they were in at the time backup was made. This may result in consent data being obsolete. To avoid complications, export all consent data into Excel before starting the restore process and use it as a reference after the restore is completed.

### See also

[Grow your business with multi-brand, custom preference centers](real-time-marketing-compliance-settings.md)
[Real-time marketing preference centers](real-time-marketing-preference-centers.md)
[Outbound marketing compliance settings](privacy-use-features.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
