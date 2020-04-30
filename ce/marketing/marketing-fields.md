---
title: "Set up input fields to be used in marketing forms (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to set up an form input field and map it to a database field in Dynamics 365 Marketing"
keywords: marketing form, fields
ms.date: 03/08/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
ms.assetid: ff9c1046-2823-460a-ad3b-946ada3a4244
author: alfergus
ms.author: alfergus
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

# Create and manage input fields for use in forms

Each field that appears in a marketing form must map unambiguously to a contact or lead field in your Dynamics 365 database, where values submitted for that field will be stored. When you're designing a form, the **Toolbox** tab of the designer lists a design element for each field that is already set up, so all you need to do to add that field is drag the matching field element to your form (see also [Design your digital content](design-digital-content.md)). The most commonly used fields (such as name, address, and email) are set up by default, but if you want to use additional fields, you must set them up first. Read this topic to learn how to create and manage fields for use in your marketing forms.

> [!IMPORTANT]
> Don't map more than one marketing-form field to the same field in the database. If you do, you may experience issues such as empty drop-down lists for the double-mapped field. If you are having issues related to redundant field mappings, delete all of the redundant fields, create a new one to replace them, and update your forms as needed.

## Create or edit a marketing-form field

To create a new marketing-form field, do one of the following:

- Go to **Marketing templates** > **Form fields** to see the full list of all fields currently available to your organization, and then select **+New** in the command bar. This creates a new, blank field mapping and opens it for editing.

- While working on an existing marketing form, look at the **Toolbox** tab to the right side of the canvas. Under the **Fields** heading here, you'll see a design element for each field that is already set up on your instance. If you don't see the one you want, select **+New** next to the **Fields** heading. A quick-create flyout slides in from the side of the screen, where you can make all the most important settings, and then select **Save**. The new **Field** element is then added to the **Toolbox** tab.

To edit an existing field, go to **Marketing templates** > **Form fields** to see the full list of all fields currently available on your instance. Browse, search, sort, and filter the list to find the field you want to edit, and then select it to open it.

## Marketing-form field configuration

The following table describes all configuration settings that are available for marketing-form fields. All settings are available when working with the field record itself; the quick-create form provided when creating a field from the form designer includes the most important of these settings, but not all of them.


|        **Setting**        |       **Description**      |
|---------------------------|---------------------------|
|         **Name**          |      Name of the form field record. This becomes the name of the element provided in the designer for placing the field. It should almost always match the field name.    |
|         **Type**          |                                                                                                                                 The type of data&mdash;such as text, number, or date&mdash;accepted by the field. More information: [Field type and format options](#field-type-and-format-options)                                                                                                                                 |
|        **Format**         | The format of data accepted by the field. This establishes the validation criteria applied for the field. For example, if you set the format to email, the form will make sure that text entered in that field looks like an email address (includes an at sign (@), and so on). The options available here depend on which **Type** is selected. More information: [Field type and format options](#field-type-and-format-options) |
|   **Rendering control**   |                                                                                                                                              The rendering control presented by the field, such as text box, text area, radio buttons, check box, date picker, and more. The options available here depend on which **Format** is selected.                                                                                                                                               |
|     **Default label**     |                       The default label shown for the field when you add it to a form. You can override this default for any specific form by configuring the field element that creates the input field for that form; you might do this to translate the form to a different language. More information: [The form element for marketing pages](content-blocks-reference.md#the-form-element-for-marketing-pages)                       |
|  **Default placeholder**  |                                                                                                          Defines the "ghost text" shown in the field until a value is entered, typically displayed in a gray color. Use this to indicate what kind of value should be entered. If the user doesn't replace the ghost text by entering a value, the field is submitted as blank.                                                                                                           |
| **Contact field mapping** | Choose the contact field to map to this marketing-form field. Leave this blank to disable contact mapping for this field. You must provide a value for **Contact field mapping**, **Lead field mapping**, or both; you won't be able to save your field mapping without a value in at least one of these fields. |
|  **Lead field mapping**   |                                                                                                                                                                                    Choose the lead field to map to this marketing-form field. Leave this blank to disable lead mapping for this field. You must provide a value for **Contact field mapping**, **Lead field mapping**, or both; you won't be able to save your field mapping without a value in at least one of these fields.  |

## Field type and format options

| **Type**  | **Format** | **Rendering control** | **Description**|
|-----------|------------|-----------------------|----------------|
| Single line of text    | Email         | Email&nbsp;Input<br />Text Box               | Creates a simple input field that accepts values that resemble an email address.                                                                                                           |
| Single line of text    | Text          | Text Box              | Creates a simple input field that accepts all types of text values.                                                                                                                         |
| Single line of text    | Text Area     | Text Area             | Creates a text area input field that accepts all types of text values.                                                                                                                     |
| Single line of text    | URL           | URL&nbsp;Input             | Creates a simple input field that accepts values that resemble a URL.                                                                                                                      |
| Single line of text    | Phone         | Phone&nbsp;Input           | Creates a simple input field that accepts values that resemble a phone number.                                                                                                             |
| Single line of text    | n/a           | Text Area             | Creates a text area, several lines high, for entering a large amount of text.                                                                                                              |
| Option set             | n/a           | Radio Buttons         | Maps to a field with a limited number of predefined values (as defined in the database). Creates a set of radio buttons, with one button for each value.                                  |
| Option set             | n/a           | Drop-down              | Maps to a field with a limited number of predefined values (as defined in the database). Creates a drop-down list for selecting a value.                                                  |
| Two options            | n/a           | Check box              | Maps to a Boolean field, which accepts a value of either true or false. Creates a check box, which is selected when true and clear when false.                                              |
| Two options            | n/a           | Drop-down              | Maps to a field that accepts one of just two possible values (typically true or false). Creates a drop-down list with two entries, with the display text for each defined in the database. |
| Two options            | n/a           | Radio&nbsp;Buttons         | Maps to a field that accepts one of just two possible values (typically true or false). Creates a pair of radio buttons, with the display text for each defined in the database.           |
| Whole number           | n/a           | Number&nbsp;Input          | Creates a simple input field that accepts a whole number (no decimals).                                                                                                                    |
| Floating point number  | n/a           | Number&nbsp;Input          | Creates a simple input field that accepts a floating-point (decimal) number. Supports a level of precision up to 5 decimal places and can range from -100,000,000,000 to 100,000,000,000.  |
| Decimal number         | n/a           | Number Input          | Creates a simple input field that accepts a floating-point (decimal) number. Supports a level of precision up to 10 decimal places and can range from -100,000,000,000 to 100,000,000,000. |
| Date and time          | Date Only     | Date Picker           | Creates a date picker, which lets visitors choose a date from a pop-up calendar display. Does not accept a time.                                                                           |
| Date and time          | Date and Time | Date-Time Picker      | Creates a date and time picker, which lets visitors choose a date from a pop-up calendar and a time from a drop-down list.                                                                   |

When you publish a marketing page, Dynamics 365 Marketing hosts it by using its portals feature at a public URL that you can share with prospects. When you first create the page, Dynamics 365 Marketing automatically creates a new website record for it, where you can go to analyze its traffic and performance. More information: [Register link clicks and website visits](register-engagement.md)

### See also

[Design your digital content](design-digital-content.md)  
[Design elements reference](content-blocks-reference.md)  
[Create, view, and manage marketing forms](marketing-forms.md)