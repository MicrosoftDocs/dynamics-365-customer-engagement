---
title: "Preview: Create and manage real-time marketing forms | Microsoft Docs"
description: "Learn how to use create and manage forms in Dynamics 365 Marketing."
ms.date: 12/12/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: petrjantac
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

# Preview: Create and manage forms in real-time marketing

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
>
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

> [!NOTE]
> **Public preview known limitations**
>
> - The real-time marketing form editor relies on a new consent model. It might take up to 48 hours for consent data migration to be completed after your organization is upgraded to the latest version. Otherwise, the consent contact point won’t be created after the form is submitted. [Learn more](whats-new-marketing.md#december-2022-update).
> - All phone number and email fields must be marked as required and phone number field validation must be enabled in the form editor.
> - The commercial communication consent purpose isn't linked to the *Do not bulk email* attribute of the Contact.

A marketing form is an inbound communication channel that allows your customers to register for newsletters, ask for quotations, etc. The form is defined by a set of input fields arranged into a form layout.

Each marketing form is made from a collection of fields, buttons, graphical elements, and a few configuration settings. Each field included in your form is linked to an attribute of an entity in Dynamics 365 Marketing.

The real-time marketing form editor allows you to easily and quickly create and publish forms.

## Enable the real-time marketing forms preview

1. Go to **Settings** > **Overview** > **Feature switches**.
1. Enable/disable the **Real-time marketing forms (preview)** feature switch toggle.

## Create a new form

To create a new form, go to **Real-time marketing** > **Channels** > **Forms** and select **New** on the command bar.

1. **Select target audience** that will be updated by the form submission. With real-time marketing form, you can select which audience you want to update between Contact and Lead. Each The target audience has a default strategy for duplicate records handling:

    - Lead - each form submission will create a new record, even if the same email address is used.
    - Contact - if a record with the same email address already exists, it will be updated. No duplicated contact will be created if the same email address is used.

    You can change the duplicate record handling in [form settings](#form-settings).

    Enter a name of your new form and select Contact as the target audience.

    > [!div class="mx-imgBorder"]
    > ![Select target audience for the form submission.](media/real-time-marketing-form-audience.png)

1. **Choose a template.** The list of templates is filtered according to the target audience selected in the previous step. You can skip the template selection to start with a blank form. After you select a template or choose to skip, you’ll be in the form editor, where you can finish creating your form.

    > [!div class="mx-imgBorder"]
    > ![Choose a template or skip the selection.](media/real-time-marketing-form-template-gallery.png)

1. Now you can see the list of questions represented by **form fields**. The list of available fields can be found in the right pane and it includes all attributes of the selected target audience (entity). If you create a new custom attribute for the entity, it will be visible in this list, and you can immediately use it as a field in your form. Some system fields may be hidden, as they can't be used in form. You can use the search bar in the list of fields to filter the field you're looking for.

    Enter "name" into the search bar to find the "Last Name" field.

    Note: You can switch between Elements and Fields using the small icons on the side of right pane.

    > [!div class="mx-imgBorder"]
    > ![Filter the list of fields.](media/real-time-marketing-form-last-name.png)

1. **Drag a field from the list and drop it on the form canvas**. Once the field is added, you'll see the field's properties in the right pane. The field properties can be used to set required field, configure validation and more. Learn more about [form field properties](#form-field-properties). There are multiple types of fields available with different properties, check the list of [field types](#field-types).

    > [!div class="mx-imgBorder"]
    > ![Field properties are opened once you add a field to the form.](media/real-time-marketing-form-properties.png)

    **Useful tips**
    - You can drag & drop a field on the form canvas to change its position.
    - The field can be removed from the form by clicking on the trash icon.
    - You can hide a field so it isn't visible to your web page visitor by enabling the toggle Hide field.
    - You can access the field properties again by clicking on the field in canvas.

1. You can directly **change the field label** by clicking it on the canvas or in the right pane. The same applies for the placeholder text. It's recommended to change the text on the canvas, as you can use the rich text editor there.

    > [!div class="mx-imgBorder"]
    > ![Change the field label.](media/real-time-marketing-form-last-name-title.png)

1. If you like to build more complex forms, you can **change layout of your form** into multi-column one and create multiple layout sections. Select the Elements section in the right pane. Now you can drag and drop column layout on form canvas to create a new section. You can add elements and fields into the newly created sections.

    > [!div class="mx-imgBorder"]
    > ![Set layout and sections for your form.](media/real-time-marketing-form-layouts.png)

1. **Add elements like submit button, images and static text** to your form. Select Elements section in the right pane. Drag & drop static text or image element on the form canvas.

    Drag & drop the Submit button to your form canvas. The form editor won't allow you to publish a form without Submit button. Click the Submit button to change the styling.

    > [!div class="mx-imgBorder"]
    > ![Add elements to the form .](media/real-time-marketing-form-elements.png)

1. **Add consent control** from Elements section to your form. Once you add the consent control to your form, you can select the correct consent purpose in the properties. Select the consent checkbox caption to change its text. Learn more about how to [Manage consent for email and text messages in real-time marketing](real-time-marketing-email-text-consent.md).

    > [!div class="mx-imgBorder"]
    > ![Add consent element to the form.](media/real-time-marketing-form-consent-element.png)

1. Now it's time to **preview your form** and check the responsiveness. Select the Preview and test tab to open the form preview. You can select various platforms to check how the form will be rendered on mobile device or tablets.

    > [!div class="mx-imgBorder"]
    > ![Preview the form.](media/real-time-marketing-form-preview.png)

1. Click the **Publish** button in the top right corner to publicly share your form. The form will be automatically saved and the [validation process](#form-validation) will start. You'll need to add Email field to your form to pass the validation, as the email field is required to check if the same contact already exists by default. Once the form is successfully validated, you'll see the following options how to publish your form. Learn more how to [publish form](#publish-form). You can now copy the JavaScript code snippet to embed the form into your web page.

    > [!div class="mx-imgBorder"]
    > ![Publish the form.](media/real-time-marketing-form-publish.png)

1. Make sure the domain where you embedded your form is allowed for external form hosting. If the domain isn't allowed for external form hosting, the form won't be rendered on your web page, and all form submission would be rejected. Learn more about [domain authentication](real-time-marketing-domain.md).
Power Pages domains are allowed for external form hosting by default.

1. Set up a "thank you" email for web page visitors who submitted the form. You can create a new journey using the "Marketing Form Submitted" trigger, which will be executed every time your form is submitted. Learn more about [trigger-based journey](real-time-marketing-trigger-based-journey.md).

## Manage forms

### Publish form

Click the Publish button in the top right corner to publish your form. There are three options to publish a form:

- **Embed to external page using JavaScript** - the most common way how to integrate the form into your own web page. You can reuse the same code snippet on multiple web pages. The form submission data includes the URL of the page where the form is embedded. There's also tracking script included to count the statistics of visitors of your page with the form embedded.
- **Embed to external page using iframe** - the iframe has several limitations, but it's the first choice if you're restricted to use external JavaScript code on your web pages. You can reuse the same iframe code snippet on multiple web pages. Due to the nature of iframe, the form submission data doesn't include the URL of the page where the form is embedded.
- **Create standalone page** - this feature requires PowerApps or Power Pages license. Power Portal page will be automatically created and the form will be embedded into this page. As a result of this process you'll get a public URL, which you can share to allow your visitors to visit and submit the form.

Once the form is published, you can still access these options by clicking Publishing options button in the top right corner. It's possible to use multiple publishing options for a single form.

### Edit live form

If your form has been already published and you need to update it, click the Edit button on the top ribbon. You can continue editing your live form, all changes will be automatically published once you click the Save button.

> [!IMPORTANT]
> If you choose to create a copy of the form, you will have to publish the newly created copy.

### Unpublish form

Click the Stop button to unpublish a live form. The form will be removed from the CDN, so you web page visitors will no longer be able to see it. The form status will be changed to Draft.

### Form field properties

Once you select a field on canvas, you'll be able to see its properties in the right pane.
> [!div class="mx-imgBorder"]
> ![Field properties are opened once you add a field to the form.](media/real-time-marketing-form-properties.png)

- **Label** - the field caption visible to the user.
- **Placeholder text** - the placeholder inside the field. Placeholder will automatically disappear once the user starts typing into the field.
- **Required** - if enabled, the user can't submit the form if this field is empty.
- **Default value** - set the default value for this field. Placeholder won't be visible if the default value is set.
- **Error message** - set error message that will be shown if the field validation fails.
- **Validation** - configure a rule that will check the content of the field. If the validation rule isn't met, the user won't be able to submit the form. It's important to set the correct validation for email and phone number fields.
- **Hide field** - if enabled, the field won't be visible in the form. You can use hidden fields to store extra meta data along with the form submission.

#### Custom validation

You can enable the **Validation** and select **Custom**. A pop-up dialog will appear, where you can enter a Regular Expression (RegExp). You can, for example, use RegExp to check if the entered value matches a specific format of phone number.

### Form Settings

Form settings allow you to configure advanced properties of your form and define what happens after the form submission.
> [!div class="mx-imgBorder"]
> ![Form settings.](media/real-time-marketing-form-settings.png)

- **Duplicate records** - choose your strategy [how to handle duplicate records](#how-to-handle-duplicate-records)
- **Thank you notification** - this message will appear if the user successfully submits the form.
- **Error notification** - this message will appear if an error occurs when the form is submitted.
- **Redirect after submission** - if enabled, you can enter a URL to which the user will be redirected after the form submission.

#### How to handle duplicate records

The default approach to duplicate records is different for contacts and leads.

- **Contact (default: Update contact using email)**
If the user submits a form with an existing email address, the existing record will be updated by the form submission. There will be no new record created.

- **Lead (default: Always create new record)**
If the user submits a form with an existing email address, there will be a new record with the same email address created.

You can change the default strategy using Duplicate records drop-down in Forms settings. You can also create your [custom matching strategy](#create-custom-matching-strategy).

##### Create custom matching strategy

It's possible to create own strategy how to handle duplicate records by creating a new Matching strategy. Select the bottom left menu to access Settings. Open Form matching strategy in Customer engagement section. Click plus icon to create a new matching strategy. Name the matching strategy and select Target entity. Save the matching strategy (don't click Save & close, as you need to stay on this record). Now add Matching strategy attributes (fields) that will be used to check if the record exists. Save your new matching strategy. Now you can see it in the list Duplicate records in Form settings.

### Field types

The field type and format are defined by the attribute meta data and it isn't possible to change them. You can change the Rendering control for field types where the format isn't defined.

| **Type**  | **Format** | **Rendering control** | **Description**|
|-----------|------------|-----------------------|----------------|
| Single line of text    | Email         | Email Input, Text Box               | Simple input field that accepts values that resemble an email address.                                                                                                           |
| Single line of text    | Text          | Text Box              | Simple input field that accepts all types of text values.                                                                                                                         |
| Single line of text    | Text Area     | Text Area             | Text area input field that accepts all types of text values.                                                                                                                     |
| Single line of text    | URL           | URL&nbsp;Input             | Simple input field that accepts values that resemble a URL.                                                                                                                      |
| Single line of text    | Phone         | Phone&nbsp;Input           | Simple input field that accepts values that resemble a phone number.                                                                                                             |
| Number           | n/a           | Number&nbsp;Input          | Simple input field that accepts a number.                                                                                                                     |
| Option set             | n/a           | Radio Buttons         | Field with a limited number of predefined values (as defined in the database). Rendered as a set of radio buttons, with one button for each value.                                  |
| Option set             | n/a           | Drop-down              | Field with a limited number of predefined values (as defined in the database). Rendered as a drop-down list for selecting a value.                                                  |
| Two options            | n/a           | Check box              | Boolean field, which accepts a value of either true or false. Rendered as a check box, which is selected when true and clear when false.                                              |
| Two options            | n/a           | Radio&nbsp;Buttons         | Field that accepts one of just two possible values (typically true or false). Rendered as a pair of radio buttons, with the display text for each defined in the database.           |
| Date and time          | Date Only     | Date Picker           | Date picker, which lets users choose a date from a pop-up calendar display. Doesn't accept a time.                                                                           |
| Date and time          | Date and Time | Date-Time Picker      | Date and time picker, which lets users choose a date from a pop-up calendar and a time from a drop-down list.                                                                   |
| Lookup field          | n/a | Lookup      | Lookup field is linked to a particular entity type, enabling you to add a drop-down list of options that were created in advance to your form. [More information](#lookup). |

#### Lookup

Lookup field is linked to a particular entity type, enabling you to add a drop-down list of options that were created in advance to your form. For example, you could use a lookup field Currency to show a drop-down list of all currencies in your form. After adding a lookup field, or if your lookup field isn't working, ensure that the service user has permissions set up for the entities you're using with the lookup field. More information: [Adding lookup fields](marketing-fields.md#adding-lookup-fields-and-troubleshooting).

### Form validation

The validation process is automatically launched along with form publishing and it checks the following aspects:

- Does the form include all fields linked to attributes of selected entity, which are mandatory to create or update a record?
- Is the Submit button included?
- Are the form fields linked to an editable attribute?
- Does the form contain duplicates?
- Does the form include all attributes required by matching strategy (Email field by default)?
- Is the target audience set?
- Are all required attributes labeled as required="required" in html?

The form validation process can be also launched manually using the Check content button.

### Advanced customization of form

Click the HTML button in the top right corner to open the HTML editor and to display the source code of the form.

#### Customize CSS

You can change the CSS classes definition in the HTML editor. This allows you to achieve more advanced design customizations on top of the possibilities of the form editor.

#### Add custom JavaScript to your form

You can add your custom JavaScript code into the HTML source code using the HTML editor.

## Troubleshooting

### Embedded form is not visible on my page

Make sure that your domain is allowed for external form hosting. You don't need to finish the domain authentication process to enable external form hosting for your domain. Learn more about [domain authentication](real-time-marketing-domain.md).

### Publish form as standalone page fails

This feature isn't available on trial. You need to have the Power Pages or Power App Portals license to use this feature.
Make sure your Power Portal is correctly provisioned with Marketing app.

## Comparison of real-time and outbound marketing forms

- The main difference is that real-time marketing form can update only one entity (typically lead or contact). Targeting single entity makes the form configuration and maintenance easier and it allows you to build properly targeted journeys.

- There's no need to create Marketing fields for real-time marketing forms. All entity attributes are already available as fields to be used in form.

- Real-time marketing form can't be used in outbound marketing pages. But you can publish a form as a standalone page, which will be hosted on Power Portals.

- It's no longer required to create form page to embed your form into a web page. You can get the form embedding code snippet on one click.

- Published real-time marketing forms are hosted on Content Delivery Network (CDN), which significantly reduces the form load time for the page visitor.

- Real-time marketing journey orchestration: Use "Marketing Form Submitted" trigger for journeys based on real-time marketing forms. The trigger for outbound marketing forms has been renamed to "Marketing Form Submitted (Outbound)".

- It's not possible to edit outbound marketing forms in the real-time marketing form editor and vice versa.

### Form types comparison

The following table summarizes types of forms currently available in real-time marketing. More form types will be available soon.

| form type in outbound marketing | form type in real-time marketing |  
|---|---|
| Landing page form  | Marketing form  |
| Subscription center form | Preference center (will be available as part fo Consent configuration) |
| Event registration form | N/A |
| External form submission capture | N/A |
| Refer to friend | N/A |

## Security notice

The security is an important aspect of forms. We take the following precautions to avoid any security risks:

- Dynamics 365 Marketing accepts form submissions only from domains allowed for external form hosting.
- We have necessary precautions in the infrastructure to minimize the impacts of a possible DDoS attack.
