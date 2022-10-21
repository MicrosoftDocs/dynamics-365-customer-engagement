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

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
>
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

# How to create and manage forms in real-time marketing

A marketing form is an inbound communication channel that allows your customers to register for newsletters, ask for quotations, etc. The form is defined by a set of input fields arranged into a form layout.

Each marketing form is made from a collection of fields, buttons, graphical elements, and a few configuration settings. Each field included in your form is linked to an attribute of entity in Dynamics 365 Marketing.

## Comparison of real-time and outbound marketing forms

- The main difference is that real-time marketing form can update only one entity (typically lead or contact). This makes the form configuration and maintenance easier and allows to build properly targeted journeys.

- There is no need to create Marketing fields for real-time marketing forms. All entity attributes are already available as fields to be used in form.

- Real-time marketing form can not be used in outbound marketing pages. But you can publish a form as a standalone page, which will be hosted on Power Portals.

### Form types comparison

The following table summarizes types of forms currently available in real-time marketing. More types of forms will be avilable soon.

| form type in outbound marketing | form type in real-time marketing |  
|---|---|
| Landing page form  | Marketing form  |
| Subscription center form | Preference center (will be available as part fo Consent configuration) |
| Event registration form | N/A |
| External form submission capture | N/A |
| Refer to friend | N/A |

## Create and edit marketing form

Forms can be found in section Channel of the left menu. Open the list of forms and click New button on the top ribbon to create a new form. 

1. Select target audience (entity) that will be updated by the form submission. You can select Lead or Contact entity. The target audience (entity) selection will also affect the default strategy how to handle duplicated records:

    - Lead - each form submission will create a new record, even if the same email address is used.
    - Contact - if a record with the same email address already exists, it will be updated. No duplicated contact will be created if the same email address is used.

    You can change the duplicated record handling in [form settings](#form-settings).

    **ToDo: image**

1. Choose a template in the template gallery. The list of templates is pre-filtered according to the target audience selected in the previous step. You can skip the template selection to start with a blank form.
   
    **ToDo: image**

1. Now you can add questions represented by fields to your new form. The list of fields can be found in the right pane. It includes all attributes of target audience (entity) represented as fields. If you create a new custom attribute for the entity, it will be visible in this list and you can immediately use it as a field in your form. You can use the search bar in the list of fields to filter the field you are looking for.

    **ToDo: image**

1. Drag a field from the list and drop it on the form canvas. Once the field is added, you will see the field's properties in the right pane. The field properties can be used to set required field, configure validation and more. Learn more about [form field properties](#form-field-properties). There are multiple types of fields available with different properties, check the list of [field types](#field-types).
    
    **Tips**
    - You can drag & drop a field on the form canvas to change its position.
    - The field can be removed from the form by clicking on the trash icon.

    **ToDo: image**

1. You can directly change the field title by clicking it on the canvas or in the right pane. The same applies for the placeholder text. It is recommended to change the text on the canvas, as you can use the rich text editor there.

    **ToDo: image**

1. If you like to build more complex forms, you can change layout of your form into multi-column one and create multiple layout sections. Click on the Elements section in the right pane. Now you you can drag and drop column layout on form canvas to create a new section.

    **ToDo: image**

1. Add images and static text to your form. Select Elements section in the right pane. Drag & drop static text or image element on the form canvas.

    **ToDo: image**

1. Add Submit button from Elements section to your form.

    **ToDo: image**

1. Add consent control from Elements section to your form. Once you add the consent control to your form, you can select the correct consent purpose in the properties. Click on the consent checkbox caption to change its text.

    **ToDo: image**

1. Now it's time to preview your form and check the responsiveness. Click the Preview and test tab to open the form preview. You can select various platforms to check how the form will be rendered on mobile device or tablets.

### Form field properties

**ToDo**

### Form Settings

**ToDo**

### Field types

**ToDo**