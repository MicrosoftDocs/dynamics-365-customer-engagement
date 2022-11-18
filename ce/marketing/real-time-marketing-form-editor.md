---
title: "How to create and manage real-time marketing forms | Microsoft Docs"
description: "Learn how to use create and manage forms in Dynamics 365 Marketing."
ms.date: 10/12/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: petrjantac
ms.author: petrjantac
manager: petrjantac
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Create and manage forms in real-time marketing

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
>
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

A marketing form is an inbound communication channel that allows your customers to register for newsletters, ask for quotations, etc. The form is defined by a set of input fields arranged into a form layout.

Each marketing form is made from a collection of fields, buttons, graphical elements, and a few configuration settings. Each field included in your form is linked to an attribute of entity in Dynamics 365 Marketing.

The real-time marketing form editor allows you to easily and quickly create and publish forms.

## Comparison of real-time and outbound marketing forms

- The main difference is that real-time marketing form can update only one entity (typically lead or contact). This makes the form configuration and maintenance easier and allows to build properly targeted journeys.

- There is no need to create Marketing fields for real-time marketing forms. All entity attributes are already available as fields to be used in form.

- Real-time marketing form can not be used in outbound marketing pages. But you can publish a form as a standalone page, which will be hosted on Power Portals.

- It is no longer needed to create form page to embed your form into a web page. You can get the form embedding code snippet on one click.

- Published real-time marketing forms are hosted on Content Delivery Network (CDN), which significantly reduces the form load time for the page visitor.

- Real-time marketing journey orchestration: Please use "Marketing Form Submitted" trigger for journeys based on real-time marketing forms. The trigger for outbound marketing forms has been renamed to "Marketing Form Submitted (Outbound)".

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

## Create a new form

To create a new form, go to Real-time marketing > Channels > Forms and select New on the command bar.

1. **Select target audience** that will be updated by the form submission. With real-time marketing form you can select which audience you want to update between Contact and Lead. Each The target audience has a default strategy for duplicate records handling:

    - Lead - each form submission will create a new record, even if the same email address is used.
    - Contact - if a record with the same email address already exists, it will be updated. No duplicated contact will be created if the same email address is used.

    You can change the duplicate record handling in [form settings](#form-settings).

    Enter a name of your new form and select Contact as the target audience.

    > [!div class="mx-imgBorder"]
    > ![Select target audience for the form submission.](media/real-time-marketing-form-audience.png)

1. **Choose a template.** The list of templates is filtered according to the target audience selected in the previous step. You can skip the template selection to start with a blank form. After you select a template or choose to skip, you’ll be in the form editor, where you can finish creating your form.

    > [!div class="mx-imgBorder"]
    > ![Choose a template or skip the selection.](media/real-time-marketing-form-template-gallery.png)

1. Now you can see the list of questions represented by **form fields**. The list of available fields can be found in the right pane and it includes all attributes of the selected target audience (entity). If you create a new custom attribute for the entity, it will be visible in this list and you can immediately use it as a field in your form. You can use the search bar in the list of fields to filter the field you are looking for.

    Enter "name" into the search bar to find the "Last Name" field.

    Note: You can switch between Elements and Fields using the small icons on the side of right pane.

    > [!div class="mx-imgBorder"]
    > ![Filter the list of fields.](media/real-time-marketing-form-last-name.png)

1. **Drag a field from the list and drop it on the form canvas**. Once the field is added, you will see the field's properties in the right pane. The field properties can be used to set required field, configure validation and more. Learn more about [form field properties](#form-field-properties). There are multiple types of fields available with different properties, check the list of [field types](#field-types).

    > [!div class="mx-imgBorder"]
    > ![Field properties are opened once you add a field to the form.](media/real-time-marketing-form-properties.png)

    **Useful tips**
    - You can drag & drop a field on the form canvas to change its position.
    - The field can be removed from the form by clicking on the trash icon.
    - You can hide a field so it isn't visible to you web page visitor by enabling the toggle Hide field.
    - You can access the field properties again by clicking on the field in canvas.

1. You can directly **change the field label** by clicking it on the canvas or in the right pane. The same applies for the placeholder text. It is recommended to change the text on the canvas, as you can use the rich text editor there.

    > [!div class="mx-imgBorder"]
    > ![Change the field label.](media/real-time-marketing-form-last-name-title.png)

1. If you like to build more complex forms, you can change layout of your form into multi-column one and create multiple layout sections. Click on the Elements section in the right pane. Now you you can drag and drop column layout on form canvas to create a new section. You can add elements as well as fields into the newly created sections.

    > [!div class="mx-imgBorder"]
    > ![Set layout and sections for your form.](media/real-time-marketing-form-layouts.png)

1. **Add elements like submit button, images and static text** to your form. Select Elements section in the right pane. Drag & drop static text or image element on the form canvas.

    Drag & drop the Submit button to your form canvas. The form editor will not allow to publish a form without Submit button. Click the Submit button to change the styling.

    > [!div class="mx-imgBorder"]
    > ![Add elements to the form .](media/real-time-marketing-form-elements.png)

1. **Add consent control** from Elements section to your form. Once you add the consent control to your form, you can select the correct consent purpose in the properties. Click on the consent checkbox caption to change its text.

    > [!div class="mx-imgBorder"]
    > ![Add consent element to the form.](media/real-time-marketing-form-consent-element.png)

1. Now it's time to **preview your form** and check the responsiveness. Click the Preview and test tab to open the form preview. You can select various platforms to check how the form will be rendered on mobile device or tablets.

    > [!div class="mx-imgBorder"]
    > ![Preview the form.](media/real-time-marketing-form-preview.png)

1. Click the **Publish** button in the top right corner to publicly share your form. The form will be automatically saved and the [validation process](#form-validation) will start. You will need to add Email field to your form to pass the validation, as the email field is required to check if the same contact already exists by default. Once the form is successfully validated you will see the following options how to publish your form. Learn more how to [publish form](#publish-form). You can now copy the JavaScript code snippet to embed the form into your web page.

    > [!div class="mx-imgBorder"]
    > ![Publish the form.](media/real-time-marketing-form-publish.png)

1. Make sure the domain where you embedded your form is allowed for external form hosting. If the domain is not allowed for external form hosting, the form will not be rendered on your web page and all form submission would be rejected. Learn more about [domain authentication](real-time-marketing-domain.md).
Power Pages domains are allowed for external form hosting by default.

1. Set up a "thank you" email for web page visitors who submitted the form. You can create a new journey using the "Marketing Form Submitted" trigger, which will be executed every time your form is submitted. Learn more about [trigger-based journey](real-time-marketing-trigger-based-journey.md).

## Manage forms

### Publish form

Click the Publish button in the top right corner to publish your form. There are three options to publish a form:

- **Embed to external page using JavaScript** - this is the most common way how to integrate the form into your own web page. You can reuse the same code snippet on multiple web pages. The form submission data includes the URL of the page where the form is embedded. There is also tracking script included to count the statistics of visitors of your page with the form embedded.
- **Embed to external page using iframe** - the iframe has several limitations, but it is the first choice if you are restricted to use external JavaScript code on your web pages. You can reuse the same iframe code snippet on multiple web pages. Due to the nature of iframe the form submission data does not include the URL of the page where the form is embedded.
- **Create standalone page** - this feature requires PowerApps or Power Pages license. Power Portal page will be automatically created and the form will be embedded into this page. As a result of this process you will get a public URL, which you can share to allow your visitors to visit and submit the form.

Once the form is published you can still access these options by clicking Publishing options button in the top right corner. It's possible to use multiple publishing options for a single form.

### Edit live form

If your form has been already published and you need to update it, click the Edit button on the top ribbon. You can continue editing your live form, all changes will be automatically published once you click the Save button.

> [!IMPORTANT]
> If you choose to create a copy of the form, you will have to publish the newly created copy.

### Unpublish form

Click the Stop button to unpublish a live form. The form will be removed from the CDN, so you web page visitors will no longer be able to see it. The form status will be changed to Draft.

### Form field properties

Once you click on a field on canvas, you will be able to see it's properties in the right pane.
> [!div class="mx-imgBorder"]
> ![Field properties are opened once you add a field to the form.](media/real-time-marketing-form-properties.png)

- **Label** - the field caption visible to the user.
- **Placeholder text** - the placeholder inside the field. Placeholder will automatically disappear once the user starts typing into the field.
- **Required** - if enabled, the user can not submit the form if this field is empty.
- **Default value** - set the default value for this field. Placeholder will not be visible if the default value is set.
- **Error message** - set error message that will be shown if the field validation fails.
- **Validation** - configure a rule that will check the content of the field. If the validation rule is not met, the user won't be able to submit the form.
- **Hide field** - if enabled, the field will not be visible in the form. You can use hidden fields to store additional meta data along with the form submission.

#### Custom validation

You can enable the **Validation** and select **Custom**. This will open a pop-up dialog, where you can enter a Regular Expression (RegExp). You can for example use RegExp to check if the entered value matches a specific format of phone number.

### Form Settings

Form settings allow you to configure advanced properties of your form and define what happens after the form submission.
> [!div class="mx-imgBorder"]
> ![Field properties are opened once you add a field to the form.](media/real-time-marketing-form-settings.png)

- **Duplicate records** - choose your strategy [how to handle duplicate records](#how-to-handle-duplicate-records)
- **Thank you notification** - this message will appear if the user successfully submits the form.
- **Error notification** - this message will appear if an error occurs when the form is submitted.
- **Redirect after submission** - if enabled, you can enter a URL to which the user will be redirected after the form submission.

#### How to handle duplicate records

**ToDo**

### Field types

#### Lookup

**ToDo**

### Form validation

The validation process is automatically launched along with form publishing and it checks the following aspects:

- Does the form include all fields linked to attributes of selected entity which are mandatory to create or update a record.
- Is the Submit button included.
- Are the form fields linked to an editable attribute.
- Does the form contain duplicates.
- Does the form include all attributes required by matching strategy (Email field by default).
- Is the target audience set.
- Are all required attributes labeled as required="required" in html.

The form validation process can be also launched manually using the Check content button.

**Important ToDo**

- OOB fields are filtered

## Troubleshooting

### Embedded form is not visible on my page

Make sure that your domain is allowed for external form hosting.

**ToDo**

### Publish form as standalone page fails

Not available on trial


**ToDo**

## Security notice

The security is an important aspect of forms. We take the following precautions to avoid any security risks:

- D365 Marketing accepts form submissions only from domains allowed for external form hosting.
- We have necessary precautions in the infrastructure to minimize the impacts of a possible DDoS attack.