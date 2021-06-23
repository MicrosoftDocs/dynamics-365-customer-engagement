---
title: "Enable prefilling for marketing forms (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to set up your marketing forms to support prefilling of form fields for returning contacts in Dynamics 365 Marketing."
ms.date: 03/08/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Enable prefilling for forms

The prefill feature for marketing-page forms provides returning contacts with a form that already shows their previously entered information, like their name and email address. Contacts will usually find prefilled forms to be more convenient, which is likely to improve the submission rate. Prefilled forms can also help lower data-entry errors, thereby improving the quality of your data. However, you must also consider your contacts' privacy, so you'll be able to control precisely which fields on which forms will allow prefilling, and each contact can choose for themselves whether or not to allow prefilled landing-page forms. Subscription center forms, however, always support prefilling due to the role they play in the system.

For general information about how to create, design, and work with marketing pages, see [Create and deploy marketing pages](create-deploy-marketing-pages.md).

## How prefilling works for different types of forms

Dynamics 365 Marketing supports three marketing form types: landing pages, subscription centers, and forward-to-a-friend. Because each form is very different, each of them treats prefilling differently.

### Landing-page forms

The following rules apply for prefilling landing-page forms:

- Landing-page forms manage prefilling at three levels: field, form, and contact. Only fields explicitly configured to allow prefilling can provide prefilled values, and only on forms where prefilling is enabled, and only for contacts that enabled the "remember me" feature the last time they submitted a form.
- All landing-page forms that have prefilling enabled must include a "remember me" check box, which enables contacts to manage the feature.
- When a contact submits a landing-page form with the "remember me" check box selected, Dynamics 365 Marketing creates or updates the contact record with information from the incoming form, sets the **Prefill marketing form** field to **Allow** for that record,  and stores a cookie in the contact's browser. The cookie contains a public hash code, which Dynamics 365 Marketing can use to find a contact record and returned a form prefilled with values from that record the next time that contact requests the form using the same browser (not in private-browsing mode).
- When a contact submits a landing-page form with the "remember me" check box cleared, Dynamics 365 Marketing creates or updates the contact record with information from the incoming form and sets **Prefill marketing form** to **Disallow** for that record.
- When a contact with **Prefill marketing form** set to **Disallow** opens a landing page, Dynamics 365 Marketing won't return any contact-record values even if the cookie is present, and regardless of the prefill settings for the form and its fields.
- When a contact with **Prefill marketing form** set to **Allow** opens a landing page, Dynamics 365 Marketing requests the cookie, finds the matching contact record (if any), and returns a form where all fields enabled for prefilling show matching values from that contact's contact record.

> [!NOTE]
> You can view the allow-prefill and other contact preferences for any contact. To see it, open the contact record, go to the **Details** tab, and review the **Contact preferences** section. More information: [Manage information about your current and prospective customers](manage-customer-information.md)

### Subscription center forms

The following rules apply for prefilling subscription-center forms:

- Subscription forms always allow prefilling, and all fields in the form will allow prefilling regardless of their **Prefill** setting.
- All marketing email messages must include a link to a subscription center. The link always includes an ID that Dynamics 365 Marketing uses to identify both the recipient and the message. When a contact selects this link, Dynamics 365 Marketing uses the submitted ID to find the contact record and return a form prefilled with contact values and the current state of each included subscription list. Dynamics 365 Marketing also sets a cookie just like the one it sets for landing pages.
- If a contact opens a subscription center page directly, rather than selecting a link from an email, then the ID won't be present in the URL. Instead, Dynamics 365 Marketing requests the cookie as backup to identify the contact. If the cookie isn't found, then the subscription center won't work because it won't know who it's talking to.
- Links in email test sends also don't include a recipient ID, which means that when you open a subscription center link in a test-send email, the subscription center probably won't work. To test a subscription center, create and run a simple customer journey with a segment that only targets your own email address and a test message that includes the subscription-center link.

### Forward-to-a-friend forms

Prefilling isn't supported for forward-to-a-friend forms because these forms don't display information from the database. The email addresses that contacts enter here aren't checked against addresses already in the database, and the values entered aren't connected to the submitting contact in any way. These addresses are only stored temporarily&mdash;they aren't used to create new contact records, nor are they visible to Dynamics 365 Marketing users.

## Create a landing-page form with prefill enabled

To create a form with prefilling enabled on one or more fields:

1. Go to **Marketing** > **Internet marketing** > **Marketing forms**. Then either open an existing form to edit it or choose **New** on the command bar to create a new one.
1. Set the **Form type** (near the top of the page) to **Landing page**.
1. Go to the **Summary** tab and find the **Content** section. Make sure the **Prefill fields** setting here is set to **Yes**. (If this is set to **No**, then the form will not support prefilling for any fields.)
1. Go to the **Designer** tab and add all the required fields and other design elements.
1. None of the fields allow prefilling by default. To enable prefilling for a field:
    - Select the field element on the canvas.
    - Open the **Properties** tab in the side panel.
    - Select the **Prefill** check box.
1. Repeat the previous step for each field where you want to enable prefilling.
1. Make sure your form includes a **Remember me** element. This creates the check box that contacts can use to control the prefill feature. (It's usually added automatically when you enable prefilling for the form.)
1. Save your form.

## Create a subscription-center form with prefill enabled

Prefilling is always enabled for all fields in a subscription center form. To create a subscription-center form:

1. Go to **Marketing** > **Internet marketing** > **Marketing forms**. Then either open an existing form to edit it or choose **New** on the command bar to create a new one.
1. Set the **Form type** (near the top of the page) to **Subscription center**. This option does the following:
   - The **Prefill fields** setting on the **Summary** tab is automatically set to **Yes** and becomes read-only.
   - All fields will support prefill, regardless of their **Prefill** setting.
   - You don't need to include a **Remember me** element, but you should consider adding one to enable contacts to enable prefilling the next time they visit one of your landing pages.
   - You must always include a **Do not email** element.
1. Go to the **Designer** tab and add all the required fields, subscription lists, and other design elements.
1. Save your form.

More information: [Set up subscription lists and subscription centers](set-up-subscription-center.md).

## Enable prefill for an embedded form

If you have embedded a marketing form on an external website (such as your own organization's website), rather than publishing it on a marketing page published on a Power Apps portal, you must authenticate the domain where you have embedded the form and also configure the form to enable prefill. For instructions, see [Integrate with forms published on an external website](embed-forms.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]