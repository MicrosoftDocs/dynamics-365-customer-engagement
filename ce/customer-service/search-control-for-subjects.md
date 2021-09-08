---
title: Search control for subject (Dynamics 365 Customer Service) | MicrosoftDocs
description: Know how to enable the search option for the subject entity in custom forms in Dynamics 365 Customer Service
ms.date: 08/08/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
---

# Preview: Enable search control for subjects in custom forms

[!INCLUDE[cc-early-access](../includes/cc-early-access.md)]

## Introduction

The search control for the subject entity provides intuitive and fast search results, the search term is highlighted in the results, and allows for easy removal of the search string with a single click.

The search control for the subject entity is available out of the box in the following forms:

- Case for Multisession experience
- Case for Interactive experience
- Case Quick Create for Multisession
- Case Quick Create

## Enable the search control for subjects

Perform the following steps to enable the search control for subjects on custom forms:

1. In Dynamics 365, go to **Customizations** in **Advanced Settings**.
2. Select **Customize the System** to open the default solution.
3. Under **Components**, expand **Entities**, select **Case**, and then select **Forms**.
4. In the list of forms, open the form that you want to edit.
5. Select the **Subject** field in the form, and double-click it.
6. In **Field Properties**, select **Controls**, and then select **Add control**.
7. Add **Selection TreeView Control**, and then enable the option for **Web**.
   > [!Note]
   > The search control for Subject field is not supported on Phone and Tablet.
8. Save and publish your changes.

At runtime, your agents can search for values in the Subject field for a case.

> [!Important]
> The search control provides optimal performance for subject hierarchies with less than 2,000 subjects.

### See also

[Create and manage subjects](create-manage-subject-tree.md)  
[Overview of case management](overview-cases.md)  