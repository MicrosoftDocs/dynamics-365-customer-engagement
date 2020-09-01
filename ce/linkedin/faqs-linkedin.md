---
title: "FAQ for LinkedIn Sales Navigator (Dynamics 365 Sales) | MicrosoftDocs"
description: "FAQ for LinkedIn Sales Navigator in Dynamics 365 Sales."
ms.date: 07/15/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Frequently asked questions

<a name="sync-load-photos-linkedin"> </a>
**Why am I unable to sync or load photos of my contacts from LinkedIn to the org chart?**  

**Answer:** 

Currently, we don't support syncing or loading contact profile pictures from LinkedIn to the org chart. The org chart displays only the pictures that are stored in Dynamics 365 for contact records. 

<a name="add-remove-fields-contact-details"> </a>
**Why am I unable to remove or add fields to a contact through the Contact Details side pane after selecting nodes in the org chart?**  

**Answer:** 

Removing or adding fields from the **Contact Details** pane isn't supported.

<a name="import-leads-accounts-crm-sync"> </a>
**Can I import leads or accounts into Dynamics 365 Sales through CRM Sync?**

**Answer:**

No, you can't import leads or accounts from Sales Navigator to Dynamics 365 Sales through CRM Sync. However, writeback of InMails, Messages, and Smart Links from Sales Navigator to Dynamics 365 Sales is supported. More information: [Enable Sales Navigator CRM Sync & Activity Writeback for Microsoft Dynamics 365 Sales](https://business.linkedin.com/sales-solutions/sales-navigator-customer-hub/resources/ms-dynamics-sync-activity-writeback)

<a name="upgrade-solution-2-to-3-version"> </a>
**Why hasn't my LinkedIn Sales Navigator solution been upgraded from version 2.x to 3.x?**

**Answer:**

Because there's no change to functionality in version 3.x, we aren't upgrading. This will have no effect on your current solution (version 2.x).

## General  

<a name="unable-sync-d365-org-under-admin-tab-linkedin"> </a>
**Why am I unable to sync Dynamics 365 organization with LinkedIn Sales Navigator under Admin tab and an error message is displayed specifying that the start of sync has failed.** 

> [!div class="mx-imgBorder"]  
> ![Unable to sync Dynamics 365 organization with LinkedIn Sales Navigator error message](media/faq-unable-sync-d365-lsn-error.png "Unable to sync Dynamics 365 organization with LinkedIn Sales Navigator error message")

**Answer**

The error is from the LinkedIn Sales Navigator application. Contact the [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue.

<a name="unable-log-in-to-linkedin-control"> </a>
**Why am I unable to sign in to LinkedIn control in Safari browser?**

**Answer**
Dynamics 365 doesn't own the sign-in of users in to Display Widget. Contact the [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue.

<a name="incorrect-owner-name-displayed"> </a>
**Why an incorrect name is displayed under the owner of the record instead of my name when I create contact in LinkedIn Sales Navigator?**

**Answer**

Dynamics 365 doesn't own the process of contact creation in LinkedIn Sales Navigator. Contact the [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue. 


<a name="unable-enable-crm-sync-for-seat"> </a>
**Why I couldn't enable CRM sync for a seat in LinkedIn Sales Navigator?**

**Answer**

The issue might have occurred due to the mismatch of user's email in Dynamics 365 and LinkedIn Sales Navigator. To resolve the issue, follow the steps described in [How Do I Enable CRM Sync if a User's Email is Mismatched?](https://www.linkedin.com/help/sales-navigator/answer/a162746)

If the issue still persists, contact the [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue.

<a name="unable-writeback-inmails"> </a>
**Why am I unable to write back inMails and messages from LinkedIn Sales Navigator to Dynamics 365 and the Copy message to CRM option is disabled.**

> [!div class="mx-imgBorder"]  
> ![Copy message to CRM option disabled](media/faq-unable-writeback-inmails-messages-error.png "Copy message to CRM option disabled")

**Answer**

The issue has occurred due to the insufficient permissions in your user account to write back to Dynamics 365 from LinkedIn Sales Navigator. Contact the [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue.

### See also

[Troubleshooting LinkedIn integration errors](ts-linkedin-integration.md)