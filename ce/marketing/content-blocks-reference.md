---
title: "Design elements reference (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Details for how to use each design element that is available for the design tool in Dynamics 365 for Marketing"
keywords: "designer; design element; element; reference; email; form;  page"
ms.date: 10/01/2018
ms.service: 
  - "dynamics-365-marketing"
ms.custom: 
  - "dyn365-marketing"
ms.topic: reference
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: d1975d36-2383-4b88-ab84-e66930ec2dd0
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer: renwe
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Design elements reference

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Read this topic to learn how to use each of the design elements that are available for use with the various content designers. Some elements are available for all designers and some are specific to email, marketing pages, or forms.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Design your digital content](design-digital-content.md)

## Common design elements

This section provides full details for the design elements that are provided in all (or nearly all) of the contexts where the designer appears (email, marketing pages, and marketing forms).

### Text elements

Text elements create a block of text within a column.

You can edit the text of any new or existing text element by working directly in the element on the canvas. Use the inline toolbar at the top of the selected text element to do inline styling like font face, font color, bold, italic, paragraph justification, and more. You can also delete, clone, or move a selected text element by using the toolbar.

![The text-element toolbar](media/text-block-toolbar.png "The text-element toolbar")

Select a text element and use the settings provided on the **Properties** tabs to stylize the element itself by using colors, fonts, margins, borders, and backgrounds. Many of the settings on the **Style** tab (which apply to the overall page, form, or message design) also affect the styling of text-element content unless overruled locally.

For email messages, the text toolbar includes an assist-edit button, which is marked with **</>**. Use this to place dynamic text, including field values such as the recipient's name. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Add dynamic content to email messages](dynamic-email-content.md)

### Image elements

Image elements add an image to a column, outside a text element. Image elements interact with the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] image gallery, which helps you store, categorize, find, and share your image files.

When you first add an image element, an image placeholder appears at the location where you dropped the element. Select the image placeholder and open the **Properties** tab, where you can set the following options.

- **Source**: Select the **Image Gallery** button next to this field to select an existing image from the gallery, or to upload a new one. When an image is selected, its file name is shown here.
- **Alt text**: Enter a short description of the image. This text will be read aloud to contacts that are using a screen reader, and will also be shown to contacts that have images disabled in their browser or email client. 
- **Link**: Enter a URL here if you'd like the image to function as a link.
- **Alignment**: Choose how the image should be aligned relative to its column (left, right, or center).

When you select an image element, you can use an inline toolbar to delete, clone, or move the element.

### Content-block elements

Content blocks let you establish a block of common content that you can reuse in multiple emails, forms, and/or pages. Use them to establish common headers, footers and other blocks of content that you would like to standardize across your communications.

Content blocks work like templates. They include a fixed collection of content that you add all at once to a design. Once added, the content is copied into your design and doesn't maintain any connection to the original block content, which means that if you edit a content block itself, or its content in a particular design, other designs that already use that block won't be affected.

Use the content-block element to add a content block to your design. When you first add the element, a placeholder icon appears at the location where you dropped the element. Select the new content-block element, open the **Properties** panel, and use the **Content block** lookup field to find and select the block that contains the content you want to include here.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create content blocks that you can reuse in multiple designs](content-blocks.md)

### Divider elements

Divider elements insert a horizontal line (&lt;hr&gt;) in a column, outside a text element.

Use the **Properties** and **Style** tabs to establish the appearance of your new or selected divider.

When you select a divider element, you can use an inline toolbar to delete, clone, or move the element.

### Button elements

Button elements create a colorful call-to-action button in a column, outside a text element. Each button is created by using pure HTML text and styling only (no image files), and acts as a link to the URL you define for it.

Use the **Properties** tab to establish the appearance of your new or selected button.

When you select a button element, you can use an inline toolbar to style the button text and to delete, clone, or move the element.

## Email-only design elements

This section describes design elements that are only available when you are designing a marketing email message.

<a name="event-elements"></a>

### Marketing-page, event, and survey elements

Each of these types of elements creates a colorful button in a new row (outside a text element) that links to a page, event, or survey (depending on the element type). The button is created using pure HTML text and styling only (no image files), and acts as a link to the page, event, or survey you define for it.

Use the **Properties** tab to establish the appearance of your new or selected button, and to choose the page, event, or survey it links to.

## The form element for marketing pages

This section describes the form element, which is only available when you are designing a marketing page. This is currently the only element that is unique for marketing pages.

A form enables visitors to register for something, manage their mailing-list subscriptions, forward a marketing message, or otherwise submit information to interact with your marketing initiatives.

After it is configured, each form element places a *marketing form*, which defines the actual fields and field layout that the form will contain. You'll define your marketing forms separately, and build a library of reusable forms that you can place on various marketing pages as needed. When you add a form element, you'll be able to choose from this library to decide which form to use on the current page. The form element also provides settings on its **Properties** tab that control how the form will behave and appear on the current page. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create, view, and manage marketing forms](marketing-forms.md)

To configure a form element, select it in your layout, open the **Properties** tab, and make the following settings:

- **Marketing form**: Choose the marketing form to be placed by the form element. Usually, you'll just use an existing form, but you can also create a new one from here if needed. You can only select or create a marketing form that matches the current page type.
- **Update contacts/leads:** This is a read-only field that shows whether the selected marketing form is set to update contacts and/or leads in response to form submissions.
- **Confirmation message**: Enter a message to show to visitors right after they submit the form. Use this to thank the submitter and confirm their submission.
- **Error message**: Enter a short message that tells the user that a temporary error has prevented the system from accepting the form submission. For example, "We can't accept your form submission right now. Please try again later."
- **Limit exceeded message**: Enter a short message announcing that the system has stopped processing new submissions temporarily, and inviting the user to try again later. This situation can occur if the server detects a submission pattern consistent with abuse of the system and has therefore entered a defensive stance.
- **Redirect URL**: Enter a URL to send the submitter to immediately after they submit the form. This typically would be a page on your own website that thanks the submitter and confirms their submission, or some other message related to the purpose of your marketing page.

<a name="form-content-elements"></a>

## Design elements for forms

The designer provides many elements that are unique to marketing forms. They are all related to positioning and configuring various types of input fields and form controls.

### Field elements

Each field element creates a single form control (such as an input field, check box, or radio button set) that is mapped to the contact and/or lead entity in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. For each marketing-form field that you've set up, you'll find a unique component named after the field under the **Fields** heading of the designer's **Toolbox** tab. So, for example, if you've mapped the **First Name** field of the contact entity to a marketing-form field called "First Name", you'll also have field element called **First Name** under the **Fields** heading of the form designer. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create, view, and manage marketing forms](marketing-forms.md)

![Field-element settings](media/field-block-details.png "Field-element settings")

When you add or select a field in your form, you can read and set the following properties on the **Properties** tab:

- **Name**: Shows the name of the field mapping this element represents (read-only).
- **Label Position**: Describes the position of the field label relative to the field (No label, At top, On left, On right).
- **Label**: Shows the field-label text to display for the field.
- **Default Value**: Shows the default value for the field (optional).
- **Placeholder**: Displays "ghost text" in the field until a value is entered, typically shown in a gray color. You can use this as an alternative to, or in addition to, the field label. This isn't a default value because if the user doesn't enter a value, the field is submitted as blank.
- **Required**: Marks the field as mandatory. Mandatory fields display an asterisk in the form, and the form will be rejected if somebody tries to submit it without filling out all the required fields.
- **Required Error Message**: Specifies the error message shown if somebody tries to submit the form without filling out all the required fields.
- **Prefill**: Select this box to enable prefilling for this field. When enabled, the form will try to display a prefilled value for this field when it recognizes the visitor (because the visitor previously submitted a form with the remember-me box checked).

### Subscription-list elements

Each subscription-list element creates a check box that a visitor can select to subscribe to, or unsubscribe from, one of your mailing lists. For each static marketing list that you've configured as a subscription list, you'll find a unique element named after that list under the **Subscription Lists** heading of the designer's **Toolbox** tab. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Set up subscription lists and subscription centers](set-up-subscription-center.md)

Subscription list elements are only available when you are working with a subscription center or landing page form, and their behavior is slightly different in each case:

- **Landing pages**: When the form is submitted, the contact is added to all lists that are checked, but is not removed from lists that are unchecked. You can choose the default value (checked or unchecked) for each list as needed. Subscription lists on landing pages aren't prefilled to indicate the visitor's current subscriptions.
- **Subscription centers**: When the form is opened, each check box is always prefilled to indicate the current visitor's subscriptions. When the form is submitted, the contact is added to all lists that are checked, *and removed* from lists that are unchecked.

When you add or select a subscription-list element for a form, you can read and set the following in properties on the **Properties** tab:

- **Subscription List**: Shows the name of the subscription list the element represents (read-only). You can click here to open the list itself.
- **Default Value**: This is only available if you are working with a landing-page form. Use it to set the default state of the check box (checked or unchecked).
- **Label Position**: Position of the label (list name) relative to the check box.
- **Label**: The name of the subscription list, as shown on the form.

### Forward-to-a-friend elements

Forward-to-a-friend elements create a collection of input fields that recipients of your marketing email messages can use to forward a copy of that message to each email address that they specify.

All forward-to-a-friend forms must include exactly one forward-to-a-friend element. This element is not available for other types of forms.

When you add or select a forward-to-a-friend element in your form, you can read and set the following in properties on the **Properties** tab:

- **Ask for friend's name**: Controls whether to include a field for entering names in addition to email addresses. The form always requests email addresses.
- **Number of recipients**: Sets the number of name/email input pair fields created by the element.

### Do-not-bulk-email elements

Do-not-bulk-email elements add a check box to a subscription center form that enables visitors to opt out of all marketing email messages. This feature is required by law in many jurisdictions, and helps maintain your organization's email reputation throughout the internet, thus helping to keep your marketing messages from getting filtered away or stuck in spam traps.

All subscription center forms must include exactly one do-not-bulk-email element. You can also include this element in landing-page forms, but it's not required.

The do-not-bulk-email element is a standard form-field element that is permanently configured to map to the "Do not bulk email" field of the contact entity. Other than this, all its properties are the same as those for standard field elements, as described in [Field elements](#field-elements).

### Remember-me elements

Remember-me elements add a remember-me feature to your form. If a visitor submits a form with the remember-me box selected, the form will be prefilled with known values the next time they open one of your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] forms (while using that same computer and browser). Only the fields specifically configured to allow prefilling will be filled the next time. You should always include a design element of this type on marketing pages that are enabled for prefilling. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Field elements](#field-elements)

The remember-me element is a standard form-field element that is permanently configured to map to the "Allow form prefill" field of the contact entity. Other than this, all its properties are the same as those for standard form fields, as described in [Field elements](#field-elements).

### Submit-button elements

Submit-button elements create a submit button for the form. All forms must include exactly one of these. Its only property is the button text, which establishes the text shown on the button.

[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] automatically adds a submit-button element to each new form you create. This type of element is not otherwise available in the **Toolbox**, so you should take care not to delete it from your forms because there is no way to add it again (other than immediate undo).

### Reset-button elements

Reset-button elements create a reset button for the form, which when selected removes all values for all fields in that form. All forms must include exactly one of these. Its only property is the button text, which establishes the text shown on the button.

Reset-button elements are only available when you are working with a forward-to-a-friend or landing-page form.

### Captcha elements

Captcha elements add a captcha to your form, which helps make sure that only humans can submit the form, thus preventing bots from filling your database full of spam or noise.

![A captcha element and its settings](media/captcha-block.png "A captcha element and its settings")

You've probably seen captchas before. They require you to recognize and repeat a set of characters designed to be difficult for a computer to recognize.

The only property for captcha elements is the **Language**, which sets the language used in the instructions displayed for the captcha.

Captcha elements are only available when you are working with a landing-page form. Forwarding pages and subscription centers don't need a captcha because they are only available to registered contacts.

### See also

[Design your digital content](design-digital-content.md)  
[Accessibility and keyboard shortcuts](designer-shortcuts.md)  
[Prepare marketing email messages](prepare-marketing-emails.md)  
[Work with email, page, and form templates](email-templates.md)  
[Create and deploy marketing pages](create-deploy-marketing-pages.md)  
[Create, view, and manage marketing forms](marketing-forms.md)  
[Create and manage input fields for use in forms](marketing-fields.md)
