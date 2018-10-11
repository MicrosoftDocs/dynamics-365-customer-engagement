---
title: "Dynamics 365 for Marketing Readme (Known Issues) | MicrosoftDocs"
ms.date: 05/10/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
ms.assetid: 78dc5157-cf1d-4e32-ace7-9e71763e7510
author: kamaybac
ms.author: renwe
manager: annbe
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Dynamics 365 for Marketing readme

This document provides important, late-breaking information about known issues and workarounds for Dynamics 365 for Marketing.

## Trials

- Trials are subject to the [Dynamics 365 for Marketing trial limits and restrictions](https://go.microsoft.com/fwlink/p/?linkid=864735).
- You can't use the sign-up process to add more users to a Marketing trial that is running on a trial tenant without a mailbox set up for the organization admin. Instead, each new user must be added in a specific way. For more information, see [Add more users to a Marketing trial running on a trial Office 365 tenant](trial-signup.md#add-users).
- You can't sign up using an \@microsoft.com email address. If you are a Microsoft employee and would like to sign up for a trial, follow the instructions given in [Sign up for a managed Office 365 trial tenant and install the Marketing trial on it](trial-signup.md#get-managed-tenant).

## Configuration, installation, and first-run experience

### Known issues

- The setup process can take up to two hours. The process might restart automatically during this time, which can result in multiple success (or failure) notifications being sent to you by email.

### Fixed issues

- You will now always receive an email summarizing the outcome of your setup.<br><del>*First-run experience success and failure emails sometimes aren't delivered.*</del>

## Customer journeys

### Known issues

- Triggers set to react to a specific "link clicked" after an email tile show multiple options for the same link. These triggers might not work correctly because clicks are not always attributed to the correct link. <!--- 759533 - Marketing Backlog -->
- Deactivated contacts won't receive any emails from journeys they were participating in, but they might continue to be included in other actions, such as tasks and workflows. <!--- 759533 - Marketing Backlog -->  
- Insights for journeys, emails, and marketing pages may take up to six hours to display.
- If you stop a live customer journey, then add contacts to the target segment, and restart the journey, those added contacts might receive emails sent by this journey more than once. <!---1196442 - November Release-->
- On non-English instances, when you save a customer journey using the **Save as template** function, the resulting template always gets saved with its language set to English. To fix this, go to **Marketing > Customer journey templates**, open the template, and change its **Language** setting to the correct value. When you're creating a new customer journey from a template, you can use the template gallery's **Language** drop-down list to show templates in any selected language. <!--- 1287079 - November 2018 Release -->

### Fixed issues

- Users can now check for errors on both the **General** and **Designer** tabs of a customer journey.<br><del>*The “checking for errors” operation triggered in the customer journey’s **General** tab results in a time-out. Users can continue   to “check for errors” from the **Designer** tab.*</del> <!---1208237 dependency - pushed to production on 10th Aug 2018-->
- The snapshot view generated for a customer journey now displays all tiles.<br><del>*The snapshot view generated for journeys might be missing some tiles.*</del>  <!--- 690797 -->

## Segmentation

### Known issues

- Segment names can't have spaces&mdash;use underscores instead.<!---695837 - Marketing Backlog-->
- You can't include lookup fields among your segmentation criteria.<!---852372 - Marketing Backlog-->  
- Metadata used for building conditions and drop-downs shown on the designer isn't localized for non-English organizations. <!--- 992449 - Marketing Backlog -->
- The **Save** button isn't visible on the command bar after the initial save of the segment. Use the **Save** button in the lower-right corner of the page instead. <!--- 862491 - Marketing Backlog -->
- When trying to estimate the size of a segment where the query doesn't end in a contact, the system displays a server communication error. To correct this error, make sure your segment definition ends with a clause that links to the contact entity as described in [Define a dynamic a segment](segmentation-lists-subscriptions.md#define-dynamic). <!--- 1226384 Backlog-->
- When you're adding members to a static segment, you can filter the list of available contacts to find the ones you want to add. Sometimes, after adding some filters and selecting **Apply**, the segment definition may stop showing its members. To fix this, save the segment, go back to the segment list, and then reopen it; you should now see the list of members and can continue working on it. <!--- 1282842 -->

### Fixed issues

- Subscription lists now remove unsubscribed contacts from running journeys.<br><del>*Dynamic segments based on subscription marketing lists don't remove unsubscribed contacts from running journeys. The unsubscribe request will be honored in future journeys.*</del>.
- When you go live with a new segment, the **Members** tab now displays correct status messages as the segment is being provisioned.<br><del>*If you go live with a new segment and then open the **Members** tab right away, you'll see a message telling you that the segment doesn't exist (even though it does). Reload the page, or open another tab and come back, to view the correct message (that the segment is being provisioned). Later, once the segment is finished provisioning, you'll see the list of contacts it contains here.*</del> <!---  1251946 Sept 1 release-->

## Email marketing

- The default content-settings record must be live before you can send any marketing emails or view heatmaps on **Insights** pages. Usually, the default content-settings record goes live automatically when your setup is complete, but sometimes this isn't the case. To solve this, set up and publish your default content-settings record manually as described in [Use content settings to set up repositories of standard and required values](dynamic-email-content.md#content-settings).
- Selecting **Stop** on a live email will prevent it from being used in future journeys, but it will continue to function in existing live journeys, which will continue to deliver it.
- If you reuse the same email multiple times (within the same journey or in different journeys) you will see incorrect performance results on its **Insights** pages.
- Many email templates have placeholder images. You should replace these placeholder images with actual images so that marketing emails look professional.
- On some Dynamics 365 instances, test sending an email throws an error and does not send the message. <!--- 1267485 - November-->

### Fixed issues

- When you create a new keyword, the **Save and close** button now correctly returns you to the **Keywords** list.<br><del>*When you save a new keyword for templates or files from a quick-create form, the keyword list isn't displayed, but the record is created successfully.*</del> <!--- 1033440 - October Release -->

## Marketing pages and forms

- When configuring a form on a page, we recommend that you enter a confirmation message or a redirect URL, so users can see that they successfully submitted the form.
- It can take up to a minute after a marketing page goes live before its public link (full page URL) is ready. Visitors might see an error message on the page prior to this.
- Marketing pages from the sample data might not go live for some organizations (especially on Italian or Japanese localizations). But you can still create new pages and go live with them. <!--- 1156824 - April Release -->
- Forms submitted over HTTP (not HTTPS) generate interaction records that don't include the contact ID, which means these interactions can't be used in interaction-based segments. If you are hosting a form on an external page (not hosted on a Dynamics 365 marketing page), then make sure your page uses HTTPS.

## Lead scoring and management

- Lead scoring results might take up to one hour to be calculated.
- When you're creating lead scoring rules, drop-down lists might not be localized for non-English languages.
- When you're creating a lead scoring model and add a condition, the "Email sent" condition isn't shown in the list of options. Use the "Sent" condition instead. <!--- 1289271 -->

## Event management

- If you disable anonymous registration for the event portal, then customer organizations must create a registerer account using the portal, after which the registerer can register as many attendees from their organization as needed. However, the registerer can't use the portal to create an account using an email address that belongs to a contact already in Dynamics 365. To set up an existing contact as a registerer, create a [portal invitation](../portals/invite-contacts.md) and then send the invitation code to the contact by email.
- Even though surveys are available in the app (such as for emails, journeys, and events), this feature currently has limited functionality. Anonymous surveys can be added to emails but can't serve as triggers in customer journeys. Please contact Microsoft Support for more information.

### Fixed

- Events now have sample data.<br><del>*Sample data is no longer available for events. We expect to provide it again in a future update.*</del>

## Videos

- When you add a video to a marketing page, the **Designer** tab shows it as a thumbnail image rather than as an embedded video in an iframe. However, the embedded video iframe will still be shown correctly on the live page when you publish it. <!--- Provided as a tip -->
- When you add a video to a marketing page or email, its thumbnail isn't shown on the **Preview** tab of the designer. However, the video is embedded correctly and will be shown in delivered emails and live marketing pages. <!--- 1277775 - November 2018 -->

## Social listening for campaigns

- The [social listening feature](https://docs.microsoft.com/en-us/business-applications-release-notes/October18/dynamics365-marketing/marketing/social-listening-campaigns) currently requires that you set it up manually as described in [Integrate Social Engagement with Dynamics 365](../social-engagement/integrate-social-engagement-dynamics-365.md). We will soon roll out a smoother setup experience fine-tuned for the Marketing app. Keep an eye on the [Dynamics 365 Customer Engagement Team Blog](https://blogs.msdn.microsoft.com/crm/) for updates.
- The social listening control may not show data on some Dynamics 365 instances. If you experience this issue, please contact Microsoft Support. <!--- This is for the UCI FCB that's required to be switched on, and requires a platform upgrade. We can also manually flip this FCB on an org by org basis by updating a DB value -->

## General

- If you have different Dynamics 365 sessions open in other browser windows or tabs, and then open the Marketing app in the same browser, it will authenticate using the same user that you have open in the other sessions. We recommend that you restart the browser each time you need to sign in using a different Dynamics 365 user account.
- Please refrain from deactivating publishable Marketing records. Instead, set the publishing states (Status Reason), and use **Stop** buttons to manage records that are no longer required. More information: [Go live with publishable entities and track their status](go-live.md)
- Dynamics 365 for Marketing is currently supported only on the following browsers: Microsoft Edge, Google Chrome, and Apple Safari on Mac. More information: [Browser and system requirements](browser-requirements.md)
