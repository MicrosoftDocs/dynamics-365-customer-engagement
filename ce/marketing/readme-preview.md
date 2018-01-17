---
title: "Dynamics 365 for Marketing Preview Readme (Known Issues) | MicrosoftDocs"
ms.date: 01/15/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 28dc5957-cf1d-4e82-ace7-9e71763e7510
---

Dynamics 365 for Marketing<br>Preview Readme (Known Issues)
===========================================================

This document provides important, late-breaking information about known issues
and possible workarounds for Dynamics 365 for Marketing Public Preview.

#### Dynamics 365 for Marketing Public Preview is subject to [these limits and restrictions](https://go.microsoft.com/fwlink/p/?linkid=864735).

## Dynamics 365 for Marketing Public Preview Sign-up Issues

-   For users signing up from languages/regions that are not yet supported, you
    must **change your browser language to English** to proceed further. Refer
    to “To change your browser language” later in this readme.

-   Dynamics 365 for Marketing is currently only supported for following
    browsers: **Microsoft Edge, Chrome, and Safari on Mac**.

-   On the **Your colleagues are also trying Dynamics 365** page, the **Learn
    more** link goes to the incorrect FAQ.

-   In the **Organization Selector**, the **Invite user** command doesn't work.

-   If the email address you chose during sign up does not already have a tenant
    associated with Microsoft, subsequent setup will fail. Please contact
    support for alternatives.

-   You cannot sign up using an \@microsoft.com email address. Please set up a
    trial tenant first as described in this <a href="https://experience.dynamics.com/insider/news/CMP-01064-T5N2S4/a6b3b39c-d4ec-e711-8185-e0071b6ac181/" target="_blank">blog post</a>.

-   You sign up for the preview, but the process doesn’t navigate to the
    first-run experience to continue setting up the application. Please contact
    support for alternatives.

-   The first-run experience link in the Welcome email leads to the Marketing
    application directly after the first-run experience is successfully
    completed. In that case, you can get to the first-run-experience from the
    Dynamics 365 admin center.

-   Certain pages and related documentation, like the FAQ, Terms and conditions,
    and sign-up screen, might be displayed in English rather than in the
    selected language.

#### _To change your browser language_

Follow the steps for the browser you are using:

-   **Microsoft Edge:** In the Windows Search bar, open Control Panel. Select
    **Clock** \> **Language** \> and **Region**. Select **Add a language** and
    select **English (United States)**. Move it to the top of the list. Close
    Control Panel. Restart your computer.

    -   **Important:** This will change the language of your user interface, not
        just your browser language preferences.

-   **Chrome:** Open the browser settings, and in the **Advanced** section
    scroll down to find **Languages**. Open **Language and Input Settings** and
    add **English (United States)**. Order the resulting list so that it is in
    descending order of preference. Also select **Display Google Chrome in this
    Language**. You don't need to restart Chrome.

-   **Safari:** On OS X the language sent is that specified in the OS X system
    language preferences. To change those preferences, go to **System
    Preferences** \> **Language & Region** \> **Preferred Language**. Click the
    plus sign (**+**) and add **English**. Drag it to the top of the list. Close
    **System Preferences**. Close the Safari browser and restart it.

    -   **Important:** This will change the language of your user interface, not
        just your browser language preferences.

## Dynamics 365 for Marketing Known Issues

-   ### Configuration, installation, and first-run experience

    -   Lifecycle operations for Dynamics 365 production and sandbox instances,
        like switch an instance, reset an instance, backup and restore an
        instance, copy an instance, and deletion, aren't yet fully supported for
        Dynamics 365 for Marketing.

    -   The first-run experience to fully deploy the Marketing app might take up
        to two hours.

    -   Your organization must be the marketing preview organization that the
        sign-up process creates and that is already the default. Using any other
        organization will lead to a failure after a long time (up to 12 hours).
        If you need the organization name, please refer to the welcome email.

    -   For some organizations, the **Advanced Settings** pages might not show
        up even after setup has been completed, which would affect the <a href="https://docs.microsoft.com/dynamics365/customer-engagement/marketing/open-advanced-settings" target="_blank">advanced
        setting steps</a>. For help, please contact the support team.

    -   The **Physical sender address** field on the setup screen might take
        some time to load; the workaround is to wait a few minutes.

    -   First-run experience Success and Failure emails sometimes aren't
        delivered. Viewing the first-run experience link would show you the
        actual status.

    -   Even though surveys show up in the app (such as for emails, journeys,
        and events) this feature is not yet functional. To try out surveys, you
        should contact support team to install this app manually.

    -   **Add user** in **Advanced Settings** doesn't work as intended. The
        workaround is to add them via the Dynamic 365 legacy Settings.

    -   Sample data isn't installed by **Sample Data Management** in **Advanced
        Settings**.

    -   **Go to Installation Setup** doesn't go to the first-run experience page
        from the Welcome screen or **Advanced Settings**.

-   ### Customer journeys and segmentation

    -   Setting triggers on specific links clicked after the email tile shows
        multiple options for the same link. Any triggers thus set might not work
        correctly, because not all clicks are attributed to the correct link.

    -   Deactivated contacts won't get any further emails from journeys they
        were participating in, but might continue to be included in other
        actions like tasks and workflows.

    -   The **Save as segment** on journey insights might not generate segment
        members.

    -   The snapshot view generated for journeys might be missing some tiles.
        Also, snapshot doesn't work correctly in full-screen mode; the
        workaround is to use snapshot in regular mode.

    -   Marketing Page tile doesn’t have a **View** button on journey
        **Insights** pages. The workaround is to go to the designer view to
        access the associated record.

    -   Republishing a stopped journey might fail if some fields have been
        cleared during edits.

    -   Activity templates for Phone Call and Task used in journeys don’t
        generate these records if they have integers specified (for example, for
        duration or dates). Text fields work as expected.

    -   Record update tile works only on when a record is created, such as a
        lead, not when a record is updated.

    -   Segment names can't have blanks—use underscores instead.

    -   Live segments can be edited by using the designer even though this isn't
        supported.

    -   Segmentation doesn't work on lookup fields or multi-option sets.

    -   Dynamic segments based on marketing lists don't reflect removed or
        unsubscribed contacts.

-   ### Email marketing

    -   To send any marketing emails, or generate a heatmap on **Insights**
        pages, the default content settings record should be live. We expect
        this to be live automatically when your setup is complete, however, this
        might not always be the case. Please refer to the <a href="https://docs.microsoft.com/dynamics365/customer-engagement/marketing/marketing-settings" target="_blank">Admin Guide</a> for troubleshooting content settings.

    -   Selecting **Stop** on a live email will not prevent it from further use
        within live journeys.

    -   If you want to see a true inbox preview for your emails, you must enable
        Litmus preview via **Advanced Settings**. Please refer to the <a href="https://docs.microsoft.com/dynamics365/customer-engagement/marketing/marketing-settings#use-marketing-configurations-to-enable-litmus-previews" target="_blank">Admin Guide</a> for details.

    -   Reusing the same email multiple times (within the same journey or in
        different journeys) yields incorrect performance results, as shown on
        the **Insights** pages.

-  ### Marketing pages and forms

    -   When configuring a form on a page, we recommend that you enter a
        confirmation message or a redirect URL so users can see that they
        successfully submitted the form.

    -   On marketing pages, the image selector (from the library) doesn't work.
        The workaround is to enter the URL of any image in the image's source
        field in the properties.

    -   Even after the marketing page goes live, it might take up to 15 minutes
        for its public link (full page URL) to be ready. Visitors might see an
        error message on the page prior to this.

-   ### Lead scoring and management

    -   Each model is limited to 14 lead scoring conditions.

    -   Lead scoring results are not calculated instantaneously.

    -   Dragging a condition that's already on the canvas to any action causes
        the designer to crash.

    -   Might take a week to update a lead scoring of zero.

    -   The **None** qualifier doesn't calculate points if no interactions are
        assigned to the lead's contact.

    -   New lead scoring models might default to text view, so the toolbar right
        panel is inactive.

-   ### Event management

    -   When an onsite event is added to an email, the call to action points to
        the (blank) webinar URL field.

    -   For unpaid events (events with no passes), when an attendee is
        registered on the portal, it's not possible to change the attendee's
        custom questions after they've been saved (before checking out). The
        current workaround is to delete the attendee and add them again.

    -   While creating a recurring event, it's not possible to create a
        multiple-day event because the start time and end time are for the same
        day.

    -   In an event, while adding custom questions, the order in which the
        custom questions are displayed on the portal is determined by the order
        in which they were added to the event.

-   ### General

    -   Please note that if different sessions are open in other browser windows
        or tabs, opening the marketing app in the browser automatically signs up
        the existing users from the other sessions. We recommend that you be
        sure to restart the browser if you typically have multiple user accounts
        for Dynamics 365.

Copyright
---------

This document is provided "as-is". Information and views expressed in this
document, including URL and other Internet web site references, may change
without notice.

Some examples depicted herein are provided for illustration only and are
fictitious. No real association or connection is intended or should be inferred.

This document does not provide you with any legal rights to any intellectual
property in any Microsoft product. You may copy and use this document for your
internal, reference purposes. This document is confidential and proprietary to
Microsoft. It is disclosed and can be used only pursuant to a non-disclosure
agreement.

© 2017 Microsoft. All rights reserved.

Microsoft and Microsoft Dynamics are trademarks of the Microsoft group of
companies. All other trademarks are property of their respective owners.

<a href="https://go.microsoft.com/fwlink/p/?linkid=853765" target="_blank">Third Party Notices</a>
