---
title: "Dynamics 365 for Marketing Preview Readme (Known Issues) | MicrosoftDocs"
ms.date: 04/01/2018
ms.service: "crm-online"
ms.topic: "article"
author: kamaybac
ms.author: kamaybac
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 28dc5957-cf1d-4e82-ace7-9e71763e7510
---

Dynamics 365 for Marketing<br/>Public Preview Readme (Known Issues)
====================================================================

This document provides important, late-breaking information about known issues
and possible workarounds for Dynamics 365 for Marketing Public Preview.

Dynamics 365 for Marketing Public Preview is subject to these limits and
restrictions.

### Dynamics 365 for Marketing Public Preview Sign-up Issues

-   Dynamics 365 for Marketing is currently only supported on the following
    browsers: **Microsoft Edge, Chrome, and Safari on Mac**.

-   On the **Your colleagues are also trying Dynamics 365** page, the **Learn
    more** link goes to the incorrect FAQ.

-   Up to five (5) users are permitted to sign up or join a single Marketing
    preview instance per tenant.

-   You cannot use the Join sign-up process to add more users to a Marketing
    preview that is running on a trial tenant. Instead, each new user must be
    added in a special way. Refer to [First Time setup
    FAQ](https://go.microsoft.com/fwlink/?linkid=866753).

-   You cannot sign up using an \@microsoft.com email address. Please set up a
    trial instance first as described in this
    [FAQ](https://go.microsoft.com/fwlink/p/?linkid=866753).

### Dynamics 365 for Marketing Known Issues

-   Configuration, installation, and first-run experience

    -   The first-run experience to fully deploy the Marketing app might take up
        to two hours. During this process, retries may happen automatically
        causing success (failure) notification by email.

    -   First-run experience success and failure emails sometimes aren't
        delivered. View the first-run experience link to show the actual status.

    -   Loading a list of organizations available for setup might be slow. You
        can refresh the setup page after 5 minutes to see if they load
        correctly. If not, please contact the Support team for help.

    -   After installing sample data via **Sample Data Management** in
        **Advanced Settings,** the status incorrectly shows that sample data has
        not been installed.

    -   In rare cases, when running the Upgrade for the Marketing application in
        the First-run experience, the Summary step incorrectly displays **In
        Progress** status even when the upgrade is finished. Please retry to see
        if any updates are still available.

    -   Lifecycle operations for Dynamics 365 production and sandbox instances,
        such as switch an instance, reset an instance, backup and restore an
        instance, copy an instance, and delete an instance, aren't yet fully
        supported for Dynamics 365 for Marketing.

-   Customer journeys

    -   Setting triggers on specific "link clicked" after the email tile, shows
        multiple options for the same link. Triggers might not work correctly
        because clicks are not always attributed to the correct link.

    -   Deactivated contacts won't get any further emails from journeys they
        were participating in, but they might continue to be included in other
        actions like tasks and workflows.

    -   The Snapshot view generated for journeys might be missing some tiles.
        Also, Snapshot doesn't work correctly in full-screen mode; the
        workaround is to use Snapshot in regular mode.

    -   Customer journeys cannot be saved if the canvas does not have any tiles.
        Add any tile to successfully save the journey.

-   Segmentation

    -   Segment names can't have blanks—use underscores instead.

    -   Segmentation doesn't work on lookup fields or multi-option sets.

    -   Metadata used for building conditions and dropdowns shown on the
        designer are not localized for non-English orgs.

    -   Dynamic segments based on subscription marketing lists don't remove
        unsubscribed contacts from running journeys. The unsubscribe request
        will be honored in future journeys. [Learn how to use suppression
        segments to ensure running journeys will implement unsubscribe
        requests](https://go.microsoft.com/fwlink/p/?linkid=867008).

-   Email marketing

    -   To send any marketing emails or generate a heatmap on the **Insights**
        pages, the default content settings record should be live. We expect
        this to be live automatically when your setup is complete. However, this
        might not always be the case. Please refer to the [Administrator
        Guide](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/marketing-settings)
        for troubleshooting content settings.

    -   Selecting **Stop** on a live email will not prevent it from further use
        within live journeys.

    -   To see a true inbox preview for your emails on specific clients and
        platform combinations, you must enable Litmus preview. Refer to the
        [Administrator
        Guide](https://docs.microsoft.com/dynamics365/customer-engagement/marketing/marketing-settings#marketing-configuration)
        for details.

    -   Reusing the same email multiple times (within the same journey or in
        different journeys) yields incorrect performance results, as shown on
        the **Insights** pages.

    -   Many email templates have placeholder images. You should replace these
        placeholder images with actual images so that marketing emails look
        professional.

    -   Email insights (and across other insights, such as marketing pages and
        journeys) may take up to 6 hours to display.

-   Marketing pages and forms

    -   When configuring a form on a page, we recommend that you enter a
        confirmation message or a redirect URL, so users can see that they
        successfully submitted the form.

    -   Even after the marketing page goes live, it might take up to 15 minutes
        for its public link (full page URL) to be ready. Visitors might see an
        error message on the page prior to this.

-   Lead scoring and management

    -   Lead scoring results may take up to one hour to be calculated.

    -   New lead scoring models might default to text view for smaller devices,
        so the toolbar right panel is inactive.

    -   Lead scoring cannot be saved if the canvas doesn’t have any tiles. Add any
        tile to save successfully.

    -   While creating lead scoring rules, dropdowns may not be localized for
        non-English languages.

-   Event management

    -   When an existing Dynamics 365 contact tries to register for an event,
        they can’t register directly from the portal using the email ID in their
        Dynamics 365 contact record. The workaround is to create a portal
        invitation, add contacts to this invitation, and then send the
        invitation code to the contact in the email.

    -   If lead creation from an event is set up, and an existing contact (who
        had registered for an event earlier and had a lead created for them)
        registers for another event, a new lead is not created for them
        automatically.

    -   Even though surveys show up in the app (such as for emails, journeys,
        and events), this feature currently has limited functionality. Anonymous
        surveys can be added to emails but cannot serve as triggers on customer
        journeys. Contact the Support team for more information.

-   General

    -   If different sessions are open in other browser windows or tabs, opening
        the marketing app in the browser automatically signs in the existing
        user from the other sessions. We recommend that you restart the browser
        if you typically have multiple user accounts for Dynamics 365.

    -   Please refrain from deactivating records. Instead, use the publishing
        states (Status Reason) across the application, and **Stop** buttons to
        manage records that are no longer required.

    -   Leads and contacts created using the Marketing app forms don’t render
        correctly on the enterprise Sales app (web client). Please view them on
        the marketing app.

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
