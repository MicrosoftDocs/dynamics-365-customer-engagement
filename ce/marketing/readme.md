---
title: "Dynamics 365 for Marketing Readme (Known Issues) | MicrosoftDocs"
ms.date: 05/10/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
ms.assetid: 78dc5157-cf1d-4e32-ace7-9e71763e7510
author: ReneeW-CPub
ms.author: renwe
manager: annbe
---

# Dynamics 365 for Marketing Readme (Known Issues)

This document provides important, late-breaking information about known issues and workarounds for Dynamics 365 for Marketing.

## Trials

- Trials are subject to the [Dynamics 365 for Marketing trial limits and restrictions](https://go.microsoft.com/fwlink/p/?linkid=864735).
- You can't use the sign-up process to add more users to a Marketing trial that is running on a trial tenant without a mailbox set up for the organization admin. Instead, each new user must be added in a specific way. For more information, see [Sign up for a free trial of Dynamics 365 for Marketing](trial-signup.md)
- You can't sign up using an \@microsoft.com email address.

## Configuration, installation, and first-run experience

- The first-run experience to fully deploy the Marketing app might take up to two hours. During this process, retries might happen automatically, causing success (failure) notification by email.
- <del>First-run experience success and failure emails sometimes aren't delivered. </del> You would get an email summarizing the outcome once the setup is completed.

## Customer journeys

- Setting triggers on specific "link clicked" after the email tile shows multiple options for the same link. Triggers might not work correctly because clicks are not always attributed to the correct link.
- Deactivated contacts won't get any further emails from journeys they were participating in, but they might continue to be included in other actions, such as tasks and workflows.
- Insights (across journeys, emails and marketing pages) may take up to six hours to display.
- The Snapshot view generated for journeys might be missing some tiles.
- The “checking for errors” operation triggered in the customer journey’s General tab results in a time-out. Users can continue   to “check for errors” from the Designer tab.

## Segmentation

- Segment names can't have spaces&mdash;use underscores instead.
- Segmentation doesn't work on lookup fields.
- Metadata used for building conditions and drop-downs shown on the designer is not localized for non-English organizations.
- The **Save** button is not visible on the command bar after the initial save of the segment. Use the **Save** button in the lower-right corner of the page instead.
- <del>Dynamic segments based on subscription marketing lists don't remove unsubscribed contacts from running journeys. The unsubscribe request will be honored in future journeys </del>. Journeys can use subscription lists that remove unsubscribed contacts from running journeys.


## Email marketing

- The default content settings records must be live before you can send any marketing emails or generate heatmaps on the **Insights** pages. The content settings records should automatically go live when your setup is complete. However, this might not always be the case. More information: [Use content settings to set up repositories of standard and required values for email messages](dynamic-email-content.md#content-settings)
- Selecting **Stop** on a live email will prevent its use on future journeys, but its use on live journeys continues unaffected, and emails are delivered.
- Reusing the same email multiple times (within the same journey or in different journeys) produces incorrect performance results, as shown on the **Insights** pages.
- Many email templates have placeholder images. You should replace these placeholder images with actual images so that marketing emails look professional.
- The keyword grid is not displayed when you save a newly created keyword but the record is created successfully.

## Marketing pages and forms

- When configuring a form on a page, we recommend that you enter a confirmation message or a redirect URL, so users can see that they successfully submitted the form.
- It can take up to a minute after a marketing page goes live before its public link (full page URL) is ready. Visitors might see an error message on the page prior to this.
- Marketing pages from the sample data do not go live in certain organizations (Italian, Japanese). A new marketing page can still be created and pushed live.

## Lead scoring and management

- Lead scoring results might take up to one hour to be calculated.
- While creating lead scoring rules, drop-downs might not be localized for non-English languages.

## Event management

- When an existing Dynamics 365 contact tries to register for an event, they can’t register directly from the portal using the email ID in their Dynamics 365 contact record. The workaround is to create a portal invitation, add contacts to this invitation, and then send the invitation code to the contact in the email.
- Even though surveys show up in the app (such as for emails, journeys, and events), this feature currently has limited functionality. Anonymous surveys can be added to emails but cannot serve as triggers on customer journeys. Contact the Support team for more information.

## General

- If different sessions are open in other browser windows or tabs, opening the marketing app in the browser automatically authenticates the existing user from the other sessions. We recommend that you restart the browser if you typically have multiple user accounts for Dynamics 365.
- Please refrain from deactivating records. Instead, use the publishing states (Status Reason) across the application, and **Stop** buttons to manage records that are no longer required.
- Dynamics 365 for Marketing is currently supported only on the following browsers: Microsoft Edge, Chrome, and Safari on Mac. More information: [Browser and system requirements](browser-requirements.md)