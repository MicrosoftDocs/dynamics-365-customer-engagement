---
title: "Recover from failed form submissions (Dynamics 365 for Marketing) | Microsoft Docs "
description: "Learn how to view and recover from failed form submissions in Dynamics 365 for Marketing"
ms.date: 08/01/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: ca23244e-25d5-4ddf-afe2-20d63ff318a2
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

# Early access: View and recover from failed form submissions

[!INCLUDE [cc-marketing-early-access-2019w2](../includes/cc-marketing-early-access-2019w2.md)]

Marketing forms must be designed to submit values for all mandatory fields and fields used in contact matching, lead matching, and duplicate detection. For option set fields, forms must also provide valid index values that map correctly to available values in the database.

Every now and then, errors in form design or changes to system settings can cause form submissions to fail some or all of the time. When a submission fails, the system will store what it can of the erroneous submission so you can examine it later and possibly recover key information from it. This information can also help you learn how to correct your form designs and/or system settings to prevent failed submissions in the future.

<a name="why-fail"></a>

## Why submissions can fail

Submissions can fail for any of the following reasons:

- **Bad option set values**: Option set fields are usually presented as drop-down lists in forms. For each option presented by the drop-down list, the database stores both a display value (shown by the form) and an index value (an integer submitted and stored in the database, which maps the each index value to a display value). An error can occur if the form submits an index value that isn't available in the database. This might happen if the database has changed since the form was designed, or if the form design includes an error that allows bad values to be submitted.
- **Mismatch of option sets between leads and contacts**: You can create forms that update or create both a contact and/or a lead. In this case, each field value from the form should be stored by two records from two different entities. Because the fields for each entity are created and updated separately, it can happen that one entity is updated, but not the other. As a result, submissions may fail some or all of the time when option set values don't match.
- **Missing required fields for matching strategies**: Matching strategies enable the system to match incoming form submissions to existing records. When a match is found, the system will typically update the existing record rather than create a new one. Each matching strategy establishes a set of fields to use when matching, and only identifies a match when all fields named by the matching strategy have matching values in both an existing record and the incoming submission. However, if the form doesn't include values for all of the matching-strategy fields, then the submission will fail. In this case, you either need to change the matching strategy or change the form to include all matching-strategy fields as required fields for the form. Remember that your contacts and leads may be using different matching strategies, so forms that affect both of these entities must also meet matching-strategy requirements for both entities too. More information: [Set matching strategies](marketing-settings.md#set-matching-strategies)
- **Incompatible customizations on the contact or lead entities**: Sometimes, customizations applied to the contact and/or lead entities will interfere with form submissions. For example, you may have a custom business process flow that has made a field mandatory, but that field is missing or not mandatory on your form. Custom plug-ins that affect contact or lead creation can also prevent new records from being created for these entities in response to form submissions.

## Find and inspect failed submissions

To find failed submissions for any form:

1. Go to **Marketing** > **Internet marketing** > **Marketing forms** to open a list of existing forms.
1. Find and open the form you want to inspect.
1. Go to the **Failed submissions** tab. If any failed submissions have been received, you'll see them listed here.

    ![List of failed form submissions](media/form-failed-submission.png "List of failed form submissions")

1. To inspect a failed submission, select and open it from this list (for example, with double-click). A new page opens showing details of the submission, including a failure description, technical details, and a list of values submitted.

    ![Failed submission details](media/form-failed-submission-details.png "Failed submission details")

1. Do the following:

    - Inspect the information provided in the **Failure Description** and **Failure Technical Details** fields to troubleshoot your form issues. You may discover how to adjust your form and/or system settings to prevent future submission failures. See [Why submissions can fail](#why-fail) for more information about what can go wrong and how to fix it.
    - Inspect the **Values** table to see what was submitted. You may be able to create a usable form submission based on these values by resubmitting the form yourself.

### See also

[Create, view, and manage marketing forms](marketing-forms.md)  
