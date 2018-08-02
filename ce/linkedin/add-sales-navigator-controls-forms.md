---
title: "Add LinkedIn Sales Navigator controls to forms | Microsoft Docs"
description: "Add LinkedIn Sales Navigator controls to forms in Dynamics 365."
keywords: "custom control, sales navigator, linkedin, integration, customization"
ms.date: 07/12/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 Version 9.x"
  - "Dynamics 365 (online)"
ms.assetid: 41253990-3a7d-0829-8509-91273db68b82
author: m-hartmann
ms.author: mhart
manager: shellyha
---

# Add LinkedIn Sales Navigator controls to forms

## Prerequisites

- Sales Navigator Controls for [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] Unified Interface [is installed](install-sales-navigator.md) in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)].
- You have Customizer or System Administrator security role in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]. 
- Your organization uses Unified Interface apps.
- To test the controls, you need to be a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator seat holder.

## Add Sales Navigator controls to a form

You can use the web app to [add custom controls](https://docs.microsoft.com/dynamics365/customer-engagement/customize/use-custom-controls-data-visualizations) on any form or entity of a Unified Interface app in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] that contains a field for last name, primary contact, or account name. 

There are four different types of [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] controls: 
 
- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Lead (member profile)**: Shows information about a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member profile using a specific lead or contact name.
- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Lookup Control**: Shows member profile information using the name of the primary contact related to the record.
- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Account (company profile)**: Shows information about a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] company profile using a specific account name. 
- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Account Lookup Control**: Shows company profile information using the account name related to the record.  

The Sales Navigator controls can be added by modifying field on a form in [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)]. Modify the following fields according to the control type. Optionally, you can add multiple fields to match the control to make the matches more relevant. Keep in mind that this requires all fields to match before a member profile or company profile is suggested. If no match, or in rare cases a wrong match is found, you can use the search interface to find the right profile.

| Sales Navigator Control                            | Field name to modify | Field type |
|----------------------------------------------------|----------------------|------------|
| LinkedIn Sales Navigator Lead (member profile)      | Last Name            | Text       |
| LinkedIn Lead Lookup Control                       | Primary Contact      | Lookup     |
| LinkedIn Sales Navigator Account (company profile) | Account Name         | Text       |
| LinkedIn Account Lookup Control                    | Account Name         | Lookup     |



This procedure shows an example of how to add a [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Lead (member profile) on the **Lead** form by modifying the **Last Name** field. Other controls can be configured in the same way.

1. In the web client of [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)], go to **Settings** > **Customizations**.

   ![Click path to customization area](media/customizations-nav-bar.png "Click path to customization area")

2. Select **Customize the System**. For this example, we'll customize the default solution. [Learn more about customizing Dynamics 365](https://docs.microsoft.com/dynamics365/customer-engagement/customize/solutions-overview).

3. Expand the **Entities** node and select the entity you want to customize. You can use virtually any entity, but for this example, we'll select the **Lead** entity and expand the node.

4. Select **Forms** and then select the default **Lead** form.

   ![Lead form in customization area](media/select-lead-form-sales-navigator.png "Lead form in customization area")

5. To add a reference to a custom control, begin by opening a field on the form, which will be bound to the primary attribute of the control (“Last Name” field for the member profile control and “Company Name” for the company profile control). In this example, we already have the **Last Name** field to the form.

6. Select the **Last Name** field and then select **Change Properties** in the ribbon.
    > [!TIP]
    > By default, controls on the Unified Interface show in two columns with the label and value side by side. To maximize the control so that it takes the full horizontal space available on the column, clear the **Display label** on the form check box on the **Display** tab.    
    > ![Cleared checkbox to hide label on the form](media/display-label-form-cleared.png "Cleared checkbox to hide label on the form")

   ![Click path to Change Properties button](media/change-form-properties.png "Click path to Change Properties button")

6. In the **Field Properties** window, switch to the **Controls** tab and select **Add control**.

   ![Click path to Add Control button](media/add-control.png "Click path to Add Control button")

7. Select the **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator member profile** control and select **Add**.

   ![Click path to add a Sales Navigator controls](media/add-control-to-form.png "Click path to add a Sales Navigator control")

8. Now you need to configure the Sales Navigator control. In the **Control** area, select **Web** form factor for the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] control. 
   > [!TIP]
   > Currently, the controls are available on desktop form factors. On mobile (phone and tablet) scenarios, the controls fall back to the default platform control. To hide the default controls from the forms on mobile scenarios, select the **Hide Default Control** check box.

   

9. In the property area, make sure all required properties (with a red asterisk) have a binding configured. You might need to scroll down in the list to find additional required properties. For this example, we need to configure one additional property. We recommend binding the remaining parameters (first name, email, job title, and company name) to the corresponding fields on the Lead entity. The more parameters are passed to the control, the greater will be the [accuracy to find the right match](https://www.linkedin.com/help/sales-navigator/answer/77041/leads-contacts-and-accounts-matching-between-sales-navigator-and-your-crm).  
 Select the **First Name** property with the description **Use this optional field to specify the LinkedIn member’s first name for the matching query. Specifying this attribute increases the match accuracy** and select the pencil icon. 

   ![Configure properties of a Sales Navigator control](media/configure-sales-navigator-control.png "Configure properties of a Sales Navigator control")

10. In the **Bind to a value on a field** list, select **firstname (SingleLine.Text)** and select **OK**.   

    ![Bind value on a field dialog box](media/configure-lastname-property.png "Bind value on a field dialog box")

11. Select **Add** in the Field Properties window.

12. In the **Form Editor**, select **Save** to apply your changes to the form. 

  ![Click path to save and publish customizations on a form](media/save-publish-customizations.png "Click path to save and publish customizations on a form")

13. Select **Publish** to make your customizations available to the organization.

### See also

[Overview for LinkedIn Sales Navigator solutions](integrate-sales-navigator.md)     
[Install and configure LinkedIn Sales Navigator Controls](install-sales-navigator.md)     
[Work with Sales Navigator controls on forms](view-sales-navigator-forms.md)
