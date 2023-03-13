---
title: "Preview: Create and manage real-time marketing forms | Microsoft Docs"
description: "Learn how to use create and manage forms in Dynamics 365 Marketing."
ms.date: 03/10/2023
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
> - The real-time marketing form editor relies on a new consent model. It might take up to 48 hours for consent data migration to be completed after your organization is upgraded to the latest version. Otherwise, the consent contact point won’t be created after the form is submitted. [Learn more](whats-new-marketing-archive.md#december-2022-update).
> - All phone number and email fields must be marked as required and phone number field validation must be enabled in the form editor.
> - The commercial communication consent purpose isn't linked to the *Do not bulk email* attribute of the Contact.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE5dqbE]

A marketing form is an inbound communication channel that allows your customers to register for newsletters, ask for quotations, etc. The form is defined by a set of input fields arranged into a form layout.

Each marketing form is made from a collection of fields, buttons, graphical elements, and a few configuration settings. Each field included in your form is linked to an attribute of an entity in Dynamics 365 Marketing.

The real-time marketing form editor allows you to easily and quickly create and publish forms.

## Enable the real-time marketing forms preview

1. Go to **Settings** > **Overview** > **Feature switches**.
1. Enable/disable the **Real-time marketing forms (preview)** feature switch toggle.

## Create a new form

To create a new form, go to **Real-time marketing** > **Channels** > **Forms** and select **New** on the command bar.

1. **Select a target audience** that will be updated by the form submission. With real-time marketing forms, you can select which audience you want to update (Contact or Lead). Each target audience has a default strategy for duplicate records handling:

    - **Lead**: Each form submission will create a new record, even if the same email address is used.
    - **Contact**: If a record with the same email address already exists, it will be updated. No duplicate contact will be created if the same email address is used.

    You can change the duplicate record handling in the [form settings](#form-settings).

    In this example, you'll enter a name for your new form and select **Contact** as the target audience.

    > [!div class="mx-imgBorder"]
    > ![Select target audience for the form submission.](media/real-time-marketing-form-audience.png)

1. **Choose a template.** The list of templates is filtered according to the target audience selected in the previous step. If you want to start with a blank form, you can skip the template selection. After you select a template or choose to skip, you’ll be in the form editor where you can finish creating your form.

    > [!div class="mx-imgBorder"]
    > ![Choose a template or skip the selection.](media/real-time-marketing-form-template-gallery.png)

1. Now you can see the list of questions represented by **form fields**. The list of available fields can be found in the right pane and it includes all attributes of the selected target audience (entity). If you create a new custom attribute for the entity, it will be visible in this list and you can immediately use it as a field in your form. Some system fields may be hidden, as they can't be used in the form. You can use the search bar in the list of fields to filter the field you're looking for.

    Enter "name" into the search bar to find the "Last Name" field.

    > [!NOTE]
    > You can switch between Elements and Fields using the small icons on the side of the right pane.

    > [!div class="mx-imgBorder"]
    > ![Filter the list of fields.](media/real-time-marketing-form-last-name.png)

1. **Drag a field from the list and drop it on the form canvas**. Once the field is added, you'll see the field's properties in the right pane. The field properties can be used to set if it's a required field, configure validation, and more. Learn more about [form field properties](#form-field-properties). There are multiple types of fields available with different properties, check the list of [field types](#field-types).

    > [!div class="mx-imgBorder"]
    > ![Field properties are opened once you add a field to the form.](media/real-time-marketing-form-properties.png)

    **Useful tips**
    - You can drag and drop a field on the form canvas to change its position.
    - Fields can be removed from the form by selecting the trash icon.
    - You can hide a field so it isn't visible to your web page visitor by enabling the **Hide field** toggle.
    - You can access the field properties again by selecting the field on the canvas.

1. You can directly **change the field label** by selecting it on the canvas or in the right pane. The same applies for placeholder text. It's recommended to change the text on the canvas, as you can use the rich text editor there.

    > [!div class="mx-imgBorder"]
    > ![Change the field label.](media/real-time-marketing-form-last-name-title.png)

1. If would you like to build more complex forms, you can change the layout of your form to multi-column and create multiple layout sections. Select the **Elements** section on the right pane. Now you can drag and drop a column layout on form canvas to create a new section. You can add elements and fields to the newly created sections.

    > [!div class="mx-imgBorder"]
    > ![Set layout and sections for your form.](media/real-time-marketing-form-layouts.png)

1. **Add elements like a submit button, images, and static text** to your form. Select the **Elements** section in the right pane. Drag and drop static text or an image element on the form canvas.

    Drag and drop a **Submit** button to your form canvas. The form editor won't allow you to publish a form without a submit button. Select the submit button to change the styling.

    > [!div class="mx-imgBorder"]
    > ![Add elements to the form .](media/real-time-marketing-form-elements.png)

1. **Add consent control** from the **Elements** section to your form. Once you add the consent control to your form, you can select the correct consent purpose in the properties. Select the consent checkbox caption to change its text. Learn more about how to [manage consent for email and text messages in real-time marketing](real-time-marketing-email-text-consent.md).

    > [!div class="mx-imgBorder"]
    > ![Add consent element to the form.](media/real-time-marketing-form-consent-element.png)

1. Now it's time to **preview your form** and check the responsiveness. To open the form preview, select the **Preview and test** tab to open the form preview. You can select various platforms to check how the form will render on a mobile device or a tablet.

    > [!div class="mx-imgBorder"]
    > ![Preview the form.](media/real-time-marketing-form-preview.png)

1. To publicly share your form, select the **Publish** button in the top right corner. The form will automatically save and the [validation process](#form-validation) will start. You'll need to add an **Email** field to your form to pass the validation, as the email field is required to check if the same contact already exists by default. Once the form is successfully validated, you'll see the following options on how to publish your form. Learn more on how to [publish the form](#publish-your-form). You can now copy the JavaScript code snippet to embed the form into your web page.

    > [!div class="mx-imgBorder"]
    > ![Publish the form.](media/real-time-marketing-form-publish.png)

1. Make sure the domain where you embedded your form is allowed for external form hosting. If the domain isn't allowed for external form hosting, the form won't be rendered on your web page and all form submissions will be rejected. Learn more about [domain authentication](domain-authentication.md). Power Pages domains are allowed for external form hosting by default.

1. Set up a "thank you" email for web page visitors who submitted the form. You can create a new journey using the "Marketing Form Submitted" trigger, which will be executed every time your form is submitted. Learn more about creating a [trigger-based journey](real-time-marketing-trigger-based-journey.md).

## Manage forms

### Publish your form

To publish your form, select the **Publish** button in the top right corner. There are three options to publish a form:

- **Embed to an external page using JavaScript**: This is the most common way to integrate the form into your own web page. You can reuse the same code snippet on multiple web pages. The form submission data includes the URL of the page where the form is embedded. There's also a tracking script included to count the statistics of visitors to the page that the form is embedded on.
- **Embed to an external page using iframe**: The IFrame has several limitations, but it's the first choice if you're restricted from using external JavaScript code on your web pages. You can reuse the same IFrame code snippet on multiple web pages. Due to the nature of iframes, the form submission data doesn't include the URL of the page where the form is embedded.
- **Create a standalone page**: This feature requires a PowerApps or Power Pages license. A Power Portal page will be automatically created and the form will be embedded into the page. As a result of this process, you'll get a public URL, which you can share to allow your visitors to visit and submit the form.

Once the form is published, you can still access these options by selecting the **Publishing** options button in the top right corner. It's possible to use multiple publishing options for a single form.

### Edit a live form

If your form has been already published and you need to update it, select the **Edit** button on the top ribbon. You can continue editing your live form and all changes will be automatically published once you select the **Save** button.

> [!IMPORTANT]
> If you choose to create a copy of the form, you will have to publish the newly created copy.

### Unpublish a form

To unpublish a live form, select the **Stop** button. The form will be removed from the content delivery network (CDN), so your web page visitors will no longer be able to see it. The form status will be changed to *Draft*.

### Form field properties

Once you select a field on the canvas, you'll be able to see its properties in the right pane.

> [!div class="mx-imgBorder"]
> ![Field properties are opened once you add a field to the form.](media/real-time-marketing-form-properties.png)

- **Label**: The field caption visible to the user.
- **Placeholder text**: The placeholder inside the field. The placeholder will automatically disappear once the user starts typing into the field.
- **Required**: If enabled, the user can't submit the form if this field is empty.
- **Default value**: Set the default value for this field. The placeholder won't be visible if the default value is set.
- **Error message**: Set the error message that will be shown if the field validation fails.
- **Validation**: Configure a rule that will check the content of the field. If the validation rule isn't met, the user won't be able to submit the form. It's important to set the correct validation for email and phone number fields.
- **Hide field**: If enabled, the field won't be visible in the form. You can use hidden fields to store extra metadata along with the form submission.

#### Custom validation

To create custom validation, enable the **Validation** option and select **Custom**. A pop-up dialog will appear where you can enter a Regular Expression (RegExp). You can, for example, use a RegExp to check if the entered value matches a specific phone number format.

### Form settings

Form settings allow you to configure advanced properties of your form and define what happens after the form submission.

> [!div class="mx-imgBorder"]
> ![Form settings.](media/real-time-marketing-form-settings.png)

- **Duplicate records**: Choose your strategy on [how to handle duplicate records](#how-to-handle-duplicate-records).
- **Thank you notification**: This message will appear if the user successfully submits the form.
- **Error notification**: This message will appear if an error occurs when the form is submitted.
- **Redirect after submission**: If enabled, you can enter a URL to which the user will be redirected after the form submission.

#### How to handle duplicate records

The default approach to duplicate records is different for Contacts and Leads.

- **Contact (default: Update contact using email)**: If the user submits a form with an existing email address, the existing record will be updated by the form submission. There will be no new record created.

- **Lead (default: Always create a new record)**: If the user submits a form with an existing email address, there will be a new record with the same email address created.

You can change the default strategy using the **Duplicate records** drop-down in **Forms** settings. You can also create a [custom matching strategy](#create-a-custom-matching-strategy).

##### Create a custom matching strategy

You can choose how to handle duplicate records by creating a new matching strategy. Select the bottom left menu to access **Settings**. Open **Form matching strategy** in the **Customer engagement** section. To create a new matching strategy, select the plus icon. Name the matching strategy and select the **Target entity**. Save the matching strategy (don't select **Save & close** as you need to stay on this record). Now, add matching strategy attributes (fields) that will be used to check if the record exists. Save your new matching strategy. Now you can see the matching strategy in the **Duplicate records** list in the form settings.

### Field types

Field types and formats are defined by the attribute metadata. It isn't possible to change field types and formats. You can, however, change the rendering control for field types where the format isn't defined.

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
| Lookup field          | n/a | Lookup      | A lookup field is linked to a particular entity type, enabling you to add a drop-down list of options that were created in advance to your form. [More information](#lookup-fields). |

#### Lookup fields

A lookup field is linked to a particular entity type, enabling you to add a drop-down list of options that were created in advance to your form. For example, you could use a lookup field called "Currency" to show a drop-down list of all currencies in your form. After adding a lookup field, or if your lookup field isn't working, ensure that the service user has permissions set up for the entities you're using with the lookup field. More information: [Adding lookup fields](marketing-fields.md#adding-lookup-fields-and-troubleshooting).

### Form validation

The validation process is automatically launched along with form publishing and it checks the following aspects:

- Does the form include all fields linked to attributes of a selected entity that are mandatory to create or update a record?
- Is a **Submit** button included?
- Are the form fields linked to an editable attribute?
- Does the form contain duplicates?
- Does the form include all attributes required by the matching strategy (email field by default)?
- Is the target audience set?
- Are all required attributes labeled as required="required" in HTML?

The form validation process can be also launched manually using the **Check content** button.

### Advanced form customization

To open the HTML editor and display the source code of a form, select the HTML button in the top right corner.

#### Customize form CSS

You can change the CSS class definitions in the HTML editor. This allows you to achieve more advanced design customizations on top of the possibilities in the form editor.

#### Add custom JavaScript to your form

You can add custom JavaScript code to the HTML source code using the HTML editor.

## Troubleshooting

### My embedded form isn't visible on my page

Make sure that your domain is allowed for external form hosting. You don't need to finish the domain authentication process to enable external form hosting for your domain. Learn more about [domain authentication](domain-authentication.md).

### Publishing a form as a standalone page fails

This feature isn't available in trial apps. You need to have a Power Pages or Power App Portals license to use this feature. Make sure your Power Portal is correctly provisioned with the Marketing app.

## Comparison of real-time and outbound marketing forms

- The main difference between real-time and outbound marketing forms is that real-time marketing forms can update only one entity (typically a Lead or Contact). Targeting a single entity makes the form configuration and maintenance easier and it allows you to build properly targeted journeys.

- There's no need to create Marketing fields for real-time marketing forms. All entity attributes are already available as fields to be used in a form.
- A real-time marketing form can't be used in outbound marketing pages. But you can publish a form as a standalone page, which will be hosted on Power Portals.
- You're no longer required to create a form page to embed your form into a web page. You can generate the form embedding code snippet with one click.
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
