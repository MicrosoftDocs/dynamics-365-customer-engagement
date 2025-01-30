---
title: Add LinkedIn Sales Navigator controls to forms
description: Learn how to add LinkedIn Sales Navigator controls to a form. This page walks you through an example which can be followed in the same way on other entities.
ms.date: 01/31/2025
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
keywords: custom control, sales navigator, linkedin, integration, customization
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Add LinkedIn Sales Navigator controls to forms

[!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] Sales Navigator controls are custom controls that you can add to forms in [!INCLUDE[pn-dynamics-365](../../includes/pn-dynamics-365.md)] to show information about a [!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] member profile or company profile.

> [!NOTE]
> For Dynamics 365 Sales Professional, the lead and contact forms must be treated as custom forms and add the controls to these forms.

## Prerequisites

- You have Customizer or System Administrator security role in [!INCLUDE[pn-dynamics-365](../../includes/pn-dynamics-365.md)].  
- To test the controls, you need to be a [!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] Sales Navigator seat holder.

## Add Sales Navigator controls to a form

You can add the Sales Navigator controls on any form or table of a Unified Interface app in [!INCLUDE[pn-dynamics-365](../../includes/pn-dynamics-365.md)] that contains a field for last name, primary contact, or account name.

There are different types of [!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] controls which are added automatically when you use the latest version of the out-of-box integrations:

- **[!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] Sales Navigator Lead (member profile)**: Shows the member profile of a [!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] contact using a specific lead or contact name.
- **[!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] Lead Lookup Control**: Shows member profile information using the name of the primary contact related to the record.
- **[!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] Sales Navigator Account (company profile)**: Shows information about a [!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] company profile using a specific account name.
- **[!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] Account Lookup Control**: Shows company profile information using the account name related to the record.
- **[!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] InMail Control**: Shows a form where you can send an InMail message to another LinkedIn member.

The Sales Navigator controls can be added by modifying a field on a form in [!INCLUDE[pn-dynamics-365](../../includes/pn-dynamics-365.md)]. Modify the following fields according to the control type. Optionally, you can add multiple fields to match the control to make the matches more relevant. Keep in mind that this requires all fields to match before a member profile or company profile is suggested. If no match, or in rare cases a wrong match is found, you can use the search interface to find the right profile.

## Add a member profile to a Lead form

This procedure shows an example of how to add a [!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] Sales Navigator Lead (member profile) on the **Lead** form by modifying the **Last Name** field. Other controls can be configured in the same way on other entities where the controls aren't added by default.

1. In the sales app, go to **Settings** > **Advanced Settings**.  

    :::image type="content" source="media/advanced-settings-option.png" alt-text="Screenshot of the Advanced Settings option on the Settings menu.":::

1. Go to **Customization** > **Customizations** > **Customize the System**.  
1. In the left pane, expand **Tables** and then the entity you want, and select **Forms**.  

    >[!NOTE]
    >If you are using the classic view, under **Components**, expand **Entities**, and then the entity you want, and select **Forms**.  

1. Open the entity form of type **Main** and then select **Components** on the tool bar.  In this example, we're using the **Lead** entity.

1. To add a reference to a custom control, begin by opening a field on the form, which will be bound to the primary attribute of the control (Last Name field for the member profile control and Company Name for the company profile control). In this example, we already have the **Last Name** field to the form.

   > [!IMPORTANT]
   > Member profile and company profile controls are read-only controls. We recommend that you create a copy of the two fields (Last Name and Company Name) that you're binding these controls to, so that you can continue to edit the fields.

1. Select the **Last Name** field and in the **Properties** pane, select **Components** > **+ Component** .  
1. In the **Add component**  dialog box, search and add the **[!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] Sales Navigator member profile** control.

    >[!NOTE]
    >If you don't see the **[!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] Sales Navigator member profile** control in the **Components** section, select **Get more components** to add it.  

1. Now you need to configure the Sales Navigator control. In the configuration pane, go to the **Show component on** sections and select **Web** form factor for the [!INCLUDE[pn-linkedin](../../includes/pn-linkedin.md)] control and remove other form factors.  

   > [!TIP]
   > Currently, the controls are available on desktop form factors. On mobile (phone and tablet) scenarios, the controls fall back to the default platform control. To hide the default controls from the forms on mobile scenarios, select the **Hide Default Control** check box.

1. In the property area, make sure all required properties (with a red asterisk) have a binding configured. You might need to scroll down in the list to find additional required properties. For this example, we need to configure one additional property. We recommend binding the remaining parameters (first name, email, job title, and company name) to the corresponding fields on the Lead entity. The more parameters are passed to the control, the greater will be the [accuracy to find the right match](https://www.linkedin.com/help/sales-navigator/answer/77041/leads-contacts-and-accounts-matching-between-sales-navigator-and-your-crm). Configure the **First Name** property. Use this optional field to specify the LinkedIn member’s first name for the matching query. Specifying this attribute increases the match accuracy.  

1. In the **Company Name** section, select **Table column** as **First Name (Text)**.  

1. Select **Done**.

1. Save and publish the form.

> [!TIP]
> When using the Microsoft Edge browser, add your Dynamics 365 domain as a trusted site. This is required to read cookies from the linkedin.com domain.  
> 1. Select the lock icon in the address bar on a Dynamics 365 record with Sales Navigator controls.  
> 2. Select **Manage for all sites** under **Tracking prevention**.  
> 3. Select **Exceptions** and add your Dynamics 365 domain to the list.

## Related information

[Overview for LinkedIn Sales Navigator solutions](integrate-sales-navigator.md)  
[Install and configure LinkedIn Sales Navigator Controls](install-sales-navigator.md)  
[Work with Sales Navigator controls on forms](view-sales-navigator-forms.md)
