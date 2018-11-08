---
title: "The lead lifecycle (Dynamics 365 for Marketing) | Microsoft Docs"
description: "How leads are created, scored, and closed in Dynamics 365 for Marketing"
keywords: "events; event management"
ms.date: 11/16/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 (online)
  - Dynamics 365 Version 9.x
ms.assetid: 33fddaa3-d345-4aa0-8d1d-a8a9bc3ce7dc
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

# Customer journey templates

Each time you create a new customer journey, you&#39;re asked to select from a gallery of _customer journey templates_ that are available on your site.

Each template is assigned a language and purpose, and you can filter the gallery by these values to make the template you&#39;re looking for easier to find. You can view details about any listed template by selecting it in the list.

You can establish your own collection of custom templates to meet the needs of your organization. Also, the only way to create a copy of an existing customer journey is to first save it as a template, and then create a new journey based on that template.

## Save an existing customer journey as a template

If you&#39;ve created a customer journey structure that you think you&#39;d like to use again as a starting point for future campaigns, then you can save your journey as a template. Once your template is created, you&#39;ll be able to select it from the template browser each time you create a new journey.

When you save an existing customer journey as a template, the pipeline structure, all tile settings, and all journey settings are saved in the template. Depending on how you want to use it, it might make sense to edit the template after you save it to clear some of the settings that you&#39;ll most likely want to customize for each new journey (such as the specific email messages assigned to the email tiles).

To save an existing customer journey as a template:

1. Go to **Marketing \&gt; Marketing execution \&gt; Customer journeys**.
2. Open your existing customer journey.
3. Select **Save as template** on the command bar.

4. A quick-create form opens at the side of the window.


Make the following settings:

- **Name** : Specify a name for the template. Users will see this name when selecting the template from the template gallery on creating a new journey.
- **Owner** : Specify the user that owns the template (by default, this will be you). This can affect which other users will be able to see and use the template.
- **Purpose** : Select the word that best describes how and where to use this template. Users can filter the template gallery based on this value to make it easier to find in the right template.
- **Target** : Choose whether this template should [target contacts or accounts](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/account-based-marketing#account-based-customer-journeys). This value is taken from the current customer journey that you are saving as a template.
- **Language** : Chose the language the template is in. Users can filter the template gallery based on this value to make it easier to find in the right template.
- **Description** : Enter a brief description of the template and what it&#39;s for. This description is shown in the template gallery when a template is selected.
- **Is recurring** : Choose whether the template should create a [recurring journey](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/customer-journeys-create-automated-campaigns#set-general-options-including-execution-schedule-and-content-settings) or not. This value is taken from the current customer journey that you are saving as a template.

1. Select **Save** to create your template.

## Create a new template from scratch

If you are planning for future, not yet existing, customer journeys, then you can create templates from scratch rather than starting from an existing customer journey.

To create a template from scratch:

1. Go to **Marketing \&gt; Templates \&gt; Customer journey templates**.
2. Select **New** on the command bar.
3. Set up the template and make all settings just as you would a [standard customer journey](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/marketing/customer-journeys-create-automated-campaigns).
4. Save your template when you&#39;re done.

## Edit, delete, or deactivate an existing template

If you&#39;ve got a template that you don&#39;t use anymore, then you can remove it from your system to keep it from cluttering up your template gallery. You might choose to hide the template by making it inactive, or to delete it permanently. You can also edit any existing template if you&#39;ve discovered an error or your needs have changed.

To edit or delete an existing template:

1. Go to **Marketing \&gt; Templates \&gt; Customer journey templates**.
2. Find the template in the list that you want to delete or edit
  - To _delete_ a template, mark it in the list by selecting any part of the row other than the template name. Then select **Delete** on the command bar. The template is permanently deleted.
  - To _deactivate_ a template, mark it in the list by selecting any part of the row other than the template name. Then select **Deactivate** on the command bar. The template will no longer be shown in the gallery but can still be reactivated if you need it again.
  - To _edit_ a template, select the relevant template name in the list to open the standard customer journey editor. Make the required settings and then save.

To reactivate an inactive template:

1. Go to **Marketing \&gt; Templates \&gt; Customer journey templates**.
2. Open the system-view selector and switch to the **Inactive customer journey templates** view.

3. Mark the template that you want to reactivate by selecting any part of the row other than the template name. Then select **Activate** on the command bar. This moves the selected template back to the **Active customer journey templates** system view and will also make it available in the customer journey template gallery.