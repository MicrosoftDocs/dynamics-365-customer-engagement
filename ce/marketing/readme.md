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

Dynamics 365 for Marketing<br>Readme (Known Issues)
===================================================

This document provides important, late-breaking information about known issues
and workarounds for Dynamics 365 for Marketing.

### Dynamics 365 for Marketing - trials 

-   A trial of Dynamics 365 for Marketing is subject to [these limits and
    restrictions](https://go.microsoft.com/fwlink/p/?linkid=864735).

-   You cannot use the Join sign-up process to add more users to a Marketing
    trial that is running on a trial tenant without a mailbox set up for the
    organization admin. Instead, each new user must be added in a specific way.
    Refer to the [First time setup
    FAQ](https://go.microsoft.com/fwlink/?linkid=866753).

-   You cannot sign up using an \@microsoft.com email address. Please set up a
    trial instance first as described in the [First time setup
    FAQ](https://go.microsoft.com/fwlink/p/?linkid=866753).

### Dynamics 365 for Marketing - known issues

-   Configuration, installation, and first-run experience

    -   The first-run experience to fully deploy the Marketing app might take up
        to two hours. During this process, retries might happen automatically,
        causing success (failure) notification by email.

    -   First-run experience success and failure emails sometimes aren't
        delivered. View the first-run experience link to show the actual status.

-   Customer journeys

    -   Setting triggers on specific "link clicked" after the email tile shows
        multiple options for the same link. Triggers might not work correctly
        because clicks are not always attributed to the correct link.

    -   Deactivated contacts won't get any further emails from journeys they
        were participating in, but they might continue to be included in other
        actions, such as tasks and workflows.

    -   Insights (across journeys, emails and marketing pages) may take up to
        six hours to display.

    -   The Snapshot view generated for journeys might be missing some tiles.

-   Segmentation

    -   Segment names can't have blanks—use underscores instead.

    -   Segmentation doesn't work on lookup fields.

    -   Metadata used for building conditions and drop-downs shown on the
        designer is not localized for non-English organizations.

    -   The Save button is not visible on the command bar after the initial save
        of the segment. Use the Save button in the lower-right corner of the
        page instead.

    -   Dynamic segments based on subscription marketing lists don't remove
        unsubscribed contacts from running journeys. The unsubscribe request
        will be honored in future journeys. [Learn how to use suppression
        segments to ensure running journeys will implement unsubscribe
        requests.](https://go.microsoft.com/fwlink/p/?linkid=867008)

    -   When creating a compound segment, users might have to wait for a few
        minutes for the segment selector data to load.

-   Email marketing

    -   The default content settings records must be live before you can send
        any marketing emails or generate heatmaps on the **Insights** pages. The
        content settings records should automatically go live when your setup is
        complete. However, this might not always be the case. Please refer to
        the [Administrator
        Guide](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/marketing-settings)
        for troubleshooting content settings.

    -   Selecting **Stop** on a live email will prevent its use on future
        journeys, but its use on live journeys continues unaffected, and emails
        are delivered.

    -   Reusing the same email multiple times (within the same journey or in
        different journeys) produces incorrect performance results, as shown on
        the **Insights** pages.

    -   Many email templates have placeholder images. You should replace these
        placeholder images with actual images so that marketing emails look
        professional.

    -   The keyword grid is not displayed when you save a newly created keyword
        but the record is created successfully.

    -   Outgoing email test sends might not work at times in some organizations.
        Contact the Support team for mitigation options.

-   Marketing pages and forms

    -   When configuring a form on a page, we recommend that you enter a
        confirmation message or a redirect URL, so users can see that they
        successfully submitted the form.

    -   It might take up to 15 minutes after a marketing page goes live before
        its public link (full page URL) is ready. Visitors might see an error
        message on the page prior to this.

    -   When adding text in the confirmation box while setting up a form in a
        Marketing page, the text is not accepted the first time, and the user
        needs to click the text box once more to enter the text.

    -   Marketing pages from the sample data do not go live in certain
        organizations (Italian, Japanese). A new marketing page can still be
        created and pushed live.

-   Lead scoring and management

    -   Lead scoring results might take up to one hour to be calculated.

    -   While creating lead scoring rules, drop-downs might not be localized for
    non-English languages.

-   Event management

    -   When an existing Dynamics 365 contact tries to register for an event,
        they can’t register directly from the portal using the email ID in their
        Dynamics 365 contact record. The workaround is to create a portal
        invitation, add contacts to this invitation, and then send the
        invitation code to the contact in the email.

    -   Even though surveys show up in the app (such as for emails, journeys,
        and events), this feature currently has limited functionality. Anonymous
        surveys can be added to emails but cannot serve as triggers on customer
        journeys. Contact the Support team for more information.

-   General

    -   If different sessions are open in other browser windows or tabs, opening
        the marketing app in the browser automatically authenticates the
        existing user from the other sessions. We recommend that you restart the
        browser if you typically have multiple user accounts for Dynamics 365.

    -   Please refrain from deactivating records. Instead, use the publishing
        states (Status Reason) across the application, and **Stop** buttons to
        manage records that are no longer required.

    -   Dynamics 365 for Marketing is currently supported only on the following
        browsers: **Microsoft Edge, Chrome, and Safari on Mac**.

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

© 2018 Microsoft. All rights reserved.

Microsoft and Microsoft Dynamics are trademarks of the Microsoft group of
companies. All other trademarks are property of their respective owners.

*Third Party Notices*
