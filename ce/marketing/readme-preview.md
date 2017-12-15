---
title: "Dynamics 365 for Marketing Preview Readme (Known Issues) | MicrosoftDocs"
ms.date: 12/18/2017
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

Dynamics 365 for Marketing Public Preview is subject to [these limits and restrictions](https://go.microsoft.com/fwlink/p/?linkid=864735)

## Known issues, organized by area:

-   ### Dynamics 365 for Marketing Public Preview sign-up

    -   The **Learn more** link goes to the incorrect FAQ on the preview
        instance picker.

    -   The **Invite user** command doesn't work on the preview instance picker.

    -   The first-run experience link in the Welcome email goes to the Marketing
        application after the first-run experience is successfully completed.

    -   Certain pages and related documentation—like the FAQ, Terms and
        conditions, and sign-up screen—might display English rather than
        localized content.

-   ### Configuration, installation, and first-run experience

    -   Lifecycle operations for Dynamics 365 production and sandbox
        instances—like switch an instance, copy an instance, and deletion—aren't
        yet fully supported for Dynamics 365 for Marketing.

    -   The first-run experience to fully deploy the Marketing app might take up
        to two hours.

    -   On Firefox, the **Give consent** button needed for surveys might not be
        displayed in a pop-up window.

    -   The **Physical sender address** field on the setup screen might take
        some time to load; the workaround is to wait a minute.

    -   First-run experience Success and Failure emails sometimes aren't
        delivered.

    -   **Add user** in Advanced Settings doesn't work as intended.

    -   Sample data isn't installed by **Sample Data Management** in Advanced
        Settings.

    -   **Go To Installation Setup** doesn't go to the first-run experience page
        from the Welcome screen or Advanced Settings.

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

    -   Surveys embedded into email and used within journeys are sent out, but
        the responses aren't triggerable nor are the interactions shown on
        **Insights** pages.

    -   Marketing Page and Survey tiles don’t have a **View** button on journey
        **Insights** pages. The workaround is to go to the designer view to
        access the associated record.

    -   Republishing a stopped journey might fail if some fields have been
        cleared during edits.

    -   Activity templates for Phone Call and Task used in journeys don’t
        generate these records if they have integers specified (for example, for
        duration or dates). Text fields work as expected.

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
        might not always be the case. Please refer to the *Setup Guide* for
        troubleshooting content settings.

    -   Selecting **Stop** on a live email doesn't work The email message will
        still be used in live journeys.

    -   If you want to see a true inbox preview for your emails, you must enable
        Litmus preview. Please refer to the Setup Guide for details.

    -   Reusing the same email multiple times (within the same journey or in
        different journeys) yields incorrect performance results, as shown on
        the **Insights** pages.

-   ### Marketing pages and forms

    -   When configuring a form on a page, we recommend that you enter a
        confirmation message or a redirect URL so users can see that they
        successfully submitted the form.

    -   On marketing pages, the image picker (from the library) doesn't work.
        The workaround is to enter the URL of any image in the image's source
        field in the properties.

-   ### Lead scoring and management

    -   Each model can currently only have 14 lead scoring conditions.

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

[Third Party Notices](https://go.microsoft.com/fwlink/p/?linkid=853765)
