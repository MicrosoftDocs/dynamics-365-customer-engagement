---
title: Search control for subject (Dynamics 365 Customer Service)
description: Learn how to enable the search option for the subject entity in custom forms in Dynamics 365 Customer Service.
ms.date: 05/31/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
  - bap-template
---

# Enable search control for subjects in custom forms

The search control for the subject entity provides intuitive and fast search results, the search term is highlighted in the results, and allows for easy removal of the search string with a single click.

The search control for the subject entity is available out of the box in the following forms:

- Case for Multisession experience
- Case for Interactive experience
- Case Quick Create for Multisession
- Case Quick Create

## Enable the search control for subjects

Perform the following steps to enable the search control for subjects on custom forms:

> [!IMPORTANT]
> The search control provides optimal performance for subject hierarchies with less than 2,000 subjects.

1. In Dynamics 365, go to **Customizations** in **Advanced Settings**.

2. Select **Customize the System** to open the default solution.

3. Under **Components**, expand **Entities**, select **Case**, and then select **Forms**.

4. In the list of forms, open the form that you want to edit.

5. Select the **Subject** field in the form, and double-click it.

6. In **Field Properties**, select **Controls**, and then select **Add control**.

7. Add **Selection TreeView Control**, and then enable the option for **Web**.

   > [!Note]
   > The search control for the Subject field is not supported on phones and tablets.

8. Save and publish your changes.

At runtime, your agents can search for values for a case in the **Subject** field.

### See also

[Create and manage subjects](create-manage-subject-tree.md)  
[Overview of case management](overview-cases.md)  
