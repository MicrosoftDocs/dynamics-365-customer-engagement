---
title: FAQ about case management
description: Learn about the frequently asked questions (FAQ) on the different features in case management.
ms.date: 04/18/2023
ms.topic: concept
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
---

# FAQs and known issues about case management

A few answers to common questions about the case management are listed here.

## An error occurs when agents try to resolve a case. What should I do?

Agents see the following error when they select **Resolve Case**:

'Could not load type "Microsoft.crm.cdshttpContext" from assembly "Microsoft.Xrm.Kernal.Contacts.Internal.Version=9.0.0.0, Culture=neutral'

This error occurs because Dataverse search isn't configured. Make sure that the Dataverse search is configured in your environment. More information: [Configure Dataverse search for your environment](/power-platform/admin/configure-relevance-search-organization).

## I can't search by any other column apart from Subject in the Case view.

 You need to make sure that the quick find search is configured for the required search parameters. More information: [Use quick find search](/power-platform/admin/configure-relevance-search-organization#select-searchable-fields-and-filters-for-each-table).

## I can't see fields like Billable time, Remarks or Total time on the case resolution dialog box.

As part of April 2023 wave, agents see the minimal case resolution dialog instead of the legacy case resolution dialog. The minimal case resolution dialog displays the **Resolution Type** and **Resolution** only. You can disable the minimal case resolution dialog and switch to the legacy experience. More information: [Disable the minimal case resolution dialog](add-enhanced-case-management.md#disable-the-minimal-case-resolution-dialog). 

   > [!NOTE]
   > - You can revert to the legacy case resolution dialog only if the **Case settings** > **Other settings** > **Resolve case dialog** is set to **Standard dialog** in Customer Service admin center.
   > - If **Resolve case dialog**  is set to **Customizable dialog** or **Quick create dialog**, to add **Duration**, **Billable TIme**, **Total Time** and other customizations, perform the steps in [Add or remove fields from the case resolution dialog](modify-case-resolution-dialog.md#add-or-remove-fields-from-the-case-resolution-dialog).
 
## I get errors when I try to access, create, or update a case. What should I do?

Agents see the following permission errors when they access, create, delete, or update a case:

Principal user (Id= \<GUID>, type=8, roleCount=5, privilegeCount=465, accessMode=0), is missing `prvReadincident` privilege (Id=\<GUID>) on OTC=112 for entity 'incident'. context.Caller=\<GUID>

The role assigned to the user is missing security privileges. To resolve the error, ensure that role assigned to the user has read access to the case entity. More information, see: [Security roles and privileges](/power-platform/admin/security-roles-privileges)