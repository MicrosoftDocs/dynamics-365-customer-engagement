---
title: "Set up and manage marketing forms for use in marketing pages (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Learn about various types of marketing forms and how to create them in Dynamics 365 for Marketing"
keywords: marketing form, fields
ms.date: 03/08/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: d27cf07f-3cef-4fdb-8d12-ffea28ed6f50
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Create, view, and manage marketing forms

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

A marketing form defines a set of input fields arranged into a form layout. You'll probably build a small library of reusable forms that you can place on all your various marketing pages as needed. To add a marketing form to a specific marketing page, use a form element to position the form and choose local settings for it, which apply to that page only.

Each marketing form is made from a collection of marketing form fields, plus form buttons, graphical elements, and a few configuration settings. Each field included in your form must be set up in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] as a marketing form field, which establishes options for how that field is presented in forms where it appears, and which lead or contact fields it maps to. Some features of a marketing form depend on which type of form it is—for example, a subscription center form can include subscription lists.

## Marketing form types

As with marketing pages, each marketing form has a type, which maps directly to the page type where you can use that form. Though you can include more than one form on a marketing page, all forms on the page must be of the same type, and that type must match the type of the page itself. The available types are:

- **Landing page form**: This is a general-purpose form for collecting contact information on marketing pages that are neither subscription centers nor forwarding forms. Landing page forms can also offer mailing-list subscriptions for opt-in, but they can't show the visitor their current subscriptions or allow them to opt out of any lists (for this, they must use a subscription form). When the form is submitted, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] tries to match the incoming data to an existing contact; if a match is found, the matching record is updated, otherwise a new record is created. The new or updated contact will also be subscribed to each mailing list where the check box is selected, but will not change their subscription status for any mailing list where the check box is cleared.

- **Subscription form**: Provides fields where contacts can view and edit their contact details, and shows a collection of mailing lists (with check boxes) where the contact can add or remove subscriptions. When the form is submitted, all contact fields are updated to match the submission, and the contact is removed from all lists where the check box is cleared and added to all lists where the check box is selected. A subscription form only modifies existing contacts, and never creates new ones.

- **Forward to a friend**: Provides a short collection of fields, each of which will accept an email address entered by a contact when forwarding a marketing message to other colleagues.

## Create and edit marketing forms

To create a new marketing form, do one of the following:

- Go to **Marketing** > **Internet marketing** > **Marketing forms** to go to the list of all forms currently available on your instance, and then select **+New** in the command bar. You'll first be asked to choose a template, which establishes the form type, column layout, and sample content. Then you'll be in the form designer.

- While working on an existing marketing page design, add a form element to your design, and then select **+ New** on the **Properties** tab instead of choosing an existing form. A quick-create flyout slides in from the side of the page, where you must enter values for all required fields, and then select **OK**. A new form is created with your selected settings, and applied to your new form element. However, you'll still need to finish the form later by adding content to it as needed. You can do that now by opening it from the **Properties** tab of the page designer while the form element is selected, or you can do it later either from here or from the forms list at **Marketing** > **Internet marketing** > **Marketing forms**.

Either way, after you've selected a template, you'll go to the form designer, which is similar to other types of digital content designers in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], but only provides design elements and settings that are appropriate for marketing forms.

To edit an existing form, do one of the following:

- Go to **Marketing** > **Internet marketing** > **Marketing forms** to go to the form list page. Use the search, sort, and filter controls to find the form you want to edit, and then select its name in the list to go to the form designer.

- Open a marketing page where you use the form, select the form element in the canvas, and then go to the **Properties** tab of the page designer and open it from there.

## Design and validate your form content

When creating or editing a form, you'll be in the form designer, which is an example of the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] digital-content designer that offers design elements for working with forms.

![The form designer](media/designer-forms.png "The form designer")

Use the designer to add, configure, and arrange the various fields, buttons, and graphical elements that your form requires by working as follows:

- Assemble your form by dragging fields and design elements from the **Toolbox** tab to the canvas.

- Configure each element by selecting it and going to the **Properties** tab. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Design elements reference](content-blocks-reference.md)

The designer also provides the usual tools for editing the HTML code and viewing previews in various screen sizes and orientations. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Design your digital content](design-digital-content.md)

Design element availability and requirements vary by form type, as outlined in the following table. Be sure to include all the elements that are required for the type of form you are designing.

| **Design element type** |**Landing page** | **Subscription center** |**Forward to a friend** |
|----------|----------|----------|--------------------------|
| **Text**, **Image**, **Divider**, and **Button** | Yes               | Yes                     | Yes                      |
| **Field**                           | Yes               | Yes                     | No                       |
| **Subscription List**               | Yes               | Yes                     | No                       |
| **Forward to a friend**             | No                | No                      | **Required**             |
| **Do not bulk email**              | Yes               | **Required**            | No                       |
| **Remember me**                    | Yes               | Yes                     | No                       |
| **Submit button**                  | **Required**      | **Required**            | **Required**             |
| **Reset button**                    | Yes               | No                      | Yes                      |
| **Captcha**                          | Yes               | No                      | No                       |

You can also view and edit the raw HTML code for the form by going to the **Designer** &gt; **HTML** tab. There, you can paste code you've copied from other applications and add features that aren't available in the graphical designer (such as custom scripts for validating form input).

When you're done designing your form, select **Check for errors** and to make sure you've included all the required content and settings. [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] checks your form and displays the results. If it reports any errors, read the error text, try to correct the issue, and then check for errors again until the form passes validation.

> [!IMPORTANT]
> Forms are nearly always intended to create or update one or more database records&mdash;especially contact or lead records. However, record creation will fail if any fields required by the database are missing when the form is submitted. When you're designing a form, always be sure to identify all of the fields required by your database, and add a form element with its **Required** check box selected for each of them. That will ensure that contacts who submit the form will get an error message if any required values are missing. If you don't do this, then form submissions may simply be ignored without informing contacts of the problem. Your database could be customized to require fields that you don't expect, so be sure to talk to your system customizer or administrator if you're not sure which fields are required. The **Check for errors** function for forms doesn't identify all of the fields required by your database, especially custom fields, so you can't depend on it to inform you of this issue. Always be sure to test your form to confirm that it creates the types of records you expect it to.

<a name="form-summary"></a>

## Form summary and configuration

In addition to the basic form design, each marketing-form record also includes a **Summary** tab, where you can set a few options and get more information about the form. The following settings and information are provided:

- **General information**: Here you can read and assign a name to the form record, read and set the owner, and see when the form was created and last modified.
- **Content and Lead matching strategies**: These settings control which incoming form-field values are matched against existing contact and lead records. If an existing record has matching values in all the specified fields, then that record will be updated with the incoming values (for the other fields); if no match is found, then a new contact and/or lead record will be created. Default strategies are provided for new forms. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set matching strategies](marketing-settings.md#matching-strategy)
- **Generate leads without matching**: This setting controls whether or not the form will attempt to match an existing lead (using the specified **Lead matching strategy**), or if instead it will always create a new lead for each submission. Set to **No** to apply the matching strategy, or to **Yes** to create a new lead every time.
- **Purpose** and **Visual style**: These fields provide more information about the form. For form templates, these values affect how the form can be found on the **Purpose** and **Visual style** tabs of the template gallery. These settings don't affect the actual layout or functionality of the form in any way.
- **Prefill fields**: Set to **Yes** to enable prefilling for the form; set to **No** to disable it. You can only change this option for landing-page forms&mdash; subscription-center forms always use prefilling, while forward-to-a-friend forms never use it. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Enable prefilling for forms](form-prefill.md)
- **Timeline**: Shows a history of notes and other activities related to the current form. Most types of entities in [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] include this type of display.
- **Related marketing pages**: Here you can see a list of marketing pages where this form is used. Select any listed page to open it.
- **Related fields**: Here you can see a list of fields used in this form. Select any listed field to open its definition.

## Establish marketing-form templates

As with marketing pages themselves, marketing forms are also based on templates, so when you need to create a new form, you are provided with a collection of form templates to help get you started more quickly.

[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] comes with a collection of sample form templates, and you can also save your own templates, which you might do to establish your own visual identity and quickly create new forms that conform to it.

You can view, edit, and create form templates by going to **Marketing** > **Templates** > **Marketing Form Templates**. The process for creating a new template is nearly the same as creating a new form.

## Add a form to a marketing page

Use a form element to add a form to a landing page. After adding the element, you'll choose (or create) the actual form that the element will show and can also choose other configuration settings that affect how it will work on that page.

When you're choosing which form the element will show, you can only choose forms whose type matches the type of marketing page you are working on (landing page, subscription center, or forward to a friend).

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [The form element for marketing pages](content-blocks-reference.md#the-form-element-for-marketing-pages)
