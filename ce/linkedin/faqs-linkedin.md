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
<!--note from editor: You can't have just one H2, you have to have at least one other heading to contrast with "General." Please add one or more H2s throughout the article, or delete this one. This whole article should probably be reorganized, since it has grown organically and the order of the issues seems a bit random.
## General  
-->
<a name="unable-sync-d365-org-under-admin-tab-linkedin"> </a>
**Why am I unable to sync a Dynamics 365 organization with LinkedIn Sales Navigator on the Admin tab? I get an error message saying that the start of the sync has failed.**<!--You can't make that second clause part of the question. Don't worry that it doesn't end with a question mark - there's plenty of precedent for having a mix of questions and statements in an FAQ article.-->

> [!div class="mx-imgBorder"]  
> ![Unable to sync a Dynamics 365 organization with LinkedIn Sales Navigator error message](media/faq-unable-sync-d365-lsn-error.png "Unable to sync Dynamics 365 organization with LinkedIn Sales Navigator error message")
<!--Once you create more H2s to organize these questions, I think you can remove these "Answer:" strings. The addition of headings will help the questions look more unified, and you won't need to add vertical space this way. (There's precedence for not having an "Answer:" heading also.)-->
**Answer:**

The error is from the LinkedIn Sales Navigator application. Contact [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue.

<a name="unable-log-in-to-linkedin-control"> </a>
**Why am I unable to sign in to LinkedIn<!--Edit okay? I don't know what signing in to a control means.--> with Safari?**

**Answer:**

Dynamics 365 doesn't own the sign-in of users from the display widget. Contact the [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue.

<a name="incorrect-owner-name-displayed"> </a>
**Why is an incorrect name displayed as the owner of the record instead of my name when I create contact in LinkedIn Sales Navigator?**

**Answer:**

Dynamics 365 doesn't own the process of contact creation in LinkedIn Sales Navigator. Contact [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue. 


<a name="unable-enable-crm-sync-for-seat"> </a>
**Why can't I enable CRM sync for a seat in LinkedIn Sales Navigator?**<!--Via Writing Style Guide, use "could" only to refer to the past.-->

**Answer:**

The issue might occur due to the mismatch of the user's email in Dynamics 365 and LinkedIn Sales Navigator. To resolve the issue, follow the steps described in [How Do I Enable CRM Sync if a User's Email is Mismatched?](https://www.linkedin.com/help/sales-navigator/answer/a162746).

If the issue persists, contact [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support.

<a name="unable-writeback-inmails"> </a>
**Why am I unable to write back inMails and messages from LinkedIn Sales Navigator to Dynamics 365? The Copy message to CRM option is unavailable.**

> [!div class="mx-imgBorder"]  
> ![Copy message to CRM option unavailable](media/faq-unable-writeback-inmails-messages-error.png "Copy message to CRM option unavailable")

**Answer:**

The issue has occurred due to the insufficient permissions in your user account to write back to Dynamics 365 from LinkedIn Sales Navigator. Contact [LinkedIn Sales Navigator](https://www.linkedin.com/help/sales-navigator/answer/a107028) support to resolve the issue.

### See also

[Troubleshooting LinkedIn integration errors](ts-linkedin-integration.md)
