---
title: "Configure form matching (Dynamics 365 Marketing) | Microsoft Docs"
description: "Set up how form submissions are matched to existing contacts or leads when deciding whether to update an existing record or to create a new one in Dynamics 365 Marketing."
ms.date: 02/27/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
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

# Set form matching

Form matching define how form submissions are matched to existing contacts or leads when deciding whether to update an existing record or to create a new one.

For example, a simple contact-matching strategy might be based on email address alone. When a submission is received, Dynamics 365 Marketing will check whether any existing contact has the submitted email address. If a match is found, the submission is used to update that contact; if no match is found, a new contact is created with the received values.

For leads, if an existing lead record is found to match an incoming form submission, then the new submission will become part of that lead's history and could affect the lead's score.

You'll probably have just a few matching strategies of each type&nbsp;many organizations use just one of each. Therefore, you can define each strategy just once and then it'll be available for selection each time you create a new form, and when you define the default strategies for all new forms. There are three places where you can view and create matching strategies:

- Go to **Settings** > **Lead management** > **Form matching** to view, create and edit all strategies that are available on your instance.
- You can select a default strategy of each type (lead and contact). These will be selected by default each time a user creates a new marketing form, but users can then customize the setting as needed for each individual form. More information: [Configure landing pages](mkt-settings-landing-pages.md)
- When you are creating or editing a marketing form, you'll  be able to select from among the available strategies, or create new ones. More information: [Create, view, and manage marketing forms](marketing-forms.md)

In each case, the settings are the same.

![Setting form matching](https://user-images.githubusercontent.com/73484213/109382436-bf27dc00-78e0-11eb-8442-14d1dbdefcaf.jpg "Setting form matching")

Describe your strategy by entering a **Name** and **Description**. Set the **Target** field to the type of entity your strategy applies to (lead or contact).

The list under the **Attributes** heading specifies which contact or lead attributes (fields) to consider when looking for a match. The matching record must have identical values for *all* the attributes shown here, so the more attributes you use, the narrower your search will be. Often the email address alone is enough to use as a unique identifier for contacts, but you might use additional attributes (such as first and last name) if you think some of your contacts might share an email address, or if you want tighter control (at the risk of creating extra contact records for the same person).

Use the buttons in the toolbar for the **Attributes** section to add, edit, and remove attribute in the list.

> [!NOTE]
> For lead matching, you might consider adding both **emailaddress1** and a lead-origin attribute such as **msdyncrm_marketingpageid** (this is the default configuration). This enables the system to identify leads based on the combination of email address and the specific marketing page that created the lead. By including the page ID as part of your lead-matching strategy, you'll be able to have multiple leads for a single contact, with each lead tracking interest in a different campaign (provided each campaign is using its own marketing page). However, the page ID is only provided by marketing pages hosted on a [Power Apps portal](portal-optional.md); for captured forms and forms embedded on an [external site](embed-forms.md), no page ID is saved, so all external forms will look like the same form when it comes to lead matching.

### See also

[Open the settings](open-advanced-settings.md)  
[Configure landing pages](mkt-settings-landing-pages.md)  
[Create, view, and manage marketing forms](marketing-forms.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
